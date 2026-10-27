using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C0 RID: 2240
	public class ConfigRoleSkillFightTrickById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003493 RID: 13459 RVA: 0x001826D7 File Offset: 0x001808D7
		static ConfigRoleSkillFightTrickById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkillFightTrickById.CreateStaticDefaultValue), new Action(ConfigRoleSkillFightTrickById.ResetStaticDefaultValue));
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x001826F8 File Offset: 0x001808F8
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

		// Token: 0x06003495 RID: 13461 RVA: 0x00182777 File Offset: 0x00180977
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkillFightTrickById.LogPair = null;
			ConfigRoleSkillFightTrickById.HandleId = 0;
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00182785 File Offset: 0x00180985
		public static void Init()
		{
			ConfigRoleSkillFightTrickById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkillFightTrickById.HandleId, "db_skilltree.db", "select BinData from `RoleSkillFightTrick` where Id = ?");
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x001827A0 File Offset: 0x001809A0
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

		// Token: 0x04003D26 RID: 15654
		private const string DB = "db_skilltree.db";

		// Token: 0x04003D27 RID: 15655
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x04003D28 RID: 15656
		private const string TABLE = "RoleSkillFightTrick";

		// Token: 0x04003D29 RID: 15657
		private const string COMMAND = "select BinData from `RoleSkillFightTrick` where Id = ?";

		// Token: 0x04003D2A RID: 15658
		private const string KEY_PREFIX = "RoleSkillFightTrickById";

		// Token: 0x04003D2B RID: 15659
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D2C RID: 15660
		private static int HandleId;
	}
}
