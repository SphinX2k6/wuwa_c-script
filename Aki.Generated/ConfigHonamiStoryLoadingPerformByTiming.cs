using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003F1 RID: 1009
	public class ConfigHonamiStoryLoadingPerformByTiming : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017AD RID: 6061 RVA: 0x000DF88C File Offset: 0x000DDA8C
		static ConfigHonamiStoryLoadingPerformByTiming()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLoadingPerformByTiming.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLoadingPerformByTiming.ResetStaticDefaultValue));
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000DF8AC File Offset: 0x000DDAAC
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformByTiming.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryLoadingPerformByTiming.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryLoadingPerform"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryLoadingPerform` where Timing = ?")
			});
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000DF92B File Offset: 0x000DDB2B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformByTiming.LogPair = null;
			ConfigHonamiStoryLoadingPerformByTiming.HandleId = 0;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x000DF939 File Offset: 0x000DDB39
		public static void Init()
		{
			ConfigHonamiStoryLoadingPerformByTiming.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLoadingPerformByTiming.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLoadingPerform` where Timing = ?");
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x000DF954 File Offset: 0x000DDB54
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryLoadingPerform> GetConfigList(int p0Timing, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryLoadingPerformByTiming.HandleId, ConfigHonamiStoryLoadingPerformByTiming.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLoadingPerformByTiming");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Timing);
				IReadOnlyList<HonamiStoryLoadingPerform> readOnlyList = (IReadOnlyList<HonamiStoryLoadingPerform>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryLoadingPerformByTiming.LogPair.Clear();
			ConfigHonamiStoryLoadingPerformByTiming.LogPair.Add(new ValueTuple<string, object>("Timing", p0Timing));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryLoadingPerformByTiming.HandleId, 1, p0Timing, ConfigHonamiStoryLoadingPerformByTiming.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformByTiming.HandleId, ConfigHonamiStoryLoadingPerformByTiming.LogPair);
				return null;
			}
			List<HonamiStoryLoadingPerform> list = new List<HonamiStoryLoadingPerform>();
			while (ConfigCommon.Step(ConfigHonamiStoryLoadingPerformByTiming.HandleId, false, ConfigHonamiStoryLoadingPerformByTiming.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryLoadingPerformByTiming.HandleId, 0, ConfigHonamiStoryLoadingPerformByTiming.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformByTiming.HandleId, ConfigHonamiStoryLoadingPerformByTiming.LogPair);
					return null;
				}
				HonamiStoryLoadingPerform rootAsHonamiStoryLoadingPerform = HonamiStoryLoadingPerform.GetRootAsHonamiStoryLoadingPerform(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryLoadingPerform);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLoadingPerformByTiming");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Timing);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformByTiming.HandleId, ConfigHonamiStoryLoadingPerformByTiming.LogPair);
			return list;
		}

		// Token: 0x04001B7B RID: 7035
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B7C RID: 7036
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B7D RID: 7037
		private const string TABLE = "HonamiStoryLoadingPerform";

		// Token: 0x04001B7E RID: 7038
		private const string COMMAND = "select BinData from `HonamiStoryLoadingPerform` where Timing = ?";

		// Token: 0x04001B7F RID: 7039
		private const string KEY_PREFIX = "HonamiStoryLoadingPerformByTiming";

		// Token: 0x04001B80 RID: 7040
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B81 RID: 7041
		private static int HandleId;
	}
}
