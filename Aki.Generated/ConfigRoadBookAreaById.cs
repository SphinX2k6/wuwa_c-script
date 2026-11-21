using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082D RID: 2093
	public class ConfigRoadBookAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003120 RID: 12576 RVA: 0x00172663 File Offset: 0x00170863
		static ConfigRoadBookAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookAreaById.CreateStaticDefaultValue), new Action(ConfigRoadBookAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x00172684 File Offset: 0x00170884
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

		// Token: 0x06003122 RID: 12578 RVA: 0x00172703 File Offset: 0x00170903
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookAreaById.LogPair = null;
			ConfigRoadBookAreaById.HandleId = 0;
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x00172711 File Offset: 0x00170911
		public static void Init()
		{
			ConfigRoadBookAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookAreaById.HandleId, "db_roadbook.db", "select BinData from `RoadBookArea` where Id=?");
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x0017272C File Offset: 0x0017092C
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

		// Token: 0x04003921 RID: 14625
		private const string DB = "db_roadbook.db";

		// Token: 0x04003922 RID: 14626
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003923 RID: 14627
		private const string TABLE = "RoadBookArea";

		// Token: 0x04003924 RID: 14628
		private const string COMMAND = "select BinData from `RoadBookArea` where Id=?";

		// Token: 0x04003925 RID: 14629
		private const string KEY_PREFIX = "RoadBookAreaById";

		// Token: 0x04003926 RID: 14630
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003927 RID: 14631
		private static int HandleId;
	}
}
