using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200309F RID: 12447
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultWeaponPurple : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DC00 RID: 121856 RVA: 0x00900D8A File Offset: 0x008FEF8A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultWeaponPurple.StaticFunctionPtr();
		}

		// Token: 0x0601DC01 RID: 121857 RVA: 0x00900D96 File Offset: 0x008FEF96
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultWeaponPurple__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultWeaponPurple__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponPurple__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultWeaponPurple__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DC02 RID: 121858 RVA: 0x00900DB9 File Offset: 0x008FEFB9
		public ResultWeaponPurple()
		{
		}

		// Token: 0x0601DC03 RID: 121859 RVA: 0x00900DC1 File Offset: 0x008FEFC1
		[NullableContext(2)]
		public ResultWeaponPurple(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DC04 RID: 121860 RVA: 0x00900DCB File Offset: 0x008FEFCB
		public ResultWeaponPurple(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DC05 RID: 121861 RVA: 0x00900DD6 File Offset: 0x008FEFD6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DC06 RID: 121862 RVA: 0x00900E08 File Offset: 0x008FF008
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultWeaponPurple.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultWeaponPurple.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultWeaponPurple.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultWeaponPurple.OnScriptCallback));
				}
				ResultWeaponPurple.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultWeaponPurple.RegisterId);
		}

		// Token: 0x0601DC07 RID: 121863 RVA: 0x00900E42 File Offset: 0x008FF042
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DC08 RID: 121864 RVA: 0x00900E4B File Offset: 0x008FF04B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DC09 RID: 121865 RVA: 0x00900E58 File Offset: 0x008FF058
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

		// Token: 0x0400FB11 RID: 64273
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponPurple__DelegateSignature";

		// Token: 0x0400FB12 RID: 64274
		private static int RegisterId;

		// Token: 0x02008D99 RID: 36249
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C950 RID: 182608
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
