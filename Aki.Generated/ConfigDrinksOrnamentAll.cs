using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022C RID: 556
	public class ConfigDrinksOrnamentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D0C RID: 3340 RVA: 0x000A3538 File Offset: 0x000A1738
		static ConfigDrinksOrnamentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksOrnamentAll.CreateStaticDefaultValue), new Action(ConfigDrinksOrnamentAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x000A3558 File Offset: 0x000A1758
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

		// Token: 0x06000D0E RID: 3342 RVA: 0x000A35D7 File Offset: 0x000A17D7
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksOrnamentAll.LogPair = null;
			ConfigDrinksOrnamentAll.HandleId = 0;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x000A35E5 File Offset: 0x000A17E5
		public static void Init()
		{
			ConfigDrinksOrnamentAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksOrnamentAll.HandleId, "db_drinks.db", "select BinData from `DrinksOrnament`");
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x000A3600 File Offset: 0x000A1800
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

		// Token: 0x04000F18 RID: 3864
		private const string DB = "db_drinks.db";

		// Token: 0x04000F19 RID: 3865
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F1A RID: 3866
		private const string TABLE = "DrinksOrnament";

		// Token: 0x04000F1B RID: 3867
		private const string COMMAND = "select BinData from `DrinksOrnament`";

		// Token: 0x04000F1C RID: 3868
		private const string KEY_PREFIX = "DrinksOrnamentAll";

		// Token: 0x04000F1D RID: 3869
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F1E RID: 3870
		private static int HandleId;
	}
}
