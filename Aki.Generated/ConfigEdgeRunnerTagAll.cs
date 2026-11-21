using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000263 RID: 611
	public class ConfigEdgeRunnerTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x000AE140 File Offset: 0x000AC340
		static ConfigEdgeRunnerTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTagAll.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000AE160 File Offset: 0x000AC360
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerTagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerTagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerTag"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerTag`")
			});
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000AE1DF File Offset: 0x000AC3DF
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTagAll.LogPair = null;
			ConfigEdgeRunnerTagAll.HandleId = 0;
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000AE1ED File Offset: 0x000AC3ED
		public static void Init()
		{
			ConfigEdgeRunnerTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTagAll.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTag`");
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000AE208 File Offset: 0x000AC408
		[NullableContext(2)]
		public static IReadOnlyList<EdgeRunnerTag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerTagAll.HandleId, ConfigEdgeRunnerTagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EdgeRunnerTag> readOnlyList = (IReadOnlyList<EdgeRunnerTag>)ConfigCommon.GetConfig("EdgeRunnerTagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EdgeRunnerTag> list = new List<EdgeRunnerTag>();
			while (ConfigCommon.Step(ConfigEdgeRunnerTagAll.HandleId, false, ConfigEdgeRunnerTagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerTagAll.HandleId, 0, ConfigEdgeRunnerTagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEdgeRunnerTagAll.HandleId, ConfigEdgeRunnerTagAll.LogPair);
					return null;
				}
				EdgeRunnerTag rootAsEdgeRunnerTag = EdgeRunnerTag.GetRootAsEdgeRunnerTag(new ByteBuffer(item2));
				list.Add(rootAsEdgeRunnerTag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EdgeRunnerTagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerTagAll.HandleId, ConfigEdgeRunnerTagAll.LogPair);
			return list;
		}

		// Token: 0x04001099 RID: 4249
		private const string DB = "db_edgerunner.db";

		// Token: 0x0400109A RID: 4250
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x0400109B RID: 4251
		private const string TABLE = "EdgeRunnerTag";

		// Token: 0x0400109C RID: 4252
		private const string COMMAND = "select BinData from `EdgeRunnerTag`";

		// Token: 0x0400109D RID: 4253
		private const string KEY_PREFIX = "EdgeRunnerTagAll";

		// Token: 0x0400109E RID: 4254
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400109F RID: 4255
		private static int HandleId;
	}
}
