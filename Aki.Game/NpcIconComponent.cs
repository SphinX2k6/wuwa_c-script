using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Map.Marks;
using CSharpScript.Game.Ui;
using CSharpScript.Game.World.Define;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022D5 RID: 8917
[NullableContext(2)]
[Nullable(0)]
public class NpcIconComponent : IGameBudgetManagedObject
{
	// Token: 0x1700164A RID: 5706
	// (get) Token: 0x06011822 RID: 71714 RVA: 0x0044AD73 File Offset: 0x00448F73
	// (set) Token: 0x06011823 RID: 71715 RVA: 0x0044AD7B File Offset: 0x00448F7B
	private bool IsSelfVisible
	{
		get
		{
			return this.IsSelfVisibleInner;
		}
		set
		{
			this.IsSelfVisibleInner = value;
		}
	}

	// Token: 0x1700164B RID: 5707
	// (get) Token: 0x06011824 RID: 71716 RVA: 0x0044AD84 File Offset: 0x00448F84
	// (set) Token: 0x06011825 RID: 71717 RVA: 0x0044AD8C File Offset: 0x00448F8C
	private bool IsNpcVisible
	{
		get
		{
			return this.IsNpcVisibleInner;
		}
		set
		{
			this.IsNpcVisibleInner = value;
		}
	}

	// Token: 0x1700164C RID: 5708
	// (get) Token: 0x06011826 RID: 71718 RVA: 0x0044AD95 File Offset: 0x00448F95
	private bool IsVisible
	{
		get
		{
			return this.IsSelfVisible || this.IsNpcVisible;
		}
	}

	// Token: 0x06011827 RID: 71719 RVA: 0x0044ADA8 File Offset: 0x00448FA8
	[NullableContext(1)]
	public NpcIconComponent(INpcIconFunction data)
	{
		this.Data = data;
		this.MaxShowRangeDisSquared = (double)NpcIconConfig.Instance.NpcIconHeadInfoLimitMaxDistanceSquared;
	}

	// Token: 0x06011828 RID: 71720 RVA: 0x0044AE08 File Offset: 0x00449008
	public unsafe void RegisterTick()
	{
		if (this.GameBudgetManagedTokenInternal != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HudUnit;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "NpcIconComponent RegisterTick: 重复注册Tick";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcIconComponent", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", this.Path);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.UnregisterTick();
		}
		if (!this.GameBudgetGCHandle.IsAllocated)
		{
			this.GameBudgetGCHandle = GCHandle.Alloc(this, GCHandleType.Normal);
		}
		TsGameBudgetGroupConfigCache tsHUDTickConfig = GameBudgetAllocatorConfigCreator.Instance.TsHUDTickConfig;
		GameBudgetInterfaceController instance2 = GameBudgetInterfaceController.Instance;
		FName groupName = tsHUDTickConfig.GroupName;
		ESignificanceGroup significanceGroup = tsHUDTickConfig.SignificanceGroup;
		UiPoolActor uiPoolActor = this.UiPoolActor;
		this.GameBudgetManagedTokenInternal = new uint?(instance2.RegisterTick(groupName, significanceGroup, this, (uiPoolActor != null) ? uiPoolActor.Actor : null, true, true, true, true));
	}

	// Token: 0x06011829 RID: 71721 RVA: 0x0044AEEA File Offset: 0x004490EA
	public void UnregisterTick()
	{
		if (this.GameBudgetManagedTokenInternal != null)
		{
			GameBudgetInterfaceController.Instance.UnregisterTick(this);
			this.GameBudgetManagedTokenInternal = null;
		}
		if (this.GameBudgetGCHandle.IsAllocated)
		{
			this.GameBudgetGCHandle.Free();
		}
	}

	// Token: 0x0601182A RID: 71722 RVA: 0x0044AF28 File Offset: 0x00449128
	public void ScheduledTick(float deltaSeconds, int deltaFrames, float distance)
	{
	}

	// Token: 0x1700164D RID: 5709
	// (get) Token: 0x0601182B RID: 71723 RVA: 0x0044AF2A File Offset: 0x0044912A
	public bool HasScheduledAfterTick
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0601182C RID: 71724 RVA: 0x0044AF2D File Offset: 0x0044912D
	public void ScheduledAfterTick(float deltaSeconds, int deltaFrames, float distance)
	{
		this.Tick(deltaSeconds * 1000f, false);
	}

	// Token: 0x1700164E RID: 5710
	// (get) Token: 0x0601182D RID: 71725 RVA: 0x0044AF3D File Offset: 0x0044913D
	public bool HasOnEnabledChange
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0601182E RID: 71726 RVA: 0x0044AF40 File Offset: 0x00449140
	public void OnEnabledChange(bool enable, float distance)
	{
		this.SetRootItemState(enable);
	}

	// Token: 0x0601182F RID: 71727 RVA: 0x0044AF49 File Offset: 0x00449149
	public void SetInteractionSpotVisible(bool isVisible)
	{
		this.IsInteractionSpotVisible = isVisible;
	}

	// Token: 0x1700164F RID: 5711
	// (get) Token: 0x06011830 RID: 71728 RVA: 0x0044AF52 File Offset: 0x00449152
	public bool HasOnWasRecentlyRenderedOnScreenChange
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06011831 RID: 71729 RVA: 0x0044AF55 File Offset: 0x00449155
	public void OnWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
	{
		this.IsSelfVisible = wasRecentlyRenderedOnScreen;
	}

	// Token: 0x06011832 RID: 71730 RVA: 0x0044AF5E File Offset: 0x0044915E
	public GCHandle GetGCHandle()
	{
		return this.GameBudgetGCHandle;
	}

	// Token: 0x06011833 RID: 71731 RVA: 0x0044AF66 File Offset: 0x00449166
	public void OnNpcWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
	{
		this.IsNpcVisible = wasRecentlyRenderedOnScreen;
	}

	// Token: 0x06011834 RID: 71732 RVA: 0x0044AF6F File Offset: 0x0044916F
	public void SetupCheckRange(double maxDisSquared)
	{
		this.MaxShowRangeDisSquared = maxDisSquared;
	}

	// Token: 0x06011835 RID: 71733 RVA: 0x0044AF78 File Offset: 0x00449178
	[NullableContext(0)]
	public UniTask<bool> AddNpcIconAsync()
	{
		NpcIconComponent.<AddNpcIconAsync>d__51 <AddNpcIconAsync>d__;
		<AddNpcIconAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<AddNpcIconAsync>d__.<>4__this = this;
		<AddNpcIconAsync>d__.<>1__state = -1;
		<AddNpcIconAsync>d__.<>t__builder.Start<NpcIconComponent.<AddNpcIconAsync>d__51>(ref <AddNpcIconAsync>d__);
		return <AddNpcIconAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011836 RID: 71734 RVA: 0x0044AFBC File Offset: 0x004491BC
	[NullableContext(0)]
	protected UniTask<bool> CreateNpcIcon()
	{
		NpcIconComponent.<CreateNpcIcon>d__52 <CreateNpcIcon>d__;
		<CreateNpcIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<CreateNpcIcon>d__.<>4__this = this;
		<CreateNpcIcon>d__.<>1__state = -1;
		<CreateNpcIcon>d__.<>t__builder.Start<NpcIconComponent.<CreateNpcIcon>d__52>(ref <CreateNpcIcon>d__);
		return <CreateNpcIcon>d__.<>t__builder.Task;
	}

	// Token: 0x06011837 RID: 71735 RVA: 0x0044AFFF File Offset: 0x004491FF
	[NullableContext(1)]
	public void RegisterNpcIconCreateCallback(Action callback)
	{
		this.NpcIconCreateCallback = callback;
	}

	// Token: 0x06011838 RID: 71736 RVA: 0x0044B008 File Offset: 0x00449208
	public void SetCharacterIconLocation()
	{
		UPrimitiveComponent attachToMeshComponent = this.Data.GetAttachToMeshComponent();
		if (attachToMeshComponent is UStaticMeshComponent)
		{
			Vector tmpVector = this.TmpVector;
			FVectorDouble fvectorDouble = attachToMeshComponent.D_K2_GetComponentLocation();
			tmpVector.FromUeVector(fvectorDouble);
		}
		else
		{
			this.Data.GetAttachToLocation(this.TmpVector);
		}
		double addOffsetZ = this.Data.GetAddOffsetZ();
		double offsetZ = (double)(this.Data.IsShowPlayerInfo() ? NpcIconConfig.Instance.GetPlayerInfoIconLocationOffsetZ() : NpcIconConfig.Instance.GetNpcIconLocationOffsetZ()) + addOffsetZ;
		this.HeadView.InitItemLocation(this.TmpVector.ToUeVector(false), offsetZ);
	}

	// Token: 0x06011839 RID: 71737 RVA: 0x0044B09B File Offset: 0x0044929B
	public void SetCharacterName(string headName)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNpcName(headName);
	}

	// Token: 0x0601183A RID: 71738 RVA: 0x0044B0AE File Offset: 0x004492AE
	public void SetCharacterSecondName(string name)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNpcSecondName(name);
	}

	// Token: 0x0601183B RID: 71739 RVA: 0x0044B0C1 File Offset: 0x004492C1
	public void SetCharacterFunctionIcon(string path)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetFunctionIcon(path, null);
	}

	// Token: 0x0601183C RID: 71740 RVA: 0x0044B0D5 File Offset: 0x004492D5
	public void SetNpcQuest(string path)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNpcQuestIcon(path);
	}

	// Token: 0x0601183D RID: 71741 RVA: 0x0044B0E8 File Offset: 0x004492E8
	public void SetHeadItemState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetHeadItemState(bState);
	}

	// Token: 0x0601183E RID: 71742 RVA: 0x0044B0FB File Offset: 0x004492FB
	public void SetQuestTrackCellState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetQuestTrackCellState(bState);
	}

	// Token: 0x0601183F RID: 71743 RVA: 0x0044B10E File Offset: 0x0044930E
	public void SetRootItemState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetRootItemState(bState, false);
	}

	// Token: 0x06011840 RID: 71744 RVA: 0x0044B122 File Offset: 0x00449322
	public bool GetRootItemState()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetRootItemState();
	}

	// Token: 0x06011841 RID: 71745 RVA: 0x0044B135 File Offset: 0x00449335
	public void SetHeadInfoNameState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetHeadInfoNameState(bState);
	}

	// Token: 0x06011842 RID: 71746 RVA: 0x0044B148 File Offset: 0x00449348
	public bool GetHeadInfoNameState()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetHeadInfoNameState();
	}

	// Token: 0x06011843 RID: 71747 RVA: 0x0044B15B File Offset: 0x0044935B
	public void SetQuestInfoState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNpcQuestIconState(bState);
	}

	// Token: 0x06011844 RID: 71748 RVA: 0x0044B16E File Offset: 0x0044936E
	public void SetQuestTrackEffectState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetTrackEffectState(bState);
	}

	// Token: 0x06011845 RID: 71749 RVA: 0x0044B181 File Offset: 0x00449381
	public void SetEntityPbDataId(int id)
	{
		this.EntityPbDataId = id;
	}

	// Token: 0x06011846 RID: 71750 RVA: 0x0044B18A File Offset: 0x0044938A
	[NullableContext(1)]
	public void SetDialogueText(string text, float removeSeconds = -1f, bool redDot = false)
	{
		this.RemoveMillSeconds = removeSeconds * 1000f;
		NpcIconComponentView headView = this.HeadView;
		if (headView != null)
		{
			headView.SetDialogueActive(true, redDot, false);
		}
		NpcIconComponentView headView2 = this.HeadView;
		if (headView2 != null)
		{
			headView2.SetDialogueText(text);
		}
		if (redDot)
		{
			this.SetTargetTracking(true);
		}
	}

	// Token: 0x06011847 RID: 71751 RVA: 0x0044B1C9 File Offset: 0x004493C9
	public void HideDialogueText()
	{
		this.RemoveMillSeconds = -1f;
		NpcIconComponentView headView = this.HeadView;
		if (headView != null)
		{
			headView.SetDialogueActive(false, false, false);
		}
		this.SetTargetTracking(false);
	}

	// Token: 0x06011848 RID: 71752 RVA: 0x0044B1F1 File Offset: 0x004493F1
	public void UpdateDialogWorldScale()
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetDialogWorldScale3D(this.Data.GetDialogWorldScale3D());
	}

	// Token: 0x06011849 RID: 71753 RVA: 0x0044B20E File Offset: 0x0044940E
	public bool IsDialogueTextActive()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetDialogueActive();
	}

	// Token: 0x0601184A RID: 71754 RVA: 0x0044B221 File Offset: 0x00449421
	public bool IsHeadIconActive()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetHeadIconActive();
	}

	// Token: 0x0601184B RID: 71755 RVA: 0x0044B234 File Offset: 0x00449434
	public bool IsHeadItemActive()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetHeadItemState();
	}

	// Token: 0x0601184C RID: 71756 RVA: 0x0044B248 File Offset: 0x00449448
	private void SetTargetTracking(bool active)
	{
		ITrackData trackData = TrackModel.Instance.IsTargetTracking(this.EntityPbDataId);
		if (trackData != null && this.QuestMarkOccupied)
		{
			TrackController.Instance.SetTrackMarkOccupied(ETrackSource.Quest, trackData.Id, active);
			this.QuestMarkOccupied = active;
		}
	}

	// Token: 0x0601184D RID: 71757 RVA: 0x0044B28F File Offset: 0x0044948F
	protected void TickDialogueText(float deltaTime)
	{
		if (this.RemoveMillSeconds < 0f)
		{
			return;
		}
		this.RemoveMillSeconds -= deltaTime;
		if (this.RemoveMillSeconds <= 0f)
		{
			this.HideDialogueText();
		}
	}

	// Token: 0x0601184E RID: 71758 RVA: 0x0044B2C0 File Offset: 0x004494C0
	public void Tick(float deltaTime, bool isForce = false)
	{
		if (!this.Data.CanTick(deltaTime))
		{
			return;
		}
		if (!isForce && !this.IsVisible)
		{
			return;
		}
		this.RefreshHeadStateFollow();
		this.UpdateHeadInfoRotationAndScale();
		this.TickDialogueText(deltaTime);
		if (this.IsFollowingHeadState)
		{
			this.FollowHeadStateHook();
		}
	}

	// Token: 0x0601184F RID: 71759 RVA: 0x0044B300 File Offset: 0x00449500
	private void RefreshHeadStateFollow()
	{
		bool isFollowingHeadState = this.IsFollowingHeadState;
		if (this.Data.TryGetHeadStateFollowData(this.HeadStateFollowData))
		{
			this.IsFollowingHeadState = true;
		}
		else
		{
			this.IsFollowingHeadState = false;
		}
		if (isFollowingHeadState && !this.IsFollowingHeadState)
		{
			this.SetCharacterIconLocation();
			this.DistanceSquare = -1f;
		}
	}

	// Token: 0x06011850 RID: 71760 RVA: 0x0044B351 File Offset: 0x00449551
	private void FollowHeadStateHook()
	{
		this.HeadView.InitItemLocation(this.HeadStateFollowData.Location.ToUeVector(false), 60.0);
		this.HeadView.SetHeadWorldScale3D(this.HeadStateFollowData.Scale);
	}

	// Token: 0x06011851 RID: 71761 RVA: 0x0044B390 File Offset: 0x00449590
	private void UpdateHeadInfoRotationAndScale()
	{
		double num = Vector.DistSquared(CameraModel.Instance.MainModel.CameraLocation, this.Data.GetSelfLocation());
		this.TickHeadInfo((float)num);
		this.UpdateCharacterIconRotation();
	}

	// Token: 0x06011852 RID: 71762 RVA: 0x0044B3CC File Offset: 0x004495CC
	private void UpdateCharacterIconRotation()
	{
		if (this.HeadView != null)
		{
			Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
			this.HeadView.UpdateRotation(cameraRotator.Yaw, cameraRotator.Pitch);
		}
	}

	// Token: 0x06011853 RID: 71763 RVA: 0x0044B408 File Offset: 0x00449608
	private void TickHeadItem(float cameraDistanceSquare)
	{
		bool flag = this.Data.IsInHeadItemShowRange((double)cameraDistanceSquare, this.MaxShowRangeDisSquared, (double)NpcIconConfig.Instance.NpcIconHeadInfoLimitMinDistanceSquared);
		flag = (flag && !this.IsInteractionSpotVisible);
		this.SetHeadItemState(flag);
		this.TickQuestTrackCellState();
		if (this.RemoveMillSeconds > 0f && (this.DistanceSquare < (float)NpcIconConfig.Instance.NpcIconHeadInfoLimitMinDistanceSquared || (double)this.DistanceSquare > this.MaxShowRangeDisSquared))
		{
			this.HideDialogueText();
		}
		if (flag)
		{
			this.SetHeadWorldScale3D(cameraDistanceSquare);
		}
	}

	// Token: 0x06011854 RID: 71764 RVA: 0x0044B490 File Offset: 0x00449690
	private void TickQuestTrackCellState()
	{
		if (this.IsInteractionSpotVisible)
		{
			this.SetQuestTrackCellState(true);
			return;
		}
		ITrackData trackData = TrackModel.Instance.IsTargetTracking(this.EntityPbDataId);
		bool flag = MarkItemUtil.CanShowTrackMark(trackData);
		bool flag2 = trackData != null && trackData.TrackSource == ETrackSource.Quest;
		this.SetQuestTrackCellState(flag2);
		if (!flag2 && this.HeadView != null)
		{
			this.HeadView.ForceHideDialog = flag;
			this.HeadView.ForceHideRootItem = flag;
		}
	}

	// Token: 0x06011855 RID: 71765 RVA: 0x0044B504 File Offset: 0x00449704
	private bool IsInHeadItemNameShowRange(float distance)
	{
		int npcIconHeadInfoNameLimitDistance = NpcIconConfig.Instance.GetNpcIconHeadInfoNameLimitDistance();
		return distance <= (float)(npcIconHeadInfoNameLimitDistance * npcIconHeadInfoNameLimitDistance);
	}

	// Token: 0x06011856 RID: 71766 RVA: 0x0044B528 File Offset: 0x00449728
	private bool IsInPlayerInfoNameShowRange(float distance)
	{
		int playerInfoNameLimitDistance = NpcIconConfig.Instance.GetPlayerInfoNameLimitDistance();
		return distance <= (float)(playerInfoNameLimitDistance * playerInfoNameLimitDistance);
	}

	// Token: 0x06011857 RID: 71767 RVA: 0x0044B54C File Offset: 0x0044974C
	private bool IsInPlayerInfoIconShowRange(float distance)
	{
		int playerInfoIconLimitDistance = NpcIconConfig.Instance.GetPlayerInfoIconLimitDistance();
		return distance < (float)(playerInfoIconLimitDistance * playerInfoIconLimitDistance);
	}

	// Token: 0x06011858 RID: 71768 RVA: 0x0044B56C File Offset: 0x0044976C
	private void TickHeadItemName(float cameraDistanceSquare)
	{
		if (this.Data.IsShowPlayerInfo())
		{
			bool nameTextState = this.IsInPlayerInfoNameShowRange(cameraDistanceSquare);
			bool playerInfoIconState = this.IsInPlayerInfoIconShowRange(cameraDistanceSquare);
			this.SetNameTextState(nameTextState);
			this.SetPlayerInfoIconState(playerInfoIconState);
			this.SetHeadInfoNameState(true);
			return;
		}
		if (this.Data.IsShowNameInfo())
		{
			bool flag = this.IsInHeadItemNameShowRange(cameraDistanceSquare);
			bool headInfoNameState = this.GetHeadInfoNameState();
			if (flag != headInfoNameState)
			{
				if (flag)
				{
					if (!this.PendingShowHeadInfoName)
					{
						this.PendingShowHeadInfoName = true;
						TickProcessSystem.Instance.RegisterOnceTickProcess(ETickingGroup.TG_PrePhysics, false, delegate(float deltaTime)
						{
							if (this.PendingShowHeadInfoName)
							{
								this.PendingShowHeadInfoName = false;
								this.SetHeadInfoNameState(true);
							}
						});
						return;
					}
				}
				else
				{
					this.SetHeadInfoNameState(flag);
				}
			}
		}
	}

	// Token: 0x06011859 RID: 71769 RVA: 0x0044B5FF File Offset: 0x004497FF
	private bool IsInHeadQuestShowRange(float distance)
	{
		return this.MaxShowQuestDisSquared == 0f || distance <= this.MaxShowQuestDisSquared * this.MaxShowQuestDisSquared;
	}

	// Token: 0x0601185A RID: 71770 RVA: 0x0044B623 File Offset: 0x00449823
	private bool IsInTrackEffectShowRange(float distance)
	{
		return this.MaxShowTrackEffectDisSquared == 0f || distance <= this.MaxShowTrackEffectDisSquared * this.MaxShowTrackEffectDisSquared;
	}

	// Token: 0x0601185B RID: 71771 RVA: 0x0044B648 File Offset: 0x00449848
	private void TickHeadQuestInfo(float cameraDistanceSquare)
	{
		if (this.Data.IsShowQuestInfo())
		{
			bool questInfoState = this.IsInHeadQuestShowRange(cameraDistanceSquare);
			this.SetQuestInfoState(questInfoState);
			bool questTrackEffectState = this.IsInTrackEffectShowRange(cameraDistanceSquare);
			this.SetQuestTrackEffectState(questTrackEffectState);
		}
	}

	// Token: 0x0601185C RID: 71772 RVA: 0x0044B680 File Offset: 0x00449880
	private void TickHeadInfo(float cameraDistanceSquare)
	{
		if (this.DistanceSquare == cameraDistanceSquare)
		{
			return;
		}
		this.DistanceSquare = cameraDistanceSquare;
		this.TickHeadItem(cameraDistanceSquare);
		this.TickHeadItemName(cameraDistanceSquare);
		this.TickHeadQuestInfo(cameraDistanceSquare);
	}

	// Token: 0x0601185D RID: 71773 RVA: 0x0044B6A8 File Offset: 0x004498A8
	private void SetHeadWorldScale3D(float cameraDistance)
	{
		float headStateScaleValue = NpcIconConfig.Instance.GetHeadStateScaleValue(cameraDistance);
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetHeadWorldScale3D(headStateScaleValue);
	}

	// Token: 0x0601185E RID: 71774 RVA: 0x0044B6D2 File Offset: 0x004498D2
	public void SetPlayerInfoIcon(string path)
	{
		this.IsPlayerInfoIconReady = false;
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetPlayerInfoIcon(path, delegate(bool result)
		{
			this.IsPlayerInfoIconReady = result;
		});
	}

	// Token: 0x0601185F RID: 71775 RVA: 0x0044B6F8 File Offset: 0x004498F8
	public void SetPlayerInfoIconState(bool bState)
	{
		if (!this.IsPlayerInfoIconReady)
		{
			return;
		}
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetPlayerInfoItemState(bState);
	}

	// Token: 0x06011860 RID: 71776 RVA: 0x0044B714 File Offset: 0x00449914
	public void SetNameTextState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNameTextItemState(bState);
	}

	// Token: 0x06011861 RID: 71777 RVA: 0x0044B728 File Offset: 0x00449928
	public void Destroy()
	{
		this.IsDestroy = true;
		bool flag = false;
		if (this.HeadView != null)
		{
			flag = true;
			UiModel.Instance.RemoveNpcIconViewUnit(this.HeadView);
			this.HeadView.Destroy(null);
			this.HeadView = null;
		}
		if (this.UiPoolActor != null)
		{
			AActor actor = this.UiPoolActor.Actor;
			if (actor != null)
			{
				actor.DetachRootComponentFromParent(true);
			}
			if (!flag)
			{
				UiActorPool.Instance.RecycleAsync(this.UiPoolActor, this.Path);
			}
			this.UiPoolActor = null;
			this.Data = null;
		}
		this.UnregisterTick();
	}

	// Token: 0x040084E2 RID: 34018
	private const double NAME_ABOVE_HEADSTATE_OFFSET = 60.0;

	// Token: 0x040084E3 RID: 34019
	private UiPoolActor UiPoolActor;

	// Token: 0x040084E4 RID: 34020
	[Nullable(1)]
	private string Path = "";

	// Token: 0x040084E5 RID: 34021
	protected NpcIconComponentView HeadView;

	// Token: 0x040084E6 RID: 34022
	private INpcIconFunction Data;

	// Token: 0x040084E7 RID: 34023
	private float RemoveMillSeconds = -1f;

	// Token: 0x040084E8 RID: 34024
	private double MaxShowRangeDisSquared;

	// Token: 0x040084E9 RID: 34025
	public float MaxShowQuestDisSquared;

	// Token: 0x040084EA RID: 34026
	private readonly float MaxShowTrackEffectDisSquared;

	// Token: 0x040084EB RID: 34027
	private UniTaskCompletionSource<bool> CustomPromise;

	// Token: 0x040084EC RID: 34028
	private Action ReCreateHeadView;

	// Token: 0x040084ED RID: 34029
	private float DistanceSquare;

	// Token: 0x040084EE RID: 34030
	private bool PendingShowHeadInfoName;

	// Token: 0x040084EF RID: 34031
	private bool IsDestroy;

	// Token: 0x040084F0 RID: 34032
	private uint? GameBudgetManagedTokenInternal;

	// Token: 0x040084F1 RID: 34033
	private int EntityPbDataId;

	// Token: 0x040084F2 RID: 34034
	private bool QuestMarkOccupied;

	// Token: 0x040084F3 RID: 34035
	private bool IsPlayerInfoIconReady;

	// Token: 0x040084F4 RID: 34036
	[Nullable(1)]
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x040084F5 RID: 34037
	[Nullable(1)]
	private readonly HeadStateFollowData HeadStateFollowData = new HeadStateFollowData();

	// Token: 0x040084F6 RID: 34038
	private bool IsFollowingHeadState;

	// Token: 0x040084F7 RID: 34039
	private bool IsSelfVisibleInner;

	// Token: 0x040084F8 RID: 34040
	private bool IsNpcVisibleInner = true;

	// Token: 0x040084F9 RID: 34041
	private Action NpcIconCreateCallback;

	// Token: 0x040084FA RID: 34042
	private bool IsInteractionSpotVisible;

	// Token: 0x040084FB RID: 34043
	private GCHandle GameBudgetGCHandle;
}
