using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Perception
{
	// Token: 0x02003523 RID: 13603
	public class FKuroPerceptionCSharpInterface
	{
		// Token: 0x06022A1C RID: 141852
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint AddStaticPerceptionRange(in FVectorDouble Center, float Range, uint Group, IntPtr GCHandlePtr, bool bEnterCondition, bool bOnEnter, bool bOnLeave);

		// Token: 0x06022A1D RID: 141853
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint AddDynamicPerceptionRange(uint Token, float Range, uint Group, IntPtr GCHandlePtr, bool bGetLocationProxy, bool bEnterCondition, bool bOnEnter, bool bOnLeave);

		// Token: 0x06022A1E RID: 141854
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint RegisterPlayerPerceptionEvent(float EnterDistance, float LeaveDistance, uint Token, in FVectorDouble LocationOffset, IntPtr GCHandlePtr, bool bOnEnter, bool bOnLeave, bool bEnterCondition, bool bOnDestroy);

		// Token: 0x06022A1F RID: 141855
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetEntitiesInPlayerPerceptionRange(float Range, uint Group, ref IntPtr[] OutEntities);
	}
}
