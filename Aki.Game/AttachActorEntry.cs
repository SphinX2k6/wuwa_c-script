using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A68 RID: 10856
[NullableContext(1)]
[Nullable(0)]
public class AttachActorEntry
{
	// Token: 0x0601B89B RID: 112795 RVA: 0x0087C7A0 File Offset: 0x0087A9A0
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

	// Token: 0x0601B89C RID: 112796 RVA: 0x0087C884 File Offset: 0x0087AA84
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

	// Token: 0x0601B89D RID: 112797 RVA: 0x0087C8AF File Offset: 0x0087AAAF
	public IReadOnlyList<AttachActorItem> GetAttachActorItems()
	{
		return this.ActorMap.GetItems();
	}

	// Token: 0x0601B89E RID: 112798 RVA: 0x0087C8BC File Offset: 0x0087AABC
	public int Size()
	{
		return this.ActorKeyMap.Count;
	}

	// Token: 0x0601B89F RID: 112799 RVA: 0x0087C8CC File Offset: 0x0087AACC
	public bool RemoveAttachActorItem(AActor actor)
	{
		int key;
		return this.ActorKeyMap.Remove(actor, out key) && this.ActorMap.Remove(key);
	}

	// Token: 0x0601B8A0 RID: 112800 RVA: 0x0087C8F7 File Offset: 0x0087AAF7
	public void Clear()
	{
		this.AttachActorId = 0;
		this.ActorKeyMap.Clear();
		this.ActorMap.Clear();
	}

	// Token: 0x0400EDF8 RID: 60920
	private int AttachActorId;

	// Token: 0x0400EDF9 RID: 60921
	private readonly Dictionary<AActor, int> ActorKeyMap = new Dictionary<AActor, int>();

	// Token: 0x0400EDFA RID: 60922
	private readonly CustomMap<int, AttachActorItem> ActorMap = new CustomMap<int, AttachActorItem>();
}
