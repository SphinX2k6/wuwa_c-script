using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FlockingSimulation
{
	// Token: 0x02003DB1 RID: 15793
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FlockingSimulation/BP_FlockingSimulation.BP_FlockingSimulation_C")]
	[UnrealStructLayout(2768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2761)]
	public class BP_FlockingSimulation_C : AKuroFlockingSimulation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602733F RID: 160575 RVA: 0x0098B00C File Offset: 0x0098920C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FlockingSimulation_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FlockingSimulation/BP_FlockingSimulation.BP_FlockingSimulation_C");
			}
			return BP_FlockingSimulation_C._ClassPtr;
		}

		// Token: 0x06027340 RID: 160576 RVA: 0x0098B030 File Offset: 0x00989230
		public BP_FlockingSimulation_C() : this(BuiltinUtils.AllocNativeUObject(BP_FlockingSimulation_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027341 RID: 160577 RVA: 0x0098B058 File Offset: 0x00989258
		[NullableContext(1)]
		public BP_FlockingSimulation_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FlockingSimulation_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170056C7 RID: 22215
		// (get) Token: 0x06027342 RID: 160578 RVA: 0x0098B08B File Offset: 0x0098928B
		// (set) Token: 0x06027343 RID: 160579 RVA: 0x0098B09F File Offset: 0x0098929F
		[Nullable(2)]
		public unsafe UInstancedStaticMeshComponent InstancedStaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlockingSimulation_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlockingSimulation_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170056C8 RID: 22216
		// (get) Token: 0x06027344 RID: 160580 RVA: 0x0098B0B4 File Offset: 0x009892B4
		// (set) Token: 0x06027345 RID: 160581 RVA: 0x0098B0C8 File Offset: 0x009892C8
		[Nullable(2)]
		public unsafe UBoxComponent Box
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlockingSimulation_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FlockingSimulation_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170056C9 RID: 22217
		// (get) Token: 0x06027346 RID: 160582 RVA: 0x0098B0E0 File Offset: 0x009892E0
		// (set) Token: 0x06027347 RID: 160583 RVA: 0x0098B119 File Offset: 0x00989319
		[Nullable(1)]
		public FKuroFlockingSettings FlockingSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroFlockingSettings result;
				if ((result = this._FlockingSettings) == null)
				{
					result = (this._FlockingSettings = new FKuroFlockingSettings(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroFlockingSettings.StaticStruct(), base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_3, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170056CA RID: 22218
		// (get) Token: 0x06027348 RID: 160584 RVA: 0x0098B13C File Offset: 0x0098933C
		// (set) Token: 0x06027349 RID: 160585 RVA: 0x0098B175 File Offset: 0x00989375
		[Nullable(1)]
		public TArray<FKuroFlockingData> FlockingDataArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroFlockingData> result;
				if ((result = this._FlockingDataArray) == null)
				{
					result = (this._FlockingDataArray = new TArray<FKuroFlockingData>(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FlockingDataArray.CopyAssign(value);
			}
		}

		// Token: 0x170056CB RID: 22219
		// (get) Token: 0x0602734A RID: 160586 RVA: 0x0098B183 File Offset: 0x00989383
		// (set) Token: 0x0602734B RID: 160587 RVA: 0x0098B193 File Offset: 0x00989393
		public unsafe int FishCountPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170056CC RID: 22220
		// (get) Token: 0x0602734C RID: 160588 RVA: 0x0098B1A4 File Offset: 0x009893A4
		// (set) Token: 0x0602734D RID: 160589 RVA: 0x0098B1B4 File Offset: 0x009893B4
		public unsafe int FrameID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170056CD RID: 22221
		// (get) Token: 0x0602734E RID: 160590 RVA: 0x0098B1C5 File Offset: 0x009893C5
		// (set) Token: 0x0602734F RID: 160591 RVA: 0x0098B1D5 File Offset: 0x009893D5
		public unsafe float SpawnRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170056CE RID: 22222
		// (get) Token: 0x06027350 RID: 160592 RVA: 0x0098B1E6 File Offset: 0x009893E6
		// (set) Token: 0x06027351 RID: 160593 RVA: 0x0098B1F6 File Offset: 0x009893F6
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170056CF RID: 22223
		// (get) Token: 0x06027352 RID: 160594 RVA: 0x0098B207 File Offset: 0x00989407
		// (set) Token: 0x06027353 RID: 160595 RVA: 0x0098B217 File Offset: 0x00989417
		public unsafe int MaxFishCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170056D0 RID: 22224
		// (get) Token: 0x06027354 RID: 160596 RVA: 0x0098B228 File Offset: 0x00989428
		// (set) Token: 0x06027355 RID: 160597 RVA: 0x0098B238 File Offset: 0x00989438
		public unsafe bool IsPC_Platform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056D1 RID: 22225
		// (get) Token: 0x06027356 RID: 160598 RVA: 0x0098B249 File Offset: 0x00989449
		// (set) Token: 0x06027357 RID: 160599 RVA: 0x0098B259 File Offset: 0x00989459
		public unsafe float FishDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170056D2 RID: 22226
		// (get) Token: 0x06027358 RID: 160600 RVA: 0x0098B26A File Offset: 0x0098946A
		// (set) Token: 0x06027359 RID: 160601 RVA: 0x0098B27A File Offset: 0x0098947A
		public unsafe int FishCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170056D3 RID: 22227
		// (get) Token: 0x0602735A RID: 160602 RVA: 0x0098B28B File Offset: 0x0098948B
		// (set) Token: 0x0602735B RID: 160603 RVA: 0x0098B29B File Offset: 0x0098949B
		public unsafe float MobileFishDensityRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170056D4 RID: 22228
		// (get) Token: 0x0602735C RID: 160604 RVA: 0x0098B2AC File Offset: 0x009894AC
		// (set) Token: 0x0602735D RID: 160605 RVA: 0x0098B2C0 File Offset: 0x009894C0
		public unsafe FVector BoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170056D5 RID: 22229
		// (get) Token: 0x0602735E RID: 160606 RVA: 0x0098B2D5 File Offset: 0x009894D5
		// (set) Token: 0x0602735F RID: 160607 RVA: 0x0098B2E5 File Offset: 0x009894E5
		public unsafe bool UseAvoidance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FlockingSimulation_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027360 RID: 160608 RVA: 0x0098B2F8 File Offset: 0x009894F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWorldOffset(FVector Offset)
		{
			BP_FlockingSimulation_C.__OnWorldOffset_FunctionParams* ptr = stackalloc BP_FlockingSimulation_C.__OnWorldOffset_FunctionParams[(UIntPtr)91] + 15L / (long)sizeof(BP_FlockingSimulation_C.__OnWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlockingSimulation_C.__OnWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Offset = Offset;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlockingSimulation_C.__OnWorldOffset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027361 RID: 160609 RVA: 0x0098B33E File Offset: 0x0098953E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlockingSimulation_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x06027362 RID: 160610 RVA: 0x0098B354 File Offset: 0x00989554
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SimGPU(float dt)
		{
			BP_FlockingSimulation_C.__SimGPU_FunctionParams* ptr = stackalloc BP_FlockingSimulation_C.__SimGPU_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_FlockingSimulation_C.__SimGPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlockingSimulation_C.__SimGPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlockingSimulation_C.__SimGPU_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027363 RID: 160611 RVA: 0x0098B39C File Offset: 0x0098959C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SimCPU(float dt)
		{
			BP_FlockingSimulation_C.__SimCPU_FunctionParams* ptr = stackalloc BP_FlockingSimulation_C.__SimCPU_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(BP_FlockingSimulation_C.__SimCPU_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlockingSimulation_C.__SimCPU_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlockingSimulation_C.__SimCPU_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027364 RID: 160612 RVA: 0x0098B3E2 File Offset: 0x009895E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlockingSimulation_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06027365 RID: 160613 RVA: 0x0098B3F6 File Offset: 0x009895F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FlockingSimulation_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06027366 RID: 160614 RVA: 0x0098B40C File Offset: 0x0098960C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FlockingSimulation_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FlockingSimulation_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FlockingSimulation_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlockingSimulation_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlockingSimulation_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027367 RID: 160615 RVA: 0x0098B454 File Offset: 0x00989654
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FlockingSimulation_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FlockingSimulation_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FlockingSimulation_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlockingSimulation_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FlockingSimulation_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027368 RID: 160616 RVA: 0x0098B49C File Offset: 0x0098969C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void OnApplyWorldOffset(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_FlockingSimulation_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_FlockingSimulation_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_FlockingSimulation_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlockingSimulation_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FlockingSimulation_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06027369 RID: 160617 RVA: 0x0098B4F0 File Offset: 0x009896F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void OnApplyWorldOffset_Implementation(in FVector InWorldOffset, bool bWorldShift)
		{
			BP_FlockingSimulation_C.__OnApplyWorldOffset_FunctionParams* ptr = stackalloc BP_FlockingSimulation_C.__OnApplyWorldOffset_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_FlockingSimulation_C.__OnApplyWorldOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FlockingSimulation_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InWorldOffset = InWorldOffset;
			ptr->bWorldShift = bWorldShift;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FlockingSimulation_C.__OnApplyWorldOffset_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602736A RID: 160618 RVA: 0x0098B543 File Offset: 0x00989743
		protected BP_FlockingSimulation_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013C65 RID: 80997
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FlockingSimulation/BP_FlockingSimulation.BP_FlockingSimulation_C";

		// Token: 0x04013C66 RID: 80998
		private static IntPtr _ClassPtr;

		// Token: 0x04013C67 RID: 80999
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013C68 RID: 81000
		internal static int __PropertyOffset_1;

		// Token: 0x04013C69 RID: 81001
		internal static int __PropertyOffset_2;

		// Token: 0x04013C6A RID: 81002
		internal static int __PropertyOffset_3;

		// Token: 0x04013C6B RID: 81003
		[Nullable(2)]
		private FKuroFlockingSettings _FlockingSettings;

		// Token: 0x04013C6C RID: 81004
		internal static int __PropertyOffset_4;

		// Token: 0x04013C6D RID: 81005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroFlockingData> _FlockingDataArray;

		// Token: 0x04013C6E RID: 81006
		internal static int __PropertyOffset_5;

		// Token: 0x04013C6F RID: 81007
		internal static int __PropertyOffset_6;

		// Token: 0x04013C70 RID: 81008
		internal static int __PropertyOffset_7;

		// Token: 0x04013C71 RID: 81009
		internal static int __PropertyOffset_8;

		// Token: 0x04013C72 RID: 81010
		internal static int __PropertyOffset_9;

		// Token: 0x04013C73 RID: 81011
		internal static int __PropertyOffset_10;

		// Token: 0x04013C74 RID: 81012
		internal static int __PropertyOffset_11;

		// Token: 0x04013C75 RID: 81013
		internal static int __PropertyOffset_12;

		// Token: 0x04013C76 RID: 81014
		internal static int __PropertyOffset_13;

		// Token: 0x04013C77 RID: 81015
		internal static int __PropertyOffset_14;

		// Token: 0x04013C78 RID: 81016
		internal static int __PropertyOffset_15;

		// Token: 0x04013C79 RID: 81017
		private static IntPtr __OnWorldOffset_NativeFunctionPtr;

		// Token: 0x04013C7A RID: 81018
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04013C7B RID: 81019
		private static IntPtr __SimGPU_NativeFunctionPtr;

		// Token: 0x04013C7C RID: 81020
		private static IntPtr __SimCPU_NativeFunctionPtr;

		// Token: 0x04013C7D RID: 81021
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04013C7E RID: 81022
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04013C7F RID: 81023
		private static IntPtr __OnApplyWorldOffset_NativeFunctionPtr;

		// Token: 0x0200A1FD RID: 41469
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 76)]
		protected ref struct __OnWorldOffset_FunctionParams
		{
			// Token: 0x04031E5F RID: 204383
			[FieldOffset(0)]
			public FVector Offset;
		}

		// Token: 0x0200A1FE RID: 41470
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SimGPU_FunctionParams
		{
			// Token: 0x04031E60 RID: 204384
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x0200A1FF RID: 41471
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SimCPU_FunctionParams
		{
			// Token: 0x04031E61 RID: 204385
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x0200A200 RID: 41472
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031E62 RID: 204386
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A201 RID: 41473
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected new ref struct __OnApplyWorldOffset_FunctionParams
		{
			// Token: 0x04031E63 RID: 204387
			[FieldOffset(0)]
			public FVector InWorldOffset;

			// Token: 0x04031E64 RID: 204388
			[FieldOffset(12)]
			public bool bWorldShift;
		}
	}
}
