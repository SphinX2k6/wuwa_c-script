using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E4 RID: 1252
	public class ConfigLoadingLevelAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D63 RID: 7523 RVA: 0x000FF59C File Offset: 0x000FD79C
		static ConfigLoadingLevelAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingLevelAreaAll.CreateStaticDefaultValue), new Action(ConfigLoadingLevelAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x000FF5BC File Offset: 0x000FD7BC
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

		// Token: 0x06001D65 RID: 7525 RVA: 0x000FF63B File Offset: 0x000FD83B
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingLevelAreaAll.LogPair = null;
			ConfigLoadingLevelAreaAll.HandleId = 0;
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000FF649 File Offset: 0x000FD849
		public static void Init()
		{
			ConfigLoadingLevelAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingLevelAreaAll.HandleId, "db_loadingtips.db", "select BinData from `LoadingLevelArea`");
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x000FF664 File Offset: 0x000FD864
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

		// Token: 0x04002220 RID: 8736
		private const string DB = "db_loadingtips.db";

		// Token: 0x04002221 RID: 8737
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x04002222 RID: 8738
		private const string TABLE = "LoadingLevelArea";

		// Token: 0x04002223 RID: 8739
		private const string COMMAND = "select BinData from `LoadingLevelArea`";

		// Token: 0x04002224 RID: 8740
		private const string KEY_PREFIX = "LoadingLevelAreaAll";

		// Token: 0x04002225 RID: 8741
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002226 RID: 8742
		private static int HandleId;
	}
}
