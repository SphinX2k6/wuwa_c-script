using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000552 RID: 1362
	public class ConfigMenuConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FF8 RID: 8184 RVA: 0x00111960 File Offset: 0x0010FB60
		static ConfigMenuConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMenuConfigAll.CreateStaticDefaultValue), new Action(ConfigMenuConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x00111980 File Offset: 0x0010FB80
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

		// Token: 0x06001FFA RID: 8186 RVA: 0x001119FF File Offset: 0x0010FBFF
		public static void ResetStaticDefaultValue()
		{
			ConfigMenuConfigAll.LogPair = null;
			ConfigMenuConfigAll.HandleId = 0;
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x00111A0D File Offset: 0x0010FC0D
		public static void Init()
		{
			ConfigMenuConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigMenuConfigAll.HandleId, "db_menu.db", "select BinData from `MenuConfig`");
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x00111A28 File Offset: 0x0010FC28
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

		// Token: 0x04002522 RID: 9506
		private const string DB = "db_menu.db";

		// Token: 0x04002523 RID: 9507
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04002524 RID: 9508
		private const string TABLE = "MenuConfig";

		// Token: 0x04002525 RID: 9509
		private const string COMMAND = "select BinData from `MenuConfig`";

		// Token: 0x04002526 RID: 9510
		private const string KEY_PREFIX = "MenuConfigAll";

		// Token: 0x04002527 RID: 9511
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002528 RID: 9512
		private static int HandleId;
	}
}
