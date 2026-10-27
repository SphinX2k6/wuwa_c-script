using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A5F RID: 14943
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultWeaponGolden : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F8F6 RID: 129270 RVA: 0x008BBF76 File Offset: 0x008BA176
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultWeaponGolden.StaticFunctionPtr();
		}

		// Token: 0x0601F8F7 RID: 129271 RVA: 0x008BBF82 File Offset: 0x008BA182
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultWeaponGolden__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultWeaponGolden__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponGolden__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultWeaponGolden__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F8F8 RID: 129272 RVA: 0x008BBFA5 File Offset: 0x008BA1A5
		public ResultWeaponGolden()
		{
		}

		// Token: 0x0601F8F9 RID: 129273 RVA: 0x008BBFAD File Offset: 0x008BA1AD
		[NullableContext(2)]
		public ResultWeaponGolden(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F8FA RID: 129274 RVA: 0x008BBFB7 File Offset: 0x008BA1B7
		public ResultWeaponGolden(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F8FB RID: 129275 RVA: 0x008BBFC2 File Offset: 0x008BA1C2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F8FC RID: 129276 RVA: 0x008BBFF4 File Offset: 0x008BA1F4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F8FD RID: 129277 RVA: 0x008BC02E File Offset: 0x008BA22E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F8FE RID: 129278 RVA: 0x008BC037 File Offset: 0x008BA237
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F8FF RID: 129279 RVA: 0x008BC044 File Offset: 0x008BA244
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

		// Token: 0x0400F2D8 RID: 62168
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponGolden__DelegateSignature";

		// Token: 0x0400F2D9 RID: 62169
		private static int RegisterId;

		// Token: 0x02009B08 RID: 39688
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310DB RID: 200923
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
