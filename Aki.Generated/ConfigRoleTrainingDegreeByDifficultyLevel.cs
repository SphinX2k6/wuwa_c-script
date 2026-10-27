using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D0 RID: 2256
	public class ConfigRoleTrainingDegreeByDifficultyLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034F3 RID: 13555 RVA: 0x00184A14 File Offset: 0x00182C14
		static ConfigRoleTrainingDegreeByDifficultyLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrainingDegreeByDifficultyLevel.CreateStaticDefaultValue), new Action(ConfigRoleTrainingDegreeByDifficultyLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00184A34 File Offset: 0x00182C34
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTrainingDegreeByDifficultyLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTrainingDegreeByDifficultyLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletrainingdegree.db"),
				new ValueTuple<string, object>("文件", "j.角色练度标准.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTrainingDegree"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTrainingDegree` where DifficultyLevel = ?")
			});
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00184AB3 File Offset: 0x00182CB3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrainingDegreeByDifficultyLevel.LogPair = null;
			ConfigRoleTrainingDegreeByDifficultyLevel.HandleId = 0;
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00184AC1 File Offset: 0x00182CC1
		public static void Init()
		{
			ConfigRoleTrainingDegreeByDifficultyLevel.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrainingDegreeByDifficultyLevel.HandleId, "db_roletrainingdegree.db", "select BinData from `RoleTrainingDegree` where DifficultyLevel = ?");
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00184ADC File Offset: 0x00182CDC
		public static RoleTrainingDegree? GetConfig(int p0DifficultyLevel, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTrainingDegreeByDifficultyLevel.HandleId, ConfigRoleTrainingDegreeByDifficultyLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrainingDegreeByDifficultyLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DifficultyLevel);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTrainingDegree?(RoleTrainingDegree.GetRootAsRoleTrainingDegree(configBuffer));
				}
			}
			ConfigRoleTrainingDegreeByDifficultyLevel.LogPair.Clear();
			ConfigRoleTrainingDegreeByDifficultyLevel.LogPair.Add(new ValueTuple<string, object>("DifficultyLevel", p0DifficultyLevel));
			if (!ConfigCommon.BindInt(ConfigRoleTrainingDegreeByDifficultyLevel.HandleId, 1, p0DifficultyLevel, ConfigRoleTrainingDegreeByDifficultyLevel.LogPair) || ConfigCommon.Step(ConfigRoleTrainingDegreeByDifficultyLevel.HandleId, true, ConfigRoleTrainingDegreeByDifficultyLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTrainingDegreeByDifficultyLevel.HandleId, ConfigRoleTrainingDegreeByDifficultyLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTrainingDegreeByDifficultyLevel.HandleId, 0, ConfigRoleTrainingDegreeByDifficultyLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTrainingDegreeByDifficultyLevel.HandleId, ConfigRoleTrainingDegreeByDifficultyLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTrainingDegree rootAsRoleTrainingDegree = RoleTrainingDegree.GetRootAsRoleTrainingDegree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrainingDegreeByDifficultyLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DifficultyLevel);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTrainingDegreeByDifficultyLevel.HandleId, ConfigRoleTrainingDegreeByDifficultyLevel.LogPair);
			return new RoleTrainingDegree?(rootAsRoleTrainingDegree);
		}

		// Token: 0x04003D96 RID: 15766
		private const string DB = "db_roletrainingdegree.db";

		// Token: 0x04003D97 RID: 15767
		private const string FILE = "j.角色练度标准.xlsx";

		// Token: 0x04003D98 RID: 15768
		private const string TABLE = "RoleTrainingDegree";

		// Token: 0x04003D99 RID: 15769
		private const string COMMAND = "select BinData from `RoleTrainingDegree` where DifficultyLevel = ?";

		// Token: 0x04003D9A RID: 15770
		private const string KEY_PREFIX = "RoleTrainingDegreeByDifficultyLevel";

		// Token: 0x04003D9B RID: 15771
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D9C RID: 15772
		private static int HandleId;
	}
}
