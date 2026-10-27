using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002EB5 RID: 11957
[NullableContext(1)]
[Nullable(0)]
public class CustomSetCollision : CustomActionBase
{
	// Token: 0x0601988C RID: 104588 RVA: 0x00699927 File Offset: 0x00697B27
	public CustomSetCollision(CharacterActorComponent actorComp, BaseActorComponent targetActor, bool ignoreCollision, [Nullable(2)] Action callback = null)
	{
		this.ActorComp = actorComp;
		this.TargetActor = targetActor;
		this.IgnoreCollision = ignoreCollision;
		this.Callback = callback;
	}

	// Token: 0x0601988D RID: 104589 RVA: 0x0069994C File Offset: 0x00697B4C
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

	// Token: 0x0400BEAD RID: 48813
	private readonly CharacterActorComponent ActorComp;

	// Token: 0x0400BEAE RID: 48814
	private readonly BaseActorComponent TargetActor;

	// Token: 0x0400BEAF RID: 48815
	private readonly bool IgnoreCollision;
}
