using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003EF RID: 1007
	public class ConfigHonamiStoryLoadingPerformByBTIdAndTiming : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017A1 RID: 6049 RVA: 0x000DF3A7 File Offset: 0x000DD5A7
		static ConfigHonamiStoryLoadingPerformByBTIdAndTiming()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.ResetStaticDefaultValue));
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000DF3C8 File Offset: 0x000DD5C8
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

		// Token: 0x060017A3 RID: 6051 RVA: 0x000DF447 File Offset: 0x000DD647
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.LogPair = null;
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId = 0;
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x000DF455 File Offset: 0x000DD655
		public static void Init()
		{
			ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLoadingPerformByBTIdAndTiming.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLoadingPerform` where MainBTId=? AND Timing = ?");
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x000DF470 File Offset: 0x000DD670
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

		// Token: 0x04001B6D RID: 7021
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B6E RID: 7022
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B6F RID: 7023
		private const string TABLE = "HonamiStoryLoadingPerform";

		// Token: 0x04001B70 RID: 7024
		private const string COMMAND = "select BinData from `HonamiStoryLoadingPerform` where MainBTId=? AND Timing = ?";

		// Token: 0x04001B71 RID: 7025
		private const string KEY_PREFIX = "HonamiStoryLoadingPerformByBTIdAndTiming";

		// Token: 0x04001B72 RID: 7026
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B73 RID: 7027
		private static int HandleId;
	}
}
