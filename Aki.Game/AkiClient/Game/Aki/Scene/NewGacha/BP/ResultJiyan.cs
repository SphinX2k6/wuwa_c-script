using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A56 RID: 14934
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultJiyan : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F89C RID: 129180 RVA: 0x008BB5AE File Offset: 0x008B97AE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultJiyan.StaticFunctionPtr();
		}

		// Token: 0x0601F89D RID: 129181 RVA: 0x008BB5BA File Offset: 0x008B97BA
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultJiyan__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultJiyan__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJiyan__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultJiyan__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F89E RID: 129182 RVA: 0x008BB5DD File Offset: 0x008B97DD
		public ResultJiyan()
		{
		}

		// Token: 0x0601F89F RID: 129183 RVA: 0x008BB5E5 File Offset: 0x008B97E5
		[NullableContext(2)]
		public ResultJiyan(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8A0 RID: 129184 RVA: 0x008BB5EF File Offset: 0x008B97EF
		public ResultJiyan(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8A1 RID: 129185 RVA: 0x008BB5FA File Offset: 0x008B97FA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8A2 RID: 129186 RVA: 0x008BB62C File Offset: 0x008B982C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultJiyan.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultJiyan.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultJiyan.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultJiyan.OnScriptCallback));
				}
				ResultJiyan.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultJiyan.RegisterId);
		}

		// Token: 0x0601F8A3 RID: 129187 RVA: 0x008BB666 File Offset: 0x008B9866
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8A4 RID: 129188 RVA: 0x008BB66F File Offset: 0x008B986F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F8A5 RID: 129189 RVA: 0x008BB67C File Offset: 0x008B987C
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

		// Token: 0x0400F2C6 RID: 62150
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJiyan__DelegateSignature";

		// Token: 0x0400F2C7 RID: 62151
		private static int RegisterId;

		// Token: 0x02009AFE RID: 39678
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310D1 RID: 200913
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
