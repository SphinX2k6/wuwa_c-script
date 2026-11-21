using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EA2 RID: 7842
[NullableContext(1)]
[Nullable(0)]
public class RouletteGridBase : UiPanelBase
{
	// Token: 0x060135ED RID: 79341 RVA: 0x005A7224 File Offset: 0x005A5424
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggleSpriteTransition)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
	}

	// Token: 0x060135EE RID: 79342 RVA: 0x005A7348 File Offset: 0x005A5548
	protected override void OnStart()
	{
		this.IsIconTexture = false;
		ULGUIBehaviour uiExtendToggleSpriteTransition = base.GetUiExtendToggleSpriteTransition(5);
		UUITexture texture = base.GetTexture(2);
		uiExtendToggleSpriteTransition.RootUIComp.Get().SetUIActive(false);
		texture.SetUIActive(false);
		this.Toggle = base.GetExtendToggle(0);
		this.Toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
		this.SetGridEquipped(false);
		this.SetRedDotVisible(false);
	}

	// Token: 0x060135EF RID: 79343 RVA: 0x005A73CC File Offset: 0x005A55CC
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
		this.Data = null;
		UUIExtendToggle toggle = this.Toggle;
		if (toggle != null)
		{
			toggle.CanExecuteChange.Unbind();
		}
		this.Toggle = null;
	}

	// Token: 0x060135F0 RID: 79344 RVA: 0x005A73F8 File Offset: 0x005A55F8
	protected virtual UniTask Init()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x060135F1 RID: 79345 RVA: 0x005A73FF File Offset: 0x005A55FF
	public bool IsDataValid()
	{
		return this.Data != null && this.Data.Id != 0;
	}

	// Token: 0x060135F2 RID: 79346 RVA: 0x005A741C File Offset: 0x005A561C
	public void RefreshGrid(RouletteData data)
	{
		this.Data = data;
		this.HideBeforeRefreshState();
		UiAsyncTask task = new UiAsyncTask("RouletteGridBase.RefreshGrid", delegate()
		{
			RouletteGridBase.<<RefreshGrid>b__9_0>d <<RefreshGrid>b__9_0>d;
			<<RefreshGrid>b__9_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshGrid>b__9_0>d.<>4__this = this;
			<<RefreshGrid>b__9_0>d.<>1__state = -1;
			<<RefreshGrid>b__9_0>d.<>t__builder.Start<RouletteGridBase.<<RefreshGrid>b__9_0>d>(ref <<RefreshGrid>b__9_0>d);
			return <<RefreshGrid>b__9_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060135F3 RID: 79347 RVA: 0x005A7458 File Offset: 0x005A5658
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(this.RedDotName.Value, item, null, uId);
		}
	}

	// Token: 0x060135F4 RID: 79348 RVA: 0x005A74AC File Offset: 0x005A56AC
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(11);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
			this.RedDotName = null;
		}
	}

	// Token: 0x060135F5 RID: 79349 RVA: 0x005A74F2 File Offset: 0x005A56F2
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(11).SetUIActive(bVisible);
	}

	// Token: 0x060135F6 RID: 79350 RVA: 0x005A7504 File Offset: 0x005A5704
	protected UUIItem GetIconItem(bool? isTexture = null)
	{
		if (isTexture ?? this.IsIconTexture)
		{
			return base.GetTexture(2);
		}
		return base.GetUiExtendToggleSpriteTransition(5).RootUIComp.Get();
	}

	// Token: 0x060135F7 RID: 79351 RVA: 0x005A754C File Offset: 0x005A574C
	protected UniTask LoadSpriteIcon(string path)
	{
		RouletteGridBase.<LoadSpriteIcon>d__14 <LoadSpriteIcon>d__;
		<LoadSpriteIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadSpriteIcon>d__.<>4__this = this;
		<LoadSpriteIcon>d__.path = path;
		<LoadSpriteIcon>d__.<>1__state = -1;
		<LoadSpriteIcon>d__.<>t__builder.Start<RouletteGridBase.<LoadSpriteIcon>d__14>(ref <LoadSpriteIcon>d__);
		return <LoadSpriteIcon>d__.<>t__builder.Task;
	}

	// Token: 0x060135F8 RID: 79352 RVA: 0x005A7598 File Offset: 0x005A5798
	protected UniTask LoadTextureIcon(string path)
	{
		RouletteGridBase.<LoadTextureIcon>d__15 <LoadTextureIcon>d__;
		<LoadTextureIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadTextureIcon>d__.<>4__this = this;
		<LoadTextureIcon>d__.path = path;
		<LoadTextureIcon>d__.<>1__state = -1;
		<LoadTextureIcon>d__.<>t__builder.Start<RouletteGridBase.<LoadTextureIcon>d__15>(ref <LoadTextureIcon>d__);
		return <LoadTextureIcon>d__.<>t__builder.Task;
	}

	// Token: 0x060135F9 RID: 79353 RVA: 0x005A75E4 File Offset: 0x005A57E4
	protected UniTask LoadIconByItemId(int itemId)
	{
		RouletteGridBase.<LoadIconByItemId>d__16 <LoadIconByItemId>d__;
		<LoadIconByItemId>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadIconByItemId>d__.<>4__this = this;
		<LoadIconByItemId>d__.itemId = itemId;
		<LoadIconByItemId>d__.<>1__state = -1;
		<LoadIconByItemId>d__.<>t__builder.Start<RouletteGridBase.<LoadIconByItemId>d__16>(ref <LoadIconByItemId>d__);
		return <LoadIconByItemId>d__.<>t__builder.Task;
	}

	// Token: 0x060135FA RID: 79354 RVA: 0x005A7630 File Offset: 0x005A5830
	private void HideBeforeRefreshState()
	{
		base.GetItem(1).SetUIActive(false);
		base.GetItem(4).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		base.GetText(10).SetUIActive(false);
		this.GetIconItem(new bool?(true)).SetUIActive(false);
		this.GetIconItem(new bool?(false)).SetUIActive(false);
	}

	// Token: 0x060135FB RID: 79355 RVA: 0x005A7698 File Offset: 0x005A5898
	private void RefreshGridState()
	{
		if (this.Data == null)
		{
			return;
		}
		EGridBehavior state = this.Data.State;
		if (state == EGridBehavior.NotShow)
		{
			this.SetActive(false);
			return;
		}
		base.GetItem(1).SetUIActive(state == EGridBehavior.CanAdd);
		base.GetItem(4).SetUIActive(state == EGridBehavior.Forbidden);
		bool showIndex = this.Data.ShowIndex;
		base.GetItem(8).SetUIActive(showIndex);
		if (showIndex)
		{
			string newText = (this.Data.GridIndex + 1).ToString();
			base.GetText(9).SetText(newText, true);
		}
		base.GetText(10).SetUIActive(this.Data.ShowNum);
		if (this.Data.ShowNum)
		{
			base.GetText(10).SetText(this.Data.DataNum.ToString(), true);
		}
		this.GetIconItem(new bool?(!this.IsIconTexture)).SetUIActive(false);
		this.GetIconItem(new bool?(this.IsIconTexture)).SetUIActive(state == EGridBehavior.Normal || state == EGridBehavior.Forbidden || state == EGridBehavior.Lock);
	}

	// Token: 0x060135FC RID: 79356 RVA: 0x005A77A8 File Offset: 0x005A59A8
	public void SetGridEquipped(bool bSelect)
	{
		base.GetItem(3).SetUIActive(bSelect);
	}

	// Token: 0x060135FD RID: 79357 RVA: 0x005A77B7 File Offset: 0x005A59B7
	public void BindOnCanToggleExecuteChange(Func<RouletteData, EToggleState, bool> onItemClicked)
	{
		this.OnCanToggleClicked = onItemClicked;
	}

	// Token: 0x060135FE RID: 79358 RVA: 0x005A77C0 File Offset: 0x005A59C0
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.Data == null || this.Toggle == null || this.OnCanToggleClicked(this.Data, this.Toggle.GetToggleState());
	}

	// Token: 0x060135FF RID: 79359 RVA: 0x005A77F8 File Offset: 0x005A59F8
	private void SetRouletteGridSelectEvent(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.Data != null)
		{
			EventSystem.Instance.Emit<RouletteData>(EEventName.OnRouletteItemSelect, this.Data);
		}
	}

	// Token: 0x06013600 RID: 79360 RVA: 0x005A781C File Offset: 0x005A5A1C
	private void SetGridEmitEquipRing(EToggleState state)
	{
		this.SetGridEquipped(state == EToggleState.ETT_Checked);
	}

	// Token: 0x06013601 RID: 79361 RVA: 0x005A7828 File Offset: 0x005A5A28
	public void AddToggleStateChangeEvent(Action<EToggleState> eventHandler)
	{
		this.Toggle.OnStateChange.Add(eventHandler);
	}

	// Token: 0x06013602 RID: 79362 RVA: 0x005A783B File Offset: 0x005A5A3B
	public void RemoveToggleStateChangeEvent(Action<EToggleState> eventHandler)
	{
		this.Toggle.OnStateChange.Remove(eventHandler);
	}

	// Token: 0x06013603 RID: 79363 RVA: 0x005A784E File Offset: 0x005A5A4E
	public void SetGridToggleChangeEvent()
	{
		this.AddToggleStateChangeEvent(new Action<EToggleState>(this.SetRouletteGridSelectEvent));
		this.AddToggleStateChangeEvent(new Action<EToggleState>(this.SetGridEmitEquipRing));
	}

	// Token: 0x06013604 RID: 79364 RVA: 0x005A7874 File Offset: 0x005A5A74
	public void RemoveGridToggleChangeEvent()
	{
		this.RemoveToggleStateChangeEvent(new Action<EToggleState>(this.SetRouletteGridSelectEvent));
		this.RemoveToggleStateChangeEvent(new Action<EToggleState>(this.SetGridEmitEquipRing));
	}

	// Token: 0x06013605 RID: 79365 RVA: 0x005A789A File Offset: 0x005A5A9A
	public void SetToggleSelfInteractive(bool bActive)
	{
		this.Toggle.SetSelfInteractive(bActive);
	}

	// Token: 0x06013606 RID: 79366 RVA: 0x005A78A8 File Offset: 0x005A5AA8
	public void SetGridToggleState(bool bSelect, bool bFireEvent = true)
	{
		EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.Toggle.SetToggleState(state, bFireEvent, false, false);
	}

	// Token: 0x06013607 RID: 79367 RVA: 0x005A78CD File Offset: 0x005A5ACD
	public void SetGridToggleNavigation(bool bSelect)
	{
		if (bSelect)
		{
			UiNavigationNewController.Instance.SetNavigationFocusForView(this.RootItem, false, false, false);
		}
	}

	// Token: 0x06013608 RID: 79368 RVA: 0x005A78E6 File Offset: 0x005A5AE6
	public void SelectOnGrid(bool bSelect)
	{
		this.OnSelect(bSelect);
	}

	// Token: 0x06013609 RID: 79369 RVA: 0x005A78EF File Offset: 0x005A5AEF
	protected virtual void OnSelect(bool bSelect)
	{
	}

	// Token: 0x0400A5DA RID: 42458
	[Nullable(2)]
	public RouletteData Data;

	// Token: 0x0400A5DB RID: 42459
	[Nullable(2)]
	protected UUIExtendToggle Toggle;

	// Token: 0x0400A5DC RID: 42460
	protected bool IsIconTexture;

	// Token: 0x0400A5DD RID: 42461
	private ERedDotName? RedDotName;

	// Token: 0x0400A5DE RID: 42462
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<RouletteData, EToggleState, bool> OnCanToggleClicked;
}
