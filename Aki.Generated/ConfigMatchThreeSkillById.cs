using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054D RID: 1357
	public class ConfigMatchThreeSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FD9 RID: 8153 RVA: 0x00110DD4 File Offset: 0x0010EFD4
		static ConfigMatchThreeSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeSkillById.CreateStaticDefaultValue), new Action(ConfigMatchThreeSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00110DF4 File Offset: 0x0010EFF4
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

		// Token: 0x06001FDB RID: 8155 RVA: 0x00110E73 File Offset: 0x0010F073
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeSkillById.LogPair = null;
			ConfigMatchThreeSkillById.HandleId = 0;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00110E81 File Offset: 0x0010F081
		public static void Init()
		{
			ConfigMatchThreeSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeSkillById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeSkill` where Id=?");
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00110E9C File Offset: 0x0010F09C
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

		// Token: 0x040024FF RID: 9471
		private const string DB = "db_matchthree.db";

		// Token: 0x04002500 RID: 9472
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x04002501 RID: 9473
		private const string TABLE = "MatchThreeSkill";

		// Token: 0x04002502 RID: 9474
		private const string COMMAND = "select BinData from `MatchThreeSkill` where Id=?";

		// Token: 0x04002503 RID: 9475
		private const string KEY_PREFIX = "MatchThreeSkillById";

		// Token: 0x04002504 RID: 9476
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002505 RID: 9477
		private static int HandleId;
	}
}
