using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x020030A1 RID: 12449
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultYinlin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC14 RID: 121876 RVA: 0x00900FAA File Offset: 0x008FF1AA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultYinlin.StaticFunctionPtr();
		}

		// Token: 0x0601DC15 RID: 121877 RVA: 0x00900FB6 File Offset: 0x008FF1B6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultYinlin__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultYinlin__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYinlin__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultYinlin__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DC16 RID: 121878 RVA: 0x00900FD9 File Offset: 0x008FF1D9
		public ResultYinlin()
		{
		}

		// Token: 0x0601DC17 RID: 121879 RVA: 0x00900FE1 File Offset: 0x008FF1E1
		[NullableContext(2)]
		public ResultYinlin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC18 RID: 121880 RVA: 0x00900FEB File Offset: 0x008FF1EB
		public ResultYinlin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC19 RID: 121881 RVA: 0x00900FF6 File Offset: 0x008FF1F6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC1A RID: 121882 RVA: 0x00901028 File Offset: 0x008FF228
		[NullableContext(1)]
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

		// Token: 0x0601DC1B RID: 121883 RVA: 0x00901062 File Offset: 0x008FF262
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DC1C RID: 121884 RVA: 0x0090106B File Offset: 0x008FF26B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DC1D RID: 121885 RVA: 0x00901078 File Offset: 0x008FF278
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

		// Token: 0x0400FB15 RID: 64277
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYinlin__DelegateSignature";

		// Token: 0x0400FB16 RID: 64278
		private static int RegisterId;

		// Token: 0x02008D9B RID: 36251
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C952 RID: 182610
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
