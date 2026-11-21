using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Roulette.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EB8 RID: 7864
[NullableContext(1)]
[Nullable(0)]
public abstract class RouletteMainViewProxyBase
{
	// Token: 0x060136B3 RID: 79539 RVA: 0x005AAACC File Offset: 0x005A8CCC
	public void RegisterView(RouletteMainView view)
	{
		this.View = view;
	}

	// Token: 0x060136B4 RID: 79540 RVA: 0x005AAAD8 File Offset: 0x005A8CD8
	public UniTask BeforeStartAsync()
	{
		RouletteMainViewProxyBase.<BeforeStartAsync>d__6 <BeforeStartAsync>d__;
		<BeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeStartAsync>d__.<>4__this = this;
		<BeforeStartAsync>d__.<>1__state = -1;
		<BeforeStartAsync>d__.<>t__builder.Start<RouletteMainViewProxyBase.<BeforeStartAsync>d__6>(ref <BeforeStartAsync>d__);
		return <BeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060136B5 RID: 79541 RVA: 0x005AAB1B File Offset: 0x005A8D1B
	public void Start()
	{
		this.RouletteType = this.GetRouletteType();
		this.CanSwitchType = this.GetCanSwitchType();
		this.OnStart();
	}

	// Token: 0x060136B6 RID: 79542 RVA: 0x005AAB3B File Offset: 0x005A8D3B
	public void BeforeShow()
	{
		this.OnBeforeShow();
	}

	// Token: 0x060136B7 RID: 79543 RVA: 0x005AAB43 File Offset: 0x005A8D43
	public void AddEventListenerByStart()
	{
		this.OnAddEventListenerByStart();
	}

	// Token: 0x060136B8 RID: 79544 RVA: 0x005AAB4B File Offset: 0x005A8D4B
	public void RemoveEventListenerByStart()
	{
		this.OnRemoveEventListenerByStart();
	}

	// Token: 0x060136B9 RID: 79545 RVA: 0x005AAB53 File Offset: 0x005A8D53
	public void AddEventListener()
	{
		this.OnAddEventListener();
	}

	// Token: 0x060136BA RID: 79546 RVA: 0x005AAB5B File Offset: 0x005A8D5B
	public void RemoveEventListener()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x060136BB RID: 79547 RVA: 0x005AAB63 File Offset: 0x005A8D63
	public bool CanOpenView()
	{
		return this.OnCanOpenView();
	}

	// Token: 0x060136BC RID: 79548 RVA: 0x005AAB6B File Offset: 0x005A8D6B
	public RouletteComponentMain GetRouletteComponent()
	{
		return this.OnGetRouletteComponent();
	}

	// Token: 0x060136BD RID: 79549 RVA: 0x005AAB73 File Offset: 0x005A8D73
	public ERouletteType GetRouletteType()
	{
		return this.OnGetRouletteType();
	}

	// Token: 0x060136BE RID: 79550 RVA: 0x005AAB7B File Offset: 0x005A8D7B
	public bool GetCanSwitchType()
	{
		return this.OnGetCanSwitchType();
	}

	// Token: 0x060136BF RID: 79551 RVA: 0x005AAB83 File Offset: 0x005A8D83
	public bool GetPanelSwitchOpen()
	{
		return this.OnGetPanelSwitchOpen();
	}

	// Token: 0x060136C0 RID: 79552 RVA: 0x005AAB8B File Offset: 0x005A8D8B
	public void RouletteTypeSwitch()
	{
		this.OnRouletteTypeSwitch();
	}

	// Token: 0x060136C1 RID: 79553 RVA: 0x005AAB94 File Offset: 0x005A8D94
	public virtual EToggleState? GetToggle1State()
	{
		return null;
	}

	// Token: 0x060136C2 RID: 79554 RVA: 0x005AABAC File Offset: 0x005A8DAC
	public virtual EToggleState? GetToggle2State()
	{
		return null;
	}

	// Token: 0x060136C3 RID: 79555 RVA: 0x005AABC2 File Offset: 0x005A8DC2
	public bool GetCanOpenAssembly(ERouletteType rouletteType)
	{
		return this.OnGetCanOpenAssembly(rouletteType);
	}

	// Token: 0x060136C4 RID: 79556 RVA: 0x005AABCB File Offset: 0x005A8DCB
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetExploreRouletteDataMap()
	{
		return this.OnGetExploreRouletteDataMap();
	}

	// Token: 0x060136C5 RID: 79557 RVA: 0x005AABD3 File Offset: 0x005A8DD3
	public int GetRouletteGridId(int index, ERouletteGridType gridType)
	{
		return this.OnGetRouletteGridId(index, gridType);
	}

	// Token: 0x060136C6 RID: 79558 RVA: 0x005AABDD File Offset: 0x005A8DDD
	public string GetActionName()
	{
		return this.OnGetActionName();
	}

	// Token: 0x060136C7 RID: 79559 RVA: 0x005AABE5 File Offset: 0x005A8DE5
	public void RefreshTips()
	{
		this.OnRefreshTips();
	}

	// Token: 0x060136C8 RID: 79560 RVA: 0x005AABED File Offset: 0x005A8DED
	public void Destroy()
	{
		this.OnDestroy();
	}

	// Token: 0x060136C9 RID: 79561 RVA: 0x005AABF5 File Offset: 0x005A8DF5
	protected virtual UniTask OnBeforeStartAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x060136CA RID: 79562 RVA: 0x005AABFC File Offset: 0x005A8DFC
	protected virtual void OnStart()
	{
	}

	// Token: 0x060136CB RID: 79563 RVA: 0x005AABFE File Offset: 0x005A8DFE
	protected virtual void OnBeforeShow()
	{
	}

	// Token: 0x060136CC RID: 79564 RVA: 0x005AAC00 File Offset: 0x005A8E00
	protected virtual void OnAddEventListenerByStart()
	{
	}

	// Token: 0x060136CD RID: 79565 RVA: 0x005AAC02 File Offset: 0x005A8E02
	protected virtual void OnRemoveEventListenerByStart()
	{
	}

	// Token: 0x060136CE RID: 79566 RVA: 0x005AAC04 File Offset: 0x005A8E04
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x060136CF RID: 79567 RVA: 0x005AAC06 File Offset: 0x005A8E06
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x060136D0 RID: 79568
	protected abstract bool OnCanOpenView();

	// Token: 0x060136D1 RID: 79569
	protected abstract RouletteComponentMain OnGetRouletteComponent();

	// Token: 0x060136D2 RID: 79570
	protected abstract ERouletteType OnGetRouletteType();

	// Token: 0x060136D3 RID: 79571
	protected abstract bool OnGetCanSwitchType();

	// Token: 0x060136D4 RID: 79572
	protected abstract bool OnGetPanelSwitchOpen();

	// Token: 0x060136D5 RID: 79573 RVA: 0x005AAC08 File Offset: 0x005A8E08
	protected virtual void OnRouletteTypeSwitch()
	{
	}

	// Token: 0x060136D6 RID: 79574
	protected abstract bool OnGetCanOpenAssembly(ERouletteType rouletteType);

	// Token: 0x060136D7 RID: 79575
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	protected abstract List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> OnGetExploreRouletteDataMap();

	// Token: 0x060136D8 RID: 79576
	protected abstract int OnGetRouletteGridId(int index, ERouletteGridType gridType);

	// Token: 0x060136D9 RID: 79577
	protected abstract string OnGetActionName();

	// Token: 0x060136DA RID: 79578 RVA: 0x005AAC0A File Offset: 0x005A8E0A
	protected virtual void OnRefreshTips()
	{
	}

	// Token: 0x060136DB RID: 79579
	protected abstract void OnDestroy();

	// Token: 0x0400A635 RID: 42549
	public ERouletteType RouletteType;

	// Token: 0x0400A636 RID: 42550
	public bool CanSwitchType;

	// Token: 0x0400A637 RID: 42551
	public ERouletteActionType ActionType = ERouletteActionType.Action1;

	// Token: 0x0400A638 RID: 42552
	public int? TouchId;

	// Token: 0x0400A639 RID: 42553
	public RouletteMainView View;
}
