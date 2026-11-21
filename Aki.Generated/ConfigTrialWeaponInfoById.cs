using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2C RID: 2860
	public class ConfigTrialWeaponInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600431C RID: 17180 RVA: 0x001D868F File Offset: 0x001D688F
		static ConfigTrialWeaponInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialWeaponInfoById.CreateStaticDefaultValue), new Action(ConfigTrialWeaponInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x001D86B0 File Offset: 0x001D68B0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrialWeaponInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrialWeaponInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trial_role.db"),
				new ValueTuple<string, object>("文件", "s.试用角色.xlsx"),
				new ValueTuple<string, object>("表名", "TrialWeaponInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TrialWeaponInfo` where Id = ?")
			});
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x001D872F File Offset: 0x001D692F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialWeaponInfoById.LogPair = null;
			ConfigTrialWeaponInfoById.HandleId = 0;
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x001D873D File Offset: 0x001D693D
		public static void Init()
		{
			ConfigTrialWeaponInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigTrialWeaponInfoById.HandleId, "db_trial_role.db", "select BinData from `TrialWeaponInfo` where Id = ?");
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x001D8758 File Offset: 0x001D6958
		public static TrialWeaponInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrialWeaponInfoById.HandleId, ConfigTrialWeaponInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialWeaponInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrialWeaponInfo?(TrialWeaponInfo.GetRootAsTrialWeaponInfo(configBuffer));
				}
			}
			ConfigTrialWeaponInfoById.LogPair.Clear();
			ConfigTrialWeaponInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrialWeaponInfoById.HandleId, 1, p0Id, ConfigTrialWeaponInfoById.LogPair) || ConfigCommon.Step(ConfigTrialWeaponInfoById.HandleId, true, ConfigTrialWeaponInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrialWeaponInfoById.HandleId, ConfigTrialWeaponInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrialWeaponInfoById.HandleId, 0, ConfigTrialWeaponInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrialWeaponInfoById.HandleId, ConfigTrialWeaponInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrialWeaponInfo rootAsTrialWeaponInfo = TrialWeaponInfo.GetRootAsTrialWeaponInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialWeaponInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrialWeaponInfoById.HandleId, ConfigTrialWeaponInfoById.LogPair);
			return new TrialWeaponInfo?(rootAsTrialWeaponInfo);
		}

		// Token: 0x04004E1A RID: 19994
		private const string DB = "db_trial_role.db";

		// Token: 0x04004E1B RID: 19995
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004E1C RID: 19996
		private const string TABLE = "TrialWeaponInfo";

		// Token: 0x04004E1D RID: 19997
		private const string COMMAND = "select BinData from `TrialWeaponInfo` where Id = ?";

		// Token: 0x04004E1E RID: 19998
		private const string KEY_PREFIX = "TrialWeaponInfoById";

		// Token: 0x04004E1F RID: 19999
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E20 RID: 20000
		private static int HandleId;
	}
}
