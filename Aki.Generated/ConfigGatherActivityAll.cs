using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000397 RID: 919
	public class ConfigGatherActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001590 RID: 5520 RVA: 0x000D71F4 File Offset: 0x000D53F4
		static ConfigGatherActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGatherActivityAll.CreateStaticDefaultValue), new Action(ConfigGatherActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x000D7214 File Offset: 0x000D5414
		public static void CreateStaticDefaultValue()
		{
			ConfigGatherActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGatherActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_collectionactivity.db"),
				new ValueTuple<string, object>("文件", "s.收集活动.xlsx"),
				new ValueTuple<string, object>("表名", "GatherActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `GatherActivity`")
			});
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x000D7293 File Offset: 0x000D5493
		public static void ResetStaticDefaultValue()
		{
			ConfigGatherActivityAll.LogPair = null;
			ConfigGatherActivityAll.HandleId = 0;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x000D72A1 File Offset: 0x000D54A1
		public static void Init()
		{
			ConfigGatherActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigGatherActivityAll.HandleId, "db_collectionactivity.db", "select BinData from `GatherActivity`");
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x000D72BC File Offset: 0x000D54BC
		[NullableContext(2)]
		public static IReadOnlyList<GatherActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGatherActivityAll.HandleId, ConfigGatherActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GatherActivity> readOnlyList = (IReadOnlyList<GatherActivity>)ConfigCommon.GetConfig("GatherActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GatherActivity> list = new List<GatherActivity>();
			while (ConfigCommon.Step(ConfigGatherActivityAll.HandleId, false, ConfigGatherActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGatherActivityAll.HandleId, 0, ConfigGatherActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGatherActivityAll.HandleId, ConfigGatherActivityAll.LogPair);
					return null;
				}
				GatherActivity rootAsGatherActivity = GatherActivity.GetRootAsGatherActivity(new ByteBuffer(item2));
				list.Add(rootAsGatherActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GatherActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGatherActivityAll.HandleId, ConfigGatherActivityAll.LogPair);
			return list;
		}

		// Token: 0x04001905 RID: 6405
		private const string DB = "db_collectionactivity.db";

		// Token: 0x04001906 RID: 6406
		private const string FILE = "s.收集活动.xlsx";

		// Token: 0x04001907 RID: 6407
		private const string TABLE = "GatherActivity";

		// Token: 0x04001908 RID: 6408
		private const string COMMAND = "select BinData from `GatherActivity`";

		// Token: 0x04001909 RID: 6409
		private const string KEY_PREFIX = "GatherActivityAll";

		// Token: 0x0400190A RID: 6410
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400190B RID: 6411
		private static int HandleId;
	}
}
