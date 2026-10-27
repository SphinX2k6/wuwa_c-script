using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004076 RID: 16502
	public enum IRecallConditionBase_Union : byte
	{
		// Token: 0x0400BBF3 RID: 48115
		NONE,
		// Token: 0x0400BBF4 RID: 48116
		IRecallConditionBase,
		// Token: 0x0400BBF5 RID: 48117
		IRecallConditionByEntityType,
		// Token: 0x0400BBF6 RID: 48118
		IRecallConditionByTemplate,
		// Token: 0x0400BBF7 RID: 48119
		IRecallConditionByGroup
	}
}
