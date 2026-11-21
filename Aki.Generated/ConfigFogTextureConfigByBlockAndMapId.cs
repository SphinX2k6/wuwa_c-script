using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000358 RID: 856
	public class ConfigFogTextureConfigByBlockAndMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001415 RID: 5141 RVA: 0x000CE62D File Offset: 0x000CC82D
		static ConfigFogTextureConfigByBlockAndMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogTextureConfigByBlockAndMapId.CreateStaticDefaultValue), new Action(ConfigFogTextureConfigByBlockAndMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x000CE64C File Offset: 0x000CC84C
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

		// Token: 0x06001417 RID: 5143 RVA: 0x000CE6CB File Offset: 0x000CC8CB
		public static void ResetStaticDefaultValue()
		{
			ConfigFogTextureConfigByBlockAndMapId.LogPair = null;
			ConfigFogTextureConfigByBlockAndMapId.HandleId = 0;
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x000CE6D9 File Offset: 0x000CC8D9
		public static void Init()
		{
			ConfigFogTextureConfigByBlockAndMapId.HandleId = ConfigCommon.InitDataStatement(ConfigFogTextureConfigByBlockAndMapId.HandleId, "db_mapfog.db", "select BinData from `FogTextureConfig` where Block=? And MapId=?");
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x000CE6F4 File Offset: 0x000CC8F4
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

		// Token: 0x0400174C RID: 5964
		private const string DB = "db_mapfog.db";

		// Token: 0x0400174D RID: 5965
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x0400174E RID: 5966
		private const string TABLE = "FogTextureConfig";

		// Token: 0x0400174F RID: 5967
		private const string COMMAND = "select BinData from `FogTextureConfig` where Block=? And MapId=?";

		// Token: 0x04001750 RID: 5968
		private const string KEY_PREFIX = "FogTextureConfigByBlockAndMapId";

		// Token: 0x04001751 RID: 5969
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001752 RID: 5970
		private static int HandleId;
	}
}
