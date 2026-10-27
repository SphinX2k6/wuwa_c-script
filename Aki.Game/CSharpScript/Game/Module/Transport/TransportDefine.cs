using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Transport
{
	// Token: 0x02004AF1 RID: 19185
	[NullableContext(1)]
	[Nullable(0)]
	public static class TransportDefine
	{
		// Token: 0x06031B1E RID: 203550 RVA: 0x00B8A068 File Offset: 0x00B88268
		public static List<int> getRoadZoneData(int mapId)
		{
			List<int> list = new List<int>();
			RoadZoneConfig? config = ConfigRoadZoneConfigByMapId.GetConfig(mapId, true);
			if (config != null)
			{
				foreach (string s in config.Value.PbDataIdIter())
				{
					list.Add(int.Parse(s));
				}
			}
			if (list.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.LC;
				string message = "读取RoadZone文件为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MapId", mapId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return list;
		}

		// Token: 0x06031B1F RID: 203551 RVA: 0x00B8A114 File Offset: 0x00B88314
		public static ERoadwaySprintProperty getRoadwayAutopilotSprintConfig(UKuroRoadway roadway)
		{
			if (roadway != null && roadway.bEnable)
			{
				switch (roadway.PavedRoadConfig)
				{
				case 0:
					return ERoadwaySprintProperty.None;
				case 1:
					return ERoadwaySprintProperty.UnlimitedNitro;
				case 2:
					return ERoadwaySprintProperty.AutoSprint;
				}
			}
			return ERoadwaySprintProperty.None;
		}
	}
}
