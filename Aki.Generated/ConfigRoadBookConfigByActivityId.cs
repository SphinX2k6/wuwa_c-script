using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000812 RID: 2066
	public class ConfigRoadBookConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600307E RID: 12414 RVA: 0x0016B5C4 File Offset: 0x001697C4
		static ConfigRoadBookConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x0016B5E4 File Offset: 0x001697E4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookConfig` where ActivityId=?")
			});
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x0016B663 File Offset: 0x00169863
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookConfigByActivityId.LogPair = null;
			ConfigRoadBookConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x0016B671 File Offset: 0x00169871
		public static void Init()
		{
			ConfigRoadBookConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookConfigByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookConfig` where ActivityId=?");
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x0016B68C File Offset: 0x0016988C
		public static RoadBookConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookConfigByActivityId.HandleId, ConfigRoadBookConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoadBookConfig?(RoadBookConfig.GetRootAsRoadBookConfig(configBuffer));
				}
			}
			ConfigRoadBookConfigByActivityId.LogPair.Clear();
			ConfigRoadBookConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoadBookConfigByActivityId.HandleId, 1, p0ActivityId, ConfigRoadBookConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigRoadBookConfigByActivityId.HandleId, true, ConfigRoadBookConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoadBookConfigByActivityId.HandleId, ConfigRoadBookConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookConfigByActivityId.HandleId, 0, ConfigRoadBookConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoadBookConfigByActivityId.HandleId, ConfigRoadBookConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoadBookConfig rootAsRoadBookConfig = RoadBookConfig.GetRootAsRoadBookConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoadBookConfigByActivityId.HandleId, ConfigRoadBookConfigByActivityId.LogPair);
			return new RoadBookConfig?(rootAsRoadBookConfig);
		}

		// Token: 0x04003864 RID: 14436
		private const string DB = "db_roadbook.db";

		// Token: 0x04003865 RID: 14437
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003866 RID: 14438
		private const string TABLE = "RoadBookConfig";

		// Token: 0x04003867 RID: 14439
		private const string COMMAND = "select BinData from `RoadBookConfig` where ActivityId=?";

		// Token: 0x04003868 RID: 14440
		private const string KEY_PREFIX = "RoadBookConfigByActivityId";

		// Token: 0x04003869 RID: 14441
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400386A RID: 14442
		private static int HandleId;
	}
}
