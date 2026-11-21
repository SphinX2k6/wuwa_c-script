using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035A RID: 858
	public class ConfigFogTextureConfigByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001421 RID: 5153 RVA: 0x000CEBB1 File Offset: 0x000CCDB1
		static ConfigFogTextureConfigByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogTextureConfigByMapId.CreateStaticDefaultValue), new Action(ConfigFogTextureConfigByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x000CEBD0 File Offset: 0x000CCDD0
		public static void CreateStaticDefaultValue()
		{
			ConfigFogTextureConfigByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFogTextureConfigByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "FogTextureConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FogTextureConfig` where MapId=?")
			});
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x000CEC4F File Offset: 0x000CCE4F
		public static void ResetStaticDefaultValue()
		{
			ConfigFogTextureConfigByMapId.LogPair = null;
			ConfigFogTextureConfigByMapId.HandleId = 0;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000CEC5D File Offset: 0x000CCE5D
		public static void Init()
		{
			ConfigFogTextureConfigByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigFogTextureConfigByMapId.HandleId, "db_mapfog.db", "select BinData from `FogTextureConfig` where MapId=?");
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000CEC78 File Offset: 0x000CCE78
		[NullableContext(2)]
		public static IReadOnlyList<FogTextureConfig> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFogTextureConfigByMapId.HandleId, ConfigFogTextureConfigByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FogTextureConfigByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<FogTextureConfig> readOnlyList = (IReadOnlyList<FogTextureConfig>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFogTextureConfigByMapId.LogPair.Clear();
			ConfigFogTextureConfigByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigFogTextureConfigByMapId.HandleId, 1, p0MapId, ConfigFogTextureConfigByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigFogTextureConfigByMapId.HandleId, ConfigFogTextureConfigByMapId.LogPair);
				return null;
			}
			List<FogTextureConfig> list = new List<FogTextureConfig>();
			while (ConfigCommon.Step(ConfigFogTextureConfigByMapId.HandleId, false, ConfigFogTextureConfigByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFogTextureConfigByMapId.HandleId, 0, ConfigFogTextureConfigByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFogTextureConfigByMapId.HandleId, ConfigFogTextureConfigByMapId.LogPair);
					return null;
				}
				FogTextureConfig rootAsFogTextureConfig = FogTextureConfig.GetRootAsFogTextureConfig(new ByteBuffer(item2));
				list.Add(rootAsFogTextureConfig);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FogTextureConfigByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFogTextureConfigByMapId.HandleId, ConfigFogTextureConfigByMapId.LogPair);
			return list;
		}

		// Token: 0x0400175A RID: 5978
		private const string DB = "db_mapfog.db";

		// Token: 0x0400175B RID: 5979
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x0400175C RID: 5980
		private const string TABLE = "FogTextureConfig";

		// Token: 0x0400175D RID: 5981
		private const string COMMAND = "select BinData from `FogTextureConfig` where MapId=?";

		// Token: 0x0400175E RID: 5982
		private const string KEY_PREFIX = "FogTextureConfigByMapId";

		// Token: 0x0400175F RID: 5983
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001760 RID: 5984
		private static int HandleId;
	}
}
