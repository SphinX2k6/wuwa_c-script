using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Core
{
	// Token: 0x02003DAB RID: 15787
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/Viewport_LightRotatorWidget.Viewport_LightRotatorWidget_C")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class Viewport_LightRotatorWidget_C : UUserWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027300 RID: 160512 RVA: 0x0098A71D File Offset: 0x0098891D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Viewport_LightRotatorWidget_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/Viewport_LightRotatorWidget.Viewport_LightRotatorWidget_C");
			}
			return Viewport_LightRotatorWidget_C._ClassPtr;
		}

		// Token: 0x06027301 RID: 160513 RVA: 0x0098A744 File Offset: 0x00988944
		public Viewport_LightRotatorWidget_C() : this(BuiltinUtils.AllocNativeUObject(Viewport_LightRotatorWidget_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027302 RID: 160514 RVA: 0x0098A76C File Offset: 0x0098896C
		[NullableContext(1)]
		public Viewport_LightRotatorWidget_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Viewport_LightRotatorWidget_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170056B6 RID: 22198
		// (get) Token: 0x06027303 RID: 160515 RVA: 0x0098A79F File Offset: 0x0098899F
		// (set) Token: 0x06027304 RID: 160516 RVA: 0x0098A7B3 File Offset: 0x009889B3
		public unsafe USlider Slider_Camera
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlider>(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170056B7 RID: 22199
		// (get) Token: 0x06027305 RID: 160517 RVA: 0x0098A7C8 File Offset: 0x009889C8
		// (set) Token: 0x06027306 RID: 160518 RVA: 0x0098A7DC File Offset: 0x009889DC
		public unsafe USlider Slider_LightAngle1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlider>(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170056B8 RID: 22200
		// (get) Token: 0x06027307 RID: 160519 RVA: 0x0098A7F1 File Offset: 0x009889F1
		// (set) Token: 0x06027308 RID: 160520 RVA: 0x0098A805 File Offset: 0x00988A05
		public unsafe USlider Slider_LightAngle2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlider>(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170056B9 RID: 22201
		// (get) Token: 0x06027309 RID: 160521 RVA: 0x0098A81A File Offset: 0x00988A1A
		// (set) Token: 0x0602730A RID: 160522 RVA: 0x0098A82E File Offset: 0x00988A2E
		public unsafe USlider Slider_LightIntensity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlider>(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170056BA RID: 22202
		// (get) Token: 0x0602730B RID: 160523 RVA: 0x0098A843 File Offset: 0x00988A43
		// (set) Token: 0x0602730C RID: 160524 RVA: 0x0098A857 File Offset: 0x00988A57
		public unsafe FRotator InitialLightRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Viewport_LightRotatorWidget_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Viewport_LightRotatorWidget_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170056BB RID: 22203
		// (get) Token: 0x0602730D RID: 160525 RVA: 0x0098A86C File Offset: 0x00988A6C
		// (set) Token: 0x0602730E RID: 160526 RVA: 0x0098A880 File Offset: 0x00988A80
		public unsafe ADirectionalLight DirectionalLight
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADirectionalLight>(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Viewport_LightRotatorWidget_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x0602730F RID: 160527 RVA: 0x0098A898 File Offset: 0x00988A98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void PreConstruct(bool IsDesignTime)
		{
			Viewport_LightRotatorWidget_C.__PreConstruct_FunctionParams* ptr = stackalloc Viewport_LightRotatorWidget_C.__PreConstruct_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(Viewport_LightRotatorWidget_C.__PreConstruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Viewport_LightRotatorWidget_C.__PreConstruct_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDesignTime = IsDesignTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Viewport_LightRotatorWidget_C.__PreConstruct_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027310 RID: 160528 RVA: 0x0098A8E0 File Offset: 0x00988AE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void PreConstruct_Implementation(bool IsDesignTime)
		{
			Viewport_LightRotatorWidget_C.__PreConstruct_FunctionParams* ptr = stackalloc Viewport_LightRotatorWidget_C.__PreConstruct_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(Viewport_LightRotatorWidget_C.__PreConstruct_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Viewport_LightRotatorWidget_C.__PreConstruct_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDesignTime = IsDesignTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Viewport_LightRotatorWidget_C.__PreConstruct_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027311 RID: 160529 RVA: 0x0098A928 File Offset: 0x00988B28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			Viewport_LightRotatorWidget_C.__Tick_FunctionParams* ptr = stackalloc Viewport_LightRotatorWidget_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(Viewport_LightRotatorWidget_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Viewport_LightRotatorWidget_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Viewport_LightRotatorWidget_C.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027312 RID: 160530 RVA: 0x0098A990 File Offset: 0x00988B90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void Tick_Implementation(FGeometry MyGeometry, float InDeltaTime)
		{
			Viewport_LightRotatorWidget_C.__Tick_FunctionParams* ptr = stackalloc Viewport_LightRotatorWidget_C.__Tick_FunctionParams[(UIntPtr)75] + 15L / (long)sizeof(Viewport_LightRotatorWidget_C.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Viewport_LightRotatorWidget_C.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			if (MyGeometry != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGeometry.StaticStruct(), &ptr->MyGeometry, MyGeometry.NativePtr, 1, false);
			}
			ptr->InDeltaTime = InDeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Viewport_LightRotatorWidget_C.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027313 RID: 160531 RVA: 0x0098A9FC File Offset: 0x00988BFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__Slider_1_K2Node_ComponentBoundEvent_0_OnFloatValueChangedEvent__DelegateSignature(float Value)
		{
			Viewport_LightRotatorWidget_C.__BndEvt__Slider_1_K2Node_ComponentBoundEvent_0_OnFloatValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc Viewport_LightRotatorWidget_C.__BndEvt__Slider_1_K2Node_ComponentBoundEvent_0_OnFloatValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Viewport_LightRotatorWidget_C.__BndEvt__Slider_1_K2Node_ComponentBoundEvent_0_OnFloatValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Viewport_LightRotatorWidget_C.__BndEvt__Slider_1_K2Node_ComponentBoundEvent_0_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Viewport_LightRotatorWidget_C.__BndEvt__Slider_1_K2Node_ComponentBoundEvent_0_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027314 RID: 160532 RVA: 0x0098AA44 File Offset: 0x00988C44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__Slider_2_K2Node_ComponentBoundEvent_1_OnFloatValueChangedEvent__DelegateSignature(float Value)
		{
			Viewport_LightRotatorWidget_C.__BndEvt__Slider_2_K2Node_ComponentBoundEvent_1_OnFloatValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc Viewport_LightRotatorWidget_C.__BndEvt__Slider_2_K2Node_ComponentBoundEvent_1_OnFloatValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Viewport_LightRotatorWidget_C.__BndEvt__Slider_2_K2Node_ComponentBoundEvent_1_OnFloatValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Viewport_LightRotatorWidget_C.__BndEvt__Slider_2_K2Node_ComponentBoundEvent_1_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Viewport_LightRotatorWidget_C.__BndEvt__Slider_2_K2Node_ComponentBoundEvent_1_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027315 RID: 160533 RVA: 0x0098AA8C File Offset: 0x00988C8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__Slider_Camera_K2Node_ComponentBoundEvent_2_OnFloatValueChangedEvent__DelegateSignature(float Value)
		{
			Viewport_LightRotatorWidget_C.__BndEvt__Slider_Camera_K2Node_ComponentBoundEvent_2_OnFloatValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc Viewport_LightRotatorWidget_C.__BndEvt__Slider_Camera_K2Node_ComponentBoundEvent_2_OnFloatValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Viewport_LightRotatorWidget_C.__BndEvt__Slider_Camera_K2Node_ComponentBoundEvent_2_OnFloatValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Viewport_LightRotatorWidget_C.__BndEvt__Slider_Camera_K2Node_ComponentBoundEvent_2_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Viewport_LightRotatorWidget_C.__BndEvt__Slider_Camera_K2Node_ComponentBoundEvent_2_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027316 RID: 160534 RVA: 0x0098AAD4 File Offset: 0x00988CD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__Slider_LightIntensity_K2Node_ComponentBoundEvent_3_OnFloatValueChangedEvent__DelegateSignature(float Value)
		{
			Viewport_LightRotatorWidget_C.__BndEvt__Slider_LightIntensity_K2Node_ComponentBoundEvent_3_OnFloatValueChangedEvent__DelegateSignature_FunctionParams* ptr = stackalloc Viewport_LightRotatorWidget_C.__BndEvt__Slider_LightIntensity_K2Node_ComponentBoundEvent_3_OnFloatValueChangedEvent__DelegateSignature_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Viewport_LightRotatorWidget_C.__BndEvt__Slider_LightIntensity_K2Node_ComponentBoundEvent_3_OnFloatValueChangedEvent__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Viewport_LightRotatorWidget_C.__BndEvt__Slider_LightIntensity_K2Node_ComponentBoundEvent_3_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Viewport_LightRotatorWidget_C.__BndEvt__Slider_LightIntensity_K2Node_ComponentBoundEvent_3_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027317 RID: 160535 RVA: 0x0098AB1A File Offset: 0x00988D1A
		protected Viewport_LightRotatorWidget_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013C36 RID: 80950
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Core/Viewport_LightRotatorWidget.Viewport_LightRotatorWidget_C";

		// Token: 0x04013C37 RID: 80951
		private static IntPtr _ClassPtr;

		// Token: 0x04013C38 RID: 80952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013C39 RID: 80953
		internal static int __PropertyOffset_1;

		// Token: 0x04013C3A RID: 80954
		internal static int __PropertyOffset_2;

		// Token: 0x04013C3B RID: 80955
		internal static int __PropertyOffset_3;

		// Token: 0x04013C3C RID: 80956
		internal static int __PropertyOffset_4;

		// Token: 0x04013C3D RID: 80957
		internal static int __PropertyOffset_5;

		// Token: 0x04013C3E RID: 80958
		internal static int __PropertyOffset_6;

		// Token: 0x04013C3F RID: 80959
		private static IntPtr __PreConstruct_NativeFunctionPtr;

		// Token: 0x04013C40 RID: 80960
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x04013C41 RID: 80961
		private static IntPtr __BndEvt__Slider_1_K2Node_ComponentBoundEvent_0_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013C42 RID: 80962
		private static IntPtr __BndEvt__Slider_2_K2Node_ComponentBoundEvent_1_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013C43 RID: 80963
		private static IntPtr __BndEvt__Slider_Camera_K2Node_ComponentBoundEvent_2_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04013C44 RID: 80964
		private static IntPtr __BndEvt__Slider_LightIntensity_K2Node_ComponentBoundEvent_3_OnFloatValueChangedEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0200A1F2 RID: 41458
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __PreConstruct_FunctionParams
		{
			// Token: 0x04031E51 RID: 204369
			[FieldOffset(0)]
			public bool IsDesignTime;
		}

		// Token: 0x0200A1F3 RID: 41459
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected new ref struct __Tick_FunctionParams
		{
			// Token: 0x04031E52 RID: 204370
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04031E53 RID: 204371
			[FieldOffset(56)]
			public float InDeltaTime;
		}

		// Token: 0x0200A1F4 RID: 41460
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__Slider_1_K2Node_ComponentBoundEvent_0_OnFloatValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E54 RID: 204372
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x0200A1F5 RID: 41461
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__Slider_2_K2Node_ComponentBoundEvent_1_OnFloatValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E55 RID: 204373
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x0200A1F6 RID: 41462
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__Slider_Camera_K2Node_ComponentBoundEvent_2_OnFloatValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E56 RID: 204374
			[FieldOffset(0)]
			public float Value;
		}

		// Token: 0x0200A1F7 RID: 41463
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __BndEvt__Slider_LightIntensity_K2Node_ComponentBoundEvent_3_OnFloatValueChangedEvent__DelegateSignature_FunctionParams
		{
			// Token: 0x04031E57 RID: 204375
			[FieldOffset(0)]
			public float Value;
		}
	}
}
