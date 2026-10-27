using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200014B RID: 331
[NullableContext(2)]
[Nullable(0)]
public class AnsInstanceState
{
	// Token: 0x17000345 RID: 837
	// (get) Token: 0x06001454 RID: 5204 RVA: 0x00071417 File Offset: 0x0006F617
	// (set) Token: 0x06001455 RID: 5205 RVA: 0x0007141F File Offset: 0x0006F61F
	public bool IsListening { get; set; }

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x06001456 RID: 5206 RVA: 0x00071428 File Offset: 0x0006F628
	// (set) Token: 0x06001457 RID: 5207 RVA: 0x00071430 File Offset: 0x0006F630
	public TsBaseCharacter Owner { get; set; }

	// Token: 0x17000347 RID: 839
	// (get) Token: 0x06001458 RID: 5208 RVA: 0x00071439 File Offset: 0x0006F639
	// (set) Token: 0x06001459 RID: 5209 RVA: 0x00071441 File Offset: 0x0006F641
	public bool IsGameplayOpened { get; set; }

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x0600145A RID: 5210 RVA: 0x0007144A File Offset: 0x0006F64A
	// (set) Token: 0x0600145B RID: 5211 RVA: 0x00071452 File Offset: 0x0006F652
	public double? StartServerTimeStamp { get; set; }

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x0600145C RID: 5212 RVA: 0x0007145B File Offset: 0x0006F65B
	// (set) Token: 0x0600145D RID: 5213 RVA: 0x00071463 File Offset: 0x0006F663
	public TInputHandle<InputDistributeDefine.EActionType> OnActionCallback { get; set; }

	// Token: 0x04000E8E RID: 3726
	[Nullable(1)]
	public List<string> BoundActionNames = new List<string>();

	// Token: 0x04000E8F RID: 3727
	[Nullable(1)]
	public List<int> ExternalInteractIds = new List<int>();
}
