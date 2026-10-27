using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092C RID: 2348
	public class ConfigSignRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600371B RID: 14107 RVA: 0x00190F14 File Offset: 0x0018F114
		static ConfigSignRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSignRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigSignRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00190F34 File Offset: 0x0018F134
		public static void CreateStaticDefaultValue()
		{
			ConfigSignRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSignRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "SignReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SignReward` where ActivityId=?")
			});
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00190FB3 File Offset: 0x0018F1B3
		public static void ResetStaticDefaultValue()
		{
			ConfigSignRewardByActivityId.LogPair = null;
			ConfigSignRewardByActivityId.HandleId = 0;
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00190FC1 File Offset: 0x0018F1C1
		public static void Init()
		{
			ConfigSignRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSignRewardByActivityId.HandleId, "db_circumfluence.db", "select BinData from `SignReward` where ActivityId=?");
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x00190FDC File Offset: 0x0018F1DC
		[NullableContext(2)]
		public static IReadOnlyList<SignReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSignRewardByActivityId.HandleId, ConfigSignRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SignRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SignReward> readOnlyList = (IReadOnlyList<SignReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSignRewardByActivityId.LogPair.Clear();
			ConfigSignRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSignRewardByActivityId.HandleId, 1, p0ActivityId, ConfigSignRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSignRewardByActivityId.HandleId, ConfigSignRewardByActivityId.LogPair);
				return null;
			}
			List<SignReward> list = new List<SignReward>();
			while (ConfigCommon.Step(ConfigSignRewardByActivityId.HandleId, false, ConfigSignRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSignRewardByActivityId.HandleId, 0, ConfigSignRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSignRewardByActivityId.HandleId, ConfigSignRewardByActivityId.LogPair);
					return null;
				}
				SignReward rootAsSignReward = SignReward.GetRootAsSignReward(new ByteBuffer(item2));
				list.Add(rootAsSignReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SignRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSignRewardByActivityId.HandleId, ConfigSignRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400401A RID: 16410
		private const string DB = "db_circumfluence.db";

		// Token: 0x0400401B RID: 16411
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x0400401C RID: 16412
		private const string TABLE = "SignReward";

		// Token: 0x0400401D RID: 16413
		private const string COMMAND = "select BinData from `SignReward` where ActivityId=?";

		// Token: 0x0400401E RID: 16414
		private const string KEY_PREFIX = "SignRewardByActivityId";

		// Token: 0x0400401F RID: 16415
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004020 RID: 16416
		private static int HandleId;
	}
}
