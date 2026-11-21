using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032A RID: 810
	public class ConfigFloroRanchCurrencyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001301 RID: 4865 RVA: 0x000C874C File Offset: 0x000C694C
		static ConfigFloroRanchCurrencyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCurrencyAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchCurrencyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000C876C File Offset: 0x000C696C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchCurrencyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchCurrencyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchCurrency"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchCurrency`")
			});
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000C87EB File Offset: 0x000C69EB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCurrencyAll.LogPair = null;
			ConfigFloroRanchCurrencyAll.HandleId = 0;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000C87F9 File Offset: 0x000C69F9
		public static void Init()
		{
			ConfigFloroRanchCurrencyAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCurrencyAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCurrency`");
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000C8814 File Offset: 0x000C6A14
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchCurrency> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchCurrencyAll.HandleId, ConfigFloroRanchCurrencyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchCurrency> readOnlyList = (IReadOnlyList<FloroRanchCurrency>)ConfigCommon.GetConfig("FloroRanchCurrencyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchCurrency> list = new List<FloroRanchCurrency>();
			while (ConfigCommon.Step(ConfigFloroRanchCurrencyAll.HandleId, false, ConfigFloroRanchCurrencyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchCurrencyAll.HandleId, 0, ConfigFloroRanchCurrencyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchCurrencyAll.HandleId, ConfigFloroRanchCurrencyAll.LogPair);
					return null;
				}
				FloroRanchCurrency rootAsFloroRanchCurrency = FloroRanchCurrency.GetRootAsFloroRanchCurrency(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchCurrency);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchCurrencyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchCurrencyAll.HandleId, ConfigFloroRanchCurrencyAll.LogPair);
			return list;
		}

		// Token: 0x0400160A RID: 5642
		private const string DB = "db_flororanch.db";

		// Token: 0x0400160B RID: 5643
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400160C RID: 5644
		private const string TABLE = "FloroRanchCurrency";

		// Token: 0x0400160D RID: 5645
		private const string COMMAND = "select BinData from `FloroRanchCurrency`";

		// Token: 0x0400160E RID: 5646
		private const string KEY_PREFIX = "FloroRanchCurrencyAll";

		// Token: 0x0400160F RID: 5647
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001610 RID: 5648
		private static int HandleId;
	}
}
