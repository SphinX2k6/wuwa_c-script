using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000772 RID: 1906
	public class ConfigPreheatSignReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CBD RID: 11453 RVA: 0x00159B50 File Offset: 0x00157D50
		static ConfigPreheatSignReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPreheatSignReAll.CreateStaticDefaultValue), new Action(ConfigPreheatSignReAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00159B70 File Offset: 0x00157D70
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

		// Token: 0x06002CBF RID: 11455 RVA: 0x00159BEF File Offset: 0x00157DEF
		public static void ResetStaticDefaultValue()
		{
			ConfigPreheatSignReAll.LogPair = null;
			ConfigPreheatSignReAll.HandleId = 0;
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x00159BFD File Offset: 0x00157DFD
		public static void Init()
		{
			ConfigPreheatSignReAll.HandleId = ConfigCommon.InitDataStatement(ConfigPreheatSignReAll.HandleId, "db_preheat.db", "select BinData from `PreheatSignRe`");
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x00159C18 File Offset: 0x00157E18
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

		// Token: 0x04003404 RID: 13316
		private const string DB = "db_preheat.db";

		// Token: 0x04003405 RID: 13317
		private const string FILE = "y.预热签到活动.xlsx";

		// Token: 0x04003406 RID: 13318
		private const string TABLE = "PreheatSignRe";

		// Token: 0x04003407 RID: 13319
		private const string COMMAND = "select BinData from `PreheatSignRe`";

		// Token: 0x04003408 RID: 13320
		private const string KEY_PREFIX = "PreheatSignReAll";

		// Token: 0x04003409 RID: 13321
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400340A RID: 13322
		private static int HandleId;
	}
}
