using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733D RID: 29501
	public enum ITalkOptionPreConditionBase_Union : byte
	{
		// Token: 0x04012133 RID: 74035
		NONE,
		// Token: 0x04012134 RID: 74036
		ITalkOptionPreConditionBase,
		// Token: 0x04012135 RID: 74037
		ITalkOptionPreOption,
		// Token: 0x04012136 RID: 74038
		ITalkOptionCondition,
		// Token: 0x04012137 RID: 74039
		ITalkOptionFirstSelect,
		// Token: 0x04012138 RID: 74040
		ITalkOptionSystemCondition
	}
}
