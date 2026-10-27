using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000694 RID: 1684
	public class ConfigPhantomFetterGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002788 RID: 10120 RVA: 0x00139328 File Offset: 0x00137528
		static ConfigPhantomFetterGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterGroupAll.CreateStaticDefaultValue), new Action(ConfigPhantomFetterGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00139348 File Offset: 0x00137548
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomFetterGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomFetterGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomFetterGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomFetterGroup`")
			});
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x001393C7 File Offset: 0x001375C7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterGroupAll.LogPair = null;
			ConfigPhantomFetterGroupAll.HandleId = 0;
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x001393D5 File Offset: 0x001375D5
		public static void Init()
		{
			ConfigPhantomFetterGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterGroupAll.HandleId, "db_phantom.db", "select BinData from `PhantomFetterGroup`");
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x001393F0 File Offset: 0x001375F0
		[NullableContext(2)]
		public static IReadOnlyList<PhantomFetterGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomFetterGroupAll.HandleId, ConfigPhantomFetterGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomFetterGroup> readOnlyList = (IReadOnlyList<PhantomFetterGroup>)ConfigCommon.GetConfig("PhantomFetterGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomFetterGroup> list = new List<PhantomFetterGroup>();
			while (ConfigCommon.Step(ConfigPhantomFetterGroupAll.HandleId, false, ConfigPhantomFetterGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomFetterGroupAll.HandleId, 0, ConfigPhantomFetterGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomFetterGroupAll.HandleId, ConfigPhantomFetterGroupAll.LogPair);
					return null;
				}
				PhantomFetterGroup rootAsPhantomFetterGroup = PhantomFetterGroup.GetRootAsPhantomFetterGroup(new ByteBuffer(item2));
				list.Add(rootAsPhantomFetterGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomFetterGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomFetterGroupAll.HandleId, ConfigPhantomFetterGroupAll.LogPair);
			return list;
		}

		// Token: 0x04002DF2 RID: 11762
		private const string DB = "db_phantom.db";

		// Token: 0x04002DF3 RID: 11763
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002DF4 RID: 11764
		private const string TABLE = "PhantomFetterGroup";

		// Token: 0x04002DF5 RID: 11765
		private const string COMMAND = "select BinData from `PhantomFetterGroup`";

		// Token: 0x04002DF6 RID: 11766
		private const string KEY_PREFIX = "PhantomFetterGroupAll";

		// Token: 0x04002DF7 RID: 11767
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DF8 RID: 11768
		private static int HandleId;
	}
}
