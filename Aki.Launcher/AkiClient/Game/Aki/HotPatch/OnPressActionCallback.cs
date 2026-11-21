using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.HotPatch
{
	// Token: 0x02000022 RID: 34
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnPressActionCallback : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06000115 RID: 277 RVA: 0x00008370 File Offset: 0x00006570
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnPressActionCallback.StaticFunctionPtr();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000837C File Offset: 0x0000657C
		private static IntPtr StaticFunctionPtr()
		{
			if (TsHotFixActionHandle_C.__OnPressActionCallback__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				TsHotFixActionHandle_C.__OnPressActionCallback__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnPressActionCallback__DelegateSignature");
			}
			return TsHotFixActionHandle_C.__OnPressActionCallback__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000839F File Offset: 0x0000659F
		public OnPressActionCallback()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000083A7 File Offset: 0x000065A7
		[NullableContext(2)]
		public OnPressActionCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000083B1 File Offset: 0x000065B1
		public OnPressActionCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000083BC File Offset: 0x000065BC
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, string, FKey>) ?? ((Action<bool, string, FKey>)Delegate.CreateDelegate(typeof(Action<bool, string, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000083EE File Offset: 0x000065EE
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool, string, FKey> Callback)
		{
			if (OnPressActionCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnPressActionCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnPressActionCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnPressActionCallback.OnScriptCallback));
				}
				OnPressActionCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnPressActionCallback.RegisterId);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00008428 File Offset: 0x00006628
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, string, FKey> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00008434 File Offset: 0x00006634
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool isPress, string actionName, [Nullable(2)] FKey key)
		{
			OnPressActionCallback.__OnPressActionCallback_DelegateParams* ptr = stackalloc OnPressActionCallback.__OnPressActionCallback_DelegateParams[(UIntPtr)71] + 15L / (long)sizeof(OnPressActionCallback.__OnPressActionCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnPressActionCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->isPress = isPress;
			FString.CopyFrom((void*)(&ptr->actionName), actionName);
			if (key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->key, key.NativePtr, 1, false);
			}
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(TsHotFixActionHandle_C.__OnPressActionCallback__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000084B0 File Offset: 0x000066B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool, string, FKey> action = target as Action<bool, string, FKey>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((OnPressActionCallback.__OnPressActionCallback_DelegateParams*)__Parameters)->actionName));
			FKey arg2 = new FKey(&((OnPressActionCallback.__OnPressActionCallback_DelegateParams*)__Parameters)->key, true, true);
			action(((OnPressActionCallback.__OnPressActionCallback_DelegateParams*)__Parameters)->isPress, arg, arg2);
		}

		// Token: 0x0400007B RID: 123
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnPressActionCallback__DelegateSignature";

		// Token: 0x0400007C RID: 124
		private static int RegisterId;

		// Token: 0x0200029C RID: 668
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __OnPressActionCallback_DelegateParams
		{
			// Token: 0x04000AA3 RID: 2723
			[FieldOffset(0)]
			public bool isPress;

			// Token: 0x04000AA4 RID: 2724
			[FieldOffset(8)]
			public FString actionName;

			// Token: 0x04000AA5 RID: 2725
			[FieldOffset(24)]
			public byte key;
		}

		// Token: 0x0200029D RID: 669
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000AA6 RID: 2726
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
