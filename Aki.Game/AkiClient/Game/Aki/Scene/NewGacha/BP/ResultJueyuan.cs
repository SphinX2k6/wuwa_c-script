using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A57 RID: 14935
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultJueyuan : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F8A6 RID: 129190 RVA: 0x008BB6BE File Offset: 0x008B98BE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultJueyuan.StaticFunctionPtr();
		}

		// Token: 0x0601F8A7 RID: 129191 RVA: 0x008BB6CA File Offset: 0x008B98CA
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultJueyuan__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultJueyuan__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJueyuan__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultJueyuan__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F8A8 RID: 129192 RVA: 0x008BB6ED File Offset: 0x008B98ED
		public ResultJueyuan()
		{
		}

		// Token: 0x0601F8A9 RID: 129193 RVA: 0x008BB6F5 File Offset: 0x008B98F5
		[NullableContext(2)]
		public ResultJueyuan(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8AA RID: 129194 RVA: 0x008BB6FF File Offset: 0x008B98FF
		public ResultJueyuan(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8AB RID: 129195 RVA: 0x008BB70A File Offset: 0x008B990A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8AC RID: 129196 RVA: 0x008BB73C File Offset: 0x008B993C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F8AD RID: 129197 RVA: 0x008BB776 File Offset: 0x008B9976
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8AE RID: 129198 RVA: 0x008BB77F File Offset: 0x008B997F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F8AF RID: 129199 RVA: 0x008BB78C File Offset: 0x008B998C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400F2C8 RID: 62152
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJueyuan__DelegateSignature";

		// Token: 0x0400F2C9 RID: 62153
		private static int RegisterId;

		// Token: 0x02009AFF RID: 39679
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310D2 RID: 200914
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
