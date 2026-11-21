using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E5 RID: 229
	public class ConfigBabelTowerDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600055F RID: 1375 RVA: 0x0007BA21 File Offset: 0x00079C21
		static ConfigBabelTowerDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDifficultyById.CreateStaticDefaultValue), new Action(ConfigBabelTowerDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0007BA40 File Offset: 0x00079C40
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDifficultyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDifficulty` where Id=?")
			});
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0007BABF File Offset: 0x00079CBF
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyById.LogPair = null;
			ConfigBabelTowerDifficultyById.HandleId = 0;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0007BACD File Offset: 0x00079CCD
		public static void Init()
		{
			ConfigBabelTowerDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDifficultyById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDifficulty` where Id=?");
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0007BAE8 File Offset: 0x00079CE8
		public static BabelTowerDifficulty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDifficultyById.HandleId, ConfigBabelTowerDifficultyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerDifficulty?(BabelTowerDifficulty.GetRootAsBabelTowerDifficulty(configBuffer));
				}
			}
			ConfigBabelTowerDifficultyById.LogPair.Clear();
			ConfigBabelTowerDifficultyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBabelTowerDifficultyById.HandleId, 1, p0Id, ConfigBabelTowerDifficultyById.LogPair) || ConfigCommon.Step(ConfigBabelTowerDifficultyById.HandleId, true, ConfigBabelTowerDifficultyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerDifficultyById.HandleId, ConfigBabelTowerDifficultyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDifficultyById.HandleId, 0, ConfigBabelTowerDifficultyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerDifficultyById.HandleId, ConfigBabelTowerDifficultyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerDifficulty rootAsBabelTowerDifficulty = BabelTowerDifficulty.GetRootAsBabelTowerDifficulty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerDifficultyById.HandleId, ConfigBabelTowerDifficultyById.LogPair);
			return new BabelTowerDifficulty?(rootAsBabelTowerDifficulty);
		}

		// Token: 0x04000627 RID: 1575
		private const string DB = "db_babeltower.db";

		// Token: 0x04000628 RID: 1576
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000629 RID: 1577
		private const string TABLE = "BabelTowerDifficulty";

		// Token: 0x0400062A RID: 1578
		private const string COMMAND = "select BinData from `BabelTowerDifficulty` where Id=?";

		// Token: 0x0400062B RID: 1579
		private const string KEY_PREFIX = "BabelTowerDifficultyById";

		// Token: 0x0400062C RID: 1580
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400062D RID: 1581
		private static int HandleId;
	}
}
