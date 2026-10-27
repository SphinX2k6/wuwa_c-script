using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033F RID: 831
	public class ConfigFogBlockByBlock : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600137F RID: 4991 RVA: 0x000C7903 File Offset: 0x000C5B03
		static ConfigFogBlockByBlock()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogBlockByBlock.CreateStaticDefaultValue), new Action(ConfigFogBlockByBlock.ResetStaticDefaultValue));
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x000C7924 File Offset: 0x000C5B24
		public static void CreateStaticDefaultValue()
		{
			ConfigFogBlockByBlock.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFogBlockByBlock.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "FogBlock"),
				new ValueTuple<string, object>("语句", "select BinData from `FogBlock` where Block=?")
			});
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x000C79A3 File Offset: 0x000C5BA3
		public static void ResetStaticDefaultValue()
		{
			ConfigFogBlockByBlock.LogPair = null;
			ConfigFogBlockByBlock.HandleId = 0;
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x000C79B1 File Offset: 0x000C5BB1
		public static void Init()
		{
			ConfigFogBlockByBlock.HandleId = ConfigCommon.InitDataStatement(ConfigFogBlockByBlock.HandleId, "db_mapfog.db", "select BinData from `FogBlock` where Block=?");
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x000C79CC File Offset: 0x000C5BCC
		public static FogBlock? GetConfig(string p0Block, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFogBlockByBlock.HandleId, ConfigFogBlockByBlock.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("FogBlockByBlock#" + p0Block);
				if (configBuffer != null)
				{
					return new FogBlock?(FogBlock.GetRootAsFogBlock(configBuffer));
				}
			}
			ConfigFogBlockByBlock.LogPair.Clear();
			ConfigFogBlockByBlock.LogPair.Add(new ValueTuple<string, object>("Block", p0Block));
			if (!ConfigCommon.BindString(ConfigFogBlockByBlock.HandleId, 1, p0Block, ConfigFogBlockByBlock.LogPair) || ConfigCommon.Step(ConfigFogBlockByBlock.HandleId, true, ConfigFogBlockByBlock.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFogBlockByBlock.HandleId, ConfigFogBlockByBlock.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFogBlockByBlock.HandleId, 0, ConfigFogBlockByBlock.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFogBlockByBlock.HandleId, ConfigFogBlockByBlock.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FogBlock rootAsFogBlock = FogBlock.GetRootAsFogBlock(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("FogBlockByBlock#" + p0Block, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFogBlockByBlock.HandleId, ConfigFogBlockByBlock.LogPair);
			return new FogBlock?(rootAsFogBlock);
		}

		// Token: 0x0400169D RID: 5789
		private const string DB = "db_mapfog.db";

		// Token: 0x0400169E RID: 5790
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x0400169F RID: 5791
		private const string TABLE = "FogBlock";

		// Token: 0x040016A0 RID: 5792
		private const string COMMAND = "select BinData from `FogBlock` where Block=?";

		// Token: 0x040016A1 RID: 5793
		private const string KEY_PREFIX = "FogBlockByBlock";

		// Token: 0x040016A2 RID: 5794
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016A3 RID: 5795
		private static int HandleId;
	}
}
