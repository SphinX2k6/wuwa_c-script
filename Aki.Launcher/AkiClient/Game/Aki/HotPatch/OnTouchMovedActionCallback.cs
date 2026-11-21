using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.HotPatch
{
	// Token: 0x02000024 RID: 36
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnTouchMovedActionCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00008682 File Offset: 0x00006882
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnTouchMovedActionCallback.StaticFunctionPtr();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000868E File Offset: 0x0000688E
		private static IntPtr StaticFunctionPtr()
		{
			if (TsHotFixActionHandle_C.__OnTouchMovedActionCallback__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				TsHotFixActionHandle_C.__OnTouchMovedActionCallback__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnTouchMovedActionCallback__DelegateSignature");
			}
			return TsHotFixActionHandle_C.__OnTouchMovedActionCallback__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000086B1 File Offset: 0x000068B1
		public OnTouchMovedActionCallback()
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000086B9 File Offset: 0x000068B9
		[NullableContext(2)]
		public OnTouchMovedActionCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000086C3 File Offset: 0x000068C3
		public OnTouchMovedActionCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000086CE File Offset: 0x000068CE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<TEnumAsByte<ETouchIndex>, FVector>) ?? ((Action<TEnumAsByte<ETouchIndex>, FVector>)Delegate.CreateDelegate(typeof(Action<TEnumAsByte<ETouchIndex>, FVector>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008700 File Offset: 0x00006900
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<ETouchIndex>, FVector> Callback)
		{
			if (OnTouchMovedActionCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnTouchMovedActionCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnTouchMovedActionCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnTouchMovedActionCallback.OnScriptCallback));
				}
				OnTouchMovedActionCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnTouchMovedActionCallback.RegisterId);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000873A File Offset: 0x0000693A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			0
		})] Action<TEnumAsByte<ETouchIndex>, FVector> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00008744 File Offset: 0x00006944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ETouchIndex touchIndex, FVector TouchPosition)
		{
			OnTouchMovedActionCallback.__OnTouchMovedActionCallback_DelegateParams* ptr = stackalloc OnTouchMovedActionCallback.__OnTouchMovedActionCallback_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(OnTouchMovedActionCallback.__OnTouchMovedActionCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnTouchMovedActionCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->touchIndex = touchIndex;
			ptr->TouchPosition = TouchPosition;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000878C File Offset: 0x0000698C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<TEnumAsByte<ETouchIndex>, FVector> action = target as Action<TEnumAsByte<ETouchIndex>, FVector>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnTouchMovedActionCallback.__OnTouchMovedActionCallback_DelegateParams*)__Parameters)->touchIndex, ((OnTouchMovedActionCallback.__OnTouchMovedActionCallback_DelegateParams*)__Parameters)->TouchPosition);
		}

		// Token: 0x0400007F RID: 127
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnTouchMovedActionCallback__DelegateSignature";

		// Token: 0x04000080 RID: 128
		private static int RegisterId;

		// Token: 0x020002A0 RID: 672
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTouchMovedActionCallback_DelegateParams
		{
			// Token: 0x04000AAB RID: 2731
			[FieldOffset(0)]
			public TEnumAsByte<ETouchIndex> touchIndex;

			// Token: 0x04000AAC RID: 2732
			[FieldOffset(4)]
			public FVector TouchPosition;
		}

		// Token: 0x020002A1 RID: 673
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000AAD RID: 2733
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
