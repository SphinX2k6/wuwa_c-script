using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000342 RID: 834
	public class ConfigFogTextureConfigByBlock : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x000C7F27 File Offset: 0x000C6127
		static ConfigFogTextureConfigByBlock()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogTextureConfigByBlock.CreateStaticDefaultValue), new Action(ConfigFogTextureConfigByBlock.ResetStaticDefaultValue));
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x000C7F48 File Offset: 0x000C6148
		public static void CreateStaticDefaultValue()
		{
			ConfigFogTextureConfigByBlock.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFogTextureConfigByBlock.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "FogTextureConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FogTextureConfig` where Block=?")
			});
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x000C7FC7 File Offset: 0x000C61C7
		public static void ResetStaticDefaultValue()
		{
			ConfigFogTextureConfigByBlock.LogPair = null;
			ConfigFogTextureConfigByBlock.HandleId = 0;
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x000C7FD5 File Offset: 0x000C61D5
		public static void Init()
		{
			ConfigFogTextureConfigByBlock.HandleId = ConfigCommon.InitDataStatement(ConfigFogTextureConfigByBlock.HandleId, "db_mapfog.db", "select BinData from `FogTextureConfig` where Block=?");
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x000C7FF0 File Offset: 0x000C61F0
		public static FogTextureConfig? GetConfig(string p0Block, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFogTextureConfigByBlock.HandleId, ConfigFogTextureConfigByBlock.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("FogTextureConfigByBlock#" + p0Block);
				if (configBuffer != null)
				{
					return new FogTextureConfig?(FogTextureConfig.GetRootAsFogTextureConfig(configBuffer));
				}
			}
			ConfigFogTextureConfigByBlock.LogPair.Clear();
			ConfigFogTextureConfigByBlock.LogPair.Add(new ValueTuple<string, object>("Block", p0Block));
			if (!ConfigCommon.BindString(ConfigFogTextureConfigByBlock.HandleId, 1, p0Block, ConfigFogTextureConfigByBlock.LogPair) || ConfigCommon.Step(ConfigFogTextureConfigByBlock.HandleId, true, ConfigFogTextureConfigByBlock.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFogTextureConfigByBlock.HandleId, ConfigFogTextureConfigByBlock.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFogTextureConfigByBlock.HandleId, 0, ConfigFogTextureConfigByBlock.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFogTextureConfigByBlock.HandleId, ConfigFogTextureConfigByBlock.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FogTextureConfig rootAsFogTextureConfig = FogTextureConfig.GetRootAsFogTextureConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("FogTextureConfigByBlock#" + p0Block, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFogTextureConfigByBlock.HandleId, ConfigFogTextureConfigByBlock.LogPair);
			return new FogTextureConfig?(rootAsFogTextureConfig);
		}

		// Token: 0x040016B2 RID: 5810
		private const string DB = "db_mapfog.db";

		// Token: 0x040016B3 RID: 5811
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x040016B4 RID: 5812
		private const string TABLE = "FogTextureConfig";

		// Token: 0x040016B5 RID: 5813
		private const string COMMAND = "select BinData from `FogTextureConfig` where Block=?";

		// Token: 0x040016B6 RID: 5814
		private const string KEY_PREFIX = "FogTextureConfigByBlock";

		// Token: 0x040016B7 RID: 5815
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016B8 RID: 5816
		private static int HandleId;
	}
}
