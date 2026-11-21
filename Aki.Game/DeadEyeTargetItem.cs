using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F40 RID: 3904
[NullableContext(2)]
[Nullable(0)]
public class DeadEyeTargetItem : CommonMarkItem
{
	// Token: 0x06009BFE RID: 39934 RVA: 0x002E3D95 File Offset: 0x002E1F95
	[NullableContext(1)]
	public DeadEyeTargetItem(in FVectorDouble TargetLocation, Vector2D AimRange, [Nullable(2)] EntityHandle TargetEntity = null) : base(TargetLocation, null)
	{
	}

	// Token: 0x1700108A RID: 4234
	// (get) Token: 0x06009BFF RID: 39935 RVA: 0x002E3DAD File Offset: 0x002E1FAD
	// (set) Token: 0x06009C00 RID: 39936 RVA: 0x002E3DB5 File Offset: 0x002E1FB5
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

	// Token: 0x06009C01 RID: 39937 RVA: 0x002E3DC8 File Offset: 0x002E1FC8
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

	// Token: 0x06009C02 RID: 39938 RVA: 0x002E3ED8 File Offset: 0x002E20D8
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

	// Token: 0x06009C03 RID: 39939 RVA: 0x002E3F2E File Offset: 0x002E212E
	protected override void OnAfterShow()
	{
		this.InRangeStateChanged(base.IsInRange(), true);
	}

	// Token: 0x06009C04 RID: 39940 RVA: 0x002E3F40 File Offset: 0x002E2140
	protected override UniTask OnBeforeHideAsync()
	{
		DeadEyeTargetItem.<OnBeforeHideAsync>d__15 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DeadEyeTargetItem.<OnBeforeHideAsync>d__15>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009C05 RID: 39941 RVA: 0x002E3F83 File Offset: 0x002E2183
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x06009C06 RID: 39942 RVA: 0x002E3F88 File Offset: 0x002E2188
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

	// Token: 0x06009C07 RID: 39943 RVA: 0x002E3FE0 File Offset: 0x002E21E0
	public UniTask PlayClickSequence()
	{
		DeadEyeTargetItem.<PlayClickSequence>d__18 <PlayClickSequence>d__;
		<PlayClickSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayClickSequence>d__.<>4__this = this;
		<PlayClickSequence>d__.<>1__state = -1;
		<PlayClickSequence>d__.<>t__builder.Start<DeadEyeTargetItem.<PlayClickSequence>d__18>(ref <PlayClickSequence>d__);
		return <PlayClickSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06009C08 RID: 39944 RVA: 0x002E4024 File Offset: 0x002E2224
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

	// Token: 0x06009C09 RID: 39945 RVA: 0x002E4078 File Offset: 0x002E2278
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

	// Token: 0x06009C0A RID: 39946 RVA: 0x002E41AF File Offset: 0x002E23AF
	private void OnHoverStateChanged(bool bHover)
	{
		this.IsHover = bHover;
		EventSystem.Instance.Emit<bool>(EEventName.DeadEyeModeTargetPointCanLockStateChange, this.IsHover);
		this.LockTarget();
	}

	// Token: 0x06009C0B RID: 39947 RVA: 0x002E41D4 File Offset: 0x002E23D4
	private bool CheckIsHover(in FVector2D offset)
	{
		double num = this.AimRange.X * 0.5;
		double num2 = this.AimRange.Y * 0.5;
		return (double)offset.X >= -num && (double)offset.X <= num && (double)offset.Y >= -num2 && (double)offset.Y <= num2;
	}

	// Token: 0x06009C0C RID: 39948 RVA: 0x002E423C File Offset: 0x002E243C
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

	// Token: 0x06009C0D RID: 39949 RVA: 0x002E42CC File Offset: 0x002E24CC
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

	// Token: 0x04005D22 RID: 23842
	private bool IsHover;

	// Token: 0x04005D23 RID: 23843
	private bool IsLockedInner;

	// Token: 0x04005D24 RID: 23844
	private LevelSequencePlayer LockedSequencePlayer;

	// Token: 0x04005D25 RID: 23845
	private LevelSequencePlayer NotLockSequencePlayer;

	// Token: 0x04005D26 RID: 23846
	private LevelSequencePlayer OutsideItemSequencePlayer;

	// Token: 0x04005D27 RID: 23847
	[Nullable(1)]
	public readonly Vector2D AimRange = AimRange;

	// Token: 0x04005D28 RID: 23848
	public readonly EntityHandle TargetEntity = TargetEntity;

	// Token: 0x0200716D RID: 29037
	[NullableContext(0)]
	private class EViewComponent
	{
		// Token: 0x04024F1C RID: 151324
		public const int RootButton = 0;

		// Token: 0x04024F1D RID: 151325
		public const int PanelNotLock = 1;

		// Token: 0x04024F1E RID: 151326
		public const int PanelLocked = 2;

		// Token: 0x04024F1F RID: 151327
		public const int InsideItem = 3;

		// Token: 0x04024F20 RID: 151328
		public const int OutsideItem = 4;

		// Token: 0x04024F21 RID: 151329
		public const int OutsideNormalItem = 5;

		// Token: 0x04024F22 RID: 151330
		public const int OutsideLockItem = 6;
	}
}
