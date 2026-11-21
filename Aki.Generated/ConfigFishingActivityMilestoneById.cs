using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E9 RID: 745
	public class ConfigFishingActivityMilestoneById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600117B RID: 4475 RVA: 0x000BFC07 File Offset: 0x000BDE07
		static ConfigFishingActivityMilestoneById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityMilestoneById.CreateStaticDefaultValue), new Action(ConfigFishingActivityMilestoneById.ResetStaticDefaultValue));
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x000BFC28 File Offset: 0x000BDE28
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingActivityMilestoneById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingActivityMilestoneById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼大活动.xlsx"),
				new ValueTuple<string, object>("表名", "FishingActivityMilestone"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingActivityMilestone` where Id=?")
			});
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000BFCA7 File Offset: 0x000BDEA7
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityMilestoneById.LogPair = null;
			ConfigFishingActivityMilestoneById.HandleId = 0;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000BFCB5 File Offset: 0x000BDEB5
		public static void Init()
		{
			ConfigFishingActivityMilestoneById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityMilestoneById.HandleId, "db_fishing.db", "select BinData from `FishingActivityMilestone` where Id=?");
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x000BFCD0 File Offset: 0x000BDED0
		public static FishingActivityMilestone? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingActivityMilestoneById.HandleId, ConfigFishingActivityMilestoneById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityMilestoneById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingActivityMilestone?(FishingActivityMilestone.GetRootAsFishingActivityMilestone(configBuffer));
				}
			}
			ConfigFishingActivityMilestoneById.LogPair.Clear();
			ConfigFishingActivityMilestoneById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingActivityMilestoneById.HandleId, 1, p0Id, ConfigFishingActivityMilestoneById.LogPair) || ConfigCommon.Step(ConfigFishingActivityMilestoneById.HandleId, true, ConfigFishingActivityMilestoneById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingActivityMilestoneById.HandleId, ConfigFishingActivityMilestoneById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingActivityMilestoneById.HandleId, 0, ConfigFishingActivityMilestoneById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingActivityMilestoneById.HandleId, ConfigFishingActivityMilestoneById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingActivityMilestone rootAsFishingActivityMilestone = FishingActivityMilestone.GetRootAsFishingActivityMilestone(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingActivityMilestoneById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingActivityMilestoneById.HandleId, ConfigFishingActivityMilestoneById.LogPair);
			return new FishingActivityMilestone?(rootAsFishingActivityMilestone);
		}

		// Token: 0x04001443 RID: 5187
		private const string DB = "db_fishing.db";

		// Token: 0x04001444 RID: 5188
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x04001445 RID: 5189
		private const string TABLE = "FishingActivityMilestone";

		// Token: 0x04001446 RID: 5190
		private const string COMMAND = "select BinData from `FishingActivityMilestone` where Id=?";

		// Token: 0x04001447 RID: 5191
		private const string KEY_PREFIX = "FishingActivityMilestoneById";

		// Token: 0x04001448 RID: 5192
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001449 RID: 5193
		private static int HandleId;
	}
}
