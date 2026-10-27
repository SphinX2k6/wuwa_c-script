using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069E RID: 1694
	public class ConfigPhantomItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027C4 RID: 10180 RVA: 0x0013A76B File Offset: 0x0013896B
		static ConfigPhantomItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomItemAll.CreateStaticDefaultValue), new Action(ConfigPhantomItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0013A78C File Offset: 0x0013898C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomItem`")
			});
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x0013A80B File Offset: 0x00138A0B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomItemAll.LogPair = null;
			ConfigPhantomItemAll.HandleId = 0;
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0013A819 File Offset: 0x00138A19
		public static void Init()
		{
			ConfigPhantomItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomItemAll.HandleId, "db_phantom.db", "select BinData from `PhantomItem`");
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0013A834 File Offset: 0x00138A34
		[NullableContext(2)]
		public static IReadOnlyList<PhantomItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomItemAll.HandleId, ConfigPhantomItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomItem> readOnlyList = (IReadOnlyList<PhantomItem>)ConfigCommon.GetConfig("PhantomItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomItem> list = new List<PhantomItem>();
			while (ConfigCommon.Step(ConfigPhantomItemAll.HandleId, false, ConfigPhantomItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomItemAll.HandleId, 0, ConfigPhantomItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomItemAll.HandleId, ConfigPhantomItemAll.LogPair);
					return null;
				}
				PhantomItem rootAsPhantomItem = PhantomItem.GetRootAsPhantomItem(new ByteBuffer(item2));
				list.Add(rootAsPhantomItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomItemAll.HandleId, ConfigPhantomItemAll.LogPair);
			return list;
		}

		// Token: 0x04002E38 RID: 11832
		private const string DB = "db_phantom.db";

		// Token: 0x04002E39 RID: 11833
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E3A RID: 11834
		private const string TABLE = "PhantomItem";

		// Token: 0x04002E3B RID: 11835
		private const string COMMAND = "select BinData from `PhantomItem`";

		// Token: 0x04002E3C RID: 11836
		private const string KEY_PREFIX = "PhantomItemAll";

		// Token: 0x04002E3D RID: 11837
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E3E RID: 11838
		private static int HandleId;
	}
}
