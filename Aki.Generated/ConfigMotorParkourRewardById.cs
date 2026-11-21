using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D4 RID: 1492
	public class ConfigMotorParkourRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002305 RID: 8965 RVA: 0x00123118 File Offset: 0x00121318
		static ConfigMotorParkourRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourRewardById.CreateStaticDefaultValue), new Action(ConfigMotorParkourRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00123138 File Offset: 0x00121338
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorParkourRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorParkourRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorparkour.db"),
				new ValueTuple<string, object>("文件", "m.摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "MotorParkourReward"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorParkourReward` where Id=?")
			});
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x001231B7 File Offset: 0x001213B7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourRewardById.LogPair = null;
			ConfigMotorParkourRewardById.HandleId = 0;
		}

		// Token: 0x06002308 RID: 8968 RVA: 0x001231C5 File Offset: 0x001213C5
		public static void Init()
		{
			ConfigMotorParkourRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourRewardById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourReward` where Id=?");
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x001231E0 File Offset: 0x001213E0
		public static MotorParkourReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorParkourRewardById.HandleId, ConfigMotorParkourRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorParkourReward?(MotorParkourReward.GetRootAsMotorParkourReward(configBuffer));
				}
			}
			ConfigMotorParkourRewardById.LogPair.Clear();
			ConfigMotorParkourRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorParkourRewardById.HandleId, 1, p0Id, ConfigMotorParkourRewardById.LogPair) || ConfigCommon.Step(ConfigMotorParkourRewardById.HandleId, true, ConfigMotorParkourRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorParkourRewardById.HandleId, ConfigMotorParkourRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorParkourRewardById.HandleId, 0, ConfigMotorParkourRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorParkourRewardById.HandleId, ConfigMotorParkourRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorParkourReward rootAsMotorParkourReward = MotorParkourReward.GetRootAsMotorParkourReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorParkourRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorParkourRewardById.HandleId, ConfigMotorParkourRewardById.LogPair);
			return new MotorParkourReward?(rootAsMotorParkourReward);
		}

		// Token: 0x040028B0 RID: 10416
		private const string DB = "db_motorparkour.db";

		// Token: 0x040028B1 RID: 10417
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x040028B2 RID: 10418
		private const string TABLE = "MotorParkourReward";

		// Token: 0x040028B3 RID: 10419
		private const string COMMAND = "select BinData from `MotorParkourReward` where Id=?";

		// Token: 0x040028B4 RID: 10420
		private const string KEY_PREFIX = "MotorParkourRewardById";

		// Token: 0x040028B5 RID: 10421
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028B6 RID: 10422
		private static int HandleId;
	}
}
