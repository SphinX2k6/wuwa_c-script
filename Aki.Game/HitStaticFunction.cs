using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Audio;
using UnrealEngine;

// Token: 0x0200233F RID: 9023
[NullableContext(2)]
[Nullable(0)]
public class HitStaticFunction
{
	// Token: 0x06016341 RID: 90945 RVA: 0x006793E9 File Offset: 0x006775E9
	public static void PlayHitAudio(ELoadEffectResult result, int handle, string audioEvent, ERoleAudioPriorityType fromPrimaryRole)
	{
		if (result != ELoadEffectResult.Success)
		{
			return;
		}
		HitStaticFunction.PlayHitAudioByActor(EffectSystem.Instance.GetSureEffectActor(handle), audioEvent, fromPrimaryRole);
	}

	// Token: 0x06016342 RID: 90946 RVA: 0x00679404 File Offset: 0x00677604
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

	// Token: 0x06016343 RID: 90947 RVA: 0x00679480 File Offset: 0x00677680
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
