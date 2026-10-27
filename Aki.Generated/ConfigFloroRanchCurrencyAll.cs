using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000315 RID: 789
	public class ConfigFloroRanchCurrencyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001283 RID: 4739 RVA: 0x000C2240 File Offset: 0x000C0440
		static ConfigFloroRanchCurrencyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCurrencyAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchCurrencyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x000C2260 File Offset: 0x000C0460
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

		// Token: 0x06001285 RID: 4741 RVA: 0x000C22DF File Offset: 0x000C04DF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCurrencyAll.LogPair = null;
			ConfigFloroRanchCurrencyAll.HandleId = 0;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000C22ED File Offset: 0x000C04ED
		public static void Init()
		{
			ConfigFloroRanchCurrencyAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCurrencyAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCurrency`");
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000C2308 File Offset: 0x000C0508
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

		// Token: 0x04001577 RID: 5495
		private const string DB = "db_flororanch.db";

		// Token: 0x04001578 RID: 5496
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001579 RID: 5497
		private const string TABLE = "FloroRanchCurrency";

		// Token: 0x0400157A RID: 5498
		private const string COMMAND = "select BinData from `FloroRanchCurrency`";

		// Token: 0x0400157B RID: 5499
		private const string KEY_PREFIX = "FloroRanchCurrencyAll";

		// Token: 0x0400157C RID: 5500
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400157D RID: 5501
		private static int HandleId;
	}
}
