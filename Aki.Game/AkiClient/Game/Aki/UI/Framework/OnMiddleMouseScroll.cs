using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Framework
{
	// Token: 0x02003063 RID: 12387
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnMiddleMouseScroll : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601D6D8 RID: 120536 RVA: 0x008F63C2 File Offset: 0x008F45C2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnMiddleMouseScroll.StaticFunctionPtr();
		}

		// Token: 0x0601D6D9 RID: 120537 RVA: 0x008F63CE File Offset: 0x008F45CE
		private static IntPtr StaticFunctionPtr()
		{
			if (LGUIEventSystemActor_C.__OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				LGUIEventSystemActor_C.__OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnMiddleMouseScroll__DelegateSignature");
			}
			return LGUIEventSystemActor_C.__OnMiddleMouseScroll__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601D6DA RID: 120538 RVA: 0x008F63F1 File Offset: 0x008F45F1
		public OnMiddleMouseScroll()
		{
		}

		// Token: 0x0601D6DB RID: 120539 RVA: 0x008F63F9 File Offset: 0x008F45F9
		[NullableContext(2)]
		public OnMiddleMouseScroll(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D6DC RID: 120540 RVA: 0x008F6403 File Offset: 0x008F4603
		public OnMiddleMouseScroll(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D6DD RID: 120541 RVA: 0x008F640E File Offset: 0x008F460E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float>) ?? ((Action<float>)Delegate.CreateDelegate(typeof(Action<float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601D6DE RID: 120542 RVA: 0x008F6440 File Offset: 0x008F4640
		[NullableContext(1)]
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

		// Token: 0x0601D6DF RID: 120543 RVA: 0x008F647A File Offset: 0x008F467A
		[NullableContext(1)]
		public void Remove(Action<float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601D6E0 RID: 120544 RVA: 0x008F6484 File Offset: 0x008F4684
		[SkipLocalsInit]
		public unsafe void Broadcast(float AxisValue)
		{
			OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams* ptr = stackalloc OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnMiddleMouseScroll.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AxisValue = AxisValue;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601D6E1 RID: 120545 RVA: 0x008F64C0 File Offset: 0x008F46C0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float> action = target as Action<float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnMiddleMouseScroll.__OnMiddleMouseScroll_DelegateParams*)__Parameters)->AxisValue);
		}

		// Token: 0x0400F7DA RID: 63450
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Framework/LGUIEventSystemActor.LGUIEventSystemActor_C:OnMiddleMouseScroll__DelegateSignature";

		// Token: 0x0400F7DB RID: 63451
		private static int RegisterId;

		// Token: 0x02008D0A RID: 36106
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __OnMiddleMouseScroll_DelegateParams
		{
			// Token: 0x0402C858 RID: 182360
			[FieldOffset(0)]
			public float AxisValue;
		}

		// Token: 0x02008D0B RID: 36107
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C859 RID: 182361
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
