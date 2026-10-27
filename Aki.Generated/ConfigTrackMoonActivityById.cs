using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A08 RID: 2568
	public class ConfigTrackMoonActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C44 RID: 15428 RVA: 0x001AE934 File Offset: 0x001ACB34
		static ConfigTrackMoonActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonActivityById.CreateStaticDefaultValue), new Action(ConfigTrackMoonActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x001AE954 File Offset: 0x001ACB54
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

		// Token: 0x06003C46 RID: 15430 RVA: 0x001AE9D3 File Offset: 0x001ACBD3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonActivityById.LogPair = null;
			ConfigTrackMoonActivityById.HandleId = 0;
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x001AE9E1 File Offset: 0x001ACBE1
		public static void Init()
		{
			ConfigTrackMoonActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonActivityById.HandleId, "db_trackmoonactivity.db", "select BinData from `TrackMoonActivity` where Id=?");
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x001AE9FC File Offset: 0x001ACBFC
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

		// Token: 0x0400461E RID: 17950
		private const string DB = "db_trackmoonactivity.db";

		// Token: 0x0400461F RID: 17951
		private const string FILE = "z.追月节活动.xlsx";

		// Token: 0x04004620 RID: 17952
		private const string TABLE = "TrackMoonActivity";

		// Token: 0x04004621 RID: 17953
		private const string COMMAND = "select BinData from `TrackMoonActivity` where Id=?";

		// Token: 0x04004622 RID: 17954
		private const string KEY_PREFIX = "TrackMoonActivityById";

		// Token: 0x04004623 RID: 17955
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004624 RID: 17956
		private static int HandleId;
	}
}
