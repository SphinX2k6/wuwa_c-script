using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ADD RID: 2781
	public class ConfigTrackMoonActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004142 RID: 16706 RVA: 0x001CDCC8 File Offset: 0x001CBEC8
		static ConfigTrackMoonActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonActivityById.CreateStaticDefaultValue), new Action(ConfigTrackMoonActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x001CDCE8 File Offset: 0x001CBEE8
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trackmoonactivity.db"),
				new ValueTuple<string, object>("文件", "z.追月节活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonActivity` where Id=?")
			});
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x001CDD67 File Offset: 0x001CBF67
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonActivityById.LogPair = null;
			ConfigTrackMoonActivityById.HandleId = 0;
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x001CDD75 File Offset: 0x001CBF75
		public static void Init()
		{
			ConfigTrackMoonActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonActivityById.HandleId, "db_trackmoonactivity.db", "select BinData from `TrackMoonActivity` where Id=?");
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x001CDD90 File Offset: 0x001CBF90
		public static TrackMoonActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonActivityById.HandleId, ConfigTrackMoonActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrackMoonActivity?(TrackMoonActivity.GetRootAsTrackMoonActivity(configBuffer));
				}
			}
			ConfigTrackMoonActivityById.LogPair.Clear();
			ConfigTrackMoonActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrackMoonActivityById.HandleId, 1, p0Id, ConfigTrackMoonActivityById.LogPair) || ConfigCommon.Step(ConfigTrackMoonActivityById.HandleId, true, ConfigTrackMoonActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrackMoonActivityById.HandleId, ConfigTrackMoonActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonActivityById.HandleId, 0, ConfigTrackMoonActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrackMoonActivityById.HandleId, ConfigTrackMoonActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrackMoonActivity rootAsTrackMoonActivity = TrackMoonActivity.GetRootAsTrackMoonActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrackMoonActivityById.HandleId, ConfigTrackMoonActivityById.LogPair);
			return new TrackMoonActivity?(rootAsTrackMoonActivity);
		}

		// Token: 0x04004BF1 RID: 19441
		private const string DB = "db_trackmoonactivity.db";

		// Token: 0x04004BF2 RID: 19442
		private const string FILE = "z.追月节活动.xlsx";

		// Token: 0x04004BF3 RID: 19443
		private const string TABLE = "TrackMoonActivity";

		// Token: 0x04004BF4 RID: 19444
		private const string COMMAND = "select BinData from `TrackMoonActivity` where Id=?";

		// Token: 0x04004BF5 RID: 19445
		private const string KEY_PREFIX = "TrackMoonActivityById";

		// Token: 0x04004BF6 RID: 19446
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004BF7 RID: 19447
		private static int HandleId;
	}
}
