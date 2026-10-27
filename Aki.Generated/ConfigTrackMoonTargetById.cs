using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A12 RID: 2578
	public class ConfigTrackMoonTargetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C80 RID: 15488 RVA: 0x001AFDD8 File Offset: 0x001ADFD8
		static ConfigTrackMoonTargetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonTargetById.CreateStaticDefaultValue), new Action(ConfigTrackMoonTargetById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x001AFDF8 File Offset: 0x001ADFF8
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonTargetById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonTargetById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonTarget"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonTarget` where Id=?")
			});
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x001AFE77 File Offset: 0x001AE077
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonTargetById.LogPair = null;
			ConfigTrackMoonTargetById.HandleId = 0;
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x001AFE85 File Offset: 0x001AE085
		public static void Init()
		{
			ConfigTrackMoonTargetById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonTargetById.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonTarget` where Id=?");
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x001AFEA0 File Offset: 0x001AE0A0
		public static TrackMoonTarget? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonTargetById.HandleId, ConfigTrackMoonTargetById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonTargetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrackMoonTarget?(TrackMoonTarget.GetRootAsTrackMoonTarget(configBuffer));
				}
			}
			ConfigTrackMoonTargetById.LogPair.Clear();
			ConfigTrackMoonTargetById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrackMoonTargetById.HandleId, 1, p0Id, ConfigTrackMoonTargetById.LogPair) || ConfigCommon.Step(ConfigTrackMoonTargetById.HandleId, true, ConfigTrackMoonTargetById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrackMoonTargetById.HandleId, ConfigTrackMoonTargetById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonTargetById.HandleId, 0, ConfigTrackMoonTargetById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrackMoonTargetById.HandleId, ConfigTrackMoonTargetById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrackMoonTarget rootAsTrackMoonTarget = TrackMoonTarget.GetRootAsTrackMoonTarget(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonTargetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrackMoonTargetById.HandleId, ConfigTrackMoonTargetById.LogPair);
			return new TrackMoonTarget?(rootAsTrackMoonTarget);
		}

		// Token: 0x04004664 RID: 18020
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004665 RID: 18021
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004666 RID: 18022
		private const string TABLE = "TrackMoonTarget";

		// Token: 0x04004667 RID: 18023
		private const string COMMAND = "select BinData from `TrackMoonTarget` where Id=?";

		// Token: 0x04004668 RID: 18024
		private const string KEY_PREFIX = "TrackMoonTargetById";

		// Token: 0x04004669 RID: 18025
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400466A RID: 18026
		private static int HandleId;
	}
}
