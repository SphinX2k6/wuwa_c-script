using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002FB7 RID: 12215
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueBeam : GameplayCueBase
{
	// Token: 0x06019E59 RID: 106073 RVA: 0x006C51C0 File Offset: 0x006C33C0
	protected override void OnInit()
	{
		string[] array = this.CueConfig.Socket.Split('#', StringSplitOptions.None);
		this.Sockets = new List<FName>(array.Length);
		foreach (string key in array)
		{
			this.Sockets.Add(FNameUtil.GetDynamicFName(key).Value);
		}
		EntityHandle instigator = this.Instigator;
		TsBaseCharacter instigatorActor;
		if (instigator == null)
		{
			instigatorActor = null;
		}
		else
		{
			WorldEntity entity = instigator.Entity;
			if (entity == null)
			{
				instigatorActor = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = entity.CheckGetComponent<CharacterActorComponent>();
				instigatorActor = ((characterActorComponent != null) ? characterActorComponent.Actor : null);
			}
		}
		this.InstigatorActor = instigatorActor;
		this.ValidateBeamConfig();
	}

	// Token: 0x06019E5A RID: 106074 RVA: 0x006C5254 File Offset: 0x006C3454
	protected override void OnTick(float delta)
	{
		if (this.BeamItem == null)
		{
			return;
		}
		if (this.ShouldHideBeam())
		{
			this.BeamItem.GetOwner().SetActorHiddenInGame(true);
			return;
		}
		this.BeamItem.GetOwner().SetActorHiddenInGame(false);
		this.BeamItem.Tick(this.GetBeamPoints(), delta);
	}

	// Token: 0x06019E5B RID: 106075 RVA: 0x006C52A7 File Offset: 0x006C34A7
	protected override void OnCreate()
	{
		this.BeamItem = GameplayCueBeamCommonItem.Spawn(this.GetBeamOwner(), this.CueConfig.Path, null);
	}

	// Token: 0x06019E5C RID: 106076 RVA: 0x006C52C6 File Offset: 0x006C34C6
	protected override void OnDestroy()
	{
		if (this.BeamItem != null)
		{
			this.BeamItem.Destroy();
			this.BeamItem = null;
		}
	}

	// Token: 0x06019E5D RID: 106077 RVA: 0x006C52E2 File Offset: 0x006C34E2
	public new static bool IsSingleInstance()
	{
		return false;
	}

	// Token: 0x06019E5E RID: 106078 RVA: 0x006C52E8 File Offset: 0x006C34E8
	protected virtual void ValidateBeamConfig()
	{
		if (this.Instigator == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.HXY, "无法获取Buff特效连线创建者", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (this.InstigatorActor == this.ActorInternal)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.HXY, "Buff特效连线两端不能是同一个人", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x06019E5F RID: 106079 RVA: 0x006C5343 File Offset: 0x006C3543
	protected virtual bool ShouldHideBeam()
	{
		return this.InstigatorActor.bHidden || this.ActorInternal.bHidden;
	}

	// Token: 0x06019E60 RID: 106080 RVA: 0x006C535F File Offset: 0x006C355F
	[NullableContext(1)]
	protected virtual ABaseCharacter GetBeamOwner()
	{
		return this.InstigatorActor;
	}

	// Token: 0x06019E61 RID: 106081 RVA: 0x006C5367 File Offset: 0x006C3567
	[NullableContext(1)]
	protected virtual FVectorDouble[] GetBeamPoints()
	{
		return new FVectorDouble[]
		{
			this.GetInstigatorPoint(),
			this.GetActorPoint()
		};
	}

	// Token: 0x06019E62 RID: 106082 RVA: 0x006C538C File Offset: 0x006C358C
	protected FVectorDouble GetInstigatorPoint()
	{
		if (!(this.Sockets[0] != null))
		{
			return this.InstigatorActor.D_K2_GetActorLocation();
		}
		return this.InstigatorActor.Mesh.D_GetSocketLocation(this.Sockets[0]);
	}

	// Token: 0x06019E63 RID: 106083 RVA: 0x006C53DC File Offset: 0x006C35DC
	protected FVectorDouble GetActorPoint()
	{
		if (!(this.Sockets[1] != null))
		{
			return this.ActorInternal.D_K2_GetActorLocation();
		}
		return this.ActorInternal.Mesh.D_GetSocketLocation(this.Sockets[1]);
	}

	// Token: 0x06019E64 RID: 106084 RVA: 0x006C542A File Offset: 0x006C362A
	protected bool HasExternalInstigator()
	{
		TsBaseCharacter instigatorActor = this.InstigatorActor;
		return instigatorActor != null && instigatorActor.IsValid() && this.InstigatorActor != this.ActorInternal;
	}

	// Token: 0x0400C3E6 RID: 50150
	protected TsBaseCharacter InstigatorActor;

	// Token: 0x0400C3E7 RID: 50151
	protected List<FName> Sockets;

	// Token: 0x0400C3E8 RID: 50152
	protected GameplayCueBeamCommonItem BeamItem;
}
