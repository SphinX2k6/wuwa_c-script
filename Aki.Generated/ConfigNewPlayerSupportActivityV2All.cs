using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F3 RID: 1523
	public class ConfigNewPlayerSupportActivityV2All : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023C1 RID: 9153 RVA: 0x00123A9D File Offset: 0x00121C9D
		static ConfigNewPlayerSupportActivityV2All()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupportActivityV2All.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupportActivityV2All.ResetStaticDefaultValue));
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00123ABC File Offset: 0x00121CBC
		public static void CreateStaticDefaultValue()
		{
			ConfigNewPlayerSupportActivityV2All.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewPlayerSupportActivityV2All.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新玩家助力活动V2.xlsx"),
				new ValueTuple<string, object>("表名", "NewPlayerSupportActivityV2"),
				new ValueTuple<string, object>("语句", "select BinData from `NewPlayerSupportActivityV2`")
			});
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00123B3B File Offset: 0x00121D3B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupportActivityV2All.LogPair = null;
			ConfigNewPlayerSupportActivityV2All.HandleId = 0;
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00123B49 File Offset: 0x00121D49
		public static void Init()
		{
			ConfigNewPlayerSupportActivityV2All.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupportActivityV2All.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewPlayerSupportActivityV2`");
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00123B64 File Offset: 0x00121D64
		[NullableContext(2)]
		public static IReadOnlyList<NewPlayerSupportActivityV2> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewPlayerSupportActivityV2All.HandleId, ConfigNewPlayerSupportActivityV2All.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewPlayerSupportActivityV2> readOnlyList = (IReadOnlyList<NewPlayerSupportActivityV2>)ConfigCommon.GetConfig("NewPlayerSupportActivityV2All");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewPlayerSupportActivityV2> list = new List<NewPlayerSupportActivityV2>();
			while (ConfigCommon.Step(ConfigNewPlayerSupportActivityV2All.HandleId, false, ConfigNewPlayerSupportActivityV2All.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewPlayerSupportActivityV2All.HandleId, 0, ConfigNewPlayerSupportActivityV2All.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewPlayerSupportActivityV2All.HandleId, ConfigNewPlayerSupportActivityV2All.LogPair);
					return null;
				}
				NewPlayerSupportActivityV2 rootAsNewPlayerSupportActivityV = NewPlayerSupportActivityV2.GetRootAsNewPlayerSupportActivityV2(new ByteBuffer(item2));
				list.Add(rootAsNewPlayerSupportActivityV);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewPlayerSupportActivityV2All", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewPlayerSupportActivityV2All.HandleId, ConfigNewPlayerSupportActivityV2All.LogPair);
			return list;
		}

		// Token: 0x0400298B RID: 10635
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x0400298C RID: 10636
		private const string FILE = "x.新玩家助力活动V2.xlsx";

		// Token: 0x0400298D RID: 10637
		private const string TABLE = "NewPlayerSupportActivityV2";

		// Token: 0x0400298E RID: 10638
		private const string COMMAND = "select BinData from `NewPlayerSupportActivityV2`";

		// Token: 0x0400298F RID: 10639
		private const string KEY_PREFIX = "NewPlayerSupportActivityV2All";

		// Token: 0x04002990 RID: 10640
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002991 RID: 10641
		private static int HandleId;
	}
}
