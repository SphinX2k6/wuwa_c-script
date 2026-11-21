using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003051 RID: 12369
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当触发相机注视时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5D5 RID: 120277 RVA: 0x008F2B0A File Offset: 0x008F0D0A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当触发相机注视时.StaticFunctionPtr();
		}

		// Token: 0x0601D5D6 RID: 120278 RVA: 0x008F2B16 File Offset: 0x008F0D16
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当触发相机注视时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当触发相机注视时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发相机注视时__DelegateSignature");
			}
			return BP_EventManager_C.__当触发相机注视时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5D7 RID: 120279 RVA: 0x008F2B39 File Offset: 0x008F0D39
		public 当触发相机注视时()
		{
		}

		// Token: 0x0601D5D8 RID: 120280 RVA: 0x008F2B41 File Offset: 0x008F0D41
		[NullableContext(2)]
		public 当触发相机注视时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D5D9 RID: 120281 RVA: 0x008F2B4B File Offset: 0x008F0D4B
		public 当触发相机注视时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D5DA RID: 120282 RVA: 0x008F2B56 File Offset: 0x008F0D56
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D5DB RID: 120283 RVA: 0x008F2B88 File Offset: 0x008F0D88
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (当触发相机注视时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当触发相机注视时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当触发相机注视时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当触发相机注视时.OnScriptCallback));
				}
				当触发相机注视时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当触发相机注视时.RegisterId);
		}

		// Token: 0x0601D5DC RID: 120284 RVA: 0x008F2BC2 File Offset: 0x008F0DC2
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5DD RID: 120285 RVA: 0x008F2BCB File Offset: 0x008F0DCB
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601D5DE RID: 120286 RVA: 0x008F2BD8 File Offset: 0x008F0DD8
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

		// Token: 0x0400F75E RID: 63326
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发相机注视时__DelegateSignature";

		// Token: 0x0400F75F RID: 63327
		private static int RegisterId;

		// Token: 0x02008CB5 RID: 36021
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7BC RID: 182204
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
