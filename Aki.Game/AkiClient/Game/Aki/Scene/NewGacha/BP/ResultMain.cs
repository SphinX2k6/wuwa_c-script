using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Scene.NewGacha.BP
{
	// Token: 0x02003097 RID: 12439
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class ResultMain : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601DBB0 RID: 121776 RVA: 0x009004D2 File Offset: 0x008FE6D2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return ResultMain.StaticFunctionPtr();
		}

		// Token: 0x0601DBB1 RID: 121777 RVA: 0x009004DE File Offset: 0x008FE6DE
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_UpdateInteract_C.__ResultMain__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_UpdateInteract_C.__ResultMain__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMain__DelegateSignature");
			}
			return BP_UpdateInteract_C.__ResultMain__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0601DBB2 RID: 121778 RVA: 0x00900501 File Offset: 0x008FE701
		public ResultMain()
		{
		}

		// Token: 0x0601DBB3 RID: 121779 RVA: 0x00900509 File Offset: 0x008FE709
		[NullableContext(2)]
		public ResultMain(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601DBB4 RID: 121780 RVA: 0x00900513 File Offset: 0x008FE713
		public ResultMain(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601DBB5 RID: 121781 RVA: 0x0090051E File Offset: 0x008FE71E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<int>) ?? ((Action<int>)Delegate.CreateDelegate(typeof(Action<int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601DBB6 RID: 121782 RVA: 0x00900550 File Offset: 0x008FE750
		[NullableContext(1)]
		public void Add(Action<int> Callback)
		{
			if (ResultMain.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = ResultMain.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (ResultMain.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(ResultMain.OnScriptCallback));
				}
				ResultMain.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, ResultMain.RegisterId);
		}

		// Token: 0x0601DBB7 RID: 121783 RVA: 0x0090058A File Offset: 0x008FE78A
		[NullableContext(1)]
		public void Remove(Action<int> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0601DBB8 RID: 121784 RVA: 0x00900594 File Offset: 0x008FE794
		[SkipLocalsInit]
		public unsafe void Broadcast(int ID)
		{
			ResultMain.__ResultMain_DelegateParams* ptr = stackalloc ResultMain.__ResultMain_DelegateParams[(UIntPtr)19] + 15L / (long)sizeof(ResultMain.__ResultMain_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ResultMain.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ID = ID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0601DBB9 RID: 121785 RVA: 0x009005D0 File Offset: 0x008FE7D0
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int> action = target as Action<int>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((ResultMain.__ResultMain_DelegateParams*)__Parameters)->ID);
		}

		// Token: 0x0400FB01 RID: 64257
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Scene/NewGacha/BP/BP_UpdateInteract.BP_UpdateInteract_C:ResultMain__DelegateSignature";

		// Token: 0x0400FB02 RID: 64258
		private static int RegisterId;

		// Token: 0x02008D90 RID: 36240
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		private ref struct __ResultMain_DelegateParams
		{
			// Token: 0x0402C947 RID: 182599
			[FieldOffset(0)]
			public int ID;
		}

		// Token: 0x02008D91 RID: 36241
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402C948 RID: 182600
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
