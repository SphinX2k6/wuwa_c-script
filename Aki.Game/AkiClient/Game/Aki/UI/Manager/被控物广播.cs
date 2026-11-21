using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Manager
{
	// Token: 0x02003058 RID: 12376
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class 被控物广播 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D61B RID: 120347 RVA: 0x008F345B File Offset: 0x008F165B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return 被控物广播.StaticFunctionPtr();
		}

		// Token: 0x0601D61C RID: 120348 RVA: 0x008F3467 File Offset: 0x008F1667
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_EventManager_C.__被控物广播__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_EventManager_C.__被控物广播__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:被控物广播__DelegateSignature");
			}
			return BP_EventManager_C.__被控物广播__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D61D RID: 120349 RVA: 0x008F348A File Offset: 0x008F168A
		public 被控物广播()
		{
		}

		// Token: 0x0601D61E RID: 120350 RVA: 0x008F3492 File Offset: 0x008F1692
		[NullableContext(2)]
		public 被控物广播(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D61F RID: 120351 RVA: 0x008F349C File Offset: 0x008F169C
		public 被控物广播(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D620 RID: 120352 RVA: 0x008F34A7 File Offset: 0x008F16A7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D621 RID: 120353 RVA: 0x008F34D9 File Offset: 0x008F16D9
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (被控物广播.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = 被控物广播.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (被控物广播.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(被控物广播.OnScriptCallback));
				}
				被控物广播.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, 被控物广播.RegisterId);
		}

		// Token: 0x0601D622 RID: 120354 RVA: 0x008F3513 File Offset: 0x008F1713
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D623 RID: 120355 RVA: 0x008F351C File Offset: 0x008F171C
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601D624 RID: 120356 RVA: 0x008F3528 File Offset: 0x008F1728
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

		// Token: 0x0400F76C RID: 63340
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Manager/BP_EventManager.BP_EventManager_C:被控物广播__DelegateSignature";

		// Token: 0x0400F76D RID: 63341
		private static int RegisterId;

		// Token: 0x02008CC1 RID: 36033
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C7CE RID: 182222
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
