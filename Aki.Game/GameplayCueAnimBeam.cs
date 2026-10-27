using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002FB0 RID: 12208
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueAnimBeam : GameplayCueBase
{
	// Token: 0x06019E1F RID: 106015 RVA: 0x006C4670 File Offset: 0x006C2870
	protected override void OnInit()
	{
		string[] array = this.CueConfig.Socket.Split('#', StringSplitOptions.None);
		this.Sockets = new List<FName>(array.Length);
		foreach (string key in array)
		{
			this.Sockets.Add(FNameUtil.GetDynamicFName(key).Value);
		}
	}

	// Token: 0x06019E20 RID: 106016 RVA: 0x006C46D0 File Offset: 0x006C28D0
	protected override void OnTick(float delta)
	{
		FVectorDouble[] points = (from socket in this.Sockets
		select this.ActorInternal.Mesh.D_GetSocketLocation(socket)).ToArray<FVectorDouble>();
		this.BeamItem.Tick(points, delta);
	}

	// Token: 0x06019E21 RID: 106017 RVA: 0x006C4707 File Offset: 0x006C2907
	protected override void OnCreate()
	{
		this.BeamItem = GameplayCueBeamCommonItem.Spawn(this.ActorInternal, this.CueConfig.Path, null);
	}

	// Token: 0x06019E22 RID: 106018 RVA: 0x006C4726 File Offset: 0x006C2926
	protected override void OnDestroy()
	{
		this.BeamItem.Destroy();
	}

	// Token: 0x06019E23 RID: 106019 RVA: 0x006C4733 File Offset: 0x006C2933
	public override void OnEnable()
	{
		this.BeamItem.GetOwner().SetActorHiddenInGame(false);
	}

	// Token: 0x06019E24 RID: 106020 RVA: 0x006C4746 File Offset: 0x006C2946
	public override void OnDisable()
	{
		this.BeamItem.GetOwner().SetActorHiddenInGame(true);
	}

	// Token: 0x0400C3C4 RID: 50116
	private GameplayCueBeamCommonItem BeamItem;

	// Token: 0x0400C3C5 RID: 50117
	private List<FName> Sockets;
}
