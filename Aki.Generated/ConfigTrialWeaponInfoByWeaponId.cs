using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2D RID: 2861
	public class ConfigTrialWeaponInfoByWeaponId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004322 RID: 17186 RVA: 0x001D88D8 File Offset: 0x001D6AD8
		static ConfigTrialWeaponInfoByWeaponId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialWeaponInfoByWeaponId.CreateStaticDefaultValue), new Action(ConfigTrialWeaponInfoByWeaponId.ResetStaticDefaultValue));
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x001D88F8 File Offset: 0x001D6AF8
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

		// Token: 0x06004324 RID: 17188 RVA: 0x001D8977 File Offset: 0x001D6B77
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialWeaponInfoByWeaponId.LogPair = null;
			ConfigTrialWeaponInfoByWeaponId.HandleId = 0;
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x001D8985 File Offset: 0x001D6B85
		public static void Init()
		{
			ConfigTrialWeaponInfoByWeaponId.HandleId = ConfigCommon.InitDataStatement(ConfigTrialWeaponInfoByWeaponId.HandleId, "db_trial_role.db", "select BinData from `TrialWeaponInfo` where WeaponId = ?");
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x001D89A0 File Offset: 0x001D6BA0
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

		// Token: 0x04004E21 RID: 20001
		private const string DB = "db_trial_role.db";

		// Token: 0x04004E22 RID: 20002
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004E23 RID: 20003
		private const string TABLE = "TrialWeaponInfo";

		// Token: 0x04004E24 RID: 20004
		private const string COMMAND = "select BinData from `TrialWeaponInfo` where WeaponId = ?";

		// Token: 0x04004E25 RID: 20005
		private const string KEY_PREFIX = "TrialWeaponInfoByWeaponId";

		// Token: 0x04004E26 RID: 20006
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E27 RID: 20007
		private static int HandleId;
	}
}
