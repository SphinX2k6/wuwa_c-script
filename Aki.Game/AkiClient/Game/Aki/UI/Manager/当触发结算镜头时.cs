using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003052 RID: 12370
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当触发结算镜头时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5DF RID: 120287 RVA: 0x008F2C1A File Offset: 0x008F0E1A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当触发结算镜头时.StaticFunctionPtr();
		}

		// Token: 0x0601D5E0 RID: 120288 RVA: 0x008F2C26 File Offset: 0x008F0E26
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当触发结算镜头时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当触发结算镜头时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发结算镜头时__DelegateSignature");
			}
			return BP_EventManager_C.__当触发结算镜头时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5E1 RID: 120289 RVA: 0x008F2C49 File Offset: 0x008F0E49
		public 当触发结算镜头时()
		{
		}

		// Token: 0x0601D5E2 RID: 120290 RVA: 0x008F2C51 File Offset: 0x008F0E51
		[NullableContext(2)]
		public 当触发结算镜头时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D5E3 RID: 120291 RVA: 0x008F2C5B File Offset: 0x008F0E5B
		public 当触发结算镜头时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D5E4 RID: 120292 RVA: 0x008F2C66 File Offset: 0x008F0E66
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D5E5 RID: 120293 RVA: 0x008F2C98 File Offset: 0x008F0E98
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (当触发结算镜头时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当触发结算镜头时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当触发结算镜头时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当触发结算镜头时.OnScriptCallback));
				}
				当触发结算镜头时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当触发结算镜头时.RegisterId);
		}

		// Token: 0x0601D5E6 RID: 120294 RVA: 0x008F2CD2 File Offset: 0x008F0ED2
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5E7 RID: 120295 RVA: 0x008F2CDB File Offset: 0x008F0EDB
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601D5E8 RID: 120296 RVA: 0x008F2CE8 File Offset: 0x008F0EE8
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

		// Token: 0x0400F760 RID: 63328
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当触发结算镜头时__DelegateSignature";

		// Token: 0x0400F761 RID: 63329
		private static int RegisterId;

		// Token: 0x02008CB6 RID: 36022
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7BD RID: 182205
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
