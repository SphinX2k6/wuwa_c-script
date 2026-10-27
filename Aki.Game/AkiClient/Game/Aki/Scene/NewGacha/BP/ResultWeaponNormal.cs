using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003A60 RID: 14944
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultWeaponNormal : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F900 RID: 129280 RVA: 0x008BC086 File Offset: 0x008BA286
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultWeaponNormal.StaticFunctionPtr();
		}

		// Token: 0x0601F901 RID: 129281 RVA: 0x008BC092 File Offset: 0x008BA292
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultWeaponNormal__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultWeaponNormal__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponNormal__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultWeaponNormal__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F902 RID: 129282 RVA: 0x008BC0B5 File Offset: 0x008BA2B5
		public ResultWeaponNormal()
		{
		}

		// Token: 0x0601F903 RID: 129283 RVA: 0x008BC0BD File Offset: 0x008BA2BD
		[NullableContext(2)]
		public ResultWeaponNormal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F904 RID: 129284 RVA: 0x008BC0C7 File Offset: 0x008BA2C7
		public ResultWeaponNormal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F905 RID: 129285 RVA: 0x008BC0D2 File Offset: 0x008BA2D2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F906 RID: 129286 RVA: 0x008BC104 File Offset: 0x008BA304
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F907 RID: 129287 RVA: 0x008BC13E File Offset: 0x008BA33E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F908 RID: 129288 RVA: 0x008BC147 File Offset: 0x008BA347
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F909 RID: 129289 RVA: 0x008BC154 File Offset: 0x008BA354
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

		// Token: 0x0400F2DA RID: 62170
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultWeaponNormal__DelegateSignature";

		// Token: 0x0400F2DB RID: 62171
		private static int RegisterId;

		// Token: 0x02009B09 RID: 39689
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040310DC RID: 200924
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
