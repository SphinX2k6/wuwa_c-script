using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Metaballs
{
	// Token: 0x02003C4F RID: 15439
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Metaballs/BP_MetaballForMobile.BP_MetaballForMobile_C")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class BP_MetaballForMobile_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023C74 RID: 146548 RVA: 0x0092C9BB File Offset: 0x0092ABBB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MetaballForMobile_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Metaballs/BP_MetaballForMobile.BP_MetaballForMobile_C");
			}
			return BP_MetaballForMobile_C._ClassPtr;
		}

		// Token: 0x06023C75 RID: 146549 RVA: 0x0092C9E0 File Offset: 0x0092ABE0
		public BP_MetaballForMobile_C() : this(BuiltinUtils.AllocNativeUObject(BP_MetaballForMobile_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023C76 RID: 146550 RVA: 0x0092CA08 File Offset: 0x0092AC08
		[NullableContext(1)]
		public BP_MetaballForMobile_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MetaballForMobile_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004382 RID: 17282
		// (get) Token: 0x06023C77 RID: 146551 RVA: 0x0092CA3B File Offset: 0x0092AC3B
		// (set) Token: 0x06023C78 RID: 146552 RVA: 0x0092CA4F File Offset: 0x0092AC4F
		public unsafe UBoxComponent BoundSize
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004383 RID: 17283
		// (get) Token: 0x06023C79 RID: 146553 RVA: 0x0092CA64 File Offset: 0x0092AC64
		// (set) Token: 0x06023C7A RID: 146554 RVA: 0x0092CA78 File Offset: 0x0092AC78
		public unsafe UStaticMeshComponent Sphere4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004384 RID: 17284
		// (get) Token: 0x06023C7B RID: 146555 RVA: 0x0092CA8D File Offset: 0x0092AC8D
		// (set) Token: 0x06023C7C RID: 146556 RVA: 0x0092CAA1 File Offset: 0x0092ACA1
		public unsafe UStaticMeshComponent Sphere3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004385 RID: 17285
		// (get) Token: 0x06023C7D RID: 146557 RVA: 0x0092CAB6 File Offset: 0x0092ACB6
		// (set) Token: 0x06023C7E RID: 146558 RVA: 0x0092CACA File Offset: 0x0092ACCA
		public unsafe UStaticMeshComponent Sphere2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004386 RID: 17286
		// (get) Token: 0x06023C7F RID: 146559 RVA: 0x0092CADF File Offset: 0x0092ACDF
		// (set) Token: 0x06023C80 RID: 146560 RVA: 0x0092CAF3 File Offset: 0x0092ACF3
		public unsafe UStaticMeshComponent Sphere1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004387 RID: 17287
		// (get) Token: 0x06023C81 RID: 146561 RVA: 0x0092CB08 File Offset: 0x0092AD08
		// (set) Token: 0x06023C82 RID: 146562 RVA: 0x0092CB1C File Offset: 0x0092AD1C
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004388 RID: 17288
		// (get) Token: 0x06023C83 RID: 146563 RVA: 0x0092CB31 File Offset: 0x0092AD31
		// (set) Token: 0x06023C84 RID: 146564 RVA: 0x0092CB45 File Offset: 0x0092AD45
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004389 RID: 17289
		// (get) Token: 0x06023C85 RID: 146565 RVA: 0x0092CB5A File Offset: 0x0092AD5A
		// (set) Token: 0x06023C86 RID: 146566 RVA: 0x0092CB6E File Offset: 0x0092AD6E
		public unsafe FVector 包围盒范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700438A RID: 17290
		// (get) Token: 0x06023C87 RID: 146567 RVA: 0x0092CB83 File Offset: 0x0092AD83
		// (set) Token: 0x06023C88 RID: 146568 RVA: 0x0092CB93 File Offset: 0x0092AD93
		public unsafe float 小球运动模式
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700438B RID: 17291
		// (get) Token: 0x06023C89 RID: 146569 RVA: 0x0092CBA4 File Offset: 0x0092ADA4
		// (set) Token: 0x06023C8A RID: 146570 RVA: 0x0092CBB4 File Offset: 0x0092ADB4
		public unsafe float 小球基础半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700438C RID: 17292
		// (get) Token: 0x06023C8B RID: 146571 RVA: 0x0092CBC5 File Offset: 0x0092ADC5
		// (set) Token: 0x06023C8C RID: 146572 RVA: 0x0092CBD5 File Offset: 0x0092ADD5
		public unsafe float 小球半径波动
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700438D RID: 17293
		// (get) Token: 0x06023C8D RID: 146573 RVA: 0x0092CBE6 File Offset: 0x0092ADE6
		// (set) Token: 0x06023C8E RID: 146574 RVA: 0x0092CBF6 File Offset: 0x0092ADF6
		public unsafe float 小球运动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700438E RID: 17294
		// (get) Token: 0x06023C8F RID: 146575 RVA: 0x0092CC07 File Offset: 0x0092AE07
		// (set) Token: 0x06023C90 RID: 146576 RVA: 0x0092CC1B File Offset: 0x0092AE1B
		public unsafe UMaterialInstanceDynamic SphereDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x1700438F RID: 17295
		// (get) Token: 0x06023C91 RID: 146577 RVA: 0x0092CC30 File Offset: 0x0092AE30
		// (set) Token: 0x06023C92 RID: 146578 RVA: 0x0092CC44 File Offset: 0x0092AE44
		public unsafe FLinearColor 小球中心颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004390 RID: 17296
		// (get) Token: 0x06023C93 RID: 146579 RVA: 0x0092CC59 File Offset: 0x0092AE59
		// (set) Token: 0x06023C94 RID: 146580 RVA: 0x0092CC6D File Offset: 0x0092AE6D
		public unsafe FLinearColor 小球边缘颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004391 RID: 17297
		// (get) Token: 0x06023C95 RID: 146581 RVA: 0x0092CC82 File Offset: 0x0092AE82
		// (set) Token: 0x06023C96 RID: 146582 RVA: 0x0092CC92 File Offset: 0x0092AE92
		public unsafe float 核心球半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004392 RID: 17298
		// (get) Token: 0x06023C97 RID: 146583 RVA: 0x0092CCA3 File Offset: 0x0092AEA3
		// (set) Token: 0x06023C98 RID: 146584 RVA: 0x0092CCB3 File Offset: 0x0092AEB3
		public unsafe float 核心球表面游动范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004393 RID: 17299
		// (get) Token: 0x06023C99 RID: 146585 RVA: 0x0092CCC4 File Offset: 0x0092AEC4
		// (set) Token: 0x06023C9A RID: 146586 RVA: 0x0092CCD4 File Offset: 0x0092AED4
		public unsafe float 反射强度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004394 RID: 17300
		// (get) Token: 0x06023C9B RID: 146587 RVA: 0x0092CCE5 File Offset: 0x0092AEE5
		// (set) Token: 0x06023C9C RID: 146588 RVA: 0x0092CCF9 File Offset: 0x0092AEF9
		public unsafe UTextureCube 反射贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004395 RID: 17301
		// (get) Token: 0x06023C9D RID: 146589 RVA: 0x0092CD0E File Offset: 0x0092AF0E
		// (set) Token: 0x06023C9E RID: 146590 RVA: 0x0092CD1E File Offset: 0x0092AF1E
		public unsafe float 核心噪声尺寸
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004396 RID: 17302
		// (get) Token: 0x06023C9F RID: 146591 RVA: 0x0092CD2F File Offset: 0x0092AF2F
		// (set) Token: 0x06023CA0 RID: 146592 RVA: 0x0092CD43 File Offset: 0x0092AF43
		public unsafe UVolumeTexture 噪声贴图
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004397 RID: 17303
		// (get) Token: 0x06023CA1 RID: 146593 RVA: 0x0092CD58 File Offset: 0x0092AF58
		// (set) Token: 0x06023CA2 RID: 146594 RVA: 0x0092CD6C File Offset: 0x0092AF6C
		public unsafe FLinearColor 核心噪声颜色
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004398 RID: 17304
		// (get) Token: 0x06023CA3 RID: 146595 RVA: 0x0092CD81 File Offset: 0x0092AF81
		// (set) Token: 0x06023CA4 RID: 146596 RVA: 0x0092CD91 File Offset: 0x0092AF91
		public unsafe float 核心噪声范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004399 RID: 17305
		// (get) Token: 0x06023CA5 RID: 146597 RVA: 0x0092CDA2 File Offset: 0x0092AFA2
		// (set) Token: 0x06023CA6 RID: 146598 RVA: 0x0092CDB2 File Offset: 0x0092AFB2
		public unsafe float 核心噪声阈值
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MetaballForMobile_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x1700439A RID: 17306
		// (get) Token: 0x06023CA7 RID: 146599 RVA: 0x0092CDC3 File Offset: 0x0092AFC3
		// (set) Token: 0x06023CA8 RID: 146600 RVA: 0x0092CDD7 File Offset: 0x0092AFD7
		public unsafe UMaterialInstanceDynamic CoreSphereDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MetaballForMobile_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x06023CA9 RID: 146601 RVA: 0x0092CDEC File Offset: 0x0092AFEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MetaballForMobile_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023CAA RID: 146602 RVA: 0x0092CE00 File Offset: 0x0092B000
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MetaballForMobile_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023CAB RID: 146603 RVA: 0x0092CE15 File Offset: 0x0092B015
		protected BP_MetaballForMobile_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011AED RID: 72429
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Metaballs/BP_MetaballForMobile.BP_MetaballForMobile_C";

		// Token: 0x04011AEE RID: 72430
		private static IntPtr _ClassPtr;

		// Token: 0x04011AEF RID: 72431
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011AF0 RID: 72432
		internal static int __PropertyOffset_0;

		// Token: 0x04011AF1 RID: 72433
		internal static int __PropertyOffset_1;

		// Token: 0x04011AF2 RID: 72434
		internal static int __PropertyOffset_2;

		// Token: 0x04011AF3 RID: 72435
		internal static int __PropertyOffset_3;

		// Token: 0x04011AF4 RID: 72436
		internal static int __PropertyOffset_4;

		// Token: 0x04011AF5 RID: 72437
		internal static int __PropertyOffset_5;

		// Token: 0x04011AF6 RID: 72438
		internal static int __PropertyOffset_6;

		// Token: 0x04011AF7 RID: 72439
		internal static int __PropertyOffset_7;

		// Token: 0x04011AF8 RID: 72440
		internal static int __PropertyOffset_8;

		// Token: 0x04011AF9 RID: 72441
		internal static int __PropertyOffset_9;

		// Token: 0x04011AFA RID: 72442
		internal static int __PropertyOffset_10;

		// Token: 0x04011AFB RID: 72443
		internal static int __PropertyOffset_11;

		// Token: 0x04011AFC RID: 72444
		internal static int __PropertyOffset_12;

		// Token: 0x04011AFD RID: 72445
		internal static int __PropertyOffset_13;

		// Token: 0x04011AFE RID: 72446
		internal static int __PropertyOffset_14;

		// Token: 0x04011AFF RID: 72447
		internal static int __PropertyOffset_15;

		// Token: 0x04011B00 RID: 72448
		internal static int __PropertyOffset_16;

		// Token: 0x04011B01 RID: 72449
		internal static int __PropertyOffset_17;

		// Token: 0x04011B02 RID: 72450
		internal static int __PropertyOffset_18;

		// Token: 0x04011B03 RID: 72451
		internal static int __PropertyOffset_19;

		// Token: 0x04011B04 RID: 72452
		internal static int __PropertyOffset_20;

		// Token: 0x04011B05 RID: 72453
		internal static int __PropertyOffset_21;

		// Token: 0x04011B06 RID: 72454
		internal static int __PropertyOffset_22;

		// Token: 0x04011B07 RID: 72455
		internal static int __PropertyOffset_23;

		// Token: 0x04011B08 RID: 72456
		internal static int __PropertyOffset_24;

		// Token: 0x04011B09 RID: 72457
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
