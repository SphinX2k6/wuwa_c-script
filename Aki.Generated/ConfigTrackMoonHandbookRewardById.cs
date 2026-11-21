using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE2 RID: 2786
	public class ConfigTrackMoonHandbookRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004160 RID: 16736 RVA: 0x001CE6C7 File Offset: 0x001CC8C7
		static ConfigTrackMoonHandbookRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonHandbookRewardById.CreateStaticDefaultValue), new Action(ConfigTrackMoonHandbookRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x001CE6E8 File Offset: 0x001CC8E8
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonHandbookRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonHandbookRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonHandbookReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonHandbookReward` where Id = ?")
			});
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x001CE767 File Offset: 0x001CC967
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonHandbookRewardById.LogPair = null;
			ConfigTrackMoonHandbookRewardById.HandleId = 0;
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x001CE775 File Offset: 0x001CC975
		public static void Init()
		{
			ConfigTrackMoonHandbookRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonHandbookRewardById.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonHandbookReward` where Id = ?");
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x001CE790 File Offset: 0x001CC990
		public static TrackMoonHandbookReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonHandbookRewardById.HandleId, ConfigTrackMoonHandbookRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonHandbookRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrackMoonHandbookReward?(TrackMoonHandbookReward.GetRootAsTrackMoonHandbookReward(configBuffer));
				}
			}
			ConfigTrackMoonHandbookRewardById.LogPair.Clear();
			ConfigTrackMoonHandbookRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrackMoonHandbookRewardById.HandleId, 1, p0Id, ConfigTrackMoonHandbookRewardById.LogPair) || ConfigCommon.Step(ConfigTrackMoonHandbookRewardById.HandleId, true, ConfigTrackMoonHandbookRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrackMoonHandbookRewardById.HandleId, ConfigTrackMoonHandbookRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonHandbookRewardById.HandleId, 0, ConfigTrackMoonHandbookRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrackMoonHandbookRewardById.HandleId, ConfigTrackMoonHandbookRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrackMoonHandbookReward rootAsTrackMoonHandbookReward = TrackMoonHandbookReward.GetRootAsTrackMoonHandbookReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonHandbookRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrackMoonHandbookRewardById.HandleId, ConfigTrackMoonHandbookRewardById.LogPair);
			return new TrackMoonHandbookReward?(rootAsTrackMoonHandbookReward);
		}

		// Token: 0x04004C14 RID: 19476
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004C15 RID: 19477
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004C16 RID: 19478
		private const string TABLE = "TrackMoonHandbookReward";

		// Token: 0x04004C17 RID: 19479
		private const string COMMAND = "select BinData from `TrackMoonHandbookReward` where Id = ?";

		// Token: 0x04004C18 RID: 19480
		private const string KEY_PREFIX = "TrackMoonHandbookRewardById";

		// Token: 0x04004C19 RID: 19481
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C1A RID: 19482
		private static int HandleId;
	}
}
