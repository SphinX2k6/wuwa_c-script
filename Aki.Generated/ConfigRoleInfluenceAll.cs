using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C8 RID: 2248
	public class ConfigRoleInfluenceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034C3 RID: 13507 RVA: 0x00186FE1 File Offset: 0x001851E1
		static ConfigRoleInfluenceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfluenceAll.CreateStaticDefaultValue), new Action(ConfigRoleInfluenceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00187000 File Offset: 0x00185200
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfluenceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfluenceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleinfluence.db"),
				new ValueTuple<string, object>("文件", "j.角色势力.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfluence"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfluence`")
			});
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x0018707F File Offset: 0x0018527F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfluenceAll.LogPair = null;
			ConfigRoleInfluenceAll.HandleId = 0;
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x0018708D File Offset: 0x0018528D
		public static void Init()
		{
			ConfigRoleInfluenceAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfluenceAll.HandleId, "db_roleinfluence.db", "select BinData from `RoleInfluence`");
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x001870A8 File Offset: 0x001852A8
		[NullableContext(2)]
		public static IReadOnlyList<RoleInfluence> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfluenceAll.HandleId, ConfigRoleInfluenceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleInfluence> readOnlyList = (IReadOnlyList<RoleInfluence>)ConfigCommon.GetConfig("RoleInfluenceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleInfluence> list = new List<RoleInfluence>();
			while (ConfigCommon.Step(ConfigRoleInfluenceAll.HandleId, false, ConfigRoleInfluenceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfluenceAll.HandleId, 0, ConfigRoleInfluenceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleInfluenceAll.HandleId, ConfigRoleInfluenceAll.LogPair);
					return null;
				}
				RoleInfluence rootAsRoleInfluence = RoleInfluence.GetRootAsRoleInfluence(new ByteBuffer(item2));
				list.Add(rootAsRoleInfluence);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleInfluenceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleInfluenceAll.HandleId, ConfigRoleInfluenceAll.LogPair);
			return list;
		}

		// Token: 0x04003D5E RID: 15710
		private const string DB = "db_roleinfluence.db";

		// Token: 0x04003D5F RID: 15711
		private const string FILE = "j.角色势力.xlsx";

		// Token: 0x04003D60 RID: 15712
		private const string TABLE = "RoleInfluence";

		// Token: 0x04003D61 RID: 15713
		private const string COMMAND = "select BinData from `RoleInfluence`";

		// Token: 0x04003D62 RID: 15714
		private const string KEY_PREFIX = "RoleInfluenceAll";

		// Token: 0x04003D63 RID: 15715
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D64 RID: 15716
		private static int HandleId;
	}
}
