using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x0200146B RID: 5227
[NullableContext(1)]
[Nullable(0)]
public class ExternalInteractInfo
{
	// Token: 0x17001377 RID: 4983
	// (get) Token: 0x0600D00E RID: 53262 RVA: 0x003DCD73 File Offset: 0x003DAF73
	// (set) Token: 0x0600D00F RID: 53263 RVA: 0x003DCD7B File Offset: 0x003DAF7B
	public string Text { get; set; }

	// Token: 0x17001378 RID: 4984
	// (get) Token: 0x0600D010 RID: 53264 RVA: 0x003DCD84 File Offset: 0x003DAF84
	// (set) Token: 0x0600D011 RID: 53265 RVA: 0x003DCD8C File Offset: 0x003DAF8C
	public EInteractIcon IconType { get; set; }

	// Token: 0x17001379 RID: 4985
	// (get) Token: 0x0600D012 RID: 53266 RVA: 0x003DCD95 File Offset: 0x003DAF95
	// (set) Token: 0x0600D013 RID: 53267 RVA: 0x003DCD9D File Offset: 0x003DAF9D
	public Action Callback { get; set; }
}
