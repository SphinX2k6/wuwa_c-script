using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039FA RID: 14842
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当触发相机注视时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F174 RID: 127348 RVA: 0x008AA4AA File Offset: 0x008A86AA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当触发相机注视时.StaticFunctionPtr();
		}

		// Token: 0x0601F175 RID: 127349 RVA: 0x008AA4B6 File Offset: 0x008A86B6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当触发相机注视时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当触发相机注视时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发相机注视时__DelegateSignature");
			}
			return BP_EventManager_C.__当触发相机注视时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F176 RID: 127350 RVA: 0x008AA4D9 File Offset: 0x008A86D9
		public 当触发相机注视时()
		{
		}

		// Token: 0x0601F177 RID: 127351 RVA: 0x008AA4E1 File Offset: 0x008A86E1
		[NullableContext(2)]
		public 当触发相机注视时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F178 RID: 127352 RVA: 0x008AA4EB File Offset: 0x008A86EB
		public 当触发相机注视时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F179 RID: 127353 RVA: 0x008AA4F6 File Offset: 0x008A86F6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F17A RID: 127354 RVA: 0x008AA528 File Offset: 0x008A8728
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (当触发相机注视时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当触发相机注视时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当触发相机注视时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当触发相机注视时.OnScriptCallback));
				}
				当触发相机注视时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当触发相机注视时.RegisterId);
		}

		// Token: 0x0601F17B RID: 127355 RVA: 0x008AA562 File Offset: 0x008A8762
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F17C RID: 127356 RVA: 0x008AA56B File Offset: 0x008A876B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F17D RID: 127357 RVA: 0x008AA578 File Offset: 0x008A8778
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

		// Token: 0x0400EE36 RID: 60982
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发相机注视时__DelegateSignature";

		// Token: 0x0400EE37 RID: 60983
		private static int RegisterId;

		// Token: 0x02009A01 RID: 39425
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EDC RID: 200412
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
