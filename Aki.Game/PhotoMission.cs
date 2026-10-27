using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;

// Token: 0x02002583 RID: 9603
[NullableContext(1)]
[Nullable(0)]
public class PhotoMission
{
	// Token: 0x060136F2 RID: 79602 RVA: 0x004D6F00 File Offset: 0x004D5100
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

	// Token: 0x04009254 RID: 37460
	[Nullable(2)]
	public EntityPhotoBehaviorNode Node;

	// Token: 0x04009255 RID: 37461
	public EEntityMissionType? ItsMissionType;

	// Token: 0x04009256 RID: 37462
	public bool IsFinished;

	// Token: 0x04009257 RID: 37463
	public int? EntityId;

	// Token: 0x04009258 RID: 37464
	public string Description = "";

	// Token: 0x04009259 RID: 37465
	public bool IsOptional;

	// Token: 0x0400925A RID: 37466
	public bool? IsOptionalFinished;
}
