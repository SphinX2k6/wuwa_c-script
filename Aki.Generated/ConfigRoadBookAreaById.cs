using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000811 RID: 2065
	public class ConfigRoadBookAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003078 RID: 12408 RVA: 0x0016B37B File Offset: 0x0016957B
		static ConfigRoadBookAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookAreaById.CreateStaticDefaultValue), new Action(ConfigRoadBookAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x0016B39C File Offset: 0x0016959C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookArea"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookArea` where Id=?")
			});
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x0016B41B File Offset: 0x0016961B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookAreaById.LogPair = null;
			ConfigRoadBookAreaById.HandleId = 0;
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x0016B429 File Offset: 0x00169629
		public static void Init()
		{
			ConfigRoadBookAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookAreaById.HandleId, "db_roadbook.db", "select BinData from `RoadBookArea` where Id=?");
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x0016B444 File Offset: 0x00169644
		public static RoadBookArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookAreaById.HandleId, ConfigRoadBookAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoadBookArea?(RoadBookArea.GetRootAsRoadBookArea(configBuffer));
				}
			}
			ConfigRoadBookAreaById.LogPair.Clear();
			ConfigRoadBookAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoadBookAreaById.HandleId, 1, p0Id, ConfigRoadBookAreaById.LogPair) || ConfigCommon.Step(ConfigRoadBookAreaById.HandleId, true, ConfigRoadBookAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoadBookAreaById.HandleId, ConfigRoadBookAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookAreaById.HandleId, 0, ConfigRoadBookAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoadBookAreaById.HandleId, ConfigRoadBookAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoadBookArea rootAsRoadBookArea = RoadBookArea.GetRootAsRoadBookArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoadBookAreaById.HandleId, ConfigRoadBookAreaById.LogPair);
			return new RoadBookArea?(rootAsRoadBookArea);
		}

		// Token: 0x0400385D RID: 14429
		private const string DB = "db_roadbook.db";

		// Token: 0x0400385E RID: 14430
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x0400385F RID: 14431
		private const string TABLE = "RoadBookArea";

		// Token: 0x04003860 RID: 14432
		private const string COMMAND = "select BinData from `RoadBookArea` where Id=?";

		// Token: 0x04003861 RID: 14433
		private const string KEY_PREFIX = "RoadBookAreaById";

		// Token: 0x04003862 RID: 14434
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003863 RID: 14435
		private static int HandleId;
	}
}
