using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000621 RID: 1569
	public class ConfigNewTowerSeasonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024D6 RID: 9430 RVA: 0x0012D53F File Offset: 0x0012B73F
		static ConfigNewTowerSeasonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonAll.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonAll.ResetStaticDefaultValue));
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x0012D560 File Offset: 0x0012B760
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

		// Token: 0x060024D8 RID: 9432 RVA: 0x0012D5DF File Offset: 0x0012B7DF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonAll.LogPair = null;
			ConfigNewTowerSeasonAll.HandleId = 0;
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x0012D5ED File Offset: 0x0012B7ED
		public static void Init()
		{
			ConfigNewTowerSeasonAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonAll.HandleId, "db_newtower.db", "select BinData from `NewTowerSeason`");
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x0012D608 File Offset: 0x0012B808
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

		// Token: 0x04002ACD RID: 10957
		private const string DB = "db_newtower.db";

		// Token: 0x04002ACE RID: 10958
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002ACF RID: 10959
		private const string TABLE = "NewTowerSeason";

		// Token: 0x04002AD0 RID: 10960
		private const string COMMAND = "select BinData from `NewTowerSeason`";

		// Token: 0x04002AD1 RID: 10961
		private const string KEY_PREFIX = "NewTowerSeasonAll";

		// Token: 0x04002AD2 RID: 10962
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AD3 RID: 10963
		private static int HandleId;
	}
}
