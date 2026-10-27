using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D2 RID: 210
	public class ConfigBabelTowerDeTermMutexById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x0007580C File Offset: 0x00073A0C
		static ConfigBabelTowerDeTermMutexById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDeTermMutexById.CreateStaticDefaultValue), new Action(ConfigBabelTowerDeTermMutexById.ResetStaticDefaultValue));
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0007582C File Offset: 0x00073A2C
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

		// Token: 0x060004EF RID: 1263 RVA: 0x000758AB File Offset: 0x00073AAB
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDeTermMutexById.LogPair = null;
			ConfigBabelTowerDeTermMutexById.HandleId = 0;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000758B9 File Offset: 0x00073AB9
		public static void Init()
		{
			ConfigBabelTowerDeTermMutexById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDeTermMutexById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDeTermMutex` where Id=?");
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000758D4 File Offset: 0x00073AD4
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

		// Token: 0x040005A2 RID: 1442
		private const string DB = "db_babeltower.db";

		// Token: 0x040005A3 RID: 1443
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005A4 RID: 1444
		private const string TABLE = "BabelTowerDeTermMutex";

		// Token: 0x040005A5 RID: 1445
		private const string COMMAND = "select BinData from `BabelTowerDeTermMutex` where Id=?";

		// Token: 0x040005A6 RID: 1446
		private const string KEY_PREFIX = "BabelTowerDeTermMutexById";

		// Token: 0x040005A7 RID: 1447
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005A8 RID: 1448
		private static int HandleId;
	}
}
