using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039F6 RID: 14838
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当浮游炮瞄准可以自动开炮时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F14C RID: 127308 RVA: 0x008A9F6D File Offset: 0x008A816D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当浮游炮瞄准可以自动开炮时.StaticFunctionPtr();
		}

		// Token: 0x0601F14D RID: 127309 RVA: 0x008A9F79 File Offset: 0x008A8179
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当浮游炮瞄准可以自动开炮时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当浮游炮瞄准可以自动开炮时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当浮游炮瞄准可以自动开炮时__DelegateSignature");
			}
			return BP_EventManager_C.__当浮游炮瞄准可以自动开炮时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F14E RID: 127310 RVA: 0x008A9F9C File Offset: 0x008A819C
		public 当浮游炮瞄准可以自动开炮时()
		{
		}

		// Token: 0x0601F14F RID: 127311 RVA: 0x008A9FA4 File Offset: 0x008A81A4
		[NullableContext(2)]
		public 当浮游炮瞄准可以自动开炮时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F150 RID: 127312 RVA: 0x008A9FAE File Offset: 0x008A81AE
		public 当浮游炮瞄准可以自动开炮时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F151 RID: 127313 RVA: 0x008A9FB9 File Offset: 0x008A81B9
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, FGameplayTag>) ?? ((Action<int, FGameplayTag>)Delegate.CreateDelegate(typeof(Action<int, FGameplayTag>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F152 RID: 127314 RVA: 0x008A9FEB File Offset: 0x008A81EB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, FGameplayTag> Callback)
		{
			if (当浮游炮瞄准可以自动开炮时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当浮游炮瞄准可以自动开炮时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当浮游炮瞄准可以自动开炮时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当浮游炮瞄准可以自动开炮时.OnScriptCallback));
				}
				当浮游炮瞄准可以自动开炮时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当浮游炮瞄准可以自动开炮时.RegisterId);
		}

		// Token: 0x0601F153 RID: 127315 RVA: 0x008AA025 File Offset: 0x008A8225
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, FGameplayTag> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F154 RID: 127316 RVA: 0x008AA030 File Offset: 0x008A8230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int EntityId, FGameplayTag TargetTag)
		{
			当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams* ptr = stackalloc 当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(当浮游炮瞄准可以自动开炮时.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EntityId = EntityId;
			ptr->TargetTag = TargetTag;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F155 RID: 127317 RVA: 0x008AA074 File Offset: 0x008A8274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, FGameplayTag> action = target as Action<int, FGameplayTag>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams*)__Parameters)->EntityId, ((当浮游炮瞄准可以自动开炮时.__当浮游炮瞄准可以自动开炮时_DelegateParams*)__Parameters)->TargetTag);
		}

		// Token: 0x0400EE2E RID: 60974
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当浮游炮瞄准可以自动开炮时__DelegateSignature";

		// Token: 0x0400EE2F RID: 60975
		private static int RegisterId;

		// Token: 0x020099FA RID: 39418
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __当浮游炮瞄准可以自动开炮时_DelegateParams
		{
			// Token: 0x04030ED3 RID: 200403
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04030ED4 RID: 200404
			[FieldOffset(4)]
			public FGameplayTag TargetTag;
		}

		// Token: 0x020099FB RID: 39419
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030ED5 RID: 200405
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
