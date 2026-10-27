using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089A RID: 2202
	public class ConfigRoleDevPhantomJumpGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033AE RID: 13230 RVA: 0x0017D7BC File Offset: 0x0017B9BC
		static ConfigRoleDevPhantomJumpGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevPhantomJumpGroupAll.CreateStaticDefaultValue), new Action(ConfigRoleDevPhantomJumpGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x0017D7DC File Offset: 0x0017B9DC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevPhantomJumpGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevPhantomJumpGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevPhantomJumpGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevPhantomJumpGroup`")
			});
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0017D85B File Offset: 0x0017BA5B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevPhantomJumpGroupAll.LogPair = null;
			ConfigRoleDevPhantomJumpGroupAll.HandleId = 0;
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x0017D869 File Offset: 0x0017BA69
		public static void Init()
		{
			ConfigRoleDevPhantomJumpGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevPhantomJumpGroupAll.HandleId, "db_roledev.db", "select BinData from `RoleDevPhantomJumpGroup`");
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x0017D884 File Offset: 0x0017BA84
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevPhantomJumpGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevPhantomJumpGroupAll.HandleId, ConfigRoleDevPhantomJumpGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevPhantomJumpGroup> readOnlyList = (IReadOnlyList<RoleDevPhantomJumpGroup>)ConfigCommon.GetConfig("RoleDevPhantomJumpGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevPhantomJumpGroup> list = new List<RoleDevPhantomJumpGroup>();
			while (ConfigCommon.Step(ConfigRoleDevPhantomJumpGroupAll.HandleId, false, ConfigRoleDevPhantomJumpGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevPhantomJumpGroupAll.HandleId, 0, ConfigRoleDevPhantomJumpGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevPhantomJumpGroupAll.HandleId, ConfigRoleDevPhantomJumpGroupAll.LogPair);
					return null;
				}
				RoleDevPhantomJumpGroup rootAsRoleDevPhantomJumpGroup = RoleDevPhantomJumpGroup.GetRootAsRoleDevPhantomJumpGroup(new ByteBuffer(item2));
				list.Add(rootAsRoleDevPhantomJumpGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevPhantomJumpGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevPhantomJumpGroupAll.HandleId, ConfigRoleDevPhantomJumpGroupAll.LogPair);
			return list;
		}

		// Token: 0x04003C1C RID: 15388
		private const string DB = "db_roledev.db";

		// Token: 0x04003C1D RID: 15389
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C1E RID: 15390
		private const string TABLE = "RoleDevPhantomJumpGroup";

		// Token: 0x04003C1F RID: 15391
		private const string COMMAND = "select BinData from `RoleDevPhantomJumpGroup`";

		// Token: 0x04003C20 RID: 15392
		private const string KEY_PREFIX = "RoleDevPhantomJumpGroupAll";

		// Token: 0x04003C21 RID: 15393
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C22 RID: 15394
		private static int HandleId;
	}
}
