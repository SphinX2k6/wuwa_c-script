using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BC RID: 2236
	public class ConfigRoleDevTypeManageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600347A RID: 13434 RVA: 0x00185638 File Offset: 0x00183838
		static ConfigRoleDevTypeManageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevTypeManageAll.CreateStaticDefaultValue), new Action(ConfigRoleDevTypeManageAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00185658 File Offset: 0x00183858
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevTypeManageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevTypeManageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevTypeManage"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevTypeManage`")
			});
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x001856D7 File Offset: 0x001838D7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevTypeManageAll.LogPair = null;
			ConfigRoleDevTypeManageAll.HandleId = 0;
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x001856E5 File Offset: 0x001838E5
		public static void Init()
		{
			ConfigRoleDevTypeManageAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevTypeManageAll.HandleId, "db_roledev.db", "select BinData from `RoleDevTypeManage`");
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00185700 File Offset: 0x00183900
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevTypeManage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevTypeManageAll.HandleId, ConfigRoleDevTypeManageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevTypeManage> readOnlyList = (IReadOnlyList<RoleDevTypeManage>)ConfigCommon.GetConfig("RoleDevTypeManageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevTypeManage> list = new List<RoleDevTypeManage>();
			while (ConfigCommon.Step(ConfigRoleDevTypeManageAll.HandleId, false, ConfigRoleDevTypeManageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevTypeManageAll.HandleId, 0, ConfigRoleDevTypeManageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevTypeManageAll.HandleId, ConfigRoleDevTypeManageAll.LogPair);
					return null;
				}
				RoleDevTypeManage rootAsRoleDevTypeManage = RoleDevTypeManage.GetRootAsRoleDevTypeManage(new ByteBuffer(item2));
				list.Add(rootAsRoleDevTypeManage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevTypeManageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevTypeManageAll.HandleId, ConfigRoleDevTypeManageAll.LogPair);
			return list;
		}

		// Token: 0x04003D0A RID: 15626
		private const string DB = "db_roledev.db";

		// Token: 0x04003D0B RID: 15627
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003D0C RID: 15628
		private const string TABLE = "RoleDevTypeManage";

		// Token: 0x04003D0D RID: 15629
		private const string COMMAND = "select BinData from `RoleDevTypeManage`";

		// Token: 0x04003D0E RID: 15630
		private const string KEY_PREFIX = "RoleDevTypeManageAll";

		// Token: 0x04003D0F RID: 15631
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D10 RID: 15632
		private static int HandleId;
	}
}
