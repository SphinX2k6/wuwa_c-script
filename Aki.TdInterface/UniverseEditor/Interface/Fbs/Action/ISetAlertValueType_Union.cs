using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F99 RID: 28569
	public enum ISetAlertValueType_Union : byte
	{
		// Token: 0x04011996 RID: 72086
		NONE,
		// Token: 0x04011997 RID: 72087
		ISetAlertValueType,
		// Token: 0x04011998 RID: 72088
		IAddOrSubAlertValue,
		// Token: 0x04011999 RID: 72089
		ICustomAlertValue,
		// Token: 0x0401199A RID: 72090
		IMinAlertValue,
		// Token: 0x0401199B RID: 72091
		IMaxAlertValue
	}
}
