using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A2E RID: 14894
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnScreenShotFade : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F5B6 RID: 128438 RVA: 0x008B64D0 File Offset: 0x008B46D0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnScreenShotFade.StaticFunctionPtr();
		}

		// Token: 0x0601F5B7 RID: 128439 RVA: 0x008B64DC File Offset: 0x008B46DC
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_KuroMasterSeqEvent_C.__OnScreenShotFade__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_KuroMasterSeqEvent_C.__OnScreenShotFade__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C:OnScreenShotFade__DelegateSignature");
			}
			return BP_KuroMasterSeqEvent_C.__OnScreenShotFade__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F5B8 RID: 128440 RVA: 0x008B64FF File Offset: 0x008B46FF
		public OnScreenShotFade()
		{
		}

		// Token: 0x0601F5B9 RID: 128441 RVA: 0x008B6507 File Offset: 0x008B4707
		[NullableContext(2)]
		public OnScreenShotFade(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F5BA RID: 128442 RVA: 0x008B6511 File Offset: 0x008B4711
		public OnScreenShotFade(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F5BB RID: 128443 RVA: 0x008B651C File Offset: 0x008B471C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F5BC RID: 128444 RVA: 0x008B654E File Offset: 0x008B474E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0601F5BD RID: 128445 RVA: 0x008B6588 File Offset: 0x008B4788
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F5BE RID: 128446 RVA: 0x008B6591 File Offset: 0x008B4791
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601F5BF RID: 128447 RVA: 0x008B659C File Offset: 0x008B479C
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

		// Token: 0x0400F0E6 RID: 61670
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Sequence/Manager/BP_KuroMasterSeqEvent.BP_KuroMasterSeqEvent_C:OnScreenShotFade__DelegateSignature";

		// Token: 0x0400F0E7 RID: 61671
		private static int RegisterId;

		// Token: 0x02009ACF RID: 39631
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031075 RID: 200821
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
