using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

// Token: 0x02001A6E RID: 6766
[NullableContext(1)]
[Nullable(0)]
public class PhotoMission
{
	// Token: 0x06010BD3 RID: 68563 RVA: 0x004E592C File Offset: 0x004E3B2C
	public PhotoMission([Nullable(2)] EntityPhotoBehaviorNode node, EEntityMissionType? type, bool bFinished, int? entityId, string desc, bool bOptional)
	{
		this.Node = node;
		this.ItsMissionType = type;
		this.IsFinished = bFinished;
		this.EntityId = entityId;
		this.Description = desc;
		this.IsOptional = bOptional;
		if (this.IsOptional)
		{
			this.IsOptionalFinished = new bool?(false);
		}
	}

	// Token: 0x040093AC RID: 37804
	[Nullable(2)]
	public EntityPhotoBehaviorNode Node;

	// Token: 0x040093AD RID: 37805
	public EEntityMissionType? ItsMissionType;

	// Token: 0x040093AE RID: 37806
	public bool IsFinished;

	// Token: 0x040093AF RID: 37807
	public int? EntityId;

	// Token: 0x040093B0 RID: 37808
	public string Description = "";

	// Token: 0x040093B1 RID: 37809
	public bool IsOptional;

	// Token: 0x040093B2 RID: 37810
	public bool? IsOptionalFinished;
}
