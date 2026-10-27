using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A63 RID: 14947
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultYinlin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F91E RID: 129310 RVA: 0x008BC3B6 File Offset: 0x008BA5B6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultYinlin.StaticFunctionPtr();
		}

		// Token: 0x0601F91F RID: 129311 RVA: 0x008BC3C2 File Offset: 0x008BA5C2
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultYinlin__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultYinlin__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYinlin__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultYinlin__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F920 RID: 129312 RVA: 0x008BC3E5 File Offset: 0x008BA5E5
		public ResultYinlin()
		{
		}

		// Token: 0x0601F921 RID: 129313 RVA: 0x008BC3ED File Offset: 0x008BA5ED
		[NullableContext(2)]
		public ResultYinlin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F922 RID: 129314 RVA: 0x008BC3F7 File Offset: 0x008BA5F7
		public ResultYinlin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F923 RID: 129315 RVA: 0x008BC402 File Offset: 0x008BA602
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F924 RID: 129316 RVA: 0x008BC434 File Offset: 0x008BA634
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultYinlin.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultYinlin.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultYinlin.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultYinlin.OnScriptCallback));
				}
				ResultYinlin.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultYinlin.RegisterId);
		}

		// Token: 0x0601F925 RID: 129317 RVA: 0x008BC46E File Offset: 0x008BA66E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F926 RID: 129318 RVA: 0x008BC477 File Offset: 0x008BA677
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F927 RID: 129319 RVA: 0x008BC484 File Offset: 0x008BA684
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

		// Token: 0x0400F2E0 RID: 62176
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYinlin__DelegateSignature";

		// Token: 0x0400F2E1 RID: 62177
		private static int RegisterId;

		// Token: 0x02009B0C RID: 39692
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310DF RID: 200927
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
