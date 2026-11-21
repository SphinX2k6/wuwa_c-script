using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053D RID: 1341
	public class ConfigMapRangeByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F79 RID: 8057 RVA: 0x0010EAEB File Offset: 0x0010CCEB
		static ConfigMapRangeByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapRangeByMapId.CreateStaticDefaultValue), new Action(ConfigMapRangeByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x0010EB0C File Offset: 0x0010CD0C
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

		// Token: 0x06001F7B RID: 8059 RVA: 0x0010EB8B File Offset: 0x0010CD8B
		public static void ResetStaticDefaultValue()
		{
			ConfigMapRangeByMapId.LogPair = null;
			ConfigMapRangeByMapId.HandleId = 0;
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0010EB99 File Offset: 0x0010CD99
		public static void Init()
		{
			ConfigMapRangeByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapRangeByMapId.HandleId, "db_map.db", "select BinData from `MapRange` where MapId=?");
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x0010EBB4 File Offset: 0x0010CDB4
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

		// Token: 0x0400248F RID: 9359
		private const string DB = "db_map.db";

		// Token: 0x04002490 RID: 9360
		private const string FILE = "d.地图参数.xlsx";

		// Token: 0x04002491 RID: 9361
		private const string TABLE = "MapRange";

		// Token: 0x04002492 RID: 9362
		private const string COMMAND = "select BinData from `MapRange` where MapId=?";

		// Token: 0x04002493 RID: 9363
		private const string KEY_PREFIX = "MapRangeByMapId";

		// Token: 0x04002494 RID: 9364
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002495 RID: 9365
		private static int HandleId;
	}
}
