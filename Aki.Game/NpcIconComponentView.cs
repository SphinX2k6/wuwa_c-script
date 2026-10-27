using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022D8 RID: 8920
[NullableContext(2)]
[Nullable(0)]
public class NpcIconComponentView : UiPanelBase
{
	// Token: 0x17001650 RID: 5712
	// (get) Token: 0x06011865 RID: 71781 RVA: 0x0044B7FA File Offset: 0x004499FA
	// (set) Token: 0x06011866 RID: 71782 RVA: 0x0044B802 File Offset: 0x00449A02
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

	// Token: 0x17001651 RID: 5713
	// (get) Token: 0x06011867 RID: 71783 RVA: 0x0044B826 File Offset: 0x00449A26
	// (set) Token: 0x06011868 RID: 71784 RVA: 0x0044B82E File Offset: 0x00449A2E
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

	// Token: 0x06011869 RID: 71785 RVA: 0x0044B858 File Offset: 0x00449A58
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

	// Token: 0x0601186A RID: 71786 RVA: 0x0044BABC File Offset: 0x00449CBC
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

	// Token: 0x0601186B RID: 71787 RVA: 0x0044BC10 File Offset: 0x00449E10
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

	// Token: 0x0601186C RID: 71788 RVA: 0x0044BCF4 File Offset: 0x00449EF4
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

	// Token: 0x0601186D RID: 71789 RVA: 0x0044BD28 File Offset: 0x00449F28
	public void InitItemLocation(FVectorDouble location, double offsetZ)
	{
		this.RootActorLocationOffset = location;
		FVectorDouble rootActorLocationOffset = this.RootActorLocationOffset;
		rootActorLocationOffset.Z = location.Z + offsetZ;
		this.RootActor.D_K2_SetActorLocation(rootActorLocationOffset, false, ref WorldGlobal.SweepHitResult, false);
	}

	// Token: 0x0601186E RID: 71790 RVA: 0x0044BD68 File Offset: 0x00449F68
	public void UpdateRotation(float yaw, float pitch)
	{
		float roll = pitch - 90f;
		float yaw2 = yaw + 90f;
		this.RootActorRotation.Roll = roll;
		this.RootActorRotation.Pitch = 0f;
		this.RootActorRotation.Yaw = yaw2;
		this.RootItem.SetUIWorldRotation(this.RootActorRotation);
	}

	// Token: 0x0601186F RID: 71791 RVA: 0x0044BDC0 File Offset: 0x00449FC0
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

	// Token: 0x06011870 RID: 71792 RVA: 0x0044BE61 File Offset: 0x0044A061
	public bool GetDialogueActive()
	{
		return this.IsDialogActive;
	}

	// Token: 0x06011871 RID: 71793 RVA: 0x0044BE69 File Offset: 0x0044A069
	[NullableContext(1)]
	public void SetDialogueText(string text)
	{
		base.GetText(3).SetText(text, true);
	}

	// Token: 0x06011872 RID: 71794 RVA: 0x0044BE7C File Offset: 0x0044A07C
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

	// Token: 0x06011873 RID: 71795 RVA: 0x0044BF43 File Offset: 0x0044A143
	public bool GetHeadItemState()
	{
		return this.IsHeadItemActive;
	}

	// Token: 0x06011874 RID: 71796 RVA: 0x0044BF4B File Offset: 0x0044A14B
	public bool GetHeadIconActive()
	{
		return this.IsHeadIconActive;
	}

	// Token: 0x06011875 RID: 71797 RVA: 0x0044BF54 File Offset: 0x0044A154
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

	// Token: 0x06011876 RID: 71798 RVA: 0x0044BFA2 File Offset: 0x0044A1A2
	public void SetPlayerInfoItemState(bool bState)
	{
		this.PlayerInfoItem.SetUIActive(bState);
	}

	// Token: 0x06011877 RID: 71799 RVA: 0x0044BFB0 File Offset: 0x0044A1B0
	public void SetNameTextItemState(bool bState)
	{
		this.NameText.SetUIActive(bState);
	}

	// Token: 0x06011878 RID: 71800 RVA: 0x0044BFC0 File Offset: 0x0044A1C0
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

	// Token: 0x06011879 RID: 71801 RVA: 0x0044C01E File Offset: 0x0044A21E
	public bool GetRootItemState()
	{
		return this.IsRootItemActive;
	}

	// Token: 0x0601187A RID: 71802 RVA: 0x0044C026 File Offset: 0x0044A226
	public void SetTrackEffectState(bool bState)
	{
		if (this.IsTrackEffectActive == bState)
		{
			return;
		}
		this.IsTrackEffectActive = bState;
		EffectSystem.Instance.SetEffectHidden(this.TrackedEffect, bState, "NpcIconComponentView", false);
	}

	// Token: 0x0601187B RID: 71803 RVA: 0x0044C050 File Offset: 0x0044A250
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

	// Token: 0x0601187C RID: 71804 RVA: 0x0044C086 File Offset: 0x0044A286
	public bool GetHeadInfoNameState()
	{
		return this.IsHeadInfoNameActive;
	}

	// Token: 0x0601187D RID: 71805 RVA: 0x0044C08E File Offset: 0x0044A28E
	public void SetNpcQuestIconState(bool bState)
	{
		this.SetHeadIconState(bState);
	}

	// Token: 0x0601187E RID: 71806 RVA: 0x0044C098 File Offset: 0x0044A298
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

	// Token: 0x0601187F RID: 71807 RVA: 0x0044C0CC File Offset: 0x0044A2CC
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

	// Token: 0x06011880 RID: 71808 RVA: 0x0044C114 File Offset: 0x0044A314
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

	// Token: 0x06011881 RID: 71809 RVA: 0x0044C15C File Offset: 0x0044A35C
	public void SetPlayerInfoIcon(string path, Action<bool> callback)
	{
		if (string.IsNullOrEmpty(path) || this.PlayerInfoItem == null)
		{
			return;
		}
		this.SetSpriteByPath(path, this.PlayerInfoItem, true, null, callback);
	}

	// Token: 0x06011882 RID: 71810 RVA: 0x0044C192 File Offset: 0x0044A392
	public void SnapSizeFromTexture()
	{
		UUITexture headIcon = this.HeadIcon;
		if (headIcon == null)
		{
			return;
		}
		headIcon.SetSizeFromTexture();
	}

	// Token: 0x06011883 RID: 71811 RVA: 0x0044C1A4 File Offset: 0x0044A3A4
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

	// Token: 0x06011884 RID: 71812 RVA: 0x0044C220 File Offset: 0x0044A420
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

	// Token: 0x06011885 RID: 71813 RVA: 0x0044C278 File Offset: 0x0044A478
	private void SetHeadIconState(bool state)
	{
		if (state == this.IsHeadIconActive)
		{
			return;
		}
		this.IsHeadIconActive = state;
		this.HeadIcon.SetUIActive(state);
	}

	// Token: 0x06011886 RID: 71814 RVA: 0x0044C298 File Offset: 0x0044A498
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

	// Token: 0x04008511 RID: 34065
	protected FRotator RootActorRotation;

	// Token: 0x04008512 RID: 34066
	private FVectorDouble RootActorLocationOffset;

	// Token: 0x04008513 RID: 34067
	private bool IsHeadInfoNameActive;

	// Token: 0x04008514 RID: 34068
	private bool IsRootItemActive;

	// Token: 0x04008515 RID: 34069
	private bool ForceHideRootItemInner;

	// Token: 0x04008516 RID: 34070
	private bool IsHeadItemActive;

	// Token: 0x04008517 RID: 34071
	private bool IsTrackEffectActive;

	// Token: 0x04008518 RID: 34072
	private bool IsHeadIconActive;

	// Token: 0x04008519 RID: 34073
	private bool IsDialogActive;

	// Token: 0x0400851A RID: 34074
	private bool IsDialogRedDotActive;

	// Token: 0x0400851B RID: 34075
	private bool ForceHideDialogInner;

	// Token: 0x0400851C RID: 34076
	private bool? PendingQuestTrackCellActive;

	// Token: 0x0400851D RID: 34077
	private UUIText NameText;

	// Token: 0x0400851E RID: 34078
	private UUIItem NameMessageItem;

	// Token: 0x0400851F RID: 34079
	private UUITexture HeadIcon;

	// Token: 0x04008520 RID: 34080
	private FVectorDouble CurrentHeadScale = new FVectorDouble(1.0, 1.0, 1.0);

	// Token: 0x04008521 RID: 34081
	private double CacheHeadScale;

	// Token: 0x04008522 RID: 34082
	private UUIItem HeadItem;

	// Token: 0x04008523 RID: 34083
	private UUIItem QuestTrackCellItem;

	// Token: 0x04008524 RID: 34084
	private UUISprite PlayerInfoItem;

	// Token: 0x04008525 RID: 34085
	private UUIItem RedDotItem;

	// Token: 0x04008526 RID: 34086
	private FVectorDouble CurrentDialogScale = new FVectorDouble(1.0, 1.0, 1.0);

	// Token: 0x04008527 RID: 34087
	private double CacheDialogScale;

	// Token: 0x04008528 RID: 34088
	private UUIItem DialogItem;

	// Token: 0x04008529 RID: 34089
	private int TrackedEffect;

	// Token: 0x0400852A RID: 34090
	private EHeadIconType? HeadIconType;

	// Token: 0x0400852B RID: 34091
	private bool IsQuestTrackCellActive;

	// Token: 0x0400852C RID: 34092
	private bool IsPlayingHiddenSequence;

	// Token: 0x0400852D RID: 34093
	private BattleUiTweenAnimPlayer TweenAnimPlayer;
}
