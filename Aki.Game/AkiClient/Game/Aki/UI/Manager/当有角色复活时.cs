using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F4 RID: 14836
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当有角色复活时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F138 RID: 127288 RVA: 0x008A9CAE File Offset: 0x008A7EAE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当有角色复活时.StaticFunctionPtr();
		}

		// Token: 0x0601F139 RID: 127289 RVA: 0x008A9CBA File Offset: 0x008A7EBA
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当有角色复活时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当有角色复活时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色复活时__DelegateSignature");
			}
			return BP_EventManager_C.__当有角色复活时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F13A RID: 127290 RVA: 0x008A9CDD File Offset: 0x008A7EDD
		public 当有角色复活时()
		{
		}

		// Token: 0x0601F13B RID: 127291 RVA: 0x008A9CE5 File Offset: 0x008A7EE5
		[NullableContext(2)]
		public 当有角色复活时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F13C RID: 127292 RVA: 0x008A9CEF File Offset: 0x008A7EEF
		public 当有角色复活时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F13D RID: 127293 RVA: 0x008A9CFA File Offset: 0x008A7EFA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter>) ?? ((Action<TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F13E RID: 127294 RVA: 0x008A9D2C File Offset: 0x008A7F2C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			if (当有角色复活时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当有角色复活时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当有角色复活时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当有角色复活时.OnScriptCallback));
				}
				当有角色复活时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当有角色复活时.RegisterId);
		}

		// Token: 0x0601F13F RID: 127295 RVA: 0x008A9D66 File Offset: 0x008A7F66
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F140 RID: 127296 RVA: 0x008A9D70 File Offset: 0x008A7F70
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 角色)
		{
			当有角色复活时.__当有角色复活时_DelegateParams* ptr = stackalloc 当有角色复活时.__当有角色复活时_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(当有角色复活时.__当有角色复活时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当有角色复活时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F141 RID: 127297 RVA: 0x008A9DBC File Offset: 0x008A7FBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter> action = target as Action<TsBaseCharacter>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((当有角色复活时.__当有角色复活时_DelegateParams*)__Parameters)->角色);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400EE2A RID: 60970
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色复活时__DelegateSignature";

		// Token: 0x0400EE2B RID: 60971
		private static int RegisterId;

		// Token: 0x020099F6 RID: 39414
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __当有角色复活时_DelegateParams
		{
			// Token: 0x04030ECF RID: 200399
			[FieldOffset(0)]
			public IntPtr 角色;
		}

		// Token: 0x020099F7 RID: 39415
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030ED0 RID: 200400
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
