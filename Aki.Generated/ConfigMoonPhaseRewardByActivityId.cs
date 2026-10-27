using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055F RID: 1375
	public class ConfigMoonPhaseRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002047 RID: 8263 RVA: 0x0010FDE4 File Offset: 0x0010DFE4
		static ConfigMoonPhaseRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoonPhaseRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigMoonPhaseRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0010FE04 File Offset: 0x0010E004
		public static void CreateStaticDefaultValue()
		{
			ConfigMoonPhaseRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoonPhaseRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonsignin.db"),
				new ValueTuple<string, object>("文件", "y.月相活动.xlsx"),
				new ValueTuple<string, object>("表名", "MoonPhaseReward"),
				new ValueTuple<string, object>("语句", "select BinData from `MoonPhaseReward` where ActivityId=?")
			});
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0010FE83 File Offset: 0x0010E083
		public static void ResetStaticDefaultValue()
		{
			ConfigMoonPhaseRewardByActivityId.LogPair = null;
			ConfigMoonPhaseRewardByActivityId.HandleId = 0;
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0010FE91 File Offset: 0x0010E091
		public static void Init()
		{
			ConfigMoonPhaseRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMoonPhaseRewardByActivityId.HandleId, "db_moonsignin.db", "select BinData from `MoonPhaseReward` where ActivityId=?");
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0010FEAC File Offset: 0x0010E0AC
		public static MoonPhaseReward? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoonPhaseRewardByActivityId.HandleId, ConfigMoonPhaseRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonPhaseRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoonPhaseReward?(MoonPhaseReward.GetRootAsMoonPhaseReward(configBuffer));
				}
			}
			ConfigMoonPhaseRewardByActivityId.LogPair.Clear();
			ConfigMoonPhaseRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMoonPhaseRewardByActivityId.HandleId, 1, p0ActivityId, ConfigMoonPhaseRewardByActivityId.LogPair) || ConfigCommon.Step(ConfigMoonPhaseRewardByActivityId.HandleId, true, ConfigMoonPhaseRewardByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoonPhaseRewardByActivityId.HandleId, ConfigMoonPhaseRewardByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoonPhaseRewardByActivityId.HandleId, 0, ConfigMoonPhaseRewardByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoonPhaseRewardByActivityId.HandleId, ConfigMoonPhaseRewardByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoonPhaseReward rootAsMoonPhaseReward = MoonPhaseReward.GetRootAsMoonPhaseReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonPhaseRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoonPhaseRewardByActivityId.HandleId, ConfigMoonPhaseRewardByActivityId.LogPair);
			return new MoonPhaseReward?(rootAsMoonPhaseReward);
		}

		// Token: 0x0400257D RID: 9597
		private const string DB = "db_moonsignin.db";

		// Token: 0x0400257E RID: 9598
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x0400257F RID: 9599
		private const string TABLE = "MoonPhaseReward";

		// Token: 0x04002580 RID: 9600
		private const string COMMAND = "select BinData from `MoonPhaseReward` where ActivityId=?";

		// Token: 0x04002581 RID: 9601
		private const string KEY_PREFIX = "MoonPhaseRewardByActivityId";

		// Token: 0x04002582 RID: 9602
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002583 RID: 9603
		private static int HandleId;
	}
}
