using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067B RID: 1659
	public class ConfigPhantomBattleCardFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026F2 RID: 9970 RVA: 0x001395F0 File Offset: 0x001377F0
		static ConfigPhantomBattleCardFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardFilterAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00139610 File Offset: 0x00137810
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardFilterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardFilterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardFilter`")
			});
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x0013968F File Offset: 0x0013788F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardFilterAll.LogPair = null;
			ConfigPhantomBattleCardFilterAll.HandleId = 0;
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0013969D File Offset: 0x0013789D
		public static void Init()
		{
			ConfigPhantomBattleCardFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardFilterAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardFilter`");
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x001396B8 File Offset: 0x001378B8
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleCardFilter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardFilterAll.HandleId, ConfigPhantomBattleCardFilterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleCardFilter> readOnlyList = (IReadOnlyList<PhantomBattleCardFilter>)ConfigCommon.GetConfig("PhantomBattleCardFilterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleCardFilter> list = new List<PhantomBattleCardFilter>();
			while (ConfigCommon.Step(ConfigPhantomBattleCardFilterAll.HandleId, false, ConfigPhantomBattleCardFilterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardFilterAll.HandleId, 0, ConfigPhantomBattleCardFilterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleCardFilterAll.HandleId, ConfigPhantomBattleCardFilterAll.LogPair);
					return null;
				}
				PhantomBattleCardFilter rootAsPhantomBattleCardFilter = PhantomBattleCardFilter.GetRootAsPhantomBattleCardFilter(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleCardFilter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleCardFilterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardFilterAll.HandleId, ConfigPhantomBattleCardFilterAll.LogPair);
			return list;
		}

		// Token: 0x04002D43 RID: 11587
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D44 RID: 11588
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D45 RID: 11589
		private const string TABLE = "PhantomBattleCardFilter";

		// Token: 0x04002D46 RID: 11590
		private const string COMMAND = "select BinData from `PhantomBattleCardFilter`";

		// Token: 0x04002D47 RID: 11591
		private const string KEY_PREFIX = "PhantomBattleCardFilterAll";

		// Token: 0x04002D48 RID: 11592
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D49 RID: 11593
		private static int HandleId;
	}
}
