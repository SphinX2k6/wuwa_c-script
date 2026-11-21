using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000411 RID: 1041
	public class ConfigHonamiStoryPluginBoxItemByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600186D RID: 6253 RVA: 0x000E756C File Offset: 0x000E576C
		static ConfigHonamiStoryPluginBoxItemByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginBoxItemByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginBoxItemByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x000E758C File Offset: 0x000E578C
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryPluginBoxItemByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryPluginBoxItemByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryPluginBoxItem"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryPluginBoxItem` where ActivityId=?")
			});
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x000E760B File Offset: 0x000E580B
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginBoxItemByActivityId.LogPair = null;
			ConfigHonamiStoryPluginBoxItemByActivityId.HandleId = 0;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x000E7619 File Offset: 0x000E5819
		public static void Init()
		{
			ConfigHonamiStoryPluginBoxItemByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginBoxItemByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginBoxItem` where ActivityId=?");
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x000E7634 File Offset: 0x000E5834
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryPluginBoxItem> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryPluginBoxItemByActivityId.HandleId, ConfigHonamiStoryPluginBoxItemByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginBoxItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryPluginBoxItem> readOnlyList = (IReadOnlyList<HonamiStoryPluginBoxItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryPluginBoxItemByActivityId.LogPair.Clear();
			ConfigHonamiStoryPluginBoxItemByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryPluginBoxItemByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryPluginBoxItemByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryPluginBoxItemByActivityId.HandleId, ConfigHonamiStoryPluginBoxItemByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryPluginBoxItem> list = new List<HonamiStoryPluginBoxItem>();
			while (ConfigCommon.Step(ConfigHonamiStoryPluginBoxItemByActivityId.HandleId, false, ConfigHonamiStoryPluginBoxItemByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryPluginBoxItemByActivityId.HandleId, 0, ConfigHonamiStoryPluginBoxItemByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryPluginBoxItemByActivityId.HandleId, ConfigHonamiStoryPluginBoxItemByActivityId.LogPair);
					return null;
				}
				HonamiStoryPluginBoxItem rootAsHonamiStoryPluginBoxItem = HonamiStoryPluginBoxItem.GetRootAsHonamiStoryPluginBoxItem(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryPluginBoxItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryPluginBoxItemByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryPluginBoxItemByActivityId.HandleId, ConfigHonamiStoryPluginBoxItemByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001C5B RID: 7259
		private const string DB = "db_honamistory.db";

		// Token: 0x04001C5C RID: 7260
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001C5D RID: 7261
		private const string TABLE = "HonamiStoryPluginBoxItem";

		// Token: 0x04001C5E RID: 7262
		private const string COMMAND = "select BinData from `HonamiStoryPluginBoxItem` where ActivityId=?";

		// Token: 0x04001C5F RID: 7263
		private const string KEY_PREFIX = "HonamiStoryPluginBoxItemByActivityId";

		// Token: 0x04001C60 RID: 7264
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C61 RID: 7265
		private static int HandleId;
	}
}
