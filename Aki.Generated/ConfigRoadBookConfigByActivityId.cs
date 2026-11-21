using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082E RID: 2094
	public class ConfigRoadBookConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003126 RID: 12582 RVA: 0x001728AC File Offset: 0x00170AAC
		static ConfigRoadBookConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigRoadBookConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x001728CC File Offset: 0x00170ACC
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

		// Token: 0x06003128 RID: 12584 RVA: 0x0017294B File Offset: 0x00170B4B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookConfigByActivityId.LogPair = null;
			ConfigRoadBookConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x00172959 File Offset: 0x00170B59
		public static void Init()
		{
			ConfigRoadBookConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookConfigByActivityId.HandleId, "db_roadbook.db", "select BinData from `RoadBookConfig` where ActivityId=?");
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x00172974 File Offset: 0x00170B74
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

		// Token: 0x04003928 RID: 14632
		private const string DB = "db_roadbook.db";

		// Token: 0x04003929 RID: 14633
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x0400392A RID: 14634
		private const string TABLE = "RoadBookConfig";

		// Token: 0x0400392B RID: 14635
		private const string COMMAND = "select BinData from `RoadBookConfig` where ActivityId=?";

		// Token: 0x0400392C RID: 14636
		private const string KEY_PREFIX = "RoadBookConfigByActivityId";

		// Token: 0x0400392D RID: 14637
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400392E RID: 14638
		private static int HandleId;
	}
}
