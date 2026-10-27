using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000982 RID: 2434
	public class ConfigSpringFestivalScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003920 RID: 14624 RVA: 0x0019C933 File Offset: 0x0019AB33
		static ConfigSpringFestivalScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalScoreRewardById.CreateStaticDefaultValue), new Action(ConfigSpringFestivalScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0019C954 File Offset: 0x0019AB54
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

		// Token: 0x06003922 RID: 14626 RVA: 0x0019C9D3 File Offset: 0x0019ABD3
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalScoreRewardById.LogPair = null;
			ConfigSpringFestivalScoreRewardById.HandleId = 0;
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x0019C9E1 File Offset: 0x0019ABE1
		public static void Init()
		{
			ConfigSpringFestivalScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalScoreRewardById.HandleId, "db_spring26.db", "select BinData from `SpringFestivalScoreReward` where Id=?");
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0019C9FC File Offset: 0x0019ABFC
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

		// Token: 0x04004274 RID: 17012
		private const string DB = "db_spring26.db";

		// Token: 0x04004275 RID: 17013
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x04004276 RID: 17014
		private const string TABLE = "SpringFestivalScoreReward";

		// Token: 0x04004277 RID: 17015
		private const string COMMAND = "select BinData from `SpringFestivalScoreReward` where Id=?";

		// Token: 0x04004278 RID: 17016
		private const string KEY_PREFIX = "SpringFestivalScoreRewardById";

		// Token: 0x04004279 RID: 17017
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400427A RID: 17018
		private static int HandleId;
	}
}
