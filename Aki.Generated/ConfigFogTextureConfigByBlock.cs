using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000357 RID: 855
	public class ConfigFogTextureConfigByBlock : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600140F RID: 5135 RVA: 0x000CE433 File Offset: 0x000CC633
		static ConfigFogTextureConfigByBlock()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogTextureConfigByBlock.CreateStaticDefaultValue), new Action(ConfigFogTextureConfigByBlock.ResetStaticDefaultValue));
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x000CE454 File Offset: 0x000CC654
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

		// Token: 0x06001411 RID: 5137 RVA: 0x000CE4D3 File Offset: 0x000CC6D3
		public static void ResetStaticDefaultValue()
		{
			ConfigFogTextureConfigByBlock.LogPair = null;
			ConfigFogTextureConfigByBlock.HandleId = 0;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x000CE4E1 File Offset: 0x000CC6E1
		public static void Init()
		{
			ConfigFogTextureConfigByBlock.HandleId = ConfigCommon.InitDataStatement(ConfigFogTextureConfigByBlock.HandleId, "db_mapfog.db", "select BinData from `FogTextureConfig` where Block=?");
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x000CE4FC File Offset: 0x000CC6FC
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

		// Token: 0x04001745 RID: 5957
		private const string DB = "db_mapfog.db";

		// Token: 0x04001746 RID: 5958
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x04001747 RID: 5959
		private const string TABLE = "FogTextureConfig";

		// Token: 0x04001748 RID: 5960
		private const string COMMAND = "select BinData from `FogTextureConfig` where Block=?";

		// Token: 0x04001749 RID: 5961
		private const string KEY_PREFIX = "FogTextureConfigByBlock";

		// Token: 0x0400174A RID: 5962
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400174B RID: 5963
		private static int HandleId;
	}
}
