using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A5D RID: 14941
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultSanhua : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F8E2 RID: 129250 RVA: 0x008BBD56 File Offset: 0x008B9F56
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultSanhua.StaticFunctionPtr();
		}

		// Token: 0x0601F8E3 RID: 129251 RVA: 0x008BBD62 File Offset: 0x008B9F62
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultSanhua__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultSanhua__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultSanhua__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultSanhua__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F8E4 RID: 129252 RVA: 0x008BBD85 File Offset: 0x008B9F85
		public ResultSanhua()
		{
		}

		// Token: 0x0601F8E5 RID: 129253 RVA: 0x008BBD8D File Offset: 0x008B9F8D
		[NullableContext(2)]
		public ResultSanhua(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8E6 RID: 129254 RVA: 0x008BBD97 File Offset: 0x008B9F97
		public ResultSanhua(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8E7 RID: 129255 RVA: 0x008BBDA2 File Offset: 0x008B9FA2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8E8 RID: 129256 RVA: 0x008BBDD4 File Offset: 0x008B9FD4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultSanhua.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultSanhua.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultSanhua.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultSanhua.OnScriptCallback));
				}
				ResultSanhua.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultSanhua.RegisterId);
		}

		// Token: 0x0601F8E9 RID: 129257 RVA: 0x008BBE0E File Offset: 0x008BA00E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8EA RID: 129258 RVA: 0x008BBE17 File Offset: 0x008BA017
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F8EB RID: 129259 RVA: 0x008BBE24 File Offset: 0x008BA024
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

		// Token: 0x0400F2D4 RID: 62164
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultSanhua__DelegateSignature";

		// Token: 0x0400F2D5 RID: 62165
		private static int RegisterId;

		// Token: 0x02009B06 RID: 39686
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310D9 RID: 200921
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
