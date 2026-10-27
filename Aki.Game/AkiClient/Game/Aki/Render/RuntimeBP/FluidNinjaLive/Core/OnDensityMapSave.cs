using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003D9F RID: 15775
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnDensityMapSave : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060272C2 RID: 160450 RVA: 0x00989F29 File Offset: 0x00988129
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnDensityMapSave.StaticFunctionPtr();
		}

		// Token: 0x060272C3 RID: 160451 RVA: 0x00989F35 File Offset: 0x00988135
		private static IntPtr StaticFunctionPtr()
		{
			if (NinjaLiveGUI_C.__OnDensityMapSave__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				NinjaLiveGUI_C.__OnDensityMapSave__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnDensityMapSave__DelegateSignature");
			}
			return NinjaLiveGUI_C.__OnDensityMapSave__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060272C4 RID: 160452 RVA: 0x00989F58 File Offset: 0x00988158
		public OnDensityMapSave()
		{
		}

		// Token: 0x060272C5 RID: 160453 RVA: 0x00989F60 File Offset: 0x00988160
		[NullableContext(2)]
		public OnDensityMapSave(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060272C6 RID: 160454 RVA: 0x00989F6A File Offset: 0x0098816A
		public OnDensityMapSave(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060272C7 RID: 160455 RVA: 0x00989F75 File Offset: 0x00988175
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060272C8 RID: 160456 RVA: 0x00989FA7 File Offset: 0x009881A7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (OnDensityMapSave.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnDensityMapSave.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnDensityMapSave.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnDensityMapSave.OnScriptCallback));
				}
				OnDensityMapSave.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnDensityMapSave.RegisterId);
		}

		// Token: 0x060272C9 RID: 160457 RVA: 0x00989FE1 File Offset: 0x009881E1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060272CA RID: 160458 RVA: 0x00989FEC File Offset: 0x009881EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool SavePaintBuffer)
		{
			OnDensityMapSave.__OnDensityMapSave_DelegateParams* ptr = stackalloc OnDensityMapSave.__OnDensityMapSave_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(OnDensityMapSave.__OnDensityMapSave_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnDensityMapSave.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->SavePaintBuffer = SavePaintBuffer;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060272CB RID: 160459 RVA: 0x0098A028 File Offset: 0x00988228
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((OnDensityMapSave.__OnDensityMapSave_DelegateParams*)__Parameters)->SavePaintBuffer);
		}

		// Token: 0x04013BFA RID: 80890
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/NinjaLiveGUI.NinjaLiveGUI_C:OnDensityMapSave__DelegateSignature";

		// Token: 0x04013BFB RID: 80891
		private static int RegisterId;

		// Token: 0x0200A1E8 RID: 41448
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnDensityMapSave_DelegateParams
		{
			// Token: 0x04031E43 RID: 204355
			[FieldOffset(0)]
			public bool SavePaintBuffer;
		}

		// Token: 0x0200A1E9 RID: 41449
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031E44 RID: 204356
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
