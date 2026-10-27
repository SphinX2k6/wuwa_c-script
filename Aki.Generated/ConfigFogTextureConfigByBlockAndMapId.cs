using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000343 RID: 835
	public class ConfigFogTextureConfigByBlockAndMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x000C8121 File Offset: 0x000C6321
		static ConfigFogTextureConfigByBlockAndMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogTextureConfigByBlockAndMapId.CreateStaticDefaultValue), new Action(ConfigFogTextureConfigByBlockAndMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x000C8140 File Offset: 0x000C6340
		public static void CreateStaticDefaultValue()
		{
			ConfigFogTextureConfigByBlockAndMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFogTextureConfigByBlockAndMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "FogTextureConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FogTextureConfig` where Block=? And MapId=?")
			});
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x000C81BF File Offset: 0x000C63BF
		public static void ResetStaticDefaultValue()
		{
			ConfigFogTextureConfigByBlockAndMapId.LogPair = null;
			ConfigFogTextureConfigByBlockAndMapId.HandleId = 0;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x000C81CD File Offset: 0x000C63CD
		public static void Init()
		{
			ConfigFogTextureConfigByBlockAndMapId.HandleId = ConfigCommon.InitDataStatement(ConfigFogTextureConfigByBlockAndMapId.HandleId, "db_mapfog.db", "select BinData from `FogTextureConfig` where Block=? And MapId=?");
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x000C81E8 File Offset: 0x000C63E8
		public static FogTextureConfig? GetConfig(string p0Block, int p1MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFogTextureConfigByBlockAndMapId.HandleId, ConfigFogTextureConfigByBlockAndMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FogTextureConfigByBlockAndMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Block);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FogTextureConfig?(FogTextureConfig.GetRootAsFogTextureConfig(configBuffer));
				}
			}
			ConfigFogTextureConfigByBlockAndMapId.LogPair.Clear();
			ConfigFogTextureConfigByBlockAndMapId.LogPair.Add(new ValueTuple<string, object>("Block", p0Block));
			ConfigFogTextureConfigByBlockAndMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p1MapId));
			if (!ConfigCommon.BindString(ConfigFogTextureConfigByBlockAndMapId.HandleId, 1, p0Block, ConfigFogTextureConfigByBlockAndMapId.LogPair) || !ConfigCommon.BindInt(ConfigFogTextureConfigByBlockAndMapId.HandleId, 2, p1MapId, ConfigFogTextureConfigByBlockAndMapId.LogPair) || ConfigCommon.Step(ConfigFogTextureConfigByBlockAndMapId.HandleId, true, ConfigFogTextureConfigByBlockAndMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFogTextureConfigByBlockAndMapId.HandleId, ConfigFogTextureConfigByBlockAndMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFogTextureConfigByBlockAndMapId.HandleId, 0, ConfigFogTextureConfigByBlockAndMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFogTextureConfigByBlockAndMapId.HandleId, ConfigFogTextureConfigByBlockAndMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FogTextureConfig rootAsFogTextureConfig = FogTextureConfig.GetRootAsFogTextureConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FogTextureConfigByBlockAndMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Block);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFogTextureConfigByBlockAndMapId.HandleId, ConfigFogTextureConfigByBlockAndMapId.LogPair);
			return new FogTextureConfig?(rootAsFogTextureConfig);
		}

		// Token: 0x040016B9 RID: 5817
		private const string DB = "db_mapfog.db";

		// Token: 0x040016BA RID: 5818
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x040016BB RID: 5819
		private const string TABLE = "FogTextureConfig";

		// Token: 0x040016BC RID: 5820
		private const string COMMAND = "select BinData from `FogTextureConfig` where Block=? And MapId=?";

		// Token: 0x040016BD RID: 5821
		private const string KEY_PREFIX = "FogTextureConfigByBlockAndMapId";

		// Token: 0x040016BE RID: 5822
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016BF RID: 5823
		private static int HandleId;
	}
}
