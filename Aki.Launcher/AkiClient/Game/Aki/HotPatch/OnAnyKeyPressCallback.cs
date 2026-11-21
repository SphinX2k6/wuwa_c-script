using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.HotPatch
{
	// Token: 0x02000020 RID: 32
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnAnyKeyPressCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00008078 File Offset: 0x00006278
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnAnyKeyPressCallback.StaticFunctionPtr();
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00008084 File Offset: 0x00006284
		private static IntPtr StaticFunctionPtr()
		{
			if (TsHotFixActionHandle_C.__OnAnyKeyPressCallback__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				TsHotFixActionHandle_C.__OnAnyKeyPressCallback__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnAnyKeyPressCallback__DelegateSignature");
			}
			return TsHotFixActionHandle_C.__OnAnyKeyPressCallback__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000080A7 File Offset: 0x000062A7
		public OnAnyKeyPressCallback()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000080AF File Offset: 0x000062AF
		[NullableContext(2)]
		public OnAnyKeyPressCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000080B9 File Offset: 0x000062B9
		public OnAnyKeyPressCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000080C4 File Offset: 0x000062C4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FKey>) ?? ((Action<FKey>)Delegate.CreateDelegate(typeof(Action<FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000080F6 File Offset: 0x000062F6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FKey> Callback)
		{
			if (OnAnyKeyPressCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnAnyKeyPressCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnAnyKeyPressCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnAnyKeyPressCallback.OnScriptCallback));
				}
				OnAnyKeyPressCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnAnyKeyPressCallback.RegisterId);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00008130 File Offset: 0x00006330
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FKey> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000813C File Offset: 0x0000633C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FKey key)
		{
			OnAnyKeyPressCallback.__OnAnyKeyPressCallback_DelegateParams* ptr = stackalloc OnAnyKeyPressCallback.__OnAnyKeyPressCallback_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(OnAnyKeyPressCallback.__OnAnyKeyPressCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnAnyKeyPressCallback.StaticFunctionPtr(), (void*)ptr, 1);
			if (key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, key.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__OnAnyKeyPressCallback__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000081A4 File Offset: 0x000063A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FKey> action = target as Action<FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			FKey obj = new FKey(&((OnAnyKeyPressCallback.__OnAnyKeyPressCallback_DelegateParams*)__Parameters)->key, true, true);
			action(obj);
		}

		// Token: 0x04000077 RID: 119
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnAnyKeyPressCallback__DelegateSignature";

		// Token: 0x04000078 RID: 120
		private static int RegisterId;

		// Token: 0x02000298 RID: 664
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __OnAnyKeyPressCallback_DelegateParams
		{
			// Token: 0x04000A9E RID: 2718
			[FieldOffset(0)]
			public byte key;
		}

		// Token: 0x02000299 RID: 665
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000A9F RID: 2719
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
