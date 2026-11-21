using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000073 RID: 115
	public class ConfigAdvertisingTabEnemyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x0006C4F7 File Offset: 0x0006A6F7
		static ConfigAdvertisingTabEnemyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabEnemyById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabEnemyById.ResetStaticDefaultValue));
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0006C518 File Offset: 0x0006A718
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

		// Token: 0x060002B4 RID: 692 RVA: 0x0006C597 File Offset: 0x0006A797
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabEnemyById.LogPair = null;
			ConfigAdvertisingTabEnemyById.HandleId = 0;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0006C5A5 File Offset: 0x0006A7A5
		public static void Init()
		{
			ConfigAdvertisingTabEnemyById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabEnemyById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabEnemy` where Id=?");
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0006C5C0 File Offset: 0x0006A7C0
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

		// Token: 0x04000309 RID: 777
		private const string DB = "db_advertisingpage.db";

		// Token: 0x0400030A RID: 778
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x0400030B RID: 779
		private const string TABLE = "AdvertisingTabEnemy";

		// Token: 0x0400030C RID: 780
		private const string COMMAND = "select BinData from `AdvertisingTabEnemy` where Id=?";

		// Token: 0x0400030D RID: 781
		private const string KEY_PREFIX = "AdvertisingTabEnemyById";

		// Token: 0x0400030E RID: 782
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400030F RID: 783
		private static int HandleId;
	}
}
