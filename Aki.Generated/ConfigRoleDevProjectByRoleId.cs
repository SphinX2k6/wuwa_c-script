using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089D RID: 2205
	public class ConfigRoleDevProjectByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033C0 RID: 13248 RVA: 0x0017DD2B File Offset: 0x0017BF2B
		static ConfigRoleDevProjectByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevProjectByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleDevProjectByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x0017DD4C File Offset: 0x0017BF4C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevProjectByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevProjectByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevProject"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevProject` where RoleId=?")
			});
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x0017DDCB File Offset: 0x0017BFCB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevProjectByRoleId.LogPair = null;
			ConfigRoleDevProjectByRoleId.HandleId = 0;
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x0017DDD9 File Offset: 0x0017BFD9
		public static void Init()
		{
			ConfigRoleDevProjectByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevProjectByRoleId.HandleId, "db_roledev.db", "select BinData from `RoleDevProject` where RoleId=?");
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x0017DDF4 File Offset: 0x0017BFF4
		public static RoleDevProject? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevProjectByRoleId.HandleId, ConfigRoleDevProjectByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevProjectByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevProject?(RoleDevProject.GetRootAsRoleDevProject(configBuffer));
				}
			}
			ConfigRoleDevProjectByRoleId.LogPair.Clear();
			ConfigRoleDevProjectByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleDevProjectByRoleId.HandleId, 1, p0RoleId, ConfigRoleDevProjectByRoleId.LogPair) || ConfigCommon.Step(ConfigRoleDevProjectByRoleId.HandleId, true, ConfigRoleDevProjectByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevProjectByRoleId.HandleId, ConfigRoleDevProjectByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevProjectByRoleId.HandleId, 0, ConfigRoleDevProjectByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevProjectByRoleId.HandleId, ConfigRoleDevProjectByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevProject rootAsRoleDevProject = RoleDevProject.GetRootAsRoleDevProject(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevProjectByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevProjectByRoleId.HandleId, ConfigRoleDevProjectByRoleId.LogPair);
			return new RoleDevProject?(rootAsRoleDevProject);
		}

		// Token: 0x04003C31 RID: 15409
		private const string DB = "db_roledev.db";

		// Token: 0x04003C32 RID: 15410
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C33 RID: 15411
		private const string TABLE = "RoleDevProject";

		// Token: 0x04003C34 RID: 15412
		private const string COMMAND = "select BinData from `RoleDevProject` where RoleId=?";

		// Token: 0x04003C35 RID: 15413
		private const string KEY_PREFIX = "RoleDevProjectByRoleId";

		// Token: 0x04003C36 RID: 15414
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C37 RID: 15415
		private static int HandleId;
	}
}
