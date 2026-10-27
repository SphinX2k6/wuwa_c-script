using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUClothSimulation
{
	// Token: 0x02003CA9 RID: 15529
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicBridgeChain.BP_PhysicBridgeChain_C")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class BP_PhysicBridgeChain_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060247E4 RID: 149476 RVA: 0x0094052C File Offset: 0x0093E72C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PhysicBridgeChain_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicBridgeChain.BP_PhysicBridgeChain_C");
			}
			return BP_PhysicBridgeChain_C._ClassPtr;
		}

		// Token: 0x060247E5 RID: 149477 RVA: 0x00940550 File Offset: 0x0093E750
		public BP_PhysicBridgeChain_C() : this(BuiltinUtils.AllocNativeUObject(BP_PhysicBridgeChain_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060247E6 RID: 149478 RVA: 0x00940578 File Offset: 0x0093E778
		[NullableContext(1)]
		public BP_PhysicBridgeChain_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PhysicBridgeChain_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700475A RID: 18266
		// (get) Token: 0x060247E7 RID: 149479 RVA: 0x009405AB File Offset: 0x0093E7AB
		// (set) Token: 0x060247E8 RID: 149480 RVA: 0x009405BF File Offset: 0x0093E7BF
		public unsafe UStaticMeshComponent SM_Com2_Bri_11EM_scale_bound_version
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700475B RID: 18267
		// (get) Token: 0x060247E9 RID: 149481 RVA: 0x009405D4 File Offset: 0x0093E7D4
		// (set) Token: 0x060247EA RID: 149482 RVA: 0x009405E8 File Offset: 0x0093E7E8
		public unsafe UChildActorComponent ChildActor3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700475C RID: 18268
		// (get) Token: 0x060247EB RID: 149483 RVA: 0x009405FD File Offset: 0x0093E7FD
		// (set) Token: 0x060247EC RID: 149484 RVA: 0x00940611 File Offset: 0x0093E811
		public unsafe UChildActorComponent ChildActor2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700475D RID: 18269
		// (get) Token: 0x060247ED RID: 149485 RVA: 0x00940626 File Offset: 0x0093E826
		// (set) Token: 0x060247EE RID: 149486 RVA: 0x0094063A File Offset: 0x0093E83A
		public unsafe UChildActorComponent ChildActor1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700475E RID: 18270
		// (get) Token: 0x060247EF RID: 149487 RVA: 0x0094064F File Offset: 0x0093E84F
		// (set) Token: 0x060247F0 RID: 149488 RVA: 0x00940663 File Offset: 0x0093E863
		public unsafe UChildActorComponent ChildActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700475F RID: 18271
		// (get) Token: 0x060247F1 RID: 149489 RVA: 0x00940678 File Offset: 0x0093E878
		// (set) Token: 0x060247F2 RID: 149490 RVA: 0x0094068C File Offset: 0x0093E88C
		public unsafe UNiagaraComponent NS_BridgeChain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004760 RID: 18272
		// (get) Token: 0x060247F3 RID: 149491 RVA: 0x009406A1 File Offset: 0x0093E8A1
		// (set) Token: 0x060247F4 RID: 149492 RVA: 0x009406B5 File Offset: 0x0093E8B5
		public unsafe UMaterialInterface Static_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004761 RID: 18273
		// (get) Token: 0x060247F5 RID: 149493 RVA: 0x009406CA File Offset: 0x0093E8CA
		// (set) Token: 0x060247F6 RID: 149494 RVA: 0x009406DE File Offset: 0x0093E8DE
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004762 RID: 18274
		// (get) Token: 0x060247F7 RID: 149495 RVA: 0x009406F3 File Offset: 0x0093E8F3
		// (set) Token: 0x060247F8 RID: 149496 RVA: 0x00940703 File Offset: 0x0093E903
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004763 RID: 18275
		// (get) Token: 0x060247F9 RID: 149497 RVA: 0x00940714 File Offset: 0x0093E914
		// (set) Token: 0x060247FA RID: 149498 RVA: 0x00940724 File Offset: 0x0093E924
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004764 RID: 18276
		// (get) Token: 0x060247FB RID: 149499 RVA: 0x00940735 File Offset: 0x0093E935
		// (set) Token: 0x060247FC RID: 149500 RVA: 0x00940745 File Offset: 0x0093E945
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004765 RID: 18277
		// (get) Token: 0x060247FD RID: 149501 RVA: 0x00940756 File Offset: 0x0093E956
		// (set) Token: 0x060247FE RID: 149502 RVA: 0x0094076A File Offset: 0x0093E96A
		public unsafe FVector v11
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004766 RID: 18278
		// (get) Token: 0x060247FF RID: 149503 RVA: 0x0094077F File Offset: 0x0093E97F
		// (set) Token: 0x06024800 RID: 149504 RVA: 0x00940793 File Offset: 0x0093E993
		public unsafe FVector v12
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004767 RID: 18279
		// (get) Token: 0x06024801 RID: 149505 RVA: 0x009407A8 File Offset: 0x0093E9A8
		// (set) Token: 0x06024802 RID: 149506 RVA: 0x009407BC File Offset: 0x0093E9BC
		public unsafe FVector v21
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004768 RID: 18280
		// (get) Token: 0x06024803 RID: 149507 RVA: 0x009407D1 File Offset: 0x0093E9D1
		// (set) Token: 0x06024804 RID: 149508 RVA: 0x009407E5 File Offset: 0x0093E9E5
		public unsafe FVector v22
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PhysicBridgeChain_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004769 RID: 18281
		// (get) Token: 0x06024805 RID: 149509 RVA: 0x009407FA File Offset: 0x0093E9FA
		// (set) Token: 0x06024806 RID: 149510 RVA: 0x0094080E File Offset: 0x0093EA0E
		public unsafe UMaterialInstanceDynamic DMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PhysicBridgeChain_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x06024807 RID: 149511 RVA: 0x00940823 File Offset: 0x0093EA23
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void niagara_Input()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicBridgeChain_C.__niagara_Input_NativeFunctionPtr, null);
		}

		// Token: 0x06024808 RID: 149512 RVA: 0x00940837 File Offset: 0x0093EA37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Bending_Points_from_Outside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicBridgeChain_C.__Bending_Points_from_Outside_NativeFunctionPtr, null);
		}

		// Token: 0x06024809 RID: 149513 RVA: 0x0094084B File Offset: 0x0093EA4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Bending_Points()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicBridgeChain_C.__Bending_Points_NativeFunctionPtr, null);
		}

		// Token: 0x0602480A RID: 149514 RVA: 0x0094085F File Offset: 0x0093EA5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Input_Parameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicBridgeChain_C.__Input_Parameters_NativeFunctionPtr, null);
		}

		// Token: 0x0602480B RID: 149515 RVA: 0x00940874 File Offset: 0x0093EA74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PhysicBridgeChain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhysicBridgeChain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhysicBridgeChain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicBridgeChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicBridgeChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602480C RID: 149516 RVA: 0x009408BC File Offset: 0x0093EABC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PhysicBridgeChain_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PhysicBridgeChain_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PhysicBridgeChain_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PhysicBridgeChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicBridgeChain_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602480D RID: 149517 RVA: 0x00940903 File Offset: 0x0093EB03
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PhysicBridgeChain_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602480E RID: 149518 RVA: 0x00940917 File Offset: 0x0093EB17
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PhysicBridgeChain_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602480F RID: 149519 RVA: 0x0094092C File Offset: 0x0093EB2C
		protected BP_PhysicBridgeChain_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121DF RID: 74207
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUClothSimulation/BP_PhysicBridgeChain.BP_PhysicBridgeChain_C";

		// Token: 0x040121E0 RID: 74208
		private static IntPtr _ClassPtr;

		// Token: 0x040121E1 RID: 74209
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040121E2 RID: 74210
		internal static int __PropertyOffset_1;

		// Token: 0x040121E3 RID: 74211
		internal static int __PropertyOffset_2;

		// Token: 0x040121E4 RID: 74212
		internal static int __PropertyOffset_3;

		// Token: 0x040121E5 RID: 74213
		internal static int __PropertyOffset_4;

		// Token: 0x040121E6 RID: 74214
		internal static int __PropertyOffset_5;

		// Token: 0x040121E7 RID: 74215
		internal static int __PropertyOffset_6;

		// Token: 0x040121E8 RID: 74216
		internal static int __PropertyOffset_7;

		// Token: 0x040121E9 RID: 74217
		internal static int __PropertyOffset_8;

		// Token: 0x040121EA RID: 74218
		internal static int __PropertyOffset_9;

		// Token: 0x040121EB RID: 74219
		internal static int __PropertyOffset_10;

		// Token: 0x040121EC RID: 74220
		internal static int __PropertyOffset_11;

		// Token: 0x040121ED RID: 74221
		internal static int __PropertyOffset_12;

		// Token: 0x040121EE RID: 74222
		internal static int __PropertyOffset_13;

		// Token: 0x040121EF RID: 74223
		internal static int __PropertyOffset_14;

		// Token: 0x040121F0 RID: 74224
		internal static int __PropertyOffset_15;

		// Token: 0x040121F1 RID: 74225
		internal static int __PropertyOffset_16;

		// Token: 0x040121F2 RID: 74226
		private static IntPtr __niagara_Input_NativeFunctionPtr;

		// Token: 0x040121F3 RID: 74227
		private static IntPtr __Bending_Points_from_Outside_NativeFunctionPtr;

		// Token: 0x040121F4 RID: 74228
		private static IntPtr __Bending_Points_NativeFunctionPtr;

		// Token: 0x040121F5 RID: 74229
		private static IntPtr __Input_Parameters_NativeFunctionPtr;

		// Token: 0x040121F6 RID: 74230
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040121F7 RID: 74231
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009F2E RID: 40750
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318B0 RID: 202928
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
