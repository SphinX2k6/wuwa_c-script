using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FF RID: 2303
	public class ConfigRoleTowerRewardByTabId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600360D RID: 13837 RVA: 0x0018E3CC File Offset: 0x0018C5CC
		static ConfigRoleTowerRewardByTabId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRewardByTabId.CreateStaticDefaultValue), new Action(ConfigRoleTowerRewardByTabId.ResetStaticDefaultValue));
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x0018E3EC File Offset: 0x0018C5EC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRewardByTabId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRewardByTabId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerReward` where TabId=?")
			});
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x0018E46B File Offset: 0x0018C66B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRewardByTabId.LogPair = null;
			ConfigRoleTowerRewardByTabId.HandleId = 0;
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x0018E479 File Offset: 0x0018C679
		public static void Init()
		{
			ConfigRoleTowerRewardByTabId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRewardByTabId.HandleId, "db_roletower.db", "select BinData from `RoleTowerReward` where TabId=?");
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x0018E494 File Offset: 0x0018C694
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerReward> GetConfigList(int p0TabId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRewardByTabId.HandleId, ConfigRoleTowerRewardByTabId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardByTabId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TabId);
				IReadOnlyList<RoleTowerReward> readOnlyList = (IReadOnlyList<RoleTowerReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerRewardByTabId.LogPair.Clear();
			ConfigRoleTowerRewardByTabId.LogPair.Add(new ValueTuple<string, object>("TabId", p0TabId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerRewardByTabId.HandleId, 1, p0TabId, ConfigRoleTowerRewardByTabId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerRewardByTabId.HandleId, ConfigRoleTowerRewardByTabId.LogPair);
				return null;
			}
			List<RoleTowerReward> list = new List<RoleTowerReward>();
			while (ConfigCommon.Step(ConfigRoleTowerRewardByTabId.HandleId, false, ConfigRoleTowerRewardByTabId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRewardByTabId.HandleId, 0, ConfigRoleTowerRewardByTabId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerRewardByTabId.HandleId, ConfigRoleTowerRewardByTabId.LogPair);
					return null;
				}
				RoleTowerReward rootAsRoleTowerReward = RoleTowerReward.GetRootAsRoleTowerReward(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardByTabId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TabId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerRewardByTabId.HandleId, ConfigRoleTowerRewardByTabId.LogPair);
			return list;
		}

		// Token: 0x04003EDF RID: 16095
		private const string DB = "db_roletower.db";

		// Token: 0x04003EE0 RID: 16096
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003EE1 RID: 16097
		private const string TABLE = "RoleTowerReward";

		// Token: 0x04003EE2 RID: 16098
		private const string COMMAND = "select BinData from `RoleTowerReward` where TabId=?";

		// Token: 0x04003EE3 RID: 16099
		private const string KEY_PREFIX = "RoleTowerRewardByTabId";

		// Token: 0x04003EE4 RID: 16100
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EE5 RID: 16101
		private static int HandleId;
	}
}
