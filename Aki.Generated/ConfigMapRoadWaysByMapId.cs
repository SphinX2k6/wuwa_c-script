using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053E RID: 1342
	public class ConfigMapRoadWaysByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F7F RID: 8063 RVA: 0x0010ED23 File Offset: 0x0010CF23
		static ConfigMapRoadWaysByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapRoadWaysByMapId.CreateStaticDefaultValue), new Action(ConfigMapRoadWaysByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x0010ED44 File Offset: 0x0010CF44
		public static void CreateStaticDefaultValue()
		{
			ConfigMapRoadWaysByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapRoadWaysByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MapRoadWays"),
				new ValueTuple<string, object>("语句", "select BinData from `MapRoadWays` where MapId=?")
			});
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x0010EDC3 File Offset: 0x0010CFC3
		public static void ResetStaticDefaultValue()
		{
			ConfigMapRoadWaysByMapId.LogPair = null;
			ConfigMapRoadWaysByMapId.HandleId = 0;
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x0010EDD1 File Offset: 0x0010CFD1
		public static void Init()
		{
			ConfigMapRoadWaysByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapRoadWaysByMapId.HandleId, "db_map.db", "select BinData from `MapRoadWays` where MapId=?");
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0010EDEC File Offset: 0x0010CFEC
		[NullableContext(2)]
		public static IReadOnlyList<MapRoadWays> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapRoadWaysByMapId.HandleId, ConfigMapRoadWaysByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapRoadWaysByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<MapRoadWays> readOnlyList = (IReadOnlyList<MapRoadWays>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMapRoadWaysByMapId.LogPair.Clear();
			ConfigMapRoadWaysByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigMapRoadWaysByMapId.HandleId, 1, p0MapId, ConfigMapRoadWaysByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigMapRoadWaysByMapId.HandleId, ConfigMapRoadWaysByMapId.LogPair);
				return null;
			}
			List<MapRoadWays> list = new List<MapRoadWays>();
			while (ConfigCommon.Step(ConfigMapRoadWaysByMapId.HandleId, false, ConfigMapRoadWaysByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapRoadWaysByMapId.HandleId, 0, ConfigMapRoadWaysByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapRoadWaysByMapId.HandleId, ConfigMapRoadWaysByMapId.LogPair);
					return null;
				}
				MapRoadWays rootAsMapRoadWays = MapRoadWays.GetRootAsMapRoadWays(new ByteBuffer(item2));
				list.Add(rootAsMapRoadWays);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapRoadWaysByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapRoadWaysByMapId.HandleId, ConfigMapRoadWaysByMapId.LogPair);
			return list;
		}

		// Token: 0x04002496 RID: 9366
		private const string DB = "db_map.db";

		// Token: 0x04002497 RID: 9367
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04002498 RID: 9368
		private const string TABLE = "MapRoadWays";

		// Token: 0x04002499 RID: 9369
		private const string COMMAND = "select BinData from `MapRoadWays` where MapId=?";

		// Token: 0x0400249A RID: 9370
		private const string KEY_PREFIX = "MapRoadWaysByMapId";

		// Token: 0x0400249B RID: 9371
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400249C RID: 9372
		private static int HandleId;
	}
}
