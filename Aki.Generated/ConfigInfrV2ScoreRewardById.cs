using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000453 RID: 1107
	public class ConfigInfrV2ScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019FC RID: 6652 RVA: 0x000EFF57 File Offset: 0x000EE157
		static ConfigInfrV2ScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2ScoreRewardById.CreateStaticDefaultValue), new Action(ConfigInfrV2ScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000EFF78 File Offset: 0x000EE178
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2ScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2ScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2ScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2ScoreReward` where Id=?")
			});
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000EFFF7 File Offset: 0x000EE1F7
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2ScoreRewardById.LogPair = null;
			ConfigInfrV2ScoreRewardById.HandleId = 0;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000F0005 File Offset: 0x000EE205
		public static void Init()
		{
			ConfigInfrV2ScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2ScoreRewardById.HandleId, "db_villageinfr.db", "select BinData from `InfrV2ScoreReward` where Id=?");
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000F0020 File Offset: 0x000EE220
		public static InfrV2ScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2ScoreRewardById.HandleId, ConfigInfrV2ScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2ScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrV2ScoreReward?(InfrV2ScoreReward.GetRootAsInfrV2ScoreReward(configBuffer));
				}
			}
			ConfigInfrV2ScoreRewardById.LogPair.Clear();
			ConfigInfrV2ScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrV2ScoreRewardById.HandleId, 1, p0Id, ConfigInfrV2ScoreRewardById.LogPair) || ConfigCommon.Step(ConfigInfrV2ScoreRewardById.HandleId, true, ConfigInfrV2ScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrV2ScoreRewardById.HandleId, ConfigInfrV2ScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2ScoreRewardById.HandleId, 0, ConfigInfrV2ScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrV2ScoreRewardById.HandleId, ConfigInfrV2ScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrV2ScoreReward rootAsInfrV2ScoreReward = InfrV2ScoreReward.GetRootAsInfrV2ScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2ScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrV2ScoreRewardById.HandleId, ConfigInfrV2ScoreRewardById.LogPair);
			return new InfrV2ScoreReward?(rootAsInfrV2ScoreReward);
		}

		// Token: 0x04001E29 RID: 7721
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E2A RID: 7722
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E2B RID: 7723
		private const string TABLE = "InfrV2ScoreReward";

		// Token: 0x04001E2C RID: 7724
		private const string COMMAND = "select BinData from `InfrV2ScoreReward` where Id=?";

		// Token: 0x04001E2D RID: 7725
		private const string KEY_PREFIX = "InfrV2ScoreRewardById";

		// Token: 0x04001E2E RID: 7726
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E2F RID: 7727
		private static int HandleId;
	}
}
