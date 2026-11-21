using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000237 RID: 567
	public class ConfigDrinksDrinkBaseAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D4E RID: 3406 RVA: 0x000A85F1 File Offset: 0x000A67F1
		static ConfigDrinksDrinkBaseAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDrinkBaseAll.CreateStaticDefaultValue), new Action(ConfigDrinksDrinkBaseAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000A8610 File Offset: 0x000A6810
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

		// Token: 0x06000D50 RID: 3408 RVA: 0x000A868F File Offset: 0x000A688F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDrinkBaseAll.LogPair = null;
			ConfigDrinksDrinkBaseAll.HandleId = 0;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000A869D File Offset: 0x000A689D
		public static void Init()
		{
			ConfigDrinksDrinkBaseAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDrinkBaseAll.HandleId, "db_drinks.db", "select BinData from `DrinksDrinkBase`");
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000A86B8 File Offset: 0x000A68B8
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

		// Token: 0x04000F65 RID: 3941
		private const string DB = "db_drinks.db";

		// Token: 0x04000F66 RID: 3942
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F67 RID: 3943
		private const string TABLE = "DrinksDrinkBase";

		// Token: 0x04000F68 RID: 3944
		private const string COMMAND = "select BinData from `DrinksDrinkBase`";

		// Token: 0x04000F69 RID: 3945
		private const string KEY_PREFIX = "DrinksDrinkBaseAll";

		// Token: 0x04000F6A RID: 3946
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F6B RID: 3947
		private static int HandleId;
	}
}
