using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000538 RID: 1336
	public class ConfigMapPeriodicActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F5B RID: 8027 RVA: 0x0010E010 File Offset: 0x0010C210
		static ConfigMapPeriodicActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapPeriodicActivityAll.CreateStaticDefaultValue), new Action(ConfigMapPeriodicActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0010E030 File Offset: 0x0010C230
		public static void CreateStaticDefaultValue()
		{
			ConfigMapPeriodicActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapPeriodicActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MapPeriodicActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `MapPeriodicActivity`")
			});
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0010E0AF File Offset: 0x0010C2AF
		public static void ResetStaticDefaultValue()
		{
			ConfigMapPeriodicActivityAll.LogPair = null;
			ConfigMapPeriodicActivityAll.HandleId = 0;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x0010E0BD File Offset: 0x0010C2BD
		public static void Init()
		{
			ConfigMapPeriodicActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapPeriodicActivityAll.HandleId, "db_map.db", "select BinData from `MapPeriodicActivity`");
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0010E0D8 File Offset: 0x0010C2D8
		[NullableContext(2)]
		public static IReadOnlyList<MapPeriodicActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapPeriodicActivityAll.HandleId, ConfigMapPeriodicActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MapPeriodicActivity> readOnlyList = (IReadOnlyList<MapPeriodicActivity>)ConfigCommon.GetConfig("MapPeriodicActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MapPeriodicActivity> list = new List<MapPeriodicActivity>();
			while (ConfigCommon.Step(ConfigMapPeriodicActivityAll.HandleId, false, ConfigMapPeriodicActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapPeriodicActivityAll.HandleId, 0, ConfigMapPeriodicActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapPeriodicActivityAll.HandleId, ConfigMapPeriodicActivityAll.LogPair);
					return null;
				}
				MapPeriodicActivity rootAsMapPeriodicActivity = MapPeriodicActivity.GetRootAsMapPeriodicActivity(new ByteBuffer(item2));
				list.Add(rootAsMapPeriodicActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MapPeriodicActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapPeriodicActivityAll.HandleId, ConfigMapPeriodicActivityAll.LogPair);
			return list;
		}

		// Token: 0x0400246C RID: 9324
		private const string DB = "db_map.db";

		// Token: 0x0400246D RID: 9325
		private const string FILE = "d.地图.xlsx";

		// Token: 0x0400246E RID: 9326
		private const string TABLE = "MapPeriodicActivity";

		// Token: 0x0400246F RID: 9327
		private const string COMMAND = "select BinData from `MapPeriodicActivity`";

		// Token: 0x04002470 RID: 9328
		private const string KEY_PREFIX = "MapPeriodicActivityAll";

		// Token: 0x04002471 RID: 9329
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002472 RID: 9330
		private static int HandleId;
	}
}
