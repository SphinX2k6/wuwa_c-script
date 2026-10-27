using System;
using CSharpScript.Game.Input;

// Token: 0x020017DE RID: 6110
public class CheckKeyCondition : IBaseCheckConditionInfo, ICheckKeyCondition
{
	// Token: 0x17000F16 RID: 3862
	// (get) Token: 0x0600B295 RID: 45717 RVA: 0x00285300 File Offset: 0x00283500
	// (set) Token: 0x0600B296 RID: 45718 RVA: 0x00285308 File Offset: 0x00283508
	public EInputAction ActionKey { get; set; }

	// Token: 0x17000F17 RID: 3863
	// (get) Token: 0x0600B297 RID: 45719 RVA: 0x00285311 File Offset: 0x00283511
	// (set) Token: 0x0600B298 RID: 45720 RVA: 0x00285319 File Offset: 0x00283519
	public EComboKeyType ActionType { get; set; }

	// Token: 0x17000F18 RID: 3864
	// (get) Token: 0x0600B299 RID: 45721 RVA: 0x00285322 File Offset: 0x00283522
	// (set) Token: 0x0600B29A RID: 45722 RVA: 0x0028532A File Offset: 0x0028352A
	public float? HoldTime { get; set; }
}
