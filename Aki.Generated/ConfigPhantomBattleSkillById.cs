using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000684 RID: 1668
	public class ConfigPhantomBattleSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002728 RID: 10024 RVA: 0x00137188 File Offset: 0x00135388
		static ConfigPhantomBattleSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleSkillById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x001371A8 File Offset: 0x001353A8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战战斗.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleSkill` where Id=?")
			});
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00137227 File Offset: 0x00135427
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleSkillById.LogPair = null;
			ConfigPhantomBattleSkillById.HandleId = 0;
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00137235 File Offset: 0x00135435
		public static void Init()
		{
			ConfigPhantomBattleSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleSkillById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleSkill` where Id=?");
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00137250 File Offset: 0x00135450
		public static PhantomBattleSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleSkillById.HandleId, ConfigPhantomBattleSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleSkill?(PhantomBattleSkill.GetRootAsPhantomBattleSkill(configBuffer));
				}
			}
			ConfigPhantomBattleSkillById.LogPair.Clear();
			ConfigPhantomBattleSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleSkillById.HandleId, 1, p0Id, ConfigPhantomBattleSkillById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleSkillById.HandleId, true, ConfigPhantomBattleSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleSkillById.HandleId, ConfigPhantomBattleSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleSkillById.HandleId, 0, ConfigPhantomBattleSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleSkillById.HandleId, ConfigPhantomBattleSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleSkill rootAsPhantomBattleSkill = PhantomBattleSkill.GetRootAsPhantomBattleSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleSkillById.HandleId, ConfigPhantomBattleSkillById.LogPair);
			return new PhantomBattleSkill?(rootAsPhantomBattleSkill);
		}

		// Token: 0x04002D82 RID: 11650
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D83 RID: 11651
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002D84 RID: 11652
		private const string TABLE = "PhantomBattleSkill";

		// Token: 0x04002D85 RID: 11653
		private const string COMMAND = "select BinData from `PhantomBattleSkill` where Id=?";

		// Token: 0x04002D86 RID: 11654
		private const string KEY_PREFIX = "PhantomBattleSkillById";

		// Token: 0x04002D87 RID: 11655
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D88 RID: 11656
		private static int HandleId;
	}
}
