using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._3_7_InteractionBrigthComponent
{
	// Token: 0x02003C0E RID: 15374
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_InteractionBrigthComponent/BP_MeshGlowCopyComponent_Fresnel.BP_MeshGlowCopyComponent_Fresnel_C")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class BP_MeshGlowCopyComponent_Fresnel_C : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023202 RID: 143874 RVA: 0x0091B1E7 File Offset: 0x009193E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshGlowCopyComponent_Fresnel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_InteractionBrigthComponent/BP_MeshGlowCopyComponent_Fresnel.BP_MeshGlowCopyComponent_Fresnel_C");
			}
			return BP_MeshGlowCopyComponent_Fresnel_C._ClassPtr;
		}

		// Token: 0x06023203 RID: 143875 RVA: 0x0091B20C File Offset: 0x0091940C
		public BP_MeshGlowCopyComponent_Fresnel_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshGlowCopyComponent_Fresnel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023204 RID: 143876 RVA: 0x0091B234 File Offset: 0x00919434
		[NullableContext(1)]
		public BP_MeshGlowCopyComponent_Fresnel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshGlowCopyComponent_Fresnel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x06023205 RID: 143877 RVA: 0x0091B267 File Offset: 0x00919467
		// (set) Token: 0x06023206 RID: 143878 RVA: 0x0091B27B File Offset: 0x0091947B
		public unsafe UMaterialInterface OverlayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x06023207 RID: 143879 RVA: 0x0091B290 File Offset: 0x00919490
		// (set) Token: 0x06023208 RID: 143880 RVA: 0x0091B2A4 File Offset: 0x009194A4
		public unsafe FName ParameterName_GlowProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x06023209 RID: 143881 RVA: 0x0091B2B9 File Offset: 0x009194B9
		// (set) Token: 0x0602320A RID: 143882 RVA: 0x0091B2CD File Offset: 0x009194CD
		public unsafe UStaticMeshComponent CopiedMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x0602320B RID: 143883 RVA: 0x0091B2E2 File Offset: 0x009194E2
		// (set) Token: 0x0602320C RID: 143884 RVA: 0x0091B2F6 File Offset: 0x009194F6
		public unsafe FName ParameterName_GlowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003FA6 RID: 16294
		// (get) Token: 0x0602320D RID: 143885 RVA: 0x0091B30B File Offset: 0x0091950B
		// (set) Token: 0x0602320E RID: 143886 RVA: 0x0091B320 File Offset: 0x00919520
		[Nullable(1)]
		public TSoftObjectPtr<UMaterialInstanceDynamic> GlowMID
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_5, this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_5, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003FA7 RID: 16295
		// (get) Token: 0x0602320F RID: 143887 RVA: 0x0091B345 File Offset: 0x00919545
		// (set) Token: 0x06023210 RID: 143888 RVA: 0x0091B359 File Offset: 0x00919559
		public unsafe UStaticMeshComponent SourceMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003FA8 RID: 16296
		// (get) Token: 0x06023211 RID: 143889 RVA: 0x0091B36E File Offset: 0x0091956E
		// (set) Token: 0x06023212 RID: 143890 RVA: 0x0091B37E File Offset: 0x0091957E
		public unsafe float GlowProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003FA9 RID: 16297
		// (get) Token: 0x06023213 RID: 143891 RVA: 0x0091B38F File Offset: 0x0091958F
		// (set) Token: 0x06023214 RID: 143892 RVA: 0x0091B39F File Offset: 0x0091959F
		public unsafe float LastProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003FAA RID: 16298
		// (get) Token: 0x06023215 RID: 143893 RVA: 0x0091B3B0 File Offset: 0x009195B0
		// (set) Token: 0x06023216 RID: 143894 RVA: 0x0091B3C4 File Offset: 0x009195C4
		public unsafe FLinearColor GlowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshGlowCopyComponent_Fresnel_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x06023217 RID: 143895 RVA: 0x0091B3DC File Offset: 0x009195DC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Vector_Paramater_Value_Soft(TSoftObjectPtr<UMaterialInstanceDynamic> TargetSoft, FName ParameterName, FLinearColor Value)
		{
			BP_MeshGlowCopyComponent_Fresnel_C.__Set_Vector_Paramater_Value_Soft_FunctionParams* ptr = stackalloc BP_MeshGlowCopyComponent_Fresnel_C.__Set_Vector_Paramater_Value_Soft_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(BP_MeshGlowCopyComponent_Fresnel_C.__Set_Vector_Paramater_Value_Soft_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshGlowCopyComponent_Fresnel_C.__Set_Vector_Paramater_Value_Soft_NativeFunctionPtr, (void*)ptr, 1);
			if (TargetSoft != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->TargetSoft, TargetSoft.NativePtr, 1);
			}
			ptr->ParameterName = ParameterName;
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGlowCopyComponent_Fresnel_C.__Set_Vector_Paramater_Value_Soft_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_MeshGlowCopyComponent_Fresnel_C.__Set_Vector_Paramater_Value_Soft_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023218 RID: 143896 RVA: 0x0091B458 File Offset: 0x00919658
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Set_Scalar_Parameter_Value_Soft(TSoftObjectPtr<UMaterialInstanceDynamic> TargetSoft, FName ParameterName, float Value)
		{
			BP_MeshGlowCopyComponent_Fresnel_C.__Set_Scalar_Parameter_Value_Soft_FunctionParams* ptr = stackalloc BP_MeshGlowCopyComponent_Fresnel_C.__Set_Scalar_Parameter_Value_Soft_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_MeshGlowCopyComponent_Fresnel_C.__Set_Scalar_Parameter_Value_Soft_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshGlowCopyComponent_Fresnel_C.__Set_Scalar_Parameter_Value_Soft_NativeFunctionPtr, (void*)ptr, 1);
			if (TargetSoft != null)
			{
				FSoftObjectPtr.NativeCopy(&ptr->TargetSoft, TargetSoft.NativePtr, 1);
			}
			ptr->ParameterName = ParameterName;
			ptr->Value = Value;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGlowCopyComponent_Fresnel_C.__Set_Scalar_Parameter_Value_Soft_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(BP_MeshGlowCopyComponent_Fresnel_C.__Set_Scalar_Parameter_Value_Soft_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06023219 RID: 143897 RVA: 0x0091B4D2 File Offset: 0x009196D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Create_Copyed_Material_Instances()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGlowCopyComponent_Fresnel_C.__Create_Copyed_Material_Instances_NativeFunctionPtr, null);
		}

		// Token: 0x0602321A RID: 143898 RVA: 0x0091B4E6 File Offset: 0x009196E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602321B RID: 143899 RVA: 0x0091B4FA File Offset: 0x009196FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602321C RID: 143900 RVA: 0x0091B510 File Offset: 0x00919710
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602321D RID: 143901 RVA: 0x0091B558 File Offset: 0x00919758
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshGlowCopyComponent_Fresnel_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602321E RID: 143902 RVA: 0x0091B59F File Offset: 0x0091979F
		protected BP_MeshGlowCopyComponent_Fresnel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114E7 RID: 70887
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_InteractionBrigthComponent/BP_MeshGlowCopyComponent_Fresnel.BP_MeshGlowCopyComponent_Fresnel_C";

		// Token: 0x040114E8 RID: 70888
		private static IntPtr _ClassPtr;

		// Token: 0x040114E9 RID: 70889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114EA RID: 70890
		internal static int __PropertyOffset_1;

		// Token: 0x040114EB RID: 70891
		internal static int __PropertyOffset_2;

		// Token: 0x040114EC RID: 70892
		internal static int __PropertyOffset_3;

		// Token: 0x040114ED RID: 70893
		internal static int __PropertyOffset_4;

		// Token: 0x040114EE RID: 70894
		internal static int __PropertyOffset_5;

		// Token: 0x040114EF RID: 70895
		internal static int __PropertyOffset_6;

		// Token: 0x040114F0 RID: 70896
		internal static int __PropertyOffset_7;

		// Token: 0x040114F1 RID: 70897
		internal static int __PropertyOffset_8;

		// Token: 0x040114F2 RID: 70898
		internal static int __PropertyOffset_9;

		// Token: 0x040114F3 RID: 70899
		private static IntPtr __Set_Vector_Paramater_Value_Soft_NativeFunctionPtr;

		// Token: 0x040114F4 RID: 70900
		private static IntPtr __Set_Scalar_Parameter_Value_Soft_NativeFunctionPtr;

		// Token: 0x040114F5 RID: 70901
		private static IntPtr __Create_Copyed_Material_Instances_NativeFunctionPtr;

		// Token: 0x040114F6 RID: 70902
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040114F7 RID: 70903
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E15 RID: 40469
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __Set_Vector_Paramater_Value_Soft_FunctionParams
		{
			// Token: 0x04031654 RID: 202324
			[FieldOffset(0)]
			public byte TargetSoft;

			// Token: 0x04031655 RID: 202325
			[FieldOffset(48)]
			public FName ParameterName;

			// Token: 0x04031656 RID: 202326
			[FieldOffset(60)]
			public FLinearColor Value;
		}

		// Token: 0x02009E16 RID: 40470
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __Set_Scalar_Parameter_Value_Soft_FunctionParams
		{
			// Token: 0x04031657 RID: 202327
			[FieldOffset(0)]
			public byte TargetSoft;

			// Token: 0x04031658 RID: 202328
			[FieldOffset(48)]
			public FName ParameterName;

			// Token: 0x04031659 RID: 202329
			[FieldOffset(60)]
			public float Value;
		}

		// Token: 0x02009E17 RID: 40471
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403165A RID: 202330
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
