using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F1 RID: 14833
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当捕鱼船创建时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F11A RID: 127258 RVA: 0x008A989A File Offset: 0x008A7A9A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当捕鱼船创建时.StaticFunctionPtr();
		}

		// Token: 0x0601F11B RID: 127259 RVA: 0x008A98A6 File Offset: 0x008A7AA6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当捕鱼船创建时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当捕鱼船创建时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当捕鱼船创建时__DelegateSignature");
			}
			return BP_EventManager_C.__当捕鱼船创建时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F11C RID: 127260 RVA: 0x008A98C9 File Offset: 0x008A7AC9
		public 当捕鱼船创建时()
		{
		}

		// Token: 0x0601F11D RID: 127261 RVA: 0x008A98D1 File Offset: 0x008A7AD1
		[NullableContext(2)]
		public 当捕鱼船创建时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F11E RID: 127262 RVA: 0x008A98DB File Offset: 0x008A7ADB
		public 当捕鱼船创建时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F11F RID: 127263 RVA: 0x008A98E6 File Offset: 0x008A7AE6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F120 RID: 127264 RVA: 0x008A9918 File Offset: 0x008A7B18
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (当捕鱼船创建时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当捕鱼船创建时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当捕鱼船创建时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当捕鱼船创建时.OnScriptCallback));
				}
				当捕鱼船创建时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当捕鱼船创建时.RegisterId);
		}

		// Token: 0x0601F121 RID: 127265 RVA: 0x008A9952 File Offset: 0x008A7B52
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F122 RID: 127266 RVA: 0x008A995C File Offset: 0x008A7B5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(AActor fishingBoat)
		{
			当捕鱼船创建时.__当捕鱼船创建时_DelegateParams* ptr = stackalloc 当捕鱼船创建时.__当捕鱼船创建时_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(当捕鱼船创建时.__当捕鱼船创建时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当捕鱼船创建时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->fishingBoat = ((fishingBoat != null) ? fishingBoat.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F123 RID: 127267 RVA: 0x008A99A8 File Offset: 0x008A7BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((当捕鱼船创建时.__当捕鱼船创建时_DelegateParams*)__Parameters)->fishingBoat);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400EE24 RID: 60964
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当捕鱼船创建时__DelegateSignature";

		// Token: 0x0400EE25 RID: 60965
		private static int RegisterId;

		// Token: 0x020099F1 RID: 39409
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __当捕鱼船创建时_DelegateParams
		{
			// Token: 0x04030EC9 RID: 200393
			[FieldOffset(0)]
			public IntPtr fishingBoat;
		}

		// Token: 0x020099F2 RID: 39410
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030ECA RID: 200394
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
