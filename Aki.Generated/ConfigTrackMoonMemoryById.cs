using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A10 RID: 2576
	public class ConfigTrackMoonMemoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C74 RID: 15476 RVA: 0x001AF947 File Offset: 0x001ADB47
		static ConfigTrackMoonMemoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonMemoryById.CreateStaticDefaultValue), new Action(ConfigTrackMoonMemoryById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x001AF968 File Offset: 0x001ADB68
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonMemoryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonMemoryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonMemory"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonMemory` where Id = ?")
			});
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x001AF9E7 File Offset: 0x001ADBE7
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonMemoryById.LogPair = null;
			ConfigTrackMoonMemoryById.HandleId = 0;
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x001AF9F5 File Offset: 0x001ADBF5
		public static void Init()
		{
			ConfigTrackMoonMemoryById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonMemoryById.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonMemory` where Id = ?");
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x001AFA10 File Offset: 0x001ADC10
		public static TrackMoonMemory? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonMemoryById.HandleId, ConfigTrackMoonMemoryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonMemoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrackMoonMemory?(TrackMoonMemory.GetRootAsTrackMoonMemory(configBuffer));
				}
			}
			ConfigTrackMoonMemoryById.LogPair.Clear();
			ConfigTrackMoonMemoryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrackMoonMemoryById.HandleId, 1, p0Id, ConfigTrackMoonMemoryById.LogPair) || ConfigCommon.Step(ConfigTrackMoonMemoryById.HandleId, true, ConfigTrackMoonMemoryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrackMoonMemoryById.HandleId, ConfigTrackMoonMemoryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonMemoryById.HandleId, 0, ConfigTrackMoonMemoryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrackMoonMemoryById.HandleId, ConfigTrackMoonMemoryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrackMoonMemory rootAsTrackMoonMemory = TrackMoonMemory.GetRootAsTrackMoonMemory(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonMemoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrackMoonMemoryById.HandleId, ConfigTrackMoonMemoryById.LogPair);
			return new TrackMoonMemory?(rootAsTrackMoonMemory);
		}

		// Token: 0x04004656 RID: 18006
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004657 RID: 18007
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004658 RID: 18008
		private const string TABLE = "TrackMoonMemory";

		// Token: 0x04004659 RID: 18009
		private const string COMMAND = "select BinData from `TrackMoonMemory` where Id = ?";

		// Token: 0x0400465A RID: 18010
		private const string KEY_PREFIX = "TrackMoonMemoryById";

		// Token: 0x0400465B RID: 18011
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400465C RID: 18012
		private static int HandleId;
	}
}
