using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AC RID: 2220
	public class ConfigRoleInfluenceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600341B RID: 13339 RVA: 0x0017FCF9 File Offset: 0x0017DEF9
		static ConfigRoleInfluenceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfluenceAll.CreateStaticDefaultValue), new Action(ConfigRoleInfluenceAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x0017FD18 File Offset: 0x0017DF18
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

		// Token: 0x0600341D RID: 13341 RVA: 0x0017FD97 File Offset: 0x0017DF97
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfluenceAll.LogPair = null;
			ConfigRoleInfluenceAll.HandleId = 0;
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x0017FDA5 File Offset: 0x0017DFA5
		public static void Init()
		{
			ConfigRoleInfluenceAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfluenceAll.HandleId, "db_roleinfluence.db", "select BinData from `RoleInfluence`");
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x0017FDC0 File Offset: 0x0017DFC0
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

		// Token: 0x04003C9A RID: 15514
		private const string DB = "db_roleinfluence.db";

		// Token: 0x04003C9B RID: 15515
		private const string FILE = "j.角色势力.xlsx";

		// Token: 0x04003C9C RID: 15516
		private const string TABLE = "RoleInfluence";

		// Token: 0x04003C9D RID: 15517
		private const string COMMAND = "select BinData from `RoleInfluence`";

		// Token: 0x04003C9E RID: 15518
		private const string KEY_PREFIX = "RoleInfluenceAll";

		// Token: 0x04003C9F RID: 15519
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CA0 RID: 15520
		private static int HandleId;
	}
}
