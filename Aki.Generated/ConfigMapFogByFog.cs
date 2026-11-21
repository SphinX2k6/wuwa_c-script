using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000528 RID: 1320
	public class ConfigMapFogByFog : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EFB RID: 7931 RVA: 0x0010BD33 File Offset: 0x00109F33
		static ConfigMapFogByFog()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapFogByFog.CreateStaticDefaultValue), new Action(ConfigMapFogByFog.ResetStaticDefaultValue));
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0010BD54 File Offset: 0x00109F54
		public static void CreateStaticDefaultValue()
		{
			ConfigMapFogByFog.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapFogByFog.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "MapFog"),
				new ValueTuple<string, object>("语句", "select BinData from `MapFog` where Fog=?")
			});
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0010BDD3 File Offset: 0x00109FD3
		public static void ResetStaticDefaultValue()
		{
			ConfigMapFogByFog.LogPair = null;
			ConfigMapFogByFog.HandleId = 0;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0010BDE1 File Offset: 0x00109FE1
		public static void Init()
		{
			ConfigMapFogByFog.HandleId = ConfigCommon.InitDataStatement(ConfigMapFogByFog.HandleId, "db_mapfog.db", "select BinData from `MapFog` where Fog=?");
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x0010BDFC File Offset: 0x00109FFC
		public static MapFog? GetConfig(int p0Fog, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapFogByFog.HandleId, ConfigMapFogByFog.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapFogByFog");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Fog);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapFog?(MapFog.GetRootAsMapFog(configBuffer));
				}
			}
			ConfigMapFogByFog.LogPair.Clear();
			ConfigMapFogByFog.LogPair.Add(new ValueTuple<string, object>("Fog", p0Fog));
			if (!ConfigCommon.BindInt(ConfigMapFogByFog.HandleId, 1, p0Fog, ConfigMapFogByFog.LogPair) || ConfigCommon.Step(ConfigMapFogByFog.HandleId, true, ConfigMapFogByFog.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapFogByFog.HandleId, ConfigMapFogByFog.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapFogByFog.HandleId, 0, ConfigMapFogByFog.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapFogByFog.HandleId, ConfigMapFogByFog.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapFog rootAsMapFog = MapFog.GetRootAsMapFog(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapFogByFog");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Fog);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapFogByFog.HandleId, ConfigMapFogByFog.LogPair);
			return new MapFog?(rootAsMapFog);
		}

		// Token: 0x040023FC RID: 9212
		private const string DB = "db_mapfog.db";

		// Token: 0x040023FD RID: 9213
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x040023FE RID: 9214
		private const string TABLE = "MapFog";

		// Token: 0x040023FF RID: 9215
		private const string COMMAND = "select BinData from `MapFog` where Fog=?";

		// Token: 0x04002400 RID: 9216
		private const string KEY_PREFIX = "MapFogByFog";

		// Token: 0x04002401 RID: 9217
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002402 RID: 9218
		private static int HandleId;
	}
}
