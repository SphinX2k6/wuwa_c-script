using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CB5 RID: 15541
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_FootballNet.BP_FootballNet_C")]
	[UnrealStructLayout(1800, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1793)]
	public class BP_FootballNet_C : AKuroCSRpbd, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060249A1 RID: 149921 RVA: 0x009438FE File Offset: 0x00941AFE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FootballNet_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_FootballNet.BP_FootballNet_C");
			}
			return BP_FootballNet_C._ClassPtr;
		}

		// Token: 0x060249A2 RID: 149922 RVA: 0x00943924 File Offset: 0x00941B24
		public BP_FootballNet_C() : this(BuiltinUtils.AllocNativeUObject(BP_FootballNet_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060249A3 RID: 149923 RVA: 0x0094394C File Offset: 0x00941B4C
		[NullableContext(1)]
		public BP_FootballNet_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FootballNet_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170047EC RID: 18412
		// (get) Token: 0x060249A4 RID: 149924 RVA: 0x0094397F File Offset: 0x00941B7F
		// (set) Token: 0x060249A5 RID: 149925 RVA: 0x00943993 File Offset: 0x00941B93
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170047ED RID: 18413
		// (get) Token: 0x060249A6 RID: 149926 RVA: 0x009439A8 File Offset: 0x00941BA8
		// (set) Token: 0x060249A7 RID: 149927 RVA: 0x009439BC File Offset: 0x00941BBC
		public unsafe UStaticMeshComponent SM_Old_Flo_01AL_ST
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170047EE RID: 18414
		// (get) Token: 0x060249A8 RID: 149928 RVA: 0x009439D1 File Offset: 0x00941BD1
		// (set) Token: 0x060249A9 RID: 149929 RVA: 0x009439E5 File Offset: 0x00941BE5
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170047EF RID: 18415
		// (get) Token: 0x060249AA RID: 149930 RVA: 0x009439FA File Offset: 0x00941BFA
		// (set) Token: 0x060249AB RID: 149931 RVA: 0x00943A0E File Offset: 0x00941C0E
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170047F0 RID: 18416
		// (get) Token: 0x060249AC RID: 149932 RVA: 0x00943A23 File Offset: 0x00941C23
		// (set) Token: 0x060249AD RID: 149933 RVA: 0x00943A37 File Offset: 0x00941C37
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170047F1 RID: 18417
		// (get) Token: 0x060249AE RID: 149934 RVA: 0x00943A4C File Offset: 0x00941C4C
		// (set) Token: 0x060249AF RID: 149935 RVA: 0x00943A60 File Offset: 0x00941C60
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170047F2 RID: 18418
		// (get) Token: 0x060249B0 RID: 149936 RVA: 0x00943A75 File Offset: 0x00941C75
		// (set) Token: 0x060249B1 RID: 149937 RVA: 0x00943A89 File Offset: 0x00941C89
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x170047F3 RID: 18419
		// (get) Token: 0x060249B2 RID: 149938 RVA: 0x00943A9E File Offset: 0x00941C9E
		// (set) Token: 0x060249B3 RID: 149939 RVA: 0x00943AAE File Offset: 0x00941CAE
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047F4 RID: 18420
		// (get) Token: 0x060249B4 RID: 149940 RVA: 0x00943ABF File Offset: 0x00941CBF
		// (set) Token: 0x060249B5 RID: 149941 RVA: 0x00943AD3 File Offset: 0x00941CD3
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170047F5 RID: 18421
		// (get) Token: 0x060249B6 RID: 149942 RVA: 0x00943AE8 File Offset: 0x00941CE8
		// (set) Token: 0x060249B7 RID: 149943 RVA: 0x00943AF8 File Offset: 0x00941CF8
		public unsafe float force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170047F6 RID: 18422
		// (get) Token: 0x060249B8 RID: 149944 RVA: 0x00943B09 File Offset: 0x00941D09
		// (set) Token: 0x060249B9 RID: 149945 RVA: 0x00943B19 File Offset: 0x00941D19
		public unsafe bool Pressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047F7 RID: 18423
		// (get) Token: 0x060249BA RID: 149946 RVA: 0x00943B2A File Offset: 0x00941D2A
		// (set) Token: 0x060249BB RID: 149947 RVA: 0x00943B3A File Offset: 0x00941D3A
		public unsafe bool FS_isPhysicSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047F8 RID: 18424
		// (get) Token: 0x060249BC RID: 149948 RVA: 0x00943B4B File Offset: 0x00941D4B
		// (set) Token: 0x060249BD RID: 149949 RVA: 0x00943B5B File Offset: 0x00941D5B
		public unsafe float mass_in_kg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170047F9 RID: 18425
		// (get) Token: 0x060249BE RID: 149950 RVA: 0x00943B6C File Offset: 0x00941D6C
		// (set) Token: 0x060249BF RID: 149951 RVA: 0x00943B7C File Offset: 0x00941D7C
		public unsafe bool editorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047FA RID: 18426
		// (get) Token: 0x060249C0 RID: 149952 RVA: 0x00943B8D File Offset: 0x00941D8D
		// (set) Token: 0x060249C1 RID: 149953 RVA: 0x00943B9D File Offset: 0x00941D9D
		public unsafe bool _2DRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047FB RID: 18427
		// (get) Token: 0x060249C2 RID: 149954 RVA: 0x00943BAE File Offset: 0x00941DAE
		// (set) Token: 0x060249C3 RID: 149955 RVA: 0x00943BBE File Offset: 0x00941DBE
		public unsafe int XCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170047FC RID: 18428
		// (get) Token: 0x060249C4 RID: 149956 RVA: 0x00943BCF File Offset: 0x00941DCF
		// (set) Token: 0x060249C5 RID: 149957 RVA: 0x00943BDF File Offset: 0x00941DDF
		public unsafe bool ReadFromBPL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047FD RID: 18429
		// (get) Token: 0x060249C6 RID: 149958 RVA: 0x00943BF0 File Offset: 0x00941DF0
		// (set) Token: 0x060249C7 RID: 149959 RVA: 0x00943C04 File Offset: 0x00941E04
		public unsafe UStaticMesh inputStaticMesh_ForBPL_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170047FE RID: 18430
		// (get) Token: 0x060249C8 RID: 149960 RVA: 0x00943C19 File Offset: 0x00941E19
		// (set) Token: 0x060249C9 RID: 149961 RVA: 0x00943C29 File Offset: 0x00941E29
		public unsafe bool extraOneMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047FF RID: 18431
		// (get) Token: 0x060249CA RID: 149962 RVA: 0x00943C3A File Offset: 0x00941E3A
		// (set) Token: 0x060249CB RID: 149963 RVA: 0x00943C4E File Offset: 0x00941E4E
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004800 RID: 18432
		// (get) Token: 0x060249CC RID: 149964 RVA: 0x00943C63 File Offset: 0x00941E63
		// (set) Token: 0x060249CD RID: 149965 RVA: 0x00943C77 File Offset: 0x00941E77
		public unsafe UMaterialInstanceDynamic MID1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FootballNet_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17004801 RID: 18433
		// (get) Token: 0x060249CE RID: 149966 RVA: 0x00943C8C File Offset: 0x00941E8C
		// (set) Token: 0x060249CF RID: 149967 RVA: 0x00943C9C File Offset: 0x00941E9C
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004802 RID: 18434
		// (get) Token: 0x060249D0 RID: 149968 RVA: 0x00943CAD File Offset: 0x00941EAD
		// (set) Token: 0x060249D1 RID: 149969 RVA: 0x00943CBD File Offset: 0x00941EBD
		public unsafe bool UseYCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004803 RID: 18435
		// (get) Token: 0x060249D2 RID: 149970 RVA: 0x00943CCE File Offset: 0x00941ECE
		// (set) Token: 0x060249D3 RID: 149971 RVA: 0x00943CDE File Offset: 0x00941EDE
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004804 RID: 18436
		// (get) Token: 0x060249D4 RID: 149972 RVA: 0x00943CEF File Offset: 0x00941EEF
		// (set) Token: 0x060249D5 RID: 149973 RVA: 0x00943D03 File Offset: 0x00941F03
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004805 RID: 18437
		// (get) Token: 0x060249D6 RID: 149974 RVA: 0x00943D18 File Offset: 0x00941F18
		// (set) Token: 0x060249D7 RID: 149975 RVA: 0x00943D2C File Offset: 0x00941F2C
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004806 RID: 18438
		// (get) Token: 0x060249D8 RID: 149976 RVA: 0x00943D41 File Offset: 0x00941F41
		// (set) Token: 0x060249D9 RID: 149977 RVA: 0x00943D51 File Offset: 0x00941F51
		public unsafe bool d1024
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FootballNet_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x060249DA RID: 149978 RVA: 0x00943D62 File Offset: 0x00941F62
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FootballNet_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060249DB RID: 149979 RVA: 0x00943D76 File Offset: 0x00941F76
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FootballNet_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060249DC RID: 149980 RVA: 0x00943D8B File Offset: 0x00941F8B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FootballNet_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060249DD RID: 149981 RVA: 0x00943D9F File Offset: 0x00941F9F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FootballNet_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060249DE RID: 149982 RVA: 0x00943DB4 File Offset: 0x00941FB4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FootballNet_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FootballNet_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FootballNet_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FootballNet_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FootballNet_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060249DF RID: 149983 RVA: 0x00943DFC File Offset: 0x00941FFC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FootballNet_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FootballNet_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FootballNet_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FootballNet_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FootballNet_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060249E0 RID: 149984 RVA: 0x00943E44 File Offset: 0x00942044
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_FootballNet_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_FootballNet_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_FootballNet_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FootballNet_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FootballNet_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060249E1 RID: 149985 RVA: 0x00943E90 File Offset: 0x00942090
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_FootballNet_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_FootballNet_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_FootballNet_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FootballNet_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FootballNet_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060249E2 RID: 149986 RVA: 0x00943EDC File Offset: 0x009420DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			BP_FootballNet_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_FootballNet_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_FootballNet_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FootballNet_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FootballNet_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060249E3 RID: 149987 RVA: 0x00943F90 File Offset: 0x00942190
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060249E4 RID: 149988 RVA: 0x0094404C File Offset: 0x0094224C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FootballNet_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060249E5 RID: 149989 RVA: 0x009440D8 File Offset: 0x009422D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_FootballNet_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_FootballNet_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_FootballNet_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FootballNet_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FootballNet_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060249E6 RID: 149990 RVA: 0x0094413B File Offset: 0x0094233B
		protected BP_FootballNet_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040122DF RID: 74463
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_FootballNet.BP_FootballNet_C";

		// Token: 0x040122E0 RID: 74464
		private static IntPtr _ClassPtr;

		// Token: 0x040122E1 RID: 74465
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040122E2 RID: 74466
		internal static int __PropertyOffset_1;

		// Token: 0x040122E3 RID: 74467
		internal static int __PropertyOffset_2;

		// Token: 0x040122E4 RID: 74468
		internal static int __PropertyOffset_3;

		// Token: 0x040122E5 RID: 74469
		internal static int __PropertyOffset_4;

		// Token: 0x040122E6 RID: 74470
		internal static int __PropertyOffset_5;

		// Token: 0x040122E7 RID: 74471
		internal static int __PropertyOffset_6;

		// Token: 0x040122E8 RID: 74472
		internal static int __PropertyOffset_7;

		// Token: 0x040122E9 RID: 74473
		internal static int __PropertyOffset_8;

		// Token: 0x040122EA RID: 74474
		internal static int __PropertyOffset_9;

		// Token: 0x040122EB RID: 74475
		internal static int __PropertyOffset_10;

		// Token: 0x040122EC RID: 74476
		internal static int __PropertyOffset_11;

		// Token: 0x040122ED RID: 74477
		internal static int __PropertyOffset_12;

		// Token: 0x040122EE RID: 74478
		internal static int __PropertyOffset_13;

		// Token: 0x040122EF RID: 74479
		internal static int __PropertyOffset_14;

		// Token: 0x040122F0 RID: 74480
		internal static int __PropertyOffset_15;

		// Token: 0x040122F1 RID: 74481
		internal static int __PropertyOffset_16;

		// Token: 0x040122F2 RID: 74482
		internal static int __PropertyOffset_17;

		// Token: 0x040122F3 RID: 74483
		internal static int __PropertyOffset_18;

		// Token: 0x040122F4 RID: 74484
		internal static int __PropertyOffset_19;

		// Token: 0x040122F5 RID: 74485
		internal static int __PropertyOffset_20;

		// Token: 0x040122F6 RID: 74486
		internal static int __PropertyOffset_21;

		// Token: 0x040122F7 RID: 74487
		internal static int __PropertyOffset_22;

		// Token: 0x040122F8 RID: 74488
		internal static int __PropertyOffset_23;

		// Token: 0x040122F9 RID: 74489
		internal static int __PropertyOffset_24;

		// Token: 0x040122FA RID: 74490
		internal static int __PropertyOffset_25;

		// Token: 0x040122FB RID: 74491
		internal static int __PropertyOffset_26;

		// Token: 0x040122FC RID: 74492
		internal static int __PropertyOffset_27;

		// Token: 0x040122FD RID: 74493
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040122FE RID: 74494
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040122FF RID: 74495
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012300 RID: 74496
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04012301 RID: 74497
		private static IntPtr __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012302 RID: 74498
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012303 RID: 74499
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012304 RID: 74500
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009F4D RID: 40781
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403190B RID: 203019
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F4E RID: 40782
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403190C RID: 203020
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F4F RID: 40783
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403190D RID: 203021
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x0403190E RID: 203022
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403190F RID: 203023
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031910 RID: 203024
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x04031911 RID: 203025
			[FieldOffset(36)]
			public byte Hit;
		}

		// Token: 0x02009F50 RID: 40784
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031912 RID: 203026
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031913 RID: 203027
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031914 RID: 203028
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031915 RID: 203029
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031916 RID: 203030
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031917 RID: 203031
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F51 RID: 40785
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031918 RID: 203032
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031919 RID: 203033
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403191A RID: 203034
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403191B RID: 203035
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F52 RID: 40786
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x0403191C RID: 203036
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x0403191D RID: 203037
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x0403191E RID: 203038
			[FieldOffset(32)]
			public int Id;
		}
	}
}
