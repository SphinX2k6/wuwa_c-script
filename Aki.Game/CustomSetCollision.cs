using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002408 RID: 9224
[NullableContext(1)]
[Nullable(0)]
public class CustomSetCollision : CustomActionBase
{
	// Token: 0x06017172 RID: 94578 RVA: 0x006BFBE7 File Offset: 0x006BDDE7
	public CustomSetCollision(CharacterActorComponent actorComp, BaseActorComponent targetActor, bool ignoreCollision, [Nullable(2)] Action callback = null)
	{
		this.ActorComp = actorComp;
		this.TargetActor = targetActor;
		this.IgnoreCollision = ignoreCollision;
		this.Callback = callback;
	}

	// Token: 0x06017173 RID: 94579 RVA: 0x006BFC0C File Offset: 0x006BDE0C
	protected unsafe override void OnRunAction()
	{
		if (this.TargetActor == null || this.ActorComp == null)
		{
			base.Finish(false);
			return;
		}
		TsBaseCharacter actor = this.ActorComp.Actor;
		UCapsuleComponent ucapsuleComponent = (actor != null) ? actor.CapsuleComponent : null;
		ACharacter acharacter = this.TargetActor.Owner as ACharacter;
		UCapsuleComponent ucapsuleComponent2 = (acharacter != null) ? acharacter.CapsuleComponent : null;
		if (ucapsuleComponent == null || !ucapsuleComponent.IsValid() || (acharacter == null || !acharacter.IsValid()) || (ucapsuleComponent2 == null || !ucapsuleComponent2.IsValid()))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[CustomAction][SetCollision] Capsule 无效，跳过";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.ActorComp.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Ignore", this.IgnoreCollision);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			base.Finish(false);
			return;
		}
		ucapsuleComponent.IgnoreActorWhenMoving(acharacter, this.IgnoreCollision);
		ucapsuleComponent2.IgnoreActorWhenMoving(this.ActorComp.Actor, this.IgnoreCollision);
		base.Finish(true);
	}

	// Token: 0x0400C248 RID: 49736
	private readonly CharacterActorComponent ActorComp;

	// Token: 0x0400C249 RID: 49737
	private readonly BaseActorComponent TargetActor;

	// Token: 0x0400C24A RID: 49738
	private readonly bool IgnoreCollision;
}
