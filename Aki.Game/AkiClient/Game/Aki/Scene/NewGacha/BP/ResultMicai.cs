using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A5B RID: 14939
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultMicai : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F8CE RID: 129230 RVA: 0x008BBB36 File Offset: 0x008B9D36
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultMicai.StaticFunctionPtr();
		}

		// Token: 0x0601F8CF RID: 129231 RVA: 0x008BBB42 File Offset: 0x008B9D42
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultMicai__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultMicai__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMicai__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultMicai__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F8D0 RID: 129232 RVA: 0x008BBB65 File Offset: 0x008B9D65
		public ResultMicai()
		{
		}

		// Token: 0x0601F8D1 RID: 129233 RVA: 0x008BBB6D File Offset: 0x008B9D6D
		[NullableContext(2)]
		public ResultMicai(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8D2 RID: 129234 RVA: 0x008BBB77 File Offset: 0x008B9D77
		public ResultMicai(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8D3 RID: 129235 RVA: 0x008BBB82 File Offset: 0x008B9D82
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8D4 RID: 129236 RVA: 0x008BBBB4 File Offset: 0x008B9DB4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F8D5 RID: 129237 RVA: 0x008BBBEE File Offset: 0x008B9DEE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8D6 RID: 129238 RVA: 0x008BBBF7 File Offset: 0x008B9DF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F8D7 RID: 129239 RVA: 0x008BBC04 File Offset: 0x008B9E04
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

		// Token: 0x0400F2D0 RID: 62160
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMicai__DelegateSignature";

		// Token: 0x0400F2D1 RID: 62161
		private static int RegisterId;

		// Token: 0x02009B04 RID: 39684
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310D7 RID: 200919
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
