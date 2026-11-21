using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000354 RID: 852
	public class ConfigFogBlockByBlock : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013FD RID: 5117 RVA: 0x000CDE0F File Offset: 0x000CC00F
		static ConfigFogBlockByBlock()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogBlockByBlock.CreateStaticDefaultValue), new Action(ConfigFogBlockByBlock.ResetStaticDefaultValue));
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x000CDE30 File Offset: 0x000CC030
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

		// Token: 0x060013FF RID: 5119 RVA: 0x000CDEAF File Offset: 0x000CC0AF
		public static void ResetStaticDefaultValue()
		{
			ConfigFogBlockByBlock.LogPair = null;
			ConfigFogBlockByBlock.HandleId = 0;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x000CDEBD File Offset: 0x000CC0BD
		public static void Init()
		{
			ConfigFogBlockByBlock.HandleId = ConfigCommon.InitDataStatement(ConfigFogBlockByBlock.HandleId, "db_mapfog.db", "select BinData from `FogBlock` where Block=?");
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x000CDED8 File Offset: 0x000CC0D8
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

		// Token: 0x04001730 RID: 5936
		private const string DB = "db_mapfog.db";

		// Token: 0x04001731 RID: 5937
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x04001732 RID: 5938
		private const string TABLE = "FogBlock";

		// Token: 0x04001733 RID: 5939
		private const string COMMAND = "select BinData from `FogBlock` where Block=?";

		// Token: 0x04001734 RID: 5940
		private const string KEY_PREFIX = "FogBlockByBlock";

		// Token: 0x04001735 RID: 5941
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001736 RID: 5942
		private static int HandleId;
	}
}
