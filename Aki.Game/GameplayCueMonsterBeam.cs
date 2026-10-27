using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002FCA RID: 12234
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueMonsterBeam : GameplayCueBeam
{
	// Token: 0x06019EF8 RID: 106232 RVA: 0x006C8D59 File Offset: 0x006C6F59
	protected override void OnInit()
	{
		base.OnInit();
		this.FallbackForwardOffset = this.ParseParamNumber("FallbackForwardOffset", 600f);
	}

	// Token: 0x06019EF9 RID: 106233 RVA: 0x006C8D77 File Offset: 0x006C6F77
	protected override void OnTick(float delta)
	{
		this.RefreshTarget();
		base.OnTick(delta);
	}

	// Token: 0x06019EFA RID: 106234 RVA: 0x006C8D88 File Offset: 0x006C6F88
	protected override void OnCreate()
	{
		this.RefreshTarget();
		this.BeamItem = GameplayCueBeamCommonItem.Spawn(this.GetBeamOwner(), this.CueConfig.Path, delegate(UNiagaraComponent niagaraComponent)
		{
			niagaraComponent.SetRenderInBurst(true);
		});
	}

	// Token: 0x06019EFB RID: 106235 RVA: 0x006C8DD6 File Offset: 0x006C6FD6
	protected override void ValidateBeamConfig()
	{
	}

	// Token: 0x06019EFC RID: 106236 RVA: 0x006C8DD8 File Offset: 0x006C6FD8
	protected override bool ShouldHideBeam()
	{
		if (!this.HasTarget())
		{
			return this.ActorInternal.bHidden;
		}
		return this.ActorInternal.bHidden || this.TargetActor.bHidden;
	}

	// Token: 0x06019EFD RID: 106237 RVA: 0x006C8E08 File Offset: 0x006C7008
	protected override ABaseCharacter GetBeamOwner()
	{
		if (!this.HasTarget())
		{
			return this.ActorInternal;
		}
		return this.TargetActor;
	}

	// Token: 0x06019EFE RID: 106238 RVA: 0x006C8E20 File Offset: 0x006C7020
	protected override FVectorDouble[] GetBeamPoints()
	{
		if (this.HasTarget())
		{
			FVectorDouble[] array = new FVectorDouble[2];
			int num = 0;
			ABaseCharacter actorInternal = this.ActorInternal;
			List<FName> sockets = this.Sockets;
			array[num] = GameplayCueMonsterBeam.GetMeshSocketLocation(actorInternal, (sockets != null) ? new FName?(sockets[0]) : null);
			array[1] = this.GetTargetPoint();
			return array;
		}
		FVectorDouble[] array2 = new FVectorDouble[2];
		int num2 = 0;
		ABaseCharacter actorInternal2 = this.ActorInternal;
		List<FName> sockets2 = this.Sockets;
		array2[num2] = GameplayCueMonsterBeam.GetMeshSocketLocation(actorInternal2, (sockets2 != null) ? new FName?(sockets2[0]) : null);
		array2[1] = this.GetFallbackPoint();
		return array2;
	}

	// Token: 0x06019EFF RID: 106239 RVA: 0x006C8EC0 File Offset: 0x006C70C0
	private bool HasTarget()
	{
		TsBaseCharacter targetActor = this.TargetActor;
		return targetActor != null && targetActor.IsValid() && this.TargetActor != this.ActorInternal;
	}

	// Token: 0x06019F00 RID: 106240 RVA: 0x006C8EEC File Offset: 0x006C70EC
	private void RefreshTarget()
	{
		ValueTuple<TsBaseCharacter, string> valueTuple = this.ResolveLockOnOrSkillTarget();
		TsBaseCharacter item = valueTuple.Item1;
		string item2 = valueTuple.Item2;
		this.TargetActor = item;
		this.TargetSocketName = item2;
	}

	// Token: 0x06019F01 RID: 106241 RVA: 0x006C8F1C File Offset: 0x006C711C
	[return: TupleElementNames(new string[]
	{
		"Target",
		"Socket"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2,
		1
	})]
	private ValueTuple<TsBaseCharacter, string> ResolveLockOnOrSkillTarget()
	{
		EntityHandle entityHandle = null;
		string item = string.Empty;
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterLockOnComponent characterLockOnComponent = (entity != null) ? entity.GetComponent<CharacterLockOnComponent>() : null;
		WorldEntity entity2 = this.EntityHandle.Entity;
		CharacterActorComponent characterActorComponent = (entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null;
		if (characterLockOnComponent != null && characterActorComponent != null && characterActorComponent.IsAutonomousProxy)
		{
			entityHandle = characterLockOnComponent.GetCurrentTarget();
			item = characterLockOnComponent.GetCurrentTargetSocketName();
		}
		bool flag;
		if (entityHandle == null)
		{
			flag = true;
		}
		else
		{
			WorldEntity entity3 = entityHandle.Entity;
			flag = !((entity3 != null) ? new bool?(entity3.Valid) : null).GetValueOrDefault();
		}
		if (flag)
		{
			WorldEntity entity4 = this.EntityHandle.Entity;
			CharacterSkillComponent characterSkillComponent = (entity4 != null) ? entity4.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent != null)
			{
				entityHandle = characterSkillComponent.SkillTarget;
				item = characterSkillComponent.SkillTargetSocket;
			}
		}
		bool flag2;
		if (entityHandle == null)
		{
			flag2 = true;
		}
		else
		{
			WorldEntity entity5 = entityHandle.Entity;
			flag2 = !((entity5 != null) ? new bool?(entity5.Valid) : null).GetValueOrDefault();
		}
		if (flag2)
		{
			return new ValueTuple<TsBaseCharacter, string>(null, string.Empty);
		}
		CharacterActorComponent component = entityHandle.Entity.GetComponent<CharacterActorComponent>();
		return new ValueTuple<TsBaseCharacter, string>((component != null) ? component.Actor : null, item);
	}

	// Token: 0x06019F02 RID: 106242 RVA: 0x006C903C File Offset: 0x006C723C
	private FVectorDouble GetTargetPoint()
	{
		TsBaseCharacter targetActor = this.TargetActor;
		USkeletalMeshComponent mesh = targetActor.Mesh;
		if (mesh == null)
		{
			return targetActor.D_K2_GetActorLocation();
		}
		FName? fname;
		if (string.IsNullOrEmpty(this.TargetSocketName))
		{
			List<FName> sockets = this.Sockets;
			fname = ((sockets != null) ? new FName?(sockets[1]) : null);
		}
		else
		{
			fname = FNameUtil.GetDynamicFName(this.TargetSocketName);
		}
		FName? fname2 = fname;
		if (fname2 == null || !mesh.DoesSocketExist(fname2.Value))
		{
			fname2 = new FName?(CharacterNameDefines.Instance.HIT_CASE_NAME);
		}
		return mesh.D_GetSocketLocation(fname2.Value);
	}

	// Token: 0x06019F03 RID: 106243 RVA: 0x006C90D4 File Offset: 0x006C72D4
	private FVectorDouble GetFallbackPoint()
	{
		FVectorDouble fvectorDouble = this.ActorInternal.D_K2_GetActorLocation();
		FVector actorForwardVector = this.ActorInternal.GetActorForwardVector();
		float fallbackForwardOffset = this.FallbackForwardOffset;
		return new FVectorDouble(fvectorDouble.X + (double)(actorForwardVector.X * fallbackForwardOffset), fvectorDouble.Y + (double)(actorForwardVector.Y * fallbackForwardOffset), fvectorDouble.Z + (double)(actorForwardVector.Z * fallbackForwardOffset));
	}

	// Token: 0x06019F04 RID: 106244 RVA: 0x006C9138 File Offset: 0x006C7338
	private static FVectorDouble GetMeshSocketLocation(ABaseCharacter actor, FName? socket)
	{
		USkeletalMeshComponent mesh = actor.Mesh;
		if (socket != null && mesh != null)
		{
			return mesh.D_GetSocketLocation(socket.Value);
		}
		return actor.D_K2_GetActorLocation();
	}

	// Token: 0x06019F05 RID: 106245 RVA: 0x006C916C File Offset: 0x006C736C
	private float ParseParamNumber(string key, float defaultValue)
	{
		int parametersLength = this.CueConfig.ParametersLength;
		string text = key + "=";
		int i = 0;
		while (i < parametersLength)
		{
			string text2 = this.CueConfig.Parameters(i);
			if (text2.StartsWith(text))
			{
				float result;
				if (!float.TryParse(text2.Substring(text.Length), out result))
				{
					return defaultValue;
				}
				return result;
			}
			else
			{
				i++;
			}
		}
		return defaultValue;
	}

	// Token: 0x0400C449 RID: 50249
	private const float DEFAULT_FALLBACK_FORWARD_OFFSET = 600f;

	// Token: 0x0400C44A RID: 50250
	private float FallbackForwardOffset = 600f;

	// Token: 0x0400C44B RID: 50251
	[Nullable(2)]
	private TsBaseCharacter TargetActor;

	// Token: 0x0400C44C RID: 50252
	private string TargetSocketName = string.Empty;
}
