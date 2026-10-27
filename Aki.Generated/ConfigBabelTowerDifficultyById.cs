using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D6 RID: 214
	public class ConfigBabelTowerDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x000760BD File Offset: 0x000742BD
		static ConfigBabelTowerDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDifficultyById.CreateStaticDefaultValue), new Action(ConfigBabelTowerDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000760DC File Offset: 0x000742DC
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

		// Token: 0x06000507 RID: 1287 RVA: 0x0007615B File Offset: 0x0007435B
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyById.LogPair = null;
			ConfigBabelTowerDifficultyById.HandleId = 0;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00076169 File Offset: 0x00074369
		public static void Init()
		{
			ConfigBabelTowerDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDifficultyById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDifficulty` where Id=?");
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00076184 File Offset: 0x00074384
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

		// Token: 0x040005BE RID: 1470
		private const string DB = "db_babeltower.db";

		// Token: 0x040005BF RID: 1471
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005C0 RID: 1472
		private const string TABLE = "BabelTowerDifficulty";

		// Token: 0x040005C1 RID: 1473
		private const string COMMAND = "select BinData from `BabelTowerDifficulty` where Id=?";

		// Token: 0x040005C2 RID: 1474
		private const string KEY_PREFIX = "BabelTowerDifficultyById";

		// Token: 0x040005C3 RID: 1475
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005C4 RID: 1476
		private static int HandleId;
	}
}
