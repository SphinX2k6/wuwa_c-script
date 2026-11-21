using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200303E RID: 12350
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnExitPhotograph : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D517 RID: 120087 RVA: 0x008F11F6 File Offset: 0x008EF3F6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnExitPhotograph.StaticFunctionPtr();
		}

		// Token: 0x0601D518 RID: 120088 RVA: 0x008F1202 File Offset: 0x008EF402
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__OnExitPhotograph__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__OnExitPhotograph__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:OnExitPhotograph__DelegateSignature");
			}
			return BP_EventManager_C.__OnExitPhotograph__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D519 RID: 120089 RVA: 0x008F1225 File Offset: 0x008EF425
		public OnExitPhotograph()
		{
		}

		// Token: 0x0601D51A RID: 120090 RVA: 0x008F122D File Offset: 0x008EF42D
		[NullableContext(2)]
		public OnExitPhotograph(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D51B RID: 120091 RVA: 0x008F1237 File Offset: 0x008EF437
		public OnExitPhotograph(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D51C RID: 120092 RVA: 0x008F1242 File Offset: 0x008EF442
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D51D RID: 120093 RVA: 0x008F1274 File Offset: 0x008EF474
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (OnExitPhotograph.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnExitPhotograph.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnExitPhotograph.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnExitPhotograph.OnScriptCallback));
				}
				OnExitPhotograph.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnExitPhotograph.RegisterId);
		}

		// Token: 0x0601D51E RID: 120094 RVA: 0x008F12AE File Offset: 0x008EF4AE
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D51F RID: 120095 RVA: 0x008F12B7 File Offset: 0x008EF4B7
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601D520 RID: 120096 RVA: 0x008F12C4 File Offset: 0x008EF4C4
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

		// Token: 0x0400F738 RID: 63288
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:OnExitPhotograph__DelegateSignature";

		// Token: 0x0400F739 RID: 63289
		private static int RegisterId;

		// Token: 0x02008C93 RID: 35987
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C792 RID: 182162
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
