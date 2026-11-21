using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010CD RID: 4301
[NullableContext(2)]
[Nullable(0)]
public class FormationRoleSlot : FormationSlotBase
{
	// Token: 0x170011D5 RID: 4565
	// (get) Token: 0x0600AB27 RID: 43815 RVA: 0x003279F3 File Offset: 0x00325BF3
	[Nullable(1)]
	protected override string LogTag { [NullableContext(1)] get; } = "FormationRoleSlot";

	// Token: 0x0600AB28 RID: 43816 RVA: 0x003279FB File Offset: 0x00325BFB
	[NullableContext(1)]
	public FormationRoleSlot(int position, IFormationProvider provider) : base(position, provider)
	{
	}

	// Token: 0x0600AB29 RID: 43817 RVA: 0x00327A10 File Offset: 0x00325C10
	protected unsafe override void OnRegisterComponent()
	{
		int num = 40;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(34, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(42, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(base.OnClickChooseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600AB2A RID: 43818 RVA: 0x00327FBC File Offset: 0x003261BC
	protected override UniTask OnBeforeStartAsync()
	{
		FormationRoleSlot.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FormationRoleSlot.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AB2B RID: 43819 RVA: 0x00328000 File Offset: 0x00326200
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.PlayerInLevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.PlayerOutLevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.CircleInLevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.CircleOutLevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetItem(7).SetAlpha(0f);
		base.BindDragCallbacks(base.GetDraggable(36));
		this.RoleItem = base.GetItem(5);
	}

	// Token: 0x0600AB2C RID: 43820 RVA: 0x0032808E File Offset: 0x0032628E
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		base.OnBeforeDestroy();
	}

	// Token: 0x0600AB2D RID: 43821 RVA: 0x003280AE File Offset: 0x003262AE
	protected override void OnDragShowProgress(float fill)
	{
		this.StopCircleInIfPlaying();
		base.GetItem(39).SetUIActive(false);
		FormationRoleDragStateItem dragStateItem = this.DragStateItem;
		if (dragStateItem == null)
		{
			return;
		}
		dragStateItem.SetBarFill(fill);
	}

	// Token: 0x0600AB2E RID: 43822 RVA: 0x003280D5 File Offset: 0x003262D5
	protected override void OnDragShowEnd()
	{
		this.StopCircleInIfPlaying();
		base.GetItem(39).SetUIActive(false);
		FormationRoleDragStateItem dragStateItem = this.DragStateItem;
		if (dragStateItem == null)
		{
			return;
		}
		dragStateItem.SetBarFill(0f);
	}

	// Token: 0x0600AB2F RID: 43823 RVA: 0x00328100 File Offset: 0x00326300
	private void StopCircleInIfPlaying()
	{
		if (this.IsPlayingCircleIn)
		{
			LevelSequencePlayer circleInLevelSequencePlayer = this.CircleInLevelSequencePlayer;
			if (circleInLevelSequencePlayer != null)
			{
				circleInLevelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer circleOutLevelSequencePlayer = this.CircleOutLevelSequencePlayer;
			if (circleOutLevelSequencePlayer != null)
			{
				circleOutLevelSequencePlayer.PlaySequencePurely("CircleOut", false, false, null, null, false);
			}
			this.IsPlayingCircleIn = false;
		}
	}

	// Token: 0x0600AB30 RID: 43824 RVA: 0x00328154 File Offset: 0x00326354
	protected override void OnEnterMoveState()
	{
		this.RoleItem.SetUIActive(false);
		base.GetItem(41).SetUIActive(false);
		base.GetItem(1).SetUIActive(true);
		base.GetItem(1).SetAlpha(1f);
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x0600AB31 RID: 43825 RVA: 0x003281A6 File Offset: 0x003263A6
	protected override void OnExitMoveState()
	{
		this.RoleItem.SetUIActive(true);
		base.GetItem(41).SetUIActive(true);
		base.GetItem(1).SetAlpha(0f);
		base.GetItem(3).SetUIActive(true);
	}

	// Token: 0x0600AB32 RID: 43826 RVA: 0x003281E0 File Offset: 0x003263E0
	public override void ShowOtherItemUpState()
	{
		if (this.IsSelfSlot)
		{
			if (!this.IsPlayingCircleIn && !this.StartDrag)
			{
				LevelSequencePlayer circleInLevelSequencePlayer = this.CircleInLevelSequencePlayer;
				if (circleInLevelSequencePlayer != null)
				{
					circleInLevelSequencePlayer.PlaySequencePurely("CircleIn", false, false, null, null, false);
				}
				this.IsPlayingCircleIn = true;
			}
			base.GetItem(39).SetUIActive(true);
			return;
		}
		base.GetItem(38).SetUIActive(true);
	}

	// Token: 0x0600AB33 RID: 43827 RVA: 0x0032824C File Offset: 0x0032644C
	public override void RefreshLockItemState(bool isDrag)
	{
		if (!isDrag)
		{
			base.GetItem(38).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			return;
		}
		if (this.ConfigId.GetValueOrDefault() <= 0 || !this.IsSelfSlot)
		{
			base.GetItem(38).SetUIActive(true);
			base.GetItem(3).SetUIActive(false);
		}
	}

	// Token: 0x0600AB34 RID: 43828 RVA: 0x003282AC File Offset: 0x003264AC
	[NullableContext(1)]
	public override void Refresh(IRoleSlotDisplayData data)
	{
		bool flag = data.ConfigId > 0;
		bool flag2 = this.VisualState == ESlotVisualState.Matching;
		if (!flag2 && flag)
		{
			int? configId = this.ConfigId;
			int configId2 = data.ConfigId;
			if (!(configId.GetValueOrDefault() == configId2 & configId != null))
			{
				base.GetItem(5).SetUIActive(true);
				LevelSequencePlayer playerOutLevelSequencePlayer = this.PlayerOutLevelSequencePlayer;
				if (playerOutLevelSequencePlayer != null)
				{
					playerOutLevelSequencePlayer.StopSequenceByKey("PlayerOut", false, false);
				}
				LevelSequencePlayer playerInLevelSequencePlayer = this.PlayerInLevelSequencePlayer;
				if (playerInLevelSequencePlayer == null || !playerInLevelSequencePlayer.IsPlayingSequence("PlayerIn"))
				{
					LevelSequencePlayer playerInLevelSequencePlayer2 = this.PlayerInLevelSequencePlayer;
					if (playerInLevelSequencePlayer2 != null)
					{
						playerInLevelSequencePlayer2.PlayLevelSequenceByName("PlayerIn", false, null, false);
					}
				}
				else
				{
					LevelSequencePlayer playerInLevelSequencePlayer3 = this.PlayerInLevelSequencePlayer;
					if (playerInLevelSequencePlayer3 != null)
					{
						playerInLevelSequencePlayer3.ReplaySequenceByKey("PlayerIn");
					}
				}
			}
		}
		base.GetItem(41).SetUIActive(flag && !flag2);
		this.ConfigId = new int?(data.ConfigId);
		this.SkinId = new int?(data.SkinId);
		this.PlayerInternal = new int?(data.PlayerId);
		this.OnlineIndex = new int?(data.OnlineIndex);
		this.IsSelfSlot = data.IsSelf;
		this.IsDead = data.IsDead;
		this.LastPrepare = data.Prepare;
		this.IsThirdPartyVisibleInternal = data.IsThirdPartyVisible;
		if (!flag)
		{
			this.ApplySlotVisualState(flag2 ? ESlotVisualState.Matching : ESlotVisualState.Empty);
			return;
		}
		base.RefreshName(data.Name);
		this.RefreshElement(data.ConfigId);
		this.RefreshSpine(data.ConfigId, data.SkinId);
		base.RefreshLevel(data.Level);
		this.RefreshDeadState(data.IsDead);
		this.RefreshTrialIcon(data.IsTrialRole);
		this.RefreshTags(data);
		this.RefreshOnlineState(data.OnlineIndex, data.PlayerId, data.IsSelf);
		this.RefreshThirdPartyItem(data.ThirdPartyOnlineId);
		this.RefreshDeadStateForSpecialTrialRole(data.ConfigId, data.CanUseSpecialTrialRole);
		this.ApplySlotVisualState(flag2 ? ESlotVisualState.Matching : ESlotVisualState.Normal);
		SlotExtensionRegistry.InvokeRefresh(this.Extensions, data);
	}

	// Token: 0x0600AB35 RID: 43829 RVA: 0x003284B8 File Offset: 0x003266B8
	private void RefreshElement(int configId)
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(configId);
		if (roleConfig == null)
		{
			return;
		}
		int elementId = roleConfig.Value.ElementId;
		if (this.MiniElementItem == null)
		{
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				this.MiniElementItem = new MiniElementItem(elementId, item, item.GetOwner());
			}
		}
		MiniElementItem miniElementItem = this.MiniElementItem;
		if (miniElementItem == null)
		{
			return;
		}
		miniElementItem.RefreshMiniElement(elementId);
	}

	// Token: 0x0600AB36 RID: 43830 RVA: 0x00328524 File Offset: 0x00326724
	private void RefreshSpine(int configId, int roleSkinId)
	{
		FormationRoleSlot.<>c__DisplayClass33_0 CS$<>8__locals1 = new FormationRoleSlot.<>c__DisplayClass33_0();
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(configId);
		if (roleConfig == null)
		{
			return;
		}
		RoleSkin? roleSkin = (roleSkinId != 0) ? SkinConfig.Instance.GetRoleSkinConfig(roleSkinId) : null;
		CS$<>8__locals1.roleItem = base.GetItem(7);
		CS$<>8__locals1.roleSpine = base.GetSpine(6);
		CS$<>8__locals1.roleItem.SetAlpha(0f);
		string atlasPath = (roleSkin != null) ? roleSkin.Value.FormationSpineAtlas : roleConfig.Value.FormationSpineAtlas;
		string skeletonPath = (roleSkin != null) ? roleSkin.Value.FormationSpineSkeletonData : roleConfig.Value.FormationSpineSkeletonData;
		FormationRoleSlot.<>c__DisplayClass33_0 CS$<>8__locals2 = CS$<>8__locals1;
		float[] param;
		if (roleSkin == null)
		{
			(param = new float[3])[2] = 1f;
		}
		else
		{
			param = roleSkin.Value.SpineParam();
		}
		CS$<>8__locals2.param = param;
		base.SetSpineAssetByPath(atlasPath, skeletonPath, CS$<>8__locals1.roleSpine).ContinueWith(delegate()
		{
			CS$<>8__locals1.roleItem.SetAlpha(1f);
			CS$<>8__locals1.roleSpine.SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
			CS$<>8__locals1.roleItem.SetAnchorOffsetX(CS$<>8__locals1.param[0]);
			CS$<>8__locals1.roleItem.SetAnchorOffsetY(CS$<>8__locals1.param[1]);
			CS$<>8__locals1.roleItem.SetUIItemScale(new FVector(CS$<>8__locals1.param[2], CS$<>8__locals1.param[2], CS$<>8__locals1.param[2]));
		});
	}

	// Token: 0x0600AB37 RID: 43831 RVA: 0x0032863B File Offset: 0x0032683B
	private void RefreshDeadState(bool isDead)
	{
		base.GetItem(24).SetUIActive(isDead);
	}

	// Token: 0x0600AB38 RID: 43832 RVA: 0x0032864B File Offset: 0x0032684B
	private void RefreshTrialIcon(bool isTrialRole)
	{
	}

	// Token: 0x0600AB39 RID: 43833 RVA: 0x0032864D File Offset: 0x0032684D
	[NullableContext(1)]
	private void RefreshTags(IRoleSlotDisplayData data)
	{
		this.RefreshWeeklyRogueTag(data.WeeklyRogue);
		this.RefreshTowerCost(data.TowerCost);
	}

	// Token: 0x0600AB3A RID: 43834 RVA: 0x00328668 File Offset: 0x00326868
	private void RefreshWeeklyRogueTag(IRoleSlotDisplayData.WeeklyRogueData weeklyRogue)
	{
		if (weeklyRogue == null)
		{
			base.GetItem(31).SetUIActive(false);
			return;
		}
		base.GetItem(31).SetUIActive(weeklyRogue.IsRecommendRole);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(32), "WeeklyRogueTag", Array.Empty<object>());
	}

	// Token: 0x0600AB3B RID: 43835 RVA: 0x003286B8 File Offset: 0x003268B8
	private void RefreshTowerCost(IRoleSlotDisplayData.TowerCostData towerCost)
	{
		if (towerCost == null)
		{
			base.GetItem(18).SetUIActive(false);
			return;
		}
		int currentCost = towerCost.CurrentCost;
		int needCost = towerCost.NeedCost;
		bool isHaveChallenge = towerCost.IsHaveChallenge;
		bool isNotEnough = currentCost < needCost;
		bool flag = isNotEnough && !isHaveChallenge;
		base.GetItem(18).SetUIActive(true);
		if (this.CurrentCost == null)
		{
			this.CurrentCost = new TowerCostItem();
			this.CurrentCost.CreateThenShowByActorAsync(base.GetItem(21).GetOwner(), null, false).ContinueWith(delegate()
			{
				this.CurrentCost.SetUiActive(!isNotEnough && !isHaveChallenge);
			});
		}
		if (this.ChangeToCost == null)
		{
			this.ChangeToCost = new TowerCostItem();
			this.ChangeToCost.CreateThenShowByActorAsync(base.GetItem(22).GetOwner(), null, false).ContinueWith(delegate()
			{
				this.ChangeToCost.SetUiActive(!isNotEnough | isHaveChallenge);
			});
		}
		base.GetItem(19).SetUIActive(flag);
		base.GetItem(20).SetUIActive(!flag);
		this.CurrentCost.SetUiActive(!isNotEnough && !isHaveChallenge);
		this.ChangeToCost.SetUiActive(!isNotEnough | isHaveChallenge);
		if (!isNotEnough && !isHaveChallenge)
		{
			this.CurrentCost.Update(currentCost);
			this.ChangeToCost.Update(currentCost - needCost);
			return;
		}
		if (isHaveChallenge)
		{
			this.ChangeToCost.Update(currentCost);
		}
	}

	// Token: 0x0600AB3C RID: 43836 RVA: 0x00328844 File Offset: 0x00326A44
	private void RefreshOnlineState(int onlineIndex, int playerId, bool isSelf)
	{
		bool flag = onlineIndex > 0;
		base.GetItem(12).SetUIActive(flag);
		base.GetSprite(14).SetUIActive(false);
		if (!flag)
		{
			this.OnlineIndex = new int?(onlineIndex);
			this.PlayerInternal = new int?(playerId);
			return;
		}
		string inString = isSelf ? "SP_Online{0}PIcon_Self" : "SP_Online{0}PIcon";
		this.LevelSequencePlayer.StopSequenceByKey("LocationNotice", false, true);
		if (isSelf)
		{
			int? playerInternal = this.PlayerInternal;
			if (!(playerInternal.GetValueOrDefault() == playerId & playerInternal != null))
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("LocationNotice", false, null, false);
			}
		}
		string resourceId = StringUtils.Format(inString, new string[]
		{
			onlineIndex.ToString()
		});
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(13), false, null, null);
		this.OnlineIndex = new int?(onlineIndex);
		this.PlayerInternal = new int?(playerId);
	}

	// Token: 0x0600AB3D RID: 43837 RVA: 0x00328944 File Offset: 0x00326B44
	private void ApplySlotVisualState(ESlotVisualState state)
	{
		this.VisualState = state;
		UUIItem item = base.GetItem(2);
		UUIItem item2 = base.GetItem(3);
		UUIItem item3 = base.GetItem(15);
		UUIItem item4 = base.GetItem(16);
		UUIItem item5 = base.GetItem(17);
		UUIItem item6 = base.GetItem(1);
		UUIButtonComponent button = base.GetButton(0);
		item.SetUIActive(false);
		item3.SetUIActive(false);
		item4.SetUIActive(false);
		item5.SetUIActive(false);
		button.SetSelfInteractive(true);
		switch (state)
		{
		case ESlotVisualState.Empty:
			item2.SetUIActive(true);
			item6.SetUIActive(true);
			base.GetItem(12).SetUIActive(false);
			base.GetSprite(14).SetUIActive(false);
			return;
		case ESlotVisualState.Normal:
			item2.SetUIActive(true);
			return;
		case ESlotVisualState.Matching:
			item.SetUIActive(true);
			item2.SetUIActive(false);
			item5.SetUIActive(this.LastPrepare != null && this.LastPrepare.IsRoleConflict && !this.LastPrepare.ShouldSuppressByGameplay);
			button.SetSelfInteractive(false);
			return;
		case ESlotVisualState.Preparing:
			item3.SetUIActive(true);
			item4.SetUIActive(true);
			return;
		case ESlotVisualState.Conflict:
			item5.SetUIActive(true);
			return;
		case ESlotVisualState.Ready:
			item3.SetUIActive(true);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600AB3E RID: 43838 RVA: 0x00328A71 File Offset: 0x00326C71
	public override void Reset()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		base.Reset();
	}

	// Token: 0x0600AB3F RID: 43839 RVA: 0x00328A94 File Offset: 0x00326C94
	public override void ResetRole()
	{
		bool flag = this.VisualState == ESlotVisualState.Matching;
		if (this.ConfigId != null)
		{
			int? configId = this.ConfigId;
			int num = 0;
			if (!(configId.GetValueOrDefault() == num & configId != null) && !flag)
			{
				LevelSequencePlayer playerInLevelSequencePlayer = this.PlayerInLevelSequencePlayer;
				if (playerInLevelSequencePlayer != null)
				{
					playerInLevelSequencePlayer.StopSequenceByKey("PlayerIn", false, true);
				}
				LevelSequencePlayer playerOutLevelSequencePlayer = this.PlayerOutLevelSequencePlayer;
				if (playerOutLevelSequencePlayer == null)
				{
					goto IL_AF;
				}
				playerOutLevelSequencePlayer.PlayLevelSequenceByName("PlayerOut", false, null, false);
				goto IL_AF;
			}
		}
		base.GetItem(5).SetUIActive(false);
		if (!flag)
		{
			LevelSequencePlayer playerOutLevelSequencePlayer2 = this.PlayerOutLevelSequencePlayer;
			if (playerOutLevelSequencePlayer2 == null || !playerOutLevelSequencePlayer2.IsPlayingSequence("PlayerOut"))
			{
				base.GetItem(1).SetAlpha(1f);
			}
		}
		IL_AF:
		this.PlayerInternal = null;
		this.ConfigId = null;
		this.OnlineIndex = null;
		this.IsSelfSlot = false;
		this.IsDead = false;
		this.LastPrepare = null;
		this.IsThirdPartyVisibleInternal = false;
		base.GetItem(41).SetUIActive(false);
		base.GetItem(24).SetUIActive(false);
		this.ApplySlotVisualState(flag ? ESlotVisualState.Matching : ESlotVisualState.Empty);
		SlotExtensionRegistry.InvokeRefresh(this.Extensions, FormationDefine.CreateEmptySlotDisplayData());
	}

	// Token: 0x0600AB40 RID: 43840 RVA: 0x00328BC9 File Offset: 0x00326DC9
	public void SetCanAddRole(bool canAddRole)
	{
		base.GetItem(3).SetUIActive(canAddRole);
		base.GetItem(4).SetUIActive(!canAddRole);
	}

	// Token: 0x0600AB41 RID: 43841 RVA: 0x00328BE8 File Offset: 0x00326DE8
	public void RefreshPrepareState(EMatchPlayerUiState? playerUiState = null)
	{
		if (playerUiState != null && this.LastPrepare != null)
		{
			this.LastPrepare = new IRoleSlotDisplayData.PrepareData
			{
				IsRoleConflict = this.LastPrepare.IsRoleConflict,
				ShouldSuppressByGameplay = this.LastPrepare.ShouldSuppressByGameplay,
				PlayerUiState = playerUiState,
				IsHost = this.LastPrepare.IsHost
			};
		}
		if (this.VisualState == ESlotVisualState.Matching)
		{
			return;
		}
		if (this.LastPrepare == null)
		{
			ESlotVisualState state;
			if (this.ConfigId != null)
			{
				int? configId = this.ConfigId;
				int num = 0;
				if (!(configId.GetValueOrDefault() == num & configId != null))
				{
					state = ESlotVisualState.Normal;
					goto IL_97;
				}
			}
			state = ESlotVisualState.Empty;
			IL_97:
			this.ApplySlotVisualState(state);
			return;
		}
		if (this.LastPrepare.IsRoleConflict && !this.LastPrepare.ShouldSuppressByGameplay)
		{
			base.GetItem(24).SetUIActive(false);
			this.ApplySlotVisualState(ESlotVisualState.Conflict);
			return;
		}
		base.GetItem(24).SetUIActive(this.IsDead);
		EMatchPlayerUiState? playerUiState2 = this.LastPrepare.PlayerUiState;
		if (playerUiState2 == null)
		{
			ESlotVisualState state2;
			if (this.ConfigId != null)
			{
				int? configId = this.ConfigId;
				int num = 0;
				if (!(configId.GetValueOrDefault() == num & configId != null))
				{
					state2 = ESlotVisualState.Normal;
					goto IL_124;
				}
			}
			state2 = ESlotVisualState.Empty;
			IL_124:
			this.ApplySlotVisualState(state2);
			return;
		}
		EMatchPlayerUiState value = playerUiState2.Value;
		if (value != EMatchPlayerUiState.Ready)
		{
			if (value == EMatchPlayerUiState.Selecting)
			{
				this.ApplySlotVisualState(ESlotVisualState.Preparing);
				EMatchPlayerUiState? ematchPlayerUiState = this.CurrentPrepareState;
				EMatchPlayerUiState? ematchPlayerUiState2 = playerUiState2;
				if (!(ematchPlayerUiState.GetValueOrDefault() == ematchPlayerUiState2.GetValueOrDefault() & ematchPlayerUiState != null == (ematchPlayerUiState2 != null)))
				{
					this.LevelSequencePlayer.PlayLevelSequenceByName("Connecting", false, null, false);
				}
				this.CurrentPrepareState = playerUiState2;
				return;
			}
			ESlotVisualState state3;
			if (this.ConfigId != null)
			{
				int? configId = this.ConfigId;
				int num = 0;
				if (!(configId.GetValueOrDefault() == num & configId != null))
				{
					state3 = ESlotVisualState.Normal;
					goto IL_233;
				}
			}
			state3 = ESlotVisualState.Empty;
			IL_233:
			this.ApplySlotVisualState(state3);
			this.CurrentPrepareState = new EMatchPlayerUiState?(EMatchPlayerUiState.Wait);
			return;
		}
		else
		{
			if (this.LastPrepare.IsHost)
			{
				this.ApplySlotVisualState(ESlotVisualState.Normal);
				return;
			}
			this.ApplySlotVisualState(ESlotVisualState.Ready);
			EMatchPlayerUiState? ematchPlayerUiState2 = this.CurrentPrepareState;
			EMatchPlayerUiState? ematchPlayerUiState = playerUiState2;
			if (!(ematchPlayerUiState2.GetValueOrDefault() == ematchPlayerUiState.GetValueOrDefault() & ematchPlayerUiState2 != null == (ematchPlayerUiState != null)))
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Match", false, null, false);
			}
			this.CurrentPrepareState = playerUiState2;
			return;
		}
	}

	// Token: 0x0600AB42 RID: 43842 RVA: 0x00328E3C File Offset: 0x0032703C
	public void SetMatchState(bool isMatching)
	{
		if (this.VisualState == ESlotVisualState.Matching == isMatching)
		{
			return;
		}
		ESlotVisualState eslotVisualState;
		if (!isMatching)
		{
			if (this.ConfigId != null)
			{
				int? configId = this.ConfigId;
				int num = 0;
				if (!(configId.GetValueOrDefault() == num & configId != null))
				{
					eslotVisualState = ESlotVisualState.Normal;
					goto IL_41;
				}
			}
			eslotVisualState = ESlotVisualState.Empty;
		}
		else
		{
			eslotVisualState = ESlotVisualState.Matching;
		}
		IL_41:
		ESlotVisualState state = eslotVisualState;
		if (!isMatching)
		{
			UUIItem item = base.GetItem(41);
			bool uiactive;
			if (this.ConfigId != null)
			{
				int? configId = this.ConfigId;
				int num = 0;
				uiactive = !(configId.GetValueOrDefault() == num & configId != null);
			}
			else
			{
				uiactive = false;
			}
			item.SetUIActive(uiactive);
		}
		if (this.ConfigId != null)
		{
			int? configId = this.ConfigId;
			int num = 0;
			if (!(configId.GetValueOrDefault() == num & configId != null))
			{
				if (isMatching)
				{
					LevelSequencePlayer playerInLevelSequencePlayer = this.PlayerInLevelSequencePlayer;
					if (playerInLevelSequencePlayer != null)
					{
						playerInLevelSequencePlayer.StopSequenceByKey("PlayerIn", false, true);
					}
					LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
					if (levelSequencePlayer != null)
					{
						levelSequencePlayer.StopSequenceByKey("LocationNotice", false, true);
					}
					LevelSequencePlayer playerOutLevelSequencePlayer = this.PlayerOutLevelSequencePlayer;
					if (playerOutLevelSequencePlayer != null)
					{
						playerOutLevelSequencePlayer.PlayLevelSequenceByName("PlayerOut", false, null, false);
					}
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 != null)
					{
						levelSequencePlayer2.PlayLevelSequenceByName("Matching", false, null, false);
					}
				}
				else
				{
					LevelSequencePlayer playerOutLevelSequencePlayer2 = this.PlayerOutLevelSequencePlayer;
					if (playerOutLevelSequencePlayer2 != null)
					{
						playerOutLevelSequencePlayer2.StopSequenceByKey("PlayerOut", false, false);
					}
					LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
					if (levelSequencePlayer3 != null)
					{
						levelSequencePlayer3.StopSequenceByKey("LocationNotice", false, true);
					}
					LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
					if (levelSequencePlayer4 != null)
					{
						levelSequencePlayer4.StopSequenceByKey("Matching", false, true);
					}
					LevelSequencePlayer playerInLevelSequencePlayer2 = this.PlayerInLevelSequencePlayer;
					if (playerInLevelSequencePlayer2 == null || !playerInLevelSequencePlayer2.IsPlayingSequence("PlayerIn"))
					{
						LevelSequencePlayer playerInLevelSequencePlayer3 = this.PlayerInLevelSequencePlayer;
						if (playerInLevelSequencePlayer3 != null)
						{
							playerInLevelSequencePlayer3.PlayLevelSequenceByName("PlayerIn", false, null, false);
						}
					}
					else
					{
						LevelSequencePlayer playerInLevelSequencePlayer4 = this.PlayerInLevelSequencePlayer;
						if (playerInLevelSequencePlayer4 != null)
						{
							playerInLevelSequencePlayer4.ReplaySequenceByKey("PlayerIn");
						}
					}
				}
			}
		}
		this.ApplySlotVisualState(state);
		if (!isMatching)
		{
			this.RefreshPrepareState(null);
		}
	}

	// Token: 0x0600AB43 RID: 43843 RVA: 0x0032902D File Offset: 0x0032722D
	public void SetMatchTime(int time)
	{
		base.GetText(23).SetText(TimeUtil.Instance.GetTimeString((double)time), true);
	}

	// Token: 0x0600AB44 RID: 43844 RVA: 0x0032904C File Offset: 0x0032724C
	public void RefreshThirdPartyItem(string onlineId)
	{
		if (!this.IsThirdPartyVisibleInternal)
		{
			UUIItem item = base.GetItem(28);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIText text = base.GetText(30);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUITexture texture = base.GetTexture(29);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(false);
			return;
		}
		else
		{
			UUIItem item2 = base.GetItem(28);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			bool flag = onlineId != null && onlineId != "";
			UUIText text2 = base.GetText(30);
			UUITexture texture2 = base.GetTexture(29);
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			if (!flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text2, "CrossNetworkPlayer_Name", Array.Empty<object>());
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_PlatformPcPhoneWhite" + ELogoSize.Medium.ToValue());
				base.SetTextureByPath(resourcePath, texture2, null, null);
				return;
			}
			if (text2 != null)
			{
				text2.SetText(onlineId, true);
			}
			string thirdPartyWhiteLogoTexturePath = UiResourceConfig.Instance.GetThirdPartyWhiteLogoTexturePath(ELogoSize.Medium);
			base.SetTextureByPath(thirdPartyWhiteLogoTexturePath, texture2, null, null);
			return;
		}
	}

	// Token: 0x0600AB45 RID: 43845 RVA: 0x00329158 File Offset: 0x00327358
	private void RefreshDeadStateForSpecialTrialRole(int roleId, bool canUseSpecialTrialRole)
	{
		UUIItem item = base.GetItem(35);
		if (!RoleUtils.IsSpecialTrialRole(roleId))
		{
			item.SetUIActive(false);
			return;
		}
		if (!canUseSpecialTrialRole)
		{
			item.SetUIActive(true);
			return;
		}
		item.SetUIActive(false);
		this.IsDead = this.Provider.ResolveSpecialTrialDeadState(roleId);
		base.GetItem(24).SetUIActive(this.IsDead);
	}

	// Token: 0x0600AB46 RID: 43846 RVA: 0x003291B5 File Offset: 0x003273B5
	protected override UUISprite GetPingSprite()
	{
		return base.GetSprite(14);
	}

	// Token: 0x0600AB47 RID: 43847 RVA: 0x003291BF File Offset: 0x003273BF
	protected override UUIText GetNameText()
	{
		return base.GetText(8);
	}

	// Token: 0x0600AB48 RID: 43848 RVA: 0x003291C8 File Offset: 0x003273C8
	protected override UUIArtText GetLevelArtText()
	{
		return base.GetArtText(9);
	}

	// Token: 0x0600AB49 RID: 43849 RVA: 0x003291D2 File Offset: 0x003273D2
	[NullableContext(1)]
	public override AActor GetRoleItemOwner()
	{
		return base.GetItem(5).GetOwner();
	}

	// Token: 0x0600AB4A RID: 43850 RVA: 0x003291E0 File Offset: 0x003273E0
	[NullableContext(1)]
	public override AActor GetPanelRoleItemOwner()
	{
		return base.GetItem(42).GetOwner();
	}

	// Token: 0x0600AB4B RID: 43851 RVA: 0x003291EF File Offset: 0x003273EF
	public override AActor GetLikeItemOwner()
	{
		UUIItem item = base.GetItem(33);
		if (item == null)
		{
			return null;
		}
		return item.GetOwner();
	}

	// Token: 0x0600AB4C RID: 43852 RVA: 0x00329204 File Offset: 0x00327404
	public override AActor GetTrialRoleItemOwner()
	{
		UUIItem item = base.GetItem(34);
		if (item == null)
		{
			return null;
		}
		return item.GetOwner();
	}

	// Token: 0x0600AB4D RID: 43853 RVA: 0x0032921C File Offset: 0x0032741C
	public override UUIItem GetChooseButtonRoot()
	{
		UUIButtonComponent button = base.GetButton(0);
		TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
		if (tweakObjectPtr == null)
		{
			return null;
		}
		return tweakObjectPtr.GetValueOrDefault();
	}

	// Token: 0x0600AB4E RID: 43854 RVA: 0x00329261 File Offset: 0x00327461
	public override AActor GetSkillBranchToggleItemOwner()
	{
		UUIItem item = base.GetItem(40);
		if (item == null)
		{
			return null;
		}
		return item.GetOwner();
	}

	// Token: 0x0400631E RID: 25374
	private ESlotVisualState VisualState;

	// Token: 0x0400631F RID: 25375
	private bool IsDead;

	// Token: 0x04006320 RID: 25376
	private IRoleSlotDisplayData.PrepareData LastPrepare;

	// Token: 0x04006321 RID: 25377
	private EMatchPlayerUiState? CurrentPrepareState;

	// Token: 0x04006322 RID: 25378
	private MiniElementItem MiniElementItem;

	// Token: 0x04006323 RID: 25379
	private TowerCostItem CurrentCost;

	// Token: 0x04006324 RID: 25380
	private TowerCostItem ChangeToCost;

	// Token: 0x04006325 RID: 25381
	private FormationRoleDragStateItem DragStateItem;

	// Token: 0x04006326 RID: 25382
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006327 RID: 25383
	private LevelSequencePlayer PlayerInLevelSequencePlayer;

	// Token: 0x04006328 RID: 25384
	private LevelSequencePlayer PlayerOutLevelSequencePlayer;

	// Token: 0x04006329 RID: 25385
	private LevelSequencePlayer CircleInLevelSequencePlayer;

	// Token: 0x0400632A RID: 25386
	private LevelSequencePlayer CircleOutLevelSequencePlayer;

	// Token: 0x0400632B RID: 25387
	private UUIItem RoleItem;

	// Token: 0x0400632C RID: 25388
	private bool IsPlayingCircleIn;

	// Token: 0x02007350 RID: 29520
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040258C4 RID: 153796
		ChooseButton,
		// Token: 0x040258C5 RID: 153797
		NoRoleItem,
		// Token: 0x040258C6 RID: 153798
		MatchingItem,
		// Token: 0x040258C7 RID: 153799
		AddRoleIcon,
		// Token: 0x040258C8 RID: 153800
		ForbiddenItem,
		// Token: 0x040258C9 RID: 153801
		RoleItem,
		// Token: 0x040258CA RID: 153802
		RoleIconSpine,
		// Token: 0x040258CB RID: 153803
		RoleIconItem,
		// Token: 0x040258CC RID: 153804
		RoleNameText,
		// Token: 0x040258CD RID: 153805
		RoleLevelText,
		// Token: 0x040258CE RID: 153806
		ElementItem,
		// Token: 0x040258CF RID: 153807
		TrailRoleIcon,
		// Token: 0x040258D0 RID: 153808
		OnlineItem,
		// Token: 0x040258D1 RID: 153809
		OnlineIndexIcon,
		// Token: 0x040258D2 RID: 153810
		OnlineSignalIcon,
		// Token: 0x040258D3 RID: 153811
		PrepareItem,
		// Token: 0x040258D4 RID: 153812
		PrepareWaitItem,
		// Token: 0x040258D5 RID: 153813
		WarnItem,
		// Token: 0x040258D6 RID: 153814
		CostItem,
		// Token: 0x040258D7 RID: 153815
		CostNotEnoughItem,
		// Token: 0x040258D8 RID: 153816
		CostEnoughItem,
		// Token: 0x040258D9 RID: 153817
		CurrentCostUIItem,
		// Token: 0x040258DA RID: 153818
		ChangeToCostUIItem,
		// Token: 0x040258DB RID: 153819
		MatchTimeText,
		// Token: 0x040258DC RID: 153820
		DeadItem,
		// Token: 0x040258DD RID: 153821
		ThirdPartyItem = 28,
		// Token: 0x040258DE RID: 153822
		ThirdPartyIcon,
		// Token: 0x040258DF RID: 153823
		ThirdPartyText,
		// Token: 0x040258E0 RID: 153824
		RightTagItem,
		// Token: 0x040258E1 RID: 153825
		RightTagText,
		// Token: 0x040258E2 RID: 153826
		LikeItem,
		// Token: 0x040258E3 RID: 153827
		TrialRoleItem,
		// Token: 0x040258E4 RID: 153828
		TrialRoleWarnItem,
		// Token: 0x040258E5 RID: 153829
		Drag,
		// Token: 0x040258E6 RID: 153830
		DragStateItem,
		// Token: 0x040258E7 RID: 153831
		LockItem,
		// Token: 0x040258E8 RID: 153832
		OtherOnItem,
		// Token: 0x040258E9 RID: 153833
		SkillBranchToggleItem,
		// Token: 0x040258EA RID: 153834
		PanelPreviewItem,
		// Token: 0x040258EB RID: 153835
		PanelRoleItem
	}
}
