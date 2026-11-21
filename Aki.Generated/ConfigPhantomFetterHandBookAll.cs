using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AE RID: 1710
	public class ConfigPhantomFetterHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002824 RID: 10276 RVA: 0x00140180 File Offset: 0x0013E380
		static ConfigPhantomFetterHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterHandBookAll.CreateStaticDefaultValue), new Action(ConfigPhantomFetterHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x001401A0 File Offset: 0x0013E3A0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomFetterHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomFetterHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomFetterHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomFetterHandBook`")
			});
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x0014021F File Offset: 0x0013E41F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterHandBookAll.LogPair = null;
			ConfigPhantomFetterHandBookAll.HandleId = 0;
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0014022D File Offset: 0x0013E42D
		public static void Init()
		{
			ConfigPhantomFetterHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterHandBookAll.HandleId, "db_handbook.db", "select BinData from `PhantomFetterHandBook`");
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00140248 File Offset: 0x0013E448
		[NullableContext(2)]
		public static IReadOnlyList<PhantomFetterHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomFetterHandBookAll.HandleId, ConfigPhantomFetterHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomFetterHandBook> readOnlyList = (IReadOnlyList<PhantomFetterHandBook>)ConfigCommon.GetConfig("PhantomFetterHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomFetterHandBook> list = new List<PhantomFetterHandBook>();
			while (ConfigCommon.Step(ConfigPhantomFetterHandBookAll.HandleId, false, ConfigPhantomFetterHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomFetterHandBookAll.HandleId, 0, ConfigPhantomFetterHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomFetterHandBookAll.HandleId, ConfigPhantomFetterHandBookAll.LogPair);
					return null;
				}
				PhantomFetterHandBook rootAsPhantomFetterHandBook = PhantomFetterHandBook.GetRootAsPhantomFetterHandBook(new ByteBuffer(item2));
				list.Add(rootAsPhantomFetterHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomFetterHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomFetterHandBookAll.HandleId, ConfigPhantomFetterHandBookAll.LogPair);
			return list;
		}

		// Token: 0x04002EA8 RID: 11944
		private const string DB = "db_handbook.db";

		// Token: 0x04002EA9 RID: 11945
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002EAA RID: 11946
		private const string TABLE = "PhantomFetterHandBook";

		// Token: 0x04002EAB RID: 11947
		private const string COMMAND = "select BinData from `PhantomFetterHandBook`";

		// Token: 0x04002EAC RID: 11948
		private const string KEY_PREFIX = "PhantomFetterHandBookAll";

		// Token: 0x04002EAD RID: 11949
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EAE RID: 11950
		private static int HandleId;
	}
}
