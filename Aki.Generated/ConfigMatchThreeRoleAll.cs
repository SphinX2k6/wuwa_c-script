using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054B RID: 1355
	public class ConfigMatchThreeRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FCD RID: 8141 RVA: 0x001109F8 File Offset: 0x0010EBF8
		static ConfigMatchThreeRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeRoleAll.CreateStaticDefaultValue), new Action(ConfigMatchThreeRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00110A18 File Offset: 0x0010EC18
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymatchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeRole"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeRole`")
			});
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00110A97 File Offset: 0x0010EC97
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeRoleAll.LogPair = null;
			ConfigMatchThreeRoleAll.HandleId = 0;
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00110AA5 File Offset: 0x0010ECA5
		public static void Init()
		{
			ConfigMatchThreeRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeRoleAll.HandleId, "db_activitymatchthree.db", "select BinData from `MatchThreeRole`");
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00110AC0 File Offset: 0x0010ECC0
		[NullableContext(2)]
		public static IReadOnlyList<MatchThreeRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeRoleAll.HandleId, ConfigMatchThreeRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MatchThreeRole> readOnlyList = (IReadOnlyList<MatchThreeRole>)ConfigCommon.GetConfig("MatchThreeRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MatchThreeRole> list = new List<MatchThreeRole>();
			while (ConfigCommon.Step(ConfigMatchThreeRoleAll.HandleId, false, ConfigMatchThreeRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeRoleAll.HandleId, 0, ConfigMatchThreeRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMatchThreeRoleAll.HandleId, ConfigMatchThreeRoleAll.LogPair);
					return null;
				}
				MatchThreeRole rootAsMatchThreeRole = MatchThreeRole.GetRootAsMatchThreeRole(new ByteBuffer(item2));
				list.Add(rootAsMatchThreeRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MatchThreeRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMatchThreeRoleAll.HandleId, ConfigMatchThreeRoleAll.LogPair);
			return list;
		}

		// Token: 0x040024F1 RID: 9457
		private const string DB = "db_activitymatchthree.db";

		// Token: 0x040024F2 RID: 9458
		private const string FILE = "s.三消活动.xlsx";

		// Token: 0x040024F3 RID: 9459
		private const string TABLE = "MatchThreeRole";

		// Token: 0x040024F4 RID: 9460
		private const string COMMAND = "select BinData from `MatchThreeRole`";

		// Token: 0x040024F5 RID: 9461
		private const string KEY_PREFIX = "MatchThreeRoleAll";

		// Token: 0x040024F6 RID: 9462
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024F7 RID: 9463
		private static int HandleId;
	}
}
