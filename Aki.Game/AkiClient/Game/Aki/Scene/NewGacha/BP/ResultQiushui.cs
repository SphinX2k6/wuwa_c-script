using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200309A RID: 12442
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultQiushui : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBCE RID: 121806 RVA: 0x0090083A File Offset: 0x008FEA3A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultQiushui.StaticFunctionPtr();
		}

		// Token: 0x0601DBCF RID: 121807 RVA: 0x00900846 File Offset: 0x008FEA46
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultQiushui__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultQiushui__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultQiushui__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultQiushui__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DBD0 RID: 121808 RVA: 0x00900869 File Offset: 0x008FEA69
		public ResultQiushui()
		{
		}

		// Token: 0x0601DBD1 RID: 121809 RVA: 0x00900871 File Offset: 0x008FEA71
		[NullableContext(2)]
		public ResultQiushui(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBD2 RID: 121810 RVA: 0x0090087B File Offset: 0x008FEA7B
		public ResultQiushui(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBD3 RID: 121811 RVA: 0x00900886 File Offset: 0x008FEA86
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBD4 RID: 121812 RVA: 0x009008B8 File Offset: 0x008FEAB8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultQiushui.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultQiushui.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultQiushui.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultQiushui.OnScriptCallback));
				}
				ResultQiushui.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultQiushui.RegisterId);
		}

		// Token: 0x0601DBD5 RID: 121813 RVA: 0x009008F2 File Offset: 0x008FEAF2
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBD6 RID: 121814 RVA: 0x009008FB File Offset: 0x008FEAFB
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DBD7 RID: 121815 RVA: 0x00900908 File Offset: 0x008FEB08
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

		// Token: 0x0400FB07 RID: 64263
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultQiushui__DelegateSignature";

		// Token: 0x0400FB08 RID: 64264
		private static int RegisterId;

		// Token: 0x02008D94 RID: 36244
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C94B RID: 182603
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
