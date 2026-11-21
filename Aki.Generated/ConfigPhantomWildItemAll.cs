using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D1 RID: 1745
	public class ConfigPhantomWildItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028F6 RID: 10486 RVA: 0x00144B1C File Offset: 0x00142D1C
		static ConfigPhantomWildItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomWildItemAll.CreateStaticDefaultValue), new Action(ConfigPhantomWildItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00144B3C File Offset: 0x00142D3C
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

		// Token: 0x060028F8 RID: 10488 RVA: 0x00144BBB File Offset: 0x00142DBB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomWildItemAll.LogPair = null;
			ConfigPhantomWildItemAll.HandleId = 0;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00144BC9 File Offset: 0x00142DC9
		public static void Init()
		{
			ConfigPhantomWildItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomWildItemAll.HandleId, "db_phantom.db", "select BinData from `PhantomWildItem`");
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00144BE4 File Offset: 0x00142DE4
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

		// Token: 0x04002F9D RID: 12189
		private const string DB = "db_phantom.db";

		// Token: 0x04002F9E RID: 12190
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F9F RID: 12191
		private const string TABLE = "PhantomWildItem";

		// Token: 0x04002FA0 RID: 12192
		private const string COMMAND = "select BinData from `PhantomWildItem`";

		// Token: 0x04002FA1 RID: 12193
		private const string KEY_PREFIX = "PhantomWildItemAll";

		// Token: 0x04002FA2 RID: 12194
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FA3 RID: 12195
		private static int HandleId;
	}
}
