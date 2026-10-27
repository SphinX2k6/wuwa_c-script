using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000742 RID: 1858
	public class ConfigPlayerHeadReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B9D RID: 11165 RVA: 0x001501CB File Offset: 0x0014E3CB
		static ConfigPlayerHeadReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerHeadReAll.CreateStaticDefaultValue), new Action(ConfigPlayerHeadReAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x001501EC File Offset: 0x0014E3EC
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerHeadReAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerHeadReAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_playerhead.db"),
				new ValueTuple<string, object>("文件", "w.玩家头像.xlsx"),
				new ValueTuple<string, object>("表名", "PlayerHeadRe"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerHeadRe`")
			});
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x0015026B File Offset: 0x0014E46B
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerHeadReAll.LogPair = null;
			ConfigPlayerHeadReAll.HandleId = 0;
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00150279 File Offset: 0x0014E479
		public static void Init()
		{
			ConfigPlayerHeadReAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerHeadReAll.HandleId, "db_playerhead.db", "select BinData from `PlayerHeadRe`");
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00150294 File Offset: 0x0014E494
		[NullableContext(2)]
		public static IReadOnlyList<PlayerHeadRe> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerHeadReAll.HandleId, ConfigPlayerHeadReAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PlayerHeadRe> readOnlyList = (IReadOnlyList<PlayerHeadRe>)ConfigCommon.GetConfig("PlayerHeadReAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PlayerHeadRe> list = new List<PlayerHeadRe>();
			while (ConfigCommon.Step(ConfigPlayerHeadReAll.HandleId, false, ConfigPlayerHeadReAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerHeadReAll.HandleId, 0, ConfigPlayerHeadReAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlayerHeadReAll.HandleId, ConfigPlayerHeadReAll.LogPair);
					return null;
				}
				PlayerHeadRe rootAsPlayerHeadRe = PlayerHeadRe.GetRootAsPlayerHeadRe(new ByteBuffer(item2));
				list.Add(rootAsPlayerHeadRe);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PlayerHeadReAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlayerHeadReAll.HandleId, ConfigPlayerHeadReAll.LogPair);
			return list;
		}

		// Token: 0x040032B4 RID: 12980
		private const string DB = "db_playerhead.db";

		// Token: 0x040032B5 RID: 12981
		private const string FILE = "w.玩家头像.xlsx";

		// Token: 0x040032B6 RID: 12982
		private const string TABLE = "PlayerHeadRe";

		// Token: 0x040032B7 RID: 12983
		private const string COMMAND = "select BinData from `PlayerHeadRe`";

		// Token: 0x040032B8 RID: 12984
		private const string KEY_PREFIX = "PlayerHeadReAll";

		// Token: 0x040032B9 RID: 12985
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032BA RID: 12986
		private static int HandleId;
	}
}
