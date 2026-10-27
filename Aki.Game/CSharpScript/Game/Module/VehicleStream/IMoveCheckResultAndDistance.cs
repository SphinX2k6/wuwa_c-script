using System;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048AF RID: 18607
	public interface IMoveCheckResultAndDistance
	{
		// Token: 0x17007968 RID: 31080
		// (get) Token: 0x06030A26 RID: 199206
		// (set) Token: 0x06030A27 RID: 199207
		EMoveCheckResult Result { get; set; }

		// Token: 0x17007969 RID: 31081
		// (get) Token: 0x06030A28 RID: 199208
		// (set) Token: 0x06030A29 RID: 199209
		float AfterAdjustDistance { get; set; }
	}
}
