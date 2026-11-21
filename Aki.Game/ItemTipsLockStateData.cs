using System;
using System.Runtime.CompilerServices;

// Token: 0x02000DAC RID: 3500
[NullableContext(2)]
[Nullable(0)]
public class ItemTipsLockStateData : IItemTipsLockStateData
{
	// Token: 0x17000FBA RID: 4026
	// (get) Token: 0x06008F13 RID: 36627 RVA: 0x002B07DB File Offset: 0x002AE9DB
	// (set) Token: 0x06008F14 RID: 36628 RVA: 0x002B07E3 File Offset: 0x002AE9E3
	public bool? IsShowLockIcon { get; set; }

	// Token: 0x17000FBB RID: 4027
	// (get) Token: 0x06008F15 RID: 36629 RVA: 0x002B07EC File Offset: 0x002AE9EC
	// (set) Token: 0x06008F16 RID: 36630 RVA: 0x002B07F4 File Offset: 0x002AE9F4
	public bool? IsShowHelpButton { get; set; }

	// Token: 0x17000FBC RID: 4028
	// (get) Token: 0x06008F17 RID: 36631 RVA: 0x002B07FD File Offset: 0x002AE9FD
	// (set) Token: 0x06008F18 RID: 36632 RVA: 0x002B0805 File Offset: 0x002AEA05
	public string TipsTextKey { get; set; }

	// Token: 0x17000FBD RID: 4029
	// (get) Token: 0x06008F19 RID: 36633 RVA: 0x002B080E File Offset: 0x002AEA0E
	// (set) Token: 0x06008F1A RID: 36634 RVA: 0x002B0816 File Offset: 0x002AEA16
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] TipsTextParams { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000FBE RID: 4030
	// (get) Token: 0x06008F1B RID: 36635 RVA: 0x002B081F File Offset: 0x002AEA1F
	// (set) Token: 0x06008F1C RID: 36636 RVA: 0x002B0827 File Offset: 0x002AEA27
	public Action HelpBtnCallback { get; set; }
}
