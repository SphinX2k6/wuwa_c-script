using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E0 RID: 480
	public class ConfigDangoBrawlScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B43 RID: 2883 RVA: 0x00099393 File Offset: 0x00097593
		static ConfigDangoBrawlScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlScoreRewardById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000993B4 File Offset: 0x000975B4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlScoreReward` where Id=?")
			});
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00099433 File Offset: 0x00097633
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlScoreRewardById.LogPair = null;
			ConfigDangoBrawlScoreRewardById.HandleId = 0;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00099441 File Offset: 0x00097641
		public static void Init()
		{
			ConfigDangoBrawlScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlScoreRewardById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlScoreReward` where Id=?");
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0009945C File Offset: 0x0009765C
		public static DangoBrawlScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlScoreRewardById.HandleId, ConfigDangoBrawlScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlScoreReward?(DangoBrawlScoreReward.GetRootAsDangoBrawlScoreReward(configBuffer));
				}
			}
			ConfigDangoBrawlScoreRewardById.LogPair.Clear();
			ConfigDangoBrawlScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlScoreRewardById.HandleId, 1, p0Id, ConfigDangoBrawlScoreRewardById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlScoreRewardById.HandleId, true, ConfigDangoBrawlScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlScoreRewardById.HandleId, ConfigDangoBrawlScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlScoreRewardById.HandleId, 0, ConfigDangoBrawlScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlScoreRewardById.HandleId, ConfigDangoBrawlScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlScoreReward rootAsDangoBrawlScoreReward = DangoBrawlScoreReward.GetRootAsDangoBrawlScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlScoreRewardById.HandleId, ConfigDangoBrawlScoreRewardById.LogPair);
			return new DangoBrawlScoreReward?(rootAsDangoBrawlScoreReward);
		}

		// Token: 0x04000D04 RID: 3332
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D05 RID: 3333
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D06 RID: 3334
		private const string TABLE = "DangoBrawlScoreReward";

		// Token: 0x04000D07 RID: 3335
		private const string COMMAND = "select BinData from `DangoBrawlScoreReward` where Id=?";

		// Token: 0x04000D08 RID: 3336
		private const string KEY_PREFIX = "DangoBrawlScoreRewardById";

		// Token: 0x04000D09 RID: 3337
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D0A RID: 3338
		private static int HandleId;
	}
}
