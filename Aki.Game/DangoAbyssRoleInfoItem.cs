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

// Token: 0x02000F18 RID: 3864
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssRoleInfoItem : UiPanelBase
{
	// Token: 0x06009A89 RID: 39561 RVA: 0x002DD830 File Offset: 0x002DBA30
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

	// Token: 0x06009A8A RID: 39562 RVA: 0x002DDA03 File Offset: 0x002DBC03
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

	// Token: 0x06009A8B RID: 39563 RVA: 0x002DDA1E File Offset: 0x002DBC1E
	protected override void OnAfterDestroy()
	{
		this.ViewModel.UnBind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
	}

	// Token: 0x06009A8C RID: 39564 RVA: 0x002DDA38 File Offset: 0x002DBC38
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssRoleInfoItem.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssRoleInfoItem.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009A8D RID: 39565 RVA: 0x002DDA7B File Offset: 0x002DBC7B
	protected override void OnBeforeShow()
	{
		this.ViewModel.Bind(new TCallback<EPluginEquipViewData>(this.OnDataUpdate));
		this.RefreshView();
	}

	// Token: 0x06009A8E RID: 39566 RVA: 0x002DDA9A File Offset: 0x002DBC9A
	private void OnAttributeToggleClick(EToggleState toggleState)
	{
		this.CurrentViewType = EViewType.Attribute;
		this.RefreshView();
	}

	// Token: 0x06009A8F RID: 39567 RVA: 0x002DDAA9 File Offset: 0x002DBCA9
	private void OnPluginToggleClick(EToggleState toggleState)
	{
		this.CurrentViewType = EViewType.Plugin;
		this.RefreshView();
	}

	// Token: 0x06009A90 RID: 39568 RVA: 0x002DDAB8 File Offset: 0x002DBCB8
	private void RefreshToggleStateByCurrentViewType()
	{
		EToggleState state = (this.CurrentViewType == EViewType.Plugin) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
		EToggleState state2 = (this.CurrentViewType == EViewType.Attribute) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(2).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06009A91 RID: 39569 RVA: 0x002DDB07 File Offset: 0x002DBD07
	public void OnDangoInfoUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x06009A92 RID: 39570 RVA: 0x002DDB0F File Offset: 0x002DBD0F
	private void OnDangoIdUpdate()
	{
		if (this.ViewModel.GetDangoId() == 0)
		{
			return;
		}
		this.RefreshView();
	}

	// Token: 0x06009A93 RID: 39571 RVA: 0x002DDB28 File Offset: 0x002DBD28
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

	// Token: 0x06009A94 RID: 39572 RVA: 0x002DDB78 File Offset: 0x002DBD78
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

	// Token: 0x06009A95 RID: 39573 RVA: 0x002DDC00 File Offset: 0x002DBE00
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

	// Token: 0x06009A96 RID: 39574 RVA: 0x002DDC29 File Offset: 0x002DBE29
	private void RefreshPluginView()
	{
		base.GetItem(4).SetUIActive(true);
		base.GetItem(3).SetUIActive(false);
		this.PluginPanelInstance.Refresh();
	}

	// Token: 0x06009A97 RID: 39575 RVA: 0x002DDC50 File Offset: 0x002DBE50
	private void RefreshAttributeView()
	{
		base.GetItem(4).SetUIActive(false);
		base.GetItem(3).SetUIActive(true);
		this.AttributePanelInstance.Refresh();
	}

	// Token: 0x06009A98 RID: 39576 RVA: 0x002DDC78 File Offset: 0x002DBE78
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

	// Token: 0x06009A99 RID: 39577 RVA: 0x002DDCC4 File Offset: 0x002DBEC4
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

	// Token: 0x06009A9A RID: 39578 RVA: 0x002DDD3C File Offset: 0x002DBF3C
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

	// Token: 0x06009A9B RID: 39579 RVA: 0x002DDDAC File Offset: 0x002DBFAC
	private void OnClickLevelUp(int _)
	{
		int dangoId = this.ViewModel.GetDangoId();
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssLevelUpView, dangoId, null);
	}

	// Token: 0x06009A9C RID: 39580 RVA: 0x002DDDDB File Offset: 0x002DBFDB
	private void OnClickEquip(int _)
	{
		this.ViewModel.SetSlotIndex(1, false);
		UiManager.Instance.OpenView(EUiViewName.DangoAbyssPluginEquipView, this.ViewModel, null);
	}

	// Token: 0x04005C48 RID: 23624
	private EViewType CurrentViewType;

	// Token: 0x04005C49 RID: 23625
	public PluginEquipViewModel ViewModel;

	// Token: 0x04005C4A RID: 23626
	private AttributePanel AttributePanelInstance;

	// Token: 0x04005C4B RID: 23627
	private AttributePanel.DangoRolePluginPanel PluginPanelInstance;

	// Token: 0x04005C4C RID: 23628
	private ButtonItem LevelUpItem;

	// Token: 0x04005C4D RID: 23629
	private ButtonItem EquipItem;

	// Token: 0x04005C4E RID: 23630
	private InActiveRedItem InActiveRedItem;

	// Token: 0x02007131 RID: 28977
	[NullableContext(0)]
	private class EInfoPanelComponent
	{
		// Token: 0x04024E09 RID: 151049
		public const int NameText = 0;

		// Token: 0x04024E0A RID: 151050
		public const int PluginToggle = 1;

		// Token: 0x04024E0B RID: 151051
		public const int AttributeToggle = 2;

		// Token: 0x04024E0C RID: 151052
		public const int AttributePanel = 3;

		// Token: 0x04024E0D RID: 151053
		public const int PluginPanel = 4;

		// Token: 0x04024E0E RID: 151054
		public const int CostItem = 5;

		// Token: 0x04024E0F RID: 151055
		public const int EquipItem = 6;

		// Token: 0x04024E10 RID: 151056
		public const int InActiveRedItem = 7;

		// Token: 0x04024E11 RID: 151057
		public const int LevelUpItem = 8;

		// Token: 0x04024E12 RID: 151058
		public const int LevelText = 9;
	}
}
