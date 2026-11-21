using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007270 RID: 29296
	public enum IMotorRadioOperationRestriction_Union : byte
	{
		// Token: 0x040122E7 RID: 74471
		NONE,
		// Token: 0x040122E8 RID: 74472
		IMotorRadioOperationRestriction,
		// Token: 0x040122E9 RID: 74473
		IEnableAllMotorRadioOperation,
		// Token: 0x040122EA RID: 74474
		IDisableAllMotorRadioOperation,
		// Token: 0x040122EB RID: 74475
		IEnableInRangeMotorRadioOperation,
		// Token: 0x040122EC RID: 74476
		IDisableInRangeMotorRadioOperation
	}
}
