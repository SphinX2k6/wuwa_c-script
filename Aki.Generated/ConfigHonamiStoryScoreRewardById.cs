using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000409 RID: 1033
	public class ConfigHonamiStoryScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600183D RID: 6205 RVA: 0x000E2D13 File Offset: 0x000E0F13
		static ConfigHonamiStoryScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryScoreRewardById.CreateStaticDefaultValue), new Action(ConfigHonamiStoryScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000E2D34 File Offset: 0x000E0F34
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

		// Token: 0x0600183F RID: 6207 RVA: 0x000E2DB3 File Offset: 0x000E0FB3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryScoreRewardById.LogPair = null;
			ConfigHonamiStoryScoreRewardById.HandleId = 0;
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x000E2DC1 File Offset: 0x000E0FC1
		public static void Init()
		{
			ConfigHonamiStoryScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryScoreRewardById.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryScoreReward` where Id=?");
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x000E2DDC File Offset: 0x000E0FDC
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

		// Token: 0x04001C23 RID: 7203
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C24 RID: 7204
		private const string FILE = "s.穗波物语活动奖励.xlsx";

		// Token: 0x04001C25 RID: 7205
		private const string TABLE = "HonamiStoryScoreReward";

		// Token: 0x04001C26 RID: 7206
		private const string COMMAND = "select BinData from `HonamiStoryScoreReward` where Id=?";

		// Token: 0x04001C27 RID: 7207
		private const string KEY_PREFIX = "HonamiStoryScoreRewardById";

		// Token: 0x04001C28 RID: 7208
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C29 RID: 7209
		private static int HandleId;
	}
}
