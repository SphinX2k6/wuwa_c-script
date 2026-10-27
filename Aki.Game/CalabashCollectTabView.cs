using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Kpose.Blueprint;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001743 RID: 5955
[NullableContext(2)]
[Nullable(0)]
public class CalabashCollectTabView : UiTabViewBase
{
	// Token: 0x0600AC45 RID: 44101 RVA: 0x00269D6C File Offset: 0x00267F6C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnBackButtonClick))
		};
	}

	// Token: 0x0600AC46 RID: 44102 RVA: 0x00269E9C File Offset: 0x0026809C
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ChangeCalabashCollectSimplyState, new Action(this.OnSimplyStateChange));
	}

	// Token: 0x0600AC47 RID: 44103 RVA: 0x00269EBA File Offset: 0x002680BA
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ChangeCalabashCollectSimplyState, new Action(this.OnSimplyStateChange));
	}

	// Token: 0x0600AC48 RID: 44104 RVA: 0x00269ED8 File Offset: 0x002680D8
	private void OnSimplyStateChange()
	{
		if (CalabashModel.Instance.GetIfSimpleState())
		{
			this.DetailItem.PlayDetailShowSequence();
			return;
		}
		this.DetailItem.PlayDetailHideSequence();
	}

	// Token: 0x0600AC49 RID: 44105 RVA: 0x00269EFD File Offset: 0x002680FD
	private void OnBackButtonClick()
	{
		if (this.IsOnlyShow)
		{
			UiManager.Instance.CloseView(EUiViewName.CalabashRootView, null);
			return;
		}
		this.QuitInternalView();
	}

	// Token: 0x0600AC4A RID: 44106 RVA: 0x00269F20 File Offset: 0x00268120
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashCollectTabView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashCollectTabView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AC4B RID: 44107 RVA: 0x00269F63 File Offset: 0x00268163
	protected override void OnStart()
	{
		if (this.IsOnlyShow)
		{
			this.StopPlayingUiTabSequence();
		}
	}

	// Token: 0x0600AC4C RID: 44108 RVA: 0x00269F74 File Offset: 0x00268174
	protected override void OnBeforeShow()
	{
		this.FilterEntrance.UpdateData(EFilterSortGroupId.CalabashCollect, CalabashModel.Instance.GetCalabashDevelopRewardSortData().ToList<CalabashDevelopRewardData>(), Array.Empty<object>());
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(EFilterSortGroupId.CalabashCollect);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateData(EFilterSortGroupId.CalabashCollect, CalabashModel.Instance.GetCalabashDevelopRewardSortData().ToList<CalabashDevelopRewardData>(), Array.Empty<object>());
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(EFilterSortGroupId.CalabashCollect);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
		this.DetailItem.RefreshDetailState();
		base.GetButton(9).RootUIComp.Get().SetUIActive(this.IsInternal);
	}

	// Token: 0x0600AC4D RID: 44109 RVA: 0x0026A022 File Offset: 0x00268222
	protected override void OnBeforeHide()
	{
		this.WaitToSelectMonsterId = this.CurrentSelectedMonsterId;
		this.LoadingItem.SetLoadingActive(false);
		this.CancelSelect();
	}

	// Token: 0x0600AC4E RID: 44110 RVA: 0x0026A042 File Offset: 0x00268242
	protected override void OnBeforeDestroy()
	{
		this.DestroyVision();
		this.LoadingItem.Destroy(null);
	}

	// Token: 0x0600AC4F RID: 44111 RVA: 0x0026A056 File Offset: 0x00268256
	[NullableContext(1)]
	private CalabashCollectGridItem CreateProxy()
	{
		return new CalabashCollectGridItem
		{
			OnToggleClick = new Action<int>(this.OnToggleClick),
			CanToggleChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x0600AC50 RID: 44112 RVA: 0x0026A081 File Offset: 0x00268281
	private void OnToggleClick(int gridIndex)
	{
		this.LoopScroll.SelectGridProxy(gridIndex, false);
		this.OnPhantomSelectChange();
	}

	// Token: 0x0600AC51 RID: 44113 RVA: 0x0026A096 File Offset: 0x00268296
	private bool CanToggleChange(int gridIndex)
	{
		LoopScrollView<CalabashCollectGridItem, CalabashDevelopRewardData> loopScroll = this.LoopScroll;
		return loopScroll == null || loopScroll.GetSelectedGridIndex() != gridIndex;
	}

	// Token: 0x0600AC52 RID: 44114 RVA: 0x0026A0B0 File Offset: 0x002682B0
	[NullableContext(1)]
	private void UpdateDataList(List<CalabashDevelopRewardData> list, bool isOutSideChange, EFilterSortType operationType)
	{
		this.DataList = list.ToArray();
		this.LoopScroll.RefreshByData(this.DataList.ToList<CalabashDevelopRewardData>(), false, new Action(this.AfterLoopScrollRefresh), true);
		if (this.DataList.Length == 0)
		{
			return;
		}
		if (operationType == EFilterSortType.Sort)
		{
			this.CurrentSelectedMonsterId = this.DataList[0].DevelopRewardData.MonsterId;
		}
	}

	// Token: 0x0600AC53 RID: 44115 RVA: 0x0026A118 File Offset: 0x00268318
	private void AfterLoopScrollRefresh()
	{
		int toSelectId = 0;
		if (this.WaitToSelectMonsterId > 0)
		{
			toSelectId = this.WaitToSelectMonsterId;
			this.WaitToSelectMonsterId = 0;
		}
		else if (this.CurrentSelectedMonsterId > 0)
		{
			toSelectId = this.CurrentSelectedMonsterId;
		}
		int num = 0;
		if (toSelectId > 0 && this.DataList != null)
		{
			num = Array.FindIndex<CalabashDevelopRewardData>(this.DataList, (CalabashDevelopRewardData data) => data.DevelopRewardData.MonsterId == toSelectId);
			if (num < 0)
			{
				int? parentMonsterId = PhantomBattleModel.Instance.GetMonsterSkinMonsterIdMapByMonsterId(toSelectId);
				if (parentMonsterId != null)
				{
					num = Array.FindIndex<CalabashDevelopRewardData>(this.DataList, (CalabashDevelopRewardData data) => data.DevelopRewardData.MonsterId == parentMonsterId.Value);
				}
			}
		}
		num = Math.Max(0, num);
		this.LoopScroll.SelectGridProxy(num, false);
		this.LoopScroll.ScrollToGridIndex(num, true);
		this.OnPhantomSelectChange();
	}

	// Token: 0x0600AC54 RID: 44116 RVA: 0x0026A200 File Offset: 0x00268400
	private void OnPhantomSelectChange()
	{
		int selectedGridIndex = this.LoopScroll.GetSelectedGridIndex();
		CalabashDevelopRewardData calabashDevelopRewardData = this.DataList[selectedGridIndex];
		this.DetailItem.Update(calabashDevelopRewardData);
		this.CurrentSelectedMonsterId = calabashDevelopRewardData.DevelopRewardData.MonsterId;
		this.DestroyVision();
		if (this.IsOnlyShow)
		{
			this.CurrentSelectedMonsterId = this.ShowMonsterId;
			this.SetEmptyState(true, false);
			this.LoadVision();
			this.StopPlayingUiTabSequence();
			this.EnterInternalView(true);
			BlackScreenController.Instance.RemoveBlackScreen("Close", "CalabashCollectOnlyShow", "Default");
			return;
		}
		this.SetEmptyState(false, !calabashDevelopRewardData.UnlockData);
		if (calabashDevelopRewardData.UnlockData)
		{
			this.LoadVision();
		}
	}

	// Token: 0x0600AC55 RID: 44117 RVA: 0x0026A2AF File Offset: 0x002684AF
	private void EnterInternalView()
	{
		this.EnterInternalView(false);
	}

	// Token: 0x0600AC56 RID: 44118 RVA: 0x0026A2B8 File Offset: 0x002684B8
	private void EnterInternalView(bool skipUiAnim)
	{
		if (this.IsInternal)
		{
			Log.Instance.Error(ELogModule.Calabash, ELogAuthor.LZK, "重复进入声骸图鉴的内部界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.IsInternal = true;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Enter", true, null, skipUiAnim);
		}
		UiCamera uiCamera = UiCameraManager.Get();
		UiCameraControlRotationComponent rotationComponent = uiCamera.GetUiCameraComponent<UiCameraControlRotationComponent>();
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.CurrentSelectedMonsterId);
		MonsterBodyTypeConfig? bodyTypeConfig = MonsterInfoConfig.Instance.GetMonsterBodyTypeConfig(calabashDevelopRewardByMonsterId.Value.MonsterBodyType);
		ResourceSystem.Instance.LoadAsync<UCurveFloat>(bodyTypeConfig.Value.MoveForwardCurvePath, delegate([Nullable(2)] UCurveFloat curve, string _)
		{
			if (curve != null)
			{
				rotationComponent.DoMoveForward((float)bodyTypeConfig.Value.MoveForwardDistance, (float)bodyTypeConfig.Value.MoveForwardDuration, curve);
			}
		}, 100, this.MemoryTag);
		this.VisionCameraInputItem.CanPitchInput = true;
		EventSystem.Instance.Emit(EEventName.CalabashEnterInternalView);
	}

	// Token: 0x0600AC57 RID: 44119 RVA: 0x0026A3AE File Offset: 0x002685AE
	private void StopPlayingUiTabSequence()
	{
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.StopPlayingSequence(false, true);
	}

	// Token: 0x0600AC58 RID: 44120 RVA: 0x0026A3CE File Offset: 0x002685CE
	private void ChangeMonsterSkin(int monsterSkinId, bool isLock)
	{
		this.DetailItem.UpdateSkinInfo(monsterSkinId);
		this.CurrentSelectedMonsterId = monsterSkinId;
		this.DestroyVision();
		this.SetEmptyState(true, isLock);
		if (!isLock)
		{
			this.LoadVision();
		}
	}

	// Token: 0x0600AC59 RID: 44121 RVA: 0x0026A3FC File Offset: 0x002685FC
	private void QuitInternalView()
	{
		if (!this.IsInternal)
		{
			Log.Instance.Error(ELogModule.Calabash, ELogAuthor.LZK, "重复退出声骸图鉴的内部界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.IsInternal = false;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Back", true, null, false);
		}
		UiCamera uiCamera = UiCameraManager.Get();
		UiCameraControlRotationComponent rotationComponent = uiCamera.GetUiCameraComponent<UiCameraControlRotationComponent>();
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.CurrentSelectedMonsterId);
		MonsterBodyTypeConfig? bodyTypeConfig = MonsterInfoConfig.Instance.GetMonsterBodyTypeConfig(calabashDevelopRewardByMonsterId.Value.MonsterBodyType);
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
		EventSystem.Instance.Emit(EEventName.CalabashQuitInternalView);
	}

	// Token: 0x0600AC5A RID: 44122 RVA: 0x0026A4F4 File Offset: 0x002686F4
	private void LoadVision()
	{
		if (this.BpHandle != -1 || UiSceneManager.Instance.GetHandBookVision() != null)
		{
			Log.Instance.Error(ELogModule.Calabash, ELogAuthor.LZK, "声骸模型重复加载", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.LoadingItem.SetLoadingActive(true);
		int monsterId = this.CurrentSelectedMonsterId;
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(monsterId);
		this.BpHandle = ResourceSystem.Instance.LoadAsync<UClass>(calabashDevelopRewardByMonsterId.Value.HandBookBp + "_C", delegate([Nullable(2)] UClass csClass, string _)
		{
			this.SetVisionInfo(monsterId, csClass);
		}, 100, this.MemoryTag);
	}

	// Token: 0x0600AC5B RID: 44123 RVA: 0x0026A5AC File Offset: 0x002687AC
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

	// Token: 0x0600AC5C RID: 44124 RVA: 0x0026A6D4 File Offset: 0x002688D4
	private void OnLoadFinish(int monsterId)
	{
		UiCameraControlRotationComponent uiCameraComponent = UiCameraManager.Get().GetUiCameraComponent<UiCameraControlRotationComponent>();
		BP_KposeBase_C handBookVision = UiSceneManager.Instance.GetHandBookVision();
		if (handBookVision == null)
		{
			Log.Instance.Error(ELogModule.Calabash, ELogAuthor.LZK, "声骸模型为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (handBookVision.CameraArmLength <= 0)
		{
			Log.Instance.Error(ELogModule.Calabash, ELogAuthor.LZK, "相机臂长配置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(monsterId);
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(calabashDevelopRewardByMonsterId.Value.HandBookCamera, false, false, "1001", false, null, null);
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

	// Token: 0x0600AC5D RID: 44125 RVA: 0x0026A7B0 File Offset: 0x002689B0
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

	// Token: 0x0600AC5E RID: 44126 RVA: 0x0026A814 File Offset: 0x00268A14
	private void InitScheduleText()
	{
		int calabashAllSchedule = CalabashModel.Instance.GetCalabashAllSchedule();
		int calabashOwnSchedule = CalabashModel.Instance.GetCalabashOwnSchedule();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "Illustration_Progress_Iteration", new <>z__ReadOnlyArray<object>(new object[]
		{
			calabashOwnSchedule,
			calabashAllSchedule
		}));
	}

	// Token: 0x0600AC5F RID: 44127 RVA: 0x0026A86A File Offset: 0x00268A6A
	private void CancelSelect()
	{
		this.CurrentSelectedMonsterId = 0;
		LoopScrollView<CalabashCollectGridItem, CalabashDevelopRewardData> loopScroll = this.LoopScroll;
		if (loopScroll != null)
		{
			loopScroll.DeselectCurrentGridProxy(false);
		}
		this.DestroyVision();
	}

	// Token: 0x0600AC60 RID: 44128 RVA: 0x0026A88B File Offset: 0x00268A8B
	private void SetEmptyState(bool isSkin, bool isEmpty)
	{
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(!isSkin && isEmpty);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(isSkin && isEmpty);
	}

	// Token: 0x04004E23 RID: 20003
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<CalabashDevelopRewardData> FilterEntrance;

	// Token: 0x04004E24 RID: 20004
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<CalabashDevelopRewardData> SortEntrance;

	// Token: 0x04004E25 RID: 20005
	private CalabashCollectDetailItem DetailItem;

	// Token: 0x04004E26 RID: 20006
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<CalabashCollectGridItem, CalabashDevelopRewardData> LoopScroll;

	// Token: 0x04004E27 RID: 20007
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CalabashDevelopRewardData[] DataList;

	// Token: 0x04004E28 RID: 20008
	private VisionCameraInputItem VisionCameraInputItem;

	// Token: 0x04004E29 RID: 20009
	private RoleModelLoadingItem LoadingItem;

	// Token: 0x04004E2A RID: 20010
	private int WaitToSelectMonsterId;

	// Token: 0x04004E2B RID: 20011
	private int CurrentSelectedMonsterId;

	// Token: 0x04004E2C RID: 20012
	private int BpHandle = -1;

	// Token: 0x04004E2D RID: 20013
	private int MeshStreamTaskId = -1;

	// Token: 0x04004E2E RID: 20014
	private bool IsInternal;

	// Token: 0x04004E2F RID: 20015
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004E30 RID: 20016
	private int ShowMonsterId;

	// Token: 0x04004E31 RID: 20017
	private bool IsOnlyShow;

	// Token: 0x02007D2C RID: 32044
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x04028FE1 RID: 167905
		LoopScroll,
		// Token: 0x04028FE2 RID: 167906
		LoopScrollItem,
		// Token: 0x04028FE3 RID: 167907
		FilterEntrance,
		// Token: 0x04028FE4 RID: 167908
		SortEntrance,
		// Token: 0x04028FE5 RID: 167909
		DetailItem,
		// Token: 0x04028FE6 RID: 167910
		ScheduleText,
		// Token: 0x04028FE7 RID: 167911
		EmptyItem,
		// Token: 0x04028FE8 RID: 167912
		DragItem,
		// Token: 0x04028FE9 RID: 167913
		LeftItem,
		// Token: 0x04028FEA RID: 167914
		BackButton,
		// Token: 0x04028FEB RID: 167915
		EmptySkinItem
	}
}
