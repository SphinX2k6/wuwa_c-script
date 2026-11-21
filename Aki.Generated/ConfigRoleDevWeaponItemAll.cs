using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BE RID: 2238
	public class ConfigRoleDevWeaponItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003486 RID: 13446 RVA: 0x00185A14 File Offset: 0x00183C14
		static ConfigRoleDevWeaponItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevWeaponItemAll.CreateStaticDefaultValue), new Action(ConfigRoleDevWeaponItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x00185A34 File Offset: 0x00183C34
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevWeaponItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevWeaponItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevWeaponItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevWeaponItem`")
			});
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00185AB3 File Offset: 0x00183CB3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevWeaponItemAll.LogPair = null;
			ConfigRoleDevWeaponItemAll.HandleId = 0;
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x00185AC1 File Offset: 0x00183CC1
		public static void Init()
		{
			ConfigRoleDevWeaponItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevWeaponItemAll.HandleId, "db_roledev.db", "select BinData from `RoleDevWeaponItem`");
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x00185ADC File Offset: 0x00183CDC
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevWeaponItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevWeaponItemAll.HandleId, ConfigRoleDevWeaponItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevWeaponItem> readOnlyList = (IReadOnlyList<RoleDevWeaponItem>)ConfigCommon.GetConfig("RoleDevWeaponItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevWeaponItem> list = new List<RoleDevWeaponItem>();
			while (ConfigCommon.Step(ConfigRoleDevWeaponItemAll.HandleId, false, ConfigRoleDevWeaponItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevWeaponItemAll.HandleId, 0, ConfigRoleDevWeaponItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevWeaponItemAll.HandleId, ConfigRoleDevWeaponItemAll.LogPair);
					return null;
				}
				RoleDevWeaponItem rootAsRoleDevWeaponItem = RoleDevWeaponItem.GetRootAsRoleDevWeaponItem(new ByteBuffer(item2));
				list.Add(rootAsRoleDevWeaponItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevWeaponItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevWeaponItemAll.HandleId, ConfigRoleDevWeaponItemAll.LogPair);
			return list;
		}

		// Token: 0x04003D18 RID: 15640
		private const string DB = "db_roledev.db";

		// Token: 0x04003D19 RID: 15641
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003D1A RID: 15642
		private const string TABLE = "RoleDevWeaponItem";

		// Token: 0x04003D1B RID: 15643
		private const string COMMAND = "select BinData from `RoleDevWeaponItem`";

		// Token: 0x04003D1C RID: 15644
		private const string KEY_PREFIX = "RoleDevWeaponItemAll";

		// Token: 0x04003D1D RID: 15645
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D1E RID: 15646
		private static int HandleId;
	}
}
