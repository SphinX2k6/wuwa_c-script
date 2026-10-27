using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033E RID: 830
	public class ConfigFogBlockAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001379 RID: 4985 RVA: 0x000C776F File Offset: 0x000C596F
		static ConfigFogBlockAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFogBlockAll.CreateStaticDefaultValue), new Action(ConfigFogBlockAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x000C7790 File Offset: 0x000C5990
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

		// Token: 0x0600137B RID: 4987 RVA: 0x000C780F File Offset: 0x000C5A0F
		public static void ResetStaticDefaultValue()
		{
			ConfigFogBlockAll.LogPair = null;
			ConfigFogBlockAll.HandleId = 0;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000C781D File Offset: 0x000C5A1D
		public static void Init()
		{
			ConfigFogBlockAll.HandleId = ConfigCommon.InitDataStatement(ConfigFogBlockAll.HandleId, "db_mapfog.db", "select BinData from `FogBlock`");
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000C7838 File Offset: 0x000C5A38
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

		// Token: 0x04001696 RID: 5782
		private const string DB = "db_mapfog.db";

		// Token: 0x04001697 RID: 5783
		private const string FILE = "d.地图迷雾.xlsx";

		// Token: 0x04001698 RID: 5784
		private const string TABLE = "FogBlock";

		// Token: 0x04001699 RID: 5785
		private const string COMMAND = "select BinData from `FogBlock`";

		// Token: 0x0400169A RID: 5786
		private const string KEY_PREFIX = "FogBlockAll";

		// Token: 0x0400169B RID: 5787
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400169C RID: 5788
		private static int HandleId;
	}
}
