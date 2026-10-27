using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A11 RID: 2577
	public class ConfigTrackMoonPhaseActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C7A RID: 15482 RVA: 0x001AFB90 File Offset: 0x001ADD90
		static ConfigTrackMoonPhaseActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonPhaseActivityById.CreateStaticDefaultValue), new Action(ConfigTrackMoonPhaseActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x001AFBB0 File Offset: 0x001ADDB0
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

		// Token: 0x06003C7C RID: 15484 RVA: 0x001AFC2F File Offset: 0x001ADE2F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonPhaseActivityById.LogPair = null;
			ConfigTrackMoonPhaseActivityById.HandleId = 0;
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x001AFC3D File Offset: 0x001ADE3D
		public static void Init()
		{
			ConfigTrackMoonPhaseActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonPhaseActivityById.HandleId, "db_trackmoonphase.db", "select BinData from `TrackMoonPhaseActivity` where Id=?");
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x001AFC58 File Offset: 0x001ADE58
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

		// Token: 0x0400465D RID: 18013
		private const string DB = "db_trackmoonphase.db";

		// Token: 0x0400465E RID: 18014
		private const string FILE = "z.追月节活动相里.xlsx";

		// Token: 0x0400465F RID: 18015
		private const string TABLE = "TrackMoonPhaseActivity";

		// Token: 0x04004660 RID: 18016
		private const string COMMAND = "select BinData from `TrackMoonPhaseActivity` where Id=?";

		// Token: 0x04004661 RID: 18017
		private const string KEY_PREFIX = "TrackMoonPhaseActivityById";

		// Token: 0x04004662 RID: 18018
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004663 RID: 18019
		private static int HandleId;
	}
}
