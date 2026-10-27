using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000886 RID: 2182
	public class ConfigRoleBattleViewInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003336 RID: 13110 RVA: 0x0017AF24 File Offset: 0x00179124
		static ConfigRoleBattleViewInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBattleViewInfoAll.CreateStaticDefaultValue), new Action(ConfigRoleBattleViewInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x0017AF44 File Offset: 0x00179144
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBattleViewInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBattleViewInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role_battle_view.db"),
				new ValueTuple<string, object>("文件", "j.角色战斗界面布局.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBattleViewInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBattleViewInfo`")
			});
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x0017AFC3 File Offset: 0x001791C3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBattleViewInfoAll.LogPair = null;
			ConfigRoleBattleViewInfoAll.HandleId = 0;
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x0017AFD1 File Offset: 0x001791D1
		public static void Init()
		{
			ConfigRoleBattleViewInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBattleViewInfoAll.HandleId, "db_role_battle_view.db", "select BinData from `RoleBattleViewInfo`");
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x0017AFEC File Offset: 0x001791EC
		[NullableContext(2)]
		public static IReadOnlyList<RoleBattleViewInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBattleViewInfoAll.HandleId, ConfigRoleBattleViewInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleBattleViewInfo> readOnlyList = (IReadOnlyList<RoleBattleViewInfo>)ConfigCommon.GetConfig("RoleBattleViewInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleBattleViewInfo> list = new List<RoleBattleViewInfo>();
			while (ConfigCommon.Step(ConfigRoleBattleViewInfoAll.HandleId, false, ConfigRoleBattleViewInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBattleViewInfoAll.HandleId, 0, ConfigRoleBattleViewInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleBattleViewInfoAll.HandleId, ConfigRoleBattleViewInfoAll.LogPair);
					return null;
				}
				RoleBattleViewInfo rootAsRoleBattleViewInfo = RoleBattleViewInfo.GetRootAsRoleBattleViewInfo(new ByteBuffer(item2));
				list.Add(rootAsRoleBattleViewInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleBattleViewInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleBattleViewInfoAll.HandleId, ConfigRoleBattleViewInfoAll.LogPair);
			return list;
		}

		// Token: 0x04003B90 RID: 15248
		private const string DB = "db_role_battle_view.db";

		// Token: 0x04003B91 RID: 15249
		private const string FILE = "j.角色战斗界面布局.xlsx";

		// Token: 0x04003B92 RID: 15250
		private const string TABLE = "RoleBattleViewInfo";

		// Token: 0x04003B93 RID: 15251
		private const string COMMAND = "select BinData from `RoleBattleViewInfo`";

		// Token: 0x04003B94 RID: 15252
		private const string KEY_PREFIX = "RoleBattleViewInfoAll";

		// Token: 0x04003B95 RID: 15253
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B96 RID: 15254
		private static int HandleId;
	}
}
