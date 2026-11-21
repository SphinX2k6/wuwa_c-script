using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F77 RID: 12151
	[NullableContext(1)]
	public interface IRangeShape
	{
		// Token: 0x0601CC5B RID: 117851
		void InitializeRangeShape(Action<bool> onInitialized);

		// Token: 0x0601CC5C RID: 117852
		void RegisterOverlapCallback([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor, bool> onOverlap);

		// Token: 0x0601CC5D RID: 117853
		void UnregisterOverlapCallback();

		// Token: 0x0601CC5E RID: 117854
		void RefreshOverlapState();

		// Token: 0x0601CC5F RID: 117855
		IReadOnlyList<AActor> GetCurrentOverlappingActors();

		// Token: 0x0601CC60 RID: 117856
		void ClearRangeShape();
	}
}
