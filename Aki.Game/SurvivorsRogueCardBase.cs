using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002AD1 RID: 10961
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCardBase : UiPanelBase
{
	// Token: 0x06016CCC RID: 93388 RVA: 0x005CA23C File Offset: 0x005C843C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUISprite)),
			new ValueTuple<int, Type>(14, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickLock))
		};
	}

	// Token: 0x06016CCD RID: 93389 RVA: 0x005CA3C8 File Offset: 0x005C85C8
	protected override void OnStart()
	{
		base.GetText(10).SetUIActive(false);
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(8),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.SurvivorsRogue
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		this.AddEvents();
	}

	// Token: 0x06016CCE RID: 93390 RVA: 0x005CA417 File Offset: 0x005C8617
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvents();
	}

	// Token: 0x06016CCF RID: 93391 RVA: 0x005CA420 File Offset: 0x005C8620
	public UniTask Apply(SurvivorsRogueItemCard data)
	{
		SurvivorsRogueCardBase.<Apply>d__12 <Apply>d__;
		<Apply>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Apply>d__.<>4__this = this;
		<Apply>d__.data = data;
		<Apply>d__.<>1__state = -1;
		<Apply>d__.<>t__builder.Start<SurvivorsRogueCardBase.<Apply>d__12>(ref <Apply>d__);
		return <Apply>d__.<>t__builder.Task;
	}

	// Token: 0x06016CD0 RID: 93392 RVA: 0x005CA46C File Offset: 0x005C866C
	public UniTask Apply(SurvivorsRogueCharacterCard data)
	{
		SurvivorsRogueCardBase.<Apply>d__13 <Apply>d__;
		<Apply>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Apply>d__.<>4__this = this;
		<Apply>d__.data = data;
		<Apply>d__.<>1__state = -1;
		<Apply>d__.<>t__builder.Start<SurvivorsRogueCardBase.<Apply>d__13>(ref <Apply>d__);
		return <Apply>d__.<>t__builder.Task;
	}

	// Token: 0x06016CD1 RID: 93393 RVA: 0x005CA4B8 File Offset: 0x005C86B8
	public UniTask Apply(SurvivorsRogueWeaponCard data)
	{
		SurvivorsRogueCardBase.<Apply>d__14 <Apply>d__;
		<Apply>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Apply>d__.<>4__this = this;
		<Apply>d__.data = data;
		<Apply>d__.<>1__state = -1;
		<Apply>d__.<>t__builder.Start<SurvivorsRogueCardBase.<Apply>d__14>(ref <Apply>d__);
		return <Apply>d__.<>t__builder.Task;
	}

	// Token: 0x06016CD2 RID: 93394 RVA: 0x005CA504 File Offset: 0x005C8704
	private UniTask ApplyInternal(SurvivorsRogueCardBaseData data)
	{
		SurvivorsRogueCardBase.<ApplyInternal>d__15 <ApplyInternal>d__;
		<ApplyInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ApplyInternal>d__.<>4__this = this;
		<ApplyInternal>d__.data = data;
		<ApplyInternal>d__.<>1__state = -1;
		<ApplyInternal>d__.<>t__builder.Start<SurvivorsRogueCardBase.<ApplyInternal>d__15>(ref <ApplyInternal>d__);
		return <ApplyInternal>d__.<>t__builder.Task;
	}

	// Token: 0x06016CD3 RID: 93395 RVA: 0x005CA550 File Offset: 0x005C8750
	protected virtual UniTask ApplyCardTypeItem(ISurvivorsRogueItemCard data)
	{
		SurvivorsRogueCardBase.<ApplyCardTypeItem>d__16 <ApplyCardTypeItem>d__;
		<ApplyCardTypeItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ApplyCardTypeItem>d__.<>4__this = this;
		<ApplyCardTypeItem>d__.data = data;
		<ApplyCardTypeItem>d__.<>1__state = -1;
		<ApplyCardTypeItem>d__.<>t__builder.Start<SurvivorsRogueCardBase.<ApplyCardTypeItem>d__16>(ref <ApplyCardTypeItem>d__);
		return <ApplyCardTypeItem>d__.<>t__builder.Task;
	}

	// Token: 0x06016CD4 RID: 93396 RVA: 0x005CA59C File Offset: 0x005C879C
	protected virtual UniTask ApplyCardTypeCharacter(ISurvivorsRogueCharacterCard data)
	{
		SurvivorsRogueCardBase.<ApplyCardTypeCharacter>d__17 <ApplyCardTypeCharacter>d__;
		<ApplyCardTypeCharacter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ApplyCardTypeCharacter>d__.<>4__this = this;
		<ApplyCardTypeCharacter>d__.data = data;
		<ApplyCardTypeCharacter>d__.<>1__state = -1;
		<ApplyCardTypeCharacter>d__.<>t__builder.Start<SurvivorsRogueCardBase.<ApplyCardTypeCharacter>d__17>(ref <ApplyCardTypeCharacter>d__);
		return <ApplyCardTypeCharacter>d__.<>t__builder.Task;
	}

	// Token: 0x06016CD5 RID: 93397 RVA: 0x005CA5E8 File Offset: 0x005C87E8
	protected virtual UniTask ApplyCardTypeWeapon(ISurvivorsRogueWeaponCard data)
	{
		SurvivorsRogueCardBase.<ApplyCardTypeWeapon>d__18 <ApplyCardTypeWeapon>d__;
		<ApplyCardTypeWeapon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ApplyCardTypeWeapon>d__.<>4__this = this;
		<ApplyCardTypeWeapon>d__.data = data;
		<ApplyCardTypeWeapon>d__.<>1__state = -1;
		<ApplyCardTypeWeapon>d__.<>t__builder.Start<SurvivorsRogueCardBase.<ApplyCardTypeWeapon>d__18>(ref <ApplyCardTypeWeapon>d__);
		return <ApplyCardTypeWeapon>d__.<>t__builder.Task;
	}

	// Token: 0x06016CD6 RID: 93398 RVA: 0x005CA634 File Offset: 0x005C8834
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	protected UniTask<SurvivorsRogueCardComponent> RefreshComponent(Type gridClass, bool bNewIfNull, [Nullable(new byte[]
	{
		1,
		2
	})] params object[] args)
	{
		SurvivorsRogueCardBase.<RefreshComponent>d__19 <RefreshComponent>d__;
		<RefreshComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder<SurvivorsRogueCardComponent>.Create();
		<RefreshComponent>d__.<>4__this = this;
		<RefreshComponent>d__.gridClass = gridClass;
		<RefreshComponent>d__.bNewIfNull = bNewIfNull;
		<RefreshComponent>d__.args = args;
		<RefreshComponent>d__.<>1__state = -1;
		<RefreshComponent>d__.<>t__builder.Start<SurvivorsRogueCardBase.<RefreshComponent>d__19>(ref <RefreshComponent>d__);
		return <RefreshComponent>d__.<>t__builder.Task;
	}

	// Token: 0x06016CD7 RID: 93399 RVA: 0x005CA690 File Offset: 0x005C8890
	[return: Nullable(2)]
	private SurvivorsRogueCardComponent GetCardComponent(Type ctor)
	{
		SurvivorsRogueCardComponent result;
		if (!this.ComponentMap.TryGetValue(ctor, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06016CD8 RID: 93400 RVA: 0x005CA6B0 File Offset: 0x005C88B0
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<SurvivorsRogueCardComponent> CreateCardComponent(Type componentClass)
	{
		SurvivorsRogueCardBase.<CreateCardComponent>d__21 <CreateCardComponent>d__;
		<CreateCardComponent>d__.<>t__builder = AsyncUniTaskMethodBuilder<SurvivorsRogueCardComponent>.Create();
		<CreateCardComponent>d__.<>4__this = this;
		<CreateCardComponent>d__.componentClass = componentClass;
		<CreateCardComponent>d__.<>1__state = -1;
		<CreateCardComponent>d__.<>t__builder.Start<SurvivorsRogueCardBase.<CreateCardComponent>d__21>(ref <CreateCardComponent>d__);
		return <CreateCardComponent>d__.<>t__builder.Task;
	}

	// Token: 0x06016CD9 RID: 93401 RVA: 0x005CA6FB File Offset: 0x005C88FB
	private void ClearComponentList()
	{
		this.CenterComponentList.Clear();
		this.BottomComponentList.Clear();
	}

	// Token: 0x06016CDA RID: 93402 RVA: 0x005CA714 File Offset: 0x005C8914
	private void AddToComponentList(SurvivorsRogueCardComponent component)
	{
		ECardMountPos layoutLevel = component.GetLayoutLevel();
		if (layoutLevel == ECardMountPos.Center)
		{
			this.CenterComponentList.Add(component);
			return;
		}
		if (layoutLevel != ECardMountPos.Bottom)
		{
			return;
		}
		this.BottomComponentList.Add(component);
	}

	// Token: 0x06016CDB RID: 93403 RVA: 0x005CA74C File Offset: 0x005C894C
	protected void RefreshComponentHierarchyIndex()
	{
		for (int i = 0; i < this.BottomComponentList.Count; i++)
		{
			SurvivorsRogueCardComponent survivorsRogueCardComponent = this.BottomComponentList[i];
			if (survivorsRogueCardComponent != null)
			{
				UUIItem originalItem = survivorsRogueCardComponent.GetOriginalItem();
				if (originalItem != null)
				{
					originalItem.SetHierarchyIndex(i);
				}
			}
		}
		for (int j = 0; j < this.CenterComponentList.Count; j++)
		{
			SurvivorsRogueCardComponent survivorsRogueCardComponent2 = this.CenterComponentList[j];
			if (survivorsRogueCardComponent2 != null)
			{
				UUIItem originalItem2 = survivorsRogueCardComponent2.GetOriginalItem();
				if (originalItem2 != null)
				{
					originalItem2.SetHierarchyIndex(j);
				}
			}
		}
	}

	// Token: 0x06016CDC RID: 93404 RVA: 0x005CA7CB File Offset: 0x005C89CB
	private void OnComponentVisibleChanged(SurvivorsRogueCardComponent component, bool bVisible)
	{
		if (bVisible)
		{
			this.VisibleComponents.Add(component);
			return;
		}
		this.VisibleComponents.Remove(component);
	}

	// Token: 0x06016CDD RID: 93405 RVA: 0x005CA7EB File Offset: 0x005C89EB
	private void ClearVisibleComponent()
	{
		this.VisibleComponents.Clear();
	}

	// Token: 0x06016CDE RID: 93406 RVA: 0x005CA7F8 File Offset: 0x005C89F8
	protected void RefreshComponentVisible()
	{
		foreach (SurvivorsRogueCardComponent survivorsRogueCardComponent in this.ComponentMap.Values)
		{
			if (!this.VisibleComponents.Contains(survivorsRogueCardComponent))
			{
				survivorsRogueCardComponent.SetActive(false);
			}
		}
	}

	// Token: 0x06016CDF RID: 93407 RVA: 0x005CA860 File Offset: 0x005C8A60
	protected void ApplyBase(ISurvivorsRogueCardBase data)
	{
		this.RefreshBaseDesc(data);
		this.RefreshBaseQuality(data);
		this.RefreshBaseFunc(data);
		this.RefreshLock(data);
		this.RefreshBaseIcon(data);
	}

	// Token: 0x06016CE0 RID: 93408 RVA: 0x005CA888 File Offset: 0x005C8A88
	private void RefreshBaseDesc(ISurvivorsRogueCardBase data)
	{
		UUIText text = base.GetText(7);
		if (data.TitleId != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, data.TitleId, Array.Empty<object>());
		}
		else if (data.TitleText != null)
		{
			text.SetText(data.TitleText, true);
		}
		UUIText text2 = base.GetText(8);
		string[] args = data.DescParams ?? Array.Empty<string>();
		LguiUtil.Instance.SetLocalTextNew(text2, data.DescId, args);
		UUIText text3 = base.GetText(5);
		string text4 = data.TagId;
		if (text4 == null)
		{
			string text5;
			switch (data.Type)
			{
			case ESurvivorsRogueItemType.Normal:
				text5 = "SurvivorsCard_Prop";
				break;
			case ESurvivorsRogueItemType.Weapon:
				text5 = "SurvivorsCard_WeaponUpgrade";
				break;
			case ESurvivorsRogueItemType.Character:
				text5 = "SurvivorsCard_RoleUpgrade";
				break;
			default:
				text5 = "SurvivorsCard_Prop";
				break;
			}
			text4 = text5;
		}
		string textStringId = text4;
		string[] args2 = data.TagParams ?? Array.Empty<string>();
		LguiUtil.Instance.SetLocalTextNew(text3, textStringId, args2);
		base.GetItem(4).SetUIActive(data.TagVisible.GetValueOrDefault(true));
	}

	// Token: 0x06016CE1 RID: 93409 RVA: 0x005CA994 File Offset: 0x005C8B94
	private void RefreshBaseQuality(ISurvivorsRogueCardBase data)
	{
		UUITexture texture = base.GetTexture(1);
		SurvivorsQuality? qualityConfig = SurvivorsRogueConfig.Instance.GetQualityConfig(data.QualityId);
		base.SetTextureByPath((qualityConfig != null) ? qualityConfig.GetValueOrDefault().CardBasePath : null, texture, null, null);
		if (data.IsLevelUp.GetValueOrDefault())
		{
			this.SetSpriteByPath(qualityConfig.Value.LvUpTagPath, base.GetSprite(13), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "SurvivorsCardLvUp", Array.Empty<object>());
		}
		base.GetItem(12).SetUIActive(data.IsLevelUp.GetValueOrDefault());
	}

	// Token: 0x06016CE2 RID: 93410 RVA: 0x005CAA58 File Offset: 0x005C8C58
	private void RefreshBaseFunc(ISurvivorsRogueCardBase data)
	{
		base.GetItem(11).SetUIActive(data.IsLevelUp.GetValueOrDefault());
		this.SetToggleInteractive(data.UseToggle.GetValueOrDefault());
		base.GetText(8).SetBubbleUpToParent(data.UseToggle.GetValueOrDefault());
	}

	// Token: 0x06016CE3 RID: 93411 RVA: 0x005CAAAE File Offset: 0x005C8CAE
	private void RefreshBaseIcon(ISurvivorsRogueCardBase data)
	{
		base.GetTexture(2).SetUIActive(false);
	}

	// Token: 0x06016CE4 RID: 93412 RVA: 0x005CAAC0 File Offset: 0x005C8CC0
	private void RefreshLock(ISurvivorsRogueCardBase data)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		bool valueOrDefault = data.NeedLock.GetValueOrDefault();
		bool valueOrDefault2 = data.LockState.GetValueOrDefault();
		extendToggle.RootUIComp.Get().SetUIActive(valueOrDefault);
		extendToggle.SetToggleStateForce(valueOrDefault2 ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06016CE5 RID: 93413 RVA: 0x005CAB15 File Offset: 0x005C8D15
	public void SetDebugText(string debugTxt)
	{
		base.GetText(10).SetUIActive(false);
	}

	// Token: 0x06016CE6 RID: 93414 RVA: 0x005CAB25 File Offset: 0x005C8D25
	private void OnClickLock(EToggleState toggleState)
	{
		if (this.Data != null && this.LockFunction != null)
		{
			this.LockFunction(this.Data, toggleState == EToggleState.ETT_UnChecked);
		}
	}

	// Token: 0x06016CE7 RID: 93415 RVA: 0x005CAB4C File Offset: 0x005C8D4C
	public void SetLock(bool bLock)
	{
		base.GetExtendToggle(6).SetToggleStateForce(bLock ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06016CE8 RID: 93416 RVA: 0x005CAB64 File Offset: 0x005C8D64
	public void BindLockFunction(Action<ISurvivorsRogueCardBase, bool> lockFunction)
	{
		this.LockFunction = lockFunction;
	}

	// Token: 0x06016CE9 RID: 93417 RVA: 0x005CAB70 File Offset: 0x005C8D70
	private UniTask RefreshCharacterType(ISurvivorsRogueCharacterCard data)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardComponentRoleItem), data.Id > 0, new object[]
		{
			data.Id,
			data.PropertyId
		}).AsUniTask();
	}

	// Token: 0x06016CEA RID: 93418 RVA: 0x005CABC0 File Offset: 0x005C8DC0
	private UniTask RefreshWeaponType(ISurvivorsRogueWeaponCard data)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardComponentWeaponItem), data.Id > 0, new object[]
		{
			data.Id,
			data.QualityId,
			data.PropertyId
		}).AsUniTask();
	}

	// Token: 0x06016CEB RID: 93419 RVA: 0x005CAC20 File Offset: 0x005C8E20
	private UniTask RefreshLvDesc(int? lv, ESurvivorsRogueItemType type)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardComponentLvDesc), lv != null && lv.Value > 0, new object[]
		{
			lv,
			type
		}).AsUniTask();
	}

	// Token: 0x06016CEC RID: 93420 RVA: 0x005CAC74 File Offset: 0x005C8E74
	private UniTask RefreshEvolveBind(int weaponId, bool bShow)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardComponentEvolveBond), bShow, new object[]
		{
			bShow ? weaponId : null
		}).AsUniTask();
	}

	// Token: 0x06016CED RID: 93421 RVA: 0x005CACB0 File Offset: 0x005C8EB0
	public UniTask RefreshCost(int? cost, bool bCreate, bool costCheckEnough)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardCostItem), bCreate, new object[]
		{
			cost,
			costCheckEnough
		}).AsUniTask();
	}

	// Token: 0x06016CEE RID: 93422 RVA: 0x005CACEE File Offset: 0x005C8EEE
	[NullableContext(2)]
	public UUIItem GetTextureIconItem()
	{
		return base.GetTexture(2);
	}

	// Token: 0x06016CEF RID: 93423 RVA: 0x005CACF7 File Offset: 0x005C8EF7
	[NullableContext(2)]
	protected UUIExtendToggle GetCardToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06016CF0 RID: 93424 RVA: 0x005CAD00 File Offset: 0x005C8F00
	protected void AddEvents()
	{
		UUIExtendToggle cardToggle = this.GetCardToggle();
		cardToggle.OnStateChange.Add(new Action<EToggleState>(this.ExtendToggleStateChanged));
		cardToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		cardToggle.OnHover.Add(new Action(this.ExtendToggleOnHover));
		cardToggle.OnUnHover.Add(new Action(this.ExtendToggleOnUnHover));
	}

	// Token: 0x06016CF1 RID: 93425 RVA: 0x005CAD6E File Offset: 0x005C8F6E
	protected void RemoveEvents()
	{
		UUIExtendToggle cardToggle = this.GetCardToggle();
		cardToggle.OnStateChange.Remove(new Action<EToggleState>(this.ExtendToggleStateChanged));
		cardToggle.CanExecuteChange.Unbind();
		cardToggle.OnHover.Clear();
		cardToggle.OnUnHover.Clear();
	}

	// Token: 0x06016CF2 RID: 93426 RVA: 0x005CADAD File Offset: 0x005C8FAD
	private void ExtendToggleStateChanged(EToggleState state)
	{
		this.OnExtendToggleStateChanged(state);
		if (this.OnStateChangedCallback != null && this.Data != null)
		{
			this.OnStateChangedCallback(this.Data, state);
		}
	}

	// Token: 0x06016CF3 RID: 93427 RVA: 0x005CADD8 File Offset: 0x005C8FD8
	protected virtual void OnExtendToggleStateChanged(EToggleState state)
	{
	}

	// Token: 0x06016CF4 RID: 93428 RVA: 0x005CADDA File Offset: 0x005C8FDA
	private bool CanExecuteChange()
	{
		if (this.OnCanExecuteChangeCallback != null && this.Data != null)
		{
			return this.OnCanExecuteChangeCallback(this.Data, this.GetCardToggle().GetToggleState());
		}
		return this.OnCanExecuteChange();
	}

	// Token: 0x06016CF5 RID: 93429 RVA: 0x005CAE0F File Offset: 0x005C900F
	protected virtual bool OnCanExecuteChange()
	{
		return true;
	}

	// Token: 0x06016CF6 RID: 93430 RVA: 0x005CAE12 File Offset: 0x005C9012
	private void ExtendToggleOnHover()
	{
		if (this.OnHoverCallback != null && this.Data != null)
		{
			this.OnHoverCallback(this.Data, this.GetCardToggle().GetToggleState());
		}
	}

	// Token: 0x06016CF7 RID: 93431 RVA: 0x005CAE40 File Offset: 0x005C9040
	private void ExtendToggleOnUnHover()
	{
		if (this.OnUnHoverCallback != null && this.Data != null)
		{
			this.OnUnHoverCallback(this.Data, this.GetCardToggle().GetToggleState());
		}
	}

	// Token: 0x06016CF8 RID: 93432 RVA: 0x005CAE6E File Offset: 0x005C906E
	public void BindOnStateChangeCallback(Action<ISurvivorsRogueCardBase, EToggleState> onStateChangeCallback)
	{
		this.OnStateChangedCallback = onStateChangeCallback;
	}

	// Token: 0x06016CF9 RID: 93433 RVA: 0x005CAE77 File Offset: 0x005C9077
	public void UnBindOnStateChangeCallback()
	{
		this.OnStateChangedCallback = null;
	}

	// Token: 0x06016CFA RID: 93434 RVA: 0x005CAE80 File Offset: 0x005C9080
	public void BindOnCanExecuteChangeCallback(Func<ISurvivorsRogueCardBase, EToggleState, bool> onCanExecuteChangeCallback)
	{
		this.OnCanExecuteChangeCallback = onCanExecuteChangeCallback;
	}

	// Token: 0x06016CFB RID: 93435 RVA: 0x005CAE89 File Offset: 0x005C9089
	public void BindOnHoverCallback(Action<ISurvivorsRogueCardBase, EToggleState> onHoverCallback)
	{
		this.OnHoverCallback = onHoverCallback;
	}

	// Token: 0x06016CFC RID: 93436 RVA: 0x005CAE92 File Offset: 0x005C9092
	public void BindOnUnHoverCallback(Action<ISurvivorsRogueCardBase, EToggleState> onUnHoverCallback)
	{
		this.OnUnHoverCallback = onUnHoverCallback;
	}

	// Token: 0x06016CFD RID: 93437 RVA: 0x005CAE9C File Offset: 0x005C909C
	public void SetSelected(bool bSelected, bool bFireEvent = false, bool bForce = false)
	{
		UUIExtendToggle cardToggle = this.GetCardToggle();
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		if (bForce)
		{
			cardToggle.SetToggleStateForce(state, bFireEvent, false, false);
			return;
		}
		cardToggle.SetToggleState(state, bFireEvent, false, false);
	}

	// Token: 0x06016CFE RID: 93438 RVA: 0x005CAED1 File Offset: 0x005C90D1
	public void SetToggleInteractive(bool bInteractive)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(bInteractive);
	}

	// Token: 0x06016CFF RID: 93439 RVA: 0x005CAEE8 File Offset: 0x005C90E8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams == null || configParams.Length == 0)
		{
			return null;
		}
		SurvivorsRogueCardComponent survivorsRogueCardComponent;
		if (!(configParams[0] == "WeaponEvolve") || !this.ComponentMap.TryGetValue(typeof(SurvivorsRogueCardComponentEvolveBond), out survivorsRogueCardComponent))
		{
			return null;
		}
		UUIItem guideUiItem = survivorsRogueCardComponent.GetGuideUiItem("0");
		if (guideUiItem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			guideUiItem,
			guideUiItem
		};
	}

	// Token: 0x06016D00 RID: 93440 RVA: 0x005CAF48 File Offset: 0x005C9148
	public bool HasBondInfo()
	{
		ISurvivorsRogueWeaponCard survivorsRogueWeaponCard = this.Data as ISurvivorsRogueWeaponCard;
		return ((survivorsRogueWeaponCard != null) ? survivorsRogueWeaponCard.WeaponBondInfo : null).GetValueOrDefault();
	}

	// Token: 0x0400A972 RID: 43378
	[Nullable(2)]
	protected ISurvivorsRogueCardBase Data;

	// Token: 0x0400A973 RID: 43379
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<ISurvivorsRogueCardBase, EToggleState, bool> OnCanExecuteChangeCallback;

	// Token: 0x0400A974 RID: 43380
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ISurvivorsRogueCardBase, EToggleState> OnStateChangedCallback;

	// Token: 0x0400A975 RID: 43381
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ISurvivorsRogueCardBase, EToggleState> OnHoverCallback;

	// Token: 0x0400A976 RID: 43382
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ISurvivorsRogueCardBase, EToggleState> OnUnHoverCallback;

	// Token: 0x0400A977 RID: 43383
	private readonly HashSet<SurvivorsRogueCardComponent> VisibleComponents = new HashSet<SurvivorsRogueCardComponent>();

	// Token: 0x0400A978 RID: 43384
	private readonly Dictionary<Type, SurvivorsRogueCardComponent> ComponentMap = new Dictionary<Type, SurvivorsRogueCardComponent>();

	// Token: 0x0400A979 RID: 43385
	private readonly List<SurvivorsRogueCardComponent> CenterComponentList = new List<SurvivorsRogueCardComponent>();

	// Token: 0x0400A97A RID: 43386
	private readonly List<SurvivorsRogueCardComponent> BottomComponentList = new List<SurvivorsRogueCardComponent>();

	// Token: 0x0400A97B RID: 43387
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<ISurvivorsRogueCardBase, bool> LockFunction;
}
