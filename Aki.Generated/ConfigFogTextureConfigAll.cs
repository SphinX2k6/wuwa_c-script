using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000341 RID: 833
	public class ConfigFogTextureConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600138B RID: 5003 RVA: 0x000C7D94 File Offset: 0x000C5F94
		static ConfigFogTextureConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogTextureConfigAll.CreateStaticDefaultValue), new Action(ConfigFogTextureConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x000C7DB4 File Offset: 0x000C5FB4
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

		// Token: 0x0600138D RID: 5005 RVA: 0x000C7E33 File Offset: 0x000C6033
		public static void ResetStaticDefaultValue()
		{
			ConfigFogTextureConfigAll.LogPair = null;
			ConfigFogTextureConfigAll.HandleId = 0;
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x000C7E41 File Offset: 0x000C6041
		public static void Init()
		{
			ConfigFogTextureConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigFogTextureConfigAll.HandleId, "db_mapfog.db", "select BinData from `FogTextureConfig`");
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x000C7E5C File Offset: 0x000C605C
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

		// Token: 0x040016AB RID: 5803
		private const string DB = "db_mapfog.db";

		// Token: 0x040016AC RID: 5804
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x040016AD RID: 5805
		private const string TABLE = "FogTextureConfig";

		// Token: 0x040016AE RID: 5806
		private const string COMMAND = "select BinData from `FogTextureConfig`";

		// Token: 0x040016AF RID: 5807
		private const string KEY_PREFIX = "FogTextureConfigAll";

		// Token: 0x040016B0 RID: 5808
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016B1 RID: 5809
		private static int HandleId;
	}
}
