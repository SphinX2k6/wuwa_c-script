using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.KuroProjectilePathTracer
{
	// Token: 0x020030B7 RID: 12471
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/KuroProjectilePathTracer/BP_KuroProjectilePathTracer.BP_KuroProjectilePathTracer_C")]
	[UnrealStructLayout(1224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1224)]
	public class BP_KuroProjectilePathTracer_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DF67 RID: 122727 RVA: 0x009072FC File Offset: 0x009054FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroProjectilePathTracer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/KuroProjectilePathTracer/BP_KuroProjectilePathTracer.BP_KuroProjectilePathTracer_C");
			}
			return BP_KuroProjectilePathTracer_C._ClassPtr;
		}

		// Token: 0x0601DF68 RID: 122728 RVA: 0x00907320 File Offset: 0x00905520
		public BP_KuroProjectilePathTracer_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroProjectilePathTracer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DF69 RID: 122729 RVA: 0x00907348 File Offset: 0x00905548
		[NullableContext(1)]
		public BP_KuroProjectilePathTracer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroProjectilePathTracer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700314E RID: 12622
		// (get) Token: 0x0601DF6A RID: 122730 RVA: 0x0090737B File Offset: 0x0090557B
		// (set) Token: 0x0601DF6B RID: 122731 RVA: 0x0090738F File Offset: 0x0090558F
		public unsafe UDecalComponent Decal
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDecalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_Decal);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_Decal, value);
			}
		}

		// Token: 0x1700314F RID: 12623
		// (get) Token: 0x0601DF6C RID: 122732 RVA: 0x009073A4 File Offset: 0x009055A4
		// (set) Token: 0x0601DF6D RID: 122733 RVA: 0x009073B8 File Offset: 0x009055B8
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_Spline);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x17003150 RID: 12624
		// (get) Token: 0x0601DF6E RID: 122734 RVA: 0x009073CD File Offset: 0x009055CD
		// (set) Token: 0x0601DF6F RID: 122735 RVA: 0x009073E1 File Offset: 0x009055E1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003151 RID: 12625
		// (get) Token: 0x0601DF70 RID: 122736 RVA: 0x009073F6 File Offset: 0x009055F6
		// (set) Token: 0x0601DF71 RID: 122737 RVA: 0x00907406 File Offset: 0x00905606
		public unsafe bool Visible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_Visible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_Visible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003152 RID: 12626
		// (get) Token: 0x0601DF72 RID: 122738 RVA: 0x00907417 File Offset: 0x00905617
		// (set) Token: 0x0601DF73 RID: 122739 RVA: 0x0090742B File Offset: 0x0090562B
		public unsafe UStaticMesh DistanceRecordMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_DistanceRecordMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_DistanceRecordMesh, value);
			}
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0601DF74 RID: 122740 RVA: 0x00907440 File Offset: 0x00905640
		// (set) Token: 0x0601DF75 RID: 122741 RVA: 0x00907450 File Offset: 0x00905650
		public unsafe float DisplayDistancePerRecord
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_DisplayDistancePerRecord);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_DisplayDistancePerRecord) = value;
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0601DF76 RID: 122742 RVA: 0x00907461 File Offset: 0x00905661
		// (set) Token: 0x0601DF77 RID: 122743 RVA: 0x00907471 File Offset: 0x00905671
		public unsafe int MaxPlaceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_MaxPlaceCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_MaxPlaceCount) = value;
			}
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0601DF78 RID: 122744 RVA: 0x00907482 File Offset: 0x00905682
		// (set) Token: 0x0601DF79 RID: 122745 RVA: 0x00907492 File Offset: 0x00905692
		public unsafe float RecordDeltaAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_RecordDeltaAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_RecordDeltaAngle) = value;
			}
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0601DF7A RID: 122746 RVA: 0x009074A3 File Offset: 0x009056A3
		// (set) Token: 0x0601DF7B RID: 122747 RVA: 0x009074B3 File Offset: 0x009056B3
		public unsafe float AnimationDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_AnimationDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_AnimationDelta) = value;
			}
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0601DF7C RID: 122748 RVA: 0x009074C4 File Offset: 0x009056C4
		// (set) Token: 0x0601DF7D RID: 122749 RVA: 0x009074D4 File Offset: 0x009056D4
		public unsafe float AnimationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_AnimationSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_AnimationSpeed) = value;
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0601DF7E RID: 122750 RVA: 0x009074E8 File Offset: 0x009056E8
		// (set) Token: 0x0601DF7F RID: 122751 RVA: 0x00907521 File Offset: 0x00905721
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
					result = (this._CachedPathPositions = new TArray<FVector>(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedPathPositions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedPathPositions.CopyAssign(value);
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0601DF80 RID: 122752 RVA: 0x0090752F File Offset: 0x0090572F
		// (set) Token: 0x0601DF81 RID: 122753 RVA: 0x00907543 File Offset: 0x00905743
		public unsafe FVector CachedLastTraceDestination
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedLastTraceDestination);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedLastTraceDestination) = value;
			}
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0601DF82 RID: 122754 RVA: 0x00907558 File Offset: 0x00905758
		// (set) Token: 0x0601DF83 RID: 122755 RVA: 0x00907568 File Offset: 0x00905768
		public unsafe bool CachedReturnValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedReturnValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedReturnValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0601DF84 RID: 122756 RVA: 0x00907579 File Offset: 0x00905779
		// (set) Token: 0x0601DF85 RID: 122757 RVA: 0x0090758D File Offset: 0x0090578D
		public unsafe FVector CachedImpactPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedImpactPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedImpactPoint) = value;
			}
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0601DF86 RID: 122758 RVA: 0x009075A2 File Offset: 0x009057A2
		// (set) Token: 0x0601DF87 RID: 122759 RVA: 0x009075B6 File Offset: 0x009057B6
		public unsafe FVector CachedImpactNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedImpactNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedImpactNormal) = value;
			}
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0601DF88 RID: 122760 RVA: 0x009075CB File Offset: 0x009057CB
		// (set) Token: 0x0601DF89 RID: 122761 RVA: 0x009075DB File Offset: 0x009057DB
		public unsafe bool CachedEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_CachedEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0601DF8A RID: 122762 RVA: 0x009075EC File Offset: 0x009057EC
		// (set) Token: 0x0601DF8B RID: 122763 RVA: 0x009075FC File Offset: 0x009057FC
		public unsafe float TargetDeltaAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_TargetDeltaAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_TargetDeltaAngle) = value;
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0601DF8C RID: 122764 RVA: 0x0090760D File Offset: 0x0090580D
		// (set) Token: 0x0601DF8D RID: 122765 RVA: 0x0090761D File Offset: 0x0090581D
		public unsafe float TargetSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_TargetSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_TargetSize) = value;
			}
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0601DF8E RID: 122766 RVA: 0x0090762E File Offset: 0x0090582E
		// (set) Token: 0x0601DF8F RID: 122767 RVA: 0x0090763E File Offset: 0x0090583E
		public unsafe float TargetThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_TargetThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_TargetThreshold) = value;
			}
		}

		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x0601DF90 RID: 122768 RVA: 0x0090764F File Offset: 0x0090584F
		// (set) Token: 0x0601DF91 RID: 122769 RVA: 0x0090765F File Offset: 0x0090585F
		public unsafe float RecordSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_RecordSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_RecordSize) = value;
			}
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x0601DF92 RID: 122770 RVA: 0x00907670 File Offset: 0x00905870
		// (set) Token: 0x0601DF93 RID: 122771 RVA: 0x00907680 File Offset: 0x00905880
		public unsafe bool UseTargetDecal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_UseTargetDecal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroProjectilePathTracer_C.__PropertyOffset_UseTargetDecal) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x0601DF94 RID: 122772 RVA: 0x00907691 File Offset: 0x00905891
		// (set) Token: 0x0601DF95 RID: 122773 RVA: 0x009076A5 File Offset: 0x009058A5
		public unsafe UMaterialInstance TargetDecalMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_TargetDecalMat);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroProjectilePathTracer_C.__PropertyOffset_TargetDecalMat, value);
			}
		}

		// Token: 0x0601DF96 RID: 122774 RVA: 0x009076BA File Offset: 0x009058BA
		[SkipLocalsInit]
		public virtual void UpdateDataAsset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__UpdateDataAsset_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF97 RID: 122775 RVA: 0x009076D0 File Offset: 0x009058D0
		[SkipLocalsInit]
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

		// Token: 0x0601DF98 RID: 122776 RVA: 0x0090777D File Offset: 0x0090597D
		[SkipLocalsInit]
		public virtual void UpdateDisplay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__UpdateDisplay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF99 RID: 122777 RVA: 0x00907791 File Offset: 0x00905991
		[SkipLocalsInit]
		public virtual void ClearCache()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__ClearCache_NativeFunctionPtr, null);
		}

		// Token: 0x0601DF9A RID: 122778 RVA: 0x009077A8 File Offset: 0x009059A8
		[SkipLocalsInit]
		public unsafe virtual void SetVisible(bool IsVisible)
		{
			BP_KuroProjectilePathTracer_C.__SetVisible_FunctionParams* ptr = stackalloc BP_KuroProjectilePathTracer_C.__SetVisible_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroProjectilePathTracer_C.__SetVisible_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroProjectilePathTracer_C.__SetVisible_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsVisible = IsVisible;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__SetVisible_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DF9B RID: 122779 RVA: 0x009077F0 File Offset: 0x009059F0
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroProjectilePathTracer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DF9C RID: 122780 RVA: 0x00907838 File Offset: 0x00905A38
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroProjectilePathTracer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroProjectilePathTracer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroProjectilePathTracer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DF9D RID: 122781 RVA: 0x0090787E File Offset: 0x00905A7E
		protected BP_KuroProjectilePathTracer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD47 RID: 64839
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/KuroProjectilePathTracer/BP_KuroProjectilePathTracer.BP_KuroProjectilePathTracer_C";

		// Token: 0x0400FD48 RID: 64840
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD49 RID: 64841
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD4A RID: 64842
		internal static int __PropertyOffset_Decal;

		// Token: 0x0400FD4B RID: 64843
		internal static int __PropertyOffset_Spline;

		// Token: 0x0400FD4C RID: 64844
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FD4D RID: 64845
		internal static int __PropertyOffset_Visible;

		// Token: 0x0400FD4E RID: 64846
		internal static int __PropertyOffset_DistanceRecordMesh;

		// Token: 0x0400FD4F RID: 64847
		internal static int __PropertyOffset_DisplayDistancePerRecord;

		// Token: 0x0400FD50 RID: 64848
		internal static int __PropertyOffset_MaxPlaceCount;

		// Token: 0x0400FD51 RID: 64849
		internal static int __PropertyOffset_RecordDeltaAngle;

		// Token: 0x0400FD52 RID: 64850
		internal static int __PropertyOffset_AnimationDelta;

		// Token: 0x0400FD53 RID: 64851
		internal static int __PropertyOffset_AnimationSpeed;

		// Token: 0x0400FD54 RID: 64852
		internal static int __PropertyOffset_CachedPathPositions;

		// Token: 0x0400FD55 RID: 64853
		private TArray<FVector> _CachedPathPositions;

		// Token: 0x0400FD56 RID: 64854
		internal static int __PropertyOffset_CachedLastTraceDestination;

		// Token: 0x0400FD57 RID: 64855
		internal static int __PropertyOffset_CachedReturnValue;

		// Token: 0x0400FD58 RID: 64856
		internal static int __PropertyOffset_CachedImpactPoint;

		// Token: 0x0400FD59 RID: 64857
		internal static int __PropertyOffset_CachedImpactNormal;

		// Token: 0x0400FD5A RID: 64858
		internal static int __PropertyOffset_CachedEnable;

		// Token: 0x0400FD5B RID: 64859
		internal static int __PropertyOffset_TargetDeltaAngle;

		// Token: 0x0400FD5C RID: 64860
		internal static int __PropertyOffset_TargetSize;

		// Token: 0x0400FD5D RID: 64861
		internal static int __PropertyOffset_TargetThreshold;

		// Token: 0x0400FD5E RID: 64862
		internal static int __PropertyOffset_RecordSize;

		// Token: 0x0400FD5F RID: 64863
		internal static int __PropertyOffset_UseTargetDecal;

		// Token: 0x0400FD60 RID: 64864
		internal static int __PropertyOffset_TargetDecalMat;

		// Token: 0x0400FD61 RID: 64865
		private static IntPtr __UpdateDataAsset_NativeFunctionPtr;

		// Token: 0x0400FD62 RID: 64866
		private static IntPtr __SetPredictProjectileInfo_NativeFunctionPtr;

		// Token: 0x0400FD63 RID: 64867
		private static IntPtr __UpdateDisplay_NativeFunctionPtr;

		// Token: 0x0400FD64 RID: 64868
		private static IntPtr __ClearCache_NativeFunctionPtr;

		// Token: 0x0400FD65 RID: 64869
		private static IntPtr __SetVisible_NativeFunctionPtr;

		// Token: 0x0400FD66 RID: 64870
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008DF8 RID: 36344
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 328)]
		protected ref struct __SetPredictProjectileInfo_FunctionParams
		{
			// Token: 0x0402CA1B RID: 182811
			[FieldOffset(0)]
			public bool ReturnValue;

			// Token: 0x0402CA1C RID: 182812
			[FieldOffset(8)]
			public byte OutPathPosition;

			// Token: 0x0402CA1D RID: 182813
			[FieldOffset(24)]
			public FVector OutLastTraceDestination;

			// Token: 0x0402CA1E RID: 182814
			[FieldOffset(36)]
			public byte OutHit;
		}

		// Token: 0x02008DF9 RID: 36345
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetVisible_FunctionParams
		{
			// Token: 0x0402CA1F RID: 182815
			[FieldOffset(0)]
			public bool IsVisible;
		}

		// Token: 0x02008DFA RID: 36346
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA20 RID: 182816
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
