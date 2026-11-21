using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082F RID: 2095
	public class ConfigRoadBookLevelExpByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600312C RID: 12588 RVA: 0x00172AF4 File Offset: 0x00170CF4
		static ConfigRoadBookLevelExpByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookLevelExpByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookLevelExpByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x00172B14 File Offset: 0x00170D14
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookLevelExpByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookLevelExpByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookLevelExp"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookLevelExp` where ActivityId=?")
			});
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x00172B93 File Offset: 0x00170D93
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookLevelExpByActivityId.LogPair = null;
			ConfigRoadBookLevelExpByActivityId.HandleId = 0;
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x00172BA1 File Offset: 0x00170DA1
		public static void Init()
		{
			ConfigRoadBookLevelExpByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookLevelExpByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookLevelExp` where ActivityId=?");
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x00172BBC File Offset: 0x00170DBC
		[NullableContext(2)]
		public static IReadOnlyList<RoadBookLevelExp> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookLevelExpByActivityId.HandleId, ConfigRoadBookLevelExpByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookLevelExpByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoadBookLevelExp> readOnlyList = (IReadOnlyList<RoadBookLevelExp>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoadBookLevelExpByActivityId.LogPair.Clear();
			ConfigRoadBookLevelExpByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoadBookLevelExpByActivityId.HandleId, 1, p0ActivityId, ConfigRoadBookLevelExpByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoadBookLevelExpByActivityId.HandleId, ConfigRoadBookLevelExpByActivityId.LogPair);
				return null;
			}
			List<RoadBookLevelExp> list = new List<RoadBookLevelExp>();
			while (ConfigCommon.Step(ConfigRoadBookLevelExpByActivityId.HandleId, false, ConfigRoadBookLevelExpByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookLevelExpByActivityId.HandleId, 0, ConfigRoadBookLevelExpByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoadBookLevelExpByActivityId.HandleId, ConfigRoadBookLevelExpByActivityId.LogPair);
					return null;
				}
				RoadBookLevelExp rootAsRoadBookLevelExp = RoadBookLevelExp.GetRootAsRoadBookLevelExp(new ByteBuffer(item2));
				list.Add(rootAsRoadBookLevelExp);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookLevelExpByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoadBookLevelExpByActivityId.HandleId, ConfigRoadBookLevelExpByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400392F RID: 14639
		private const string DB = "db_roadbook.db";

		// Token: 0x04003930 RID: 14640
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003931 RID: 14641
		private const string TABLE = "RoadBookLevelExp";

		// Token: 0x04003932 RID: 14642
		private const string COMMAND = "select BinData from `RoadBookLevelExp` where ActivityId=?";

		// Token: 0x04003933 RID: 14643
		private const string KEY_PREFIX = "RoadBookLevelExpByActivityId";

		// Token: 0x04003934 RID: 14644
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003935 RID: 14645
		private static int HandleId;
	}
}
