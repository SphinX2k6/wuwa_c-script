using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE6 RID: 2790
	public class ConfigTrackMoonPhaseActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004178 RID: 16760 RVA: 0x001CEF24 File Offset: 0x001CD124
		static ConfigTrackMoonPhaseActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonPhaseActivityById.CreateStaticDefaultValue), new Action(ConfigTrackMoonPhaseActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06004179 RID: 16761 RVA: 0x001CEF44 File Offset: 0x001CD144
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonPhaseActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonPhaseActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trackmoonphase.db"),
				new ValueTuple<string, object>("文件", "z.追月节活动相里.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonPhaseActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonPhaseActivity` where Id=?")
			});
		}

		// Token: 0x0600417A RID: 16762 RVA: 0x001CEFC3 File Offset: 0x001CD1C3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonPhaseActivityById.LogPair = null;
			ConfigTrackMoonPhaseActivityById.HandleId = 0;
		}

		// Token: 0x0600417B RID: 16763 RVA: 0x001CEFD1 File Offset: 0x001CD1D1
		public static void Init()
		{
			ConfigTrackMoonPhaseActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonPhaseActivityById.HandleId, "db_trackmoonphase.db", "select BinData from `TrackMoonPhaseActivity` where Id=?");
		}

		// Token: 0x0600417C RID: 16764 RVA: 0x001CEFEC File Offset: 0x001CD1EC
		public static TrackMoonPhaseActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonPhaseActivityById.HandleId, ConfigTrackMoonPhaseActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonPhaseActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrackMoonPhaseActivity?(TrackMoonPhaseActivity.GetRootAsTrackMoonPhaseActivity(configBuffer));
				}
			}
			ConfigTrackMoonPhaseActivityById.LogPair.Clear();
			ConfigTrackMoonPhaseActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrackMoonPhaseActivityById.HandleId, 1, p0Id, ConfigTrackMoonPhaseActivityById.LogPair) || ConfigCommon.Step(ConfigTrackMoonPhaseActivityById.HandleId, true, ConfigTrackMoonPhaseActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrackMoonPhaseActivityById.HandleId, ConfigTrackMoonPhaseActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonPhaseActivityById.HandleId, 0, ConfigTrackMoonPhaseActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrackMoonPhaseActivityById.HandleId, ConfigTrackMoonPhaseActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrackMoonPhaseActivity rootAsTrackMoonPhaseActivity = TrackMoonPhaseActivity.GetRootAsTrackMoonPhaseActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonPhaseActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrackMoonPhaseActivityById.HandleId, ConfigTrackMoonPhaseActivityById.LogPair);
			return new TrackMoonPhaseActivity?(rootAsTrackMoonPhaseActivity);
		}

		// Token: 0x04004C30 RID: 19504
		private const string DB = "db_trackmoonphase.db";

		// Token: 0x04004C31 RID: 19505
		private const string FILE = "z.追月节活动相里.xlsx";

		// Token: 0x04004C32 RID: 19506
		private const string TABLE = "TrackMoonPhaseActivity";

		// Token: 0x04004C33 RID: 19507
		private const string COMMAND = "select BinData from `TrackMoonPhaseActivity` where Id=?";

		// Token: 0x04004C34 RID: 19508
		private const string KEY_PREFIX = "TrackMoonPhaseActivityById";

		// Token: 0x04004C35 RID: 19509
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C36 RID: 19510
		private static int HandleId;
	}
}
