using System;
using CSharpScript.Game.Input;

// Token: 0x02000C96 RID: 3222
public interface ICheckKeyCondition : IBaseCheckConditionInfo
{
	// Token: 0x17000F36 RID: 3894
	// (get) Token: 0x06008678 RID: 34424
	// (set) Token: 0x06008679 RID: 34425
	EInputAction ActionKey { get; set; }

	// Token: 0x17000F37 RID: 3895
	// (get) Token: 0x0600867A RID: 34426
	// (set) Token: 0x0600867B RID: 34427
	EComboKeyType ActionType { get; set; }

	// Token: 0x17000F38 RID: 3896
	// (get) Token: 0x0600867C RID: 34428
	// (set) Token: 0x0600867D RID: 34429
	float? HoldTime { get; set; }
}
