using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200250B RID: 9483
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueBeam : GameplayCueBase
{
	// Token: 0x0601776B RID: 96107 RVA: 0x006EBA84 File Offset: 0x006E9C84
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

	// Token: 0x0601776C RID: 96108 RVA: 0x006EBB18 File Offset: 0x006E9D18
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

	// Token: 0x0601776D RID: 96109 RVA: 0x006EBB6B File Offset: 0x006E9D6B
	protected override void OnCreate()
	{
		this.BeamItem = GameplayCueBeamCommonItem.Spawn(this.GetBeamOwner(), this.CueConfig.Path, null);
	}

	// Token: 0x0601776E RID: 96110 RVA: 0x006EBB8A File Offset: 0x006E9D8A
	protected override void OnDestroy()
	{
		if (this.BeamItem != null)
		{
			this.BeamItem.Destroy();
			this.BeamItem = null;
		}
	}

	// Token: 0x0601776F RID: 96111 RVA: 0x006EBBA6 File Offset: 0x006E9DA6
	public new static bool IsSingleInstance()
	{
		return false;
	}

	// Token: 0x06017770 RID: 96112 RVA: 0x006EBBAC File Offset: 0x006E9DAC
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

	// Token: 0x06017771 RID: 96113 RVA: 0x006EBC07 File Offset: 0x006E9E07
	protected virtual bool ShouldHideBeam()
	{
		return this.InstigatorActor.bHidden || this.ActorInternal.bHidden;
	}

	// Token: 0x06017772 RID: 96114 RVA: 0x006EBC23 File Offset: 0x006E9E23
	[NullableContext(1)]
	protected virtual ABaseCharacter GetBeamOwner()
	{
		return this.InstigatorActor;
	}

	// Token: 0x06017773 RID: 96115 RVA: 0x006EBC2B File Offset: 0x006E9E2B
	[NullableContext(1)]
	protected virtual FVectorDouble[] GetBeamPoints()
	{
		return new FVectorDouble[]
		{
			this.GetInstigatorPoint(),
			this.GetActorPoint()
		};
	}

	// Token: 0x06017774 RID: 96116 RVA: 0x006EBC50 File Offset: 0x006E9E50
	protected FVectorDouble GetInstigatorPoint()
	{
		if (!(this.Sockets[0] != null))
		{
			return this.InstigatorActor.D_K2_GetActorLocation();
		}
		return this.InstigatorActor.Mesh.D_GetSocketLocation(this.Sockets[0]);
	}

	// Token: 0x06017775 RID: 96117 RVA: 0x006EBCA0 File Offset: 0x006E9EA0
	protected FVectorDouble GetActorPoint()
	{
		if (!(this.Sockets[1] != null))
		{
			return this.ActorInternal.D_K2_GetActorLocation();
		}
		return this.ActorInternal.Mesh.D_GetSocketLocation(this.Sockets[1]);
	}

	// Token: 0x06017776 RID: 96118 RVA: 0x006EBCEE File Offset: 0x006E9EEE
	protected bool HasExternalInstigator()
	{
		TsBaseCharacter instigatorActor = this.InstigatorActor;
		return instigatorActor != null && instigatorActor.IsValid() && this.InstigatorActor != this.ActorInternal;
	}

	// Token: 0x0400C78F RID: 51087
	protected TsBaseCharacter InstigatorActor;

	// Token: 0x0400C790 RID: 51088
	protected List<FName> Sockets;

	// Token: 0x0400C791 RID: 51089
	protected GameplayCueBeamCommonItem BeamItem;
}
