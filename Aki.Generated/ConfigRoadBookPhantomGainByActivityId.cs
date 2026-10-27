using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000815 RID: 2069
	public class ConfigRoadBookPhantomGainByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003090 RID: 12432 RVA: 0x0016BC8C File Offset: 0x00169E8C
		static ConfigRoadBookPhantomGainByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookPhantomGainByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookPhantomGainByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x0016BCAC File Offset: 0x00169EAC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookPhantomGainByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookPhantomGainByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookPhantomGain"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookPhantomGain` where ActivityId=?")
			});
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x0016BD2B File Offset: 0x00169F2B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookPhantomGainByActivityId.LogPair = null;
			ConfigRoadBookPhantomGainByActivityId.HandleId = 0;
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x0016BD39 File Offset: 0x00169F39
		public static void Init()
		{
			ConfigRoadBookPhantomGainByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookPhantomGainByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookPhantomGain` where ActivityId=?");
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x0016BD54 File Offset: 0x00169F54
		[NullableContext(2)]
		public static IReadOnlyList<RoadBookPhantomGain> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookPhantomGainByActivityId.HandleId, ConfigRoadBookPhantomGainByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookPhantomGainByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoadBookPhantomGain> readOnlyList = (IReadOnlyList<RoadBookPhantomGain>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoadBookPhantomGainByActivityId.LogPair.Clear();
			ConfigRoadBookPhantomGainByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoadBookPhantomGainByActivityId.HandleId, 1, p0ActivityId, ConfigRoadBookPhantomGainByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoadBookPhantomGainByActivityId.HandleId, ConfigRoadBookPhantomGainByActivityId.LogPair);
				return null;
			}
			List<RoadBookPhantomGain> list = new List<RoadBookPhantomGain>();
			while (ConfigCommon.Step(ConfigRoadBookPhantomGainByActivityId.HandleId, false, ConfigRoadBookPhantomGainByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookPhantomGainByActivityId.HandleId, 0, ConfigRoadBookPhantomGainByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoadBookPhantomGainByActivityId.HandleId, ConfigRoadBookPhantomGainByActivityId.LogPair);
					return null;
				}
				RoadBookPhantomGain rootAsRoadBookPhantomGain = RoadBookPhantomGain.GetRootAsRoadBookPhantomGain(new ByteBuffer(item2));
				list.Add(rootAsRoadBookPhantomGain);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookPhantomGainByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoadBookPhantomGainByActivityId.HandleId, ConfigRoadBookPhantomGainByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003879 RID: 14457
		private const string DB = "db_roadbook.db";

		// Token: 0x0400387A RID: 14458
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x0400387B RID: 14459
		private const string TABLE = "RoadBookPhantomGain";

		// Token: 0x0400387C RID: 14460
		private const string COMMAND = "select BinData from `RoadBookPhantomGain` where ActivityId=?";

		// Token: 0x0400387D RID: 14461
		private const string KEY_PREFIX = "RoadBookPhantomGainByActivityId";

		// Token: 0x0400387E RID: 14462
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400387F RID: 14463
		private static int HandleId;
	}
}
