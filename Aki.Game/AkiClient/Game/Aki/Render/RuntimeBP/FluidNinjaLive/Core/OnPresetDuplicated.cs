using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA0 RID: 15776
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnPresetDuplicated : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060272CC RID: 160460 RVA: 0x0098A072 File Offset: 0x00988272
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnPresetDuplicated.StaticFunctionPtr();
		}

		// Token: 0x060272CD RID: 160461 RVA: 0x0098A07E File Offset: 0x0098827E
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLiveGUI_C.__OnPresetDuplicated__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLiveGUI_C.__OnPresetDuplicated__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnPresetDuplicated__DelegateSignature");
			}
			return NinjaLiveGUI_C.__OnPresetDuplicated__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060272CE RID: 160462 RVA: 0x0098A0A1 File Offset: 0x009882A1
		public OnPresetDuplicated()
		{
		}

		// Token: 0x060272CF RID: 160463 RVA: 0x0098A0A9 File Offset: 0x009882A9
		[NullableContext(2)]
		public OnPresetDuplicated(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060272D0 RID: 160464 RVA: 0x0098A0B3 File Offset: 0x009882B3
		public OnPresetDuplicated(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060272D1 RID: 160465 RVA: 0x0098A0BE File Offset: 0x009882BE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UDataTable>) ?? ((Action<UDataTable>)Delegate.CreateDelegate(typeof(Action<UDataTable>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060272D2 RID: 160466 RVA: 0x0098A0F0 File Offset: 0x009882F0
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UDataTable> Callback)
		{
			if (OnPresetDuplicated.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnPresetDuplicated.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnPresetDuplicated.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnPresetDuplicated.OnScriptCallback));
				}
				OnPresetDuplicated.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnPresetDuplicated.RegisterId);
		}

		// Token: 0x060272D3 RID: 160467 RVA: 0x0098A12A File Offset: 0x0098832A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UDataTable> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060272D4 RID: 160468 RVA: 0x0098A134 File Offset: 0x00988334
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UDataTable DuplicatedPreset)
		{
			OnPresetDuplicated.__OnPresetDuplicated_DelegateParams* ptr = stackalloc OnPresetDuplicated.__OnPresetDuplicated_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(OnPresetDuplicated.__OnPresetDuplicated_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnPresetDuplicated.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DuplicatedPreset = ((DuplicatedPreset != null) ? DuplicatedPreset.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060272D5 RID: 160469 RVA: 0x0098A180 File Offset: 0x00988380
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UDataTable> action = target as Action<UDataTable>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UDataTable orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDataTable>(((OnPresetDuplicated.__OnPresetDuplicated_DelegateParams*)__Parameters)->DuplicatedPreset);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04013BFC RID: 80892
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnPresetDuplicated__DelegateSignature";

		// Token: 0x04013BFD RID: 80893
		private static int RegisterId;

		// Token: 0x0200A1EA RID: 41450
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnPresetDuplicated_DelegateParams
		{
			// Token: 0x04031E45 RID: 204357
			[FieldOffset(0)]
			public IntPtr DuplicatedPreset;
		}

		// Token: 0x0200A1EB RID: 41451
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031E46 RID: 204358
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
