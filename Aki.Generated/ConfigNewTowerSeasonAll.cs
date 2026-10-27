using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000609 RID: 1545
	public class ConfigNewTowerSeasonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002446 RID: 9286 RVA: 0x00126AC3 File Offset: 0x00124CC3
		static ConfigNewTowerSeasonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonAll.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00126AE4 File Offset: 0x00124CE4
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerSeasonAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerSeasonAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerSeason`")
			});
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00126B63 File Offset: 0x00124D63
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonAll.LogPair = null;
			ConfigNewTowerSeasonAll.HandleId = 0;
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00126B71 File Offset: 0x00124D71
		public static void Init()
		{
			ConfigNewTowerSeasonAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonAll.HandleId, "db_newtower.db", "select BinData from `NewTowerSeason`");
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00126B8C File Offset: 0x00124D8C
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerSeason> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerSeasonAll.HandleId, ConfigNewTowerSeasonAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewTowerSeason> readOnlyList = (IReadOnlyList<NewTowerSeason>)ConfigCommon.GetConfig("NewTowerSeasonAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewTowerSeason> list = new List<NewTowerSeason>();
			while (ConfigCommon.Step(ConfigNewTowerSeasonAll.HandleId, false, ConfigNewTowerSeasonAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerSeasonAll.HandleId, 0, ConfigNewTowerSeasonAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerSeasonAll.HandleId, ConfigNewTowerSeasonAll.LogPair);
					return null;
				}
				NewTowerSeason rootAsNewTowerSeason = NewTowerSeason.GetRootAsNewTowerSeason(new ByteBuffer(item2));
				list.Add(rootAsNewTowerSeason);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewTowerSeasonAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerSeasonAll.HandleId, ConfigNewTowerSeasonAll.LogPair);
			return list;
		}

		// Token: 0x04002A25 RID: 10789
		private const string DB = "db_newtower.db";

		// Token: 0x04002A26 RID: 10790
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A27 RID: 10791
		private const string TABLE = "NewTowerSeason";

		// Token: 0x04002A28 RID: 10792
		private const string COMMAND = "select BinData from `NewTowerSeason`";

		// Token: 0x04002A29 RID: 10793
		private const string KEY_PREFIX = "NewTowerSeasonAll";

		// Token: 0x04002A2A RID: 10794
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A2B RID: 10795
		private static int HandleId;
	}
}
