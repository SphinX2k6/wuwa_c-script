using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000407 RID: 1031
	public class ConfigHonamiStoryLoadingPerformByTiming : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001831 RID: 6193 RVA: 0x000E5FE0 File Offset: 0x000E41E0
		static ConfigHonamiStoryLoadingPerformByTiming()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLoadingPerformByTiming.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLoadingPerformByTiming.ResetStaticDefaultValue));
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x000E6000 File Offset: 0x000E4200
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

		// Token: 0x06001833 RID: 6195 RVA: 0x000E607F File Offset: 0x000E427F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformByTiming.LogPair = null;
			ConfigHonamiStoryLoadingPerformByTiming.HandleId = 0;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000E608D File Offset: 0x000E428D
		public static void Init()
		{
			ConfigHonamiStoryLoadingPerformByTiming.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLoadingPerformByTiming.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLoadingPerform` where Timing = ?");
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x000E60A8 File Offset: 0x000E42A8
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

		// Token: 0x04001C15 RID: 7189
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C16 RID: 7190
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C17 RID: 7191
		private const string TABLE = "HonamiStoryLoadingPerform";

		// Token: 0x04001C18 RID: 7192
		private const string COMMAND = "select BinData from `HonamiStoryLoadingPerform` where Timing = ?";

		// Token: 0x04001C19 RID: 7193
		private const string KEY_PREFIX = "HonamiStoryLoadingPerformByTiming";

		// Token: 0x04001C1A RID: 7194
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C1B RID: 7195
		private static int HandleId;
	}
}
