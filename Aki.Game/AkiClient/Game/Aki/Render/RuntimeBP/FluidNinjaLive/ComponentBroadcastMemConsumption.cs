using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive
{
	// Token: 0x02003D88 RID: 15752
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ComponentBroadcastMemConsumption : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06026BA3 RID: 158627 RVA: 0x0097D1D5 File Offset: 0x0097B3D5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ComponentBroadcastMemConsumption.StaticFunctionPtr();
		}

		// Token: 0x06026BA4 RID: 158628 RVA: 0x0097D1E1 File Offset: 0x0097B3E1
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLiveComponent_C.__ComponentBroadcastMemConsumption__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLiveComponent_C.__ComponentBroadcastMemConsumption__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C:ComponentBroadcastMemConsumption__DelegateSignature");
			}
			return NinjaLiveComponent_C.__ComponentBroadcastMemConsumption__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06026BA5 RID: 158629 RVA: 0x0097D204 File Offset: 0x0097B404
		public ComponentBroadcastMemConsumption()
		{
		}

		// Token: 0x06026BA6 RID: 158630 RVA: 0x0097D20C File Offset: 0x0097B40C
		[NullableContext(2)]
		public ComponentBroadcastMemConsumption(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026BA7 RID: 158631 RVA: 0x0097D216 File Offset: 0x0097B416
		public ComponentBroadcastMemConsumption(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026BA8 RID: 158632 RVA: 0x0097D221 File Offset: 0x0097B421
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UObject, float, bool>) ?? ((Action<UObject, float, bool>)Delegate.CreateDelegate(typeof(Action<UObject, float, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06026BA9 RID: 158633 RVA: 0x0097D253 File Offset: 0x0097B453
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, float, bool> Callback)
		{
			if (ComponentBroadcastMemConsumption.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ComponentBroadcastMemConsumption.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ComponentBroadcastMemConsumption.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ComponentBroadcastMemConsumption.OnScriptCallback));
				}
				ComponentBroadcastMemConsumption.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ComponentBroadcastMemConsumption.RegisterId);
		}

		// Token: 0x06026BAA RID: 158634 RVA: 0x0097D28D File Offset: 0x0097B48D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UObject, float, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06026BAB RID: 158635 RVA: 0x0097D298 File Offset: 0x0097B498
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UObject Consumer, float MemConsumption, bool TakenOrReturned)
		{
			ComponentBroadcastMemConsumption.__ComponentBroadcastMemConsumption_DelegateParams* ptr = stackalloc ComponentBroadcastMemConsumption.__ComponentBroadcastMemConsumption_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(ComponentBroadcastMemConsumption.__ComponentBroadcastMemConsumption_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ComponentBroadcastMemConsumption.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Consumer = ((Consumer != null) ? Consumer.NativePtr : IntPtr.Zero);
			ptr->MemConsumption = MemConsumption;
			ptr->TakenOrReturned = TakenOrReturned;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06026BAC RID: 158636 RVA: 0x0097D2F4 File Offset: 0x0097B4F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UObject, float, bool> action = target as Action<UObject, float, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(((ComponentBroadcastMemConsumption.__ComponentBroadcastMemConsumption_DelegateParams*)__Parameters)->Consumer);
			action(orCreateUObjectByNativePointer, ((ComponentBroadcastMemConsumption.__ComponentBroadcastMemConsumption_DelegateParams*)__Parameters)->MemConsumption, ((ComponentBroadcastMemConsumption.__ComponentBroadcastMemConsumption_DelegateParams*)__Parameters)->TakenOrReturned);
		}

		// Token: 0x040137A2 RID: 79778
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/NinjaLiveComponent.NinjaLiveComponent_C:ComponentBroadcastMemConsumption__DelegateSignature";

		// Token: 0x040137A3 RID: 79779
		private static int RegisterId;

		// Token: 0x0200A14F RID: 41295
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ComponentBroadcastMemConsumption_DelegateParams
		{
			// Token: 0x04031CF6 RID: 204022
			[FieldOffset(0)]
			public IntPtr Consumer;

			// Token: 0x04031CF7 RID: 204023
			[FieldOffset(8)]
			public float MemConsumption;

			// Token: 0x04031CF8 RID: 204024
			[FieldOffset(12)]
			public bool TakenOrReturned;
		}

		// Token: 0x0200A150 RID: 41296
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031CF9 RID: 204025
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
