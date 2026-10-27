using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A4F RID: 14927
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultBailian : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F856 RID: 129110 RVA: 0x008BAE3E File Offset: 0x008B903E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultBailian.StaticFunctionPtr();
		}

		// Token: 0x0601F857 RID: 129111 RVA: 0x008BAE4A File Offset: 0x008B904A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultBailian__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultBailian__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultBailian__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultBailian__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F858 RID: 129112 RVA: 0x008BAE6D File Offset: 0x008B906D
		public ResultBailian()
		{
		}

		// Token: 0x0601F859 RID: 129113 RVA: 0x008BAE75 File Offset: 0x008B9075
		[NullableContext(2)]
		public ResultBailian(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F85A RID: 129114 RVA: 0x008BAE7F File Offset: 0x008B907F
		public ResultBailian(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F85B RID: 129115 RVA: 0x008BAE8A File Offset: 0x008B908A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F85C RID: 129116 RVA: 0x008BAEBC File Offset: 0x008B90BC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultBailian.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultBailian.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultBailian.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultBailian.OnScriptCallback));
				}
				ResultBailian.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultBailian.RegisterId);
		}

		// Token: 0x0601F85D RID: 129117 RVA: 0x008BAEF6 File Offset: 0x008B90F6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F85E RID: 129118 RVA: 0x008BAEFF File Offset: 0x008B90FF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F85F RID: 129119 RVA: 0x008BAF0C File Offset: 0x008B910C
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

		// Token: 0x0400F2B8 RID: 62136
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultBailian__DelegateSignature";

		// Token: 0x0400F2B9 RID: 62137
		private static int RegisterId;

		// Token: 0x02009AF7 RID: 39671
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310CA RID: 200906
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
