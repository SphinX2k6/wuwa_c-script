using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Map.BlockOut.Tools.LevelMarker
{
	// Token: 0x02003E4D RID: 15949
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Map/BlockOut/Tools/LevelMarker/ELevelMarkerType.ELevelMarkerType")]
	public enum ELevelMarkerType : byte
	{
		// Token: 0x0401465F RID: 83551
		LevelMarker_Function,
		// Token: 0x04014660 RID: 83552
		LevelMarker_Quest,
		// Token: 0x04014661 RID: 83553
		LevelMarker_Atmosphere,
		// Token: 0x04014662 RID: 83554
		ELevelMarkerType_MAX
	}
}
