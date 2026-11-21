using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000676 RID: 1654
	public class ConfigPhantomBattleCardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026D4 RID: 9940 RVA: 0x00138B4C File Offset: 0x00136D4C
		static ConfigPhantomBattleCardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00138B6C File Offset: 0x00136D6C
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

		// Token: 0x060026D6 RID: 9942 RVA: 0x00138BEB File Offset: 0x00136DEB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardAll.LogPair = null;
			ConfigPhantomBattleCardAll.HandleId = 0;
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00138BF9 File Offset: 0x00136DF9
		public static void Init()
		{
			ConfigPhantomBattleCardAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCard`");
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00138C14 File Offset: 0x00136E14
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

		// Token: 0x04002D20 RID: 11552
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D21 RID: 11553
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D22 RID: 11554
		private const string TABLE = "PhantomBattleCard";

		// Token: 0x04002D23 RID: 11555
		private const string COMMAND = "select BinData from `PhantomBattleCard`";

		// Token: 0x04002D24 RID: 11556
		private const string KEY_PREFIX = "PhantomBattleCardAll";

		// Token: 0x04002D25 RID: 11557
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D26 RID: 11558
		private static int HandleId;
	}
}
