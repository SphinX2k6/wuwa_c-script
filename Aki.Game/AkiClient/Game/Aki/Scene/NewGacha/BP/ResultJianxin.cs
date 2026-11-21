using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003092 RID: 12434
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultJianxin : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB7E RID: 121726 RVA: 0x008FFF82 File Offset: 0x008FE182
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultJianxin.StaticFunctionPtr();
		}

		// Token: 0x0601DB7F RID: 121727 RVA: 0x008FFF8E File Offset: 0x008FE18E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultJianxin__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultJianxin__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJianxin__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultJianxin__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB80 RID: 121728 RVA: 0x008FFFB1 File Offset: 0x008FE1B1
		public ResultJianxin()
		{
		}

		// Token: 0x0601DB81 RID: 121729 RVA: 0x008FFFB9 File Offset: 0x008FE1B9
		[NullableContext(2)]
		public ResultJianxin(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB82 RID: 121730 RVA: 0x008FFFC3 File Offset: 0x008FE1C3
		public ResultJianxin(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB83 RID: 121731 RVA: 0x008FFFCE File Offset: 0x008FE1CE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB84 RID: 121732 RVA: 0x00900000 File Offset: 0x008FE200
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultJianxin.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultJianxin.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultJianxin.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultJianxin.OnScriptCallback));
				}
				ResultJianxin.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultJianxin.RegisterId);
		}

		// Token: 0x0601DB85 RID: 121733 RVA: 0x0090003A File Offset: 0x008FE23A
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB86 RID: 121734 RVA: 0x00900043 File Offset: 0x008FE243
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB87 RID: 121735 RVA: 0x00900050 File Offset: 0x008FE250
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

		// Token: 0x0400FAF7 RID: 64247
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJianxin__DelegateSignature";

		// Token: 0x0400FAF8 RID: 64248
		private static int RegisterId;

		// Token: 0x02008D8B RID: 36235
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C942 RID: 182594
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
