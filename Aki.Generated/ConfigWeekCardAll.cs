using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B67 RID: 2919
	public class ConfigWeekCardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600447E RID: 17534 RVA: 0x001E0A84 File Offset: 0x001DEC84
		static ConfigWeekCardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeekCardAll.CreateStaticDefaultValue), new Action(ConfigWeekCardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x001E0AA4 File Offset: 0x001DECA4
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

		// Token: 0x06004480 RID: 17536 RVA: 0x001E0B23 File Offset: 0x001DED23
		public static void ResetStaticDefaultValue()
		{
			ConfigWeekCardAll.LogPair = null;
			ConfigWeekCardAll.HandleId = 0;
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x001E0B31 File Offset: 0x001DED31
		public static void Init()
		{
			ConfigWeekCardAll.HandleId = ConfigCommon.InitDataStatement(ConfigWeekCardAll.HandleId, "db_weekcard.db", "select BinData from `WeekCard`");
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x001E0B4C File Offset: 0x001DED4C
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

		// Token: 0x04004FB7 RID: 20407
		private const string DB = "db_weekcard.db";

		// Token: 0x04004FB8 RID: 20408
		private const string FILE = "z.周卡.xlsx";

		// Token: 0x04004FB9 RID: 20409
		private const string TABLE = "WeekCard";

		// Token: 0x04004FBA RID: 20410
		private const string COMMAND = "select BinData from `WeekCard`";

		// Token: 0x04004FBB RID: 20411
		private const string KEY_PREFIX = "WeekCardAll";

		// Token: 0x04004FBC RID: 20412
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FBD RID: 20413
		private static int HandleId;
	}
}
