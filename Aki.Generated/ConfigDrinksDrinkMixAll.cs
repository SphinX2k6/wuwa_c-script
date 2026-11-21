using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000239 RID: 569
	public class ConfigDrinksDrinkMixAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x000A89CC File Offset: 0x000A6BCC
		static ConfigDrinksDrinkMixAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDrinkMixAll.CreateStaticDefaultValue), new Action(ConfigDrinksDrinkMixAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x000A89EC File Offset: 0x000A6BEC
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksDrinkMixAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksDrinkMixAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksDrinkMix"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksDrinkMix`")
			});
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000A8A6B File Offset: 0x000A6C6B
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDrinkMixAll.LogPair = null;
			ConfigDrinksDrinkMixAll.HandleId = 0;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000A8A79 File Offset: 0x000A6C79
		public static void Init()
		{
			ConfigDrinksDrinkMixAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDrinkMixAll.HandleId, "db_drinks.db", "select BinData from `DrinksDrinkMix`");
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000A8A94 File Offset: 0x000A6C94
		[NullableContext(2)]
		public static IReadOnlyList<DrinksDrinkMix> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksDrinkMixAll.HandleId, ConfigDrinksDrinkMixAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DrinksDrinkMix> readOnlyList = (IReadOnlyList<DrinksDrinkMix>)ConfigCommon.GetConfig("DrinksDrinkMixAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DrinksDrinkMix> list = new List<DrinksDrinkMix>();
			while (ConfigCommon.Step(ConfigDrinksDrinkMixAll.HandleId, false, ConfigDrinksDrinkMixAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksDrinkMixAll.HandleId, 0, ConfigDrinksDrinkMixAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDrinksDrinkMixAll.HandleId, ConfigDrinksDrinkMixAll.LogPair);
					return null;
				}
				DrinksDrinkMix rootAsDrinksDrinkMix = DrinksDrinkMix.GetRootAsDrinksDrinkMix(new ByteBuffer(item2));
				list.Add(rootAsDrinksDrinkMix);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DrinksDrinkMixAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDrinksDrinkMixAll.HandleId, ConfigDrinksDrinkMixAll.LogPair);
			return list;
		}

		// Token: 0x04000F73 RID: 3955
		private const string DB = "db_drinks.db";

		// Token: 0x04000F74 RID: 3956
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F75 RID: 3957
		private const string TABLE = "DrinksDrinkMix";

		// Token: 0x04000F76 RID: 3958
		private const string COMMAND = "select BinData from `DrinksDrinkMix`";

		// Token: 0x04000F77 RID: 3959
		private const string KEY_PREFIX = "DrinksDrinkMixAll";

		// Token: 0x04000F78 RID: 3960
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F79 RID: 3961
		private static int HandleId;
	}
}
