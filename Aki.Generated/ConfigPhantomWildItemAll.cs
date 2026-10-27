using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B9 RID: 1721
	public class ConfigPhantomWildItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002866 RID: 10342 RVA: 0x0013E0A0 File Offset: 0x0013C2A0
		static ConfigPhantomWildItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomWildItemAll.CreateStaticDefaultValue), new Action(ConfigPhantomWildItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0013E0C0 File Offset: 0x0013C2C0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomWildItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomWildItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomWildItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomWildItem`")
			});
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0013E13F File Offset: 0x0013C33F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomWildItemAll.LogPair = null;
			ConfigPhantomWildItemAll.HandleId = 0;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x0013E14D File Offset: 0x0013C34D
		public static void Init()
		{
			ConfigPhantomWildItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomWildItemAll.HandleId, "db_phantom.db", "select BinData from `PhantomWildItem`");
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0013E168 File Offset: 0x0013C368
		[NullableContext(2)]
		public static IReadOnlyList<PhantomWildItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomWildItemAll.HandleId, ConfigPhantomWildItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomWildItem> readOnlyList = (IReadOnlyList<PhantomWildItem>)ConfigCommon.GetConfig("PhantomWildItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomWildItem> list = new List<PhantomWildItem>();
			while (ConfigCommon.Step(ConfigPhantomWildItemAll.HandleId, false, ConfigPhantomWildItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomWildItemAll.HandleId, 0, ConfigPhantomWildItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomWildItemAll.HandleId, ConfigPhantomWildItemAll.LogPair);
					return null;
				}
				PhantomWildItem rootAsPhantomWildItem = PhantomWildItem.GetRootAsPhantomWildItem(new ByteBuffer(item2));
				list.Add(rootAsPhantomWildItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomWildItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomWildItemAll.HandleId, ConfigPhantomWildItemAll.LogPair);
			return list;
		}

		// Token: 0x04002EF5 RID: 12021
		private const string DB = "db_phantom.db";

		// Token: 0x04002EF6 RID: 12022
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EF7 RID: 12023
		private const string TABLE = "PhantomWildItem";

		// Token: 0x04002EF8 RID: 12024
		private const string COMMAND = "select BinData from `PhantomWildItem`";

		// Token: 0x04002EF9 RID: 12025
		private const string KEY_PREFIX = "PhantomWildItemAll";

		// Token: 0x04002EFA RID: 12026
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EFB RID: 12027
		private static int HandleId;
	}
}
