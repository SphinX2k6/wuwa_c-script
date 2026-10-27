using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F2 RID: 14834
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当换人完成时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F124 RID: 127268 RVA: 0x008A99F9 File Offset: 0x008A7BF9
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当换人完成时.StaticFunctionPtr();
		}

		// Token: 0x0601F125 RID: 127269 RVA: 0x008A9A05 File Offset: 0x008A7C05
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当换人完成时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当换人完成时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当换人完成时__DelegateSignature");
			}
			return BP_EventManager_C.__当换人完成时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F126 RID: 127270 RVA: 0x008A9A28 File Offset: 0x008A7C28
		public 当换人完成时()
		{
		}

		// Token: 0x0601F127 RID: 127271 RVA: 0x008A9A30 File Offset: 0x008A7C30
		[NullableContext(2)]
		public 当换人完成时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F128 RID: 127272 RVA: 0x008A9A3A File Offset: 0x008A7C3A
		public 当换人完成时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F129 RID: 127273 RVA: 0x008A9A45 File Offset: 0x008A7C45
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F12A RID: 127274 RVA: 0x008A9A77 File Offset: 0x008A7C77
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (当换人完成时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当换人完成时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当换人完成时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当换人完成时.OnScriptCallback));
				}
				当换人完成时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当换人完成时.RegisterId);
		}

		// Token: 0x0601F12B RID: 127275 RVA: 0x008A9AB1 File Offset: 0x008A7CB1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F12C RID: 127276 RVA: 0x008A9ABA File Offset: 0x008A7CBA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F12D RID: 127277 RVA: 0x008A9AC4 File Offset: 0x008A7CC4
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

		// Token: 0x0400EE26 RID: 60966
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当换人完成时__DelegateSignature";

		// Token: 0x0400EE27 RID: 60967
		private static int RegisterId;

		// Token: 0x020099F3 RID: 39411
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030ECB RID: 200395
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
