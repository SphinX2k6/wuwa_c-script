using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x0200309E RID: 12446
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultWeaponNormal : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBF6 RID: 121846 RVA: 0x00900C7A File Offset: 0x008FEE7A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultWeaponNormal.StaticFunctionPtr();
		}

		// Token: 0x0601DBF7 RID: 121847 RVA: 0x00900C86 File Offset: 0x008FEE86
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultWeaponNormal__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultWeaponNormal__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponNormal__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultWeaponNormal__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DBF8 RID: 121848 RVA: 0x00900CA9 File Offset: 0x008FEEA9
		public ResultWeaponNormal()
		{
		}

		// Token: 0x0601DBF9 RID: 121849 RVA: 0x00900CB1 File Offset: 0x008FEEB1
		[NullableContext(2)]
		public ResultWeaponNormal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBFA RID: 121850 RVA: 0x00900CBB File Offset: 0x008FEEBB
		public ResultWeaponNormal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBFB RID: 121851 RVA: 0x00900CC6 File Offset: 0x008FEEC6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBFC RID: 121852 RVA: 0x00900CF8 File Offset: 0x008FEEF8
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (ResultWeaponNormal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultWeaponNormal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultWeaponNormal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultWeaponNormal.OnScriptCallback));
				}
				ResultWeaponNormal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultWeaponNormal.RegisterId);
		}

		// Token: 0x0601DBFD RID: 121853 RVA: 0x00900D32 File Offset: 0x008FEF32
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBFE RID: 121854 RVA: 0x00900D3B File Offset: 0x008FEF3B
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601DBFF RID: 121855 RVA: 0x00900D48 File Offset: 0x008FEF48
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

		// Token: 0x0400FB0F RID: 64271
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponNormal__DelegateSignature";

		// Token: 0x0400FB10 RID: 64272
		private static int RegisterId;

		// Token: 0x02008D98 RID: 36248
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C94F RID: 182607
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
