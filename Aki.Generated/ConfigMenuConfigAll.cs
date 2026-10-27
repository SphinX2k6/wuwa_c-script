using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053C RID: 1340
	public class ConfigMenuConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F74 RID: 8052 RVA: 0x0010B20C File Offset: 0x0010940C
		static ConfigMenuConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMenuConfigAll.CreateStaticDefaultValue), new Action(ConfigMenuConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x0010B22C File Offset: 0x0010942C
		public static void CreateStaticDefaultValue()
		{
			ConfigMenuConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMenuConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "MenuConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MenuConfig`")
			});
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0010B2AB File Offset: 0x001094AB
		public static void ResetStaticDefaultValue()
		{
			ConfigMenuConfigAll.LogPair = null;
			ConfigMenuConfigAll.HandleId = 0;
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0010B2B9 File Offset: 0x001094B9
		public static void Init()
		{
			ConfigMenuConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigMenuConfigAll.HandleId, "db_menu.db", "select BinData from `MenuConfig`");
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x0010B2D4 File Offset: 0x001094D4
		[NullableContext(2)]
		public static IReadOnlyList<MenuConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMenuConfigAll.HandleId, ConfigMenuConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MenuConfig> readOnlyList = (IReadOnlyList<MenuConfig>)ConfigCommon.GetConfig("MenuConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MenuConfig> list = new List<MenuConfig>();
			while (ConfigCommon.Step(ConfigMenuConfigAll.HandleId, false, ConfigMenuConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMenuConfigAll.HandleId, 0, ConfigMenuConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMenuConfigAll.HandleId, ConfigMenuConfigAll.LogPair);
					return null;
				}
				MenuConfig rootAsMenuConfig = MenuConfig.GetRootAsMenuConfig(new ByteBuffer(item2));
				list.Add(rootAsMenuConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MenuConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMenuConfigAll.HandleId, ConfigMenuConfigAll.LogPair);
			return list;
		}

		// Token: 0x04002488 RID: 9352
		private const string DB = "db_menu.db";

		// Token: 0x04002489 RID: 9353
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x0400248A RID: 9354
		private const string TABLE = "MenuConfig";

		// Token: 0x0400248B RID: 9355
		private const string COMMAND = "select BinData from `MenuConfig`";

		// Token: 0x0400248C RID: 9356
		private const string KEY_PREFIX = "MenuConfigAll";

		// Token: 0x0400248D RID: 9357
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400248E RID: 9358
		private static int HandleId;
	}
}
