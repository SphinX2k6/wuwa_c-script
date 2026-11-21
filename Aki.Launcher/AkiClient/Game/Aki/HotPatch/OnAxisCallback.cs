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
		// Token: 0x0600010B RID: 267 RVA: 0x000081F8 File Offset: 0x000063F8
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnAxisCallback.StaticFunctionPtr();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00008204 File Offset: 0x00006404
		private static IntPtr StaticFunctionPtr()
		{
			if (TsHotFixActionHandle_C.__OnAxisCallback__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				TsHotFixActionHandle_C.__OnAxisCallback__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnAxisCallback__DelegateSignature");
			}
			return TsHotFixActionHandle_C.__OnAxisCallback__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00008227 File Offset: 0x00006427
		public OnAxisCallback()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000822F File Offset: 0x0000642F
		[NullableContext(2)]
		public OnAxisCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00008239 File Offset: 0x00006439
		public OnAxisCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008244 File Offset: 0x00006444
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<float, string>) ?? ((Action<float, string>)Delegate.CreateDelegate(typeof(Action<float, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00008276 File Offset: 0x00006476
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

		// Token: 0x06000112 RID: 274 RVA: 0x000082B0 File Offset: 0x000064B0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<float, string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000082BC File Offset: 0x000064BC
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

		// Token: 0x06000114 RID: 276 RVA: 0x00008318 File Offset: 0x00006518
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

		// Token: 0x04000079 RID: 121
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnAxisCallback__DelegateSignature";

		// Token: 0x0400007A RID: 122
		private static int RegisterId;

		// Token: 0x0200029A RID: 666
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnAxisCallback_DelegateParams
		{
			// Token: 0x04000AA0 RID: 2720
			[FieldOffset(0)]
			public float value;

			// Token: 0x04000AA1 RID: 2721
			[FieldOffset(8)]
			public FString axisName;
		}

		// Token: 0x0200029B RID: 667
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000AA2 RID: 2722
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
