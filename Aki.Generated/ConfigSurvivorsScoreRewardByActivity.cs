using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7C RID: 2684
	public class ConfigSurvivorsScoreRewardByActivity : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EFC RID: 16124 RVA: 0x001C0E03 File Offset: 0x001BF003
		static ConfigSurvivorsScoreRewardByActivity()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsScoreRewardByActivity.CreateStaticDefaultValue), new Action(ConfigSurvivorsScoreRewardByActivity.ResetStaticDefaultValue));
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x001C0E24 File Offset: 0x001BF024
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

		// Token: 0x06003EFE RID: 16126 RVA: 0x001C0EA3 File Offset: 0x001BF0A3
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsScoreRewardByActivity.LogPair = null;
			ConfigSurvivorsScoreRewardByActivity.HandleId = 0;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x001C0EB1 File Offset: 0x001BF0B1
		public static void Init()
		{
			ConfigSurvivorsScoreRewardByActivity.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsScoreRewardByActivity.HandleId, "db_survivors.db", "select BinData from `SurvivorsScoreReward` where Activity=?");
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x001C0ECC File Offset: 0x001BF0CC
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

		// Token: 0x0400494A RID: 18762
		private const string DB = "db_survivors.db";

		// Token: 0x0400494B RID: 18763
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x0400494C RID: 18764
		private const string TABLE = "SurvivorsScoreReward";

		// Token: 0x0400494D RID: 18765
		private const string COMMAND = "select BinData from `SurvivorsScoreReward` where Activity=?";

		// Token: 0x0400494E RID: 18766
		private const string KEY_PREFIX = "SurvivorsScoreRewardByActivity";

		// Token: 0x0400494F RID: 18767
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004950 RID: 18768
		private static int HandleId;
	}
}
