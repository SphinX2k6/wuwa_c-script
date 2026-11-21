using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003076 RID: 12406
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnScreenShotFade : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D940 RID: 121152 RVA: 0x008FBD34 File Offset: 0x008F9F34
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnScreenShotFade.StaticFunctionPtr();
		}

		// Token: 0x0601D941 RID: 121153 RVA: 0x008FBD40 File Offset: 0x008F9F40
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_KuroMasterSeqEvent_C.__OnScreenShotFade__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_KuroMasterSeqEvent_C.__OnScreenShotFade__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C:OnScreenShotFade__DelegateSignature");
			}
			return BP_KuroMasterSeqEvent_C.__OnScreenShotFade__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D942 RID: 121154 RVA: 0x008FBD63 File Offset: 0x008F9F63
		public OnScreenShotFade()
		{
		}

		// Token: 0x0601D943 RID: 121155 RVA: 0x008FBD6B File Offset: 0x008F9F6B
		[NullableContext(2)]
		public OnScreenShotFade(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D944 RID: 121156 RVA: 0x008FBD75 File Offset: 0x008F9F75
		public OnScreenShotFade(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D945 RID: 121157 RVA: 0x008FBD80 File Offset: 0x008F9F80
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D946 RID: 121158 RVA: 0x008FBDB2 File Offset: 0x008F9FB2
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (OnScreenShotFade.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnScreenShotFade.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnScreenShotFade.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnScreenShotFade.OnScriptCallback));
				}
				OnScreenShotFade.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnScreenShotFade.RegisterId);
		}

		// Token: 0x0601D947 RID: 121159 RVA: 0x008FBDEC File Offset: 0x008F9FEC
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D948 RID: 121160 RVA: 0x008FBDF5 File Offset: 0x008F9FF5
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601D949 RID: 121161 RVA: 0x008FBE00 File Offset: 0x008FA000
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

		// Token: 0x0400F963 RID: 63843
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C:OnScreenShotFade__DelegateSignature";

		// Token: 0x0400F964 RID: 63844
		private static int RegisterId;

		// Token: 0x02008D5E RID: 36190
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C8E8 RID: 182504
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
