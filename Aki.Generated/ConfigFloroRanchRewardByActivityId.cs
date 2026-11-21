using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000337 RID: 823
	public class ConfigFloroRanchRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600134F RID: 4943 RVA: 0x000CA160 File Offset: 0x000C8360
		static ConfigFloroRanchRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigFloroRanchRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x000CA180 File Offset: 0x000C8380
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchReward"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchReward` where ActivityId=?")
			});
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x000CA1FF File Offset: 0x000C83FF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRewardByActivityId.LogPair = null;
			ConfigFloroRanchRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x000CA20D File Offset: 0x000C840D
		public static void Init()
		{
			ConfigFloroRanchRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRewardByActivityId.HandleId, "db_flororanch.db", "select BinData from `FloroRanchReward` where ActivityId=?");
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x000CA228 File Offset: 0x000C8428
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchRewardByActivityId.HandleId, ConfigFloroRanchRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<FloroRanchReward> readOnlyList = (IReadOnlyList<FloroRanchReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFloroRanchRewardByActivityId.LogPair.Clear();
			ConfigFloroRanchRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFloroRanchRewardByActivityId.HandleId, 1, p0ActivityId, ConfigFloroRanchRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFloroRanchRewardByActivityId.HandleId, ConfigFloroRanchRewardByActivityId.LogPair);
				return null;
			}
			List<FloroRanchReward> list = new List<FloroRanchReward>();
			while (ConfigCommon.Step(ConfigFloroRanchRewardByActivityId.HandleId, false, ConfigFloroRanchRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchRewardByActivityId.HandleId, 0, ConfigFloroRanchRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchRewardByActivityId.HandleId, ConfigFloroRanchRewardByActivityId.LogPair);
					return null;
				}
				FloroRanchReward rootAsFloroRanchReward = FloroRanchReward.GetRootAsFloroRanchReward(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchRewardByActivityId.HandleId, ConfigFloroRanchRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001665 RID: 5733
		private const string DB = "db_flororanch.db";

		// Token: 0x04001666 RID: 5734
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001667 RID: 5735
		private const string TABLE = "FloroRanchReward";

		// Token: 0x04001668 RID: 5736
		private const string COMMAND = "select BinData from `FloroRanchReward` where ActivityId=?";

		// Token: 0x04001669 RID: 5737
		private const string KEY_PREFIX = "FloroRanchRewardByActivityId";

		// Token: 0x0400166A RID: 5738
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400166B RID: 5739
		private static int HandleId;
	}
}
