using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EF RID: 2287
	public class ConfigRoleTowerEchoLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035AD RID: 13741 RVA: 0x0018C26B File Offset: 0x0018A46B
		static ConfigRoleTowerEchoLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerEchoLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleTowerEchoLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x0018C28C File Offset: 0x0018A48C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerEchoLevelByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerEchoLevelByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerEchoLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerEchoLevel` where ActivityId=?")
			});
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x0018C30B File Offset: 0x0018A50B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerEchoLevelByActivityId.LogPair = null;
			ConfigRoleTowerEchoLevelByActivityId.HandleId = 0;
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x0018C319 File Offset: 0x0018A519
		public static void Init()
		{
			ConfigRoleTowerEchoLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerEchoLevelByActivityId.HandleId, "db_roletower.db", "select BinData from `RoleTowerEchoLevel` where ActivityId=?");
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x0018C334 File Offset: 0x0018A534
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerEchoLevel> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerEchoLevelByActivityId.HandleId, ConfigRoleTowerEchoLevelByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerEchoLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoleTowerEchoLevel> readOnlyList = (IReadOnlyList<RoleTowerEchoLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerEchoLevelByActivityId.LogPair.Clear();
			ConfigRoleTowerEchoLevelByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerEchoLevelByActivityId.HandleId, 1, p0ActivityId, ConfigRoleTowerEchoLevelByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerEchoLevelByActivityId.HandleId, ConfigRoleTowerEchoLevelByActivityId.LogPair);
				return null;
			}
			List<RoleTowerEchoLevel> list = new List<RoleTowerEchoLevel>();
			while (ConfigCommon.Step(ConfigRoleTowerEchoLevelByActivityId.HandleId, false, ConfigRoleTowerEchoLevelByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerEchoLevelByActivityId.HandleId, 0, ConfigRoleTowerEchoLevelByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerEchoLevelByActivityId.HandleId, ConfigRoleTowerEchoLevelByActivityId.LogPair);
					return null;
				}
				RoleTowerEchoLevel rootAsRoleTowerEchoLevel = RoleTowerEchoLevel.GetRootAsRoleTowerEchoLevel(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerEchoLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerEchoLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerEchoLevelByActivityId.HandleId, ConfigRoleTowerEchoLevelByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003E6F RID: 15983
		private const string DB = "db_roletower.db";

		// Token: 0x04003E70 RID: 15984
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003E71 RID: 15985
		private const string TABLE = "RoleTowerEchoLevel";

		// Token: 0x04003E72 RID: 15986
		private const string COMMAND = "select BinData from `RoleTowerEchoLevel` where ActivityId=?";

		// Token: 0x04003E73 RID: 15987
		private const string KEY_PREFIX = "RoleTowerEchoLevelByActivityId";

		// Token: 0x04003E74 RID: 15988
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E75 RID: 15989
		private static int HandleId;
	}
}
