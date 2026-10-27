using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002D4 RID: 724
	public class ConfigFishingActivityMilestoneById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010FD RID: 4349 RVA: 0x000B96FB File Offset: 0x000B78FB
		static ConfigFishingActivityMilestoneById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingActivityMilestoneById.CreateStaticDefaultValue), new Action(ConfigFishingActivityMilestoneById.ResetStaticDefaultValue));
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x000B971C File Offset: 0x000B791C
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

		// Token: 0x060010FF RID: 4351 RVA: 0x000B979B File Offset: 0x000B799B
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingActivityMilestoneById.LogPair = null;
			ConfigFishingActivityMilestoneById.HandleId = 0;
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x000B97A9 File Offset: 0x000B79A9
		public static void Init()
		{
			ConfigFishingActivityMilestoneById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingActivityMilestoneById.HandleId, "db_fishing.db", "select BinData from `FishingActivityMilestone` where Id=?");
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000B97C4 File Offset: 0x000B79C4
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

		// Token: 0x040013B0 RID: 5040
		private const string DB = "db_fishing.db";

		// Token: 0x040013B1 RID: 5041
		private const string FILE = "b.捕鱼大活动.xlsx";

		// Token: 0x040013B2 RID: 5042
		private const string TABLE = "FishingActivityMilestone";

		// Token: 0x040013B3 RID: 5043
		private const string COMMAND = "select BinData from `FishingActivityMilestone` where Id=?";

		// Token: 0x040013B4 RID: 5044
		private const string KEY_PREFIX = "FishingActivityMilestoneById";

		// Token: 0x040013B5 RID: 5045
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013B6 RID: 5046
		private static int HandleId;
	}
}
