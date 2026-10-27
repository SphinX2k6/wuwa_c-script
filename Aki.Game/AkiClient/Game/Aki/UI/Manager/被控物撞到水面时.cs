using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003A02 RID: 14850
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 被控物撞到水面时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F1C4 RID: 127428 RVA: 0x008AAF0A File Offset: 0x008A910A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 被控物撞到水面时.StaticFunctionPtr();
		}

		// Token: 0x0601F1C5 RID: 127429 RVA: 0x008AAF16 File Offset: 0x008A9116
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__被控物撞到水面时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__被控物撞到水面时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:被控物撞到水面时__DelegateSignature");
			}
			return BP_EventManager_C.__被控物撞到水面时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F1C6 RID: 127430 RVA: 0x008AAF39 File Offset: 0x008A9139
		public 被控物撞到水面时()
		{
		}

		// Token: 0x0601F1C7 RID: 127431 RVA: 0x008AAF41 File Offset: 0x008A9141
		[NullableContext(2)]
		public 被控物撞到水面时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F1C8 RID: 127432 RVA: 0x008AAF4B File Offset: 0x008A914B
		public 被控物撞到水面时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F1C9 RID: 127433 RVA: 0x008AAF56 File Offset: 0x008A9156
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor>) ?? ((Action<AActor, AActor>)Delegate.CreateDelegate(typeof(Action<AActor, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F1CA RID: 127434 RVA: 0x008AAF88 File Offset: 0x008A9188
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<AActor, AActor> Callback)
		{
			if (被控物撞到水面时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 被控物撞到水面时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (被控物撞到水面时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(被控物撞到水面时.OnScriptCallback));
				}
				被控物撞到水面时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 被控物撞到水面时.RegisterId);
		}

		// Token: 0x0601F1CB RID: 127435 RVA: 0x008AAFC2 File Offset: 0x008A91C2
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<AActor, AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F1CC RID: 127436 RVA: 0x008AAFCC File Offset: 0x008A91CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor 被控物, AActor 水面)
		{
			被控物撞到水面时.__被控物撞到水面时_DelegateParams* ptr = stackalloc 被控物撞到水面时.__被控物撞到水面时_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(被控物撞到水面时.__被控物撞到水面时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(被控物撞到水面时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->被控物 = ((被控物 != null) ? 被控物.NativePtr : IntPtr.Zero);
			ptr->水面 = ((水面 != null) ? 水面.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F1CD RID: 127437 RVA: 0x008AB030 File Offset: 0x008A9230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor, AActor> action = target as Action<AActor, AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((被控物撞到水面时.__被控物撞到水面时_DelegateParams*)__Parameters)->被控物);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((被控物撞到水面时.__被控物撞到水面时_DelegateParams*)__Parameters)->水面);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x0400EE46 RID: 60998
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:被控物撞到水面时__DelegateSignature";

		// Token: 0x0400EE47 RID: 60999
		private static int RegisterId;

		// Token: 0x02009A0E RID: 39438
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __被控物撞到水面时_DelegateParams
		{
			// Token: 0x04030EEF RID: 200431
			[FieldOffset(0)]
			public IntPtr 被控物;

			// Token: 0x04030EF0 RID: 200432
			[FieldOffset(8)]
			public IntPtr 水面;
		}

		// Token: 0x02009A0F RID: 39439
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EF1 RID: 200433
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
