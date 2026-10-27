using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D5 RID: 213
	public class ConfigBabelTowerDifficultyByActivityIdAndDifficultyId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004FF RID: 1279 RVA: 0x00075E1F File Offset: 0x0007401F
		static ConfigBabelTowerDifficultyByActivityIdAndDifficultyId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.CreateStaticDefaultValue), new Action(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.ResetStaticDefaultValue));
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00075E40 File Offset: 0x00074040
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDifficulty` where ActivityId=? AND DifficultyId=?")
			});
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00075EBF File Offset: 0x000740BF
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair = null;
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId = 0;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00075ECD File Offset: 0x000740CD
		public static void Init()
		{
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDifficulty` where ActivityId=? AND DifficultyId=?");
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00075EE8 File Offset: 0x000740E8
		public static BabelTowerDifficulty? GetConfig(int p0ActivityId, int p1DifficultyId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDifficultyByActivityIdAndDifficultyId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1DifficultyId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerDifficulty?(BabelTowerDifficulty.GetRootAsBabelTowerDifficulty(configBuffer));
				}
			}
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair.Clear();
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair.Add(new ValueTuple<string, object>("DifficultyId", p1DifficultyId));
			if (!ConfigCommon.BindInt(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, 1, p0ActivityId, ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair) || !ConfigCommon.BindInt(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, 2, p1DifficultyId, ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair) || ConfigCommon.Step(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, true, ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, 0, ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerDifficulty rootAsBabelTowerDifficulty = BabelTowerDifficulty.GetRootAsBabelTowerDifficulty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDifficultyByActivityIdAndDifficultyId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1DifficultyId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair);
			return new BabelTowerDifficulty?(rootAsBabelTowerDifficulty);
		}

		// Token: 0x040005B7 RID: 1463
		private const string DB = "db_babeltower.db";

		// Token: 0x040005B8 RID: 1464
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005B9 RID: 1465
		private const string TABLE = "BabelTowerDifficulty";

		// Token: 0x040005BA RID: 1466
		private const string COMMAND = "select BinData from `BabelTowerDifficulty` where ActivityId=? AND DifficultyId=?";

		// Token: 0x040005BB RID: 1467
		private const string KEY_PREFIX = "BabelTowerDifficultyByActivityIdAndDifficultyId";

		// Token: 0x040005BC RID: 1468
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005BD RID: 1469
		private static int HandleId;
	}
}
