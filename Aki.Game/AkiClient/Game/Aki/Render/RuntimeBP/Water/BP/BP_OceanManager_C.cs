using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Water.BP
{
	// Token: 0x02003A89 RID: 14985
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Water/BP/BP_OceanManager.BP_OceanManager_C")]
	[UnrealStructLayout(1192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1192)]
	public class BP_OceanManager_C : AActor, IUnrealUObject, IUnrealObject, INiagaraParticleCallbackHandler, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601FD57 RID: 130391 RVA: 0x008C3D4E File Offset: 0x008C1F4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_OceanManager_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Water/BP/BP_OceanManager.BP_OceanManager_C");
			}
			return BP_OceanManager_C._ClassPtr;
		}

		// Token: 0x0601FD58 RID: 130392 RVA: 0x008C3D72 File Offset: 0x008C1F72
		int INiagaraParticleCallbackHandler.InterfaceOffset()
		{
			return BP_OceanManager_C.__InterfaceOffset_INiagaraParticleCallbackHandler;
		}

		// Token: 0x0601FD59 RID: 130393 RVA: 0x008C3D7C File Offset: 0x008C1F7C
		public BP_OceanManager_C() : this(BuiltinUtils.AllocNativeUObject(BP_OceanManager_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FD5A RID: 130394 RVA: 0x008C3DA4 File Offset: 0x008C1FA4
		[NullableContext(1)]
		public BP_OceanManager_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_OceanManager_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x0601FD5B RID: 130395 RVA: 0x008C3DD7 File Offset: 0x008C1FD7
		// (set) Token: 0x0601FD5C RID: 130396 RVA: 0x008C3DEB File Offset: 0x008C1FEB
		public unsafe UNiagaraComponent NS_OceanData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x0601FD5D RID: 130397 RVA: 0x008C3E00 File Offset: 0x008C2000
		// (set) Token: 0x0601FD5E RID: 130398 RVA: 0x008C3E14 File Offset: 0x008C2014
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x0601FD5F RID: 130399 RVA: 0x008C3E2C File Offset: 0x008C202C
		// (set) Token: 0x0601FD60 RID: 130400 RVA: 0x008C3E65 File Offset: 0x008C2065
		[Nullable(1)]
		public TArray<FVector> A_ActorPosArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._A_ActorPosArray) == null)
				{
					result = (this._A_ActorPosArray = new TArray<FVector>(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.A_ActorPosArray.CopyAssign(value);
			}
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x0601FD61 RID: 130401 RVA: 0x008C3E73 File Offset: 0x008C2073
		// (set) Token: 0x0601FD62 RID: 130402 RVA: 0x008C3E83 File Offset: 0x008C2083
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x0601FD63 RID: 130403 RVA: 0x008C3E94 File Offset: 0x008C2094
		// (set) Token: 0x0601FD64 RID: 130404 RVA: 0x008C3ECD File Offset: 0x008C20CD
		[Nullable(1)]
		public TArray<AActor> A_ActorArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._A_ActorArray) == null)
				{
					result = (this._A_ActorArray = new TArray<AActor>(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.A_ActorArray.CopyAssign(value);
			}
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x0601FD65 RID: 130405 RVA: 0x008C3EDB File Offset: 0x008C20DB
		// (set) Token: 0x0601FD66 RID: 130406 RVA: 0x008C3EEF File Offset: 0x008C20EF
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0601FD67 RID: 130407 RVA: 0x008C3F04 File Offset: 0x008C2104
		// (set) Token: 0x0601FD68 RID: 130408 RVA: 0x008C3F3D File Offset: 0x008C213D
		[Nullable(1)]
		public TArray<FVector4> sphereList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector4> result;
				if ((result = this._sphereList) == null)
				{
					result = (this._sphereList = new TArray<FVector4>(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.sphereList.CopyAssign(value);
			}
		}

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x0601FD69 RID: 130409 RVA: 0x008C3F4B File Offset: 0x008C214B
		// (set) Token: 0x0601FD6A RID: 130410 RVA: 0x008C3F5B File Offset: 0x008C215B
		public unsafe float dt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x0601FD6B RID: 130411 RVA: 0x008C3F6C File Offset: 0x008C216C
		// (set) Token: 0x0601FD6C RID: 130412 RVA: 0x008C3F7C File Offset: 0x008C217C
		public unsafe float V_inWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x0601FD6D RID: 130413 RVA: 0x008C3F8D File Offset: 0x008C218D
		// (set) Token: 0x0601FD6E RID: 130414 RVA: 0x008C3F9D File Offset: 0x008C219D
		public unsafe float V_total
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x0601FD6F RID: 130415 RVA: 0x008C3FB0 File Offset: 0x008C21B0
		// (set) Token: 0x0601FD70 RID: 130416 RVA: 0x008C3FE9 File Offset: 0x008C21E9
		[Nullable(1)]
		public TArray<float> waveHeightList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._waveHeightList) == null)
				{
					result = (this._waveHeightList = new TArray<float>(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.waveHeightList.CopyAssign(value);
			}
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x0601FD71 RID: 130417 RVA: 0x008C3FF7 File Offset: 0x008C21F7
		// (set) Token: 0x0601FD72 RID: 130418 RVA: 0x008C4007 File Offset: 0x008C2207
		public unsafe float timescale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_OceanManager_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x0601FD73 RID: 130419 RVA: 0x008C4018 File Offset: 0x008C2218
		// (set) Token: 0x0601FD74 RID: 130420 RVA: 0x008C402C File Offset: 0x008C222C
		public unsafe UVolumeTexture OceanWaveVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x0601FD75 RID: 130421 RVA: 0x008C4041 File Offset: 0x008C2241
		// (set) Token: 0x0601FD76 RID: 130422 RVA: 0x008C4055 File Offset: 0x008C2255
		public unsafe UTexture NewVar_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_OceanManager_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x0601FD77 RID: 130423 RVA: 0x008C406A File Offset: 0x008C226A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_OceanManager_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD78 RID: 130424 RVA: 0x008C407E File Offset: 0x008C227E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_OceanManager_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FD79 RID: 130425 RVA: 0x008C4093 File Offset: 0x008C2293
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_OceanManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601FD7A RID: 130426 RVA: 0x008C40A7 File Offset: 0x008C22A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_OceanManager_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601FD7B RID: 130427 RVA: 0x008C40BC File Offset: 0x008C22BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReceiveParticleData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_OceanManager_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_OceanManager_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_OceanManager_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_OceanManager_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_OceanManager_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_OceanManager_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FD7C RID: 130428 RVA: 0x008C414C File Offset: 0x008C234C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveParticleData_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_OceanManager_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_OceanManager_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_OceanManager_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_OceanManager_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_OceanManager_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_OceanManager_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FD7D RID: 130429 RVA: 0x008C41DB File Offset: 0x008C23DB
		protected BP_OceanManager_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F587 RID: 62855
		internal static int __InterfaceOffset_INiagaraParticleCallbackHandler;

		// Token: 0x0400F588 RID: 62856
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Water/BP/BP_OceanManager.BP_OceanManager_C";

		// Token: 0x0400F589 RID: 62857
		private static IntPtr _ClassPtr;

		// Token: 0x0400F58A RID: 62858
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F58B RID: 62859
		internal static int __PropertyOffset_1;

		// Token: 0x0400F58C RID: 62860
		internal static int __PropertyOffset_2;

		// Token: 0x0400F58D RID: 62861
		internal static int __PropertyOffset_3;

		// Token: 0x0400F58E RID: 62862
		private TArray<FVector> _A_ActorPosArray;

		// Token: 0x0400F58F RID: 62863
		internal static int __PropertyOffset_4;

		// Token: 0x0400F590 RID: 62864
		internal static int __PropertyOffset_5;

		// Token: 0x0400F591 RID: 62865
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _A_ActorArray;

		// Token: 0x0400F592 RID: 62866
		internal static int __PropertyOffset_6;

		// Token: 0x0400F593 RID: 62867
		internal static int __PropertyOffset_7;

		// Token: 0x0400F594 RID: 62868
		private TArray<FVector4> _sphereList;

		// Token: 0x0400F595 RID: 62869
		internal static int __PropertyOffset_8;

		// Token: 0x0400F596 RID: 62870
		internal static int __PropertyOffset_9;

		// Token: 0x0400F597 RID: 62871
		internal static int __PropertyOffset_10;

		// Token: 0x0400F598 RID: 62872
		internal static int __PropertyOffset_11;

		// Token: 0x0400F599 RID: 62873
		private TArray<float> _waveHeightList;

		// Token: 0x0400F59A RID: 62874
		internal static int __PropertyOffset_12;

		// Token: 0x0400F59B RID: 62875
		internal static int __PropertyOffset_13;

		// Token: 0x0400F59C RID: 62876
		internal static int __PropertyOffset_14;

		// Token: 0x0400F59D RID: 62877
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F59E RID: 62878
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F59F RID: 62879
		private static IntPtr __ReceiveParticleData_NativeFunctionPtr;

		// Token: 0x02009B59 RID: 39769
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveParticleData_FunctionParams
		{
			// Token: 0x04031182 RID: 201090
			[FieldOffset(0)]
			public byte Data;

			// Token: 0x04031183 RID: 201091
			[FieldOffset(16)]
			public IntPtr NiagaraSystem;
		}
	}
}
