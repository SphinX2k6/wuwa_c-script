using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000813 RID: 2067
	public class ConfigRoadBookLevelExpByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003084 RID: 12420 RVA: 0x0016B80C File Offset: 0x00169A0C
		static ConfigRoadBookLevelExpByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookLevelExpByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookLevelExpByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x0016B82C File Offset: 0x00169A2C
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

		// Token: 0x06003086 RID: 12422 RVA: 0x0016B8AB File Offset: 0x00169AAB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookLevelExpByActivityId.LogPair = null;
			ConfigRoadBookLevelExpByActivityId.HandleId = 0;
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x0016B8B9 File Offset: 0x00169AB9
		public static void Init()
		{
			ConfigRoadBookLevelExpByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookLevelExpByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookLevelExp` where ActivityId=?");
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x0016B8D4 File Offset: 0x00169AD4
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

		// Token: 0x0400386B RID: 14443
		private const string DB = "db_roadbook.db";

		// Token: 0x0400386C RID: 14444
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x0400386D RID: 14445
		private const string TABLE = "RoadBookLevelExp";

		// Token: 0x0400386E RID: 14446
		private const string COMMAND = "select BinData from `RoadBookLevelExp` where ActivityId=?";

		// Token: 0x0400386F RID: 14447
		private const string KEY_PREFIX = "RoadBookLevelExpByActivityId";

		// Token: 0x04003870 RID: 14448
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003871 RID: 14449
		private static int HandleId;
	}
}
