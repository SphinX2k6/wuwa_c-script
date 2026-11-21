using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D9 RID: 729
	public class ConfigFightPhotoTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600111B RID: 4379 RVA: 0x000BDB0C File Offset: 0x000BBD0C
		static ConfigFightPhotoTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFightPhotoTabAll.CreateStaticDefaultValue), new Action(ConfigFightPhotoTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000BDB2C File Offset: 0x000BBD2C
		public static void CreateStaticDefaultValue()
		{
			ConfigFightPhotoTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFightPhotoTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotooption.db"),
				new ValueTuple<string, object>("文件", "z.战斗拍照模板.xlsx"),
				new ValueTuple<string, object>("表名", "FightPhotoTab"),
				new ValueTuple<string, object>("语句", "select BinData from `FightPhotoTab`")
			});
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000BDBAB File Offset: 0x000BBDAB
		public static void ResetStaticDefaultValue()
		{
			ConfigFightPhotoTabAll.LogPair = null;
			ConfigFightPhotoTabAll.HandleId = 0;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x000BDBB9 File Offset: 0x000BBDB9
		public static void Init()
		{
			ConfigFightPhotoTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigFightPhotoTabAll.HandleId, "db_fightphotooption.db", "select BinData from `FightPhotoTab`");
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x000BDBD4 File Offset: 0x000BBDD4
		[NullableContext(2)]
		public static IReadOnlyList<FightPhotoTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFightPhotoTabAll.HandleId, ConfigFightPhotoTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FightPhotoTab> readOnlyList = (IReadOnlyList<FightPhotoTab>)ConfigCommon.GetConfig("FightPhotoTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FightPhotoTab> list = new List<FightPhotoTab>();
			while (ConfigCommon.Step(ConfigFightPhotoTabAll.HandleId, false, ConfigFightPhotoTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFightPhotoTabAll.HandleId, 0, ConfigFightPhotoTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFightPhotoTabAll.HandleId, ConfigFightPhotoTabAll.LogPair);
					return null;
				}
				FightPhotoTab rootAsFightPhotoTab = FightPhotoTab.GetRootAsFightPhotoTab(new ByteBuffer(item2));
				list.Add(rootAsFightPhotoTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FightPhotoTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFightPhotoTabAll.HandleId, ConfigFightPhotoTabAll.LogPair);
			return list;
		}

		// Token: 0x040013D3 RID: 5075
		private const string DB = "db_fightphotooption.db";

		// Token: 0x040013D4 RID: 5076
		private const string FILE = "z.战斗拍照模板.xlsx";

		// Token: 0x040013D5 RID: 5077
		private const string TABLE = "FightPhotoTab";

		// Token: 0x040013D6 RID: 5078
		private const string COMMAND = "select BinData from `FightPhotoTab`";

		// Token: 0x040013D7 RID: 5079
		private const string KEY_PREFIX = "FightPhotoTabAll";

		// Token: 0x040013D8 RID: 5080
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013D9 RID: 5081
		private static int HandleId;
	}
}
