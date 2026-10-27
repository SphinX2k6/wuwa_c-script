using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066C RID: 1644
	public class ConfigPhantomBattleCardSlotSortAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002698 RID: 9880 RVA: 0x00133E64 File Offset: 0x00132064
		static ConfigPhantomBattleCardSlotSortAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardSlotSortAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardSlotSortAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00133E84 File Offset: 0x00132084
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

		// Token: 0x0600269A RID: 9882 RVA: 0x00133F03 File Offset: 0x00132103
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardSlotSortAll.LogPair = null;
			ConfigPhantomBattleCardSlotSortAll.HandleId = 0;
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00133F11 File Offset: 0x00132111
		public static void Init()
		{
			ConfigPhantomBattleCardSlotSortAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardSlotSortAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardSlotSort`");
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00133F2C File Offset: 0x0013212C
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

		// Token: 0x04002CDA RID: 11482
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CDB RID: 11483
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CDC RID: 11484
		private const string TABLE = "PhantomBattleCardSlotSort";

		// Token: 0x04002CDD RID: 11485
		private const string COMMAND = "select BinData from `PhantomBattleCardSlotSort`";

		// Token: 0x04002CDE RID: 11486
		private const string KEY_PREFIX = "PhantomBattleCardSlotSortAll";

		// Token: 0x04002CDF RID: 11487
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CE0 RID: 11488
		private static int HandleId;
	}
}
