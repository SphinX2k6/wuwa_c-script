using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057B RID: 1403
	public class ConfigMoraleKeepLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020EF RID: 8431 RVA: 0x00117234 File Offset: 0x00115434
		static ConfigMoraleKeepLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleKeepLevelAll.CreateStaticDefaultValue), new Action(ConfigMoraleKeepLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00117254 File Offset: 0x00115454
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleKeepLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleKeepLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleKeepLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleKeepLevel`")
			});
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x001172D3 File Offset: 0x001154D3
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleKeepLevelAll.LogPair = null;
			ConfigMoraleKeepLevelAll.HandleId = 0;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x001172E1 File Offset: 0x001154E1
		public static void Init()
		{
			ConfigMoraleKeepLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleKeepLevelAll.HandleId, "db_moraleplay.db", "select BinData from `MoraleKeepLevel`");
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x001172FC File Offset: 0x001154FC
		[NullableContext(2)]
		public static IReadOnlyList<MoraleKeepLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleKeepLevelAll.HandleId, ConfigMoraleKeepLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MoraleKeepLevel> readOnlyList = (IReadOnlyList<MoraleKeepLevel>)ConfigCommon.GetConfig("MoraleKeepLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MoraleKeepLevel> list = new List<MoraleKeepLevel>();
			while (ConfigCommon.Step(ConfigMoraleKeepLevelAll.HandleId, false, ConfigMoraleKeepLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleKeepLevelAll.HandleId, 0, ConfigMoraleKeepLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMoraleKeepLevelAll.HandleId, ConfigMoraleKeepLevelAll.LogPair);
					return null;
				}
				MoraleKeepLevel rootAsMoraleKeepLevel = MoraleKeepLevel.GetRootAsMoraleKeepLevel(new ByteBuffer(item2));
				list.Add(rootAsMoraleKeepLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MoraleKeepLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMoraleKeepLevelAll.HandleId, ConfigMoraleKeepLevelAll.LogPair);
			return list;
		}

		// Token: 0x04002641 RID: 9793
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002642 RID: 9794
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002643 RID: 9795
		private const string TABLE = "MoraleKeepLevel";

		// Token: 0x04002644 RID: 9796
		private const string COMMAND = "select BinData from `MoraleKeepLevel`";

		// Token: 0x04002645 RID: 9797
		private const string KEY_PREFIX = "MoraleKeepLevelAll";

		// Token: 0x04002646 RID: 9798
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002647 RID: 9799
		private static int HandleId;
	}
}
