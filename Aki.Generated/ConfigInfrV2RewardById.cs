using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000451 RID: 1105
	public class ConfigInfrV2RewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019F0 RID: 6640 RVA: 0x000EFB7B File Offset: 0x000EDD7B
		static ConfigInfrV2RewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2RewardById.CreateStaticDefaultValue), new Action(ConfigInfrV2RewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x000EFB9C File Offset: 0x000EDD9C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2RewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2RewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2Reward"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2Reward` where Id=?")
			});
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x000EFC1B File Offset: 0x000EDE1B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2RewardById.LogPair = null;
			ConfigInfrV2RewardById.HandleId = 0;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x000EFC29 File Offset: 0x000EDE29
		public static void Init()
		{
			ConfigInfrV2RewardById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2RewardById.HandleId, "db_villageinfr.db", "select BinData from `InfrV2Reward` where Id=?");
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x000EFC44 File Offset: 0x000EDE44
		public static InfrV2Reward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2RewardById.HandleId, ConfigInfrV2RewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2RewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrV2Reward?(InfrV2Reward.GetRootAsInfrV2Reward(configBuffer));
				}
			}
			ConfigInfrV2RewardById.LogPair.Clear();
			ConfigInfrV2RewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrV2RewardById.HandleId, 1, p0Id, ConfigInfrV2RewardById.LogPair) || ConfigCommon.Step(ConfigInfrV2RewardById.HandleId, true, ConfigInfrV2RewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrV2RewardById.HandleId, ConfigInfrV2RewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2RewardById.HandleId, 0, ConfigInfrV2RewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrV2RewardById.HandleId, ConfigInfrV2RewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrV2Reward rootAsInfrV2Reward = InfrV2Reward.GetRootAsInfrV2Reward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2RewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrV2RewardById.HandleId, ConfigInfrV2RewardById.LogPair);
			return new InfrV2Reward?(rootAsInfrV2Reward);
		}

		// Token: 0x04001E1B RID: 7707
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E1C RID: 7708
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E1D RID: 7709
		private const string TABLE = "InfrV2Reward";

		// Token: 0x04001E1E RID: 7710
		private const string COMMAND = "select BinData from `InfrV2Reward` where Id=?";

		// Token: 0x04001E1F RID: 7711
		private const string KEY_PREFIX = "InfrV2RewardById";

		// Token: 0x04001E20 RID: 7712
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E21 RID: 7713
		private static int HandleId;
	}
}
