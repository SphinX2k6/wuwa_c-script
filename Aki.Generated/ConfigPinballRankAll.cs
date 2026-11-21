using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073F RID: 1855
	public class ConfigPinballRankAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B8A RID: 11146 RVA: 0x0015303C File Offset: 0x0015123C
		static ConfigPinballRankAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRankAll.CreateStaticDefaultValue), new Action(ConfigPinballRankAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x0015305C File Offset: 0x0015125C
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

		// Token: 0x06002B8C RID: 11148 RVA: 0x001530DB File Offset: 0x001512DB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRankAll.LogPair = null;
			ConfigPinballRankAll.HandleId = 0;
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x001530E9 File Offset: 0x001512E9
		public static void Init()
		{
			ConfigPinballRankAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRankAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballRank`");
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00153104 File Offset: 0x00151304
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

		// Token: 0x0400329F RID: 12959
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032A0 RID: 12960
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x040032A1 RID: 12961
		private const string TABLE = "PinballRank";

		// Token: 0x040032A2 RID: 12962
		private const string COMMAND = "select BinData from `PinballRank`";

		// Token: 0x040032A3 RID: 12963
		private const string KEY_PREFIX = "PinballRankAll";

		// Token: 0x040032A4 RID: 12964
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032A5 RID: 12965
		private static int HandleId;
	}
}
