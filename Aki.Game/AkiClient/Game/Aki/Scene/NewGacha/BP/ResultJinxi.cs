using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A55 RID: 14933
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultJinxi : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F892 RID: 129170 RVA: 0x008BB49E File Offset: 0x008B969E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultJinxi.StaticFunctionPtr();
		}

		// Token: 0x0601F893 RID: 129171 RVA: 0x008BB4AA File Offset: 0x008B96AA
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultJinxi__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultJinxi__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJinxi__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultJinxi__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F894 RID: 129172 RVA: 0x008BB4CD File Offset: 0x008B96CD
		public ResultJinxi()
		{
		}

		// Token: 0x0601F895 RID: 129173 RVA: 0x008BB4D5 File Offset: 0x008B96D5
		[NullableContext(2)]
		public ResultJinxi(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F896 RID: 129174 RVA: 0x008BB4DF File Offset: 0x008B96DF
		public ResultJinxi(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F897 RID: 129175 RVA: 0x008BB4EA File Offset: 0x008B96EA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F898 RID: 129176 RVA: 0x008BB51C File Offset: 0x008B971C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultJinxi.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultJinxi.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultJinxi.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultJinxi.OnScriptCallback));
				}
				ResultJinxi.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultJinxi.RegisterId);
		}

		// Token: 0x0601F899 RID: 129177 RVA: 0x008BB556 File Offset: 0x008B9756
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F89A RID: 129178 RVA: 0x008BB55F File Offset: 0x008B975F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F89B RID: 129179 RVA: 0x008BB56C File Offset: 0x008B976C
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

		// Token: 0x0400F2C4 RID: 62148
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultJinxi__DelegateSignature";

		// Token: 0x0400F2C5 RID: 62149
		private static int RegisterId;

		// Token: 0x02009AFD RID: 39677
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310D0 RID: 200912
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
