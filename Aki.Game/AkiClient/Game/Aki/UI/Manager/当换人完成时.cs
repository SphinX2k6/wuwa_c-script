using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003049 RID: 12361
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当换人完成时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D585 RID: 120197 RVA: 0x008F2059 File Offset: 0x008F0259
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当换人完成时.StaticFunctionPtr();
		}

		// Token: 0x0601D586 RID: 120198 RVA: 0x008F2065 File Offset: 0x008F0265
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当换人完成时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当换人完成时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当换人完成时__DelegateSignature");
			}
			return BP_EventManager_C.__当换人完成时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D587 RID: 120199 RVA: 0x008F2088 File Offset: 0x008F0288
		public 当换人完成时()
		{
		}

		// Token: 0x0601D588 RID: 120200 RVA: 0x008F2090 File Offset: 0x008F0290
		[NullableContext(2)]
		public 当换人完成时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D589 RID: 120201 RVA: 0x008F209A File Offset: 0x008F029A
		public 当换人完成时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D58A RID: 120202 RVA: 0x008F20A5 File Offset: 0x008F02A5
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D58B RID: 120203 RVA: 0x008F20D7 File Offset: 0x008F02D7
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (当换人完成时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当换人完成时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当换人完成时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当换人完成时.OnScriptCallback));
				}
				当换人完成时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当换人完成时.RegisterId);
		}

		// Token: 0x0601D58C RID: 120204 RVA: 0x008F2111 File Offset: 0x008F0311
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D58D RID: 120205 RVA: 0x008F211A File Offset: 0x008F031A
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601D58E RID: 120206 RVA: 0x008F2124 File Offset: 0x008F0324
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

		// Token: 0x0400F74E RID: 63310
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当换人完成时__DelegateSignature";

		// Token: 0x0400F74F RID: 63311
		private static int RegisterId;

		// Token: 0x02008CA7 RID: 36007
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7AB RID: 182187
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
