using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000692 RID: 1682
	public class ConfigPhantomFetterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600277C RID: 10108 RVA: 0x00138F4C File Offset: 0x0013714C
		static ConfigPhantomFetterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterAll.CreateStaticDefaultValue), new Action(ConfigPhantomFetterAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00138F6C File Offset: 0x0013716C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomFetterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomFetterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomFetter"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomFetter`")
			});
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00138FEB File Offset: 0x001371EB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterAll.LogPair = null;
			ConfigPhantomFetterAll.HandleId = 0;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00138FF9 File Offset: 0x001371F9
		public static void Init()
		{
			ConfigPhantomFetterAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterAll.HandleId, "db_phantom.db", "select BinData from `PhantomFetter`");
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00139014 File Offset: 0x00137214
		[NullableContext(2)]
		public static IReadOnlyList<PhantomFetter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomFetterAll.HandleId, ConfigPhantomFetterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomFetter> readOnlyList = (IReadOnlyList<PhantomFetter>)ConfigCommon.GetConfig("PhantomFetterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomFetter> list = new List<PhantomFetter>();
			while (ConfigCommon.Step(ConfigPhantomFetterAll.HandleId, false, ConfigPhantomFetterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomFetterAll.HandleId, 0, ConfigPhantomFetterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomFetterAll.HandleId, ConfigPhantomFetterAll.LogPair);
					return null;
				}
				PhantomFetter rootAsPhantomFetter = PhantomFetter.GetRootAsPhantomFetter(new ByteBuffer(item2));
				list.Add(rootAsPhantomFetter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomFetterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomFetterAll.HandleId, ConfigPhantomFetterAll.LogPair);
			return list;
		}

		// Token: 0x04002DE4 RID: 11748
		private const string DB = "db_phantom.db";

		// Token: 0x04002DE5 RID: 11749
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002DE6 RID: 11750
		private const string TABLE = "PhantomFetter";

		// Token: 0x04002DE7 RID: 11751
		private const string COMMAND = "select BinData from `PhantomFetter`";

		// Token: 0x04002DE8 RID: 11752
		private const string KEY_PREFIX = "PhantomFetterAll";

		// Token: 0x04002DE9 RID: 11753
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DEA RID: 11754
		private static int HandleId;
	}
}
