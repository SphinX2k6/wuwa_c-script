using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x020039FB RID: 14843
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当触发结算镜头时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F17E RID: 127358 RVA: 0x008AA5BA File Offset: 0x008A87BA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当触发结算镜头时.StaticFunctionPtr();
		}

		// Token: 0x0601F17F RID: 127359 RVA: 0x008AA5C6 File Offset: 0x008A87C6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当触发结算镜头时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当触发结算镜头时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发结算镜头时__DelegateSignature");
			}
			return BP_EventManager_C.__当触发结算镜头时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F180 RID: 127360 RVA: 0x008AA5E9 File Offset: 0x008A87E9
		public 当触发结算镜头时()
		{
		}

		// Token: 0x0601F181 RID: 127361 RVA: 0x008AA5F1 File Offset: 0x008A87F1
		[NullableContext(2)]
		public 当触发结算镜头时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F182 RID: 127362 RVA: 0x008AA5FB File Offset: 0x008A87FB
		public 当触发结算镜头时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F183 RID: 127363 RVA: 0x008AA606 File Offset: 0x008A8806
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F184 RID: 127364 RVA: 0x008AA638 File Offset: 0x008A8838
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (当触发结算镜头时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当触发结算镜头时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当触发结算镜头时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当触发结算镜头时.OnScriptCallback));
				}
				当触发结算镜头时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当触发结算镜头时.RegisterId);
		}

		// Token: 0x0601F185 RID: 127365 RVA: 0x008AA672 File Offset: 0x008A8872
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F186 RID: 127366 RVA: 0x008AA67B File Offset: 0x008A887B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F187 RID: 127367 RVA: 0x008AA688 File Offset: 0x008A8888
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

		// Token: 0x0400EE38 RID: 60984
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发结算镜头时__DelegateSignature";

		// Token: 0x0400EE39 RID: 60985
		private static int RegisterId;

		// Token: 0x02009A02 RID: 39426
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030EDD RID: 200413
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
