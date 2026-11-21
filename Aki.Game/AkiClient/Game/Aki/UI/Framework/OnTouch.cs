using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003064 RID: 12388
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnTouch : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D6E2 RID: 120546 RVA: 0x008F650A File Offset: 0x008F470A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnTouch.StaticFunctionPtr();
		}

		// Token: 0x0601D6E3 RID: 120547 RVA: 0x008F6516 File Offset: 0x008F4716
		private static IntPtr StaticFunctionPtr()
		{
			if (LGUIEventSystemActor_C.__OnTouch__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				LGUIEventSystemActor_C.__OnTouch__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnTouch__DelegateSignature");
			}
			return LGUIEventSystemActor_C.__OnTouch__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D6E4 RID: 120548 RVA: 0x008F6539 File Offset: 0x008F4739
		public OnTouch()
		{
		}

		// Token: 0x0601D6E5 RID: 120549 RVA: 0x008F6541 File Offset: 0x008F4741
		[NullableContext(2)]
		public OnTouch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D6E6 RID: 120550 RVA: 0x008F654B File Offset: 0x008F474B
		public OnTouch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D6E7 RID: 120551 RVA: 0x008F6556 File Offset: 0x008F4756
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, int, FVector>) ?? ((Action<bool, int, FVector>)Delegate.CreateDelegate(typeof(Action<bool, int, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D6E8 RID: 120552 RVA: 0x008F6588 File Offset: 0x008F4788
		[NullableContext(1)]
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

		// Token: 0x0601D6E9 RID: 120553 RVA: 0x008F65C2 File Offset: 0x008F47C2
		[NullableContext(1)]
		public void Remove(Action<bool, int, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D6EA RID: 120554 RVA: 0x008F65CC File Offset: 0x008F47CC
		[SkipLocalsInit]
		public unsafe void Broadcast(bool TouchPress, int TouchID, FVector TouchPointPosition)
		{
			OnTouch.__OnTouch_DelegateParams* ptr = stackalloc OnTouch.__OnTouch_DelegateParams[(UIntPtr)35] + 15L / (long)sizeof(OnTouch.__OnTouch_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnTouch.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchPress = TouchPress;
			ptr->TouchID = TouchID;
			ptr->TouchPointPosition = TouchPointPosition;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D6EB RID: 120555 RVA: 0x008F6618 File Offset: 0x008F4818
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, int, FVector> action = target as Action<bool, int, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnTouch.__OnTouch_DelegateParams*)__Parameters)->TouchPress, ((OnTouch.__OnTouch_DelegateParams*)__Parameters)->TouchID, ((OnTouch.__OnTouch_DelegateParams*)__Parameters)->TouchPointPosition);
		}

		// Token: 0x0400F7DC RID: 63452
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnTouch__DelegateSignature";

		// Token: 0x0400F7DD RID: 63453
		private static int RegisterId;

		// Token: 0x02008D0C RID: 36108
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		private ref struct __OnTouch_DelegateParams
		{
			// Token: 0x0402C85A RID: 182362
			[FieldOffset(0)]
			public bool TouchPress;

			// Token: 0x0402C85B RID: 182363
			[FieldOffset(4)]
			public int TouchID;

			// Token: 0x0402C85C RID: 182364
			[FieldOffset(8)]
			public FVector TouchPointPosition;
		}

		// Token: 0x02008D0D RID: 36109
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C85D RID: 182365
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
