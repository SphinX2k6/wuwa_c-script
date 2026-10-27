using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0B RID: 2571
	public class ConfigTrackMoonEntrustById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C56 RID: 15446 RVA: 0x001AEF58 File Offset: 0x001AD158
		static ConfigTrackMoonEntrustById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonEntrustById.CreateStaticDefaultValue), new Action(ConfigTrackMoonEntrustById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x001AEF78 File Offset: 0x001AD178
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

		// Token: 0x06003C58 RID: 15448 RVA: 0x001AEFF7 File Offset: 0x001AD1F7
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonEntrustById.LogPair = null;
			ConfigTrackMoonEntrustById.HandleId = 0;
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x001AF005 File Offset: 0x001AD205
		public static void Init()
		{
			ConfigTrackMoonEntrustById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonEntrustById.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonEntrust` where Id=?");
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x001AF020 File Offset: 0x001AD220
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

		// Token: 0x04004633 RID: 17971
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004634 RID: 17972
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004635 RID: 17973
		private const string TABLE = "TrackMoonEntrust";

		// Token: 0x04004636 RID: 17974
		private const string COMMAND = "select BinData from `TrackMoonEntrust` where Id=?";

		// Token: 0x04004637 RID: 17975
		private const string KEY_PREFIX = "TrackMoonEntrustById";

		// Token: 0x04004638 RID: 17976
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004639 RID: 17977
		private static int HandleId;
	}
}
