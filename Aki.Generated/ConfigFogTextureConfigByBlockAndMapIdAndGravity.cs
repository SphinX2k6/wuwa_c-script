using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000344 RID: 836
	public class ConfigFogTextureConfigByBlockAndMapIdAndGravity : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x000C83B8 File Offset: 0x000C65B8
		static ConfigFogTextureConfigByBlockAndMapIdAndGravity()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogTextureConfigByBlockAndMapIdAndGravity.CreateStaticDefaultValue), new Action(ConfigFogTextureConfigByBlockAndMapIdAndGravity.ResetStaticDefaultValue));
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x000C83D8 File Offset: 0x000C65D8
		public static void CreateStaticDefaultValue()
		{
			ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "FogTextureConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FogTextureConfig` where Block=? And MapId=? And GravityFlip=?")
			});
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x000C8457 File Offset: 0x000C6657
		public static void ResetStaticDefaultValue()
		{
			ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair = null;
			ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId = 0;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x000C8465 File Offset: 0x000C6665
		public static void Init()
		{
			ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId = ConfigCommon.InitDataStatement(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, "db_mapfog.db", "select BinData from `FogTextureConfig` where Block=? And MapId=? And GravityFlip=?");
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x000C8480 File Offset: 0x000C6680
		public static FogTextureConfig? GetConfig(string p0Block, int p1MapId, int p2GravityFlip, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("FogTextureConfigByBlockAndMapIdAndGravity");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Block);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2GravityFlip);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FogTextureConfig?(FogTextureConfig.GetRootAsFogTextureConfig(configBuffer));
				}
			}
			ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair.Clear();
			ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair.Add(new ValueTuple<string, object>("Block", p0Block));
			ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair.Add(new ValueTuple<string, object>("MapId", p1MapId));
			ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair.Add(new ValueTuple<string, object>("GravityFlip", p2GravityFlip));
			if (!ConfigCommon.BindString(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, 1, p0Block, ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair) || !ConfigCommon.BindInt(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, 2, p1MapId, ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair) || !ConfigCommon.BindInt(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, 3, p2GravityFlip, ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair) || ConfigCommon.Step(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, true, ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, 0, ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FogTextureConfig rootAsFogTextureConfig = FogTextureConfig.GetRootAsFogTextureConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("FogTextureConfigByBlockAndMapIdAndGravity");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Block);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p2GravityFlip);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFogTextureConfigByBlockAndMapIdAndGravity.HandleId, ConfigFogTextureConfigByBlockAndMapIdAndGravity.LogPair);
			return new FogTextureConfig?(rootAsFogTextureConfig);
		}

		// Token: 0x040016C0 RID: 5824
		private const string DB = "db_mapfog.db";

		// Token: 0x040016C1 RID: 5825
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x040016C2 RID: 5826
		private const string TABLE = "FogTextureConfig";

		// Token: 0x040016C3 RID: 5827
		private const string COMMAND = "select BinData from `FogTextureConfig` where Block=? And MapId=? And GravityFlip=?";

		// Token: 0x040016C4 RID: 5828
		private const string KEY_PREFIX = "FogTextureConfigByBlockAndMapIdAndGravity";

		// Token: 0x040016C5 RID: 5829
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016C6 RID: 5830
		private static int HandleId;
	}
}
