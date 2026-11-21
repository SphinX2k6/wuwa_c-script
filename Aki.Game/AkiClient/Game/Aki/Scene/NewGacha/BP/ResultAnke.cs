using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200308A RID: 12426
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultAnke : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB2E RID: 121646 RVA: 0x008FF703 File Offset: 0x008FD903
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultAnke.StaticFunctionPtr();
		}

		// Token: 0x0601DB2F RID: 121647 RVA: 0x008FF70F File Offset: 0x008FD90F
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultAnke__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultAnke__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultAnke__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultAnke__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB30 RID: 121648 RVA: 0x008FF732 File Offset: 0x008FD932
		public ResultAnke()
		{
		}

		// Token: 0x0601DB31 RID: 121649 RVA: 0x008FF73A File Offset: 0x008FD93A
		[NullableContext(2)]
		public ResultAnke(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB32 RID: 121650 RVA: 0x008FF744 File Offset: 0x008FD944
		public ResultAnke(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB33 RID: 121651 RVA: 0x008FF74F File Offset: 0x008FD94F
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB34 RID: 121652 RVA: 0x008FF781 File Offset: 0x008FD981
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultAnke.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultAnke.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultAnke.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultAnke.OnScriptCallback));
				}
				ResultAnke.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultAnke.RegisterId);
		}

		// Token: 0x0601DB35 RID: 121653 RVA: 0x008FF7BB File Offset: 0x008FD9BB
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB36 RID: 121654 RVA: 0x008FF7C4 File Offset: 0x008FD9C4
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB37 RID: 121655 RVA: 0x008FF7D0 File Offset: 0x008FD9D0
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

		// Token: 0x0400FAE7 RID: 64231
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultAnke__DelegateSignature";

		// Token: 0x0400FAE8 RID: 64232
		private static int RegisterId;

		// Token: 0x02008D83 RID: 36227
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C93A RID: 182586
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
