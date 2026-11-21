using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B5 RID: 1717
	public class ConfigPhantomHandBookPageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600284E RID: 10318 RVA: 0x00141054 File Offset: 0x0013F254
		static ConfigPhantomHandBookPageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomHandBookPageAll.CreateStaticDefaultValue), new Action(ConfigPhantomHandBookPageAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00141074 File Offset: 0x0013F274
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

		// Token: 0x06002850 RID: 10320 RVA: 0x001410F3 File Offset: 0x0013F2F3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomHandBookPageAll.LogPair = null;
			ConfigPhantomHandBookPageAll.HandleId = 0;
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00141101 File Offset: 0x0013F301
		public static void Init()
		{
			ConfigPhantomHandBookPageAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomHandBookPageAll.HandleId, "db_handbook.db", "select BinData from `PhantomHandBookPage`");
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x0014111C File Offset: 0x0013F31C
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

		// Token: 0x04002ED9 RID: 11993
		private const string DB = "db_handbook.db";

		// Token: 0x04002EDA RID: 11994
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002EDB RID: 11995
		private const string TABLE = "PhantomHandBookPage";

		// Token: 0x04002EDC RID: 11996
		private const string COMMAND = "select BinData from `PhantomHandBookPage`";

		// Token: 0x04002EDD RID: 11997
		private const string KEY_PREFIX = "PhantomHandBookPageAll";

		// Token: 0x04002EDE RID: 11998
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EDF RID: 11999
		private static int HandleId;
	}
}
