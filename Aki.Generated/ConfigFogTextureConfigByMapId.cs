using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000345 RID: 837
	public class ConfigFogTextureConfigByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x000C86A5 File Offset: 0x000C68A5
		static ConfigFogTextureConfigByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogTextureConfigByMapId.CreateStaticDefaultValue), new Action(ConfigFogTextureConfigByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x000C86C4 File Offset: 0x000C68C4
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

		// Token: 0x060013A5 RID: 5029 RVA: 0x000C8743 File Offset: 0x000C6943
		public static void ResetStaticDefaultValue()
		{
			ConfigFogTextureConfigByMapId.LogPair = null;
			ConfigFogTextureConfigByMapId.HandleId = 0;
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x000C8751 File Offset: 0x000C6951
		public static void Init()
		{
			ConfigFogTextureConfigByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigFogTextureConfigByMapId.HandleId, "db_mapfog.db", "select BinData from `FogTextureConfig` where MapId=?");
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x000C876C File Offset: 0x000C696C
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

		// Token: 0x040016C7 RID: 5831
		private const string DB = "db_mapfog.db";

		// Token: 0x040016C8 RID: 5832
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x040016C9 RID: 5833
		private const string TABLE = "FogTextureConfig";

		// Token: 0x040016CA RID: 5834
		private const string COMMAND = "select BinData from `FogTextureConfig` where MapId=?";

		// Token: 0x040016CB RID: 5835
		private const string KEY_PREFIX = "FogTextureConfigByMapId";

		// Token: 0x040016CC RID: 5836
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016CD RID: 5837
		private static int HandleId;
	}
}
