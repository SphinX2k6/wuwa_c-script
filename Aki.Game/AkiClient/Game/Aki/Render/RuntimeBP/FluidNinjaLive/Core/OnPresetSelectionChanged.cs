using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA2 RID: 15778
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnPresetSelectionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060272E0 RID: 160480 RVA: 0x0098A363 File Offset: 0x00988563
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnPresetSelectionChanged.StaticFunctionPtr();
		}

		// Token: 0x060272E1 RID: 160481 RVA: 0x0098A36F File Offset: 0x0098856F
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLiveGUI_C.__OnPresetSelectionChanged__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLiveGUI_C.__OnPresetSelectionChanged__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnPresetSelectionChanged__DelegateSignature");
			}
			return NinjaLiveGUI_C.__OnPresetSelectionChanged__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060272E2 RID: 160482 RVA: 0x0098A392 File Offset: 0x00988592
		public OnPresetSelectionChanged()
		{
		}

		// Token: 0x060272E3 RID: 160483 RVA: 0x0098A39A File Offset: 0x0098859A
		[NullableContext(2)]
		public OnPresetSelectionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060272E4 RID: 160484 RVA: 0x0098A3A4 File Offset: 0x009885A4
		public OnPresetSelectionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060272E5 RID: 160485 RVA: 0x0098A3AF File Offset: 0x009885AF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, bool>) ?? ((Action<string, bool>)Delegate.CreateDelegate(typeof(Action<string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060272E6 RID: 160486 RVA: 0x0098A3E1 File Offset: 0x009885E1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string, bool> Callback)
		{
			if (OnPresetSelectionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnPresetSelectionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnPresetSelectionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnPresetSelectionChanged.OnScriptCallback));
				}
				OnPresetSelectionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnPresetSelectionChanged.RegisterId);
		}

		// Token: 0x060272E7 RID: 160487 RVA: 0x0098A41B File Offset: 0x0098861B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060272E8 RID: 160488 RVA: 0x0098A424 File Offset: 0x00988624
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string SelectedPreset, bool ForceAutoLoadPreset)
		{
			OnPresetSelectionChanged.__OnPresetSelectionChanged_DelegateParams* ptr = stackalloc OnPresetSelectionChanged.__OnPresetSelectionChanged_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(OnPresetSelectionChanged.__OnPresetSelectionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnPresetSelectionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedPreset), SelectedPreset);
			ptr->ForceAutoLoadPreset = ForceAutoLoadPreset;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__OnPresetSelectionChanged__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060272E9 RID: 160489 RVA: 0x0098A480 File Offset: 0x00988680
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, bool> action = target as Action<string, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((OnPresetSelectionChanged.__OnPresetSelectionChanged_DelegateParams*)__Parameters)->SelectedPreset));
			action(arg, ((OnPresetSelectionChanged.__OnPresetSelectionChanged_DelegateParams*)__Parameters)->ForceAutoLoadPreset);
		}

		// Token: 0x04013C00 RID: 80896
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnPresetSelectionChanged__DelegateSignature";

		// Token: 0x04013C01 RID: 80897
		private static int RegisterId;

		// Token: 0x0200A1EE RID: 41454
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnPresetSelectionChanged_DelegateParams
		{
			// Token: 0x04031E4B RID: 204363
			[FieldOffset(0)]
			public FString SelectedPreset;

			// Token: 0x04031E4C RID: 204364
			[FieldOffset(16)]
			public bool ForceAutoLoadPreset;
		}

		// Token: 0x0200A1EF RID: 41455
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031E4D RID: 204365
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
