using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069C RID: 1692
	public class ConfigPhantomBattleSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027B8 RID: 10168 RVA: 0x0013DC04 File Offset: 0x0013BE04
		static ConfigPhantomBattleSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleSkillById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x0013DC24 File Offset: 0x0013BE24
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

		// Token: 0x060027BA RID: 10170 RVA: 0x0013DCA3 File Offset: 0x0013BEA3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleSkillById.LogPair = null;
			ConfigPhantomBattleSkillById.HandleId = 0;
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x0013DCB1 File Offset: 0x0013BEB1
		public static void Init()
		{
			ConfigPhantomBattleSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleSkillById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleSkill` where Id=?");
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0013DCCC File Offset: 0x0013BECC
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

		// Token: 0x04002E2A RID: 11818
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E2B RID: 11819
		private const string FILE = "s.声骸大作战战斗.xlsx";

		// Token: 0x04002E2C RID: 11820
		private const string TABLE = "PhantomBattleSkill";

		// Token: 0x04002E2D RID: 11821
		private const string COMMAND = "select BinData from `PhantomBattleSkill` where Id=?";

		// Token: 0x04002E2E RID: 11822
		private const string KEY_PREFIX = "PhantomBattleSkillById";

		// Token: 0x04002E2F RID: 11823
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E30 RID: 11824
		private static int HandleId;
	}
}
