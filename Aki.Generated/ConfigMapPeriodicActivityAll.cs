using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000522 RID: 1314
	public class ConfigMapPeriodicActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ED7 RID: 7895 RVA: 0x001078BC File Offset: 0x00105ABC
		static ConfigMapPeriodicActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapPeriodicActivityAll.CreateStaticDefaultValue), new Action(ConfigMapPeriodicActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x001078DC File Offset: 0x00105ADC
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

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0010795B File Offset: 0x00105B5B
		public static void ResetStaticDefaultValue()
		{
			ConfigMapPeriodicActivityAll.LogPair = null;
			ConfigMapPeriodicActivityAll.HandleId = 0;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00107969 File Offset: 0x00105B69
		public static void Init()
		{
			ConfigMapPeriodicActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigMapPeriodicActivityAll.HandleId, "db_map.db", "select BinData from `MapPeriodicActivity`");
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00107984 File Offset: 0x00105B84
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

		// Token: 0x040023D2 RID: 9170
		private const string DB = "db_map.db";

		// Token: 0x040023D3 RID: 9171
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040023D4 RID: 9172
		private const string TABLE = "MapPeriodicActivity";

		// Token: 0x040023D5 RID: 9173
		private const string COMMAND = "select BinData from `MapPeriodicActivity`";

		// Token: 0x040023D6 RID: 9174
		private const string KEY_PREFIX = "MapPeriodicActivityAll";

		// Token: 0x040023D7 RID: 9175
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023D8 RID: 9176
		private static int HandleId;
	}
}
