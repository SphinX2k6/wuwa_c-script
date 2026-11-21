using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000681 RID: 1665
	public class ConfigPhantomBattleCardRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002716 RID: 10006 RVA: 0x0013A2CC File Offset: 0x001384CC
		static ConfigPhantomBattleCardRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRoleAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x0013A2EC File Offset: 0x001384EC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardRole"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardRole`")
			});
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x0013A36B File Offset: 0x0013856B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRoleAll.LogPair = null;
			ConfigPhantomBattleCardRoleAll.HandleId = 0;
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x0013A379 File Offset: 0x00138579
		public static void Init()
		{
			ConfigPhantomBattleCardRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRoleAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardRole`");
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x0013A394 File Offset: 0x00138594
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleCardRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardRoleAll.HandleId, ConfigPhantomBattleCardRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleCardRole> readOnlyList = (IReadOnlyList<PhantomBattleCardRole>)ConfigCommon.GetConfig("PhantomBattleCardRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleCardRole> list = new List<PhantomBattleCardRole>();
			while (ConfigCommon.Step(ConfigPhantomBattleCardRoleAll.HandleId, false, ConfigPhantomBattleCardRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardRoleAll.HandleId, 0, ConfigPhantomBattleCardRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleCardRoleAll.HandleId, ConfigPhantomBattleCardRoleAll.LogPair);
					return null;
				}
				PhantomBattleCardRole rootAsPhantomBattleCardRole = PhantomBattleCardRole.GetRootAsPhantomBattleCardRole(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleCardRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleCardRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardRoleAll.HandleId, ConfigPhantomBattleCardRoleAll.LogPair);
			return list;
		}

		// Token: 0x04002D6D RID: 11629
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D6E RID: 11630
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D6F RID: 11631
		private const string TABLE = "PhantomBattleCardRole";

		// Token: 0x04002D70 RID: 11632
		private const string COMMAND = "select BinData from `PhantomBattleCardRole`";

		// Token: 0x04002D71 RID: 11633
		private const string KEY_PREFIX = "PhantomBattleCardRoleAll";

		// Token: 0x04002D72 RID: 11634
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D73 RID: 11635
		private static int HandleId;
	}
}
