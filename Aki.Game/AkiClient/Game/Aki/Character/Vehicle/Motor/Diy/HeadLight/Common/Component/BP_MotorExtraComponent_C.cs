using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.Component
{
	// Token: 0x0200328F RID: 12943
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/Component/BP_MotorExtraComponent.BP_MotorExtraComponent_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class BP_MotorExtraComponent_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060206A3 RID: 132771 RVA: 0x00945DCF File Offset: 0x00943FCF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MotorExtraComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/Component/BP_MotorExtraComponent.BP_MotorExtraComponent_C");
			}
			return BP_MotorExtraComponent_C._ClassPtr;
		}

		// Token: 0x060206A4 RID: 132772 RVA: 0x00945DF4 File Offset: 0x00943FF4
		public BP_MotorExtraComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_MotorExtraComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060206A5 RID: 132773 RVA: 0x00945E1C File Offset: 0x0094401C
		[NullableContext(1)]
		public BP_MotorExtraComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MotorExtraComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x060206A6 RID: 132774 RVA: 0x00945E4F File Offset: 0x0094404F
		// (set) Token: 0x060206A7 RID: 132775 RVA: 0x00945E63 File Offset: 0x00944063
		public unsafe UKuroMaterialControllerComponent MaterialControllerComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_MaterialControllerComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_MaterialControllerComp, value);
			}
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x060206A8 RID: 132776 RVA: 0x00945E78 File Offset: 0x00944078
		// (set) Token: 0x060206A9 RID: 132777 RVA: 0x00945E8C File Offset: 0x0094408C
		public unsafe AActor MotorActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_MotorActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_MotorActor, value);
			}
		}

		// Token: 0x17003EEE RID: 16110
		// (get) Token: 0x060206AA RID: 132778 RVA: 0x00945EA1 File Offset: 0x009440A1
		// (set) Token: 0x060206AB RID: 132779 RVA: 0x00945EB5 File Offset: 0x009440B5
		public unsafe ADecalActor DecalActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADecalActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_DecalActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_DecalActor, value);
			}
		}

		// Token: 0x060206AC RID: 132780 RVA: 0x00945ECA File Offset: 0x009440CA
		[SkipLocalsInit]
		public virtual void DisplayAllMotorExtraComponent_Func()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__DisplayAllMotorExtraComponent_Func_NativeFunctionPtr, null);
		}

		// Token: 0x060206AD RID: 132781 RVA: 0x00945EDE File Offset: 0x009440DE
		[SkipLocalsInit]
		public virtual void HiddenAllMotorExtraComponent_Func()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__HiddenAllMotorExtraComponent_Func_NativeFunctionPtr, null);
		}

		// Token: 0x060206AE RID: 132782 RVA: 0x00945EF2 File Offset: 0x009440F2
		[SkipLocalsInit]
		public virtual void RemoveAllMotorExtraComponent_Func()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__RemoveAllMotorExtraComponent_Func_NativeFunctionPtr, null);
		}

		// Token: 0x060206AF RID: 132783 RVA: 0x00945F08 File Offset: 0x00944108
		[SkipLocalsInit]
		public unsafe virtual void AddAllMotorExtraComponent_Func(UObject MotorSetupDA, AActor MotorActor)
		{
			BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_FunctionParams* ptr = stackalloc BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MotorSetupDA = ((MotorSetupDA != null) ? MotorSetupDA.NativePtr : IntPtr.Zero);
			ptr->MotorActor = ((MotorActor != null) ? MotorActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060206B0 RID: 132784 RVA: 0x00945F74 File Offset: 0x00944174
		[SkipLocalsInit]
		public unsafe virtual void SetupVolumeLight_Func(PD_MotorExtraComponentData_C MotorSetupDA, AActor MotorActor, USkeletalMeshComponent MotorSkeletalMeshActor)
		{
			BP_MotorExtraComponent_C.__SetupVolumeLight_Func_FunctionParams* ptr = stackalloc BP_MotorExtraComponent_C.__SetupVolumeLight_Func_FunctionParams[(UIntPtr)399] + 15L / (long)sizeof(BP_MotorExtraComponent_C.__SetupVolumeLight_Func_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorExtraComponent_C.__SetupVolumeLight_Func_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MotorSetupDA = ((MotorSetupDA != null) ? MotorSetupDA.NativePtr : IntPtr.Zero);
			ptr->MotorActor = ((MotorActor != null) ? MotorActor.NativePtr : IntPtr.Zero);
			ptr->MotorSkeletalMeshActor = ((MotorSkeletalMeshActor != null) ? MotorSkeletalMeshActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__SetupVolumeLight_Func_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060206B1 RID: 132785 RVA: 0x00945FF8 File Offset: 0x009441F8
		[SkipLocalsInit]
		public unsafe virtual void SetupSceneLensflare_Func(PD_MotorExtraComponentData_C MotorSetupDA, AActor MotorActor, USkeletalMeshComponent MotorSkeletalMeshActor)
		{
			BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_FunctionParams* ptr = stackalloc BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_FunctionParams[(UIntPtr)399] + 15L / (long)sizeof(BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MotorSetupDA = ((MotorSetupDA != null) ? MotorSetupDA.NativePtr : IntPtr.Zero);
			ptr->MotorActor = ((MotorActor != null) ? MotorActor.NativePtr : IntPtr.Zero);
			ptr->MotorSkeletalMeshActor = ((MotorSkeletalMeshActor != null) ? MotorSkeletalMeshActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060206B2 RID: 132786 RVA: 0x0094607C File Offset: 0x0094427C
		[SkipLocalsInit]
		public unsafe virtual void SetupAoDecal_Func(PD_MotorExtraComponentData_C MotorSetupDA, AActor MotorActor, USkeletalMeshComponent MotorSkeletalMeshActor)
		{
			BP_MotorExtraComponent_C.__SetupAoDecal_Func_FunctionParams* ptr = stackalloc BP_MotorExtraComponent_C.__SetupAoDecal_Func_FunctionParams[(UIntPtr)399] + 15L / (long)sizeof(BP_MotorExtraComponent_C.__SetupAoDecal_Func_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorExtraComponent_C.__SetupAoDecal_Func_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MotorSetupDA = ((MotorSetupDA != null) ? MotorSetupDA.NativePtr : IntPtr.Zero);
			ptr->MotorActor = ((MotorActor != null) ? MotorActor.NativePtr : IntPtr.Zero);
			ptr->MotorSkeletalMeshActor = ((MotorSkeletalMeshActor != null) ? MotorSkeletalMeshActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__SetupAoDecal_Func_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060206B3 RID: 132787 RVA: 0x00946100 File Offset: 0x00944300
		protected BP_MotorExtraComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401181F RID: 71711
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/Component/BP_MotorExtraComponent.BP_MotorExtraComponent_C";

		// Token: 0x04011820 RID: 71712
		private static IntPtr _ClassPtr;

		// Token: 0x04011821 RID: 71713
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011822 RID: 71714
		internal static int __PropertyOffset_MaterialControllerComp;

		// Token: 0x04011823 RID: 71715
		internal static int __PropertyOffset_MotorActor;

		// Token: 0x04011824 RID: 71716
		internal static int __PropertyOffset_DecalActor;

		// Token: 0x04011825 RID: 71717
		private static IntPtr __DisplayAllMotorExtraComponent_Func_NativeFunctionPtr;

		// Token: 0x04011826 RID: 71718
		private static IntPtr __HiddenAllMotorExtraComponent_Func_NativeFunctionPtr;

		// Token: 0x04011827 RID: 71719
		private static IntPtr __RemoveAllMotorExtraComponent_Func_NativeFunctionPtr;

		// Token: 0x04011828 RID: 71720
		private static IntPtr __AddAllMotorExtraComponent_Func_NativeFunctionPtr;

		// Token: 0x04011829 RID: 71721
		private static IntPtr __SetupVolumeLight_Func_NativeFunctionPtr;

		// Token: 0x0401182A RID: 71722
		private static IntPtr __SetupSceneLensflare_Func_NativeFunctionPtr;

		// Token: 0x0401182B RID: 71723
		private static IntPtr __SetupAoDecal_Func_NativeFunctionPtr;

		// Token: 0x02008F63 RID: 36707
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __AddAllMotorExtraComponent_Func_FunctionParams
		{
			// Token: 0x0402CCDA RID: 183514
			[FieldOffset(0)]
			public IntPtr MotorSetupDA;

			// Token: 0x0402CCDB RID: 183515
			[FieldOffset(8)]
			public IntPtr MotorActor;
		}

		// Token: 0x02008F64 RID: 36708
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 384)]
		protected ref struct __SetupVolumeLight_Func_FunctionParams
		{
			// Token: 0x0402CCDC RID: 183516
			[FieldOffset(0)]
			public IntPtr MotorSetupDA;

			// Token: 0x0402CCDD RID: 183517
			[FieldOffset(8)]
			public IntPtr MotorActor;

			// Token: 0x0402CCDE RID: 183518
			[FieldOffset(16)]
			public IntPtr MotorSkeletalMeshActor;
		}

		// Token: 0x02008F65 RID: 36709
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 384)]
		protected ref struct __SetupSceneLensflare_Func_FunctionParams
		{
			// Token: 0x0402CCDF RID: 183519
			[FieldOffset(0)]
			public IntPtr MotorSetupDA;

			// Token: 0x0402CCE0 RID: 183520
			[FieldOffset(8)]
			public IntPtr MotorActor;

			// Token: 0x0402CCE1 RID: 183521
			[FieldOffset(16)]
			public IntPtr MotorSkeletalMeshActor;
		}

		// Token: 0x02008F66 RID: 36710
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 384)]
		protected ref struct __SetupAoDecal_Func_FunctionParams
		{
			// Token: 0x0402CCE2 RID: 183522
			[FieldOffset(0)]
			public IntPtr MotorSetupDA;

			// Token: 0x0402CCE3 RID: 183523
			[FieldOffset(8)]
			public IntPtr MotorActor;

			// Token: 0x0402CCE4 RID: 183524
			[FieldOffset(16)]
			public IntPtr MotorSkeletalMeshActor;
		}
	}
}
