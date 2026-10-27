using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A59 RID: 6745
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssRoleInfoItem : UiPanelBase
{
	// Token: 0x0600C679 RID: 50809 RVA: 0x002D2720 File Offset: 0x002D0920
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnPluginToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnAttributeToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C67A RID: 50810 RVA: 0x002D28F3 File Offset: 0x002D0AF3
	private void OnDataUpdate(EPluginEquipViewData key)
	{
		switch (key)
		{
		case EPluginEquipViewData.DangoId:
			this.OnDangoIdUpdate();
			break;
		case EPluginEquipViewData.SlotIndex:
		case EPluginEquipViewData.PluginItem:
			break;
		default:
			return;
		}
	}

	// Token: 0x0600C67B RID: 50811 RVA: 0x002D290E File Offset: 0x002D0B0E
	protected override void OnAfterDestroy()
	{
		this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
	}

	// Token: 0x0600C67C RID: 50812 RVA: 0x002D2928 File Offset: 0x002D0B28
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssRoleInfoItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssRoleInfoItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C67D RID: 50813 RVA: 0x002D296B File Offset: 0x002D0B6B
	protected override void OnBeforeShow()
	{
		this.ViewModel.Bind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
		this.RefreshView();
	}

	// Token: 0x0600C67E RID: 50814 RVA: 0x002D298A File Offset: 0x002D0B8A
	private void OnAttributeToggleClick(EToggleState toggleState)
	{
		this.CurrentViewType = EViewType.Attribute;
		this.RefreshView();
	}

	// Token: 0x0600C67F RID: 50815 RVA: 0x002D2999 File Offset: 0x002D0B99
	private void OnPluginToggleClick(EToggleState toggleState)
	{
		this.CurrentViewType = EViewType.Plugin;
		this.RefreshView();
	}

	// Token: 0x0600C680 RID: 50816 RVA: 0x002D29A8 File Offset: 0x002D0BA8
	private void RefreshToggleStateByCurrentViewType()
	{
		EToggleState state = (this.CurrentViewType == EViewType.Plugin) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
		EToggleState state2 = (this.CurrentViewType == EViewType.Attribute) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(2).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600C681 RID: 50817 RVA: 0x002D29F7 File Offset: 0x002D0BF7
	public void OnDangoInfoUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x0600C682 RID: 50818 RVA: 0x002D29FF File Offset: 0x002D0BFF
	private void OnDangoIdUpdate()
	{
		if (this.ViewModel.GetDangoId() == 0)
		{
			return;
		}
		this.RefreshView();
	}

	// Token: 0x0600C683 RID: 50819 RVA: 0x002D2A18 File Offset: 0x002D0C18
	public void RefreshView()
	{
		int dangoId = this.ViewModel.GetDangoId();
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(dangoId);
		this.RefreshName(dangoAbyssRoleData);
		this.RefreshEquipItem(dangoAbyssRoleData);
		this.RefreshInActiveRedItem(dangoAbyssRoleData);
		this.RefreshLevelUpItem(dangoAbyssRoleData);
		this.RefreshToggleStateByCurrentViewType();
		this.RefreshViewByViewType();
	}

	// Token: 0x0600C684 RID: 50820 RVA: 0x002D2A68 File Offset: 0x002D0C68
	private void RefreshName(AbyssDangoRoleData data)
	{
		if (data == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.GetName(), Array.Empty<object>());
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(9), "Text_DangoLevel_Text", new <>z__ReadOnlyArray<object>(new object[]
		{
			data.GetLevel().ToString(),
			data.GetMaxLevel().ToString()
		}));
		base.GetText(9).SetUIActive(!data.GetIfLock());
	}

	// Token: 0x0600C685 RID: 50821 RVA: 0x002D2AF0 File Offset: 0x002D0CF0
	private void RefreshViewByViewType()
	{
		EViewType currentViewType = this.CurrentViewType;
		if (currentViewType == EViewType.Plugin)
		{
			this.RefreshPluginView();
			return;
		}
		if (currentViewType != EViewType.Attribute)
		{
			return;
		}
		this.RefreshAttributeView();
	}

	// Token: 0x0600C686 RID: 50822 RVA: 0x002D2B19 File Offset: 0x002D0D19
	private void RefreshPluginView()
	{
		base.GetItem(4).SetUIActive(true);
		base.GetItem(3).SetUIActive(false);
		this.PluginPanelInstance.Refresh();
	}

	// Token: 0x0600C687 RID: 50823 RVA: 0x002D2B40 File Offset: 0x002D0D40
	private void RefreshAttributeView()
	{
		base.GetItem(4).SetUIActive(false);
		base.GetItem(3).SetUIActive(true);
		this.AttributePanelInstance.Refresh();
	}

	// Token: 0x0600C688 RID: 50824 RVA: 0x002D2B68 File Offset: 0x002D0D68
	private void RefreshEquipItem(AbyssDangoRoleData data)
	{
		if (data == null)
		{
			ButtonItem equipItem = this.EquipItem;
			if (equipItem == null)
			{
				return;
			}
			equipItem.SetActive(false);
			return;
		}
		else
		{
			bool ifLock = data.GetIfLock();
			this.EquipItem.SetActive(!ifLock);
			ButtonItem equipItem2 = this.EquipItem;
			if (equipItem2 == null)
			{
				return;
			}
			equipItem2.SetRedDotVisible(false);
			return;
		}
	}

	// Token: 0x0600C689 RID: 50825 RVA: 0x002D2BB4 File Offset: 0x002D0DB4
	private void RefreshInActiveRedItem(AbyssDangoRoleData data)
	{
		if (data == null)
		{
			InActiveRedItem inActiveRedItem = this.InActiveRedItem;
			if (inActiveRedItem == null)
			{
				return;
			}
			inActiveRedItem.SetActive(false);
			return;
		}
		else
		{
			AbyssLittleRole value = data.GetConfig().Value;
			bool ifLock = data.GetIfLock();
			InActiveRedItem inActiveRedItem2 = this.InActiveRedItem;
			if (inActiveRedItem2 != null)
			{
				inActiveRedItem2.SetActive(ifLock);
			}
			InActiveRedItem inActiveRedItem3 = this.InActiveRedItem;
			if (inActiveRedItem3 != null)
			{
				inActiveRedItem3.SetDetailButtonVisible(false);
			}
			InActiveRedItem inActiveRedItem4 = this.InActiveRedItem;
			if (inActiveRedItem4 == null)
			{
				return;
			}
			inActiveRedItem4.SetText(value.UnlockDesc, Array.Empty<object>());
			return;
		}
	}

	// Token: 0x0600C68A RID: 50826 RVA: 0x002D2C2C File Offset: 0x002D0E2C
	private void RefreshLevelUpItem(AbyssDangoRoleData data)
	{
		if (data == null)
		{
			ButtonItem levelUpItem = this.LevelUpItem;
			if (levelUpItem == null)
			{
				return;
			}
			levelUpItem.SetActive(false);
			return;
		}
		else
		{
			bool ifCanLevelUp = data.GetIfCanLevelUp();
			bool ifLock = data.GetIfLock();
			ButtonItem levelUpItem2 = this.LevelUpItem;
			if (levelUpItem2 != null)
			{
				levelUpItem2.SetActive(!ifLock);
			}
			bool dangoLevelUpRedDotById = DangoAbyssModel.Instance.GetDangoLevelUpRedDotById(data.GetId(), new bool?(false));
			ButtonItem levelUpItem3 = this.LevelUpItem;
			if (levelUpItem3 == null)
			{
				return;
			}
			levelUpItem3.SetRedDotVisible(ifCanLevelUp && dangoLevelUpRedDotById);
			return;
		}
	}

	// Token: 0x0600C68B RID: 50827 RVA: 0x002D2C9C File Offset: 0x002D0E9C
	private void OnClickLevelUp(int _)
	{
		int dangoId = this.ViewModel.GetDangoId();
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssLevelUpView, dangoId, null);
	}

	// Token: 0x0600C68C RID: 50828 RVA: 0x002D2CCB File Offset: 0x002D0ECB
	private void OnClickEquip(int _)
	{
		this.ViewModel.SetSlotIndex(1, false);
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssPluginEquipView, this.ViewModel, null);
	}

	// Token: 0x04005B79 RID: 23417
	private EViewType CurrentViewType;

	// Token: 0x04005B7A RID: 23418
	public PluginEquipViewModel ViewModel;

	// Token: 0x04005B7B RID: 23419
	private AttributePanel AttributePanelInstance;

	// Token: 0x04005B7C RID: 23420
	private AttributePanel.DangoRolePluginPanel PluginPanelInstance;

	// Token: 0x04005B7D RID: 23421
	private ButtonItem LevelUpItem;

	// Token: 0x04005B7E RID: 23422
	private ButtonItem EquipItem;

	// Token: 0x04005B7F RID: 23423
	private InActiveRedItem InActiveRedItem;

	// Token: 0x02007FA2 RID: 32674
	[NullableContext(0)]
	private class EInfoPanelComponent
	{
		// Token: 0x04029ACC RID: 170700
		public const int NameText = 0;

		// Token: 0x04029ACD RID: 170701
		public const int PluginToggle = 1;

		// Token: 0x04029ACE RID: 170702
		public const int AttributeToggle = 2;

		// Token: 0x04029ACF RID: 170703
		public const int AttributePanel = 3;

		// Token: 0x04029AD0 RID: 170704
		public const int PluginPanel = 4;

		// Token: 0x04029AD1 RID: 170705
		public const int CostItem = 5;

		// Token: 0x04029AD2 RID: 170706
		public const int EquipItem = 6;

		// Token: 0x04029AD3 RID: 170707
		public const int InActiveRedItem = 7;

		// Token: 0x04029AD4 RID: 170708
		public const int LevelUpItem = 8;

		// Token: 0x04029AD5 RID: 170709
		public const int LevelText = 9;
	}
}
