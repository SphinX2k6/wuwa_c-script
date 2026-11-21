using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082C RID: 2092
	public class ConfigRoadBookAreaByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600311A RID: 12570 RVA: 0x0017242C File Offset: 0x0017062C
		static ConfigRoadBookAreaByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookAreaByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookAreaByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x0017244C File Offset: 0x0017064C
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

		// Token: 0x0600311C RID: 12572 RVA: 0x001724CB File Offset: 0x001706CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookAreaByActivityId.LogPair = null;
			ConfigRoadBookAreaByActivityId.HandleId = 0;
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x001724D9 File Offset: 0x001706D9
		public static void Init()
		{
			ConfigRoadBookAreaByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookAreaByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookArea` where ActivityId=?");
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x001724F4 File Offset: 0x001706F4
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

		// Token: 0x0400391A RID: 14618
		private const string DB = "db_roadbook.db";

		// Token: 0x0400391B RID: 14619
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x0400391C RID: 14620
		private const string TABLE = "RoadBookArea";

		// Token: 0x0400391D RID: 14621
		private const string COMMAND = "select BinData from `RoadBookArea` where ActivityId=?";

		// Token: 0x0400391E RID: 14622
		private const string KEY_PREFIX = "RoadBookAreaByActivityId";

		// Token: 0x0400391F RID: 14623
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003920 RID: 14624
		private static int HandleId;
	}
}
