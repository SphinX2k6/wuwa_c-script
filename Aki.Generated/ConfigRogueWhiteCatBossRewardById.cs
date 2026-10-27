using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000880 RID: 2176
	public class ConfigRogueWhiteCatBossRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003312 RID: 13074 RVA: 0x0017A184 File Offset: 0x00178384
		static ConfigRogueWhiteCatBossRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWhiteCatBossRewardById.CreateStaticDefaultValue), new Action(ConfigRogueWhiteCatBossRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x0017A1A4 File Offset: 0x001783A4
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWhiteCatBossRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWhiteCatBossRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWhiteCatBossReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWhiteCatBossReward` where Id=?")
			});
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0017A223 File Offset: 0x00178423
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWhiteCatBossRewardById.LogPair = null;
			ConfigRogueWhiteCatBossRewardById.HandleId = 0;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x0017A231 File Offset: 0x00178431
		public static void Init()
		{
			ConfigRogueWhiteCatBossRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWhiteCatBossRewardById.HandleId, "db_dreamlink.db", "select BinData from `RogueWhiteCatBossReward` where Id=?");
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x0017A24C File Offset: 0x0017844C
		public static RogueWhiteCatBossReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWhiteCatBossRewardById.HandleId, ConfigRogueWhiteCatBossRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWhiteCatBossRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWhiteCatBossReward?(RogueWhiteCatBossReward.GetRootAsRogueWhiteCatBossReward(configBuffer));
				}
			}
			ConfigRogueWhiteCatBossRewardById.LogPair.Clear();
			ConfigRogueWhiteCatBossRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWhiteCatBossRewardById.HandleId, 1, p0Id, ConfigRogueWhiteCatBossRewardById.LogPair) || ConfigCommon.Step(ConfigRogueWhiteCatBossRewardById.HandleId, true, ConfigRogueWhiteCatBossRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWhiteCatBossRewardById.HandleId, ConfigRogueWhiteCatBossRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWhiteCatBossRewardById.HandleId, 0, ConfigRogueWhiteCatBossRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWhiteCatBossRewardById.HandleId, ConfigRogueWhiteCatBossRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWhiteCatBossReward rootAsRogueWhiteCatBossReward = RogueWhiteCatBossReward.GetRootAsRogueWhiteCatBossReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWhiteCatBossRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWhiteCatBossRewardById.HandleId, ConfigRogueWhiteCatBossRewardById.LogPair);
			return new RogueWhiteCatBossReward?(rootAsRogueWhiteCatBossReward);
		}

		// Token: 0x04003B66 RID: 15206
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003B67 RID: 15207
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003B68 RID: 15208
		private const string TABLE = "RogueWhiteCatBossReward";

		// Token: 0x04003B69 RID: 15209
		private const string COMMAND = "select BinData from `RogueWhiteCatBossReward` where Id=?";

		// Token: 0x04003B6A RID: 15210
		private const string KEY_PREFIX = "RogueWhiteCatBossRewardById";

		// Token: 0x04003B6B RID: 15211
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B6C RID: 15212
		private static int HandleId;
	}
}
