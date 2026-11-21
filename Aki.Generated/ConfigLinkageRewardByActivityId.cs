using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F1 RID: 1265
	public class ConfigLinkageRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DB1 RID: 7601 RVA: 0x0010492C File Offset: 0x00102B2C
		static ConfigLinkageRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLinkageRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigLinkageRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0010494C File Offset: 0x00102B4C
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

		// Token: 0x06001DB3 RID: 7603 RVA: 0x001049CB File Offset: 0x00102BCB
		public static void ResetStaticDefaultValue()
		{
			ConfigLinkageRewardByActivityId.LogPair = null;
			ConfigLinkageRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x001049D9 File Offset: 0x00102BD9
		public static void Init()
		{
			ConfigLinkageRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigLinkageRewardByActivityId.HandleId, "db_linkagereward.db", "select BinData from `LinkageReward` where ActivityId=?");
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x001049F4 File Offset: 0x00102BF4
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

		// Token: 0x0400227B RID: 8827
		private const string DB = "db_linkagereward.db";

		// Token: 0x0400227C RID: 8828
		private const string FILE = "l.联动签到活动.xlsx";

		// Token: 0x0400227D RID: 8829
		private const string TABLE = "LinkageReward";

		// Token: 0x0400227E RID: 8830
		private const string COMMAND = "select BinData from `LinkageReward` where ActivityId=?";

		// Token: 0x0400227F RID: 8831
		private const string KEY_PREFIX = "LinkageRewardByActivityId";

		// Token: 0x04002280 RID: 8832
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002281 RID: 8833
		private static int HandleId;
	}
}
