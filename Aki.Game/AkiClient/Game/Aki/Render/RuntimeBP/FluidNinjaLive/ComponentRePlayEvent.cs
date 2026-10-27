using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D89 RID: 15753
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ComponentRePlayEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026BAD RID: 158637 RVA: 0x0097D351 File Offset: 0x0097B551
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ComponentRePlayEvent.StaticFunctionPtr();
		}

		// Token: 0x06026BAE RID: 158638 RVA: 0x0097D35D File Offset: 0x0097B55D
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLiveComponent_C.__ComponentRePlayEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLiveComponent_C.__ComponentRePlayEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C:ComponentRePlayEvent__DelegateSignature");
			}
			return NinjaLiveComponent_C.__ComponentRePlayEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06026BAF RID: 158639 RVA: 0x0097D380 File Offset: 0x0097B580
		public ComponentRePlayEvent()
		{
		}

		// Token: 0x06026BB0 RID: 158640 RVA: 0x0097D388 File Offset: 0x0097B588
		[NullableContext(2)]
		public ComponentRePlayEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026BB1 RID: 158641 RVA: 0x0097D392 File Offset: 0x0097B592
		public ComponentRePlayEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026BB2 RID: 158642 RVA: 0x0097D39D File Offset: 0x0097B59D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026BB3 RID: 158643 RVA: 0x0097D3CF File Offset: 0x0097B5CF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ComponentRePlayEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ComponentRePlayEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ComponentRePlayEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ComponentRePlayEvent.OnScriptCallback));
				}
				ComponentRePlayEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ComponentRePlayEvent.RegisterId);
		}

		// Token: 0x06026BB4 RID: 158644 RVA: 0x0097D409 File Offset: 0x0097B609
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026BB5 RID: 158645 RVA: 0x0097D412 File Offset: 0x0097B612
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06026BB6 RID: 158646 RVA: 0x0097D41C File Offset: 0x0097B61C
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

		// Token: 0x040137A4 RID: 79780
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C:ComponentRePlayEvent__DelegateSignature";

		// Token: 0x040137A5 RID: 79781
		private static int RegisterId;

		// Token: 0x0200A151 RID: 41297
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031CFA RID: 204026
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
