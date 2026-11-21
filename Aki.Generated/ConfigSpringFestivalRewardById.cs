using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A53 RID: 2643
	public class ConfigSpringFestivalRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E06 RID: 15878 RVA: 0x001BB3C7 File Offset: 0x001B95C7
		static ConfigSpringFestivalRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalRewardById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x001BB3E8 File Offset: 0x001B95E8
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalReward` where Id=?")
			});
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x001BB467 File Offset: 0x001B9667
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalRewardById.LogPair = null;
			ConfigSpringFestivalRewardById.HandleId = 0;
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x001BB475 File Offset: 0x001B9675
		public static void Init()
		{
			ConfigSpringFestivalRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalRewardById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalReward` where Id=?");
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x001BB490 File Offset: 0x001B9690
		public static SpringFestivalReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalRewardById.HandleId, ConfigSpringFestivalRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalReward?(SpringFestivalReward.GetRootAsSpringFestivalReward(configBuffer));
				}
			}
			ConfigSpringFestivalRewardById.LogPair.Clear();
			ConfigSpringFestivalRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalRewardById.HandleId, 1, p0Id, ConfigSpringFestivalRewardById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalRewardById.HandleId, true, ConfigSpringFestivalRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalRewardById.HandleId, ConfigSpringFestivalRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalRewardById.HandleId, 0, ConfigSpringFestivalRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalRewardById.HandleId, ConfigSpringFestivalRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalReward rootAsSpringFestivalReward = SpringFestivalReward.GetRootAsSpringFestivalReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalRewardById.HandleId, ConfigSpringFestivalRewardById.LogPair);
			return new SpringFestivalReward?(rootAsSpringFestivalReward);
		}

		// Token: 0x0400482B RID: 18475
		private const string DB = "db_spring26.db";

		// Token: 0x0400482C RID: 18476
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x0400482D RID: 18477
		private const string TABLE = "SpringFestivalReward";

		// Token: 0x0400482E RID: 18478
		private const string COMMAND = "select BinData from `SpringFestivalReward` where Id=?";

		// Token: 0x0400482F RID: 18479
		private const string KEY_PREFIX = "SpringFestivalRewardById";

		// Token: 0x04004830 RID: 18480
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004831 RID: 18481
		private static int HandleId;
	}
}
