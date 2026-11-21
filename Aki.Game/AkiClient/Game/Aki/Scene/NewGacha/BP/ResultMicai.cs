using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003099 RID: 12441
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultMicai : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBC4 RID: 121796 RVA: 0x0090072A File Offset: 0x008FE92A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultMicai.StaticFunctionPtr();
		}

		// Token: 0x0601DBC5 RID: 121797 RVA: 0x00900736 File Offset: 0x008FE936
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultMicai__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultMicai__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMicai__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultMicai__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DBC6 RID: 121798 RVA: 0x00900759 File Offset: 0x008FE959
		public ResultMicai()
		{
		}

		// Token: 0x0601DBC7 RID: 121799 RVA: 0x00900761 File Offset: 0x008FE961
		[NullableContext(2)]
		public ResultMicai(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBC8 RID: 121800 RVA: 0x0090076B File Offset: 0x008FE96B
		public ResultMicai(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBC9 RID: 121801 RVA: 0x00900776 File Offset: 0x008FE976
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBCA RID: 121802 RVA: 0x009007A8 File Offset: 0x008FE9A8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultMicai.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultMicai.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultMicai.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultMicai.OnScriptCallback));
				}
				ResultMicai.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultMicai.RegisterId);
		}

		// Token: 0x0601DBCB RID: 121803 RVA: 0x009007E2 File Offset: 0x008FE9E2
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBCC RID: 121804 RVA: 0x009007EB File Offset: 0x008FE9EB
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DBCD RID: 121805 RVA: 0x009007F8 File Offset: 0x008FE9F8
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

		// Token: 0x0400FB05 RID: 64261
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMicai__DelegateSignature";

		// Token: 0x0400FB06 RID: 64262
		private static int RegisterId;

		// Token: 0x02008D93 RID: 36243
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C94A RID: 182602
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
