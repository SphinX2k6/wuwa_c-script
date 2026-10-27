using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CB4 RID: 15540
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_BubbleCol.BP_BubbleCol_C")]
	[UnrealStructLayout(1752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1752)]
	public class BP_BubbleCol_C : AKuroCSRpbd, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024966 RID: 149862 RVA: 0x009431E4 File Offset: 0x009413E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BubbleCol_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_BubbleCol.BP_BubbleCol_C");
			}
			return BP_BubbleCol_C._ClassPtr;
		}

		// Token: 0x06024967 RID: 149863 RVA: 0x00943208 File Offset: 0x00941408
		public BP_BubbleCol_C() : this(BuiltinUtils.AllocNativeUObject(BP_BubbleCol_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024968 RID: 149864 RVA: 0x00943230 File Offset: 0x00941430
		[NullableContext(1)]
		public BP_BubbleCol_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BubbleCol_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170047D6 RID: 18390
		// (get) Token: 0x06024969 RID: 149865 RVA: 0x00943263 File Offset: 0x00941463
		// (set) Token: 0x0602496A RID: 149866 RVA: 0x00943277 File Offset: 0x00941477
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170047D7 RID: 18391
		// (get) Token: 0x0602496B RID: 149867 RVA: 0x0094328C File Offset: 0x0094148C
		// (set) Token: 0x0602496C RID: 149868 RVA: 0x009432A0 File Offset: 0x009414A0
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170047D8 RID: 18392
		// (get) Token: 0x0602496D RID: 149869 RVA: 0x009432B5 File Offset: 0x009414B5
		// (set) Token: 0x0602496E RID: 149870 RVA: 0x009432C9 File Offset: 0x009414C9
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170047D9 RID: 18393
		// (get) Token: 0x0602496F RID: 149871 RVA: 0x009432DE File Offset: 0x009414DE
		// (set) Token: 0x06024970 RID: 149872 RVA: 0x009432F2 File Offset: 0x009414F2
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170047DA RID: 18394
		// (get) Token: 0x06024971 RID: 149873 RVA: 0x00943307 File Offset: 0x00941507
		// (set) Token: 0x06024972 RID: 149874 RVA: 0x0094331B File Offset: 0x0094151B
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170047DB RID: 18395
		// (get) Token: 0x06024973 RID: 149875 RVA: 0x00943330 File Offset: 0x00941530
		// (set) Token: 0x06024974 RID: 149876 RVA: 0x00943340 File Offset: 0x00941540
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047DC RID: 18396
		// (get) Token: 0x06024975 RID: 149877 RVA: 0x00943351 File Offset: 0x00941551
		// (set) Token: 0x06024976 RID: 149878 RVA: 0x00943365 File Offset: 0x00941565
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170047DD RID: 18397
		// (get) Token: 0x06024977 RID: 149879 RVA: 0x0094337A File Offset: 0x0094157A
		// (set) Token: 0x06024978 RID: 149880 RVA: 0x0094338A File Offset: 0x0094158A
		public unsafe float force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170047DE RID: 18398
		// (get) Token: 0x06024979 RID: 149881 RVA: 0x0094339B File Offset: 0x0094159B
		// (set) Token: 0x0602497A RID: 149882 RVA: 0x009433AB File Offset: 0x009415AB
		public unsafe bool Pressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047DF RID: 18399
		// (get) Token: 0x0602497B RID: 149883 RVA: 0x009433BC File Offset: 0x009415BC
		// (set) Token: 0x0602497C RID: 149884 RVA: 0x009433CC File Offset: 0x009415CC
		public unsafe bool FS_isPhysicSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047E0 RID: 18400
		// (get) Token: 0x0602497D RID: 149885 RVA: 0x009433DD File Offset: 0x009415DD
		// (set) Token: 0x0602497E RID: 149886 RVA: 0x009433ED File Offset: 0x009415ED
		public unsafe float mass_in_kg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170047E1 RID: 18401
		// (get) Token: 0x0602497F RID: 149887 RVA: 0x009433FE File Offset: 0x009415FE
		// (set) Token: 0x06024980 RID: 149888 RVA: 0x0094340E File Offset: 0x0094160E
		public unsafe bool editorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047E2 RID: 18402
		// (get) Token: 0x06024981 RID: 149889 RVA: 0x0094341F File Offset: 0x0094161F
		// (set) Token: 0x06024982 RID: 149890 RVA: 0x0094342F File Offset: 0x0094162F
		public unsafe bool _2DRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047E3 RID: 18403
		// (get) Token: 0x06024983 RID: 149891 RVA: 0x00943440 File Offset: 0x00941640
		// (set) Token: 0x06024984 RID: 149892 RVA: 0x00943450 File Offset: 0x00941650
		public unsafe int XCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170047E4 RID: 18404
		// (get) Token: 0x06024985 RID: 149893 RVA: 0x00943461 File Offset: 0x00941661
		// (set) Token: 0x06024986 RID: 149894 RVA: 0x00943471 File Offset: 0x00941671
		public unsafe bool ReadFromBPL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047E5 RID: 18405
		// (get) Token: 0x06024987 RID: 149895 RVA: 0x00943482 File Offset: 0x00941682
		// (set) Token: 0x06024988 RID: 149896 RVA: 0x00943496 File Offset: 0x00941696
		public unsafe UStaticMesh inputStaticMesh_ForBPL_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x170047E6 RID: 18406
		// (get) Token: 0x06024989 RID: 149897 RVA: 0x009434AB File Offset: 0x009416AB
		// (set) Token: 0x0602498A RID: 149898 RVA: 0x009434BB File Offset: 0x009416BB
		public unsafe bool extraOneMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047E7 RID: 18407
		// (get) Token: 0x0602498B RID: 149899 RVA: 0x009434CC File Offset: 0x009416CC
		// (set) Token: 0x0602498C RID: 149900 RVA: 0x009434E0 File Offset: 0x009416E0
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170047E8 RID: 18408
		// (get) Token: 0x0602498D RID: 149901 RVA: 0x009434F5 File Offset: 0x009416F5
		// (set) Token: 0x0602498E RID: 149902 RVA: 0x00943509 File Offset: 0x00941709
		public unsafe UMaterialInstanceDynamic MID1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BubbleCol_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x170047E9 RID: 18409
		// (get) Token: 0x0602498F RID: 149903 RVA: 0x0094351E File Offset: 0x0094171E
		// (set) Token: 0x06024990 RID: 149904 RVA: 0x0094352E File Offset: 0x0094172E
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047EA RID: 18410
		// (get) Token: 0x06024991 RID: 149905 RVA: 0x0094353F File Offset: 0x0094173F
		// (set) Token: 0x06024992 RID: 149906 RVA: 0x0094354F File Offset: 0x0094174F
		public unsafe bool UseYCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047EB RID: 18411
		// (get) Token: 0x06024993 RID: 149907 RVA: 0x00943560 File Offset: 0x00941760
		// (set) Token: 0x06024994 RID: 149908 RVA: 0x00943570 File Offset: 0x00941770
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BubbleCol_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x06024995 RID: 149909 RVA: 0x00943581 File Offset: 0x00941781
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BubbleCol_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024996 RID: 149910 RVA: 0x00943595 File Offset: 0x00941795
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BubbleCol_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024997 RID: 149911 RVA: 0x009435AA File Offset: 0x009417AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BubbleCol_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024998 RID: 149912 RVA: 0x009435BE File Offset: 0x009417BE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BubbleCol_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024999 RID: 149913 RVA: 0x009435D4 File Offset: 0x009417D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BubbleCol_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BubbleCol_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BubbleCol_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BubbleCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BubbleCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602499A RID: 149914 RVA: 0x0094361C File Offset: 0x0094181C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BubbleCol_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BubbleCol_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BubbleCol_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BubbleCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BubbleCol_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602499B RID: 149915 RVA: 0x00943664 File Offset: 0x00941864
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_BubbleCol_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_BubbleCol_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BubbleCol_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BubbleCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BubbleCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602499C RID: 149916 RVA: 0x009436B0 File Offset: 0x009418B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_BubbleCol_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_BubbleCol_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_BubbleCol_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BubbleCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BubbleCol_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602499D RID: 149917 RVA: 0x009436FC File Offset: 0x009418FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			BP_BubbleCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BubbleCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BubbleCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BubbleCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BubbleCol_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602499E RID: 149918 RVA: 0x009437B0 File Offset: 0x009419B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602499F RID: 149919 RVA: 0x0094386C File Offset: 0x00941A6C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BubbleCol_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060249A0 RID: 149920 RVA: 0x009438F5 File Offset: 0x00941AF5
		protected BP_BubbleCol_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040122BF RID: 74431
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_BubbleCol.BP_BubbleCol_C";

		// Token: 0x040122C0 RID: 74432
		private static IntPtr _ClassPtr;

		// Token: 0x040122C1 RID: 74433
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040122C2 RID: 74434
		internal static int __PropertyOffset_1;

		// Token: 0x040122C3 RID: 74435
		internal static int __PropertyOffset_2;

		// Token: 0x040122C4 RID: 74436
		internal static int __PropertyOffset_3;

		// Token: 0x040122C5 RID: 74437
		internal static int __PropertyOffset_4;

		// Token: 0x040122C6 RID: 74438
		internal static int __PropertyOffset_5;

		// Token: 0x040122C7 RID: 74439
		internal static int __PropertyOffset_6;

		// Token: 0x040122C8 RID: 74440
		internal static int __PropertyOffset_7;

		// Token: 0x040122C9 RID: 74441
		internal static int __PropertyOffset_8;

		// Token: 0x040122CA RID: 74442
		internal static int __PropertyOffset_9;

		// Token: 0x040122CB RID: 74443
		internal static int __PropertyOffset_10;

		// Token: 0x040122CC RID: 74444
		internal static int __PropertyOffset_11;

		// Token: 0x040122CD RID: 74445
		internal static int __PropertyOffset_12;

		// Token: 0x040122CE RID: 74446
		internal static int __PropertyOffset_13;

		// Token: 0x040122CF RID: 74447
		internal static int __PropertyOffset_14;

		// Token: 0x040122D0 RID: 74448
		internal static int __PropertyOffset_15;

		// Token: 0x040122D1 RID: 74449
		internal static int __PropertyOffset_16;

		// Token: 0x040122D2 RID: 74450
		internal static int __PropertyOffset_17;

		// Token: 0x040122D3 RID: 74451
		internal static int __PropertyOffset_18;

		// Token: 0x040122D4 RID: 74452
		internal static int __PropertyOffset_19;

		// Token: 0x040122D5 RID: 74453
		internal static int __PropertyOffset_20;

		// Token: 0x040122D6 RID: 74454
		internal static int __PropertyOffset_21;

		// Token: 0x040122D7 RID: 74455
		internal static int __PropertyOffset_22;

		// Token: 0x040122D8 RID: 74456
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040122D9 RID: 74457
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040122DA RID: 74458
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040122DB RID: 74459
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040122DC RID: 74460
		private static IntPtr __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040122DD RID: 74461
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040122DE RID: 74462
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009F48 RID: 40776
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318FA RID: 203002
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F49 RID: 40777
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040318FB RID: 203003
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F4A RID: 40778
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318FC RID: 203004
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x040318FD RID: 203005
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318FE RID: 203006
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318FF RID: 203007
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x04031900 RID: 203008
			[FieldOffset(36)]
			public byte Hit;
		}

		// Token: 0x02009F4B RID: 40779
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031901 RID: 203009
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031902 RID: 203010
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031903 RID: 203011
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031904 RID: 203012
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031905 RID: 203013
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031906 RID: 203014
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F4C RID: 40780
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031907 RID: 203015
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031908 RID: 203016
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031909 RID: 203017
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403190A RID: 203018
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
