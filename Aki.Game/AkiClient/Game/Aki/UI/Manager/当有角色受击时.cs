using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F3 RID: 14835
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当有角色受击时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F12E RID: 127278 RVA: 0x008A9B06 File Offset: 0x008A7D06
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当有角色受击时.StaticFunctionPtr();
		}

		// Token: 0x0601F12F RID: 127279 RVA: 0x008A9B12 File Offset: 0x008A7D12
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当有角色受击时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当有角色受击时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色受击时__DelegateSignature");
			}
			return BP_EventManager_C.__当有角色受击时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F130 RID: 127280 RVA: 0x008A9B35 File Offset: 0x008A7D35
		public 当有角色受击时()
		{
		}

		// Token: 0x0601F131 RID: 127281 RVA: 0x008A9B3D File Offset: 0x008A7D3D
		[NullableContext(2)]
		public 当有角色受击时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F132 RID: 127282 RVA: 0x008A9B47 File Offset: 0x008A7D47
		public 当有角色受击时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F133 RID: 127283 RVA: 0x008A9B52 File Offset: 0x008A7D52
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, SHitInformation>) ?? ((Action<TsBaseCharacter, SHitInformation>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, SHitInformation>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F134 RID: 127284 RVA: 0x008A9B84 File Offset: 0x008A7D84
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<TsBaseCharacter, SHitInformation> Callback)
		{
			if (当有角色受击时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当有角色受击时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当有角色受击时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当有角色受击时.OnScriptCallback));
				}
				当有角色受击时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当有角色受击时.RegisterId);
		}

		// Token: 0x0601F135 RID: 127285 RVA: 0x008A9BBE File Offset: 0x008A7DBE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			1
		})] Action<TsBaseCharacter, SHitInformation> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F136 RID: 127286 RVA: 0x008A9BC8 File Offset: 0x008A7DC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 角色, SHitInformation 受击数据)
		{
			当有角色受击时.__当有角色受击时_DelegateParams* ptr = stackalloc 当有角色受击时.__当有角色受击时_DelegateParams[(UIntPtr)2295] + 15L / (long)sizeof(当有角色受击时.__当有角色受击时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当有角色受击时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			if (受击数据 != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SHitInformation.StaticStruct(), &ptr->受击数据, 受击数据.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_EventManager_C.__当有角色受击时__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F137 RID: 127287 RVA: 0x008A9C4C File Offset: 0x008A7E4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter, SHitInformation> action = target as Action<TsBaseCharacter, SHitInformation>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((当有角色受击时.__当有角色受击时_DelegateParams*)__Parameters)->角色);
			SHitInformation arg = new SHitInformation(&((当有角色受击时.__当有角色受击时_DelegateParams*)__Parameters)->受击数据, true, true);
			action(orCreateUObjectByNativePointer, arg);
		}

		// Token: 0x0400EE28 RID: 60968
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当有角色受击时__DelegateSignature";

		// Token: 0x0400EE29 RID: 60969
		private static int RegisterId;

		// Token: 0x020099F4 RID: 39412
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2280)]
		protected ref struct __当有角色受击时_DelegateParams
		{
			// Token: 0x04030ECC RID: 200396
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04030ECD RID: 200397
			[FieldOffset(8)]
			public byte 受击数据;
		}

		// Token: 0x020099F5 RID: 39413
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030ECE RID: 200398
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
