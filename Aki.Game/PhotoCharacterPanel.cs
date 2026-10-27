using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002557 RID: 9559
[NullableContext(1)]
[Nullable(0)]
public class PhotoCharacterPanel : PhotoDetailPanelBase
{
	// Token: 0x06013466 RID: 78950 RVA: 0x004CB520 File Offset: 0x004C9720
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIText))
		};
	}

	// Token: 0x170018E1 RID: 6369
	// (get) Token: 0x06013467 RID: 78951 RVA: 0x004CB65A File Offset: 0x004C985A
	protected override int TabLockPanelIndex
	{
		get
		{
			return 9;
		}
	}

	// Token: 0x170018E2 RID: 6370
	// (get) Token: 0x06013468 RID: 78952 RVA: 0x004CB65E File Offset: 0x004C985E
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 11;
		}
	}

	// Token: 0x06013469 RID: 78953 RVA: 0x004CB664 File Offset: 0x004C9864
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoCharacterPanel.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoCharacterPanel.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601346A RID: 78954 RVA: 0x004CB6A8 File Offset: 0x004C98A8
	protected override void OnStart()
	{
		this.LastMotionSelectMode = this.GetMotionSelectMode();
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnModeChanged = (Action<PhotoCameraType>)Delegate.Combine(viewModel.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Combine(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
		EventSystem.Instance.Add<Entity, EMorphType, EMorphType>(EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x0601346B RID: 78955 RVA: 0x004CB746 File Offset: 0x004C9946
	private void CacheRoleInfo()
	{
		this.Gender = (int)PlayerInfoModel.Instance.GetPlayerGender();
		this.TryRefreshRoleInfo(SceneTeamModel.Instance.GetCurrentEntity);
	}

	// Token: 0x0601346C RID: 78956 RVA: 0x004CB769 File Offset: 0x004C9969
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (!this.TryRefreshRoleInfo(newEntity))
		{
			return;
		}
		this.RefreshSubTabContent(this.CurrentSubTabType);
	}

	// Token: 0x0601346D RID: 78957 RVA: 0x004CB784 File Offset: 0x004C9984
	[NullableContext(2)]
	private bool TryRefreshRoleInfo(EntityHandle handle)
	{
		bool flag = this.TryRefreshSkinId(handle);
		bool flag2 = this.TryRefreshMorphType(handle);
		return flag || flag2;
	}

	// Token: 0x0601346E RID: 78958 RVA: 0x004CB7A4 File Offset: 0x004C99A4
	[NullableContext(2)]
	private bool TryRefreshSkinId(EntityHandle handle)
	{
		CreatureDataComponent creatureDataComponent;
		if (handle == null)
		{
			creatureDataComponent = null;
		}
		else
		{
			WorldEntity entity = handle.Entity;
			creatureDataComponent = ((entity != null) ? entity.CheckGetComponent<CreatureDataComponent>() : null);
		}
		CreatureDataComponent creatureDataComponent2 = creatureDataComponent;
		if (creatureDataComponent2 == null)
		{
			return false;
		}
		int skinId = creatureDataComponent2.GetSkinId();
		if (skinId == this.SkinId)
		{
			return false;
		}
		this.SkinId = skinId;
		this.CachedMontageDataList = null;
		return true;
	}

	// Token: 0x0601346F RID: 78959 RVA: 0x004CB7F0 File Offset: 0x004C99F0
	[NullableContext(2)]
	private bool TryRefreshMorphType(EntityHandle handle)
	{
		EMorphType? emorphType;
		if (handle == null)
		{
			emorphType = null;
		}
		else
		{
			WorldEntity entity = handle.Entity;
			if (entity == null)
			{
				emorphType = null;
			}
			else
			{
				CharacterMorphComponent component = entity.GetComponent<CharacterMorphComponent>();
				emorphType = ((component != null) ? new EMorphType?(component.GetMorphType()) : null);
			}
		}
		EMorphType? emorphType2 = emorphType;
		EMorphType valueOrDefault = emorphType2.GetValueOrDefault();
		if (valueOrDefault == this.MorphType)
		{
			return false;
		}
		this.MorphType = valueOrDefault;
		this.CachedMontageDataList = null;
		return true;
	}

	// Token: 0x06013470 RID: 78960 RVA: 0x004CB864 File Offset: 0x004C9A64
	private void OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType)
	{
		int id = entity.Id;
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		int? num = (getCurrentEntity != null) ? new int?(getCurrentEntity.Id) : null;
		if (!(id == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		if (!this.TryRefreshMorphType(SceneTeamModel.Instance.GetCurrentEntity))
		{
			return;
		}
		this.RefreshSubTabContent(this.CurrentSubTabType);
	}

	// Token: 0x06013471 RID: 78961 RVA: 0x004CB8D0 File Offset: 0x004C9AD0
	private EPhotoMotionSelectMode GetMotionSelectMode()
	{
		PhotoMode? photoModeConfigByType = PhotographConfig.Instance.GetPhotoModeConfigByType((int)this.ViewModel.CurrentMode);
		if (photoModeConfigByType == null)
		{
			return EPhotoMotionSelectMode.None;
		}
		return (EPhotoMotionSelectMode)photoModeConfigByType.Value.MotionSelectMode;
	}

	// Token: 0x06013472 RID: 78962 RVA: 0x004CB910 File Offset: 0x004C9B10
	private UniTask RefreshSubTabList()
	{
		PhotoCharacterPanel.<RefreshSubTabList>d__30 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoCharacterPanel.<RefreshSubTabList>d__30>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x06013473 RID: 78963 RVA: 0x004CB954 File Offset: 0x004C9B54
	private void RefreshSubTabContent(EPhotoCharacterSubTabType subTabType)
	{
		this.CurrentSubTabType = subTabType;
		this.RefreshContentVisible();
		this.RefreshPlayPanel();
		EPhotoMotionSelectMode motionSelectMode = this.GetMotionSelectMode();
		bool flag = motionSelectMode == EPhotoMotionSelectMode.Selfie;
		bool flag2 = motionSelectMode == EPhotoMotionSelectMode.PhotoMontage;
		bool flag3 = subTabType == EPhotoCharacterSubTabType.Motion;
		if (flag)
		{
			this.RefreshSelfieList(subTabType).Forget();
			return;
		}
		if (flag2 && flag3)
		{
			this.RefreshMontageList().Forget();
		}
	}

	// Token: 0x06013474 RID: 78964 RVA: 0x004CB9A8 File Offset: 0x004C9BA8
	protected override void RefreshContentVisible()
	{
		EPhotoMotionSelectMode motionSelectMode = this.GetMotionSelectMode();
		bool uiactive = motionSelectMode == EPhotoMotionSelectMode.Selfie;
		bool flag = motionSelectMode == EPhotoMotionSelectMode.PhotoMontage;
		bool flag2 = this.CurrentSubTabType == EPhotoCharacterSubTabType.Motion;
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(1);
		if (verticalLayout != null)
		{
			verticalLayout.RootUIComp.Get().SetUIActive(flag && flag2);
		}
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(7);
		if (loopScrollViewComponent == null)
		{
			return;
		}
		loopScrollViewComponent.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06013475 RID: 78965 RVA: 0x004CBA10 File Offset: 0x004C9C10
	private UniTask RefreshMontageList()
	{
		PhotoCharacterPanel.<RefreshMontageList>d__33 <RefreshMontageList>d__;
		<RefreshMontageList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshMontageList>d__.<>4__this = this;
		<RefreshMontageList>d__.<>1__state = -1;
		<RefreshMontageList>d__.<>t__builder.Start<PhotoCharacterPanel.<RefreshMontageList>d__33>(ref <RefreshMontageList>d__);
		return <RefreshMontageList>d__.<>t__builder.Task;
	}

	// Token: 0x06013476 RID: 78966 RVA: 0x004CBA54 File Offset: 0x004C9C54
	private List<PhotoMontageItemData> BuildMontageDataList()
	{
		List<PhotoMontageItemData> list = new List<PhotoMontageItemData>
		{
			PhotoMontageItemData.CreateDefault()
		};
		IReadOnlyList<PhotoMontage> photoMontageConfigListBySkinIdAndMorph = PhotographConfig.Instance.GetPhotoMontageConfigListBySkinIdAndMorph(this.SkinId, this.MorphType);
		if (photoMontageConfigListBySkinIdAndMorph == null)
		{
			return list;
		}
		List<PhotoMontage> list2 = new List<PhotoMontage>(photoMontageConfigListBySkinIdAndMorph);
		list2.Sort((PhotoMontage a, PhotoMontage b) => a.Sort - b.Sort);
		foreach (PhotoMontage cfg in list2)
		{
			if (cfg.MotionType == 0)
			{
				list.Add(PhotoMontageItemData.FromConfig(cfg));
			}
		}
		return list;
	}

	// Token: 0x06013477 RID: 78967 RVA: 0x004CBB08 File Offset: 0x004C9D08
	private void SelectPlayingMontage()
	{
		int montageId = PhotographModel.Instance.MontageId;
		int i = 0;
		while (i < this.MontageDataList.Count)
		{
			if (this.MontageDataList[i].Id == montageId)
			{
				LoopScrollView<PhotoMontageItem, PhotoMontageItemData> montageScroll = this.MontageScroll;
				if (montageScroll == null)
				{
					return;
				}
				montageScroll.SelectGridProxy(i, false);
				return;
			}
			else
			{
				i++;
			}
		}
		LoopScrollView<PhotoMontageItem, PhotoMontageItemData> montageScroll2 = this.MontageScroll;
		if (montageScroll2 == null)
		{
			return;
		}
		montageScroll2.SelectGridProxy(0, false);
	}

	// Token: 0x06013478 RID: 78968 RVA: 0x004CBB70 File Offset: 0x004C9D70
	private UniTask RefreshSelfieList(EPhotoCharacterSubTabType subTabType)
	{
		PhotoCharacterPanel.<RefreshSelfieList>d__36 <RefreshSelfieList>d__;
		<RefreshSelfieList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSelfieList>d__.<>4__this = this;
		<RefreshSelfieList>d__.subTabType = subTabType;
		<RefreshSelfieList>d__.<>1__state = -1;
		<RefreshSelfieList>d__.<>t__builder.Start<PhotoCharacterPanel.<RefreshSelfieList>d__36>(ref <RefreshSelfieList>d__);
		return <RefreshSelfieList>d__.<>t__builder.Task;
	}

	// Token: 0x06013479 RID: 78969 RVA: 0x004CBBBC File Offset: 0x004C9DBC
	private List<PhotoSelfieItemData> BuildSelfieDataList(EPhotoCharacterSubTabType subTabType)
	{
		List<PhotoSelfieItemData> list = new List<PhotoSelfieItemData>();
		if (subTabType == EPhotoCharacterSubTabType.Motion)
		{
			List<PhotoSelfieMontage> photoSelfieMontageListByGender = PhotographConfig.Instance.GetPhotoSelfieMontageListByGender(this.Gender);
			photoSelfieMontageListByGender.Sort((PhotoSelfieMontage a, PhotoSelfieMontage b) => a.SortId - b.SortId);
			using (List<PhotoSelfieMontage>.Enumerator enumerator = photoSelfieMontageListByGender.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					PhotoSelfieMontage cfg = enumerator.Current;
					list.Add(PhotoSelfieItemData.FromMotion(cfg));
				}
				return list;
			}
		}
		List<PhotoExpression> photoExpressionListByGender = PhotographConfig.Instance.GetPhotoExpressionListByGender(this.Gender);
		photoExpressionListByGender.Sort((PhotoExpression a, PhotoExpression b) => a.SortId - b.SortId);
		foreach (PhotoExpression cfg2 in photoExpressionListByGender)
		{
			list.Add(PhotoSelfieItemData.FromExpression(cfg2));
		}
		return list;
	}

	// Token: 0x0601347A RID: 78970 RVA: 0x004CBCC8 File Offset: 0x004C9EC8
	private void SelectCurrentSelfie(bool isMotion)
	{
		int num = isMotion ? this.CurrentSelfieMotionId : this.CurrentExpressionId;
		int num2 = -1;
		int i = 0;
		while (i < this.SelfieDataList.Count)
		{
			PhotoSelfieItemData photoSelfieItemData = this.SelfieDataList[i];
			if (num != 0 && photoSelfieItemData.Id == num)
			{
				LoopScrollView<PhotoSelfieItem, PhotoSelfieItemData> selfieScroll = this.SelfieScroll;
				if (selfieScroll == null)
				{
					return;
				}
				selfieScroll.SelectGridProxy(i, false);
				return;
			}
			else
			{
				if (photoSelfieItemData.IsDefault && num2 < 0)
				{
					num2 = i;
				}
				i++;
			}
		}
		if (num2 < 0)
		{
			return;
		}
		LoopScrollView<PhotoSelfieItem, PhotoSelfieItemData> selfieScroll2 = this.SelfieScroll;
		if (selfieScroll2 != null)
		{
			selfieScroll2.SelectGridProxy(num2, false);
		}
		this.RecordSelfieId(isMotion, this.SelfieDataList[num2].Id);
	}

	// Token: 0x0601347B RID: 78971 RVA: 0x004CBD69 File Offset: 0x004C9F69
	private void RecordSelfieId(bool isMotion, int id)
	{
		if (isMotion)
		{
			this.CurrentSelfieMotionId = id;
			this.ViewModel.CurrentSelfieMotionId = id;
			return;
		}
		this.CurrentExpressionId = id;
		this.ViewModel.CurrentExpressionId = id;
	}

	// Token: 0x0601347C RID: 78972 RVA: 0x004CBD95 File Offset: 0x004C9F95
	private void RefreshPlayPanel()
	{
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0601347D RID: 78973 RVA: 0x004CBDAC File Offset: 0x004C9FAC
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnModeChanged = (Action<PhotoCameraType>)Delegate.Remove(viewModel.OnModeChanged, new Action<PhotoCameraType>(this.OnModeChanged));
		PhotographController instance = PhotographController.Instance;
		instance.OnPhotographOptionChanged = (Action<EPhotoSetupValueType, float>)Delegate.Remove(instance.OnPhotographOptionChanged, new Action<EPhotoSetupValueType, float>(this.OnPhotographOptionChanged));
		EventSystem.Instance.Remove<Entity, EMorphType, EMorphType>(EEventName.OnCharacterMorphTypeChanged, new Action<Entity, EMorphType, EMorphType>(this.OnCharacterMorphTypeChanged));
		EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x0601347E RID: 78974 RVA: 0x004CBE44 File Offset: 0x004CA044
	private PhotoMontageItem CreateMontageItem()
	{
		return new PhotoMontageItem
		{
			OnMontageClick = new Action<int>(this.OnMontageClick)
		};
	}

	// Token: 0x0601347F RID: 78975 RVA: 0x004CBE5D File Offset: 0x004CA05D
	private PhotoSelfieItem CreateSelfieItem()
	{
		return new PhotoSelfieItem
		{
			OnSelfieClick = new Action<int>(this.OnSelfieClick)
		};
	}

	// Token: 0x06013480 RID: 78976 RVA: 0x004CBE78 File Offset: 0x004CA078
	private void OnSubTabClick(PhotoSubTab data, bool playSwitchAnim = true)
	{
		PhotoSubTabPanel subTabPanel = this.SubTabPanel;
		if (subTabPanel != null)
		{
			subTabPanel.SelectByKey(data.Id, false);
		}
		this.CurrentSubTabType = (EPhotoCharacterSubTabType)data.Type;
		base.SetSubTabId(data.Id, playSwitchAnim);
		this.RefreshSubTabContent(this.CurrentSubTabType);
	}

	// Token: 0x06013481 RID: 78977 RVA: 0x004CBECC File Offset: 0x004CA0CC
	private void OnMontageClick(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.MontageDataList.Count)
		{
			return;
		}
		LoopScrollView<PhotoMontageItem, PhotoMontageItemData> montageScroll = this.MontageScroll;
		if (montageScroll != null && montageScroll.GetSelectedGridIndex() == gridIndex)
		{
			return;
		}
		LoopScrollView<PhotoMontageItem, PhotoMontageItemData> montageScroll2 = this.MontageScroll;
		if (montageScroll2 != null)
		{
			montageScroll2.SelectGridProxy(gridIndex, false);
		}
		PhotoMontageItemData photoMontageItemData = this.MontageDataList[gridIndex];
		if (photoMontageItemData.IsDefault)
		{
			PhotographController.Instance.ResetPhotoMontage();
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return;
		}
		PhotographController.Instance.PlayPhotoMontage(getCurrentEntity, photoMontageItemData.Id);
	}

	// Token: 0x06013482 RID: 78978 RVA: 0x004CBF68 File Offset: 0x004CA168
	private void OnSelfieClick(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.SelfieDataList.Count)
		{
			return;
		}
		LoopScrollView<PhotoSelfieItem, PhotoSelfieItemData> selfieScroll = this.SelfieScroll;
		if (selfieScroll != null && selfieScroll.GetSelectedGridIndex() == gridIndex)
		{
			return;
		}
		LoopScrollView<PhotoSelfieItem, PhotoSelfieItemData> selfieScroll2 = this.SelfieScroll;
		if (selfieScroll2 != null)
		{
			selfieScroll2.SelectGridProxy(gridIndex, false);
		}
		PhotoSelfieItemData photoSelfieItemData = this.SelfieDataList[gridIndex];
		this.RecordSelfieId(photoSelfieItemData.SubTabType == EPhotoCharacterSubTabType.Motion, photoSelfieItemData.Id);
		PhotographController.Instance.PlaySelfieMontage(photoSelfieItemData.MontageConfigDtId, photoSelfieItemData.MontageType);
	}

	// Token: 0x06013483 RID: 78979 RVA: 0x004CBFEC File Offset: 0x004CA1EC
	private void OnPhotographOptionChanged(EPhotoSetupValueType valueType, float value)
	{
		if (valueType != EPhotoSetupValueType.MeshVisible)
		{
			return;
		}
		if (this.MontageDataList.Count == 0 || this.GetMotionSelectMode() == EPhotoMotionSelectMode.Selfie)
		{
			return;
		}
		this.SelectPlayingMontage();
	}

	// Token: 0x06013484 RID: 78980 RVA: 0x004CC010 File Offset: 0x004CA210
	private void OnModeChanged(PhotoCameraType mode)
	{
		this.TryRefreshRoleInfo(SceneTeamModel.Instance.GetCurrentEntity);
		EPhotoMotionSelectMode motionSelectMode = this.GetMotionSelectMode();
		if (motionSelectMode != this.LastMotionSelectMode)
		{
			this.LastMotionSelectMode = motionSelectMode;
			this.CurrentSelfieMotionId = 0;
			this.CurrentExpressionId = 0;
			this.ViewModel.CurrentExpressionId = 1;
			this.ViewModel.CurrentSelfieMotionId = 1;
		}
		this.RefreshSubTabContent(this.CurrentSubTabType);
	}

	// Token: 0x04009172 RID: 37234
	private EPhotoCharacterSubTabType CurrentSubTabType = EPhotoCharacterSubTabType.Motion;

	// Token: 0x04009173 RID: 37235
	private EPhotoMotionSelectMode LastMotionSelectMode;

	// Token: 0x04009174 RID: 37236
	private int CurrentSelfieMotionId;

	// Token: 0x04009175 RID: 37237
	private int CurrentExpressionId;

	// Token: 0x04009176 RID: 37238
	[Nullable(2)]
	private PhotoSubTabPanel SubTabPanel;

	// Token: 0x04009177 RID: 37239
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhotoMontageItem, PhotoMontageItemData> MontageScroll;

	// Token: 0x04009178 RID: 37240
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhotoSelfieItem, PhotoSelfieItemData> SelfieScroll;

	// Token: 0x04009179 RID: 37241
	private int SkinId;

	// Token: 0x0400917A RID: 37242
	private EMorphType MorphType;

	// Token: 0x0400917B RID: 37243
	private int Gender;

	// Token: 0x0400917C RID: 37244
	private List<PhotoMontageItemData> MontageDataList = new List<PhotoMontageItemData>();

	// Token: 0x0400917D RID: 37245
	private List<PhotoSelfieItemData> SelfieDataList = new List<PhotoSelfieItemData>();

	// Token: 0x0400917E RID: 37246
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoMontageItemData> CachedMontageDataList;

	// Token: 0x0400917F RID: 37247
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoSelfieItemData> CachedSelfieMotionDataList;

	// Token: 0x04009180 RID: 37248
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoSelfieItemData> CachedExpressionDataList;

	// Token: 0x02008B1E RID: 35614
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D2AE RID: 185006
		SubTabMenu,
		// Token: 0x0402D2AF RID: 185007
		LayoutMontagePanel,
		// Token: 0x0402D2B0 RID: 185008
		LoopScrollMontage,
		// Token: 0x0402D2B1 RID: 185009
		ItemMontageTemplate,
		// Token: 0x0402D2B2 RID: 185010
		ItemPlayPanel,
		// Token: 0x0402D2B3 RID: 185011
		TogglePauseAnim,
		// Token: 0x0402D2B4 RID: 185012
		TextActionCtrl,
		// Token: 0x0402D2B5 RID: 185013
		LoopScrollSelfie,
		// Token: 0x0402D2B6 RID: 185014
		ItemSelfieTemplate,
		// Token: 0x0402D2B7 RID: 185015
		ItemTabLockPanel,
		// Token: 0x0402D2B8 RID: 185016
		TextTabLockTips,
		// Token: 0x0402D2B9 RID: 185017
		ItemSubTabLockPanel,
		// Token: 0x0402D2BA RID: 185018
		TextSubTabLockTips
	}
}
