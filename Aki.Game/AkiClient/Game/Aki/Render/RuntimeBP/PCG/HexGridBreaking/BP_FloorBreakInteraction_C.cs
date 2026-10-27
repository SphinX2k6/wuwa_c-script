using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.HexGridBreaking
{
	// Token: 0x02003CA0 RID: 15520
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_FloorBreakInteraction.BP_FloorBreakInteraction_C")]
	[UnrealStructLayout(1800, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1793)]
	public class BP_FloorBreakInteraction_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060246A5 RID: 149157 RVA: 0x0093DE0C File Offset: 0x0093C00C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloorBreakInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_FloorBreakInteraction.BP_FloorBreakInteraction_C");
			}
			return BP_FloorBreakInteraction_C._ClassPtr;
		}

		// Token: 0x060246A6 RID: 149158 RVA: 0x0093DE30 File Offset: 0x0093C030
		public BP_FloorBreakInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloorBreakInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060246A7 RID: 149159 RVA: 0x0093DE58 File Offset: 0x0093C058
		[NullableContext(1)]
		public BP_FloorBreakInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloorBreakInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046F0 RID: 18160
		// (get) Token: 0x060246A8 RID: 149160 RVA: 0x0093DE8B File Offset: 0x0093C08B
		// (set) Token: 0x060246A9 RID: 149161 RVA: 0x0093DE9F File Offset: 0x0093C09F
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170046F1 RID: 18161
		// (get) Token: 0x060246AA RID: 149162 RVA: 0x0093DEB4 File Offset: 0x0093C0B4
		// (set) Token: 0x060246AB RID: 149163 RVA: 0x0093DEC8 File Offset: 0x0093C0C8
		public unsafe UInstancedStaticMeshComponent InstancedStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170046F2 RID: 18162
		// (get) Token: 0x060246AC RID: 149164 RVA: 0x0093DEDD File Offset: 0x0093C0DD
		// (set) Token: 0x060246AD RID: 149165 RVA: 0x0093DEF1 File Offset: 0x0093C0F1
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170046F3 RID: 18163
		// (get) Token: 0x060246AE RID: 149166 RVA: 0x0093DF06 File Offset: 0x0093C106
		// (set) Token: 0x060246AF RID: 149167 RVA: 0x0093DF1A File Offset: 0x0093C11A
		public unsafe USceneComponent Scene
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x170046F4 RID: 18164
		// (get) Token: 0x060246B0 RID: 149168 RVA: 0x0093DF30 File Offset: 0x0093C130
		// (set) Token: 0x060246B1 RID: 149169 RVA: 0x0093DF69 File Offset: 0x0093C169
		[Nullable(1)]
		public TMap<string, int> InstanceIndex
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._InstanceIndex) == null)
				{
					result = (this._InstanceIndex = new TMap<string, int>(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InstanceIndex.CopyAssign(value);
			}
		}

		// Token: 0x170046F5 RID: 18165
		// (get) Token: 0x060246B2 RID: 149170 RVA: 0x0093DF77 File Offset: 0x0093C177
		// (set) Token: 0x060246B3 RID: 149171 RVA: 0x0093DF8B File Offset: 0x0093C18B
		public unsafe FVectorDouble OriginPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170046F6 RID: 18166
		// (get) Token: 0x060246B4 RID: 149172 RVA: 0x0093DFA0 File Offset: 0x0093C1A0
		// (set) Token: 0x060246B5 RID: 149173 RVA: 0x0093DFB0 File Offset: 0x0093C1B0
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170046F7 RID: 18167
		// (get) Token: 0x060246B6 RID: 149174 RVA: 0x0093DFC4 File Offset: 0x0093C1C4
		// (set) Token: 0x060246B7 RID: 149175 RVA: 0x0093DFFD File Offset: 0x0093C1FD
		[Nullable(1)]
		public TArray<FVector> DirectoryList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._DirectoryList) == null)
				{
					result = (this._DirectoryList = new TArray<FVector>(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DirectoryList.CopyAssign(value);
			}
		}

		// Token: 0x170046F8 RID: 18168
		// (get) Token: 0x060246B8 RID: 149176 RVA: 0x0093E00B File Offset: 0x0093C20B
		// (set) Token: 0x060246B9 RID: 149177 RVA: 0x0093E01B File Offset: 0x0093C21B
		public unsafe bool IsMonster
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046F9 RID: 18169
		// (get) Token: 0x060246BA RID: 149178 RVA: 0x0093E02C File Offset: 0x0093C22C
		// (set) Token: 0x060246BB RID: 149179 RVA: 0x0093E040 File Offset: 0x0093C240
		public unsafe FVectorDouble OffsetPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170046FA RID: 18170
		// (get) Token: 0x060246BC RID: 149180 RVA: 0x0093E058 File Offset: 0x0093C258
		// (set) Token: 0x060246BD RID: 149181 RVA: 0x0093E091 File Offset: 0x0093C291
		[Nullable(1)]
		public TMap<BP_RuntimeCellPieces_C, float> HitCellPieceActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<BP_RuntimeCellPieces_C, float> result;
				if ((result = this._HitCellPieceActors) == null)
				{
					result = (this._HitCellPieceActors = new TMap<BP_RuntimeCellPieces_C, float>(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HitCellPieceActors.CopyAssign(value);
			}
		}

		// Token: 0x170046FB RID: 18171
		// (get) Token: 0x060246BE RID: 149182 RVA: 0x0093E09F File Offset: 0x0093C29F
		// (set) Token: 0x060246BF RID: 149183 RVA: 0x0093E0AF File Offset: 0x0093C2AF
		public unsafe float In_Delta_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170046FC RID: 18172
		// (get) Token: 0x060246C0 RID: 149184 RVA: 0x0093E0C0 File Offset: 0x0093C2C0
		// (set) Token: 0x060246C1 RID: 149185 RVA: 0x0093E0D4 File Offset: 0x0093C2D4
		[Nullable(1)]
		public unsafe string ISMInfo
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_13)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_13)), value);
			}
		}

		// Token: 0x170046FD RID: 18173
		// (get) Token: 0x060246C2 RID: 149186 RVA: 0x0093E0E9 File Offset: 0x0093C2E9
		// (set) Token: 0x060246C3 RID: 149187 RVA: 0x0093E0FD File Offset: 0x0093C2FD
		public unsafe UInstancedStaticMeshComponent ISMComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170046FE RID: 18174
		// (get) Token: 0x060246C4 RID: 149188 RVA: 0x0093E112 File Offset: 0x0093C312
		// (set) Token: 0x060246C5 RID: 149189 RVA: 0x0093E122 File Offset: 0x0093C322
		public unsafe bool IsDesktop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046FF RID: 18175
		// (get) Token: 0x060246C6 RID: 149190 RVA: 0x0093E133 File Offset: 0x0093C333
		// (set) Token: 0x060246C7 RID: 149191 RVA: 0x0093E147 File Offset: 0x0093C347
		public unsafe UStaticMesh MobileAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004700 RID: 18176
		// (get) Token: 0x060246C8 RID: 149192 RVA: 0x0093E15C File Offset: 0x0093C35C
		// (set) Token: 0x060246C9 RID: 149193 RVA: 0x0093E170 File Offset: 0x0093C370
		public unsafe UAkAudioEvent AudioAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FloorBreakInteraction_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17004701 RID: 18177
		// (get) Token: 0x060246CA RID: 149194 RVA: 0x0093E185 File Offset: 0x0093C385
		// (set) Token: 0x060246CB RID: 149195 RVA: 0x0093E195 File Offset: 0x0093C395
		public unsafe bool Voice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloorBreakInteraction_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x060246CC RID: 149196 RVA: 0x0093E1A6 File Offset: 0x0093C3A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetMask()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__ResetMask_NativeFunctionPtr, null);
		}

		// Token: 0x060246CD RID: 149197 RVA: 0x0093E1BA File Offset: 0x0093C3BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GenerateISM()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__GenerateISM_NativeFunctionPtr, null);
		}

		// Token: 0x060246CE RID: 149198 RVA: 0x0093E1D0 File Offset: 0x0093C3D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetOffsetPosition(int Index, float OffsetDistance, ref FVectorDouble OffsetPosition)
		{
			BP_FloorBreakInteraction_C.__GetOffsetPosition_FunctionParams* ptr = stackalloc BP_FloorBreakInteraction_C.__GetOffsetPosition_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_FloorBreakInteraction_C.__GetOffsetPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloorBreakInteraction_C.__GetOffsetPosition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Index = Index;
			ptr->OffsetDistance = OffsetDistance;
			ptr->OffsetPosition = OffsetPosition;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__GetOffsetPosition_NativeFunctionPtr, (void*)ptr);
			OffsetPosition = ptr->OffsetPosition;
		}

		// Token: 0x060246CF RID: 149199 RVA: 0x0093E238 File Offset: 0x0093C438
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Initialization()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__Initialization_NativeFunctionPtr, null);
		}

		// Token: 0x060246D0 RID: 149200 RVA: 0x0093E24C File Offset: 0x0093C44C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060246D1 RID: 149201 RVA: 0x0093E260 File Offset: 0x0093C460
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060246D2 RID: 149202 RVA: 0x0093E275 File Offset: 0x0093C475
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060246D3 RID: 149203 RVA: 0x0093E289 File Offset: 0x0093C489
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060246D4 RID: 149204 RVA: 0x0093E2A0 File Offset: 0x0093C4A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FloorBreakInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FloorBreakInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloorBreakInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloorBreakInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060246D5 RID: 149205 RVA: 0x0093E2E8 File Offset: 0x0093C4E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FloorBreakInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FloorBreakInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FloorBreakInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloorBreakInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060246D6 RID: 149206 RVA: 0x0093E330 File Offset: 0x0093C530
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_FloorBreakInteraction_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_FloorBreakInteraction_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_FloorBreakInteraction_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloorBreakInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060246D7 RID: 149207 RVA: 0x0093E394 File Offset: 0x0093C594
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060246D8 RID: 149208 RVA: 0x0093E450 File Offset: 0x0093C650
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FloorBreakInteraction_C.__BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060246D9 RID: 149209 RVA: 0x0093E4D9 File Offset: 0x0093C6D9
		protected BP_FloorBreakInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012114 RID: 74004
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/HexGridBreaking/BP_FloorBreakInteraction.BP_FloorBreakInteraction_C";

		// Token: 0x04012115 RID: 74005
		private static IntPtr _ClassPtr;

		// Token: 0x04012116 RID: 74006
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012117 RID: 74007
		internal static int __PropertyOffset_1;

		// Token: 0x04012118 RID: 74008
		internal static int __PropertyOffset_2;

		// Token: 0x04012119 RID: 74009
		internal static int __PropertyOffset_3;

		// Token: 0x0401211A RID: 74010
		internal static int __PropertyOffset_4;

		// Token: 0x0401211B RID: 74011
		internal static int __PropertyOffset_5;

		// Token: 0x0401211C RID: 74012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _InstanceIndex;

		// Token: 0x0401211D RID: 74013
		internal static int __PropertyOffset_6;

		// Token: 0x0401211E RID: 74014
		internal static int __PropertyOffset_7;

		// Token: 0x0401211F RID: 74015
		internal static int __PropertyOffset_8;

		// Token: 0x04012120 RID: 74016
		private TArray<FVector> _DirectoryList;

		// Token: 0x04012121 RID: 74017
		internal static int __PropertyOffset_9;

		// Token: 0x04012122 RID: 74018
		internal static int __PropertyOffset_10;

		// Token: 0x04012123 RID: 74019
		internal static int __PropertyOffset_11;

		// Token: 0x04012124 RID: 74020
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<BP_RuntimeCellPieces_C, float> _HitCellPieceActors;

		// Token: 0x04012125 RID: 74021
		internal static int __PropertyOffset_12;

		// Token: 0x04012126 RID: 74022
		internal static int __PropertyOffset_13;

		// Token: 0x04012127 RID: 74023
		internal static int __PropertyOffset_14;

		// Token: 0x04012128 RID: 74024
		internal static int __PropertyOffset_15;

		// Token: 0x04012129 RID: 74025
		internal static int __PropertyOffset_16;

		// Token: 0x0401212A RID: 74026
		internal static int __PropertyOffset_17;

		// Token: 0x0401212B RID: 74027
		internal static int __PropertyOffset_18;

		// Token: 0x0401212C RID: 74028
		private static IntPtr __ResetMask_NativeFunctionPtr;

		// Token: 0x0401212D RID: 74029
		private static IntPtr __GenerateISM_NativeFunctionPtr;

		// Token: 0x0401212E RID: 74030
		private static IntPtr __GetOffsetPosition_NativeFunctionPtr;

		// Token: 0x0401212F RID: 74031
		private static IntPtr __Initialization_NativeFunctionPtr;

		// Token: 0x04012130 RID: 74032
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012131 RID: 74033
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012132 RID: 74034
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012133 RID: 74035
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x04012134 RID: 74036
		private static IntPtr __BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012135 RID: 74037
		private static IntPtr __BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009F15 RID: 40725
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __GetOffsetPosition_FunctionParams
		{
			// Token: 0x0403186A RID: 202858
			[FieldOffset(0)]
			public int Index;

			// Token: 0x0403186B RID: 202859
			[FieldOffset(4)]
			public float OffsetDistance;

			// Token: 0x0403186C RID: 202860
			[FieldOffset(8)]
			public FVectorDouble OffsetPosition;
		}

		// Token: 0x02009F16 RID: 40726
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403186D RID: 202861
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F17 RID: 40727
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x0403186E RID: 202862
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x0403186F RID: 202863
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031870 RID: 202864
			[FieldOffset(32)]
			public int Id;
		}

		// Token: 0x02009F18 RID: 40728
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031871 RID: 202865
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031872 RID: 202866
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031873 RID: 202867
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031874 RID: 202868
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031875 RID: 202869
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031876 RID: 202870
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F19 RID: 40729
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_FloorBreakInteraction_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031877 RID: 202871
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031878 RID: 202872
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031879 RID: 202873
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403187A RID: 202874
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
