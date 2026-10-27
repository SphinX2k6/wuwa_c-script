using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A58 RID: 14936
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultKakaluo : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F8B0 RID: 129200 RVA: 0x008BB7CE File Offset: 0x008B99CE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultKakaluo.StaticFunctionPtr();
		}

		// Token: 0x0601F8B1 RID: 129201 RVA: 0x008BB7DA File Offset: 0x008B99DA
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultKakaluo__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultKakaluo__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultKakaluo__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultKakaluo__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F8B2 RID: 129202 RVA: 0x008BB7FD File Offset: 0x008B99FD
		public ResultKakaluo()
		{
		}

		// Token: 0x0601F8B3 RID: 129203 RVA: 0x008BB805 File Offset: 0x008B9A05
		[NullableContext(2)]
		public ResultKakaluo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8B4 RID: 129204 RVA: 0x008BB80F File Offset: 0x008B9A0F
		public ResultKakaluo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8B5 RID: 129205 RVA: 0x008BB81A File Offset: 0x008B9A1A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8B6 RID: 129206 RVA: 0x008BB84C File Offset: 0x008B9A4C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultKakaluo.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultKakaluo.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultKakaluo.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultKakaluo.OnScriptCallback));
				}
				ResultKakaluo.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultKakaluo.RegisterId);
		}

		// Token: 0x0601F8B7 RID: 129207 RVA: 0x008BB886 File Offset: 0x008B9A86
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8B8 RID: 129208 RVA: 0x008BB88F File Offset: 0x008B9A8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F8B9 RID: 129209 RVA: 0x008BB89C File Offset: 0x008B9A9C
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

		// Token: 0x0400F2CA RID: 62154
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultKakaluo__DelegateSignature";

		// Token: 0x0400F2CB RID: 62155
		private static int RegisterId;

		// Token: 0x02009B00 RID: 39680
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310D3 RID: 200915
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
