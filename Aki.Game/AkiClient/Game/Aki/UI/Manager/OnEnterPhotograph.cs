using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039E6 RID: 14822
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnEnterPhotograph : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F0AC RID: 127148 RVA: 0x008A8A88 File Offset: 0x008A6C88
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnEnterPhotograph.StaticFunctionPtr();
		}

		// Token: 0x0601F0AD RID: 127149 RVA: 0x008A8A94 File Offset: 0x008A6C94
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__OnEnterPhotograph__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__OnEnterPhotograph__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:OnEnterPhotograph__DelegateSignature");
			}
			return BP_EventManager_C.__OnEnterPhotograph__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F0AE RID: 127150 RVA: 0x008A8AB7 File Offset: 0x008A6CB7
		public OnEnterPhotograph()
		{
		}

		// Token: 0x0601F0AF RID: 127151 RVA: 0x008A8ABF File Offset: 0x008A6CBF
		[NullableContext(2)]
		public OnEnterPhotograph(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F0B0 RID: 127152 RVA: 0x008A8AC9 File Offset: 0x008A6CC9
		public OnEnterPhotograph(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F0B1 RID: 127153 RVA: 0x008A8AD4 File Offset: 0x008A6CD4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F0B2 RID: 127154 RVA: 0x008A8B06 File Offset: 0x008A6D06
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (OnEnterPhotograph.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnEnterPhotograph.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnEnterPhotograph.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnEnterPhotograph.OnScriptCallback));
				}
				OnEnterPhotograph.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnEnterPhotograph.RegisterId);
		}

		// Token: 0x0601F0B3 RID: 127155 RVA: 0x008A8B40 File Offset: 0x008A6D40
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F0B4 RID: 127156 RVA: 0x008A8B49 File Offset: 0x008A6D49
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F0B5 RID: 127157 RVA: 0x008A8B54 File Offset: 0x008A6D54
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

		// Token: 0x0400EE0E RID: 60942
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:OnEnterPhotograph__DelegateSignature";

		// Token: 0x0400EE0F RID: 60943
		private static int RegisterId;

		// Token: 0x020099DE RID: 39390
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EB1 RID: 200369
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
