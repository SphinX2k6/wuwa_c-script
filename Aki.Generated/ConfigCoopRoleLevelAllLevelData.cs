using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A4 RID: 420
	public class ConfigCoopRoleLevelAllLevelData : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009DB RID: 2523 RVA: 0x00091318 File Offset: 0x0008F518
		static ConfigCoopRoleLevelAllLevelData()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopRoleLevelAllLevelData.CreateStaticDefaultValue), new Action(ConfigCoopRoleLevelAllLevelData.ResetStaticDefaultValue));
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00091338 File Offset: 0x0008F538
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

		// Token: 0x060009DD RID: 2525 RVA: 0x000913B7 File Offset: 0x0008F5B7
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopRoleLevelAllLevelData.LogPair = null;
			ConfigCoopRoleLevelAllLevelData.HandleId = 0;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000913C5 File Offset: 0x0008F5C5
		public static void Init()
		{
			ConfigCoopRoleLevelAllLevelData.HandleId = ConfigCommon.InitDataStatement(ConfigCoopRoleLevelAllLevelData.HandleId, "db_cooprolelevel.db", "select BinData from `CoopRoleLevel` where ActivityId=? AND CoopRoleId=?");
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000913E0 File Offset: 0x0008F5E0
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

		// Token: 0x04000B60 RID: 2912
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000B61 RID: 2913
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000B62 RID: 2914
		private const string TABLE = "CoopRoleLevel";

		// Token: 0x04000B63 RID: 2915
		private const string COMMAND = "select BinData from `CoopRoleLevel` where ActivityId=? AND CoopRoleId=?";

		// Token: 0x04000B64 RID: 2916
		private const string KEY_PREFIX = "CoopRoleLevelAllLevelData";

		// Token: 0x04000B65 RID: 2917
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B66 RID: 2918
		private static int HandleId;
	}
}
