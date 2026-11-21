using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E1 RID: 225
	public class ConfigBabelTowerDeTermMutexById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000547 RID: 1351 RVA: 0x0007B170 File Offset: 0x00079370
		static ConfigBabelTowerDeTermMutexById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDeTermMutexById.CreateStaticDefaultValue), new Action(ConfigBabelTowerDeTermMutexById.ResetStaticDefaultValue));
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0007B190 File Offset: 0x00079390
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDeTermMutexById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDeTermMutexById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDeTermMutex"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDeTermMutex` where Id=?")
			});
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0007B20F File Offset: 0x0007940F
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDeTermMutexById.LogPair = null;
			ConfigBabelTowerDeTermMutexById.HandleId = 0;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0007B21D File Offset: 0x0007941D
		public static void Init()
		{
			ConfigBabelTowerDeTermMutexById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDeTermMutexById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDeTermMutex` where Id=?");
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0007B238 File Offset: 0x00079438
		public static BabelTowerDeTermMutex? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDeTermMutexById.HandleId, ConfigBabelTowerDeTermMutexById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDeTermMutexById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerDeTermMutex?(BabelTowerDeTermMutex.GetRootAsBabelTowerDeTermMutex(configBuffer));
				}
			}
			ConfigBabelTowerDeTermMutexById.LogPair.Clear();
			ConfigBabelTowerDeTermMutexById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBabelTowerDeTermMutexById.HandleId, 1, p0Id, ConfigBabelTowerDeTermMutexById.LogPair) || ConfigCommon.Step(ConfigBabelTowerDeTermMutexById.HandleId, true, ConfigBabelTowerDeTermMutexById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerDeTermMutexById.HandleId, ConfigBabelTowerDeTermMutexById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDeTermMutexById.HandleId, 0, ConfigBabelTowerDeTermMutexById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerDeTermMutexById.HandleId, ConfigBabelTowerDeTermMutexById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerDeTermMutex rootAsBabelTowerDeTermMutex = BabelTowerDeTermMutex.GetRootAsBabelTowerDeTermMutex(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDeTermMutexById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerDeTermMutexById.HandleId, ConfigBabelTowerDeTermMutexById.LogPair);
			return new BabelTowerDeTermMutex?(rootAsBabelTowerDeTermMutex);
		}

		// Token: 0x0400060B RID: 1547
		private const string DB = "db_babeltower.db";

		// Token: 0x0400060C RID: 1548
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x0400060D RID: 1549
		private const string TABLE = "BabelTowerDeTermMutex";

		// Token: 0x0400060E RID: 1550
		private const string COMMAND = "select BinData from `BabelTowerDeTermMutex` where Id=?";

		// Token: 0x0400060F RID: 1551
		private const string KEY_PREFIX = "BabelTowerDeTermMutexById";

		// Token: 0x04000610 RID: 1552
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000611 RID: 1553
		private static int HandleId;
	}
}
