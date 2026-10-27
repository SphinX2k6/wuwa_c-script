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
		// Token: 0x06000115 RID: 277 RVA: 0x00008338 File Offset: 0x00006538
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnPressActionCallback.StaticFunctionPtr();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00008344 File Offset: 0x00006544
		private static IntPtr StaticFunctionPtr()
		{
			if (TsHotFixActionHandle_C.__OnPressActionCallback__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				TsHotFixActionHandle_C.__OnPressActionCallback__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnPressActionCallback__DelegateSignature");
			}
			return TsHotFixActionHandle_C.__OnPressActionCallback__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00008367 File Offset: 0x00006567
		public OnPressActionCallback()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000836F File Offset: 0x0000656F
		[NullableContext(2)]
		public OnPressActionCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008379 File Offset: 0x00006579
		public OnPressActionCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008384 File Offset: 0x00006584
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool, string, FKey>) ?? ((Action<bool, string, FKey>)Delegate.CreateDelegate(typeof(Action<bool, string, FKey>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000083B6 File Offset: 0x000065B6
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

		// Token: 0x0600011C RID: 284 RVA: 0x000083F0 File Offset: 0x000065F0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool, string, FKey> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000083FC File Offset: 0x000065FC
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

		// Token: 0x0600011E RID: 286 RVA: 0x00008478 File Offset: 0x00006678
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

		// Token: 0x0400007A RID: 122
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/HotPatch/TsHotFixActionHandle.TsHotFixActionHandle_C:OnPressActionCallback__DelegateSignature";

		// Token: 0x0400007B RID: 123
		private static int RegisterId;

		// Token: 0x02000293 RID: 659
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __OnPressActionCallback_DelegateParams
		{
			// Token: 0x04000A53 RID: 2643
			[FieldOffset(0)]
			public bool isPress;

			// Token: 0x04000A54 RID: 2644
			[FieldOffset(8)]
			public FString actionName;

			// Token: 0x04000A55 RID: 2645
			[FieldOffset(24)]
			public byte key;
		}

		// Token: 0x02000294 RID: 660
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000A56 RID: 2646
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
