using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091B RID: 2331
	public class ConfigRoleTrainingDegreeByDifficultyLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036B5 RID: 14005 RVA: 0x00191C34 File Offset: 0x0018FE34
		static ConfigRoleTrainingDegreeByDifficultyLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrainingDegreeByDifficultyLevel.CreateStaticDefaultValue), new Action(ConfigRoleTrainingDegreeByDifficultyLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00191C54 File Offset: 0x0018FE54
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

		// Token: 0x060036B7 RID: 14007 RVA: 0x00191CD3 File Offset: 0x0018FED3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrainingDegreeByDifficultyLevel.LogPair = null;
			ConfigRoleTrainingDegreeByDifficultyLevel.HandleId = 0;
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x00191CE1 File Offset: 0x0018FEE1
		public static void Init()
		{
			ConfigRoleTrainingDegreeByDifficultyLevel.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrainingDegreeByDifficultyLevel.HandleId, "db_roletrainingdegree.db", "select BinData from `RoleTrainingDegree` where DifficultyLevel = ?");
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00191CFC File Offset: 0x0018FEFC
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

		// Token: 0x04003FA3 RID: 16291
		private const string DB = "db_roletrainingdegree.db";

		// Token: 0x04003FA4 RID: 16292
		private const string FILE = "j.角色练度标准.xlsx";

		// Token: 0x04003FA5 RID: 16293
		private const string TABLE = "RoleTrainingDegree";

		// Token: 0x04003FA6 RID: 16294
		private const string COMMAND = "select BinData from `RoleTrainingDegree` where DifficultyLevel = ?";

		// Token: 0x04003FA7 RID: 16295
		private const string KEY_PREFIX = "RoleTrainingDegreeByDifficultyLevel";

		// Token: 0x04003FA8 RID: 16296
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FA9 RID: 16297
		private static int HandleId;
	}
}
