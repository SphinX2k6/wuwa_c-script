using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AC RID: 1708
	public class ConfigPhantomFetterGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002818 RID: 10264 RVA: 0x0013FDA4 File Offset: 0x0013DFA4
		static ConfigPhantomFetterGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterGroupAll.CreateStaticDefaultValue), new Action(ConfigPhantomFetterGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x0013FDC4 File Offset: 0x0013DFC4
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

		// Token: 0x0600281A RID: 10266 RVA: 0x0013FE43 File Offset: 0x0013E043
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterGroupAll.LogPair = null;
			ConfigPhantomFetterGroupAll.HandleId = 0;
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x0013FE51 File Offset: 0x0013E051
		public static void Init()
		{
			ConfigPhantomFetterGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterGroupAll.HandleId, "db_phantom.db", "select BinData from `PhantomFetterGroup`");
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x0013FE6C File Offset: 0x0013E06C
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

		// Token: 0x04002E9A RID: 11930
		private const string DB = "db_phantom.db";

		// Token: 0x04002E9B RID: 11931
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E9C RID: 11932
		private const string TABLE = "PhantomFetterGroup";

		// Token: 0x04002E9D RID: 11933
		private const string COMMAND = "select BinData from `PhantomFetterGroup`";

		// Token: 0x04002E9E RID: 11934
		private const string KEY_PREFIX = "PhantomFetterGroupAll";

		// Token: 0x04002E9F RID: 11935
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EA0 RID: 11936
		private static int HandleId;
	}
}
