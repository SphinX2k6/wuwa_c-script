using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000372 RID: 882
	public class ConfigGachaRoleDevelopInsByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x000CE8C8 File Offset: 0x000CCAC8
		static ConfigGachaRoleDevelopInsByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaRoleDevelopInsByRoleId.CreateStaticDefaultValue), new Action(ConfigGachaRoleDevelopInsByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000CE8E8 File Offset: 0x000CCAE8
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaRoleDevelopInsByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacharoledevelop.db"),
				new ValueTuple<string, object>("文件", "d.当期卡池角色养成推荐.xlsx"),
				new ValueTuple<string, object>("表名", "GachaRoleDevelopIns"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaRoleDevelopIns` where RoleId=?")
			});
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000CE967 File Offset: 0x000CCB67
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsByRoleId.LogPair = null;
			ConfigGachaRoleDevelopInsByRoleId.HandleId = 0;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000CE975 File Offset: 0x000CCB75
		public static void Init()
		{
			ConfigGachaRoleDevelopInsByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigGachaRoleDevelopInsByRoleId.HandleId, "db_gacharoledevelop.db", "select BinData from `GachaRoleDevelopIns` where RoleId=?");
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000CE990 File Offset: 0x000CCB90
		[NullableContext(2)]
		public static IReadOnlyList<GachaRoleDevelopIns> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaRoleDevelopInsByRoleId.HandleId, ConfigGachaRoleDevelopInsByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<GachaRoleDevelopIns> readOnlyList = (IReadOnlyList<GachaRoleDevelopIns>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigGachaRoleDevelopInsByRoleId.LogPair.Clear();
			ConfigGachaRoleDevelopInsByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigGachaRoleDevelopInsByRoleId.HandleId, 1, p0RoleId, ConfigGachaRoleDevelopInsByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigGachaRoleDevelopInsByRoleId.HandleId, ConfigGachaRoleDevelopInsByRoleId.LogPair);
				return null;
			}
			List<GachaRoleDevelopIns> list = new List<GachaRoleDevelopIns>();
			while (ConfigCommon.Step(ConfigGachaRoleDevelopInsByRoleId.HandleId, false, ConfigGachaRoleDevelopInsByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaRoleDevelopInsByRoleId.HandleId, 0, ConfigGachaRoleDevelopInsByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGachaRoleDevelopInsByRoleId.HandleId, ConfigGachaRoleDevelopInsByRoleId.LogPair);
					return null;
				}
				GachaRoleDevelopIns rootAsGachaRoleDevelopIns = GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(new ByteBuffer(item2));
				list.Add(rootAsGachaRoleDevelopIns);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigGachaRoleDevelopInsByRoleId.HandleId, ConfigGachaRoleDevelopInsByRoleId.LogPair);
			return list;
		}

		// Token: 0x04001802 RID: 6146
		private const string DB = "db_gacharoledevelop.db";

		// Token: 0x04001803 RID: 6147
		private const string FILE = "d.当期卡池角色养成推荐.xlsx";

		// Token: 0x04001804 RID: 6148
		private const string TABLE = "GachaRoleDevelopIns";

		// Token: 0x04001805 RID: 6149
		private const string COMMAND = "select BinData from `GachaRoleDevelopIns` where RoleId=?";

		// Token: 0x04001806 RID: 6150
		private const string KEY_PREFIX = "GachaRoleDevelopInsByRoleId";

		// Token: 0x04001807 RID: 6151
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001808 RID: 6152
		private static int HandleId;
	}
}
