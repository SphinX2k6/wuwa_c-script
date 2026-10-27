using System;
using CSharpScript.Game.Input;

// Token: 0x020017DD RID: 6109
public interface ICheckKeyCondition : IBaseCheckConditionInfo
{
	// Token: 0x17000F13 RID: 3859
	// (get) Token: 0x0600B28F RID: 45711
	// (set) Token: 0x0600B290 RID: 45712
	EInputAction ActionKey { get; set; }

	// Token: 0x17000F14 RID: 3860
	// (get) Token: 0x0600B291 RID: 45713
	// (set) Token: 0x0600B292 RID: 45714
	EComboKeyType ActionType { get; set; }

	// Token: 0x17000F15 RID: 3861
	// (get) Token: 0x0600B293 RID: 45715
	// (set) Token: 0x0600B294 RID: 45716
	float? HoldTime { get; set; }
}
