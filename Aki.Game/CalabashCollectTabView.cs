using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Kpose.Blueprint;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000BFC RID: 3068
[NullableContext(2)]
[Nullable(0)]
public class CalabashCollectTabView : UiTabViewBase
{
	// Token: 0x0600802C RID: 32812 RVA: 0x002741A8 File Offset: 0x002723A8
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

	// Token: 0x0600802D RID: 32813 RVA: 0x002742D8 File Offset: 0x002724D8
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ChangeCalabashCollectSimplyState, new Action(this.OnSimplyStateChange));
	}

	// Token: 0x0600802E RID: 32814 RVA: 0x002742F6 File Offset: 0x002724F6
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ChangeCalabashCollectSimplyState, new Action(this.OnSimplyStateChange));
	}

	// Token: 0x0600802F RID: 32815 RVA: 0x00274314 File Offset: 0x00272514
	private void OnSimplyStateChange()
	{
		if (CalabashModel.Instance.GetIfSimpleState())
		{
			this.DetailItem.PlayDetailShowSequence();
			return;
		}
		this.DetailItem.PlayDetailHideSequence();
	}

	// Token: 0x06008030 RID: 32816 RVA: 0x00274339 File Offset: 0x00272539
	private void OnBackButtonClick()
	{
		if (this.IsOnlyShow)
		{
			UiManager.Instance.CloseView(EUiViewName.CalabashRootView, null);
			return;
		}
		this.QuitInternalView();
	}

	// Token: 0x06008031 RID: 32817 RVA: 0x0027435C File Offset: 0x0027255C
	protected override UniTask OnBeforeStartAsync()
	{
		CalabashCollectTabView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CalabashCollectTabView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008032 RID: 32818 RVA: 0x0027439F File Offset: 0x0027259F
	protected override void OnStart()
	{
		if (this.IsOnlyShow)
		{
			this.StopPlayingUiTabSequence();
		}
	}

	// Token: 0x06008033 RID: 32819 RVA: 0x002743B0 File Offset: 0x002725B0
	protected override void OnBeforeShow()
	{
		this.FilterEntrance.UpdateData(EFilterSortGroupId.CalabashCollect, new List<CalabashDevelopRewardData>(CalabashModel.Instance.GetCalabashDevelopRewardSortData()), Array.Empty<object>());
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(EFilterSortGroupId.CalabashCollect);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateData(EFilterSortGroupId.CalabashCollect, new List<CalabashDevelopRewardData>(CalabashModel.Instance.GetCalabashDevelopRewardSortData()), Array.Empty<object>());
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(EFilterSortGroupId.CalabashCollect);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
		this.DetailItem.RefreshDetailState();
		base.GetButton(9).RootUIComp.Get().SetUIActive(this.IsInternal);
	}

	// Token: 0x06008034 RID: 32820 RVA: 0x0027445E File Offset: 0x0027265E
	protected override void OnBeforeHide()
	{
		this.WaitToSelectMonsterId = this.CurrentSelectedMonsterId;
		this.LoadingItem.SetLoadingActive(false);
		this.CancelSelect();
	}

	// Token: 0x06008035 RID: 32821 RVA: 0x0027447E File Offset: 0x0027267E
	protected override void OnBeforeDestroy()
	{
		this.DestroyVision();
		this.LoadingItem.Destroy(null);
	}

	// Token: 0x06008036 RID: 32822 RVA: 0x00274492 File Offset: 0x00272692
	[NullableContext(1)]
	private CalabashCollectGridItem CreateProxy()
	{
		return new CalabashCollectGridItem
		{
			OnToggleClick = new Action<int>(this.OnToggleClick),
			CanToggleChange = new Func<int, bool>(this.CanToggleChange)
		};
	}

	// Token: 0x06008037 RID: 32823 RVA: 0x002744BD File Offset: 0x002726BD
	private void OnToggleClick(int gridIndex)
	{
		this.LoopScroll.SelectGridProxy(gridIndex, false);
		this.OnPhantomSelectChange();
	}

	// Token: 0x06008038 RID: 32824 RVA: 0x002744D2 File Offset: 0x002726D2
	private bool CanToggleChange(int gridIndex)
	{
		LoopScrollView<CalabashCollectGridItem, CalabashDevelopRewardData> loopScroll = this.LoopScroll;
		return loopScroll == null || loopScroll.GetSelectedGridIndex() != gridIndex;
	}

	// Token: 0x06008039 RID: 32825 RVA: 0x002744EC File Offset: 0x002726EC
	[NullableContext(1)]
	private void UpdateDataList(List<CalabashDevelopRewardData> list, bool isOutSideChange, EFilterSortType operationType)
	{
		this.DataList = list.ToArray();
		this.LoopScroll.RefreshByData(this.DataList, false, new Action(this.AfterLoopScrollRefresh), true);
		if (this.DataList.Length == 0)
		{
			return;
		}
		if (operationType == EFilterSortType.Sort)
		{
			this.CurrentSelectedMonsterId = this.DataList[0].DevelopRewardData.MonsterId;
		}
	}

	// Token: 0x0600803A RID: 32826 RVA: 0x00274550 File Offset: 0x00272750
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

	// Token: 0x0600803B RID: 32827 RVA: 0x00274638 File Offset: 0x00272838
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

	// Token: 0x0600803C RID: 32828 RVA: 0x002746E7 File Offset: 0x002728E7
	private void EnterInternalView()
	{
		this.EnterInternalView(false);
	}

	// Token: 0x0600803D RID: 32829 RVA: 0x002746F0 File Offset: 0x002728F0
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
		UiCamera orCreateCamera = UiCameraModel.Instance.GetOrCreateCamera();
		UiCameraBlendComponent blendComponent = orCreateCamera.GetUiCameraComponent<UiCameraBlendComponent>();
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.CurrentSelectedMonsterId);
		MonsterBodyTypeConfig? bodyTypeConfig = MonsterInfoConfig.Instance.GetMonsterBodyTypeConfig(calabashDevelopRewardByMonsterId.Value.MonsterBodyType);
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
		EventSystem.Instance.Emit(EEventName.CalabashEnterInternalView);
	}

	// Token: 0x0600803E RID: 32830 RVA: 0x002747EB File Offset: 0x002729EB
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

	// Token: 0x0600803F RID: 32831 RVA: 0x0027480B File Offset: 0x00272A0B
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

	// Token: 0x06008040 RID: 32832 RVA: 0x00274838 File Offset: 0x00272A38
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
		UiCamera orCreateCamera = UiCameraModel.Instance.GetOrCreateCamera();
		UiCameraLogicComponent logicComponent = orCreateCamera.GetUiCameraComponent<UiCameraLogicComponent>();
		UiCameraBlendComponent blendComponent = orCreateCamera.GetUiCameraComponent<UiCameraBlendComponent>();
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(this.CurrentSelectedMonsterId);
		MonsterBodyTypeConfig? bodyTypeConfig = MonsterInfoConfig.Instance.GetMonsterBodyTypeConfig(calabashDevelopRewardByMonsterId.Value.MonsterBodyType);
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
		EventSystem.Instance.Emit(EEventName.CalabashQuitInternalView);
	}

	// Token: 0x06008041 RID: 32833 RVA: 0x00274940 File Offset: 0x00272B40
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

	// Token: 0x06008042 RID: 32834 RVA: 0x002749F8 File Offset: 0x00272BF8
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

	// Token: 0x06008043 RID: 32835 RVA: 0x00274B20 File Offset: 0x00272D20
	private void OnLoadFinish(int monsterId)
	{
		UiCameraLogicComponent uiCameraComponent = UiCameraModel.Instance.GetOrCreateCamera().GetUiCameraComponent<UiCameraLogicComponent>();
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
		UiCameraModel.Instance.PushCameraHandleByHandleName(calabashDevelopRewardByMonsterId.Value.HandBookCamera, false, false, "1001", false, null);
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

	// Token: 0x06008044 RID: 32836 RVA: 0x00274BF8 File Offset: 0x00272DF8
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

	// Token: 0x06008045 RID: 32837 RVA: 0x00274C5C File Offset: 0x00272E5C
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

	// Token: 0x06008046 RID: 32838 RVA: 0x00274CB2 File Offset: 0x00272EB2
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

	// Token: 0x06008047 RID: 32839 RVA: 0x00274CD3 File Offset: 0x00272ED3
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

	// Token: 0x04004ECC RID: 20172
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<CalabashDevelopRewardData> FilterEntrance;

	// Token: 0x04004ECD RID: 20173
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<CalabashDevelopRewardData> SortEntrance;

	// Token: 0x04004ECE RID: 20174
	private CalabashCollectDetailItem DetailItem;

	// Token: 0x04004ECF RID: 20175
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<CalabashCollectGridItem, CalabashDevelopRewardData> LoopScroll;

	// Token: 0x04004ED0 RID: 20176
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CalabashDevelopRewardData[] DataList;

	// Token: 0x04004ED1 RID: 20177
	private VisionCameraInputItem VisionCameraInputItem;

	// Token: 0x04004ED2 RID: 20178
	private RoleModelLoadingItem LoadingItem;

	// Token: 0x04004ED3 RID: 20179
	private int WaitToSelectMonsterId;

	// Token: 0x04004ED4 RID: 20180
	private int CurrentSelectedMonsterId;

	// Token: 0x04004ED5 RID: 20181
	private int BpHandle = -1;

	// Token: 0x04004ED6 RID: 20182
	private int MeshStreamTaskId = -1;

	// Token: 0x04004ED7 RID: 20183
	private bool IsInternal;

	// Token: 0x04004ED8 RID: 20184
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04004ED9 RID: 20185
	private int ShowMonsterId;

	// Token: 0x04004EDA RID: 20186
	private bool IsOnlyShow;

	// Token: 0x02006EB2 RID: 28338
	[NullableContext(0)]
	private enum ECompDefine
	{
		// Token: 0x0402430B RID: 148235
		LoopScroll,
		// Token: 0x0402430C RID: 148236
		LoopScrollItem,
		// Token: 0x0402430D RID: 148237
		FilterEntrance,
		// Token: 0x0402430E RID: 148238
		SortEntrance,
		// Token: 0x0402430F RID: 148239
		DetailItem,
		// Token: 0x04024310 RID: 148240
		ScheduleText,
		// Token: 0x04024311 RID: 148241
		EmptyItem,
		// Token: 0x04024312 RID: 148242
		DragItem,
		// Token: 0x04024313 RID: 148243
		LeftItem,
		// Token: 0x04024314 RID: 148244
		BackButton,
		// Token: 0x04024315 RID: 148245
		EmptySkinItem
	}
}
