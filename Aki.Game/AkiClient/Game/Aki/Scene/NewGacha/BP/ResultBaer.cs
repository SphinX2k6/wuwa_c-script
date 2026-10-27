using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A4E RID: 14926
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultBaer : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F84C RID: 129100 RVA: 0x008BAD2E File Offset: 0x008B8F2E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultBaer.StaticFunctionPtr();
		}

		// Token: 0x0601F84D RID: 129101 RVA: 0x008BAD3A File Offset: 0x008B8F3A
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultBaer__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultBaer__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultBaer__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultBaer__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F84E RID: 129102 RVA: 0x008BAD5D File Offset: 0x008B8F5D
		public ResultBaer()
		{
		}

		// Token: 0x0601F84F RID: 129103 RVA: 0x008BAD65 File Offset: 0x008B8F65
		[NullableContext(2)]
		public ResultBaer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F850 RID: 129104 RVA: 0x008BAD6F File Offset: 0x008B8F6F
		public ResultBaer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F851 RID: 129105 RVA: 0x008BAD7A File Offset: 0x008B8F7A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F852 RID: 129106 RVA: 0x008BADAC File Offset: 0x008B8FAC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ResultBaer.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultBaer.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultBaer.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultBaer.OnScriptCallback));
				}
				ResultBaer.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultBaer.RegisterId);
		}

		// Token: 0x0601F853 RID: 129107 RVA: 0x008BADE6 File Offset: 0x008B8FE6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F854 RID: 129108 RVA: 0x008BADEF File Offset: 0x008B8FEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F855 RID: 129109 RVA: 0x008BADFC File Offset: 0x008B8FFC
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

		// Token: 0x0400F2B6 RID: 62134
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultBaer__DelegateSignature";

		// Token: 0x0400F2B7 RID: 62135
		private static int RegisterId;

		// Token: 0x02009AF6 RID: 39670
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310C9 RID: 200905
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
