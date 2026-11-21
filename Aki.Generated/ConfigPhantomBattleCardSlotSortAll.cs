using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000684 RID: 1668
	public class ConfigPhantomBattleCardSlotSortAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002728 RID: 10024 RVA: 0x0013A8E0 File Offset: 0x00138AE0
		static ConfigPhantomBattleCardSlotSortAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardSlotSortAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardSlotSortAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x0013A900 File Offset: 0x00138B00
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardSlotSortAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardSlotSortAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardSlotSort"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardSlotSort`")
			});
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x0013A97F File Offset: 0x00138B7F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardSlotSortAll.LogPair = null;
			ConfigPhantomBattleCardSlotSortAll.HandleId = 0;
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0013A98D File Offset: 0x00138B8D
		public static void Init()
		{
			ConfigPhantomBattleCardSlotSortAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardSlotSortAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardSlotSort`");
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0013A9A8 File Offset: 0x00138BA8
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleCardSlotSort> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardSlotSortAll.HandleId, ConfigPhantomBattleCardSlotSortAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleCardSlotSort> readOnlyList = (IReadOnlyList<PhantomBattleCardSlotSort>)ConfigCommon.GetConfig("PhantomBattleCardSlotSortAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleCardSlotSort> list = new List<PhantomBattleCardSlotSort>();
			while (ConfigCommon.Step(ConfigPhantomBattleCardSlotSortAll.HandleId, false, ConfigPhantomBattleCardSlotSortAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardSlotSortAll.HandleId, 0, ConfigPhantomBattleCardSlotSortAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleCardSlotSortAll.HandleId, ConfigPhantomBattleCardSlotSortAll.LogPair);
					return null;
				}
				PhantomBattleCardSlotSort rootAsPhantomBattleCardSlotSort = PhantomBattleCardSlotSort.GetRootAsPhantomBattleCardSlotSort(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleCardSlotSort);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleCardSlotSortAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardSlotSortAll.HandleId, ConfigPhantomBattleCardSlotSortAll.LogPair);
			return list;
		}

		// Token: 0x04002D82 RID: 11650
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D83 RID: 11651
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D84 RID: 11652
		private const string TABLE = "PhantomBattleCardSlotSort";

		// Token: 0x04002D85 RID: 11653
		private const string COMMAND = "select BinData from `PhantomBattleCardSlotSort`";

		// Token: 0x04002D86 RID: 11654
		private const string KEY_PREFIX = "PhantomBattleCardSlotSortAll";

		// Token: 0x04002D87 RID: 11655
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D88 RID: 11656
		private static int HandleId;
	}
}
