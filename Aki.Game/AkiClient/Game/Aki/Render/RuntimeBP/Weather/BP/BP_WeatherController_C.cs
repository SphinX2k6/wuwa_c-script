using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP
{
	// Token: 0x02003A7D RID: 14973
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/BP_WeatherController.BP_WeatherController_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1529)]
	public class BP_WeatherController_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC24 RID: 130084 RVA: 0x008C1BCC File Offset: 0x008BFDCC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WeatherController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/BP/BP_WeatherController.BP_WeatherController_C");
			}
			return BP_WeatherController_C._ClassPtr;
		}

		// Token: 0x0601FC25 RID: 130085 RVA: 0x008C1BF0 File Offset: 0x008BFDF0
		public BP_WeatherController_C() : this(BuiltinUtils.AllocNativeUObject(BP_WeatherController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC26 RID: 130086 RVA: 0x008C1C18 File Offset: 0x008BFE18
		[NullableContext(1)]
		public BP_WeatherController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WeatherController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x0601FC27 RID: 130087 RVA: 0x008C1C4B File Offset: 0x008BFE4B
		// (set) Token: 0x0601FC28 RID: 130088 RVA: 0x008C1C5F File Offset: 0x008BFE5F
		public unsafe UChildActorComponent SurfaceRipple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherController_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x0601FC29 RID: 130089 RVA: 0x008C1C74 File Offset: 0x008BFE74
		// (set) Token: 0x0601FC2A RID: 130090 RVA: 0x008C1C88 File Offset: 0x008BFE88
		public unsafe UChildActorComponent RainDrop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherController_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherController_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x0601FC2B RID: 130091 RVA: 0x008C1C9D File Offset: 0x008BFE9D
		// (set) Token: 0x0601FC2C RID: 130092 RVA: 0x008C1CB1 File Offset: 0x008BFEB1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherController_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherController_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x0601FC2D RID: 130093 RVA: 0x008C1CC6 File Offset: 0x008BFEC6
		// (set) Token: 0x0601FC2E RID: 130094 RVA: 0x008C1CDA File Offset: 0x008BFEDA
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherController_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherController_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x0601FC2F RID: 130095 RVA: 0x008C1CEF File Offset: 0x008BFEEF
		// (set) Token: 0x0601FC30 RID: 130096 RVA: 0x008C1CFF File Offset: 0x008BFEFF
		public unsafe bool GlobalGI_Legality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x0601FC31 RID: 130097 RVA: 0x008C1D10 File Offset: 0x008BFF10
		// (set) Token: 0x0601FC32 RID: 130098 RVA: 0x008C1D20 File Offset: 0x008BFF20
		public unsafe float RainIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x0601FC33 RID: 130099 RVA: 0x008C1D31 File Offset: 0x008BFF31
		// (set) Token: 0x0601FC34 RID: 130100 RVA: 0x008C1D41 File Offset: 0x008BFF41
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x0601FC35 RID: 130101 RVA: 0x008C1D52 File Offset: 0x008BFF52
		// (set) Token: 0x0601FC36 RID: 130102 RVA: 0x008C1D62 File Offset: 0x008BFF62
		public unsafe bool IsInCave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x0601FC37 RID: 130103 RVA: 0x008C1D73 File Offset: 0x008BFF73
		// (set) Token: 0x0601FC38 RID: 130104 RVA: 0x008C1D87 File Offset: 0x008BFF87
		public unsafe FVectorDouble PostCharacterPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x0601FC39 RID: 130105 RVA: 0x008C1D9C File Offset: 0x008BFF9C
		// (set) Token: 0x0601FC3A RID: 130106 RVA: 0x008C1DAC File Offset: 0x008BFFAC
		public unsafe bool EditorUpdateDroplets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherController_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FC3B RID: 130107 RVA: 0x008C1DBD File Offset: 0x008BFFBD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnRep_GlobalGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherController_C.__OnRep_GlobalGI_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC3C RID: 130108 RVA: 0x008C1DD1 File Offset: 0x008BFFD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherController_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC3D RID: 130109 RVA: 0x008C1DE5 File Offset: 0x008BFFE5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeatherController_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FC3E RID: 130110 RVA: 0x008C1DFA File Offset: 0x008BFFFA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherController_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC3F RID: 130111 RVA: 0x008C1E0E File Offset: 0x008C000E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeatherController_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FC40 RID: 130112 RVA: 0x008C1E24 File Offset: 0x008C0024
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WeatherController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeatherController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeatherController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeatherController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FC41 RID: 130113 RVA: 0x008C1E6C File Offset: 0x008C006C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WeatherController_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeatherController_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeatherController_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeatherController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeatherController_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FC42 RID: 130114 RVA: 0x008C1EB4 File Offset: 0x008C00B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_WeatherController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WeatherController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeatherController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeatherController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherController_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FC43 RID: 130115 RVA: 0x008C1EFC File Offset: 0x008C00FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_WeatherController_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WeatherController_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeatherController_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeatherController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeatherController_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FC44 RID: 130116 RVA: 0x008C1F43 File Offset: 0x008C0143
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TracingCave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherController_C.__TracingCave_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC45 RID: 130117 RVA: 0x008C1F57 File Offset: 0x008C0157
		protected BP_WeatherController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F4D1 RID: 62673
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/BP_WeatherController.BP_WeatherController_C";

		// Token: 0x0400F4D2 RID: 62674
		private static IntPtr _ClassPtr;

		// Token: 0x0400F4D3 RID: 62675
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F4D4 RID: 62676
		internal static int __PropertyOffset_1;

		// Token: 0x0400F4D5 RID: 62677
		internal static int __PropertyOffset_2;

		// Token: 0x0400F4D6 RID: 62678
		internal static int __PropertyOffset_3;

		// Token: 0x0400F4D7 RID: 62679
		internal static int __PropertyOffset_4;

		// Token: 0x0400F4D8 RID: 62680
		internal static int __PropertyOffset_5;

		// Token: 0x0400F4D9 RID: 62681
		internal static int __PropertyOffset_6;

		// Token: 0x0400F4DA RID: 62682
		internal static int __PropertyOffset_7;

		// Token: 0x0400F4DB RID: 62683
		internal static int __PropertyOffset_8;

		// Token: 0x0400F4DC RID: 62684
		internal static int __PropertyOffset_9;

		// Token: 0x0400F4DD RID: 62685
		internal static int __PropertyOffset_10;

		// Token: 0x0400F4DE RID: 62686
		private static IntPtr __OnRep_GlobalGI_NativeFunctionPtr;

		// Token: 0x0400F4DF RID: 62687
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F4E0 RID: 62688
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F4E1 RID: 62689
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F4E2 RID: 62690
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400F4E3 RID: 62691
		private static IntPtr __TracingCave_NativeFunctionPtr;

		// Token: 0x02009B4A RID: 39754
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031163 RID: 201059
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B4B RID: 39755
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031164 RID: 201060
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
