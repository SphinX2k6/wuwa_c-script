using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000438 RID: 1080
	public class ConfigInfrArchiveItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001959 RID: 6489 RVA: 0x000EC8D8 File Offset: 0x000EAAD8
		static ConfigInfrArchiveItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveItemAll.CreateStaticDefaultValue), new Action(ConfigInfrArchiveItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x000EC8F8 File Offset: 0x000EAAF8
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrArchiveItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrArchiveItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建_档案馆.xlsx"),
				new ValueTuple<string, object>("表名", "InfrArchiveItem"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrArchiveItem`")
			});
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000EC977 File Offset: 0x000EAB77
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveItemAll.LogPair = null;
			ConfigInfrArchiveItemAll.HandleId = 0;
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x000EC985 File Offset: 0x000EAB85
		public static void Init()
		{
			ConfigInfrArchiveItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveItemAll.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveItem`");
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x000EC9A0 File Offset: 0x000EABA0
		[NullableContext(2)]
		public static IReadOnlyList<InfrArchiveItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrArchiveItemAll.HandleId, ConfigInfrArchiveItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrArchiveItem> readOnlyList = (IReadOnlyList<InfrArchiveItem>)ConfigCommon.GetConfig("InfrArchiveItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrArchiveItem> list = new List<InfrArchiveItem>();
			while (ConfigCommon.Step(ConfigInfrArchiveItemAll.HandleId, false, ConfigInfrArchiveItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrArchiveItemAll.HandleId, 0, ConfigInfrArchiveItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrArchiveItemAll.HandleId, ConfigInfrArchiveItemAll.LogPair);
					return null;
				}
				InfrArchiveItem rootAsInfrArchiveItem = InfrArchiveItem.GetRootAsInfrArchiveItem(new ByteBuffer(item2));
				list.Add(rootAsInfrArchiveItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrArchiveItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrArchiveItemAll.HandleId, ConfigInfrArchiveItemAll.LogPair);
			return list;
		}

		// Token: 0x04001D6C RID: 7532
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D6D RID: 7533
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001D6E RID: 7534
		private const string TABLE = "InfrArchiveItem";

		// Token: 0x04001D6F RID: 7535
		private const string COMMAND = "select BinData from `InfrArchiveItem`";

		// Token: 0x04001D70 RID: 7536
		private const string KEY_PREFIX = "InfrArchiveItemAll";

		// Token: 0x04001D71 RID: 7537
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D72 RID: 7538
		private static int HandleId;
	}
}
