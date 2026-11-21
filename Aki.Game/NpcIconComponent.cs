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

// Token: 0x020017B9 RID: 6073
[NullableContext(2)]
[Nullable(0)]
public class NpcIconComponent : IGameBudgetManagedObject
{
	// Token: 0x17001681 RID: 5761
	// (get) Token: 0x0600ECB9 RID: 60601 RVA: 0x00457A7B File Offset: 0x00455C7B
	// (set) Token: 0x0600ECBA RID: 60602 RVA: 0x00457A83 File Offset: 0x00455C83
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

	// Token: 0x17001682 RID: 5762
	// (get) Token: 0x0600ECBB RID: 60603 RVA: 0x00457A8C File Offset: 0x00455C8C
	// (set) Token: 0x0600ECBC RID: 60604 RVA: 0x00457A94 File Offset: 0x00455C94
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

	// Token: 0x17001683 RID: 5763
	// (get) Token: 0x0600ECBD RID: 60605 RVA: 0x00457A9D File Offset: 0x00455C9D
	private bool IsVisible
	{
		get
		{
			return this.IsSelfVisible || this.IsNpcVisible;
		}
	}

	// Token: 0x0600ECBE RID: 60606 RVA: 0x00457AB0 File Offset: 0x00455CB0
	[NullableContext(1)]
	public NpcIconComponent(INpcIconFunction data)
	{
		this.Data = data;
		this.MaxShowRangeDisSquared = (double)NpcIconConfig.Instance.NpcIconHeadInfoLimitMaxDistanceSquared;
	}

	// Token: 0x0600ECBF RID: 60607 RVA: 0x00457B10 File Offset: 0x00455D10
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

	// Token: 0x0600ECC0 RID: 60608 RVA: 0x00457BF2 File Offset: 0x00455DF2
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

	// Token: 0x0600ECC1 RID: 60609 RVA: 0x00457C30 File Offset: 0x00455E30
	public void ScheduledTick(float deltaSeconds, int deltaFrames, float distance)
	{
	}

	// Token: 0x17001684 RID: 5764
	// (get) Token: 0x0600ECC2 RID: 60610 RVA: 0x00457C32 File Offset: 0x00455E32
	public bool HasScheduledAfterTick
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600ECC3 RID: 60611 RVA: 0x00457C35 File Offset: 0x00455E35
	public void ScheduledAfterTick(float deltaSeconds, int deltaFrames, float distance)
	{
		this.Tick(deltaSeconds * 1000f, false);
	}

	// Token: 0x17001685 RID: 5765
	// (get) Token: 0x0600ECC4 RID: 60612 RVA: 0x00457C45 File Offset: 0x00455E45
	public bool HasOnEnabledChange
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600ECC5 RID: 60613 RVA: 0x00457C48 File Offset: 0x00455E48
	public void OnEnabledChange(bool enable, float distance)
	{
		this.SetRootItemState(enable);
	}

	// Token: 0x0600ECC6 RID: 60614 RVA: 0x00457C51 File Offset: 0x00455E51
	public void SetInteractionSpotVisible(bool isVisible)
	{
		this.IsInteractionSpotVisible = isVisible;
	}

	// Token: 0x17001686 RID: 5766
	// (get) Token: 0x0600ECC7 RID: 60615 RVA: 0x00457C5A File Offset: 0x00455E5A
	public bool HasOnWasRecentlyRenderedOnScreenChange
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600ECC8 RID: 60616 RVA: 0x00457C5D File Offset: 0x00455E5D
	public void OnWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
	{
		this.IsSelfVisible = wasRecentlyRenderedOnScreen;
	}

	// Token: 0x0600ECC9 RID: 60617 RVA: 0x00457C66 File Offset: 0x00455E66
	public GCHandle GetGCHandle()
	{
		return this.GameBudgetGCHandle;
	}

	// Token: 0x0600ECCA RID: 60618 RVA: 0x00457C6E File Offset: 0x00455E6E
	public void OnNpcWasRecentlyRenderedOnScreenChange(bool wasRecentlyRenderedOnScreen)
	{
		this.IsNpcVisible = wasRecentlyRenderedOnScreen;
	}

	// Token: 0x0600ECCB RID: 60619 RVA: 0x00457C77 File Offset: 0x00455E77
	public void SetupCheckRange(double maxDisSquared)
	{
		this.MaxShowRangeDisSquared = maxDisSquared;
	}

	// Token: 0x0600ECCC RID: 60620 RVA: 0x00457C80 File Offset: 0x00455E80
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

	// Token: 0x0600ECCD RID: 60621 RVA: 0x00457CC4 File Offset: 0x00455EC4
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

	// Token: 0x0600ECCE RID: 60622 RVA: 0x00457D07 File Offset: 0x00455F07
	[NullableContext(1)]
	public void RegisterNpcIconCreateCallback(Action callback)
	{
		this.NpcIconCreateCallback = callback;
	}

	// Token: 0x0600ECCF RID: 60623 RVA: 0x00457D10 File Offset: 0x00455F10
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

	// Token: 0x0600ECD0 RID: 60624 RVA: 0x00457DA3 File Offset: 0x00455FA3
	public void SetCharacterName(string headName)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNpcName(headName);
	}

	// Token: 0x0600ECD1 RID: 60625 RVA: 0x00457DB6 File Offset: 0x00455FB6
	public void SetCharacterSecondName(string name)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNpcSecondName(name);
	}

	// Token: 0x0600ECD2 RID: 60626 RVA: 0x00457DC9 File Offset: 0x00455FC9
	public void SetCharacterFunctionIcon(string path)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetFunctionIcon(path, null);
	}

	// Token: 0x0600ECD3 RID: 60627 RVA: 0x00457DDD File Offset: 0x00455FDD
	public void SetNpcQuest(string path)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNpcQuestIcon(path);
	}

	// Token: 0x0600ECD4 RID: 60628 RVA: 0x00457DF0 File Offset: 0x00455FF0
	public void SetHeadItemState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetHeadItemState(bState);
	}

	// Token: 0x0600ECD5 RID: 60629 RVA: 0x00457E03 File Offset: 0x00456003
	public void SetQuestTrackCellState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetQuestTrackCellState(bState);
	}

	// Token: 0x0600ECD6 RID: 60630 RVA: 0x00457E16 File Offset: 0x00456016
	public void SetRootItemState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetRootItemState(bState, false);
	}

	// Token: 0x0600ECD7 RID: 60631 RVA: 0x00457E2A File Offset: 0x0045602A
	public bool GetRootItemState()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetRootItemState();
	}

	// Token: 0x0600ECD8 RID: 60632 RVA: 0x00457E3D File Offset: 0x0045603D
	public void SetHeadInfoNameState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetHeadInfoNameState(bState);
	}

	// Token: 0x0600ECD9 RID: 60633 RVA: 0x00457E50 File Offset: 0x00456050
	public bool GetHeadInfoNameState()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetHeadInfoNameState();
	}

	// Token: 0x0600ECDA RID: 60634 RVA: 0x00457E63 File Offset: 0x00456063
	public void SetQuestInfoState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNpcQuestIconState(bState);
	}

	// Token: 0x0600ECDB RID: 60635 RVA: 0x00457E76 File Offset: 0x00456076
	public void SetQuestTrackEffectState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetTrackEffectState(bState);
	}

	// Token: 0x0600ECDC RID: 60636 RVA: 0x00457E89 File Offset: 0x00456089
	public void SetEntityPbDataId(int id)
	{
		this.EntityPbDataId = id;
	}

	// Token: 0x0600ECDD RID: 60637 RVA: 0x00457E92 File Offset: 0x00456092
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

	// Token: 0x0600ECDE RID: 60638 RVA: 0x00457ED1 File Offset: 0x004560D1
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

	// Token: 0x0600ECDF RID: 60639 RVA: 0x00457EF9 File Offset: 0x004560F9
	public void UpdateDialogWorldScale()
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetDialogWorldScale3D(this.Data.GetDialogWorldScale3D());
	}

	// Token: 0x0600ECE0 RID: 60640 RVA: 0x00457F16 File Offset: 0x00456116
	public bool IsDialogueTextActive()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetDialogueActive();
	}

	// Token: 0x0600ECE1 RID: 60641 RVA: 0x00457F29 File Offset: 0x00456129
	public bool IsHeadIconActive()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetHeadIconActive();
	}

	// Token: 0x0600ECE2 RID: 60642 RVA: 0x00457F3C File Offset: 0x0045613C
	public bool IsHeadItemActive()
	{
		NpcIconComponentView headView = this.HeadView;
		return headView != null && headView.GetHeadItemState();
	}

	// Token: 0x0600ECE3 RID: 60643 RVA: 0x00457F50 File Offset: 0x00456150
	private void SetTargetTracking(bool active)
	{
		ITrackData trackData = TrackModel.Instance.IsTargetTracking(this.EntityPbDataId);
		if (trackData != null && this.QuestMarkOccupied)
		{
			TrackController.Instance.SetTrackMarkOccupied(ETrackSource.Quest, trackData.Id, active);
			this.QuestMarkOccupied = active;
		}
	}

	// Token: 0x0600ECE4 RID: 60644 RVA: 0x00457F97 File Offset: 0x00456197
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

	// Token: 0x0600ECE5 RID: 60645 RVA: 0x00457FC8 File Offset: 0x004561C8
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

	// Token: 0x0600ECE6 RID: 60646 RVA: 0x00458008 File Offset: 0x00456208
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

	// Token: 0x0600ECE7 RID: 60647 RVA: 0x00458059 File Offset: 0x00456259
	private void FollowHeadStateHook()
	{
		this.HeadView.InitItemLocation(this.HeadStateFollowData.Location.ToUeVector(false), 60.0);
		this.HeadView.SetHeadWorldScale3D(this.HeadStateFollowData.Scale);
	}

	// Token: 0x0600ECE8 RID: 60648 RVA: 0x00458098 File Offset: 0x00456298
	private void UpdateHeadInfoRotationAndScale()
	{
		double num = Vector.DistSquared(CameraModel.Instance.MainModel.CameraLocation, this.Data.GetSelfLocation());
		this.TickHeadInfo((float)num);
		this.UpdateCharacterIconRotation();
	}

	// Token: 0x0600ECE9 RID: 60649 RVA: 0x004580D4 File Offset: 0x004562D4
	private void UpdateCharacterIconRotation()
	{
		if (this.HeadView != null)
		{
			Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
			this.HeadView.UpdateRotation(cameraRotator.Yaw, cameraRotator.Pitch);
		}
	}

	// Token: 0x0600ECEA RID: 60650 RVA: 0x00458110 File Offset: 0x00456310
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

	// Token: 0x0600ECEB RID: 60651 RVA: 0x00458198 File Offset: 0x00456398
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

	// Token: 0x0600ECEC RID: 60652 RVA: 0x0045820C File Offset: 0x0045640C
	private bool IsInHeadItemNameShowRange(float distance)
	{
		int npcIconHeadInfoNameLimitDistance = NpcIconConfig.Instance.GetNpcIconHeadInfoNameLimitDistance();
		return distance <= (float)(npcIconHeadInfoNameLimitDistance * npcIconHeadInfoNameLimitDistance);
	}

	// Token: 0x0600ECED RID: 60653 RVA: 0x00458230 File Offset: 0x00456430
	private bool IsInPlayerInfoNameShowRange(float distance)
	{
		int playerInfoNameLimitDistance = NpcIconConfig.Instance.GetPlayerInfoNameLimitDistance();
		return distance <= (float)(playerInfoNameLimitDistance * playerInfoNameLimitDistance);
	}

	// Token: 0x0600ECEE RID: 60654 RVA: 0x00458254 File Offset: 0x00456454
	private bool IsInPlayerInfoIconShowRange(float distance)
	{
		int playerInfoIconLimitDistance = NpcIconConfig.Instance.GetPlayerInfoIconLimitDistance();
		return distance < (float)(playerInfoIconLimitDistance * playerInfoIconLimitDistance);
	}

	// Token: 0x0600ECEF RID: 60655 RVA: 0x00458274 File Offset: 0x00456474
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

	// Token: 0x0600ECF0 RID: 60656 RVA: 0x00458307 File Offset: 0x00456507
	private bool IsInHeadQuestShowRange(float distance)
	{
		return this.MaxShowQuestDisSquared == 0f || distance <= this.MaxShowQuestDisSquared * this.MaxShowQuestDisSquared;
	}

	// Token: 0x0600ECF1 RID: 60657 RVA: 0x0045832B File Offset: 0x0045652B
	private bool IsInTrackEffectShowRange(float distance)
	{
		return this.MaxShowTrackEffectDisSquared == 0f || distance <= this.MaxShowTrackEffectDisSquared * this.MaxShowTrackEffectDisSquared;
	}

	// Token: 0x0600ECF2 RID: 60658 RVA: 0x00458350 File Offset: 0x00456550
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

	// Token: 0x0600ECF3 RID: 60659 RVA: 0x00458388 File Offset: 0x00456588
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

	// Token: 0x0600ECF4 RID: 60660 RVA: 0x004583B0 File Offset: 0x004565B0
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

	// Token: 0x0600ECF5 RID: 60661 RVA: 0x004583DA File Offset: 0x004565DA
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

	// Token: 0x0600ECF6 RID: 60662 RVA: 0x00458400 File Offset: 0x00456600
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

	// Token: 0x0600ECF7 RID: 60663 RVA: 0x0045841C File Offset: 0x0045661C
	public void SetNameTextState(bool bState)
	{
		NpcIconComponentView headView = this.HeadView;
		if (headView == null)
		{
			return;
		}
		headView.SetNameTextItemState(bState);
	}

	// Token: 0x0600ECF8 RID: 60664 RVA: 0x00458430 File Offset: 0x00456630
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

	// Token: 0x04008620 RID: 34336
	private const double NAME_ABOVE_HEADSTATE_OFFSET = 60.0;

	// Token: 0x04008621 RID: 34337
	private UiPoolActor UiPoolActor;

	// Token: 0x04008622 RID: 34338
	[Nullable(1)]
	private string Path = "";

	// Token: 0x04008623 RID: 34339
	protected NpcIconComponentView HeadView;

	// Token: 0x04008624 RID: 34340
	private INpcIconFunction Data;

	// Token: 0x04008625 RID: 34341
	private float RemoveMillSeconds = -1f;

	// Token: 0x04008626 RID: 34342
	private double MaxShowRangeDisSquared;

	// Token: 0x04008627 RID: 34343
	public float MaxShowQuestDisSquared;

	// Token: 0x04008628 RID: 34344
	private readonly float MaxShowTrackEffectDisSquared;

	// Token: 0x04008629 RID: 34345
	private UniTaskCompletionSource<bool> CustomPromise;

	// Token: 0x0400862A RID: 34346
	private Action ReCreateHeadView;

	// Token: 0x0400862B RID: 34347
	private float DistanceSquare;

	// Token: 0x0400862C RID: 34348
	private bool PendingShowHeadInfoName;

	// Token: 0x0400862D RID: 34349
	private bool IsDestroy;

	// Token: 0x0400862E RID: 34350
	private uint? GameBudgetManagedTokenInternal;

	// Token: 0x0400862F RID: 34351
	private int EntityPbDataId;

	// Token: 0x04008630 RID: 34352
	private bool QuestMarkOccupied;

	// Token: 0x04008631 RID: 34353
	private bool IsPlayerInfoIconReady;

	// Token: 0x04008632 RID: 34354
	[Nullable(1)]
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x04008633 RID: 34355
	[Nullable(1)]
	private readonly HeadStateFollowData HeadStateFollowData = new HeadStateFollowData();

	// Token: 0x04008634 RID: 34356
	private bool IsFollowingHeadState;

	// Token: 0x04008635 RID: 34357
	private bool IsSelfVisibleInner;

	// Token: 0x04008636 RID: 34358
	private bool IsNpcVisibleInner = true;

	// Token: 0x04008637 RID: 34359
	private Action NpcIconCreateCallback;

	// Token: 0x04008638 RID: 34360
	private bool IsInteractionSpotVisible;

	// Token: 0x04008639 RID: 34361
	private GCHandle GameBudgetGCHandle;
}
