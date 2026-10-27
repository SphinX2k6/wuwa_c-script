using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003EE RID: 1006
	public class ConfigHonamiStoryLoadingPerformByBTId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600179B RID: 6043 RVA: 0x000DF170 File Offset: 0x000DD370
		static ConfigHonamiStoryLoadingPerformByBTId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLoadingPerformByBTId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLoadingPerformByBTId.ResetStaticDefaultValue));
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x000DF190 File Offset: 0x000DD390
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformByBTId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryLoadingPerformByBTId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryLoadingPerform"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryLoadingPerform` where MainBTId=?")
			});
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x000DF20F File Offset: 0x000DD40F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformByBTId.LogPair = null;
			ConfigHonamiStoryLoadingPerformByBTId.HandleId = 0;
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x000DF21D File Offset: 0x000DD41D
		public static void Init()
		{
			ConfigHonamiStoryLoadingPerformByBTId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLoadingPerformByBTId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLoadingPerform` where MainBTId=?");
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x000DF238 File Offset: 0x000DD438
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryLoadingPerform> GetConfigList(int p0MainBTId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryLoadingPerformByBTId.HandleId, ConfigHonamiStoryLoadingPerformByBTId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLoadingPerformByBTId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MainBTId);
				IReadOnlyList<HonamiStoryLoadingPerform> readOnlyList = (IReadOnlyList<HonamiStoryLoadingPerform>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryLoadingPerformByBTId.LogPair.Clear();
			ConfigHonamiStoryLoadingPerformByBTId.LogPair.Add(new ValueTuple<string, object>("MainBTId", p0MainBTId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryLoadingPerformByBTId.HandleId, 1, p0MainBTId, ConfigHonamiStoryLoadingPerformByBTId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformByBTId.HandleId, ConfigHonamiStoryLoadingPerformByBTId.LogPair);
				return null;
			}
			List<HonamiStoryLoadingPerform> list = new List<HonamiStoryLoadingPerform>();
			while (ConfigCommon.Step(ConfigHonamiStoryLoadingPerformByBTId.HandleId, false, ConfigHonamiStoryLoadingPerformByBTId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryLoadingPerformByBTId.HandleId, 0, ConfigHonamiStoryLoadingPerformByBTId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformByBTId.HandleId, ConfigHonamiStoryLoadingPerformByBTId.LogPair);
					return null;
				}
				HonamiStoryLoadingPerform rootAsHonamiStoryLoadingPerform = HonamiStoryLoadingPerform.GetRootAsHonamiStoryLoadingPerform(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryLoadingPerform);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryLoadingPerformByBTId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MainBTId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryLoadingPerformByBTId.HandleId, ConfigHonamiStoryLoadingPerformByBTId.LogPair);
			return list;
		}

		// Token: 0x04001B66 RID: 7014
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B67 RID: 7015
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B68 RID: 7016
		private const string TABLE = "HonamiStoryLoadingPerform";

		// Token: 0x04001B69 RID: 7017
		private const string COMMAND = "select BinData from `HonamiStoryLoadingPerform` where MainBTId=?";

		// Token: 0x04001B6A RID: 7018
		private const string KEY_PREFIX = "HonamiStoryLoadingPerformByBTId";

		// Token: 0x04001B6B RID: 7019
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B6C RID: 7020
		private static int HandleId;
	}
}
