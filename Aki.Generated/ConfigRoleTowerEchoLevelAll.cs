using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EE RID: 2286
	public class ConfigRoleTowerEchoLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035A7 RID: 13735 RVA: 0x0018C0D8 File Offset: 0x0018A2D8
		static ConfigRoleTowerEchoLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerEchoLevelAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerEchoLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x0018C0F8 File Offset: 0x0018A2F8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerEchoLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerEchoLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerEchoLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerEchoLevel`")
			});
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x0018C177 File Offset: 0x0018A377
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerEchoLevelAll.LogPair = null;
			ConfigRoleTowerEchoLevelAll.HandleId = 0;
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x0018C185 File Offset: 0x0018A385
		public static void Init()
		{
			ConfigRoleTowerEchoLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerEchoLevelAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerEchoLevel`");
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x0018C1A0 File Offset: 0x0018A3A0
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerEchoLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerEchoLevelAll.HandleId, ConfigRoleTowerEchoLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerEchoLevel> readOnlyList = (IReadOnlyList<RoleTowerEchoLevel>)ConfigCommon.GetConfig("RoleTowerEchoLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerEchoLevel> list = new List<RoleTowerEchoLevel>();
			while (ConfigCommon.Step(ConfigRoleTowerEchoLevelAll.HandleId, false, ConfigRoleTowerEchoLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerEchoLevelAll.HandleId, 0, ConfigRoleTowerEchoLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerEchoLevelAll.HandleId, ConfigRoleTowerEchoLevelAll.LogPair);
					return null;
				}
				RoleTowerEchoLevel rootAsRoleTowerEchoLevel = RoleTowerEchoLevel.GetRootAsRoleTowerEchoLevel(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerEchoLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerEchoLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerEchoLevelAll.HandleId, ConfigRoleTowerEchoLevelAll.LogPair);
			return list;
		}

		// Token: 0x04003E68 RID: 15976
		private const string DB = "db_roletower.db";

		// Token: 0x04003E69 RID: 15977
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003E6A RID: 15978
		private const string TABLE = "RoleTowerEchoLevel";

		// Token: 0x04003E6B RID: 15979
		private const string COMMAND = "select BinData from `RoleTowerEchoLevel`";

		// Token: 0x04003E6C RID: 15980
		private const string KEY_PREFIX = "RoleTowerEchoLevelAll";

		// Token: 0x04003E6D RID: 15981
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E6E RID: 15982
		private static int HandleId;
	}
}
