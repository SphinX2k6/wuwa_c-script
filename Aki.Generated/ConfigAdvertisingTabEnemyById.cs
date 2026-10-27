using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006B RID: 107
	public class ConfigAdvertisingTabEnemyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000282 RID: 642 RVA: 0x00067C43 File Offset: 0x00065E43
		static ConfigAdvertisingTabEnemyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabEnemyById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabEnemyById.ResetStaticDefaultValue));
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00067C64 File Offset: 0x00065E64
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabEnemyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabEnemyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabEnemy"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabEnemy` where Id=?")
			});
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00067CE3 File Offset: 0x00065EE3
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabEnemyById.LogPair = null;
			ConfigAdvertisingTabEnemyById.HandleId = 0;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00067CF1 File Offset: 0x00065EF1
		public static void Init()
		{
			ConfigAdvertisingTabEnemyById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabEnemyById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabEnemy` where Id=?");
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00067D0C File Offset: 0x00065F0C
		public static AdvertisingTabEnemy? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabEnemyById.HandleId, ConfigAdvertisingTabEnemyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabEnemyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingTabEnemy?(AdvertisingTabEnemy.GetRootAsAdvertisingTabEnemy(configBuffer));
				}
			}
			ConfigAdvertisingTabEnemyById.LogPair.Clear();
			ConfigAdvertisingTabEnemyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingTabEnemyById.HandleId, 1, p0Id, ConfigAdvertisingTabEnemyById.LogPair) || ConfigCommon.Step(ConfigAdvertisingTabEnemyById.HandleId, true, ConfigAdvertisingTabEnemyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabEnemyById.HandleId, ConfigAdvertisingTabEnemyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabEnemyById.HandleId, 0, ConfigAdvertisingTabEnemyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabEnemyById.HandleId, ConfigAdvertisingTabEnemyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingTabEnemy rootAsAdvertisingTabEnemy = AdvertisingTabEnemy.GetRootAsAdvertisingTabEnemy(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabEnemyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabEnemyById.HandleId, ConfigAdvertisingTabEnemyById.LogPair);
			return new AdvertisingTabEnemy?(rootAsAdvertisingTabEnemy);
		}

		// Token: 0x040002D1 RID: 721
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002D2 RID: 722
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002D3 RID: 723
		private const string TABLE = "AdvertisingTabEnemy";

		// Token: 0x040002D4 RID: 724
		private const string COMMAND = "select BinData from `AdvertisingTabEnemy` where Id=?";

		// Token: 0x040002D5 RID: 725
		private const string KEY_PREFIX = "AdvertisingTabEnemyById";

		// Token: 0x040002D6 RID: 726
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002D7 RID: 727
		private static int HandleId;
	}
}
