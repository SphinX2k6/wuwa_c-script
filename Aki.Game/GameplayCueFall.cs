using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002FBD RID: 12221
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueFall : GameplayCueBase
{
	// Token: 0x06019E92 RID: 106130 RVA: 0x006C684A File Offset: 0x006C4A4A
	protected override void OnCreate()
	{
		this.NeedRetry = !this.TryFall();
	}

	// Token: 0x06019E93 RID: 106131 RVA: 0x006C685B File Offset: 0x006C4A5B
	protected override void OnTick(float delta)
	{
		if (!this.NeedRetry)
		{
			return;
		}
		this.NeedRetry = !this.TryFall();
	}

	// Token: 0x06019E94 RID: 106132 RVA: 0x006C6878 File Offset: 0x006C4A78
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

	// Token: 0x06019E95 RID: 106133 RVA: 0x006C68C4 File Offset: 0x006C4AC4
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

	// Token: 0x06019E96 RID: 106134 RVA: 0x006C69C4 File Offset: 0x006C4BC4
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

	// Token: 0x0400C401 RID: 50177
	private AActor IgnoredFloor;

	// Token: 0x0400C402 RID: 50178
	private bool NeedRetry;
}
