using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B6 RID: 438
	public class ConfigCoopRoleLevelAllLevelData : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A47 RID: 2631 RVA: 0x00097250 File Offset: 0x00095450
		static ConfigCoopRoleLevelAllLevelData()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopRoleLevelAllLevelData.CreateStaticDefaultValue), new Action(ConfigCoopRoleLevelAllLevelData.ResetStaticDefaultValue));
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00097270 File Offset: 0x00095470
		public static void CreateStaticDefaultValue()
		{
			ConfigCoopRoleLevelAllLevelData.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCoopRoleLevelAllLevelData.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cooprolelevel.db"),
				new ValueTuple<string, object>("文件", "c.3.2coop活动.xlsx"),
				new ValueTuple<string, object>("表名", "CoopRoleLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `CoopRoleLevel` where ActivityId=? AND CoopRoleId=?")
			});
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000972EF File Offset: 0x000954EF
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopRoleLevelAllLevelData.LogPair = null;
			ConfigCoopRoleLevelAllLevelData.HandleId = 0;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000972FD File Offset: 0x000954FD
		public static void Init()
		{
			ConfigCoopRoleLevelAllLevelData.HandleId = ConfigCommon.InitDataStatement(ConfigCoopRoleLevelAllLevelData.HandleId, "db_cooprolelevel.db", "select BinData from `CoopRoleLevel` where ActivityId=? AND CoopRoleId=?");
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00097318 File Offset: 0x00095518
		[NullableContext(2)]
		public static IReadOnlyList<CoopRoleLevel> GetConfigList(int p0ActivityId, int p1CoopRoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCoopRoleLevelAllLevelData.HandleId, ConfigCoopRoleLevelAllLevelData.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("CoopRoleLevelAllLevelData");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1CoopRoleId);
				IReadOnlyList<CoopRoleLevel> readOnlyList = (IReadOnlyList<CoopRoleLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCoopRoleLevelAllLevelData.LogPair.Clear();
			ConfigCoopRoleLevelAllLevelData.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigCoopRoleLevelAllLevelData.LogPair.Add(new ValueTuple<string, object>("CoopRoleId", p1CoopRoleId));
			if (!ConfigCommon.BindInt(ConfigCoopRoleLevelAllLevelData.HandleId, 1, p0ActivityId, ConfigCoopRoleLevelAllLevelData.LogPair) || !ConfigCommon.BindInt(ConfigCoopRoleLevelAllLevelData.HandleId, 2, p1CoopRoleId, ConfigCoopRoleLevelAllLevelData.LogPair))
			{
				ConfigCommon.Reset(ConfigCoopRoleLevelAllLevelData.HandleId, ConfigCoopRoleLevelAllLevelData.LogPair);
				return null;
			}
			List<CoopRoleLevel> list = new List<CoopRoleLevel>();
			while (ConfigCommon.Step(ConfigCoopRoleLevelAllLevelData.HandleId, false, ConfigCoopRoleLevelAllLevelData.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCoopRoleLevelAllLevelData.HandleId, 0, ConfigCoopRoleLevelAllLevelData.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCoopRoleLevelAllLevelData.HandleId, ConfigCoopRoleLevelAllLevelData.LogPair);
					return null;
				}
				CoopRoleLevel rootAsCoopRoleLevel = CoopRoleLevel.GetRootAsCoopRoleLevel(new ByteBuffer(item2));
				list.Add(rootAsCoopRoleLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("CoopRoleLevelAllLevelData");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1CoopRoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCoopRoleLevelAllLevelData.HandleId, ConfigCoopRoleLevelAllLevelData.LogPair);
			return list;
		}

		// Token: 0x04000BDE RID: 3038
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000BDF RID: 3039
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000BE0 RID: 3040
		private const string TABLE = "CoopRoleLevel";

		// Token: 0x04000BE1 RID: 3041
		private const string COMMAND = "select BinData from `CoopRoleLevel` where ActivityId=? AND CoopRoleId=?";

		// Token: 0x04000BE2 RID: 3042
		private const string KEY_PREFIX = "CoopRoleLevelAllLevelData";

		// Token: 0x04000BE3 RID: 3043
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BE4 RID: 3044
		private static int HandleId;
	}
}
