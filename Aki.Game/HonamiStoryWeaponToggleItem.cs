using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013CE RID: 5070
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryWeaponToggleItem : UiPanelBase, IGridProxy<IHonamiStoryWeaponToggleItemData>
{
	// Token: 0x17001349 RID: 4937
	// (get) Token: 0x0600C8D8 RID: 51416 RVA: 0x003BC4C3 File Offset: 0x003BA6C3
	// (set) Token: 0x0600C8D9 RID: 51417 RVA: 0x003BC4CB File Offset: 0x003BA6CB
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<IHonamiStoryWeaponToggleItemData>, IHonamiStoryWeaponToggleItemData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x1700134A RID: 4938
	// (get) Token: 0x0600C8DA RID: 51418 RVA: 0x003BC4D4 File Offset: 0x003BA6D4
	// (set) Token: 0x0600C8DB RID: 51419 RVA: 0x003BC4DC File Offset: 0x003BA6DC
	public int GridIndex { get; set; }

	// Token: 0x1700134B RID: 4939
	// (get) Token: 0x0600C8DC RID: 51420 RVA: 0x003BC4E5 File Offset: 0x003BA6E5
	// (set) Token: 0x0600C8DD RID: 51421 RVA: 0x003BC4ED File Offset: 0x003BA6ED
	public int DisplayIndex { get; set; }

	// Token: 0x0600C8DE RID: 51422 RVA: 0x003BC4F8 File Offset: 0x003BA6F8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.OnToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C8DF RID: 51423 RVA: 0x003BC774 File Offset: 0x003BA974
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryWeaponToggleItem.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryWeaponToggleItem.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C8E0 RID: 51424 RVA: 0x003BC7B7 File Offset: 0x003BA9B7
	public void Refresh(IHonamiStoryWeaponToggleItemData data, bool isSelected, int gridIndex)
	{
		this.WeaponIdInternal = data.WeaponId;
		this.UseWayInternal = data.UseWay;
		if (data.EquipData != null)
		{
			this.EquipData = data.EquipData;
		}
		this.RefreshItem();
	}

	// Token: 0x0600C8E1 RID: 51425 RVA: 0x003BC7EC File Offset: 0x003BA9EC
	public void RefreshItem()
	{
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(11);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		HonamiStoryWeaponData weaponData = HonamiStoryModel.Instance.GetWeaponData(this.WeaponIdInternal);
		if (this.WeaponIdInternal <= 0 || weaponData == null)
		{
			UUIItem item3 = base.GetItem(8);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			string resourceId = HonamiStoryUtil.CheckInHonamiStoryDungeon() ? "SP_EquipBozaiLock" : "SP_EquipBozaiNor";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			UUISprite sprite = base.GetSprite(13);
			this.SetSpriteByPath(resourcePath, sprite, false, null, delegate(bool _)
			{
				UUIExtendToggleSpriteTransition uuiextendToggleSpriteTransition = sprite.GetOwner().GetComponentByClass(UUIExtendToggleSpriteTransition.StaticClass()) as UUIExtendToggleSpriteTransition;
				if (uuiextendToggleSpriteTransition == null)
				{
					return;
				}
				uuiextendToggleSpriteTransition.SetAllStateSprite(sprite.GetSprite());
			});
			sprite.SetUIActive(true);
			return;
		}
		HonamiStoryWeapon? config = weaponData.Config;
		bool isUnlock = weaponData.IsUnlock;
		UUIItem item4 = base.GetItem(7);
		if (item4 != null)
		{
			item4.SetUIActive(!isUnlock);
		}
		UUIItem item5 = base.GetItem(6);
		if (item5 != null)
		{
			item5.SetUIActive(isUnlock);
		}
		if (isUnlock)
		{
			int[] suitIdList = config.Value.SuitId();
			this.RefreshSuitActiveItems(suitIdList);
			if (this.UseWayInternal == EHonamiStoryWeaponUseWay.Change)
			{
				HonamiStoryRoleEquipData honamiStoryRoleEquipData = this.EquipData;
				if (honamiStoryRoleEquipData == null)
				{
					honamiStoryRoleEquipData = HonamiStoryModel.Instance.GetWeaponEquipState(this.WeaponIdInternal);
				}
				if (honamiStoryRoleEquipData != null)
				{
					int roleId = honamiStoryRoleEquipData.GetRoleId();
					if (roleId > 0)
					{
						RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
						if (roleConfig != null)
						{
							base.SetRoleIcon(roleConfig.Value.RoleHeadIcon, base.GetTexture(10), roleId, null, null);
							UUIItem item6 = base.GetItem(9);
							if (item6 != null)
							{
								item6.SetUIActive(true);
							}
						}
					}
					else
					{
						int position = honamiStoryRoleEquipData.GetPosition();
						base.GetText(12).SetText((position + 1).ToString(), true);
						UUIItem item7 = base.GetItem(11);
						if (item7 != null)
						{
							item7.SetUIActive(true);
						}
					}
				}
			}
		}
		this.SetNewItemShow(false);
		base.SetTextureByPath(config.Value.IconToggle, base.GetTexture(0), null, null);
		UUIItem item8 = base.GetItem(8);
		if (item8 != null)
		{
			item8.SetUIActive(true);
		}
		base.GetSprite(13).SetUIActive(false);
	}

	// Token: 0x0600C8E2 RID: 51426 RVA: 0x003BCA30 File Offset: 0x003BAC30
	public void RefreshCurSelectLightSprite(HonamiStoryRoleEquipData curSelectEquipData)
	{
		base.GetSprite(14).SetUIActive(false);
		base.GetSprite(15).SetUIActive(false);
		if (this.UseWayInternal == EHonamiStoryWeaponUseWay.Change)
		{
			HonamiStoryRoleEquipData honamiStoryRoleEquipData = this.EquipData;
			if (honamiStoryRoleEquipData == null)
			{
				honamiStoryRoleEquipData = HonamiStoryModel.Instance.GetWeaponEquipState(this.WeaponIdInternal);
			}
			if (honamiStoryRoleEquipData != null && honamiStoryRoleEquipData.GetPosition() == curSelectEquipData.GetPosition())
			{
				base.GetSprite(14).SetUIActive(true);
				base.GetSprite(15).SetUIActive(true);
			}
		}
	}

	// Token: 0x0600C8E3 RID: 51427 RVA: 0x003BCAAC File Offset: 0x003BACAC
	private void RefreshSuitActiveItems(IReadOnlyList<int> suitIdList)
	{
		HonamiStoryRoleEquipData honamiStoryRoleEquipData = this.EquipData;
		if (honamiStoryRoleEquipData == null)
		{
			honamiStoryRoleEquipData = HonamiStoryModel.Instance.GetWeaponEquipState(this.WeaponIdInternal);
		}
		int num = Math.Min(suitIdList.Count, 3);
		for (int i = 0; i < num; i++)
		{
			int suitId = suitIdList[i];
			this.SuitActiveItemList[i].Refresh(new HonamiStoryWeaponSuitData
			{
				SuitId = suitId,
				EquipData = honamiStoryRoleEquipData
			});
			this.SuitActiveItemList[i].SetUiActive(true);
		}
		for (int j = num; j < 3; j++)
		{
			this.SuitActiveItemList[j].SetUiActive(false);
		}
	}

	// Token: 0x1700134C RID: 4940
	// (get) Token: 0x0600C8E4 RID: 51428 RVA: 0x003BCB4E File Offset: 0x003BAD4E
	public int WeaponId
	{
		get
		{
			return this.WeaponIdInternal;
		}
	}

	// Token: 0x0600C8E5 RID: 51429 RVA: 0x003BCB56 File Offset: 0x003BAD56
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetEquipData()
	{
		return this.EquipData;
	}

	// Token: 0x0600C8E6 RID: 51430 RVA: 0x003BCB5E File Offset: 0x003BAD5E
	public void BindWeaponToggleClick(Action<HonamiStoryWeaponToggleItem> callback)
	{
		this.OnWeaponToggleClick = callback;
	}

	// Token: 0x0600C8E7 RID: 51431 RVA: 0x003BCB68 File Offset: 0x003BAD68
	private void OnUndeterminedClicked()
	{
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, null) ?? new HashSet<int>();
		hashSet.Remove(this.WeaponIdInternal);
		LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, hashSet);
		Action<HonamiStoryWeaponToggleItem> onWeaponToggleClick = this.OnWeaponToggleClick;
		if (onWeaponToggleClick != null)
		{
			onWeaponToggleClick(this);
		}
		this.SetNewItemShow(true);
	}

	// Token: 0x0600C8E8 RID: 51432 RVA: 0x003BCBBC File Offset: 0x003BADBC
	private void OnToggle(EToggleState toggleState)
	{
		this.OnUndeterminedClicked();
	}

	// Token: 0x0600C8E9 RID: 51433 RVA: 0x003BCBC4 File Offset: 0x003BADC4
	public void OnSelected()
	{
		base.GetExtendToggle(5).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600C8EA RID: 51434 RVA: 0x003BCBD6 File Offset: 0x003BADD6
	public void OnDeselected()
	{
		base.GetExtendToggle(5).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600C8EB RID: 51435 RVA: 0x003BCBE8 File Offset: 0x003BADE8
	public void Clear()
	{
	}

	// Token: 0x0600C8EC RID: 51436 RVA: 0x003BCBEA File Offset: 0x003BADEA
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600C8ED RID: 51437 RVA: 0x003BCBEC File Offset: 0x003BADEC
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600C8EE RID: 51438 RVA: 0x003BCBEE File Offset: 0x003BADEE
	public object GetKey(IHonamiStoryWeaponToggleItemData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x0600C8EF RID: 51439 RVA: 0x003BCBFB File Offset: 0x003BADFB
	public void SetIsEnable(bool value)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetAlpha(value ? 1f : 0.4f);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(5);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetSelfInteractive(value);
	}

	// Token: 0x0600C8F0 RID: 51440 RVA: 0x003BCC30 File Offset: 0x003BAE30
	public void SetNewItemShow(bool needEmit = true)
	{
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.HonamiStoryWeaponUnlockSet, null) ?? new HashSet<int>();
		if (this.UseWayInternal == EHonamiStoryWeaponUseWay.Equip)
		{
			bool uiactive = hashSet.Count > 0;
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
		}
		else
		{
			bool uiactive2 = hashSet.Contains(this.WeaponIdInternal);
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(uiactive2);
			}
		}
		if (needEmit)
		{
			EventSystem.Instance.Emit(EEventName.OnHonamiStoryBackpackClickWeapon);
		}
	}

	// Token: 0x0600C8F1 RID: 51441 RVA: 0x003BCCAC File Offset: 0x003BAEAC
	public void ResetToggleState()
	{
		base.GetExtendToggle(5).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04007219 RID: 29209
	private const int SUIT_ITEM_COUNT = 3;

	// Token: 0x0400721A RID: 29210
	private int WeaponIdInternal;

	// Token: 0x0400721B RID: 29211
	private EHonamiStoryWeaponUseWay UseWayInternal;

	// Token: 0x0400721C RID: 29212
	private Action<HonamiStoryWeaponToggleItem> OnWeaponToggleClick;

	// Token: 0x0400721D RID: 29213
	private List<HonamiStoryWeaponSuitActiveItem> SuitActiveItemList = new List<HonamiStoryWeaponSuitActiveItem>();

	// Token: 0x0400721E RID: 29214
	[Nullable(2)]
	private HonamiStoryRoleEquipData EquipData;

	// Token: 0x0200769C RID: 30364
	[NullableContext(0)]
	private enum EHonamiStoryWeaponToggleItemComponent
	{
		// Token: 0x04026821 RID: 157729
		IconTexture,
		// Token: 0x04026822 RID: 157730
		SuitItemOne,
		// Token: 0x04026823 RID: 157731
		SuitItemTwo,
		// Token: 0x04026824 RID: 157732
		SuitItemThree,
		// Token: 0x04026825 RID: 157733
		NewItem,
		// Token: 0x04026826 RID: 157734
		Toggle,
		// Token: 0x04026827 RID: 157735
		SuitPanel,
		// Token: 0x04026828 RID: 157736
		LockPanel,
		// Token: 0x04026829 RID: 157737
		InfoPanel,
		// Token: 0x0402682A RID: 157738
		RoleItem,
		// Token: 0x0402682B RID: 157739
		RoleTexture,
		// Token: 0x0402682C RID: 157740
		NumItem,
		// Token: 0x0402682D RID: 157741
		NumText,
		// Token: 0x0402682E RID: 157742
		SpriteEmpty,
		// Token: 0x0402682F RID: 157743
		SpriteRoleLight,
		// Token: 0x04026830 RID: 157744
		SpriteNumLight
	}
}
