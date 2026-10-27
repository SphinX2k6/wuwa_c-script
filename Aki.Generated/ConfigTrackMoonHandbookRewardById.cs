using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0D RID: 2573
	public class ConfigTrackMoonHandbookRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C62 RID: 15458 RVA: 0x001AF333 File Offset: 0x001AD533
		static ConfigTrackMoonHandbookRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonHandbookRewardById.CreateStaticDefaultValue), new Action(ConfigTrackMoonHandbookRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x001AF354 File Offset: 0x001AD554
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

		// Token: 0x06003C64 RID: 15460 RVA: 0x001AF3D3 File Offset: 0x001AD5D3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonHandbookRewardById.LogPair = null;
			ConfigTrackMoonHandbookRewardById.HandleId = 0;
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x001AF3E1 File Offset: 0x001AD5E1
		public static void Init()
		{
			ConfigTrackMoonHandbookRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonHandbookRewardById.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonHandbookReward` where Id = ?");
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x001AF3FC File Offset: 0x001AD5FC
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

		// Token: 0x04004641 RID: 17985
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004642 RID: 17986
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004643 RID: 17987
		private const string TABLE = "TrackMoonHandbookReward";

		// Token: 0x04004644 RID: 17988
		private const string COMMAND = "select BinData from `TrackMoonHandbookReward` where Id = ?";

		// Token: 0x04004645 RID: 17989
		private const string KEY_PREFIX = "TrackMoonHandbookRewardById";

		// Token: 0x04004646 RID: 17990
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004647 RID: 17991
		private static int HandleId;
	}
}
