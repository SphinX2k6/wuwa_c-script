using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

// Token: 0x02002584 RID: 9604
[NullableContext(2)]
[Nullable(0)]
public class PhotoThing
{
	// Token: 0x060136F3 RID: 79603 RVA: 0x004D6F5F File Offset: 0x004D515F
	public PhotoThing(EntityPhotoBehaviorNode behaviorNode, [Nullable(new byte[]
	{
		2,
		1
	})] List<PhotoMission> missions, EMissionGetType? type)
	{
		this.BehaviorNode = behaviorNode;
		this.PhotoMissions = missions;
		this.Type = type;
	}

	// Token: 0x0400925B RID: 37467
	public EntityPhotoBehaviorNode BehaviorNode;

	// Token: 0x0400925C RID: 37468
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PhotoMission> PhotoMissions;

	// Token: 0x0400925D RID: 37469
	public EMissionGetType? Type;
}
