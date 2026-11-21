using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200308F RID: 12431
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultCharacterGolden : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DB60 RID: 121696 RVA: 0x008FFC52 File Offset: 0x008FDE52
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultCharacterGolden.StaticFunctionPtr();
		}

		// Token: 0x0601DB61 RID: 121697 RVA: 0x008FFC5E File Offset: 0x008FDE5E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultCharacterGolden__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultCharacterGolden__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultCharacterGolden__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultCharacterGolden__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DB62 RID: 121698 RVA: 0x008FFC81 File Offset: 0x008FDE81
		public ResultCharacterGolden()
		{
		}

		// Token: 0x0601DB63 RID: 121699 RVA: 0x008FFC89 File Offset: 0x008FDE89
		[NullableContext(2)]
		public ResultCharacterGolden(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DB64 RID: 121700 RVA: 0x008FFC93 File Offset: 0x008FDE93
		public ResultCharacterGolden(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DB65 RID: 121701 RVA: 0x008FFC9E File Offset: 0x008FDE9E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DB66 RID: 121702 RVA: 0x008FFCD0 File Offset: 0x008FDED0
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultCharacterGolden.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultCharacterGolden.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultCharacterGolden.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultCharacterGolden.OnScriptCallback));
				}
				ResultCharacterGolden.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultCharacterGolden.RegisterId);
		}

		// Token: 0x0601DB67 RID: 121703 RVA: 0x008FFD0A File Offset: 0x008FDF0A
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DB68 RID: 121704 RVA: 0x008FFD13 File Offset: 0x008FDF13
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DB69 RID: 121705 RVA: 0x008FFD20 File Offset: 0x008FDF20
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

		// Token: 0x0400FAF1 RID: 64241
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultCharacterGolden__DelegateSignature";

		// Token: 0x0400FAF2 RID: 64242
		private static int RegisterId;

		// Token: 0x02008D88 RID: 36232
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C93F RID: 182591
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
