using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006A RID: 106
	public class ConfigAdvertisingTabEnemyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600027C RID: 636 RVA: 0x00067AB0 File Offset: 0x00065CB0
		static ConfigAdvertisingTabEnemyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabEnemyAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabEnemyAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00067AD0 File Offset: 0x00065CD0
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabEnemyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabEnemyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabEnemy"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabEnemy`")
			});
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00067B4F File Offset: 0x00065D4F
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabEnemyAll.LogPair = null;
			ConfigAdvertisingTabEnemyAll.HandleId = 0;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00067B5D File Offset: 0x00065D5D
		public static void Init()
		{
			ConfigAdvertisingTabEnemyAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabEnemyAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabEnemy`");
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00067B78 File Offset: 0x00065D78
		[NullableContext(2)]
		public static IReadOnlyList<AdvertisingTabEnemy> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabEnemyAll.HandleId, ConfigAdvertisingTabEnemyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdvertisingTabEnemy> readOnlyList = (IReadOnlyList<AdvertisingTabEnemy>)ConfigCommon.GetConfig("AdvertisingTabEnemyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdvertisingTabEnemy> list = new List<AdvertisingTabEnemy>();
			while (ConfigCommon.Step(ConfigAdvertisingTabEnemyAll.HandleId, false, ConfigAdvertisingTabEnemyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabEnemyAll.HandleId, 0, ConfigAdvertisingTabEnemyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdvertisingTabEnemyAll.HandleId, ConfigAdvertisingTabEnemyAll.LogPair);
					return null;
				}
				AdvertisingTabEnemy rootAsAdvertisingTabEnemy = AdvertisingTabEnemy.GetRootAsAdvertisingTabEnemy(new ByteBuffer(item2));
				list.Add(rootAsAdvertisingTabEnemy);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdvertisingTabEnemyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabEnemyAll.HandleId, ConfigAdvertisingTabEnemyAll.LogPair);
			return list;
		}

		// Token: 0x040002CA RID: 714
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002CB RID: 715
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002CC RID: 716
		private const string TABLE = "AdvertisingTabEnemy";

		// Token: 0x040002CD RID: 717
		private const string COMMAND = "select BinData from `AdvertisingTabEnemy`";

		// Token: 0x040002CE RID: 718
		private const string KEY_PREFIX = "AdvertisingTabEnemyAll";

		// Token: 0x040002CF RID: 719
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002D0 RID: 720
		private static int HandleId;
	}
}
