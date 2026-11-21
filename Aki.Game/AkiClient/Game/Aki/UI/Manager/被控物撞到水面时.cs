using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003059 RID: 12377
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 被控物撞到水面时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D625 RID: 120357 RVA: 0x008F356A File Offset: 0x008F176A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 被控物撞到水面时.StaticFunctionPtr();
		}

		// Token: 0x0601D626 RID: 120358 RVA: 0x008F3576 File Offset: 0x008F1776
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__被控物撞到水面时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__被控物撞到水面时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:被控物撞到水面时__DelegateSignature");
			}
			return BP_EventManager_C.__被控物撞到水面时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D627 RID: 120359 RVA: 0x008F3599 File Offset: 0x008F1799
		public 被控物撞到水面时()
		{
		}

		// Token: 0x0601D628 RID: 120360 RVA: 0x008F35A1 File Offset: 0x008F17A1
		[NullableContext(2)]
		public 被控物撞到水面时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D629 RID: 120361 RVA: 0x008F35AB File Offset: 0x008F17AB
		public 被控物撞到水面时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D62A RID: 120362 RVA: 0x008F35B6 File Offset: 0x008F17B6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor, AActor>) ?? ((Action<AActor, AActor>)Delegate.CreateDelegate(typeof(Action<AActor, AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D62B RID: 120363 RVA: 0x008F35E8 File Offset: 0x008F17E8
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

		// Token: 0x0601D62C RID: 120364 RVA: 0x008F3622 File Offset: 0x008F1822
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<AActor, AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D62D RID: 120365 RVA: 0x008F362C File Offset: 0x008F182C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor 被控物, AActor 水面)
		{
			被控物撞到水面时.__被控物撞到水面时_DelegateParams* ptr = stackalloc 被控物撞到水面时.__被控物撞到水面时_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(被控物撞到水面时.__被控物撞到水面时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(被控物撞到水面时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->被控物 = ((被控物 != null) ? 被控物.NativePtr : IntPtr.Zero);
			ptr->水面 = ((水面 != null) ? 水面.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D62E RID: 120366 RVA: 0x008F3690 File Offset: 0x008F1890
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400F76E RID: 63342
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:被控物撞到水面时__DelegateSignature";

		// Token: 0x0400F76F RID: 63343
		private static int RegisterId;

		// Token: 0x02008CC2 RID: 36034
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __被控物撞到水面时_DelegateParams
		{
			// Token: 0x0402C7CF RID: 182223
			[FieldOffset(0)]
			public IntPtr 被控物;

			// Token: 0x0402C7D0 RID: 182224
			[FieldOffset(8)]
			public IntPtr 水面;
		}

		// Token: 0x02008CC3 RID: 36035
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7D1 RID: 182225
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
