using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003090 RID: 12432
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultCharacterPurple : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB6A RID: 121706 RVA: 0x008FFD62 File Offset: 0x008FDF62
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultCharacterPurple.StaticFunctionPtr();
		}

		// Token: 0x0601DB6B RID: 121707 RVA: 0x008FFD6E File Offset: 0x008FDF6E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultCharacterPurple__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultCharacterPurple__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultCharacterPurple__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultCharacterPurple__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB6C RID: 121708 RVA: 0x008FFD91 File Offset: 0x008FDF91
		public ResultCharacterPurple()
		{
		}

		// Token: 0x0601DB6D RID: 121709 RVA: 0x008FFD99 File Offset: 0x008FDF99
		[NullableContext(2)]
		public ResultCharacterPurple(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB6E RID: 121710 RVA: 0x008FFDA3 File Offset: 0x008FDFA3
		public ResultCharacterPurple(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB6F RID: 121711 RVA: 0x008FFDAE File Offset: 0x008FDFAE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB70 RID: 121712 RVA: 0x008FFDE0 File Offset: 0x008FDFE0
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultCharacterPurple.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultCharacterPurple.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultCharacterPurple.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultCharacterPurple.OnScriptCallback));
				}
				ResultCharacterPurple.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultCharacterPurple.RegisterId);
		}

		// Token: 0x0601DB71 RID: 121713 RVA: 0x008FFE1A File Offset: 0x008FE01A
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB72 RID: 121714 RVA: 0x008FFE23 File Offset: 0x008FE023
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB73 RID: 121715 RVA: 0x008FFE30 File Offset: 0x008FE030
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x0400FAF3 RID: 64243
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultCharacterPurple__DelegateSignature";

		// Token: 0x0400FAF4 RID: 64244
		private static int RegisterId;

		// Token: 0x02008D89 RID: 36233
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C940 RID: 182592
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
