using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200308D RID: 12429
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultBailian : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB4C RID: 121676 RVA: 0x008FFA32 File Offset: 0x008FDC32
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultBailian.StaticFunctionPtr();
		}

		// Token: 0x0601DB4D RID: 121677 RVA: 0x008FFA3E File Offset: 0x008FDC3E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultBailian__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultBailian__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultBailian__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultBailian__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB4E RID: 121678 RVA: 0x008FFA61 File Offset: 0x008FDC61
		public ResultBailian()
		{
		}

		// Token: 0x0601DB4F RID: 121679 RVA: 0x008FFA69 File Offset: 0x008FDC69
		[NullableContext(2)]
		public ResultBailian(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB50 RID: 121680 RVA: 0x008FFA73 File Offset: 0x008FDC73
		public ResultBailian(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB51 RID: 121681 RVA: 0x008FFA7E File Offset: 0x008FDC7E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB52 RID: 121682 RVA: 0x008FFAB0 File Offset: 0x008FDCB0
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultBailian.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultBailian.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultBailian.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultBailian.OnScriptCallback));
				}
				ResultBailian.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultBailian.RegisterId);
		}

		// Token: 0x0601DB53 RID: 121683 RVA: 0x008FFAEA File Offset: 0x008FDCEA
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB54 RID: 121684 RVA: 0x008FFAF3 File Offset: 0x008FDCF3
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB55 RID: 121685 RVA: 0x008FFB00 File Offset: 0x008FDD00
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

		// Token: 0x0400FAED RID: 64237
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultBailian__DelegateSignature";

		// Token: 0x0400FAEE RID: 64238
		private static int RegisterId;

		// Token: 0x02008D86 RID: 36230
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C93D RID: 182589
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
