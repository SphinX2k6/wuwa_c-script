using System;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x02003826 RID: 14374
	public interface IMoveCheckResultAndDistance
	{
		// Token: 0x17004CD0 RID: 19664
		// (get) Token: 0x06025552 RID: 152914
		// (set) Token: 0x06025553 RID: 152915
		EMoveCheckResult Result { get; set; }

		// Token: 0x17004CD1 RID: 19665
		// (get) Token: 0x06025554 RID: 152916
		// (set) Token: 0x06025555 RID: 152917
		float AfterAdjustDistance { get; set; }
	}
}
