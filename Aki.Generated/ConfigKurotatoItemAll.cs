using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AD RID: 1197
	public class ConfigKurotatoItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C19 RID: 7193 RVA: 0x000FBC9C File Offset: 0x000F9E9C
		static ConfigKurotatoItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoItemAll.CreateStaticDefaultValue), new Action(ConfigKurotatoItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000FBCBC File Offset: 0x000F9EBC
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_道具.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoItem"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoItem`")
			});
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000FBD3B File Offset: 0x000F9F3B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoItemAll.LogPair = null;
			ConfigKurotatoItemAll.HandleId = 0;
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000FBD49 File Offset: 0x000F9F49
		public static void Init()
		{
			ConfigKurotatoItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoItemAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoItem`");
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000FBD64 File Offset: 0x000F9F64
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoItemAll.HandleId, ConfigKurotatoItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoItem> readOnlyList = (IReadOnlyList<KurotatoItem>)ConfigCommon.GetConfig("KurotatoItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoItem> list = new List<KurotatoItem>();
			while (ConfigCommon.Step(ConfigKurotatoItemAll.HandleId, false, ConfigKurotatoItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoItemAll.HandleId, 0, ConfigKurotatoItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoItemAll.HandleId, ConfigKurotatoItemAll.LogPair);
					return null;
				}
				KurotatoItem rootAsKurotatoItem = KurotatoItem.GetRootAsKurotatoItem(new ByteBuffer(item2));
				list.Add(rootAsKurotatoItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoItemAll.HandleId, ConfigKurotatoItemAll.LogPair);
			return list;
		}

		// Token: 0x0400209F RID: 8351
		private const string DB = "db_kurotato.db";

		// Token: 0x040020A0 RID: 8352
		private const string FILE = "t.土豆兄弟_道具.xlsx";

		// Token: 0x040020A1 RID: 8353
		private const string TABLE = "KurotatoItem";

		// Token: 0x040020A2 RID: 8354
		private const string COMMAND = "select BinData from `KurotatoItem`";

		// Token: 0x040020A3 RID: 8355
		private const string KEY_PREFIX = "KurotatoItemAll";

		// Token: 0x040020A4 RID: 8356
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020A5 RID: 8357
		private static int HandleId;
	}
}
