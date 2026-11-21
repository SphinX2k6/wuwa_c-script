using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000532 RID: 1330
	public class ConfigMapMarkHasEntityConfigId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F37 RID: 7991 RVA: 0x0010D3C9 File Offset: 0x0010B5C9
		static ConfigMapMarkHasEntityConfigId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkHasEntityConfigId.CreateStaticDefaultValue), new Action(ConfigMapMarkHasEntityConfigId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0010D3E8 File Offset: 0x0010B5E8
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

		// Token: 0x06001F39 RID: 7993 RVA: 0x0010D467 File Offset: 0x0010B667
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkHasEntityConfigId.LogPair = null;
			ConfigMapMarkHasEntityConfigId.HandleId = 0;
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x0010D475 File Offset: 0x0010B675
		public static void Init()
		{
			ConfigMapMarkHasEntityConfigId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkHasEntityConfigId.HandleId, "db_map_mark.db", "select BinData from `MapMark` where EntityConfigId > 0");
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0010D490 File Offset: 0x0010B690
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

		// Token: 0x04002442 RID: 9282
		private const string DB = "db_map_mark.db";

		// Token: 0x04002443 RID: 9283
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002444 RID: 9284
		private const string TABLE = "MapMark";

		// Token: 0x04002445 RID: 9285
		private const string COMMAND = "select BinData from `MapMark` where EntityConfigId > 0";

		// Token: 0x04002446 RID: 9286
		private const string KEY_PREFIX = "MapMarkHasEntityConfigId";

		// Token: 0x04002447 RID: 9287
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002448 RID: 9288
		private static int HandleId;
	}
}
