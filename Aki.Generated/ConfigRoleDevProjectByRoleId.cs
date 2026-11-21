using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B9 RID: 2233
	public class ConfigRoleDevProjectByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003468 RID: 13416 RVA: 0x00185013 File Offset: 0x00183213
		static ConfigRoleDevProjectByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevProjectByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleDevProjectByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x00185034 File Offset: 0x00183234
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

		// Token: 0x0600346A RID: 13418 RVA: 0x001850B3 File Offset: 0x001832B3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevProjectByRoleId.LogPair = null;
			ConfigRoleDevProjectByRoleId.HandleId = 0;
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x001850C1 File Offset: 0x001832C1
		public static void Init()
		{
			ConfigRoleDevProjectByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevProjectByRoleId.HandleId, "db_roledev.db", "select BinData from `RoleDevProject` where RoleId=?");
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x001850DC File Offset: 0x001832DC
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

		// Token: 0x04003CF5 RID: 15605
		private const string DB = "db_roledev.db";

		// Token: 0x04003CF6 RID: 15606
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CF7 RID: 15607
		private const string TABLE = "RoleDevProject";

		// Token: 0x04003CF8 RID: 15608
		private const string COMMAND = "select BinData from `RoleDevProject` where RoleId=?";

		// Token: 0x04003CF9 RID: 15609
		private const string KEY_PREFIX = "RoleDevProjectByRoleId";

		// Token: 0x04003CFA RID: 15610
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CFB RID: 15611
		private static int HandleId;
	}
}
