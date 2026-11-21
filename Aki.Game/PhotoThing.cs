using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

// Token: 0x02001A6F RID: 6767
[NullableContext(2)]
[Nullable(0)]
public class PhotoThing
{
	// Token: 0x06010BD4 RID: 68564 RVA: 0x004E598B File Offset: 0x004E3B8B
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

	// Token: 0x040093B3 RID: 37811
	public EntityPhotoBehaviorNode BehaviorNode;

	// Token: 0x040093B4 RID: 37812
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PhotoMission> PhotoMissions;

	// Token: 0x040093B5 RID: 37813
	public EMissionGetType? Type;
}
