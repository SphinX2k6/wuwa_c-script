using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints
{
	// Token: 0x02003AD3 RID: 15059
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent.BP_SnowTrailComponent_C")]
	[UnrealStructLayout(768, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 764)]
	public class BP_SnowTrailComponent_C : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060207AE RID: 133038 RVA: 0x008D3E6F File Offset: 0x008D206F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SnowTrailComponent_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent.BP_SnowTrailComponent_C");
			}
			return BP_SnowTrailComponent_C._ClassPtr;
		}

		// Token: 0x060207AF RID: 133039 RVA: 0x008D3E94 File Offset: 0x008D2094
		public BP_SnowTrailComponent_C() : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailComponent_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060207B0 RID: 133040 RVA: 0x008D3EBC File Offset: 0x008D20BC
		[NullableContext(1)]
		public BP_SnowTrailComponent_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SnowTrailComponent_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x060207B1 RID: 133041 RVA: 0x008D3EEF File Offset: 0x008D20EF
		// (set) Token: 0x060207B2 RID: 133042 RVA: 0x008D3EFF File Offset: 0x008D20FF
		public unsafe bool UseActorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x060207B3 RID: 133043 RVA: 0x008D3F10 File Offset: 0x008D2110
		// (set) Token: 0x060207B4 RID: 133044 RVA: 0x008D3F20 File Offset: 0x008D2120
		public unsafe bool UseEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x060207B5 RID: 133045 RVA: 0x008D3F31 File Offset: 0x008D2131
		// (set) Token: 0x060207B6 RID: 133046 RVA: 0x008D3F41 File Offset: 0x008D2141
		public unsafe bool UseSimplePrint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x060207B7 RID: 133047 RVA: 0x008D3F52 File Offset: 0x008D2152
		// (set) Token: 0x060207B8 RID: 133048 RVA: 0x008D3F62 File Offset: 0x008D2162
		public unsafe int NFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x060207B9 RID: 133049 RVA: 0x008D3F73 File Offset: 0x008D2173
		// (set) Token: 0x060207BA RID: 133050 RVA: 0x008D3F83 File Offset: 0x008D2183
		public unsafe float Hardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003100 RID: 12544
		// (get) Token: 0x060207BB RID: 133051 RVA: 0x008D3F94 File Offset: 0x008D2194
		// (set) Token: 0x060207BC RID: 133052 RVA: 0x008D3FA4 File Offset: 0x008D21A4
		public unsafe float RayLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003101 RID: 12545
		// (get) Token: 0x060207BD RID: 133053 RVA: 0x008D3FB5 File Offset: 0x008D21B5
		// (set) Token: 0x060207BE RID: 133054 RVA: 0x008D3FC5 File Offset: 0x008D21C5
		public unsafe float TrailRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003102 RID: 12546
		// (get) Token: 0x060207BF RID: 133055 RVA: 0x008D3FD6 File Offset: 0x008D21D6
		// (set) Token: 0x060207C0 RID: 133056 RVA: 0x008D3FE6 File Offset: 0x008D21E6
		public unsafe float DistanceTraveld2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003103 RID: 12547
		// (get) Token: 0x060207C1 RID: 133057 RVA: 0x008D3FF7 File Offset: 0x008D21F7
		// (set) Token: 0x060207C2 RID: 133058 RVA: 0x008D400B File Offset: 0x008D220B
		public unsafe FVector LastUpdateLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003104 RID: 12548
		// (get) Token: 0x060207C3 RID: 133059 RVA: 0x008D4020 File Offset: 0x008D2220
		// (set) Token: 0x060207C4 RID: 133060 RVA: 0x008D4034 File Offset: 0x008D2234
		[Nullable(2)]
		public unsafe BP_SnowTraceManager_C MyTraceManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SnowTraceManager_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_C.__PropertyOffset_10);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x060207C5 RID: 133061 RVA: 0x008D4049 File Offset: 0x008D2249
		// (set) Token: 0x060207C6 RID: 133062 RVA: 0x008D405D File Offset: 0x008D225D
		public unsafe FVector LastCheckLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x060207C7 RID: 133063 RVA: 0x008D4072 File Offset: 0x008D2272
		// (set) Token: 0x060207C8 RID: 133064 RVA: 0x008D4086 File Offset: 0x008D2286
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x060207C9 RID: 133065 RVA: 0x008D409B File Offset: 0x008D229B
		// (set) Token: 0x060207CA RID: 133066 RVA: 0x008D40AF File Offset: 0x008D22AF
		public unsafe FVector BoneTransOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x060207CB RID: 133067 RVA: 0x008D40C4 File Offset: 0x008D22C4
		// (set) Token: 0x060207CC RID: 133068 RVA: 0x008D40D8 File Offset: 0x008D22D8
		public unsafe FVector BoneLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003109 RID: 12553
		// (get) Token: 0x060207CD RID: 133069 RVA: 0x008D40ED File Offset: 0x008D22ED
		// (set) Token: 0x060207CE RID: 133070 RVA: 0x008D4101 File Offset: 0x008D2301
		[Nullable(2)]
		public unsafe BP_SceneBattleInteract_C Config
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_C.__PropertyOffset_15);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SnowTrailComponent_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700310A RID: 12554
		// (get) Token: 0x060207CF RID: 133071 RVA: 0x008D4116 File Offset: 0x008D2316
		// (set) Token: 0x060207D0 RID: 133072 RVA: 0x008D4126 File Offset: 0x008D2326
		public unsafe double Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x060207D1 RID: 133073 RVA: 0x008D4137 File Offset: 0x008D2337
		// (set) Token: 0x060207D2 RID: 133074 RVA: 0x008D4147 File Offset: 0x008D2347
		public unsafe float BulletLastHitTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x060207D3 RID: 133075 RVA: 0x008D4158 File Offset: 0x008D2358
		// (set) Token: 0x060207D4 RID: 133076 RVA: 0x008D4191 File Offset: 0x008D2391
		[Nullable(1)]
		public TArray<FVectorDouble> BulletHitList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._BulletHitList) == null)
				{
					result = (this._BulletHitList = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_18, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BulletHitList.CopyAssign(value);
			}
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x060207D5 RID: 133077 RVA: 0x008D419F File Offset: 0x008D239F
		// (set) Token: 0x060207D6 RID: 133078 RVA: 0x008D41AF File Offset: 0x008D23AF
		public unsafe double Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x060207D7 RID: 133079 RVA: 0x008D41C0 File Offset: 0x008D23C0
		// (set) Token: 0x060207D8 RID: 133080 RVA: 0x008D41D0 File Offset: 0x008D23D0
		public unsafe double BulletMaxConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x060207D9 RID: 133081 RVA: 0x008D41E1 File Offset: 0x008D23E1
		// (set) Token: 0x060207DA RID: 133082 RVA: 0x008D41F1 File Offset: 0x008D23F1
		public unsafe double BulletMinConnectDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x060207DB RID: 133083 RVA: 0x008D4202 File Offset: 0x008D2402
		// (set) Token: 0x060207DC RID: 133084 RVA: 0x008D4212 File Offset: 0x008D2412
		public unsafe int Step
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x060207DD RID: 133085 RVA: 0x008D4223 File Offset: 0x008D2423
		// (set) Token: 0x060207DE RID: 133086 RVA: 0x008D4233 File Offset: 0x008D2433
		public unsafe bool SelfEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x060207DF RID: 133087 RVA: 0x008D4244 File Offset: 0x008D2444
		// (set) Token: 0x060207E0 RID: 133088 RVA: 0x008D4254 File Offset: 0x008D2454
		public unsafe int FrameConter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SnowTrailComponent_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x060207E1 RID: 133089 RVA: 0x008D4268 File Offset: 0x008D2468
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateDeltaTime(float DeltaTime)
		{
			BP_SnowTrailComponent_C.__UpdateDeltaTime_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__UpdateDeltaTime_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__UpdateDeltaTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__UpdateDeltaTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__UpdateDeltaTime_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207E2 RID: 133090 RVA: 0x008D42B0 File Offset: 0x008D24B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CompareNewPointWeapon(FVectorDouble V2, ref bool Valid)
		{
			BP_SnowTrailComponent_C.__CompareNewPointWeapon_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__CompareNewPointWeapon_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__CompareNewPointWeapon_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__CompareNewPointWeapon_NativeFunctionPtr, (void*)ptr, 1);
			ptr->V2 = V2;
			ptr->Valid = Valid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__CompareNewPointWeapon_NativeFunctionPtr, (void*)ptr);
			Valid = ptr->Valid;
		}

		// Token: 0x060207E3 RID: 133091 RVA: 0x008D4308 File Offset: 0x008D2508
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SnowCollisionEffect(FVectorDouble AvailablePoint, float TrailRadius, float TrailDepth)
		{
			BP_SnowTrailComponent_C.__SnowCollisionEffect_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__SnowCollisionEffect_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__SnowCollisionEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__SnowCollisionEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AvailablePoint = AvailablePoint;
			ptr->TrailRadius = TrailRadius;
			ptr->TrailDepth = TrailDepth;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__SnowCollisionEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207E4 RID: 133092 RVA: 0x008D435F File Offset: 0x008D255F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SnowCollisionActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__SnowCollisionActor_NativeFunctionPtr, null);
		}

		// Token: 0x060207E5 RID: 133093 RVA: 0x008D4373 File Offset: 0x008D2573
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SnowCollisionBone()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__SnowCollisionBone_NativeFunctionPtr, null);
		}

		// Token: 0x060207E6 RID: 133094 RVA: 0x008D4388 File Offset: 0x008D2588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void RegisterTrailComp(float Radius, float Depth, float Hardness, float TrailRotation, FVector TrailLocation)
		{
			BP_SnowTrailComponent_C.__RegisterTrailComp_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__RegisterTrailComp_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__RegisterTrailComp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__RegisterTrailComp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Radius = Radius;
			ptr->Depth = Depth;
			ptr->Hardness = Hardness;
			ptr->TrailRotation = TrailRotation;
			ptr->TrailLocation = TrailLocation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__RegisterTrailComp_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207E7 RID: 133095 RVA: 0x008D43EC File Offset: 0x008D25EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FindTrailManager()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__FindTrailManager_NativeFunctionPtr, null);
		}

		// Token: 0x060207E8 RID: 133096 RVA: 0x008D4400 File Offset: 0x008D2600
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060207E9 RID: 133097 RVA: 0x008D4414 File Offset: 0x008D2614
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTrailComponent_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060207EA RID: 133098 RVA: 0x008D442C File Offset: 0x008D262C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207EB RID: 133099 RVA: 0x008D4474 File Offset: 0x008D2674
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SnowTrailComponent_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060207EC RID: 133100 RVA: 0x008D44BC File Offset: 0x008D26BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_SnowTrailComponent_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_SnowTrailComponent_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_SnowTrailComponent_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SnowTrailComponent_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SnowTrailComponent_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060207ED RID: 133101 RVA: 0x008D451F File Offset: 0x008D271F
		protected BP_SnowTrailComponent_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBBC RID: 64444
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SnowCoverInteraction/BluePrints/BP_SnowTrailComponent.BP_SnowTrailComponent_C";

		// Token: 0x0400FBBD RID: 64445
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBBE RID: 64446
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBBF RID: 64447
		internal static int __PropertyOffset_1;

		// Token: 0x0400FBC0 RID: 64448
		internal static int __PropertyOffset_2;

		// Token: 0x0400FBC1 RID: 64449
		internal static int __PropertyOffset_3;

		// Token: 0x0400FBC2 RID: 64450
		internal static int __PropertyOffset_4;

		// Token: 0x0400FBC3 RID: 64451
		internal static int __PropertyOffset_5;

		// Token: 0x0400FBC4 RID: 64452
		internal static int __PropertyOffset_6;

		// Token: 0x0400FBC5 RID: 64453
		internal static int __PropertyOffset_7;

		// Token: 0x0400FBC6 RID: 64454
		internal static int __PropertyOffset_8;

		// Token: 0x0400FBC7 RID: 64455
		internal static int __PropertyOffset_9;

		// Token: 0x0400FBC8 RID: 64456
		internal static int __PropertyOffset_10;

		// Token: 0x0400FBC9 RID: 64457
		internal static int __PropertyOffset_11;

		// Token: 0x0400FBCA RID: 64458
		internal static int __PropertyOffset_12;

		// Token: 0x0400FBCB RID: 64459
		internal static int __PropertyOffset_13;

		// Token: 0x0400FBCC RID: 64460
		internal static int __PropertyOffset_14;

		// Token: 0x0400FBCD RID: 64461
		internal static int __PropertyOffset_15;

		// Token: 0x0400FBCE RID: 64462
		internal static int __PropertyOffset_16;

		// Token: 0x0400FBCF RID: 64463
		internal static int __PropertyOffset_17;

		// Token: 0x0400FBD0 RID: 64464
		internal static int __PropertyOffset_18;

		// Token: 0x0400FBD1 RID: 64465
		[Nullable(2)]
		private TArray<FVectorDouble> _BulletHitList;

		// Token: 0x0400FBD2 RID: 64466
		internal static int __PropertyOffset_19;

		// Token: 0x0400FBD3 RID: 64467
		internal static int __PropertyOffset_20;

		// Token: 0x0400FBD4 RID: 64468
		internal static int __PropertyOffset_21;

		// Token: 0x0400FBD5 RID: 64469
		internal static int __PropertyOffset_22;

		// Token: 0x0400FBD6 RID: 64470
		internal static int __PropertyOffset_23;

		// Token: 0x0400FBD7 RID: 64471
		internal static int __PropertyOffset_24;

		// Token: 0x0400FBD8 RID: 64472
		private static IntPtr __UpdateDeltaTime_NativeFunctionPtr;

		// Token: 0x0400FBD9 RID: 64473
		private static IntPtr __CompareNewPointWeapon_NativeFunctionPtr;

		// Token: 0x0400FBDA RID: 64474
		private static IntPtr __SnowCollisionEffect_NativeFunctionPtr;

		// Token: 0x0400FBDB RID: 64475
		private static IntPtr __SnowCollisionActor_NativeFunctionPtr;

		// Token: 0x0400FBDC RID: 64476
		private static IntPtr __SnowCollisionBone_NativeFunctionPtr;

		// Token: 0x0400FBDD RID: 64477
		private static IntPtr __RegisterTrailComp_NativeFunctionPtr;

		// Token: 0x0400FBDE RID: 64478
		private static IntPtr __FindTrailManager_NativeFunctionPtr;

		// Token: 0x0400FBDF RID: 64479
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FBE0 RID: 64480
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FBE1 RID: 64481
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009BC3 RID: 39875
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __UpdateDeltaTime_FunctionParams
		{
			// Token: 0x04031248 RID: 201288
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02009BC4 RID: 39876
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __CompareNewPointWeapon_FunctionParams
		{
			// Token: 0x04031249 RID: 201289
			[FieldOffset(0)]
			public FVectorDouble V2;

			// Token: 0x0403124A RID: 201290
			[FieldOffset(24)]
			public bool Valid;
		}

		// Token: 0x02009BC5 RID: 39877
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __SnowCollisionEffect_FunctionParams
		{
			// Token: 0x0403124B RID: 201291
			[FieldOffset(0)]
			public FVectorDouble AvailablePoint;

			// Token: 0x0403124C RID: 201292
			[FieldOffset(24)]
			public float TrailRadius;

			// Token: 0x0403124D RID: 201293
			[FieldOffset(28)]
			public float TrailDepth;
		}

		// Token: 0x02009BC6 RID: 39878
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __RegisterTrailComp_FunctionParams
		{
			// Token: 0x0403124E RID: 201294
			[FieldOffset(0)]
			public float Radius;

			// Token: 0x0403124F RID: 201295
			[FieldOffset(4)]
			public float Depth;

			// Token: 0x04031250 RID: 201296
			[FieldOffset(8)]
			public float Hardness;

			// Token: 0x04031251 RID: 201297
			[FieldOffset(12)]
			public float TrailRotation;

			// Token: 0x04031252 RID: 201298
			[FieldOffset(16)]
			public FVector TrailLocation;
		}

		// Token: 0x02009BC7 RID: 39879
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031253 RID: 201299
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BC8 RID: 39880
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031254 RID: 201300
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031255 RID: 201301
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031256 RID: 201302
			[FieldOffset(32)]
			public int Id;
		}
	}
}
