using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A81 RID: 6785
[NullableContext(2)]
[Nullable(0)]
public class DeadEyeTargetItem : CommonMarkItem
{
	// Token: 0x0600C7EE RID: 51182 RVA: 0x002D8C79 File Offset: 0x002D6E79
	[NullableContext(1)]
	public DeadEyeTargetItem(in FVectorDouble TargetLocation, Vector2D AimRange, [Nullable(2)] EntityHandle TargetEntity = null) : base(TargetLocation, null)
	{
	}

	// Token: 0x17001065 RID: 4197
	// (get) Token: 0x0600C7EF RID: 51183 RVA: 0x002D8C91 File Offset: 0x002D6E91
	// (set) Token: 0x0600C7F0 RID: 51184 RVA: 0x002D8C99 File Offset: 0x002D6E99
	public bool IsLocked
	{
		get
		{
			return this.IsLockedInner;
		}
		set
		{
			this.IsLockedInner = value;
			this.OnLockStateChange(value);
		}
	}

	// Token: 0x0600C7F1 RID: 51185 RVA: 0x002D8CAC File Offset: 0x002D6EAC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
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
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C7F2 RID: 51186 RVA: 0x002D8DBC File Offset: 0x002D6FBC
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(1);
		this.NotLockSequencePlayer = new LevelSequencePlayer(item);
		UUIItem item2 = base.GetItem(2);
		this.LockedSequencePlayer = new LevelSequencePlayer(item2);
		UUIItem item3 = base.GetItem(4);
		this.OutsideItemSequencePlayer = new LevelSequencePlayer(item3);
		base.UpdatePositionAndRotation();
		this.IsLocked = false;
	}

	// Token: 0x0600C7F3 RID: 51187 RVA: 0x002D8E12 File Offset: 0x002D7012
	protected override void OnAfterShow()
	{
		this.InRangeStateChanged(base.IsInRange(), true);
	}

	// Token: 0x0600C7F4 RID: 51188 RVA: 0x002D8E24 File Offset: 0x002D7024
	protected override UniTask OnBeforeHideAsync()
	{
		DeadEyeTargetItem.<OnBeforeHideAsync>d__15 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DeadEyeTargetItem.<OnBeforeHideAsync>d__15>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7F5 RID: 51189 RVA: 0x002D8E67 File Offset: 0x002D7067
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600C7F6 RID: 51190 RVA: 0x002D8E6C File Offset: 0x002D706C
	public override void OnTick(float delta)
	{
		if (this.RootItem == null || !base.GetActive() || !DeadEyeModeModel.Instance.ViewStartSequenceFinish)
		{
			return;
		}
		base.OnTick(delta);
		FVector2D anchorOffset = this.RootItem.GetAnchorOffset();
		bool flag = this.CheckIsHover(anchorOffset);
		if (flag != this.IsHover)
		{
			this.OnHoverStateChanged(flag);
		}
	}

	// Token: 0x0600C7F7 RID: 51191 RVA: 0x002D8EC4 File Offset: 0x002D70C4
	public UniTask PlayClickSequence()
	{
		DeadEyeTargetItem.<PlayClickSequence>d__18 <PlayClickSequence>d__;
		<PlayClickSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayClickSequence>d__.<>4__this = this;
		<PlayClickSequence>d__.<>1__state = -1;
		<PlayClickSequence>d__.<>t__builder.Start<DeadEyeTargetItem.<PlayClickSequence>d__18>(ref <PlayClickSequence>d__);
		return <PlayClickSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7F8 RID: 51192 RVA: 0x002D8F08 File Offset: 0x002D7108
	protected override void OnScreenPositionChanged(bool bInRange)
	{
		UUIItem item = base.GetItem(4);
		if (!bInRange && item != null)
		{
			UUIItem uuiitem = item;
			FRotator frotator = new FRotator();
			frotator.Yaw = (float)Math.Atan2(this.ScreenPosition.Y, this.ScreenPosition.X) * 57.295776f;
			uuiitem.SetUIRelativeRotation(frotator);
		}
	}

	// Token: 0x0600C7F9 RID: 51193 RVA: 0x002D8F5C File Offset: 0x002D715C
	protected override void InRangeStateChanged(bool bInRange, bool bFirst = false)
	{
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(bInRange);
		}
		if (item2 != null)
		{
			item2.SetUIActive(!bInRange && !this.IsLocked);
		}
		if (!base.GetActive() || base.IsHideOrHiding)
		{
			return;
		}
		if (bInRange)
		{
			if (this.IsLocked)
			{
				LevelSequencePlayer lockedSequencePlayer = this.LockedSequencePlayer;
				if (lockedSequencePlayer != null)
				{
					lockedSequencePlayer.PlayLevelSequenceByName(bFirst ? "Start" : "ShowView", false, null, false);
				}
			}
			else
			{
				LevelSequencePlayer notLockSequencePlayer = this.NotLockSequencePlayer;
				if (notLockSequencePlayer != null)
				{
					notLockSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
				}
			}
			LevelSequencePlayer outsideItemSequencePlayer = this.OutsideItemSequencePlayer;
			if (outsideItemSequencePlayer == null)
			{
				return;
			}
			outsideItemSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
			return;
		}
		else
		{
			if (this.IsLocked)
			{
				LevelSequencePlayer lockedSequencePlayer2 = this.LockedSequencePlayer;
				if (lockedSequencePlayer2 != null)
				{
					lockedSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
				}
			}
			else
			{
				LevelSequencePlayer notLockSequencePlayer2 = this.NotLockSequencePlayer;
				if (notLockSequencePlayer2 != null)
				{
					notLockSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
				}
			}
			LevelSequencePlayer outsideItemSequencePlayer2 = this.OutsideItemSequencePlayer;
			if (outsideItemSequencePlayer2 == null)
			{
				return;
			}
			outsideItemSequencePlayer2.PlayLevelSequenceByName("Start", false, null, false);
			return;
		}
	}

	// Token: 0x0600C7FA RID: 51194 RVA: 0x002D9093 File Offset: 0x002D7293
	private void OnHoverStateChanged(bool bHover)
	{
		this.IsHover = bHover;
		EventSystem.Instance.Emit<bool>(EEventName.DeadEyeModeTargetPointCanLockStateChange, this.IsHover);
		this.LockTarget();
	}

	// Token: 0x0600C7FB RID: 51195 RVA: 0x002D90B8 File Offset: 0x002D72B8
	private bool CheckIsHover(in FVector2D offset)
	{
		double num = this.AimRange.X * 0.5;
		double num2 = this.AimRange.Y * 0.5;
		return (double)offset.X >= -num && (double)offset.X <= num && (double)offset.Y >= -num2 && (double)offset.Y <= num2;
	}

	// Token: 0x0600C7FC RID: 51196 RVA: 0x002D9120 File Offset: 0x002D7320
	private void LockTarget()
	{
		if (this.IsLocked)
		{
			return;
		}
		if (!DeadEyeModeModel.Instance.CheckEnergyEnoughLockTarget())
		{
			Log.Instance.Info(ELogModule.UiCommon, ELogAuthor.YSQ, "当前能量不足以再射一发子弹", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.IsLocked = true;
		if (this.TargetEntity != null)
		{
			DeadEyeModeModel.Instance.RecordLockedTarget(this.TargetEntity);
		}
		EventSystem.Instance.Emit(EEventName.DeadEyeModeTargetPointLocked);
		LevelSequencePlayer lockedSequencePlayer = this.LockedSequencePlayer;
		if (lockedSequencePlayer == null)
		{
			return;
		}
		lockedSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600C7FD RID: 51197 RVA: 0x002D91B0 File Offset: 0x002D73B0
	private void OnLockStateChange(bool bLock)
	{
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(!bLock);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(bLock);
		}
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(bLock);
		}
		UUIItem item4 = base.GetItem(5);
		if (item4 != null)
		{
			item4.SetUIActive(!bLock);
		}
		if (bLock && this.TargetEntity != null)
		{
			DeadEyeModeController.Instance.EnableSingleEntityHighlight(this.TargetEntity, ETargetHighlightType.Locked);
		}
	}

	// Token: 0x04005C53 RID: 23635
	private bool IsHover;

	// Token: 0x04005C54 RID: 23636
	private bool IsLockedInner;

	// Token: 0x04005C55 RID: 23637
	private LevelSequencePlayer LockedSequencePlayer;

	// Token: 0x04005C56 RID: 23638
	private LevelSequencePlayer NotLockSequencePlayer;

	// Token: 0x04005C57 RID: 23639
	private LevelSequencePlayer OutsideItemSequencePlayer;

	// Token: 0x04005C58 RID: 23640
	[Nullable(1)]
	public readonly Vector2D AimRange = AimRange;

	// Token: 0x04005C59 RID: 23641
	public readonly EntityHandle TargetEntity = TargetEntity;

	// Token: 0x02007FDE RID: 32734
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04029BDF RID: 170975
		public const int RootButton = 0;

		// Token: 0x04029BE0 RID: 170976
		public const int PanelNotLock = 1;

		// Token: 0x04029BE1 RID: 170977
		public const int PanelLocked = 2;

		// Token: 0x04029BE2 RID: 170978
		public const int InsideItem = 3;

		// Token: 0x04029BE3 RID: 170979
		public const int OutsideItem = 4;

		// Token: 0x04029BE4 RID: 170980
		public const int OutsideNormalItem = 5;

		// Token: 0x04029BE5 RID: 170981
		public const int OutsideLockItem = 6;
	}
}
