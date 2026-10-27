using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000535 RID: 1333
	public class ConfigMatchThreeRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F49 RID: 8009 RVA: 0x0010A2A4 File Offset: 0x001084A4
		static ConfigMatchThreeRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeRoleAll.CreateStaticDefaultValue), new Action(ConfigMatchThreeRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x0010A2C4 File Offset: 0x001084C4
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

		// Token: 0x06001F4B RID: 8011 RVA: 0x0010A343 File Offset: 0x00108543
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeRoleAll.LogPair = null;
			ConfigMatchThreeRoleAll.HandleId = 0;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0010A351 File Offset: 0x00108551
		public static void Init()
		{
			ConfigMatchThreeRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeRoleAll.HandleId, "db_activitymatchthree.db", "select BinData from `MatchThreeRole`");
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0010A36C File Offset: 0x0010856C
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

		// Token: 0x04002457 RID: 9303
		private const string DB = "db_activitymatchthree.db";

		// Token: 0x04002458 RID: 9304
		private const string FILE = "s.三消活动.xlsx";

		// Token: 0x04002459 RID: 9305
		private const string TABLE = "MatchThreeRole";

		// Token: 0x0400245A RID: 9306
		private const string COMMAND = "select BinData from `MatchThreeRole`";

		// Token: 0x0400245B RID: 9307
		private const string KEY_PREFIX = "MatchThreeRoleAll";

		// Token: 0x0400245C RID: 9308
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400245D RID: 9309
		private static int HandleId;
	}
}
