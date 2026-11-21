using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089C RID: 2204
	public class ConfigRogueWhiteCatBossRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033BA RID: 13242 RVA: 0x0018146C File Offset: 0x0017F66C
		static ConfigRogueWhiteCatBossRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWhiteCatBossRewardById.CreateStaticDefaultValue), new Action(ConfigRogueWhiteCatBossRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x0018148C File Offset: 0x0017F68C
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

		// Token: 0x060033BC RID: 13244 RVA: 0x0018150B File Offset: 0x0017F70B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWhiteCatBossRewardById.LogPair = null;
			ConfigRogueWhiteCatBossRewardById.HandleId = 0;
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00181519 File Offset: 0x0017F719
		public static void Init()
		{
			ConfigRogueWhiteCatBossRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWhiteCatBossRewardById.HandleId, "db_dreamlink.db", "select BinData from `RogueWhiteCatBossReward` where Id=?");
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00181534 File Offset: 0x0017F734
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

		// Token: 0x04003C2A RID: 15402
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003C2B RID: 15403
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003C2C RID: 15404
		private const string TABLE = "RogueWhiteCatBossReward";

		// Token: 0x04003C2D RID: 15405
		private const string COMMAND = "select BinData from `RogueWhiteCatBossReward` where Id=?";

		// Token: 0x04003C2E RID: 15406
		private const string KEY_PREFIX = "RogueWhiteCatBossRewardById";

		// Token: 0x04003C2F RID: 15407
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C30 RID: 15408
		private static int HandleId;
	}
}
