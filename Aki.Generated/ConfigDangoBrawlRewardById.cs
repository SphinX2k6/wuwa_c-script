using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D9 RID: 473
	public class ConfigDangoBrawlRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B19 RID: 2841 RVA: 0x00098513 File Offset: 0x00096713
		static ConfigDangoBrawlRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlRewardById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00098534 File Offset: 0x00096734
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlReward"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlReward` where Id=?")
			});
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000985B3 File Offset: 0x000967B3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlRewardById.LogPair = null;
			ConfigDangoBrawlRewardById.HandleId = 0;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000985C1 File Offset: 0x000967C1
		public static void Init()
		{
			ConfigDangoBrawlRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlRewardById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlReward` where Id=?");
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000985DC File Offset: 0x000967DC
		public static DangoBrawlReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlRewardById.HandleId, ConfigDangoBrawlRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlReward?(DangoBrawlReward.GetRootAsDangoBrawlReward(configBuffer));
				}
			}
			ConfigDangoBrawlRewardById.LogPair.Clear();
			ConfigDangoBrawlRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlRewardById.HandleId, 1, p0Id, ConfigDangoBrawlRewardById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlRewardById.HandleId, true, ConfigDangoBrawlRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRewardById.HandleId, ConfigDangoBrawlRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlRewardById.HandleId, 0, ConfigDangoBrawlRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlRewardById.HandleId, ConfigDangoBrawlRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlReward rootAsDangoBrawlReward = DangoBrawlReward.GetRootAsDangoBrawlReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlRewardById.HandleId, ConfigDangoBrawlRewardById.LogPair);
			return new DangoBrawlReward?(rootAsDangoBrawlReward);
		}

		// Token: 0x04000CD3 RID: 3283
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CD4 RID: 3284
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CD5 RID: 3285
		private const string TABLE = "DangoBrawlReward";

		// Token: 0x04000CD6 RID: 3286
		private const string COMMAND = "select BinData from `DangoBrawlReward` where Id=?";

		// Token: 0x04000CD7 RID: 3287
		private const string KEY_PREFIX = "DangoBrawlRewardById";

		// Token: 0x04000CD8 RID: 3288
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CD9 RID: 3289
		private static int HandleId;
	}
}
