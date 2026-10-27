using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A5E RID: 14942
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultTaoqi : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F8EC RID: 129260 RVA: 0x008BBE66 File Offset: 0x008BA066
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultTaoqi.StaticFunctionPtr();
		}

		// Token: 0x0601F8ED RID: 129261 RVA: 0x008BBE72 File Offset: 0x008BA072
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultTaoqi__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultTaoqi__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultTaoqi__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultTaoqi__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F8EE RID: 129262 RVA: 0x008BBE95 File Offset: 0x008BA095
		public ResultTaoqi()
		{
		}

		// Token: 0x0601F8EF RID: 129263 RVA: 0x008BBE9D File Offset: 0x008BA09D
		[NullableContext(2)]
		public ResultTaoqi(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8F0 RID: 129264 RVA: 0x008BBEA7 File Offset: 0x008BA0A7
		public ResultTaoqi(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8F1 RID: 129265 RVA: 0x008BBEB2 File Offset: 0x008BA0B2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8F2 RID: 129266 RVA: 0x008BBEE4 File Offset: 0x008BA0E4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultTaoqi.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultTaoqi.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultTaoqi.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultTaoqi.OnScriptCallback));
				}
				ResultTaoqi.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultTaoqi.RegisterId);
		}

		// Token: 0x0601F8F3 RID: 129267 RVA: 0x008BBF1E File Offset: 0x008BA11E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8F4 RID: 129268 RVA: 0x008BBF27 File Offset: 0x008BA127
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F8F5 RID: 129269 RVA: 0x008BBF34 File Offset: 0x008BA134
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

		// Token: 0x0400F2D6 RID: 62166
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultTaoqi__DelegateSignature";

		// Token: 0x0400F2D7 RID: 62167
		private static int RegisterId;

		// Token: 0x02009B07 RID: 39687
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310DA RID: 200922
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
