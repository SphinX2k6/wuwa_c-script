using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C1 RID: 2241
	public class ConfigRoleSkillFightTrickByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003499 RID: 13465 RVA: 0x00182920 File Offset: 0x00180B20
		static ConfigRoleSkillFightTrickByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkillFightTrickByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleSkillFightTrickByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00182940 File Offset: 0x00180B40
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkillFightTrickByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkillFightTrickByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skilltree.db"),
				new ValueTuple<string, object>("文件", "j.技能树.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkillFightTrick"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkillFightTrick` where RoleId = ?")
			});
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x001829BF File Offset: 0x00180BBF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkillFightTrickByRoleId.LogPair = null;
			ConfigRoleSkillFightTrickByRoleId.HandleId = 0;
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x001829CD File Offset: 0x00180BCD
		public static void Init()
		{
			ConfigRoleSkillFightTrickByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkillFightTrickByRoleId.HandleId, "db_skilltree.db", "select BinData from `RoleSkillFightTrick` where RoleId = ?");
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x001829E8 File Offset: 0x00180BE8
		[NullableContext(2)]
		public static IReadOnlyList<RoleSkillFightTrick> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkillFightTrickByRoleId.HandleId, ConfigRoleSkillFightTrickByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkillFightTrickByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<RoleSkillFightTrick> readOnlyList = (IReadOnlyList<RoleSkillFightTrick>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleSkillFightTrickByRoleId.LogPair.Clear();
			ConfigRoleSkillFightTrickByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleSkillFightTrickByRoleId.HandleId, 1, p0RoleId, ConfigRoleSkillFightTrickByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleSkillFightTrickByRoleId.HandleId, ConfigRoleSkillFightTrickByRoleId.LogPair);
				return null;
			}
			List<RoleSkillFightTrick> list = new List<RoleSkillFightTrick>();
			while (ConfigCommon.Step(ConfigRoleSkillFightTrickByRoleId.HandleId, false, ConfigRoleSkillFightTrickByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkillFightTrickByRoleId.HandleId, 0, ConfigRoleSkillFightTrickByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleSkillFightTrickByRoleId.HandleId, ConfigRoleSkillFightTrickByRoleId.LogPair);
					return null;
				}
				RoleSkillFightTrick rootAsRoleSkillFightTrick = RoleSkillFightTrick.GetRootAsRoleSkillFightTrick(new ByteBuffer(item2));
				list.Add(rootAsRoleSkillFightTrick);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkillFightTrickByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleSkillFightTrickByRoleId.HandleId, ConfigRoleSkillFightTrickByRoleId.LogPair);
			return list;
		}

		// Token: 0x04003D2D RID: 15661
		private const string DB = "db_skilltree.db";

		// Token: 0x04003D2E RID: 15662
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x04003D2F RID: 15663
		private const string TABLE = "RoleSkillFightTrick";

		// Token: 0x04003D30 RID: 15664
		private const string COMMAND = "select BinData from `RoleSkillFightTrick` where RoleId = ?";

		// Token: 0x04003D31 RID: 15665
		private const string KEY_PREFIX = "RoleSkillFightTrickByRoleId";

		// Token: 0x04003D32 RID: 15666
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D33 RID: 15667
		private static int HandleId;
	}
}
