using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002511 RID: 9489
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueFall : GameplayCueBase
{
	// Token: 0x060177A4 RID: 96164 RVA: 0x006ED116 File Offset: 0x006EB316
	protected override void OnCreate()
	{
		this.NeedRetry = !this.TryFall();
	}

	// Token: 0x060177A5 RID: 96165 RVA: 0x006ED127 File Offset: 0x006EB327
	protected override void OnTick(float delta)
	{
		if (!this.NeedRetry)
		{
			return;
		}
		this.NeedRetry = !this.TryFall();
	}

	// Token: 0x060177A6 RID: 96166 RVA: 0x006ED144 File Offset: 0x006EB344
	protected override void OnDestroy()
	{
		this.NeedRetry = false;
		if (this.IgnoredFloor == null)
		{
			return;
		}
		TsBaseCharacter character = this.GetCharacter();
		if (((character != null) ? character.CapsuleComponent : null) != null)
		{
			character.CapsuleComponent.IgnoreActorWhenMoving(this.IgnoredFloor, false);
		}
		this.IgnoredFloor = null;
	}

	// Token: 0x060177A7 RID: 96167 RVA: 0x006ED190 File Offset: 0x006EB390
	private bool TryFall()
	{
		TsBaseCharacter character = this.GetCharacter();
		if (character == null)
		{
			return true;
		}
		UCharacterMovementComponent characterMovement = character.CharacterMovement;
		if (characterMovement == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "Fall 找不到 CharacterMovement，跳过";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", this.EntityHandle.Id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}
		FFindFloorResult currentFloor = characterMovement.CurrentFloor;
		if (!currentFloor.bBlockingHit)
		{
			return false;
		}
		AActor aactor = currentFloor.HitResult.Actor.Get();
		if (aactor == null)
		{
			return false;
		}
		string text = (this.CueConfig.ParametersLength > 0) ? this.CueConfig.Parameters(0) : string.Empty;
		if (!string.IsNullOrEmpty(text) && !aactor.ActorHasTag(FNameUtil.GetDynamicFName(text).Value))
		{
			return true;
		}
		character.CapsuleComponent.IgnoreActorWhenMoving(aactor, true);
		this.IgnoredFloor = aactor;
		character.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Falling,
			Context = "[GameplayCueFall.TryFall]"
		});
		return true;
	}

	// Token: 0x060177A8 RID: 96168 RVA: 0x006ED290 File Offset: 0x006EB490
	private TsBaseCharacter GetCharacter()
	{
		TsBaseCharacter tsBaseCharacter = this.ActorInternal as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HXY;
			string message = "Fall 仅支持角色，跳过";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", this.EntityHandle.Id);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return tsBaseCharacter;
	}

	// Token: 0x0400C7AA RID: 51114
	private AActor IgnoredFloor;

	// Token: 0x0400C7AB RID: 51115
	private bool NeedRetry;
}
