using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline
{
	// Token: 0x02003C27 RID: 15399
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_SplineScatter.BP_SplineScatter_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1941)]
	public class BP_SplineScatter_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023520 RID: 144672 RVA: 0x00920FA9 File Offset: 0x0091F1A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineScatter_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_SplineScatter.BP_SplineScatter_C");
			}
			return BP_SplineScatter_C._ClassPtr;
		}

		// Token: 0x06023521 RID: 144673 RVA: 0x00920FD0 File Offset: 0x0091F1D0
		public BP_SplineScatter_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineScatter_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023522 RID: 144674 RVA: 0x00920FF8 File Offset: 0x0091F1F8
		public BP_SplineScatter_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineScatter_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040A7 RID: 16551
		// (get) Token: 0x06023523 RID: 144675 RVA: 0x0092102B File Offset: 0x0091F22B
		// (set) Token: 0x06023524 RID: 144676 RVA: 0x0092103F File Offset: 0x0091F23F
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170040A8 RID: 16552
		// (get) Token: 0x06023525 RID: 144677 RVA: 0x00921054 File Offset: 0x0091F254
		// (set) Token: 0x06023526 RID: 144678 RVA: 0x00921064 File Offset: 0x0091F264
		public unsafe bool 自动生成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040A9 RID: 16553
		// (get) Token: 0x06023527 RID: 144679 RVA: 0x00921075 File Offset: 0x0091F275
		// (set) Token: 0x06023528 RID: 144680 RVA: 0x00921085 File Offset: 0x0091F285
		public unsafe bool 向下吸附表面
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040AA RID: 16554
		// (get) Token: 0x06023529 RID: 144681 RVA: 0x00921096 File Offset: 0x0091F296
		// (set) Token: 0x0602352A RID: 144682 RVA: 0x009210A6 File Offset: 0x0091F2A6
		public unsafe float 生成宽度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170040AB RID: 16555
		// (get) Token: 0x0602352B RID: 144683 RVA: 0x009210B7 File Offset: 0x0091F2B7
		// (set) Token: 0x0602352C RID: 144684 RVA: 0x009210C7 File Offset: 0x0091F2C7
		public unsafe float 生成密度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170040AC RID: 16556
		// (get) Token: 0x0602352D RID: 144685 RVA: 0x009210D8 File Offset: 0x0091F2D8
		// (set) Token: 0x0602352E RID: 144686 RVA: 0x009210E8 File Offset: 0x0091F2E8
		public unsafe float 缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170040AD RID: 16557
		// (get) Token: 0x0602352F RID: 144687 RVA: 0x009210F9 File Offset: 0x0091F2F9
		// (set) Token: 0x06023530 RID: 144688 RVA: 0x00921109 File Offset: 0x0091F309
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170040AE RID: 16558
		// (get) Token: 0x06023531 RID: 144689 RVA: 0x0092111A File Offset: 0x0091F31A
		// (set) Token: 0x06023532 RID: 144690 RVA: 0x0092112A File Offset: 0x0091F32A
		public unsafe int ScatterCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170040AF RID: 16559
		// (get) Token: 0x06023533 RID: 144691 RVA: 0x0092113C File Offset: 0x0091F33C
		// (set) Token: 0x06023534 RID: 144692 RVA: 0x00921175 File Offset: 0x0091F375
		public TMap<UStaticMesh, UInstancedStaticMeshComponent> ScatterAssetsComponent
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UStaticMesh, UInstancedStaticMeshComponent> result;
				if ((result = this._ScatterAssetsComponent) == null)
				{
					result = (this._ScatterAssetsComponent = new TMap<UStaticMesh, UInstancedStaticMeshComponent>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.ScatterAssetsComponent.CopyAssign(value);
			}
		}

		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x06023535 RID: 144693 RVA: 0x00921183 File Offset: 0x0091F383
		// (set) Token: 0x06023536 RID: 144694 RVA: 0x00921193 File Offset: 0x0091F393
		public unsafe bool Tick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x06023537 RID: 144695 RVA: 0x009211A4 File Offset: 0x0091F3A4
		// (set) Token: 0x06023538 RID: 144696 RVA: 0x009211B4 File Offset: 0x0091F3B4
		public unsafe int ScatterPerTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x06023539 RID: 144697 RVA: 0x009211C5 File Offset: 0x0091F3C5
		// (set) Token: 0x0602353A RID: 144698 RVA: 0x009211D5 File Offset: 0x0091F3D5
		public unsafe float SplineLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170040B3 RID: 16563
		// (get) Token: 0x0602353B RID: 144699 RVA: 0x009211E6 File Offset: 0x0091F3E6
		// (set) Token: 0x0602353C RID: 144700 RVA: 0x009211FA File Offset: 0x0091F3FA
		public unsafe FVectorDouble ScatterLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x0602353D RID: 144701 RVA: 0x0092120F File Offset: 0x0091F40F
		// (set) Token: 0x0602353E RID: 144702 RVA: 0x0092121F File Offset: 0x0091F41F
		public unsafe float RandomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x0602353F RID: 144703 RVA: 0x00921230 File Offset: 0x0091F430
		// (set) Token: 0x06023540 RID: 144704 RVA: 0x00921240 File Offset: 0x0091F440
		public unsafe int TickStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x06023541 RID: 144705 RVA: 0x00921254 File Offset: 0x0091F454
		// (set) Token: 0x06023542 RID: 144706 RVA: 0x0092128D File Offset: 0x0091F48D
		public TMap<int, int> InstanceCount
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._InstanceCount) == null)
				{
					result = (this._InstanceCount = new TMap<int, int>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.InstanceCount.CopyAssign(value);
			}
		}

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x06023543 RID: 144707 RVA: 0x0092129C File Offset: 0x0091F49C
		// (set) Token: 0x06023544 RID: 144708 RVA: 0x009212D5 File Offset: 0x0091F4D5
		public TMap<string, FVector> CustomDataInfo
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FVector> result;
				if ((result = this._CustomDataInfo) == null)
				{
					result = (this._CustomDataInfo = new TMap<string, FVector>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_17, this));
				}
				return result;
			}
			set
			{
				this.CustomDataInfo.CopyAssign(value);
			}
		}

		// Token: 0x170040B8 RID: 16568
		// (get) Token: 0x06023545 RID: 144709 RVA: 0x009212E3 File Offset: 0x0091F4E3
		// (set) Token: 0x06023546 RID: 144710 RVA: 0x009212F3 File Offset: 0x0091F4F3
		public unsafe int AssetCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170040B9 RID: 16569
		// (get) Token: 0x06023547 RID: 144711 RVA: 0x00921304 File Offset: 0x0091F504
		// (set) Token: 0x06023548 RID: 144712 RVA: 0x00921314 File Offset: 0x0091F514
		public unsafe int RandomID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x06023549 RID: 144713 RVA: 0x00921328 File Offset: 0x0091F528
		// (set) Token: 0x0602354A RID: 144714 RVA: 0x00921361 File Offset: 0x0091F561
		public TArray<string> CustomDataID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomDataID) == null)
				{
					result = (this._CustomDataID = new TArray<string>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				this.CustomDataID.CopyAssign(value);
			}
		}

		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x0602354B RID: 144715 RVA: 0x0092136F File Offset: 0x0091F56F
		// (set) Token: 0x0602354C RID: 144716 RVA: 0x0092137F File Offset: 0x0091F57F
		public unsafe float LastGrowthTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x0602354D RID: 144717 RVA: 0x00921390 File Offset: 0x0091F590
		// (set) Token: 0x0602354E RID: 144718 RVA: 0x009213A0 File Offset: 0x0091F5A0
		public unsafe float RandomAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x0602354F RID: 144719 RVA: 0x009213B1 File Offset: 0x0091F5B1
		// (set) Token: 0x06023550 RID: 144720 RVA: 0x009213C1 File Offset: 0x0091F5C1
		public unsafe float RandomWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x06023551 RID: 144721 RVA: 0x009213D2 File Offset: 0x0091F5D2
		// (set) Token: 0x06023552 RID: 144722 RVA: 0x009213E2 File Offset: 0x0091F5E2
		public unsafe bool 启用流淌
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x06023553 RID: 144723 RVA: 0x009213F3 File Offset: 0x0091F5F3
		// (set) Token: 0x06023554 RID: 144724 RVA: 0x00921407 File Offset: 0x0091F607
		[Nullable(2)]
		public unsafe UTexture2D 路径Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_25);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x06023555 RID: 144725 RVA: 0x0092141C File Offset: 0x0091F61C
		// (set) Token: 0x06023556 RID: 144726 RVA: 0x00921430 File Offset: 0x0091F630
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D 路径RT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_26);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x06023557 RID: 144727 RVA: 0x00921445 File Offset: 0x0091F645
		// (set) Token: 0x06023558 RID: 144728 RVA: 0x00921455 File Offset: 0x0091F655
		public unsafe bool 基于RT撒点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x06023559 RID: 144729 RVA: 0x00921466 File Offset: 0x0091F666
		// (set) Token: 0x0602355A RID: 144730 RVA: 0x00921476 File Offset: 0x0091F676
		public unsafe bool 运行时生成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x0602355B RID: 144731 RVA: 0x00921488 File Offset: 0x0091F688
		// (set) Token: 0x0602355C RID: 144732 RVA: 0x009214C1 File Offset: 0x0091F6C1
		public TArray<UStaticMesh> ScatterAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._ScatterAssets) == null)
				{
					result = (this._ScatterAssets = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_29, this));
				}
				return result;
			}
			set
			{
				this.ScatterAssets.CopyAssign(value);
			}
		}

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x0602355D RID: 144733 RVA: 0x009214D0 File Offset: 0x0091F6D0
		// (set) Token: 0x0602355E RID: 144734 RVA: 0x00921509 File Offset: 0x0091F709
		public TArray<UMaterialInstanceDynamic> MIDAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MIDAssets) == null)
				{
					result = (this._MIDAssets = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_30, this));
				}
				return result;
			}
			set
			{
				this.MIDAssets.CopyAssign(value);
			}
		}

		// Token: 0x170040C5 RID: 16581
		// (get) Token: 0x0602355F RID: 144735 RVA: 0x00921518 File Offset: 0x0091F718
		// (set) Token: 0x06023560 RID: 144736 RVA: 0x00921551 File Offset: 0x0091F751
		public TArray<FLinearColor> RTData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._RTData) == null)
				{
					result = (this._RTData = new TArray<FLinearColor>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_31, this));
				}
				return result;
			}
			set
			{
				this.RTData.CopyAssign(value);
			}
		}

		// Token: 0x170040C6 RID: 16582
		// (get) Token: 0x06023561 RID: 144737 RVA: 0x0092155F File Offset: 0x0091F75F
		// (set) Token: 0x06023562 RID: 144738 RVA: 0x00921573 File Offset: 0x0091F773
		public unsafe FVectorDouble FirstLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x170040C7 RID: 16583
		// (get) Token: 0x06023563 RID: 144739 RVA: 0x00921588 File Offset: 0x0091F788
		// (set) Token: 0x06023564 RID: 144740 RVA: 0x0092159C File Offset: 0x0091F79C
		public unsafe FVectorDouble FirstRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x170040C8 RID: 16584
		// (get) Token: 0x06023565 RID: 144741 RVA: 0x009215B1 File Offset: 0x0091F7B1
		// (set) Token: 0x06023566 RID: 144742 RVA: 0x009215C1 File Offset: 0x0091F7C1
		public unsafe int Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x170040C9 RID: 16585
		// (get) Token: 0x06023567 RID: 144743 RVA: 0x009215D2 File Offset: 0x0091F7D2
		// (set) Token: 0x06023568 RID: 144744 RVA: 0x009215E2 File Offset: 0x0091F7E2
		public unsafe bool Preview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x06023569 RID: 144745 RVA: 0x009215F3 File Offset: 0x0091F7F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 花路预览()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__花路预览_NativeFunctionPtr, null);
		}

		// Token: 0x0602356A RID: 144746 RVA: 0x00921607 File Offset: 0x0091F807
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成动态材质()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__生成动态材质_NativeFunctionPtr, null);
		}

		// Token: 0x0602356B RID: 144747 RVA: 0x0092161B File Offset: 0x0091F81B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成路径RT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__生成路径RT_NativeFunctionPtr, null);
		}

		// Token: 0x0602356C RID: 144748 RVA: 0x0092162F File Offset: 0x0091F82F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成撒点()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__生成撒点_NativeFunctionPtr, null);
		}

		// Token: 0x0602356D RID: 144749 RVA: 0x00921644 File Offset: 0x0091F844
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IsEditor(ref bool IsEditor)
		{
			BP_SplineScatter_C.__IsEditor_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__IsEditor_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_SplineScatter_C.__IsEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__IsEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__IsEditor_NativeFunctionPtr, (void*)ptr);
			IsEditor = ptr->IsEditor;
		}

		// Token: 0x0602356E RID: 144750 RVA: 0x00921693 File Offset: 0x0091F893
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602356F RID: 144751 RVA: 0x009216A7 File Offset: 0x0091F8A7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineScatter_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023570 RID: 144752 RVA: 0x009216BC File Offset: 0x0091F8BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023571 RID: 144753 RVA: 0x009216D0 File Offset: 0x0091F8D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineScatter_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023572 RID: 144754 RVA: 0x009216E8 File Offset: 0x0091F8E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SplineScatter_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineScatter_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023573 RID: 144755 RVA: 0x00921730 File Offset: 0x0091F930
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SplineScatter_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineScatter_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineScatter_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023574 RID: 144756 RVA: 0x00921778 File Offset: 0x0091F978
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplineScatter_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineScatter_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023575 RID: 144757 RVA: 0x009217C0 File Offset: 0x0091F9C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplineScatter_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineScatter_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineScatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023576 RID: 144758 RVA: 0x00921807 File Offset: 0x0091FA07
		protected BP_SplineScatter_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116C7 RID: 71367
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_SplineScatter.BP_SplineScatter_C";

		// Token: 0x040116C8 RID: 71368
		private static IntPtr _ClassPtr;

		// Token: 0x040116C9 RID: 71369
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116CA RID: 71370
		internal static int __PropertyOffset_1;

		// Token: 0x040116CB RID: 71371
		internal static int __PropertyOffset_2;

		// Token: 0x040116CC RID: 71372
		internal static int __PropertyOffset_3;

		// Token: 0x040116CD RID: 71373
		internal static int __PropertyOffset_4;

		// Token: 0x040116CE RID: 71374
		internal static int __PropertyOffset_5;

		// Token: 0x040116CF RID: 71375
		internal static int __PropertyOffset_6;

		// Token: 0x040116D0 RID: 71376
		internal static int __PropertyOffset_7;

		// Token: 0x040116D1 RID: 71377
		internal static int __PropertyOffset_8;

		// Token: 0x040116D2 RID: 71378
		internal static int __PropertyOffset_9;

		// Token: 0x040116D3 RID: 71379
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UStaticMesh, UInstancedStaticMeshComponent> _ScatterAssetsComponent;

		// Token: 0x040116D4 RID: 71380
		internal static int __PropertyOffset_10;

		// Token: 0x040116D5 RID: 71381
		internal static int __PropertyOffset_11;

		// Token: 0x040116D6 RID: 71382
		internal static int __PropertyOffset_12;

		// Token: 0x040116D7 RID: 71383
		internal static int __PropertyOffset_13;

		// Token: 0x040116D8 RID: 71384
		internal static int __PropertyOffset_14;

		// Token: 0x040116D9 RID: 71385
		internal static int __PropertyOffset_15;

		// Token: 0x040116DA RID: 71386
		internal static int __PropertyOffset_16;

		// Token: 0x040116DB RID: 71387
		[Nullable(2)]
		private TMap<int, int> _InstanceCount;

		// Token: 0x040116DC RID: 71388
		internal static int __PropertyOffset_17;

		// Token: 0x040116DD RID: 71389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _CustomDataInfo;

		// Token: 0x040116DE RID: 71390
		internal static int __PropertyOffset_18;

		// Token: 0x040116DF RID: 71391
		internal static int __PropertyOffset_19;

		// Token: 0x040116E0 RID: 71392
		internal static int __PropertyOffset_20;

		// Token: 0x040116E1 RID: 71393
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomDataID;

		// Token: 0x040116E2 RID: 71394
		internal static int __PropertyOffset_21;

		// Token: 0x040116E3 RID: 71395
		internal static int __PropertyOffset_22;

		// Token: 0x040116E4 RID: 71396
		internal static int __PropertyOffset_23;

		// Token: 0x040116E5 RID: 71397
		internal static int __PropertyOffset_24;

		// Token: 0x040116E6 RID: 71398
		internal static int __PropertyOffset_25;

		// Token: 0x040116E7 RID: 71399
		internal static int __PropertyOffset_26;

		// Token: 0x040116E8 RID: 71400
		internal static int __PropertyOffset_27;

		// Token: 0x040116E9 RID: 71401
		internal static int __PropertyOffset_28;

		// Token: 0x040116EA RID: 71402
		internal static int __PropertyOffset_29;

		// Token: 0x040116EB RID: 71403
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _ScatterAssets;

		// Token: 0x040116EC RID: 71404
		internal static int __PropertyOffset_30;

		// Token: 0x040116ED RID: 71405
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MIDAssets;

		// Token: 0x040116EE RID: 71406
		internal static int __PropertyOffset_31;

		// Token: 0x040116EF RID: 71407
		[Nullable(2)]
		private TArray<FLinearColor> _RTData;

		// Token: 0x040116F0 RID: 71408
		internal static int __PropertyOffset_32;

		// Token: 0x040116F1 RID: 71409
		internal static int __PropertyOffset_33;

		// Token: 0x040116F2 RID: 71410
		internal static int __PropertyOffset_34;

		// Token: 0x040116F3 RID: 71411
		internal static int __PropertyOffset_35;

		// Token: 0x040116F4 RID: 71412
		private static IntPtr __花路预览_NativeFunctionPtr;

		// Token: 0x040116F5 RID: 71413
		private static IntPtr __生成动态材质_NativeFunctionPtr;

		// Token: 0x040116F6 RID: 71414
		private static IntPtr __生成路径RT_NativeFunctionPtr;

		// Token: 0x040116F7 RID: 71415
		private static IntPtr __生成撒点_NativeFunctionPtr;

		// Token: 0x040116F8 RID: 71416
		private static IntPtr __IsEditor_NativeFunctionPtr;

		// Token: 0x040116F9 RID: 71417
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040116FA RID: 71418
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040116FB RID: 71419
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040116FC RID: 71420
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009E5A RID: 40538
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsEditor_FunctionParams
		{
			// Token: 0x040316DC RID: 202460
			[FieldOffset(0)]
			public bool IsEditor;
		}

		// Token: 0x02009E5B RID: 40539
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040316DD RID: 202461
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E5C RID: 40540
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040316DE RID: 202462
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
