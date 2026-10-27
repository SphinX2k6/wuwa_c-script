using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000596 RID: 1430
	public class ConfigMotorFightRankAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x00117538 File Offset: 0x00115738
		static ConfigMotorFightRankAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightRankAll.CreateStaticDefaultValue), new Action(ConfigMotorFightRankAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00117558 File Offset: 0x00115758
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightRankAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightRankAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightRank"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightRank`")
			});
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x001175D7 File Offset: 0x001157D7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightRankAll.LogPair = null;
			ConfigMotorFightRankAll.HandleId = 0;
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x001175E5 File Offset: 0x001157E5
		public static void Init()
		{
			ConfigMotorFightRankAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightRankAll.HandleId, "db_motorfight.db", "select BinData from `MotorFightRank`");
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00117600 File Offset: 0x00115800
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightRank> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightRankAll.HandleId, ConfigMotorFightRankAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorFightRank> readOnlyList = (IReadOnlyList<MotorFightRank>)ConfigCommon.GetConfig("MotorFightRankAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorFightRank> list = new List<MotorFightRank>();
			while (ConfigCommon.Step(ConfigMotorFightRankAll.HandleId, false, ConfigMotorFightRankAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightRankAll.HandleId, 0, ConfigMotorFightRankAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightRankAll.HandleId, ConfigMotorFightRankAll.LogPair);
					return null;
				}
				MotorFightRank rootAsMotorFightRank = MotorFightRank.GetRootAsMotorFightRank(new ByteBuffer(item2));
				list.Add(rootAsMotorFightRank);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorFightRankAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightRankAll.HandleId, ConfigMotorFightRankAll.LogPair);
			return list;
		}

		// Token: 0x040026FE RID: 9982
		private const string DB = "db_motorfight.db";

		// Token: 0x040026FF RID: 9983
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002700 RID: 9984
		private const string TABLE = "MotorFightRank";

		// Token: 0x04002701 RID: 9985
		private const string COMMAND = "select BinData from `MotorFightRank`";

		// Token: 0x04002702 RID: 9986
		private const string KEY_PREFIX = "MotorFightRankAll";

		// Token: 0x04002703 RID: 9987
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002704 RID: 9988
		private static int HandleId;
	}
}
