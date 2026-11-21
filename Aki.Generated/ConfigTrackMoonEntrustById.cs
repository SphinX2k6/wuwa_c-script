using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE0 RID: 2784
	public class ConfigTrackMoonEntrustById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004154 RID: 16724 RVA: 0x001CE2EC File Offset: 0x001CC4EC
		static ConfigTrackMoonEntrustById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonEntrustById.CreateStaticDefaultValue), new Action(ConfigTrackMoonEntrustById.ResetStaticDefaultValue));
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x001CE30C File Offset: 0x001CC50C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonEntrustById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonEntrustById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonEntrust"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonEntrust` where Id=?")
			});
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x001CE38B File Offset: 0x001CC58B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonEntrustById.LogPair = null;
			ConfigTrackMoonEntrustById.HandleId = 0;
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x001CE399 File Offset: 0x001CC599
		public static void Init()
		{
			ConfigTrackMoonEntrustById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonEntrustById.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonEntrust` where Id=?");
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x001CE3B4 File Offset: 0x001CC5B4
		public static TrackMoonEntrust? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonEntrustById.HandleId, ConfigTrackMoonEntrustById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrackMoonEntrust?(TrackMoonEntrust.GetRootAsTrackMoonEntrust(configBuffer));
				}
			}
			ConfigTrackMoonEntrustById.LogPair.Clear();
			ConfigTrackMoonEntrustById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrackMoonEntrustById.HandleId, 1, p0Id, ConfigTrackMoonEntrustById.LogPair) || ConfigCommon.Step(ConfigTrackMoonEntrustById.HandleId, true, ConfigTrackMoonEntrustById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrackMoonEntrustById.HandleId, ConfigTrackMoonEntrustById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonEntrustById.HandleId, 0, ConfigTrackMoonEntrustById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrackMoonEntrustById.HandleId, ConfigTrackMoonEntrustById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrackMoonEntrust rootAsTrackMoonEntrust = TrackMoonEntrust.GetRootAsTrackMoonEntrust(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrackMoonEntrustById.HandleId, ConfigTrackMoonEntrustById.LogPair);
			return new TrackMoonEntrust?(rootAsTrackMoonEntrust);
		}

		// Token: 0x04004C06 RID: 19462
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004C07 RID: 19463
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004C08 RID: 19464
		private const string TABLE = "TrackMoonEntrust";

		// Token: 0x04004C09 RID: 19465
		private const string COMMAND = "select BinData from `TrackMoonEntrust` where Id=?";

		// Token: 0x04004C0A RID: 19466
		private const string KEY_PREFIX = "TrackMoonEntrustById";

		// Token: 0x04004C0B RID: 19467
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C0C RID: 19468
		private static int HandleId;
	}
}
