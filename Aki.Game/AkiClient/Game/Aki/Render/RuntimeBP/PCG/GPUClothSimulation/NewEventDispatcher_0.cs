using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUClothSimulation
{
	// Token: 0x02003CAD RID: 15533
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class NewEventDispatcher_0 : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0602488D RID: 149645 RVA: 0x009414B5 File Offset: 0x0093F6B5
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return NewEventDispatcher_0.StaticFunctionPtr();
		}

		// Token: 0x0602488E RID: 149646 RVA: 0x009414C1 File Offset: 0x0093F6C1
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_PhysicCloth_v2_C.__NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_PhysicCloth_v2_C.__NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_v2.BP_PhysicCloth_v2_C:NewEventDispatcher_0__DelegateSignature");
			}
			return BP_PhysicCloth_v2_C.__NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0602488F RID: 149647 RVA: 0x009414E4 File Offset: 0x0093F6E4
		public NewEventDispatcher_0()
		{
		}

		// Token: 0x06024890 RID: 149648 RVA: 0x009414EC File Offset: 0x0093F6EC
		[NullableContext(2)]
		public NewEventDispatcher_0(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024891 RID: 149649 RVA: 0x009414F6 File Offset: 0x0093F6F6
		public NewEventDispatcher_0(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024892 RID: 149650 RVA: 0x00941501 File Offset: 0x0093F701
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06024893 RID: 149651 RVA: 0x00941533 File Offset: 0x0093F733
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action Callback)
		{
			if (NewEventDispatcher_0.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = NewEventDispatcher_0.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (NewEventDispatcher_0.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(NewEventDispatcher_0.OnScriptCallback));
				}
				NewEventDispatcher_0.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, NewEventDispatcher_0.RegisterId);
		}

		// Token: 0x06024894 RID: 149652 RVA: 0x0094156D File Offset: 0x0093F76D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06024895 RID: 149653 RVA: 0x00941576 File Offset: 0x0093F776
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06024896 RID: 149654 RVA: 0x00941580 File Offset: 0x0093F780
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

		// Token: 0x0401223F RID: 74303
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicCloth_v2.BP_PhysicCloth_v2_C:NewEventDispatcher_0__DelegateSignature";

		// Token: 0x04012240 RID: 74304
		private static int RegisterId;

		// Token: 0x02009F32 RID: 40754
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040318B4 RID: 202932
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
