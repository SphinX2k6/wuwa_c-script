using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000225 RID: 549
	public class ConfigDrinksDrinkBaseAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CE2 RID: 3298 RVA: 0x000A26B9 File Offset: 0x000A08B9
		static ConfigDrinksDrinkBaseAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDrinkBaseAll.CreateStaticDefaultValue), new Action(ConfigDrinksDrinkBaseAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000A26D8 File Offset: 0x000A08D8
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksDrinkBaseAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksDrinkBaseAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksDrinkBase"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksDrinkBase`")
			});
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000A2757 File Offset: 0x000A0957
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDrinkBaseAll.LogPair = null;
			ConfigDrinksDrinkBaseAll.HandleId = 0;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000A2765 File Offset: 0x000A0965
		public static void Init()
		{
			ConfigDrinksDrinkBaseAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDrinkBaseAll.HandleId, "db_drinks.db", "select BinData from `DrinksDrinkBase`");
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000A2780 File Offset: 0x000A0980
		[NullableContext(2)]
		public static IReadOnlyList<DrinksDrinkBase> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksDrinkBaseAll.HandleId, ConfigDrinksDrinkBaseAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DrinksDrinkBase> readOnlyList = (IReadOnlyList<DrinksDrinkBase>)ConfigCommon.GetConfig("DrinksDrinkBaseAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DrinksDrinkBase> list = new List<DrinksDrinkBase>();
			while (ConfigCommon.Step(ConfigDrinksDrinkBaseAll.HandleId, false, ConfigDrinksDrinkBaseAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksDrinkBaseAll.HandleId, 0, ConfigDrinksDrinkBaseAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDrinksDrinkBaseAll.HandleId, ConfigDrinksDrinkBaseAll.LogPair);
					return null;
				}
				DrinksDrinkBase rootAsDrinksDrinkBase = DrinksDrinkBase.GetRootAsDrinksDrinkBase(new ByteBuffer(item2));
				list.Add(rootAsDrinksDrinkBase);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DrinksDrinkBaseAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDrinksDrinkBaseAll.HandleId, ConfigDrinksDrinkBaseAll.LogPair);
			return list;
		}

		// Token: 0x04000EE7 RID: 3815
		private const string DB = "db_drinks.db";

		// Token: 0x04000EE8 RID: 3816
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000EE9 RID: 3817
		private const string TABLE = "DrinksDrinkBase";

		// Token: 0x04000EEA RID: 3818
		private const string COMMAND = "select BinData from `DrinksDrinkBase`";

		// Token: 0x04000EEB RID: 3819
		private const string KEY_PREFIX = "DrinksDrinkBaseAll";

		// Token: 0x04000EEC RID: 3820
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EED RID: 3821
		private static int HandleId;
	}
}
