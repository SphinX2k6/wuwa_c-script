using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A61 RID: 14945
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultWeaponPurple : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F90A RID: 129290 RVA: 0x008BC196 File Offset: 0x008BA396
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultWeaponPurple.StaticFunctionPtr();
		}

		// Token: 0x0601F90B RID: 129291 RVA: 0x008BC1A2 File Offset: 0x008BA3A2
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultWeaponPurple__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultWeaponPurple__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponPurple__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultWeaponPurple__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F90C RID: 129292 RVA: 0x008BC1C5 File Offset: 0x008BA3C5
		public ResultWeaponPurple()
		{
		}

		// Token: 0x0601F90D RID: 129293 RVA: 0x008BC1CD File Offset: 0x008BA3CD
		[NullableContext(2)]
		public ResultWeaponPurple(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F90E RID: 129294 RVA: 0x008BC1D7 File Offset: 0x008BA3D7
		public ResultWeaponPurple(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F90F RID: 129295 RVA: 0x008BC1E2 File Offset: 0x008BA3E2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F910 RID: 129296 RVA: 0x008BC214 File Offset: 0x008BA414
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F911 RID: 129297 RVA: 0x008BC24E File Offset: 0x008BA44E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F912 RID: 129298 RVA: 0x008BC257 File Offset: 0x008BA457
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F913 RID: 129299 RVA: 0x008BC264 File Offset: 0x008BA464
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

		// Token: 0x0400F2DC RID: 62172
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponPurple__DelegateSignature";

		// Token: 0x0400F2DD RID: 62173
		private static int RegisterId;

		// Token: 0x02009B0A RID: 39690
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310DD RID: 200925
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
