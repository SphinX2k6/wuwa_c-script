using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FC RID: 1020
	public class ConfigHonamiStoryItemCollectionByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017EF RID: 6127 RVA: 0x000E4768 File Offset: 0x000E2968
		static ConfigHonamiStoryItemCollectionByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemCollectionByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemCollectionByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000E4788 File Offset: 0x000E2988
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryItemCollectionByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryItemCollectionByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryItemCollection"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryItemCollection` where ActivityId=?")
			});
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x000E4807 File Offset: 0x000E2A07
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemCollectionByActivityId.LogPair = null;
			ConfigHonamiStoryItemCollectionByActivityId.HandleId = 0;
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x000E4815 File Offset: 0x000E2A15
		public static void Init()
		{
			ConfigHonamiStoryItemCollectionByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemCollectionByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItemCollection` where ActivityId=?");
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000E4830 File Offset: 0x000E2A30
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryItemCollection> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryItemCollectionByActivityId.HandleId, ConfigHonamiStoryItemCollectionByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemCollectionByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<HonamiStoryItemCollection> readOnlyList = (IReadOnlyList<HonamiStoryItemCollection>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigHonamiStoryItemCollectionByActivityId.LogPair.Clear();
			ConfigHonamiStoryItemCollectionByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryItemCollectionByActivityId.HandleId, 1, p0ActivityId, ConfigHonamiStoryItemCollectionByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemCollectionByActivityId.HandleId, ConfigHonamiStoryItemCollectionByActivityId.LogPair);
				return null;
			}
			List<HonamiStoryItemCollection> list = new List<HonamiStoryItemCollection>();
			while (ConfigCommon.Step(ConfigHonamiStoryItemCollectionByActivityId.HandleId, false, ConfigHonamiStoryItemCollectionByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryItemCollectionByActivityId.HandleId, 0, ConfigHonamiStoryItemCollectionByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryItemCollectionByActivityId.HandleId, ConfigHonamiStoryItemCollectionByActivityId.LogPair);
					return null;
				}
				HonamiStoryItemCollection rootAsHonamiStoryItemCollection = HonamiStoryItemCollection.GetRootAsHonamiStoryItemCollection(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryItemCollection);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemCollectionByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryItemCollectionByActivityId.HandleId, ConfigHonamiStoryItemCollectionByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001BC8 RID: 7112
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BC9 RID: 7113
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001BCA RID: 7114
		private const string TABLE = "HonamiStoryItemCollection";

		// Token: 0x04001BCB RID: 7115
		private const string COMMAND = "select BinData from `HonamiStoryItemCollection` where ActivityId=?";

		// Token: 0x04001BCC RID: 7116
		private const string KEY_PREFIX = "HonamiStoryItemCollectionByActivityId";

		// Token: 0x04001BCD RID: 7117
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BCE RID: 7118
		private static int HandleId;
	}
}
