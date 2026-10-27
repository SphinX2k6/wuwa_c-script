using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048AD RID: 18605
	[NullableContext(2)]
	public interface IDistanceAndRoadway
	{
		// Token: 0x17007964 RID: 31076
		// (get) Token: 0x06030A1D RID: 199197
		// (set) Token: 0x06030A1E RID: 199198
		float Distance { get; set; }

		// Token: 0x17007965 RID: 31077
		// (get) Token: 0x06030A1F RID: 199199
		// (set) Token: 0x06030A20 RID: 199200
		UKuroRoadway Roadway { get; set; }
	}
}
