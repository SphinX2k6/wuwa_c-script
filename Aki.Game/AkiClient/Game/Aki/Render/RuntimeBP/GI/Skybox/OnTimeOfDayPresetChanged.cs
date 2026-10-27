using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.Data.TOD;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.Skybox
{
	// Token: 0x02003D48 RID: 15688
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnTimeOfDayPresetChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060262B6 RID: 156342 RVA: 0x0096D122 File Offset: 0x0096B322
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnTimeOfDayPresetChanged.StaticFunctionPtr();
		}

		// Token: 0x060262B7 RID: 156343 RVA: 0x0096D12E File Offset: 0x0096B32E
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_SkyDome_C.__OnTimeOfDayPresetChanged__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_SkyDome_C.__OnTimeOfDayPresetChanged__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C:OnTimeOfDayPresetChanged__DelegateSignature");
			}
			return BP_SkyDome_C.__OnTimeOfDayPresetChanged__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060262B8 RID: 156344 RVA: 0x0096D151 File Offset: 0x0096B351
		public OnTimeOfDayPresetChanged()
		{
		}

		// Token: 0x060262B9 RID: 156345 RVA: 0x0096D159 File Offset: 0x0096B359
		[NullableContext(2)]
		public OnTimeOfDayPresetChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262BA RID: 156346 RVA: 0x0096D163 File Offset: 0x0096B363
		public OnTimeOfDayPresetChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262BB RID: 156347 RVA: 0x0096D16E File Offset: 0x0096B36E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as OnTimeOfDayPresetChanged.OnTimeOfDayPresetChanged_ScriptDelegate) ?? ((OnTimeOfDayPresetChanged.OnTimeOfDayPresetChanged_ScriptDelegate)Delegate.CreateDelegate(typeof(OnTimeOfDayPresetChanged.OnTimeOfDayPresetChanged_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060262BC RID: 156348 RVA: 0x0096D1A0 File Offset: 0x0096B3A0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(OnTimeOfDayPresetChanged.OnTimeOfDayPresetChanged_ScriptDelegate Callback)
		{
			if (OnTimeOfDayPresetChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnTimeOfDayPresetChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnTimeOfDayPresetChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnTimeOfDayPresetChanged.OnScriptCallback));
				}
				OnTimeOfDayPresetChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnTimeOfDayPresetChanged.RegisterId);
		}

		// Token: 0x060262BD RID: 156349 RVA: 0x0096D1DA File Offset: 0x0096B3DA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(OnTimeOfDayPresetChanged.OnTimeOfDayPresetChanged_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060262BE RID: 156350 RVA: 0x0096D1E4 File Offset: 0x0096B3E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<TimeOfDayPreset_C> Preset, float TransitionDuraion)
		{
			OnTimeOfDayPresetChanged.__OnTimeOfDayPresetChanged_DelegateParams* ptr = stackalloc OnTimeOfDayPresetChanged.__OnTimeOfDayPresetChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(OnTimeOfDayPresetChanged.__OnTimeOfDayPresetChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnTimeOfDayPresetChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Preset = Preset;
			ptr->TransitionDuraion = TransitionDuraion;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060262BF RID: 156351 RVA: 0x0096D228 File Offset: 0x0096B428
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			OnTimeOfDayPresetChanged.OnTimeOfDayPresetChanged_ScriptDelegate onTimeOfDayPresetChanged_ScriptDelegate = target as OnTimeOfDayPresetChanged.OnTimeOfDayPresetChanged_ScriptDelegate;
			if (onTimeOfDayPresetChanged_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			onTimeOfDayPresetChanged_ScriptDelegate(((OnTimeOfDayPresetChanged.__OnTimeOfDayPresetChanged_DelegateParams*)__Parameters)->Preset, ((OnTimeOfDayPresetChanged.__OnTimeOfDayPresetChanged_DelegateParams*)__Parameters)->TransitionDuraion);
		}

		// Token: 0x040131D2 RID: 78290
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C:OnTimeOfDayPresetChanged__DelegateSignature";

		// Token: 0x040131D3 RID: 78291
		private static int RegisterId;

		// Token: 0x0200A0A3 RID: 41123
		// (Invoke) Token: 0x0604C79E RID: 313246
		public delegate void OnTimeOfDayPresetChanged_ScriptDelegate([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<TimeOfDayPreset_C> Preset, float TransitionDuraion);

		// Token: 0x0200A0A4 RID: 41124
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnTimeOfDayPresetChanged_DelegateParams
		{
			// Token: 0x04031BA8 RID: 203688
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<TimeOfDayPreset_C> Preset;

			// Token: 0x04031BA9 RID: 203689
			[FieldOffset(8)]
			public float TransitionDuraion;
		}

		// Token: 0x0200A0A5 RID: 41125
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031BAA RID: 203690
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
