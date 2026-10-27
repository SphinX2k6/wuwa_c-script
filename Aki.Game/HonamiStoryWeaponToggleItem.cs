using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001F0C RID: 7948
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryWeaponToggleItem : UiPanelBase, IGridProxy<IHonamiStoryWeaponToggleItemData>
{
	// Token: 0x1700131F RID: 4895
	// (get) Token: 0x0600F4B9 RID: 62649 RVA: 0x003B09CF File Offset: 0x003AEBCF
	// (set) Token: 0x0600F4BA RID: 62650 RVA: 0x003B09D7 File Offset: 0x003AEBD7
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

	// Token: 0x17001320 RID: 4896
	// (get) Token: 0x0600F4BB RID: 62651 RVA: 0x003B09E0 File Offset: 0x003AEBE0
	// (set) Token: 0x0600F4BC RID: 62652 RVA: 0x003B09E8 File Offset: 0x003AEBE8
	public int GridIndex { get; set; }

	// Token: 0x17001321 RID: 4897
	// (get) Token: 0x0600F4BD RID: 62653 RVA: 0x003B09F1 File Offset: 0x003AEBF1
	// (set) Token: 0x0600F4BE RID: 62654 RVA: 0x003B09F9 File Offset: 0x003AEBF9
	public int DisplayIndex { get; set; }

	// Token: 0x0600F4BF RID: 62655 RVA: 0x003B0A04 File Offset: 0x003AEC04
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

	// Token: 0x0600F4C0 RID: 62656 RVA: 0x003B0C80 File Offset: 0x003AEE80
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryWeaponToggleItem.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryWeaponToggleItem.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F4C1 RID: 62657 RVA: 0x003B0CC3 File Offset: 0x003AEEC3
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

	// Token: 0x0600F4C2 RID: 62658 RVA: 0x003B0CF8 File Offset: 0x003AEEF8
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
			int[] source = config.Value.SuitId();
			this.RefreshSuitActiveItems(source.ToList<int>());
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

	// Token: 0x0600F4C3 RID: 62659 RVA: 0x003B0F44 File Offset: 0x003AF144
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

	// Token: 0x0600F4C4 RID: 62660 RVA: 0x003B0FC0 File Offset: 0x003AF1C0
	private void RefreshSuitActiveItems(List<int> suitIdList)
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

	// Token: 0x17001322 RID: 4898
	// (get) Token: 0x0600F4C5 RID: 62661 RVA: 0x003B1062 File Offset: 0x003AF262
	public int WeaponId
	{
		get
		{
			return this.WeaponIdInternal;
		}
	}

	// Token: 0x0600F4C6 RID: 62662 RVA: 0x003B106A File Offset: 0x003AF26A
	[NullableContext(2)]
	public HonamiStoryRoleEquipData GetEquipData()
	{
		return this.EquipData;
	}

	// Token: 0x0600F4C7 RID: 62663 RVA: 0x003B1072 File Offset: 0x003AF272
	public void BindWeaponToggleClick(Action<HonamiStoryWeaponToggleItem> callback)
	{
		this.OnWeaponToggleClick = callback;
	}

	// Token: 0x0600F4C8 RID: 62664 RVA: 0x003B107C File Offset: 0x003AF27C
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

	// Token: 0x0600F4C9 RID: 62665 RVA: 0x003B10D0 File Offset: 0x003AF2D0
	private void OnToggle(EToggleState toggleState)
	{
		this.OnUndeterminedClicked();
	}

	// Token: 0x0600F4CA RID: 62666 RVA: 0x003B10D8 File Offset: 0x003AF2D8
	public void OnSelected()
	{
		base.GetExtendToggle(5).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600F4CB RID: 62667 RVA: 0x003B10EA File Offset: 0x003AF2EA
	public void OnDeselected()
	{
		base.GetExtendToggle(5).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600F4CC RID: 62668 RVA: 0x003B10FC File Offset: 0x003AF2FC
	public void Clear()
	{
	}

	// Token: 0x0600F4CD RID: 62669 RVA: 0x003B10FE File Offset: 0x003AF2FE
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600F4CE RID: 62670 RVA: 0x003B1100 File Offset: 0x003AF300
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x0600F4CF RID: 62671 RVA: 0x003B1102 File Offset: 0x003AF302
	public object GetKey(IHonamiStoryWeaponToggleItemData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x0600F4D0 RID: 62672 RVA: 0x003B110F File Offset: 0x003AF30F
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

	// Token: 0x0600F4D1 RID: 62673 RVA: 0x003B1144 File Offset: 0x003AF344
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

	// Token: 0x0600F4D2 RID: 62674 RVA: 0x003B11C0 File Offset: 0x003AF3C0
	public void ResetToggleState()
	{
		base.GetExtendToggle(5).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04007138 RID: 28984
	private const int SUIT_ITEM_COUNT = 3;

	// Token: 0x04007139 RID: 28985
	private int WeaponIdInternal;

	// Token: 0x0400713A RID: 28986
	private EHonamiStoryWeaponUseWay UseWayInternal;

	// Token: 0x0400713B RID: 28987
	private Action<HonamiStoryWeaponToggleItem> OnWeaponToggleClick;

	// Token: 0x0400713C RID: 28988
	private List<HonamiStoryWeaponSuitActiveItem> SuitActiveItemList = new List<HonamiStoryWeaponSuitActiveItem>();

	// Token: 0x0400713D RID: 28989
	[Nullable(2)]
	private HonamiStoryRoleEquipData EquipData;

	// Token: 0x02008517 RID: 34071
	[NullableContext(0)]
	private enum EHonamiStoryWeaponToggleItemComponent
	{
		// Token: 0x0402B4FD RID: 177405
		IconTexture,
		// Token: 0x0402B4FE RID: 177406
		SuitItemOne,
		// Token: 0x0402B4FF RID: 177407
		SuitItemTwo,
		// Token: 0x0402B500 RID: 177408
		SuitItemThree,
		// Token: 0x0402B501 RID: 177409
		NewItem,
		// Token: 0x0402B502 RID: 177410
		Toggle,
		// Token: 0x0402B503 RID: 177411
		SuitPanel,
		// Token: 0x0402B504 RID: 177412
		LockPanel,
		// Token: 0x0402B505 RID: 177413
		InfoPanel,
		// Token: 0x0402B506 RID: 177414
		RoleItem,
		// Token: 0x0402B507 RID: 177415
		RoleTexture,
		// Token: 0x0402B508 RID: 177416
		NumItem,
		// Token: 0x0402B509 RID: 177417
		NumText,
		// Token: 0x0402B50A RID: 177418
		SpriteEmpty,
		// Token: 0x0402B50B RID: 177419
		SpriteRoleLight,
		// Token: 0x0402B50C RID: 177420
		SpriteNumLight
	}
}
