using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006FC1 RID: 28609
	[NullableContext(1)]
	[Nullable(0)]
	public class EntitySpawnTracker
	{
		// Token: 0x060458E7 RID: 284903 RVA: 0x01144327 File Offset: 0x01142527
		public void Add(int creatureId)
		{
			if (!this.IsServerDataAllReceived)
			{
				this.PendingCreatureIds.Add(creatureId);
			}
		}

		// Token: 0x060458E8 RID: 284904 RVA: 0x0114433E File Offset: 0x0114253E
		[NullableContext(2)]
		public void Complete(int creatureId, AKSC_Entity entity = null)
		{
			if (entity != null)
			{
				this.SpawnedEntities.Add(entity);
			}
			this.PendingCreatureIds.Remove(creatureId);
			this.TryTrigger();
		}

		// Token: 0x060458E9 RID: 284905 RVA: 0x01144362 File Offset: 0x01142562
		public void MarkServerDone()
		{
			this.IsServerDataAllReceived = true;
			this.TryTrigger();
		}

		// Token: 0x060458EA RID: 284906 RVA: 0x01144371 File Offset: 0x01142571
		private void TryTrigger()
		{
			if (this.IsServerDataAllReceived && this.PendingCreatureIds.Count == 0)
			{
				Action onAllSpawned = this.OnAllSpawned;
				if (onAllSpawned != null)
				{
					onAllSpawned();
				}
				this.Reset();
			}
		}

		// Token: 0x060458EB RID: 284907 RVA: 0x0114439F File Offset: 0x0114259F
		public void Reset()
		{
			this.IsServerDataAllReceived = false;
			this.PendingCreatureIds.Clear();
			this.SpawnedEntities.Clear();
		}

		// Token: 0x040244BD RID: 148669
		private readonly HashSet<int> PendingCreatureIds = new HashSet<int>();

		// Token: 0x040244BE RID: 148670
		public readonly List<AKSC_Entity> SpawnedEntities = new List<AKSC_Entity>();

		// Token: 0x040244BF RID: 148671
		private bool IsServerDataAllReceived;

		// Token: 0x040244C0 RID: 148672
		[Nullable(2)]
		public Action OnAllSpawned;
	}
}
