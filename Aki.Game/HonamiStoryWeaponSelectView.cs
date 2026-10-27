using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001EF5 RID: 7925
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryWeaponSelectView : UiViewBase
{
	// Token: 0x0600F3E4 RID: 62436 RVA: 0x003ACE25 File Offset: 0x003AB025
	public HonamiStoryWeaponSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F3E5 RID: 62437 RVA: 0x003ACE3C File Offset: 0x003AB03C
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

	// Token: 0x0600F3E6 RID: 62438 RVA: 0x003AD125 File Offset: 0x003AB325
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<bool>(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
	}

	// Token: 0x0600F3E7 RID: 62439 RVA: 0x003AD143 File Offset: 0x003AB343
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<bool>(EEventName.OnHonamiStorySkillDescModeChange, new Action<bool>(this.OnSkillDescModeChange));
	}

	// Token: 0x0600F3E8 RID: 62440 RVA: 0x003AD164 File Offset: 0x003AB364
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryWeaponSelectView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryWeaponSelectView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F3E9 RID: 62441 RVA: 0x003AD1A8 File Offset: 0x003AB3A8
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

	// Token: 0x0600F3EA RID: 62442 RVA: 0x003AD1E3 File Offset: 0x003AB3E3
	protected override void OnBeforeShow()
	{
		UUIItem item = base.GetItem(19);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.UpdateDetailView();
	}

	// Token: 0x0600F3EB RID: 62443 RVA: 0x003AD200 File Offset: 0x003AB400
	protected override void OnBeforeHide()
	{
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, null) ?? new HashSet<int>();
		hashSet.Clear();
		LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, hashSet);
		EventSystem.Instance.Emit(EEventName.OnHonamiStoryBackpackClickWeapon);
	}

	// Token: 0x0600F3EC RID: 62444 RVA: 0x003AD244 File Offset: 0x003AB444
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
				tagLayout.RefreshByData(value.PluginTags().ToList<int>(), null, false);
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

	// Token: 0x0600F3ED RID: 62445 RVA: 0x003AD42C File Offset: 0x003AB62C
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

	// Token: 0x0600F3EE RID: 62446 RVA: 0x003AD4A9 File Offset: 0x003AB6A9
	private void InitData()
	{
		this.EquipData = (HonamiStoryRoleEquipData)this.OpenParam;
	}

	// Token: 0x0600F3EF RID: 62447 RVA: 0x003AD4BC File Offset: 0x003AB6BC
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

	// Token: 0x0600F3F0 RID: 62448 RVA: 0x003AD5C6 File Offset: 0x003AB7C6
	private HonamiStoryWeaponPanelItem CreateWeaponPanelItem()
	{
		HonamiStoryWeaponPanelItem honamiStoryWeaponPanelItem = new HonamiStoryWeaponPanelItem();
		honamiStoryWeaponPanelItem.BindWeaponToggleClick(new Action<HonamiStoryWeaponToggleItem>(this.OnWeaponToggleClick));
		return honamiStoryWeaponPanelItem;
	}

	// Token: 0x0600F3F1 RID: 62449 RVA: 0x003AD5DF File Offset: 0x003AB7DF
	private HonamiStoryWeaponTagItem CreateTagItem()
	{
		return new HonamiStoryWeaponTagItem();
	}

	// Token: 0x0600F3F2 RID: 62450 RVA: 0x003AD5E6 File Offset: 0x003AB7E6
	private HonamiStoryWeaponSuitInfoItem CreateSuitItem()
	{
		return new HonamiStoryWeaponSuitInfoItem();
	}

	// Token: 0x0600F3F3 RID: 62451 RVA: 0x003AD5F0 File Offset: 0x003AB7F0
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

	// Token: 0x0600F3F4 RID: 62452 RVA: 0x003AD708 File Offset: 0x003AB908
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

	// Token: 0x0600F3F5 RID: 62453 RVA: 0x003AD740 File Offset: 0x003AB940
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

	// Token: 0x0600F3F6 RID: 62454 RVA: 0x003AD836 File Offset: 0x003ABA36
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

	// Token: 0x0600F3F7 RID: 62455 RVA: 0x003AD850 File Offset: 0x003ABA50
	private void OnClickBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F3F8 RID: 62456 RVA: 0x003AD859 File Offset: 0x003ABA59
	private void OnSkillDescModeChange(bool _)
	{
		this.UpdateDetailView();
	}

	// Token: 0x040070EB RID: 28907
	public PopupCaptionItem PopupCaption;

	// Token: 0x040070EC RID: 28908
	[Nullable(2)]
	private HonamiStoryRoleEquipData EquipData;

	// Token: 0x040070ED RID: 28909
	[Nullable(2)]
	private HonamiStoryWeaponToggleItem CurSelectWeaponToggleItem;

	// Token: 0x040070EE RID: 28910
	private readonly List<HonamiStoryWeaponToggleItem> WeaponToggleList = new List<HonamiStoryWeaponToggleItem>();

	// Token: 0x040070EF RID: 28911
	private GenericLayout<HonamiStoryWeaponPanelItem, EHonamiStoryWeaponType> WeaponPanelVerticalLayout;

	// Token: 0x040070F0 RID: 28912
	private GenericLayout<HonamiStoryWeaponTagItem, int> TagLayout;

	// Token: 0x040070F1 RID: 28913
	private GenericLayout<HonamiStoryWeaponSuitInfoItem, IHonamiStoryWeaponSuitData> SuitVerticalLayout;

	// Token: 0x040070F2 RID: 28914
	private ButtonItem ConfirmButtonItem;

	// Token: 0x040070F3 RID: 28915
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x040070F4 RID: 28916
	[Nullable(2)]
	private HonamiStorySkillDescToggle DescToggleItem;

	// Token: 0x020084EF RID: 34031
	[NullableContext(0)]
	private enum EHonamiStoryWeaponSelectComponent
	{
		// Token: 0x0402B423 RID: 177187
		SkillModeToggle,
		// Token: 0x0402B424 RID: 177188
		WeaponPanelVerticalLayout,
		// Token: 0x0402B425 RID: 177189
		WeaponPanelItem,
		// Token: 0x0402B426 RID: 177190
		ConfirmButton,
		// Token: 0x0402B427 RID: 177191
		ItemCaption,
		// Token: 0x0402B428 RID: 177192
		DetailPanel,
		// Token: 0x0402B429 RID: 177193
		WeaponName,
		// Token: 0x0402B42A RID: 177194
		WeaponSkillTitle,
		// Token: 0x0402B42B RID: 177195
		WeaponSkillDesc,
		// Token: 0x0402B42C RID: 177196
		TagTitle,
		// Token: 0x0402B42D RID: 177197
		TagLayout,
		// Token: 0x0402B42E RID: 177198
		TagItem,
		// Token: 0x0402B42F RID: 177199
		SuitTitle,
		// Token: 0x0402B430 RID: 177200
		SuitVerticalLayout,
		// Token: 0x0402B431 RID: 177201
		SuitItem,
		// Token: 0x0402B432 RID: 177202
		GetTitleText,
		// Token: 0x0402B433 RID: 177203
		GetDescText,
		// Token: 0x0402B434 RID: 177204
		TagPanel,
		// Token: 0x0402B435 RID: 177205
		SuitPanel,
		// Token: 0x0402B436 RID: 177206
		GetPanel,
		// Token: 0x0402B437 RID: 177207
		LockPanel
	}
}
