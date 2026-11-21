using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000527 RID: 1319
	public class ConfigMapFogByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EF5 RID: 7925 RVA: 0x0010BAFD File Offset: 0x00109CFD
		static ConfigMapFogByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapFogByAreaId.CreateStaticDefaultValue), new Action(ConfigMapFogByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0010BB1C File Offset: 0x00109D1C
		public static void CreateStaticDefaultValue()
		{
			ConfigMapFogByAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapFogByAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "MapFog"),
				new ValueTuple<string, object>("语句", "select BinData from `MapFog` where AreaId=?")
			});
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0010BB9B File Offset: 0x00109D9B
		public static void ResetStaticDefaultValue()
		{
			ConfigMapFogByAreaId.LogPair = null;
			ConfigMapFogByAreaId.HandleId = 0;
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0010BBA9 File Offset: 0x00109DA9
		public static void Init()
		{
			ConfigMapFogByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigMapFogByAreaId.HandleId, "db_mapfog.db", "select BinData from `MapFog` where AreaId=?");
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0010BBC4 File Offset: 0x00109DC4
		[NullableContext(2)]
		public static IReadOnlyList<MapFog> GetConfigList(int p0AreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapFogByAreaId.HandleId, ConfigMapFogByAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapFogByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				IReadOnlyList<MapFog> readOnlyList = (IReadOnlyList<MapFog>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMapFogByAreaId.LogPair.Clear();
			ConfigMapFogByAreaId.LogPair.Add(new ValueTuple<string, object>("AreaId", p0AreaId));
			if (!ConfigCommon.BindInt(ConfigMapFogByAreaId.HandleId, 1, p0AreaId, ConfigMapFogByAreaId.LogPair))
			{
				ConfigCommon.Reset(ConfigMapFogByAreaId.HandleId, ConfigMapFogByAreaId.LogPair);
				return null;
			}
			List<MapFog> list = new List<MapFog>();
			while (ConfigCommon.Step(ConfigMapFogByAreaId.HandleId, false, ConfigMapFogByAreaId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapFogByAreaId.HandleId, 0, ConfigMapFogByAreaId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMapFogByAreaId.HandleId, ConfigMapFogByAreaId.LogPair);
					return null;
				}
				MapFog rootAsMapFog = MapFog.GetRootAsMapFog(new ByteBuffer(item2));
				list.Add(rootAsMapFog);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapFogByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0AreaId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMapFogByAreaId.HandleId, ConfigMapFogByAreaId.LogPair);
			return list;
		}

		// Token: 0x040023F5 RID: 9205
		private const string DB = "db_mapfog.db";

		// Token: 0x040023F6 RID: 9206
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x040023F7 RID: 9207
		private const string TABLE = "MapFog";

		// Token: 0x040023F8 RID: 9208
		private const string COMMAND = "select BinData from `MapFog` where AreaId=?";

		// Token: 0x040023F9 RID: 9209
		private const string KEY_PREFIX = "MapFogByAreaId";

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
