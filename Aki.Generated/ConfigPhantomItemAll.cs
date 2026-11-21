using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B6 RID: 1718
	public class ConfigPhantomItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002854 RID: 10324 RVA: 0x001411E7 File Offset: 0x0013F3E7
		static ConfigPhantomItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomItemAll.CreateStaticDefaultValue), new Action(ConfigPhantomItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00141208 File Offset: 0x0013F408
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

		// Token: 0x06002856 RID: 10326 RVA: 0x00141287 File Offset: 0x0013F487
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomItemAll.LogPair = null;
			ConfigPhantomItemAll.HandleId = 0;
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00141295 File Offset: 0x0013F495
		public static void Init()
		{
			ConfigPhantomItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomItemAll.HandleId, "db_phantom.db", "select BinData from `PhantomItem`");
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x001412B0 File Offset: 0x0013F4B0
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

		// Token: 0x04002EE0 RID: 12000
		private const string DB = "db_phantom.db";

		// Token: 0x04002EE1 RID: 12001
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EE2 RID: 12002
		private const string TABLE = "PhantomItem";

		// Token: 0x04002EE3 RID: 12003
		private const string COMMAND = "select BinData from `PhantomItem`";

		// Token: 0x04002EE4 RID: 12004
		private const string KEY_PREFIX = "PhantomItemAll";

		// Token: 0x04002EE5 RID: 12005
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EE6 RID: 12006
		private static int HandleId;
	}
}
