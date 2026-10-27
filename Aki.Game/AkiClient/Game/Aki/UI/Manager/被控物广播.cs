using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003A01 RID: 14849
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 被控物广播 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F1BA RID: 127418 RVA: 0x008AADFB File Offset: 0x008A8FFB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 被控物广播.StaticFunctionPtr();
		}

		// Token: 0x0601F1BB RID: 127419 RVA: 0x008AAE07 File Offset: 0x008A9007
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__被控物广播__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__被控物广播__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:被控物广播__DelegateSignature");
			}
			return BP_EventManager_C.__被控物广播__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F1BC RID: 127420 RVA: 0x008AAE2A File Offset: 0x008A902A
		public 被控物广播()
		{
		}

		// Token: 0x0601F1BD RID: 127421 RVA: 0x008AAE32 File Offset: 0x008A9032
		[NullableContext(2)]
		public 被控物广播(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F1BE RID: 127422 RVA: 0x008AAE3C File Offset: 0x008A903C
		public 被控物广播(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F1BF RID: 127423 RVA: 0x008AAE47 File Offset: 0x008A9047
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F1C0 RID: 127424 RVA: 0x008AAE79 File Offset: 0x008A9079
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (被控物广播.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 被控物广播.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (被控物广播.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(被控物广播.OnScriptCallback));
				}
				被控物广播.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 被控物广播.RegisterId);
		}

		// Token: 0x0601F1C1 RID: 127425 RVA: 0x008AAEB3 File Offset: 0x008A90B3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F1C2 RID: 127426 RVA: 0x008AAEBC File Offset: 0x008A90BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F1C3 RID: 127427 RVA: 0x008AAEC8 File Offset: 0x008A90C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400EE44 RID: 60996
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:被控物广播__DelegateSignature";

		// Token: 0x0400EE45 RID: 60997
		private static int RegisterId;

		// Token: 0x02009A0D RID: 39437
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EEE RID: 200430
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
