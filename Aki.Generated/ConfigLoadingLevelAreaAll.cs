using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FA RID: 1274
	public class ConfigLoadingLevelAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DE7 RID: 7655 RVA: 0x00105CF0 File Offset: 0x00103EF0
		static ConfigLoadingLevelAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingLevelAreaAll.CreateStaticDefaultValue), new Action(ConfigLoadingLevelAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00105D10 File Offset: 0x00103F10
		public static void CreateStaticDefaultValue()
		{
			ConfigLoadingLevelAreaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLoadingLevelAreaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_loadingtips.db"),
				new ValueTuple<string, object>("文件", "z.载入提示.xlsx"),
				new ValueTuple<string, object>("表名", "LoadingLevelArea"),
				new ValueTuple<string, object>("语句", "select BinData from `LoadingLevelArea`")
			});
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00105D8F File Offset: 0x00103F8F
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingLevelAreaAll.LogPair = null;
			ConfigLoadingLevelAreaAll.HandleId = 0;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00105D9D File Offset: 0x00103F9D
		public static void Init()
		{
			ConfigLoadingLevelAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingLevelAreaAll.HandleId, "db_loadingtips.db", "select BinData from `LoadingLevelArea`");
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x00105DB8 File Offset: 0x00103FB8
		[NullableContext(2)]
		public static IReadOnlyList<LoadingLevelArea> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLoadingLevelAreaAll.HandleId, ConfigLoadingLevelAreaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LoadingLevelArea> readOnlyList = (IReadOnlyList<LoadingLevelArea>)ConfigCommon.GetConfig("LoadingLevelAreaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LoadingLevelArea> list = new List<LoadingLevelArea>();
			while (ConfigCommon.Step(ConfigLoadingLevelAreaAll.HandleId, false, ConfigLoadingLevelAreaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLoadingLevelAreaAll.HandleId, 0, ConfigLoadingLevelAreaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLoadingLevelAreaAll.HandleId, ConfigLoadingLevelAreaAll.LogPair);
					return null;
				}
				LoadingLevelArea rootAsLoadingLevelArea = LoadingLevelArea.GetRootAsLoadingLevelArea(new ByteBuffer(item2));
				list.Add(rootAsLoadingLevelArea);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LoadingLevelAreaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLoadingLevelAreaAll.HandleId, ConfigLoadingLevelAreaAll.LogPair);
			return list;
		}

		// Token: 0x040022BA RID: 8890
		private const string DB = "db_loadingtips.db";

		// Token: 0x040022BB RID: 8891
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x040022BC RID: 8892
		private const string TABLE = "LoadingLevelArea";

		// Token: 0x040022BD RID: 8893
		private const string COMMAND = "select BinData from `LoadingLevelArea`";

		// Token: 0x040022BE RID: 8894
		private const string KEY_PREFIX = "LoadingLevelAreaAll";

		// Token: 0x040022BF RID: 8895
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022C0 RID: 8896
		private static int HandleId;
	}
}
