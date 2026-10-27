using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069B RID: 1691
	public class ConfigPhantomHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027B2 RID: 10162 RVA: 0x0013A1FD File Offset: 0x001383FD
		static ConfigPhantomHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomHandBookAll.CreateStaticDefaultValue), new Action(ConfigPhantomHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x0013A21C File Offset: 0x0013841C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomHandBook`")
			});
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x0013A29B File Offset: 0x0013849B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomHandBookAll.LogPair = null;
			ConfigPhantomHandBookAll.HandleId = 0;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x0013A2A9 File Offset: 0x001384A9
		public static void Init()
		{
			ConfigPhantomHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomHandBookAll.HandleId, "db_handbook.db", "select BinData from `PhantomHandBook`");
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x0013A2C4 File Offset: 0x001384C4
		[NullableContext(2)]
		public static IReadOnlyList<PhantomHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomHandBookAll.HandleId, ConfigPhantomHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomHandBook> readOnlyList = (IReadOnlyList<PhantomHandBook>)ConfigCommon.GetConfig("PhantomHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomHandBook> list = new List<PhantomHandBook>();
			while (ConfigCommon.Step(ConfigPhantomHandBookAll.HandleId, false, ConfigPhantomHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomHandBookAll.HandleId, 0, ConfigPhantomHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomHandBookAll.HandleId, ConfigPhantomHandBookAll.LogPair);
					return null;
				}
				PhantomHandBook rootAsPhantomHandBook = PhantomHandBook.GetRootAsPhantomHandBook(new ByteBuffer(item2));
				list.Add(rootAsPhantomHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomHandBookAll.HandleId, ConfigPhantomHandBookAll.LogPair);
			return list;
		}

		// Token: 0x04002E23 RID: 11811
		private const string DB = "db_handbook.db";

		// Token: 0x04002E24 RID: 11812
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002E25 RID: 11813
		private const string TABLE = "PhantomHandBook";

		// Token: 0x04002E26 RID: 11814
		private const string COMMAND = "select BinData from `PhantomHandBook`";

		// Token: 0x04002E27 RID: 11815
		private const string KEY_PREFIX = "PhantomHandBookAll";

		// Token: 0x04002E28 RID: 11816
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E29 RID: 11817
		private static int HandleId;
	}
}
