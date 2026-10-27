using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0A RID: 2570
	public class ConfigTrackMoonActivityRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C50 RID: 15440 RVA: 0x001AED0F File Offset: 0x001ACF0F
		static ConfigTrackMoonActivityRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonActivityRewardById.CreateStaticDefaultValue), new Action(ConfigTrackMoonActivityRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x001AED30 File Offset: 0x001ACF30
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

		// Token: 0x06003C52 RID: 15442 RVA: 0x001AEDAF File Offset: 0x001ACFAF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonActivityRewardById.LogPair = null;
			ConfigTrackMoonActivityRewardById.HandleId = 0;
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x001AEDBD File Offset: 0x001ACFBD
		public static void Init()
		{
			ConfigTrackMoonActivityRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonActivityRewardById.HandleId, "db_trackmoonactivity.db", "select BinData from `TrackMoonActivityReward` where Id=?");
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x001AEDD8 File Offset: 0x001ACFD8
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

		// Token: 0x0400462C RID: 17964
		private const string DB = "db_trackmoonactivity.db";

		// Token: 0x0400462D RID: 17965
		private const string FILE = "z.追月节活动.xlsx";

		// Token: 0x0400462E RID: 17966
		private const string TABLE = "TrackMoonActivityReward";

		// Token: 0x0400462F RID: 17967
		private const string COMMAND = "select BinData from `TrackMoonActivityReward` where Id=?";

		// Token: 0x04004630 RID: 17968
		private const string KEY_PREFIX = "TrackMoonActivityRewardById";

		// Token: 0x04004631 RID: 17969
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004632 RID: 17970
		private static int HandleId;
	}
}
