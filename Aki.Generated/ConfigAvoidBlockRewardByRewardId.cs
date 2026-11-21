using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D3 RID: 211
	public class ConfigAvoidBlockRewardByRewardId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004F3 RID: 1267 RVA: 0x00079583 File Offset: 0x00077783
		static ConfigAvoidBlockRewardByRewardId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvoidBlockRewardByRewardId.CreateStaticDefaultValue), new Action(ConfigAvoidBlockRewardByRewardId.ResetStaticDefaultValue));
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000795A4 File Offset: 0x000777A4
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

		// Token: 0x060004F5 RID: 1269 RVA: 0x00079623 File Offset: 0x00077823
		public static void ResetStaticDefaultValue()
		{
			ConfigAvoidBlockRewardByRewardId.LogPair = null;
			ConfigAvoidBlockRewardByRewardId.HandleId = 0;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00079631 File Offset: 0x00077831
		public static void Init()
		{
			ConfigAvoidBlockRewardByRewardId.HandleId = ConfigCommon.InitDataStatement(ConfigAvoidBlockRewardByRewardId.HandleId, "db_avoidblock.db", "select BinData from `AvoidBlockReward` where RewardId=?");
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0007964C File Offset: 0x0007784C
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

		// Token: 0x040005A9 RID: 1449
		private const string DB = "db_avoidblock.db";

		// Token: 0x040005AA RID: 1450
		private const string FILE = "d.躲避方块.xlsx";

		// Token: 0x040005AB RID: 1451
		private const string TABLE = "AvoidBlockReward";

		// Token: 0x040005AC RID: 1452
		private const string COMMAND = "select BinData from `AvoidBlockReward` where RewardId=?";

		// Token: 0x040005AD RID: 1453
		private const string KEY_PREFIX = "AvoidBlockRewardByRewardId";

		// Token: 0x040005AE RID: 1454
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005AF RID: 1455
		private static int HandleId;
	}
}
