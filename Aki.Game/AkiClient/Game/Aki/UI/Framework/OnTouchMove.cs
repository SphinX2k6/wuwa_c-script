using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003A0D RID: 14861
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnTouchMove : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F289 RID: 127625 RVA: 0x008AE44E File Offset: 0x008AC64E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnTouchMove.StaticFunctionPtr();
		}

		// Token: 0x0601F28A RID: 127626 RVA: 0x008AE45A File Offset: 0x008AC65A
		private static IntPtr StaticFunctionPtr()
		{
			if (LGUIEventSystemActor_C.__OnTouchMove__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				LGUIEventSystemActor_C.__OnTouchMove__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnTouchMove__DelegateSignature");
			}
			return LGUIEventSystemActor_C.__OnTouchMove__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F28B RID: 127627 RVA: 0x008AE47D File Offset: 0x008AC67D
		public OnTouchMove()
		{
		}

		// Token: 0x0601F28C RID: 127628 RVA: 0x008AE485 File Offset: 0x008AC685
		[NullableContext(2)]
		public OnTouchMove(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F28D RID: 127629 RVA: 0x008AE48F File Offset: 0x008AC68F
		public OnTouchMove(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F28E RID: 127630 RVA: 0x008AE49A File Offset: 0x008AC69A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, FVector>) ?? ((Action<int, FVector>)Delegate.CreateDelegate(typeof(Action<int, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F28F RID: 127631 RVA: 0x008AE4CC File Offset: 0x008AC6CC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<int, FVector> Callback)
		{
			if (OnTouchMove.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnTouchMove.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnTouchMove.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnTouchMove.OnScriptCallback));
				}
				OnTouchMove.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnTouchMove.RegisterId);
		}

		// Token: 0x0601F290 RID: 127632 RVA: 0x008AE506 File Offset: 0x008AC706
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<int, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F291 RID: 127633 RVA: 0x008AE510 File Offset: 0x008AC710
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(int TouchID, FVector TouchPointPosition)
		{
			OnTouchMove.__OnTouchMove_DelegateParams* ptr = stackalloc OnTouchMove.__OnTouchMove_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(OnTouchMove.__OnTouchMove_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnTouchMove.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchID = TouchID;
			ptr->TouchPointPosition = TouchPointPosition;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F292 RID: 127634 RVA: 0x008AE554 File Offset: 0x008AC754
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, FVector> action = target as Action<int, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnTouchMove.__OnTouchMove_DelegateParams*)__Parameters)->TouchID, ((OnTouchMove.__OnTouchMove_DelegateParams*)__Parameters)->TouchPointPosition);
		}

		// Token: 0x0400EEBC RID: 61116
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnTouchMove__DelegateSignature";

		// Token: 0x0400EEBD RID: 61117
		private static int RegisterId;

		// Token: 0x02009A5F RID: 39519
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchMove_DelegateParams
		{
			// Token: 0x04030F9A RID: 200602
			[FieldOffset(0)]
			public int TouchID;

			// Token: 0x04030F9B RID: 200603
			[FieldOffset(4)]
			public FVector TouchPointPosition;
		}

		// Token: 0x02009A60 RID: 39520
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030F9C RID: 200604
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
