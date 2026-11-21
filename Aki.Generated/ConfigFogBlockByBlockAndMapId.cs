using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000355 RID: 853
	public class ConfigFogBlockByBlockAndMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001403 RID: 5123 RVA: 0x000CE009 File Offset: 0x000CC209
		static ConfigFogBlockByBlockAndMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogBlockByBlockAndMapId.CreateStaticDefaultValue), new Action(ConfigFogBlockByBlockAndMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x000CE028 File Offset: 0x000CC228
		public static void CreateStaticDefaultValue()
		{
			ConfigFogBlockByBlockAndMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFogBlockByBlockAndMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "FogBlock"),
				new ValueTuple<string, object>("语句", "select BinData from `FogBlock` where Block=? And MapId=?")
			});
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x000CE0A7 File Offset: 0x000CC2A7
		public static void ResetStaticDefaultValue()
		{
			ConfigFogBlockByBlockAndMapId.LogPair = null;
			ConfigFogBlockByBlockAndMapId.HandleId = 0;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x000CE0B5 File Offset: 0x000CC2B5
		public static void Init()
		{
			ConfigFogBlockByBlockAndMapId.HandleId = ConfigCommon.InitDataStatement(ConfigFogBlockByBlockAndMapId.HandleId, "db_mapfog.db", "select BinData from `FogBlock` where Block=? And MapId=?");
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000CE0D0 File Offset: 0x000CC2D0
		public static FogBlock? GetConfig(string p0Block, int p1MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFogBlockByBlockAndMapId.HandleId, ConfigFogBlockByBlockAndMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FogBlockByBlockAndMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Block);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FogBlock?(FogBlock.GetRootAsFogBlock(configBuffer));
				}
			}
			ConfigFogBlockByBlockAndMapId.LogPair.Clear();
			ConfigFogBlockByBlockAndMapId.LogPair.Add(new ValueTuple<string, object>("Block", p0Block));
			ConfigFogBlockByBlockAndMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p1MapId));
			if (!ConfigCommon.BindString(ConfigFogBlockByBlockAndMapId.HandleId, 1, p0Block, ConfigFogBlockByBlockAndMapId.LogPair) || !ConfigCommon.BindInt(ConfigFogBlockByBlockAndMapId.HandleId, 2, p1MapId, ConfigFogBlockByBlockAndMapId.LogPair) || ConfigCommon.Step(ConfigFogBlockByBlockAndMapId.HandleId, true, ConfigFogBlockByBlockAndMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFogBlockByBlockAndMapId.HandleId, ConfigFogBlockByBlockAndMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFogBlockByBlockAndMapId.HandleId, 0, ConfigFogBlockByBlockAndMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFogBlockByBlockAndMapId.HandleId, ConfigFogBlockByBlockAndMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FogBlock rootAsFogBlock = FogBlock.GetRootAsFogBlock(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FogBlockByBlockAndMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Block);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFogBlockByBlockAndMapId.HandleId, ConfigFogBlockByBlockAndMapId.LogPair);
			return new FogBlock?(rootAsFogBlock);
		}

		// Token: 0x04001737 RID: 5943
		private const string DB = "db_mapfog.db";

		// Token: 0x04001738 RID: 5944
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x04001739 RID: 5945
		private const string TABLE = "FogBlock";

		// Token: 0x0400173A RID: 5946
		private const string COMMAND = "select BinData from `FogBlock` where Block=? And MapId=?";

		// Token: 0x0400173B RID: 5947
		private const string KEY_PREFIX = "FogBlockByBlockAndMapId";

		// Token: 0x0400173C RID: 5948
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400173D RID: 5949
		private static int HandleId;
	}
}
