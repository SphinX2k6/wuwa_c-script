using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A57 RID: 2647
	public class ConfigSpringFestivalScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E1E RID: 15902 RVA: 0x001BBCC7 File Offset: 0x001B9EC7
		static ConfigSpringFestivalScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalScoreRewardById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x001BBCE8 File Offset: 0x001B9EE8
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestivalScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestivalScoreReward` where Id=?")
			});
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x001BBD67 File Offset: 0x001B9F67
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalScoreRewardById.LogPair = null;
			ConfigSpringFestivalScoreRewardById.HandleId = 0;
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x001BBD75 File Offset: 0x001B9F75
		public static void Init()
		{
			ConfigSpringFestivalScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalScoreRewardById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalScoreReward` where Id=?");
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x001BBD90 File Offset: 0x001B9F90
		public static SpringFestivalScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalScoreRewardById.HandleId, ConfigSpringFestivalScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpringFestivalScoreReward?(SpringFestivalScoreReward.GetRootAsSpringFestivalScoreReward(configBuffer));
				}
			}
			ConfigSpringFestivalScoreRewardById.LogPair.Clear();
			ConfigSpringFestivalScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpringFestivalScoreRewardById.HandleId, 1, p0Id, ConfigSpringFestivalScoreRewardById.LogPair) || ConfigCommon.Step(ConfigSpringFestivalScoreRewardById.HandleId, true, ConfigSpringFestivalScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpringFestivalScoreRewardById.HandleId, ConfigSpringFestivalScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalScoreRewardById.HandleId, 0, ConfigSpringFestivalScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpringFestivalScoreRewardById.HandleId, ConfigSpringFestivalScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpringFestivalScoreReward rootAsSpringFestivalScoreReward = SpringFestivalScoreReward.GetRootAsSpringFestivalScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpringFestivalScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpringFestivalScoreRewardById.HandleId, ConfigSpringFestivalScoreRewardById.LogPair);
			return new SpringFestivalScoreReward?(rootAsSpringFestivalScoreReward);
		}

		// Token: 0x04004847 RID: 18503
		private const string DB = "db_spring26.db";

		// Token: 0x04004848 RID: 18504
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004849 RID: 18505
		private const string TABLE = "SpringFestivalScoreReward";

		// Token: 0x0400484A RID: 18506
		private const string COMMAND = "select BinData from `SpringFestivalScoreReward` where Id=?";

		// Token: 0x0400484B RID: 18507
		private const string KEY_PREFIX = "SpringFestivalScoreRewardById";

		// Token: 0x0400484C RID: 18508
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400484D RID: 18509
		private static int HandleId;
	}
}
