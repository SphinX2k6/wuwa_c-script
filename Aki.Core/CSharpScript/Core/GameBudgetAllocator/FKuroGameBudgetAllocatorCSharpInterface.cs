using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Core.GameBudgetAllocator
{
	// Token: 0x02000133 RID: 307
	[NullableContext(1)]
	[Nullable(0)]
	public class FKuroGameBudgetAllocatorCSharpInterface
	{
		// Token: 0x06000B4A RID: 2890
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint RegisterFunction(IntPtr GCHandlePtr, in FName GroupTag, ESignificanceGroup SignificanceGroup, IntPtr ActorPtr, bool OverrideLateUpdate, bool OverrideEnableChange, bool OverrideWasRecentlyRenderedChange, bool OverrideLocationProxy);

		// Token: 0x06000B4B RID: 2891
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetAllPlayerEntities(ref IntPtr[] OutEntities);

		// Token: 0x06000B4C RID: 2892
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetEntitiesInRangeWithLocation(in FVectorDouble Location, float Distance, in FName GroupName, ref IntPtr[] OutEntities);
	}
}
