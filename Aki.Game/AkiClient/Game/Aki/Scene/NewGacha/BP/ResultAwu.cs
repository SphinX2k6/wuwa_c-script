using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A4D RID: 14925
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultAwu : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F842 RID: 129090 RVA: 0x008BAC1E File Offset: 0x008B8E1E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultAwu.StaticFunctionPtr();
		}

		// Token: 0x0601F843 RID: 129091 RVA: 0x008BAC2A File Offset: 0x008B8E2A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultAwu__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultAwu__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultAwu__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultAwu__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F844 RID: 129092 RVA: 0x008BAC4D File Offset: 0x008B8E4D
		public ResultAwu()
		{
		}

		// Token: 0x0601F845 RID: 129093 RVA: 0x008BAC55 File Offset: 0x008B8E55
		[NullableContext(2)]
		public ResultAwu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F846 RID: 129094 RVA: 0x008BAC5F File Offset: 0x008B8E5F
		public ResultAwu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F847 RID: 129095 RVA: 0x008BAC6A File Offset: 0x008B8E6A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F848 RID: 129096 RVA: 0x008BAC9C File Offset: 0x008B8E9C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F849 RID: 129097 RVA: 0x008BACD6 File Offset: 0x008B8ED6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F84A RID: 129098 RVA: 0x008BACDF File Offset: 0x008B8EDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F84B RID: 129099 RVA: 0x008BACEC File Offset: 0x008B8EEC
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

		// Token: 0x0400F2B4 RID: 62132
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultAwu__DelegateSignature";

		// Token: 0x0400F2B5 RID: 62133
		private static int RegisterId;

		// Token: 0x02009AF5 RID: 39669
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310C8 RID: 200904
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
