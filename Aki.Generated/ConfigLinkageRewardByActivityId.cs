using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DB RID: 1243
	public class ConfigLinkageRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D2D RID: 7469 RVA: 0x000FE1D8 File Offset: 0x000FC3D8
		static ConfigLinkageRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkageRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigLinkageRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000FE1F8 File Offset: 0x000FC3F8
		public static void CreateStaticDefaultValue()
		{
			ConfigLinkageRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLinkageRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_linkagereward.db"),
				new ValueTuple<string, object>("文件", "l.联动签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "LinkageReward"),
				new ValueTuple<string, object>("语句", "select BinData from `LinkageReward` where ActivityId=?")
			});
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x000FE277 File Offset: 0x000FC477
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkageRewardByActivityId.LogPair = null;
			ConfigLinkageRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x000FE285 File Offset: 0x000FC485
		public static void Init()
		{
			ConfigLinkageRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLinkageRewardByActivityId.HandleId, "db_linkagereward.db", "select BinData from `LinkageReward` where ActivityId=?");
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x000FE2A0 File Offset: 0x000FC4A0
		[NullableContext(2)]
		public static IReadOnlyList<LinkageReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLinkageRewardByActivityId.HandleId, ConfigLinkageRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkageRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<LinkageReward> readOnlyList = (IReadOnlyList<LinkageReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigLinkageRewardByActivityId.LogPair.Clear();
			ConfigLinkageRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigLinkageRewardByActivityId.HandleId, 1, p0ActivityId, ConfigLinkageRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigLinkageRewardByActivityId.HandleId, ConfigLinkageRewardByActivityId.LogPair);
				return null;
			}
			List<LinkageReward> list = new List<LinkageReward>();
			while (ConfigCommon.Step(ConfigLinkageRewardByActivityId.HandleId, false, ConfigLinkageRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLinkageRewardByActivityId.HandleId, 0, ConfigLinkageRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLinkageRewardByActivityId.HandleId, ConfigLinkageRewardByActivityId.LogPair);
					return null;
				}
				LinkageReward rootAsLinkageReward = LinkageReward.GetRootAsLinkageReward(new ByteBuffer(item2));
				list.Add(rootAsLinkageReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LinkageRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigLinkageRewardByActivityId.HandleId, ConfigLinkageRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x040021E1 RID: 8673
		private const string DB = "db_linkagereward.db";

		// Token: 0x040021E2 RID: 8674
		private const string FILE = "l.联动签到活动.xlsx";

		// Token: 0x040021E3 RID: 8675
		private const string TABLE = "LinkageReward";

		// Token: 0x040021E4 RID: 8676
		private const string COMMAND = "select BinData from `LinkageReward` where ActivityId=?";

		// Token: 0x040021E5 RID: 8677
		private const string KEY_PREFIX = "LinkageRewardByActivityId";

		// Token: 0x040021E6 RID: 8678
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021E7 RID: 8679
		private static int HandleId;
	}
}
