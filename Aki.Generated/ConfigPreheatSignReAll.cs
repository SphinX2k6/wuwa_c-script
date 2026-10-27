using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075A RID: 1882
	public class ConfigPreheatSignReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C2D RID: 11309 RVA: 0x001530D4 File Offset: 0x001512D4
		static ConfigPreheatSignReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatSignReAll.CreateStaticDefaultValue), new Action(ConfigPreheatSignReAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x001530F4 File Offset: 0x001512F4
		public static void CreateStaticDefaultValue()
		{
			ConfigPreheatSignReAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPreheatSignReAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_preheat.db"),
				new ValueTuple<string, object>("文件", "y.预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "PreheatSignRe"),
				new ValueTuple<string, object>("语句", "select BinData from `PreheatSignRe`")
			});
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00153173 File Offset: 0x00151373
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatSignReAll.LogPair = null;
			ConfigPreheatSignReAll.HandleId = 0;
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x00153181 File Offset: 0x00151381
		public static void Init()
		{
			ConfigPreheatSignReAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatSignReAll.HandleId, "db_preheat.db", "select BinData from `PreheatSignRe`");
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x0015319C File Offset: 0x0015139C
		[NullableContext(2)]
		public static IReadOnlyList<PreheatSignRe> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPreheatSignReAll.HandleId, ConfigPreheatSignReAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PreheatSignRe> readOnlyList = (IReadOnlyList<PreheatSignRe>)ConfigCommon.GetConfig("PreheatSignReAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PreheatSignRe> list = new List<PreheatSignRe>();
			while (ConfigCommon.Step(ConfigPreheatSignReAll.HandleId, false, ConfigPreheatSignReAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPreheatSignReAll.HandleId, 0, ConfigPreheatSignReAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPreheatSignReAll.HandleId, ConfigPreheatSignReAll.LogPair);
					return null;
				}
				PreheatSignRe rootAsPreheatSignRe = PreheatSignRe.GetRootAsPreheatSignRe(new ByteBuffer(item2));
				list.Add(rootAsPreheatSignRe);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PreheatSignReAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPreheatSignReAll.HandleId, ConfigPreheatSignReAll.LogPair);
			return list;
		}

		// Token: 0x0400335C RID: 13148
		private const string DB = "db_preheat.db";

		// Token: 0x0400335D RID: 13149
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x0400335E RID: 13150
		private const string TABLE = "PreheatSignRe";

		// Token: 0x0400335F RID: 13151
		private const string COMMAND = "select BinData from `PreheatSignRe`";

		// Token: 0x04003360 RID: 13152
		private const string KEY_PREFIX = "PreheatSignReAll";

		// Token: 0x04003361 RID: 13153
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003362 RID: 13154
		private static int HandleId;
	}
}
