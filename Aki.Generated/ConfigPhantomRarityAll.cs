using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B0 RID: 1712
	public class ConfigPhantomRarityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002830 RID: 10288 RVA: 0x0013CDA0 File Offset: 0x0013AFA0
		static ConfigPhantomRarityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomRarityAll.CreateStaticDefaultValue), new Action(ConfigPhantomRarityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x0013CDC0 File Offset: 0x0013AFC0
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

		// Token: 0x06002832 RID: 10290 RVA: 0x0013CE3F File Offset: 0x0013B03F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomRarityAll.LogPair = null;
			ConfigPhantomRarityAll.HandleId = 0;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x0013CE4D File Offset: 0x0013B04D
		public static void Init()
		{
			ConfigPhantomRarityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomRarityAll.HandleId, "db_phantom.db", "select BinData from `PhantomRarity`");
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x0013CE68 File Offset: 0x0013B068
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

		// Token: 0x04002EB6 RID: 11958
		private const string DB = "db_phantom.db";

		// Token: 0x04002EB7 RID: 11959
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EB8 RID: 11960
		private const string TABLE = "PhantomRarity";

		// Token: 0x04002EB9 RID: 11961
		private const string COMMAND = "select BinData from `PhantomRarity`";

		// Token: 0x04002EBA RID: 11962
		private const string KEY_PREFIX = "PhantomRarityAll";

		// Token: 0x04002EBB RID: 11963
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EBC RID: 11964
		private static int HandleId;
	}
}
