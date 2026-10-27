using System;
using System.Runtime.CompilerServices;

// Token: 0x020018F3 RID: 6387
[NullableContext(2)]
[Nullable(0)]
public class ItemTipsLockStateData : IItemTipsLockStateData
{
	// Token: 0x17000F97 RID: 3991
	// (get) Token: 0x0600BB29 RID: 47913 RVA: 0x002A607B File Offset: 0x002A427B
	// (set) Token: 0x0600BB2A RID: 47914 RVA: 0x002A6083 File Offset: 0x002A4283
	public bool? IsShowLockIcon { get; set; }

	// Token: 0x17000F98 RID: 3992
	// (get) Token: 0x0600BB2B RID: 47915 RVA: 0x002A608C File Offset: 0x002A428C
	// (set) Token: 0x0600BB2C RID: 47916 RVA: 0x002A6094 File Offset: 0x002A4294
	public bool? IsShowHelpButton { get; set; }

	// Token: 0x17000F99 RID: 3993
	// (get) Token: 0x0600BB2D RID: 47917 RVA: 0x002A609D File Offset: 0x002A429D
	// (set) Token: 0x0600BB2E RID: 47918 RVA: 0x002A60A5 File Offset: 0x002A42A5
	public string TipsTextKey { get; set; }

	// Token: 0x17000F9A RID: 3994
	// (get) Token: 0x0600BB2F RID: 47919 RVA: 0x002A60AE File Offset: 0x002A42AE
	// (set) Token: 0x0600BB30 RID: 47920 RVA: 0x002A60B6 File Offset: 0x002A42B6
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

	// Token: 0x17000F9B RID: 3995
	// (get) Token: 0x0600BB31 RID: 47921 RVA: 0x002A60BF File Offset: 0x002A42BF
	// (set) Token: 0x0600BB32 RID: 47922 RVA: 0x002A60C7 File Offset: 0x002A42C7
	public Action HelpBtnCallback { get; set; }
}
