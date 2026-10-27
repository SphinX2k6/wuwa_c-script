using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Audio;
using UnrealEngine;

// Token: 0x02002DE4 RID: 11748
[NullableContext(2)]
[Nullable(0)]
public class HitStaticFunction
{
	// Token: 0x06018A94 RID: 101012 RVA: 0x00653309 File Offset: 0x00651509
	public static void PlayHitAudio(ELoadEffectResult result, int handle, string audioEvent, ERoleAudioPriorityType fromPrimaryRole)
	{
		if (result != ELoadEffectResult.Success)
		{
			return;
		}
		HitStaticFunction.PlayHitAudioByActor(EffectSystem.Instance.GetSureEffectActor(handle), audioEvent, fromPrimaryRole);
	}

	// Token: 0x06018A95 RID: 101013 RVA: 0x00653324 File Offset: 0x00651524
	public static void PlayHitAudioByActor(AActor actor, string audioEvent, ERoleAudioPriorityType fromPrimaryRole)
	{
		if (audioEvent == null || StringUtils.IsBlank(audioEvent))
		{
			return;
		}
		if (EffectAudioController.Instance.CheckHitEffectCooldownTime(new EHitEffectType?(EHitEffectType.BulletHitEffect), audioEvent))
		{
			return;
		}
		EffectAudioController.Instance.AddPlayEffectAudio(audioEvent, (actor != null) ? actor.D_GetTransform() : default(FTransformDouble), new EHitEffectType?(EHitEffectType.BulletHitEffect), new ERoleAudioPriorityType?((fromPrimaryRole == ERoleAudioPriorityType.PlayerControl) ? ERoleAudioPriorityType.PlayerControl : ERoleAudioPriorityType.OtherControl), null, new bool?(true));
		bool openHitActorLog = BulletConstant.Instance.OpenHitActorLog;
	}

	// Token: 0x06018A96 RID: 101014 RVA: 0x006533A0 File Offset: 0x006515A0
	public static EffectContext CreateEffectContext(Entity attacker, bool disablePostProcess)
	{
		if (attacker == null)
		{
			return null;
		}
		CharacterAudioComponent component = attacker.GetComponent<CharacterAudioComponent>();
		BaseActorComponent component2 = attacker.GetComponent<BaseActorComponent>();
		EffectContext effectContext = null;
		if (component2 != null && component2.Valid)
		{
			if (component != null)
			{
				effectContext = new EffectAudioContext
				{
					FromPrimaryRole = (component.CurrentPriority == ERoleAudioPriorityType.PlayerControl)
				};
			}
			else
			{
				effectContext = new EffectContext();
			}
			effectContext.SourceObject = component2.Owner;
			effectContext.EntityId = new int?(attacker.Id);
			effectContext.DisablePostProcess = disablePostProcess;
		}
		return effectContext;
	}
}
