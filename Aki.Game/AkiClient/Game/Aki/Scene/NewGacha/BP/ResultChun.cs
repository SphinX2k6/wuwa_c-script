using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A53 RID: 14931
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultChun : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F87E RID: 129150 RVA: 0x008BB27E File Offset: 0x008B947E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultChun.StaticFunctionPtr();
		}

		// Token: 0x0601F87F RID: 129151 RVA: 0x008BB28A File Offset: 0x008B948A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultChun__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultChun__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultChun__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultChun__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F880 RID: 129152 RVA: 0x008BB2AD File Offset: 0x008B94AD
		public ResultChun()
		{
		}

		// Token: 0x0601F881 RID: 129153 RVA: 0x008BB2B5 File Offset: 0x008B94B5
		[NullableContext(2)]
		public ResultChun(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F882 RID: 129154 RVA: 0x008BB2BF File Offset: 0x008B94BF
		public ResultChun(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F883 RID: 129155 RVA: 0x008BB2CA File Offset: 0x008B94CA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F884 RID: 129156 RVA: 0x008BB2FC File Offset: 0x008B94FC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultChun.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultChun.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultChun.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultChun.OnScriptCallback));
				}
				ResultChun.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultChun.RegisterId);
		}

		// Token: 0x0601F885 RID: 129157 RVA: 0x008BB336 File Offset: 0x008B9536
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F886 RID: 129158 RVA: 0x008BB33F File Offset: 0x008B953F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F887 RID: 129159 RVA: 0x008BB34C File Offset: 0x008B954C
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

		// Token: 0x0400F2C0 RID: 62144
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultChun__DelegateSignature";

		// Token: 0x0400F2C1 RID: 62145
		private static int RegisterId;

		// Token: 0x02009AFB RID: 39675
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310CE RID: 200910
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
