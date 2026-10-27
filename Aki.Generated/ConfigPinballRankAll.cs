using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000727 RID: 1831
	public class ConfigPinballRankAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AFA RID: 11002 RVA: 0x0014C5C0 File Offset: 0x0014A7C0
		static ConfigPinballRankAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRankAll.CreateStaticDefaultValue), new Action(ConfigPinballRankAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x0014C5E0 File Offset: 0x0014A7E0
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRankAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRankAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_活动.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRank"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRank`")
			});
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x0014C65F File Offset: 0x0014A85F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRankAll.LogPair = null;
			ConfigPinballRankAll.HandleId = 0;
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x0014C66D File Offset: 0x0014A86D
		public static void Init()
		{
			ConfigPinballRankAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRankAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballRank`");
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x0014C688 File Offset: 0x0014A888
		[NullableContext(2)]
		public static IReadOnlyList<PinballRank> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRankAll.HandleId, ConfigPinballRankAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballRank> readOnlyList = (IReadOnlyList<PinballRank>)ConfigCommon.GetConfig("PinballRankAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballRank> list = new List<PinballRank>();
			while (ConfigCommon.Step(ConfigPinballRankAll.HandleId, false, ConfigPinballRankAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRankAll.HandleId, 0, ConfigPinballRankAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballRankAll.HandleId, ConfigPinballRankAll.LogPair);
					return null;
				}
				PinballRank rootAsPinballRank = PinballRank.GetRootAsPinballRank(new ByteBuffer(item2));
				list.Add(rootAsPinballRank);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballRankAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballRankAll.HandleId, ConfigPinballRankAll.LogPair);
			return list;
		}

		// Token: 0x040031F7 RID: 12791
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031F8 RID: 12792
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x040031F9 RID: 12793
		private const string TABLE = "PinballRank";

		// Token: 0x040031FA RID: 12794
		private const string COMMAND = "select BinData from `PinballRank`";

		// Token: 0x040031FB RID: 12795
		private const string KEY_PREFIX = "PinballRankAll";

		// Token: 0x040031FC RID: 12796
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031FD RID: 12797
		private static int HandleId;
	}
}
