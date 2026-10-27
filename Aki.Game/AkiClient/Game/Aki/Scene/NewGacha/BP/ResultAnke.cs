using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A4C RID: 14924
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultAnke : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F838 RID: 129080 RVA: 0x008BAB0F File Offset: 0x008B8D0F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultAnke.StaticFunctionPtr();
		}

		// Token: 0x0601F839 RID: 129081 RVA: 0x008BAB1B File Offset: 0x008B8D1B
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultAnke__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultAnke__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultAnke__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultAnke__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F83A RID: 129082 RVA: 0x008BAB3E File Offset: 0x008B8D3E
		public ResultAnke()
		{
		}

		// Token: 0x0601F83B RID: 129083 RVA: 0x008BAB46 File Offset: 0x008B8D46
		[NullableContext(2)]
		public ResultAnke(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F83C RID: 129084 RVA: 0x008BAB50 File Offset: 0x008B8D50
		public ResultAnke(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F83D RID: 129085 RVA: 0x008BAB5B File Offset: 0x008B8D5B
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F83E RID: 129086 RVA: 0x008BAB8D File Offset: 0x008B8D8D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultAnke.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultAnke.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultAnke.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultAnke.OnScriptCallback));
				}
				ResultAnke.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultAnke.RegisterId);
		}

		// Token: 0x0601F83F RID: 129087 RVA: 0x008BABC7 File Offset: 0x008B8DC7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F840 RID: 129088 RVA: 0x008BABD0 File Offset: 0x008B8DD0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F841 RID: 129089 RVA: 0x008BABDC File Offset: 0x008B8DDC
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

		// Token: 0x0400F2B2 RID: 62130
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultAnke__DelegateSignature";

		// Token: 0x0400F2B3 RID: 62131
		private static int RegisterId;

		// Token: 0x02009AF4 RID: 39668
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310C7 RID: 200903
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
