using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.HotPatch
{
	// Token: 0x02000021 RID: 33
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnAxisCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600010B RID: 267 RVA: 0x000081C0 File Offset: 0x000063C0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnAxisCallback.StaticFunctionPtr();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000081CC File Offset: 0x000063CC
		private static IntPtr StaticFunctionPtr()
		{
			if (TsHotFixActionHandle_C.__OnAxisCallback__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				TsHotFixActionHandle_C.__OnAxisCallback__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnAxisCallback__DelegateSignature");
			}
			return TsHotFixActionHandle_C.__OnAxisCallback__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000081EF File Offset: 0x000063EF
		public OnAxisCallback()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000081F7 File Offset: 0x000063F7
		[NullableContext(2)]
		public OnAxisCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008201 File Offset: 0x00006401
		public OnAxisCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000820C File Offset: 0x0000640C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, string>) ?? ((Action<float, string>)Delegate.CreateDelegate(typeof(Action<float, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000823E File Offset: 0x0000643E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<float, string> Callback)
		{
			if (OnAxisCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnAxisCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnAxisCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnAxisCallback.OnScriptCallback));
				}
				OnAxisCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnAxisCallback.RegisterId);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00008278 File Offset: 0x00006478
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00008284 File Offset: 0x00006484
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(float value, string axisName)
		{
			OnAxisCallback.__OnAxisCallback_DelegateParams* ptr = stackalloc OnAxisCallback.__OnAxisCallback_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(OnAxisCallback.__OnAxisCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnAxisCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			FString.CopyFrom((void*)(&ptr->axisName), axisName);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__OnAxisCallback__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000082E0 File Offset: 0x000064E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<float, string> action = target as Action<float, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((OnAxisCallback.__OnAxisCallback_DelegateParams*)__Parameters)->axisName));
			action(((OnAxisCallback.__OnAxisCallback_DelegateParams*)__Parameters)->value, arg);
		}

		// Token: 0x04000078 RID: 120
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnAxisCallback__DelegateSignature";

		// Token: 0x04000079 RID: 121
		private static int RegisterId;

		// Token: 0x02000291 RID: 657
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnAxisCallback_DelegateParams
		{
			// Token: 0x04000A50 RID: 2640
			[FieldOffset(0)]
			public float value;

			// Token: 0x04000A51 RID: 2641
			[FieldOffset(8)]
			public FString axisName;
		}

		// Token: 0x02000292 RID: 658
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000A52 RID: 2642
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
