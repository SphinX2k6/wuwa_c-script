using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060B RID: 1547
	public class ConfigNewPlayerSupportActivityV2All : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002451 RID: 9297 RVA: 0x0012A519 File Offset: 0x00128719
		static ConfigNewPlayerSupportActivityV2All()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupportActivityV2All.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupportActivityV2All.ResetStaticDefaultValue));
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x0012A538 File Offset: 0x00128738
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

		// Token: 0x06002453 RID: 9299 RVA: 0x0012A5B7 File Offset: 0x001287B7
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupportActivityV2All.LogPair = null;
			ConfigNewPlayerSupportActivityV2All.HandleId = 0;
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0012A5C5 File Offset: 0x001287C5
		public static void Init()
		{
			ConfigNewPlayerSupportActivityV2All.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupportActivityV2All.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewPlayerSupportActivityV2`");
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0012A5E0 File Offset: 0x001287E0
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

		// Token: 0x04002A33 RID: 10803
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A34 RID: 10804
		private const string FILE = "x.新玩家助力活动V2.xlsx";

		// Token: 0x04002A35 RID: 10805
		private const string TABLE = "NewPlayerSupportActivityV2";

		// Token: 0x04002A36 RID: 10806
		private const string COMMAND = "select BinData from `NewPlayerSupportActivityV2`";

		// Token: 0x04002A37 RID: 10807
		private const string KEY_PREFIX = "NewPlayerSupportActivityV2All";

		// Token: 0x04002A38 RID: 10808
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A39 RID: 10809
		private static int HandleId;
	}
}
