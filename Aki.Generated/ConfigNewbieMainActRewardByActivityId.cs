using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000602 RID: 1538
	public class ConfigNewbieMainActRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600241B RID: 9243 RVA: 0x00129278 File Offset: 0x00127478
		static ConfigNewbieMainActRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigNewbieMainActRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00129298 File Offset: 0x00127498
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieMainActRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieMainActRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手主线奖励新.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieMainActReward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieMainActReward` where ActivityId=?")
			});
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00129317 File Offset: 0x00127517
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActRewardByActivityId.LogPair = null;
			ConfigNewbieMainActRewardByActivityId.HandleId = 0;
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00129325 File Offset: 0x00127525
		public static void Init()
		{
			ConfigNewbieMainActRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActRewardByActivityId.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActReward` where ActivityId=?");
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00129340 File Offset: 0x00127540
		[NullableContext(2)]
		public static IReadOnlyList<NewbieMainActReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieMainActRewardByActivityId.HandleId, ConfigNewbieMainActRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<NewbieMainActReward> readOnlyList = (IReadOnlyList<NewbieMainActReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewbieMainActRewardByActivityId.LogPair.Clear();
			ConfigNewbieMainActRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigNewbieMainActRewardByActivityId.HandleId, 1, p0ActivityId, ConfigNewbieMainActRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewbieMainActRewardByActivityId.HandleId, ConfigNewbieMainActRewardByActivityId.LogPair);
				return null;
			}
			List<NewbieMainActReward> list = new List<NewbieMainActReward>();
			while (ConfigCommon.Step(ConfigNewbieMainActRewardByActivityId.HandleId, false, ConfigNewbieMainActRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieMainActRewardByActivityId.HandleId, 0, ConfigNewbieMainActRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieMainActRewardByActivityId.HandleId, ConfigNewbieMainActRewardByActivityId.LogPair);
					return null;
				}
				NewbieMainActReward rootAsNewbieMainActReward = NewbieMainActReward.GetRootAsNewbieMainActReward(new ByteBuffer(item2));
				list.Add(rootAsNewbieMainActReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieMainActRewardByActivityId.HandleId, ConfigNewbieMainActRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x040029F4 RID: 10740
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x040029F5 RID: 10741
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x040029F6 RID: 10742
		private const string TABLE = "NewbieMainActReward";

		// Token: 0x040029F7 RID: 10743
		private const string COMMAND = "select BinData from `NewbieMainActReward` where ActivityId=?";

		// Token: 0x040029F8 RID: 10744
		private const string KEY_PREFIX = "NewbieMainActRewardByActivityId";

		// Token: 0x040029F9 RID: 10745
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029FA RID: 10746
		private static int HandleId;
	}
}
