using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E6 RID: 998
	public class ConfigHonamiStoryItemCollectionByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x000DE014 File Offset: 0x000DC214
		static ConfigHonamiStoryItemCollectionByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemCollectionByActivityId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemCollectionByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000DE034 File Offset: 0x000DC234
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

		// Token: 0x0600176D RID: 5997 RVA: 0x000DE0B3 File Offset: 0x000DC2B3
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemCollectionByActivityId.LogPair = null;
			ConfigHonamiStoryItemCollectionByActivityId.HandleId = 0;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000DE0C1 File Offset: 0x000DC2C1
		public static void Init()
		{
			ConfigHonamiStoryItemCollectionByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemCollectionByActivityId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItemCollection` where ActivityId=?");
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x000DE0DC File Offset: 0x000DC2DC
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

		// Token: 0x04001B2E RID: 6958
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B2F RID: 6959
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001B30 RID: 6960
		private const string TABLE = "HonamiStoryItemCollection";

		// Token: 0x04001B31 RID: 6961
		private const string COMMAND = "select BinData from `HonamiStoryItemCollection` where ActivityId=?";

		// Token: 0x04001B32 RID: 6962
		private const string KEY_PREFIX = "HonamiStoryItemCollectionByActivityId";

		// Token: 0x04001B33 RID: 6963
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B34 RID: 6964
		private static int HandleId;
	}
}
