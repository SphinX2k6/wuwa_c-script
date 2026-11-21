using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013B7 RID: 5047
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryWeaponSelectView : UiViewBase
{
	// Token: 0x0600C803 RID: 51203 RVA: 0x003B8921 File Offset: 0x003B6B21
	public HonamiStoryWeaponSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C804 RID: 51204 RVA: 0x003B8938 File Offset: 0x003B6B38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 21;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIMultiTemplateLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C805 RID: 51205 RVA: 0x003B8C21 File Offset: 0x003B6E21
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
	}

	// Token: 0x0600C806 RID: 51206 RVA: 0x003B8C3F File Offset: 0x003B6E3F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
	}

	// Token: 0x0600C807 RID: 51207 RVA: 0x003B8C60 File Offset: 0x003B6E60
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryWeaponSelectView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryWeaponSelectView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C808 RID: 51208 RVA: 0x003B8CA4 File Offset: 0x003B6EA4
	protected override void OnStart()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(8),
			ViewType = ETermExplanationViewType.Center,
			ReportType = ETermExplanationReportType.HonamiStory
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600C809 RID: 51209 RVA: 0x003B8CDF File Offset: 0x003B6EDF
	protected override void OnBeforeShow()
	{
		UUIItem item = base.GetItem(19);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.UpdateDetailView();
	}

	// Token: 0x0600C80A RID: 51210 RVA: 0x003B8CFC File Offset: 0x003B6EFC
	protected override void OnBeforeHide()
	{
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, null) ?? new HashSet<int>();
		hashSet.Clear();
		LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, hashSet);
		EventSystem.Instance.Emit(EEventName.OnHonamiStoryBackpackClickWeapon);
	}

	// Token: 0x0600C80B RID: 51211 RVA: 0x003B8D40 File Offset: 0x003B6F40
	private void UpdateDetailView()
	{
		if (this.CurSelectWeaponToggleItem == null)
		{
			return;
		}
		bool flag = HonamiStoryUtil.CheckInHonamiStoryDungeon();
		bool flag2 = FunctionModel.Instance.IsOpen(10123);
		HonamiStoryWeaponData weaponData = HonamiStoryModel.Instance.GetWeaponData(this.CurSelectWeaponToggleItem.WeaponId);
		if (weaponData == null)
		{
			return;
		}
		bool isUnlock = weaponData.IsUnlock;
		UUIItem item = base.GetItem(18);
		if (item != null)
		{
			item.SetUIActive(isUnlock);
		}
		UUIItem item2 = base.GetItem(17);
		if (item2 != null)
		{
			item2.SetUIActive(isUnlock);
		}
		UUIItem item3 = base.GetItem(3);
		if (item3 != null)
		{
			item3.SetUIActive(isUnlock && !flag && flag2);
		}
		this.PanelLock.SetActive(!isUnlock);
		HonamiStoryWeapon value = weaponData.Config.Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value.Name, Array.Empty<object>());
		bool skillDescMode = HonamiStoryModel.Instance.GetSkillDescMode();
		string textStringId = skillDescMode ? value.AttributesDescriptionSimple : value.AttributesDescription;
		string[] args = skillDescMode ? value.AttributesDescriptionSimpleArgs() : value.AttributesDescriptionArgs();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textStringId, args);
		UUIText text = base.GetText(16);
		if (text != null)
		{
			text.ShowTextNew(value.GetWayDes);
		}
		if (isUnlock)
		{
			GenericLayout<HonamiStoryWeaponTagItem, int> tagLayout = this.TagLayout;
			if (tagLayout != null)
			{
				tagLayout.RefreshByData(value.PluginTags(), null, false);
			}
			int[] array = value.SuitId();
			List<IHonamiStoryWeaponSuitData> list = new List<IHonamiStoryWeaponSuitData>();
			foreach (int suitId in array)
			{
				list.Add(new HonamiStoryWeaponSuitData
				{
					SuitId = suitId,
					EquipData = this.EquipData
				});
			}
			GenericLayout<HonamiStoryWeaponSuitInfoItem, IHonamiStoryWeaponSuitData> suitVerticalLayout = this.SuitVerticalLayout;
			if (suitVerticalLayout != null)
			{
				suitVerticalLayout.RefreshByData(list, null, false);
			}
		}
		else
		{
			this.PanelLock.SetTextByTextId(weaponData.Config.Value.LockDescription, Array.Empty<string>());
		}
		this.RefreshConfirmButton();
	}

	// Token: 0x0600C80C RID: 51212 RVA: 0x003B8F20 File Offset: 0x003B7120
	private void RefreshConfirmButton()
	{
		switch (HonamiStoryModel.Instance.CheckSelectWeaponState(this.CurSelectWeaponToggleItem.WeaponId, this.EquipData))
		{
		case EHonamiStoryWeaponState.Remove:
			this.ConfirmButtonItem.SetLocalTextNew("HonamiStory_Remove", Array.Empty<object>());
			return;
		case EHonamiStoryWeaponState.Equip:
			this.ConfirmButtonItem.SetLocalTextNew("HonamiStory_Equip", Array.Empty<object>());
			return;
		case EHonamiStoryWeaponState.Change:
			this.ConfirmButtonItem.SetLocalTextNew("HonamiStory_Change", Array.Empty<object>());
			return;
		default:
			return;
		}
	}

	// Token: 0x0600C80D RID: 51213 RVA: 0x003B8F9D File Offset: 0x003B719D
	private void InitData()
	{
		this.EquipData = (HonamiStoryRoleEquipData)this.OpenParam;
	}

	// Token: 0x0600C80E RID: 51214 RVA: 0x003B8FB0 File Offset: 0x003B71B0
	private void InitComponents()
	{
		this.WeaponPanelVerticalLayout = new GenericLayout<HonamiStoryWeaponPanelItem, EHonamiStoryWeaponType>(base.GetVerticalLayout(1), new Func<HonamiStoryWeaponPanelItem>(this.CreateWeaponPanelItem), (AUIBaseActor)base.GetItem(2).GetOwner(), true, true);
		this.TagLayout = new GenericLayout<HonamiStoryWeaponTagItem, int>(base.GetMultiTemplateLayout(10), new Func<HonamiStoryWeaponTagItem>(this.CreateTagItem), null, false, true);
		this.SuitVerticalLayout = new GenericLayout<HonamiStoryWeaponSuitInfoItem, IHonamiStoryWeaponSuitData>(base.GetVerticalLayout(13), new Func<HonamiStoryWeaponSuitInfoItem>(this.CreateSuitItem), null, false, true);
		this.PopupCaption = new PopupCaptionItem(base.GetItem(4));
		this.PopupCaption.SetCloseCallBack(new Action(this.OnClickBack));
		this.PopupCaption.SetHelpBtnActive(true);
		this.PopupCaption.SetHelpCallBack(delegate
		{
			HelpController.Instance.OpenHelpById(436);
		});
		this.ConfirmButtonItem = new ButtonItem(base.GetItem(3));
		this.ConfirmButtonItem.SetFunction(new Action<int>(this.OnClickConfirm));
	}

	// Token: 0x0600C80F RID: 51215 RVA: 0x003B90BA File Offset: 0x003B72BA
	private HonamiStoryWeaponPanelItem CreateWeaponPanelItem()
	{
		HonamiStoryWeaponPanelItem honamiStoryWeaponPanelItem = new HonamiStoryWeaponPanelItem();
		honamiStoryWeaponPanelItem.BindWeaponToggleClick(new Action<HonamiStoryWeaponToggleItem>(this.OnWeaponToggleClick));
		return honamiStoryWeaponPanelItem;
	}

	// Token: 0x0600C810 RID: 51216 RVA: 0x003B90D3 File Offset: 0x003B72D3
	private HonamiStoryWeaponTagItem CreateTagItem()
	{
		return new HonamiStoryWeaponTagItem();
	}

	// Token: 0x0600C811 RID: 51217 RVA: 0x003B90DA File Offset: 0x003B72DA
	private HonamiStoryWeaponSuitInfoItem CreateSuitItem()
	{
		return new HonamiStoryWeaponSuitInfoItem();
	}

	// Token: 0x0600C812 RID: 51218 RVA: 0x003B90E4 File Offset: 0x003B72E4
	private void InitWeaponToggleList()
	{
		if (this.CurSelectWeaponToggleItem != null)
		{
			this.CurSelectWeaponToggleItem.OnDeselected();
			this.CurSelectWeaponToggleItem = null;
		}
		int weaponId = this.EquipData.GetWeaponId();
		List<HonamiStoryWeaponPanelItem> layoutItemList = this.WeaponPanelVerticalLayout.GetLayoutItemList();
		this.WeaponToggleList.Clear();
		foreach (HonamiStoryWeaponPanelItem honamiStoryWeaponPanelItem in layoutItemList)
		{
			foreach (HonamiStoryWeaponToggleItem honamiStoryWeaponToggleItem in honamiStoryWeaponPanelItem.WeaponToggleList)
			{
				this.WeaponToggleList.Add(honamiStoryWeaponToggleItem);
				if (honamiStoryWeaponToggleItem.WeaponId == weaponId)
				{
					this.CurSelectWeaponToggleItem = honamiStoryWeaponToggleItem;
				}
			}
		}
		if (this.CurSelectWeaponToggleItem == null && this.WeaponToggleList.Count > 0)
		{
			this.CurSelectWeaponToggleItem = this.WeaponToggleList[0];
		}
		HonamiStoryWeaponToggleItem curSelectWeaponToggleItem = this.CurSelectWeaponToggleItem;
		if (curSelectWeaponToggleItem != null)
		{
			curSelectWeaponToggleItem.OnSelected();
		}
		this.UpdateDetailView();
	}

	// Token: 0x0600C813 RID: 51219 RVA: 0x003B91FC File Offset: 0x003B73FC
	private void OnWeaponToggleClick(HonamiStoryWeaponToggleItem toggleItem)
	{
		if (this.CurSelectWeaponToggleItem == toggleItem)
		{
			return;
		}
		HonamiStoryWeaponToggleItem curSelectWeaponToggleItem = this.CurSelectWeaponToggleItem;
		if (curSelectWeaponToggleItem != null)
		{
			curSelectWeaponToggleItem.OnDeselected();
		}
		this.CurSelectWeaponToggleItem = toggleItem;
		this.CurSelectWeaponToggleItem.OnSelected();
		this.UpdateDetailView();
	}

	// Token: 0x0600C814 RID: 51220 RVA: 0x003B9234 File Offset: 0x003B7434
	private void OnClickConfirm(int _)
	{
		if (this.CurSelectWeaponToggleItem == null || this.EquipData == null)
		{
			return;
		}
		EHonamiStoryWeaponState ehonamiStoryWeaponState = HonamiStoryModel.Instance.CheckSelectWeaponState(this.CurSelectWeaponToggleItem.WeaponId, this.EquipData);
		int weaponId = 0;
		if (ehonamiStoryWeaponState != EHonamiStoryWeaponState.Remove)
		{
			if (ehonamiStoryWeaponState - EHonamiStoryWeaponState.Equip <= 1)
			{
				weaponId = this.CurSelectWeaponToggleItem.WeaponId;
			}
		}
		else
		{
			weaponId = 0;
		}
		HonamiStoryRoleEquipData honamiStoryRoleEquipData = HonamiStoryModel.Instance.GetWeaponEquipState(weaponId) ?? this.CurSelectWeaponToggleItem.GetEquipData();
		if (honamiStoryRoleEquipData != null && honamiStoryRoleEquipData.GetRoleId() != 0 && this.EquipData.GetRoleId() != honamiStoryRoleEquipData.GetRoleId())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.HonamiStoryEquipWeaponConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				this.DressRequest(weaponId, this.EquipData.GetPosition());
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		this.DressRequest(weaponId, this.EquipData.GetPosition());
	}

	// Token: 0x0600C815 RID: 51221 RVA: 0x003B932A File Offset: 0x003B752A
	private void DressRequest(int weaponId, int position)
	{
		HonamiStoryController.Instance.SendHonamiStoryWeaponDressRequest(weaponId, position, delegate
		{
			this.UpdateDetailView();
			foreach (HonamiStoryWeaponToggleItem honamiStoryWeaponToggleItem in this.WeaponToggleList)
			{
				if (honamiStoryWeaponToggleItem != null)
				{
					honamiStoryWeaponToggleItem.RefreshItem();
					honamiStoryWeaponToggleItem.RefreshCurSelectLightSprite(this.EquipData);
				}
			}
		});
	}

	// Token: 0x0600C816 RID: 51222 RVA: 0x003B9344 File Offset: 0x003B7544
	private void OnClickBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C817 RID: 51223 RVA: 0x003B934D File Offset: 0x003B754D
	private void OnSkillDescModeChange(bool _)
	{
		this.UpdateDetailView();
	}

	// Token: 0x040071CC RID: 29132
	public PopupCaptionItem PopupCaption;

	// Token: 0x040071CD RID: 29133
	[Nullable(2)]
	private HonamiStoryRoleEquipData EquipData;

	// Token: 0x040071CE RID: 29134
	[Nullable(2)]
	private HonamiStoryWeaponToggleItem CurSelectWeaponToggleItem;

	// Token: 0x040071CF RID: 29135
	private readonly List<HonamiStoryWeaponToggleItem> WeaponToggleList = new List<HonamiStoryWeaponToggleItem>();

	// Token: 0x040071D0 RID: 29136
	private GenericLayout<HonamiStoryWeaponPanelItem, EHonamiStoryWeaponType> WeaponPanelVerticalLayout;

	// Token: 0x040071D1 RID: 29137
	private GenericLayout<HonamiStoryWeaponTagItem, int> TagLayout;

	// Token: 0x040071D2 RID: 29138
	private GenericLayout<HonamiStoryWeaponSuitInfoItem, IHonamiStoryWeaponSuitData> SuitVerticalLayout;

	// Token: 0x040071D3 RID: 29139
	private ButtonItem ConfirmButtonItem;

	// Token: 0x040071D4 RID: 29140
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x040071D5 RID: 29141
	[Nullable(2)]
	private HonamiStorySkillDescToggle DescToggleItem;

	// Token: 0x02007674 RID: 30324
	[NullableContext(0)]
	private enum EHonamiStoryWeaponSelectComponent
	{
		// Token: 0x04026747 RID: 157511
		SkillModeToggle,
		// Token: 0x04026748 RID: 157512
		WeaponPanelVerticalLayout,
		// Token: 0x04026749 RID: 157513
		WeaponPanelItem,
		// Token: 0x0402674A RID: 157514
		ConfirmButton,
		// Token: 0x0402674B RID: 157515
		ItemCaption,
		// Token: 0x0402674C RID: 157516
		DetailPanel,
		// Token: 0x0402674D RID: 157517
		WeaponName,
		// Token: 0x0402674E RID: 157518
		WeaponSkillTitle,
		// Token: 0x0402674F RID: 157519
		WeaponSkillDesc,
		// Token: 0x04026750 RID: 157520
		TagTitle,
		// Token: 0x04026751 RID: 157521
		TagLayout,
		// Token: 0x04026752 RID: 157522
		TagItem,
		// Token: 0x04026753 RID: 157523
		SuitTitle,
		// Token: 0x04026754 RID: 157524
		SuitVerticalLayout,
		// Token: 0x04026755 RID: 157525
		SuitItem,
		// Token: 0x04026756 RID: 157526
		GetTitleText,
		// Token: 0x04026757 RID: 157527
		GetDescText,
		// Token: 0x04026758 RID: 157528
		TagPanel,
		// Token: 0x04026759 RID: 157529
		SuitPanel,
		// Token: 0x0402675A RID: 157530
		GetPanel,
		// Token: 0x0402675B RID: 157531
		LockPanel
	}
}
