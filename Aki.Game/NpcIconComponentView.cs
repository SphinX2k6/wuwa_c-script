using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017BC RID: 6076
[NullableContext(2)]
[Nullable(0)]
public class NpcIconComponentView : UiPanelBase
{
	// Token: 0x17001687 RID: 5767
	// (get) Token: 0x0600ECFC RID: 60668 RVA: 0x00458502 File Offset: 0x00456702
	// (set) Token: 0x0600ECFD RID: 60669 RVA: 0x0045850A File Offset: 0x0045670A
	public bool ForceHideRootItem
	{
		get
		{
			return this.ForceHideRootItemInner;
		}
		set
		{
			bool flag = this.ForceHideRootItemInner != value;
			this.ForceHideRootItemInner = value;
			if (flag)
			{
				this.SetRootItemState(this.IsRootItemActive, true);
			}
		}
	}

	// Token: 0x17001688 RID: 5768
	// (get) Token: 0x0600ECFE RID: 60670 RVA: 0x0045852E File Offset: 0x0045672E
	// (set) Token: 0x0600ECFF RID: 60671 RVA: 0x00458536 File Offset: 0x00456736
	public bool ForceHideDialog
	{
		get
		{
			return this.ForceHideDialogInner;
		}
		set
		{
			bool flag = this.ForceHideDialogInner != value;
			this.ForceHideDialogInner = value;
			if (flag)
			{
				this.SetDialogueActive(this.IsDialogActive, this.IsDialogRedDotActive, true);
			}
		}
	}

	// Token: 0x0600ED00 RID: 60672 RVA: 0x00458560 File Offset: 0x00456760
	protected unsafe override void OnRegisterComponent()
	{
		int num = 17;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600ED01 RID: 60673 RVA: 0x004587C4 File Offset: 0x004569C4
	protected override void OnStart()
	{
		this.InitTweenAnim();
		this.RootActorRotation = this.RootActor.K2_GetActorRotation();
		this.RootActorLocationOffset = new FVectorDouble(0.0, 0.0, 0.0);
		this.HeadItem = base.GetItem(6);
		this.CacheHeadScale = this.HeadItem.D_K2_GetComponentScale().X;
		this.DialogItem = base.GetItem(2);
		this.CacheDialogScale = this.DialogItem.D_K2_GetComponentScale().X;
		this.NameText = base.GetText(0);
		this.NameMessageItem = base.GetItem(5);
		this.HeadIcon = base.GetTexture(4);
		this.RedDotItem = base.GetItem(8);
		this.QuestTrackCellItem = base.GetItem(10);
		this.PlayerInfoItem = base.GetSprite(11);
		this.IsHeadIconActive = this.HeadIcon.bIsUIActive;
		this.IsHeadItemActive = this.HeadItem.bIsUIActive;
		this.IsRootItemActive = this.RootItem.bIsUIActive;
		this.IsHeadInfoNameActive = this.NameMessageItem.bIsUIActive;
		this.IsQuestTrackCellActive = this.QuestTrackCellItem.bIsUIActive;
		this.ForceHideDialogInner = false;
		this.IsDialogRedDotActive = false;
		this.SetDialogueActive(false, false, false);
		this.SetPlayerInfoItemState(false);
	}

	// Token: 0x0600ED02 RID: 60674 RVA: 0x00458918 File Offset: 0x00456B18
	private void InitTweenAnim()
	{
		this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
		this.TweenAnimPlayer.InitTweenAnim(12, base.GetItem(12), false);
		this.TweenAnimPlayer.InitTweenAnim(13, base.GetItem(13), false);
		this.TweenAnimPlayer.InitTweenAnim(14, base.GetItem(14), false);
		this.TweenAnimPlayer.InitTweenAnim(17, base.GetItem(17), false);
		this.TweenAnimPlayer.InitTweenAnim(18, base.GetItem(18), false);
		this.TweenAnimPlayer.InitTweenAnim(15, base.GetItem(15), false);
		this.TweenAnimPlayer.InitTweenAnim(16, base.GetItem(16), false);
		this.TweenAnimPlayer.RegisterOnComplete(14, delegate
		{
			this.DialogItem.SetUIActive(false);
		});
		this.TweenAnimPlayer.RegisterOnComplete(18, delegate
		{
			if (!this.IsPlayingHiddenSequence)
			{
				return;
			}
			this.IsPlayingHiddenSequence = false;
			this.HeadItem.SetUIActive(false);
			if (this.PendingQuestTrackCellActive != null)
			{
				this.SetQuestTrackCellState(this.PendingQuestTrackCellActive.Value);
				this.PendingQuestTrackCellActive = null;
			}
		});
	}

	// Token: 0x0600ED03 RID: 60675 RVA: 0x004589FC File Offset: 0x00456BFC
	public void SetNpcName(string name)
	{
		UUIText text = base.GetText(0);
		if (StringUtils.IsEmpty(name))
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		text.SetText(name, true);
	}

	// Token: 0x0600ED04 RID: 60676 RVA: 0x00458A30 File Offset: 0x00456C30
	public void InitItemLocation(FVectorDouble location, double offsetZ)
	{
		this.RootActorLocationOffset = location;
		FVectorDouble rootActorLocationOffset = this.RootActorLocationOffset;
		rootActorLocationOffset.Z = location.Z + offsetZ;
		this.RootActor.D_K2_SetActorLocation(rootActorLocationOffset, false, ref WorldGlobal.SweepHitResult, false);
	}

	// Token: 0x0600ED05 RID: 60677 RVA: 0x00458A70 File Offset: 0x00456C70
	public void UpdateRotation(float yaw, float pitch)
	{
		float roll = pitch - 90f;
		float yaw2 = yaw + 90f;
		this.RootActorRotation.Roll = roll;
		this.RootActorRotation.Pitch = 0f;
		this.RootActorRotation.Yaw = yaw2;
		this.RootItem.SetUIWorldRotation(this.RootActorRotation);
	}

	// Token: 0x0600ED06 RID: 60678 RVA: 0x00458AC8 File Offset: 0x00456CC8
	public void SetDialogueActive(bool bActive, bool redDot = false, bool force = false)
	{
		if (this.ForceHideDialog)
		{
			if (this.DialogItem.bIsUIActive)
			{
				this.DialogItem.SetUIActive(false);
			}
			this.IsDialogActive = bActive;
			return;
		}
		if (bActive == this.IsDialogActive && !force)
		{
			return;
		}
		this.IsDialogActive = bActive;
		if (bActive)
		{
			this.TweenAnimPlayer.StopTweenAnim(14);
			this.DialogItem.SetUIActive(true);
			this.TweenAnimPlayer.PlayTweenAnim(13);
			this.RedDotItem.SetUIActive(redDot);
			this.IsDialogRedDotActive = redDot;
			return;
		}
		this.TweenAnimPlayer.StopTweenAnim(13);
		this.TweenAnimPlayer.PlayTweenAnim(14);
	}

	// Token: 0x0600ED07 RID: 60679 RVA: 0x00458B69 File Offset: 0x00456D69
	public bool GetDialogueActive()
	{
		return this.IsDialogActive;
	}

	// Token: 0x0600ED08 RID: 60680 RVA: 0x00458B71 File Offset: 0x00456D71
	[NullableContext(1)]
	public void SetDialogueText(string text)
	{
		base.GetText(3).SetText(text, true);
	}

	// Token: 0x0600ED09 RID: 60681 RVA: 0x00458B84 File Offset: 0x00456D84
	public void SetHeadItemState(bool bState)
	{
		if (this.IsHeadItemActive == bState)
		{
			return;
		}
		this.IsHeadItemActive = bState;
		if (bState)
		{
			this.HeadItem.SetUIActive(true);
			if (this.IsPlayingHiddenSequence)
			{
				this.TweenAnimPlayer.StopAll();
				this.IsPlayingHiddenSequence = false;
			}
			this.TweenAnimPlayer.PlayTweenAnim(17);
			if (this.IsHeadIconActive)
			{
				EHeadIconType? headIconType = this.HeadIconType;
				EHeadIconType eheadIconType = EHeadIconType.Function;
				if (headIconType.GetValueOrDefault() == eheadIconType & headIconType != null)
				{
					this.TweenAnimPlayer.PlayTweenAnim(12);
					return;
				}
				if (this.HeadIconType.GetValueOrDefault() == EHeadIconType.Quest)
				{
					this.TweenAnimPlayer.PlayTweenAnim(15);
					return;
				}
			}
		}
		else
		{
			this.TweenAnimPlayer.PlayTweenAnim(18);
			this.TweenAnimPlayer.PlayTweenAnim(16);
			this.IsPlayingHiddenSequence = true;
		}
	}

	// Token: 0x0600ED0A RID: 60682 RVA: 0x00458C4B File Offset: 0x00456E4B
	public bool GetHeadItemState()
	{
		return this.IsHeadItemActive;
	}

	// Token: 0x0600ED0B RID: 60683 RVA: 0x00458C53 File Offset: 0x00456E53
	public bool GetHeadIconActive()
	{
		return this.IsHeadIconActive;
	}

	// Token: 0x0600ED0C RID: 60684 RVA: 0x00458C5C File Offset: 0x00456E5C
	public void SetQuestTrackCellState(bool bState)
	{
		if (this.IsQuestTrackCellActive == bState)
		{
			return;
		}
		if (this.TweenAnimPlayer != null && this.TweenAnimPlayer.CheckIsPlaying(18))
		{
			this.PendingQuestTrackCellActive = new bool?(bState);
			return;
		}
		this.IsQuestTrackCellActive = bState;
		this.QuestTrackCellItem.SetUIActive(bState);
	}

	// Token: 0x0600ED0D RID: 60685 RVA: 0x00458CAA File Offset: 0x00456EAA
	public void SetPlayerInfoItemState(bool bState)
	{
		this.PlayerInfoItem.SetUIActive(bState);
	}

	// Token: 0x0600ED0E RID: 60686 RVA: 0x00458CB8 File Offset: 0x00456EB8
	public void SetNameTextItemState(bool bState)
	{
		this.NameText.SetUIActive(bState);
	}

	// Token: 0x0600ED0F RID: 60687 RVA: 0x00458CC8 File Offset: 0x00456EC8
	public void SetRootItemState(bool bState, bool force = false)
	{
		if (this.ForceHideRootItem)
		{
			if (this.RootItem.bIsUIActive)
			{
				this.SetActive(false);
			}
			this.IsRootItemActive = bState;
			return;
		}
		if (this.IsRootItemActive == bState && !force)
		{
			return;
		}
		this.IsRootItemActive = bState;
		this.SetActive(bState && !UiLayer.Instance.IsForceHideUi());
	}

	// Token: 0x0600ED10 RID: 60688 RVA: 0x00458D26 File Offset: 0x00456F26
	public bool GetRootItemState()
	{
		return this.IsRootItemActive;
	}

	// Token: 0x0600ED11 RID: 60689 RVA: 0x00458D2E File Offset: 0x00456F2E
	public void SetTrackEffectState(bool bState)
	{
		if (this.IsTrackEffectActive == bState)
		{
			return;
		}
		this.IsTrackEffectActive = bState;
		EffectSystem.Instance.SetEffectHidden(this.TrackedEffect, bState, "NpcIconComponentView", false);
	}

	// Token: 0x0600ED12 RID: 60690 RVA: 0x00458D58 File Offset: 0x00456F58
	public void SetHeadInfoNameState(bool bState)
	{
		if (this.IsHeadInfoNameActive == bState)
		{
			return;
		}
		this.IsHeadInfoNameActive = bState;
		this.NameMessageItem.SetUIActive(bState);
		this.DialogItem.SetUIActive(bState && this.IsDialogActive);
	}

	// Token: 0x0600ED13 RID: 60691 RVA: 0x00458D8E File Offset: 0x00456F8E
	public bool GetHeadInfoNameState()
	{
		return this.IsHeadInfoNameActive;
	}

	// Token: 0x0600ED14 RID: 60692 RVA: 0x00458D96 File Offset: 0x00456F96
	public void SetNpcQuestIconState(bool bState)
	{
		this.SetHeadIconState(bState);
	}

	// Token: 0x0600ED15 RID: 60693 RVA: 0x00458DA0 File Offset: 0x00456FA0
	public void SetNpcSecondName(string name)
	{
		UUIText text = base.GetText(1);
		if (!string.IsNullOrEmpty(name))
		{
			text.SetUIActive(true);
			text.ShowTextNew(name);
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600ED16 RID: 60694 RVA: 0x00458DD4 File Offset: 0x00456FD4
	public void SetFunctionIcon(string path, Action<bool> doneCallback = null)
	{
		if (!string.IsNullOrEmpty(path))
		{
			this.SetHeadIconState(true);
			base.SetTextureByPath(path, this.HeadIcon, null, doneCallback);
			this.HeadIconType = new EHeadIconType?(EHeadIconType.Function);
			return;
		}
		this.SetHeadIconState(false);
	}

	// Token: 0x0600ED17 RID: 60695 RVA: 0x00458E1C File Offset: 0x0045701C
	public void SetNpcQuestIcon(string path)
	{
		if (!string.IsNullOrEmpty(path))
		{
			base.SetTextureByPath(path, this.HeadIcon, null, null);
			this.SetHeadIconState(true);
			this.HeadIconType = new EHeadIconType?(EHeadIconType.Quest);
			return;
		}
		this.SetHeadIconState(false);
	}

	// Token: 0x0600ED18 RID: 60696 RVA: 0x00458E64 File Offset: 0x00457064
	public void SetPlayerInfoIcon(string path, Action<bool> callback)
	{
		if (string.IsNullOrEmpty(path) || this.PlayerInfoItem == null)
		{
			return;
		}
		this.SetSpriteByPath(path, this.PlayerInfoItem, true, null, callback);
	}

	// Token: 0x0600ED19 RID: 60697 RVA: 0x00458E9A File Offset: 0x0045709A
	public void SnapSizeFromTexture()
	{
		UUITexture headIcon = this.HeadIcon;
		if (headIcon == null)
		{
			return;
		}
		headIcon.SetSizeFromTexture();
	}

	// Token: 0x0600ED1A RID: 60698 RVA: 0x00458EAC File Offset: 0x004570AC
	public void SetHeadWorldScale3D(float scale)
	{
		if (!this.IsHeadItemActive)
		{
			return;
		}
		if (MathUtils.Instance.IsNearlyEqual(this.CacheHeadScale, (double)scale, new double?(0.01)))
		{
			return;
		}
		this.CacheHeadScale = (double)scale;
		this.CurrentHeadScale.X = (double)scale;
		this.CurrentHeadScale.Y = (double)scale;
		this.CurrentHeadScale.Z = (double)scale;
		this.HeadItem.D_SetWorldScale3D(this.CurrentHeadScale);
	}

	// Token: 0x0600ED1B RID: 60699 RVA: 0x00458F28 File Offset: 0x00457128
	public void SetDialogWorldScale3D(float scale)
	{
		if (this.CacheDialogScale == (double)scale)
		{
			return;
		}
		this.CacheDialogScale = (double)scale;
		this.CurrentDialogScale.X = (double)scale;
		this.CurrentDialogScale.Y = (double)scale;
		this.CurrentDialogScale.Z = (double)scale;
		this.DialogItem.D_SetWorldScale3D(this.CurrentDialogScale);
	}

	// Token: 0x0600ED1C RID: 60700 RVA: 0x00458F80 File Offset: 0x00457180
	private void SetHeadIconState(bool state)
	{
		if (state == this.IsHeadIconActive)
		{
			return;
		}
		this.IsHeadIconActive = state;
		this.HeadIcon.SetUIActive(state);
	}

	// Token: 0x0600ED1D RID: 60701 RVA: 0x00458FA0 File Offset: 0x004571A0
	protected override void OnBeforeDestroy()
	{
		if (EffectSystem.Instance.IsValid(this.TrackedEffect))
		{
			EffectSystem.Instance.StopEffectById(this.TrackedEffect, "[NpcIconComponentView.OnBeforeDestroy]", true, null);
			this.TrackedEffect = 0;
		}
		BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
		if (tweenAnimPlayer == null)
		{
			return;
		}
		tweenAnimPlayer.Clear(false);
	}

	// Token: 0x0400864F RID: 34383
	protected FRotator RootActorRotation;

	// Token: 0x04008650 RID: 34384
	private FVectorDouble RootActorLocationOffset;

	// Token: 0x04008651 RID: 34385
	private bool IsHeadInfoNameActive;

	// Token: 0x04008652 RID: 34386
	private bool IsRootItemActive;

	// Token: 0x04008653 RID: 34387
	private bool ForceHideRootItemInner;

	// Token: 0x04008654 RID: 34388
	private bool IsHeadItemActive;

	// Token: 0x04008655 RID: 34389
	private bool IsTrackEffectActive;

	// Token: 0x04008656 RID: 34390
	private bool IsHeadIconActive;

	// Token: 0x04008657 RID: 34391
	private bool IsDialogActive;

	// Token: 0x04008658 RID: 34392
	private bool IsDialogRedDotActive;

	// Token: 0x04008659 RID: 34393
	private bool ForceHideDialogInner;

	// Token: 0x0400865A RID: 34394
	private bool? PendingQuestTrackCellActive;

	// Token: 0x0400865B RID: 34395
	private UUIText NameText;

	// Token: 0x0400865C RID: 34396
	private UUIItem NameMessageItem;

	// Token: 0x0400865D RID: 34397
	private UUITexture HeadIcon;

	// Token: 0x0400865E RID: 34398
	private FVectorDouble CurrentHeadScale = new FVectorDouble(1.0, 1.0, 1.0);

	// Token: 0x0400865F RID: 34399
	private double CacheHeadScale;

	// Token: 0x04008660 RID: 34400
	private UUIItem HeadItem;

	// Token: 0x04008661 RID: 34401
	private UUIItem QuestTrackCellItem;

	// Token: 0x04008662 RID: 34402
	private UUISprite PlayerInfoItem;

	// Token: 0x04008663 RID: 34403
	private UUIItem RedDotItem;

	// Token: 0x04008664 RID: 34404
	private FVectorDouble CurrentDialogScale = new FVectorDouble(1.0, 1.0, 1.0);

	// Token: 0x04008665 RID: 34405
	private double CacheDialogScale;

	// Token: 0x04008666 RID: 34406
	private UUIItem DialogItem;

	// Token: 0x04008667 RID: 34407
	private int TrackedEffect;

	// Token: 0x04008668 RID: 34408
	private EHeadIconType? HeadIconType;

	// Token: 0x04008669 RID: 34409
	private bool IsQuestTrackCellActive;

	// Token: 0x0400866A RID: 34410
	private bool IsPlayingHiddenSequence;

	// Token: 0x0400866B RID: 34411
	private BattleUiTweenAnimPlayer TweenAnimPlayer;
}
