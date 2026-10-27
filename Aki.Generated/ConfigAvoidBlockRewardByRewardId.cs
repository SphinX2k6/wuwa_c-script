using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C4 RID: 196
	public class ConfigAvoidBlockRewardByRewardId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000499 RID: 1177 RVA: 0x00073C1F File Offset: 0x00071E1F
		static ConfigAvoidBlockRewardByRewardId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvoidBlockRewardByRewardId.CreateStaticDefaultValue), new Action(ConfigAvoidBlockRewardByRewardId.ResetStaticDefaultValue));
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00073C40 File Offset: 0x00071E40
		public static void CreateStaticDefaultValue()
		{
			ConfigAvoidBlockRewardByRewardId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvoidBlockRewardByRewardId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avoidblock.db"),
				new ValueTuple<string, object>("文件", "d.躲避方块.xlsx"),
				new ValueTuple<string, object>("表名", "AvoidBlockReward"),
				new ValueTuple<string, object>("语句", "select BinData from `AvoidBlockReward` where RewardId=?")
			});
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00073CBF File Offset: 0x00071EBF
		public static void ResetStaticDefaultValue()
		{
			ConfigAvoidBlockRewardByRewardId.LogPair = null;
			ConfigAvoidBlockRewardByRewardId.HandleId = 0;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00073CCD File Offset: 0x00071ECD
		public static void Init()
		{
			ConfigAvoidBlockRewardByRewardId.HandleId = ConfigCommon.InitDataStatement(ConfigAvoidBlockRewardByRewardId.HandleId, "db_avoidblock.db", "select BinData from `AvoidBlockReward` where RewardId=?");
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00073CE8 File Offset: 0x00071EE8
		public static AvoidBlockReward? GetConfig(int p0RewardId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvoidBlockRewardByRewardId.HandleId, ConfigAvoidBlockRewardByRewardId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvoidBlockRewardByRewardId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RewardId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvoidBlockReward?(AvoidBlockReward.GetRootAsAvoidBlockReward(configBuffer));
				}
			}
			ConfigAvoidBlockRewardByRewardId.LogPair.Clear();
			ConfigAvoidBlockRewardByRewardId.LogPair.Add(new ValueTuple<string, object>("RewardId", p0RewardId));
			if (!ConfigCommon.BindInt(ConfigAvoidBlockRewardByRewardId.HandleId, 1, p0RewardId, ConfigAvoidBlockRewardByRewardId.LogPair) || ConfigCommon.Step(ConfigAvoidBlockRewardByRewardId.HandleId, true, ConfigAvoidBlockRewardByRewardId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvoidBlockRewardByRewardId.HandleId, ConfigAvoidBlockRewardByRewardId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvoidBlockRewardByRewardId.HandleId, 0, ConfigAvoidBlockRewardByRewardId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvoidBlockRewardByRewardId.HandleId, ConfigAvoidBlockRewardByRewardId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvoidBlockReward rootAsAvoidBlockReward = AvoidBlockReward.GetRootAsAvoidBlockReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvoidBlockRewardByRewardId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RewardId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvoidBlockRewardByRewardId.HandleId, ConfigAvoidBlockRewardByRewardId.LogPair);
			return new AvoidBlockReward?(rootAsAvoidBlockReward);
		}

		// Token: 0x04000540 RID: 1344
		private const string DB = "db_avoidblock.db";

		// Token: 0x04000541 RID: 1345
		private const string FILE = "d.躲避方块.xlsx";

		// Token: 0x04000542 RID: 1346
		private const string TABLE = "AvoidBlockReward";

		// Token: 0x04000543 RID: 1347
		private const string COMMAND = "select BinData from `AvoidBlockReward` where RewardId=?";

		// Token: 0x04000544 RID: 1348
		private const string KEY_PREFIX = "AvoidBlockRewardByRewardId";

		// Token: 0x04000545 RID: 1349
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000546 RID: 1350
		private static int HandleId;
	}
}
