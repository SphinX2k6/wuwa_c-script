using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AB RID: 2219
	public class ConfigRoleIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003415 RID: 13333 RVA: 0x0017FB00 File Offset: 0x0017DD00
		static ConfigRoleIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleIconTagById.CreateStaticDefaultValue), new Action(ConfigRoleIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x0017FB20 File Offset: 0x0017DD20
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

		// Token: 0x06003417 RID: 13335 RVA: 0x0017FB9F File Offset: 0x0017DD9F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleIconTagById.LogPair = null;
			ConfigRoleIconTagById.HandleId = 0;
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x0017FBAD File Offset: 0x0017DDAD
		public static void Init()
		{
			ConfigRoleIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleIconTagById.HandleId, "db_component_config.db", "select BinData from `RoleIconTag` where Id=?");
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x0017FBC8 File Offset: 0x0017DDC8
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

		// Token: 0x04003C93 RID: 15507
		private const string DB = "db_component_config.db";

		// Token: 0x04003C94 RID: 15508
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x04003C95 RID: 15509
		private const string TABLE = "RoleIconTag";

		// Token: 0x04003C96 RID: 15510
		private const string COMMAND = "select BinData from `RoleIconTag` where Id=?";

		// Token: 0x04003C97 RID: 15511
		private const string KEY_PREFIX = "RoleIconTagById";

		// Token: 0x04003C98 RID: 15512
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C99 RID: 15513
		private static int HandleId;
	}
}
