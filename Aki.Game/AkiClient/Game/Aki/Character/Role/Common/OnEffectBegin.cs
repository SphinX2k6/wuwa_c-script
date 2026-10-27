using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common
{
	// Token: 0x020040A4 RID: 16548
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnEffectBegin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602AB6C RID: 174956 RVA: 0x009E9B3E File Offset: 0x009E7D3E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnEffectBegin.StaticFunctionPtr();
		}

		// Token: 0x0602AB6D RID: 174957 RVA: 0x009E9B4A File Offset: 0x009E7D4A
		private static IntPtr StaticFunctionPtr()
		{
			if (ABP_PerformanceRole_C.__OnEffectBegin__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				ABP_PerformanceRole_C.__OnEffectBegin__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C:OnEffectBegin__DelegateSignature");
			}
			return ABP_PerformanceRole_C.__OnEffectBegin__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602AB6E RID: 174958 RVA: 0x009E9B6D File Offset: 0x009E7D6D
		public OnEffectBegin()
		{
		}

		// Token: 0x0602AB6F RID: 174959 RVA: 0x009E9B75 File Offset: 0x009E7D75
		[NullableContext(2)]
		public OnEffectBegin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602AB70 RID: 174960 RVA: 0x009E9B7F File Offset: 0x009E7D7F
		public OnEffectBegin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602AB71 RID: 174961 RVA: 0x009E9B8A File Offset: 0x009E7D8A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602AB72 RID: 174962 RVA: 0x009E9BBC File Offset: 0x009E7DBC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602AB73 RID: 174963 RVA: 0x009E9BF6 File Offset: 0x009E7DF6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0602AB74 RID: 174964 RVA: 0x009E9BFF File Offset: 0x009E7DFF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0602AB75 RID: 174965 RVA: 0x009E9C0C File Offset: 0x009E7E0C
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

		// Token: 0x040161B6 RID: 90550
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_PerformanceRole.ABP_PerformanceRole_C:OnEffectBegin__DelegateSignature";

		// Token: 0x040161B7 RID: 90551
		private static int RegisterId;

		// Token: 0x0200A41B RID: 42011
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04032254 RID: 205396
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
