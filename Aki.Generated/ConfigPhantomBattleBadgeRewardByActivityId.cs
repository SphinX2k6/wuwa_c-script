using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000673 RID: 1651
	public class ConfigPhantomBattleBadgeRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026C2 RID: 9922 RVA: 0x00138484 File Offset: 0x00136684
		static ConfigPhantomBattleBadgeRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x001384A4 File Offset: 0x001366A4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleBadgeRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleBadgeReward"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleBadgeReward` where ActivityId=?")
			});
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00138523 File Offset: 0x00136723
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeRewardByActivityId.LogPair = null;
			ConfigPhantomBattleBadgeRewardByActivityId.HandleId = 0;
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00138531 File Offset: 0x00136731
		public static void Init()
		{
			ConfigPhantomBattleBadgeRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeRewardByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadgeReward` where ActivityId=?");
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x0013854C File Offset: 0x0013674C
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleBadgeReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleBadgeRewardByActivityId.HandleId, ConfigPhantomBattleBadgeRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomBattleBadgeReward> readOnlyList = (IReadOnlyList<PhantomBattleBadgeReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleBadgeRewardByActivityId.LogPair.Clear();
			ConfigPhantomBattleBadgeRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleBadgeRewardByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleBadgeRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleBadgeRewardByActivityId.HandleId, ConfigPhantomBattleBadgeRewardByActivityId.LogPair);
				return null;
			}
			List<PhantomBattleBadgeReward> list = new List<PhantomBattleBadgeReward>();
			while (ConfigCommon.Step(ConfigPhantomBattleBadgeRewardByActivityId.HandleId, false, ConfigPhantomBattleBadgeRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleBadgeRewardByActivityId.HandleId, 0, ConfigPhantomBattleBadgeRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleBadgeRewardByActivityId.HandleId, ConfigPhantomBattleBadgeRewardByActivityId.LogPair);
					return null;
				}
				PhantomBattleBadgeReward rootAsPhantomBattleBadgeReward = PhantomBattleBadgeReward.GetRootAsPhantomBattleBadgeReward(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleBadgeReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleBadgeRewardByActivityId.HandleId, ConfigPhantomBattleBadgeRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002D0B RID: 11531
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D0C RID: 11532
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D0D RID: 11533
		private const string TABLE = "PhantomBattleBadgeReward";

		// Token: 0x04002D0E RID: 11534
		private const string COMMAND = "select BinData from `PhantomBattleBadgeReward` where ActivityId=?";

		// Token: 0x04002D0F RID: 11535
		private const string KEY_PREFIX = "PhantomBattleBadgeRewardByActivityId";

		// Token: 0x04002D10 RID: 11536
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D11 RID: 11537
		private static int HandleId;
	}
}
