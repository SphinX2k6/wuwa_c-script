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

// Token: 0x02000F3C RID: 3900
public class DeadEyeFloaterShooterTargetItem : CommonMarkItem
{
	// Token: 0x06009BC9 RID: 39881 RVA: 0x002E2D8B File Offset: 0x002E0F8B
	[NullableContext(1)]
	public DeadEyeFloaterShooterTargetItem(in FVectorDouble TargetLocation, Vector2D AimRange, [Nullable(2)] EntityHandle TargetEntity = null) : base(TargetLocation, null)
	{
	}

	// Token: 0x06009BCA RID: 39882 RVA: 0x002E2DA4 File Offset: 0x002E0FA4
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

	// Token: 0x06009BCB RID: 39883 RVA: 0x002E2DEC File Offset: 0x002E0FEC
	protected override void OnStart()
	{
		this.LockedSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.UpdatePositionAndRotation();
		base.GetItem(0).SetUIActive(false);
		this.IsLockedInner = false;
	}

	// Token: 0x06009BCC RID: 39884 RVA: 0x002E2E1C File Offset: 0x002E101C
	protected override UniTask OnBeforeHideAsync()
	{
		DeadEyeFloaterShooterTargetItem.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<DeadEyeFloaterShooterTargetItem.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009BCD RID: 39885 RVA: 0x002E2E60 File Offset: 0x002E1060
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

	// Token: 0x06009BCE RID: 39886 RVA: 0x002E2F50 File Offset: 0x002E1150
	public UniTask PlayClickSequence()
	{
		DeadEyeFloaterShooterTargetItem.<PlayClickSequence>d__10 <PlayClickSequence>d__;
		<PlayClickSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayClickSequence>d__.<>4__this = this;
		<PlayClickSequence>d__.<>1__state = -1;
		<PlayClickSequence>d__.<>t__builder.Start<DeadEyeFloaterShooterTargetItem.<PlayClickSequence>d__10>(ref <PlayClickSequence>d__);
		return <PlayClickSequence>d__.<>t__builder.Task;
	}

	// Token: 0x06009BCF RID: 39887 RVA: 0x002E2F94 File Offset: 0x002E1194
	private bool CheckIsHover(in FVector2D offset)
	{
		double num = this.AimRange.X * 0.5;
		double num2 = this.AimRange.Y * 0.5;
		return (double)offset.X >= -num && (double)offset.X <= num && (double)offset.Y >= -num2 && (double)offset.Y <= num2;
	}

	// Token: 0x06009BD0 RID: 39888 RVA: 0x002E2FFC File Offset: 0x002E11FC
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

	// Token: 0x17001089 RID: 4233
	// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x002E305A File Offset: 0x002E125A
	public bool IsLocked
	{
		get
		{
			return this.IsLockedInner;
		}
	}

	// Token: 0x04005D09 RID: 23817
	private bool IsLockedInner;

	// Token: 0x04005D0A RID: 23818
	[Nullable(2)]
	private LevelSequencePlayer LockedSequencePlayer;

	// Token: 0x04005D0B RID: 23819
	[Nullable(1)]
	public readonly Vector2D AimRange = AimRange;

	// Token: 0x04005D0C RID: 23820
	[Nullable(2)]
	public readonly EntityHandle TargetEntity = TargetEntity;

	// Token: 0x0200715A RID: 29018
	private class EViewComponent
	{
		// Token: 0x04024ECB RID: 151243
		public const int RootItem = 0;
	}
}
