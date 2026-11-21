using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200251E RID: 9502
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueMonsterBeam : GameplayCueBeam
{
	// Token: 0x0601780A RID: 96266 RVA: 0x006EF62D File Offset: 0x006ED82D
	protected override void OnInit()
	{
		base.OnInit();
		this.FallbackForwardOffset = this.ParseParamNumber("FallbackForwardOffset", 600f);
	}

	// Token: 0x0601780B RID: 96267 RVA: 0x006EF64B File Offset: 0x006ED84B
	protected override void OnTick(float delta)
	{
		this.RefreshTarget();
		base.OnTick(delta);
	}

	// Token: 0x0601780C RID: 96268 RVA: 0x006EF65C File Offset: 0x006ED85C
	protected override void OnCreate()
	{
		this.RefreshTarget();
		this.BeamItem = GameplayCueBeamCommonItem.Spawn(this.GetBeamOwner(), this.CueConfig.Path, delegate(UNiagaraComponent niagaraComponent)
		{
			niagaraComponent.SetRenderInBurst(true);
		});
	}

	// Token: 0x0601780D RID: 96269 RVA: 0x006EF6AA File Offset: 0x006ED8AA
	protected override void ValidateBeamConfig()
	{
	}

	// Token: 0x0601780E RID: 96270 RVA: 0x006EF6AC File Offset: 0x006ED8AC
	protected override bool ShouldHideBeam()
	{
		if (!this.HasTarget())
		{
			return this.ActorInternal.bHidden;
		}
		return this.ActorInternal.bHidden || this.TargetActor.bHidden;
	}

	// Token: 0x0601780F RID: 96271 RVA: 0x006EF6DC File Offset: 0x006ED8DC
	protected override ABaseCharacter GetBeamOwner()
	{
		if (!this.HasTarget())
		{
			return this.ActorInternal;
		}
		return this.TargetActor;
	}

	// Token: 0x06017810 RID: 96272 RVA: 0x006EF6F4 File Offset: 0x006ED8F4
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

	// Token: 0x06017811 RID: 96273 RVA: 0x006EF794 File Offset: 0x006ED994
	private bool HasTarget()
	{
		TsBaseCharacter targetActor = this.TargetActor;
		return targetActor != null && targetActor.IsValid() && this.TargetActor != this.ActorInternal;
	}

	// Token: 0x06017812 RID: 96274 RVA: 0x006EF7C0 File Offset: 0x006ED9C0
	private void RefreshTarget()
	{
		ValueTuple<TsBaseCharacter, string> valueTuple = this.ResolveLockOnOrSkillTarget();
		TsBaseCharacter item = valueTuple.Item1;
		string item2 = valueTuple.Item2;
		this.TargetActor = item;
		this.TargetSocketName = item2;
	}

	// Token: 0x06017813 RID: 96275 RVA: 0x006EF7F0 File Offset: 0x006ED9F0
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

	// Token: 0x06017814 RID: 96276 RVA: 0x006EF910 File Offset: 0x006EDB10
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

	// Token: 0x06017815 RID: 96277 RVA: 0x006EF9A8 File Offset: 0x006EDBA8
	private FVectorDouble GetFallbackPoint()
	{
		FVectorDouble fvectorDouble = this.ActorInternal.D_K2_GetActorLocation();
		FVector actorForwardVector = this.ActorInternal.GetActorForwardVector();
		float fallbackForwardOffset = this.FallbackForwardOffset;
		return new FVectorDouble(fvectorDouble.X + (double)(actorForwardVector.X * fallbackForwardOffset), fvectorDouble.Y + (double)(actorForwardVector.Y * fallbackForwardOffset), fvectorDouble.Z + (double)(actorForwardVector.Z * fallbackForwardOffset));
	}

	// Token: 0x06017816 RID: 96278 RVA: 0x006EFA0C File Offset: 0x006EDC0C
	private static FVectorDouble GetMeshSocketLocation(ABaseCharacter actor, FName? socket)
	{
		USkeletalMeshComponent mesh = actor.Mesh;
		if (socket != null && mesh != null)
		{
			return mesh.D_GetSocketLocation(socket.Value);
		}
		return actor.D_K2_GetActorLocation();
	}

	// Token: 0x06017817 RID: 96279 RVA: 0x006EFA40 File Offset: 0x006EDC40
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

	// Token: 0x0400C7F2 RID: 51186
	private const float DEFAULT_FALLBACK_FORWARD_OFFSET = 600f;

	// Token: 0x0400C7F3 RID: 51187
	private float FallbackForwardOffset = 600f;

	// Token: 0x0400C7F4 RID: 51188
	[Nullable(2)]
	private TsBaseCharacter TargetActor;

	// Token: 0x0400C7F5 RID: 51189
	private string TargetSocketName = string.Empty;
}
