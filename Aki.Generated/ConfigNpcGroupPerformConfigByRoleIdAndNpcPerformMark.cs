using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061A RID: 1562
	public class ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024AC RID: 9388 RVA: 0x00128EE0 File Offset: 0x001270E0
		static ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.CreateStaticDefaultValue), new Action(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.ResetStaticDefaultValue));
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00128F00 File Offset: 0x00127100
		public static void CreateStaticDefaultValue()
		{
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_npcgroupperformconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/n.NPC组合表演配置/*.csv*"),
				new ValueTuple<string, object>("表名", "NpcGroupPerformConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `NpcGroupPerformConfig` where PerformMark=? And RoleId=? And NpcType=?")
			});
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00128F7F File Offset: 0x0012717F
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair = null;
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId = 0;
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00128F8D File Offset: 0x0012718D
		public static void Init()
		{
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId = ConfigCommon.InitDataStatement(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, "db_npcgroupperformconfig.db", "select BinData from `NpcGroupPerformConfig` where PerformMark=? And RoleId=? And NpcType=?");
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x00128FA8 File Offset: 0x001271A8
		[return: Nullable(2)]
		public static IReadOnlyList<NpcGroupPerformConfig> GetConfigList(string p0PerformMark, int p1RoleId, string p2NpcType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("NpcGroupPerformConfigByRoleIdAndNpcPerformMark");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0PerformMark);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2NpcType);
				IReadOnlyList<NpcGroupPerformConfig> readOnlyList = (IReadOnlyList<NpcGroupPerformConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair.Clear();
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair.Add(new ValueTuple<string, object>("PerformMark", p0PerformMark));
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair.Add(new ValueTuple<string, object>("RoleId", p1RoleId));
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair.Add(new ValueTuple<string, object>("NpcType", p2NpcType));
			if (!ConfigCommon.BindString(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, 1, p0PerformMark, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair) || !ConfigCommon.BindInt(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, 2, p1RoleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair) || !ConfigCommon.BindString(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, 3, p2NpcType, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair))
			{
				ConfigCommon.Reset(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair);
				return null;
			}
			List<NpcGroupPerformConfig> list = new List<NpcGroupPerformConfig>();
			while (ConfigCommon.Step(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, false, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, 0, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair);
					return null;
				}
				NpcGroupPerformConfig rootAsNpcGroupPerformConfig = NpcGroupPerformConfig.GetRootAsNpcGroupPerformConfig(new ByteBuffer(item2));
				list.Add(rootAsNpcGroupPerformConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("NpcGroupPerformConfigByRoleIdAndNpcPerformMark");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0PerformMark);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2NpcType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair);
			return list;
		}

		// Token: 0x04002A9C RID: 10908
		private const string DB = "db_npcgroupperformconfig.db";

		// Token: 0x04002A9D RID: 10909
		private const string FILE = "k.可视化编辑/c.Csv/n.NPC组合表演配置/*.csv*";

		// Token: 0x04002A9E RID: 10910
		private const string TABLE = "NpcGroupPerformConfig";

		// Token: 0x04002A9F RID: 10911
		private const string COMMAND = "select BinData from `NpcGroupPerformConfig` where PerformMark=? And RoleId=? And NpcType=?";

		// Token: 0x04002AA0 RID: 10912
		private const string KEY_PREFIX = "NpcGroupPerformConfigByRoleIdAndNpcPerformMark";

		// Token: 0x04002AA1 RID: 10913
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AA2 RID: 10914
		private static int HandleId;
	}
}
