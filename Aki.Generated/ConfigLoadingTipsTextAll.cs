using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FC RID: 1276
	public class ConfigLoadingTipsTextAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DF3 RID: 7667 RVA: 0x001060CC File Offset: 0x001042CC
		static ConfigLoadingTipsTextAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoadingTipsTextAll.CreateStaticDefaultValue), new Action(ConfigLoadingTipsTextAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x001060EC File Offset: 0x001042EC
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

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0010616B File Offset: 0x0010436B
		public static void ResetStaticDefaultValue()
		{
			ConfigLoadingTipsTextAll.LogPair = null;
			ConfigLoadingTipsTextAll.HandleId = 0;
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00106179 File Offset: 0x00104379
		public static void Init()
		{
			ConfigLoadingTipsTextAll.HandleId = ConfigCommon.InitDataStatement(ConfigLoadingTipsTextAll.HandleId, "db_loadingtips.db", "select BinData from `LoadingTipsText`");
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00106194 File Offset: 0x00104394
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

		// Token: 0x040022C8 RID: 8904
		private const string DB = "db_loadingtips.db";

		// Token: 0x040022C9 RID: 8905
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x040022CA RID: 8906
		private const string TABLE = "LoadingTipsText";

		// Token: 0x040022CB RID: 8907
		private const string COMMAND = "select BinData from `LoadingTipsText`";

		// Token: 0x040022CC RID: 8908
		private const string KEY_PREFIX = "LoadingTipsTextAll";

		// Token: 0x040022CD RID: 8909
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022CE RID: 8910
		private static int HandleId;
	}
}
