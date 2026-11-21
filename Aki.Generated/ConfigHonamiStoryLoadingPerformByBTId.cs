using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000404 RID: 1028
	public class ConfigHonamiStoryLoadingPerformByBTId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600181F RID: 6175 RVA: 0x000E58C4 File Offset: 0x000E3AC4
		static ConfigHonamiStoryLoadingPerformByBTId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryLoadingPerformByBTId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryLoadingPerformByBTId.ResetStaticDefaultValue));
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000E58E4 File Offset: 0x000E3AE4
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

		// Token: 0x06001821 RID: 6177 RVA: 0x000E5963 File Offset: 0x000E3B63
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryLoadingPerformByBTId.LogPair = null;
			ConfigHonamiStoryLoadingPerformByBTId.HandleId = 0;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000E5971 File Offset: 0x000E3B71
		public static void Init()
		{
			ConfigHonamiStoryLoadingPerformByBTId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryLoadingPerformByBTId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryLoadingPerform` where MainBTId=?");
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000E598C File Offset: 0x000E3B8C
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

		// Token: 0x04001C00 RID: 7168
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C01 RID: 7169
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001C02 RID: 7170
		private const string TABLE = "HonamiStoryLoadingPerform";

		// Token: 0x04001C03 RID: 7171
		private const string COMMAND = "select BinData from `HonamiStoryLoadingPerform` where MainBTId=?";

		// Token: 0x04001C04 RID: 7172
		private const string KEY_PREFIX = "HonamiStoryLoadingPerformByBTId";

		// Token: 0x04001C05 RID: 7173
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C06 RID: 7174
		private static int HandleId;
	}
}
