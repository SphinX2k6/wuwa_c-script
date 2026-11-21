using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B15 RID: 31509
	public enum ITalkOptionPreConditionBase_Union : byte
	{
		// Token: 0x04013139 RID: 78137
		NONE,
		// Token: 0x0401313A RID: 78138
		ITalkOptionPreConditionBase,
		// Token: 0x0401313B RID: 78139
		ITalkOptionPreOption,
		// Token: 0x0401313C RID: 78140
		ITalkOptionCondition,
		// Token: 0x0401313D RID: 78141
		ITalkOptionFirstSelect,
		// Token: 0x0401313E RID: 78142
		ITalkOptionSystemCondition
	}
}
