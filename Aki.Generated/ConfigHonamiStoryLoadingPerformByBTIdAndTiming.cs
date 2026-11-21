using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000405 RID: 1029
	public class ConfigHonamiStoryLoadingPerformByBTIdAndTiming : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001825 RID: 6181 RVA: 0x000E5AFB File Offset: 0x000E3CFB
		static ConfigHonamiStoryLoadingPerformByBTIdAndTiming()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.ResetStaticDefaultValue));
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000E5B1C File Offset: 0x000E3D1C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryLoadingPerform"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryLoadingPerform` where MainBTId=? AND Timing = ?")
			});
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000E5B9B File Offset: 0x000E3D9B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair = null;
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId = 0;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000E5BA9 File Offset: 0x000E3DA9
		public static void Init()
		{
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLoadingPerform` where MainBTId=? AND Timing = ?");
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000E5BC4 File Offset: 0x000E3DC4
		public static HonamiStoryLoadingPerform? GetConfig(int p0MainBTId, int p1Timing, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLoadingPerformByBTIdAndTiming");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MainBTId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Timing);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryLoadingPerform?(HonamiStoryLoadingPerform.GetRootAsHonamiStoryLoadingPerform(configBuffer));
				}
			}
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair.Clear();
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair.Add(new ValueTuple<string, object>("MainBTId", p0MainBTId));
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair.Add(new ValueTuple<string, object>("Timing", p1Timing));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, 1, p0MainBTId, ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair) || !ConfigCommon.BindInt(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, 2, p1Timing, ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair) || ConfigCommon.Step(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, true, ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, 0, ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryLoadingPerform rootAsHonamiStoryLoadingPerform = HonamiStoryLoadingPerform.GetRootAsHonamiStoryLoadingPerform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLoadingPerformByBTIdAndTiming");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MainBTId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Timing);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair);
			return new HonamiStoryLoadingPerform?(rootAsHonamiStoryLoadingPerform);
		}

		// Token: 0x04001C07 RID: 7175
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C08 RID: 7176
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C09 RID: 7177
		private const string TABLE = "HonamiStoryLoadingPerform";

		// Token: 0x04001C0A RID: 7178
		private const string COMMAND = "select BinData from `HonamiStoryLoadingPerform` where MainBTId=? AND Timing = ?";

		// Token: 0x04001C0B RID: 7179
		private const string KEY_PREFIX = "HonamiStoryLoadingPerformByBTIdAndTiming";

		// Token: 0x04001C0C RID: 7180
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C0D RID: 7181
		private static int HandleId;
	}
}
