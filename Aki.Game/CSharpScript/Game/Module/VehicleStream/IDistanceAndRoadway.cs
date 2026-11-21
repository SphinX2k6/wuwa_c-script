using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003824 RID: 14372
	[NullableContext(2)]
	public interface IDistanceAndRoadway
	{
		// Token: 0x17004CCC RID: 19660
		// (get) Token: 0x06025549 RID: 152905
		// (set) Token: 0x0602554A RID: 152906
		float Distance { get; set; }

		// Token: 0x17004CCD RID: 19661
		// (get) Token: 0x0602554B RID: 152907
		// (set) Token: 0x0602554C RID: 152908
		UKuroRoadway Roadway { get; set; }
	}
}
