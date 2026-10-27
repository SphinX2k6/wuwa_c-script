using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterPlantInteraction
{
	// Token: 0x02003BDA RID: 15322
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterPlantInteraction/BP_PlantCollisionInteration_A.BP_PlantCollisionInteration_A_C")]
	[UnrealStructLayout(1264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1264)]
	public class BP_PlantCollisionInteration_A_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060228CA RID: 141514 RVA: 0x0090BCC8 File Offset: 0x00909EC8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PlantCollisionInteration_A_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterPlantInteraction/BP_PlantCollisionInteration_A.BP_PlantCollisionInteration_A_C");
			}
			return BP_PlantCollisionInteration_A_C._ClassPtr;
		}

		// Token: 0x060228CB RID: 141515 RVA: 0x0090BCEC File Offset: 0x00909EEC
		public BP_PlantCollisionInteration_A_C() : this(BuiltinUtils.AllocNativeUObject(BP_PlantCollisionInteration_A_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060228CC RID: 141516 RVA: 0x0090BD14 File Offset: 0x00909F14
		[NullableContext(1)]
		public BP_PlantCollisionInteration_A_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PlantCollisionInteration_A_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x060228CD RID: 141517 RVA: 0x0090BD47 File Offset: 0x00909F47
		// (set) Token: 0x060228CE RID: 141518 RVA: 0x0090BD5B File Offset: 0x00909F5B
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantCollisionInteration_A_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantCollisionInteration_A_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003C59 RID: 15449
		// (get) Token: 0x060228CF RID: 141519 RVA: 0x0090BD70 File Offset: 0x00909F70
		// (set) Token: 0x060228D0 RID: 141520 RVA: 0x0090BD84 File Offset: 0x00909F84
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantCollisionInteration_A_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantCollisionInteration_A_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x060228D1 RID: 141521 RVA: 0x0090BD99 File Offset: 0x00909F99
		// (set) Token: 0x060228D2 RID: 141522 RVA: 0x0090BDA9 File Offset: 0x00909FA9
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x060228D3 RID: 141523 RVA: 0x0090BDBC File Offset: 0x00909FBC
		// (set) Token: 0x060228D4 RID: 141524 RVA: 0x0090BDF5 File Offset: 0x00909FF5
		[Nullable(1)]
		public TArray<FVector> posArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr) == null)
				{
					result = (this._posArr = new TArray<FVector>(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.posArr.CopyAssign(value);
			}
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x060228D5 RID: 141525 RVA: 0x0090BE04 File Offset: 0x0090A004
		// (set) Token: 0x060228D6 RID: 141526 RVA: 0x0090BE3D File Offset: 0x0090A03D
		[Nullable(1)]
		public TArray<FVector> volArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._volArr) == null)
				{
					result = (this._volArr = new TArray<FVector>(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.volArr.CopyAssign(value);
			}
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x060228D7 RID: 141527 RVA: 0x0090BE4B File Offset: 0x0090A04B
		// (set) Token: 0x060228D8 RID: 141528 RVA: 0x0090BE5B File Offset: 0x0090A05B
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x060228D9 RID: 141529 RVA: 0x0090BE6C File Offset: 0x0090A06C
		// (set) Token: 0x060228DA RID: 141530 RVA: 0x0090BE7C File Offset: 0x0090A07C
		public unsafe float linkDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x060228DB RID: 141531 RVA: 0x0090BE8D File Offset: 0x0090A08D
		// (set) Token: 0x060228DC RID: 141532 RVA: 0x0090BEA1 File Offset: 0x0090A0A1
		public unsafe FVector emitterOriginPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x060228DD RID: 141533 RVA: 0x0090BEB6 File Offset: 0x0090A0B6
		// (set) Token: 0x060228DE RID: 141534 RVA: 0x0090BECA File Offset: 0x0090A0CA
		public unsafe FVector accel_ext
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x060228DF RID: 141535 RVA: 0x0090BEE0 File Offset: 0x0090A0E0
		// (set) Token: 0x060228E0 RID: 141536 RVA: 0x0090BF19 File Offset: 0x0090A119
		[Nullable(1)]
		public TArray<FVector> posArr_foe
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArr_foe) == null)
				{
					result = (this._posArr_foe = new TArray<FVector>(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.posArr_foe.CopyAssign(value);
			}
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x060228E1 RID: 141537 RVA: 0x0090BF27 File Offset: 0x0090A127
		// (set) Token: 0x060228E2 RID: 141538 RVA: 0x0090BF37 File Offset: 0x0090A137
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x060228E3 RID: 141539 RVA: 0x0090BF48 File Offset: 0x0090A148
		// (set) Token: 0x060228E4 RID: 141540 RVA: 0x0090BF58 File Offset: 0x0090A158
		public unsafe long frameID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x060228E5 RID: 141541 RVA: 0x0090BF69 File Offset: 0x0090A169
		// (set) Token: 0x060228E6 RID: 141542 RVA: 0x0090BF79 File Offset: 0x0090A179
		public unsafe float volDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x060228E7 RID: 141543 RVA: 0x0090BF8C File Offset: 0x0090A18C
		// (set) Token: 0x060228E8 RID: 141544 RVA: 0x0090BFC5 File Offset: 0x0090A1C5
		[Nullable(1)]
		public TArray<FVector> posArrOrigin
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._posArrOrigin) == null)
				{
					result = (this._posArrOrigin = new TArray<FVector>(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.posArrOrigin.CopyAssign(value);
			}
		}

		// Token: 0x17003C66 RID: 15462
		// (get) Token: 0x060228E9 RID: 141545 RVA: 0x0090BFD3 File Offset: 0x0090A1D3
		// (set) Token: 0x060228EA RID: 141546 RVA: 0x0090BFE7 File Offset: 0x0090A1E7
		public unsafe UMaterialInstanceDynamic DMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantCollisionInteration_A_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantCollisionInteration_A_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003C67 RID: 15463
		// (get) Token: 0x060228EB RID: 141547 RVA: 0x0090BFFC File Offset: 0x0090A1FC
		// (set) Token: 0x060228EC RID: 141548 RVA: 0x0090C010 File Offset: 0x0090A210
		public unsafe UMaterialInterface Material_InstanceTemp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantCollisionInteration_A_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PlantCollisionInteration_A_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003C68 RID: 15464
		// (get) Token: 0x060228ED RID: 141549 RVA: 0x0090C025 File Offset: 0x0090A225
		// (set) Token: 0x060228EE RID: 141550 RVA: 0x0090C035 File Offset: 0x0090A235
		public unsafe bool PC_Platform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C69 RID: 15465
		// (get) Token: 0x060228EF RID: 141551 RVA: 0x0090C046 File Offset: 0x0090A246
		// (set) Token: 0x060228F0 RID: 141552 RVA: 0x0090C056 File Offset: 0x0090A256
		public unsafe float Debug_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003C6A RID: 15466
		// (get) Token: 0x060228F1 RID: 141553 RVA: 0x0090C067 File Offset: 0x0090A267
		// (set) Token: 0x060228F2 RID: 141554 RVA: 0x0090C07B File Offset: 0x0090A27B
		public unsafe FVectorDouble CharacterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003C6B RID: 15467
		// (get) Token: 0x060228F3 RID: 141555 RVA: 0x0090C090 File Offset: 0x0090A290
		// (set) Token: 0x060228F4 RID: 141556 RVA: 0x0090C0A0 File Offset: 0x0090A2A0
		public unsafe float Self_WorldScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003C6C RID: 15468
		// (get) Token: 0x060228F5 RID: 141557 RVA: 0x0090C0B1 File Offset: 0x0090A2B1
		// (set) Token: 0x060228F6 RID: 141558 RVA: 0x0090C0C5 File Offset: 0x0090A2C5
		public unsafe FVector rootOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PlantCollisionInteration_A_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x060228F7 RID: 141559 RVA: 0x0090C0DC File Offset: 0x0090A2DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ScheduledTick(float DeltaSeconds)
		{
			BP_PlantCollisionInteration_A_C.__ScheduledTick_FunctionParams* ptr = stackalloc BP_PlantCollisionInteration_A_C.__ScheduledTick_FunctionParams[(UIntPtr)399] + 15L / (long)sizeof(BP_PlantCollisionInteration_A_C.__ScheduledTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantCollisionInteration_A_C.__ScheduledTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantCollisionInteration_A_C.__ScheduledTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060228F8 RID: 141560 RVA: 0x0090C125 File Offset: 0x0090A325
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Get_CharacterPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantCollisionInteration_A_C.__Get_CharacterPosition_NativeFunctionPtr, null);
		}

		// Token: 0x060228F9 RID: 141561 RVA: 0x0090C13C File Offset: 0x0090A33C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void solve(bool isPinned, FVector pos, FVector linkPos, float targetLen, FVector emitterOriginPos, ref FVector pos_new)
		{
			BP_PlantCollisionInteration_A_C.__solve_FunctionParams* ptr = stackalloc BP_PlantCollisionInteration_A_C.__solve_FunctionParams[(UIntPtr)131] + 15L / (long)sizeof(BP_PlantCollisionInteration_A_C.__solve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantCollisionInteration_A_C.__solve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isPinned = isPinned;
			ptr->pos = pos;
			ptr->linkPos = linkPos;
			ptr->targetLen = targetLen;
			ptr->emitterOriginPos = emitterOriginPos;
			ptr->pos_new = pos_new;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantCollisionInteration_A_C.__solve_NativeFunctionPtr, (void*)ptr);
			pos_new = ptr->pos_new;
		}

		// Token: 0x060228FA RID: 141562 RVA: 0x0090C1BD File Offset: 0x0090A3BD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantCollisionInteration_A_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060228FB RID: 141563 RVA: 0x0090C1D1 File Offset: 0x0090A3D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantCollisionInteration_A_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060228FC RID: 141564 RVA: 0x0090C1E8 File Offset: 0x0090A3E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060228FD RID: 141565 RVA: 0x0090C234 File Offset: 0x0090A434
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantCollisionInteration_A_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060228FE RID: 141566 RVA: 0x0090C280 File Offset: 0x0090A480
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PlantCollisionInteration_A_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060228FF RID: 141567 RVA: 0x0090C294 File Offset: 0x0090A494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PlantCollisionInteration_A_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022900 RID: 141568 RVA: 0x0090C2A9 File Offset: 0x0090A4A9
		protected BP_PlantCollisionInteration_A_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F73 RID: 69491
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterPlantInteraction/BP_PlantCollisionInteration_A.BP_PlantCollisionInteration_A_C";

		// Token: 0x04010F74 RID: 69492
		private static IntPtr _ClassPtr;

		// Token: 0x04010F75 RID: 69493
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F76 RID: 69494
		internal static int __PropertyOffset_1;

		// Token: 0x04010F77 RID: 69495
		internal static int __PropertyOffset_2;

		// Token: 0x04010F78 RID: 69496
		internal static int __PropertyOffset_3;

		// Token: 0x04010F79 RID: 69497
		internal static int __PropertyOffset_4;

		// Token: 0x04010F7A RID: 69498
		private TArray<FVector> _posArr;

		// Token: 0x04010F7B RID: 69499
		internal static int __PropertyOffset_5;

		// Token: 0x04010F7C RID: 69500
		private TArray<FVector> _volArr;

		// Token: 0x04010F7D RID: 69501
		internal static int __PropertyOffset_6;

		// Token: 0x04010F7E RID: 69502
		internal static int __PropertyOffset_7;

		// Token: 0x04010F7F RID: 69503
		internal static int __PropertyOffset_8;

		// Token: 0x04010F80 RID: 69504
		internal static int __PropertyOffset_9;

		// Token: 0x04010F81 RID: 69505
		internal static int __PropertyOffset_10;

		// Token: 0x04010F82 RID: 69506
		private TArray<FVector> _posArr_foe;

		// Token: 0x04010F83 RID: 69507
		internal static int __PropertyOffset_11;

		// Token: 0x04010F84 RID: 69508
		internal static int __PropertyOffset_12;

		// Token: 0x04010F85 RID: 69509
		internal static int __PropertyOffset_13;

		// Token: 0x04010F86 RID: 69510
		internal static int __PropertyOffset_14;

		// Token: 0x04010F87 RID: 69511
		private TArray<FVector> _posArrOrigin;

		// Token: 0x04010F88 RID: 69512
		internal static int __PropertyOffset_15;

		// Token: 0x04010F89 RID: 69513
		internal static int __PropertyOffset_16;

		// Token: 0x04010F8A RID: 69514
		internal static int __PropertyOffset_17;

		// Token: 0x04010F8B RID: 69515
		internal static int __PropertyOffset_18;

		// Token: 0x04010F8C RID: 69516
		internal static int __PropertyOffset_19;

		// Token: 0x04010F8D RID: 69517
		internal static int __PropertyOffset_20;

		// Token: 0x04010F8E RID: 69518
		internal static int __PropertyOffset_21;

		// Token: 0x04010F8F RID: 69519
		private static IntPtr __ScheduledTick_NativeFunctionPtr;

		// Token: 0x04010F90 RID: 69520
		private static IntPtr __Get_CharacterPosition_NativeFunctionPtr;

		// Token: 0x04010F91 RID: 69521
		private static IntPtr __solve_NativeFunctionPtr;

		// Token: 0x04010F92 RID: 69522
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010F93 RID: 69523
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04010F94 RID: 69524
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009D94 RID: 40340
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 384)]
		protected ref struct __ScheduledTick_FunctionParams
		{
			// Token: 0x04031560 RID: 202080
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D95 RID: 40341
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 116)]
		protected ref struct __solve_FunctionParams
		{
			// Token: 0x04031561 RID: 202081
			[FieldOffset(0)]
			public bool isPinned;

			// Token: 0x04031562 RID: 202082
			[FieldOffset(4)]
			public FVector pos;

			// Token: 0x04031563 RID: 202083
			[FieldOffset(16)]
			public FVector linkPos;

			// Token: 0x04031564 RID: 202084
			[FieldOffset(28)]
			public float targetLen;

			// Token: 0x04031565 RID: 202085
			[FieldOffset(32)]
			public FVector emitterOriginPos;

			// Token: 0x04031566 RID: 202086
			[FieldOffset(44)]
			public FVector pos_new;
		}

		// Token: 0x02009D96 RID: 40342
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031567 RID: 202087
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
