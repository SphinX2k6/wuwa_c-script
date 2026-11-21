using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x020030A2 RID: 12450
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultYuanwu : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC1E RID: 121886 RVA: 0x009010BA File Offset: 0x008FF2BA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultYuanwu.StaticFunctionPtr();
		}

		// Token: 0x0601DC1F RID: 121887 RVA: 0x009010C6 File Offset: 0x008FF2C6
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultYuanwu__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultYuanwu__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYuanwu__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultYuanwu__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DC20 RID: 121888 RVA: 0x009010E9 File Offset: 0x008FF2E9
		public ResultYuanwu()
		{
		}

		// Token: 0x0601DC21 RID: 121889 RVA: 0x009010F1 File Offset: 0x008FF2F1
		[NullableContext(2)]
		public ResultYuanwu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC22 RID: 121890 RVA: 0x009010FB File Offset: 0x008FF2FB
		public ResultYuanwu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC23 RID: 121891 RVA: 0x00901106 File Offset: 0x008FF306
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC24 RID: 121892 RVA: 0x00901138 File Offset: 0x008FF338
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultYuanwu.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultYuanwu.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultYuanwu.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultYuanwu.OnScriptCallback));
				}
				ResultYuanwu.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultYuanwu.RegisterId);
		}

		// Token: 0x0601DC25 RID: 121893 RVA: 0x00901172 File Offset: 0x008FF372
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DC26 RID: 121894 RVA: 0x0090117B File Offset: 0x008FF37B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DC27 RID: 121895 RVA: 0x00901188 File Offset: 0x008FF388
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

		// Token: 0x0400FB17 RID: 64279
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultYuanwu__DelegateSignature";

		// Token: 0x0400FB18 RID: 64280
		private static int RegisterId;

		// Token: 0x02008D9C RID: 36252
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C953 RID: 182611
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
