using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051C RID: 1308
	public class ConfigMapMarkHasEntityConfigId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EB3 RID: 7859 RVA: 0x00106C75 File Offset: 0x00104E75
		static ConfigMapMarkHasEntityConfigId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkHasEntityConfigId.CreateStaticDefaultValue), new Action(ConfigMapMarkHasEntityConfigId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00106C94 File Offset: 0x00104E94
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkHasEntityConfigId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkHasEntityConfigId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMark` where EntityConfigId > 0")
			});
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00106D13 File Offset: 0x00104F13
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkHasEntityConfigId.LogPair = null;
			ConfigMapMarkHasEntityConfigId.HandleId = 0;
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00106D21 File Offset: 0x00104F21
		public static void Init()
		{
			ConfigMapMarkHasEntityConfigId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkHasEntityConfigId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where EntityConfigId > 0");
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00106D3C File Offset: 0x00104F3C
		[NullableContext(2)]
		public static IReadOnlyList<MapMark> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkHasEntityConfigId.HandleId, ConfigMapMarkHasEntityConfigId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MapMark> readOnlyList = (IReadOnlyList<MapMark>)ConfigCommon.GetConfig("MapMarkHasEntityConfigId");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MapMark> list = new List<MapMark>();
			while (ConfigCommon.Step(ConfigMapMarkHasEntityConfigId.HandleId, false, ConfigMapMarkHasEntityConfigId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkHasEntityConfigId.HandleId, 0, ConfigMapMarkHasEntityConfigId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapMarkHasEntityConfigId.HandleId, ConfigMapMarkHasEntityConfigId.LogPair);
					return null;
				}
				MapMark rootAsMapMark = MapMark.GetRootAsMapMark(new ByteBuffer(item2));
				list.Add(rootAsMapMark);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MapMarkHasEntityConfigId", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapMarkHasEntityConfigId.HandleId, ConfigMapMarkHasEntityConfigId.LogPair);
			return list;
		}

		// Token: 0x040023A8 RID: 9128
		private const string DB = "db_map_mark.db";

		// Token: 0x040023A9 RID: 9129
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x040023AA RID: 9130
		private const string TABLE = "MapMark";

		// Token: 0x040023AB RID: 9131
		private const string COMMAND = "select BinData from `MapMark` where EntityConfigId > 0";

		// Token: 0x040023AC RID: 9132
		private const string KEY_PREFIX = "MapMarkHasEntityConfigId";

		// Token: 0x040023AD RID: 9133
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023AE RID: 9134
		private static int HandleId;
	}
}
