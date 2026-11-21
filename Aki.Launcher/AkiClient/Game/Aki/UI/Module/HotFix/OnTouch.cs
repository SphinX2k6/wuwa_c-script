using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.HotFix
{
	// Token: 0x0200001E RID: 30
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnTouch : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00007DBE File Offset: 0x00005FBE
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnTouch.StaticFunctionPtr();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007DCA File Offset: 0x00005FCA
		private static IntPtr StaticFunctionPtr()
		{
			if (HotFixLGUIEventSystemActor_C.__OnTouch__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				HotFixLGUIEventSystemActor_C.__OnTouch__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C:OnTouch__DelegateSignature");
			}
			return HotFixLGUIEventSystemActor_C.__OnTouch__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007DED File Offset: 0x00005FED
		public OnTouch()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00007DF5 File Offset: 0x00005FF5
		[NullableContext(2)]
		public OnTouch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007DFF File Offset: 0x00005FFF
		public OnTouch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007E0A File Offset: 0x0000600A
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, int, FVector>) ?? ((Action<bool, int, FVector>)Delegate.CreateDelegate(typeof(Action<bool, int, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00007E3C File Offset: 0x0000603C
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

		// Token: 0x060000F4 RID: 244 RVA: 0x00007E76 File Offset: 0x00006076
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, int, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007E80 File Offset: 0x00006080
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

		// Token: 0x060000F6 RID: 246 RVA: 0x00007ECC File Offset: 0x000060CC
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

		// Token: 0x04000073 RID: 115
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/UI/Module/HotFix/HotFixLGUIEventSystemActor.HotFixLGUIEventSystemActor_C:OnTouch__DelegateSignature";

		// Token: 0x04000074 RID: 116
		private static int RegisterId;

		// Token: 0x02000294 RID: 660
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __OnTouch_DelegateParams
		{
			// Token: 0x04000A97 RID: 2711
			[FieldOffset(0)]
			public bool TouchPress;

			// Token: 0x04000A98 RID: 2712
			[FieldOffset(4)]
			public int TouchID;

			// Token: 0x04000A99 RID: 2713
			[FieldOffset(8)]
			public FVector TouchPointPosition;
		}

		// Token: 0x02000295 RID: 661
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000A9A RID: 2714
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
