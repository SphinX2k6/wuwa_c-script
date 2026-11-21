using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068E RID: 1678
	public class ConfigPhantomBattleFactorAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002764 RID: 10084 RVA: 0x0013BF14 File Offset: 0x0013A114
		static ConfigPhantomBattleFactorAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleFactorAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleFactorAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x0013BF34 File Offset: 0x0013A134
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

		// Token: 0x06002766 RID: 10086 RVA: 0x0013BFB3 File Offset: 0x0013A1B3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleFactorAll.LogPair = null;
			ConfigPhantomBattleFactorAll.HandleId = 0;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0013BFC1 File Offset: 0x0013A1C1
		public static void Init()
		{
			ConfigPhantomBattleFactorAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleFactorAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleFactor`");
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0013BFDC File Offset: 0x0013A1DC
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

		// Token: 0x04002DC8 RID: 11720
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002DC9 RID: 11721
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002DCA RID: 11722
		private const string TABLE = "PhantomBattleFactor";

		// Token: 0x04002DCB RID: 11723
		private const string COMMAND = "select BinData from `PhantomBattleFactor`";

		// Token: 0x04002DCC RID: 11724
		private const string KEY_PREFIX = "PhantomBattleFactorAll";

		// Token: 0x04002DCD RID: 11725
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DCE RID: 11726
		private static int HandleId;
	}
}
