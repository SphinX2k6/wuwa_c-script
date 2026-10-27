using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000081 RID: 129
	public class ConfigAiBaseSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0006A8C4 File Offset: 0x00068AC4
		static ConfigAiBaseSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiBaseSkillById.CreateStaticDefaultValue), new Action(ConfigAiBaseSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0006A8E4 File Offset: 0x00068AE4
		public static void CreateStaticDefaultValue()
		{
			ConfigAiBaseSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiBaseSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ai.db"),
				new ValueTuple<string, object>("文件", "a.AI随机技能库.xlsx"),
				new ValueTuple<string, object>("表名", "AiBaseSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `AiBaseSkill` where Id=?")
			});
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0006A963 File Offset: 0x00068B63
		public static void ResetStaticDefaultValue()
		{
			ConfigAiBaseSkillById.LogPair = null;
			ConfigAiBaseSkillById.HandleId = 0;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0006A971 File Offset: 0x00068B71
		public static void Init()
		{
			ConfigAiBaseSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigAiBaseSkillById.HandleId, "db_ai.db", "select BinData from `AiBaseSkill` where Id=?");
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0006A98C File Offset: 0x00068B8C
		public static AiBaseSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiBaseSkillById.HandleId, ConfigAiBaseSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBaseSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AiBaseSkill?(AiBaseSkill.GetRootAsAiBaseSkill(configBuffer));
				}
			}
			ConfigAiBaseSkillById.LogPair.Clear();
			ConfigAiBaseSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAiBaseSkillById.HandleId, 1, p0Id, ConfigAiBaseSkillById.LogPair) || ConfigCommon.Step(ConfigAiBaseSkillById.HandleId, true, ConfigAiBaseSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiBaseSkillById.HandleId, ConfigAiBaseSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiBaseSkillById.HandleId, 0, ConfigAiBaseSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiBaseSkillById.HandleId, ConfigAiBaseSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiBaseSkill rootAsAiBaseSkill = AiBaseSkill.GetRootAsAiBaseSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AiBaseSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiBaseSkillById.HandleId, ConfigAiBaseSkillById.LogPair);
			return new AiBaseSkill?(rootAsAiBaseSkill);
		}

		// Token: 0x0400036B RID: 875
		private const string DB = "db_ai.db";

		// Token: 0x0400036C RID: 876
		private const string FILE = "a.AI随机技能库.xlsx";

		// Token: 0x0400036D RID: 877
		private const string TABLE = "AiBaseSkill";

		// Token: 0x0400036E RID: 878
		private const string COMMAND = "select BinData from `AiBaseSkill` where Id=?";

		// Token: 0x0400036F RID: 879
		private const string KEY_PREFIX = "AiBaseSkillById";

		// Token: 0x04000370 RID: 880
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000371 RID: 881
		private static int HandleId;
	}
}
