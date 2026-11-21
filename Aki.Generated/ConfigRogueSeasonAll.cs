using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000880 RID: 2176
	public class ConfigRogueSeasonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003312 RID: 13074 RVA: 0x0017DB20 File Offset: 0x0017BD20
		static ConfigRogueSeasonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueSeasonAll.CreateStaticDefaultValue), new Action(ConfigRogueSeasonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x0017DB40 File Offset: 0x0017BD40
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueSeasonAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueSeasonAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueSeason`")
			});
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0017DBBF File Offset: 0x0017BDBF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueSeasonAll.LogPair = null;
			ConfigRogueSeasonAll.HandleId = 0;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x0017DBCD File Offset: 0x0017BDCD
		public static void Init()
		{
			ConfigRogueSeasonAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueSeasonAll.HandleId, "db_rogue.db", "select BinData from `RogueSeason`");
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x0017DBE8 File Offset: 0x0017BDE8
		[NullableContext(2)]
		public static IReadOnlyList<RogueSeason> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueSeasonAll.HandleId, ConfigRogueSeasonAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueSeason> readOnlyList = (IReadOnlyList<RogueSeason>)ConfigCommon.GetConfig("RogueSeasonAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueSeason> list = new List<RogueSeason>();
			while (ConfigCommon.Step(ConfigRogueSeasonAll.HandleId, false, ConfigRogueSeasonAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueSeasonAll.HandleId, 0, ConfigRogueSeasonAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueSeasonAll.HandleId, ConfigRogueSeasonAll.LogPair);
					return null;
				}
				RogueSeason rootAsRogueSeason = RogueSeason.GetRootAsRogueSeason(new ByteBuffer(item2));
				list.Add(rootAsRogueSeason);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueSeasonAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueSeasonAll.HandleId, ConfigRogueSeasonAll.LogPair);
			return list;
		}

		// Token: 0x04003B66 RID: 15206
		private const string DB = "db_rogue.db";

		// Token: 0x04003B67 RID: 15207
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B68 RID: 15208
		private const string TABLE = "RogueSeason";

		// Token: 0x04003B69 RID: 15209
		private const string COMMAND = "select BinData from `RogueSeason`";

		// Token: 0x04003B6A RID: 15210
		private const string KEY_PREFIX = "RogueSeasonAll";

		// Token: 0x04003B6B RID: 15211
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B6C RID: 15212
		private static int HandleId;
	}
}
