using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADF RID: 2783
	public class ConfigTrackMoonActivityRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600414E RID: 16718 RVA: 0x001CE0A3 File Offset: 0x001CC2A3
		static ConfigTrackMoonActivityRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonActivityRewardById.CreateStaticDefaultValue), new Action(ConfigTrackMoonActivityRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x001CE0C4 File Offset: 0x001CC2C4
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonActivityRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonActivityRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trackmoonactivity.db"),
				new ValueTuple<string, object>("文件", "z.追月节活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonActivityReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonActivityReward` where Id=?")
			});
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x001CE143 File Offset: 0x001CC343
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonActivityRewardById.LogPair = null;
			ConfigTrackMoonActivityRewardById.HandleId = 0;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x001CE151 File Offset: 0x001CC351
		public static void Init()
		{
			ConfigTrackMoonActivityRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonActivityRewardById.HandleId, "db_trackmoonactivity.db", "select BinData from `TrackMoonActivityReward` where Id=?");
		}

		// Token: 0x06004152 RID: 16722 RVA: 0x001CE16C File Offset: 0x001CC36C
		public static TrackMoonActivityReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonActivityRewardById.HandleId, ConfigTrackMoonActivityRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonActivityRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrackMoonActivityReward?(TrackMoonActivityReward.GetRootAsTrackMoonActivityReward(configBuffer));
				}
			}
			ConfigTrackMoonActivityRewardById.LogPair.Clear();
			ConfigTrackMoonActivityRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrackMoonActivityRewardById.HandleId, 1, p0Id, ConfigTrackMoonActivityRewardById.LogPair) || ConfigCommon.Step(ConfigTrackMoonActivityRewardById.HandleId, true, ConfigTrackMoonActivityRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrackMoonActivityRewardById.HandleId, ConfigTrackMoonActivityRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonActivityRewardById.HandleId, 0, ConfigTrackMoonActivityRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrackMoonActivityRewardById.HandleId, ConfigTrackMoonActivityRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrackMoonActivityReward rootAsTrackMoonActivityReward = TrackMoonActivityReward.GetRootAsTrackMoonActivityReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonActivityRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrackMoonActivityRewardById.HandleId, ConfigTrackMoonActivityRewardById.LogPair);
			return new TrackMoonActivityReward?(rootAsTrackMoonActivityReward);
		}

		// Token: 0x04004BFF RID: 19455
		private const string DB = "db_trackmoonactivity.db";

		// Token: 0x04004C00 RID: 19456
		private const string FILE = "z.追月节活动.xlsx";

		// Token: 0x04004C01 RID: 19457
		private const string TABLE = "TrackMoonActivityReward";

		// Token: 0x04004C02 RID: 19458
		private const string COMMAND = "select BinData from `TrackMoonActivityReward` where Id=?";

		// Token: 0x04004C03 RID: 19459
		private const string KEY_PREFIX = "TrackMoonActivityRewardById";

		// Token: 0x04004C04 RID: 19460
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C05 RID: 19461
		private static int HandleId;
	}
}
