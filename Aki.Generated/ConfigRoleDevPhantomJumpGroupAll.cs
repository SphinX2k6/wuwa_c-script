using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B6 RID: 2230
	public class ConfigRoleDevPhantomJumpGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003456 RID: 13398 RVA: 0x00184AA4 File Offset: 0x00182CA4
		static ConfigRoleDevPhantomJumpGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevPhantomJumpGroupAll.CreateStaticDefaultValue), new Action(ConfigRoleDevPhantomJumpGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00184AC4 File Offset: 0x00182CC4
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

		// Token: 0x06003458 RID: 13400 RVA: 0x00184B43 File Offset: 0x00182D43
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevPhantomJumpGroupAll.LogPair = null;
			ConfigRoleDevPhantomJumpGroupAll.HandleId = 0;
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00184B51 File Offset: 0x00182D51
		public static void Init()
		{
			ConfigRoleDevPhantomJumpGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevPhantomJumpGroupAll.HandleId, "db_roledev.db", "select BinData from `RoleDevPhantomJumpGroup`");
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00184B6C File Offset: 0x00182D6C
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

		// Token: 0x04003CE0 RID: 15584
		private const string DB = "db_roledev.db";

		// Token: 0x04003CE1 RID: 15585
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CE2 RID: 15586
		private const string TABLE = "RoleDevPhantomJumpGroup";

		// Token: 0x04003CE3 RID: 15587
		private const string COMMAND = "select BinData from `RoleDevPhantomJumpGroup`";

		// Token: 0x04003CE4 RID: 15588
		private const string KEY_PREFIX = "RoleDevPhantomJumpGroupAll";

		// Token: 0x04003CE5 RID: 15589
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CE6 RID: 15590
		private static int HandleId;
	}
}
