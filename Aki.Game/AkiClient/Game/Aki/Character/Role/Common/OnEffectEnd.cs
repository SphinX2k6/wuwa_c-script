using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x020040A5 RID: 16549
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnEffectEnd : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602AB76 RID: 174966 RVA: 0x009E9C4E File Offset: 0x009E7E4E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnEffectEnd.StaticFunctionPtr();
		}

		// Token: 0x0602AB77 RID: 174967 RVA: 0x009E9C5A File Offset: 0x009E7E5A
		private static IntPtr StaticFunctionPtr()
		{
			if (ABP_PerformanceRole_C.__OnEffectEnd__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				ABP_PerformanceRole_C.__OnEffectEnd__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C:OnEffectEnd__DelegateSignature");
			}
			return ABP_PerformanceRole_C.__OnEffectEnd__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602AB78 RID: 174968 RVA: 0x009E9C7D File Offset: 0x009E7E7D
		public OnEffectEnd()
		{
		}

		// Token: 0x0602AB79 RID: 174969 RVA: 0x009E9C85 File Offset: 0x009E7E85
		[NullableContext(2)]
		public OnEffectEnd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602AB7A RID: 174970 RVA: 0x009E9C8F File Offset: 0x009E7E8F
		public OnEffectEnd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602AB7B RID: 174971 RVA: 0x009E9C9A File Offset: 0x009E7E9A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602AB7C RID: 174972 RVA: 0x009E9CCC File Offset: 0x009E7ECC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602AB7D RID: 174973 RVA: 0x009E9D06 File Offset: 0x009E7F06
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602AB7E RID: 174974 RVA: 0x009E9D0F File Offset: 0x009E7F0F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0602AB7F RID: 174975 RVA: 0x009E9D1C File Offset: 0x009E7F1C
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

		// Token: 0x040161B8 RID: 90552
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C:OnEffectEnd__DelegateSignature";

		// Token: 0x040161B9 RID: 90553
		private static int RegisterId;

		// Token: 0x0200A41C RID: 42012
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04032255 RID: 205397
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
