using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A2 RID: 2210
	public class ConfigRoleBattleViewInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033DE RID: 13278 RVA: 0x0018220C File Offset: 0x0018040C
		static ConfigRoleBattleViewInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBattleViewInfoAll.CreateStaticDefaultValue), new Action(ConfigRoleBattleViewInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0018222C File Offset: 0x0018042C
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

		// Token: 0x060033E0 RID: 13280 RVA: 0x001822AB File Offset: 0x001804AB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBattleViewInfoAll.LogPair = null;
			ConfigRoleBattleViewInfoAll.HandleId = 0;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x001822B9 File Offset: 0x001804B9
		public static void Init()
		{
			ConfigRoleBattleViewInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBattleViewInfoAll.HandleId, "db_role_battle_view.db", "select BinData from `RoleBattleViewInfo`");
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x001822D4 File Offset: 0x001804D4
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

		// Token: 0x04003C54 RID: 15444
		private const string DB = "db_role_battle_view.db";

		// Token: 0x04003C55 RID: 15445
		private const string FILE = "j.角色战斗界面布局.xlsx";

		// Token: 0x04003C56 RID: 15446
		private const string TABLE = "RoleBattleViewInfo";

		// Token: 0x04003C57 RID: 15447
		private const string COMMAND = "select BinData from `RoleBattleViewInfo`";

		// Token: 0x04003C58 RID: 15448
		private const string KEY_PREFIX = "RoleBattleViewInfoAll";

		// Token: 0x04003C59 RID: 15449
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C5A RID: 15450
		private static int HandleId;
	}
}
