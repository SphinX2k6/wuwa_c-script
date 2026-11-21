using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7D RID: 2685
	public class ConfigSurvivorsScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F02 RID: 16130 RVA: 0x001C103B File Offset: 0x001BF23B
		static ConfigSurvivorsScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsScoreRewardById.CreateStaticDefaultValue), new Action(ConfigSurvivorsScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x001C105C File Offset: 0x001BF25C
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_活动.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsScoreReward` where Id=?")
			});
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x001C10DB File Offset: 0x001BF2DB
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsScoreRewardById.LogPair = null;
			ConfigSurvivorsScoreRewardById.HandleId = 0;
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x001C10E9 File Offset: 0x001BF2E9
		public static void Init()
		{
			ConfigSurvivorsScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsScoreRewardById.HandleId, "db_survivors.db", "select BinData from `SurvivorsScoreReward` where Id=?");
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x001C1104 File Offset: 0x001BF304
		public static SurvivorsScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsScoreRewardById.HandleId, ConfigSurvivorsScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsScoreReward?(SurvivorsScoreReward.GetRootAsSurvivorsScoreReward(configBuffer));
				}
			}
			ConfigSurvivorsScoreRewardById.LogPair.Clear();
			ConfigSurvivorsScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsScoreRewardById.HandleId, 1, p0Id, ConfigSurvivorsScoreRewardById.LogPair) || ConfigCommon.Step(ConfigSurvivorsScoreRewardById.HandleId, true, ConfigSurvivorsScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsScoreRewardById.HandleId, ConfigSurvivorsScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsScoreRewardById.HandleId, 0, ConfigSurvivorsScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsScoreRewardById.HandleId, ConfigSurvivorsScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsScoreReward rootAsSurvivorsScoreReward = SurvivorsScoreReward.GetRootAsSurvivorsScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsScoreRewardById.HandleId, ConfigSurvivorsScoreRewardById.LogPair);
			return new SurvivorsScoreReward?(rootAsSurvivorsScoreReward);
		}

		// Token: 0x04004951 RID: 18769
		private const string DB = "db_survivors.db";

		// Token: 0x04004952 RID: 18770
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x04004953 RID: 18771
		private const string TABLE = "SurvivorsScoreReward";

		// Token: 0x04004954 RID: 18772
		private const string COMMAND = "select BinData from `SurvivorsScoreReward` where Id=?";

		// Token: 0x04004955 RID: 18773
		private const string KEY_PREFIX = "SurvivorsScoreRewardById";

		// Token: 0x04004956 RID: 18774
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004957 RID: 18775
		private static int HandleId;
	}
}
