using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000669 RID: 1641
	public class ConfigPhantomBattleCardRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002686 RID: 9862 RVA: 0x00133850 File Offset: 0x00131A50
		static ConfigPhantomBattleCardRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRoleAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00133870 File Offset: 0x00131A70
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

		// Token: 0x06002688 RID: 9864 RVA: 0x001338EF File Offset: 0x00131AEF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRoleAll.LogPair = null;
			ConfigPhantomBattleCardRoleAll.HandleId = 0;
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x001338FD File Offset: 0x00131AFD
		public static void Init()
		{
			ConfigPhantomBattleCardRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRoleAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardRole`");
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00133918 File Offset: 0x00131B18
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

		// Token: 0x04002CC5 RID: 11461
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CC6 RID: 11462
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CC7 RID: 11463
		private const string TABLE = "PhantomBattleCardRole";

		// Token: 0x04002CC8 RID: 11464
		private const string COMMAND = "select BinData from `PhantomBattleCardRole`";

		// Token: 0x04002CC9 RID: 11465
		private const string KEY_PREFIX = "PhantomBattleCardRoleAll";

		// Token: 0x04002CCA RID: 11466
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CCB RID: 11467
		private static int HandleId;
	}
}
