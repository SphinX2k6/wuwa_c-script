using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C8 RID: 1736
	public class ConfigPhantomRarityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028C0 RID: 10432 RVA: 0x0014381C File Offset: 0x00141A1C
		static ConfigPhantomRarityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomRarityAll.CreateStaticDefaultValue), new Action(ConfigPhantomRarityAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0014383C File Offset: 0x00141A3C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomRarityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomRarityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomRarity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomRarity`")
			});
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x001438BB File Offset: 0x00141ABB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomRarityAll.LogPair = null;
			ConfigPhantomRarityAll.HandleId = 0;
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x001438C9 File Offset: 0x00141AC9
		public static void Init()
		{
			ConfigPhantomRarityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomRarityAll.HandleId, "db_phantom.db", "select BinData from `PhantomRarity`");
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x001438E4 File Offset: 0x00141AE4
		[NullableContext(2)]
		public static IReadOnlyList<PhantomRarity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomRarityAll.HandleId, ConfigPhantomRarityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomRarity> readOnlyList = (IReadOnlyList<PhantomRarity>)ConfigCommon.GetConfig("PhantomRarityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomRarity> list = new List<PhantomRarity>();
			while (ConfigCommon.Step(ConfigPhantomRarityAll.HandleId, false, ConfigPhantomRarityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomRarityAll.HandleId, 0, ConfigPhantomRarityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomRarityAll.HandleId, ConfigPhantomRarityAll.LogPair);
					return null;
				}
				PhantomRarity rootAsPhantomRarity = PhantomRarity.GetRootAsPhantomRarity(new ByteBuffer(item2));
				list.Add(rootAsPhantomRarity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomRarityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomRarityAll.HandleId, ConfigPhantomRarityAll.LogPair);
			return list;
		}

		// Token: 0x04002F5E RID: 12126
		private const string DB = "db_phantom.db";

		// Token: 0x04002F5F RID: 12127
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F60 RID: 12128
		private const string TABLE = "PhantomRarity";

		// Token: 0x04002F61 RID: 12129
		private const string COMMAND = "select BinData from `PhantomRarity`";

		// Token: 0x04002F62 RID: 12130
		private const string KEY_PREFIX = "PhantomRarityAll";

		// Token: 0x04002F63 RID: 12131
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F64 RID: 12132
		private static int HandleId;
	}
}
