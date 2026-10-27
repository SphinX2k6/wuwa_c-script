using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A64 RID: 14948
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultYuanwu : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F928 RID: 129320 RVA: 0x008BC4C6 File Offset: 0x008BA6C6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultYuanwu.StaticFunctionPtr();
		}

		// Token: 0x0601F929 RID: 129321 RVA: 0x008BC4D2 File Offset: 0x008BA6D2
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultYuanwu__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultYuanwu__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYuanwu__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultYuanwu__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F92A RID: 129322 RVA: 0x008BC4F5 File Offset: 0x008BA6F5
		public ResultYuanwu()
		{
		}

		// Token: 0x0601F92B RID: 129323 RVA: 0x008BC4FD File Offset: 0x008BA6FD
		[NullableContext(2)]
		public ResultYuanwu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F92C RID: 129324 RVA: 0x008BC507 File Offset: 0x008BA707
		public ResultYuanwu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F92D RID: 129325 RVA: 0x008BC512 File Offset: 0x008BA712
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F92E RID: 129326 RVA: 0x008BC544 File Offset: 0x008BA744
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultYuanwu.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultYuanwu.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultYuanwu.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultYuanwu.OnScriptCallback));
				}
				ResultYuanwu.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultYuanwu.RegisterId);
		}

		// Token: 0x0601F92F RID: 129327 RVA: 0x008BC57E File Offset: 0x008BA77E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F930 RID: 129328 RVA: 0x008BC587 File Offset: 0x008BA787
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F931 RID: 129329 RVA: 0x008BC594 File Offset: 0x008BA794
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

		// Token: 0x0400F2E2 RID: 62178
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYuanwu__DelegateSignature";

		// Token: 0x0400F2E3 RID: 62179
		private static int RegisterId;

		// Token: 0x02009B0D RID: 39693
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310E0 RID: 200928
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
