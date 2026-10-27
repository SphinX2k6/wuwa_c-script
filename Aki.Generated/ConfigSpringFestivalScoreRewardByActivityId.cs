using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000981 RID: 2433
	public class ConfigSpringFestivalScoreRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600391A RID: 14618 RVA: 0x0019C6FC File Offset: 0x0019A8FC
		static ConfigSpringFestivalScoreRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalScoreRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalScoreRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x0019C71C File Offset: 0x0019A91C
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

		// Token: 0x0600391C RID: 14620 RVA: 0x0019C79B File Offset: 0x0019A99B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalScoreRewardByActivityId.LogPair = null;
			ConfigSpringFestivalScoreRewardByActivityId.HandleId = 0;
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x0019C7A9 File Offset: 0x0019A9A9
		public static void Init()
		{
			ConfigSpringFestivalScoreRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalScoreRewardByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalScoreReward` where Activity=?");
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x0019C7C4 File Offset: 0x0019A9C4
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

		// Token: 0x0400426D RID: 17005
		private const string DB = "db_spring26.db";

		// Token: 0x0400426E RID: 17006
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400426F RID: 17007
		private const string TABLE = "SpringFestivalScoreReward";

		// Token: 0x04004270 RID: 17008
		private const string COMMAND = "select BinData from `SpringFestivalScoreReward` where Activity=?";

		// Token: 0x04004271 RID: 17009
		private const string KEY_PREFIX = "SpringFestivalScoreRewardByActivityId";

		// Token: 0x04004272 RID: 17010
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004273 RID: 17011
		private static int HandleId;
	}
}
