using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B2 RID: 2226
	public class ConfigRoleDevItemJumpGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600343E RID: 13374 RVA: 0x001842EC File Offset: 0x001824EC
		static ConfigRoleDevItemJumpGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevItemJumpGroupAll.CreateStaticDefaultValue), new Action(ConfigRoleDevItemJumpGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x0018430C File Offset: 0x0018250C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevItemJumpGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevItemJumpGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevItemJumpGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevItemJumpGroup`")
			});
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x0018438B File Offset: 0x0018258B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevItemJumpGroupAll.LogPair = null;
			ConfigRoleDevItemJumpGroupAll.HandleId = 0;
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00184399 File Offset: 0x00182599
		public static void Init()
		{
			ConfigRoleDevItemJumpGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevItemJumpGroupAll.HandleId, "db_roledev.db", "select BinData from `RoleDevItemJumpGroup`");
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x001843B4 File Offset: 0x001825B4
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevItemJumpGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevItemJumpGroupAll.HandleId, ConfigRoleDevItemJumpGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevItemJumpGroup> readOnlyList = (IReadOnlyList<RoleDevItemJumpGroup>)ConfigCommon.GetConfig("RoleDevItemJumpGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevItemJumpGroup> list = new List<RoleDevItemJumpGroup>();
			while (ConfigCommon.Step(ConfigRoleDevItemJumpGroupAll.HandleId, false, ConfigRoleDevItemJumpGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevItemJumpGroupAll.HandleId, 0, ConfigRoleDevItemJumpGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevItemJumpGroupAll.HandleId, ConfigRoleDevItemJumpGroupAll.LogPair);
					return null;
				}
				RoleDevItemJumpGroup rootAsRoleDevItemJumpGroup = RoleDevItemJumpGroup.GetRootAsRoleDevItemJumpGroup(new ByteBuffer(item2));
				list.Add(rootAsRoleDevItemJumpGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevItemJumpGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevItemJumpGroupAll.HandleId, ConfigRoleDevItemJumpGroupAll.LogPair);
			return list;
		}

		// Token: 0x04003CC4 RID: 15556
		private const string DB = "db_roledev.db";

		// Token: 0x04003CC5 RID: 15557
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CC6 RID: 15558
		private const string TABLE = "RoleDevItemJumpGroup";

		// Token: 0x04003CC7 RID: 15559
		private const string COMMAND = "select BinData from `RoleDevItemJumpGroup`";

		// Token: 0x04003CC8 RID: 15560
		private const string KEY_PREFIX = "RoleDevItemJumpGroupAll";

		// Token: 0x04003CC9 RID: 15561
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CCA RID: 15562
		private static int HandleId;
	}
}
