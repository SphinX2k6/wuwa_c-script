using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DA1 RID: 15777
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnPresetSave : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060272D6 RID: 160470 RVA: 0x0098A1D1 File Offset: 0x009883D1
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnPresetSave.StaticFunctionPtr();
		}

		// Token: 0x060272D7 RID: 160471 RVA: 0x0098A1DD File Offset: 0x009883DD
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLiveGUI_C.__OnPresetSave__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLiveGUI_C.__OnPresetSave__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnPresetSave__DelegateSignature");
			}
			return NinjaLiveGUI_C.__OnPresetSave__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060272D8 RID: 160472 RVA: 0x0098A200 File Offset: 0x00988400
		public OnPresetSave()
		{
		}

		// Token: 0x060272D9 RID: 160473 RVA: 0x0098A208 File Offset: 0x00988408
		[NullableContext(2)]
		public OnPresetSave(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060272DA RID: 160474 RVA: 0x0098A212 File Offset: 0x00988412
		public OnPresetSave(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060272DB RID: 160475 RVA: 0x0098A21D File Offset: 0x0098841D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string, string, bool>) ?? ((Action<string, string, bool>)Delegate.CreateDelegate(typeof(Action<string, string, bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060272DC RID: 160476 RVA: 0x0098A24F File Offset: 0x0098844F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string, string, bool> Callback)
		{
			if (OnPresetSave.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnPresetSave.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnPresetSave.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnPresetSave.OnScriptCallback));
				}
				OnPresetSave.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnPresetSave.RegisterId);
		}

		// Token: 0x060272DD RID: 160477 RVA: 0x0098A289 File Offset: 0x00988489
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string, string, bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060272DE RID: 160478 RVA: 0x0098A294 File Offset: 0x00988494
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string SelectedProject, string SelectedPreset, bool OverWriteOrNot)
		{
			OnPresetSave.__OnPresetSave_DelegateParams* ptr = stackalloc OnPresetSave.__OnPresetSave_DelegateParams[(UIntPtr)55] + 15L / (long)sizeof(OnPresetSave.__OnPresetSave_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnPresetSave.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->SelectedProject), SelectedProject);
			FString.CopyFrom((void*)(&ptr->SelectedPreset), SelectedPreset);
			ptr->OverWriteOrNot = OverWriteOrNot;
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(NinjaLiveGUI_C.__OnPresetSave__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060272DF RID: 160479 RVA: 0x0098A2FC File Offset: 0x009884FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string, string, bool> action = target as Action<string, string, bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((OnPresetSave.__OnPresetSave_DelegateParams*)__Parameters)->SelectedProject));
			string arg2 = FString.ToString((void*)(&((OnPresetSave.__OnPresetSave_DelegateParams*)__Parameters)->SelectedPreset));
			action(arg, arg2, ((OnPresetSave.__OnPresetSave_DelegateParams*)__Parameters)->OverWriteOrNot);
		}

		// Token: 0x04013BFE RID: 80894
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnPresetSave__DelegateSignature";

		// Token: 0x04013BFF RID: 80895
		private static int RegisterId;

		// Token: 0x0200A1EC RID: 41452
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnPresetSave_DelegateParams
		{
			// Token: 0x04031E47 RID: 204359
			[FieldOffset(0)]
			public FString SelectedProject;

			// Token: 0x04031E48 RID: 204360
			[FieldOffset(16)]
			public FString SelectedPreset;

			// Token: 0x04031E49 RID: 204361
			[FieldOffset(32)]
			public bool OverWriteOrNot;
		}

		// Token: 0x0200A1ED RID: 41453
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031E4A RID: 204362
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
