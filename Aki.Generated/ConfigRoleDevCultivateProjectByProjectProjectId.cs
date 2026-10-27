using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000893 RID: 2195
	public class ConfigRoleDevCultivateProjectByProjectProjectId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003384 RID: 13188 RVA: 0x0017C93B File Offset: 0x0017AB3B
		static ConfigRoleDevCultivateProjectByProjectProjectId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevCultivateProjectByProjectProjectId.CreateStaticDefaultValue), new Action(ConfigRoleDevCultivateProjectByProjectProjectId.ResetStaticDefaultValue));
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x0017C95C File Offset: 0x0017AB5C
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

		// Token: 0x06003386 RID: 13190 RVA: 0x0017C9DB File Offset: 0x0017ABDB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevCultivateProjectByProjectProjectId.LogPair = null;
			ConfigRoleDevCultivateProjectByProjectProjectId.HandleId = 0;
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x0017C9E9 File Offset: 0x0017ABE9
		public static void Init()
		{
			ConfigRoleDevCultivateProjectByProjectProjectId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevCultivateProjectByProjectProjectId.HandleId, "db_roledev.db", "select BinData from `RoleDevCultivateProject` where ProjectProjectId=?");
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x0017CA04 File Offset: 0x0017AC04
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

		// Token: 0x04003BEB RID: 15339
		private const string DB = "db_roledev.db";

		// Token: 0x04003BEC RID: 15340
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003BED RID: 15341
		private const string TABLE = "RoleDevCultivateProject";

		// Token: 0x04003BEE RID: 15342
		private const string COMMAND = "select BinData from `RoleDevCultivateProject` where ProjectProjectId=?";

		// Token: 0x04003BEF RID: 15343
		private const string KEY_PREFIX = "RoleDevCultivateProjectByProjectProjectId";

		// Token: 0x04003BF0 RID: 15344
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BF1 RID: 15345
		private static int HandleId;
	}
}
