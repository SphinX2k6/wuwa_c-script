using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000512 RID: 1298
	public class ConfigMapFogByFog : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E77 RID: 7799 RVA: 0x001055DF File Offset: 0x001037DF
		static ConfigMapFogByFog()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapFogByFog.CreateStaticDefaultValue), new Action(ConfigMapFogByFog.ResetStaticDefaultValue));
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00105600 File Offset: 0x00103800
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

		// Token: 0x06001E79 RID: 7801 RVA: 0x0010567F File Offset: 0x0010387F
		public static void ResetStaticDefaultValue()
		{
			ConfigMapFogByFog.LogPair = null;
			ConfigMapFogByFog.HandleId = 0;
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0010568D File Offset: 0x0010388D
		public static void Init()
		{
			ConfigMapFogByFog.HandleId = ConfigCommon.InitDataStatement(ConfigMapFogByFog.HandleId, "db_mapfog.db", "select BinData from `MapFog` where Fog=?");
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x001056A8 File Offset: 0x001038A8
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

		// Token: 0x04002362 RID: 9058
		private const string DB = "db_mapfog.db";

		// Token: 0x04002363 RID: 9059
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x04002364 RID: 9060
		private const string TABLE = "MapFog";

		// Token: 0x04002365 RID: 9061
		private const string COMMAND = "select BinData from `MapFog` where Fog=?";

		// Token: 0x04002366 RID: 9062
		private const string KEY_PREFIX = "MapFogByFog";

		// Token: 0x04002367 RID: 9063
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002368 RID: 9064
		private static int HandleId;
	}
}
