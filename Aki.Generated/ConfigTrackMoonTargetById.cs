using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE7 RID: 2791
	public class ConfigTrackMoonTargetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600417E RID: 16766 RVA: 0x001CF16C File Offset: 0x001CD36C
		static ConfigTrackMoonTargetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonTargetById.CreateStaticDefaultValue), new Action(ConfigTrackMoonTargetById.ResetStaticDefaultValue));
		}

		// Token: 0x0600417F RID: 16767 RVA: 0x001CF18C File Offset: 0x001CD38C
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

		// Token: 0x06004180 RID: 16768 RVA: 0x001CF20B File Offset: 0x001CD40B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonTargetById.LogPair = null;
			ConfigTrackMoonTargetById.HandleId = 0;
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x001CF219 File Offset: 0x001CD419
		public static void Init()
		{
			ConfigTrackMoonTargetById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonTargetById.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonTarget` where Id=?");
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x001CF234 File Offset: 0x001CD434
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

		// Token: 0x04004C37 RID: 19511
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004C38 RID: 19512
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004C39 RID: 19513
		private const string TABLE = "TrackMoonTarget";

		// Token: 0x04004C3A RID: 19514
		private const string COMMAND = "select BinData from `TrackMoonTarget` where Id=?";

		// Token: 0x04004C3B RID: 19515
		private const string KEY_PREFIX = "TrackMoonTargetById";

		// Token: 0x04004C3C RID: 19516
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C3D RID: 19517
		private static int HandleId;
	}
}
