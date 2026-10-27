using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000511 RID: 1297
	public class ConfigMapFogByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E71 RID: 7793 RVA: 0x001053A9 File Offset: 0x001035A9
		static ConfigMapFogByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapFogByAreaId.CreateStaticDefaultValue), new Action(ConfigMapFogByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x001053C8 File Offset: 0x001035C8
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

		// Token: 0x06001E73 RID: 7795 RVA: 0x00105447 File Offset: 0x00103647
		public static void ResetStaticDefaultValue()
		{
			ConfigMapFogByAreaId.LogPair = null;
			ConfigMapFogByAreaId.HandleId = 0;
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00105455 File Offset: 0x00103655
		public static void Init()
		{
			ConfigMapFogByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigMapFogByAreaId.HandleId, "db_mapfog.db", "select BinData from `MapFog` where AreaId=?");
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00105470 File Offset: 0x00103670
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

		// Token: 0x0400235B RID: 9051
		private const string DB = "db_mapfog.db";

		// Token: 0x0400235C RID: 9052
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x0400235D RID: 9053
		private const string TABLE = "MapFog";

		// Token: 0x0400235E RID: 9054
		private const string COMMAND = "select BinData from `MapFog` where AreaId=?";

		// Token: 0x0400235F RID: 9055
		private const string KEY_PREFIX = "MapFogByAreaId";

		// Token: 0x04002360 RID: 9056
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002361 RID: 9057
		private static int HandleId;
	}
}
