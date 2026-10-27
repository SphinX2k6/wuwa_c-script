using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A57 RID: 2647
	public class ConfigTrialWeaponInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E1E RID: 15902 RVA: 0x001B92FB File Offset: 0x001B74FB
		static ConfigTrialWeaponInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialWeaponInfoById.CreateStaticDefaultValue), new Action(ConfigTrialWeaponInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x001B931C File Offset: 0x001B751C
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

		// Token: 0x06003E20 RID: 15904 RVA: 0x001B939B File Offset: 0x001B759B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialWeaponInfoById.LogPair = null;
			ConfigTrialWeaponInfoById.HandleId = 0;
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x001B93A9 File Offset: 0x001B75A9
		public static void Init()
		{
			ConfigTrialWeaponInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigTrialWeaponInfoById.HandleId, "db_trial_role.db", "select BinData from `TrialWeaponInfo` where Id = ?");
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x001B93C4 File Offset: 0x001B75C4
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

		// Token: 0x04004847 RID: 18503
		private const string DB = "db_trial_role.db";

		// Token: 0x04004848 RID: 18504
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004849 RID: 18505
		private const string TABLE = "TrialWeaponInfo";

		// Token: 0x0400484A RID: 18506
		private const string COMMAND = "select BinData from `TrialWeaponInfo` where Id = ?";

		// Token: 0x0400484B RID: 18507
		private const string KEY_PREFIX = "TrialWeaponInfoById";

		// Token: 0x0400484C RID: 18508
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400484D RID: 18509
		private static int HandleId;
	}
}
