using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000663 RID: 1635
	public class ConfigPhantomBattleCardFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002662 RID: 9826 RVA: 0x00132B74 File Offset: 0x00130D74
		static ConfigPhantomBattleCardFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardFilterAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x00132B94 File Offset: 0x00130D94
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

		// Token: 0x06002664 RID: 9828 RVA: 0x00132C13 File Offset: 0x00130E13
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardFilterAll.LogPair = null;
			ConfigPhantomBattleCardFilterAll.HandleId = 0;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00132C21 File Offset: 0x00130E21
		public static void Init()
		{
			ConfigPhantomBattleCardFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardFilterAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardFilter`");
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00132C3C File Offset: 0x00130E3C
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

		// Token: 0x04002C9B RID: 11419
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C9C RID: 11420
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C9D RID: 11421
		private const string TABLE = "PhantomBattleCardFilter";

		// Token: 0x04002C9E RID: 11422
		private const string COMMAND = "select BinData from `PhantomBattleCardFilter`";

		// Token: 0x04002C9F RID: 11423
		private const string KEY_PREFIX = "PhantomBattleCardFilterAll";

		// Token: 0x04002CA0 RID: 11424
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CA1 RID: 11425
		private static int HandleId;
	}
}
