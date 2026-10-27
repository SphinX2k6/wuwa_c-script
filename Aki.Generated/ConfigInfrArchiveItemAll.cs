using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000422 RID: 1058
	public class ConfigInfrArchiveItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018D5 RID: 6357 RVA: 0x000E6184 File Offset: 0x000E4384
		static ConfigInfrArchiveItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveItemAll.CreateStaticDefaultValue), new Action(ConfigInfrArchiveItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x000E61A4 File Offset: 0x000E43A4
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

		// Token: 0x060018D7 RID: 6359 RVA: 0x000E6223 File Offset: 0x000E4423
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveItemAll.LogPair = null;
			ConfigInfrArchiveItemAll.HandleId = 0;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x000E6231 File Offset: 0x000E4431
		public static void Init()
		{
			ConfigInfrArchiveItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveItemAll.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveItem`");
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x000E624C File Offset: 0x000E444C
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

		// Token: 0x04001CD2 RID: 7378
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001CD3 RID: 7379
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001CD4 RID: 7380
		private const string TABLE = "InfrArchiveItem";

		// Token: 0x04001CD5 RID: 7381
		private const string COMMAND = "select BinData from `InfrArchiveItem`";

		// Token: 0x04001CD6 RID: 7382
		private const string KEY_PREFIX = "InfrArchiveItemAll";

		// Token: 0x04001CD7 RID: 7383
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CD8 RID: 7384
		private static int HandleId;
	}
}
