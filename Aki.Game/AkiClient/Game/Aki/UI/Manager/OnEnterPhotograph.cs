using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200303D RID: 12349
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnEnterPhotograph : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D50D RID: 120077 RVA: 0x008F10E8 File Offset: 0x008EF2E8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnEnterPhotograph.StaticFunctionPtr();
		}

		// Token: 0x0601D50E RID: 120078 RVA: 0x008F10F4 File Offset: 0x008EF2F4
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__OnEnterPhotograph__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__OnEnterPhotograph__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:OnEnterPhotograph__DelegateSignature");
			}
			return BP_EventManager_C.__OnEnterPhotograph__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D50F RID: 120079 RVA: 0x008F1117 File Offset: 0x008EF317
		public OnEnterPhotograph()
		{
		}

		// Token: 0x0601D510 RID: 120080 RVA: 0x008F111F File Offset: 0x008EF31F
		[NullableContext(2)]
		public OnEnterPhotograph(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D511 RID: 120081 RVA: 0x008F1129 File Offset: 0x008EF329
		public OnEnterPhotograph(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D512 RID: 120082 RVA: 0x008F1134 File Offset: 0x008EF334
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D513 RID: 120083 RVA: 0x008F1166 File Offset: 0x008EF366
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (OnEnterPhotograph.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnEnterPhotograph.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnEnterPhotograph.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnEnterPhotograph.OnScriptCallback));
				}
				OnEnterPhotograph.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnEnterPhotograph.RegisterId);
		}

		// Token: 0x0601D514 RID: 120084 RVA: 0x008F11A0 File Offset: 0x008EF3A0
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D515 RID: 120085 RVA: 0x008F11A9 File Offset: 0x008EF3A9
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601D516 RID: 120086 RVA: 0x008F11B4 File Offset: 0x008EF3B4
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

		// Token: 0x0400F736 RID: 63286
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:OnEnterPhotograph__DelegateSignature";

		// Token: 0x0400F737 RID: 63287
		private static int RegisterId;

		// Token: 0x02008C92 RID: 35986
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C791 RID: 182161
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
