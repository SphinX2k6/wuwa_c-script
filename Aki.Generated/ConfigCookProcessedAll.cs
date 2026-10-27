using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A0 RID: 416
	public class ConfigCookProcessedAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009C3 RID: 2499 RVA: 0x00090AAC File Offset: 0x0008ECAC
		static ConfigCookProcessedAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookProcessedAll.CreateStaticDefaultValue), new Action(ConfigCookProcessedAll.ResetStaticDefaultValue));
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00090ACC File Offset: 0x0008ECCC
		public static void CreateStaticDefaultValue()
		{
			ConfigCookProcessedAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookProcessedAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookProcessed"),
				new ValueTuple<string, object>("语句", "select BinData from `CookProcessed`")
			});
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00090B4B File Offset: 0x0008ED4B
		public static void ResetStaticDefaultValue()
		{
			ConfigCookProcessedAll.LogPair = null;
			ConfigCookProcessedAll.HandleId = 0;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00090B59 File Offset: 0x0008ED59
		public static void Init()
		{
			ConfigCookProcessedAll.HandleId = ConfigCommon.InitDataStatement(ConfigCookProcessedAll.HandleId, "db_cook.db", "select BinData from `CookProcessed`");
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00090B74 File Offset: 0x0008ED74
		[NullableContext(2)]
		public static IReadOnlyList<CookProcessed> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookProcessedAll.HandleId, ConfigCookProcessedAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CookProcessed> readOnlyList = (IReadOnlyList<CookProcessed>)ConfigCommon.GetConfig("CookProcessedAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CookProcessed> list = new List<CookProcessed>();
			while (ConfigCommon.Step(ConfigCookProcessedAll.HandleId, false, ConfigCookProcessedAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookProcessedAll.HandleId, 0, ConfigCookProcessedAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCookProcessedAll.HandleId, ConfigCookProcessedAll.LogPair);
					return null;
				}
				CookProcessed rootAsCookProcessed = CookProcessed.GetRootAsCookProcessed(new ByteBuffer(item2));
				list.Add(rootAsCookProcessed);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CookProcessedAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCookProcessedAll.HandleId, ConfigCookProcessedAll.LogPair);
			return list;
		}

		// Token: 0x04000B44 RID: 2884
		private const string DB = "db_cook.db";

		// Token: 0x04000B45 RID: 2885
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B46 RID: 2886
		private const string TABLE = "CookProcessed";

		// Token: 0x04000B47 RID: 2887
		private const string COMMAND = "select BinData from `CookProcessed`";

		// Token: 0x04000B48 RID: 2888
		private const string KEY_PREFIX = "CookProcessedAll";

		// Token: 0x04000B49 RID: 2889
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B4A RID: 2890
		private static int HandleId;
	}
}
