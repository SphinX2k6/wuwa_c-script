using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003095 RID: 12437
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultJueyuan : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB9C RID: 121756 RVA: 0x009002B2 File Offset: 0x008FE4B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultJueyuan.StaticFunctionPtr();
		}

		// Token: 0x0601DB9D RID: 121757 RVA: 0x009002BE File Offset: 0x008FE4BE
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultJueyuan__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultJueyuan__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJueyuan__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultJueyuan__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB9E RID: 121758 RVA: 0x009002E1 File Offset: 0x008FE4E1
		public ResultJueyuan()
		{
		}

		// Token: 0x0601DB9F RID: 121759 RVA: 0x009002E9 File Offset: 0x008FE4E9
		[NullableContext(2)]
		public ResultJueyuan(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBA0 RID: 121760 RVA: 0x009002F3 File Offset: 0x008FE4F3
		public ResultJueyuan(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBA1 RID: 121761 RVA: 0x009002FE File Offset: 0x008FE4FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBA2 RID: 121762 RVA: 0x00900330 File Offset: 0x008FE530
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultJueyuan.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultJueyuan.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultJueyuan.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultJueyuan.OnScriptCallback));
				}
				ResultJueyuan.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultJueyuan.RegisterId);
		}

		// Token: 0x0601DBA3 RID: 121763 RVA: 0x0090036A File Offset: 0x008FE56A
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBA4 RID: 121764 RVA: 0x00900373 File Offset: 0x008FE573
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DBA5 RID: 121765 RVA: 0x00900380 File Offset: 0x008FE580
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

		// Token: 0x0400FAFD RID: 64253
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJueyuan__DelegateSignature";

		// Token: 0x0400FAFE RID: 64254
		private static int RegisterId;

		// Token: 0x02008D8E RID: 36238
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C945 RID: 182597
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
