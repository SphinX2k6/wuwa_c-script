using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FB RID: 1019
	public class ConfigHonamiStoryPluginBoxItemByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017E9 RID: 6121 RVA: 0x000E0E18 File Offset: 0x000DF018
		static ConfigHonamiStoryPluginBoxItemByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryPluginBoxItemByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryPluginBoxItemByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000E0E38 File Offset: 0x000DF038
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

		// Token: 0x060017EB RID: 6123 RVA: 0x000E0EB7 File Offset: 0x000DF0B7
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryPluginBoxItemByActivityId.LogPair = null;
			ConfigHonamiStoryPluginBoxItemByActivityId.HandleId = 0;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x000E0EC5 File Offset: 0x000DF0C5
		public static void Init()
		{
			ConfigHonamiStoryPluginBoxItemByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryPluginBoxItemByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryPluginBoxItem` where ActivityId=?");
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000E0EE0 File Offset: 0x000DF0E0
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

		// Token: 0x04001BC1 RID: 7105
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BC2 RID: 7106
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BC3 RID: 7107
		private const string TABLE = "HonamiStoryPluginBoxItem";

		// Token: 0x04001BC4 RID: 7108
		private const string COMMAND = "select BinData from `HonamiStoryPluginBoxItem` where ActivityId=?";

		// Token: 0x04001BC5 RID: 7109
		private const string KEY_PREFIX = "HonamiStoryPluginBoxItemByActivityId";

		// Token: 0x04001BC6 RID: 7110
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BC7 RID: 7111
		private static int HandleId;
	}
}
