using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000072 RID: 114
	public class ConfigAdvertisingTabEnemyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060002AC RID: 684 RVA: 0x0006C364 File Offset: 0x0006A564
		static ConfigAdvertisingTabEnemyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabEnemyAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabEnemyAll.ResetStaticDefaultValue));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0006C384 File Offset: 0x0006A584
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

		// Token: 0x060002AE RID: 686 RVA: 0x0006C403 File Offset: 0x0006A603
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabEnemyAll.LogPair = null;
			ConfigAdvertisingTabEnemyAll.HandleId = 0;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0006C411 File Offset: 0x0006A611
		public static void Init()
		{
			ConfigAdvertisingTabEnemyAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabEnemyAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabEnemy`");
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0006C42C File Offset: 0x0006A62C
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

		// Token: 0x04000302 RID: 770
		private const string DB = "db_advertisingpage.db";

		// Token: 0x04000303 RID: 771
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x04000304 RID: 772
		private const string TABLE = "AdvertisingTabEnemy";

		// Token: 0x04000305 RID: 773
		private const string COMMAND = "select BinData from `AdvertisingTabEnemy`";

		// Token: 0x04000306 RID: 774
		private const string KEY_PREFIX = "AdvertisingTabEnemyAll";

		// Token: 0x04000307 RID: 775
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000308 RID: 776
		private static int HandleId;
	}
}
