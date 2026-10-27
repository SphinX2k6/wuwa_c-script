using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003A04 RID: 14852
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 角色部位弱点打击时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F1D8 RID: 127448 RVA: 0x008AB21F File Offset: 0x008A941F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 角色部位弱点打击时.StaticFunctionPtr();
		}

		// Token: 0x0601F1D9 RID: 127449 RVA: 0x008AB22B File Offset: 0x008A942B
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__角色部位弱点打击时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__角色部位弱点打击时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色部位弱点打击时__DelegateSignature");
			}
			return BP_EventManager_C.__角色部位弱点打击时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F1DA RID: 127450 RVA: 0x008AB24E File Offset: 0x008A944E
		public 角色部位弱点打击时()
		{
		}

		// Token: 0x0601F1DB RID: 127451 RVA: 0x008AB256 File Offset: 0x008A9456
		[NullableContext(2)]
		public 角色部位弱点打击时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F1DC RID: 127452 RVA: 0x008AB260 File Offset: 0x008A9460
		public 角色部位弱点打击时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F1DD RID: 127453 RVA: 0x008AB26B File Offset: 0x008A946B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter>) ?? ((Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter>)Delegate.CreateDelegate(typeof(Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F1DE RID: 127454 RVA: 0x008AB29D File Offset: 0x008A949D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter> Callback)
		{
			if (角色部位弱点打击时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 角色部位弱点打击时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (角色部位弱点打击时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(角色部位弱点打击时.OnScriptCallback));
				}
				角色部位弱点打击时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 角色部位弱点打击时.RegisterId);
		}

		// Token: 0x0601F1DF RID: 127455 RVA: 0x008AB2D7 File Offset: 0x008A94D7
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F1E0 RID: 127456 RVA: 0x008AB2E0 File Offset: 0x008A94E0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(TsBaseCharacter 角色, FGameplayTag 部位Tag, TsBaseCharacter 攻击者)
		{
			角色部位弱点打击时.__角色部位弱点打击时_DelegateParams* ptr = stackalloc 角色部位弱点打击时.__角色部位弱点打击时_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(角色部位弱点打击时.__角色部位弱点打击时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(角色部位弱点打击时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->角色 = ((角色 != null) ? 角色.NativePtr : IntPtr.Zero);
			ptr->部位Tag = 部位Tag;
			ptr->攻击者 = ((攻击者 != null) ? 攻击者.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F1E1 RID: 127457 RVA: 0x008AB348 File Offset: 0x008A9548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter> action = target as Action<TsBaseCharacter, FGameplayTag, TsBaseCharacter>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((角色部位弱点打击时.__角色部位弱点打击时_DelegateParams*)__Parameters)->角色);
			TsBaseCharacter orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(((角色部位弱点打击时.__角色部位弱点打击时_DelegateParams*)__Parameters)->攻击者);
			action(orCreateUObjectByNativePointer, ((角色部位弱点打击时.__角色部位弱点打击时_DelegateParams*)__Parameters)->部位Tag, orCreateUObjectByNativePointer2);
		}

		// Token: 0x0400EE4A RID: 61002
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:角色部位弱点打击时__DelegateSignature";

		// Token: 0x0400EE4B RID: 61003
		private static int RegisterId;

		// Token: 0x02009A12 RID: 39442
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __角色部位弱点打击时_DelegateParams
		{
			// Token: 0x04030EF7 RID: 200439
			[FieldOffset(0)]
			public IntPtr 角色;

			// Token: 0x04030EF8 RID: 200440
			[FieldOffset(8)]
			public FGameplayTag 部位Tag;

			// Token: 0x04030EF9 RID: 200441
			[FieldOffset(24)]
			public IntPtr 攻击者;
		}

		// Token: 0x02009A13 RID: 39443
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EFA RID: 200442
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
