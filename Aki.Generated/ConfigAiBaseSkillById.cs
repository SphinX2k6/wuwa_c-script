using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000089 RID: 137
	public class ConfigAiBaseSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000336 RID: 822 RVA: 0x0006F178 File Offset: 0x0006D378
		static ConfigAiBaseSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiBaseSkillById.CreateStaticDefaultValue), new Action(ConfigAiBaseSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0006F198 File Offset: 0x0006D398
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

		// Token: 0x06000338 RID: 824 RVA: 0x0006F217 File Offset: 0x0006D417
		public static void ResetStaticDefaultValue()
		{
			ConfigAiBaseSkillById.LogPair = null;
			ConfigAiBaseSkillById.HandleId = 0;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0006F225 File Offset: 0x0006D425
		public static void Init()
		{
			ConfigAiBaseSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigAiBaseSkillById.HandleId, "db_ai.db", "select BinData from `AiBaseSkill` where Id=?");
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0006F240 File Offset: 0x0006D440
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

		// Token: 0x040003A3 RID: 931
		private const string DB = "db_ai.db";

		// Token: 0x040003A4 RID: 932
		private const string FILE = "a.AI随机技能库.xlsx";

		// Token: 0x040003A5 RID: 933
		private const string TABLE = "AiBaseSkill";

		// Token: 0x040003A6 RID: 934
		private const string COMMAND = "select BinData from `AiBaseSkill` where Id=?";

		// Token: 0x040003A7 RID: 935
		private const string KEY_PREFIX = "AiBaseSkillById";

		// Token: 0x040003A8 RID: 936
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003A9 RID: 937
		private static int HandleId;
	}
}
