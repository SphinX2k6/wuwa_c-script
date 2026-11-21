using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DA3 RID: 3491
[NullableContext(1)]
[Nullable(0)]
public class ButtonInfo : IButtonInfo
{
	// Token: 0x17000FB0 RID: 4016
	// (get) Token: 0x06008EC8 RID: 36552 RVA: 0x002AF927 File Offset: 0x002ADB27
	// (set) Token: 0x06008EC9 RID: 36553 RVA: 0x002AF92F File Offset: 0x002ADB2F
	public Action<int> Function { get; set; }

	// Token: 0x17000FB1 RID: 4017
	// (get) Token: 0x06008ECA RID: 36554 RVA: 0x002AF938 File Offset: 0x002ADB38
	// (set) Token: 0x06008ECB RID: 36555 RVA: 0x002AF940 File Offset: 0x002ADB40
	public string Text { get; set; }

	// Token: 0x17000FB2 RID: 4018
	// (get) Token: 0x06008ECC RID: 36556 RVA: 0x002AF949 File Offset: 0x002ADB49
	// (set) Token: 0x06008ECD RID: 36557 RVA: 0x002AF951 File Offset: 0x002ADB51
	public int Index { get; set; }

	// Token: 0x17000FB3 RID: 4019
	// (get) Token: 0x06008ECE RID: 36558 RVA: 0x002AF95A File Offset: 0x002ADB5A
	// (set) Token: 0x06008ECF RID: 36559 RVA: 0x002AF962 File Offset: 0x002ADB62
	public ERedDotName? RedDotName { get; set; }

	// Token: 0x17000FB4 RID: 4020
	// (get) Token: 0x06008ED0 RID: 36560 RVA: 0x002AF96B File Offset: 0x002ADB6B
	// (set) Token: 0x06008ED1 RID: 36561 RVA: 0x002AF973 File Offset: 0x002ADB73
	public int? RedDotId { get; set; }
}
