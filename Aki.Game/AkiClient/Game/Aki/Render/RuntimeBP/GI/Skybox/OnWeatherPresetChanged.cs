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
	// Token: 0x02003D49 RID: 15689
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class OnWeatherPresetChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060262C0 RID: 156352 RVA: 0x0096D278 File Offset: 0x0096B478
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return OnWeatherPresetChanged.StaticFunctionPtr();
		}

		// Token: 0x060262C1 RID: 156353 RVA: 0x0096D284 File Offset: 0x0096B484
		private static IntPtr StaticFunctionPtr()
		{
			if (BP_SkyDome_C.__OnWeatherPresetChanged__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				BP_SkyDome_C.__OnWeatherPresetChanged__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C:OnWeatherPresetChanged__DelegateSignature");
			}
			return BP_SkyDome_C.__OnWeatherPresetChanged__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x060262C2 RID: 156354 RVA: 0x0096D2A7 File Offset: 0x0096B4A7
		public OnWeatherPresetChanged()
		{
		}

		// Token: 0x060262C3 RID: 156355 RVA: 0x0096D2AF File Offset: 0x0096B4AF
		[NullableContext(2)]
		public OnWeatherPresetChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060262C4 RID: 156356 RVA: 0x0096D2B9 File Offset: 0x0096B4B9
		public OnWeatherPresetChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060262C5 RID: 156357 RVA: 0x0096D2C4 File Offset: 0x0096B4C4
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as OnWeatherPresetChanged.OnWeatherPresetChanged_ScriptDelegate) ?? ((OnWeatherPresetChanged.OnWeatherPresetChanged_ScriptDelegate)Delegate.CreateDelegate(typeof(OnWeatherPresetChanged.OnWeatherPresetChanged_ScriptDelegate), Callback.Target, Callback.Method)));
		}

		// Token: 0x060262C6 RID: 156358 RVA: 0x0096D2F6 File Offset: 0x0096B4F6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(OnWeatherPresetChanged.OnWeatherPresetChanged_ScriptDelegate Callback)
		{
			if (OnWeatherPresetChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = OnWeatherPresetChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (OnWeatherPresetChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(OnWeatherPresetChanged.OnScriptCallback));
				}
				OnWeatherPresetChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, OnWeatherPresetChanged.RegisterId);
		}

		// Token: 0x060262C7 RID: 156359 RVA: 0x0096D330 File Offset: 0x0096B530
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(OnWeatherPresetChanged.OnWeatherPresetChanged_ScriptDelegate Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060262C8 RID: 156360 RVA: 0x0096D33C File Offset: 0x0096B53C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<WeatherPreset_C> Preset, float TransitionDuration)
		{
			OnWeatherPresetChanged.__OnWeatherPresetChanged_DelegateParams* ptr = stackalloc OnWeatherPresetChanged.__OnWeatherPresetChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(OnWeatherPresetChanged.__OnWeatherPresetChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(OnWeatherPresetChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Preset = Preset;
			ptr->TransitionDuration = TransitionDuration;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060262C9 RID: 156361 RVA: 0x0096D380 File Offset: 0x0096B580
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			OnWeatherPresetChanged.OnWeatherPresetChanged_ScriptDelegate onWeatherPresetChanged_ScriptDelegate = target as OnWeatherPresetChanged.OnWeatherPresetChanged_ScriptDelegate;
			if (onWeatherPresetChanged_ScriptDelegate == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			onWeatherPresetChanged_ScriptDelegate(((OnWeatherPresetChanged.__OnWeatherPresetChanged_DelegateParams*)__Parameters)->Preset, ((OnWeatherPresetChanged.__OnWeatherPresetChanged_DelegateParams*)__Parameters)->TransitionDuration);
		}

		// Token: 0x040131D4 RID: 78292
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/Skybox/BP_SkyDome.BP_SkyDome_C:OnWeatherPresetChanged__DelegateSignature";

		// Token: 0x040131D5 RID: 78293
		private static int RegisterId;

		// Token: 0x0200A0A6 RID: 41126
		// (Invoke) Token: 0x0604C7A2 RID: 313250
		public delegate void OnWeatherPresetChanged_ScriptDelegate([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<WeatherPreset_C> Preset, float TransitionDuration);

		// Token: 0x0200A0A7 RID: 41127
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnWeatherPresetChanged_DelegateParams
		{
			// Token: 0x04031BAB RID: 203691
			[Nullable(new byte[]
			{
				0,
				1
			})]
			[FieldOffset(0)]
			public TSubclassOf<WeatherPreset_C> Preset;

			// Token: 0x04031BAC RID: 203692
			[FieldOffset(8)]
			public float TransitionDuration;
		}

		// Token: 0x0200A0A8 RID: 41128
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04031BAD RID: 203693
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
