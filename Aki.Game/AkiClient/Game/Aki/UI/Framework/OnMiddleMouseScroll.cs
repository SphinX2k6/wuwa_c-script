using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003A0B RID: 14859
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnMiddleMouseScroll : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F275 RID: 127605 RVA: 0x008AE1A2 File Offset: 0x008AC3A2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnMiddleMouseScroll.StaticFunctionPtr();
		}

		// Token: 0x0601F276 RID: 127606 RVA: 0x008AE1AE File Offset: 0x008AC3AE
		private static IntPtr StaticFunctionPtr()
		{
			if (LGUIEventSystemActor_C.__OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				LGUIEventSystemActor_C.__OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnMiddleMouseScroll__DelegateSignature");
			}
			return LGUIEventSystemActor_C.__OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F277 RID: 127607 RVA: 0x008AE1D1 File Offset: 0x008AC3D1
		public OnMiddleMouseScroll()
		{
		}

		// Token: 0x0601F278 RID: 127608 RVA: 0x008AE1D9 File Offset: 0x008AC3D9
		[NullableContext(2)]
		public OnMiddleMouseScroll(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F279 RID: 127609 RVA: 0x008AE1E3 File Offset: 0x008AC3E3
		public OnMiddleMouseScroll(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F27A RID: 127610 RVA: 0x008AE1EE File Offset: 0x008AC3EE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F27B RID: 127611 RVA: 0x008AE220 File Offset: 0x008AC420
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float> Callback)
		{
			if (OnMiddleMouseScroll.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnMiddleMouseScroll.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnMiddleMouseScroll.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnMiddleMouseScroll.OnScriptCallback));
				}
				OnMiddleMouseScroll.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnMiddleMouseScroll.RegisterId);
		}

		// Token: 0x0601F27C RID: 127612 RVA: 0x008AE25A File Offset: 0x008AC45A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F27D RID: 127613 RVA: 0x008AE264 File Offset: 0x008AC464
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float AxisValue)
		{
			OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams* ptr = stackalloc OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnMiddleMouseScroll.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AxisValue = AxisValue;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F27E RID: 127614 RVA: 0x008AE2A0 File Offset: 0x008AC4A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams*)__Parameters)->AxisValue);
		}

		// Token: 0x0400EEB8 RID: 61112
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnMiddleMouseScroll__DelegateSignature";

		// Token: 0x0400EEB9 RID: 61113
		private static int RegisterId;

		// Token: 0x02009A5B RID: 39515
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnMiddleMouseScroll_DelegateParams
		{
			// Token: 0x04030F94 RID: 200596
			[FieldOffset(0)]
			public float AxisValue;
		}

		// Token: 0x02009A5C RID: 39516
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030F95 RID: 200597
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
