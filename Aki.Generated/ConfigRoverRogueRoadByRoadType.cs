using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EF RID: 2287
	public class ConfigRoverRogueRoadByRoadType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035AD RID: 13741 RVA: 0x00188BC0 File Offset: 0x00186DC0
		static ConfigRoverRogueRoadByRoadType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoadByRoadType.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoadByRoadType.ResetStaticDefaultValue));
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x00188BE0 File Offset: 0x00186DE0
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

		// Token: 0x060035AF RID: 13743 RVA: 0x00188C5F File Offset: 0x00186E5F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoadByRoadType.LogPair = null;
			ConfigRoverRogueRoadByRoadType.HandleId = 0;
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00188C6D File Offset: 0x00186E6D
		public static void Init()
		{
			ConfigRoverRogueRoadByRoadType.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoadByRoadType.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoad` where RoadType=?");
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00188C88 File Offset: 0x00186E88
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

		// Token: 0x04003E6F RID: 15983
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E70 RID: 15984
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x04003E71 RID: 15985
		private const string TABLE = "RoverRogueRoad";

		// Token: 0x04003E72 RID: 15986
		private const string COMMAND = "select BinData from `RoverRogueRoad` where RoadType=?";

		// Token: 0x04003E73 RID: 15987
		private const string KEY_PREFIX = "RoverRogueRoadByRoadType";

		// Token: 0x04003E74 RID: 15988
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E75 RID: 15989
		private static int HandleId;
	}
}
