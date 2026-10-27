using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089B RID: 2203
	public class ConfigRoleDevPhantomJumpGroupByPhantomId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033B4 RID: 13236 RVA: 0x0017D94F File Offset: 0x0017BB4F
		static ConfigRoleDevPhantomJumpGroupByPhantomId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevPhantomJumpGroupByPhantomId.CreateStaticDefaultValue), new Action(ConfigRoleDevPhantomJumpGroupByPhantomId.ResetStaticDefaultValue));
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x0017D970 File Offset: 0x0017BB70
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevPhantomJumpGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevPhantomJumpGroup` where PhantomId=?")
			});
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x0017D9EF File Offset: 0x0017BBEF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair = null;
			ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId = 0;
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x0017D9FD File Offset: 0x0017BBFD
		public static void Init()
		{
			ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, "db_roledev.db", "select BinData from `RoleDevPhantomJumpGroup` where PhantomId=?");
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x0017DA18 File Offset: 0x0017BC18
		public static RoleDevPhantomJumpGroup? GetConfig(int p0PhantomId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevPhantomJumpGroupByPhantomId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PhantomId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevPhantomJumpGroup?(RoleDevPhantomJumpGroup.GetRootAsRoleDevPhantomJumpGroup(configBuffer));
				}
			}
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair.Clear();
			ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair.Add(new ValueTuple<string, object>("PhantomId", p0PhantomId));
			if (!ConfigCommon.BindInt(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, 1, p0PhantomId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair) || ConfigCommon.Step(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, true, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, 0, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevPhantomJumpGroup rootAsRoleDevPhantomJumpGroup = RoleDevPhantomJumpGroup.GetRootAsRoleDevPhantomJumpGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevPhantomJumpGroupByPhantomId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PhantomId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevPhantomJumpGroupByPhantomId.HandleId, ConfigRoleDevPhantomJumpGroupByPhantomId.LogPair);
			return new RoleDevPhantomJumpGroup?(rootAsRoleDevPhantomJumpGroup);
		}

		// Token: 0x04003C23 RID: 15395
		private const string DB = "db_roledev.db";

		// Token: 0x04003C24 RID: 15396
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C25 RID: 15397
		private const string TABLE = "RoleDevPhantomJumpGroup";

		// Token: 0x04003C26 RID: 15398
		private const string COMMAND = "select BinData from `RoleDevPhantomJumpGroup` where PhantomId=?";

		// Token: 0x04003C27 RID: 15399
		private const string KEY_PREFIX = "RoleDevPhantomJumpGroupByPhantomId";

		// Token: 0x04003C28 RID: 15400
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C29 RID: 15401
		private static int HandleId;
	}
}
