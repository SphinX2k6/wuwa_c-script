using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000528 RID: 1320
	public class ConfigMapRoadWaysByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EFB RID: 7931 RVA: 0x001085CF File Offset: 0x001067CF
		static ConfigMapRoadWaysByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapRoadWaysByMapId.CreateStaticDefaultValue), new Action(ConfigMapRoadWaysByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x001085F0 File Offset: 0x001067F0
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

		// Token: 0x06001EFD RID: 7933 RVA: 0x0010866F File Offset: 0x0010686F
		public static void ResetStaticDefaultValue()
		{
			ConfigMapRoadWaysByMapId.LogPair = null;
			ConfigMapRoadWaysByMapId.HandleId = 0;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0010867D File Offset: 0x0010687D
		public static void Init()
		{
			ConfigMapRoadWaysByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigMapRoadWaysByMapId.HandleId, "db_map.db", "select BinData from `MapRoadWays` where MapId=?");
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00108698 File Offset: 0x00106898
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

		// Token: 0x040023FC RID: 9212
		private const string DB = "db_map.db";

		// Token: 0x040023FD RID: 9213
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040023FE RID: 9214
		private const string TABLE = "MapRoadWays";

		// Token: 0x040023FF RID: 9215
		private const string COMMAND = "select BinData from `MapRoadWays` where MapId=?";

		// Token: 0x04002400 RID: 9216
		private const string KEY_PREFIX = "MapRoadWaysByMapId";

		// Token: 0x04002401 RID: 9217
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002402 RID: 9218
		private static int HandleId;
	}
}
