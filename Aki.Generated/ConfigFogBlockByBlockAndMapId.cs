using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000340 RID: 832
	public class ConfigFogBlockByBlockAndMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001385 RID: 4997 RVA: 0x000C7AFD File Offset: 0x000C5CFD
		static ConfigFogBlockByBlockAndMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogBlockByBlockAndMapId.CreateStaticDefaultValue), new Action(ConfigFogBlockByBlockAndMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000C7B1C File Offset: 0x000C5D1C
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

		// Token: 0x06001387 RID: 4999 RVA: 0x000C7B9B File Offset: 0x000C5D9B
		public static void ResetStaticDefaultValue()
		{
			ConfigFogBlockByBlockAndMapId.LogPair = null;
			ConfigFogBlockByBlockAndMapId.HandleId = 0;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x000C7BA9 File Offset: 0x000C5DA9
		public static void Init()
		{
			ConfigFogBlockByBlockAndMapId.HandleId = ConfigCommon.InitDataStatement(ConfigFogBlockByBlockAndMapId.HandleId, "db_mapfog.db", "select BinData from `FogBlock` where Block=? And MapId=?");
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x000C7BC4 File Offset: 0x000C5DC4
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

		// Token: 0x040016A4 RID: 5796
		private const string DB = "db_mapfog.db";

		// Token: 0x040016A5 RID: 5797
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x040016A6 RID: 5798
		private const string TABLE = "FogBlock";

		// Token: 0x040016A7 RID: 5799
		private const string COMMAND = "select BinData from `FogBlock` where Block=? And MapId=?";

		// Token: 0x040016A8 RID: 5800
		private const string KEY_PREFIX = "FogBlockByBlockAndMapId";

		// Token: 0x040016A9 RID: 5801
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016AA RID: 5802
		private static int HandleId;
	}
}
