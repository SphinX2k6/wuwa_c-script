using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x0200304E RID: 12366
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 当编队更新时 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D5B7 RID: 120247 RVA: 0x008F2724 File Offset: 0x008F0924
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 当编队更新时.StaticFunctionPtr();
		}

		// Token: 0x0601D5B8 RID: 120248 RVA: 0x008F2730 File Offset: 0x008F0930
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__当编队更新时__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__当编队更新时__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当编队更新时__DelegateSignature");
			}
			return BP_EventManager_C.__当编队更新时__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D5B9 RID: 120249 RVA: 0x008F2753 File Offset: 0x008F0953
		public 当编队更新时()
		{
		}

		// Token: 0x0601D5BA RID: 120250 RVA: 0x008F275B File Offset: 0x008F095B
		[NullableContext(2)]
		public 当编队更新时(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D5BB RID: 120251 RVA: 0x008F2765 File Offset: 0x008F0965
		public 当编队更新时(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D5BC RID: 120252 RVA: 0x008F2770 File Offset: 0x008F0970
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D5BD RID: 120253 RVA: 0x008F27A2 File Offset: 0x008F09A2
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (当编队更新时.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 当编队更新时.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (当编队更新时.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(当编队更新时.OnScriptCallback));
				}
				当编队更新时.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 当编队更新时.RegisterId);
		}

		// Token: 0x0601D5BE RID: 120254 RVA: 0x008F27DC File Offset: 0x008F09DC
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D5BF RID: 120255 RVA: 0x008F27E5 File Offset: 0x008F09E5
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601D5C0 RID: 120256 RVA: 0x008F27F0 File Offset: 0x008F09F0
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

		// Token: 0x0400F758 RID: 63320
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:当编队更新时__DelegateSignature";

		// Token: 0x0400F759 RID: 63321
		private static int RegisterId;

		// Token: 0x02008CB0 RID: 36016
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7B6 RID: 182198
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
