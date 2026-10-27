using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000690 RID: 1680
	public class ConfigPhantomExpItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002770 RID: 10096 RVA: 0x00138B70 File Offset: 0x00136D70
		static ConfigPhantomExpItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomExpItemAll.CreateStaticDefaultValue), new Action(ConfigPhantomExpItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00138B90 File Offset: 0x00136D90
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

		// Token: 0x06002772 RID: 10098 RVA: 0x00138C0F File Offset: 0x00136E0F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomExpItemAll.LogPair = null;
			ConfigPhantomExpItemAll.HandleId = 0;
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00138C1D File Offset: 0x00136E1D
		public static void Init()
		{
			ConfigPhantomExpItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomExpItemAll.HandleId, "db_phantom.db", "select BinData from `PhantomExpItem`");
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00138C38 File Offset: 0x00136E38
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

		// Token: 0x04002DD6 RID: 11734
		private const string DB = "db_phantom.db";

		// Token: 0x04002DD7 RID: 11735
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002DD8 RID: 11736
		private const string TABLE = "PhantomExpItem";

		// Token: 0x04002DD9 RID: 11737
		private const string COMMAND = "select BinData from `PhantomExpItem`";

		// Token: 0x04002DDA RID: 11738
		private const string KEY_PREFIX = "PhantomExpItemAll";

		// Token: 0x04002DDB RID: 11739
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DDC RID: 11740
		private static int HandleId;
	}
}
