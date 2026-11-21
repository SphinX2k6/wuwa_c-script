using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200204D RID: 8269
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCardBase : UiPanelBase
{
	// Token: 0x060146FD RID: 83709 RVA: 0x005F6D90 File Offset: 0x005F4F90
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

	// Token: 0x060146FE RID: 83710 RVA: 0x005F6F1C File Offset: 0x005F511C
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

	// Token: 0x060146FF RID: 83711 RVA: 0x005F6F6B File Offset: 0x005F516B
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvents();
	}

	// Token: 0x06014700 RID: 83712 RVA: 0x005F6F74 File Offset: 0x005F5174
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

	// Token: 0x06014701 RID: 83713 RVA: 0x005F6FC0 File Offset: 0x005F51C0
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

	// Token: 0x06014702 RID: 83714 RVA: 0x005F700C File Offset: 0x005F520C
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

	// Token: 0x06014703 RID: 83715 RVA: 0x005F7058 File Offset: 0x005F5258
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

	// Token: 0x06014704 RID: 83716 RVA: 0x005F70A4 File Offset: 0x005F52A4
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

	// Token: 0x06014705 RID: 83717 RVA: 0x005F70F0 File Offset: 0x005F52F0
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

	// Token: 0x06014706 RID: 83718 RVA: 0x005F713C File Offset: 0x005F533C
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

	// Token: 0x06014707 RID: 83719 RVA: 0x005F7188 File Offset: 0x005F5388
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

	// Token: 0x06014708 RID: 83720 RVA: 0x005F71E4 File Offset: 0x005F53E4
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

	// Token: 0x06014709 RID: 83721 RVA: 0x005F7204 File Offset: 0x005F5404
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

	// Token: 0x0601470A RID: 83722 RVA: 0x005F724F File Offset: 0x005F544F
	private void ClearComponentList()
	{
		this.CenterComponentList.Clear();
		this.BottomComponentList.Clear();
	}

	// Token: 0x0601470B RID: 83723 RVA: 0x005F7268 File Offset: 0x005F5468
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

	// Token: 0x0601470C RID: 83724 RVA: 0x005F72A0 File Offset: 0x005F54A0
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

	// Token: 0x0601470D RID: 83725 RVA: 0x005F731F File Offset: 0x005F551F
	private void OnComponentVisibleChanged(SurvivorsRogueCardComponent component, bool bVisible)
	{
		if (bVisible)
		{
			this.VisibleComponents.Add(component);
			return;
		}
		this.VisibleComponents.Remove(component);
	}

	// Token: 0x0601470E RID: 83726 RVA: 0x005F733F File Offset: 0x005F553F
	private void ClearVisibleComponent()
	{
		this.VisibleComponents.Clear();
	}

	// Token: 0x0601470F RID: 83727 RVA: 0x005F734C File Offset: 0x005F554C
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

	// Token: 0x06014710 RID: 83728 RVA: 0x005F73B4 File Offset: 0x005F55B4
	protected void ApplyBase(ISurvivorsRogueCardBase data)
	{
		this.RefreshBaseDesc(data);
		this.RefreshBaseQuality(data);
		this.RefreshBaseFunc(data);
		this.RefreshLock(data);
		this.RefreshBaseIcon(data);
	}

	// Token: 0x06014711 RID: 83729 RVA: 0x005F73DC File Offset: 0x005F55DC
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

	// Token: 0x06014712 RID: 83730 RVA: 0x005F74E8 File Offset: 0x005F56E8
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

	// Token: 0x06014713 RID: 83731 RVA: 0x005F75AC File Offset: 0x005F57AC
	private void RefreshBaseFunc(ISurvivorsRogueCardBase data)
	{
		base.GetItem(11).SetUIActive(data.IsLevelUp.GetValueOrDefault());
		this.SetToggleInteractive(data.UseToggle.GetValueOrDefault());
		base.GetText(8).SetBubbleUpToParent(data.UseToggle.GetValueOrDefault());
	}

	// Token: 0x06014714 RID: 83732 RVA: 0x005F7602 File Offset: 0x005F5802
	private void RefreshBaseIcon(ISurvivorsRogueCardBase data)
	{
		base.GetTexture(2).SetUIActive(false);
	}

	// Token: 0x06014715 RID: 83733 RVA: 0x005F7614 File Offset: 0x005F5814
	private void RefreshLock(ISurvivorsRogueCardBase data)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		bool valueOrDefault = data.NeedLock.GetValueOrDefault();
		bool valueOrDefault2 = data.LockState.GetValueOrDefault();
		extendToggle.RootUIComp.Get().SetUIActive(valueOrDefault);
		extendToggle.SetToggleStateForce(valueOrDefault2 ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06014716 RID: 83734 RVA: 0x005F7669 File Offset: 0x005F5869
	public void SetDebugText(string debugTxt)
	{
		base.GetText(10).SetUIActive(false);
	}

	// Token: 0x06014717 RID: 83735 RVA: 0x005F7679 File Offset: 0x005F5879
	private void OnClickLock(EToggleState toggleState)
	{
		if (this.Data != null && this.LockFunction != null)
		{
			this.LockFunction(this.Data, toggleState == EToggleState.ETT_UnChecked);
		}
	}

	// Token: 0x06014718 RID: 83736 RVA: 0x005F76A0 File Offset: 0x005F58A0
	public void SetLock(bool bLock)
	{
		base.GetExtendToggle(6).SetToggleStateForce(bLock ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06014719 RID: 83737 RVA: 0x005F76B8 File Offset: 0x005F58B8
	public void BindLockFunction(Action<ISurvivorsRogueCardBase, bool> lockFunction)
	{
		this.LockFunction = lockFunction;
	}

	// Token: 0x0601471A RID: 83738 RVA: 0x005F76C4 File Offset: 0x005F58C4
	private UniTask RefreshCharacterType(ISurvivorsRogueCharacterCard data)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardComponentRoleItem), data.Id > 0, new object[]
		{
			data.Id,
			data.PropertyId
		}).AsUniTask();
	}

	// Token: 0x0601471B RID: 83739 RVA: 0x005F7714 File Offset: 0x005F5914
	private UniTask RefreshWeaponType(ISurvivorsRogueWeaponCard data)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardComponentWeaponItem), data.Id > 0, new object[]
		{
			data.Id,
			data.QualityId,
			data.PropertyId
		}).AsUniTask();
	}

	// Token: 0x0601471C RID: 83740 RVA: 0x005F7774 File Offset: 0x005F5974
	private UniTask RefreshLvDesc(int? lv, ESurvivorsRogueItemType type)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardComponentLvDesc), lv != null && lv.Value > 0, new object[]
		{
			lv,
			type
		}).AsUniTask();
	}

	// Token: 0x0601471D RID: 83741 RVA: 0x005F77C8 File Offset: 0x005F59C8
	private UniTask RefreshEvolveBind(int weaponId, bool bShow)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardComponentEvolveBond), bShow, new object[]
		{
			bShow ? weaponId : null
		}).AsUniTask();
	}

	// Token: 0x0601471E RID: 83742 RVA: 0x005F7804 File Offset: 0x005F5A04
	public UniTask RefreshCost(int? cost, bool bCreate, bool costCheckEnough)
	{
		return this.RefreshComponent(typeof(SurvivorsRogueCardCostItem), bCreate, new object[]
		{
			cost,
			costCheckEnough
		}).AsUniTask();
	}

	// Token: 0x0601471F RID: 83743 RVA: 0x005F7842 File Offset: 0x005F5A42
	[NullableContext(2)]
	public UUIItem GetTextureIconItem()
	{
		return base.GetTexture(2);
	}

	// Token: 0x06014720 RID: 83744 RVA: 0x005F784B File Offset: 0x005F5A4B
	[NullableContext(2)]
	protected UUIExtendToggle GetCardToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06014721 RID: 83745 RVA: 0x005F7854 File Offset: 0x005F5A54
	protected void AddEvents()
	{
		UUIExtendToggle cardToggle = this.GetCardToggle();
		cardToggle.OnStateChange.Add(new Action<EToggleState>(this.ExtendToggleStateChanged));
		cardToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		cardToggle.OnHover.Add(new Action(this.ExtendToggleOnHover));
		cardToggle.OnUnHover.Add(new Action(this.ExtendToggleOnUnHover));
	}

	// Token: 0x06014722 RID: 83746 RVA: 0x005F78C2 File Offset: 0x005F5AC2
	protected void RemoveEvents()
	{
		UUIExtendToggle cardToggle = this.GetCardToggle();
		cardToggle.OnStateChange.Remove(new Action<EToggleState>(this.ExtendToggleStateChanged));
		cardToggle.CanExecuteChange.Unbind();
		cardToggle.OnHover.Clear();
		cardToggle.OnUnHover.Clear();
	}

	// Token: 0x06014723 RID: 83747 RVA: 0x005F7901 File Offset: 0x005F5B01
	private void ExtendToggleStateChanged(EToggleState state)
	{
		this.OnExtendToggleStateChanged(state);
		if (this.OnStateChangedCallback != null && this.Data != null)
		{
			this.OnStateChangedCallback(this.Data, state);
		}
	}

	// Token: 0x06014724 RID: 83748 RVA: 0x005F792C File Offset: 0x005F5B2C
	protected virtual void OnExtendToggleStateChanged(EToggleState state)
	{
	}

	// Token: 0x06014725 RID: 83749 RVA: 0x005F792E File Offset: 0x005F5B2E
	private bool CanExecuteChange()
	{
		if (this.OnCanExecuteChangeCallback != null && this.Data != null)
		{
			return this.OnCanExecuteChangeCallback(this.Data, this.GetCardToggle().GetToggleState());
		}
		return this.OnCanExecuteChange();
	}

	// Token: 0x06014726 RID: 83750 RVA: 0x005F7963 File Offset: 0x005F5B63
	protected virtual bool OnCanExecuteChange()
	{
		return true;
	}

	// Token: 0x06014727 RID: 83751 RVA: 0x005F7966 File Offset: 0x005F5B66
	private void ExtendToggleOnHover()
	{
		if (this.OnHoverCallback != null && this.Data != null)
		{
			this.OnHoverCallback(this.Data, this.GetCardToggle().GetToggleState());
		}
	}

	// Token: 0x06014728 RID: 83752 RVA: 0x005F7994 File Offset: 0x005F5B94
	private void ExtendToggleOnUnHover()
	{
		if (this.OnUnHoverCallback != null && this.Data != null)
		{
			this.OnUnHoverCallback(this.Data, this.GetCardToggle().GetToggleState());
		}
	}

	// Token: 0x06014729 RID: 83753 RVA: 0x005F79C2 File Offset: 0x005F5BC2
	public void BindOnStateChangeCallback(Action<ISurvivorsRogueCardBase, EToggleState> onStateChangeCallback)
	{
		this.OnStateChangedCallback = onStateChangeCallback;
	}

	// Token: 0x0601472A RID: 83754 RVA: 0x005F79CB File Offset: 0x005F5BCB
	public void UnBindOnStateChangeCallback()
	{
		this.OnStateChangedCallback = null;
	}

	// Token: 0x0601472B RID: 83755 RVA: 0x005F79D4 File Offset: 0x005F5BD4
	public void BindOnCanExecuteChangeCallback(Func<ISurvivorsRogueCardBase, EToggleState, bool> onCanExecuteChangeCallback)
	{
		this.OnCanExecuteChangeCallback = onCanExecuteChangeCallback;
	}

	// Token: 0x0601472C RID: 83756 RVA: 0x005F79DD File Offset: 0x005F5BDD
	public void BindOnHoverCallback(Action<ISurvivorsRogueCardBase, EToggleState> onHoverCallback)
	{
		this.OnHoverCallback = onHoverCallback;
	}

	// Token: 0x0601472D RID: 83757 RVA: 0x005F79E6 File Offset: 0x005F5BE6
	public void BindOnUnHoverCallback(Action<ISurvivorsRogueCardBase, EToggleState> onUnHoverCallback)
	{
		this.OnUnHoverCallback = onUnHoverCallback;
	}

	// Token: 0x0601472E RID: 83758 RVA: 0x005F79F0 File Offset: 0x005F5BF0
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

	// Token: 0x0601472F RID: 83759 RVA: 0x005F7A25 File Offset: 0x005F5C25
	public void SetToggleInteractive(bool bInteractive)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(bInteractive);
	}

	// Token: 0x06014730 RID: 83760 RVA: 0x005F7A3C File Offset: 0x005F5C3C
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

	// Token: 0x06014731 RID: 83761 RVA: 0x005F7A9C File Offset: 0x005F5C9C
	public bool HasBondInfo()
	{
		ISurvivorsRogueWeaponCard survivorsRogueWeaponCard = this.Data as ISurvivorsRogueWeaponCard;
		return ((survivorsRogueWeaponCard != null) ? survivorsRogueWeaponCard.WeaponBondInfo : null).GetValueOrDefault();
	}

	// Token: 0x0400AD78 RID: 44408
	[Nullable(2)]
	protected ISurvivorsRogueCardBase Data;

	// Token: 0x0400AD79 RID: 44409
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<ISurvivorsRogueCardBase, EToggleState, bool> OnCanExecuteChangeCallback;

	// Token: 0x0400AD7A RID: 44410
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ISurvivorsRogueCardBase, EToggleState> OnStateChangedCallback;

	// Token: 0x0400AD7B RID: 44411
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ISurvivorsRogueCardBase, EToggleState> OnHoverCallback;

	// Token: 0x0400AD7C RID: 44412
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<ISurvivorsRogueCardBase, EToggleState> OnUnHoverCallback;

	// Token: 0x0400AD7D RID: 44413
	private readonly HashSet<SurvivorsRogueCardComponent> VisibleComponents = new HashSet<SurvivorsRogueCardComponent>();

	// Token: 0x0400AD7E RID: 44414
	private readonly Dictionary<Type, SurvivorsRogueCardComponent> ComponentMap = new Dictionary<Type, SurvivorsRogueCardComponent>();

	// Token: 0x0400AD7F RID: 44415
	private readonly List<SurvivorsRogueCardComponent> CenterComponentList = new List<SurvivorsRogueCardComponent>();

	// Token: 0x0400AD80 RID: 44416
	private readonly List<SurvivorsRogueCardComponent> BottomComponentList = new List<SurvivorsRogueCardComponent>();

	// Token: 0x0400AD81 RID: 44417
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Action<ISurvivorsRogueCardBase, bool> LockFunction;
}
