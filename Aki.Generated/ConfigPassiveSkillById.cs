using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000638 RID: 1592
	public class ConfigPassiveSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002560 RID: 9568 RVA: 0x0012CFD8 File Offset: 0x0012B1D8
		static ConfigPassiveSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPassiveSkillById.CreateStaticDefaultValue), new Action(ConfigPassiveSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x0012CFF8 File Offset: 0x0012B1F8
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

		// Token: 0x06002562 RID: 9570 RVA: 0x0012D077 File Offset: 0x0012B277
		public static void ResetStaticDefaultValue()
		{
			ConfigPassiveSkillById.LogPair = null;
			ConfigPassiveSkillById.HandleId = 0;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x0012D085 File Offset: 0x0012B285
		public static void Init()
		{
			ConfigPassiveSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigPassiveSkillById.HandleId, "db_passiveskill.db", "select BinData from `PassiveSkill` where Id=?");
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x0012D0A0 File Offset: 0x0012B2A0
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

		// Token: 0x04002B6E RID: 11118
		private const string DB = "db_passiveskill.db";

		// Token: 0x04002B6F RID: 11119
		private const string FILE = "b.被动技能.xlsx";

		// Token: 0x04002B70 RID: 11120
		private const string TABLE = "PassiveSkill";

		// Token: 0x04002B71 RID: 11121
		private const string COMMAND = "select BinData from `PassiveSkill` where Id=?";

		// Token: 0x04002B72 RID: 11122
		private const string KEY_PREFIX = "PassiveSkillById";

		// Token: 0x04002B73 RID: 11123
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B74 RID: 11124
		private static int HandleId;
	}
}
