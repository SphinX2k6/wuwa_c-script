using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000894 RID: 2196
	public class ConfigRogueWeeklyRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600338A RID: 13194 RVA: 0x00180447 File Offset: 0x0017E647
		static ConfigRogueWeeklyRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRewardById.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x00180468 File Offset: 0x0017E668
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyReward` where Id=?")
			});
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x001804E7 File Offset: 0x0017E6E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRewardById.LogPair = null;
			ConfigRogueWeeklyRewardById.HandleId = 0;
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x001804F5 File Offset: 0x0017E6F5
		public static void Init()
		{
			ConfigRogueWeeklyRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRewardById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyReward` where Id=?");
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x00180510 File Offset: 0x0017E710
		public static RogueWeeklyReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyRewardById.HandleId, ConfigRogueWeeklyRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeeklyReward?(RogueWeeklyReward.GetRootAsRogueWeeklyReward(configBuffer));
				}
			}
			ConfigRogueWeeklyRewardById.LogPair.Clear();
			ConfigRogueWeeklyRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyRewardById.HandleId, 1, p0Id, ConfigRogueWeeklyRewardById.LogPair) || ConfigCommon.Step(ConfigRogueWeeklyRewardById.HandleId, true, ConfigRogueWeeklyRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyRewardById.HandleId, ConfigRogueWeeklyRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyRewardById.HandleId, 0, ConfigRogueWeeklyRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeeklyRewardById.HandleId, ConfigRogueWeeklyRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeeklyReward rootAsRogueWeeklyReward = RogueWeeklyReward.GetRootAsRogueWeeklyReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyRewardById.HandleId, ConfigRogueWeeklyRewardById.LogPair);
			return new RogueWeeklyReward?(rootAsRogueWeeklyReward);
		}

		// Token: 0x04003BF2 RID: 15346
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BF3 RID: 15347
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BF4 RID: 15348
		private const string TABLE = "RogueWeeklyReward";

		// Token: 0x04003BF5 RID: 15349
		private const string COMMAND = "select BinData from `RogueWeeklyReward` where Id=?";

		// Token: 0x04003BF6 RID: 15350
		private const string KEY_PREFIX = "RogueWeeklyRewardById";

		// Token: 0x04003BF7 RID: 15351
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BF8 RID: 15352
		private static int HandleId;
	}
}
