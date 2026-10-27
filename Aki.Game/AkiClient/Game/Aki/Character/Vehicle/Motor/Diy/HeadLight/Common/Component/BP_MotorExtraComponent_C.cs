using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.Lensflare;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.VolumetricConeLight;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Diy.HeadLight.Common.Component
{
	// Token: 0x02004045 RID: 16453
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/Component/BP_MotorExtraComponent.BP_MotorExtraComponent_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class BP_MotorExtraComponent_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A478 RID: 173176 RVA: 0x009DB1CF File Offset: 0x009D93CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MotorExtraComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/Component/BP_MotorExtraComponent.BP_MotorExtraComponent_C");
			}
			return BP_MotorExtraComponent_C._ClassPtr;
		}

		// Token: 0x0602A479 RID: 173177 RVA: 0x009DB1F4 File Offset: 0x009D93F4
		public BP_MotorExtraComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_MotorExtraComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A47A RID: 173178 RVA: 0x009DB21C File Offset: 0x009D941C
		[NullableContext(1)]
		public BP_MotorExtraComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MotorExtraComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067A7 RID: 26535
		// (get) Token: 0x0602A47B RID: 173179 RVA: 0x009DB24F File Offset: 0x009D944F
		// (set) Token: 0x0602A47C RID: 173180 RVA: 0x009DB263 File Offset: 0x009D9463
		public unsafe UKuroMaterialControllerComponent MaterialControllerComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170067A8 RID: 26536
		// (get) Token: 0x0602A47D RID: 173181 RVA: 0x009DB278 File Offset: 0x009D9478
		// (set) Token: 0x0602A47E RID: 173182 RVA: 0x009DB28C File Offset: 0x009D948C
		public unsafe AActor MotorActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170067A9 RID: 26537
		// (get) Token: 0x0602A47F RID: 173183 RVA: 0x009DB2A1 File Offset: 0x009D94A1
		// (set) Token: 0x0602A480 RID: 173184 RVA: 0x009DB2B5 File Offset: 0x009D94B5
		public unsafe ADecalActor DecalActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ADecalActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170067AA RID: 26538
		// (get) Token: 0x0602A481 RID: 173185 RVA: 0x009DB2CA File Offset: 0x009D94CA
		// (set) Token: 0x0602A482 RID: 173186 RVA: 0x009DB2DE File Offset: 0x009D94DE
		public unsafe BP_SceneLensflare_Motor_C LensflareActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneLensflare_Motor_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170067AB RID: 26539
		// (get) Token: 0x0602A483 RID: 173187 RVA: 0x009DB2F3 File Offset: 0x009D94F3
		// (set) Token: 0x0602A484 RID: 173188 RVA: 0x009DB307 File Offset: 0x009D9507
		public unsafe BP_VolumetricConeLightShaft_InMotor_C VolumeLightActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_VolumetricConeLightShaft_InMotor_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MotorExtraComponent_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x0602A485 RID: 173189 RVA: 0x009DB31C File Offset: 0x009D951C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisplayAllMotorExtraComponent_Func()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__DisplayAllMotorExtraComponent_Func_NativeFunctionPtr, null);
		}

		// Token: 0x0602A486 RID: 173190 RVA: 0x009DB330 File Offset: 0x009D9530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HiddenAllMotorExtraComponent_Func()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__HiddenAllMotorExtraComponent_Func_NativeFunctionPtr, null);
		}

		// Token: 0x0602A487 RID: 173191 RVA: 0x009DB344 File Offset: 0x009D9544
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveAllMotorExtraComponent_Func()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__RemoveAllMotorExtraComponent_Func_NativeFunctionPtr, null);
		}

		// Token: 0x0602A488 RID: 173192 RVA: 0x009DB358 File Offset: 0x009D9558
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddAllMotorExtraComponent_Func(UObject MotorSetupDA, AActor MotorActor)
		{
			BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_FunctionParams* ptr = stackalloc BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MotorSetupDA = ((MotorSetupDA != null) ? MotorSetupDA.NativePtr : IntPtr.Zero);
			ptr->MotorActor = ((MotorActor != null) ? MotorActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__AddAllMotorExtraComponent_Func_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A489 RID: 173193 RVA: 0x009DB3C4 File Offset: 0x009D95C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetupVolumeLight_Func(PD_MotorExtraComponentData_C MotorSetupDA, AActor MotorActor, USkeletalMeshComponent MotorSkeletalMeshActor)
		{
			BP_MotorExtraComponent_C.__SetupVolumeLight_Func_FunctionParams* ptr = stackalloc BP_MotorExtraComponent_C.__SetupVolumeLight_Func_FunctionParams[(UIntPtr)399] + 15L / (long)sizeof(BP_MotorExtraComponent_C.__SetupVolumeLight_Func_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorExtraComponent_C.__SetupVolumeLight_Func_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MotorSetupDA = ((MotorSetupDA != null) ? MotorSetupDA.NativePtr : IntPtr.Zero);
			ptr->MotorActor = ((MotorActor != null) ? MotorActor.NativePtr : IntPtr.Zero);
			ptr->MotorSkeletalMeshActor = ((MotorSkeletalMeshActor != null) ? MotorSkeletalMeshActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__SetupVolumeLight_Func_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A48A RID: 173194 RVA: 0x009DB448 File Offset: 0x009D9648
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetupSceneLensflare_Func(PD_MotorExtraComponentData_C MotorSetupDA, AActor MotorActor, USkeletalMeshComponent MotorSkeletalMeshActor)
		{
			BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_FunctionParams* ptr = stackalloc BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_FunctionParams[(UIntPtr)399] + 15L / (long)sizeof(BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MotorSetupDA = ((MotorSetupDA != null) ? MotorSetupDA.NativePtr : IntPtr.Zero);
			ptr->MotorActor = ((MotorActor != null) ? MotorActor.NativePtr : IntPtr.Zero);
			ptr->MotorSkeletalMeshActor = ((MotorSkeletalMeshActor != null) ? MotorSkeletalMeshActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__SetupSceneLensflare_Func_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A48B RID: 173195 RVA: 0x009DB4CC File Offset: 0x009D96CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetupAoDecal_Func(PD_MotorExtraComponentData_C MotorSetupDA, AActor MotorActor, USkeletalMeshComponent MotorSkeletalMeshActor)
		{
			BP_MotorExtraComponent_C.__SetupAoDecal_Func_FunctionParams* ptr = stackalloc BP_MotorExtraComponent_C.__SetupAoDecal_Func_FunctionParams[(UIntPtr)399] + 15L / (long)sizeof(BP_MotorExtraComponent_C.__SetupAoDecal_Func_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MotorExtraComponent_C.__SetupAoDecal_Func_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MotorSetupDA = ((MotorSetupDA != null) ? MotorSetupDA.NativePtr : IntPtr.Zero);
			ptr->MotorActor = ((MotorActor != null) ? MotorActor.NativePtr : IntPtr.Zero);
			ptr->MotorSkeletalMeshActor = ((MotorSkeletalMeshActor != null) ? MotorSkeletalMeshActor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MotorExtraComponent_C.__SetupAoDecal_Func_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A48C RID: 173196 RVA: 0x009DB550 File Offset: 0x009D9750
		protected BP_MotorExtraComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CD3 RID: 89299
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Diy/HeadLight/Common/Component/BP_MotorExtraComponent.BP_MotorExtraComponent_C";

		// Token: 0x04015CD4 RID: 89300
		private static IntPtr _ClassPtr;

		// Token: 0x04015CD5 RID: 89301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CD6 RID: 89302
		internal static int __PropertyOffset_0;

		// Token: 0x04015CD7 RID: 89303
		internal static int __PropertyOffset_1;

		// Token: 0x04015CD8 RID: 89304
		internal static int __PropertyOffset_2;

		// Token: 0x04015CD9 RID: 89305
		internal static int __PropertyOffset_3;

		// Token: 0x04015CDA RID: 89306
		internal static int __PropertyOffset_4;

		// Token: 0x04015CDB RID: 89307
		private static IntPtr __DisplayAllMotorExtraComponent_Func_NativeFunctionPtr;

		// Token: 0x04015CDC RID: 89308
		private static IntPtr __HiddenAllMotorExtraComponent_Func_NativeFunctionPtr;

		// Token: 0x04015CDD RID: 89309
		private static IntPtr __RemoveAllMotorExtraComponent_Func_NativeFunctionPtr;

		// Token: 0x04015CDE RID: 89310
		private static IntPtr __AddAllMotorExtraComponent_Func_NativeFunctionPtr;

		// Token: 0x04015CDF RID: 89311
		private static IntPtr __SetupVolumeLight_Func_NativeFunctionPtr;

		// Token: 0x04015CE0 RID: 89312
		private static IntPtr __SetupSceneLensflare_Func_NativeFunctionPtr;

		// Token: 0x04015CE1 RID: 89313
		private static IntPtr __SetupAoDecal_Func_NativeFunctionPtr;

		// Token: 0x0200A359 RID: 41817
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __AddAllMotorExtraComponent_Func_FunctionParams
		{
			// Token: 0x04032121 RID: 205089
			[FieldOffset(0)]
			public IntPtr MotorSetupDA;

			// Token: 0x04032122 RID: 205090
			[FieldOffset(8)]
			public IntPtr MotorActor;
		}

		// Token: 0x0200A35A RID: 41818
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 384)]
		protected ref struct __SetupVolumeLight_Func_FunctionParams
		{
			// Token: 0x04032123 RID: 205091
			[FieldOffset(0)]
			public IntPtr MotorSetupDA;

			// Token: 0x04032124 RID: 205092
			[FieldOffset(8)]
			public IntPtr MotorActor;

			// Token: 0x04032125 RID: 205093
			[FieldOffset(16)]
			public IntPtr MotorSkeletalMeshActor;
		}

		// Token: 0x0200A35B RID: 41819
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 384)]
		protected ref struct __SetupSceneLensflare_Func_FunctionParams
		{
			// Token: 0x04032126 RID: 205094
			[FieldOffset(0)]
			public IntPtr MotorSetupDA;

			// Token: 0x04032127 RID: 205095
			[FieldOffset(8)]
			public IntPtr MotorActor;

			// Token: 0x04032128 RID: 205096
			[FieldOffset(16)]
			public IntPtr MotorSkeletalMeshActor;
		}

		// Token: 0x0200A35C RID: 41820
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 384)]
		protected ref struct __SetupAoDecal_Func_FunctionParams
		{
			// Token: 0x04032129 RID: 205097
			[FieldOffset(0)]
			public IntPtr MotorSetupDA;

			// Token: 0x0403212A RID: 205098
			[FieldOffset(8)]
			public IntPtr MotorActor;

			// Token: 0x0403212B RID: 205099
			[FieldOffset(16)]
			public IntPtr MotorSkeletalMeshActor;
		}
	}
}
