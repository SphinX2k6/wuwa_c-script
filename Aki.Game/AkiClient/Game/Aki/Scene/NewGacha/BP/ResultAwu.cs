using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200308B RID: 12427
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultAwu : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB38 RID: 121656 RVA: 0x008FF812 File Offset: 0x008FDA12
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultAwu.StaticFunctionPtr();
		}

		// Token: 0x0601DB39 RID: 121657 RVA: 0x008FF81E File Offset: 0x008FDA1E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultAwu__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultAwu__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultAwu__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultAwu__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB3A RID: 121658 RVA: 0x008FF841 File Offset: 0x008FDA41
		public ResultAwu()
		{
		}

		// Token: 0x0601DB3B RID: 121659 RVA: 0x008FF849 File Offset: 0x008FDA49
		[NullableContext(2)]
		public ResultAwu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB3C RID: 121660 RVA: 0x008FF853 File Offset: 0x008FDA53
		public ResultAwu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB3D RID: 121661 RVA: 0x008FF85E File Offset: 0x008FDA5E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB3E RID: 121662 RVA: 0x008FF890 File Offset: 0x008FDA90
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultAwu.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultAwu.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultAwu.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultAwu.OnScriptCallback));
				}
				ResultAwu.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultAwu.RegisterId);
		}

		// Token: 0x0601DB3F RID: 121663 RVA: 0x008FF8CA File Offset: 0x008FDACA
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB40 RID: 121664 RVA: 0x008FF8D3 File Offset: 0x008FDAD3
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB41 RID: 121665 RVA: 0x008FF8E0 File Offset: 0x008FDAE0
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

		// Token: 0x0400FAE9 RID: 64233
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultAwu__DelegateSignature";

		// Token: 0x0400FAEA RID: 64234
		private static int RegisterId;

		// Token: 0x02008D84 RID: 36228
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C93B RID: 182587
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
