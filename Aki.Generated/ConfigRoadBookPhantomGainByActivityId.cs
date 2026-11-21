using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000831 RID: 2097
	public class ConfigRoadBookPhantomGainByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003138 RID: 12600 RVA: 0x00172F74 File Offset: 0x00171174
		static ConfigRoadBookPhantomGainByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookPhantomGainByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookPhantomGainByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x00172F94 File Offset: 0x00171194
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

		// Token: 0x0600313A RID: 12602 RVA: 0x00173013 File Offset: 0x00171213
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookPhantomGainByActivityId.LogPair = null;
			ConfigRoadBookPhantomGainByActivityId.HandleId = 0;
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x00173021 File Offset: 0x00171221
		public static void Init()
		{
			ConfigRoadBookPhantomGainByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookPhantomGainByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookPhantomGain` where ActivityId=?");
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x0017303C File Offset: 0x0017123C
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

		// Token: 0x0400393D RID: 14653
		private const string DB = "db_roadbook.db";

		// Token: 0x0400393E RID: 14654
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x0400393F RID: 14655
		private const string TABLE = "RoadBookPhantomGain";

		// Token: 0x04003940 RID: 14656
		private const string COMMAND = "select BinData from `RoadBookPhantomGain` where ActivityId=?";

		// Token: 0x04003941 RID: 14657
		private const string KEY_PREFIX = "RoadBookPhantomGainByActivityId";

		// Token: 0x04003942 RID: 14658
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003943 RID: 14659
		private static int HandleId;
	}
}
