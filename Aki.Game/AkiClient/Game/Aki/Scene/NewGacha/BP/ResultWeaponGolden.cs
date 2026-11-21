using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200309D RID: 12445
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultWeaponGolden : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBEC RID: 121836 RVA: 0x00900B6A File Offset: 0x008FED6A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultWeaponGolden.StaticFunctionPtr();
		}

		// Token: 0x0601DBED RID: 121837 RVA: 0x00900B76 File Offset: 0x008FED76
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultWeaponGolden__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultWeaponGolden__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponGolden__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultWeaponGolden__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DBEE RID: 121838 RVA: 0x00900B99 File Offset: 0x008FED99
		public ResultWeaponGolden()
		{
		}

		// Token: 0x0601DBEF RID: 121839 RVA: 0x00900BA1 File Offset: 0x008FEDA1
		[NullableContext(2)]
		public ResultWeaponGolden(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBF0 RID: 121840 RVA: 0x00900BAB File Offset: 0x008FEDAB
		public ResultWeaponGolden(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBF1 RID: 121841 RVA: 0x00900BB6 File Offset: 0x008FEDB6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBF2 RID: 121842 RVA: 0x00900BE8 File Offset: 0x008FEDE8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultWeaponGolden.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultWeaponGolden.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultWeaponGolden.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultWeaponGolden.OnScriptCallback));
				}
				ResultWeaponGolden.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultWeaponGolden.RegisterId);
		}

		// Token: 0x0601DBF3 RID: 121843 RVA: 0x00900C22 File Offset: 0x008FEE22
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBF4 RID: 121844 RVA: 0x00900C2B File Offset: 0x008FEE2B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DBF5 RID: 121845 RVA: 0x00900C38 File Offset: 0x008FEE38
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

		// Token: 0x0400FB0D RID: 64269
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponGolden__DelegateSignature";

		// Token: 0x0400FB0E RID: 64270
		private static int RegisterId;

		// Token: 0x02008D97 RID: 36247
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C94E RID: 182606
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
