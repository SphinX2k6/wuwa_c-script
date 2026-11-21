using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002504 RID: 9476
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueAnimBeam : GameplayCueBase
{
	// Token: 0x06017731 RID: 96049 RVA: 0x006EAF0C File Offset: 0x006E910C
	protected override void OnInit()
	{
		string[] array = this.CueConfig.Socket.Split('#', StringSplitOptions.None);
		this.Sockets = new List<FName>(array.Length);
		foreach (string key in array)
		{
			this.Sockets.Add(FNameUtil.GetDynamicFName(key).Value);
		}
	}

	// Token: 0x06017732 RID: 96050 RVA: 0x006EAF6C File Offset: 0x006E916C
	protected override void OnTick(float delta)
	{
		List<FName> sockets = this.Sockets;
		FVectorDouble[] array = new FVectorDouble[sockets.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = this.ActorInternal.Mesh.D_GetSocketLocation(sockets[i]);
		}
		this.BeamItem.Tick(array, delta);
	}

	// Token: 0x06017733 RID: 96051 RVA: 0x006EAFC5 File Offset: 0x006E91C5
	protected override void OnCreate()
	{
		this.BeamItem = GameplayCueBeamCommonItem.Spawn(this.ActorInternal, this.CueConfig.Path, null);
	}

	// Token: 0x06017734 RID: 96052 RVA: 0x006EAFE4 File Offset: 0x006E91E4
	protected override void OnDestroy()
	{
		this.BeamItem.Destroy();
	}

	// Token: 0x06017735 RID: 96053 RVA: 0x006EAFF1 File Offset: 0x006E91F1
	public override void OnEnable()
	{
		this.BeamItem.GetOwner().SetActorHiddenInGame(false);
	}

	// Token: 0x06017736 RID: 96054 RVA: 0x006EB004 File Offset: 0x006E9204
	public override void OnDisable()
	{
		this.BeamItem.GetOwner().SetActorHiddenInGame(true);
	}

	// Token: 0x0400C76D RID: 51053
	private GameplayCueBeamCommonItem BeamItem;

	// Token: 0x0400C76E RID: 51054
	private List<FName> Sockets;
}
