using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000356 RID: 854
	public class ConfigFogTextureConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001409 RID: 5129 RVA: 0x000CE2A0 File Offset: 0x000CC4A0
		static ConfigFogTextureConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogTextureConfigAll.CreateStaticDefaultValue), new Action(ConfigFogTextureConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x000CE2C0 File Offset: 0x000CC4C0
		public static void CreateStaticDefaultValue()
		{
			ConfigFogTextureConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFogTextureConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "FogTextureConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FogTextureConfig`")
			});
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x000CE33F File Offset: 0x000CC53F
		public static void ResetStaticDefaultValue()
		{
			ConfigFogTextureConfigAll.LogPair = null;
			ConfigFogTextureConfigAll.HandleId = 0;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x000CE34D File Offset: 0x000CC54D
		public static void Init()
		{
			ConfigFogTextureConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigFogTextureConfigAll.HandleId, "db_mapfog.db", "select BinData from `FogTextureConfig`");
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x000CE368 File Offset: 0x000CC568
		[NullableContext(2)]
		public static IReadOnlyList<FogTextureConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFogTextureConfigAll.HandleId, ConfigFogTextureConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FogTextureConfig> readOnlyList = (IReadOnlyList<FogTextureConfig>)ConfigCommon.GetConfig("FogTextureConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FogTextureConfig> list = new List<FogTextureConfig>();
			while (ConfigCommon.Step(ConfigFogTextureConfigAll.HandleId, false, ConfigFogTextureConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFogTextureConfigAll.HandleId, 0, ConfigFogTextureConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFogTextureConfigAll.HandleId, ConfigFogTextureConfigAll.LogPair);
					return null;
				}
				FogTextureConfig rootAsFogTextureConfig = FogTextureConfig.GetRootAsFogTextureConfig(new ByteBuffer(item2));
				list.Add(rootAsFogTextureConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FogTextureConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFogTextureConfigAll.HandleId, ConfigFogTextureConfigAll.LogPair);
			return list;
		}

		// Token: 0x0400173E RID: 5950
		private const string DB = "db_mapfog.db";

		// Token: 0x0400173F RID: 5951
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x04001740 RID: 5952
		private const string TABLE = "FogTextureConfig";

		// Token: 0x04001741 RID: 5953
		private const string COMMAND = "select BinData from `FogTextureConfig`";

		// Token: 0x04001742 RID: 5954
		private const string KEY_PREFIX = "FogTextureConfigAll";

		// Token: 0x04001743 RID: 5955
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001744 RID: 5956
		private static int HandleId;
	}
}
