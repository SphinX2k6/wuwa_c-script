using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x0200329C RID: 12956
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnEffectBegin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060208E9 RID: 133353 RVA: 0x00949B0F File Offset: 0x00947D0F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnEffectBegin.StaticFunctionPtr();
		}

		// Token: 0x060208EA RID: 133354 RVA: 0x00949B1B File Offset: 0x00947D1B
		private static IntPtr StaticFunctionPtr()
		{
			if (ABP_PerformanceRole_C.__OnEffectBegin__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				ABP_PerformanceRole_C.__OnEffectBegin__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C:OnEffectBegin__DelegateSignature");
			}
			return ABP_PerformanceRole_C.__OnEffectBegin__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060208EB RID: 133355 RVA: 0x00949B3E File Offset: 0x00947D3E
		public OnEffectBegin()
		{
		}

		// Token: 0x060208EC RID: 133356 RVA: 0x00949B46 File Offset: 0x00947D46
		[NullableContext(2)]
		public OnEffectBegin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060208ED RID: 133357 RVA: 0x00949B50 File Offset: 0x00947D50
		public OnEffectBegin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060208EE RID: 133358 RVA: 0x00949B5B File Offset: 0x00947D5B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x060208EF RID: 133359 RVA: 0x00949B8D File Offset: 0x00947D8D
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (OnEffectBegin.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnEffectBegin.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnEffectBegin.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnEffectBegin.OnScriptCallback));
				}
				OnEffectBegin.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnEffectBegin.RegisterId);
		}

		// Token: 0x060208F0 RID: 133360 RVA: 0x00949BC7 File Offset: 0x00947DC7
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060208F1 RID: 133361 RVA: 0x00949BD0 File Offset: 0x00947DD0
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x060208F2 RID: 133362 RVA: 0x00949BDC File Offset: 0x00947DDC
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

		// Token: 0x04011995 RID: 72085
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C:OnEffectBegin__DelegateSignature";

		// Token: 0x04011996 RID: 72086
		private static int RegisterId;

		// Token: 0x02008F94 RID: 36756
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CD33 RID: 183603
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
