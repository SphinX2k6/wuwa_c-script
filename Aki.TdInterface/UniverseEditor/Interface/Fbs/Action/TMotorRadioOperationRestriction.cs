using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F4B RID: 32587
	public enum TMotorRadioOperationRestriction : byte
	{
		// Token: 0x040138CF RID: 80079
		NONE,
		// Token: 0x040138D0 RID: 80080
		IDisableAllMotorRadioOperation,
		// Token: 0x040138D1 RID: 80081
		IDisableInRangeMotorRadioOperation,
		// Token: 0x040138D2 RID: 80082
		IEnableAllMotorRadioOperation,
		// Token: 0x040138D3 RID: 80083
		IEnableInRangeMotorRadioOperation
	}
}
