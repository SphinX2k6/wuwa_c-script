using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DC RID: 2268
	public class ConfigRoleSkillFightTrickById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600353B RID: 13627 RVA: 0x001899BF File Offset: 0x00187BBF
		static ConfigRoleSkillFightTrickById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkillFightTrickById.CreateStaticDefaultValue), new Action(ConfigRoleSkillFightTrickById.ResetStaticDefaultValue));
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x001899E0 File Offset: 0x00187BE0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkillFightTrickById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkillFightTrickById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skilltree.db"),
				new ValueTuple<string, object>("文件", "j.技能树.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkillFightTrick"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkillFightTrick` where Id = ?")
			});
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00189A5F File Offset: 0x00187C5F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkillFightTrickById.LogPair = null;
			ConfigRoleSkillFightTrickById.HandleId = 0;
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x00189A6D File Offset: 0x00187C6D
		public static void Init()
		{
			ConfigRoleSkillFightTrickById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkillFightTrickById.HandleId, "db_skilltree.db", "select BinData from `RoleSkillFightTrick` where Id = ?");
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x00189A88 File Offset: 0x00187C88
		public static RoleSkillFightTrick? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkillFightTrickById.HandleId, ConfigRoleSkillFightTrickById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkillFightTrickById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkillFightTrick?(RoleSkillFightTrick.GetRootAsRoleSkillFightTrick(configBuffer));
				}
			}
			ConfigRoleSkillFightTrickById.LogPair.Clear();
			ConfigRoleSkillFightTrickById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleSkillFightTrickById.HandleId, 1, p0Id, ConfigRoleSkillFightTrickById.LogPair) || ConfigCommon.Step(ConfigRoleSkillFightTrickById.HandleId, true, ConfigRoleSkillFightTrickById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkillFightTrickById.HandleId, ConfigRoleSkillFightTrickById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkillFightTrickById.HandleId, 0, ConfigRoleSkillFightTrickById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkillFightTrickById.HandleId, ConfigRoleSkillFightTrickById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkillFightTrick rootAsRoleSkillFightTrick = RoleSkillFightTrick.GetRootAsRoleSkillFightTrick(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkillFightTrickById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkillFightTrickById.HandleId, ConfigRoleSkillFightTrickById.LogPair);
			return new RoleSkillFightTrick?(rootAsRoleSkillFightTrick);
		}

		// Token: 0x04003DEA RID: 15850
		private const string DB = "db_skilltree.db";

		// Token: 0x04003DEB RID: 15851
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x04003DEC RID: 15852
		private const string TABLE = "RoleSkillFightTrick";

		// Token: 0x04003DED RID: 15853
		private const string COMMAND = "select BinData from `RoleSkillFightTrick` where Id = ?";

		// Token: 0x04003DEE RID: 15854
		private const string KEY_PREFIX = "RoleSkillFightTrickById";

		// Token: 0x04003DEF RID: 15855
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DF0 RID: 15856
		private static int HandleId;
	}
}
