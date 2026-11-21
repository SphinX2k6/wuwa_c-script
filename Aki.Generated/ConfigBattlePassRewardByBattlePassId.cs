using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F5 RID: 245
	public class ConfigBattlePassRewardByBattlePassId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x0007DB60 File Offset: 0x0007BD60
		static ConfigBattlePassRewardByBattlePassId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattlePassRewardByBattlePassId.CreateStaticDefaultValue), new Action(ConfigBattlePassRewardByBattlePassId.ResetStaticDefaultValue));
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0007DB80 File Offset: 0x0007BD80
		public static void CreateStaticDefaultValue()
		{
			ConfigBattlePassRewardByBattlePassId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattlePassRewardByBattlePassId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battle_pass.db"),
				new ValueTuple<string, object>("文件", "z.战令.xlsx"),
				new ValueTuple<string, object>("表名", "BattlePassReward"),
				new ValueTuple<string, object>("语句", "select BinData from `BattlePassReward` where BattlePassId=?")
			});
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0007DBFF File Offset: 0x0007BDFF
		public static void ResetStaticDefaultValue()
		{
			ConfigBattlePassRewardByBattlePassId.LogPair = null;
			ConfigBattlePassRewardByBattlePassId.HandleId = 0;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0007DC0D File Offset: 0x0007BE0D
		public static void Init()
		{
			ConfigBattlePassRewardByBattlePassId.HandleId = ConfigCommon.InitDataStatement(ConfigBattlePassRewardByBattlePassId.HandleId, "db_battle_pass.db", "select BinData from `BattlePassReward` where BattlePassId=?");
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0007DC28 File Offset: 0x0007BE28
		[NullableContext(2)]
		public static IReadOnlyList<BattlePassReward> GetConfigList(int p0BattlePassId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattlePassRewardByBattlePassId.HandleId, ConfigBattlePassRewardByBattlePassId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassRewardByBattlePassId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BattlePassId);
				IReadOnlyList<BattlePassReward> readOnlyList = (IReadOnlyList<BattlePassReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBattlePassRewardByBattlePassId.LogPair.Clear();
			ConfigBattlePassRewardByBattlePassId.LogPair.Add(new ValueTuple<string, object>("BattlePassId", p0BattlePassId));
			if (!ConfigCommon.BindInt(ConfigBattlePassRewardByBattlePassId.HandleId, 1, p0BattlePassId, ConfigBattlePassRewardByBattlePassId.LogPair))
			{
				ConfigCommon.Reset(ConfigBattlePassRewardByBattlePassId.HandleId, ConfigBattlePassRewardByBattlePassId.LogPair);
				return null;
			}
			List<BattlePassReward> list = new List<BattlePassReward>();
			while (ConfigCommon.Step(ConfigBattlePassRewardByBattlePassId.HandleId, false, ConfigBattlePassRewardByBattlePassId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattlePassRewardByBattlePassId.HandleId, 0, ConfigBattlePassRewardByBattlePassId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBattlePassRewardByBattlePassId.HandleId, ConfigBattlePassRewardByBattlePassId.LogPair);
					return null;
				}
				BattlePassReward rootAsBattlePassReward = BattlePassReward.GetRootAsBattlePassReward(new ByteBuffer(item2));
				list.Add(rootAsBattlePassReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassRewardByBattlePassId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BattlePassId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBattlePassRewardByBattlePassId.HandleId, ConfigBattlePassRewardByBattlePassId.LogPair);
			return list;
		}

		// Token: 0x04000697 RID: 1687
		private const string DB = "db_battle_pass.db";

		// Token: 0x04000698 RID: 1688
		private const string FILE = "z.战令.xlsx";

		// Token: 0x04000699 RID: 1689
		private const string TABLE = "BattlePassReward";

		// Token: 0x0400069A RID: 1690
		private const string COMMAND = "select BinData from `BattlePassReward` where BattlePassId=?";

		// Token: 0x0400069B RID: 1691
		private const string KEY_PREFIX = "BattlePassRewardByBattlePassId";

		// Token: 0x0400069C RID: 1692
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400069D RID: 1693
		private static int HandleId;
	}
}
