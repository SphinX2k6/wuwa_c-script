using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Ice
{
	// Token: 0x02003C9C RID: 15516
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Ice/BP_IceCollision.BP_IceCollision_C")]
	[UnrealStructLayout(1344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1344)]
	public class BP_IceCollision_C : AKuroCSSimpleCollision, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024604 RID: 148996 RVA: 0x0093CDA8 File Offset: 0x0093AFA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_IceCollision_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Ice/BP_IceCollision.BP_IceCollision_C");
			}
			return BP_IceCollision_C._ClassPtr;
		}

		// Token: 0x06024605 RID: 148997 RVA: 0x0093CDCC File Offset: 0x0093AFCC
		public BP_IceCollision_C() : this(BuiltinUtils.AllocNativeUObject(BP_IceCollision_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024606 RID: 148998 RVA: 0x0093CDF4 File Offset: 0x0093AFF4
		[NullableContext(1)]
		public BP_IceCollision_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_IceCollision_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046B7 RID: 18103
		// (get) Token: 0x06024607 RID: 148999 RVA: 0x0093CE27 File Offset: 0x0093B027
		// (set) Token: 0x06024608 RID: 149000 RVA: 0x0093CE3B File Offset: 0x0093B03B
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170046B8 RID: 18104
		// (get) Token: 0x06024609 RID: 149001 RVA: 0x0093CE50 File Offset: 0x0093B050
		// (set) Token: 0x0602460A RID: 149002 RVA: 0x0093CE64 File Offset: 0x0093B064
		public unsafe UMaterialInterface RenderMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170046B9 RID: 18105
		// (get) Token: 0x0602460B RID: 149003 RVA: 0x0093CE79 File Offset: 0x0093B079
		// (set) Token: 0x0602460C RID: 149004 RVA: 0x0093CE8D File Offset: 0x0093B08D
		public unsafe UMaterialInterface RenderMat_OceanWave
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170046BA RID: 18106
		// (get) Token: 0x0602460D RID: 149005 RVA: 0x0093CEA2 File Offset: 0x0093B0A2
		// (set) Token: 0x0602460E RID: 149006 RVA: 0x0093CEB6 File Offset: 0x0093B0B6
		public unsafe UTextureRenderTarget2D T_Particle_Pivot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170046BB RID: 18107
		// (get) Token: 0x0602460F RID: 149007 RVA: 0x0093CECB File Offset: 0x0093B0CB
		// (set) Token: 0x06024610 RID: 149008 RVA: 0x0093CEDB File Offset: 0x0093B0DB
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceCollision_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceCollision_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046BC RID: 18108
		// (get) Token: 0x06024611 RID: 149009 RVA: 0x0093CEEC File Offset: 0x0093B0EC
		// (set) Token: 0x06024612 RID: 149010 RVA: 0x0093CEFC File Offset: 0x0093B0FC
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceCollision_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceCollision_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046BD RID: 18109
		// (get) Token: 0x06024613 RID: 149011 RVA: 0x0093CF0D File Offset: 0x0093B10D
		// (set) Token: 0x06024614 RID: 149012 RVA: 0x0093CF21 File Offset: 0x0093B121
		public unsafe UMaterialInterface CopyTexMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170046BE RID: 18110
		// (get) Token: 0x06024615 RID: 149013 RVA: 0x0093CF36 File Offset: 0x0093B136
		// (set) Token: 0x06024616 RID: 149014 RVA: 0x0093CF4A File Offset: 0x0093B14A
		public unsafe UMaterialInstanceDynamic RenderMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x170046BF RID: 18111
		// (get) Token: 0x06024617 RID: 149015 RVA: 0x0093CF5F File Offset: 0x0093B15F
		// (set) Token: 0x06024618 RID: 149016 RVA: 0x0093CF73 File Offset: 0x0093B173
		public unsafe UStaticMesh SM_Ice1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170046C0 RID: 18112
		// (get) Token: 0x06024619 RID: 149017 RVA: 0x0093CF88 File Offset: 0x0093B188
		// (set) Token: 0x0602461A RID: 149018 RVA: 0x0093CF9C File Offset: 0x0093B19C
		public unsafe UStaticMesh SM_Ice2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x170046C1 RID: 18113
		// (get) Token: 0x0602461B RID: 149019 RVA: 0x0093CFB1 File Offset: 0x0093B1B1
		// (set) Token: 0x0602461C RID: 149020 RVA: 0x0093CFC5 File Offset: 0x0093B1C5
		public unsafe UStaticMesh SM_Ice3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170046C2 RID: 18114
		// (get) Token: 0x0602461D RID: 149021 RVA: 0x0093CFDA File Offset: 0x0093B1DA
		// (set) Token: 0x0602461E RID: 149022 RVA: 0x0093CFEE File Offset: 0x0093B1EE
		public unsafe UTexture2D Input_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170046C3 RID: 18115
		// (get) Token: 0x0602461F RID: 149023 RVA: 0x0093D003 File Offset: 0x0093B203
		// (set) Token: 0x06024620 RID: 149024 RVA: 0x0093D017 File Offset: 0x0093B217
		public unsafe UTexture2D Input_Texture_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170046C4 RID: 18116
		// (get) Token: 0x06024621 RID: 149025 RVA: 0x0093D02C File Offset: 0x0093B22C
		// (set) Token: 0x06024622 RID: 149026 RVA: 0x0093D040 File Offset: 0x0093B240
		public unsafe UTexture2D Input_Texture_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_IceCollision_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170046C5 RID: 18117
		// (get) Token: 0x06024623 RID: 149027 RVA: 0x0093D055 File Offset: 0x0093B255
		// (set) Token: 0x06024624 RID: 149028 RVA: 0x0093D065 File Offset: 0x0093B265
		public unsafe bool 使用跟随海浪起伏
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceCollision_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceCollision_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046C6 RID: 18118
		// (get) Token: 0x06024625 RID: 149029 RVA: 0x0093D076 File Offset: 0x0093B276
		// (set) Token: 0x06024626 RID: 149030 RVA: 0x0093D086 File Offset: 0x0093B286
		public unsafe float 跟随海浪起伏强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_IceCollision_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_IceCollision_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x06024627 RID: 149031 RVA: 0x0093D097 File Offset: 0x0093B297
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 应用贴图材质()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceCollision_C.__应用贴图材质_NativeFunctionPtr, null);
		}

		// Token: 0x06024628 RID: 149032 RVA: 0x0093D0AB File Offset: 0x0093B2AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceCollision_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024629 RID: 149033 RVA: 0x0093D0BF File Offset: 0x0093B2BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_IceCollision_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602462A RID: 149034 RVA: 0x0093D0D4 File Offset: 0x0093B2D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceCollision_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602462B RID: 149035 RVA: 0x0093D0E8 File Offset: 0x0093B2E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_IceCollision_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602462C RID: 149036 RVA: 0x0093D100 File Offset: 0x0093B300
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_IceCollision_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_IceCollision_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_IceCollision_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_IceCollision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceCollision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602462D RID: 149037 RVA: 0x0093D148 File Offset: 0x0093B348
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_IceCollision_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_IceCollision_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_IceCollision_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_IceCollision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_IceCollision_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602462E RID: 149038 RVA: 0x0093D190 File Offset: 0x0093B390
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602462F RID: 149039 RVA: 0x0093D24C File Offset: 0x0093B44C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_IceCollision_C.__BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024630 RID: 149040 RVA: 0x0093D2D5 File Offset: 0x0093B4D5
		protected BP_IceCollision_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040120BB RID: 73915
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Ice/BP_IceCollision.BP_IceCollision_C";

		// Token: 0x040120BC RID: 73916
		private static IntPtr _ClassPtr;

		// Token: 0x040120BD RID: 73917
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040120BE RID: 73918
		internal static int __PropertyOffset_1;

		// Token: 0x040120BF RID: 73919
		internal static int __PropertyOffset_2;

		// Token: 0x040120C0 RID: 73920
		internal static int __PropertyOffset_3;

		// Token: 0x040120C1 RID: 73921
		internal static int __PropertyOffset_4;

		// Token: 0x040120C2 RID: 73922
		internal static int __PropertyOffset_5;

		// Token: 0x040120C3 RID: 73923
		internal static int __PropertyOffset_6;

		// Token: 0x040120C4 RID: 73924
		internal static int __PropertyOffset_7;

		// Token: 0x040120C5 RID: 73925
		internal static int __PropertyOffset_8;

		// Token: 0x040120C6 RID: 73926
		internal static int __PropertyOffset_9;

		// Token: 0x040120C7 RID: 73927
		internal static int __PropertyOffset_10;

		// Token: 0x040120C8 RID: 73928
		internal static int __PropertyOffset_11;

		// Token: 0x040120C9 RID: 73929
		internal static int __PropertyOffset_12;

		// Token: 0x040120CA RID: 73930
		internal static int __PropertyOffset_13;

		// Token: 0x040120CB RID: 73931
		internal static int __PropertyOffset_14;

		// Token: 0x040120CC RID: 73932
		internal static int __PropertyOffset_15;

		// Token: 0x040120CD RID: 73933
		internal static int __PropertyOffset_16;

		// Token: 0x040120CE RID: 73934
		private static IntPtr __应用贴图材质_NativeFunctionPtr;

		// Token: 0x040120CF RID: 73935
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040120D0 RID: 73936
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040120D1 RID: 73937
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040120D2 RID: 73938
		private static IntPtr __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040120D3 RID: 73939
		private static IntPtr __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009F0D RID: 40717
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031857 RID: 202839
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F0E RID: 40718
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031858 RID: 202840
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031859 RID: 202841
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403185A RID: 202842
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403185B RID: 202843
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403185C RID: 202844
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403185D RID: 202845
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F0F RID: 40719
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_IceCollision_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403185E RID: 202846
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403185F RID: 202847
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031860 RID: 202848
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031861 RID: 202849
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
