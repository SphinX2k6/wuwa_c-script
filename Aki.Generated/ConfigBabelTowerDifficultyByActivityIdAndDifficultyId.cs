using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E4 RID: 228
	public class ConfigBabelTowerDifficultyByActivityIdAndDifficultyId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x0007B783 File Offset: 0x00079983
		static ConfigBabelTowerDifficultyByActivityIdAndDifficultyId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.CreateStaticDefaultValue), new Action(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.ResetStaticDefaultValue));
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0007B7A4 File Offset: 0x000799A4
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

		// Token: 0x0600055B RID: 1371 RVA: 0x0007B823 File Offset: 0x00079A23
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.LogPair = null;
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId = 0;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0007B831 File Offset: 0x00079A31
		public static void Init()
		{
			ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDifficultyByActivityIdAndDifficultyId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDifficulty` where ActivityId=? AND DifficultyId=?");
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0007B84C File Offset: 0x00079A4C
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

		// Token: 0x04000620 RID: 1568
		private const string DB = "db_babeltower.db";

		// Token: 0x04000621 RID: 1569
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000622 RID: 1570
		private const string TABLE = "BabelTowerDifficulty";

		// Token: 0x04000623 RID: 1571
		private const string COMMAND = "select BinData from `BabelTowerDifficulty` where ActivityId=? AND DifficultyId=?";

		// Token: 0x04000624 RID: 1572
		private const string KEY_PREFIX = "BabelTowerDifficultyByActivityIdAndDifficultyId";

		// Token: 0x04000625 RID: 1573
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000626 RID: 1574
		private static int HandleId;
	}
}
