using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000353 RID: 851
	public class ConfigFogBlockAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013F7 RID: 5111 RVA: 0x000CDC7B File Offset: 0x000CBE7B
		static ConfigFogBlockAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogBlockAll.CreateStaticDefaultValue), new Action(ConfigFogBlockAll.ResetStaticDefaultValue));
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x000CDC9C File Offset: 0x000CBE9C
		public static void CreateStaticDefaultValue()
		{
			ConfigFogBlockAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFogBlockAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mapfog.db"),
				new ValueTuple<string, object>("文件", "d.地图迷雾.xlsx"),
				new ValueTuple<string, object>("表名", "FogBlock"),
				new ValueTuple<string, object>("语句", "select BinData from `FogBlock`")
			});
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x000CDD1B File Offset: 0x000CBF1B
		public static void ResetStaticDefaultValue()
		{
			ConfigFogBlockAll.LogPair = null;
			ConfigFogBlockAll.HandleId = 0;
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x000CDD29 File Offset: 0x000CBF29
		public static void Init()
		{
			ConfigFogBlockAll.HandleId = ConfigCommon.InitDataStatement(ConfigFogBlockAll.HandleId, "db_mapfog.db", "select BinData from `FogBlock`");
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000CDD44 File Offset: 0x000CBF44
		[NullableContext(2)]
		public static IReadOnlyList<FogBlock> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFogBlockAll.HandleId, ConfigFogBlockAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FogBlock> readOnlyList = (IReadOnlyList<FogBlock>)ConfigCommon.GetConfig("FogBlockAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FogBlock> list = new List<FogBlock>();
			while (ConfigCommon.Step(ConfigFogBlockAll.HandleId, false, ConfigFogBlockAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFogBlockAll.HandleId, 0, ConfigFogBlockAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFogBlockAll.HandleId, ConfigFogBlockAll.LogPair);
					return null;
				}
				FogBlock rootAsFogBlock = FogBlock.GetRootAsFogBlock(new ByteBuffer(item2));
				list.Add(rootAsFogBlock);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FogBlockAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFogBlockAll.HandleId, ConfigFogBlockAll.LogPair);
			return list;
		}

		// Token: 0x04001729 RID: 5929
		private const string DB = "db_mapfog.db";

		// Token: 0x0400172A RID: 5930
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x0400172B RID: 5931
		private const string TABLE = "FogBlock";

		// Token: 0x0400172C RID: 5932
		private const string COMMAND = "select BinData from `FogBlock`";

		// Token: 0x0400172D RID: 5933
		private const string KEY_PREFIX = "FogBlockAll";

		// Token: 0x0400172E RID: 5934
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400172F RID: 5935
		private static int HandleId;
	}
}
