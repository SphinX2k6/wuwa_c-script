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
	// Token: 0x02004B30 RID: 19248
	[NullableContext(2)]
	[Nullable(0)]
	public class MediumItemGrid : ItemGridBase
	{
		// Token: 0x06030247 RID: 197191 RVA: 0x00D6C9CC File Offset: 0x00D6ABCC
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

		// Token: 0x06030248 RID: 197192 RVA: 0x00D6CB83 File Offset: 0x00D6AD83
		protected override UUIItem OnSetUnderTextAdditionItem()
		{
			return base.GetItem(7);
		}

		// Token: 0x06030249 RID: 197193 RVA: 0x00D6CB8C File Offset: 0x00D6AD8C
		protected override UUIItem OnSetBottomAdditionItem()
		{
			return base.GetItem(5);
		}

		// Token: 0x0603024A RID: 197194 RVA: 0x00D6CB95 File Offset: 0x00D6AD95
		protected override UUIItem OnSetTopAdditionItem()
		{
			return base.GetItem(4);
		}

		// Token: 0x0603024B RID: 197195 RVA: 0x00D6CB9E File Offset: 0x00D6AD9E
		protected override void UnBindComponentEvents()
		{
			this.UnBindReduceButtonCallback();
			this.UnBindEmptySlotButtonCallback();
			this.UnBindReduceLongPress();
		}

		// Token: 0x0603024C RID: 197196 RVA: 0x00D6CBB4 File Offset: 0x00D6ADB4
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

		// Token: 0x0603024D RID: 197197 RVA: 0x00D6CCD4 File Offset: 0x00D6AED4
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

		// Token: 0x0603024E RID: 197198 RVA: 0x00D6CD30 File Offset: 0x00D6AF30
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

		// Token: 0x0603024F RID: 197199 RVA: 0x00D6CD8C File Offset: 0x00D6AF8C
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

		// Token: 0x06030250 RID: 197200 RVA: 0x00D6D040 File Offset: 0x00D6B240
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
			this.SetRoleTowerEnemyLevel(parameters.RoleTowerEnemyLevel);
			this.SetRoleTowerElement(parameters.RoleTowerElementId);
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

		// Token: 0x06030251 RID: 197201 RVA: 0x00D6D18C File Offset: 0x00D6B38C
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
			if (parameters.UseRoleItemAddtion)
			{
				RoleItemAddtionData roleItemAddtion;
				if (!parameters.IsTrialRoleVisible.GetValueOrDefault() && parameters.ShowCostData == null)
				{
					roleItemAddtion = null;
				}
				else
				{
					RoleItemAddtionData roleItemAddtionData = new RoleItemAddtionData();
					roleItemAddtionData.IsTrial = parameters.IsTrialRoleVisible.GetValueOrDefault();
					roleItemAddtion = roleItemAddtionData;
					roleItemAddtionData.CostData = parameters.ShowCostData;
				}
				this.SetRoleItemAddtion(roleItemAddtion);
			}
			else
			{
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
			}
			this.SetLevelAndLock(parameters.Level, parameters.IsShowLock, parameters.IsLevelTextUseChangeColor, null, null, null);
			this.SetNewVisible(new bool?(parameters.IsNewVisible.GetValueOrDefault()));
			if (!parameters.UseRoleItemAddtion)
			{
				this.SetRoleCost(parameters.ShowCostData);
			}
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

		// Token: 0x06030252 RID: 197202 RVA: 0x00D6D3AF File Offset: 0x00D6B5AF
		[NullableContext(1)]
		private void ApplyForecastCharacterMediumItemGrid(ForecastCharacterMediumItemGrid parameters)
		{
			this.ApplyForecastCharacterBaseDisplay(parameters);
		}

		// Token: 0x06030253 RID: 197203 RVA: 0x00D6D3B8 File Offset: 0x00D6B5B8
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

		// Token: 0x06030254 RID: 197204 RVA: 0x00D6D528 File Offset: 0x00D6B728
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

		// Token: 0x06030255 RID: 197205 RVA: 0x00D6D59B File Offset: 0x00D6B79B
		public void SetWeeklyRogueTag(bool? isShowWeeklyRogueTag)
		{
			base.RefreshComponent(typeof(MediumItemGridWeeklyRogueTagComponent), new bool?(isShowWeeklyRogueTag.GetValueOrDefault()), isShowWeeklyRogueTag);
		}

		// Token: 0x06030256 RID: 197206 RVA: 0x00D6D5C0 File Offset: 0x00D6B7C0
		public void SetRogueFinish(bool? isRogueFinish)
		{
			base.RefreshComponent(typeof(MediumItemGridRogueFinishComponent), new bool?(isRogueFinish.GetValueOrDefault()), isRogueFinish);
		}

		// Token: 0x06030257 RID: 197207 RVA: 0x00D6D5E5 File Offset: 0x00D6B7E5
		public void SetGreenSelected(bool? isShowSelect)
		{
			base.RefreshComponent(typeof(MediumItemGridVisionGreenSelectComponent), new bool?(isShowSelect.GetValueOrDefault()), isShowSelect);
		}

		// Token: 0x06030258 RID: 197208 RVA: 0x00D6D60A File Offset: 0x00D6B80A
		public void SetWarningIcon(bool? isShowSelect)
		{
			base.RefreshComponent(typeof(MediumItemGridVisionWarningComponent), isShowSelect, isShowSelect);
		}

		// Token: 0x06030259 RID: 197209 RVA: 0x00D6D624 File Offset: 0x00D6B824
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

		// Token: 0x0603025A RID: 197210 RVA: 0x00D6D695 File Offset: 0x00D6B895
		public void SetDangoPluginIcon(IDangoPluginIconInfo dangoPluginIconInfo)
		{
			base.RefreshComponent(typeof(MediumItemGridDangoPluginIconComponent), new bool?(true), dangoPluginIconInfo);
		}

		// Token: 0x0603025B RID: 197211 RVA: 0x00D6D6B0 File Offset: 0x00D6B8B0
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

		// Token: 0x0603025C RID: 197212 RVA: 0x00D6D6FE File Offset: 0x00D6B8FE
		public void SetIsPhantomLock(bool? isPhantomLock)
		{
			base.RefreshComponent(typeof(MediumItemGridPhantomLockComponent), new bool?(isPhantomLock.GetValueOrDefault()), isPhantomLock);
		}

		// Token: 0x0603025D RID: 197213 RVA: 0x00D6D724 File Offset: 0x00D6B924
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

		// Token: 0x0603025E RID: 197214 RVA: 0x00D6D798 File Offset: 0x00D6B998
		public void SetLevelAndStar(IMediumLevelAndStar data)
		{
			base.RefreshComponent(typeof(MediumItemGridLvAndStarComponent), new bool?((data != null && data.Level != null) || (data != null && data.Star != null)), data);
		}

		// Token: 0x0603025F RID: 197215 RVA: 0x00D6D7E6 File Offset: 0x00D6B9E6
		public void SetItemPrice(IMediumItemPrice data)
		{
			base.RefreshComponent(typeof(MediumItemGridItemPriceComponent), new bool?(data != null), data);
		}

		// Token: 0x06030260 RID: 197216 RVA: 0x00D6D803 File Offset: 0x00D6BA03
		public void SetFrameEffectVisible(bool? bVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridFrameEffectComponent), new bool?(bVisible.GetValueOrDefault()), bVisible);
		}

		// Token: 0x06030261 RID: 197217 RVA: 0x00D6D828 File Offset: 0x00D6BA28
		public void SetRedDotVisible(bool? isRedDotVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridRedDotComponent), new bool?(isRedDotVisible.GetValueOrDefault()), isRedDotVisible);
		}

		// Token: 0x06030262 RID: 197218 RVA: 0x00D6D84D File Offset: 0x00D6BA4D
		public void SetNewVisible(bool? isNewVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridNewFlagComponent), new bool?(isNewVisible.GetValueOrDefault()), isNewVisible);
		}

		// Token: 0x06030263 RID: 197219 RVA: 0x00D6D872 File Offset: 0x00D6BA72
		public void SetStartLevel(int? startLevel)
		{
		}

		// Token: 0x06030264 RID: 197220 RVA: 0x00D6D874 File Offset: 0x00D6BA74
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

		// Token: 0x06030265 RID: 197221 RVA: 0x00D6D8BC File Offset: 0x00D6BABC
		public void SetVisionRoleHead(VisionRoleHeadInfo roleHeadInfo)
		{
			bool flag;
			if (roleHeadInfo != null)
			{
				int? roleConfigId = roleHeadInfo.RoleConfigId;
				int num = 0;
				flag = (roleConfigId.GetValueOrDefault() > num & roleConfigId != null);
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			bool flag3 = flag2 && RoleModel.Instance.IsMainRole(roleHeadInfo.RoleConfigId.Value);
			base.RefreshComponent(typeof(MediumItemGridVisionRoleHeadComponent), new bool?(flag2 && !flag3), flag3 ? null : roleHeadInfo);
			base.RefreshComponent(typeof(MediumItemGridVisionMainRoleHeadComponent), new bool?(flag2 && flag3), flag3 ? roleHeadInfo : null);
		}

		// Token: 0x06030266 RID: 197222 RVA: 0x00D6D950 File Offset: 0x00D6BB50
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

		// Token: 0x06030267 RID: 197223 RVA: 0x00D6D9A0 File Offset: 0x00D6BBA0
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

		// Token: 0x06030268 RID: 197224 RVA: 0x00D6D9F0 File Offset: 0x00D6BBF0
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

		// Token: 0x06030269 RID: 197225 RVA: 0x00D6DA70 File Offset: 0x00D6BC70
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

		// Token: 0x0603026A RID: 197226 RVA: 0x00D6DAC7 File Offset: 0x00D6BCC7
		private void SetStackFlagVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(11);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x0603026B RID: 197227 RVA: 0x00D6DADC File Offset: 0x00D6BCDC
		public void SetComposeIcon(MediumItemGridComposeTag composeTag)
		{
			base.RefreshComponent(typeof(MediumItemGridComposeTag), new bool?(composeTag != null), composeTag);
		}

		// Token: 0x0603026C RID: 197228 RVA: 0x00D6DAF9 File Offset: 0x00D6BCF9
		public void SetComposeChangeAble(bool? isChangeAble)
		{
			base.RefreshComponent(typeof(MediumItemGridChangeAbleComponent), new bool?(isChangeAble.GetValueOrDefault()), isChangeAble);
		}

		// Token: 0x0603026D RID: 197229 RVA: 0x00D6DB1E File Offset: 0x00D6BD1E
		public void SetVisionSlotState(EMediumItemGridVisionSlotState[] visionSlotStateList)
		{
			base.RefreshComponent(typeof(MediumItemGridVisionSlotComponent), new bool?(visionSlotStateList != null && visionSlotStateList.Length != 0), visionSlotStateList);
		}

		// Token: 0x0603026E RID: 197230 RVA: 0x00D6DB42 File Offset: 0x00D6BD42
		public void SetDevelopRewardInfo(DevelopRewardInfo developRewardInfo)
		{
			base.RefreshComponent(typeof(MediumItemGridDevelopRewardComponent), new bool?(developRewardInfo != null), developRewardInfo);
		}

		// Token: 0x0603026F RID: 197231 RVA: 0x00D6DB5F File Offset: 0x00D6BD5F
		public void SetIsMainVision(bool? isMainVisionVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridMainVisionComponent), new bool?(isMainVisionVisible.GetValueOrDefault()), isMainVisionVisible);
		}

		// Token: 0x06030270 RID: 197232 RVA: 0x00D6DB84 File Offset: 0x00D6BD84
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

		// Token: 0x06030271 RID: 197233 RVA: 0x00D6DBE2 File Offset: 0x00D6BDE2
		public void SetIsProhibit(bool? isProhibit)
		{
			base.RefreshComponent(typeof(MediumItemGridProhibitComponent), new bool?(isProhibit.GetValueOrDefault()), isProhibit);
		}

		// Token: 0x06030272 RID: 197234 RVA: 0x00D6DC08 File Offset: 0x00D6BE08
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

		// Token: 0x06030273 RID: 197235 RVA: 0x00D6DC8B File Offset: 0x00D6BE8B
		public void SetRoundCount(int? round)
		{
			base.RefreshComponent(typeof(MediumItemGridRoundCountComponent), new bool?(round != null), round);
		}

		// Token: 0x06030274 RID: 197236 RVA: 0x00D6DCB0 File Offset: 0x00D6BEB0
		public void SetWarningPanelInfo(MediumWarningPanelInfo info = null)
		{
			base.RefreshComponent(typeof(MediumItemGridWarningPanelComponent), new bool?(info != null), info);
		}

		// Token: 0x06030275 RID: 197237 RVA: 0x00D6DCD0 File Offset: 0x00D6BED0
		public void SetSortIndex(int? sortIndex, bool highlight = false)
		{
			if (highlight)
			{
				base.RefreshComponent(typeof(MediumItemGridSortHighlightIndexComponent), new bool?(sortIndex != null), sortIndex);
				return;
			}
			base.RefreshComponent(typeof(MediumItemGridSortIndexComponent), new bool?(sortIndex != null), sortIndex);
		}

		// Token: 0x06030276 RID: 197238 RVA: 0x00D6DD27 File Offset: 0x00D6BF27
		public void SetTeamIcon(bool? isInTeam)
		{
			base.RefreshComponent(typeof(MediumItemGridTeamIconComponent), new bool?(isInTeam != null), isInTeam);
		}

		// Token: 0x06030277 RID: 197239 RVA: 0x00D6DD4C File Offset: 0x00D6BF4C
		[NullableContext(1)]
		public void BindReduceLongPress(Action<bool, MediumItemGrid, object> callback)
		{
			this.OnReduceButtonLongActiveCallback = callback;
		}

		// Token: 0x06030278 RID: 197240 RVA: 0x00D6DD55 File Offset: 0x00D6BF55
		public void UnBindReduceLongPress()
		{
			this.OnReduceButtonLongActiveCallback = null;
		}

		// Token: 0x06030279 RID: 197241 RVA: 0x00D6DD5E File Offset: 0x00D6BF5E
		private void OnReduceButtonLongPressActive(bool isShortPress)
		{
			if (this.OnReduceButtonLongActiveCallback != null)
			{
				this.OnReduceButtonLongActiveCallback(isShortPress, this, this.Data);
			}
		}

		// Token: 0x0603027A RID: 197242 RVA: 0x00D6DD7C File Offset: 0x00D6BF7C
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

		// Token: 0x0603027B RID: 197243 RVA: 0x00D6DDB8 File Offset: 0x00D6BFB8
		public void SetCheckTickVisible(bool? isCheckTick)
		{
			MediumItemGridCheckTickComponentParams @params = new MediumItemGridCheckTickComponentParams
			{
				IsCheckTick = isCheckTick
			};
			base.RefreshComponent(typeof(MediumItemGridCheckTickComponent), new bool?(isCheckTick.GetValueOrDefault()), @params);
		}

		// Token: 0x0603027C RID: 197244 RVA: 0x00D6DDF0 File Offset: 0x00D6BFF0
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

		// Token: 0x0603027D RID: 197245 RVA: 0x00D6DE3E File Offset: 0x00D6C03E
		public void SetTimeFlagVisible(bool? isTimeFlagVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridTimeFlagComponent), new bool?(isTimeFlagVisible.GetValueOrDefault()), isTimeFlagVisible);
		}

		// Token: 0x0603027E RID: 197246 RVA: 0x00D6DE63 File Offset: 0x00D6C063
		public void SetReceivedFlagVisible(bool? isReceivedFlagVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridReceivedComponent), new bool?(isReceivedFlagVisible.GetValueOrDefault()), isReceivedFlagVisible);
		}

		// Token: 0x0603027F RID: 197247 RVA: 0x00D6DE88 File Offset: 0x00D6C088
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

		// Token: 0x06030280 RID: 197248 RVA: 0x00D6DED8 File Offset: 0x00D6C0D8
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

		// Token: 0x06030281 RID: 197249 RVA: 0x00D6DF34 File Offset: 0x00D6C134
		private void SetBgVisible(bool bVisible)
		{
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(bVisible);
		}

		// Token: 0x06030282 RID: 197250 RVA: 0x00D6DF48 File Offset: 0x00D6C148
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

		// Token: 0x06030283 RID: 197251 RVA: 0x00D6DF82 File Offset: 0x00D6C182
		public void SetElement(int? elementId)
		{
			base.RefreshComponent(typeof(MediumItemGridElementComponent), new bool?(elementId != null), elementId);
		}

		// Token: 0x06030284 RID: 197252 RVA: 0x00D6DFA7 File Offset: 0x00D6C1A7
		public void SetRecommendVisible(bool? isRecommendVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridRecommendComponent), new bool?(isRecommendVisible.GetValueOrDefault()), isRecommendVisible);
		}

		// Token: 0x06030285 RID: 197253 RVA: 0x00D6DFCC File Offset: 0x00D6C1CC
		public void SetUnRecommendVisible(bool? isUnRecommendVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridUnRecommendComponent), new bool?(isUnRecommendVisible.GetValueOrDefault()), isUnRecommendVisible);
		}

		// Token: 0x06030286 RID: 197254 RVA: 0x00D6DFF1 File Offset: 0x00D6C1F1
		public void SetIsDisable(bool? isRoleDisable)
		{
			base.RefreshComponent(typeof(MediumItemGridDisableComponent), new bool?(isRoleDisable.GetValueOrDefault()), isRoleDisable);
		}

		// Token: 0x06030287 RID: 197255 RVA: 0x00D6E018 File Offset: 0x00D6C218
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

		// Token: 0x06030288 RID: 197256 RVA: 0x00D6E064 File Offset: 0x00D6C264
		public bool IsDisable()
		{
			ItemGridComponent itemGridComponent = base.GetItemGridComponent(typeof(MediumItemGridDisableComponent));
			return itemGridComponent != null && itemGridComponent.GetActive();
		}

		// Token: 0x06030289 RID: 197257 RVA: 0x00D6E08D File Offset: 0x00D6C28D
		public void SetTrialRoleVisible(bool? isTrialRoleVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridTimeFlagComponent), new bool?(isTrialRoleVisible.GetValueOrDefault()), isTrialRoleVisible);
		}

		// Token: 0x0603028A RID: 197258 RVA: 0x00D6E0B2 File Offset: 0x00D6C2B2
		public void SetRoleRightBottomTagVisible(MediumRoleRightBottomTag roleRightBottomTag)
		{
			base.RefreshComponent(typeof(MediumItemGridRoleRightBottomTag), new bool?(roleRightBottomTag != null), roleRightBottomTag);
		}

		// Token: 0x0603028B RID: 197259 RVA: 0x00D6E0CF File Offset: 0x00D6C2CF
		public void SetTrialRoleRightBottomTagVisible(MediumTrialRoleRightBottomTag trialRoleRightBottomTag)
		{
			base.RefreshComponent(typeof(MediumItemGridTrialRoleRightBottomTag), new bool?(trialRoleRightBottomTag != null), trialRoleRightBottomTag);
		}

		// Token: 0x0603028C RID: 197260 RVA: 0x00D6E0EC File Offset: 0x00D6C2EC
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

		// Token: 0x0603028D RID: 197261 RVA: 0x00D6E132 File Offset: 0x00D6C332
		public void SetSkinIcon(int? itemConfigId)
		{
			if (itemConfigId == null)
			{
				return;
			}
			base.RefreshComponent(typeof(MediumItemGridSkinComponent), new bool?(true), itemConfigId);
		}

		// Token: 0x0603028E RID: 197262 RVA: 0x00D6E15C File Offset: 0x00D6C35C
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

		// Token: 0x0603028F RID: 197263 RVA: 0x00D6E1A0 File Offset: 0x00D6C3A0
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

		// Token: 0x06030290 RID: 197264 RVA: 0x00D6E1F0 File Offset: 0x00D6C3F0
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

		// Token: 0x06030291 RID: 197265 RVA: 0x00D6E350 File Offset: 0x00D6C550
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

		// Token: 0x06030292 RID: 197266 RVA: 0x00D6E40C File Offset: 0x00D6C60C
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

		// Token: 0x06030293 RID: 197267 RVA: 0x00D6E540 File Offset: 0x00D6C740
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

		// Token: 0x06030294 RID: 197268 RVA: 0x00D6E600 File Offset: 0x00D6C800
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

		// Token: 0x06030295 RID: 197269 RVA: 0x00D6E6D4 File Offset: 0x00D6C8D4
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

		// Token: 0x06030296 RID: 197270 RVA: 0x00D6E710 File Offset: 0x00D6C910
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

		// Token: 0x06030297 RID: 197271 RVA: 0x00D6E768 File Offset: 0x00D6C968
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

		// Token: 0x06030298 RID: 197272 RVA: 0x00D6E7E8 File Offset: 0x00D6C9E8
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

		// Token: 0x06030299 RID: 197273 RVA: 0x00D6E884 File Offset: 0x00D6CA84
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

		// Token: 0x0603029A RID: 197274 RVA: 0x00D6E8E8 File Offset: 0x00D6CAE8
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

		// Token: 0x0603029B RID: 197275 RVA: 0x00D6E928 File Offset: 0x00D6CB28
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

		// Token: 0x0603029C RID: 197276 RVA: 0x00D6E9E8 File Offset: 0x00D6CBE8
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

		// Token: 0x0603029D RID: 197277 RVA: 0x00D6EA98 File Offset: 0x00D6CC98
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

		// Token: 0x0603029E RID: 197278 RVA: 0x00D6EBF4 File Offset: 0x00D6CDF4
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

		// Token: 0x0603029F RID: 197279 RVA: 0x00D6ECA4 File Offset: 0x00D6CEA4
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

		// Token: 0x060302A0 RID: 197280 RVA: 0x00D6ED18 File Offset: 0x00D6CF18
		public void SetCurTagIcon(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridCurTagComponent), isShow, isShow);
		}

		// Token: 0x060302A1 RID: 197281 RVA: 0x00D6ED34 File Offset: 0x00D6CF34
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

		// Token: 0x060302A2 RID: 197282 RVA: 0x00D6ED60 File Offset: 0x00D6CF60
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

		// Token: 0x060302A3 RID: 197283 RVA: 0x00D6EDA0 File Offset: 0x00D6CFA0
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

		// Token: 0x060302A4 RID: 197284 RVA: 0x00D6EDC9 File Offset: 0x00D6CFC9
		[NullableContext(1)]
		public void BindReduceButtonCallback(Action<MediumItemGridButtonCallback> onClickedReduceButton, [Nullable(2)] object data = null)
		{
			this.OnClickedReduceButtonCallback = onClickedReduceButton;
		}

		// Token: 0x060302A5 RID: 197285 RVA: 0x00D6EDD2 File Offset: 0x00D6CFD2
		public void UnBindReduceButtonCallback()
		{
			this.OnClickedReduceButtonCallback = null;
		}

		// Token: 0x060302A6 RID: 197286 RVA: 0x00D6EDDB File Offset: 0x00D6CFDB
		[NullableContext(1)]
		public void BindEmptySlotButtonCallback(Action<MediumItemGridButtonCallback> onClickedEmptySlotButton)
		{
			this.OnClickedEmptySlotButtonCallback = onClickedEmptySlotButton;
		}

		// Token: 0x060302A7 RID: 197287 RVA: 0x00D6EDE4 File Offset: 0x00D6CFE4
		public void UnBindEmptySlotButtonCallback()
		{
			this.OnClickedEmptySlotButtonCallback = null;
		}

		// Token: 0x060302A8 RID: 197288 RVA: 0x00D6EDED File Offset: 0x00D6CFED
		public override UUIExtendToggle GetItemGridExtendToggle()
		{
			return base.GetExtendToggle(6);
		}

		// Token: 0x060302A9 RID: 197289 RVA: 0x00D6EDF6 File Offset: 0x00D6CFF6
		private void SetRoleCost(MediumItemGridCostComponentData costData)
		{
			base.RefreshComponent(typeof(MediumItemGridCostComponent), new bool?(costData != null), costData);
		}

		// Token: 0x060302AA RID: 197290 RVA: 0x00D6EE13 File Offset: 0x00D6D013
		private void SetRoleItemAddtion(RoleItemAddtionData data)
		{
			base.RefreshComponent(typeof(MediumItemGridRoleItemAddtionComponent), new bool?(data != null), data);
		}

		// Token: 0x060302AB RID: 197291 RVA: 0x00D6EE30 File Offset: 0x00D6D030
		private void SetRoleTowerEnemyLevel(int? level)
		{
			base.RefreshComponent(typeof(MediumItemGridRoleTowerEnemyLevelComponent), new bool?(level != null), level);
		}

		// Token: 0x060302AC RID: 197292 RVA: 0x00D6EE55 File Offset: 0x00D6D055
		private void SetRoleTowerElement(int? elementId)
		{
			base.RefreshComponent(typeof(MediumItemGridRoleTowerElementComponent), new bool?(elementId != null), elementId);
		}

		// Token: 0x060302AD RID: 197293 RVA: 0x00D6EE7A File Offset: 0x00D6D07A
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

		// Token: 0x060302AE RID: 197294 RVA: 0x00D6EE94 File Offset: 0x00D6D094
		public void SetHalfAreaInfo(HaveAreaInfo info)
		{
			bool value = info != null;
			base.RefreshComponent(typeof(MediumItemGridHalfAreaComponent), new bool?(value), info);
		}

		// Token: 0x060302AF RID: 197295 RVA: 0x00D6EEBE File Offset: 0x00D6D0BE
		public void SetUpGradeVisible(bool? visible)
		{
			base.RefreshComponent(typeof(MediumItemGridUpgradeComponent), new bool?(visible.GetValueOrDefault()), visible);
		}

		// Token: 0x060302B0 RID: 197296 RVA: 0x00D6EEE4 File Offset: 0x00D6D0E4
		public void SetTagsInfo([Nullable(new byte[]
		{
			2,
			1
		})] string[] tags)
		{
			bool value = tags != null && tags.Length != 0;
			base.RefreshComponent(typeof(MediumItemGridTagsComponent), new bool?(value), tags);
		}

		// Token: 0x060302B1 RID: 197297 RVA: 0x00D6EF18 File Offset: 0x00D6D118
		public void SetRightTopValueInfo(string value)
		{
			bool value2 = !string.IsNullOrEmpty(value);
			base.RefreshComponent(typeof(MediumItemGridRightTopValueComponent), new bool?(value2), value);
		}

		// Token: 0x060302B2 RID: 197298 RVA: 0x00D6EF47 File Offset: 0x00D6D147
		public void SetIsBranchUpgrade(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridBranchUpgradeComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x060302B3 RID: 197299 RVA: 0x00D6EF6C File Offset: 0x00D6D16C
		public void SetSubIconPath(string path)
		{
			base.RefreshComponent(typeof(MediumItemGridSubIconComponent), new bool?(!string.IsNullOrEmpty(path)), path);
		}

		// Token: 0x060302B4 RID: 197300 RVA: 0x00D6EF8E File Offset: 0x00D6D18E
		public void SetRoleDevTag(ERoleDevelopHotRoleTag? tagType)
		{
			base.RefreshComponent(typeof(MediumItemGridRoleDevTagComponent), new bool?(tagType != null), tagType);
		}

		// Token: 0x060302B5 RID: 197301 RVA: 0x00D6EFB3 File Offset: 0x00D6D1B3
		public void SetRoleDevelopTagMark(bool? isRoleDevelopTagMarkVisible)
		{
			base.RefreshComponent(typeof(MediumItemGridRoleDevelopTagMarkComponent), new bool?(isRoleDevelopTagMarkVisible.GetValueOrDefault()), isRoleDevelopTagMarkVisible);
		}

		// Token: 0x060302B6 RID: 197302 RVA: 0x00D6EFD8 File Offset: 0x00D6D1D8
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

		// Token: 0x060302B7 RID: 197303 RVA: 0x00D6F066 File Offset: 0x00D6D266
		public void SetAddLevel(int? addLevel)
		{
			base.RefreshComponent(typeof(MediumItemGridAddLevelComponent), new bool?(addLevel != null), addLevel);
		}

		// Token: 0x060302B8 RID: 197304 RVA: 0x00D6F08B File Offset: 0x00D6D28B
		public void SetArchiveIcon(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridArchiveComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x060302B9 RID: 197305 RVA: 0x00D6F0B0 File Offset: 0x00D6D2B0
		public void SetLeftUpperIcon(string iconPath)
		{
			if (iconPath == null)
			{
				return;
			}
			base.RefreshComponent(typeof(MediumItemGridLeftUpperIconComponent), new bool?(true), iconPath);
		}

		// Token: 0x060302BA RID: 197306 RVA: 0x00D6F0CE File Offset: 0x00D6D2CE
		public void SetWarningTips(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridWarningTipsComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x060302BB RID: 197307 RVA: 0x00D6F0F3 File Offset: 0x00D6D2F3
		public void SetUpgradeArrow(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridUpgradeArrowComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x060302BC RID: 197308 RVA: 0x00D6F118 File Offset: 0x00D6D318
		public void SetTemplateIcon(bool? isShow)
		{
			base.RefreshComponent(typeof(MediumItemGridTemplateIconComponent), new bool?(isShow.GetValueOrDefault()), isShow);
		}

		// Token: 0x04019827 RID: 104487
		private const int TRIAL_ROLE_ID = 10000;

		// Token: 0x04019828 RID: 104488
		private int TextureItemConfigId;

		// Token: 0x04019829 RID: 104489
		private int QualityItemConfigId;

		// Token: 0x0401982A RID: 104490
		[Nullable(1)]
		private string CurrentBgResourceId = "";

		// Token: 0x0401982B RID: 104491
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<MediumItemGridButtonCallback> OnClickedReduceButtonCallback;

		// Token: 0x0401982C RID: 104492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<MediumItemGridButtonCallback> OnClickedEmptySlotButtonCallback;

		// Token: 0x0401982D RID: 104493
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<bool, MediumItemGrid, object> OnReduceButtonLongActiveCallback;

		// Token: 0x0200A785 RID: 42885
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04033C4E RID: 212046
			public const int QualitySprite = 0;

			// Token: 0x04033C4F RID: 212047
			public const int ItemTexture = 1;

			// Token: 0x04033C50 RID: 212048
			public const int BottomText = 2;

			// Token: 0x04033C51 RID: 212049
			public const int BgSprite = 3;

			// Token: 0x04033C52 RID: 212050
			public const int TopAdditionItem = 4;

			// Token: 0x04033C53 RID: 212051
			public const int BottomAdditionItem = 5;

			// Token: 0x04033C54 RID: 212052
			public const int ExtendToggle = 6;

			// Token: 0x04033C55 RID: 212053
			public const int UnderTextAdditionItem = 7;

			// Token: 0x04033C56 RID: 212054
			public const int SkinQualitySprite = 8;

			// Token: 0x04033C57 RID: 212055
			public const int AniLoop = 9;

			// Token: 0x04033C58 RID: 212056
			public const int ItemSprite = 10;

			// Token: 0x04033C59 RID: 212057
			public const int PhantomStackFlag = 11;
		}
	}
}
