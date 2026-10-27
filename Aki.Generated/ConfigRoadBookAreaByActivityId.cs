using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000810 RID: 2064
	public class ConfigRoadBookAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003072 RID: 12402 RVA: 0x0016B144 File Offset: 0x00169344
		static ConfigRoadBookAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x0016B164 File Offset: 0x00169364
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookAreaByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookAreaByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookArea"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookArea` where ActivityId=?")
			});
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x0016B1E3 File Offset: 0x001693E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookAreaByActivityId.LogPair = null;
			ConfigRoadBookAreaByActivityId.HandleId = 0;
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x0016B1F1 File Offset: 0x001693F1
		public static void Init()
		{
			ConfigRoadBookAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookAreaByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookArea` where ActivityId=?");
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x0016B20C File Offset: 0x0016940C
		[NullableContext(2)]
		public static IReadOnlyList<RoadBookArea> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookAreaByActivityId.HandleId, ConfigRoadBookAreaByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoadBookArea> readOnlyList = (IReadOnlyList<RoadBookArea>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoadBookAreaByActivityId.LogPair.Clear();
			ConfigRoadBookAreaByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoadBookAreaByActivityId.HandleId, 1, p0ActivityId, ConfigRoadBookAreaByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoadBookAreaByActivityId.HandleId, ConfigRoadBookAreaByActivityId.LogPair);
				return null;
			}
			List<RoadBookArea> list = new List<RoadBookArea>();
			while (ConfigCommon.Step(ConfigRoadBookAreaByActivityId.HandleId, false, ConfigRoadBookAreaByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookAreaByActivityId.HandleId, 0, ConfigRoadBookAreaByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoadBookAreaByActivityId.HandleId, ConfigRoadBookAreaByActivityId.LogPair);
					return null;
				}
				RoadBookArea rootAsRoadBookArea = RoadBookArea.GetRootAsRoadBookArea(new ByteBuffer(item2));
				list.Add(rootAsRoadBookArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookAreaByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoadBookAreaByActivityId.HandleId, ConfigRoadBookAreaByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003856 RID: 14422
		private const string DB = "db_roadbook.db";

		// Token: 0x04003857 RID: 14423
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003858 RID: 14424
		private const string TABLE = "RoadBookArea";

		// Token: 0x04003859 RID: 14425
		private const string COMMAND = "select BinData from `RoadBookArea` where ActivityId=?";

		// Token: 0x0400385A RID: 14426
		private const string KEY_PREFIX = "RoadBookAreaByActivityId";

		// Token: 0x0400385B RID: 14427
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400385C RID: 14428
		private static int HandleId;
	}
}
