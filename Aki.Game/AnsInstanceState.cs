using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200014F RID: 335
[NullableContext(2)]
[Nullable(0)]
public class AnsInstanceState
{
	// Token: 0x17000367 RID: 871
	// (get) Token: 0x060014F1 RID: 5361 RVA: 0x000767AF File Offset: 0x000749AF
	// (set) Token: 0x060014F2 RID: 5362 RVA: 0x000767B7 File Offset: 0x000749B7
	public bool IsListening { get; set; }

	// Token: 0x17000368 RID: 872
	// (get) Token: 0x060014F3 RID: 5363 RVA: 0x000767C0 File Offset: 0x000749C0
	// (set) Token: 0x060014F4 RID: 5364 RVA: 0x000767C8 File Offset: 0x000749C8
	public TsBaseCharacter Owner { get; set; }

	// Token: 0x17000369 RID: 873
	// (get) Token: 0x060014F5 RID: 5365 RVA: 0x000767D1 File Offset: 0x000749D1
	// (set) Token: 0x060014F6 RID: 5366 RVA: 0x000767D9 File Offset: 0x000749D9
	public bool IsGameplayOpened { get; set; }

	// Token: 0x1700036A RID: 874
	// (get) Token: 0x060014F7 RID: 5367 RVA: 0x000767E2 File Offset: 0x000749E2
	// (set) Token: 0x060014F8 RID: 5368 RVA: 0x000767EA File Offset: 0x000749EA
	public double? StartServerTimeStamp { get; set; }

	// Token: 0x1700036B RID: 875
	// (get) Token: 0x060014F9 RID: 5369 RVA: 0x000767F3 File Offset: 0x000749F3
	// (set) Token: 0x060014FA RID: 5370 RVA: 0x000767FB File Offset: 0x000749FB
	public TInputHandle<InputDistributeDefine.EActionType> OnActionCallback { get; set; }

	// Token: 0x04000ED1 RID: 3793
	[Nullable(1)]
	public List<string> BoundActionNames = new List<string>();

	// Token: 0x04000ED2 RID: 3794
	[Nullable(1)]
	public List<int> ExternalInteractIds = new List<int>();
}
