using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D8A RID: 15754
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ComponentShutdownEvent : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026BB7 RID: 158647 RVA: 0x0097D45E File Offset: 0x0097B65E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ComponentShutdownEvent.StaticFunctionPtr();
		}

		// Token: 0x06026BB8 RID: 158648 RVA: 0x0097D46A File Offset: 0x0097B66A
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLiveComponent_C.__ComponentShutdownEvent__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLiveComponent_C.__ComponentShutdownEvent__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C:ComponentShutdownEvent__DelegateSignature");
			}
			return NinjaLiveComponent_C.__ComponentShutdownEvent__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06026BB9 RID: 158649 RVA: 0x0097D48D File Offset: 0x0097B68D
		public ComponentShutdownEvent()
		{
		}

		// Token: 0x06026BBA RID: 158650 RVA: 0x0097D495 File Offset: 0x0097B695
		[NullableContext(2)]
		public ComponentShutdownEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026BBB RID: 158651 RVA: 0x0097D49F File Offset: 0x0097B69F
		public ComponentShutdownEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026BBC RID: 158652 RVA: 0x0097D4AA File Offset: 0x0097B6AA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026BBD RID: 158653 RVA: 0x0097D4DC File Offset: 0x0097B6DC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (ComponentShutdownEvent.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ComponentShutdownEvent.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ComponentShutdownEvent.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ComponentShutdownEvent.OnScriptCallback));
				}
				ComponentShutdownEvent.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ComponentShutdownEvent.RegisterId);
		}

		// Token: 0x06026BBE RID: 158654 RVA: 0x0097D516 File Offset: 0x0097B716
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026BBF RID: 158655 RVA: 0x0097D51F File Offset: 0x0097B71F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06026BC0 RID: 158656 RVA: 0x0097D52C File Offset: 0x0097B72C
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

		// Token: 0x040137A6 RID: 79782
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C:ComponentShutdownEvent__DelegateSignature";

		// Token: 0x040137A7 RID: 79783
		private static int RegisterId;

		// Token: 0x0200A152 RID: 41298
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031CFB RID: 204027
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
