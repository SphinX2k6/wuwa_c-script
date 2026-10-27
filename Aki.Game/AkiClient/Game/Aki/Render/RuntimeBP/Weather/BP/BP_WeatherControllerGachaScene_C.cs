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
	// Token: 0x02003A7C RID: 14972
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/BP_WeatherControllerGachaScene.BP_WeatherControllerGachaScene_C")]
	[UnrealStructLayout(1544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1537)]
	public class BP_WeatherControllerGachaScene_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC00 RID: 130048 RVA: 0x008C180D File Offset: 0x008BFA0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WeatherControllerGachaScene_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/BP/BP_WeatherControllerGachaScene.BP_WeatherControllerGachaScene_C");
			}
			return BP_WeatherControllerGachaScene_C._ClassPtr;
		}

		// Token: 0x0601FC01 RID: 130049 RVA: 0x008C1834 File Offset: 0x008BFA34
		public BP_WeatherControllerGachaScene_C() : this(BuiltinUtils.AllocNativeUObject(BP_WeatherControllerGachaScene_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC02 RID: 130050 RVA: 0x008C185C File Offset: 0x008BFA5C
		[NullableContext(1)]
		public BP_WeatherControllerGachaScene_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WeatherControllerGachaScene_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x0601FC03 RID: 130051 RVA: 0x008C188F File Offset: 0x008BFA8F
		// (set) Token: 0x0601FC04 RID: 130052 RVA: 0x008C18A3 File Offset: 0x008BFAA3
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x0601FC05 RID: 130053 RVA: 0x008C18B8 File Offset: 0x008BFAB8
		// (set) Token: 0x0601FC06 RID: 130054 RVA: 0x008C18CC File Offset: 0x008BFACC
		public unsafe UChildActorComponent SurfaceRipple
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x0601FC07 RID: 130055 RVA: 0x008C18E1 File Offset: 0x008BFAE1
		// (set) Token: 0x0601FC08 RID: 130056 RVA: 0x008C18F5 File Offset: 0x008BFAF5
		public unsafe UChildActorComponent RainDrop
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x0601FC09 RID: 130057 RVA: 0x008C190A File Offset: 0x008BFB0A
		// (set) Token: 0x0601FC0A RID: 130058 RVA: 0x008C191E File Offset: 0x008BFB1E
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002CBA RID: 11450
		// (get) Token: 0x0601FC0B RID: 130059 RVA: 0x008C1933 File Offset: 0x008BFB33
		// (set) Token: 0x0601FC0C RID: 130060 RVA: 0x008C1947 File Offset: 0x008BFB47
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeatherControllerGachaScene_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002CBB RID: 11451
		// (get) Token: 0x0601FC0D RID: 130061 RVA: 0x008C195C File Offset: 0x008BFB5C
		// (set) Token: 0x0601FC0E RID: 130062 RVA: 0x008C196C File Offset: 0x008BFB6C
		public unsafe bool GlobalGI_Legality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CBC RID: 11452
		// (get) Token: 0x0601FC0F RID: 130063 RVA: 0x008C197D File Offset: 0x008BFB7D
		// (set) Token: 0x0601FC10 RID: 130064 RVA: 0x008C198D File Offset: 0x008BFB8D
		public unsafe float RainIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x0601FC11 RID: 130065 RVA: 0x008C199E File Offset: 0x008BFB9E
		// (set) Token: 0x0601FC12 RID: 130066 RVA: 0x008C19AE File Offset: 0x008BFBAE
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x0601FC13 RID: 130067 RVA: 0x008C19BF File Offset: 0x008BFBBF
		// (set) Token: 0x0601FC14 RID: 130068 RVA: 0x008C19CF File Offset: 0x008BFBCF
		public unsafe bool IsInCave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x0601FC15 RID: 130069 RVA: 0x008C19E0 File Offset: 0x008BFBE0
		// (set) Token: 0x0601FC16 RID: 130070 RVA: 0x008C19F4 File Offset: 0x008BFBF4
		public unsafe FVectorDouble PostCharacterPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x0601FC17 RID: 130071 RVA: 0x008C1A09 File Offset: 0x008BFC09
		// (set) Token: 0x0601FC18 RID: 130072 RVA: 0x008C1A19 File Offset: 0x008BFC19
		public unsafe bool EditorUpdateDroplets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeatherControllerGachaScene_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FC19 RID: 130073 RVA: 0x008C1A2A File Offset: 0x008BFC2A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnRep_GlobalGI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__OnRep_GlobalGI_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC1A RID: 130074 RVA: 0x008C1A3E File Offset: 0x008BFC3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC1B RID: 130075 RVA: 0x008C1A52 File Offset: 0x008BFC52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FC1C RID: 130076 RVA: 0x008C1A67 File Offset: 0x008BFC67
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC1D RID: 130077 RVA: 0x008C1A7B File Offset: 0x008BFC7B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FC1E RID: 130078 RVA: 0x008C1A90 File Offset: 0x008BFC90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WeatherControllerGachaScene_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeatherControllerGachaScene_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeatherControllerGachaScene_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeatherControllerGachaScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FC1F RID: 130079 RVA: 0x008C1AD8 File Offset: 0x008BFCD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WeatherControllerGachaScene_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeatherControllerGachaScene_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeatherControllerGachaScene_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeatherControllerGachaScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FC20 RID: 130080 RVA: 0x008C1B20 File Offset: 0x008BFD20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_WeatherControllerGachaScene_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WeatherControllerGachaScene_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeatherControllerGachaScene_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeatherControllerGachaScene_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FC21 RID: 130081 RVA: 0x008C1B68 File Offset: 0x008BFD68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_WeatherControllerGachaScene_C.__EditorTick_FunctionParams* ptr = stackalloc BP_WeatherControllerGachaScene_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeatherControllerGachaScene_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeatherControllerGachaScene_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FC22 RID: 130082 RVA: 0x008C1BAF File Offset: 0x008BFDAF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TracingCave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeatherControllerGachaScene_C.__TracingCave_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC23 RID: 130083 RVA: 0x008C1BC3 File Offset: 0x008BFDC3
		protected BP_WeatherControllerGachaScene_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F4BD RID: 62653
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/BP_WeatherControllerGachaScene.BP_WeatherControllerGachaScene_C";

		// Token: 0x0400F4BE RID: 62654
		private static IntPtr _ClassPtr;

		// Token: 0x0400F4BF RID: 62655
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F4C0 RID: 62656
		internal static int __PropertyOffset_1;

		// Token: 0x0400F4C1 RID: 62657
		internal static int __PropertyOffset_2;

		// Token: 0x0400F4C2 RID: 62658
		internal static int __PropertyOffset_3;

		// Token: 0x0400F4C3 RID: 62659
		internal static int __PropertyOffset_4;

		// Token: 0x0400F4C4 RID: 62660
		internal static int __PropertyOffset_5;

		// Token: 0x0400F4C5 RID: 62661
		internal static int __PropertyOffset_6;

		// Token: 0x0400F4C6 RID: 62662
		internal static int __PropertyOffset_7;

		// Token: 0x0400F4C7 RID: 62663
		internal static int __PropertyOffset_8;

		// Token: 0x0400F4C8 RID: 62664
		internal static int __PropertyOffset_9;

		// Token: 0x0400F4C9 RID: 62665
		internal static int __PropertyOffset_10;

		// Token: 0x0400F4CA RID: 62666
		internal static int __PropertyOffset_11;

		// Token: 0x0400F4CB RID: 62667
		private static IntPtr __OnRep_GlobalGI_NativeFunctionPtr;

		// Token: 0x0400F4CC RID: 62668
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F4CD RID: 62669
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F4CE RID: 62670
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F4CF RID: 62671
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400F4D0 RID: 62672
		private static IntPtr __TracingCave_NativeFunctionPtr;

		// Token: 0x02009B48 RID: 39752
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031161 RID: 201057
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B49 RID: 39753
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031162 RID: 201058
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
