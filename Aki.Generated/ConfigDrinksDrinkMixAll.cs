using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000227 RID: 551
	public class ConfigDrinksDrinkMixAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CEE RID: 3310 RVA: 0x000A2A94 File Offset: 0x000A0C94
		static ConfigDrinksDrinkMixAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDrinkMixAll.CreateStaticDefaultValue), new Action(ConfigDrinksDrinkMixAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000A2AB4 File Offset: 0x000A0CB4
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

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000A2B33 File Offset: 0x000A0D33
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDrinkMixAll.LogPair = null;
			ConfigDrinksDrinkMixAll.HandleId = 0;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x000A2B41 File Offset: 0x000A0D41
		public static void Init()
		{
			ConfigDrinksDrinkMixAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDrinkMixAll.HandleId, "db_drinks.db", "select BinData from `DrinksDrinkMix`");
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000A2B5C File Offset: 0x000A0D5C
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

		// Token: 0x04000EF5 RID: 3829
		private const string DB = "db_drinks.db";

		// Token: 0x04000EF6 RID: 3830
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000EF7 RID: 3831
		private const string TABLE = "DrinksDrinkMix";

		// Token: 0x04000EF8 RID: 3832
		private const string COMMAND = "select BinData from `DrinksDrinkMix`";

		// Token: 0x04000EF9 RID: 3833
		private const string KEY_PREFIX = "DrinksDrinkMixAll";

		// Token: 0x04000EFA RID: 3834
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EFB RID: 3835
		private static int HandleId;
	}
}
