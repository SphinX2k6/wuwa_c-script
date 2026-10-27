using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000676 RID: 1654
	public class ConfigPhantomBattleFactorAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026D4 RID: 9940 RVA: 0x00135498 File Offset: 0x00133698
		static ConfigPhantomBattleFactorAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleFactorAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleFactorAll.ResetStaticDefaultValue));
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x001354B8 File Offset: 0x001336B8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleFactorAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleFactorAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战战斗.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleFactor"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleFactor`")
			});
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00135537 File Offset: 0x00133737
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleFactorAll.LogPair = null;
			ConfigPhantomBattleFactorAll.HandleId = 0;
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00135545 File Offset: 0x00133745
		public static void Init()
		{
			ConfigPhantomBattleFactorAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleFactorAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleFactor`");
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00135560 File Offset: 0x00133760
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleFactor> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleFactorAll.HandleId, ConfigPhantomBattleFactorAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleFactor> readOnlyList = (IReadOnlyList<PhantomBattleFactor>)ConfigCommon.GetConfig("PhantomBattleFactorAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleFactor> list = new List<PhantomBattleFactor>();
			while (ConfigCommon.Step(ConfigPhantomBattleFactorAll.HandleId, false, ConfigPhantomBattleFactorAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleFactorAll.HandleId, 0, ConfigPhantomBattleFactorAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleFactorAll.HandleId, ConfigPhantomBattleFactorAll.LogPair);
					return null;
				}
				PhantomBattleFactor rootAsPhantomBattleFactor = PhantomBattleFactor.GetRootAsPhantomBattleFactor(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleFactor);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleFactorAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleFactorAll.HandleId, ConfigPhantomBattleFactorAll.LogPair);
			return list;
		}

		// Token: 0x04002D20 RID: 11552
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D21 RID: 11553
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002D22 RID: 11554
		private const string TABLE = "PhantomBattleFactor";

		// Token: 0x04002D23 RID: 11555
		private const string COMMAND = "select BinData from `PhantomBattleFactor`";

		// Token: 0x04002D24 RID: 11556
		private const string KEY_PREFIX = "PhantomBattleFactorAll";

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
