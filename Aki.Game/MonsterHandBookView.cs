using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Kpose.Blueprint;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E36 RID: 7734
[NullableContext(2)]
[Nullable(0)]
public class MonsterHandBookView : UiViewBase
{
	// Token: 0x0600EB15 RID: 60181 RVA: 0x0037B11B File Offset: 0x0037931B
	[NullableContext(1)]
	public MonsterHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EB16 RID: 60182 RVA: 0x0037B13C File Offset: 0x0037933C
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

	// Token: 0x0600EB17 RID: 60183 RVA: 0x0037B39C File Offset: 0x0037959C
	protected override UniTask OnBeforeStartAsync()
	{
		MonsterHandBookView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MonsterHandBookView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EB18 RID: 60184 RVA: 0x0037B3E0 File Offset: 0x003795E0
	protected override void OnBeforeShowImplementImplement()
	{
		this.RefreshCollectText();
		int[] allHandBookMonsterIdList = HandBookModel.Instance.GetAllHandBookMonsterIdList();
		this.FilterBtn.UpdateData(EFilterSortGroupId.MonsterHandBook, allHandBookMonsterIdList.ToList<int>(), Array.Empty<object>());
	}

	// Token: 0x0600EB19 RID: 60185 RVA: 0x0037B418 File Offset: 0x00379618
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

	// Token: 0x0600EB1A RID: 60186 RVA: 0x0037B514 File Offset: 0x00379714
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

	// Token: 0x0600EB1B RID: 60187 RVA: 0x0037B640 File Offset: 0x00379840
	private void RefreshCollectText()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress(EHandBookTabType.Monster);
		LguiUtil.Instance.SetLocalText(base.GetText(3), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			collectProgress[0],
			collectProgress[1]
		}));
	}

	// Token: 0x0600EB1C RID: 60188 RVA: 0x0037B690 File Offset: 0x00379890
	[NullableContext(1)]
	private MonsterHandBookItem CreateNodeGrid(object data, UUIItem uiItem, int index)
	{
		return new MonsterHandBookItem
		{
			OnClickCallBack = new Action<UUIExtendToggle, int, bool>(this.OnClickMonsterItemCallBack)
		};
	}

	// Token: 0x0600EB1D RID: 60189 RVA: 0x0037B6AC File Offset: 0x003798AC
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

	// Token: 0x0600EB1E RID: 60190 RVA: 0x0037B730 File Offset: 0x00379930
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

	// Token: 0x0600EB1F RID: 60191 RVA: 0x0037B964 File Offset: 0x00379B64
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

	// Token: 0x0600EB20 RID: 60192 RVA: 0x0037BA58 File Offset: 0x00379C58
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

	// Token: 0x0600EB21 RID: 60193 RVA: 0x0037BB80 File Offset: 0x00379D80
	private void OnLoadFinish(int monsterId)
	{
		UiCameraControlRotationComponent uiCameraComponent = UiCameraManager.Get().GetUiCameraComponent<UiCameraControlRotationComponent>();
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
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(monsterHandBookConfigById.Value.HandBookCamera, false, false, "1001", false, null, null);
		uiCameraComponent.SetArmLength((float)handBookVision.CameraArmLength);
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

	// Token: 0x0600EB22 RID: 60194 RVA: 0x0037BC64 File Offset: 0x00379E64
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

	// Token: 0x0600EB23 RID: 60195 RVA: 0x0037BCC7 File Offset: 0x00379EC7
	protected override void OnBeforeDestroy()
	{
		this.DestroyVision();
		this.LoadingItem.Destroy(null);
	}

	// Token: 0x0600EB24 RID: 60196 RVA: 0x0037BCDC File Offset: 0x00379EDC
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
		UiCamera uiCamera = UiCameraManager.Get();
		UiCameraControlRotationComponent rotationComponent = uiCamera.GetUiCameraComponent<UiCameraControlRotationComponent>();
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
				rotationComponent.DoMoveForward((float)bodyTypeConfig.Value.MoveForwardDistance, (float)bodyTypeConfig.Value.MoveForwardDuration, curve);
			}
		}, 100, this.MemoryTag);
		this.VisionCameraInputItem.CanPitchInput = true;
		this.RefreshInternal();
	}

	// Token: 0x0600EB25 RID: 60197 RVA: 0x0037BE1C File Offset: 0x0037A01C
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
		UiCamera uiCamera = UiCameraManager.Get();
		UiCameraControlRotationComponent rotationComponent = uiCamera.GetUiCameraComponent<UiCameraControlRotationComponent>();
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
					rotationComponent.SetArmLength((float)handBookVision.CameraArmLength);
					rotationComponent.SetArmRotationByDefaultCamera();
					rotationComponent.StartFade((float)bodyTypeConfig.Value.MoveForwardDuration, curve, true, true, true, true);
				}
			}
		}, 100, this.MemoryTag);
		this.VisionCameraInputItem.CanPitchInput = false;
		this.RefreshInternal();
	}

	// Token: 0x0600EB26 RID: 60198 RVA: 0x0037BF94 File Offset: 0x0037A194
	private void RefreshInternal()
	{
		base.GetItem(18).SetUIActive(!this.IsInternal);
		base.GetItem(16).SetUIActive(!this.IsInternal);
		if (this.CaptionItem != null)
		{
			this.CaptionItem.SetUiActive(!this.IsInternal);
		}
	}

	// Token: 0x0600EB27 RID: 60199 RVA: 0x0037BFEC File Offset: 0x0037A1EC
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

	// Token: 0x0600EB28 RID: 60200 RVA: 0x0037C110 File Offset: 0x0037A310
	private void OnBackCheckBtnClick()
	{
		this.QuitInternalView();
	}

	// Token: 0x0600EB29 RID: 60201 RVA: 0x0037C118 File Offset: 0x0037A318
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

	// Token: 0x0600EB2A RID: 60202 RVA: 0x0037C1BC File Offset: 0x0037A3BC
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

	// Token: 0x04006D0D RID: 27917
	private PopupCaptionItem CaptionItem;

	// Token: 0x04006D0E RID: 27918
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private DynamicScrollView<MonsterHandBookItem, MonsterHandBookDynamicItem, MonsterHandBookDynamicData> MonsterGenericLayout;

	// Token: 0x04006D0F RID: 27919
	private UUIExtendToggle CurrentToggle;

	// Token: 0x04006D10 RID: 27920
	private FilterSortEntrance<int> FilterBtn;

	// Token: 0x04006D11 RID: 27921
	private MonsterHandBookDynamicItem MonsterBaseItem;

	// Token: 0x04006D12 RID: 27922
	private int BpHandle = -1;

	// Token: 0x04006D13 RID: 27923
	private RoleModelLoadingItem LoadingItem;

	// Token: 0x04006D14 RID: 27924
	private int MeshStreamTaskId = -1;

	// Token: 0x04006D15 RID: 27925
	private VisionCameraInputItem VisionCameraInputItem;

	// Token: 0x04006D16 RID: 27926
	private bool IsInternal;

	// Token: 0x04006D17 RID: 27927
	private int CurrentSelectedMonsterInfoId;

	// Token: 0x04006D18 RID: 27928
	private bool IsLock = true;

	// Token: 0x04006D19 RID: 27929
	private int[] SkinList;

	// Token: 0x04006D1A RID: 27930
	private int ShowSkinIndex;

	// Token: 0x04006D1B RID: 27931
	private bool IsShowingSkin;

	// Token: 0x020083E6 RID: 33766
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402AEFB RID: 175867
		public const int CaptionItem = 0;

		// Token: 0x0402AEFC RID: 175868
		public const int DragItem = 1;

		// Token: 0x0402AEFD RID: 175869
		public const int CollectText = 2;

		// Token: 0x0402AEFE RID: 175870
		public const int CollectNumText = 3;

		// Token: 0x0402AEFF RID: 175871
		public const int MonsterScrollView = 4;

		// Token: 0x0402AF00 RID: 175872
		public const int MonsterItem = 5;

		// Token: 0x0402AF01 RID: 175873
		public const int SortFilterItem = 6;

		// Token: 0x0402AF02 RID: 175874
		public const int MonsterNameText = 7;

		// Token: 0x0402AF03 RID: 175875
		public const int MonsterLevelNameText = 8;

		// Token: 0x0402AF04 RID: 175876
		public const int ElementLayout = 9;

		// Token: 0x0402AF05 RID: 175877
		public const int ElementItem = 10;

		// Token: 0x0402AF06 RID: 175878
		public const int DesText = 11;

		// Token: 0x0402AF07 RID: 175879
		public const int CheckBtn = 12;

		// Token: 0x0402AF08 RID: 175880
		public const int SkinBtn = 13;

		// Token: 0x0402AF09 RID: 175881
		public const int PoseLayout = 14;

		// Token: 0x0402AF0A RID: 175882
		public const int PoseItem = 15;

		// Token: 0x0402AF0B RID: 175883
		public const int UnLockItem = 16;

		// Token: 0x0402AF0C RID: 175884
		public const int NoneItem = 17;

		// Token: 0x0402AF0D RID: 175885
		public const int LeftItem = 18;

		// Token: 0x0402AF0E RID: 175886
		public const int NoneAText = 19;

		// Token: 0x0402AF0F RID: 175887
		public const int NoneBText = 20;

		// Token: 0x0402AF10 RID: 175888
		public const int BackCheckBtn = 21;
	}
}
