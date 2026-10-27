using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A92 RID: 2706
	public class ConfigWeekCardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F80 RID: 16256 RVA: 0x001C16F0 File Offset: 0x001BF8F0
		static ConfigWeekCardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeekCardAll.CreateStaticDefaultValue), new Action(ConfigWeekCardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x001C1710 File Offset: 0x001BF910
		public static void CreateStaticDefaultValue()
		{
			ConfigWeekCardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeekCardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weekcard.db"),
				new ValueTuple<string, object>("文件", "z.周卡.xlsx"),
				new ValueTuple<string, object>("表名", "WeekCard"),
				new ValueTuple<string, object>("语句", "select BinData from `WeekCard`")
			});
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x001C178F File Offset: 0x001BF98F
		public static void ResetStaticDefaultValue()
		{
			ConfigWeekCardAll.LogPair = null;
			ConfigWeekCardAll.HandleId = 0;
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x001C179D File Offset: 0x001BF99D
		public static void Init()
		{
			ConfigWeekCardAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeekCardAll.HandleId, "db_weekcard.db", "select BinData from `WeekCard`");
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x001C17B8 File Offset: 0x001BF9B8
		[NullableContext(2)]
		public static IReadOnlyList<WeekCard> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeekCardAll.HandleId, ConfigWeekCardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WeekCard> readOnlyList = (IReadOnlyList<WeekCard>)ConfigCommon.GetConfig("WeekCardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WeekCard> list = new List<WeekCard>();
			while (ConfigCommon.Step(ConfigWeekCardAll.HandleId, false, ConfigWeekCardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeekCardAll.HandleId, 0, ConfigWeekCardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeekCardAll.HandleId, ConfigWeekCardAll.LogPair);
					return null;
				}
				WeekCard rootAsWeekCard = WeekCard.GetRootAsWeekCard(new ByteBuffer(item2));
				list.Add(rootAsWeekCard);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WeekCardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeekCardAll.HandleId, ConfigWeekCardAll.LogPair);
			return list;
		}

		// Token: 0x040049E4 RID: 18916
		private const string DB = "db_weekcard.db";

		// Token: 0x040049E5 RID: 18917
		private const string FILE = "z.周卡.xlsx";

		// Token: 0x040049E6 RID: 18918
		private const string TABLE = "WeekCard";

		// Token: 0x040049E7 RID: 18919
		private const string COMMAND = "select BinData from `WeekCard`";

		// Token: 0x040049E8 RID: 18920
		private const string KEY_PREFIX = "WeekCardAll";

		// Token: 0x040049E9 RID: 18921
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049EA RID: 18922
		private static int HandleId;
	}
}
