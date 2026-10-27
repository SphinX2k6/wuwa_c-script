using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000829 RID: 2089
	public class ConfigRogueLimitTimeRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003108 RID: 12552 RVA: 0x0016E958 File Offset: 0x0016CB58
		static ConfigRogueLimitTimeRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueLimitTimeRewardById.CreateStaticDefaultValue), new Action(ConfigRogueLimitTimeRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x0016E978 File Offset: 0x0016CB78
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueLimitTimeRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueLimitTimeRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "RogueLimitTimeReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueLimitTimeReward` where Id=?")
			});
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x0016E9F7 File Offset: 0x0016CBF7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueLimitTimeRewardById.LogPair = null;
			ConfigRogueLimitTimeRewardById.HandleId = 0;
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x0016EA05 File Offset: 0x0016CC05
		public static void Init()
		{
			ConfigRogueLimitTimeRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueLimitTimeRewardById.HandleId, "db_dreamlink.db", "select BinData from `RogueLimitTimeReward` where Id=?");
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x0016EA20 File Offset: 0x0016CC20
		public static RogueLimitTimeReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueLimitTimeRewardById.HandleId, ConfigRogueLimitTimeRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueLimitTimeRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueLimitTimeReward?(RogueLimitTimeReward.GetRootAsRogueLimitTimeReward(configBuffer));
				}
			}
			ConfigRogueLimitTimeRewardById.LogPair.Clear();
			ConfigRogueLimitTimeRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueLimitTimeRewardById.HandleId, 1, p0Id, ConfigRogueLimitTimeRewardById.LogPair) || ConfigCommon.Step(ConfigRogueLimitTimeRewardById.HandleId, true, ConfigRogueLimitTimeRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueLimitTimeRewardById.HandleId, ConfigRogueLimitTimeRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueLimitTimeRewardById.HandleId, 0, ConfigRogueLimitTimeRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueLimitTimeRewardById.HandleId, ConfigRogueLimitTimeRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueLimitTimeReward rootAsRogueLimitTimeReward = RogueLimitTimeReward.GetRootAsRogueLimitTimeReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueLimitTimeRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueLimitTimeRewardById.HandleId, ConfigRogueLimitTimeRewardById.LogPair);
			return new RogueLimitTimeReward?(rootAsRogueLimitTimeReward);
		}

		// Token: 0x04003905 RID: 14597
		private const string DB = "db_dreamlink.db";

		// Token: 0x04003906 RID: 14598
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04003907 RID: 14599
		private const string TABLE = "RogueLimitTimeReward";

		// Token: 0x04003908 RID: 14600
		private const string COMMAND = "select BinData from `RogueLimitTimeReward` where Id=?";

		// Token: 0x04003909 RID: 14601
		private const string KEY_PREFIX = "RogueLimitTimeRewardById";

		// Token: 0x0400390A RID: 14602
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400390B RID: 14603
		private static int HandleId;
	}
}
