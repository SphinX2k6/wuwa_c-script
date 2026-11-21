using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023E RID: 574
	public class ConfigDrinksOrnamentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D78 RID: 3448 RVA: 0x000A9470 File Offset: 0x000A7670
		static ConfigDrinksOrnamentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksOrnamentAll.CreateStaticDefaultValue), new Action(ConfigDrinksOrnamentAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000A9490 File Offset: 0x000A7690
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksOrnamentAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksOrnamentAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksOrnament"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksOrnament`")
			});
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000A950F File Offset: 0x000A770F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksOrnamentAll.LogPair = null;
			ConfigDrinksOrnamentAll.HandleId = 0;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x000A951D File Offset: 0x000A771D
		public static void Init()
		{
			ConfigDrinksOrnamentAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksOrnamentAll.HandleId, "db_drinks.db", "select BinData from `DrinksOrnament`");
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000A9538 File Offset: 0x000A7738
		[NullableContext(2)]
		public static IReadOnlyList<DrinksOrnament> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksOrnamentAll.HandleId, ConfigDrinksOrnamentAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DrinksOrnament> readOnlyList = (IReadOnlyList<DrinksOrnament>)ConfigCommon.GetConfig("DrinksOrnamentAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DrinksOrnament> list = new List<DrinksOrnament>();
			while (ConfigCommon.Step(ConfigDrinksOrnamentAll.HandleId, false, ConfigDrinksOrnamentAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksOrnamentAll.HandleId, 0, ConfigDrinksOrnamentAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDrinksOrnamentAll.HandleId, ConfigDrinksOrnamentAll.LogPair);
					return null;
				}
				DrinksOrnament rootAsDrinksOrnament = DrinksOrnament.GetRootAsDrinksOrnament(new ByteBuffer(item2));
				list.Add(rootAsDrinksOrnament);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DrinksOrnamentAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDrinksOrnamentAll.HandleId, ConfigDrinksOrnamentAll.LogPair);
			return list;
		}

		// Token: 0x04000F96 RID: 3990
		private const string DB = "db_drinks.db";

		// Token: 0x04000F97 RID: 3991
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F98 RID: 3992
		private const string TABLE = "DrinksOrnament";

		// Token: 0x04000F99 RID: 3993
		private const string COMMAND = "select BinData from `DrinksOrnament`";

		// Token: 0x04000F9A RID: 3994
		private const string KEY_PREFIX = "DrinksOrnamentAll";

		// Token: 0x04000F9B RID: 3995
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F9C RID: 3996
		private static int HandleId;
	}
}
