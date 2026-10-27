using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000667 RID: 1639
	public class ConfigPhantomBattleCardRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600267A RID: 9850 RVA: 0x001333D0 File Offset: 0x001315D0
		static ConfigPhantomBattleCardRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x001333F0 File Offset: 0x001315F0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardReward"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardReward` where ActivityId=?")
			});
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x0013346F File Offset: 0x0013166F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardRewardByActivityId.LogPair = null;
			ConfigPhantomBattleCardRewardByActivityId.HandleId = 0;
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x0013347D File Offset: 0x0013167D
		public static void Init()
		{
			ConfigPhantomBattleCardRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardRewardByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardReward` where ActivityId=?");
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00133498 File Offset: 0x00131698
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleCardReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardRewardByActivityId.HandleId, ConfigPhantomBattleCardRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<PhantomBattleCardReward> readOnlyList = (IReadOnlyList<PhantomBattleCardReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomBattleCardRewardByActivityId.LogPair.Clear();
			ConfigPhantomBattleCardRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardRewardByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleCardRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardRewardByActivityId.HandleId, ConfigPhantomBattleCardRewardByActivityId.LogPair);
				return null;
			}
			List<PhantomBattleCardReward> list = new List<PhantomBattleCardReward>();
			while (ConfigCommon.Step(ConfigPhantomBattleCardRewardByActivityId.HandleId, false, ConfigPhantomBattleCardRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardRewardByActivityId.HandleId, 0, ConfigPhantomBattleCardRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleCardRewardByActivityId.HandleId, ConfigPhantomBattleCardRewardByActivityId.LogPair);
					return null;
				}
				PhantomBattleCardReward rootAsPhantomBattleCardReward = PhantomBattleCardReward.GetRootAsPhantomBattleCardReward(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleCardReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardRewardByActivityId.HandleId, ConfigPhantomBattleCardRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04002CB7 RID: 11447
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CB8 RID: 11448
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CB9 RID: 11449
		private const string TABLE = "PhantomBattleCardReward";

		// Token: 0x04002CBA RID: 11450
		private const string COMMAND = "select BinData from `PhantomBattleCardReward` where ActivityId=?";

		// Token: 0x04002CBB RID: 11451
		private const string KEY_PREFIX = "PhantomBattleCardRewardByActivityId";

		// Token: 0x04002CBC RID: 11452
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CBD RID: 11453
		private static int HandleId;
	}
}
