using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.KuroProjectilePathTracer
{
	// Token: 0x02003B39 RID: 15161
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/KuroProjectilePathTracer/PD_KuroProjectileAsset.PD_KuroProjectileAsset_C")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class PD_KuroProjectileAsset_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060218AB RID: 137387 RVA: 0x008EF0A0 File Offset: 0x008ED2A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_KuroProjectileAsset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/KuroProjectilePathTracer/PD_KuroProjectileAsset.PD_KuroProjectileAsset_C");
			}
			return PD_KuroProjectileAsset_C._ClassPtr;
		}

		// Token: 0x060218AC RID: 137388 RVA: 0x008EF0C4 File Offset: 0x008ED2C4
		public PD_KuroProjectileAsset_C() : this(BuiltinUtils.AllocNativeUObject(PD_KuroProjectileAsset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060218AD RID: 137389 RVA: 0x008EF0EC File Offset: 0x008ED2EC
		[NullableContext(1)]
		public PD_KuroProjectileAsset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_KuroProjectileAsset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x060218AE RID: 137390 RVA: 0x008EF11F File Offset: 0x008ED31F
		// (set) Token: 0x060218AF RID: 137391 RVA: 0x008EF133 File Offset: 0x008ED333
		public unsafe UStaticMesh DistanceRocordMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PD_KuroProjectileAsset_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_KuroProjectileAsset_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x060218B0 RID: 137392 RVA: 0x008EF148 File Offset: 0x008ED348
		// (set) Token: 0x060218B1 RID: 137393 RVA: 0x008EF158 File Offset: 0x008ED358
		public unsafe float DisplayDistancePerRecord
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x060218B2 RID: 137394 RVA: 0x008EF169 File Offset: 0x008ED369
		// (set) Token: 0x060218B3 RID: 137395 RVA: 0x008EF179 File Offset: 0x008ED379
		public unsafe int MaxPlaceCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x060218B4 RID: 137396 RVA: 0x008EF18A File Offset: 0x008ED38A
		// (set) Token: 0x060218B5 RID: 137397 RVA: 0x008EF19A File Offset: 0x008ED39A
		public unsafe float RecordDeltaAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x060218B6 RID: 137398 RVA: 0x008EF1AB File Offset: 0x008ED3AB
		// (set) Token: 0x060218B7 RID: 137399 RVA: 0x008EF1BB File Offset: 0x008ED3BB
		public unsafe float TargetDeltaAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x060218B8 RID: 137400 RVA: 0x008EF1CC File Offset: 0x008ED3CC
		// (set) Token: 0x060218B9 RID: 137401 RVA: 0x008EF1DC File Offset: 0x008ED3DC
		public unsafe float TargetSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x060218BA RID: 137402 RVA: 0x008EF1ED File Offset: 0x008ED3ED
		// (set) Token: 0x060218BB RID: 137403 RVA: 0x008EF1FD File Offset: 0x008ED3FD
		public unsafe float TargetThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x060218BC RID: 137404 RVA: 0x008EF20E File Offset: 0x008ED40E
		// (set) Token: 0x060218BD RID: 137405 RVA: 0x008EF21E File Offset: 0x008ED41E
		public unsafe float AnimationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x060218BE RID: 137406 RVA: 0x008EF22F File Offset: 0x008ED42F
		// (set) Token: 0x060218BF RID: 137407 RVA: 0x008EF23F File Offset: 0x008ED43F
		public unsafe float RecordSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PD_KuroProjectileAsset_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x060218C0 RID: 137408 RVA: 0x008EF250 File Offset: 0x008ED450
		// (set) Token: 0x060218C1 RID: 137409 RVA: 0x008EF264 File Offset: 0x008ED464
		public unsafe UMaterialInstance TargetDecalMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + PD_KuroProjectileAsset_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PD_KuroProjectileAsset_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x060218C2 RID: 137410 RVA: 0x008EF279 File Offset: 0x008ED479
		protected PD_KuroProjectileAsset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401058C RID: 66956
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/KuroProjectilePathTracer/PD_KuroProjectileAsset.PD_KuroProjectileAsset_C";

		// Token: 0x0401058D RID: 66957
		private static IntPtr _ClassPtr;

		// Token: 0x0401058E RID: 66958
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401058F RID: 66959
		internal static int __PropertyOffset_0;

		// Token: 0x04010590 RID: 66960
		internal static int __PropertyOffset_1;

		// Token: 0x04010591 RID: 66961
		internal static int __PropertyOffset_2;

		// Token: 0x04010592 RID: 66962
		internal static int __PropertyOffset_3;

		// Token: 0x04010593 RID: 66963
		internal static int __PropertyOffset_4;

		// Token: 0x04010594 RID: 66964
		internal static int __PropertyOffset_5;

		// Token: 0x04010595 RID: 66965
		internal static int __PropertyOffset_6;

		// Token: 0x04010596 RID: 66966
		internal static int __PropertyOffset_7;

		// Token: 0x04010597 RID: 66967
		internal static int __PropertyOffset_8;

		// Token: 0x04010598 RID: 66968
		internal static int __PropertyOffset_9;
	}
}
