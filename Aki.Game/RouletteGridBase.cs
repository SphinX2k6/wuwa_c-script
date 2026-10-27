using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002927 RID: 10535
[NullableContext(1)]
[Nullable(0)]
public class RouletteGridBase : UiPanelBase
{
	// Token: 0x06015BE8 RID: 89064 RVA: 0x0057C1E4 File Offset: 0x0057A3E4
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

	// Token: 0x06015BE9 RID: 89065 RVA: 0x0057C308 File Offset: 0x0057A508
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

	// Token: 0x06015BEA RID: 89066 RVA: 0x0057C38C File Offset: 0x0057A58C
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

	// Token: 0x06015BEB RID: 89067 RVA: 0x0057C3B8 File Offset: 0x0057A5B8
	protected virtual UniTask Init()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x06015BEC RID: 89068 RVA: 0x0057C3BF File Offset: 0x0057A5BF
	public bool IsDataValid()
	{
		return this.Data != null && this.Data.Id != 0;
	}

	// Token: 0x06015BED RID: 89069 RVA: 0x0057C3DC File Offset: 0x0057A5DC
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

	// Token: 0x06015BEE RID: 89070 RVA: 0x0057C418 File Offset: 0x0057A618
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

	// Token: 0x06015BEF RID: 89071 RVA: 0x0057C46C File Offset: 0x0057A66C
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(11);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, 0);
			this.RedDotName = null;
		}
	}

	// Token: 0x06015BF0 RID: 89072 RVA: 0x0057C4B2 File Offset: 0x0057A6B2
	public void SetRedDotVisible(bool bVisible)
	{
		base.GetItem(11).SetUIActive(bVisible);
	}

	// Token: 0x06015BF1 RID: 89073 RVA: 0x0057C4C4 File Offset: 0x0057A6C4
	protected UUIItem GetIconItem(bool? isTexture = null)
	{
		if (isTexture ?? this.IsIconTexture)
		{
			return base.GetTexture(2);
		}
		return base.GetUiExtendToggleSpriteTransition(5).RootUIComp.Get();
	}

	// Token: 0x06015BF2 RID: 89074 RVA: 0x0057C50C File Offset: 0x0057A70C
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

	// Token: 0x06015BF3 RID: 89075 RVA: 0x0057C558 File Offset: 0x0057A758
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

	// Token: 0x06015BF4 RID: 89076 RVA: 0x0057C5A4 File Offset: 0x0057A7A4
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

	// Token: 0x06015BF5 RID: 89077 RVA: 0x0057C5F0 File Offset: 0x0057A7F0
	private void HideBeforeRefreshState()
	{
		base.GetItem(1).SetUIActive(false);
		base.GetItem(4).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		base.GetText(10).SetUIActive(false);
		this.GetIconItem(new bool?(true)).SetUIActive(false);
		this.GetIconItem(new bool?(false)).SetUIActive(false);
	}

	// Token: 0x06015BF6 RID: 89078 RVA: 0x0057C658 File Offset: 0x0057A858
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

	// Token: 0x06015BF7 RID: 89079 RVA: 0x0057C768 File Offset: 0x0057A968
	public void SetGridEquipped(bool bSelect)
	{
		base.GetItem(3).SetUIActive(bSelect);
	}

	// Token: 0x06015BF8 RID: 89080 RVA: 0x0057C777 File Offset: 0x0057A977
	public void BindOnCanToggleExecuteChange(Func<RouletteData, EToggleState, bool> onItemClicked)
	{
		this.OnCanToggleClicked = onItemClicked;
	}

	// Token: 0x06015BF9 RID: 89081 RVA: 0x0057C780 File Offset: 0x0057A980
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.Data == null || this.Toggle == null || this.OnCanToggleClicked(this.Data, this.Toggle.GetToggleState());
	}

	// Token: 0x06015BFA RID: 89082 RVA: 0x0057C7B8 File Offset: 0x0057A9B8
	private void SetRouletteGridSelectEvent(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked && this.Data != null)
		{
			EventSystem.Instance.Emit<RouletteData>(EEventName.OnRouletteItemSelect, this.Data);
		}
	}

	// Token: 0x06015BFB RID: 89083 RVA: 0x0057C7DC File Offset: 0x0057A9DC
	private void SetGridEmitEquipRing(EToggleState state)
	{
		this.SetGridEquipped(state == EToggleState.ETT_Checked);
	}

	// Token: 0x06015BFC RID: 89084 RVA: 0x0057C7E8 File Offset: 0x0057A9E8
	public void AddToggleStateChangeEvent(Action<EToggleState> eventHandler)
	{
		this.Toggle.OnStateChange.Add(eventHandler);
	}

	// Token: 0x06015BFD RID: 89085 RVA: 0x0057C7FB File Offset: 0x0057A9FB
	public void RemoveToggleStateChangeEvent(Action<EToggleState> eventHandler)
	{
		this.Toggle.OnStateChange.Remove(eventHandler);
	}

	// Token: 0x06015BFE RID: 89086 RVA: 0x0057C80E File Offset: 0x0057AA0E
	public void SetGridToggleChangeEvent()
	{
		this.AddToggleStateChangeEvent(new Action<EToggleState>(this.SetRouletteGridSelectEvent));
		this.AddToggleStateChangeEvent(new Action<EToggleState>(this.SetGridEmitEquipRing));
	}

	// Token: 0x06015BFF RID: 89087 RVA: 0x0057C834 File Offset: 0x0057AA34
	public void RemoveGridToggleChangeEvent()
	{
		this.RemoveToggleStateChangeEvent(new Action<EToggleState>(this.SetRouletteGridSelectEvent));
		this.RemoveToggleStateChangeEvent(new Action<EToggleState>(this.SetGridEmitEquipRing));
	}

	// Token: 0x06015C00 RID: 89088 RVA: 0x0057C85A File Offset: 0x0057AA5A
	public void SetToggleSelfInteractive(bool bActive)
	{
		this.Toggle.SetSelfInteractive(bActive);
	}

	// Token: 0x06015C01 RID: 89089 RVA: 0x0057C868 File Offset: 0x0057AA68
	public void SetGridToggleState(bool bSelect, bool bFireEvent = true)
	{
		EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.Toggle.SetToggleState(state, bFireEvent, false, false);
	}

	// Token: 0x06015C02 RID: 89090 RVA: 0x0057C88D File Offset: 0x0057AA8D
	public void SetGridToggleNavigation(bool bSelect)
	{
		if (bSelect)
		{
			UiNavigationNewController.Instance.SetNavigationFocusForView(this.RootItem, false, false, false);
		}
	}

	// Token: 0x06015C03 RID: 89091 RVA: 0x0057C8A6 File Offset: 0x0057AAA6
	public void SelectOnGrid(bool bSelect)
	{
		this.OnSelect(bSelect);
	}

	// Token: 0x06015C04 RID: 89092 RVA: 0x0057C8AF File Offset: 0x0057AAAF
	protected virtual void OnSelect(bool bSelect)
	{
	}

	// Token: 0x0400A1EF RID: 41455
	[Nullable(2)]
	public RouletteData Data;

	// Token: 0x0400A1F0 RID: 41456
	[Nullable(2)]
	protected UUIExtendToggle Toggle;

	// Token: 0x0400A1F1 RID: 41457
	protected bool IsIconTexture;

	// Token: 0x0400A1F2 RID: 41458
	private ERedDotName? RedDotName;

	// Token: 0x0400A1F3 RID: 41459
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<RouletteData, EToggleState, bool> OnCanToggleClicked;
}
