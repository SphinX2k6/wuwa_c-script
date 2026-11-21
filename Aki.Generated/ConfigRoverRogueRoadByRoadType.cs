using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093A RID: 2362
	public class ConfigRoverRogueRoadByRoadType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600376F RID: 14191 RVA: 0x00195DE0 File Offset: 0x00193FE0
		static ConfigRoverRogueRoadByRoadType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoadByRoadType.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoadByRoadType.ResetStaticDefaultValue));
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00195E00 File Offset: 0x00194000
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoadByRoadType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoadByRoadType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRoad"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRoad` where RoadType=?")
			});
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00195E7F File Offset: 0x0019407F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoadByRoadType.LogPair = null;
			ConfigRoverRogueRoadByRoadType.HandleId = 0;
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00195E8D File Offset: 0x0019408D
		public static void Init()
		{
			ConfigRoverRogueRoadByRoadType.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoadByRoadType.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoad` where RoadType=?");
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00195EA8 File Offset: 0x001940A8
		[NullableContext(2)]
		public static IReadOnlyList<RoverRogueRoad> GetConfigList(int p0RoadType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoadByRoadType.HandleId, ConfigRoverRogueRoadByRoadType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoadByRoadType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoadType);
				IReadOnlyList<RoverRogueRoad> readOnlyList = (IReadOnlyList<RoverRogueRoad>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoverRogueRoadByRoadType.LogPair.Clear();
			ConfigRoverRogueRoadByRoadType.LogPair.Add(new ValueTuple<string, object>("RoadType", p0RoadType));
			if (!ConfigCommon.BindInt(ConfigRoverRogueRoadByRoadType.HandleId, 1, p0RoadType, ConfigRoverRogueRoadByRoadType.LogPair))
			{
				ConfigCommon.Reset(ConfigRoverRogueRoadByRoadType.HandleId, ConfigRoverRogueRoadByRoadType.LogPair);
				return null;
			}
			List<RoverRogueRoad> list = new List<RoverRogueRoad>();
			while (ConfigCommon.Step(ConfigRoverRogueRoadByRoadType.HandleId, false, ConfigRoverRogueRoadByRoadType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoadByRoadType.HandleId, 0, ConfigRoverRogueRoadByRoadType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoverRogueRoadByRoadType.HandleId, ConfigRoverRogueRoadByRoadType.LogPair);
					return null;
				}
				RoverRogueRoad rootAsRoverRogueRoad = RoverRogueRoad.GetRootAsRoverRogueRoad(new ByteBuffer(item2));
				list.Add(rootAsRoverRogueRoad);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoadByRoadType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoadType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoadByRoadType.HandleId, ConfigRoverRogueRoadByRoadType.LogPair);
			return list;
		}

		// Token: 0x0400407C RID: 16508
		private const string DB = "db_roverlike.db";

		// Token: 0x0400407D RID: 16509
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x0400407E RID: 16510
		private const string TABLE = "RoverRogueRoad";

		// Token: 0x0400407F RID: 16511
		private const string COMMAND = "select BinData from `RoverRogueRoad` where RoadType=?";

		// Token: 0x04004080 RID: 16512
		private const string KEY_PREFIX = "RoverRogueRoadByRoadType";

		// Token: 0x04004081 RID: 16513
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004082 RID: 16514
		private static int HandleId;
	}
}
