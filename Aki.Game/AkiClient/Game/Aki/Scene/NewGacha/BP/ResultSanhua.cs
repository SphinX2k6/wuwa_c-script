using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200309B RID: 12443
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultSanhua : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBD8 RID: 121816 RVA: 0x0090094A File Offset: 0x008FEB4A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultSanhua.StaticFunctionPtr();
		}

		// Token: 0x0601DBD9 RID: 121817 RVA: 0x00900956 File Offset: 0x008FEB56
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultSanhua__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultSanhua__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultSanhua__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultSanhua__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DBDA RID: 121818 RVA: 0x00900979 File Offset: 0x008FEB79
		public ResultSanhua()
		{
		}

		// Token: 0x0601DBDB RID: 121819 RVA: 0x00900981 File Offset: 0x008FEB81
		[NullableContext(2)]
		public ResultSanhua(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBDC RID: 121820 RVA: 0x0090098B File Offset: 0x008FEB8B
		public ResultSanhua(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBDD RID: 121821 RVA: 0x00900996 File Offset: 0x008FEB96
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBDE RID: 121822 RVA: 0x009009C8 File Offset: 0x008FEBC8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultSanhua.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultSanhua.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultSanhua.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultSanhua.OnScriptCallback));
				}
				ResultSanhua.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultSanhua.RegisterId);
		}

		// Token: 0x0601DBDF RID: 121823 RVA: 0x00900A02 File Offset: 0x008FEC02
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBE0 RID: 121824 RVA: 0x00900A0B File Offset: 0x008FEC0B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DBE1 RID: 121825 RVA: 0x00900A18 File Offset: 0x008FEC18
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

		// Token: 0x0400FB09 RID: 64265
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultSanhua__DelegateSignature";

		// Token: 0x0400FB0A RID: 64266
		private static int RegisterId;

		// Token: 0x02008D95 RID: 36245
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C94C RID: 182604
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
