using System;
using CSharpScript.Game.Input;

// Token: 0x02000C97 RID: 3223
public class CheckKeyCondition : IBaseCheckConditionInfo, ICheckKeyCondition
{
	// Token: 0x17000F39 RID: 3897
	// (get) Token: 0x0600867E RID: 34430 RVA: 0x0028F8AC File Offset: 0x0028DAAC
	// (set) Token: 0x0600867F RID: 34431 RVA: 0x0028F8B4 File Offset: 0x0028DAB4
	public EInputAction ActionKey { get; set; }

	// Token: 0x17000F3A RID: 3898
	// (get) Token: 0x06008680 RID: 34432 RVA: 0x0028F8BD File Offset: 0x0028DABD
	// (set) Token: 0x06008681 RID: 34433 RVA: 0x0028F8C5 File Offset: 0x0028DAC5
	public EComboKeyType ActionType { get; set; }

	// Token: 0x17000F3B RID: 3899
	// (get) Token: 0x06008682 RID: 34434 RVA: 0x0028F8CE File Offset: 0x0028DACE
	// (set) Token: 0x06008683 RID: 34435 RVA: 0x0028F8D6 File Offset: 0x0028DAD6
	public float? HoldTime { get; set; }
}
