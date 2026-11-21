using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A52 RID: 2642
	public class ConfigSpringFestivalRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E00 RID: 15872 RVA: 0x001BB190 File Offset: 0x001B9390
		static ConfigSpringFestivalRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x001BB1B0 File Offset: 0x001B93B0
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalReward` where ActivityId=?")
			});
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x001BB22F File Offset: 0x001B942F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalRewardByActivityId.LogPair = null;
			ConfigSpringFestivalRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x001BB23D File Offset: 0x001B943D
		public static void Init()
		{
			ConfigSpringFestivalRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalRewardByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalReward` where ActivityId=?");
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x001BB258 File Offset: 0x001B9458
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestivalReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalRewardByActivityId.HandleId, ConfigSpringFestivalRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SpringFestivalReward> readOnlyList = (IReadOnlyList<SpringFestivalReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSpringFestivalRewardByActivityId.LogPair.Clear();
			ConfigSpringFestivalRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalRewardByActivityId.HandleId, 1, p0ActivityId, ConfigSpringFestivalRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSpringFestivalRewardByActivityId.HandleId, ConfigSpringFestivalRewardByActivityId.LogPair);
				return null;
			}
			List<SpringFestivalReward> list = new List<SpringFestivalReward>();
			while (ConfigCommon.Step(ConfigSpringFestivalRewardByActivityId.HandleId, false, ConfigSpringFestivalRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalRewardByActivityId.HandleId, 0, ConfigSpringFestivalRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalRewardByActivityId.HandleId, ConfigSpringFestivalRewardByActivityId.LogPair);
					return null;
				}
				SpringFestivalReward rootAsSpringFestivalReward = SpringFestivalReward.GetRootAsSpringFestivalReward(new ByteBuffer(item2));
				list.Add(rootAsSpringFestivalReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalRewardByActivityId.HandleId, ConfigSpringFestivalRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004824 RID: 18468
		private const string DB = "db_spring26.db";

		// Token: 0x04004825 RID: 18469
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004826 RID: 18470
		private const string TABLE = "SpringFestivalReward";

		// Token: 0x04004827 RID: 18471
		private const string COMMAND = "select BinData from `SpringFestivalReward` where ActivityId=?";

		// Token: 0x04004828 RID: 18472
		private const string KEY_PREFIX = "SpringFestivalRewardByActivityId";

		// Token: 0x04004829 RID: 18473
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400482A RID: 18474
		private static int HandleId;
	}
}
