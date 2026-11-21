using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A8 RID: 1704
	public class ConfigPhantomExpItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002800 RID: 10240 RVA: 0x0013F5EC File Offset: 0x0013D7EC
		static ConfigPhantomExpItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomExpItemAll.CreateStaticDefaultValue), new Action(ConfigPhantomExpItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x0013F60C File Offset: 0x0013D80C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomExpItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomExpItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomExpItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomExpItem`")
			});
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x0013F68B File Offset: 0x0013D88B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomExpItemAll.LogPair = null;
			ConfigPhantomExpItemAll.HandleId = 0;
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x0013F699 File Offset: 0x0013D899
		public static void Init()
		{
			ConfigPhantomExpItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomExpItemAll.HandleId, "db_phantom.db", "select BinData from `PhantomExpItem`");
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x0013F6B4 File Offset: 0x0013D8B4
		[NullableContext(2)]
		public static IReadOnlyList<PhantomExpItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomExpItemAll.HandleId, ConfigPhantomExpItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomExpItem> readOnlyList = (IReadOnlyList<PhantomExpItem>)ConfigCommon.GetConfig("PhantomExpItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomExpItem> list = new List<PhantomExpItem>();
			while (ConfigCommon.Step(ConfigPhantomExpItemAll.HandleId, false, ConfigPhantomExpItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomExpItemAll.HandleId, 0, ConfigPhantomExpItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomExpItemAll.HandleId, ConfigPhantomExpItemAll.LogPair);
					return null;
				}
				PhantomExpItem rootAsPhantomExpItem = PhantomExpItem.GetRootAsPhantomExpItem(new ByteBuffer(item2));
				list.Add(rootAsPhantomExpItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomExpItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomExpItemAll.HandleId, ConfigPhantomExpItemAll.LogPair);
			return list;
		}

		// Token: 0x04002E7E RID: 11902
		private const string DB = "db_phantom.db";

		// Token: 0x04002E7F RID: 11903
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E80 RID: 11904
		private const string TABLE = "PhantomExpItem";

		// Token: 0x04002E81 RID: 11905
		private const string COMMAND = "select BinData from `PhantomExpItem`";

		// Token: 0x04002E82 RID: 11906
		private const string KEY_PREFIX = "PhantomExpItemAll";

		// Token: 0x04002E83 RID: 11907
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E84 RID: 11908
		private static int HandleId;
	}
}
