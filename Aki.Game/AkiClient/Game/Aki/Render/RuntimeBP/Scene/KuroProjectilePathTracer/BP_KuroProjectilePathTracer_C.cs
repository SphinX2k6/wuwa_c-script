using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.KuroProjectilePathTracer
{
	// Token: 0x02003B38 RID: 15160
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/KuroProjectilePathTracer/BP_KuroProjectilePathTracer.BP_KuroProjectilePathTracer_C")]
	[UnrealStructLayout(1224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1224)]
	public class BP_KuroProjectilePathTracer_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021870 RID: 137328 RVA: 0x008EEAC4 File Offset: 0x008ECCC4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroProjectilePathTracer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/KuroProjectilePathTracer/BP_KuroProjectilePathTracer.BP_KuroProjectilePathTracer_C");
			}
			return BP_KuroProjectilePathTracer_C._ClassPtr;
		}

		// Token: 0x06021871 RID: 137329 RVA: 0x008EEAE8 File Offset: 0x008ECCE8
		public BP_KuroProjectilePathTracer_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroProjectilePathTracer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021872 RID: 137330 RVA: 0x008EEB10 File Offset: 0x008ECD10
		[NullableContext(1)]
		public BP_KuroProjectilePathTracer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroProjectilePathTracer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x06021873 RID: 137331 RVA: 0x008EEB43 File Offset: 0x008ECD43
		// (set) Token: 0x06021874 RID: 137332 RVA: 0x008EEB57 File Offset: 0x008ECD57
		public unsafe UDecalComponent Decal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x06021875 RID: 137333 RVA: 0x008EEB6C File Offset: 0x008ECD6C
		// (set) Token: 0x06021876 RID: 137334 RVA: 0x008EEB80 File Offset: 0x008ECD80
		public unsafe UHierarchicalInstancedStaticMeshComponent HierarchicalInstancedStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHierarchicalInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x06021877 RID: 137335 RVA: 0x008EEB95 File Offset: 0x008ECD95
		// (set) Token: 0x06021878 RID: 137336 RVA: 0x008EEBA9 File Offset: 0x008ECDA9
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x06021879 RID: 137337 RVA: 0x008EEBBE File Offset: 0x008ECDBE
		// (set) Token: 0x0602187A RID: 137338 RVA: 0x008EEBD2 File Offset: 0x008ECDD2
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x0602187B RID: 137339 RVA: 0x008EEBE7 File Offset: 0x008ECDE7
		// (set) Token: 0x0602187C RID: 137340 RVA: 0x008EEBF7 File Offset: 0x008ECDF7
		public unsafe bool Visible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0602187D RID: 137341 RVA: 0x008EEC08 File Offset: 0x008ECE08
		// (set) Token: 0x0602187E RID: 137342 RVA: 0x008EEC1C File Offset: 0x008ECE1C
		public unsafe UStaticMesh DistanceRecordMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0602187F RID: 137343 RVA: 0x008EEC31 File Offset: 0x008ECE31
		// (set) Token: 0x06021880 RID: 137344 RVA: 0x008EEC41 File Offset: 0x008ECE41
		public unsafe float DisplayDistancePerRecord
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x06021881 RID: 137345 RVA: 0x008EEC52 File Offset: 0x008ECE52
		// (set) Token: 0x06021882 RID: 137346 RVA: 0x008EEC62 File Offset: 0x008ECE62
		public unsafe int MaxPlaceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x06021883 RID: 137347 RVA: 0x008EEC73 File Offset: 0x008ECE73
		// (set) Token: 0x06021884 RID: 137348 RVA: 0x008EEC83 File Offset: 0x008ECE83
		public unsafe float RecordDeltaAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x06021885 RID: 137349 RVA: 0x008EEC94 File Offset: 0x008ECE94
		// (set) Token: 0x06021886 RID: 137350 RVA: 0x008EECA4 File Offset: 0x008ECEA4
		public unsafe float AnimationDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x06021887 RID: 137351 RVA: 0x008EECB5 File Offset: 0x008ECEB5
		// (set) Token: 0x06021888 RID: 137352 RVA: 0x008EECC5 File Offset: 0x008ECEC5
		public unsafe float AnimationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x06021889 RID: 137353 RVA: 0x008EECD8 File Offset: 0x008ECED8
		// (set) Token: 0x0602188A RID: 137354 RVA: 0x008EED11 File Offset: 0x008ECF11
		[Nullable(1)]
		public TArray<FVector> CachedPathPositions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._CachedPathPositions) == null)
				{
					result = (this._CachedPathPositions = new TArray<FVector>(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedPathPositions.CopyAssign(value);
			}
		}

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0602188B RID: 137355 RVA: 0x008EED1F File Offset: 0x008ECF1F
		// (set) Token: 0x0602188C RID: 137356 RVA: 0x008EED33 File Offset: 0x008ECF33
		public unsafe FVector CachedLastTraceDestination
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0602188D RID: 137357 RVA: 0x008EED48 File Offset: 0x008ECF48
		// (set) Token: 0x0602188E RID: 137358 RVA: 0x008EED58 File Offset: 0x008ECF58
		public unsafe bool CachedReturnValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0602188F RID: 137359 RVA: 0x008EED69 File Offset: 0x008ECF69
		// (set) Token: 0x06021890 RID: 137360 RVA: 0x008EED7D File Offset: 0x008ECF7D
		public unsafe FVector CachedImpactPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x06021891 RID: 137361 RVA: 0x008EED92 File Offset: 0x008ECF92
		// (set) Token: 0x06021892 RID: 137362 RVA: 0x008EEDA6 File Offset: 0x008ECFA6
		public unsafe FVector CachedImpactNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x06021893 RID: 137363 RVA: 0x008EEDBB File Offset: 0x008ECFBB
		// (set) Token: 0x06021894 RID: 137364 RVA: 0x008EEDCB File Offset: 0x008ECFCB
		public unsafe bool CachedEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x06021895 RID: 137365 RVA: 0x008EEDDC File Offset: 0x008ECFDC
		// (set) Token: 0x06021896 RID: 137366 RVA: 0x008EEDEC File Offset: 0x008ECFEC
		public unsafe float TargetDeltaAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x06021897 RID: 137367 RVA: 0x008EEDFD File Offset: 0x008ECFFD
		// (set) Token: 0x06021898 RID: 137368 RVA: 0x008EEE0D File Offset: 0x008ED00D
		public unsafe float TargetSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x06021899 RID: 137369 RVA: 0x008EEE1E File Offset: 0x008ED01E
		// (set) Token: 0x0602189A RID: 137370 RVA: 0x008EEE2E File Offset: 0x008ED02E
		public unsafe float TargetThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0602189B RID: 137371 RVA: 0x008EEE3F File Offset: 0x008ED03F
		// (set) Token: 0x0602189C RID: 137372 RVA: 0x008EEE53 File Offset: 0x008ED053
		public unsafe PD_KuroProjectileAsset_C KuroProjectileAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_KuroProjectileAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0602189D RID: 137373 RVA: 0x008EEE68 File Offset: 0x008ED068
		// (set) Token: 0x0602189E RID: 137374 RVA: 0x008EEE78 File Offset: 0x008ED078
		public unsafe float RecordSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0602189F RID: 137375 RVA: 0x008EEE89 File Offset: 0x008ED089
		// (set) Token: 0x060218A0 RID: 137376 RVA: 0x008EEE99 File Offset: 0x008ED099
		public unsafe bool UseTargetDecal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x060218A1 RID: 137377 RVA: 0x008EEEAA File Offset: 0x008ED0AA
		// (set) Token: 0x060218A2 RID: 137378 RVA: 0x008EEEBE File Offset: 0x008ED0BE
		public unsafe UMaterialInstance TargetDecalMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x060218A3 RID: 137379 RVA: 0x008EEED3 File Offset: 0x008ED0D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDataAsset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__UpdateDataAsset_NativeFunctionPtr, null);
		}

		// Token: 0x060218A4 RID: 137380 RVA: 0x008EEEE8 File Offset: 0x008ED0E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPredictProjectileInfo(bool ReturnValue, ref TArray<FVector> OutPathPosition, FVector OutLastTraceDestination, FHitResult OutHit)
		{
			BP_KuroProjectilePathTracer_C.__SetPredictProjectileInfo_FunctionParams* ptr = stackalloc BP_KuroProjectilePathTracer_C.__SetPredictProjectileInfo_FunctionParams[(UIntPtr)343] + 15L / (long)sizeof(BP_KuroProjectilePathTracer_C.__SetPredictProjectileInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroProjectilePathTracer_C.__SetPredictProjectileInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ReturnValue = ReturnValue;
			TArray<FVector> tarray = OutPathPosition;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutPathPosition);
			}
			ptr->OutLastTraceDestination = OutLastTraceDestination;
			if (OutHit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->OutHit, OutHit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__SetPredictProjectileInfo_NativeFunctionPtr, (void*)ptr);
			TArray<FVector> tarray2 = OutPathPosition;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutPathPosition);
			}
			UnrealReflectionUtils.DestroyStruct(BP_KuroProjectilePathTracer_C.__SetPredictProjectileInfo_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060218A5 RID: 137381 RVA: 0x008EEF95 File Offset: 0x008ED195
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateDisplay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__UpdateDisplay_NativeFunctionPtr, null);
		}

		// Token: 0x060218A6 RID: 137382 RVA: 0x008EEFA9 File Offset: 0x008ED1A9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearCache()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__ClearCache_NativeFunctionPtr, null);
		}

		// Token: 0x060218A7 RID: 137383 RVA: 0x008EEFC0 File Offset: 0x008ED1C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetVisible(bool IsVisible)
		{
			BP_KuroProjectilePathTracer_C.__SetVisible_FunctionParams* ptr = stackalloc BP_KuroProjectilePathTracer_C.__SetVisible_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroProjectilePathTracer_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroProjectilePathTracer_C.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsVisible = IsVisible;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060218A8 RID: 137384 RVA: 0x008EF008 File Offset: 0x008ED208
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroProjectilePathTracer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060218A9 RID: 137385 RVA: 0x008EF050 File Offset: 0x008ED250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroProjectilePathTracer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060218AA RID: 137386 RVA: 0x008EF097 File Offset: 0x008ED297
		protected BP_KuroProjectilePathTracer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401056A RID: 66922
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/KuroProjectilePathTracer/BP_KuroProjectilePathTracer.BP_KuroProjectilePathTracer_C";

		// Token: 0x0401056B RID: 66923
		private static IntPtr _ClassPtr;

		// Token: 0x0401056C RID: 66924
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401056D RID: 66925
		internal static int __PropertyOffset_1;

		// Token: 0x0401056E RID: 66926
		internal static int __PropertyOffset_2;

		// Token: 0x0401056F RID: 66927
		internal static int __PropertyOffset_3;

		// Token: 0x04010570 RID: 66928
		internal static int __PropertyOffset_4;

		// Token: 0x04010571 RID: 66929
		internal static int __PropertyOffset_5;

		// Token: 0x04010572 RID: 66930
		internal static int __PropertyOffset_6;

		// Token: 0x04010573 RID: 66931
		internal static int __PropertyOffset_7;

		// Token: 0x04010574 RID: 66932
		internal static int __PropertyOffset_8;

		// Token: 0x04010575 RID: 66933
		internal static int __PropertyOffset_9;

		// Token: 0x04010576 RID: 66934
		internal static int __PropertyOffset_10;

		// Token: 0x04010577 RID: 66935
		internal static int __PropertyOffset_11;

		// Token: 0x04010578 RID: 66936
		internal static int __PropertyOffset_12;

		// Token: 0x04010579 RID: 66937
		private TArray<FVector> _CachedPathPositions;

		// Token: 0x0401057A RID: 66938
		internal static int __PropertyOffset_13;

		// Token: 0x0401057B RID: 66939
		internal static int __PropertyOffset_14;

		// Token: 0x0401057C RID: 66940
		internal static int __PropertyOffset_15;

		// Token: 0x0401057D RID: 66941
		internal static int __PropertyOffset_16;

		// Token: 0x0401057E RID: 66942
		internal static int __PropertyOffset_17;

		// Token: 0x0401057F RID: 66943
		internal static int __PropertyOffset_18;

		// Token: 0x04010580 RID: 66944
		internal static int __PropertyOffset_19;

		// Token: 0x04010581 RID: 66945
		internal static int __PropertyOffset_20;

		// Token: 0x04010582 RID: 66946
		internal static int __PropertyOffset_21;

		// Token: 0x04010583 RID: 66947
		internal static int __PropertyOffset_22;

		// Token: 0x04010584 RID: 66948
		internal static int __PropertyOffset_23;

		// Token: 0x04010585 RID: 66949
		internal static int __PropertyOffset_24;

		// Token: 0x04010586 RID: 66950
		private static IntPtr __UpdateDataAsset_NativeFunctionPtr;

		// Token: 0x04010587 RID: 66951
		private static IntPtr __SetPredictProjectileInfo_NativeFunctionPtr;

		// Token: 0x04010588 RID: 66952
		private static IntPtr __UpdateDisplay_NativeFunctionPtr;

		// Token: 0x04010589 RID: 66953
		private static IntPtr __ClearCache_NativeFunctionPtr;

		// Token: 0x0401058A RID: 66954
		private static IntPtr __SetVisible_NativeFunctionPtr;

		// Token: 0x0401058B RID: 66955
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009C9F RID: 40095
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 328)]
		protected ref struct __SetPredictProjectileInfo_FunctionParams
		{
			// Token: 0x04031364 RID: 201572
			[FieldOffset(0)]
			public bool ReturnValue;

			// Token: 0x04031365 RID: 201573
			[FieldOffset(8)]
			public byte OutPathPosition;

			// Token: 0x04031366 RID: 201574
			[FieldOffset(24)]
			public FVector OutLastTraceDestination;

			// Token: 0x04031367 RID: 201575
			[FieldOffset(36)]
			public byte OutHit;
		}

		// Token: 0x02009CA0 RID: 40096
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetVisible_FunctionParams
		{
			// Token: 0x04031368 RID: 201576
			[FieldOffset(0)]
			public bool IsVisible;
		}

		// Token: 0x02009CA1 RID: 40097
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031369 RID: 201577
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
