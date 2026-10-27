using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069D RID: 1693
	public class ConfigPhantomHandBookPageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027BE RID: 10174 RVA: 0x0013A5D8 File Offset: 0x001387D8
		static ConfigPhantomHandBookPageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomHandBookPageAll.CreateStaticDefaultValue), new Action(ConfigPhantomHandBookPageAll.ResetStaticDefaultValue));
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x0013A5F8 File Offset: 0x001387F8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomHandBookPageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomHandBookPageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomHandBookPage"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomHandBookPage`")
			});
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x0013A677 File Offset: 0x00138877
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomHandBookPageAll.LogPair = null;
			ConfigPhantomHandBookPageAll.HandleId = 0;
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x0013A685 File Offset: 0x00138885
		public static void Init()
		{
			ConfigPhantomHandBookPageAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomHandBookPageAll.HandleId, "db_handbook.db", "select BinData from `PhantomHandBookPage`");
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0013A6A0 File Offset: 0x001388A0
		[NullableContext(2)]
		public static IReadOnlyList<PhantomHandBookPage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomHandBookPageAll.HandleId, ConfigPhantomHandBookPageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomHandBookPage> readOnlyList = (IReadOnlyList<PhantomHandBookPage>)ConfigCommon.GetConfig("PhantomHandBookPageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomHandBookPage> list = new List<PhantomHandBookPage>();
			while (ConfigCommon.Step(ConfigPhantomHandBookPageAll.HandleId, false, ConfigPhantomHandBookPageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomHandBookPageAll.HandleId, 0, ConfigPhantomHandBookPageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomHandBookPageAll.HandleId, ConfigPhantomHandBookPageAll.LogPair);
					return null;
				}
				PhantomHandBookPage rootAsPhantomHandBookPage = PhantomHandBookPage.GetRootAsPhantomHandBookPage(new ByteBuffer(item2));
				list.Add(rootAsPhantomHandBookPage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomHandBookPageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomHandBookPageAll.HandleId, ConfigPhantomHandBookPageAll.LogPair);
			return list;
		}

		// Token: 0x04002E31 RID: 11825
		private const string DB = "db_handbook.db";

		// Token: 0x04002E32 RID: 11826
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002E33 RID: 11827
		private const string TABLE = "PhantomHandBookPage";

		// Token: 0x04002E34 RID: 11828
		private const string COMMAND = "select BinData from `PhantomHandBookPage`";

		// Token: 0x04002E35 RID: 11829
		private const string KEY_PREFIX = "PhantomHandBookPageAll";

		// Token: 0x04002E36 RID: 11830
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E37 RID: 11831
		private static int HandleId;
	}
}
