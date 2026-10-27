using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A58 RID: 2648
	public class ConfigTrialWeaponInfoByWeaponId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E24 RID: 15908 RVA: 0x001B9544 File Offset: 0x001B7744
		static ConfigTrialWeaponInfoByWeaponId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialWeaponInfoByWeaponId.CreateStaticDefaultValue), new Action(ConfigTrialWeaponInfoByWeaponId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x001B9564 File Offset: 0x001B7764
		public static void CreateStaticDefaultValue()
		{
			ConfigTrialWeaponInfoByWeaponId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrialWeaponInfoByWeaponId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trial_role.db"),
				new ValueTuple<string, object>("文件", "s.试用角色.xlsx"),
				new ValueTuple<string, object>("表名", "TrialWeaponInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TrialWeaponInfo` where WeaponId = ?")
			});
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x001B95E3 File Offset: 0x001B77E3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialWeaponInfoByWeaponId.LogPair = null;
			ConfigTrialWeaponInfoByWeaponId.HandleId = 0;
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x001B95F1 File Offset: 0x001B77F1
		public static void Init()
		{
			ConfigTrialWeaponInfoByWeaponId.HandleId = ConfigCommon.InitDataStatement(ConfigTrialWeaponInfoByWeaponId.HandleId, "db_trial_role.db", "select BinData from `TrialWeaponInfo` where WeaponId = ?");
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x001B960C File Offset: 0x001B780C
		[NullableContext(2)]
		public static IReadOnlyList<TrialWeaponInfo> GetConfigList(int p0WeaponId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrialWeaponInfoByWeaponId.HandleId, ConfigTrialWeaponInfoByWeaponId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialWeaponInfoByWeaponId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponId);
				IReadOnlyList<TrialWeaponInfo> readOnlyList = (IReadOnlyList<TrialWeaponInfo>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrialWeaponInfoByWeaponId.LogPair.Clear();
			ConfigTrialWeaponInfoByWeaponId.LogPair.Add(new ValueTuple<string, object>("WeaponId", p0WeaponId));
			if (!ConfigCommon.BindInt(ConfigTrialWeaponInfoByWeaponId.HandleId, 1, p0WeaponId, ConfigTrialWeaponInfoByWeaponId.LogPair))
			{
				ConfigCommon.Reset(ConfigTrialWeaponInfoByWeaponId.HandleId, ConfigTrialWeaponInfoByWeaponId.LogPair);
				return null;
			}
			List<TrialWeaponInfo> list = new List<TrialWeaponInfo>();
			while (ConfigCommon.Step(ConfigTrialWeaponInfoByWeaponId.HandleId, false, ConfigTrialWeaponInfoByWeaponId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrialWeaponInfoByWeaponId.HandleId, 0, ConfigTrialWeaponInfoByWeaponId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrialWeaponInfoByWeaponId.HandleId, ConfigTrialWeaponInfoByWeaponId.LogPair);
					return null;
				}
				TrialWeaponInfo rootAsTrialWeaponInfo = TrialWeaponInfo.GetRootAsTrialWeaponInfo(new ByteBuffer(item2));
				list.Add(rootAsTrialWeaponInfo);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialWeaponInfoByWeaponId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0WeaponId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrialWeaponInfoByWeaponId.HandleId, ConfigTrialWeaponInfoByWeaponId.LogPair);
			return list;
		}

		// Token: 0x0400484E RID: 18510
		private const string DB = "db_trial_role.db";

		// Token: 0x0400484F RID: 18511
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004850 RID: 18512
		private const string TABLE = "TrialWeaponInfo";

		// Token: 0x04004851 RID: 18513
		private const string COMMAND = "select BinData from `TrialWeaponInfo` where WeaponId = ?";

		// Token: 0x04004852 RID: 18514
		private const string KEY_PREFIX = "TrialWeaponInfoByWeaponId";

		// Token: 0x04004853 RID: 18515
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004854 RID: 18516
		private static int HandleId;
	}
}
