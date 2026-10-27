using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097D RID: 2429
	public class ConfigSpringFestivalRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003902 RID: 14594 RVA: 0x0019BDFC File Offset: 0x00199FFC
		static ConfigSpringFestivalRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigSpringFestivalRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x0019BE1C File Offset: 0x0019A01C
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

		// Token: 0x06003904 RID: 14596 RVA: 0x0019BE9B File Offset: 0x0019A09B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalRewardByActivityId.LogPair = null;
			ConfigSpringFestivalRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0019BEA9 File Offset: 0x0019A0A9
		public static void Init()
		{
			ConfigSpringFestivalRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalRewardByActivityId.HandleId, "db_spring26.db", "select BinData from `SpringFestivalReward` where ActivityId=?");
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x0019BEC4 File Offset: 0x0019A0C4
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

		// Token: 0x04004251 RID: 16977
		private const string DB = "db_spring26.db";

		// Token: 0x04004252 RID: 16978
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004253 RID: 16979
		private const string TABLE = "SpringFestivalReward";

		// Token: 0x04004254 RID: 16980
		private const string COMMAND = "select BinData from `SpringFestivalReward` where ActivityId=?";

		// Token: 0x04004255 RID: 16981
		private const string KEY_PREFIX = "SpringFestivalRewardByActivityId";

		// Token: 0x04004256 RID: 16982
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004257 RID: 16983
		private static int HandleId;
	}
}
