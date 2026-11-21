using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000234 RID: 564
	public class ConfigDrinksBatchingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D3C RID: 3388 RVA: 0x000A801C File Offset: 0x000A621C
		static ConfigDrinksBatchingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksBatchingAll.CreateStaticDefaultValue), new Action(ConfigDrinksBatchingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x000A803C File Offset: 0x000A623C
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

		// Token: 0x06000D3E RID: 3390 RVA: 0x000A80BB File Offset: 0x000A62BB
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksBatchingAll.LogPair = null;
			ConfigDrinksBatchingAll.HandleId = 0;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x000A80C9 File Offset: 0x000A62C9
		public static void Init()
		{
			ConfigDrinksBatchingAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksBatchingAll.HandleId, "db_drinks.db", "select BinData from `DrinksBatching`");
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000A80E4 File Offset: 0x000A62E4
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

		// Token: 0x04000F50 RID: 3920
		private const string DB = "db_drinks.db";

		// Token: 0x04000F51 RID: 3921
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F52 RID: 3922
		private const string TABLE = "DrinksBatching";

		// Token: 0x04000F53 RID: 3923
		private const string COMMAND = "select BinData from `DrinksBatching`";

		// Token: 0x04000F54 RID: 3924
		private const string KEY_PREFIX = "DrinksBatchingAll";

		// Token: 0x04000F55 RID: 3925
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F56 RID: 3926
		private static int HandleId;
	}
}
