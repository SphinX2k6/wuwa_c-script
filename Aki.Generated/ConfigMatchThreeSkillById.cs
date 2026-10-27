using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000537 RID: 1335
	public class ConfigMatchThreeSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F55 RID: 8021 RVA: 0x0010A680 File Offset: 0x00108880
		static ConfigMatchThreeSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeSkillById.CreateStaticDefaultValue), new Action(ConfigMatchThreeSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0010A6A0 File Offset: 0x001088A0
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeSkill` where Id=?")
			});
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x0010A71F File Offset: 0x0010891F
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeSkillById.LogPair = null;
			ConfigMatchThreeSkillById.HandleId = 0;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x0010A72D File Offset: 0x0010892D
		public static void Init()
		{
			ConfigMatchThreeSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeSkillById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeSkill` where Id=?");
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x0010A748 File Offset: 0x00108948
		public static MatchThreeSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeSkillById.HandleId, ConfigMatchThreeSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeSkill?(MatchThreeSkill.GetRootAsMatchThreeSkill(configBuffer));
				}
			}
			ConfigMatchThreeSkillById.LogPair.Clear();
			ConfigMatchThreeSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeSkillById.HandleId, 1, p0Id, ConfigMatchThreeSkillById.LogPair) || ConfigCommon.Step(ConfigMatchThreeSkillById.HandleId, true, ConfigMatchThreeSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeSkillById.HandleId, ConfigMatchThreeSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeSkillById.HandleId, 0, ConfigMatchThreeSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeSkillById.HandleId, ConfigMatchThreeSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeSkill rootAsMatchThreeSkill = MatchThreeSkill.GetRootAsMatchThreeSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeSkillById.HandleId, ConfigMatchThreeSkillById.LogPair);
			return new MatchThreeSkill?(rootAsMatchThreeSkill);
		}

		// Token: 0x04002465 RID: 9317
		private const string DB = "db_matchthree.db";

		// Token: 0x04002466 RID: 9318
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x04002467 RID: 9319
		private const string TABLE = "MatchThreeSkill";

		// Token: 0x04002468 RID: 9320
		private const string COMMAND = "select BinData from `MatchThreeSkill` where Id=?";

		// Token: 0x04002469 RID: 9321
		private const string KEY_PREFIX = "MatchThreeSkillById";

		// Token: 0x0400246A RID: 9322
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400246B RID: 9323
		private static int HandleId;
	}
}
