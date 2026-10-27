using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065E RID: 1630
	public class ConfigPhantomBattleCardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002644 RID: 9796 RVA: 0x001320D0 File Offset: 0x001302D0
		static ConfigPhantomBattleCardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x001320F0 File Offset: 0x001302F0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCard"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCard`")
			});
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x0013216F File Offset: 0x0013036F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardAll.LogPair = null;
			ConfigPhantomBattleCardAll.HandleId = 0;
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x0013217D File Offset: 0x0013037D
		public static void Init()
		{
			ConfigPhantomBattleCardAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCard`");
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00132198 File Offset: 0x00130398
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleCard> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardAll.HandleId, ConfigPhantomBattleCardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleCard> readOnlyList = (IReadOnlyList<PhantomBattleCard>)ConfigCommon.GetConfig("PhantomBattleCardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleCard> list = new List<PhantomBattleCard>();
			while (ConfigCommon.Step(ConfigPhantomBattleCardAll.HandleId, false, ConfigPhantomBattleCardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardAll.HandleId, 0, ConfigPhantomBattleCardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleCardAll.HandleId, ConfigPhantomBattleCardAll.LogPair);
					return null;
				}
				PhantomBattleCard rootAsPhantomBattleCard = PhantomBattleCard.GetRootAsPhantomBattleCard(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleCard);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleCardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardAll.HandleId, ConfigPhantomBattleCardAll.LogPair);
			return list;
		}

		// Token: 0x04002C78 RID: 11384
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C79 RID: 11385
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C7A RID: 11386
		private const string TABLE = "PhantomBattleCard";

		// Token: 0x04002C7B RID: 11387
		private const string COMMAND = "select BinData from `PhantomBattleCard`";

		// Token: 0x04002C7C RID: 11388
		private const string KEY_PREFIX = "PhantomBattleCardAll";

		// Token: 0x04002C7D RID: 11389
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C7E RID: 11390
		private static int HandleId;
	}
}
