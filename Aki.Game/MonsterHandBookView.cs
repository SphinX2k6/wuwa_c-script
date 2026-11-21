using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Kpose.Blueprint;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012F8 RID: 4856
[NullableContext(2)]
[Nullable(0)]
public class MonsterHandBookView : UiViewBase
{
	// Token: 0x0600BF34 RID: 48948 RVA: 0x00386DA7 File Offset: 0x00384FA7
	[NullableContext(1)]
	public MonsterHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BF35 RID: 48949 RVA: 0x00386DC8 File Offset: 0x00384FC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIDynScrollViewComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIText)),
			new ValueTuple<int, Type>(21, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(12, new Action(this.EnterInternalView)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnMonsterSkinBtnClick)),
			new ValueTuple<int, Delegate>(21, new Action(this.OnBackCheckBtnClick))
		};
	}

	// Token: 0x0600BF36 RID: 48950 RVA: 0x00387028 File Offset: 0x00385228
	protected override UniTask OnBeforeStartAsync()
	{
		MonsterHandBookView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MonsterHandBookView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BF37 RID: 48951 RVA: 0x0038706C File Offset: 0x0038526C
	protected override void OnBeforeShowImplementImplement()
	{
		this.RefreshCollectText();
		int[] allHandBookMonsterIdList = HandBookModel.Instance.GetAllHandBookMonsterIdList();
		this.FilterBtn.UpdateData(EFilterSortGroupId.MonsterHandBook, new List<int>(allHandBookMonsterIdList), Array.Empty<object>());
	}

	// Token: 0x0600BF38 RID: 48952 RVA: 0x003870A4 File Offset: 0x003852A4
	private void RefeshView()
	{
		if (this.RefreshLockState())
		{
			return;
		}
		MonsterHandBook? monsterHandBookConfigById = HandBookConfig.Instance.GetMonsterHandBookConfigById(this.CurrentSelectedMonsterInfoId);
		if (monsterHandBookConfigById == null)
		{
			return;
		}
		MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(this.CurrentSelectedMonsterInfoId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), monsterInfoConfig.Value.Name, Array.Empty<object>());
		MonsterHandBookType? monsterHandBookTypeConfigById = HandBookConfig.Instance.GetMonsterHandBookTypeConfigById(monsterHandBookConfigById.Value.Type);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), ((monsterHandBookTypeConfigById != null) ? monsterHandBookTypeConfigById.GetValueOrDefault().Descrtption : null) ?? "", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), monsterInfoConfig.Value.DiscoveredDes, Array.Empty<object>());
		this.RefreshSkinBtn(monsterHandBookConfigById.Value.MonsterId);
	}

	// Token: 0x0600BF39 RID: 48953 RVA: 0x003871A0 File Offset: 0x003853A0
	private bool RefreshLockState()
	{
		base.GetButton(12).RootUIComp.Get().SetUIActive(!this.IsLock);
		if (this.IsLock || this.CurrentSelectedMonsterInfoId == 0)
		{
			base.GetItem(17).SetUIActive(true);
			base.GetItem(16).SetUIActive(false);
			if (this.VisionCameraInputItem != null)
			{
				this.VisionCameraInputItem.SetUiActive(false);
			}
			if (this.IsShowingSkin)
			{
				base.GetText(20).SetUIActive(false);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(19), "MonsterHandBookMonsterSkinNotHave", Array.Empty<object>());
			}
			else
			{
				base.GetText(20).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(19), "MonsterHandBookMonsterNotHave", Array.Empty<object>());
				base.GetButton(13).RootUIComp.Get().SetUIActive(false);
			}
			this.LoadingItem.SetLoadingActive(false);
			return true;
		}
		base.GetItem(17).SetUIActive(false);
		base.GetItem(16).SetUIActive(true);
		if (this.VisionCameraInputItem != null)
		{
			this.VisionCameraInputItem.SetUiActive(true);
		}
		return false;
	}

	// Token: 0x0600BF3A RID: 48954 RVA: 0x003872CC File Offset: 0x003854CC
	private void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Monster);
		LguiUtil.Instance.SetLocalText(base.GetText(3), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600BF3B RID: 48955 RVA: 0x0038731C File Offset: 0x0038551C
	[NullableContext(1)]
	private MonsterHandBookItem CreateNodeGrid(object data, UUIItem uiItem, int index)
	{
		return new MonsterHandBookItem
		{
			OnClickCallBack = new Action<UUIExtendToggle, int, bool>(this.OnClickMonsterItemCallBack)
		};
	}

	// Token: 0x0600BF3C RID: 48956 RVA: 0x00387338 File Offset: 0x00385538
	[NullableContext(1)]
	private void OnClickMonsterItemCallBack(UUIExtendToggle toggle, int handBookId, bool isLock)
	{
		if (this.CurrentToggle != toggle)
		{
			UUIExtendToggle currentToggle = this.CurrentToggle;
			if (currentToggle != null)
			{
				currentToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
		}
		this.CurrentToggle = toggle;
		if (handBookId == this.CurrentSelectedMonsterInfoId)
		{
			return;
		}
		this.IsShowingSkin = false;
		this.CurrentSelectedMonsterInfoId = handBookId;
		HandBookModel.Instance.CurrentSelectMonsterHandBookId = this.CurrentSelectedMonsterInfoId;
		this.DestroyVision();
		this.IsLock = isLock;
		if (!this.IsLock)
		{
			this.LoadVision();
		}
		this.RefeshView();
		this.ReadMonsterHandBook(handBookId);
	}

	// Token: 0x0600BF3D RID: 48957 RVA: 0x003873BC File Offset: 0x003855BC
	[NullableContext(1)]
	private void OnFilterUpdate(List<int> list, bool isOutSideChange, EFilterSortType OperationType)
	{
		List<int> list2 = new List<int>();
		foreach (int item in list)
		{
			list2.Add(item);
		}
		if (list2 == null || list2.Count <= 0)
		{
			base.GetUIDynScrollViewComponent(4).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetUIDynScrollViewComponent(4).RootUIComp.Get().SetUIActive(true);
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		foreach (int id in list2)
		{
			MonsterHandBook? monsterHandBookConfigById = HandBookConfig.Instance.GetMonsterHandBookConfigById(id);
			if (monsterHandBookConfigById != null)
			{
				List<int> list3;
				if (!dictionary.TryGetValue(monsterHandBookConfigById.Value.Type, out list3))
				{
					list3 = new List<int>();
				}
				list3.Add(monsterHandBookConfigById.Value.Id);
				dictionary[monsterHandBookConfigById.Value.Type] = list3;
			}
		}
		List<MonsterHandBookDynamicData> list4 = new List<MonsterHandBookDynamicData>();
		foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
		{
			int key = keyValuePair.Key;
			List<int> value = keyValuePair.Value;
			MonsterHandBookDynamicData monsterHandBookDynamicData = new MonsterHandBookDynamicData();
			MonsterHandBookType? monsterHandBookTypeConfigById = HandBookConfig.Instance.GetMonsterHandBookTypeConfigById(key);
			monsterHandBookDynamicData.TitleId = (((monsterHandBookTypeConfigById != null) ? monsterHandBookTypeConfigById.GetValueOrDefault().Descrtption : null) ?? "");
			list4.Add(monsterHandBookDynamicData);
			list4.Add(new MonsterHandBookDynamicData
			{
				MonsterList = value.ToArray()
			});
		}
		if (list4.Count <= 0)
		{
			this.RefeshView();
			return;
		}
		HandBookModel.Instance.CurrentSelectMonsterHandBookId = list2[0];
		DynamicScrollView<MonsterHandBookItem, MonsterHandBookDynamicItem, MonsterHandBookDynamicData> monsterGenericLayout = this.MonsterGenericLayout;
		if (monsterGenericLayout == null)
		{
			return;
		}
		monsterGenericLayout.RefreshByData(list4.ToArray(), false, false);
	}

	// Token: 0x0600BF3E RID: 48958 RVA: 0x003875F0 File Offset: 0x003857F0
	private void LoadVision()
	{
		if (this.BpHandle != -1 || UiSceneManager.Instance.GetHandBookVision() != null)
		{
			Log.Instance.Error(ELogModule.HandBook, ELogAuthor.LJQ, "怪物模型重复加载", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.LoadingItem.SetLoadingActive(true);
		int monsterId = this.CurrentSelectedMonsterInfoId;
		MonsterHandBook? monsterHandBookConfigById = HandBookConfig.Instance.GetMonsterHandBookConfigById(monsterId);
		if (monsterHandBookConfigById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HandBook;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "怪物图鉴配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("monsterId", monsterId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.BpHandle = ResourceSystem.Instance.LoadAsync<UClass>(monsterHandBookConfigById.Value.HandBookBp + "_C", delegate([Nullable(2)] UClass csClass, string _)
		{
			this.SetVisionInfo(monsterId, csClass);
		}, 100, this.MemoryTag);
	}

	// Token: 0x0600BF3F RID: 48959 RVA: 0x003876E4 File Offset: 0x003858E4
	[NullableContext(1)]
	private void SetVisionInfo(int monsterId, UClass csClass)
	{
		UiSceneManager.Instance.CreateHandBookVision(csClass);
		BP_KposeBase_C handBookVision = UiSceneManager.Instance.GetHandBookVision();
		UiSceneManager.Instance.HideHandBookVision();
		TArray<USkeletalMesh> tarray = new TArray<USkeletalMesh>();
		TArray<UStaticMesh> tarray2 = new TArray<UStaticMesh>();
		TArray<UActorComponent> tarray3 = handBookVision.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
		TArray<UActorComponent> tarray4 = handBookVision.K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
		if (tarray3 != null)
		{
			for (int i = 0; i < tarray3.Num(); i++)
			{
				USkeletalMeshComponent uskeletalMeshComponent = tarray3.Get(i) as USkeletalMeshComponent;
				uskeletalMeshComponent.SetForcedLOD(1);
				tarray.Add(uskeletalMeshComponent.SkeletalMesh);
			}
		}
		if (tarray4 != null)
		{
			for (int j = 0; j < tarray4.Num(); j++)
			{
				UStaticMeshComponent ustaticMeshComponent = tarray4.Get(j) as UStaticMeshComponent;
				ustaticMeshComponent.SetForcedLodModel(1);
				tarray2.Add(ustaticMeshComponent.StaticMesh);
			}
		}
		MeshStreamTaskContext meshStreamTaskContext = new MeshStreamTaskContext();
		meshStreamTaskContext.SkeletalMeshes = tarray;
		meshStreamTaskContext.StaticMeshes = tarray2;
		meshStreamTaskContext.OnTaskFinish = delegate()
		{
			this.OnLoadFinish(monsterId);
		};
		this.MeshStreamTaskId = MeshStreamController.Instance.AddMeshStreamTask(meshStreamTaskContext);
	}

	// Token: 0x0600BF40 RID: 48960 RVA: 0x0038780C File Offset: 0x00385A0C
	private void OnLoadFinish(int monsterId)
	{
		UiCameraLogicComponent uiCameraComponent = UiCameraModel.Instance.GetOrCreateCamera().GetUiCameraComponent<UiCameraLogicComponent>();
		BP_KposeBase_C handBookVision = UiSceneManager.Instance.GetHandBookVision();
		if (handBookVision == null)
		{
			Log.Instance.Error(ELogModule.HandBook, ELogAuthor.LJQ, "声骸模型为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (handBookVision.CameraArmLength <= 0)
		{
			Log.Instance.Error(ELogModule.HandBook, ELogAuthor.LJQ, "相机臂长配置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		MonsterHandBook? monsterHandBookConfigById = HandBookConfig.Instance.GetMonsterHandBookConfigById(monsterId);
		if (monsterHandBookConfigById == null)
		{
			return;
		}
		UiCameraModel.Instance.PushCameraHandleByHandleName(monsterHandBookConfigById.Value.HandBookCamera, false, false, "1001", false, null);
		if (uiCameraComponent != null)
		{
			uiCameraComponent.SetArmLength((float)handBookVision.CameraArmLength);
		}
		UiSceneManager.Instance.ShowHandBookVision();
		if (handBookVision != null)
		{
			handBookVision.PlayStart();
		}
		RoleModelLoadingItem loadingItem = this.LoadingItem;
		if (loadingItem == null)
		{
			return;
		}
		loadingItem.SetLoadingActive(false);
	}

	// Token: 0x0600BF41 RID: 48961 RVA: 0x003878EC File Offset: 0x00385AEC
	private void DestroyVision()
	{
		if (this.BpHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.BpHandle);
			this.BpHandle = -1;
		}
		if (this.MeshStreamTaskId != -1)
		{
			MeshStreamController.Instance.RemoveMeshStreamTask(this.MeshStreamTaskId);
			this.MeshStreamTaskId = -1;
		}
		if (UiSceneManager.Instance.GetHandBookVision() != null)
		{
			UiSceneManager.Instance.DestroyHandBookVision();
		}
	}

	// Token: 0x0600BF42 RID: 48962 RVA: 0x0038794F File Offset: 0x00385B4F
	protected override void OnBeforeDestroy()
	{
		this.DestroyVision();
		this.LoadingItem.Destroy(null);
	}

	// Token: 0x0600BF43 RID: 48963 RVA: 0x00387964 File Offset: 0x00385B64
	private void EnterInternalView()
	{
		if (this.IsInternal)
		{
			return;
		}
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlaySequence("On", false, null);
		}
		base.GetButton(21).RootUIComp.Get().SetUIActive(true);
		base.GetButton(12).RootUIComp.Get().SetUIActive(false);
		base.GetButton(13).RootUIComp.Get().SetUIActive(false);
		if (this.CaptionItem != null)
		{
			this.CaptionItem.SetCloseBtnActive(false);
		}
		this.IsInternal = true;
		UiCamera orCreateCamera = UiCameraModel.Instance.GetOrCreateCamera();
		UiCameraBlendComponent blendComponent = orCreateCamera.GetUiCameraComponent<UiCameraBlendComponent>();
		MonsterHandBook? monsterHandBookConfigById = HandBookConfig.Instance.GetMonsterHandBookConfigById(this.CurrentSelectedMonsterInfoId);
		if (monsterHandBookConfigById == null)
		{
			return;
		}
		MonsterBodyTypeConfig? bodyTypeConfig = MonsterInfoConfig.Instance.GetMonsterBodyTypeConfig(monsterHandBookConfigById.Value.MonsterBodyType);
		ResourceSystem.Instance.LoadAsync<UCurveFloat>(bodyTypeConfig.Value.MoveForwardCurvePath, delegate([Nullable(2)] UCurveFloat curve, string _)
		{
			if (curve != null)
			{
				UiCameraBlendComponent blendComponent = blendComponent;
				if (blendComponent == null)
				{
					return;
				}
				blendComponent.DoMoveForward((float)bodyTypeConfig.Value.MoveForwardDistance, (float)bodyTypeConfig.Value.MoveForwardDuration, curve);
			}
		}, 100, this.MemoryTag);
		this.VisionCameraInputItem.CanPitchInput = true;
		this.RefreshInternal();
	}

	// Token: 0x0600BF44 RID: 48964 RVA: 0x00387AA8 File Offset: 0x00385CA8
	private void QuitInternalView()
	{
		if (!this.IsInternal)
		{
			Log.Instance.Error(ELogModule.HandBook, ELogAuthor.LJQ, "重复退出声骸图鉴的内部界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.PlaySequence("Off", false, null);
		}
		base.GetButton(21).RootUIComp.Get().SetUIActive(false);
		base.GetButton(12).RootUIComp.Get().SetUIActive(true);
		if (this.CaptionItem != null)
		{
			this.CaptionItem.SetCloseBtnActive(true);
		}
		UUIItem uuiitem = base.GetButton(13).RootUIComp.Get();
		bool uiactive;
		if (!this.IsLock)
		{
			int[] skinList = this.SkinList;
			uiactive = (((skinList != null) ? skinList.Length : 0) > 1);
		}
		else
		{
			uiactive = false;
		}
		uuiitem.SetUIActive(uiactive);
		this.IsInternal = false;
		UiCamera orCreateCamera = UiCameraModel.Instance.GetOrCreateCamera();
		UiCameraLogicComponent logicComponent = orCreateCamera.GetUiCameraComponent<UiCameraLogicComponent>();
		UiCameraBlendComponent blendComponent = orCreateCamera.GetUiCameraComponent<UiCameraBlendComponent>();
		MonsterHandBook? monsterHandBookConfigById = HandBookConfig.Instance.GetMonsterHandBookConfigById(this.CurrentSelectedMonsterInfoId);
		if (monsterHandBookConfigById == null)
		{
			return;
		}
		MonsterBodyTypeConfig? bodyTypeConfig = MonsterInfoConfig.Instance.GetMonsterBodyTypeConfig(monsterHandBookConfigById.Value.MonsterBodyType);
		ResourceSystem.Instance.LoadAsync<UCurveFloat>(bodyTypeConfig.Value.MoveForwardCurvePath, delegate([Nullable(2)] UCurveFloat curve, string _)
		{
			if (curve != null)
			{
				BP_KposeBase_C handBookVision = UiSceneManager.Instance.GetHandBookVision();
				if (handBookVision != null && handBookVision.IsValid())
				{
					UiCameraLogicComponent logicComponent = logicComponent;
					if (logicComponent != null)
					{
						logicComponent.SetArmLength((float)handBookVision.CameraArmLength);
					}
					UiCameraLogicComponent logicComponent2 = logicComponent;
					if (logicComponent2 != null)
					{
						logicComponent2.SetArmRotationByDefaultCamera();
					}
					UiCameraBlendComponent blendComponent = blendComponent;
					if (blendComponent == null)
					{
						return;
					}
					blendComponent.StartFade((float)bodyTypeConfig.Value.MoveForwardDuration, curve, true, true, true, true);
				}
			}
		}, 100, this.MemoryTag);
		this.VisionCameraInputItem.CanPitchInput = false;
		this.RefreshInternal();
	}

	// Token: 0x0600BF45 RID: 48965 RVA: 0x00387C34 File Offset: 0x00385E34
	private void RefreshInternal()
	{
		base.GetItem(18).SetUIActive(!this.IsInternal);
		base.GetItem(16).SetUIActive(!this.IsInternal);
		if (this.CaptionItem != null)
		{
			this.CaptionItem.SetUiActive(!this.IsInternal);
		}
	}

	// Token: 0x0600BF46 RID: 48966 RVA: 0x00387C8C File Offset: 0x00385E8C
	private void OnMonsterSkinBtnClick()
	{
		if (this.SkinList == null)
		{
			return;
		}
		this.ShowSkinIndex++;
		if (this.ShowSkinIndex >= this.SkinList.Length)
		{
			this.ShowSkinIndex = 0;
		}
		this.IsShowingSkin = (this.ShowSkinIndex > 0);
		int monsterId = PhantomBattleConfig.Instance.GetPhantomItemById(this.SkinList[this.ShowSkinIndex]).Value.MonsterId;
		MonsterHandBook? monsterHandBookConfigByMonsterId = HandBookConfig.Instance.GetMonsterHandBookConfigByMonsterId(monsterId);
		this.CurrentSelectedMonsterInfoId = ((monsterHandBookConfigByMonsterId != null) ? monsterHandBookConfigByMonsterId.GetValueOrDefault().Id : 0);
		if (this.ShowSkinIndex == 0)
		{
			HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Monster, monsterHandBookConfigByMonsterId.Value.Id);
			this.IsLock = (handBookInfo == null);
		}
		else
		{
			this.IsLock = (this.ShowSkinIndex > 0 && !PhantomBattleModel.Instance.GetSkinIsUnlock(this.SkinList[this.ShowSkinIndex]));
		}
		this.DestroyVision();
		this.LoadingItem.SetLoadingActive(false);
		if (!this.IsLock)
		{
			this.LoadVision();
		}
		this.RefeshView();
	}

	// Token: 0x0600BF47 RID: 48967 RVA: 0x00387DB0 File Offset: 0x00385FB0
	private void OnBackCheckBtnClick()
	{
		this.QuitInternalView();
	}

	// Token: 0x0600BF48 RID: 48968 RVA: 0x00387DB8 File Offset: 0x00385FB8
	private void RefreshSkinBtn(int monsterId)
	{
		if (this.IsShowingSkin)
		{
			return;
		}
		this.SkinList = null;
		if (monsterId == 0)
		{
			base.GetButton(13).RootUIComp.Get().SetUIActive(false);
			return;
		}
		int[] monsterSkinListByMonsterId = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(monsterId);
		if (monsterSkinListByMonsterId == null || monsterSkinListByMonsterId.Length == 0)
		{
			base.GetButton(13).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetButton(13).RootUIComp.Get().SetUIActive(!this.IsLock && monsterSkinListByMonsterId.Length > 1);
		this.SkinList = monsterSkinListByMonsterId;
		this.ShowSkinIndex = 0;
	}

	// Token: 0x0600BF49 RID: 48969 RVA: 0x00387E5C File Offset: 0x0038605C
	private void ReadMonsterHandBook(int handBookId)
	{
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Monster, handBookId);
		if (handBookInfo == null)
		{
			return;
		}
		if (!handBookInfo.IsRead)
		{
			HandBookController.Instance.SendIllustratedReadRequest(EHandBookTabType.Monster, handBookId);
		}
	}

	// Token: 0x04006DEE RID: 28142
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006DEF RID: 28143
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<MonsterHandBookItem, MonsterHandBookDynamicItem, MonsterHandBookDynamicData> MonsterGenericLayout;

	// Token: 0x04006DF0 RID: 28144
	private UUIExtendToggle CurrentToggle;

	// Token: 0x04006DF1 RID: 28145
	private FilterSortEntrance<int> FilterBtn;

	// Token: 0x04006DF2 RID: 28146
	private MonsterHandBookDynamicItem MonsterBaseItem;

	// Token: 0x04006DF3 RID: 28147
	private int BpHandle = -1;

	// Token: 0x04006DF4 RID: 28148
	private RoleModelLoadingItem LoadingItem;

	// Token: 0x04006DF5 RID: 28149
	private int MeshStreamTaskId = -1;

	// Token: 0x04006DF6 RID: 28150
	private VisionCameraInputItem VisionCameraInputItem;

	// Token: 0x04006DF7 RID: 28151
	private bool IsInternal;

	// Token: 0x04006DF8 RID: 28152
	private int CurrentSelectedMonsterInfoId;

	// Token: 0x04006DF9 RID: 28153
	private bool IsLock = true;

	// Token: 0x04006DFA RID: 28154
	private int[] SkinList;

	// Token: 0x04006DFB RID: 28155
	private int ShowSkinIndex;

	// Token: 0x04006DFC RID: 28156
	private bool IsShowingSkin;

	// Token: 0x0200756B RID: 30059
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402621E RID: 156190
		public const int CaptionItem = 0;

		// Token: 0x0402621F RID: 156191
		public const int DragItem = 1;

		// Token: 0x04026220 RID: 156192
		public const int CollectText = 2;

		// Token: 0x04026221 RID: 156193
		public const int CollectNumText = 3;

		// Token: 0x04026222 RID: 156194
		public const int MonsterScrollView = 4;

		// Token: 0x04026223 RID: 156195
		public const int MonsterItem = 5;

		// Token: 0x04026224 RID: 156196
		public const int SortFilterItem = 6;

		// Token: 0x04026225 RID: 156197
		public const int MonsterNameText = 7;

		// Token: 0x04026226 RID: 156198
		public const int MonsterLevelNameText = 8;

		// Token: 0x04026227 RID: 156199
		public const int ElementLayout = 9;

		// Token: 0x04026228 RID: 156200
		public const int ElementItem = 10;

		// Token: 0x04026229 RID: 156201
		public const int DesText = 11;

		// Token: 0x0402622A RID: 156202
		public const int CheckBtn = 12;

		// Token: 0x0402622B RID: 156203
		public const int SkinBtn = 13;

		// Token: 0x0402622C RID: 156204
		public const int PoseLayout = 14;

		// Token: 0x0402622D RID: 156205
		public const int PoseItem = 15;

		// Token: 0x0402622E RID: 156206
		public const int UnLockItem = 16;

		// Token: 0x0402622F RID: 156207
		public const int NoneItem = 17;

		// Token: 0x04026230 RID: 156208
		public const int LeftItem = 18;

		// Token: 0x04026231 RID: 156209
		public const int NoneAText = 19;

		// Token: 0x04026232 RID: 156210
		public const int NoneBText = 20;

		// Token: 0x04026233 RID: 156211
		public const int BackCheckBtn = 21;
	}
}
