using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200308E RID: 12430
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultChangli : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB56 RID: 121686 RVA: 0x008FFB42 File Offset: 0x008FDD42
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultChangli.StaticFunctionPtr();
		}

		// Token: 0x0601DB57 RID: 121687 RVA: 0x008FFB4E File Offset: 0x008FDD4E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultChangli__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultChangli__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultChangli__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultChangli__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB58 RID: 121688 RVA: 0x008FFB71 File Offset: 0x008FDD71
		public ResultChangli()
		{
		}

		// Token: 0x0601DB59 RID: 121689 RVA: 0x008FFB79 File Offset: 0x008FDD79
		[NullableContext(2)]
		public ResultChangli(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB5A RID: 121690 RVA: 0x008FFB83 File Offset: 0x008FDD83
		public ResultChangli(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB5B RID: 121691 RVA: 0x008FFB8E File Offset: 0x008FDD8E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB5C RID: 121692 RVA: 0x008FFBC0 File Offset: 0x008FDDC0
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultChangli.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultChangli.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultChangli.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultChangli.OnScriptCallback));
				}
				ResultChangli.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultChangli.RegisterId);
		}

		// Token: 0x0601DB5D RID: 121693 RVA: 0x008FFBFA File Offset: 0x008FDDFA
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB5E RID: 121694 RVA: 0x008FFC03 File Offset: 0x008FDE03
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB5F RID: 121695 RVA: 0x008FFC10 File Offset: 0x008FDE10
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

		// Token: 0x0400FAEF RID: 64239
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultChangli__DelegateSignature";

		// Token: 0x0400FAF0 RID: 64240
		private static int RegisterId;

		// Token: 0x02008D87 RID: 36231
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C93E RID: 182590
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
