using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013F RID: 319
	public class ConfigBulletPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x00087984 File Offset: 0x00085B84
		static ConfigBulletPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBulletPreloadByAll.CreateStaticDefaultValue), new Action(ConfigBulletPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000879A4 File Offset: 0x00085BA4
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

		// Token: 0x0600077D RID: 1917 RVA: 0x00087A23 File Offset: 0x00085C23
		public static void ResetStaticDefaultValue()
		{
			ConfigBulletPreloadByAll.LogPair = null;
			ConfigBulletPreloadByAll.HandleId = 0;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00087A31 File Offset: 0x00085C31
		public static void Init()
		{
			ConfigBulletPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigBulletPreloadByAll.HandleId, "db_bullet_preload.db", "select BinData from `BulletPreload`");
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00087A4C File Offset: 0x00085C4C
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

		// Token: 0x0400089D RID: 2205
		private const string DB = "db_bullet_preload.db";

		// Token: 0x0400089E RID: 2206
		private const string FILE = "Preload/BulletPreload.csv";

		// Token: 0x0400089F RID: 2207
		private const string TABLE = "BulletPreload";

		// Token: 0x040008A0 RID: 2208
		private const string COMMAND = "select BinData from `BulletPreload`";

		// Token: 0x040008A1 RID: 2209
		private const string KEY_PREFIX = "BulletPreloadByAll";

		// Token: 0x040008A2 RID: 2210
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008A3 RID: 2211
		private static int HandleId;
	}
}
