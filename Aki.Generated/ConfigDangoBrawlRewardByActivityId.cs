using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D8 RID: 472
	public class ConfigDangoBrawlRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B13 RID: 2835 RVA: 0x000982DC File Offset: 0x000964DC
		static ConfigDangoBrawlRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x000982FC File Offset: 0x000964FC
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlReward"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlReward` where ActivityId=?")
			});
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0009837B File Offset: 0x0009657B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRewardByActivityId.LogPair = null;
			ConfigDangoBrawlRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00098389 File Offset: 0x00096589
		public static void Init()
		{
			ConfigDangoBrawlRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRewardByActivityId.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlReward` where ActivityId=?");
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x000983A4 File Offset: 0x000965A4
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlRewardByActivityId.HandleId, ConfigDangoBrawlRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<DangoBrawlReward> readOnlyList = (IReadOnlyList<DangoBrawlReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDangoBrawlRewardByActivityId.LogPair.Clear();
			ConfigDangoBrawlRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlRewardByActivityId.HandleId, 1, p0ActivityId, ConfigDangoBrawlRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigDangoBrawlRewardByActivityId.HandleId, ConfigDangoBrawlRewardByActivityId.LogPair);
				return null;
			}
			List<DangoBrawlReward> list = new List<DangoBrawlReward>();
			while (ConfigCommon.Step(ConfigDangoBrawlRewardByActivityId.HandleId, false, ConfigDangoBrawlRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlRewardByActivityId.HandleId, 0, ConfigDangoBrawlRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlRewardByActivityId.HandleId, ConfigDangoBrawlRewardByActivityId.LogPair);
					return null;
				}
				DangoBrawlReward rootAsDangoBrawlReward = DangoBrawlReward.GetRootAsDangoBrawlReward(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlRewardByActivityId.HandleId, ConfigDangoBrawlRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04000CCC RID: 3276
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CCD RID: 3277
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CCE RID: 3278
		private const string TABLE = "DangoBrawlReward";

		// Token: 0x04000CCF RID: 3279
		private const string COMMAND = "select BinData from `DangoBrawlReward` where ActivityId=?";

		// Token: 0x04000CD0 RID: 3280
		private const string KEY_PREFIX = "DangoBrawlRewardByActivityId";

		// Token: 0x04000CD1 RID: 3281
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CD2 RID: 3282
		private static int HandleId;
	}
}
