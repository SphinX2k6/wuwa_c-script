using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A07 RID: 2567
	public class ConfigSolarSchoolRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C3E RID: 15422 RVA: 0x001B1520 File Offset: 0x001AF720
		static ConfigSolarSchoolRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRewardAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x001B1540 File Offset: 0x001AF740
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_投放.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolReward`")
			});
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x001B15BF File Offset: 0x001AF7BF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRewardAll.LogPair = null;
			ConfigSolarSchoolRewardAll.HandleId = 0;
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x001B15CD File Offset: 0x001AF7CD
		public static void Init()
		{
			ConfigSolarSchoolRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRewardAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolReward`");
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x001B15E8 File Offset: 0x001AF7E8
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRewardAll.HandleId, ConfigSolarSchoolRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolReward> readOnlyList = (IReadOnlyList<SolarSchoolReward>)ConfigCommon.GetConfig("SolarSchoolRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolReward> list = new List<SolarSchoolReward>();
			while (ConfigCommon.Step(ConfigSolarSchoolRewardAll.HandleId, false, ConfigSolarSchoolRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRewardAll.HandleId, 0, ConfigSolarSchoolRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRewardAll.HandleId, ConfigSolarSchoolRewardAll.LogPair);
					return null;
				}
				SolarSchoolReward rootAsSolarSchoolReward = SolarSchoolReward.GetRootAsSolarSchoolReward(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRewardAll.HandleId, ConfigSolarSchoolRewardAll.LogPair);
			return list;
		}

		// Token: 0x04004617 RID: 17943
		private const string DB = "db_solarschool.db";

		// Token: 0x04004618 RID: 17944
		private const string FILE = "d.第二索拉_投放.xlsx";

		// Token: 0x04004619 RID: 17945
		private const string TABLE = "SolarSchoolReward";

		// Token: 0x0400461A RID: 17946
		private const string COMMAND = "select BinData from `SolarSchoolReward`";

		// Token: 0x0400461B RID: 17947
		private const string KEY_PREFIX = "SolarSchoolRewardAll";

		// Token: 0x0400461C RID: 17948
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400461D RID: 17949
		private static int HandleId;
	}
}
