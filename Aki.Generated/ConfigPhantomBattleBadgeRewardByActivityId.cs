using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200065B RID: 1627
	public class ConfigPhantomBattleBadgeRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002632 RID: 9778 RVA: 0x00131A08 File Offset: 0x0012FC08
		static ConfigPhantomBattleBadgeRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00131A28 File Offset: 0x0012FC28
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

		// Token: 0x06002634 RID: 9780 RVA: 0x00131AA7 File Offset: 0x0012FCA7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeRewardByActivityId.LogPair = null;
			ConfigPhantomBattleBadgeRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00131AB5 File Offset: 0x0012FCB5
		public static void Init()
		{
			ConfigPhantomBattleBadgeRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeRewardByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadgeReward` where ActivityId=?");
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x00131AD0 File Offset: 0x0012FCD0
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

		// Token: 0x04002C63 RID: 11363
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C64 RID: 11364
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C65 RID: 11365
		private const string TABLE = "PhantomBattleBadgeReward";

		// Token: 0x04002C66 RID: 11366
		private const string COMMAND = "select BinData from `PhantomBattleBadgeReward` where ActivityId=?";

		// Token: 0x04002C67 RID: 11367
		private const string KEY_PREFIX = "PhantomBattleBadgeRewardByActivityId";

		// Token: 0x04002C68 RID: 11368
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C69 RID: 11369
		private static int HandleId;
	}
}
