using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DD RID: 2269
	public class ConfigRoleSkillFightTrickByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003541 RID: 13633 RVA: 0x00189C08 File Offset: 0x00187E08
		static ConfigRoleSkillFightTrickByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkillFightTrickByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleSkillFightTrickByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x00189C28 File Offset: 0x00187E28
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

		// Token: 0x06003543 RID: 13635 RVA: 0x00189CA7 File Offset: 0x00187EA7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkillFightTrickByRoleId.LogPair = null;
			ConfigRoleSkillFightTrickByRoleId.HandleId = 0;
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00189CB5 File Offset: 0x00187EB5
		public static void Init()
		{
			ConfigRoleSkillFightTrickByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkillFightTrickByRoleId.HandleId, "db_skilltree.db", "select BinData from `RoleSkillFightTrick` where RoleId = ?");
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00189CD0 File Offset: 0x00187ED0
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

		// Token: 0x04003DF1 RID: 15857
		private const string DB = "db_skilltree.db";

		// Token: 0x04003DF2 RID: 15858
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x04003DF3 RID: 15859
		private const string TABLE = "RoleSkillFightTrick";

		// Token: 0x04003DF4 RID: 15860
		private const string COMMAND = "select BinData from `RoleSkillFightTrick` where RoleId = ?";

		// Token: 0x04003DF5 RID: 15861
		private const string KEY_PREFIX = "RoleSkillFightTrickByRoleId";

		// Token: 0x04003DF6 RID: 15862
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DF7 RID: 15863
		private static int HandleId;
	}
}
