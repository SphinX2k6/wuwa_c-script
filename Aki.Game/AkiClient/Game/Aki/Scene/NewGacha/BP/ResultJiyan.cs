using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003094 RID: 12436
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultJiyan : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB92 RID: 121746 RVA: 0x009001A2 File Offset: 0x008FE3A2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultJiyan.StaticFunctionPtr();
		}

		// Token: 0x0601DB93 RID: 121747 RVA: 0x009001AE File Offset: 0x008FE3AE
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultJiyan__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultJiyan__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJiyan__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultJiyan__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB94 RID: 121748 RVA: 0x009001D1 File Offset: 0x008FE3D1
		public ResultJiyan()
		{
		}

		// Token: 0x0601DB95 RID: 121749 RVA: 0x009001D9 File Offset: 0x008FE3D9
		[NullableContext(2)]
		public ResultJiyan(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB96 RID: 121750 RVA: 0x009001E3 File Offset: 0x008FE3E3
		public ResultJiyan(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB97 RID: 121751 RVA: 0x009001EE File Offset: 0x008FE3EE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB98 RID: 121752 RVA: 0x00900220 File Offset: 0x008FE420
		[NullableContext(1)]
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

		// Token: 0x0601DB99 RID: 121753 RVA: 0x0090025A File Offset: 0x008FE45A
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB9A RID: 121754 RVA: 0x00900263 File Offset: 0x008FE463
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB9B RID: 121755 RVA: 0x00900270 File Offset: 0x008FE470
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

		// Token: 0x0400FAFB RID: 64251
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJiyan__DelegateSignature";

		// Token: 0x0400FAFC RID: 64252
		private static int RegisterId;

		// Token: 0x02008D8D RID: 36237
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C944 RID: 182596
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
