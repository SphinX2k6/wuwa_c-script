using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.SmallItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.Skin;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000E23 RID: 3619
[NullableContext(2)]
[Nullable(0)]
public class SmallItemGrid : ItemGridBase
{
	// Token: 0x06009244 RID: 37444 RVA: 0x002BB2FC File Offset: 0x002B94FC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009245 RID: 37445 RVA: 0x002BB4B3 File Offset: 0x002B96B3
	protected override void OnStart()
	{
		UUISprite sprite = base.GetSprite(8);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x06009246 RID: 37446 RVA: 0x002BB4C7 File Offset: 0x002B96C7
	[NullableContext(1)]
	protected override UUIItem OnSetUnderTextAdditionItem()
	{
		return base.GetItem(9);
	}

	// Token: 0x06009247 RID: 37447 RVA: 0x002BB4D1 File Offset: 0x002B96D1
	[NullableContext(1)]
	protected override UUIItem OnSetBottomAdditionItem()
	{
		return base.GetItem(5);
	}

	// Token: 0x06009248 RID: 37448 RVA: 0x002BB4DA File Offset: 0x002B96DA
	[NullableContext(1)]
	protected override UUIItem OnSetTopAdditionItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x06009249 RID: 37449 RVA: 0x002BB4E3 File Offset: 0x002B96E3
	[NullableContext(1)]
	public override UUIExtendToggle GetItemGridExtendToggle()
	{
		return base.GetExtendToggle(7);
	}

	// Token: 0x0600924A RID: 37450 RVA: 0x002BB4EC File Offset: 0x002B96EC
	[NullableContext(1)]
	public void Apply<[Nullable(0)] T>(T parameters) where T : IMediumItemGridBase
	{
		base.ClearVisibleComponent();
		base.ClearComponentList();
		ESmallItemGridType type = parameters.Type;
		bool flag = type - ESmallItemGridType.Character <= 2;
		bool flag2;
		if (flag)
		{
			SmallItemGridBase smallItemGridBase = parameters as SmallItemGridBase;
			if (smallItemGridBase != null)
			{
				flag2 = smallItemGridBase.IsDoubleRewardVisible.GetValueOrDefault();
				goto IL_46;
			}
		}
		flag2 = false;
		IL_46:
		if (!flag2)
		{
			this.SetDoubleRewardVisible(false);
		}
		if (parameters.Type == ESmallItemGridType.Empty)
		{
			this.ApplyEmptySmallItemGrid(parameters as EmptySmallItemGrid);
		}
		if (parameters.Type == ESmallItemGridType.Prop)
		{
			this.ApplyPropSmallItemGrid(parameters as PropSmallItemGrid);
		}
		if (parameters.Type == ESmallItemGridType.Phantom)
		{
			this.ApplyPhantomSmallItemGrid(parameters as PhantomSmallItemGrid);
		}
		if (parameters.Type == ESmallItemGridType.Character)
		{
			this.ApplyCharacterSmallItemGrid(parameters as CharacterSmallItemGrid);
		}
		if (parameters.Type == ESmallItemGridType.ForecastCharacter)
		{
			this.ApplyForecastCharacterSmallItemGrid(parameters as ForecastCharacterSmallItemGrid);
		}
		if (parameters.Type == ESmallItemGridType.CharacterOrnament)
		{
			this.ApplyCharacterOrnamentSmallItemGrid(parameters as CharacterOrnamentSmallItemGrid);
		}
		if (parameters.Type == ESmallItemGridType.Kurotato)
		{
			this.ApplyKurotatoWeaponSmallItemGrid(parameters as KurotatoSmallItemGrid);
		}
		if (parameters.Type == ESmallItemGridType.Weapon)
		{
			this.ApplyWeaponSmallItemGrid(parameters as WeaponSmallItemGrid);
		}
		base.RefreshComponentVisible();
		base.RefreshComponentHierarchyIndex();
	}

	// Token: 0x0600924B RID: 37451 RVA: 0x002BB65C File Offset: 0x002B985C
	public void ApplyEmptySmallItemGrid(EmptySmallItemGrid parameters)
	{
		this.SetEmptySlotVisible(true);
		this.SetTexture(null);
		this.SetSkinItemQuality(null);
		this.SetBottomTextVisible(false);
		this.SetQuality(null);
		base.SetExtendToggleEnable(false, false);
		this.SetElement(null);
		this.SetDirectionalFusionComponent(null);
	}

	// Token: 0x0600924C RID: 37452 RVA: 0x002BB6C4 File Offset: 0x002B98C4
	public void ApplyEmptyWithoutAddSmallItemGrid(EmptySmallItemGrid parameters)
	{
		base.ClearVisibleComponent();
		base.ClearComponentList();
		this.SetDoubleRewardVisible(false);
		this.SetTexture(null);
		this.SetSkinItemQuality(null);
		this.SetBottomTextVisible(false);
		this.SetQuality(null);
		base.SetExtendToggleEnable(false, false);
		this.SetElement(null);
		base.RefreshComponentVisible();
		base.RefreshComponentHierarchyIndex();
	}

	// Token: 0x0600924D RID: 37453 RVA: 0x002BB734 File Offset: 0x002B9934
	public void ApplyPropSmallItemGrid(PropSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		bool valueOrDefault = parameters.IsLockVisible.GetValueOrDefault();
		bool valueOrDefault2 = parameters.IsReceivableVisible.GetValueOrDefault();
		bool valueOrDefault3 = parameters.IsLockVisibleBlack.GetValueOrDefault();
		bool valueOrDefault4 = parameters.IsStarReceivableVisible.GetValueOrDefault();
		bool valueOrDefault5 = parameters.IsReceivedVisible.GetValueOrDefault();
		bool? isNewVisible = parameters.IsNewVisible;
		bool? isNotFoundVisible = parameters.IsNotFoundVisible;
		int? coolDownTime = parameters.CoolDownTime;
		float? coolDown = (coolDownTime != null) ? new float?((float)coolDownTime.GetValueOrDefault()) : null;
		bool? isDisable = parameters.IsDisable;
		bool? isBirthdayEffectVisible = parameters.IsBirthdayEffectVisible;
		bool? isOrnamentConflictVisible = parameters.IsOrnamentConflictVisible;
		bool valueOrDefault6 = parameters.IsDoubleRewardVisible.GetValueOrDefault();
		this.SetIsDisable(isDisable);
		this.SetLockVisible(valueOrDefault);
		this.SetLockBlackVisible(valueOrDefault3);
		this.SetReceivableVisible(valueOrDefault2);
		this.SetReceivedVisible(valueOrDefault5);
		this.SetNewFlagVisible(isNewVisible);
		this.SetTimeFlagVisible(parameters.IsTimeFlagVisible);
		this.SetNotFoundVisible(isNotFoundVisible);
		this.SetCoolDown(coolDown, null);
		this.SetRedDotVisible(parameters.IsRedDotVisible);
		this.SetBirthdayEffect(isBirthdayEffectVisible);
		this.ApplyPropBaseDisplay(parameters);
		this.SetElement(parameters.ElementId);
		this.SetRoleDevelopStateTag(parameters.RoleDevelopStateTagType);
		this.SetStarReceivableVisible(valueOrDefault4);
		this.SetOrnamentConflictVisible(isOrnamentConflictVisible);
		this.SetDoubleRewardVisible(valueOrDefault6);
	}

	// Token: 0x0600924E RID: 37454 RVA: 0x002BB880 File Offset: 0x002B9A80
	[NullableContext(1)]
	public void ApplyPhantomSmallItemGrid(PhantomSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		bool valueOrDefault = parameters.IsLockVisible.GetValueOrDefault();
		bool valueOrDefault2 = parameters.IsLockVisibleBlack.GetValueOrDefault();
		bool valueOrDefault3 = parameters.IsReceivableVisible.GetValueOrDefault();
		bool valueOrDefault4 = parameters.IsReceivedVisible.GetValueOrDefault();
		bool? isNewVisible = parameters.IsNewVisible;
		bool? isNotFoundVisible = parameters.IsNotFoundVisible;
		bool valueOrDefault5 = parameters.IsSelectedFlag.GetValueOrDefault();
		int? visionRoleHeadInfo = parameters.VisionRoleHeadInfo;
		int? fetterGroupId = parameters.FetterGroupId;
		this.SetLockVisible(valueOrDefault);
		this.SetLockAndDepracte(parameters.IsPhantomLock, parameters.IsPhantomDeprecate);
		this.SetLockBlackVisible(valueOrDefault2);
		this.SetReceivableVisible(valueOrDefault3);
		this.SetReceivedVisible(valueOrDefault4);
		this.SetNewFlagVisible(isNewVisible);
		this.SetNotFoundVisible(isNotFoundVisible);
		this.SetSelectedFlagVisible(valueOrDefault5);
		this.SetVisionRoleHead(visionRoleHeadInfo);
		this.SetVisionFetterGroup(fetterGroupId);
		this.SetRedDotVisible(parameters.IsRedDotVisible);
		this.ApplyPhantomBaseDisplay(parameters);
		this.SetDoubleRewardVisible(parameters.IsDoubleRewardVisible.GetValueOrDefault());
		this.SetMultiPlayerVisible(parameters.MultiPlayer);
	}

	// Token: 0x0600924F RID: 37455 RVA: 0x002BB974 File Offset: 0x002B9B74
	public void ApplyCharacterSmallItemGrid(CharacterSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		bool valueOrDefault = parameters.IsLockVisible.GetValueOrDefault();
		bool valueOrDefault2 = parameters.IsReceivableVisible.GetValueOrDefault();
		bool valueOrDefault3 = parameters.IsReceivedVisible.GetValueOrDefault();
		bool valueOrDefault4 = parameters.IsSelectedFlag.GetValueOrDefault();
		bool valueOrDefault5 = parameters.IsCookUp.GetValueOrDefault();
		bool valueOrDefault6 = parameters.IsBlack.GetValueOrDefault();
		this.SetIsBlack(valueOrDefault6);
		this.SetLockVisible(valueOrDefault);
		this.SetReceivableVisible(valueOrDefault2);
		this.SetReceivedVisible(valueOrDefault3);
		this.SetSelectedFlagVisible(valueOrDefault4);
		this.SetCookUpVisible(valueOrDefault5);
		this.SetElement(parameters.ElementId);
		this.SetRedDotVisible(parameters.IsRedDotVisible);
		this.ApplyCharacterBaseDisplay(parameters);
		this.SetDoubleRewardVisible(parameters.IsDoubleRewardVisible.GetValueOrDefault());
	}

	// Token: 0x06009250 RID: 37456 RVA: 0x002BBA2B File Offset: 0x002B9C2B
	public void ApplyForecastCharacterSmallItemGrid(ForecastCharacterSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		this.ApplyForecastCharacterBaseDisplay(parameters);
	}

	// Token: 0x06009251 RID: 37457 RVA: 0x002BBA38 File Offset: 0x002B9C38
	public void ApplyWeaponSmallItemGrid(WeaponSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		this.SetIsDisable(parameters.IsDisable);
		this.RefreshWeaponLevelText(parameters.Level);
		this.SetWeaponResonanceLevel(parameters.ResonanceLevel);
		this.SetWeaponFlagVisible(parameters.IsWeaponFlagVisible);
		this.ApplyWeaponBaseDisplay(parameters);
	}

	// Token: 0x06009252 RID: 37458 RVA: 0x002BBA75 File Offset: 0x002B9C75
	private void ApplyWeaponBaseDisplay(WeaponSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		this.Data = parameters.Data;
		this.SetTexture(parameters.ItemConfigId);
		this.SetItemQuality(parameters);
		base.SetExtendToggleEnable(true, false);
	}

	// Token: 0x06009253 RID: 37459 RVA: 0x002BBAA4 File Offset: 0x002B9CA4
	private void RefreshWeaponLevelText(int? level)
	{
		bool flag = level > 0;
		this.SetBottomTextVisible(flag);
		if (flag)
		{
			this.SetBottomTextId("Text_LevelShow_Text", new object[]
			{
				level.Value
			});
		}
	}

	// Token: 0x06009254 RID: 37460 RVA: 0x002BBAF4 File Offset: 0x002B9CF4
	[NullableContext(1)]
	public void ApplyKurotatoWeaponSmallItemGrid(KurotatoSmallItemGrid param)
	{
		this.SetRedDotVisible(param.IsRedDotVisible);
		this.SetReceivedVisible(param.IsReceivedVisible.GetValueOrDefault());
		if (param.CardType == EKurotatoCardType.Weapon)
		{
			KurotatoWeapon? config = ConfigKurotatoWeaponById.GetConfig(param.Id, true);
			if (config != null)
			{
				KurotatoWeaponGroup? config2 = ConfigKurotatoWeaponGroupById.GetConfig(config.Value.GroupId, true);
				if (config2 != null && !string.IsNullOrEmpty(config2.Value.Icon))
				{
					this.SetTextureByIconPath(config2.Value.Icon);
				}
			}
			this.SetSkinQuality(null);
		}
		else
		{
			KurotatoItem? config3 = ConfigKurotatoItemById.GetConfig(param.Id, true);
			if (config3 != null && !string.IsNullOrEmpty(config3.Value.Icon))
			{
				this.SetTextureByIconPath(config3.Value.Icon);
			}
			this.SetSkinQuality(null);
		}
		this.SetKurotatoItemQuality(param);
		this.RefreshBottomText(param);
		this.SetRightTopValueInfo(param.RightTopValue);
		base.SetExtendToggleEnable(true, false);
	}

	// Token: 0x06009255 RID: 37461 RVA: 0x002BBC10 File Offset: 0x002B9E10
	[NullableContext(1)]
	private void SetKurotatoItemQuality(KurotatoSmallItemGrid param)
	{
		int id = param.Id;
		UUISprite sprite = base.GetSprite(0);
		if (this.QualityItemConfigId == id)
		{
			sprite.SetUIActive(true);
			return;
		}
		string mediumItemGridQualitySpritePath = ConfigKurotatoQualityById.GetConfig(param.QualityId.Value, true).Value.MediumItemGridQualitySpritePath;
		this.SetSpriteByPath(mediumItemGridQualitySpritePath, sprite, true, null, null);
		sprite.SetUIActive(true);
		this.QualityItemConfigId = id;
	}

	// Token: 0x06009256 RID: 37462 RVA: 0x002BBC84 File Offset: 0x002B9E84
	public void ApplyCharacterOrnamentSmallItemGrid(CharacterOrnamentSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		bool valueOrDefault = parameters.IsLockVisibleBlack.GetValueOrDefault();
		bool valueOrDefault2 = parameters.IsReceivableVisible.GetValueOrDefault();
		bool valueOrDefault3 = parameters.IsReceivedVisible.GetValueOrDefault();
		bool valueOrDefault4 = parameters.IsSelectedFlag.GetValueOrDefault();
		bool valueOrDefault5 = parameters.IsOrnamentConflictVisible.GetValueOrDefault();
		this.SetLockBlackVisible(valueOrDefault);
		this.SetReceivableVisible(valueOrDefault2);
		this.SetReceivedVisible(valueOrDefault3);
		this.SetSelectedFlagVisible(valueOrDefault4);
		this.SetOrnamentConflictVisible(new bool?(valueOrDefault5));
		this.SetRedDotVisible(parameters.IsRedDotVisible);
		this.ApplyCharacterOrnamentBaseDisplay(parameters);
	}

	// Token: 0x06009257 RID: 37463 RVA: 0x002BBD10 File Offset: 0x002B9F10
	private void ApplyPropBaseDisplay(PropSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		int? itemConfigId = parameters.ItemConfigId;
		this.Data = parameters.Data;
		UUITexture texture = base.GetTexture(1);
		InventoryDefine.EItemDataType? eitemDataType = new InventoryDefine.EItemDataType?(InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(parameters.ItemConfigId.GetValueOrDefault())));
		if (parameters.IsIconHide != null && itemConfigId.GetValueOrDefault() > 0)
		{
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
		}
		else if (!string.IsNullOrEmpty(parameters.IconPath))
		{
			base.SetTextureByPath(parameters.IconPath, texture, null, null);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
		}
		else if (eitemDataType.GetValueOrDefault() == InventoryDefine.EItemDataType.DangoAbyssItem)
		{
			this.SetDangoItemTexture(itemConfigId.Value);
		}
		else if (eitemDataType.GetValueOrDefault() == InventoryDefine.EItemDataType.HonamiStoryItem)
		{
			this.SetHonamiStoryItemTexture(itemConfigId.Value);
		}
		else if (eitemDataType.GetValueOrDefault() == InventoryDefine.EItemDataType.MotorStickerItem)
		{
			this.SetMotorStickerTexture(itemConfigId.Value);
		}
		else
		{
			this.SetTexture(itemConfigId);
		}
		this.SetItemQuality(parameters);
		this.SetIconSprite(parameters.SpriteIconPath);
		this.RefreshBottomText(parameters);
		this.RefreshTopRightText(parameters);
		base.SetExtendToggleEnable(true, false);
		this.RefreshSkin(parameters, itemConfigId);
	}

	// Token: 0x06009258 RID: 37464 RVA: 0x002BBE3C File Offset: 0x002BA03C
	public void SetElement(int? elementId)
	{
		base.RefreshComponent(typeof(SmallItemGridElementComponent), new bool?(elementId != null), elementId);
	}

	// Token: 0x06009259 RID: 37465 RVA: 0x002BBE61 File Offset: 0x002BA061
	public void SetDirectionalFusionComponent(int? phantomFetterId)
	{
		base.RefreshComponent(typeof(SmallItemGridDirectionalFusionComponent), new bool?(phantomFetterId != null), phantomFetterId);
	}

	// Token: 0x0600925A RID: 37466 RVA: 0x002BBE88 File Offset: 0x002BA088
	[NullableContext(1)]
	private void ApplyPhantomBaseDisplay(PhantomSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		int? itemConfigId = parameters.ItemConfigId;
		int? monsterId = parameters.MonsterId;
		int? phantomId = parameters.PhantomId;
		string qualityIconResourceId = parameters.QualityIconResourceId;
		bool? isQualityHidden = parameters.IsQualityHidden;
		bool? iconHidden = parameters.IconHidden;
		this.Data = parameters.Data;
		if (iconHidden.GetValueOrDefault())
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
		}
		else if (monsterId != null)
		{
			this.SetMonsterTexture(monsterId.Value);
		}
		else if (phantomId != null)
		{
			this.SetPhantomTexture(phantomId.Value);
		}
		else
		{
			this.SetTexture(itemConfigId);
		}
		UUISprite sprite = base.GetSprite(0);
		if (isQualityHidden.GetValueOrDefault())
		{
			sprite.SetUIActive(false);
		}
		else if (qualityIconResourceId != null)
		{
			this.SetQualityByResourceId(qualityIconResourceId);
			this.QualityItemConfigId = parameters.ItemConfigId.GetValueOrDefault();
		}
		else
		{
			this.SetQuality(itemConfigId);
		}
		this.RefreshBottomText(parameters);
		this.RefreshTopRightText(parameters);
		base.SetExtendToggleEnable(true, false);
	}

	// Token: 0x0600925B RID: 37467 RVA: 0x002BBF7C File Offset: 0x002BA17C
	private void ApplyCharacterBaseDisplay(SmallItemGridBase parameters)
	{
		if (parameters == null)
		{
			return;
		}
		int num = parameters.ItemConfigId.Value;
		this.Data = parameters.Data;
		UUITexture texture = base.GetTexture(1);
		if (num > 10000)
		{
			num = RoleConfig.Instance.GetTrialRoleConfig(num).Value.ParentId;
		}
		int? skinId = parameters.SkinId;
		if (skinId != null)
		{
			string roleHeadIconLarge = SkinConfig.Instance.GetRoleSkinConfig(skinId.Value).Value.RoleHeadIconLarge;
			base.SetRoleSkinIcon(roleHeadIconLarge, texture, skinId.Value, null, null);
		}
		else
		{
			string roleHeadIconBig = RoleConfig.Instance.GetRoleConfig(num).Value.RoleHeadIconBig;
			base.SetRoleIcon(roleHeadIconBig, texture, num, null, null);
		}
		texture.SetUIActive(true);
		this.SetNormalItemQualityInternal(parameters.IsQualityHidden, parameters.QualityId, new int?(num), parameters.QualityIcon, parameters.QualityType);
		this.RefreshBottomText(parameters);
		this.RefreshTopRightText(parameters);
		base.SetExtendToggleEnable(true, false);
	}

	// Token: 0x0600925C RID: 37468 RVA: 0x002BC09C File Offset: 0x002BA29C
	private void ApplyForecastCharacterBaseDisplay(ForecastCharacterSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		this.Data = parameters.Data;
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(parameters.RoleId.Value);
		int elementId = roleDevProsProjectConfig.ElementId;
		string roleHeadIcon = roleDevProsProjectConfig.RoleHeadIcon;
		this.SetTextureByIconPath(roleHeadIcon);
		this.SetBottomTextId("Text_LevelShow_Text", new object[]
		{
			1
		});
		this.SetElement(new int?(elementId));
		base.SetExtendToggleEnable(true, false);
	}

	// Token: 0x0600925D RID: 37469 RVA: 0x002BC110 File Offset: 0x002BA310
	private void ApplyCharacterOrnamentBaseDisplay(CharacterOrnamentSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		this.Data = parameters.Data;
		int value = parameters.ItemConfigId.Value;
		this.SetTexture(new int?(value));
		this.SetItemQuality(parameters);
		this.RefreshBottomText(parameters);
		this.RefreshTopRightText(parameters);
		base.SetExtendToggleEnable(true, false);
		this.RefreshSkin(parameters, new int?(value));
	}

	// Token: 0x0600925E RID: 37470 RVA: 0x002BC16F File Offset: 0x002BA36F
	public void SetLockVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridLockComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600925F RID: 37471 RVA: 0x002BC18E File Offset: 0x002BA38E
	public void SetArrowVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridArrowComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x06009260 RID: 37472 RVA: 0x002BC1B0 File Offset: 0x002BA3B0
	public void SetLockAndDepracte(bool? isLock, bool? isDeprecate)
	{
		ISmallItemGridLockAndDeprecate @params = new SmallItemGridLockAndDeprecate
		{
			IsLock = isLock,
			IsDeprecate = isDeprecate
		};
		bool value = isLock.GetValueOrDefault() || isDeprecate.GetValueOrDefault();
		base.RefreshComponent(typeof(SmallItemGridLockAndDeprecateComponent), new bool?(value), @params);
	}

	// Token: 0x06009261 RID: 37473 RVA: 0x002BC1FD File Offset: 0x002BA3FD
	public void SetLockBlackVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridLockBlackComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x06009262 RID: 37474 RVA: 0x002BC21C File Offset: 0x002BA41C
	public void SetLockBlackBigVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridLockBlackBigComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x06009263 RID: 37475 RVA: 0x002BC23B File Offset: 0x002BA43B
	public void SetCurrentEquipmentVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridCurrentEquipmentComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x06009264 RID: 37476 RVA: 0x002BC25A File Offset: 0x002BA45A
	public void SetReceivableVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridReceivableComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x06009265 RID: 37477 RVA: 0x002BC279 File Offset: 0x002BA479
	public void SetStarReceivableVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridStarReceivableComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x06009266 RID: 37478 RVA: 0x002BC298 File Offset: 0x002BA498
	public void SetPreviewVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridPreviewComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x06009267 RID: 37479 RVA: 0x002BC2B7 File Offset: 0x002BA4B7
	public void SetReceivedVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridReceivedComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x06009268 RID: 37480 RVA: 0x002BC2D8 File Offset: 0x002BA4D8
	[NullableContext(1)]
	public void SetReceivedColor(string hexColor)
	{
		SmallItemGridReceivedComponent smallItemGridReceivedComponent = base.RefreshComponent(typeof(SmallItemGridReceivedComponent), new bool?(false), true) as SmallItemGridReceivedComponent;
		if (smallItemGridReceivedComponent == null)
		{
			return;
		}
		smallItemGridReceivedComponent.GetAsync().ContinueWith(delegate(ItemGridComponent component)
		{
			SmallItemGridReceivedComponent smallItemGridReceivedComponent2 = component as SmallItemGridReceivedComponent;
			if (smallItemGridReceivedComponent2 == null)
			{
				return;
			}
			smallItemGridReceivedComponent2.SetSpriteColor(hexColor);
		});
	}

	// Token: 0x06009269 RID: 37481 RVA: 0x002BC330 File Offset: 0x002BA530
	public void SetSelectedFlagVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridSelectedFlagComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600926A RID: 37482 RVA: 0x002BC34F File Offset: 0x002BA54F
	public void SetSelectVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridSelectComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600926B RID: 37483 RVA: 0x002BC36E File Offset: 0x002BA56E
	private void SetCookUpVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridCookUpComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600926C RID: 37484 RVA: 0x002BC38D File Offset: 0x002BA58D
	public void SetFirstRewardVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridFirstRewardComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600926D RID: 37485 RVA: 0x002BC3AC File Offset: 0x002BA5AC
	public void SetExchangeRewardVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridExchangeRewardComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600926E RID: 37486 RVA: 0x002BC3CB File Offset: 0x002BA5CB
	public void SetDoubleRewardVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridDoubleRewardComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600926F RID: 37487 RVA: 0x002BC3EC File Offset: 0x002BA5EC
	[NullableContext(1)]
	protected void SetTextureByIconPath(string iconPath)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetUIActive(true);
		}
		base.SetTextureByPath(iconPath, texture, null, null);
	}

	// Token: 0x06009270 RID: 37488 RVA: 0x002BC420 File Offset: 0x002BA620
	private void SetTexture(int? itemConfigId)
	{
		UUITexture texture = base.GetTexture(1);
		if (itemConfigId == null)
		{
			texture.SetUIActive(false);
			return;
		}
		base.SetItemIcon(texture, itemConfigId.Value, null, null);
		texture.SetUIActive(true);
	}

	// Token: 0x06009271 RID: 37489 RVA: 0x002BC468 File Offset: 0x002BA668
	private void SetMotorStickerTexture(int itemId)
	{
		UUITexture texture = base.GetTexture(1);
		MotorSticker? motorSticker;
		string text = (MotorDiyConfig.Instance.GetMotorStickerConfig(itemId) != null) ? motorSticker.GetValueOrDefault().Icon : null;
		if (string.IsNullOrEmpty(text))
		{
			texture.SetUIActive(false);
			return;
		}
		base.SetTextureByPath(text, texture, null, null);
		texture.SetUIActive(true);
	}

	// Token: 0x06009272 RID: 37490 RVA: 0x002BC4D0 File Offset: 0x002BA6D0
	private void SetDangoItemTexture(int itemId)
	{
		IDangoPluginIconInfo dangoPluginIcon = new DangoPluginIconInfo
		{
			PluginItemId = itemId
		};
		this.SetDangoPluginIcon(dangoPluginIcon);
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		texture.SetUIActive(false);
	}

	// Token: 0x06009273 RID: 37491 RVA: 0x002BC504 File Offset: 0x002BA704
	private void SetHonamiStoryItemTexture(int itemId)
	{
		UUITexture texture = base.GetTexture(1);
		HonamiStoryItem? honamiStoryItem = HonamiStoryConfig.Instance.GetHonamiStoryItem(itemId);
		if (honamiStoryItem == null || honamiStoryItem == null)
		{
			texture.SetUIActive(false);
			return;
		}
		base.SetTextureByPath(honamiStoryItem.Value.IconMiddle, texture, null, null);
		texture.SetUIActive(true);
	}

	// Token: 0x06009274 RID: 37492 RVA: 0x002BC568 File Offset: 0x002BA768
	private void SetMonsterTexture(int monsterId)
	{
		UUITexture texture = base.GetTexture(1);
		string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(monsterId);
		base.SetTextureByPath(monsterIcon, texture, null, null);
		texture.SetUIActive(true);
	}

	// Token: 0x06009275 RID: 37493 RVA: 0x002BC5A4 File Offset: 0x002BA7A4
	private void SetPhantomTexture(int phantomId)
	{
		UUITexture texture = base.GetTexture(1);
		base.SetTextureByPath(PhantomBattleConfig.Instance.GetPhantomItemById(phantomId).Value.IconMiddle, texture, null, null);
		texture.SetUIActive(true);
	}

	// Token: 0x06009276 RID: 37494 RVA: 0x002BC5EC File Offset: 0x002BA7EC
	[NullableContext(1)]
	public void RefreshSkin(SmallItemGridBase parameters, int? itemId)
	{
		ISmallItemGridSkinComponentParams smallItemGridSkinComponentParams = new SmallItemGridSkinComponentParams
		{
			SkinId = itemId,
			BottomText = parameters.BottomText
		};
		bool flag = false;
		if (itemId != null)
		{
			InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId.Value));
			flag = (itemDataTypeByConfigId == InventoryDefine.EItemDataType.WeaponSkinItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleSkinItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.FlySkinItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.CalabashSkinItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.OrnamentItem);
		}
		if (flag)
		{
			this.SetBottomTextVisible(false);
		}
		base.RefreshComponent(typeof(SmallItemGridSkinComponent), new bool?(flag), flag ? smallItemGridSkinComponentParams : null);
	}

	// Token: 0x06009277 RID: 37495 RVA: 0x002BC67C File Offset: 0x002BA87C
	public void SetIconSprite(string iconSpritePath)
	{
		UUISprite sprite = base.GetSprite(11);
		if (string.IsNullOrEmpty(iconSpritePath))
		{
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			return;
		}
		this.SetSpriteByPath(iconSpritePath, sprite, false, null, null);
		if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
	}

	// Token: 0x06009278 RID: 37496 RVA: 0x002BC6C4 File Offset: 0x002BA8C4
	public void RefreshSkinByDefault(int qualityId, InventoryDefine.EItemDataType itemType)
	{
		ISmallItemGridSkinComponentParams @params = new SmallItemGridSkinComponentParams
		{
			QualityId = new int?(qualityId)
		};
		if (itemType == InventoryDefine.EItemDataType.WeaponSkinItem || itemType == InventoryDefine.EItemDataType.RoleSkinItem || itemType == InventoryDefine.EItemDataType.FlySkinItem || itemType == InventoryDefine.EItemDataType.CalabashSkinItem || itemType == InventoryDefine.EItemDataType.OrnamentItem)
		{
			this.SetBottomTextVisible(false);
		}
		base.RefreshComponent(typeof(SmallItemGridSkinComponent), new bool?(true), @params);
	}

	// Token: 0x06009279 RID: 37497 RVA: 0x002BC71C File Offset: 0x002BA91C
	[NullableContext(1)]
	public void SetItemQuality(SmallItemGridBase parameters)
	{
		if (parameters.ItemConfigId == null)
		{
			this.SetSkinQuality(null);
			this.SetNormalItemQuality(parameters);
			return;
		}
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(parameters.ItemConfigId.Value));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.WeaponSkinItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleSkinItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.FlySkinItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.CalabashSkinItem)
		{
			this.SetSkinQualityByParameters(parameters);
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.DangoAbyssItem)
		{
			this.SetDangoAbyssItemQuality(parameters);
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.HonamiStoryItem)
		{
			this.SetHonamiStoryItemQuality(parameters);
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.PinballRoleItem || itemDataTypeByConfigId == InventoryDefine.EItemDataType.PinballWeaponItem)
		{
			this.SetPinballItemQuality(parameters);
			return;
		}
		this.SetSkinQuality(null);
		this.SetNormalItemQuality(parameters);
	}

	// Token: 0x0600927A RID: 37498 RVA: 0x002BC7C8 File Offset: 0x002BA9C8
	[NullableContext(1)]
	public void SetSkinQualityByParameters(SmallItemGridBase parameters)
	{
		this.SetQuality(null);
		this.SetSkinItemQuality(parameters);
	}

	// Token: 0x0600927B RID: 37499 RVA: 0x002BC7EC File Offset: 0x002BA9EC
	public void SetQuality(int? itemConfigId = null)
	{
		UUISprite sprite = base.GetSprite(0);
		if (itemConfigId == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		int qualityItemConfigId = this.QualityItemConfigId;
		int? num = itemConfigId;
		if (qualityItemConfigId == num.GetValueOrDefault() & num != null)
		{
			sprite.SetUIActive(true);
			return;
		}
		this.QualityItemConfigId = itemConfigId.Value;
		base.SetItemQualityIcon(sprite, itemConfigId.Value, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		sprite.SetUIActive(true);
	}

	// Token: 0x0600927C RID: 37500 RVA: 0x002BC864 File Offset: 0x002BAA64
	public void SetSkinQuality(int? itemConfigId = null)
	{
		UUISprite sprite = base.GetSprite(8);
		if (itemConfigId == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		int qualityItemConfigId = this.QualityItemConfigId;
		int? num = itemConfigId;
		if (qualityItemConfigId == num.GetValueOrDefault() & num != null)
		{
			sprite.SetUIActive(true);
			return;
		}
		this.QualityItemConfigId = itemConfigId.Value;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemConfigId.Value);
		this.SetSpriteByPath(CommonConfig.Instance.GetItemQualityById(itemConfigData.QualityId).Value.SkinQuality, sprite, false, null, null);
		sprite.SetUIActive(true);
	}

	// Token: 0x0600927D RID: 37501 RVA: 0x002BC908 File Offset: 0x002BAB08
	private void SetNormalItemQuality(SmallItemGridBase parameters)
	{
		UUISprite sprite = base.GetSprite(0);
		if (parameters == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		this.SetNormalItemQualityInternal(parameters.IsQualityHidden, parameters.QualityId, parameters.ItemConfigId, parameters.QualityIcon, parameters.QualityType);
	}

	// Token: 0x0600927E RID: 37502 RVA: 0x002BC94C File Offset: 0x002BAB4C
	private void SetPinballItemQuality(SmallItemGridBase parameters)
	{
		if (parameters == null || parameters.ItemConfigId == null)
		{
			base.GetSprite(0).SetUIActive(false);
			return;
		}
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(parameters.ItemConfigId.Value);
		if (itemConfigData == null)
		{
			base.GetSprite(0).SetUIActive(false);
			return;
		}
		this.SetNormalItemQualityInternal(parameters.IsQualityHidden, new int?(parameters.QualityId ?? itemConfigData.QualityId), parameters.ItemConfigId, parameters.QualityIcon, new CommonDefine.EQualityIconType?(parameters.QualityType.GetValueOrDefault(CommonDefine.EQualityIconType.TypeAGridQualitySpritePath)));
	}

	// Token: 0x0600927F RID: 37503 RVA: 0x002BC9EC File Offset: 0x002BABEC
	private void SetNormalItemQualityInternal(bool? isQualityHidden, int? qualityId, int? itemConfigId, string qualityIcon, CommonDefine.EQualityIconType? qualityType)
	{
		UUISprite sprite = base.GetSprite(0);
		if (isQualityHidden.GetValueOrDefault())
		{
			sprite.SetUIActive(false);
			return;
		}
		if (!string.IsNullOrEmpty(qualityIcon))
		{
			this.SetQualityIconById(qualityIcon);
			this.QualityItemConfigId = ((itemConfigId != null) ? itemConfigId.Value : 0);
			return;
		}
		int? num = qualityId;
		int num2 = 0;
		if (num.GetValueOrDefault() > num2 & num != null)
		{
			base.SetQualityIconById(sprite, qualityId.Value, null, qualityType, null);
			sprite.SetUIActive(true);
			this.QualityItemConfigId = ((itemConfigId != null) ? itemConfigId.Value : 0);
			return;
		}
		num = qualityId;
		num2 = 0;
		if (num.GetValueOrDefault() == num2 & num != null)
		{
			string defaultQualitySpritePath = SmallItemGridModel.Instance.DefaultQualitySpritePath;
			this.SetSpriteByPath(defaultQualitySpritePath, sprite, false, null, null);
			sprite.SetUIActive(true);
			this.QualityItemConfigId = ((itemConfigId != null) ? itemConfigId.Value : 0);
			return;
		}
		this.SetQuality(itemConfigId);
	}

	// Token: 0x06009280 RID: 37504 RVA: 0x002BCAF0 File Offset: 0x002BACF0
	private void SetSkinItemQuality(SmallItemGridBase parameters)
	{
		UUISprite sprite = base.GetSprite(8);
		if (parameters == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		if (parameters.IsQualityHidden.GetValueOrDefault())
		{
			sprite.SetUIActive(false);
			return;
		}
		int? qualityId = parameters.QualityId;
		int num = 0;
		if (qualityId.GetValueOrDefault() > num & qualityId != null)
		{
			this.SetSpriteByPath(CommonConfig.Instance.GetItemQualityById(parameters.QualityId.Value).Value.SkinQuality, sprite, false, null, null);
			sprite.SetUIActive(true);
			this.QualityItemConfigId = ((parameters.ItemConfigId != null) ? parameters.ItemConfigId.Value : 0);
			return;
		}
		qualityId = parameters.QualityId;
		num = 0;
		if (qualityId.GetValueOrDefault() == num & qualityId != null)
		{
			string defaultQualitySpritePath = SmallItemGridModel.Instance.DefaultQualitySpritePath;
			this.SetSpriteByPath(defaultQualitySpritePath, sprite, false, null, null);
			sprite.SetUIActive(true);
			this.QualityItemConfigId = ((parameters.ItemConfigId != null) ? parameters.ItemConfigId.Value : 0);
			return;
		}
		this.SetSkinQuality(parameters.ItemConfigId);
	}

	// Token: 0x06009281 RID: 37505 RVA: 0x002BCC18 File Offset: 0x002BAE18
	private void SetDangoAbyssItemQuality(SmallItemGridBase parameters)
	{
		UUISprite sprite = base.GetSprite(0);
		if (parameters == null || parameters.ItemConfigId == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		if (parameters.IsQualityHidden.GetValueOrDefault())
		{
			sprite.SetUIActive(false);
			return;
		}
		int qualityItemConfigId = this.QualityItemConfigId;
		int? itemConfigId = parameters.ItemConfigId;
		if (qualityItemConfigId == itemConfigId.GetValueOrDefault() & itemConfigId != null)
		{
			sprite.SetUIActive(true);
			return;
		}
		this.QualityItemConfigId = parameters.ItemConfigId.Value;
		AbyssQuality? abyssQualityByPluginItemId = DangoAbyssConfig.Instance.GetAbyssQualityByPluginItemId(parameters.ItemConfigId.Value);
		CommonDefine.EQualityIconType valueOrDefault = parameters.QualityType.GetValueOrDefault();
		string path = null;
		if (valueOrDefault == CommonDefine.EQualityIconType.BackgroundSprite)
		{
			path = (abyssQualityByPluginItemId.Value.BackgroundSprite ?? SmallItemGridModel.Instance.DefaultQualitySpritePath);
		}
		else if (valueOrDefault == CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath)
		{
			path = (abyssQualityByPluginItemId.Value.MediumItemGridQualitySpritePath ?? SmallItemGridModel.Instance.DefaultQualitySpritePath);
		}
		this.SetSpriteByPath(path, sprite, false, null, null);
		sprite.SetUIActive(true);
	}

	// Token: 0x06009282 RID: 37506 RVA: 0x002BCD1C File Offset: 0x002BAF1C
	private void SetHonamiStoryItemQuality(SmallItemGridBase parameters)
	{
		UUISprite sprite = base.GetSprite(0);
		if (parameters == null || parameters.ItemConfigId == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		if (parameters.IsQualityHidden.GetValueOrDefault())
		{
			sprite.SetUIActive(false);
			return;
		}
		int qualityItemConfigId = this.QualityItemConfigId;
		int? itemConfigId = parameters.ItemConfigId;
		if (qualityItemConfigId == itemConfigId.GetValueOrDefault() & itemConfigId != null)
		{
			sprite.SetUIActive(true);
			return;
		}
		this.QualityItemConfigId = parameters.ItemConfigId.Value;
		HonamiStoryItem? honamiStoryItem = HonamiStoryConfig.Instance.GetHonamiStoryItem(parameters.ItemConfigId.Value);
		HonamiStoryItemQuality? honamiStoryQuality = HonamiStoryConfig.Instance.GetHonamiStoryQuality(honamiStoryItem.Value.QualityId);
		CommonDefine.EQualityIconType valueOrDefault = parameters.QualityType.GetValueOrDefault();
		string path = null;
		if (valueOrDefault == CommonDefine.EQualityIconType.BackgroundSprite)
		{
			path = (honamiStoryQuality.Value.BackgroundSprite ?? SmallItemGridModel.Instance.DefaultQualitySpritePath);
		}
		else if (valueOrDefault == CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath)
		{
			path = (honamiStoryQuality.Value.MediumItemGridQualitySpritePath ?? SmallItemGridModel.Instance.DefaultQualitySpritePath);
		}
		this.SetSpriteByPath(path, sprite, false, null, null);
		sprite.SetUIActive(true);
	}

	// Token: 0x06009283 RID: 37507 RVA: 0x002BCE40 File Offset: 0x002BB040
	[NullableContext(1)]
	public void SetItemQualityByPath(string qualityIconPath)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		this.SetSpriteByPath(qualityIconPath, sprite, true, null, null);
		sprite.SetUIActive(true);
	}

	// Token: 0x06009284 RID: 37508 RVA: 0x002BCE7C File Offset: 0x002BB07C
	private void SetQualityByPath(string path)
	{
		UUISprite sprite = base.GetSprite(0);
		if (path == null)
		{
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			return;
		}
		if (StringUtils.IsEmpty(path))
		{
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			return;
		}
		this.SetSpriteByPath(path, sprite, true, null, null);
		if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
	}

	// Token: 0x06009285 RID: 37509 RVA: 0x002BCECF File Offset: 0x002BB0CF
	public void SetOrnamentConflictVisible(bool? bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridOrnamentConflictComponent), bVisible, bVisible);
	}

	// Token: 0x06009286 RID: 37510 RVA: 0x002BCEEC File Offset: 0x002BB0EC
	[NullableContext(1)]
	private void SetQualityByResourceId(string resourceId)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		if (StringUtils.IsEmpty(resourcePath))
		{
			sprite.SetUIActive(false);
			return;
		}
		this.SetSpriteByPath(resourcePath, sprite, true, null, null);
		sprite.SetUIActive(true);
	}

	// Token: 0x06009287 RID: 37511 RVA: 0x002BCF3C File Offset: 0x002BB13C
	[NullableContext(1)]
	private void RefreshBottomText(SmallItemGridBase parameters)
	{
		if (parameters == null)
		{
			return;
		}
		string bottomTextId = parameters.BottomTextId;
		string bottomText = parameters.BottomText;
		object[] bottomTextParameter = parameters.BottomTextParameter;
		bool flag = !StringUtils.IsEmpty(bottomTextId) || !StringUtils.IsEmpty(bottomText);
		this.SetBottomTextVisible(flag);
		if (flag)
		{
			this.SetBottomTextId(bottomTextId, bottomTextParameter);
			this.SetBottomText(bottomText);
		}
	}

	// Token: 0x06009288 RID: 37512 RVA: 0x002BCF90 File Offset: 0x002BB190
	public void SetBottomTextId(string textId, [Nullable(new byte[]
	{
		2,
		1
	})] object[] textParameter)
	{
		UUIText text = base.GetText(3);
		if (StringUtils.IsEmpty(textId))
		{
			return;
		}
		if (textParameter != null)
		{
			LguiUtil.Instance.SetLocalTextNew(text, textId, textParameter);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
	}

	// Token: 0x06009289 RID: 37513 RVA: 0x002BCFD0 File Offset: 0x002BB1D0
	public void SetBottomText(string text)
	{
		UUIText text2 = base.GetText(3);
		if (StringUtils.IsEmpty(text))
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x0600928A RID: 37514 RVA: 0x002BCFF6 File Offset: 0x002BB1F6
	[NullableContext(1)]
	public void SetBottomTextColor(string hexColor)
	{
		base.GetText(3).SetColor(FColor.FromHex(hexColor));
	}

	// Token: 0x0600928B RID: 37515 RVA: 0x002BD00C File Offset: 0x002BB20C
	public void SetBottomTextVisible(bool bVisible)
	{
		UUISprite sprite = base.GetSprite(4);
		UUIText text = base.GetText(3);
		if (sprite.IsUIActiveSelf() != bVisible)
		{
			sprite.SetUIActive(bVisible);
		}
		if (text.IsUIActiveSelf() != bVisible)
		{
			text.SetUIActive(bVisible);
		}
	}

	// Token: 0x0600928C RID: 37516 RVA: 0x002BD04C File Offset: 0x002BB24C
	[NullableContext(1)]
	public void RefreshTopRightText(SmallItemGridBase parameters)
	{
		ISmallItemTopRightTagComponentParams @params = new SmallItemTopRightTagComponentParams
		{
			TopRightTextBgColor = parameters.TopRightTextBgColor,
			TopRightTextColor = parameters.TopRightTextColor,
			TopRightTextId = parameters.TopRightTextId,
			TopRightText = parameters.TopRightText,
			TopRightTextParameter = parameters.TopRightTextParameter
		};
		bool value = !StringUtils.IsEmpty(parameters.TopRightTextId) || !StringUtils.IsEmpty(parameters.TopRightText);
		base.RefreshComponent(typeof(SmallItemTopRightTagComponent), new bool?(value), @params);
	}

	// Token: 0x0600928D RID: 37517 RVA: 0x002BD0D4 File Offset: 0x002BB2D4
	public void SetRightTopValueInfo(string value)
	{
		bool value2 = !string.IsNullOrEmpty(value);
		base.RefreshComponent(typeof(SmallItemGridRightTopValueComponent), new bool?(value2), value);
	}

	// Token: 0x0600928E RID: 37518 RVA: 0x002BD104 File Offset: 0x002BB304
	public void SetCoolDown(float? coolDown, float? totalCdTime = null)
	{
		ISmallItemGridCoolDownComponentParams @params = new SmallItemGridCoolDownComponentParams
		{
			CoolDown = coolDown,
			TotalCdTime = totalCdTime
		};
		Type typeFromHandle = typeof(SmallItemGridCoolDownComponent);
		bool value;
		if (coolDown != null)
		{
			float? num = coolDown;
			float num2 = 0f;
			value = (num.GetValueOrDefault() > num2 & num != null);
		}
		else
		{
			value = false;
		}
		base.RefreshComponent(typeFromHandle, new bool?(value), @params);
	}

	// Token: 0x0600928F RID: 37519 RVA: 0x002BD162 File Offset: 0x002BB362
	public void SetIsDisable(bool? isDisable)
	{
		base.RefreshComponent(typeof(SmallItemGridDisableComponent), new bool?(isDisable.GetValueOrDefault()), isDisable);
	}

	// Token: 0x06009290 RID: 37520 RVA: 0x002BD188 File Offset: 0x002BB388
	[NullableContext(1)]
	public void SetDisableComponentColor(string hexColor, bool isDisable = true)
	{
		SmallItemGridDisableComponent smallItemGridDisableComponent = base.RefreshComponent(typeof(SmallItemGridDisableComponent), new bool?(false), isDisable) as SmallItemGridDisableComponent;
		if (smallItemGridDisableComponent == null)
		{
			return;
		}
		smallItemGridDisableComponent.GetAsync().ContinueWith(delegate(ItemGridComponent component)
		{
			SmallItemGridDisableComponent smallItemGridDisableComponent2 = component as SmallItemGridDisableComponent;
			if (smallItemGridDisableComponent2 == null)
			{
				return;
			}
			smallItemGridDisableComponent2.SetSpriteColor(hexColor);
		});
	}

	// Token: 0x06009291 RID: 37521 RVA: 0x002BD1E0 File Offset: 0x002BB3E0
	public void SetIsBlack(bool isBlack)
	{
		base.RefreshComponent(typeof(SmallItemGridBlackComponent), new bool?(isBlack), isBlack);
	}

	// Token: 0x06009292 RID: 37522 RVA: 0x002BD1FF File Offset: 0x002BB3FF
	public void SetNewFlagVisible(bool? isVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridNewFlagComponent), new bool?(isVisible.GetValueOrDefault()), isVisible);
	}

	// Token: 0x06009293 RID: 37523 RVA: 0x002BD224 File Offset: 0x002BB424
	public void SetTimeFlagVisible(bool? bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridTimeFlagComponent), bVisible, bVisible);
	}

	// Token: 0x06009294 RID: 37524 RVA: 0x002BD23E File Offset: 0x002BB43E
	private void SetNotFoundVisible(bool? isVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridNotFoundComponent), new bool?(isVisible.GetValueOrDefault()), isVisible);
	}

	// Token: 0x06009295 RID: 37525 RVA: 0x002BD263 File Offset: 0x002BB463
	public void SetRedDotVisible(bool? isVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridRedDotComponent), new bool?(isVisible.GetValueOrDefault()), isVisible);
	}

	// Token: 0x06009296 RID: 37526 RVA: 0x002BD288 File Offset: 0x002BB488
	public void SetRedDotNumCount(int? count)
	{
		bool flag = count != null && count.Value > 0;
		base.RefreshComponent(typeof(SmallItemGridRedDotNumComponent), new bool?(flag), flag ? count.Value : null);
	}

	// Token: 0x06009297 RID: 37527 RVA: 0x002BD2D5 File Offset: 0x002BB4D5
	public void SetRoleDevelopStateTag(ERoleDevelopStateTagType? roleDevelopStateTagType)
	{
		base.RefreshComponent(typeof(SmallItemGridRoleDevelopStateTagComponent), new bool?(roleDevelopStateTagType != null), roleDevelopStateTagType);
	}

	// Token: 0x06009298 RID: 37528 RVA: 0x002BD2FA File Offset: 0x002BB4FA
	public void SetWeaponResonanceLevel(int? resonanceLevel)
	{
		base.RefreshComponent(typeof(SmallItemGridWeaponResonanceLevelComponent), new bool?(resonanceLevel != null), resonanceLevel);
	}

	// Token: 0x06009299 RID: 37529 RVA: 0x002BD31F File Offset: 0x002BB51F
	public void SetWeaponFlagVisible(bool? bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridWeaponFlagComponent), new bool?(bVisible.GetValueOrDefault()), bVisible);
	}

	// Token: 0x0600929A RID: 37530 RVA: 0x002BD344 File Offset: 0x002BB544
	public void SetDangoPluginIcon(IDangoPluginIconInfo dangoPluginIconInfo)
	{
		base.RefreshComponent(typeof(SmallItemGridDangoPluginIconComponent), new bool?(true), dangoPluginIconInfo);
	}

	// Token: 0x0600929B RID: 37531 RVA: 0x002BD35E File Offset: 0x002BB55E
	public void SetBirthdayEffect(bool? bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridBirthdayEffectComponent), new bool?(true), bVisible);
	}

	// Token: 0x0600929C RID: 37532 RVA: 0x002BD380 File Offset: 0x002BB580
	public void SetEmptySlotVisible(bool isVisible)
	{
		SmallItemGridEmptySlotComponent smallItemGridEmptySlotComponent = base.RefreshComponent(typeof(SmallItemGridEmptySlotComponent), new bool?(isVisible), isVisible) as SmallItemGridEmptySlotComponent;
		if (smallItemGridEmptySlotComponent == null)
		{
			return;
		}
		if (isVisible)
		{
			smallItemGridEmptySlotComponent.BindEmptySlotButtonCallback(new Action(this.OnClickedEmptySlotButton));
			return;
		}
		smallItemGridEmptySlotComponent.UnBindEmptySlotButtonCallback();
	}

	// Token: 0x0600929D RID: 37533 RVA: 0x002BD3D0 File Offset: 0x002BB5D0
	protected void OnClickedEmptySlotButton()
	{
		if (this.OnClickedEmptySlotButtonCallback != null)
		{
			SmallItemGridButtonCallback obj = new SmallItemGridButtonCallback
			{
				SmallItemGrid = this,
				Data = this.Data
			};
			this.OnClickedEmptySlotButtonCallback(obj);
		}
	}

	// Token: 0x0600929E RID: 37534 RVA: 0x002BD40A File Offset: 0x002BB60A
	private void SetVisionRoleHead(int? visionHeadInfo)
	{
		base.RefreshComponent(typeof(SmallItemGridVisionRoleHeadComponent), new bool?(visionHeadInfo != null), visionHeadInfo);
	}

	// Token: 0x0600929F RID: 37535 RVA: 0x002BD42F File Offset: 0x002BB62F
	public void SetRoleHead(int? roleHeadInfo)
	{
		base.RefreshComponent(typeof(SmallItemGridRoleHeadComponent), new bool?(roleHeadInfo != null), roleHeadInfo);
	}

	// Token: 0x060092A0 RID: 37536 RVA: 0x002BD454 File Offset: 0x002BB654
	public void SetVisionFetterGroup(int? fetterGroupId)
	{
		Type typeFromHandle = typeof(SmallItemGridVisionFetterComponent);
		bool value;
		if (fetterGroupId != null)
		{
			int? num = fetterGroupId;
			int num2 = 0;
			value = (num.GetValueOrDefault() > num2 & num != null);
		}
		else
		{
			value = false;
		}
		base.RefreshComponent(typeFromHandle, new bool?(value), fetterGroupId);
	}

	// Token: 0x060092A1 RID: 37537 RVA: 0x002BD49F File Offset: 0x002BB69F
	public void BindEmptySlotButtonCallback([Nullable(new byte[]
	{
		2,
		1
	})] Action<SmallItemGridButtonCallback> callback)
	{
		this.OnClickedEmptySlotButtonCallback = callback;
	}

	// Token: 0x060092A2 RID: 37538 RVA: 0x002BD4A8 File Offset: 0x002BB6A8
	public override void SetSelected(bool bSelected, bool bForce = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(7);
		if (bSelected)
		{
			if (bForce)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			}
			else
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
		}
		else if (bForce)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		else
		{
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.IsSelected = bSelected;
		this.IsForceSelected = bForce;
	}

	// Token: 0x060092A3 RID: 37539 RVA: 0x002BD504 File Offset: 0x002BB704
	[NullableContext(1)]
	public void SetIconByPath(string iconPath)
	{
		this.SetTextureByIconPath(iconPath);
	}

	// Token: 0x060092A4 RID: 37540 RVA: 0x002BD50D File Offset: 0x002BB70D
	public void SetLeftTopIconVisible(string path)
	{
		base.RefreshComponent(typeof(SmallItemGridLeftTopIconComponent), new bool?(path != null), path);
	}

	// Token: 0x060092A5 RID: 37541 RVA: 0x002BD52A File Offset: 0x002BB72A
	public void SetMultiPlayerVisible(SmallItemMultiPlayer @params)
	{
		base.RefreshComponent(typeof(SmallItemGridMultiPlayerComponent), new bool?(@params != null && @params.Players.Count > 0), @params);
	}

	// Token: 0x060092A6 RID: 37542 RVA: 0x002BD558 File Offset: 0x002BB758
	[NullableContext(1)]
	private void SetQualityIconById(string qualityIcon)
	{
		UUISprite sprite = base.GetSprite(0);
		if (string.IsNullOrEmpty(qualityIcon))
		{
			sprite.SetUIActive(false);
			return;
		}
		this.SetSpriteByPath(qualityIcon, sprite, true, null, null);
		sprite.SetUIActive(true);
	}

	// Token: 0x0400566C RID: 22124
	private int QualityItemConfigId;

	// Token: 0x0400566D RID: 22125
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<SmallItemGridButtonCallback> OnClickedEmptySlotButtonCallback;

	// Token: 0x0400566E RID: 22126
	private const int TRIAL_ROLE_ID = 10000;

	// Token: 0x0200704A RID: 28746
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04024A21 RID: 150049
		public const int QualitySprite = 0;

		// Token: 0x04024A22 RID: 150050
		public const int ItemTexture = 1;

		// Token: 0x04024A23 RID: 150051
		public const int BottomTextItem = 2;

		// Token: 0x04024A24 RID: 150052
		public const int BottomText = 3;

		// Token: 0x04024A25 RID: 150053
		public const int BottomTextBgSprite = 4;

		// Token: 0x04024A26 RID: 150054
		public const int BottomAdditionItem = 5;

		// Token: 0x04024A27 RID: 150055
		public const int TopAdditionItem = 6;

		// Token: 0x04024A28 RID: 150056
		public const int ExtendToggle = 7;

		// Token: 0x04024A29 RID: 150057
		public const int SkinQualitySprite = 8;

		// Token: 0x04024A2A RID: 150058
		public const int UnderTextAdditionItem = 9;

		// Token: 0x04024A2B RID: 150059
		public const int AniLoop = 10;

		// Token: 0x04024A2C RID: 150060
		public const int ItemSprite = 11;
	}
}
