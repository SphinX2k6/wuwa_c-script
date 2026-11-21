using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000633 RID: 1587
	public class ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002542 RID: 9538 RVA: 0x0012FC36 File Offset: 0x0012DE36
		static ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.CreateStaticDefaultValue), new Action(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.ResetStaticDefaultValue));
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x0012FC58 File Offset: 0x0012DE58
		public static void CreateStaticDefaultValue()
		{
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_npcgroupperformconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/n.NPC组合表演配置/*.csv*"),
				new ValueTuple<string, object>("表名", "NpcGroupPerformConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `NpcGroupPerformConfig` where PerformType=? And RoleId=? And NpcType=?")
			});
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x0012FCD7 File Offset: 0x0012DED7
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair = null;
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId = 0;
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x0012FCE5 File Offset: 0x0012DEE5
		public static void Init()
		{
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId = ConfigCommon.InitDataStatement(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, "db_npcgroupperformconfig.db", "select BinData from `NpcGroupPerformConfig` where PerformType=? And RoleId=? And NpcType=?");
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x0012FD00 File Offset: 0x0012DF00
		[return: Nullable(2)]
		public static IReadOnlyList<NpcGroupPerformConfig> GetConfigList(int p0PerformType, int p1RoleId, string p2NpcType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("NpcGroupPerformConfigByRoleIdAndNpcPerformType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PerformType);
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
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair.Clear();
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair.Add(new ValueTuple<string, object>("PerformType", p0PerformType));
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair.Add(new ValueTuple<string, object>("RoleId", p1RoleId));
			ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair.Add(new ValueTuple<string, object>("NpcType", p2NpcType));
			if (!ConfigCommon.BindInt(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, 1, p0PerformType, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair) || !ConfigCommon.BindInt(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, 2, p1RoleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair) || !ConfigCommon.BindString(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, 3, p2NpcType, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair))
			{
				ConfigCommon.Reset(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair);
				return null;
			}
			List<NpcGroupPerformConfig> list = new List<NpcGroupPerformConfig>();
			while (ConfigCommon.Step(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, false, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, 0, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair);
					return null;
				}
				NpcGroupPerformConfig rootAsNpcGroupPerformConfig = NpcGroupPerformConfig.GetRootAsNpcGroupPerformConfig(new ByteBuffer(item2));
				list.Add(rootAsNpcGroupPerformConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("NpcGroupPerformConfigByRoleIdAndNpcPerformType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PerformType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2NpcType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.HandleId, ConfigNpcGroupPerformConfigByRoleIdAndNpcPerformType.LogPair);
			return list;
		}

		// Token: 0x04002B4B RID: 11083
		private const string DB = "db_npcgroupperformconfig.db";

		// Token: 0x04002B4C RID: 11084
		private const string FILE = "k.可视化编辑/c.Csv/n.NPC组合表演配置/*.csv*";

		// Token: 0x04002B4D RID: 11085
		private const string TABLE = "NpcGroupPerformConfig";

		// Token: 0x04002B4E RID: 11086
		private const string COMMAND = "select BinData from `NpcGroupPerformConfig` where PerformType=? And RoleId=? And NpcType=?";

		// Token: 0x04002B4F RID: 11087
		private const string KEY_PREFIX = "NpcGroupPerformConfigByRoleIdAndNpcPerformType";

		// Token: 0x04002B50 RID: 11088
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B51 RID: 11089
		private static int HandleId;
	}
}
