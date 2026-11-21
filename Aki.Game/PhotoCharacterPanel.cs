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

// Token: 0x02001A42 RID: 6722
[NullableContext(1)]
[Nullable(0)]
public class PhotoCharacterPanel : PhotoDetailPanelBase
{
	// Token: 0x06010946 RID: 67910 RVA: 0x004DA0A0 File Offset: 0x004D82A0
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

	// Token: 0x1700191A RID: 6426
	// (get) Token: 0x06010947 RID: 67911 RVA: 0x004DA1DA File Offset: 0x004D83DA
	protected override int TabLockPanelIndex
	{
		get
		{
			return 9;
		}
	}

	// Token: 0x1700191B RID: 6427
	// (get) Token: 0x06010948 RID: 67912 RVA: 0x004DA1DE File Offset: 0x004D83DE
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 11;
		}
	}

	// Token: 0x06010949 RID: 67913 RVA: 0x004DA1E4 File Offset: 0x004D83E4
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoCharacterPanel.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoCharacterPanel.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601094A RID: 67914 RVA: 0x004DA228 File Offset: 0x004D8428
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

	// Token: 0x0601094B RID: 67915 RVA: 0x004DA2C6 File Offset: 0x004D84C6
	private void CacheRoleInfo()
	{
		this.Gender = (int)PlayerInfoModel.Instance.GetPlayerGender();
		this.TryRefreshRoleInfo(SceneTeamModel.Instance.GetCurrentEntity);
	}

	// Token: 0x0601094C RID: 67916 RVA: 0x004DA2E9 File Offset: 0x004D84E9
	private void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		if (!this.TryRefreshRoleInfo(newEntity))
		{
			return;
		}
		this.RefreshSubTabContent(this.CurrentSubTabType);
	}

	// Token: 0x0601094D RID: 67917 RVA: 0x004DA304 File Offset: 0x004D8504
	[NullableContext(2)]
	private bool TryRefreshRoleInfo(EntityHandle handle)
	{
		bool flag = this.TryRefreshSkinId(handle);
		bool flag2 = this.TryRefreshMorphType(handle);
		return flag || flag2;
	}

	// Token: 0x0601094E RID: 67918 RVA: 0x004DA324 File Offset: 0x004D8524
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

	// Token: 0x0601094F RID: 67919 RVA: 0x004DA370 File Offset: 0x004D8570
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

	// Token: 0x06010950 RID: 67920 RVA: 0x004DA3E4 File Offset: 0x004D85E4
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

	// Token: 0x06010951 RID: 67921 RVA: 0x004DA450 File Offset: 0x004D8650
	private EPhotoMotionSelectMode GetMotionSelectMode()
	{
		PhotoMode? photoModeConfigByType = PhotographConfig.Instance.GetPhotoModeConfigByType((int)this.ViewModel.CurrentMode);
		if (photoModeConfigByType == null)
		{
			return EPhotoMotionSelectMode.None;
		}
		return (EPhotoMotionSelectMode)photoModeConfigByType.Value.MotionSelectMode;
	}

	// Token: 0x06010952 RID: 67922 RVA: 0x004DA490 File Offset: 0x004D8690
	private UniTask RefreshSubTabList()
	{
		PhotoCharacterPanel.<RefreshSubTabList>d__30 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoCharacterPanel.<RefreshSubTabList>d__30>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x06010953 RID: 67923 RVA: 0x004DA4D4 File Offset: 0x004D86D4
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

	// Token: 0x06010954 RID: 67924 RVA: 0x004DA528 File Offset: 0x004D8728
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

	// Token: 0x06010955 RID: 67925 RVA: 0x004DA590 File Offset: 0x004D8790
	private UniTask RefreshMontageList()
	{
		PhotoCharacterPanel.<RefreshMontageList>d__33 <RefreshMontageList>d__;
		<RefreshMontageList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshMontageList>d__.<>4__this = this;
		<RefreshMontageList>d__.<>1__state = -1;
		<RefreshMontageList>d__.<>t__builder.Start<PhotoCharacterPanel.<RefreshMontageList>d__33>(ref <RefreshMontageList>d__);
		return <RefreshMontageList>d__.<>t__builder.Task;
	}

	// Token: 0x06010956 RID: 67926 RVA: 0x004DA5D4 File Offset: 0x004D87D4
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

	// Token: 0x06010957 RID: 67927 RVA: 0x004DA688 File Offset: 0x004D8888
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

	// Token: 0x06010958 RID: 67928 RVA: 0x004DA6F0 File Offset: 0x004D88F0
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

	// Token: 0x06010959 RID: 67929 RVA: 0x004DA73C File Offset: 0x004D893C
	private List<PhotoSelfieItemData> BuildSelfieDataList(EPhotoCharacterSubTabType subTabType)
	{
		List<PhotoSelfieItemData> list = new List<PhotoSelfieItemData>();
		if (subTabType == EPhotoCharacterSubTabType.Motion)
		{
			using (List<PhotoSelfieMontage>.Enumerator enumerator = PhotographConfig.Instance.GetPhotoSelfieMontageListByGender(this.Gender).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					PhotoSelfieMontage cfg = enumerator.Current;
					list.Add(PhotoSelfieItemData.FromMotion(cfg));
				}
				goto IL_96;
			}
		}
		foreach (PhotoExpression cfg2 in PhotographConfig.Instance.GetPhotoExpressionListByGender(this.Gender))
		{
			list.Add(PhotoSelfieItemData.FromExpression(cfg2));
		}
		IL_96:
		list.Sort();
		return list;
	}

	// Token: 0x0601095A RID: 67930 RVA: 0x004DA804 File Offset: 0x004D8A04
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

	// Token: 0x0601095B RID: 67931 RVA: 0x004DA8A5 File Offset: 0x004D8AA5
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

	// Token: 0x0601095C RID: 67932 RVA: 0x004DA8D1 File Offset: 0x004D8AD1
	private void RefreshPlayPanel()
	{
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0601095D RID: 67933 RVA: 0x004DA8E8 File Offset: 0x004D8AE8
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

	// Token: 0x0601095E RID: 67934 RVA: 0x004DA980 File Offset: 0x004D8B80
	private PhotoMontageItem CreateMontageItem()
	{
		return new PhotoMontageItem
		{
			OnMontageClick = new Action<int>(this.OnMontageClick)
		};
	}

	// Token: 0x0601095F RID: 67935 RVA: 0x004DA999 File Offset: 0x004D8B99
	private PhotoSelfieItem CreateSelfieItem()
	{
		return new PhotoSelfieItem
		{
			OnSelfieClick = new Action<int>(this.OnSelfieClick)
		};
	}

	// Token: 0x06010960 RID: 67936 RVA: 0x004DA9B4 File Offset: 0x004D8BB4
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

	// Token: 0x06010961 RID: 67937 RVA: 0x004DAA08 File Offset: 0x004D8C08
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

	// Token: 0x06010962 RID: 67938 RVA: 0x004DAAA4 File Offset: 0x004D8CA4
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

	// Token: 0x06010963 RID: 67939 RVA: 0x004DAB28 File Offset: 0x004D8D28
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

	// Token: 0x06010964 RID: 67940 RVA: 0x004DAB4C File Offset: 0x004D8D4C
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

	// Token: 0x040092CB RID: 37579
	private EPhotoCharacterSubTabType CurrentSubTabType = EPhotoCharacterSubTabType.Motion;

	// Token: 0x040092CC RID: 37580
	private EPhotoMotionSelectMode LastMotionSelectMode;

	// Token: 0x040092CD RID: 37581
	private int CurrentSelfieMotionId;

	// Token: 0x040092CE RID: 37582
	private int CurrentExpressionId;

	// Token: 0x040092CF RID: 37583
	[Nullable(2)]
	private PhotoSubTabPanel SubTabPanel;

	// Token: 0x040092D0 RID: 37584
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhotoMontageItem, PhotoMontageItemData> MontageScroll;

	// Token: 0x040092D1 RID: 37585
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhotoSelfieItem, PhotoSelfieItemData> SelfieScroll;

	// Token: 0x040092D2 RID: 37586
	private int SkinId;

	// Token: 0x040092D3 RID: 37587
	private EMorphType MorphType;

	// Token: 0x040092D4 RID: 37588
	private int Gender;

	// Token: 0x040092D5 RID: 37589
	private List<PhotoMontageItemData> MontageDataList = new List<PhotoMontageItemData>();

	// Token: 0x040092D6 RID: 37590
	private List<PhotoSelfieItemData> SelfieDataList = new List<PhotoSelfieItemData>();

	// Token: 0x040092D7 RID: 37591
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoMontageItemData> CachedMontageDataList;

	// Token: 0x040092D8 RID: 37592
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoSelfieItemData> CachedSelfieMotionDataList;

	// Token: 0x040092D9 RID: 37593
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoSelfieItemData> CachedExpressionDataList;

	// Token: 0x02007CA4 RID: 31908
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040285BD RID: 165309
		SubTabMenu,
		// Token: 0x040285BE RID: 165310
		LayoutMontagePanel,
		// Token: 0x040285BF RID: 165311
		LoopScrollMontage,
		// Token: 0x040285C0 RID: 165312
		ItemMontageTemplate,
		// Token: 0x040285C1 RID: 165313
		ItemPlayPanel,
		// Token: 0x040285C2 RID: 165314
		TogglePauseAnim,
		// Token: 0x040285C3 RID: 165315
		TextActionCtrl,
		// Token: 0x040285C4 RID: 165316
		LoopScrollSelfie,
		// Token: 0x040285C5 RID: 165317
		ItemSelfieTemplate,
		// Token: 0x040285C6 RID: 165318
		ItemTabLockPanel,
		// Token: 0x040285C7 RID: 165319
		TextTabLockTips,
		// Token: 0x040285C8 RID: 165320
		ItemSubTabLockPanel,
		// Token: 0x040285C9 RID: 165321
		TextSubTabLockTips
	}
}
