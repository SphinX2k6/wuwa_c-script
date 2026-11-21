using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000172 RID: 370
	public class ConfigCiacconaActivityRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008AD RID: 2221 RVA: 0x0008E1CC File Offset: 0x0008C3CC
		static ConfigCiacconaActivityRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaActivityRewardAll.CreateStaticDefaultValue), new Action(ConfigCiacconaActivityRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0008E1EC File Offset: 0x0008C3EC
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaActivityRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaActivityRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaActivityReward"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaActivityReward`")
			});
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0008E26B File Offset: 0x0008C46B
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaActivityRewardAll.LogPair = null;
			ConfigCiacconaActivityRewardAll.HandleId = 0;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0008E279 File Offset: 0x0008C479
		public static void Init()
		{
			ConfigCiacconaActivityRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaActivityRewardAll.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaActivityReward`");
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0008E294 File Offset: 0x0008C494
		[NullableContext(2)]
		public static IReadOnlyList<CiacconaActivityReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaActivityRewardAll.HandleId, ConfigCiacconaActivityRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CiacconaActivityReward> readOnlyList = (IReadOnlyList<CiacconaActivityReward>)ConfigCommon.GetConfig("CiacconaActivityRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CiacconaActivityReward> list = new List<CiacconaActivityReward>();
			while (ConfigCommon.Step(ConfigCiacconaActivityRewardAll.HandleId, false, ConfigCiacconaActivityRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaActivityRewardAll.HandleId, 0, ConfigCiacconaActivityRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCiacconaActivityRewardAll.HandleId, ConfigCiacconaActivityRewardAll.LogPair);
					return null;
				}
				CiacconaActivityReward rootAsCiacconaActivityReward = CiacconaActivityReward.GetRootAsCiacconaActivityReward(new ByteBuffer(item2));
				list.Add(rootAsCiacconaActivityReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CiacconaActivityRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCiacconaActivityRewardAll.HandleId, ConfigCiacconaActivityRewardAll.LogPair);
			return list;
		}

		// Token: 0x04000A02 RID: 2562
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A03 RID: 2563
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A04 RID: 2564
		private const string TABLE = "CiacconaActivityReward";

		// Token: 0x04000A05 RID: 2565
		private const string COMMAND = "select BinData from `CiacconaActivityReward`";

		// Token: 0x04000A06 RID: 2566
		private const string KEY_PREFIX = "CiacconaActivityRewardAll";

		// Token: 0x04000A07 RID: 2567
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A08 RID: 2568
		private static int HandleId;
	}
}
