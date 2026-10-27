using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Roulette.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200293D RID: 10557
[NullableContext(1)]
[Nullable(0)]
public abstract class RouletteMainViewProxyBase
{
	// Token: 0x06015CAE RID: 89262 RVA: 0x0057FA94 File Offset: 0x0057DC94
	public void RegisterView(RouletteMainView view)
	{
		this.View = view;
	}

	// Token: 0x06015CAF RID: 89263 RVA: 0x0057FAA0 File Offset: 0x0057DCA0
	public UniTask BeforeStartAsync()
	{
		RouletteMainViewProxyBase.<BeforeStartAsync>d__6 <BeforeStartAsync>d__;
		<BeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeStartAsync>d__.<>4__this = this;
		<BeforeStartAsync>d__.<>1__state = -1;
		<BeforeStartAsync>d__.<>t__builder.Start<RouletteMainViewProxyBase.<BeforeStartAsync>d__6>(ref <BeforeStartAsync>d__);
		return <BeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015CB0 RID: 89264 RVA: 0x0057FAE3 File Offset: 0x0057DCE3
	public void Start()
	{
		this.RouletteType = this.GetRouletteType();
		this.CanSwitchType = this.GetCanSwitchType();
		this.OnStart();
	}

	// Token: 0x06015CB1 RID: 89265 RVA: 0x0057FB03 File Offset: 0x0057DD03
	public void BeforeShow()
	{
		this.OnBeforeShow();
	}

	// Token: 0x06015CB2 RID: 89266 RVA: 0x0057FB0B File Offset: 0x0057DD0B
	public void AddEventListenerByStart()
	{
		this.OnAddEventListenerByStart();
	}

	// Token: 0x06015CB3 RID: 89267 RVA: 0x0057FB13 File Offset: 0x0057DD13
	public void RemoveEventListenerByStart()
	{
		this.OnRemoveEventListenerByStart();
	}

	// Token: 0x06015CB4 RID: 89268 RVA: 0x0057FB1B File Offset: 0x0057DD1B
	public void AddEventListener()
	{
		this.OnAddEventListener();
	}

	// Token: 0x06015CB5 RID: 89269 RVA: 0x0057FB23 File Offset: 0x0057DD23
	public void RemoveEventListener()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x06015CB6 RID: 89270 RVA: 0x0057FB2B File Offset: 0x0057DD2B
	public bool CanOpenView()
	{
		return this.OnCanOpenView();
	}

	// Token: 0x06015CB7 RID: 89271 RVA: 0x0057FB33 File Offset: 0x0057DD33
	public RouletteComponentMain GetRouletteComponent()
	{
		return this.OnGetRouletteComponent();
	}

	// Token: 0x06015CB8 RID: 89272 RVA: 0x0057FB3B File Offset: 0x0057DD3B
	public ERouletteType GetRouletteType()
	{
		return this.OnGetRouletteType();
	}

	// Token: 0x06015CB9 RID: 89273 RVA: 0x0057FB43 File Offset: 0x0057DD43
	public bool GetCanSwitchType()
	{
		return this.OnGetCanSwitchType();
	}

	// Token: 0x06015CBA RID: 89274 RVA: 0x0057FB4B File Offset: 0x0057DD4B
	public bool GetPanelSwitchOpen()
	{
		return this.OnGetPanelSwitchOpen();
	}

	// Token: 0x06015CBB RID: 89275 RVA: 0x0057FB53 File Offset: 0x0057DD53
	public void RouletteTypeSwitch()
	{
		this.OnRouletteTypeSwitch();
	}

	// Token: 0x06015CBC RID: 89276 RVA: 0x0057FB5C File Offset: 0x0057DD5C
	public virtual EToggleState? GetToggle1State()
	{
		return null;
	}

	// Token: 0x06015CBD RID: 89277 RVA: 0x0057FB74 File Offset: 0x0057DD74
	public virtual EToggleState? GetToggle2State()
	{
		return null;
	}

	// Token: 0x06015CBE RID: 89278 RVA: 0x0057FB8A File Offset: 0x0057DD8A
	public bool GetCanOpenAssembly(ERouletteType rouletteType)
	{
		return this.OnGetCanOpenAssembly(rouletteType);
	}

	// Token: 0x06015CBF RID: 89279 RVA: 0x0057FB93 File Offset: 0x0057DD93
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

	// Token: 0x06015CC0 RID: 89280 RVA: 0x0057FB9B File Offset: 0x0057DD9B
	public int GetRouletteGridId(int index, ERouletteGridType gridType)
	{
		return this.OnGetRouletteGridId(index, gridType);
	}

	// Token: 0x06015CC1 RID: 89281 RVA: 0x0057FBA5 File Offset: 0x0057DDA5
	public string GetActionName()
	{
		return this.OnGetActionName();
	}

	// Token: 0x06015CC2 RID: 89282 RVA: 0x0057FBAD File Offset: 0x0057DDAD
	public void RefreshTips()
	{
		this.OnRefreshTips();
	}

	// Token: 0x06015CC3 RID: 89283 RVA: 0x0057FBB5 File Offset: 0x0057DDB5
	public void Destroy()
	{
		this.OnDestroy();
	}

	// Token: 0x06015CC4 RID: 89284 RVA: 0x0057FBBD File Offset: 0x0057DDBD
	protected virtual UniTask OnBeforeStartAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06015CC5 RID: 89285 RVA: 0x0057FBC4 File Offset: 0x0057DDC4
	protected virtual void OnStart()
	{
	}

	// Token: 0x06015CC6 RID: 89286 RVA: 0x0057FBC6 File Offset: 0x0057DDC6
	protected virtual void OnBeforeShow()
	{
	}

	// Token: 0x06015CC7 RID: 89287 RVA: 0x0057FBC8 File Offset: 0x0057DDC8
	protected virtual void OnAddEventListenerByStart()
	{
	}

	// Token: 0x06015CC8 RID: 89288 RVA: 0x0057FBCA File Offset: 0x0057DDCA
	protected virtual void OnRemoveEventListenerByStart()
	{
	}

	// Token: 0x06015CC9 RID: 89289 RVA: 0x0057FBCC File Offset: 0x0057DDCC
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x06015CCA RID: 89290 RVA: 0x0057FBCE File Offset: 0x0057DDCE
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x06015CCB RID: 89291
	protected abstract bool OnCanOpenView();

	// Token: 0x06015CCC RID: 89292
	protected abstract RouletteComponentMain OnGetRouletteComponent();

	// Token: 0x06015CCD RID: 89293
	protected abstract ERouletteType OnGetRouletteType();

	// Token: 0x06015CCE RID: 89294
	protected abstract bool OnGetCanSwitchType();

	// Token: 0x06015CCF RID: 89295
	protected abstract bool OnGetPanelSwitchOpen();

	// Token: 0x06015CD0 RID: 89296 RVA: 0x0057FBD0 File Offset: 0x0057DDD0
	protected virtual void OnRouletteTypeSwitch()
	{
	}

	// Token: 0x06015CD1 RID: 89297
	protected abstract bool OnGetCanOpenAssembly(ERouletteType rouletteType);

	// Token: 0x06015CD2 RID: 89298
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	protected abstract List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> OnGetExploreRouletteDataMap();

	// Token: 0x06015CD3 RID: 89299
	protected abstract int OnGetRouletteGridId(int index, ERouletteGridType gridType);

	// Token: 0x06015CD4 RID: 89300
	protected abstract string OnGetActionName();

	// Token: 0x06015CD5 RID: 89301 RVA: 0x0057FBD2 File Offset: 0x0057DDD2
	protected virtual void OnRefreshTips()
	{
	}

	// Token: 0x06015CD6 RID: 89302
	protected abstract void OnDestroy();

	// Token: 0x0400A24A RID: 41546
	public ERouletteType RouletteType;

	// Token: 0x0400A24B RID: 41547
	public bool CanSwitchType;

	// Token: 0x0400A24C RID: 41548
	public ERouletteActionType ActionType = ERouletteActionType.Action1;

	// Token: 0x0400A24D RID: 41549
	public int? TouchId;

	// Token: 0x0400A24E RID: 41550
	public RouletteMainView View;
}
