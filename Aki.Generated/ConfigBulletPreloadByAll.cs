using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000130 RID: 304
	public class ConfigBulletPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x00082020 File Offset: 0x00080220
		static ConfigBulletPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBulletPreloadByAll.CreateStaticDefaultValue), new Action(ConfigBulletPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00082040 File Offset: 0x00080240
		public static void CreateStaticDefaultValue()
		{
			ConfigBulletPreloadByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBulletPreloadByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bullet_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/BulletPreload.csv"),
				new ValueTuple<string, object>("表名", "BulletPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `BulletPreload`")
			});
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000820BF File Offset: 0x000802BF
		public static void ResetStaticDefaultValue()
		{
			ConfigBulletPreloadByAll.LogPair = null;
			ConfigBulletPreloadByAll.HandleId = 0;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000820CD File Offset: 0x000802CD
		public static void Init()
		{
			ConfigBulletPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigBulletPreloadByAll.HandleId, "db_bullet_preload.db", "select BinData from `BulletPreload`");
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000820E8 File Offset: 0x000802E8
		[NullableContext(2)]
		public static IReadOnlyList<BulletPreload> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBulletPreloadByAll.HandleId, ConfigBulletPreloadByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BulletPreload> readOnlyList = (IReadOnlyList<BulletPreload>)ConfigCommon.GetConfig("BulletPreloadByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BulletPreload> list = new List<BulletPreload>();
			while (ConfigCommon.Step(ConfigBulletPreloadByAll.HandleId, false, ConfigBulletPreloadByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBulletPreloadByAll.HandleId, 0, ConfigBulletPreloadByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBulletPreloadByAll.HandleId, ConfigBulletPreloadByAll.LogPair);
					return null;
				}
				BulletPreload rootAsBulletPreload = BulletPreload.GetRootAsBulletPreload(new ByteBuffer(item2));
				list.Add(rootAsBulletPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BulletPreloadByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBulletPreloadByAll.HandleId, ConfigBulletPreloadByAll.LogPair);
			return list;
		}

		// Token: 0x04000834 RID: 2100
		private const string DB = "db_bullet_preload.db";

		// Token: 0x04000835 RID: 2101
		private const string FILE = "Preload/BulletPreload.csv";

		// Token: 0x04000836 RID: 2102
		private const string TABLE = "BulletPreload";

		// Token: 0x04000837 RID: 2103
		private const string COMMAND = "select BinData from `BulletPreload`";

		// Token: 0x04000838 RID: 2104
		private const string KEY_PREFIX = "BulletPreloadByAll";

		// Token: 0x04000839 RID: 2105
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400083A RID: 2106
		private static int HandleId;
	}
}
