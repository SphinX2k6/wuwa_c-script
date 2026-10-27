using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000162 RID: 354
	public class ConfigCiacconaActivityRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600084D RID: 2125 RVA: 0x00088670 File Offset: 0x00086870
		static ConfigCiacconaActivityRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaActivityRewardAll.CreateStaticDefaultValue), new Action(ConfigCiacconaActivityRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00088690 File Offset: 0x00086890
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

		// Token: 0x0600084F RID: 2127 RVA: 0x0008870F File Offset: 0x0008690F
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaActivityRewardAll.LogPair = null;
			ConfigCiacconaActivityRewardAll.HandleId = 0;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0008871D File Offset: 0x0008691D
		public static void Init()
		{
			ConfigCiacconaActivityRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaActivityRewardAll.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaActivityReward`");
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00088738 File Offset: 0x00086938
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

		// Token: 0x04000992 RID: 2450
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000993 RID: 2451
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000994 RID: 2452
		private const string TABLE = "CiacconaActivityReward";

		// Token: 0x04000995 RID: 2453
		private const string COMMAND = "select BinData from `CiacconaActivityReward`";

		// Token: 0x04000996 RID: 2454
		private const string KEY_PREFIX = "CiacconaActivityRewardAll";

		// Token: 0x04000997 RID: 2455
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000998 RID: 2456
		private static int HandleId;
	}
}
