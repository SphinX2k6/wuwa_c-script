using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000527 RID: 1319
	public class ConfigMapRangeByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EF5 RID: 7925 RVA: 0x00108397 File Offset: 0x00106597
		static ConfigMapRangeByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapRangeByMapId.CreateStaticDefaultValue), new Action(ConfigMapRangeByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x001083B8 File Offset: 0x001065B8
		public static void CreateStaticDefaultValue()
		{
			ConfigMapRangeByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapRangeByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图参数.xlsx"),
				new ValueTuple<string, object>("表名", "MapRange"),
				new ValueTuple<string, object>("语句", "select BinData from `MapRange` where MapId=?")
			});
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00108437 File Offset: 0x00106637
		public static void ResetStaticDefaultValue()
		{
			ConfigMapRangeByMapId.LogPair = null;
			ConfigMapRangeByMapId.HandleId = 0;
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00108445 File Offset: 0x00106645
		public static void Init()
		{
			ConfigMapRangeByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapRangeByMapId.HandleId, "db_map.db", "select BinData from `MapRange` where MapId=?");
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00108460 File Offset: 0x00106660
		[NullableContext(2)]
		public static IReadOnlyList<MapRange> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapRangeByMapId.HandleId, ConfigMapRangeByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapRangeByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<MapRange> readOnlyList = (IReadOnlyList<MapRange>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMapRangeByMapId.LogPair.Clear();
			ConfigMapRangeByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigMapRangeByMapId.HandleId, 1, p0MapId, ConfigMapRangeByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigMapRangeByMapId.HandleId, ConfigMapRangeByMapId.LogPair);
				return null;
			}
			List<MapRange> list = new List<MapRange>();
			while (ConfigCommon.Step(ConfigMapRangeByMapId.HandleId, false, ConfigMapRangeByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapRangeByMapId.HandleId, 0, ConfigMapRangeByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapRangeByMapId.HandleId, ConfigMapRangeByMapId.LogPair);
					return null;
				}
				MapRange rootAsMapRange = MapRange.GetRootAsMapRange(new ByteBuffer(item2));
				list.Add(rootAsMapRange);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapRangeByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapRangeByMapId.HandleId, ConfigMapRangeByMapId.LogPair);
			return list;
		}

		// Token: 0x040023F5 RID: 9205
		private const string DB = "db_map.db";

		// Token: 0x040023F6 RID: 9206
		private const string FILE = "d.地图参数.xlsx";

		// Token: 0x040023F7 RID: 9207
		private const string TABLE = "MapRange";

		// Token: 0x040023F8 RID: 9208
		private const string COMMAND = "select BinData from `MapRange` where MapId=?";

		// Token: 0x040023F9 RID: 9209
		private const string KEY_PREFIX = "MapRangeByMapId";

		// Token: 0x040023FA RID: 9210
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023FB RID: 9211
		private static int HandleId;
	}
}
