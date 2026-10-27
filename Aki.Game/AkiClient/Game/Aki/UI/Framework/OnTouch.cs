using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003A0C RID: 14860
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnTouch : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F27F RID: 127615 RVA: 0x008AE2EA File Offset: 0x008AC4EA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnTouch.StaticFunctionPtr();
		}

		// Token: 0x0601F280 RID: 127616 RVA: 0x008AE2F6 File Offset: 0x008AC4F6
		private static IntPtr StaticFunctionPtr()
		{
			if (LGUIEventSystemActor_C.__OnTouch__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				LGUIEventSystemActor_C.__OnTouch__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnTouch__DelegateSignature");
			}
			return LGUIEventSystemActor_C.__OnTouch__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601F281 RID: 127617 RVA: 0x008AE319 File Offset: 0x008AC519
		public OnTouch()
		{
		}

		// Token: 0x0601F282 RID: 127618 RVA: 0x008AE321 File Offset: 0x008AC521
		[NullableContext(2)]
		public OnTouch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F283 RID: 127619 RVA: 0x008AE32B File Offset: 0x008AC52B
		public OnTouch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F284 RID: 127620 RVA: 0x008AE336 File Offset: 0x008AC536
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, int, FVector>) ?? ((Action<bool, int, FVector>)Delegate.CreateDelegate(typeof(Action<bool, int, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F285 RID: 127621 RVA: 0x008AE368 File Offset: 0x008AC568
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, int, FVector> Callback)
		{
			if (OnTouch.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnTouch.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnTouch.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnTouch.OnScriptCallback));
				}
				OnTouch.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnTouch.RegisterId);
		}

		// Token: 0x0601F286 RID: 127622 RVA: 0x008AE3A2 File Offset: 0x008AC5A2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, int, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601F287 RID: 127623 RVA: 0x008AE3AC File Offset: 0x008AC5AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool TouchPress, int TouchID, FVector TouchPointPosition)
		{
			OnTouch.__OnTouch_DelegateParams* ptr = stackalloc OnTouch.__OnTouch_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(OnTouch.__OnTouch_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnTouch.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchPress = TouchPress;
			ptr->TouchID = TouchID;
			ptr->TouchPointPosition = TouchPointPosition;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601F288 RID: 127624 RVA: 0x008AE3F8 File Offset: 0x008AC5F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, int, FVector> action = target as Action<bool, int, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnTouch.__OnTouch_DelegateParams*)__Parameters)->TouchPress, ((OnTouch.__OnTouch_DelegateParams*)__Parameters)->TouchID, ((OnTouch.__OnTouch_DelegateParams*)__Parameters)->TouchPointPosition);
		}

		// Token: 0x0400EEBA RID: 61114
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnTouch__DelegateSignature";

		// Token: 0x0400EEBB RID: 61115
		private static int RegisterId;

		// Token: 0x02009A5D RID: 39517
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __OnTouch_DelegateParams
		{
			// Token: 0x04030F96 RID: 200598
			[FieldOffset(0)]
			public bool TouchPress;

			// Token: 0x04030F97 RID: 200599
			[FieldOffset(4)]
			public int TouchID;

			// Token: 0x04030F98 RID: 200600
			[FieldOffset(8)]
			public FVector TouchPointPosition;
		}

		// Token: 0x02009A5E RID: 39518
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04030F99 RID: 200601
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
