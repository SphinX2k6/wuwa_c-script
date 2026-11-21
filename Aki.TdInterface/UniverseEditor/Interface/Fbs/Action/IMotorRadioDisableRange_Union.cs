using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726A RID: 29290
	public enum IMotorRadioDisableRange_Union : byte
	{
		// Token: 0x040122DD RID: 74461
		NONE,
		// Token: 0x040122DE RID: 74462
		IMotorRadioDisableRange,
		// Token: 0x040122DF RID: 74463
		IMotorRadioDisableByAreaId,
		// Token: 0x040122E0 RID: 74464
		IMotorRadioDisableByAbsoluteRange,
		// Token: 0x040122E1 RID: 74465
		IMotorRadioDisableByRangeEntities
	}
}
