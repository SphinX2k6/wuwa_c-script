using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B3 RID: 1715
	public class ConfigPhantomHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002842 RID: 10306 RVA: 0x00140C79 File Offset: 0x0013EE79
		static ConfigPhantomHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomHandBookAll.CreateStaticDefaultValue), new Action(ConfigPhantomHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00140C98 File Offset: 0x0013EE98
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

		// Token: 0x06002844 RID: 10308 RVA: 0x00140D17 File Offset: 0x0013EF17
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomHandBookAll.LogPair = null;
			ConfigPhantomHandBookAll.HandleId = 0;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00140D25 File Offset: 0x0013EF25
		public static void Init()
		{
			ConfigPhantomHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomHandBookAll.HandleId, "db_handbook.db", "select BinData from `PhantomHandBook`");
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00140D40 File Offset: 0x0013EF40
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

		// Token: 0x04002ECB RID: 11979
		private const string DB = "db_handbook.db";

		// Token: 0x04002ECC RID: 11980
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002ECD RID: 11981
		private const string TABLE = "PhantomHandBook";

		// Token: 0x04002ECE RID: 11982
		private const string COMMAND = "select BinData from `PhantomHandBook`";

		// Token: 0x04002ECF RID: 11983
		private const string KEY_PREFIX = "PhantomHandBookAll";

		// Token: 0x04002ED0 RID: 11984
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ED1 RID: 11985
		private static int HandleId;
	}
}
