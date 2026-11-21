using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C7 RID: 2247
	public class ConfigRoleIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034BD RID: 13501 RVA: 0x00186DE8 File Offset: 0x00184FE8
		static ConfigRoleIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleIconTagById.CreateStaticDefaultValue), new Action(ConfigRoleIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00186E08 File Offset: 0x00185008
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleIconTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleIconTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_component_config.db"),
				new ValueTuple<string, object>("文件", "t.通用组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "RoleIconTag"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleIconTag` where Id=?")
			});
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00186E87 File Offset: 0x00185087
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleIconTagById.LogPair = null;
			ConfigRoleIconTagById.HandleId = 0;
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00186E95 File Offset: 0x00185095
		public static void Init()
		{
			ConfigRoleIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleIconTagById.HandleId, "db_component_config.db", "select BinData from `RoleIconTag` where Id=?");
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00186EB0 File Offset: 0x001850B0
		public static RoleIconTag? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleIconTagById.HandleId, ConfigRoleIconTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("RoleIconTagById#" + p0Id);
				if (configBuffer != null)
				{
					return new RoleIconTag?(RoleIconTag.GetRootAsRoleIconTag(configBuffer));
				}
			}
			ConfigRoleIconTagById.LogPair.Clear();
			ConfigRoleIconTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigRoleIconTagById.HandleId, 1, p0Id, ConfigRoleIconTagById.LogPair) || ConfigCommon.Step(ConfigRoleIconTagById.HandleId, true, ConfigRoleIconTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleIconTagById.HandleId, ConfigRoleIconTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleIconTagById.HandleId, 0, ConfigRoleIconTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleIconTagById.HandleId, ConfigRoleIconTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleIconTag rootAsRoleIconTag = RoleIconTag.GetRootAsRoleIconTag(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("RoleIconTagById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleIconTagById.HandleId, ConfigRoleIconTagById.LogPair);
			return new RoleIconTag?(rootAsRoleIconTag);
		}

		// Token: 0x04003D57 RID: 15703
		private const string DB = "db_component_config.db";

		// Token: 0x04003D58 RID: 15704
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x04003D59 RID: 15705
		private const string TABLE = "RoleIconTag";

		// Token: 0x04003D5A RID: 15706
		private const string COMMAND = "select BinData from `RoleIconTag` where Id=?";

		// Token: 0x04003D5B RID: 15707
		private const string KEY_PREFIX = "RoleIconTagById";

		// Token: 0x04003D5C RID: 15708
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D5D RID: 15709
		private static int HandleId;
	}
}
