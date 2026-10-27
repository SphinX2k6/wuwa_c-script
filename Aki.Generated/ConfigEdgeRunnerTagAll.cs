using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024F RID: 591
	public class ConfigEdgeRunnerTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x000A7E7C File Offset: 0x000A607C
		static ConfigEdgeRunnerTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTagAll.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x000A7E9C File Offset: 0x000A609C
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

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000A7F1B File Offset: 0x000A611B
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTagAll.LogPair = null;
			ConfigEdgeRunnerTagAll.HandleId = 0;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x000A7F29 File Offset: 0x000A6129
		public static void Init()
		{
			ConfigEdgeRunnerTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTagAll.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTag`");
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000A7F44 File Offset: 0x000A6144
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

		// Token: 0x0400100D RID: 4109
		private const string DB = "db_edgerunner.db";

		// Token: 0x0400100E RID: 4110
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x0400100F RID: 4111
		private const string TABLE = "EdgeRunnerTag";

		// Token: 0x04001010 RID: 4112
		private const string COMMAND = "select BinData from `EdgeRunnerTag`";

		// Token: 0x04001011 RID: 4113
		private const string KEY_PREFIX = "EdgeRunnerTagAll";

		// Token: 0x04001012 RID: 4114
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001013 RID: 4115
		private static int HandleId;
	}
}
