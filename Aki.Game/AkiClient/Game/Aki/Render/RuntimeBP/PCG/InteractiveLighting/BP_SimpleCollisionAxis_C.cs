using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.InteractiveLighting
{
	// Token: 0x02003C99 RID: 15513
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/InteractiveLighting/BP_SimpleCollisionAxis.BP_SimpleCollisionAxis_C")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1456)]
	public class BP_SimpleCollisionAxis_C : AKuroCSSimpleCollisionAxis, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024583 RID: 148867 RVA: 0x0093BEC1 File Offset: 0x0093A0C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SimpleCollisionAxis_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/InteractiveLighting/BP_SimpleCollisionAxis.BP_SimpleCollisionAxis_C");
			}
			return BP_SimpleCollisionAxis_C._ClassPtr;
		}

		// Token: 0x06024584 RID: 148868 RVA: 0x0093BEE8 File Offset: 0x0093A0E8
		public BP_SimpleCollisionAxis_C() : this(BuiltinUtils.AllocNativeUObject(BP_SimpleCollisionAxis_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024585 RID: 148869 RVA: 0x0093BF10 File Offset: 0x0093A110
		[NullableContext(1)]
		public BP_SimpleCollisionAxis_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SimpleCollisionAxis_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x06024586 RID: 148870 RVA: 0x0093BF43 File Offset: 0x0093A143
		// (set) Token: 0x06024587 RID: 148871 RVA: 0x0093BF57 File Offset: 0x0093A157
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700468B RID: 18059
		// (get) Token: 0x06024588 RID: 148872 RVA: 0x0093BF6C File Offset: 0x0093A16C
		// (set) Token: 0x06024589 RID: 148873 RVA: 0x0093BF80 File Offset: 0x0093A180
		public unsafe UTextureRenderTarget2D T_Particle_Pivot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700468C RID: 18060
		// (get) Token: 0x0602458A RID: 148874 RVA: 0x0093BF95 File Offset: 0x0093A195
		// (set) Token: 0x0602458B RID: 148875 RVA: 0x0093BFA5 File Offset: 0x0093A1A5
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700468D RID: 18061
		// (get) Token: 0x0602458C RID: 148876 RVA: 0x0093BFB6 File Offset: 0x0093A1B6
		// (set) Token: 0x0602458D RID: 148877 RVA: 0x0093BFC6 File Offset: 0x0093A1C6
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_C.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_C.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700468E RID: 18062
		// (get) Token: 0x0602458E RID: 148878 RVA: 0x0093BFD7 File Offset: 0x0093A1D7
		// (set) Token: 0x0602458F RID: 148879 RVA: 0x0093BFEB File Offset: 0x0093A1EB
		public unsafe UMaterialInterface CopyTexMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700468F RID: 18063
		// (get) Token: 0x06024590 RID: 148880 RVA: 0x0093C000 File Offset: 0x0093A200
		// (set) Token: 0x06024591 RID: 148881 RVA: 0x0093C039 File Offset: 0x0093A239
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> RenderMID
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._RenderMID) == null)
				{
					result = (this._RenderMID = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_SimpleCollisionAxis_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RenderMID.CopyAssign(value);
			}
		}

		// Token: 0x17004690 RID: 18064
		// (get) Token: 0x06024592 RID: 148882 RVA: 0x0093C047 File Offset: 0x0093A247
		// (set) Token: 0x06024593 RID: 148883 RVA: 0x0093C05B File Offset: 0x0093A25B
		public unsafe UStaticMesh SM_Ice1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004691 RID: 18065
		// (get) Token: 0x06024594 RID: 148884 RVA: 0x0093C070 File Offset: 0x0093A270
		// (set) Token: 0x06024595 RID: 148885 RVA: 0x0093C084 File Offset: 0x0093A284
		public unsafe UStaticMesh SM_Ice2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004692 RID: 18066
		// (get) Token: 0x06024596 RID: 148886 RVA: 0x0093C099 File Offset: 0x0093A299
		// (set) Token: 0x06024597 RID: 148887 RVA: 0x0093C0AD File Offset: 0x0093A2AD
		public unsafe UStaticMesh SM_Ice3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004693 RID: 18067
		// (get) Token: 0x06024598 RID: 148888 RVA: 0x0093C0C2 File Offset: 0x0093A2C2
		// (set) Token: 0x06024599 RID: 148889 RVA: 0x0093C0D6 File Offset: 0x0093A2D6
		public unsafe UTexture2D Input_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004694 RID: 18068
		// (get) Token: 0x0602459A RID: 148890 RVA: 0x0093C0EB File Offset: 0x0093A2EB
		// (set) Token: 0x0602459B RID: 148891 RVA: 0x0093C0FF File Offset: 0x0093A2FF
		public unsafe UTexture2D Input_Texture_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004695 RID: 18069
		// (get) Token: 0x0602459C RID: 148892 RVA: 0x0093C114 File Offset: 0x0093A314
		// (set) Token: 0x0602459D RID: 148893 RVA: 0x0093C128 File Offset: 0x0093A328
		public unsafe UTexture2D Input_Texture_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SimpleCollisionAxis_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x0602459E RID: 148894 RVA: 0x0093C13D File Offset: 0x0093A33D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 应用贴图材质()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_C.__应用贴图材质_NativeFunctionPtr, null);
		}

		// Token: 0x0602459F RID: 148895 RVA: 0x0093C151 File Offset: 0x0093A351
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060245A0 RID: 148896 RVA: 0x0093C165 File Offset: 0x0093A365
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SimpleCollisionAxis_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060245A1 RID: 148897 RVA: 0x0093C17C File Offset: 0x0093A37C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SimpleCollisionAxis_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SimpleCollisionAxis_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SimpleCollisionAxis_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleCollisionAxis_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060245A2 RID: 148898 RVA: 0x0093C1C4 File Offset: 0x0093A3C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SimpleCollisionAxis_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SimpleCollisionAxis_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SimpleCollisionAxis_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleCollisionAxis_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SimpleCollisionAxis_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060245A3 RID: 148899 RVA: 0x0093C20B File Offset: 0x0093A40B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060245A4 RID: 148900 RVA: 0x0093C21F File Offset: 0x0093A41F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SimpleCollisionAxis_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060245A5 RID: 148901 RVA: 0x0093C234 File Offset: 0x0093A434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060245A6 RID: 148902 RVA: 0x0093C2F0 File Offset: 0x0093A4F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SimpleCollisionAxis_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060245A7 RID: 148903 RVA: 0x0093C379 File Offset: 0x0093A579
		protected BP_SimpleCollisionAxis_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401206F RID: 73839
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/InteractiveLighting/BP_SimpleCollisionAxis.BP_SimpleCollisionAxis_C";

		// Token: 0x04012070 RID: 73840
		private static IntPtr _ClassPtr;

		// Token: 0x04012071 RID: 73841
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012072 RID: 73842
		internal static int __PropertyOffset_1;

		// Token: 0x04012073 RID: 73843
		internal static int __PropertyOffset_2;

		// Token: 0x04012074 RID: 73844
		internal static int __PropertyOffset_3;

		// Token: 0x04012075 RID: 73845
		internal static int __PropertyOffset_4;

		// Token: 0x04012076 RID: 73846
		internal static int __PropertyOffset_5;

		// Token: 0x04012077 RID: 73847
		internal static int __PropertyOffset_6;

		// Token: 0x04012078 RID: 73848
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _RenderMID;

		// Token: 0x04012079 RID: 73849
		internal static int __PropertyOffset_7;

		// Token: 0x0401207A RID: 73850
		internal static int __PropertyOffset_8;

		// Token: 0x0401207B RID: 73851
		internal static int __PropertyOffset_9;

		// Token: 0x0401207C RID: 73852
		internal static int __PropertyOffset_10;

		// Token: 0x0401207D RID: 73853
		internal static int __PropertyOffset_11;

		// Token: 0x0401207E RID: 73854
		internal static int __PropertyOffset_12;

		// Token: 0x0401207F RID: 73855
		private static IntPtr __应用贴图材质_NativeFunctionPtr;

		// Token: 0x04012080 RID: 73856
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012081 RID: 73857
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012082 RID: 73858
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012083 RID: 73859
		private static IntPtr __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012084 RID: 73860
		private static IntPtr __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009F04 RID: 40708
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403183C RID: 202812
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F05 RID: 40709
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403183D RID: 202813
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403183E RID: 202814
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403183F RID: 202815
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031840 RID: 202816
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031841 RID: 202817
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031842 RID: 202818
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F06 RID: 40710
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031843 RID: 202819
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031844 RID: 202820
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031845 RID: 202821
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031846 RID: 202822
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
