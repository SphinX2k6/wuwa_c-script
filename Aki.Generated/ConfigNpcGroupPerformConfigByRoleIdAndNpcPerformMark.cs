using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000632 RID: 1586
	public class ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600253C RID: 9532 RVA: 0x0012F95C File Offset: 0x0012DB5C
		static ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.CreateStaticDefaultValue), new Action(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.ResetStaticDefaultValue));
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x0012F97C File Offset: 0x0012DB7C
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

		// Token: 0x0600253E RID: 9534 RVA: 0x0012F9FB File Offset: 0x0012DBFB
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.LogPair = null;
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId = 0;
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x0012FA09 File Offset: 0x0012DC09
		public static void Init()
		{
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId = ConfigCommon.InitDataStatement(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformMark.HandleId, "db_npcgroupperformconfig.db", "select BinData from `NpcGroupPerformConfig` where PerformMark=? And RoleId=? And NpcType=?");
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x0012FA24 File Offset: 0x0012DC24
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

		// Token: 0x04002B44 RID: 11076
		private const string DB = "db_npcgroupperformconfig.db";

		// Token: 0x04002B45 RID: 11077
		private const string FILE = "k.可视化编辑/c.Csv/n.NPC组合表演配置/*.csv*";

		// Token: 0x04002B46 RID: 11078
		private const string TABLE = "NpcGroupPerformConfig";

		// Token: 0x04002B47 RID: 11079
		private const string COMMAND = "select BinData from `NpcGroupPerformConfig` where PerformMark=? And RoleId=? And NpcType=?";

		// Token: 0x04002B48 RID: 11080
		private const string KEY_PREFIX = "NpcGroupPerformConfigByRoleIdAndNpcPerformMark";

		// Token: 0x04002B49 RID: 11081
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B4A RID: 11082
		private static int HandleId;
	}
}
