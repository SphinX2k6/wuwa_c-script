using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003065 RID: 12389
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnTouchMove : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D6EC RID: 120556 RVA: 0x008F666E File Offset: 0x008F486E
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnTouchMove.StaticFunctionPtr();
		}

		// Token: 0x0601D6ED RID: 120557 RVA: 0x008F667A File Offset: 0x008F487A
		private static IntPtr StaticFunctionPtr()
		{
			if (LGUIEventSystemActor_C.__OnTouchMove__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				LGUIEventSystemActor_C.__OnTouchMove__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnTouchMove__DelegateSignature");
			}
			return LGUIEventSystemActor_C.__OnTouchMove__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D6EE RID: 120558 RVA: 0x008F669D File Offset: 0x008F489D
		public OnTouchMove()
		{
		}

		// Token: 0x0601D6EF RID: 120559 RVA: 0x008F66A5 File Offset: 0x008F48A5
		[NullableContext(2)]
		public OnTouchMove(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D6F0 RID: 120560 RVA: 0x008F66AF File Offset: 0x008F48AF
		public OnTouchMove(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D6F1 RID: 120561 RVA: 0x008F66BA File Offset: 0x008F48BA
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int, FVector>) ?? ((Action<int, FVector>)Delegate.CreateDelegate(typeof(Action<int, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D6F2 RID: 120562 RVA: 0x008F66EC File Offset: 0x008F48EC
		[NullableContext(1)]
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

		// Token: 0x0601D6F3 RID: 120563 RVA: 0x008F6726 File Offset: 0x008F4926
		[NullableContext(1)]
		public void Remove(Action<int, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D6F4 RID: 120564 RVA: 0x008F6730 File Offset: 0x008F4930
		[SkipLocalsInit]
		public unsafe void Broadcast(int TouchID, FVector TouchPointPosition)
		{
			OnTouchMove.__OnTouchMove_DelegateParams* ptr = stackalloc OnTouchMove.__OnTouchMove_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(OnTouchMove.__OnTouchMove_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnTouchMove.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->TouchID = TouchID;
			ptr->TouchPointPosition = TouchPointPosition;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D6F5 RID: 120565 RVA: 0x008F6774 File Offset: 0x008F4974
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, FVector> action = target as Action<int, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnTouchMove.__OnTouchMove_DelegateParams*)__Parameters)->TouchID, ((OnTouchMove.__OnTouchMove_DelegateParams*)__Parameters)->TouchPointPosition);
		}

		// Token: 0x0400F7DE RID: 63454
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnTouchMove__DelegateSignature";

		// Token: 0x0400F7DF RID: 63455
		private static int RegisterId;

		// Token: 0x02008D0E RID: 36110
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __OnTouchMove_DelegateParams
		{
			// Token: 0x0402C85E RID: 182366
			[FieldOffset(0)]
			public int TouchID;

			// Token: 0x0402C85F RID: 182367
			[FieldOffset(4)]
			public FVector TouchPointPosition;
		}

		// Token: 0x02008D0F RID: 36111
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C860 RID: 182368
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
