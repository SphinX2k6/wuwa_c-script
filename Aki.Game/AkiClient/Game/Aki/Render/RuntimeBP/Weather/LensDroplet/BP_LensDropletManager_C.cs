using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.LensDroplet
{
	// Token: 0x02003A7B RID: 14971
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/LensDroplet/BP_LensDropletManager.BP_LensDropletManager_C")]
	[UnrealStructLayout(1648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1646)]
	public class BP_LensDropletManager_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FBAE RID: 129966 RVA: 0x008C1044 File Offset: 0x008BF244
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LensDropletManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/LensDroplet/BP_LensDropletManager.BP_LensDropletManager_C");
			}
			return BP_LensDropletManager_C._ClassPtr;
		}

		// Token: 0x0601FBAF RID: 129967 RVA: 0x008C1068 File Offset: 0x008BF268
		public BP_LensDropletManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_LensDropletManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FBB0 RID: 129968 RVA: 0x008C1090 File Offset: 0x008BF290
		[NullableContext(1)]
		public BP_LensDropletManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LensDropletManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x0601FBB1 RID: 129969 RVA: 0x008C10C3 File Offset: 0x008BF2C3
		// (set) Token: 0x0601FBB2 RID: 129970 RVA: 0x008C10D7 File Offset: 0x008BF2D7
		[Nullable(2)]
		public unsafe UProceduralMeshComponent Droplets
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProceduralMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDropletManager_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDropletManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x0601FBB3 RID: 129971 RVA: 0x008C10EC File Offset: 0x008BF2EC
		// (set) Token: 0x0601FBB4 RID: 129972 RVA: 0x008C1100 File Offset: 0x008BF300
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDropletManager_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDropletManager_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x0601FBB5 RID: 129973 RVA: 0x008C1115 File Offset: 0x008BF315
		// (set) Token: 0x0601FBB6 RID: 129974 RVA: 0x008C1125 File Offset: 0x008BF325
		public unsafe float DropletGenerate_NewTrack_0_43A8026C4C5253C2ECCC34BC1AFDE7FF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x0601FBB7 RID: 129975 RVA: 0x008C1136 File Offset: 0x008BF336
		// (set) Token: 0x0601FBB8 RID: 129976 RVA: 0x008C114A File Offset: 0x008BF34A
		public unsafe TEnumAsByte<ETimelineDirection> DropletGenerate__Direction_43A8026C4C5253C2ECCC34BC1AFDE7FF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x0601FBB9 RID: 129977 RVA: 0x008C115F File Offset: 0x008BF35F
		// (set) Token: 0x0601FBBA RID: 129978 RVA: 0x008C1173 File Offset: 0x008BF373
		[Nullable(2)]
		public unsafe UTimelineComponent DropletGenerate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDropletManager_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDropletManager_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x0601FBBB RID: 129979 RVA: 0x008C1188 File Offset: 0x008BF388
		// (set) Token: 0x0601FBBC RID: 129980 RVA: 0x008C1198 File Offset: 0x008BF398
		public unsafe float Rain_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x0601FBBD RID: 129981 RVA: 0x008C11A9 File Offset: 0x008BF3A9
		// (set) Token: 0x0601FBBE RID: 129982 RVA: 0x008C11B9 File Offset: 0x008BF3B9
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x0601FBBF RID: 129983 RVA: 0x008C11CA File Offset: 0x008BF3CA
		// (set) Token: 0x0601FBC0 RID: 129984 RVA: 0x008C11DA File Offset: 0x008BF3DA
		public unsafe float DropletIntensityMul
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x0601FBC1 RID: 129985 RVA: 0x008C11EB File Offset: 0x008BF3EB
		// (set) Token: 0x0601FBC2 RID: 129986 RVA: 0x008C11FB File Offset: 0x008BF3FB
		public unsafe float time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x0601FBC3 RID: 129987 RVA: 0x008C120C File Offset: 0x008BF40C
		// (set) Token: 0x0601FBC4 RID: 129988 RVA: 0x008C121C File Offset: 0x008BF41C
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x0601FBC5 RID: 129989 RVA: 0x008C122D File Offset: 0x008BF42D
		// (set) Token: 0x0601FBC6 RID: 129990 RVA: 0x008C1241 File Offset: 0x008BF441
		public unsafe FVector2D ScreenSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x0601FBC7 RID: 129991 RVA: 0x008C1256 File Offset: 0x008BF456
		// (set) Token: 0x0601FBC8 RID: 129992 RVA: 0x008C1266 File Offset: 0x008BF466
		public unsafe float RainDropOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x0601FBC9 RID: 129993 RVA: 0x008C1277 File Offset: 0x008BF477
		// (set) Token: 0x0601FBCA RID: 129994 RVA: 0x008C1287 File Offset: 0x008BF487
		public unsafe bool InOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x0601FBCB RID: 129995 RVA: 0x008C1298 File Offset: 0x008BF498
		// (set) Token: 0x0601FBCC RID: 129996 RVA: 0x008C12AC File Offset: 0x008BF4AC
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic DropletDMI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDropletManager_C.__PropertyOffset_14);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LensDropletManager_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x0601FBCD RID: 129997 RVA: 0x008C12C1 File Offset: 0x008BF4C1
		// (set) Token: 0x0601FBCE RID: 129998 RVA: 0x008C12D1 File Offset: 0x008BF4D1
		public unsafe float TimeForInOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x0601FBCF RID: 129999 RVA: 0x008C12E2 File Offset: 0x008BF4E2
		// (set) Token: 0x0601FBD0 RID: 130000 RVA: 0x008C12F2 File Offset: 0x008BF4F2
		public unsafe bool InOutActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x0601FBD1 RID: 130001 RVA: 0x008C1303 File Offset: 0x008BF503
		// (set) Token: 0x0601FBD2 RID: 130002 RVA: 0x008C1313 File Offset: 0x008BF513
		public unsafe float time_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x0601FBD3 RID: 130003 RVA: 0x008C1324 File Offset: 0x008BF524
		// (set) Token: 0x0601FBD4 RID: 130004 RVA: 0x008C1334 File Offset: 0x008BF534
		public unsafe bool IsEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x0601FBD5 RID: 130005 RVA: 0x008C1345 File Offset: 0x008BF545
		// (set) Token: 0x0601FBD6 RID: 130006 RVA: 0x008C1359 File Offset: 0x008BF559
		public unsafe FVectorDouble PrezCamPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x0601FBD7 RID: 130007 RVA: 0x008C136E File Offset: 0x008BF56E
		// (set) Token: 0x0601FBD8 RID: 130008 RVA: 0x008C1382 File Offset: 0x008BF582
		public unsafe FVector PrezCamVec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x0601FBD9 RID: 130009 RVA: 0x008C1397 File Offset: 0x008BF597
		// (set) Token: 0x0601FBDA RID: 130010 RVA: 0x008C13AB File Offset: 0x008BF5AB
		public unsafe FVectorDouble CurrCamPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x0601FBDB RID: 130011 RVA: 0x008C13C0 File Offset: 0x008BF5C0
		// (set) Token: 0x0601FBDC RID: 130012 RVA: 0x008C13D4 File Offset: 0x008BF5D4
		public unsafe FVector CurrCamVec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x0601FBDD RID: 130013 RVA: 0x008C13E9 File Offset: 0x008BF5E9
		// (set) Token: 0x0601FBDE RID: 130014 RVA: 0x008C13F9 File Offset: 0x008BF5F9
		public unsafe float SpawnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x0601FBDF RID: 130015 RVA: 0x008C140A File Offset: 0x008BF60A
		// (set) Token: 0x0601FBE0 RID: 130016 RVA: 0x008C141E File Offset: 0x008BF61E
		public unsafe TEnumAsByte<EKuroRainType> RainType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x0601FBE1 RID: 130017 RVA: 0x008C1433 File Offset: 0x008BF633
		// (set) Token: 0x0601FBE2 RID: 130018 RVA: 0x008C1443 File Offset: 0x008BF643
		public unsafe float MaxNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x0601FBE3 RID: 130019 RVA: 0x008C1454 File Offset: 0x008BF654
		// (set) Token: 0x0601FBE4 RID: 130020 RVA: 0x008C1464 File Offset: 0x008BF664
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x0601FBE5 RID: 130021 RVA: 0x008C1475 File Offset: 0x008BF675
		// (set) Token: 0x0601FBE6 RID: 130022 RVA: 0x008C1485 File Offset: 0x008BF685
		public unsafe bool Is_in_Cave
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x0601FBE7 RID: 130023 RVA: 0x008C1496 File Offset: 0x008BF696
		// (set) Token: 0x0601FBE8 RID: 130024 RVA: 0x008C14A6 File Offset: 0x008BF6A6
		public unsafe bool DoEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LensDropletManager_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601FBE9 RID: 130025 RVA: 0x008C14B7 File Offset: 0x008BF6B7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GenerateOneDroplets()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__GenerateOneDroplets_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBEA RID: 130026 RVA: 0x008C14CC File Offset: 0x008BF6CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Timer(float Time, bool InOut)
		{
			BP_LensDropletManager_C.__Timer_FunctionParams* ptr = stackalloc BP_LensDropletManager_C.__Timer_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_LensDropletManager_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDropletManager_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Time = Time;
			ptr->InOut = InOut;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__Timer_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FBEB RID: 130027 RVA: 0x008C1519 File Offset: 0x008BF719
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__UpdateParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBEC RID: 130028 RVA: 0x008C152D File Offset: 0x008BF72D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBED RID: 130029 RVA: 0x008C1544 File Offset: 0x008BF744
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ConstructPolyMesh(int DropletAmount)
		{
			BP_LensDropletManager_C.__ConstructPolyMesh_FunctionParams* ptr = stackalloc BP_LensDropletManager_C.__ConstructPolyMesh_FunctionParams[(UIntPtr)1503] + 15L / (long)sizeof(BP_LensDropletManager_C.__ConstructPolyMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDropletManager_C.__ConstructPolyMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DropletAmount = DropletAmount;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__ConstructPolyMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FBEE RID: 130030 RVA: 0x008C1590 File Offset: 0x008BF790
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetBasicDropletParameters(float RainIntensity, float Gravity, EKuroRainType RainType, bool IsInCave)
		{
			BP_LensDropletManager_C.__SetBasicDropletParameters_FunctionParams* ptr = stackalloc BP_LensDropletManager_C.__SetBasicDropletParameters_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_LensDropletManager_C.__SetBasicDropletParameters_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDropletManager_C.__SetBasicDropletParameters_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RainIntensity = RainIntensity;
			ptr->Gravity = Gravity;
			ptr->RainType = RainType;
			ptr->IsInCave = IsInCave;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__SetBasicDropletParameters_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FBEF RID: 130031 RVA: 0x008C15F1 File Offset: 0x008BF7F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBF0 RID: 130032 RVA: 0x008C1605 File Offset: 0x008BF805
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LensDropletManager_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FBF1 RID: 130033 RVA: 0x008C161A File Offset: 0x008BF81A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DropletGenerate__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__DropletGenerate__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBF2 RID: 130034 RVA: 0x008C162E File Offset: 0x008BF82E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DropletGenerate__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__DropletGenerate__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBF3 RID: 130035 RVA: 0x008C1642 File Offset: 0x008BF842
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__CustomEvent_1_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBF4 RID: 130036 RVA: 0x008C1656 File Offset: 0x008BF856
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DropletEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__DropletEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBF5 RID: 130037 RVA: 0x008C166A File Offset: 0x008BF86A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DropletStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__DropletStart_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBF6 RID: 130038 RVA: 0x008C167E File Offset: 0x008BF87E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DisableDroplets()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__DisableDroplets_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBF7 RID: 130039 RVA: 0x008C1692 File Offset: 0x008BF892
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CleanMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__CleanMesh_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBF8 RID: 130040 RVA: 0x008C16A8 File Offset: 0x008BF8A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_LensDropletManager_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LensDropletManager_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LensDropletManager_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDropletManager_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FBF9 RID: 130041 RVA: 0x008C16F0 File Offset: 0x008BF8F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_LensDropletManager_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LensDropletManager_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LensDropletManager_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDropletManager_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LensDropletManager_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FBFA RID: 130042 RVA: 0x008C1737 File Offset: 0x008BF937
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EnableDroplets()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__EnableDroplets_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBFB RID: 130043 RVA: 0x008C174C File Offset: 0x008BF94C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LensDropletManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LensDropletManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LensDropletManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDropletManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601FBFC RID: 130044 RVA: 0x008C1794 File Offset: 0x008BF994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LensDropletManager_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LensDropletManager_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LensDropletManager_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LensDropletManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LensDropletManager_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601FBFD RID: 130045 RVA: 0x008C17DB File Offset: 0x008BF9DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LensDropletManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FBFE RID: 130046 RVA: 0x008C17EF File Offset: 0x008BF9EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LensDropletManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FBFF RID: 130047 RVA: 0x008C1804 File Offset: 0x008BFA04
		protected BP_LensDropletManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F48C RID: 62604
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/LensDroplet/BP_LensDropletManager.BP_LensDropletManager_C";

		// Token: 0x0400F48D RID: 62605
		private static IntPtr _ClassPtr;

		// Token: 0x0400F48E RID: 62606
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F48F RID: 62607
		internal static int __PropertyOffset_1;

		// Token: 0x0400F490 RID: 62608
		internal static int __PropertyOffset_2;

		// Token: 0x0400F491 RID: 62609
		internal static int __PropertyOffset_3;

		// Token: 0x0400F492 RID: 62610
		internal static int __PropertyOffset_4;

		// Token: 0x0400F493 RID: 62611
		internal static int __PropertyOffset_5;

		// Token: 0x0400F494 RID: 62612
		internal static int __PropertyOffset_6;

		// Token: 0x0400F495 RID: 62613
		internal static int __PropertyOffset_7;

		// Token: 0x0400F496 RID: 62614
		internal static int __PropertyOffset_8;

		// Token: 0x0400F497 RID: 62615
		internal static int __PropertyOffset_9;

		// Token: 0x0400F498 RID: 62616
		internal static int __PropertyOffset_10;

		// Token: 0x0400F499 RID: 62617
		internal static int __PropertyOffset_11;

		// Token: 0x0400F49A RID: 62618
		internal static int __PropertyOffset_12;

		// Token: 0x0400F49B RID: 62619
		internal static int __PropertyOffset_13;

		// Token: 0x0400F49C RID: 62620
		internal static int __PropertyOffset_14;

		// Token: 0x0400F49D RID: 62621
		internal static int __PropertyOffset_15;

		// Token: 0x0400F49E RID: 62622
		internal static int __PropertyOffset_16;

		// Token: 0x0400F49F RID: 62623
		internal static int __PropertyOffset_17;

		// Token: 0x0400F4A0 RID: 62624
		internal static int __PropertyOffset_18;

		// Token: 0x0400F4A1 RID: 62625
		internal static int __PropertyOffset_19;

		// Token: 0x0400F4A2 RID: 62626
		internal static int __PropertyOffset_20;

		// Token: 0x0400F4A3 RID: 62627
		internal static int __PropertyOffset_21;

		// Token: 0x0400F4A4 RID: 62628
		internal static int __PropertyOffset_22;

		// Token: 0x0400F4A5 RID: 62629
		internal static int __PropertyOffset_23;

		// Token: 0x0400F4A6 RID: 62630
		internal static int __PropertyOffset_24;

		// Token: 0x0400F4A7 RID: 62631
		internal static int __PropertyOffset_25;

		// Token: 0x0400F4A8 RID: 62632
		internal static int __PropertyOffset_26;

		// Token: 0x0400F4A9 RID: 62633
		internal static int __PropertyOffset_27;

		// Token: 0x0400F4AA RID: 62634
		internal static int __PropertyOffset_28;

		// Token: 0x0400F4AB RID: 62635
		private static IntPtr __GenerateOneDroplets_NativeFunctionPtr;

		// Token: 0x0400F4AC RID: 62636
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x0400F4AD RID: 62637
		private static IntPtr __UpdateParameters_NativeFunctionPtr;

		// Token: 0x0400F4AE RID: 62638
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400F4AF RID: 62639
		private static IntPtr __ConstructPolyMesh_NativeFunctionPtr;

		// Token: 0x0400F4B0 RID: 62640
		private static IntPtr __SetBasicDropletParameters_NativeFunctionPtr;

		// Token: 0x0400F4B1 RID: 62641
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F4B2 RID: 62642
		private static IntPtr __DropletGenerate__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0400F4B3 RID: 62643
		private static IntPtr __DropletGenerate__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0400F4B4 RID: 62644
		private static IntPtr __CustomEvent_1_NativeFunctionPtr;

		// Token: 0x0400F4B5 RID: 62645
		private static IntPtr __DropletEnd_NativeFunctionPtr;

		// Token: 0x0400F4B6 RID: 62646
		private static IntPtr __DropletStart_NativeFunctionPtr;

		// Token: 0x0400F4B7 RID: 62647
		private static IntPtr __DisableDroplets_NativeFunctionPtr;

		// Token: 0x0400F4B8 RID: 62648
		private static IntPtr __CleanMesh_NativeFunctionPtr;

		// Token: 0x0400F4B9 RID: 62649
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400F4BA RID: 62650
		private static IntPtr __EnableDroplets_NativeFunctionPtr;

		// Token: 0x0400F4BB RID: 62651
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F4BC RID: 62652
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009B43 RID: 39747
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x04031158 RID: 201048
			[FieldOffset(0)]
			public float Time;

			// Token: 0x04031159 RID: 201049
			[FieldOffset(4)]
			public bool InOut;
		}

		// Token: 0x02009B44 RID: 39748
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1488)]
		protected ref struct __ConstructPolyMesh_FunctionParams
		{
			// Token: 0x0403115A RID: 201050
			[FieldOffset(0)]
			public int DropletAmount;
		}

		// Token: 0x02009B45 RID: 39749
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetBasicDropletParameters_FunctionParams
		{
			// Token: 0x0403115B RID: 201051
			[FieldOffset(0)]
			public float RainIntensity;

			// Token: 0x0403115C RID: 201052
			[FieldOffset(4)]
			public float Gravity;

			// Token: 0x0403115D RID: 201053
			[FieldOffset(8)]
			public TEnumAsByte<EKuroRainType> RainType;

			// Token: 0x0403115E RID: 201054
			[FieldOffset(9)]
			public bool IsInCave;
		}

		// Token: 0x02009B46 RID: 39750
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403115F RID: 201055
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B47 RID: 39751
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031160 RID: 201056
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
