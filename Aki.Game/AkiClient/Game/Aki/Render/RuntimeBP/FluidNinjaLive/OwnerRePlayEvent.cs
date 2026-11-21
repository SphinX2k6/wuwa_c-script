using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x020030FD RID: 12541
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OwnerRePlayEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601EAA4 RID: 125604 RVA: 0x00919C16 File Offset: 0x00917E16
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OwnerRePlayEvent.StaticFunctionPtr();
		}

		// Token: 0x0601EAA5 RID: 125605 RVA: 0x00919C22 File Offset: 0x00917E22
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLive_C.__OwnerRePlayEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLive_C.__OwnerRePlayEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C:OwnerRePlayEvent__DelegateSignature");
			}
			return NinjaLive_C.__OwnerRePlayEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601EAA6 RID: 125606 RVA: 0x00919C45 File Offset: 0x00917E45
		public OwnerRePlayEvent()
		{
		}

		// Token: 0x0601EAA7 RID: 125607 RVA: 0x00919C4D File Offset: 0x00917E4D
		[NullableContext(2)]
		public OwnerRePlayEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EAA8 RID: 125608 RVA: 0x00919C57 File Offset: 0x00917E57
		public OwnerRePlayEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EAA9 RID: 125609 RVA: 0x00919C62 File Offset: 0x00917E62
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601EAAA RID: 125610 RVA: 0x00919C94 File Offset: 0x00917E94
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (OwnerRePlayEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OwnerRePlayEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OwnerRePlayEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OwnerRePlayEvent.OnScriptCallback));
				}
				OwnerRePlayEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OwnerRePlayEvent.RegisterId);
		}

		// Token: 0x0601EAAB RID: 125611 RVA: 0x00919CCE File Offset: 0x00917ECE
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601EAAC RID: 125612 RVA: 0x00919CD7 File Offset: 0x00917ED7
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x0601EAAD RID: 125613 RVA: 0x00919CE4 File Offset: 0x00917EE4
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

		// Token: 0x0401045B RID: 66651
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLive.NinjaLive_C:OwnerRePlayEvent__DelegateSignature";

		// Token: 0x0401045C RID: 66652
		private static int RegisterId;

		// Token: 0x02008EB0 RID: 36528
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402CB4C RID: 183116
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
