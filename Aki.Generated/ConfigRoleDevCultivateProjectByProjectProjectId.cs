using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AF RID: 2223
	public class ConfigRoleDevCultivateProjectByProjectProjectId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600342C RID: 13356 RVA: 0x00183C23 File Offset: 0x00181E23
		static ConfigRoleDevCultivateProjectByProjectProjectId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevCultivateProjectByProjectProjectId.CreateStaticDefaultValue), new Action(ConfigRoleDevCultivateProjectByProjectProjectId.ResetStaticDefaultValue));
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x00183C44 File Offset: 0x00181E44
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevCultivateProjectByProjectProjectId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevCultivateProjectByProjectProjectId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevCultivateProject"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevCultivateProject` where ProjectProjectId=?")
			});
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x00183CC3 File Offset: 0x00181EC3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevCultivateProjectByProjectProjectId.LogPair = null;
			ConfigRoleDevCultivateProjectByProjectProjectId.HandleId = 0;
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x00183CD1 File Offset: 0x00181ED1
		public static void Init()
		{
			ConfigRoleDevCultivateProjectByProjectProjectId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevCultivateProjectByProjectProjectId.HandleId, "db_roledev.db", "select BinData from `RoleDevCultivateProject` where ProjectProjectId=?");
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x00183CEC File Offset: 0x00181EEC
		public static RoleDevCultivateProject? GetConfig(int p0ProjectProjectId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevCultivateProjectByProjectProjectId.HandleId, ConfigRoleDevCultivateProjectByProjectProjectId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevCultivateProjectByProjectProjectId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ProjectProjectId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevCultivateProject?(RoleDevCultivateProject.GetRootAsRoleDevCultivateProject(configBuffer));
				}
			}
			ConfigRoleDevCultivateProjectByProjectProjectId.LogPair.Clear();
			ConfigRoleDevCultivateProjectByProjectProjectId.LogPair.Add(new ValueTuple<string, object>("ProjectProjectId", p0ProjectProjectId));
			if (!ConfigCommon.BindInt(ConfigRoleDevCultivateProjectByProjectProjectId.HandleId, 1, p0ProjectProjectId, ConfigRoleDevCultivateProjectByProjectProjectId.LogPair) || ConfigCommon.Step(ConfigRoleDevCultivateProjectByProjectProjectId.HandleId, true, ConfigRoleDevCultivateProjectByProjectProjectId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevCultivateProjectByProjectProjectId.HandleId, ConfigRoleDevCultivateProjectByProjectProjectId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevCultivateProjectByProjectProjectId.HandleId, 0, ConfigRoleDevCultivateProjectByProjectProjectId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevCultivateProjectByProjectProjectId.HandleId, ConfigRoleDevCultivateProjectByProjectProjectId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevCultivateProject rootAsRoleDevCultivateProject = RoleDevCultivateProject.GetRootAsRoleDevCultivateProject(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevCultivateProjectByProjectProjectId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ProjectProjectId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevCultivateProjectByProjectProjectId.HandleId, ConfigRoleDevCultivateProjectByProjectProjectId.LogPair);
			return new RoleDevCultivateProject?(rootAsRoleDevCultivateProject);
		}

		// Token: 0x04003CAF RID: 15535
		private const string DB = "db_roledev.db";

		// Token: 0x04003CB0 RID: 15536
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CB1 RID: 15537
		private const string TABLE = "RoleDevCultivateProject";

		// Token: 0x04003CB2 RID: 15538
		private const string COMMAND = "select BinData from `RoleDevCultivateProject` where ProjectProjectId=?";

		// Token: 0x04003CB3 RID: 15539
		private const string KEY_PREFIX = "RoleDevCultivateProjectByProjectProjectId";

		// Token: 0x04003CB4 RID: 15540
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CB5 RID: 15541
		private static int HandleId;
	}
}
