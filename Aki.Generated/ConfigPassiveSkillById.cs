using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000650 RID: 1616
	public class ConfigPassiveSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025F0 RID: 9712 RVA: 0x00133A54 File Offset: 0x00131C54
		static ConfigPassiveSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPassiveSkillById.CreateStaticDefaultValue), new Action(ConfigPassiveSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x00133A74 File Offset: 0x00131C74
		public static void CreateStaticDefaultValue()
		{
			ConfigPassiveSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPassiveSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_passiveskill.db"),
				new ValueTuple<string, object>("文件", "b.被动技能.xlsx"),
				new ValueTuple<string, object>("表名", "PassiveSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `PassiveSkill` where Id=?")
			});
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00133AF3 File Offset: 0x00131CF3
		public static void ResetStaticDefaultValue()
		{
			ConfigPassiveSkillById.LogPair = null;
			ConfigPassiveSkillById.HandleId = 0;
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x00133B01 File Offset: 0x00131D01
		public static void Init()
		{
			ConfigPassiveSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigPassiveSkillById.HandleId, "db_passiveskill.db", "select BinData from `PassiveSkill` where Id=?");
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00133B1C File Offset: 0x00131D1C
		public static PassiveSkill? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPassiveSkillById.HandleId, ConfigPassiveSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PassiveSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PassiveSkill?(PassiveSkill.GetRootAsPassiveSkill(configBuffer));
				}
			}
			ConfigPassiveSkillById.LogPair.Clear();
			ConfigPassiveSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigPassiveSkillById.HandleId, 1, (double)p0Id, ConfigPassiveSkillById.LogPair) || ConfigCommon.Step(ConfigPassiveSkillById.HandleId, true, ConfigPassiveSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPassiveSkillById.HandleId, ConfigPassiveSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPassiveSkillById.HandleId, 0, ConfigPassiveSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPassiveSkillById.HandleId, ConfigPassiveSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PassiveSkill rootAsPassiveSkill = PassiveSkill.GetRootAsPassiveSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PassiveSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPassiveSkillById.HandleId, ConfigPassiveSkillById.LogPair);
			return new PassiveSkill?(rootAsPassiveSkill);
		}

		// Token: 0x04002C16 RID: 11286
		private const string DB = "db_passiveskill.db";

		// Token: 0x04002C17 RID: 11287
		private const string FILE = "b.被动技能.xlsx";

		// Token: 0x04002C18 RID: 11288
		private const string TABLE = "PassiveSkill";

		// Token: 0x04002C19 RID: 11289
		private const string COMMAND = "select BinData from `PassiveSkill` where Id=?";

		// Token: 0x04002C1A RID: 11290
		private const string KEY_PREFIX = "PassiveSkillById";

		// Token: 0x04002C1B RID: 11291
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C1C RID: 11292
		private static int HandleId;
	}
}
