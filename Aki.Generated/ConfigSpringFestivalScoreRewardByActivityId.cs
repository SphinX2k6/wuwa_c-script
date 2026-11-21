using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A56 RID: 2646
	public class ConfigSpringFestivalScoreRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E18 RID: 15896 RVA: 0x001BBA90 File Offset: 0x001B9C90
		static ConfigSpringFestivalScoreRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalScoreRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalScoreRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x001BBAB0 File Offset: 0x001B9CB0
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalScoreRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalScoreRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalScoreReward` where Activity=?")
			});
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x001BBB2F File Offset: 0x001B9D2F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalScoreRewardByActivityId.LogPair = null;
			ConfigSpringFestivalScoreRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x001BBB3D File Offset: 0x001B9D3D
		public static void Init()
		{
			ConfigSpringFestivalScoreRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalScoreRewardByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalScoreReward` where Activity=?");
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x001BBB58 File Offset: 0x001B9D58
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestivalScoreReward> GetConfigList(int p0Activity, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalScoreRewardByActivityId.HandleId, ConfigSpringFestivalScoreRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Activity);
				IReadOnlyList<SpringFestivalScoreReward> readOnlyList = (IReadOnlyList<SpringFestivalScoreReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSpringFestivalScoreRewardByActivityId.LogPair.Clear();
			ConfigSpringFestivalScoreRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("Activity", p0Activity));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalScoreRewardByActivityId.HandleId, 1, p0Activity, ConfigSpringFestivalScoreRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSpringFestivalScoreRewardByActivityId.HandleId, ConfigSpringFestivalScoreRewardByActivityId.LogPair);
				return null;
			}
			List<SpringFestivalScoreReward> list = new List<SpringFestivalScoreReward>();
			while (ConfigCommon.Step(ConfigSpringFestivalScoreRewardByActivityId.HandleId, false, ConfigSpringFestivalScoreRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalScoreRewardByActivityId.HandleId, 0, ConfigSpringFestivalScoreRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalScoreRewardByActivityId.HandleId, ConfigSpringFestivalScoreRewardByActivityId.LogPair);
					return null;
				}
				SpringFestivalScoreReward rootAsSpringFestivalScoreReward = SpringFestivalScoreReward.GetRootAsSpringFestivalScoreReward(new ByteBuffer(item2));
				list.Add(rootAsSpringFestivalScoreReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Activity);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalScoreRewardByActivityId.HandleId, ConfigSpringFestivalScoreRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004840 RID: 18496
		private const string DB = "db_spring26.db";

		// Token: 0x04004841 RID: 18497
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004842 RID: 18498
		private const string TABLE = "SpringFestivalScoreReward";

		// Token: 0x04004843 RID: 18499
		private const string COMMAND = "select BinData from `SpringFestivalScoreReward` where Activity=?";

		// Token: 0x04004844 RID: 18500
		private const string KEY_PREFIX = "SpringFestivalScoreRewardByActivityId";

		// Token: 0x04004845 RID: 18501
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004846 RID: 18502
		private static int HandleId;
	}
}
