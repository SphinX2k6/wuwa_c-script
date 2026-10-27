using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.Water
{
	// Token: 0x02003D94 RID: 15764
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Water/BP_SplineGenerator.BP_SplineGenerator_C")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class BP_SplineGenerator_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027082 RID: 159874 RVA: 0x0098510E File Offset: 0x0098330E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineGenerator_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Water/BP_SplineGenerator.BP_SplineGenerator_C");
			}
			return BP_SplineGenerator_C._ClassPtr;
		}

		// Token: 0x06027083 RID: 159875 RVA: 0x00985134 File Offset: 0x00983334
		public BP_SplineGenerator_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineGenerator_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027084 RID: 159876 RVA: 0x0098515C File Offset: 0x0098335C
		[NullableContext(1)]
		public BP_SplineGenerator_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineGenerator_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170055EC RID: 21996
		// (get) Token: 0x06027085 RID: 159877 RVA: 0x0098518F File Offset: 0x0098338F
		// (set) Token: 0x06027086 RID: 159878 RVA: 0x009851A3 File Offset: 0x009833A3
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170055ED RID: 21997
		// (get) Token: 0x06027087 RID: 159879 RVA: 0x009851B8 File Offset: 0x009833B8
		// (set) Token: 0x06027088 RID: 159880 RVA: 0x009851CC File Offset: 0x009833CC
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170055EE RID: 21998
		// (get) Token: 0x06027089 RID: 159881 RVA: 0x009851E1 File Offset: 0x009833E1
		// (set) Token: 0x0602708A RID: 159882 RVA: 0x009851F5 File Offset: 0x009833F5
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170055EF RID: 21999
		// (get) Token: 0x0602708B RID: 159883 RVA: 0x0098520A File Offset: 0x0098340A
		// (set) Token: 0x0602708C RID: 159884 RVA: 0x0098521E File Offset: 0x0098341E
		public unsafe UStaticMesh StaticMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170055F0 RID: 22000
		// (get) Token: 0x0602708D RID: 159885 RVA: 0x00985233 File Offset: 0x00983433
		// (set) Token: 0x0602708E RID: 159886 RVA: 0x00985247 File Offset: 0x00983447
		[Nullable(0)]
		public unsafe TEnumAsByte<ESplineMeshAxis> In_Forward_Axis
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineGenerator_C.__PropertyOffset_5);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineGenerator_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170055F1 RID: 22001
		// (get) Token: 0x0602708F RID: 159887 RVA: 0x0098525C File Offset: 0x0098345C
		// (set) Token: 0x06027090 RID: 159888 RVA: 0x00985270 File Offset: 0x00983470
		public unsafe UMaterialInstance EditorPlaceholderMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineGenerator_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170055F2 RID: 22002
		// (get) Token: 0x06027091 RID: 159889 RVA: 0x00985285 File Offset: 0x00983485
		// (set) Token: 0x06027092 RID: 159890 RVA: 0x00985295 File Offset: 0x00983495
		public unsafe float SizeAdjutment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineGenerator_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineGenerator_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170055F3 RID: 22003
		// (get) Token: 0x06027093 RID: 159891 RVA: 0x009852A6 File Offset: 0x009834A6
		// (set) Token: 0x06027094 RID: 159892 RVA: 0x009852B6 File Offset: 0x009834B6
		public unsafe float SectionLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineGenerator_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineGenerator_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170055F4 RID: 22004
		// (get) Token: 0x06027095 RID: 159893 RVA: 0x009852C8 File Offset: 0x009834C8
		// (set) Token: 0x06027096 RID: 159894 RVA: 0x00985301 File Offset: 0x00983501
		[Nullable(1)]
		public TArray<USplineMeshComponent> SplineMeshComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USplineMeshComponent> result;
				if ((result = this._SplineMeshComponents) == null)
				{
					result = (this._SplineMeshComponents = new TArray<USplineMeshComponent>(base.NativePtr + (IntPtr)BP_SplineGenerator_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SplineMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x06027097 RID: 159895 RVA: 0x0098530F File Offset: 0x0098350F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineGenerator_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06027098 RID: 159896 RVA: 0x00985323 File Offset: 0x00983523
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineGenerator_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027099 RID: 159897 RVA: 0x00985338 File Offset: 0x00983538
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineGenerator_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602709A RID: 159898 RVA: 0x0098534C File Offset: 0x0098354C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineGenerator_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602709B RID: 159899 RVA: 0x00985364 File Offset: 0x00983564
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveActorBeginOverlap(AActor OtherActor)
		{
			BP_SplineGenerator_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_SplineGenerator_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SplineGenerator_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineGenerator_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineGenerator_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602709C RID: 159900 RVA: 0x009853BC File Offset: 0x009835BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveActorBeginOverlap_Implementation(AActor OtherActor)
		{
			BP_SplineGenerator_C.__ReceiveActorBeginOverlap_FunctionParams* ptr = stackalloc BP_SplineGenerator_C.__ReceiveActorBeginOverlap_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SplineGenerator_C.__ReceiveActorBeginOverlap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineGenerator_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineGenerator_C.__ReceiveActorBeginOverlap_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602709D RID: 159901 RVA: 0x00985414 File Offset: 0x00983614
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplineGenerator_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineGenerator_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineGenerator_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineGenerator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineGenerator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602709E RID: 159902 RVA: 0x0098545C File Offset: 0x0098365C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplineGenerator_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineGenerator_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineGenerator_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineGenerator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineGenerator_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602709F RID: 159903 RVA: 0x009854A3 File Offset: 0x009836A3
		protected BP_SplineGenerator_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A8A RID: 80522
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/Water/BP_SplineGenerator.BP_SplineGenerator_C";

		// Token: 0x04013A8B RID: 80523
		private static IntPtr _ClassPtr;

		// Token: 0x04013A8C RID: 80524
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A8D RID: 80525
		internal static int __PropertyOffset_1;

		// Token: 0x04013A8E RID: 80526
		internal static int __PropertyOffset_2;

		// Token: 0x04013A8F RID: 80527
		internal static int __PropertyOffset_3;

		// Token: 0x04013A90 RID: 80528
		internal static int __PropertyOffset_4;

		// Token: 0x04013A91 RID: 80529
		internal static int __PropertyOffset_5;

		// Token: 0x04013A92 RID: 80530
		internal static int __PropertyOffset_6;

		// Token: 0x04013A93 RID: 80531
		internal static int __PropertyOffset_7;

		// Token: 0x04013A94 RID: 80532
		internal static int __PropertyOffset_8;

		// Token: 0x04013A95 RID: 80533
		internal static int __PropertyOffset_9;

		// Token: 0x04013A96 RID: 80534
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineMeshComponent> _SplineMeshComponents;

		// Token: 0x04013A97 RID: 80535
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04013A98 RID: 80536
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013A99 RID: 80537
		private static IntPtr __ReceiveActorBeginOverlap_NativeFunctionPtr;

		// Token: 0x04013A9A RID: 80538
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A18C RID: 41356
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected new ref struct __ReceiveActorBeginOverlap_FunctionParams
		{
			// Token: 0x04031D6F RID: 204143
			[FieldOffset(0)]
			public IntPtr OtherActor;
		}

		// Token: 0x0200A18D RID: 41357
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031D70 RID: 204144
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
