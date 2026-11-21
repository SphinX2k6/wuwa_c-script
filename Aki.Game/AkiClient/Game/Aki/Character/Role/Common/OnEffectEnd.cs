using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x0200329D RID: 12957
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnEffectEnd : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060208F3 RID: 133363 RVA: 0x00949C1E File Offset: 0x00947E1E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnEffectEnd.StaticFunctionPtr();
		}

		// Token: 0x060208F4 RID: 133364 RVA: 0x00949C2A File Offset: 0x00947E2A
		private static IntPtr StaticFunctionPtr()
		{
			if (ABP_PerformanceRole_C.__OnEffectEnd__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				ABP_PerformanceRole_C.__OnEffectEnd__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C:OnEffectEnd__DelegateSignature");
			}
			return ABP_PerformanceRole_C.__OnEffectEnd__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060208F5 RID: 133365 RVA: 0x00949C4D File Offset: 0x00947E4D
		public OnEffectEnd()
		{
		}

		// Token: 0x060208F6 RID: 133366 RVA: 0x00949C55 File Offset: 0x00947E55
		[NullableContext(2)]
		public OnEffectEnd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060208F7 RID: 133367 RVA: 0x00949C5F File Offset: 0x00947E5F
		public OnEffectEnd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060208F8 RID: 133368 RVA: 0x00949C6A File Offset: 0x00947E6A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060208F9 RID: 133369 RVA: 0x00949C9C File Offset: 0x00947E9C
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (OnEffectEnd.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnEffectEnd.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnEffectEnd.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnEffectEnd.OnScriptCallback));
				}
				OnEffectEnd.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnEffectEnd.RegisterId);
		}

		// Token: 0x060208FA RID: 133370 RVA: 0x00949CD6 File Offset: 0x00947ED6
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060208FB RID: 133371 RVA: 0x00949CDF File Offset: 0x00947EDF
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060208FC RID: 133372 RVA: 0x00949CEC File Offset: 0x00947EEC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04011997 RID: 72087
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C:OnEffectEnd__DelegateSignature";

		// Token: 0x04011998 RID: 72088
		private static int RegisterId;

		// Token: 0x02008F95 RID: 36757
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CD34 RID: 183604
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
