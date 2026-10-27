using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000585 RID: 1413
	public class ConfigMotorFightAttrShowAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600212B RID: 8491 RVA: 0x00114FF7 File Offset: 0x001131F7
		static ConfigMotorFightAttrShowAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightAttrShowAll.CreateStaticDefaultValue), new Action(ConfigMotorFightAttrShowAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00115018 File Offset: 0x00113218
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightAttrShowAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightAttrShowAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightAttrShow"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightAttrShow`")
			});
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00115097 File Offset: 0x00113297
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightAttrShowAll.LogPair = null;
			ConfigMotorFightAttrShowAll.HandleId = 0;
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x001150A5 File Offset: 0x001132A5
		public static void Init()
		{
			ConfigMotorFightAttrShowAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightAttrShowAll.HandleId, "db_motorfight.db", "select BinData from `MotorFightAttrShow`");
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x001150C0 File Offset: 0x001132C0
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightAttrShow> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightAttrShowAll.HandleId, ConfigMotorFightAttrShowAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorFightAttrShow> readOnlyList = (IReadOnlyList<MotorFightAttrShow>)ConfigCommon.GetConfig("MotorFightAttrShowAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorFightAttrShow> list = new List<MotorFightAttrShow>();
			while (ConfigCommon.Step(ConfigMotorFightAttrShowAll.HandleId, false, ConfigMotorFightAttrShowAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightAttrShowAll.HandleId, 0, ConfigMotorFightAttrShowAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightAttrShowAll.HandleId, ConfigMotorFightAttrShowAll.LogPair);
					return null;
				}
				MotorFightAttrShow rootAsMotorFightAttrShow = MotorFightAttrShow.GetRootAsMotorFightAttrShow(new ByteBuffer(item2));
				list.Add(rootAsMotorFightAttrShow);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorFightAttrShowAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightAttrShowAll.HandleId, ConfigMotorFightAttrShowAll.LogPair);
			return list;
		}

		// Token: 0x04002687 RID: 9863
		private const string DB = "db_motorfight.db";

		// Token: 0x04002688 RID: 9864
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002689 RID: 9865
		private const string TABLE = "MotorFightAttrShow";

		// Token: 0x0400268A RID: 9866
		private const string COMMAND = "select BinData from `MotorFightAttrShow`";

		// Token: 0x0400268B RID: 9867
		private const string KEY_PREFIX = "MotorFightAttrShowAll";

		// Token: 0x0400268C RID: 9868
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400268D RID: 9869
		private static int HandleId;
	}
}
