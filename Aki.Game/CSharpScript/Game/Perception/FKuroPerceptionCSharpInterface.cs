using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Perception
{
	// Token: 0x020045FA RID: 17914
	public class FKuroPerceptionCSharpInterface
	{
		// Token: 0x0602E327 RID: 189223
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint AddStaticPerceptionRange(in FVectorDouble Center, float Range, uint Group, IntPtr GCHandlePtr, bool bEnterCondition, bool bOnEnter, bool bOnLeave);

		// Token: 0x0602E328 RID: 189224
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint AddDynamicPerceptionRange(uint Token, float Range, uint Group, IntPtr GCHandlePtr, bool bGetLocationProxy, bool bEnterCondition, bool bOnEnter, bool bOnLeave);

		// Token: 0x0602E329 RID: 189225
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern uint RegisterPlayerPerceptionEvent(float EnterDistance, float LeaveDistance, uint Token, in FVectorDouble LocationOffset, IntPtr GCHandlePtr, bool bOnEnter, bool bOnLeave, bool bEnterCondition, bool bOnDestroy);

		// Token: 0x0602E32A RID: 189226
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetEntitiesInPlayerPerceptionRange(float Range, uint Group, ref IntPtr[] OutEntities);
	}
}
