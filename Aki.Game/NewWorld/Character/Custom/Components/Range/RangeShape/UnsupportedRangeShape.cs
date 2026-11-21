using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range.RangeShape
{
	// Token: 0x02002F89 RID: 12169
	public class UnsupportedRangeShape : IRangeShape
	{
		// Token: 0x0601CD55 RID: 118101 RVA: 0x008CF41C File Offset: 0x008CD61C
		[NullableContext(1)]
		public void InitializeRangeShape(Action<bool> onInitialized)
		{
			onInitialized(false);
		}

		// Token: 0x0601CD56 RID: 118102 RVA: 0x008CF425 File Offset: 0x008CD625
		public void RegisterOverlapCallback([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, bool> onOverlap)
		{
		}

		// Token: 0x0601CD57 RID: 118103 RVA: 0x008CF427 File Offset: 0x008CD627
		public void UnregisterOverlapCallback()
		{
		}

		// Token: 0x0601CD58 RID: 118104 RVA: 0x008CF429 File Offset: 0x008CD629
		public void RefreshOverlapState()
		{
		}

		// Token: 0x0601CD59 RID: 118105 RVA: 0x008CF42B File Offset: 0x008CD62B
		[NullableContext(1)]
		public IReadOnlyList<AActor> GetCurrentOverlappingActors()
		{
			return Array.Empty<AActor>();
		}

		// Token: 0x0601CD5A RID: 118106 RVA: 0x008CF432 File Offset: 0x008CD632
		public void ClearRangeShape()
		{
		}
	}
}
