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

// Token: 0x02001966 RID: 6502
[NullableContext(2)]
[Nullable(0)]
public class SmallItemGrid : ItemGridBase
{
	// Token: 0x0600BE41 RID: 48705 RVA: 0x002B04B8 File Offset: 0x002AE6B8
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

	// Token: 0x0600BE42 RID: 48706 RVA: 0x002B066F File Offset: 0x002AE86F
	protected override void OnStart()
	{
		UUISprite sprite = base.GetSprite(8);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(false);
	}

	// Token: 0x0600BE43 RID: 48707 RVA: 0x002B0683 File Offset: 0x002AE883
	[NullableContext(1)]
	protected override UUIItem OnSetUnderTextAdditionItem()
	{
		return base.GetItem(9);
	}

	// Token: 0x0600BE44 RID: 48708 RVA: 0x002B068D File Offset: 0x002AE88D
	[NullableContext(1)]
	protected override UUIItem OnSetBottomAdditionItem()
	{
		return base.GetItem(5);
	}

	// Token: 0x0600BE45 RID: 48709 RVA: 0x002B0696 File Offset: 0x002AE896
	[NullableContext(1)]
	protected override UUIItem OnSetTopAdditionItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x0600BE46 RID: 48710 RVA: 0x002B069F File Offset: 0x002AE89F
	[NullableContext(1)]
	public override UUIExtendToggle GetItemGridExtendToggle()
	{
		return base.GetExtendToggle(7);
	}

	// Token: 0x0600BE47 RID: 48711 RVA: 0x002B06A8 File Offset: 0x002AE8A8
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
		base.RefreshComponentVisible();
		base.RefreshComponentHierarchyIndex();
	}

	// Token: 0x0600BE48 RID: 48712 RVA: 0x002B07F8 File Offset: 0x002AE9F8
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

	// Token: 0x0600BE49 RID: 48713 RVA: 0x002B0860 File Offset: 0x002AEA60
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

	// Token: 0x0600BE4A RID: 48714 RVA: 0x002B08D0 File Offset: 0x002AEAD0
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
		this.SetRoleDevelopStateTag(parameters.RoleDevelopStateTagType);
		this.SetStarReceivableVisible(valueOrDefault4);
		this.SetOrnamentConflictVisible(isOrnamentConflictVisible);
		this.SetDoubleRewardVisible(valueOrDefault6);
	}

	// Token: 0x0600BE4B RID: 48715 RVA: 0x002B0A10 File Offset: 0x002AEC10
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

	// Token: 0x0600BE4C RID: 48716 RVA: 0x002B0B04 File Offset: 0x002AED04
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

	// Token: 0x0600BE4D RID: 48717 RVA: 0x002B0BBB File Offset: 0x002AEDBB
	public void ApplyForecastCharacterSmallItemGrid(ForecastCharacterSmallItemGrid parameters)
	{
		if (parameters == null)
		{
			return;
		}
		this.ApplyForecastCharacterBaseDisplay(parameters);
	}

	// Token: 0x0600BE4E RID: 48718 RVA: 0x002B0BC8 File Offset: 0x002AEDC8
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

	// Token: 0x0600BE4F RID: 48719 RVA: 0x002B0CE4 File Offset: 0x002AEEE4
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

	// Token: 0x0600BE50 RID: 48720 RVA: 0x002B0D58 File Offset: 0x002AEF58
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

	// Token: 0x0600BE51 RID: 48721 RVA: 0x002B0DE4 File Offset: 0x002AEFE4
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

	// Token: 0x0600BE52 RID: 48722 RVA: 0x002B0F03 File Offset: 0x002AF103
	public void SetElement(int? elementId)
	{
		base.RefreshComponent(typeof(SmallItemGridElementComponent), new bool?(elementId != null), elementId);
	}

	// Token: 0x0600BE53 RID: 48723 RVA: 0x002B0F28 File Offset: 0x002AF128
	public void SetDirectionalFusionComponent(int? phantomFetterId)
	{
		base.RefreshComponent(typeof(SmallItemGridDirectionalFusionComponent), new bool?(phantomFetterId != null), phantomFetterId);
	}

	// Token: 0x0600BE54 RID: 48724 RVA: 0x002B0F50 File Offset: 0x002AF150
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

	// Token: 0x0600BE55 RID: 48725 RVA: 0x002B1044 File Offset: 0x002AF244
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

	// Token: 0x0600BE56 RID: 48726 RVA: 0x002B1164 File Offset: 0x002AF364
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

	// Token: 0x0600BE57 RID: 48727 RVA: 0x002B11D8 File Offset: 0x002AF3D8
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

	// Token: 0x0600BE58 RID: 48728 RVA: 0x002B1237 File Offset: 0x002AF437
	public void SetLockVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridLockComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE59 RID: 48729 RVA: 0x002B1256 File Offset: 0x002AF456
	public void SetArrowVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridArrowComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE5A RID: 48730 RVA: 0x002B1278 File Offset: 0x002AF478
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

	// Token: 0x0600BE5B RID: 48731 RVA: 0x002B12C5 File Offset: 0x002AF4C5
	public void SetLockBlackVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridLockBlackComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE5C RID: 48732 RVA: 0x002B12E4 File Offset: 0x002AF4E4
	public void SetLockBlackBigVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridLockBlackBigComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE5D RID: 48733 RVA: 0x002B1303 File Offset: 0x002AF503
	public void SetCurrentEquipmentVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridCurrentEquipmentComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE5E RID: 48734 RVA: 0x002B1322 File Offset: 0x002AF522
	public void SetReceivableVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridReceivableComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE5F RID: 48735 RVA: 0x002B1341 File Offset: 0x002AF541
	public void SetStarReceivableVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridStarReceivableComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE60 RID: 48736 RVA: 0x002B1360 File Offset: 0x002AF560
	public void SetPreviewVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridPreviewComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE61 RID: 48737 RVA: 0x002B137F File Offset: 0x002AF57F
	public void SetReceivedVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridReceivedComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE62 RID: 48738 RVA: 0x002B13A0 File Offset: 0x002AF5A0
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

	// Token: 0x0600BE63 RID: 48739 RVA: 0x002B13F8 File Offset: 0x002AF5F8
	public void SetSelectedFlagVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridSelectedFlagComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE64 RID: 48740 RVA: 0x002B1417 File Offset: 0x002AF617
	public void SetSelectVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridSelectComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE65 RID: 48741 RVA: 0x002B1436 File Offset: 0x002AF636
	private void SetCookUpVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridCookUpComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE66 RID: 48742 RVA: 0x002B1455 File Offset: 0x002AF655
	public void SetFirstRewardVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridFirstRewardComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE67 RID: 48743 RVA: 0x002B1474 File Offset: 0x002AF674
	public void SetExchangeRewardVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridExchangeRewardComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE68 RID: 48744 RVA: 0x002B1493 File Offset: 0x002AF693
	public void SetDoubleRewardVisible(bool bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridDoubleRewardComponent), new bool?(bVisible), bVisible);
	}

	// Token: 0x0600BE69 RID: 48745 RVA: 0x002B14B4 File Offset: 0x002AF6B4
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

	// Token: 0x0600BE6A RID: 48746 RVA: 0x002B14E8 File Offset: 0x002AF6E8
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

	// Token: 0x0600BE6B RID: 48747 RVA: 0x002B1530 File Offset: 0x002AF730
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

	// Token: 0x0600BE6C RID: 48748 RVA: 0x002B1598 File Offset: 0x002AF798
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

	// Token: 0x0600BE6D RID: 48749 RVA: 0x002B15CC File Offset: 0x002AF7CC
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

	// Token: 0x0600BE6E RID: 48750 RVA: 0x002B1630 File Offset: 0x002AF830
	private void SetMonsterTexture(int monsterId)
	{
		UUITexture texture = base.GetTexture(1);
		string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(monsterId);
		base.SetTextureByPath(monsterIcon, texture, null, null);
		texture.SetUIActive(true);
	}

	// Token: 0x0600BE6F RID: 48751 RVA: 0x002B166C File Offset: 0x002AF86C
	private void SetPhantomTexture(int phantomId)
	{
		UUITexture texture = base.GetTexture(1);
		base.SetTextureByPath(PhantomBattleConfig.Instance.GetPhantomItemById(phantomId).Value.IconMiddle, texture, null, null);
		texture.SetUIActive(true);
	}

	// Token: 0x0600BE70 RID: 48752 RVA: 0x002B16B4 File Offset: 0x002AF8B4
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

	// Token: 0x0600BE71 RID: 48753 RVA: 0x002B1744 File Offset: 0x002AF944
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

	// Token: 0x0600BE72 RID: 48754 RVA: 0x002B178C File Offset: 0x002AF98C
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

	// Token: 0x0600BE73 RID: 48755 RVA: 0x002B17E4 File Offset: 0x002AF9E4
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

	// Token: 0x0600BE74 RID: 48756 RVA: 0x002B1890 File Offset: 0x002AFA90
	[NullableContext(1)]
	public void SetSkinQualityByParameters(SmallItemGridBase parameters)
	{
		this.SetQuality(null);
		this.SetSkinItemQuality(parameters);
	}

	// Token: 0x0600BE75 RID: 48757 RVA: 0x002B18B4 File Offset: 0x002AFAB4
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

	// Token: 0x0600BE76 RID: 48758 RVA: 0x002B192C File Offset: 0x002AFB2C
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

	// Token: 0x0600BE77 RID: 48759 RVA: 0x002B19D0 File Offset: 0x002AFBD0
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

	// Token: 0x0600BE78 RID: 48760 RVA: 0x002B1A14 File Offset: 0x002AFC14
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

	// Token: 0x0600BE79 RID: 48761 RVA: 0x002B1AB4 File Offset: 0x002AFCB4
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

	// Token: 0x0600BE7A RID: 48762 RVA: 0x002B1BB8 File Offset: 0x002AFDB8
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

	// Token: 0x0600BE7B RID: 48763 RVA: 0x002B1CE0 File Offset: 0x002AFEE0
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

	// Token: 0x0600BE7C RID: 48764 RVA: 0x002B1DE4 File Offset: 0x002AFFE4
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

	// Token: 0x0600BE7D RID: 48765 RVA: 0x002B1F08 File Offset: 0x002B0108
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

	// Token: 0x0600BE7E RID: 48766 RVA: 0x002B1F44 File Offset: 0x002B0144
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

	// Token: 0x0600BE7F RID: 48767 RVA: 0x002B1F97 File Offset: 0x002B0197
	public void SetOrnamentConflictVisible(bool? bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridOrnamentConflictComponent), bVisible, bVisible);
	}

	// Token: 0x0600BE80 RID: 48768 RVA: 0x002B1FB4 File Offset: 0x002B01B4
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

	// Token: 0x0600BE81 RID: 48769 RVA: 0x002B2004 File Offset: 0x002B0204
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

	// Token: 0x0600BE82 RID: 48770 RVA: 0x002B2058 File Offset: 0x002B0258
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

	// Token: 0x0600BE83 RID: 48771 RVA: 0x002B2098 File Offset: 0x002B0298
	public void SetBottomText(string text)
	{
		UUIText text2 = base.GetText(3);
		if (StringUtils.IsEmpty(text))
		{
			return;
		}
		text2.SetText(text, true);
	}

	// Token: 0x0600BE84 RID: 48772 RVA: 0x002B20BE File Offset: 0x002B02BE
	[NullableContext(1)]
	public void SetBottomTextColor(string hexColor)
	{
		base.GetText(3).SetColor(FColor.FromHex(hexColor));
	}

	// Token: 0x0600BE85 RID: 48773 RVA: 0x002B20D4 File Offset: 0x002B02D4
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

	// Token: 0x0600BE86 RID: 48774 RVA: 0x002B2114 File Offset: 0x002B0314
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

	// Token: 0x0600BE87 RID: 48775 RVA: 0x002B219C File Offset: 0x002B039C
	public void SetRightTopValueInfo(string value)
	{
		bool value2 = !string.IsNullOrEmpty(value);
		base.RefreshComponent(typeof(SmallItemGridRightTopValueComponent), new bool?(value2), value);
	}

	// Token: 0x0600BE88 RID: 48776 RVA: 0x002B21CC File Offset: 0x002B03CC
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

	// Token: 0x0600BE89 RID: 48777 RVA: 0x002B222A File Offset: 0x002B042A
	public void SetIsDisable(bool? isDisable)
	{
		base.RefreshComponent(typeof(SmallItemGridDisableComponent), new bool?(isDisable.GetValueOrDefault()), isDisable);
	}

	// Token: 0x0600BE8A RID: 48778 RVA: 0x002B2250 File Offset: 0x002B0450
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

	// Token: 0x0600BE8B RID: 48779 RVA: 0x002B22A8 File Offset: 0x002B04A8
	public void SetIsBlack(bool isBlack)
	{
		base.RefreshComponent(typeof(SmallItemGridBlackComponent), new bool?(isBlack), isBlack);
	}

	// Token: 0x0600BE8C RID: 48780 RVA: 0x002B22C7 File Offset: 0x002B04C7
	public void SetNewFlagVisible(bool? isVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridNewFlagComponent), new bool?(isVisible.GetValueOrDefault()), isVisible);
	}

	// Token: 0x0600BE8D RID: 48781 RVA: 0x002B22EC File Offset: 0x002B04EC
	public void SetTimeFlagVisible(bool? bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridTimeFlagComponent), bVisible, bVisible);
	}

	// Token: 0x0600BE8E RID: 48782 RVA: 0x002B2306 File Offset: 0x002B0506
	private void SetNotFoundVisible(bool? isVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridNotFoundComponent), new bool?(isVisible.GetValueOrDefault()), isVisible);
	}

	// Token: 0x0600BE8F RID: 48783 RVA: 0x002B232B File Offset: 0x002B052B
	public void SetRedDotVisible(bool? isVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridRedDotComponent), new bool?(isVisible.GetValueOrDefault()), isVisible);
	}

	// Token: 0x0600BE90 RID: 48784 RVA: 0x002B2350 File Offset: 0x002B0550
	public void SetRedDotNumCount(int? count)
	{
		bool flag = count != null && count.Value > 0;
		base.RefreshComponent(typeof(SmallItemGridRedDotNumComponent), new bool?(flag), flag ? count.Value : null);
	}

	// Token: 0x0600BE91 RID: 48785 RVA: 0x002B239D File Offset: 0x002B059D
	public void SetRoleDevelopStateTag(ERoleDevelopStateTagType? roleDevelopStateTagType)
	{
		base.RefreshComponent(typeof(SmallItemGridRoleDevelopStateTagComponent), new bool?(roleDevelopStateTagType != null), roleDevelopStateTagType);
	}

	// Token: 0x0600BE92 RID: 48786 RVA: 0x002B23C2 File Offset: 0x002B05C2
	public void SetDangoPluginIcon(IDangoPluginIconInfo dangoPluginIconInfo)
	{
		base.RefreshComponent(typeof(SmallItemGridDangoPluginIconComponent), new bool?(true), dangoPluginIconInfo);
	}

	// Token: 0x0600BE93 RID: 48787 RVA: 0x002B23DC File Offset: 0x002B05DC
	public void SetBirthdayEffect(bool? bVisible)
	{
		base.RefreshComponent(typeof(SmallItemGridBirthdayEffectComponent), new bool?(true), bVisible);
	}

	// Token: 0x0600BE94 RID: 48788 RVA: 0x002B23FC File Offset: 0x002B05FC
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

	// Token: 0x0600BE95 RID: 48789 RVA: 0x002B244C File Offset: 0x002B064C
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

	// Token: 0x0600BE96 RID: 48790 RVA: 0x002B2486 File Offset: 0x002B0686
	private void SetVisionRoleHead(int? visionHeadInfo)
	{
		base.RefreshComponent(typeof(SmallItemGridVisionRoleHeadComponent), new bool?(visionHeadInfo != null), visionHeadInfo);
	}

	// Token: 0x0600BE97 RID: 48791 RVA: 0x002B24AB File Offset: 0x002B06AB
	public void SetRoleHead(int? roleHeadInfo)
	{
		base.RefreshComponent(typeof(SmallItemGridRoleHeadComponent), new bool?(roleHeadInfo != null), roleHeadInfo);
	}

	// Token: 0x0600BE98 RID: 48792 RVA: 0x002B24D0 File Offset: 0x002B06D0
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

	// Token: 0x0600BE99 RID: 48793 RVA: 0x002B251B File Offset: 0x002B071B
	public void BindEmptySlotButtonCallback([Nullable(new byte[]
	{
		2,
		1
	})] Action<SmallItemGridButtonCallback> callback)
	{
		this.OnClickedEmptySlotButtonCallback = callback;
	}

	// Token: 0x0600BE9A RID: 48794 RVA: 0x002B2524 File Offset: 0x002B0724
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

	// Token: 0x0600BE9B RID: 48795 RVA: 0x002B2580 File Offset: 0x002B0780
	[NullableContext(1)]
	public void SetIconByPath(string iconPath)
	{
		this.SetTextureByIconPath(iconPath);
	}

	// Token: 0x0600BE9C RID: 48796 RVA: 0x002B2589 File Offset: 0x002B0789
	public void SetLeftTopIconVisible(string path)
	{
		base.RefreshComponent(typeof(SmallItemGridLeftTopIconComponent), new bool?(path != null), path);
	}

	// Token: 0x0600BE9D RID: 48797 RVA: 0x002B25A6 File Offset: 0x002B07A6
	public void SetMultiPlayerVisible(SmallItemMultiPlayer @params)
	{
		base.RefreshComponent(typeof(SmallItemGridMultiPlayerComponent), new bool?(@params != null && @params.Players.Count > 0), @params);
	}

	// Token: 0x0600BE9E RID: 48798 RVA: 0x002B25D4 File Offset: 0x002B07D4
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

	// Token: 0x040055BF RID: 21951
	private int QualityItemConfigId;

	// Token: 0x040055C0 RID: 21952
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<SmallItemGridButtonCallback> OnClickedEmptySlotButtonCallback;

	// Token: 0x040055C1 RID: 21953
	private const int TRIAL_ROLE_ID = 10000;

	// Token: 0x02007EBB RID: 32443
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x040296E4 RID: 169700
		public const int QualitySprite = 0;

		// Token: 0x040296E5 RID: 169701
		public const int ItemTexture = 1;

		// Token: 0x040296E6 RID: 169702
		public const int BottomTextItem = 2;

		// Token: 0x040296E7 RID: 169703
		public const int BottomText = 3;

		// Token: 0x040296E8 RID: 169704
		public const int BottomTextBgSprite = 4;

		// Token: 0x040296E9 RID: 169705
		public const int BottomAdditionItem = 5;

		// Token: 0x040296EA RID: 169706
		public const int TopAdditionItem = 6;

		// Token: 0x040296EB RID: 169707
		public const int ExtendToggle = 7;

		// Token: 0x040296EC RID: 169708
		public const int SkinQualitySprite = 8;

		// Token: 0x040296ED RID: 169709
		public const int UnderTextAdditionItem = 9;

		// Token: 0x040296EE RID: 169710
		public const int AniLoop = 10;

		// Token: 0x040296EF RID: 169711
		public const int ItemSprite = 11;
	}
}
