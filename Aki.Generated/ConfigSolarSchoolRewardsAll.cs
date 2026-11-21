using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A09 RID: 2569
	public class ConfigSolarSchoolRewardsAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C4A RID: 15434 RVA: 0x001B18FC File Offset: 0x001AFAFC
		static ConfigSolarSchoolRewardsAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRewardsAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRewardsAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x001B191C File Offset: 0x001AFB1C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRewardsAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRewardsAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRewards"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRewards`")
			});
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x001B199B File Offset: 0x001AFB9B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRewardsAll.LogPair = null;
			ConfigSolarSchoolRewardsAll.HandleId = 0;
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x001B19A9 File Offset: 0x001AFBA9
		public static void Init()
		{
			ConfigSolarSchoolRewardsAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRewardsAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRewards`");
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x001B19C4 File Offset: 0x001AFBC4
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRewards> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRewardsAll.HandleId, ConfigSolarSchoolRewardsAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolRewards> readOnlyList = (IReadOnlyList<SolarSchoolRewards>)ConfigCommon.GetConfig("SolarSchoolRewardsAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolRewards> list = new List<SolarSchoolRewards>();
			while (ConfigCommon.Step(ConfigSolarSchoolRewardsAll.HandleId, false, ConfigSolarSchoolRewardsAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRewardsAll.HandleId, 0, ConfigSolarSchoolRewardsAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRewardsAll.HandleId, ConfigSolarSchoolRewardsAll.LogPair);
					return null;
				}
				SolarSchoolRewards rootAsSolarSchoolRewards = SolarSchoolRewards.GetRootAsSolarSchoolRewards(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRewards);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolRewardsAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRewardsAll.HandleId, ConfigSolarSchoolRewardsAll.LogPair);
			return list;
		}

		// Token: 0x04004625 RID: 17957
		private const string DB = "db_solarschool.db";

		// Token: 0x04004626 RID: 17958
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x04004627 RID: 17959
		private const string TABLE = "SolarSchoolRewards";

		// Token: 0x04004628 RID: 17960
		private const string COMMAND = "select BinData from `SolarSchoolRewards`";

		// Token: 0x04004629 RID: 17961
		private const string KEY_PREFIX = "SolarSchoolRewardsAll";

		// Token: 0x0400462A RID: 17962
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400462B RID: 17963
		private static int HandleId;
	}
}
