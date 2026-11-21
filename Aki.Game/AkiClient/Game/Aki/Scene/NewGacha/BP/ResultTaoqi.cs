using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200309C RID: 12444
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultTaoqi : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBE2 RID: 121826 RVA: 0x00900A5A File Offset: 0x008FEC5A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultTaoqi.StaticFunctionPtr();
		}

		// Token: 0x0601DBE3 RID: 121827 RVA: 0x00900A66 File Offset: 0x008FEC66
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultTaoqi__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultTaoqi__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultTaoqi__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultTaoqi__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DBE4 RID: 121828 RVA: 0x00900A89 File Offset: 0x008FEC89
		public ResultTaoqi()
		{
		}

		// Token: 0x0601DBE5 RID: 121829 RVA: 0x00900A91 File Offset: 0x008FEC91
		[NullableContext(2)]
		public ResultTaoqi(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBE6 RID: 121830 RVA: 0x00900A9B File Offset: 0x008FEC9B
		public ResultTaoqi(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBE7 RID: 121831 RVA: 0x00900AA6 File Offset: 0x008FECA6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBE8 RID: 121832 RVA: 0x00900AD8 File Offset: 0x008FECD8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultTaoqi.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultTaoqi.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultTaoqi.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultTaoqi.OnScriptCallback));
				}
				ResultTaoqi.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultTaoqi.RegisterId);
		}

		// Token: 0x0601DBE9 RID: 121833 RVA: 0x00900B12 File Offset: 0x008FED12
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBEA RID: 121834 RVA: 0x00900B1B File Offset: 0x008FED1B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DBEB RID: 121835 RVA: 0x00900B28 File Offset: 0x008FED28
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

		// Token: 0x0400FB0B RID: 64267
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultTaoqi__DelegateSignature";

		// Token: 0x0400FB0C RID: 64268
		private static int RegisterId;

		// Token: 0x02008D96 RID: 36246
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C94D RID: 182605
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
