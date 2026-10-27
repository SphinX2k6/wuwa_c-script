using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Common;
using CSharpScript.Game.Module.BattleUi;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A7D RID: 6781
public class DeadEyeFloaterShooterTargetItem : CommonMarkItem
{
	// Token: 0x0600C7B9 RID: 51129 RVA: 0x002D7C6F File Offset: 0x002D5E6F
	[NullableContext(1)]
	public DeadEyeFloaterShooterTargetItem(in FVectorDouble TargetLocation, Vector2D AimRange, [Nullable(2)] EntityHandle TargetEntity = null) : base(TargetLocation, null)
	{
	}

	// Token: 0x0600C7BA RID: 51130 RVA: 0x002D7C88 File Offset: 0x002D5E88
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C7BB RID: 51131 RVA: 0x002D7CD0 File Offset: 0x002D5ED0
	protected override void OnStart()
	{
		this.LockedSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.UpdatePositionAndRotation();
		base.GetItem(0).SetUIActive(false);
		this.IsLockedInner = false;
	}

	// Token: 0x0600C7BC RID: 51132 RVA: 0x002D7D00 File Offset: 0x002D5F00
	protected override UniTask OnBeforeHideAsync()
	{
		DeadEyeFloaterShooterTargetItem.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DeadEyeFloaterShooterTargetItem.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7BD RID: 51133 RVA: 0x002D7D44 File Offset: 0x002D5F44
	public override void OnTick(float delta)
	{
		if (this.RootItem == null || base.IsCreateOrCreating)
		{
			return;
		}
		TsCharacterController characterController = Global.CharacterController;
		if (characterController == null)
		{
			return;
		}
		UGameplayStatics.D_ProjectWorldToScreen(characterController, this.TargetPosition, ref this.ScreenPositionRef, false);
		this.ScreenPosition.Set((double)this.ScreenPositionRef.X, (double)this.ScreenPositionRef.Y);
		BattleUiModel instance = BattleUiModel.Instance;
		this.ScreenPosition.MultiplyEqual((double)instance.ScreenPositionScale).AdditionEqual(instance.ScreenPositionOffset).MultiplyEqual(this.PointTransport);
		Vector2D vector2D = this.ScreenPosition.AdditionEqual(this.Center);
		this.RootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
		if (!this.IsLocked)
		{
			FVector2D anchorOffset = this.RootItem.GetAnchorOffset();
			if (this.CheckIsHover(anchorOffset))
			{
				this.LockTarget();
				this.IsLockedInner = true;
			}
		}
		base.GetItem(0).SetUIActive(this.IsLocked);
	}

	// Token: 0x0600C7BE RID: 51134 RVA: 0x002D7E34 File Offset: 0x002D6034
	public UniTask PlayClickSequence()
	{
		DeadEyeFloaterShooterTargetItem.<PlayClickSequence>d__10 <PlayClickSequence>d__;
		<PlayClickSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayClickSequence>d__.<>4__this = this;
		<PlayClickSequence>d__.<>1__state = -1;
		<PlayClickSequence>d__.<>t__builder.Start<DeadEyeFloaterShooterTargetItem.<PlayClickSequence>d__10>(ref <PlayClickSequence>d__);
		return <PlayClickSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7BF RID: 51135 RVA: 0x002D7E78 File Offset: 0x002D6078
	private bool CheckIsHover(in FVector2D offset)
	{
		double num = this.AimRange.X * 0.5;
		double num2 = this.AimRange.Y * 0.5;
		return (double)offset.X >= -num && (double)offset.X <= num && (double)offset.Y >= -num2 && (double)offset.Y <= num2;
	}

	// Token: 0x0600C7C0 RID: 51136 RVA: 0x002D7EE0 File Offset: 0x002D60E0
	private void LockTarget()
	{
		if (this.IsLocked)
		{
			return;
		}
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

	// Token: 0x17001064 RID: 4196
	// (get) Token: 0x0600C7C1 RID: 51137 RVA: 0x002D7F3E File Offset: 0x002D613E
	public bool IsLocked
	{
		get
		{
			return this.IsLockedInner;
		}
	}

	// Token: 0x04005C3A RID: 23610
	private bool IsLockedInner;

	// Token: 0x04005C3B RID: 23611
	[Nullable(2)]
	private LevelSequencePlayer LockedSequencePlayer;

	// Token: 0x04005C3C RID: 23612
	[Nullable(1)]
	public readonly Vector2D AimRange = AimRange;

	// Token: 0x04005C3D RID: 23613
	[Nullable(2)]
	public readonly EntityHandle TargetEntity = TargetEntity;

	// Token: 0x02007FCB RID: 32715
	private class EViewComponent
	{
		// Token: 0x04029B8E RID: 170894
		public const int RootItem = 0;
	}
}
