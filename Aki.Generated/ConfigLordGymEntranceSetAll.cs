using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000510 RID: 1296
	public class ConfigLordGymEntranceSetAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E6B RID: 7787 RVA: 0x00108BEF File Offset: 0x00106DEF
		static ConfigLordGymEntranceSetAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceSetAll.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceSetAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00108C10 File Offset: 0x00106E10
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymEntranceSetAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymEntranceSetAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymEntranceSet"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymEntranceSet`")
			});
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00108C8F File Offset: 0x00106E8F
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceSetAll.LogPair = null;
			ConfigLordGymEntranceSetAll.HandleId = 0;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00108C9D File Offset: 0x00106E9D
		public static void Init()
		{
			ConfigLordGymEntranceSetAll.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceSetAll.HandleId, "db_lordgym.db", "select BinData from `LordGymEntranceSet`");
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00108CB8 File Offset: 0x00106EB8
		[NullableContext(2)]
		public static IReadOnlyList<LordGymEntranceSet> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymEntranceSetAll.HandleId, ConfigLordGymEntranceSetAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LordGymEntranceSet> readOnlyList = (IReadOnlyList<LordGymEntranceSet>)ConfigCommon.GetConfig("LordGymEntranceSetAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LordGymEntranceSet> list = new List<LordGymEntranceSet>();
			while (ConfigCommon.Step(ConfigLordGymEntranceSetAll.HandleId, false, ConfigLordGymEntranceSetAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymEntranceSetAll.HandleId, 0, ConfigLordGymEntranceSetAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLordGymEntranceSetAll.HandleId, ConfigLordGymEntranceSetAll.LogPair);
					return null;
				}
				LordGymEntranceSet rootAsLordGymEntranceSet = LordGymEntranceSet.GetRootAsLordGymEntranceSet(new ByteBuffer(item2));
				list.Add(rootAsLordGymEntranceSet);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LordGymEntranceSetAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLordGymEntranceSetAll.HandleId, ConfigLordGymEntranceSetAll.LogPair);
			return list;
		}

		// Token: 0x04002354 RID: 9044
		private const string DB = "db_lordgym.db";

		// Token: 0x04002355 RID: 9045
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x04002356 RID: 9046
		private const string TABLE = "LordGymEntranceSet";

		// Token: 0x04002357 RID: 9047
		private const string COMMAND = "select BinData from `LordGymEntranceSet`";

		// Token: 0x04002358 RID: 9048
		private const string KEY_PREFIX = "LordGymEntranceSetAll";

		// Token: 0x04002359 RID: 9049
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400235A RID: 9050
		private static int HandleId;
	}
}
