using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.Skin;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B51 RID: 23377
	[NullableContext(2)]
	[Nullable(0)]
	public class MediumItemGrid : ItemGridBase
	{
		// Token: 0x0603B2FE RID: 242430 RVA: 0x00E1C584 File Offset: 0x00E1A784
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B2FF RID: 242431 RVA: 0x00E1C73B File Offset: 0x00E1A93B
		protected override UUIItem OnSetUnderTextAdditionItem()
		{
			return base.GetItem(7);
		}

		// Token: 0x0603B300 RID: 242432 RVA: 0x00E1C744 File Offset: 0x00E1A944
		protected override UUIItem OnSetBottomAdditionItem()
		{
			return base.GetItem(5);
		}

		// Token: 0x0603B301 RID: 242433 RVA: 0x00E1C74D File Offset: 0x00E1A94D
		protected override UUIItem OnSetTopAdditionItem()
		{
			return base.GetItem(4);
		}

		// Token: 0x0603B302 RID: 242434 RVA: 0x00E1C756 File Offset: 0x00E1A956
		protected override void UnBindComponentEvents()
		{
			this.UnBindReduceButtonCallback();
			this.UnBindEmptySlotButtonCallback();
			this.UnBindReduceLongPress();
		}

		// Token: 0x0603B303 RID: 242435 RVA: 0x00E1C76C File Offset: 0x00E1A96C
		[NullableContext(1)]
		public void Apply<[Nullable(0)] T>(T parameters) where T : IMediumItemGridBase
		{
			base.ClearVisibleComponent();
			base.ClearComponentList();
			this.SetBgByResourceId("SP_QualityFrmA");
			this.SetStackFlagVisible(false);
			if (parameters.Type == EMediumItemGridType.Empty)
			{
				this.ApplyEmptyMediumItemGrid(parameters as EmptyItemGrid);
			}
			if (parameters.Type == EMediumItemGridType.OnlyEmpty)
			{
				this.ApplyOnlyEmptyMediumItemGrid(parameters as OnlyEmptyItemGrid);
			}
			if (parameters.Type == EMediumItemGridType.Prop)
			{
				this.ApplyPropMediumItemGrid(parameters as PropMediumItemGrid);
			}
			if (parameters.Type == EMediumItemGridType.Phantom)
			{
				this.ApplyPhantomMediumItemGrid(parameters as PhantomMediumItemGrid);
			}
			if (parameters.Type == EMediumItemGridType.Character)
			{
				this.ApplyCharacterMediumItemGrid(parameters as CharacterMediumItemGrid);
			}
			if (parameters.Type == EMediumItemGridType.ForecastCharacter)
			{
				this.ApplyForecastCharacterMediumItemGrid(parameters as ForecastCharacterMediumItemGrid);
			}
			if (parameters.Type == EMediumItemGridType.Kurotato)
			{
				this.ApplyKurotatoWeaponMediumItemGrid(parameters as KurotatoMediumItemGrid);
			}
			base.RefreshComponentVisible();
			base.RefreshComponentHierarchyIndex();
		}

		// Token: 0x0603B304 RID: 242436 RVA: 0x00E1C88C File Offset: 0x00E1AA8C
		[NullableContext(1)]
		private void ApplyEmptyMediumItemGrid(EmptyItemGrid parameters)
		{
			this.Data = parameters.Data;
			this.SetEmptySlotVisible(true);
			this.SetTexture(null);
			this.SetQuality(null);
			this.SetBgVisible(false);
			this.SetBottomTextVisible(false);
			base.SetExtendToggleEnable(true, false);
			this.ApplyEmptyDisplay(parameters);
		}

		// Token: 0x0603B305 RID: 242437 RVA: 0x00E1C8E8 File Offset: 0x00E1AAE8
		[NullableContext(1)]
		private void ApplyOnlyEmptyMediumItemGrid(OnlyEmptyItemGrid parameters)
		{
			this.Data = parameters.Data;
			this.SetTexture(null);
			this.SetQuality(null);
			this.SetBgVisible(false);
			this.SetBottomTextVisible(false);
			base.SetExtendToggleEnable(true, false);
			this.SetBottomTextVisible(false);
			this.SetOnlyEmptyVisible(true, parameters);
		}

		// Token: 0x0603B306 RID: 242438 RVA: 0x00E1C944 File Offset: 0x00E1AB44
		[NullableContext(1)]
		private void ApplyPropMediumItemGrid(PropMediumItemGrid parameters)
		{
			int? starLevel = parameters.StarLevel;
			bool? isNewVisible = parameters.IsNewVisible;
			EMediumItemGridBuffType? buffIconType = parameters.BuffIconType;
			bool? isRedDotVisible = parameters.IsRedDotVisible;
			bool? isLockVisible = parameters.IsLockVisible;
			bool? isDeprecate = parameters.IsDeprecate;
			int? level = parameters.Level;
			bool? isLevelInfinite = parameters.IsLevelInfinite;
			bool? isLevelTextUseChangeColor = parameters.IsLevelTextUseChangeColor;
			float? coolDown = parameters.CoolDown;
			float? totalCoolDown = parameters.TotalCoolDown;
			bool? isProhibit = parameters.IsProhibit;
			LongPressButton reduceButtonInfo = parameters.ReduceButtonInfo;
			bool? isGreenSelected = parameters.IsGreenSelected;
			bool? isWarning = parameters.IsWarning;
			bool? isCheckTick = parameters.IsCheckTick;
			bool? isTimeFlagVisible = parameters.IsTimeFlagVisible;
			bool? isReceivedFlagVisible = parameters.IsReceivedFlagVisible;
			RoleHeadInfo roleHeadInfo = parameters.RoleHeadInfo;
			int? sortIndex = parameters.SortIndex;
			bool? isDisable = parameters.IsDisable;
			bool? isMainVisionVisible = parameters.IsMainVisionVisible;
			int? visionFetterGroupId = parameters.VisionFetterGroupId;
			VisionRoleHeadInfo visionRoleHeadInfo = parameters.VisionRoleHeadInfo;
			DangoRoleHeadInfo dangoRoleHeadInfo = parameters.DangoRoleHeadInfo;
			MediumItemGridComposeTag composeIconTag = parameters.ComposeIconTag;
			bool? changeAble = parameters.ChangeAble;
			bool? isUpGrade = parameters.IsUpGrade;
			string[] tagPathList = parameters.TagPathList;
			string subIconPath = parameters.SubIconPath;
			string rightTopValue = parameters.RightTopValue;
			bool value = InventoryConfig.Instance.GetItemDataTypeByConfigId(parameters.ItemConfigId) == InventoryDefine.EItemDataType.PhantomItem;
			bool? isBranchUpgrade = parameters.IsBranchUpgrade;
			bool? isRecommendVisible = parameters.IsRecommendVisible;
			MediumWarningPanelInfo warningPanelInfo = parameters.WarningPanelInfo;
			this.SetStartLevel(starLevel);
			this.SetBuffSprite(buffIconType);
			this.SetLevelAndLock(level, isLockVisible, isLevelTextUseChangeColor, new bool?(value), isDeprecate, isLevelInfinite);
			this.SetRecommendVisible(isRecommendVisible);
			this.SetItemPrice(parameters.ItemPrice);
			this.SetCoolDown(coolDown, totalCoolDown);
			this.SetIsProhibit(isProhibit);
			this.SetReduceButton(reduceButtonInfo);
			this.SetGreenSelected(isGreenSelected);
			this.SetWarningIcon(isWarning);
			this.SetCheckTickVisible(isCheckTick);
			this.SetTimeFlagVisible(isTimeFlagVisible);
			this.SetReceivedFlagVisible(isReceivedFlagVisible);
			this.SetRoleHead(roleHeadInfo);
			this.SetSortIndex(sortIndex, false);
			this.SetIsDisable(isDisable);
			this.SetRogueFinish(parameters.IsRogueFinish);
			this.SetIsMainVision(isMainVisionVisible);
			if (!parameters.IsNewOverRedDot.GetValueOrDefault())
			{
				this.SetRedDotVisible(isRedDotVisible);
				this.SetNewVisible(new bool?(!isRedDotVisible.GetValueOrDefault() && isNewVisible.GetValueOrDefault()));
			}
			else
			{
				this.SetNewVisible(new bool?(isNewVisible.GetValueOrDefault()));
				this.SetRedDotVisible(new bool?(!isNewVisible.GetValueOrDefault() && isRedDotVisible.GetValueOrDefault()));
			}
			this.SetVisionFetterGroup(visionFetterGroupId);
			this.SetVisionRoleHead(visionRoleHeadInfo);
			this.SetComposeIcon(composeIconTag);
			this.SetComposeChangeAble(changeAble);
			this.SetDangoRoleHead(dangoRoleHeadInfo);
			this.SetUpGradeVisible(isUpGrade);
			this.SetTagsInfo(tagPathList);
			this.SetSubIconPath(subIconPath);
			this.SetRightTopValueInfo(rightTopValue);
			this.SetIsBranchUpgrade(isBranchUpgrade);
			this.SetWarningPanelInfo(warningPanelInfo);
			this.SetRoundCount(parameters.RoundCount);
			this.ApplyPropBaseDisplay(parameters);
			this.SetPhantomStackDisplay(parameters.StackDisplayInfo);
		}

		// Token: 0x0603B307 RID: 242439 RVA: 0x00E1CBF8 File Offset: 0x00E1ADF8
		[NullableContext(1)]
		private void ApplyPhantomMediumItemGrid(PhantomMediumItemGrid parameters)
		{
			int? starLevel = parameters.StarLevel;
			bool? isMainVisionVisible = parameters.IsMainVisionVisible;
			RoleHeadInfo roleHeadInfo = parameters.RoleHeadInfo;
			bool? isNewVisible = parameters.IsNewVisible;
			bool? isLockVisible = parameters.IsLockVisible;
			bool? isDeprecate = parameters.IsDeprecate;
			bool? isPhantomLock = parameters.IsPhantomLock;
			DevelopRewardInfo developRewardInfo = parameters.DevelopRewardInfo;
			bool? isRedDotVisible = parameters.IsRedDotVisible;
			int? level = parameters.Level;
			bool? isLevelTextUseChangeColor = parameters.IsLevelTextUseChangeColor;
			int? fetterGroupId = parameters.FetterGroupId;
			VisionRoleHeadInfo visionRoleHeadInfo = parameters.VisionRoleHeadInfo;
			EMediumItemGridPhantomSpecialSkill? specialSkill = parameters.SpecialSkill;
			int? sortNum = parameters.SortNum;
			bool? isDisable = parameters.IsDisable;
			MediumWarningPanelInfo warningPanelInfo = parameters.WarningPanelInfo;
			this.SetStartLevel(starLevel);
			this.SetRedDotVisible(isRedDotVisible);
			this.SetIsMainVision(isMainVisionVisible);
			this.SetRoleHead(roleHeadInfo);
			this.SetLevelAndLock(level, isLockVisible, isLevelTextUseChangeColor, new bool?(true), isDeprecate, null);
			this.SetIsPhantomLock(isPhantomLock);
			this.SetDevelopRewardInfo(developRewardInfo);
			this.SetNewVisible(new bool?(isNewVisible.GetValueOrDefault()));
			this.SetVisionFetterGroup(fetterGroupId);
			this.SetVisionRoleHead(visionRoleHeadInfo);
			this.SetPhantomIsSpecialSkill(specialSkill);
			this.SetPhantomSortNum(sortNum);
			this.SetIsDisable(isDisable);
			this.SetWarningPanelInfo(warningPanelInfo);
			this.ApplyPhantomBaseDisplay(parameters);
			this.SetPhantomStackDisplay(parameters.StackDisplayInfo);
		}

		// Token: 0x0603B308 RID: 242440 RVA: 0x00E1CD2C File Offset: 0x00E1AF2C
		[NullableContext(1)]
		private void ApplyCharacterMediumItemGrid(CharacterMediumItemGrid parameters)
		{
			this.SetFrameEffectVisible(parameters.FrameEffect);
			this.SetElement(parameters.ElementId);
			this.SetSortIndex(parameters.Index, parameters.HighlightIndex.GetValueOrDefault());
			this.SetTeamIcon(parameters.IsInTeam);
			this.SetRecommendVisible(parameters.IsRecommendVisible);
			this.SetUnRecommendVisible(parameters.IsUnRecommendVisible);
			this.SetIsDisable(parameters.IsDisable);
			MediumRoleRightBottomTag roleRightBottomTagVisible = null;
			if (parameters.IsRecommendBottomVisible.GetValueOrDefault() || parameters.IsTrialBottomVisible.GetValueOrDefault())
			{
				roleRightBottomTagVisible = new MediumRoleRightBottomTag
				{
					IsTrialRole = parameters.IsTrialBottomVisible.GetValueOrDefault(),
					IsRecommendRole = parameters.IsRecommendBottomVisible.GetValueOrDefault()
				};
			}
			this.SetRoleRightBottomTagVisible(roleRightBottomTagVisible);
			MediumTrialRoleRightBottomTag trialRoleRightBottomTagVisible = null;
			if (parameters.IsTrialRoleVisible.GetValueOrDefault())
			{
				trialRoleRightBottomTagVisible = new MediumTrialRoleRightBottomTag
				{
					IsTrialRole = parameters.IsTrialRoleVisible.GetValueOrDefault(),
					TrialRoleId = parameters.ItemConfigId.GetValueOrDefault()
				};
			}
			this.SetTrialRoleRightBottomTagVisible(trialRoleRightBottomTagVisible);
			this.SetLevelAndLock(parameters.Level, parameters.IsShowLock, parameters.IsLevelTextUseChangeColor, null, null, null);
			this.SetNewVisible(new bool?(parameters.IsNewVisible.GetValueOrDefault()));
			this.SetRoleCost(parameters.ShowCostData);
			this.SetHalfAreaInfo(parameters.HalfAreaInfo);
			this.SetWeeklyRogueTag(parameters.IsShowWeeklyRogueTag);
			this.SetLevelAndStar(parameters.LvAndStar);
			this.SetRoleDevTag(parameters.RoleDevTag);
			this.SetRoleDevelopTagMark(parameters.IsRoleDevelopTagMark);
			this.SetAddLevel(parameters.AddLevel);
			this.SetRoleSkillBranch(parameters.SkillBranchIndex, parameters.ItemConfigId, parameters.IsTrialRoleVisible);
			this.SetArchiveIcon(parameters.IsShowArchive);
			this.SetLeftUpperIcon(parameters.LeftUpperIconPath);
			this.ApplyCharacterBaseDisplay(parameters);
		}

		// Token: 0x0603B309 RID: 242441 RVA: 0x00E1CEF5 File Offset: 0x00E1B0F5
		[NullableContext(1)]
		private void ApplyForecastCharacterMediumItemGrid(ForecastCharacterMediumItemGrid parameters)
		{
			this.ApplyForecastCharacterBaseDisplay(parameters);
		}

		// Token: 0x0603B30A RID: 242442 RVA: 0x00E1CF00 File Offset: 0x00E1B100
		[NullableContext(1)]
		private void ApplyKurotatoWeaponMediumItemGrid(KurotatoMediumItemGrid param)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			if (param.CardType == EKurotatoCardType.Weapon)
			{
				string icon = KurotatoConfig.Instance.GetWeaponGroupConfigByWeaponId(param.Id).Value.Icon;
				base.SetTextureByPath(icon, texture, null, null);
				this.SetBottomTextId(param.BottomTextId, param.BottomTextParameter);
				this.SetBottomText(param.BottomText);
				this.SetSkinQuality(null);
			}
			else
			{
				string icon2 = KurotatoConfig.Instance.GetItemConfigByItemId(param.Id).Value.Icon;
				base.SetTextureByPath(icon2, texture, null, null);
				this.SetBottomTextId(param.BottomTextId, param.BottomTextParameter);
				this.SetBottomText(param.BottomText);
				this.SetSkinQuality(null);
				this.SetRightTopValueInfo(param.RightTopValue);
			}
			this.SetNewVisible(param.IsNewVisible);
			this.SetIsDisable(param.IsDisable);
			this.SetLevelAndLock(null, param.IsDisable, null, null, null, null);
			this.SetKurotatoItemQuality(param);
			this.SetBottomTextVisible(true);
			this.SetBgVisible(true);
			base.SetExtendToggleEnable(true, false);
		}

		// Token: 0x0603B30B RID: 242443 RVA: 0x00E1D070 File Offset: 0x00E1B270
		[NullableContext(1)]
		private void SetKurotatoItemQuality(KurotatoMediumItemGrid param)
		{
			int id = param.Id;
			UUISprite sprite = base.GetSprite(0);
			if (this.QualityItemConfigId == id)
			{
				sprite.SetUIActive(true);
				return;
			}
			this.SetSpriteByPath(KurotatoConfig.Instance.GetQualityByQuality(param.QualityId.Value).Value.MediumItemGridQualitySpritePath, sprite, true, null, null);
			sprite.SetUIActive(true);
			this.QualityItemConfigId = id;
		}

		// Token: 0x0603B30C RID: 242444 RVA: 0x00E1D0E3 File Offset: 0x00E1B2E3
		public void SetWeeklyRogueTag(bool? isShowWeeklyRogueTag)
		{
			base.RefreshComponent(typeof(MediumItemGridWeeklyRogueTagComponent), new bool?(isShowWeeklyRogueTag.GetValueOrDefault()), isShowWeeklyRogueTag);
		}

		// Token: 0x0603B30D RID: 242445 RVA: 0x00E1D108 File Offset: 0x00E1B308
		public void SetRogueFinish(bool? isRogueFinish)
		{
			base.RefreshComponent(typeof(MediumItemGridRogueFinishComponent), new bool?(isRogueFinish.GetValueOrDefault()), isRogueFinish);
		}

		// Token: 0x0603B30E RID: 242446 RVA: 0x00E1D12D File Offset: 0x00E1B32D
		public void SetGreenSelected(bool? isShowSelect)
		{
			base.RefreshComponent(typeof(MediumItemGridVisionGreenSelectComponent), new bool?(isShowSelect.GetValueOrDefault()), isShowSelect);
		}

		// Token: 0x0603B30F RID: 242447 RVA: 0x00E1D152 File Offset: 0x00E1B352
		public void SetWarningIcon(bool? isShowSelect)
		{
			base.RefreshComponent(typeof(MediumItemGridVisionWarningComponent), isShowSelect, isShowSelect);
		}

		// Token: 0x0603B310 RID: 242448 RVA: 0x00E1D16C File Offset: 0x00E1B36C
		public void SetDangoRoleHead(DangoRoleHeadInfo roleHeadInfo)
		{
			Type typeFromHandle = typeof(MediumItemGridDangoRoleHeadComponent);
			bool value;
			if (roleHeadInfo != null)
			{
				int? dangoConfigId = roleHeadInfo.DangoConfigId;
				int num = 0;
				value = (dangoConfigId.GetValueOrDefault() > num & dangoConfigId != null);
			}
			else
			{
				value = false;
			}
			ItemGridComponent itemGridComponent = base.RefreshComponent(typeFromHandle, new bool?(value), roleHeadInfo);
			if (itemGridComponent == null)
			{
				return;
			}
			ItemGridComponent component = itemGridComponent;
			bool bVisible;
			if (roleHeadInfo != null)
			{
				int? dangoConfigId = roleHeadInfo.DangoConfigId;
				int num = 0;
				bVisible = (dangoConfigId.GetValueOrDefault() > num & dangoConfigId != null);
			}
			else
			{
				bVisible = false;
			}
			base.SetComponentVisible(component, bVisible);
		}

		// Token: 0x0603B311 RID: 242449 RVA: 0x00E1D1DD File Offset: 0x00E1B3DD
		public void SetDangoPluginIcon(IDangoPluginIconInfo dangoPluginIconInfo)
		{
			base.RefreshComponent(typeof(MediumItemGridDangoPluginIconComponent), new bool?(true), dangoPluginIconInfo);
		}

		// Token: 0x0603B312 RID: 242450 RVA: 0x00E1D1F8 File Offset: 0x00E1B3F8
		public void SetBuffSprite(EMediumItemGridBuffType? buffIconType)
		{
			Type typeFromHandle = typeof(MediumItemGridBuffIconComponent);
			bool value;
			if (buffIconType != null)
			{
				EMediumItemGridBuffType? emediumItemGridBuffType = buffIconType;
				EMediumItemGridBuffType emediumItemGridBuffType2 = EMediumItemGridBuffType.None;
				value = !(emediumItemGridBuffType.GetValueOrDefault() == emediumItemGridBuffType2 & emediumItemGridBuffType != null);
			}
			else
			{
				value = false;
			}
			base.RefreshComponent(typeFromHandle, new bool?(value), buffIconType);
		}

		// Token: 0x0603B313 RID: 242451 RVA: 0x00E1D246 File Offset: 0x00E1B446
		public void SetIsPhantomLock(bool? isPhantomLock)
		{
			base.RefreshComponent(typeof(MediumItemGridPhantomLockComponent), new bool?(isPhantomLock.GetValueOrDefault()), isPhantomLock);
		}

		// Token: 0x0603B314 RID: 242452 RVA: 0x00E1D26C File Offset: 0x00E1B46C
		public void SetLevelAndLock(int? level, bool? isLockVisible, bool? isLevelUseChangeColor = null, bool? isUseVision = null, bool? isDeprecate = null, bool? isLevelInfinite = null)
		{
			MediumLevelAndLock @params = new MediumLevelAndLock
			{
				Level = level,
				IsLevelInfinite = isLevelInfinite,
				IsLockVisible = isLockVisible,
				IsLevelUseChangeColor = isLevelUseChangeColor,
				IsUseVision = isUseVision,
				IsDeprecate = isDeprecate
			};
			base.RefreshComponent(typeof(MediumItemGridLevelAndLockComponent), new bool?(level != null || isLockVisible.GetValueOrDefault() || isLevelInfinite.GetValueOrDefault()), @params);
		}

		// Token: 0x0603B315 RID: 242453 RVA: 0x00E1D2E0 File Offset: 0x00E1B4E0
		public void SetLevelAndStar(IMediumLevelAndStar data)
		{
			base.RefreshComponent(typeof(MediumItemGridLvAndStarComponent), new bool?((data != null && data.Level != null) || (data != null && data.Star != null)), data);
		}

		// Token: 0x0603B316 RID: 242454 RVA: 0x00E1D32E File Offset: 0x00E1B52E
		public void SetItemPrice(IMediumItemPrice data)
		{
			base.RefreshComponent(typeof(MediumItemGridItemPriceComponent), new bool?(data != null), data);
		}

		// Token: 0x0603B317 RID: 242455 RVA: 0x00E1D34B File Offset: 0x00E1B54B
		public void SetFrameEffectVisible(bool? bVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridFrameEffectComponent), new bool?(bVisible.GetValueOrDefault()), bVisible);
		}

		// Token: 0x0603B318 RID: 242456 RVA: 0x00E1D370 File Offset: 0x00E1B570
		public void SetRedDotVisible(bool? isRedDotVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridRedDotComponent), new bool?(isRedDotVisible.GetValueOrDefault()), isRedDotVisible);
		}

		// Token: 0x0603B319 RID: 242457 RVA: 0x00E1D395 File Offset: 0x00E1B595
		public void SetNewVisible(bool? isNewVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridNewFlagComponent), new bool?(isNewVisible.GetValueOrDefault()), isNewVisible);
		}

		// Token: 0x0603B31A RID: 242458 RVA: 0x00E1D3BA File Offset: 0x00E1B5BA
		public void SetStartLevel(int? startLevel)
		{
		}

		// Token: 0x0603B31B RID: 242459 RVA: 0x00E1D3BC File Offset: 0x00E1B5BC
		public void SetRoleHead(RoleHeadInfo roleHeadInfo)
		{
			Type typeFromHandle = typeof(MediumItemGridRoleHeadComponent);
			bool value;
			if (roleHeadInfo != null)
			{
				int? roleConfigId = roleHeadInfo.RoleConfigId;
				int num = 0;
				value = (roleConfigId.GetValueOrDefault() > num & roleConfigId != null);
			}
			else
			{
				value = false;
			}
			base.RefreshComponent(typeFromHandle, new bool?(value), roleHeadInfo);
		}

		// Token: 0x0603B31C RID: 242460 RVA: 0x00E1D404 File Offset: 0x00E1B604
		public void SetVisionRoleHead(VisionRoleHeadInfo roleHeadInfo)
		{
			Type typeFromHandle = typeof(MediumItemGridVisionRoleHeadComponent);
			bool value;
			if (roleHeadInfo != null)
			{
				int? roleConfigId = roleHeadInfo.RoleConfigId;
				int num = 0;
				value = (roleConfigId.GetValueOrDefault() > num & roleConfigId != null);
			}
			else
			{
				value = false;
			}
			base.RefreshComponent(typeFromHandle, new bool?(value), roleHeadInfo);
		}

		// Token: 0x0603B31D RID: 242461 RVA: 0x00E1D44C File Offset: 0x00E1B64C
		public void SetPhantomIsSpecialSkill(EMediumItemGridPhantomSpecialSkill? specialSkill)
		{
			bool flag;
			if (specialSkill != null)
			{
				EMediumItemGridPhantomSpecialSkill? emediumItemGridPhantomSpecialSkill = specialSkill;
				EMediumItemGridPhantomSpecialSkill emediumItemGridPhantomSpecialSkill2 = EMediumItemGridPhantomSpecialSkill.Hide;
				flag = !(emediumItemGridPhantomSpecialSkill.GetValueOrDefault() == emediumItemGridPhantomSpecialSkill2 & emediumItemGridPhantomSpecialSkill != null);
			}
			else
			{
				flag = false;
			}
			bool value = flag;
			base.RefreshComponent(typeof(MediumItemGridPhantomSpecialSkillComponent), new bool?(value), specialSkill);
		}

		// Token: 0x0603B31E RID: 242462 RVA: 0x00E1D49C File Offset: 0x00E1B69C
		public void SetPhantomSortNum(int? sortNum)
		{
			bool flag;
			if (sortNum != null)
			{
				int? num = sortNum;
				int num2 = 0;
				flag = (num.GetValueOrDefault() > num2 & num != null);
			}
			else
			{
				flag = false;
			}
			bool value = flag;
			base.RefreshComponent(typeof(MediumItemGridPhantomSortNumComponent), new bool?(value), sortNum);
		}

		// Token: 0x0603B31F RID: 242463 RVA: 0x00E1D4EC File Offset: 0x00E1B6EC
		public void SetPhantomStackDisplay(PhantomStackDisplay stackDisplay)
		{
			if (stackDisplay == null)
			{
				this.SetBgByResourceId("SP_QualityFrmA");
				this.SetStackFlagVisible(false);
				return;
			}
			bool flag = !stackDisplay.CanStack && !stackDisplay.AlwaysShowSelected;
			this.SetBgByResourceId(flag ? "SP_QualityFrmAEcho" : "SP_QualityFrmA");
			this.SetStackFlagVisible(!flag);
			if (!flag)
			{
				string stackBottomText = PhantomStackUtil.GetStackBottomText(stackDisplay.StackCount, stackDisplay.SelectedCount, stackDisplay.AlwaysShowSelected);
				this.SetBottomTextVisible(true);
				this.SetBottomText(stackBottomText);
			}
		}

		// Token: 0x0603B320 RID: 242464 RVA: 0x00E1D56C File Offset: 0x00E1B76C
		[NullableContext(1)]
		private void SetBgByResourceId(string resourceId)
		{
			if (this.CurrentBgResourceId == resourceId)
			{
				return;
			}
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (StringUtils.IsEmpty(resourcePath))
			{
				return;
			}
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
			this.CurrentBgResourceId = resourceId;
		}

		// Token: 0x0603B321 RID: 242465 RVA: 0x00E1D5C3 File Offset: 0x00E1B7C3
		private void SetStackFlagVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(11);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x0603B322 RID: 242466 RVA: 0x00E1D5D8 File Offset: 0x00E1B7D8
		public void SetComposeIcon(MediumItemGridComposeTag composeTag)
		{
			base.RefreshComponent(typeof(MediumItemGridComposeTag), new bool?(composeTag != null), composeTag);
		}

		// Token: 0x0603B323 RID: 242467 RVA: 0x00E1D5F5 File Offset: 0x00E1B7F5
		public void SetComposeChangeAble(bool? isChangeAble)
		{
			base.RefreshComponent(typeof(MediumItemGridChangeAbleComponent), new bool?(isChangeAble.GetValueOrDefault()), isChangeAble);
		}

		// Token: 0x0603B324 RID: 242468 RVA: 0x00E1D61A File Offset: 0x00E1B81A
		public void SetVisionSlotState(EMediumItemGridVisionSlotState[] visionSlotStateList)
		{
			base.RefreshComponent(typeof(MediumItemGridVisionSlotComponent), new bool?(visionSlotStateList != null && visionSlotStateList.Length != 0), visionSlotStateList);
		}

		// Token: 0x0603B325 RID: 242469 RVA: 0x00E1D63E File Offset: 0x00E1B83E
		public void SetDevelopRewardInfo(DevelopRewardInfo developRewardInfo)
		{
			base.RefreshComponent(typeof(MediumItemGridDevelopRewardComponent), new bool?(developRewardInfo != null), developRewardInfo);
		}

		// Token: 0x0603B326 RID: 242470 RVA: 0x00E1D65B File Offset: 0x00E1B85B
		public void SetIsMainVision(bool? isMainVisionVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridMainVisionComponent), new bool?(isMainVisionVisible.GetValueOrDefault()), isMainVisionVisible);
		}

		// Token: 0x0603B327 RID: 242471 RVA: 0x00E1D680 File Offset: 0x00E1B880
		public void SetCoolDown(float? coolDown, float? totalCdTime)
		{
			MediumItemGridCoolDownComponentParams @params = new MediumItemGridCoolDownComponentParams
			{
				CoolDown = coolDown,
				TotalCdTime = totalCdTime
			};
			Type typeFromHandle = typeof(MediumItemGridCoolDownComponent);
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

		// Token: 0x0603B328 RID: 242472 RVA: 0x00E1D6DE File Offset: 0x00E1B8DE
		public void SetIsProhibit(bool? isProhibit)
		{
			base.RefreshComponent(typeof(MediumItemGridProhibitComponent), new bool?(isProhibit.GetValueOrDefault()), isProhibit);
		}

		// Token: 0x0603B329 RID: 242473 RVA: 0x00E1D704 File Offset: 0x00E1B904
		public void SetReduceButton(LongPressButton reduceButtonInfo)
		{
			bool? flag = (reduceButtonInfo != null) ? reduceButtonInfo.IsVisible : null;
			MediumItemGridReduceButtonComponent mediumItemGridReduceButtonComponent = base.RefreshComponent(typeof(MediumItemGridReduceButtonComponent), new bool?(flag.GetValueOrDefault()), reduceButtonInfo) as MediumItemGridReduceButtonComponent;
			if (mediumItemGridReduceButtonComponent == null)
			{
				return;
			}
			if (flag.GetValueOrDefault())
			{
				mediumItemGridReduceButtonComponent.BindReduceButtonCallback(new Action(this.OnClickedReduceButton));
				mediumItemGridReduceButtonComponent.BindLongPressCallback(new Action<bool>(this.OnReduceButtonLongPressActive));
				return;
			}
			mediumItemGridReduceButtonComponent.UnBindReduceButtonCallback();
			mediumItemGridReduceButtonComponent.UnBindLongPressCallback();
		}

		// Token: 0x0603B32A RID: 242474 RVA: 0x00E1D787 File Offset: 0x00E1B987
		public void SetRoundCount(int? round)
		{
			base.RefreshComponent(typeof(MediumItemGridRoundCountComponent), new bool?(round != null), round);
		}

		// Token: 0x0603B32B RID: 242475 RVA: 0x00E1D7AC File Offset: 0x00E1B9AC
		public void SetWarningPanelInfo(MediumWarningPanelInfo info = null)
		{
			base.RefreshComponent(typeof(MediumItemGridWarningPanelComponent), new bool?(info != null), info);
		}

		// Token: 0x0603B32C RID: 242476 RVA: 0x00E1D7CC File Offset: 0x00E1B9CC
		public void SetSortIndex(int? sortIndex, bool highlight = false)
		{
			if (highlight)
			{
				base.RefreshComponent(typeof(MediumItemGridSortHighlightIndexComponent), new bool?(sortIndex != null), sortIndex);
				return;
			}
			base.RefreshComponent(typeof(MediumItemGridSortIndexComponent), new bool?(sortIndex != null), sortIndex);
		}

		// Token: 0x0603B32D RID: 242477 RVA: 0x00E1D823 File Offset: 0x00E1BA23
		public void SetTeamIcon(bool? isInTeam)
		{
			base.RefreshComponent(typeof(MediumItemGridTeamIconComponent), new bool?(isInTeam != null), isInTeam);
		}

		// Token: 0x0603B32E RID: 242478 RVA: 0x00E1D848 File Offset: 0x00E1BA48
		[NullableContext(1)]
		public void BindReduceLongPress(Action<bool, MediumItemGrid, object> callback)
		{
			this.OnReduceButtonLongActiveCallback = callback;
		}

		// Token: 0x0603B32F RID: 242479 RVA: 0x00E1D851 File Offset: 0x00E1BA51
		public void UnBindReduceLongPress()
		{
			this.OnReduceButtonLongActiveCallback = null;
		}

		// Token: 0x0603B330 RID: 242480 RVA: 0x00E1D85A File Offset: 0x00E1BA5A
		private void OnReduceButtonLongPressActive(bool isShortPress)
		{
			if (this.OnReduceButtonLongActiveCallback != null)
			{
				this.OnReduceButtonLongActiveCallback(isShortPress, this, this.Data);
			}
		}

		// Token: 0x0603B331 RID: 242481 RVA: 0x00E1D878 File Offset: 0x00E1BA78
		private void OnClickedReduceButton()
		{
			if (this.OnClickedReduceButtonCallback != null)
			{
				MediumItemGridButtonCallback obj = new MediumItemGridButtonCallback
				{
					MediumItemGrid = this,
					Data = this.Data
				};
				this.OnClickedReduceButtonCallback(obj);
			}
		}

		// Token: 0x0603B332 RID: 242482 RVA: 0x00E1D8B4 File Offset: 0x00E1BAB4
		public void SetCheckTickVisible(bool? isCheckTick)
		{
			MediumItemGridCheckTickComponentParams @params = new MediumItemGridCheckTickComponentParams
			{
				IsCheckTick = isCheckTick
			};
			base.RefreshComponent(typeof(MediumItemGridCheckTickComponent), new bool?(isCheckTick.GetValueOrDefault()), @params);
		}

		// Token: 0x0603B333 RID: 242483 RVA: 0x00E1D8EC File Offset: 0x00E1BAEC
		public void SetCheckTickPerformance(bool? isCheckTick, string hexColor, float? alpha, string tickHexColor)
		{
			MediumItemGridCheckTickComponentParams @params = new MediumItemGridCheckTickComponentParams
			{
				IsCheckTick = isCheckTick,
				HexColor = hexColor,
				Alpha = alpha,
				TickHexColor = tickHexColor
			};
			base.RefreshComponent(typeof(MediumItemGridCheckTickComponent), new bool?(isCheckTick.GetValueOrDefault()), @params);
		}

		// Token: 0x0603B334 RID: 242484 RVA: 0x00E1D93A File Offset: 0x00E1BB3A
		public void SetTimeFlagVisible(bool? isTimeFlagVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridTimeFlagComponent), new bool?(isTimeFlagVisible.GetValueOrDefault()), isTimeFlagVisible);
		}

		// Token: 0x0603B335 RID: 242485 RVA: 0x00E1D95F File Offset: 0x00E1BB5F
		public void SetReceivedFlagVisible(bool? isReceivedFlagVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridReceivedComponent), new bool?(isReceivedFlagVisible.GetValueOrDefault()), isReceivedFlagVisible);
		}

		// Token: 0x0603B336 RID: 242486 RVA: 0x00E1D984 File Offset: 0x00E1BB84
		public void SetEmptySlotVisible(bool isVisible)
		{
			MediumItemGridEmptySlotComponent mediumItemGridEmptySlotComponent = base.RefreshComponent(typeof(MediumItemGridEmptySlotComponent), new bool?(isVisible), isVisible) as MediumItemGridEmptySlotComponent;
			if (mediumItemGridEmptySlotComponent == null)
			{
				return;
			}
			if (isVisible)
			{
				mediumItemGridEmptySlotComponent.BindEmptySlotButtonCallback(new Action(this.OnClickedEmptySlotButton));
				return;
			}
			mediumItemGridEmptySlotComponent.UnBindEmptySlotButtonCallback();
		}

		// Token: 0x0603B337 RID: 242487 RVA: 0x00E1D9D4 File Offset: 0x00E1BBD4
		public void SetOnlyEmptyVisible(bool isVisible, OnlyEmptyItemGrid parameters)
		{
			MediumItemGridEmptyComponent mediumItemGridEmptyComponent = base.RefreshComponent(typeof(MediumItemGridEmptyComponent), new bool?(isVisible), isVisible) as MediumItemGridEmptyComponent;
			if (mediumItemGridEmptyComponent == null)
			{
				return;
			}
			mediumItemGridEmptyComponent.OnClickedCallback = ((parameters != null) ? parameters.OnClickedCallback : null);
			mediumItemGridEmptyComponent.SetClickable(parameters != null && parameters.IsClickable.GetValueOrDefault());
		}

		// Token: 0x0603B338 RID: 242488 RVA: 0x00E1DA30 File Offset: 0x00E1BC30
		private void SetBgVisible(bool bVisible)
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(bVisible);
		}

		// Token: 0x0603B339 RID: 242489 RVA: 0x00E1DA44 File Offset: 0x00E1BC44
		private void OnClickedEmptySlotButton()
		{
			if (this.OnClickedEmptySlotButtonCallback != null)
			{
				MediumItemGridButtonCallback obj = new MediumItemGridButtonCallback
				{
					MediumItemGrid = this,
					Data = this.Data
				};
				this.OnClickedEmptySlotButtonCallback(obj);
			}
		}

		// Token: 0x0603B33A RID: 242490 RVA: 0x00E1DA7E File Offset: 0x00E1BC7E
		public void SetElement(int? elementId)
		{
			base.RefreshComponent(typeof(MediumItemGridElementComponent), new bool?(elementId != null), elementId);
		}

		// Token: 0x0603B33B RID: 242491 RVA: 0x00E1DAA3 File Offset: 0x00E1BCA3
		public void SetRecommendVisible(bool? isRecommendVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridRecommendComponent), new bool?(isRecommendVisible.GetValueOrDefault()), isRecommendVisible);
		}

		// Token: 0x0603B33C RID: 242492 RVA: 0x00E1DAC8 File Offset: 0x00E1BCC8
		public void SetUnRecommendVisible(bool? isUnRecommendVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridUnRecommendComponent), new bool?(isUnRecommendVisible.GetValueOrDefault()), isUnRecommendVisible);
		}

		// Token: 0x0603B33D RID: 242493 RVA: 0x00E1DAED File Offset: 0x00E1BCED
		public void SetIsDisable(bool? isRoleDisable)
		{
			base.RefreshComponent(typeof(MediumItemGridDisableComponent), new bool?(isRoleDisable.GetValueOrDefault()), isRoleDisable);
		}

		// Token: 0x0603B33E RID: 242494 RVA: 0x00E1DB14 File Offset: 0x00E1BD14
		public void SetVisionFetterGroup(int? fetterGroupId)
		{
			Type typeFromHandle = typeof(MediumItemGridVisionFetterComponent);
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

		// Token: 0x0603B33F RID: 242495 RVA: 0x00E1DB60 File Offset: 0x00E1BD60
		public bool IsDisable()
		{
			ItemGridComponent itemGridComponent = base.GetItemGridComponent(typeof(MediumItemGridDisableComponent));
			return itemGridComponent != null && itemGridComponent.GetActive();
		}

		// Token: 0x0603B340 RID: 242496 RVA: 0x00E1DB89 File Offset: 0x00E1BD89
		public void SetTrialRoleVisible(bool? isTrialRoleVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridTimeFlagComponent), new bool?(isTrialRoleVisible.GetValueOrDefault()), isTrialRoleVisible);
		}

		// Token: 0x0603B341 RID: 242497 RVA: 0x00E1DBAE File Offset: 0x00E1BDAE
		public void SetRoleRightBottomTagVisible(MediumRoleRightBottomTag roleRightBottomTag)
		{
			base.RefreshComponent(typeof(MediumItemGridRoleRightBottomTag), new bool?(roleRightBottomTag != null), roleRightBottomTag);
		}

		// Token: 0x0603B342 RID: 242498 RVA: 0x00E1DBCB File Offset: 0x00E1BDCB
		public void SetTrialRoleRightBottomTagVisible(MediumTrialRoleRightBottomTag trialRoleRightBottomTag)
		{
			base.RefreshComponent(typeof(MediumItemGridTrialRoleRightBottomTag), new bool?(trialRoleRightBottomTag != null), trialRoleRightBottomTag);
		}

		// Token: 0x0603B343 RID: 242499 RVA: 0x00E1DBE8 File Offset: 0x00E1BDE8
		public void SetIconSprite(string iconSpritePath)
		{
			UUISprite sprite = base.GetSprite(10);
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

		// Token: 0x0603B344 RID: 242500 RVA: 0x00E1DC2E File Offset: 0x00E1BE2E
		public void SetSkinIcon(int? itemConfigId)
		{
			if (itemConfigId == null)
			{
				return;
			}
			base.RefreshComponent(typeof(MediumItemGridSkinComponent), new bool?(true), itemConfigId);
		}

		// Token: 0x0603B345 RID: 242501 RVA: 0x00E1DC58 File Offset: 0x00E1BE58
		private void SetIconTexture(string iconPath)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(iconPath))
			{
				texture.SetUIActive(false);
				return;
			}
			texture.SetUIActive(true);
			base.SetTextureByPath(iconPath, texture, null, null);
		}

		// Token: 0x0603B346 RID: 242502 RVA: 0x00E1DC9C File Offset: 0x00E1BE9C
		[NullableContext(1)]
		public void ApplyEmptyDisplay(EmptyItemGrid parameters)
		{
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

		// Token: 0x0603B347 RID: 242503 RVA: 0x00E1DCEC File Offset: 0x00E1BEEC
		[NullableContext(1)]
		public void ApplyPropBaseDisplay(PropMediumItemGrid parameters)
		{
			int? itemConfigId = parameters.ItemConfigId;
			string bottomTextId = parameters.BottomTextId;
			string bottomText = parameters.BottomText;
			object[] bottomTextParameter = parameters.BottomTextParameter;
			string spriteIconPath = parameters.SpriteIconPath;
			this.Data = parameters.Data;
			UUITexture texture = base.GetTexture(1);
			InventoryConfig instance = InventoryConfig.Instance;
			InventoryDefine.EItemDataType? eitemDataType = (instance != null) ? new InventoryDefine.EItemDataType?(instance.GetItemDataTypeByConfigId(parameters.ItemConfigId)) : null;
			if (parameters.IsIconHide.GetValueOrDefault())
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
				this.SetDangoItemTexture(itemConfigId);
			}
			else if (eitemDataType.GetValueOrDefault() == InventoryDefine.EItemDataType.MotorStickerItem)
			{
				this.SetMotorStickerTexture(itemConfigId.Value);
			}
			else
			{
				this.SetTexture(itemConfigId);
			}
			if (eitemDataType.GetValueOrDefault() == InventoryDefine.EItemDataType.WeaponSkinItem || eitemDataType.GetValueOrDefault() == InventoryDefine.EItemDataType.OrnamentItem)
			{
				this.SetSkinIcon(itemConfigId);
			}
			this.SetIconSprite(spriteIconPath);
			this.SetItemQuality(parameters);
			bool flag = !StringUtils.IsEmpty(bottomTextId) || !StringUtils.IsEmpty(bottomText);
			this.SetBottomTextVisible(flag);
			if (flag)
			{
				this.SetBottomTextId(bottomTextId, bottomTextParameter);
				this.SetBottomText(bottomText);
			}
			base.SetExtendToggleEnable(true, false);
			this.SetBgVisible(true);
		}

		// Token: 0x0603B348 RID: 242504 RVA: 0x00E1DE4C File Offset: 0x00E1C04C
		[NullableContext(1)]
		public void ApplyPhantomBaseDisplay(PhantomMediumItemGrid parameters)
		{
			int? itemConfigId = parameters.ItemConfigId;
			string bottomTextId = parameters.BottomTextId;
			string bottomText = parameters.BottomText;
			object[] bottomTextParameter = parameters.BottomTextParameter;
			int? monsterId = parameters.MonsterId;
			this.Data = parameters.Data;
			if (monsterId != null)
			{
				this.SetMonsterTexture(monsterId);
			}
			else
			{
				this.SetTexture(itemConfigId);
			}
			this.SetNormalItemQualityInternal(parameters.IsQualityHidden, parameters.QualityId, parameters.ItemConfigId, parameters.QualityIcon, parameters.QualityType);
			bool flag = !StringUtils.IsEmpty(bottomTextId) || !StringUtils.IsEmpty(bottomText);
			this.SetBottomTextVisible(flag);
			if (flag)
			{
				this.SetBottomTextId(bottomTextId, bottomTextParameter);
				this.SetBottomText(bottomText);
			}
			base.SetExtendToggleEnable(true, false);
			this.SetBgVisible(true);
		}

		// Token: 0x0603B349 RID: 242505 RVA: 0x00E1DF08 File Offset: 0x00E1C108
		[NullableContext(1)]
		public void ApplyCharacterBaseDisplay(CharacterMediumItemGrid parameters)
		{
			int? itemConfigId = parameters.ItemConfigId;
			string bottomTextId = parameters.BottomTextId;
			string bottomText = parameters.BottomText;
			object[] bottomTextParameter = parameters.BottomTextParameter;
			int skinId = parameters.SkinId;
			this.Data = parameters.Data;
			UUITexture texture = base.GetTexture(1);
			int? num = itemConfigId;
			int num2 = 10000;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				itemConfigId = new int?(RoleConfig.Instance.GetTrialRoleConfig(itemConfigId.Value).Value.ParentId);
			}
			string roleHeadIconLarge = SkinConfig.Instance.GetRoleSkinConfig(skinId).Value.RoleHeadIconLarge;
			base.SetRoleSkinIcon(roleHeadIconLarge, texture, skinId, null, null);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			this.SetNormalItemQualityInternal(parameters.IsQualityHidden, parameters.QualityId, itemConfigId, parameters.QualityIcon, parameters.QualityType);
			bool flag = !StringUtils.IsEmpty(bottomTextId) || !StringUtils.IsEmpty(bottomText);
			this.SetBottomTextVisible(flag);
			if (flag)
			{
				this.SetBottomTextId(bottomTextId, bottomTextParameter);
				this.SetBottomText(bottomText);
			}
			base.SetExtendToggleEnable(true, false);
			this.SetBgVisible(true);
		}

		// Token: 0x0603B34A RID: 242506 RVA: 0x00E1E03C File Offset: 0x00E1C23C
		[NullableContext(1)]
		public void ApplyForecastCharacterBaseDisplay(ForecastCharacterMediumItemGrid parameters)
		{
			this.Data = parameters.Data;
			RoleDisplayModelBase roleDisplayModelBase = parameters.Data as RoleDisplayModelBase;
			this.SetIconTexture(parameters.IconPath);
			this.SetElement((roleDisplayModelBase != null) ? new int?(roleDisplayModelBase.ElementId) : null);
			this.SetBottomText(parameters.BottomText);
			bool flag = !StringUtils.IsEmpty(parameters.BottomTextId) || !StringUtils.IsEmpty(parameters.BottomText);
			this.SetBottomTextVisible(flag);
			if (flag)
			{
				this.SetBottomTextId(parameters.BottomTextId, parameters.BottomTextParameter);
				this.SetBottomText(parameters.BottomText);
			}
			this.SetRoleDevTag(parameters.RoleDevTag);
			base.SetExtendToggleEnable(true, false);
			this.SetBgVisible(true);
		}

		// Token: 0x0603B34B RID: 242507 RVA: 0x00E1E0FC File Offset: 0x00E1C2FC
		private void SetTexture(int? itemConfigId)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Quest;
				ELogAuthor author = ELogAuthor.LRX;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(41, 2);
				defaultInterpolatedStringHandler.AppendFormatted(base.GetType().Name);
				defaultInterpolatedStringHandler.AppendLiteral(":GetTexture with ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(1);
				defaultInterpolatedStringHandler.AppendLiteral(" return null UUITexture!");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (itemConfigId == null)
			{
				texture.SetUIActive(false);
				return;
			}
			int textureItemConfigId = this.TextureItemConfigId;
			int? num = itemConfigId;
			if (textureItemConfigId == num.GetValueOrDefault() & num != null)
			{
				texture.SetUIActive(true);
				return;
			}
			this.TextureItemConfigId = itemConfigId.Value;
			base.SetItemIcon(texture, itemConfigId.Value, null, null);
			texture.SetUIActive(true);
		}

		// Token: 0x0603B34C RID: 242508 RVA: 0x00E1E1D0 File Offset: 0x00E1C3D0
		private void SetDangoItemTexture(int? itemId)
		{
			DangoPluginIconInfo dangoPluginIcon = new DangoPluginIconInfo
			{
				PluginItemId = itemId.GetValueOrDefault()
			};
			this.SetDangoPluginIcon(dangoPluginIcon);
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
		}

		// Token: 0x0603B34D RID: 242509 RVA: 0x00E1E20C File Offset: 0x00E1C40C
		private void SetMonsterTexture(int? monsterId)
		{
			UUITexture texture = base.GetTexture(1);
			if (monsterId == null)
			{
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				return;
			}
			string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(monsterId.Value);
			base.SetTextureByPath(monsterIcon, texture, null, null);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
		}

		// Token: 0x0603B34E RID: 242510 RVA: 0x00E1E264 File Offset: 0x00E1C464
		private void SetQuality(int? itemConfigId)
		{
			UUISprite sprite = base.GetSprite(0);
			if (itemConfigId == null)
			{
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				return;
			}
			int qualityItemConfigId = this.QualityItemConfigId;
			int? num = itemConfigId;
			if (qualityItemConfigId == num.GetValueOrDefault() & num != null)
			{
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				return;
			}
			base.SetItemQualityIcon(sprite, itemConfigId.Value, null, CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath, null);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			this.QualityItemConfigId = itemConfigId.Value;
		}

		// Token: 0x0603B34F RID: 242511 RVA: 0x00E1E2E4 File Offset: 0x00E1C4E4
		private void SetDangoAbyssItemQuality(int? itemConfigId)
		{
			UUISprite sprite = base.GetSprite(0);
			if (itemConfigId == null)
			{
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				return;
			}
			int qualityItemConfigId = this.QualityItemConfigId;
			int? num = itemConfigId;
			if (qualityItemConfigId == num.GetValueOrDefault() & num != null)
			{
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				return;
			}
			this.SetSpriteByPath(DangoAbyssConfig.Instance.GetAbyssQualityByPluginItemId(itemConfigId.Value).Value.MediumItemGridQualitySpritePath, sprite, true, null, null);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			this.QualityItemConfigId = itemConfigId.Value;
		}

		// Token: 0x0603B350 RID: 242512 RVA: 0x00E1E380 File Offset: 0x00E1C580
		private void SetQualityByResourceId(string resourceId)
		{
			UUISprite sprite = base.GetSprite(0);
			if (string.IsNullOrEmpty(resourceId))
			{
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (StringUtils.IsEmpty(resourcePath))
			{
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				return;
			}
			this.SetSpriteByPath(resourcePath, sprite, true, null, null);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
		}

		// Token: 0x0603B351 RID: 242513 RVA: 0x00E1E3E4 File Offset: 0x00E1C5E4
		private void SetQualityByPath(string path)
		{
			UUISprite sprite = base.GetSprite(0);
			bool flag = !string.IsNullOrEmpty(path);
			if (sprite != null)
			{
				sprite.SetUIActive(flag);
			}
			if (flag)
			{
				this.SetSpriteByPath(path, sprite, false, null, null);
			}
		}

		// Token: 0x0603B352 RID: 242514 RVA: 0x00E1E424 File Offset: 0x00E1C624
		public void SetSkinQuality(int? itemConfigId)
		{
			UUISprite sprite = base.GetSprite(8);
			if (itemConfigId == null)
			{
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				return;
			}
			int qualityItemConfigId = this.QualityItemConfigId;
			int? num = itemConfigId;
			if (qualityItemConfigId == num.GetValueOrDefault() & num != null)
			{
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				return;
			}
			UUISprite sprite2 = base.GetSprite(0);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			this.QualityItemConfigId = itemConfigId.Value;
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemConfigId.Value);
			this.SetSpriteByPath(CommonConfig.Instance.GetItemQualityById(itemConfigData.QualityId).Value.SkinQualityItemA, sprite, false, null, null);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
		}

		// Token: 0x0603B353 RID: 242515 RVA: 0x00E1E4E4 File Offset: 0x00E1C6E4
		[NullableContext(1)]
		private void SetPinballItemQuality(MediumItemGridBase parameters)
		{
			if (parameters == null || parameters.ItemConfigId == null)
			{
				UUISprite sprite = base.GetSprite(0);
				if (sprite == null)
				{
					return;
				}
				sprite.SetUIActive(false);
				return;
			}
			else
			{
				InventoryConfig instance = InventoryConfig.Instance;
				ItemConfig itemConfig = (instance != null) ? instance.GetItemConfigData(parameters.ItemConfigId.Value) : null;
				if (itemConfig != null)
				{
					this.SetNormalItemQualityInternal(parameters.IsQualityHidden, new int?(parameters.QualityId ?? itemConfig.QualityId), parameters.ItemConfigId, parameters.QualityIcon, new CommonDefine.EQualityIconType?(parameters.QualityType.GetValueOrDefault(CommonDefine.EQualityIconType.TypeAGridQualitySpritePath)));
					return;
				}
				UUISprite sprite2 = base.GetSprite(0);
				if (sprite2 == null)
				{
					return;
				}
				sprite2.SetUIActive(false);
				return;
			}
		}

		// Token: 0x0603B354 RID: 242516 RVA: 0x00E1E594 File Offset: 0x00E1C794
		[NullableContext(1)]
		private void SetItemQuality(MediumItemGridBase parameters)
		{
			int? itemConfigId = parameters.ItemConfigId;
			bool? isQualityHidden = parameters.IsQualityHidden;
			int? qualityId = parameters.QualityId;
			string qualityIcon = parameters.QualityIcon;
			CommonDefine.EQualityIconType? qualityType = parameters.QualityType;
			UUISprite sprite = base.GetSprite(0);
			if (isQualityHidden.GetValueOrDefault())
			{
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				return;
			}
			if (!string.IsNullOrEmpty(qualityIcon))
			{
				this.SetQualityByPath(qualityIcon);
				this.QualityItemConfigId = itemConfigId.GetValueOrDefault();
				return;
			}
			if (qualityId != null)
			{
				int? num = qualityId;
				int num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					base.SetQualityIconById(sprite, qualityId.Value, null, new CommonDefine.EQualityIconType?(qualityType.GetValueOrDefault(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath)), null);
					if (sprite != null)
					{
						sprite.SetUIActive(true);
					}
					this.QualityItemConfigId = itemConfigId.GetValueOrDefault();
					return;
				}
			}
			InventoryConfig instance = InventoryConfig.Instance;
			InventoryDefine.EItemDataType? eitemDataType = (instance != null) ? new InventoryDefine.EItemDataType?(instance.GetItemDataTypeByConfigId(parameters.ItemConfigId)) : null;
			if (eitemDataType != null)
			{
				InventoryDefine.EItemDataType valueOrDefault = eitemDataType.GetValueOrDefault();
				if (valueOrDefault == InventoryDefine.EItemDataType.WeaponSkinItem)
				{
					this.SetSkinQuality(parameters.ItemConfigId);
					return;
				}
				if (valueOrDefault == InventoryDefine.EItemDataType.DangoAbyssItem)
				{
					this.SetDangoAbyssItemQuality(parameters.ItemConfigId);
					return;
				}
				if (valueOrDefault - InventoryDefine.EItemDataType.PinballRoleItem <= 1)
				{
					this.SetPinballItemQuality(parameters);
					return;
				}
			}
			this.SetSkinQuality(null);
			this.SetQuality(itemConfigId);
		}

		// Token: 0x0603B355 RID: 242517 RVA: 0x00E1E6F0 File Offset: 0x00E1C8F0
		private void SetNormalItemQualityInternal(bool? isQualityHidden, int? qualityId, int? itemConfigId, string qualityIcon, CommonDefine.EQualityIconType? qualityType)
		{
			UUISprite sprite = base.GetSprite(0);
			if (isQualityHidden.GetValueOrDefault())
			{
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
				return;
			}
			if (!string.IsNullOrEmpty(qualityIcon))
			{
				this.SetQualityByPath(qualityIcon);
				this.QualityItemConfigId = itemConfigId.GetValueOrDefault();
				return;
			}
			if (qualityId != null)
			{
				int? num = qualityId;
				int num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					base.SetQualityIconById(sprite, qualityId.Value, null, new CommonDefine.EQualityIconType?(qualityType.GetValueOrDefault(CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath)), null);
					if (sprite != null)
					{
						sprite.SetUIActive(true);
					}
					this.QualityItemConfigId = itemConfigId.GetValueOrDefault();
					return;
				}
			}
			this.SetQuality(itemConfigId);
		}

		// Token: 0x0603B356 RID: 242518 RVA: 0x00E1E7A0 File Offset: 0x00E1C9A0
		private void SetMotorStickerTexture(int itemId)
		{
			UUITexture texture = base.GetTexture(1);
			MotorDiyConfig instance = MotorDiyConfig.Instance;
			MotorSticker? motorSticker;
			string text = (instance != null) ? ((instance.GetMotorStickerConfig(itemId) != null) ? motorSticker.GetValueOrDefault().IconMiddle : null) : null;
			if (string.IsNullOrEmpty(text))
			{
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				return;
			}
			base.SetTextureByPath(text, texture, null, null);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
		}

		// Token: 0x0603B357 RID: 242519 RVA: 0x00E1E814 File Offset: 0x00E1CA14
		public void SetCurTagIcon(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridCurTagComponent), isShow, isShow);
		}

		// Token: 0x0603B358 RID: 242520 RVA: 0x00E1E830 File Offset: 0x00E1CA30
		public void SetBottomTextVisible(bool bVisible)
		{
			UUIText text = base.GetText(2);
			if (text != null && text.IsUIActiveSelf() == bVisible)
			{
				return;
			}
			if (text != null)
			{
				text.SetUIActive(bVisible);
			}
		}

		// Token: 0x0603B359 RID: 242521 RVA: 0x00E1E85C File Offset: 0x00E1CA5C
		public void SetBottomTextId(string textId, [Nullable(new byte[]
		{
			2,
			1
		})] object[] textParameter)
		{
			UUIText text = base.GetText(2);
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

		// Token: 0x0603B35A RID: 242522 RVA: 0x00E1E89C File Offset: 0x00E1CA9C
		public void SetBottomText(string text)
		{
			UUIText text2 = base.GetText(2);
			if (StringUtils.IsEmpty(text))
			{
				return;
			}
			if (text2 != null)
			{
				text2.SetText(text, true);
			}
		}

		// Token: 0x0603B35B RID: 242523 RVA: 0x00E1E8C5 File Offset: 0x00E1CAC5
		[NullableContext(1)]
		public void BindReduceButtonCallback(Action<MediumItemGridButtonCallback> onClickedReduceButton, [Nullable(2)] object data = null)
		{
			this.OnClickedReduceButtonCallback = onClickedReduceButton;
		}

		// Token: 0x0603B35C RID: 242524 RVA: 0x00E1E8CE File Offset: 0x00E1CACE
		public void UnBindReduceButtonCallback()
		{
			this.OnClickedReduceButtonCallback = null;
		}

		// Token: 0x0603B35D RID: 242525 RVA: 0x00E1E8D7 File Offset: 0x00E1CAD7
		[NullableContext(1)]
		public void BindEmptySlotButtonCallback(Action<MediumItemGridButtonCallback> onClickedEmptySlotButton)
		{
			this.OnClickedEmptySlotButtonCallback = onClickedEmptySlotButton;
		}

		// Token: 0x0603B35E RID: 242526 RVA: 0x00E1E8E0 File Offset: 0x00E1CAE0
		public void UnBindEmptySlotButtonCallback()
		{
			this.OnClickedEmptySlotButtonCallback = null;
		}

		// Token: 0x0603B35F RID: 242527 RVA: 0x00E1E8E9 File Offset: 0x00E1CAE9
		public override UUIExtendToggle GetItemGridExtendToggle()
		{
			return base.GetExtendToggle(6);
		}

		// Token: 0x0603B360 RID: 242528 RVA: 0x00E1E8F2 File Offset: 0x00E1CAF2
		private void SetRoleCost(MediumItemGridCostComponentData costData)
		{
			base.RefreshComponent(typeof(MediumItemGridCostComponent), new bool?(costData != null), costData);
		}

		// Token: 0x0603B361 RID: 242529 RVA: 0x00E1E90F File Offset: 0x00E1CB0F
		[NullableContext(1)]
		public void SetBottomTextColor(string hexColor)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetColor(FColor.FromHex(hexColor));
		}

		// Token: 0x0603B362 RID: 242530 RVA: 0x00E1E928 File Offset: 0x00E1CB28
		public void SetHalfAreaInfo(HaveAreaInfo info)
		{
			bool value = info != null;
			base.RefreshComponent(typeof(MediumItemGridHalfAreaComponent), new bool?(value), info);
		}

		// Token: 0x0603B363 RID: 242531 RVA: 0x00E1E952 File Offset: 0x00E1CB52
		public void SetUpGradeVisible(bool? visible)
		{
			base.RefreshComponent(typeof(MediumItemGridUpgradeComponent), new bool?(visible.GetValueOrDefault()), visible);
		}

		// Token: 0x0603B364 RID: 242532 RVA: 0x00E1E978 File Offset: 0x00E1CB78
		public void SetTagsInfo([Nullable(new byte[]
		{
			2,
			1
		})] string[] tags)
		{
			bool value = tags != null && tags.Length != 0;
			base.RefreshComponent(typeof(MediumItemGridTagsComponent), new bool?(value), tags);
		}

		// Token: 0x0603B365 RID: 242533 RVA: 0x00E1E9AC File Offset: 0x00E1CBAC
		public void SetRightTopValueInfo(string value)
		{
			bool value2 = !string.IsNullOrEmpty(value);
			base.RefreshComponent(typeof(MediumItemGridRightTopValueComponent), new bool?(value2), value);
		}

		// Token: 0x0603B366 RID: 242534 RVA: 0x00E1E9DB File Offset: 0x00E1CBDB
		public void SetIsBranchUpgrade(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridBranchUpgradeComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x0603B367 RID: 242535 RVA: 0x00E1EA00 File Offset: 0x00E1CC00
		public void SetSubIconPath(string path)
		{
			base.RefreshComponent(typeof(MediumItemGridSubIconComponent), new bool?(!string.IsNullOrEmpty(path)), path);
		}

		// Token: 0x0603B368 RID: 242536 RVA: 0x00E1EA22 File Offset: 0x00E1CC22
		public void SetRoleDevTag(ERoleDevelopHotRoleTag? tagType)
		{
			base.RefreshComponent(typeof(MediumItemGridRoleDevTagComponent), new bool?(tagType != null), tagType);
		}

		// Token: 0x0603B369 RID: 242537 RVA: 0x00E1EA47 File Offset: 0x00E1CC47
		public void SetRoleDevelopTagMark(bool? isRoleDevelopTagMarkVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridRoleDevelopTagMarkComponent), new bool?(isRoleDevelopTagMarkVisible.GetValueOrDefault()), isRoleDevelopTagMarkVisible);
		}

		// Token: 0x0603B36A RID: 242538 RVA: 0x00E1EA6C File Offset: 0x00E1CC6C
		public void SetRoleSkillBranch(int? index, int? itemConfigId = null, bool? isTrialRoleVisible = null)
		{
			int? num = index;
			if (num != null && itemConfigId != null && !isTrialRoleVisible.GetValueOrDefault())
			{
				int num2 = itemConfigId.Value;
				if (num2 > 10000)
				{
					num2 = RoleConfig.Instance.GetTrialRoleConfig(num2).Value.ParentId;
				}
				if (!RoleModel.Instance.IsHasRole(num2))
				{
					num = null;
				}
			}
			base.RefreshComponent(typeof(MediumItemGridRoleSkillBranchComponent), new bool?(num != null), num);
		}

		// Token: 0x0603B36B RID: 242539 RVA: 0x00E1EAFA File Offset: 0x00E1CCFA
		public void SetAddLevel(int? addLevel)
		{
			base.RefreshComponent(typeof(MediumItemGridAddLevelComponent), new bool?(addLevel != null), addLevel);
		}

		// Token: 0x0603B36C RID: 242540 RVA: 0x00E1EB1F File Offset: 0x00E1CD1F
		public void SetArchiveIcon(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridArchiveComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x0603B36D RID: 242541 RVA: 0x00E1EB44 File Offset: 0x00E1CD44
		public void SetLeftUpperIcon(string iconPath)
		{
			if (iconPath == null)
			{
				return;
			}
			base.RefreshComponent(typeof(MediumItemGridLeftUpperIconComponent), new bool?(true), iconPath);
		}

		// Token: 0x0603B36E RID: 242542 RVA: 0x00E1EB62 File Offset: 0x00E1CD62
		public void SetWarningTips(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridWarningTipsComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x0603B36F RID: 242543 RVA: 0x00E1EB87 File Offset: 0x00E1CD87
		public void SetUpgradeArrow(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridUpgradeArrowComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x0603B370 RID: 242544 RVA: 0x00E1EBAC File Offset: 0x00E1CDAC
		public void SetTemplateIcon(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridTemplateIconComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x0401ED7B RID: 126331
		private const int TRIAL_ROLE_ID = 10000;

		// Token: 0x0401ED7C RID: 126332
		private int TextureItemConfigId;

		// Token: 0x0401ED7D RID: 126333
		private int QualityItemConfigId;

		// Token: 0x0401ED7E RID: 126334
		[Nullable(1)]
		private string CurrentBgResourceId = "";

		// Token: 0x0401ED7F RID: 126335
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<MediumItemGridButtonCallback> OnClickedReduceButtonCallback;

		// Token: 0x0401ED80 RID: 126336
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<MediumItemGridButtonCallback> OnClickedEmptySlotButtonCallback;

		// Token: 0x0401ED81 RID: 126337
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<bool, MediumItemGrid, object> OnReduceButtonLongActiveCallback;

		// Token: 0x0200BD7B RID: 48507
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04039280 RID: 234112
			public const int QualitySprite = 0;

			// Token: 0x04039281 RID: 234113
			public const int ItemTexture = 1;

			// Token: 0x04039282 RID: 234114
			public const int BottomText = 2;

			// Token: 0x04039283 RID: 234115
			public const int BgSprite = 3;

			// Token: 0x04039284 RID: 234116
			public const int TopAdditionItem = 4;

			// Token: 0x04039285 RID: 234117
			public const int BottomAdditionItem = 5;

			// Token: 0x04039286 RID: 234118
			public const int ExtendToggle = 6;

			// Token: 0x04039287 RID: 234119
			public const int UnderTextAdditionItem = 7;

			// Token: 0x04039288 RID: 234120
			public const int SkinQualitySprite = 8;

			// Token: 0x04039289 RID: 234121
			public const int AniLoop = 9;

			// Token: 0x0403928A RID: 234122
			public const int ItemSprite = 10;

			// Token: 0x0403928B RID: 234123
			public const int PhantomStackFlag = 11;
		}
	}
}
