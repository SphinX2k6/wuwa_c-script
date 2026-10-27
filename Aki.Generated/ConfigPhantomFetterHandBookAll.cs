using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000696 RID: 1686
	public class ConfigPhantomFetterHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002794 RID: 10132 RVA: 0x00139704 File Offset: 0x00137904
		static ConfigPhantomFetterHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterHandBookAll.CreateStaticDefaultValue), new Action(ConfigPhantomFetterHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x00139724 File Offset: 0x00137924
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

		// Token: 0x06002796 RID: 10134 RVA: 0x001397A3 File Offset: 0x001379A3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterHandBookAll.LogPair = null;
			ConfigPhantomFetterHandBookAll.HandleId = 0;
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x001397B1 File Offset: 0x001379B1
		public static void Init()
		{
			ConfigPhantomFetterHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterHandBookAll.HandleId, "db_handbook.db", "select BinData from `PhantomFetterHandBook`");
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x001397CC File Offset: 0x001379CC
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

		// Token: 0x04002E00 RID: 11776
		private const string DB = "db_handbook.db";

		// Token: 0x04002E01 RID: 11777
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002E02 RID: 11778
		private const string TABLE = "PhantomFetterHandBook";

		// Token: 0x04002E03 RID: 11779
		private const string COMMAND = "select BinData from `PhantomFetterHandBook`";

		// Token: 0x04002E04 RID: 11780
		private const string KEY_PREFIX = "PhantomFetterHandBookAll";

		// Token: 0x04002E05 RID: 11781
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E06 RID: 11782
		private static int HandleId;
	}
}
