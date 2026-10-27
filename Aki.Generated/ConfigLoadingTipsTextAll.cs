using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E6 RID: 1254
	public class ConfigLoadingTipsTextAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D6F RID: 7535 RVA: 0x000FF978 File Offset: 0x000FDB78
		static ConfigLoadingTipsTextAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingTipsTextAll.CreateStaticDefaultValue), new Action(ConfigLoadingTipsTextAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x000FF998 File Offset: 0x000FDB98
		public static void CreateStaticDefaultValue()
		{
			ConfigLoadingTipsTextAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLoadingTipsTextAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_loadingtips.db"),
				new ValueTuple<string, object>("文件", "z.载入提示.xlsx"),
				new ValueTuple<string, object>("表名", "LoadingTipsText"),
				new ValueTuple<string, object>("语句", "select BinData from `LoadingTipsText`")
			});
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x000FFA17 File Offset: 0x000FDC17
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingTipsTextAll.LogPair = null;
			ConfigLoadingTipsTextAll.HandleId = 0;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x000FFA25 File Offset: 0x000FDC25
		public static void Init()
		{
			ConfigLoadingTipsTextAll.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingTipsTextAll.HandleId, "db_loadingtips.db", "select BinData from `LoadingTipsText`");
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x000FFA40 File Offset: 0x000FDC40
		[NullableContext(2)]
		public static IReadOnlyList<LoadingTipsText> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLoadingTipsTextAll.HandleId, ConfigLoadingTipsTextAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LoadingTipsText> readOnlyList = (IReadOnlyList<LoadingTipsText>)ConfigCommon.GetConfig("LoadingTipsTextAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LoadingTipsText> list = new List<LoadingTipsText>();
			while (ConfigCommon.Step(ConfigLoadingTipsTextAll.HandleId, false, ConfigLoadingTipsTextAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLoadingTipsTextAll.HandleId, 0, ConfigLoadingTipsTextAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLoadingTipsTextAll.HandleId, ConfigLoadingTipsTextAll.LogPair);
					return null;
				}
				LoadingTipsText rootAsLoadingTipsText = LoadingTipsText.GetRootAsLoadingTipsText(new ByteBuffer(item2));
				list.Add(rootAsLoadingTipsText);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LoadingTipsTextAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLoadingTipsTextAll.HandleId, ConfigLoadingTipsTextAll.LogPair);
			return list;
		}

		// Token: 0x0400222E RID: 8750
		private const string DB = "db_loadingtips.db";

		// Token: 0x0400222F RID: 8751
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x04002230 RID: 8752
		private const string TABLE = "LoadingTipsText";

		// Token: 0x04002231 RID: 8753
		private const string COMMAND = "select BinData from `LoadingTipsText`";

		// Token: 0x04002232 RID: 8754
		private const string KEY_PREFIX = "LoadingTipsTextAll";

		// Token: 0x04002233 RID: 8755
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002234 RID: 8756
		private static int HandleId;
	}
}
