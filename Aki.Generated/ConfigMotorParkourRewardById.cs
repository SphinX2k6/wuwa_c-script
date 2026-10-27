using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005BD RID: 1469
	public class ConfigMotorParkourRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600227B RID: 8827 RVA: 0x0011C830 File Offset: 0x0011AA30
		static ConfigMotorParkourRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorParkourRewardById.CreateStaticDefaultValue), new Action(ConfigMotorParkourRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x0011C850 File Offset: 0x0011AA50
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

		// Token: 0x0600227D RID: 8829 RVA: 0x0011C8CF File Offset: 0x0011AACF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorParkourRewardById.LogPair = null;
			ConfigMotorParkourRewardById.HandleId = 0;
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x0011C8DD File Offset: 0x0011AADD
		public static void Init()
		{
			ConfigMotorParkourRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorParkourRewardById.HandleId, "db_motorparkour.db", "select BinData from `MotorParkourReward` where Id=?");
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x0011C8F8 File Offset: 0x0011AAF8
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

		// Token: 0x0400280F RID: 10255
		private const string DB = "db_motorparkour.db";

		// Token: 0x04002810 RID: 10256
		private const string FILE = "m.摩托跑酷.xlsx";

		// Token: 0x04002811 RID: 10257
		private const string TABLE = "MotorParkourReward";

		// Token: 0x04002812 RID: 10258
		private const string COMMAND = "select BinData from `MotorParkourReward` where Id=?";

		// Token: 0x04002813 RID: 10259
		private const string KEY_PREFIX = "MotorParkourRewardById";

		// Token: 0x04002814 RID: 10260
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002815 RID: 10261
		private static int HandleId;
	}
}
