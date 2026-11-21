using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006142 RID: 24898
	[NullableContext(1)]
	[Nullable(0)]
	public class EntitySpawnTracker
	{
		// Token: 0x0603BA97 RID: 244375 RVA: 0x010EE0FF File Offset: 0x010EC2FF
		public void Add(int creatureId)
		{
			if (!this.IsServerDataAllReceived)
			{
				this.PendingCreatureIds.Add(creatureId);
			}
		}

		// Token: 0x0603BA98 RID: 244376 RVA: 0x010EE116 File Offset: 0x010EC316
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

		// Token: 0x0603BA99 RID: 244377 RVA: 0x010EE13A File Offset: 0x010EC33A
		public void MarkServerDone()
		{
			this.IsServerDataAllReceived = true;
			this.TryTrigger();
		}

		// Token: 0x0603BA9A RID: 244378 RVA: 0x010EE149 File Offset: 0x010EC349
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

		// Token: 0x0603BA9B RID: 244379 RVA: 0x010EE177 File Offset: 0x010EC377
		public void Reset()
		{
			this.IsServerDataAllReceived = false;
			this.PendingCreatureIds.Clear();
			this.SpawnedEntities.Clear();
		}

		// Token: 0x0401F772 RID: 128882
		private readonly HashSet<int> PendingCreatureIds = new HashSet<int>();

		// Token: 0x0401F773 RID: 128883
		public readonly List<AKSC_Entity> SpawnedEntities = new List<AKSC_Entity>();

		// Token: 0x0401F774 RID: 128884
		private bool IsServerDataAllReceived;

		// Token: 0x0401F775 RID: 128885
		[Nullable(2)]
		public Action OnAllSpawned;
	}
}
