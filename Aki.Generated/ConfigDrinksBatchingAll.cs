using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000222 RID: 546
	public class ConfigDrinksBatchingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CD0 RID: 3280 RVA: 0x000A20E4 File Offset: 0x000A02E4
		static ConfigDrinksBatchingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksBatchingAll.CreateStaticDefaultValue), new Action(ConfigDrinksBatchingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x000A2104 File Offset: 0x000A0304
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksBatchingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksBatchingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksBatching"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksBatching`")
			});
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000A2183 File Offset: 0x000A0383
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksBatchingAll.LogPair = null;
			ConfigDrinksBatchingAll.HandleId = 0;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000A2191 File Offset: 0x000A0391
		public static void Init()
		{
			ConfigDrinksBatchingAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksBatchingAll.HandleId, "db_drinks.db", "select BinData from `DrinksBatching`");
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x000A21AC File Offset: 0x000A03AC
		[NullableContext(2)]
		public static IReadOnlyList<DrinksBatching> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksBatchingAll.HandleId, ConfigDrinksBatchingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DrinksBatching> readOnlyList = (IReadOnlyList<DrinksBatching>)ConfigCommon.GetConfig("DrinksBatchingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DrinksBatching> list = new List<DrinksBatching>();
			while (ConfigCommon.Step(ConfigDrinksBatchingAll.HandleId, false, ConfigDrinksBatchingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksBatchingAll.HandleId, 0, ConfigDrinksBatchingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDrinksBatchingAll.HandleId, ConfigDrinksBatchingAll.LogPair);
					return null;
				}
				DrinksBatching rootAsDrinksBatching = DrinksBatching.GetRootAsDrinksBatching(new ByteBuffer(item2));
				list.Add(rootAsDrinksBatching);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DrinksBatchingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDrinksBatchingAll.HandleId, ConfigDrinksBatchingAll.LogPair);
			return list;
		}

		// Token: 0x04000ED2 RID: 3794
		private const string DB = "db_drinks.db";

		// Token: 0x04000ED3 RID: 3795
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000ED4 RID: 3796
		private const string TABLE = "DrinksBatching";

		// Token: 0x04000ED5 RID: 3797
		private const string COMMAND = "select BinData from `DrinksBatching`";

		// Token: 0x04000ED6 RID: 3798
		private const string KEY_PREFIX = "DrinksBatchingAll";

		// Token: 0x04000ED7 RID: 3799
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ED8 RID: 3800
		private static int HandleId;
	}
}
