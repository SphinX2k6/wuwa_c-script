using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A7 RID: 2471
	public class ConfigSurvivorsScoreRewardByActivity : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039FE RID: 14846 RVA: 0x001A1A6F File Offset: 0x0019FC6F
		static ConfigSurvivorsScoreRewardByActivity()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsScoreRewardByActivity.CreateStaticDefaultValue), new Action(ConfigSurvivorsScoreRewardByActivity.ResetStaticDefaultValue));
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x001A1A90 File Offset: 0x0019FC90
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsScoreRewardByActivity.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsScoreRewardByActivity.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_活动.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsScoreReward` where Activity=?")
			});
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x001A1B0F File Offset: 0x0019FD0F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsScoreRewardByActivity.LogPair = null;
			ConfigSurvivorsScoreRewardByActivity.HandleId = 0;
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x001A1B1D File Offset: 0x0019FD1D
		public static void Init()
		{
			ConfigSurvivorsScoreRewardByActivity.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsScoreRewardByActivity.HandleId, "db_survivors.db", "select BinData from `SurvivorsScoreReward` where Activity=?");
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x001A1B38 File Offset: 0x0019FD38
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsScoreReward> GetConfigList(int p0Activity, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsScoreRewardByActivity.HandleId, ConfigSurvivorsScoreRewardByActivity.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsScoreRewardByActivity");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Activity);
				IReadOnlyList<SurvivorsScoreReward> readOnlyList = (IReadOnlyList<SurvivorsScoreReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsScoreRewardByActivity.LogPair.Clear();
			ConfigSurvivorsScoreRewardByActivity.LogPair.Add(new ValueTuple<string, object>("Activity", p0Activity));
			if (!ConfigCommon.BindInt(ConfigSurvivorsScoreRewardByActivity.HandleId, 1, p0Activity, ConfigSurvivorsScoreRewardByActivity.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsScoreRewardByActivity.HandleId, ConfigSurvivorsScoreRewardByActivity.LogPair);
				return null;
			}
			List<SurvivorsScoreReward> list = new List<SurvivorsScoreReward>();
			while (ConfigCommon.Step(ConfigSurvivorsScoreRewardByActivity.HandleId, false, ConfigSurvivorsScoreRewardByActivity.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsScoreRewardByActivity.HandleId, 0, ConfigSurvivorsScoreRewardByActivity.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsScoreRewardByActivity.HandleId, ConfigSurvivorsScoreRewardByActivity.LogPair);
					return null;
				}
				SurvivorsScoreReward rootAsSurvivorsScoreReward = SurvivorsScoreReward.GetRootAsSurvivorsScoreReward(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsScoreReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsScoreRewardByActivity");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Activity);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsScoreRewardByActivity.HandleId, ConfigSurvivorsScoreRewardByActivity.LogPair);
			return list;
		}

		// Token: 0x04004377 RID: 17271
		private const string DB = "db_survivors.db";

		// Token: 0x04004378 RID: 17272
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x04004379 RID: 17273
		private const string TABLE = "SurvivorsScoreReward";

		// Token: 0x0400437A RID: 17274
		private const string COMMAND = "select BinData from `SurvivorsScoreReward` where Activity=?";

		// Token: 0x0400437B RID: 17275
		private const string KEY_PREFIX = "SurvivorsScoreRewardByActivity";

		// Token: 0x0400437C RID: 17276
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400437D RID: 17277
		private static int HandleId;
	}
}
