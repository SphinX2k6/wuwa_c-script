using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020034F4 RID: 13556
[NullableContext(1)]
[Nullable(0)]
public class AttachActorEntry
{
	// Token: 0x0601DB8D RID: 121741 RVA: 0x008543D8 File Offset: 0x008525D8
	public bool AddAttachActorItem(int id, int entityId, AActor actor, AActor parentActor, string reason, EDetachType detachType)
	{
		if (this.ActorKeyMap.ContainsKey(actor))
		{
			return false;
		}
		Dictionary<AActor, int> actorKeyMap = this.ActorKeyMap;
		int num = this.AttachActorId + 1;
		this.AttachActorId = num;
		actorKeyMap[actor] = num;
		AttachActorItem value = new AttachActorItem
		{
			Id = id,
			EntityId = entityId,
			Reason = reason,
			Actor = actor,
			Name = actor.GetName(),
			ParentActorName = parentActor.GetName(),
			DetachType = new EDetachType?(detachType)
		};
		if (GlobalData.IsPlayInEditor)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("AttachId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(id);
			FName? dynamicFName = FNameUtil.GetDynamicFName(defaultInterpolatedStringHandler.ToStringAndClear());
			if (dynamicFName != null)
			{
				actor.Tags.Add(dynamicFName.Value);
			}
		}
		this.ActorMap.Set(this.AttachActorId, value);
		return true;
	}

	// Token: 0x0601DB8E RID: 121742 RVA: 0x008544BC File Offset: 0x008526BC
	[return: Nullable(2)]
	public AttachActorItem GetAttachActorItem(AActor actor)
	{
		int key;
		if (!this.ActorKeyMap.TryGetValue(actor, out key))
		{
			return null;
		}
		return this.ActorMap.Get(key);
	}

	// Token: 0x0601DB8F RID: 121743 RVA: 0x008544E7 File Offset: 0x008526E7
	public IReadOnlyList<AttachActorItem> GetAttachActorItems()
	{
		return this.ActorMap.GetItems();
	}

	// Token: 0x0601DB90 RID: 121744 RVA: 0x008544F4 File Offset: 0x008526F4
	public int Size()
	{
		return this.ActorKeyMap.Count;
	}

	// Token: 0x0601DB91 RID: 121745 RVA: 0x00854504 File Offset: 0x00852704
	public bool RemoveAttachActorItem(AActor actor)
	{
		int key;
		return this.ActorKeyMap.Remove(actor, out key) && this.ActorMap.Remove(key);
	}

	// Token: 0x0601DB92 RID: 121746 RVA: 0x0085452F File Offset: 0x0085272F
	public void Clear()
	{
		this.AttachActorId = 0;
		this.ActorKeyMap.Clear();
		this.ActorMap.Clear();
	}

	// Token: 0x0400E941 RID: 59713
	private int AttachActorId;

	// Token: 0x0400E942 RID: 59714
	private readonly Dictionary<AActor, int> ActorKeyMap = new Dictionary<AActor, int>();

	// Token: 0x0400E943 RID: 59715
	private readonly CustomMap<int, AttachActorItem> ActorMap = new CustomMap<int, AttachActorItem>();
}
