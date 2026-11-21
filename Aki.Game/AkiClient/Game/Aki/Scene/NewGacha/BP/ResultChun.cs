using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003091 RID: 12433
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultChun : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB74 RID: 121716 RVA: 0x008FFE72 File Offset: 0x008FE072
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultChun.StaticFunctionPtr();
		}

		// Token: 0x0601DB75 RID: 121717 RVA: 0x008FFE7E File Offset: 0x008FE07E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultChun__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultChun__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultChun__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultChun__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB76 RID: 121718 RVA: 0x008FFEA1 File Offset: 0x008FE0A1
		public ResultChun()
		{
		}

		// Token: 0x0601DB77 RID: 121719 RVA: 0x008FFEA9 File Offset: 0x008FE0A9
		[NullableContext(2)]
		public ResultChun(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB78 RID: 121720 RVA: 0x008FFEB3 File Offset: 0x008FE0B3
		public ResultChun(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB79 RID: 121721 RVA: 0x008FFEBE File Offset: 0x008FE0BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB7A RID: 121722 RVA: 0x008FFEF0 File Offset: 0x008FE0F0
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultChun.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultChun.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultChun.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultChun.OnScriptCallback));
				}
				ResultChun.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultChun.RegisterId);
		}

		// Token: 0x0601DB7B RID: 121723 RVA: 0x008FFF2A File Offset: 0x008FE12A
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB7C RID: 121724 RVA: 0x008FFF33 File Offset: 0x008FE133
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB7D RID: 121725 RVA: 0x008FFF40 File Offset: 0x008FE140
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

		// Token: 0x0400FAF5 RID: 64245
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultChun__DelegateSignature";

		// Token: 0x0400FAF6 RID: 64246
		private static int RegisterId;

		// Token: 0x02008D8A RID: 36234
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C941 RID: 182593
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
