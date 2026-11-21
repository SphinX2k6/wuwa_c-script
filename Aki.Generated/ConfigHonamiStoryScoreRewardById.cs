using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041F RID: 1055
	public class ConfigHonamiStoryScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018C1 RID: 6337 RVA: 0x000E9467 File Offset: 0x000E7667
		static ConfigHonamiStoryScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryScoreRewardById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x000E9488 File Offset: 0x000E7688
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波物语活动奖励.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryScoreReward` where Id=?")
			});
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x000E9507 File Offset: 0x000E7707
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryScoreRewardById.LogPair = null;
			ConfigHonamiStoryScoreRewardById.HandleId = 0;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000E9515 File Offset: 0x000E7715
		public static void Init()
		{
			ConfigHonamiStoryScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryScoreRewardById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryScoreReward` where Id=?");
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000E9530 File Offset: 0x000E7730
		public static HonamiStoryScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryScoreRewardById.HandleId, ConfigHonamiStoryScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryScoreReward?(HonamiStoryScoreReward.GetRootAsHonamiStoryScoreReward(configBuffer));
				}
			}
			ConfigHonamiStoryScoreRewardById.LogPair.Clear();
			ConfigHonamiStoryScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryScoreRewardById.HandleId, 1, p0Id, ConfigHonamiStoryScoreRewardById.LogPair) || ConfigCommon.Step(ConfigHonamiStoryScoreRewardById.HandleId, true, ConfigHonamiStoryScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryScoreRewardById.HandleId, ConfigHonamiStoryScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryScoreRewardById.HandleId, 0, ConfigHonamiStoryScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryScoreRewardById.HandleId, ConfigHonamiStoryScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryScoreReward rootAsHonamiStoryScoreReward = HonamiStoryScoreReward.GetRootAsHonamiStoryScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryScoreRewardById.HandleId, ConfigHonamiStoryScoreRewardById.LogPair);
			return new HonamiStoryScoreReward?(rootAsHonamiStoryScoreReward);
		}

		// Token: 0x04001CBD RID: 7357
		private const string DB = "db_honamistory.db";

		// Token: 0x04001CBE RID: 7358
		private const string FILE = "s.穗波物语活动奖励.xlsx";

		// Token: 0x04001CBF RID: 7359
		private const string TABLE = "HonamiStoryScoreReward";

		// Token: 0x04001CC0 RID: 7360
		private const string COMMAND = "select BinData from `HonamiStoryScoreReward` where Id=?";

		// Token: 0x04001CC1 RID: 7361
		private const string KEY_PREFIX = "HonamiStoryScoreRewardById";

		// Token: 0x04001CC2 RID: 7362
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CC3 RID: 7363
		private static int HandleId;
	}
}
