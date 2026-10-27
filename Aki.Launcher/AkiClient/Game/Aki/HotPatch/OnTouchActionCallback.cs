using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.HotPatch
{
	// Token: 0x02000023 RID: 35
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnTouchActionCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600011F RID: 287 RVA: 0x000084E1 File Offset: 0x000066E1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnTouchActionCallback.StaticFunctionPtr();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000084ED File Offset: 0x000066ED
		private static IntPtr StaticFunctionPtr()
		{
			if (TsHotFixActionHandle_C.__OnTouchActionCallback__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				TsHotFixActionHandle_C.__OnTouchActionCallback__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnTouchActionCallback__DelegateSignature");
			}
			return TsHotFixActionHandle_C.__OnTouchActionCallback__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008510 File Offset: 0x00006710
		public OnTouchActionCallback()
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008518 File Offset: 0x00006718
		[NullableContext(2)]
		public OnTouchActionCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00008522 File Offset: 0x00006722
		public OnTouchActionCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000852D File Offset: 0x0000672D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, TEnumAsByte<ETouchIndex>, FVector>) ?? ((Action<bool, TEnumAsByte<ETouchIndex>, FVector>)Delegate.CreateDelegate(typeof(Action<bool, TEnumAsByte<ETouchIndex>, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000855F File Offset: 0x0000675F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0
		})] Action<bool, TEnumAsByte<ETouchIndex>, FVector> Callback)
		{
			if (OnTouchActionCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnTouchActionCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnTouchActionCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnTouchActionCallback.OnScriptCallback));
				}
				OnTouchActionCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnTouchActionCallback.RegisterId);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008599 File Offset: 0x00006799
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0
		})] Action<bool, TEnumAsByte<ETouchIndex>, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000085A4 File Offset: 0x000067A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool isPress, ETouchIndex TouchIndex, FVector TouchPosition)
		{
			OnTouchActionCallback.__OnTouchActionCallback_DelegateParams* ptr = stackalloc OnTouchActionCallback.__OnTouchActionCallback_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(OnTouchActionCallback.__OnTouchActionCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnTouchActionCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->isPress = isPress;
			ptr->TouchIndex = TouchIndex;
			ptr->TouchPosition = TouchPosition;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000085F4 File Offset: 0x000067F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, TEnumAsByte<ETouchIndex>, FVector> action = target as Action<bool, TEnumAsByte<ETouchIndex>, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnTouchActionCallback.__OnTouchActionCallback_DelegateParams*)__Parameters)->isPress, ((OnTouchActionCallback.__OnTouchActionCallback_DelegateParams*)__Parameters)->TouchIndex, ((OnTouchActionCallback.__OnTouchActionCallback_DelegateParams*)__Parameters)->TouchPosition);
		}

		// Token: 0x0400007C RID: 124
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnTouchActionCallback__DelegateSignature";

		// Token: 0x0400007D RID: 125
		private static int RegisterId;

		// Token: 0x02000295 RID: 661
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchActionCallback_DelegateParams
		{
			// Token: 0x04000A57 RID: 2647
			[FieldOffset(0)]
			public bool isPress;

			// Token: 0x04000A58 RID: 2648
			[FieldOffset(1)]
			public TEnumAsByte<ETouchIndex> TouchIndex;

			// Token: 0x04000A59 RID: 2649
			[FieldOffset(4)]
			public FVector TouchPosition;
		}

		// Token: 0x02000296 RID: 662
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000A5A RID: 2650
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
