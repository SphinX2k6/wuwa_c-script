using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.PBD_DrumKit
{
	// Token: 0x02003C47 RID: 15431
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/PBD_DrumKit/BP_Drum.BP_Drum_C")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1628)]
	public class BP_Drum_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023B79 RID: 146297 RVA: 0x0092AE45 File Offset: 0x00929045
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Drum_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/PBD_DrumKit/BP_Drum.BP_Drum_C");
			}
			return BP_Drum_C._ClassPtr;
		}

		// Token: 0x06023B7A RID: 146298 RVA: 0x0092AE6C File Offset: 0x0092906C
		public BP_Drum_C() : this(BuiltinUtils.AllocNativeUObject(BP_Drum_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023B7B RID: 146299 RVA: 0x0092AE94 File Offset: 0x00929094
		[NullableContext(1)]
		public BP_Drum_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Drum_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700432E RID: 17198
		// (get) Token: 0x06023B7C RID: 146300 RVA: 0x0092AEC7 File Offset: 0x009290C7
		// (set) Token: 0x06023B7D RID: 146301 RVA: 0x0092AEDB File Offset: 0x009290DB
		public unsafe UStaticMeshComponent StaticMesh3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700432F RID: 17199
		// (get) Token: 0x06023B7E RID: 146302 RVA: 0x0092AEF0 File Offset: 0x009290F0
		// (set) Token: 0x06023B7F RID: 146303 RVA: 0x0092AF04 File Offset: 0x00929104
		public unsafe UStaticMeshComponent StaticMesh2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004330 RID: 17200
		// (get) Token: 0x06023B80 RID: 146304 RVA: 0x0092AF19 File Offset: 0x00929119
		// (set) Token: 0x06023B81 RID: 146305 RVA: 0x0092AF2D File Offset: 0x0092912D
		public unsafe UStaticMeshComponent StaticMesh1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004331 RID: 17201
		// (get) Token: 0x06023B82 RID: 146306 RVA: 0x0092AF42 File Offset: 0x00929142
		// (set) Token: 0x06023B83 RID: 146307 RVA: 0x0092AF56 File Offset: 0x00929156
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x06023B84 RID: 146308 RVA: 0x0092AF6B File Offset: 0x0092916B
		// (set) Token: 0x06023B85 RID: 146309 RVA: 0x0092AF7F File Offset: 0x0092917F
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x06023B86 RID: 146310 RVA: 0x0092AF94 File Offset: 0x00929194
		// (set) Token: 0x06023B87 RID: 146311 RVA: 0x0092AFA4 File Offset: 0x009291A4
		public unsafe float MeshBoundRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x06023B88 RID: 146312 RVA: 0x0092AFB5 File Offset: 0x009291B5
		// (set) Token: 0x06023B89 RID: 146313 RVA: 0x0092AFC9 File Offset: 0x009291C9
		public unsafe FVectorDouble MeshPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x06023B8A RID: 146314 RVA: 0x0092AFDE File Offset: 0x009291DE
		// (set) Token: 0x06023B8B RID: 146315 RVA: 0x0092AFEE File Offset: 0x009291EE
		public unsafe float PlayerImpulseLerpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x06023B8C RID: 146316 RVA: 0x0092AFFF File Offset: 0x009291FF
		// (set) Token: 0x06023B8D RID: 146317 RVA: 0x0092B00F File Offset: 0x0092920F
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x06023B8E RID: 146318 RVA: 0x0092B020 File Offset: 0x00929220
		// (set) Token: 0x06023B8F RID: 146319 RVA: 0x0092B030 File Offset: 0x00929230
		public unsafe float PlayerImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x06023B90 RID: 146320 RVA: 0x0092B041 File Offset: 0x00929241
		// (set) Token: 0x06023B91 RID: 146321 RVA: 0x0092B055 File Offset: 0x00929255
		public unsafe FVector CurWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004339 RID: 17209
		// (get) Token: 0x06023B92 RID: 146322 RVA: 0x0092B06A File Offset: 0x0092926A
		// (set) Token: 0x06023B93 RID: 146323 RVA: 0x0092B07E File Offset: 0x0092927E
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700433A RID: 17210
		// (get) Token: 0x06023B94 RID: 146324 RVA: 0x0092B093 File Offset: 0x00929293
		// (set) Token: 0x06023B95 RID: 146325 RVA: 0x0092B0A3 File Offset: 0x009292A3
		public unsafe float HitRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x1700433B RID: 17211
		// (get) Token: 0x06023B96 RID: 146326 RVA: 0x0092B0B4 File Offset: 0x009292B4
		// (set) Token: 0x06023B97 RID: 146327 RVA: 0x0092B0C4 File Offset: 0x009292C4
		public unsafe float DamageForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700433C RID: 17212
		// (get) Token: 0x06023B98 RID: 146328 RVA: 0x0092B0D5 File Offset: 0x009292D5
		// (set) Token: 0x06023B99 RID: 146329 RVA: 0x0092B0E9 File Offset: 0x009292E9
		public unsafe UMaterialInstance MI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Drum_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700433D RID: 17213
		// (get) Token: 0x06023B9A RID: 146330 RVA: 0x0092B100 File Offset: 0x00929300
		// (set) Token: 0x06023B9B RID: 146331 RVA: 0x0092B139 File Offset: 0x00929339
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> DynamicMaterials
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DynamicMaterials) == null)
				{
					result = (this._DynamicMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DynamicMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700433E RID: 17214
		// (get) Token: 0x06023B9C RID: 146332 RVA: 0x0092B148 File Offset: 0x00929348
		// (set) Token: 0x06023B9D RID: 146333 RVA: 0x0092B181 File Offset: 0x00929381
		[Nullable(1)]
		public TArray<float> Timer
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Timer) == null)
				{
					result = (this._Timer = new TArray<float>(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_17, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Timer.CopyAssign(value);
			}
		}

		// Token: 0x1700433F RID: 17215
		// (get) Token: 0x06023B9E RID: 146334 RVA: 0x0092B190 File Offset: 0x00929390
		// (set) Token: 0x06023B9F RID: 146335 RVA: 0x0092B1C9 File Offset: 0x009293C9
		[Nullable(1)]
		public TArray<UStaticMeshComponent> Meshes
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._Meshes) == null)
				{
					result = (this._Meshes = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_18, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Meshes.CopyAssign(value);
			}
		}

		// Token: 0x17004340 RID: 17216
		// (get) Token: 0x06023BA0 RID: 146336 RVA: 0x0092B1D7 File Offset: 0x009293D7
		// (set) Token: 0x06023BA1 RID: 146337 RVA: 0x0092B1E7 File Offset: 0x009293E7
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Drum_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x06023BA2 RID: 146338 RVA: 0x0092B1F8 File Offset: 0x009293F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Drum_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023BA3 RID: 146339 RVA: 0x0092B20C File Offset: 0x0092940C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Drum_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023BA4 RID: 146340 RVA: 0x0092B224 File Offset: 0x00929424
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Completed_971E8CDE49000EC1340651962C6B5599(int PlayingID)
		{
			BP_Drum_C.__Completed_971E8CDE49000EC1340651962C6B5599_FunctionParams* ptr = stackalloc BP_Drum_C.__Completed_971E8CDE49000EC1340651962C6B5599_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Drum_C.__Completed_971E8CDE49000EC1340651962C6B5599_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Drum_C.__Completed_971E8CDE49000EC1340651962C6B5599_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayingID = PlayingID;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Drum_C.__Completed_971E8CDE49000EC1340651962C6B5599_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023BA5 RID: 146341 RVA: 0x0092B26A File Offset: 0x0092946A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Drum_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023BA6 RID: 146342 RVA: 0x0092B27E File Offset: 0x0092947E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Drum_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023BA7 RID: 146343 RVA: 0x0092B294 File Offset: 0x00929494
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Drum_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Drum_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Drum_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Drum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Drum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023BA8 RID: 146344 RVA: 0x0092B2DC File Offset: 0x009294DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Drum_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Drum_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Drum_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Drum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Drum_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023BA9 RID: 146345 RVA: 0x0092B323 File Offset: 0x00929523
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicEnable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Drum_C.__OnLogicEnable_NativeFunctionPtr, null);
		}

		// Token: 0x06023BAA RID: 146346 RVA: 0x0092B337 File Offset: 0x00929537
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicEnable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Drum_C.__OnLogicEnable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023BAB RID: 146347 RVA: 0x0092B34C File Offset: 0x0092954C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnLogicDisable()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Drum_C.__OnLogicDisable_NativeFunctionPtr, null);
		}

		// Token: 0x06023BAC RID: 146348 RVA: 0x0092B360 File Offset: 0x00929560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnLogicDisable_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Drum_C.__OnLogicDisable_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023BAD RID: 146349 RVA: 0x0092B378 File Offset: 0x00929578
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_Drum_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_Drum_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_Drum_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Drum_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Drum_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023BAE RID: 146350 RVA: 0x0092B3DB File Offset: 0x009295DB
		protected BP_Drum_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A5E RID: 72286
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/PBD_DrumKit/BP_Drum.BP_Drum_C";

		// Token: 0x04011A5F RID: 72287
		private static IntPtr _ClassPtr;

		// Token: 0x04011A60 RID: 72288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A61 RID: 72289
		internal static int __PropertyOffset_1;

		// Token: 0x04011A62 RID: 72290
		internal static int __PropertyOffset_2;

		// Token: 0x04011A63 RID: 72291
		internal static int __PropertyOffset_3;

		// Token: 0x04011A64 RID: 72292
		internal static int __PropertyOffset_4;

		// Token: 0x04011A65 RID: 72293
		internal static int __PropertyOffset_5;

		// Token: 0x04011A66 RID: 72294
		internal static int __PropertyOffset_6;

		// Token: 0x04011A67 RID: 72295
		internal static int __PropertyOffset_7;

		// Token: 0x04011A68 RID: 72296
		internal static int __PropertyOffset_8;

		// Token: 0x04011A69 RID: 72297
		internal static int __PropertyOffset_9;

		// Token: 0x04011A6A RID: 72298
		internal static int __PropertyOffset_10;

		// Token: 0x04011A6B RID: 72299
		internal static int __PropertyOffset_11;

		// Token: 0x04011A6C RID: 72300
		internal static int __PropertyOffset_12;

		// Token: 0x04011A6D RID: 72301
		internal static int __PropertyOffset_13;

		// Token: 0x04011A6E RID: 72302
		internal static int __PropertyOffset_14;

		// Token: 0x04011A6F RID: 72303
		internal static int __PropertyOffset_15;

		// Token: 0x04011A70 RID: 72304
		internal static int __PropertyOffset_16;

		// Token: 0x04011A71 RID: 72305
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DynamicMaterials;

		// Token: 0x04011A72 RID: 72306
		internal static int __PropertyOffset_17;

		// Token: 0x04011A73 RID: 72307
		private TArray<float> _Timer;

		// Token: 0x04011A74 RID: 72308
		internal static int __PropertyOffset_18;

		// Token: 0x04011A75 RID: 72309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _Meshes;

		// Token: 0x04011A76 RID: 72310
		internal static int __PropertyOffset_19;

		// Token: 0x04011A77 RID: 72311
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011A78 RID: 72312
		private static IntPtr __Completed_971E8CDE49000EC1340651962C6B5599_NativeFunctionPtr;

		// Token: 0x04011A79 RID: 72313
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011A7A RID: 72314
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011A7B RID: 72315
		private static IntPtr __OnLogicEnable_NativeFunctionPtr;

		// Token: 0x04011A7C RID: 72316
		private static IntPtr __OnLogicDisable_NativeFunctionPtr;

		// Token: 0x04011A7D RID: 72317
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009E90 RID: 40592
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Completed_971E8CDE49000EC1340651962C6B5599_FunctionParams
		{
			// Token: 0x04031754 RID: 202580
			[FieldOffset(0)]
			public int PlayingID;
		}

		// Token: 0x02009E91 RID: 40593
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031755 RID: 202581
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E92 RID: 40594
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031756 RID: 202582
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031757 RID: 202583
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031758 RID: 202584
			[FieldOffset(32)]
			public int Id;
		}
	}
}
