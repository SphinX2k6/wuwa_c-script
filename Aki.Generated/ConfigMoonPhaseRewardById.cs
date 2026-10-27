using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000560 RID: 1376
	public class ConfigMoonPhaseRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600204D RID: 8269 RVA: 0x0011002C File Offset: 0x0010E22C
		static ConfigMoonPhaseRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoonPhaseRewardById.CreateStaticDefaultValue), new Action(ConfigMoonPhaseRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0011004C File Offset: 0x0010E24C
		public static void CreateStaticDefaultValue()
		{
			ConfigMoonPhaseRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoonPhaseRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonsignin.db"),
				new ValueTuple<string, object>("文件", "y.月相活动.xlsx"),
				new ValueTuple<string, object>("表名", "MoonPhaseReward"),
				new ValueTuple<string, object>("语句", "select BinData from `MoonPhaseReward` where Id=?")
			});
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x001100CB File Offset: 0x0010E2CB
		public static void ResetStaticDefaultValue()
		{
			ConfigMoonPhaseRewardById.LogPair = null;
			ConfigMoonPhaseRewardById.HandleId = 0;
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x001100D9 File Offset: 0x0010E2D9
		public static void Init()
		{
			ConfigMoonPhaseRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigMoonPhaseRewardById.HandleId, "db_moonsignin.db", "select BinData from `MoonPhaseReward` where Id=?");
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x001100F4 File Offset: 0x0010E2F4
		public static MoonPhaseReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoonPhaseRewardById.HandleId, ConfigMoonPhaseRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonPhaseRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoonPhaseReward?(MoonPhaseReward.GetRootAsMoonPhaseReward(configBuffer));
				}
			}
			ConfigMoonPhaseRewardById.LogPair.Clear();
			ConfigMoonPhaseRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMoonPhaseRewardById.HandleId, 1, p0Id, ConfigMoonPhaseRewardById.LogPair) || ConfigCommon.Step(ConfigMoonPhaseRewardById.HandleId, true, ConfigMoonPhaseRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoonPhaseRewardById.HandleId, ConfigMoonPhaseRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoonPhaseRewardById.HandleId, 0, ConfigMoonPhaseRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoonPhaseRewardById.HandleId, ConfigMoonPhaseRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoonPhaseReward rootAsMoonPhaseReward = MoonPhaseReward.GetRootAsMoonPhaseReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonPhaseRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoonPhaseRewardById.HandleId, ConfigMoonPhaseRewardById.LogPair);
			return new MoonPhaseReward?(rootAsMoonPhaseReward);
		}

		// Token: 0x04002584 RID: 9604
		private const string DB = "db_moonsignin.db";

		// Token: 0x04002585 RID: 9605
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x04002586 RID: 9606
		private const string TABLE = "MoonPhaseReward";

		// Token: 0x04002587 RID: 9607
		private const string COMMAND = "select BinData from `MoonPhaseReward` where Id=?";

		// Token: 0x04002588 RID: 9608
		private const string KEY_PREFIX = "MoonPhaseRewardById";

		// Token: 0x04002589 RID: 9609
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400258A RID: 9610
		private static int HandleId;
	}
}
