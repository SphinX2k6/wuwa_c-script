using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline
{
	// Token: 0x020030DE RID: 12510
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_SplineScatter.BP_SplineScatter_C")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1941)]
	public class BP_SplineScatter_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E37B RID: 123771 RVA: 0x0090E4FC File Offset: 0x0090C6FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplineScatter_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_SplineScatter.BP_SplineScatter_C");
			}
			return BP_SplineScatter_C._ClassPtr;
		}

		// Token: 0x0601E37C RID: 123772 RVA: 0x0090E520 File Offset: 0x0090C720
		public BP_SplineScatter_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplineScatter_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E37D RID: 123773 RVA: 0x0090E548 File Offset: 0x0090C748
		public BP_SplineScatter_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplineScatter_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0601E37E RID: 123774 RVA: 0x0090E57B File Offset: 0x0090C77B
		// (set) Token: 0x0601E37F RID: 123775 RVA: 0x0090E58F File Offset: 0x0090C78F
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_Spline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0601E380 RID: 123776 RVA: 0x0090E5A4 File Offset: 0x0090C7A4
		// (set) Token: 0x0601E381 RID: 123777 RVA: 0x0090E5B4 File Offset: 0x0090C7B4
		public unsafe bool 自动生成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_自动生成) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_自动生成) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0601E382 RID: 123778 RVA: 0x0090E5C5 File Offset: 0x0090C7C5
		// (set) Token: 0x0601E383 RID: 123779 RVA: 0x0090E5D5 File Offset: 0x0090C7D5
		public unsafe bool 向下吸附表面
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_向下吸附表面) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_向下吸附表面) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0601E384 RID: 123780 RVA: 0x0090E5E6 File Offset: 0x0090C7E6
		// (set) Token: 0x0601E385 RID: 123781 RVA: 0x0090E5F6 File Offset: 0x0090C7F6
		public unsafe float 生成宽度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_生成宽度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_生成宽度) = value;
			}
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0601E386 RID: 123782 RVA: 0x0090E607 File Offset: 0x0090C807
		// (set) Token: 0x0601E387 RID: 123783 RVA: 0x0090E617 File Offset: 0x0090C817
		public unsafe float 生成密度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_生成密度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_生成密度) = value;
			}
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0601E388 RID: 123784 RVA: 0x0090E628 File Offset: 0x0090C828
		// (set) Token: 0x0601E389 RID: 123785 RVA: 0x0090E638 File Offset: 0x0090C838
		public unsafe float 缩放
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_缩放);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_缩放) = value;
			}
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0601E38A RID: 123786 RVA: 0x0090E649 File Offset: 0x0090C849
		// (set) Token: 0x0601E38B RID: 123787 RVA: 0x0090E659 File Offset: 0x0090C859
		public unsafe float CustomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_CustomTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_CustomTime) = value;
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0601E38C RID: 123788 RVA: 0x0090E66A File Offset: 0x0090C86A
		// (set) Token: 0x0601E38D RID: 123789 RVA: 0x0090E67A File Offset: 0x0090C87A
		public unsafe int ScatterCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_ScatterCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_ScatterCount) = value;
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0601E38E RID: 123790 RVA: 0x0090E68B File Offset: 0x0090C88B
		// (set) Token: 0x0601E38F RID: 123791 RVA: 0x0090E69B File Offset: 0x0090C89B
		public unsafe bool Tick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_Tick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_Tick) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0601E390 RID: 123792 RVA: 0x0090E6AC File Offset: 0x0090C8AC
		// (set) Token: 0x0601E391 RID: 123793 RVA: 0x0090E6BC File Offset: 0x0090C8BC
		public unsafe int ScatterPerTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_ScatterPerTick);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_ScatterPerTick) = value;
			}
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0601E392 RID: 123794 RVA: 0x0090E6CD File Offset: 0x0090C8CD
		// (set) Token: 0x0601E393 RID: 123795 RVA: 0x0090E6DD File Offset: 0x0090C8DD
		public unsafe float SplineLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_SplineLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_SplineLength) = value;
			}
		}

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0601E394 RID: 123796 RVA: 0x0090E6EE File Offset: 0x0090C8EE
		// (set) Token: 0x0601E395 RID: 123797 RVA: 0x0090E702 File Offset: 0x0090C902
		public unsafe FVectorDouble ScatterLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_ScatterLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_ScatterLocation) = value;
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0601E396 RID: 123798 RVA: 0x0090E717 File Offset: 0x0090C917
		// (set) Token: 0x0601E397 RID: 123799 RVA: 0x0090E727 File Offset: 0x0090C927
		public unsafe float RandomTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_RandomTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_RandomTime) = value;
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0601E398 RID: 123800 RVA: 0x0090E738 File Offset: 0x0090C938
		// (set) Token: 0x0601E399 RID: 123801 RVA: 0x0090E748 File Offset: 0x0090C948
		public unsafe int TickStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_TickStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_TickStart) = value;
			}
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0601E39A RID: 123802 RVA: 0x0090E75C File Offset: 0x0090C95C
		// (set) Token: 0x0601E39B RID: 123803 RVA: 0x0090E795 File Offset: 0x0090C995
		public TMap<int, int> InstanceCount
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, int> result;
				if ((result = this._InstanceCount) == null)
				{
					result = (this._InstanceCount = new TMap<int, int>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_InstanceCount, this));
				}
				return result;
			}
			set
			{
				this.InstanceCount.CopyAssign(value);
			}
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0601E39C RID: 123804 RVA: 0x0090E7A4 File Offset: 0x0090C9A4
		// (set) Token: 0x0601E39D RID: 123805 RVA: 0x0090E7DD File Offset: 0x0090C9DD
		public TMap<string, FVector> CustomDataInfo
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FVector> result;
				if ((result = this._CustomDataInfo) == null)
				{
					result = (this._CustomDataInfo = new TMap<string, FVector>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_CustomDataInfo, this));
				}
				return result;
			}
			set
			{
				this.CustomDataInfo.CopyAssign(value);
			}
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0601E39E RID: 123806 RVA: 0x0090E7EB File Offset: 0x0090C9EB
		// (set) Token: 0x0601E39F RID: 123807 RVA: 0x0090E7FB File Offset: 0x0090C9FB
		public unsafe int AssetCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_AssetCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_AssetCount) = value;
			}
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0601E3A0 RID: 123808 RVA: 0x0090E80C File Offset: 0x0090CA0C
		// (set) Token: 0x0601E3A1 RID: 123809 RVA: 0x0090E81C File Offset: 0x0090CA1C
		public unsafe int RandomID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_RandomID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_RandomID) = value;
			}
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0601E3A2 RID: 123810 RVA: 0x0090E830 File Offset: 0x0090CA30
		// (set) Token: 0x0601E3A3 RID: 123811 RVA: 0x0090E869 File Offset: 0x0090CA69
		public TArray<string> CustomDataID
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._CustomDataID) == null)
				{
					result = (this._CustomDataID = new TArray<string>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_CustomDataID, this));
				}
				return result;
			}
			set
			{
				this.CustomDataID.CopyAssign(value);
			}
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0601E3A4 RID: 123812 RVA: 0x0090E877 File Offset: 0x0090CA77
		// (set) Token: 0x0601E3A5 RID: 123813 RVA: 0x0090E887 File Offset: 0x0090CA87
		public unsafe float LastGrowthTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_LastGrowthTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_LastGrowthTime) = value;
			}
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0601E3A6 RID: 123814 RVA: 0x0090E898 File Offset: 0x0090CA98
		// (set) Token: 0x0601E3A7 RID: 123815 RVA: 0x0090E8A8 File Offset: 0x0090CAA8
		public unsafe float RandomAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_RandomAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_RandomAngle) = value;
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0601E3A8 RID: 123816 RVA: 0x0090E8B9 File Offset: 0x0090CAB9
		// (set) Token: 0x0601E3A9 RID: 123817 RVA: 0x0090E8C9 File Offset: 0x0090CAC9
		public unsafe float RandomWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_RandomWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_RandomWidth) = value;
			}
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0601E3AA RID: 123818 RVA: 0x0090E8DA File Offset: 0x0090CADA
		// (set) Token: 0x0601E3AB RID: 123819 RVA: 0x0090E8EA File Offset: 0x0090CAEA
		public unsafe bool 启用流淌
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_启用流淌) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_启用流淌) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0601E3AC RID: 123820 RVA: 0x0090E8FB File Offset: 0x0090CAFB
		// (set) Token: 0x0601E3AD RID: 123821 RVA: 0x0090E90F File Offset: 0x0090CB0F
		[Nullable(2)]
		public unsafe UTexture2D 路径Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_路径Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_路径Texture, value);
			}
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0601E3AE RID: 123822 RVA: 0x0090E924 File Offset: 0x0090CB24
		// (set) Token: 0x0601E3AF RID: 123823 RVA: 0x0090E938 File Offset: 0x0090CB38
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D 路径RT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_路径RT);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplineScatter_C.__PropertyOffset_路径RT, value);
			}
		}

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0601E3B0 RID: 123824 RVA: 0x0090E94D File Offset: 0x0090CB4D
		// (set) Token: 0x0601E3B1 RID: 123825 RVA: 0x0090E95D File Offset: 0x0090CB5D
		public unsafe bool 基于RT撒点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_基于RT撒点) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_基于RT撒点) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0601E3B2 RID: 123826 RVA: 0x0090E96E File Offset: 0x0090CB6E
		// (set) Token: 0x0601E3B3 RID: 123827 RVA: 0x0090E97E File Offset: 0x0090CB7E
		public unsafe bool 运行时生成
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_运行时生成) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_运行时生成) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0601E3B4 RID: 123828 RVA: 0x0090E990 File Offset: 0x0090CB90
		// (set) Token: 0x0601E3B5 RID: 123829 RVA: 0x0090E9C9 File Offset: 0x0090CBC9
		public TArray<UStaticMesh> ScatterAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._ScatterAssets) == null)
				{
					result = (this._ScatterAssets = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_ScatterAssets, this));
				}
				return result;
			}
			set
			{
				this.ScatterAssets.CopyAssign(value);
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0601E3B6 RID: 123830 RVA: 0x0090E9D8 File Offset: 0x0090CBD8
		// (set) Token: 0x0601E3B7 RID: 123831 RVA: 0x0090EA11 File Offset: 0x0090CC11
		public TArray<UMaterialInstanceDynamic> MIDAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MIDAssets) == null)
				{
					result = (this._MIDAssets = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_MIDAssets, this));
				}
				return result;
			}
			set
			{
				this.MIDAssets.CopyAssign(value);
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0601E3B8 RID: 123832 RVA: 0x0090EA20 File Offset: 0x0090CC20
		// (set) Token: 0x0601E3B9 RID: 123833 RVA: 0x0090EA59 File Offset: 0x0090CC59
		public TArray<FLinearColor> RTData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._RTData) == null)
				{
					result = (this._RTData = new TArray<FLinearColor>(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_RTData, this));
				}
				return result;
			}
			set
			{
				this.RTData.CopyAssign(value);
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0601E3BA RID: 123834 RVA: 0x0090EA67 File Offset: 0x0090CC67
		// (set) Token: 0x0601E3BB RID: 123835 RVA: 0x0090EA7B File Offset: 0x0090CC7B
		public unsafe FVectorDouble FirstLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_FirstLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_FirstLocation) = value;
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0601E3BC RID: 123836 RVA: 0x0090EA90 File Offset: 0x0090CC90
		// (set) Token: 0x0601E3BD RID: 123837 RVA: 0x0090EAA4 File Offset: 0x0090CCA4
		public unsafe FVectorDouble FirstRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_FirstRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_FirstRight) = value;
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0601E3BE RID: 123838 RVA: 0x0090EAB9 File Offset: 0x0090CCB9
		// (set) Token: 0x0601E3BF RID: 123839 RVA: 0x0090EAC9 File Offset: 0x0090CCC9
		public unsafe int Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0601E3C0 RID: 123840 RVA: 0x0090EADA File Offset: 0x0090CCDA
		// (set) Token: 0x0601E3C1 RID: 123841 RVA: 0x0090EAEA File Offset: 0x0090CCEA
		public unsafe bool Preview
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_Preview) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplineScatter_C.__PropertyOffset_Preview) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E3C2 RID: 123842 RVA: 0x0090EAFB File Offset: 0x0090CCFB
		[SkipLocalsInit]
		public virtual void 花路预览()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__花路预览_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3C3 RID: 123843 RVA: 0x0090EB0F File Offset: 0x0090CD0F
		[SkipLocalsInit]
		public virtual void 生成动态材质()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__生成动态材质_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3C4 RID: 123844 RVA: 0x0090EB23 File Offset: 0x0090CD23
		[SkipLocalsInit]
		public virtual void 生成路径RT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__生成路径RT_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3C5 RID: 123845 RVA: 0x0090EB37 File Offset: 0x0090CD37
		[SkipLocalsInit]
		public virtual void 生成撒点()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__生成撒点_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3C6 RID: 123846 RVA: 0x0090EB4C File Offset: 0x0090CD4C
		[SkipLocalsInit]
		public unsafe virtual void IsEditor(ref bool IsEditor)
		{
			BP_SplineScatter_C.__IsEditor_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__IsEditor_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_SplineScatter_C.__IsEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__IsEditor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsEditor = IsEditor;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__IsEditor_NativeFunctionPtr, (void*)ptr);
			IsEditor = ptr->IsEditor;
		}

		// Token: 0x0601E3C7 RID: 123847 RVA: 0x0090EB9B File Offset: 0x0090CD9B
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3C8 RID: 123848 RVA: 0x0090EBAF File Offset: 0x0090CDAF
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineScatter_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3C9 RID: 123849 RVA: 0x0090EBC3 File Offset: 0x0090CDC3
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3CA RID: 123850 RVA: 0x0090EBD7 File Offset: 0x0090CDD7
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineScatter_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E3CB RID: 123851 RVA: 0x0090EBEC File Offset: 0x0090CDEC
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SplineScatter_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineScatter_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E3CC RID: 123852 RVA: 0x0090EC34 File Offset: 0x0090CE34
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SplineScatter_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineScatter_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineScatter_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E3CD RID: 123853 RVA: 0x0090EC7C File Offset: 0x0090CE7C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplineScatter_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineScatter_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplineScatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E3CE RID: 123854 RVA: 0x0090ECC4 File Offset: 0x0090CEC4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplineScatter_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplineScatter_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplineScatter_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplineScatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplineScatter_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E3CF RID: 123855 RVA: 0x0090ED0A File Offset: 0x0090CF0A
		protected BP_SplineScatter_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FFD3 RID: 65491
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/BP_SplineScatter.BP_SplineScatter_C";

		// Token: 0x0400FFD4 RID: 65492
		private static IntPtr _ClassPtr;

		// Token: 0x0400FFD5 RID: 65493
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FFD6 RID: 65494
		internal static int __PropertyOffset_Spline;

		// Token: 0x0400FFD7 RID: 65495
		internal static int __PropertyOffset_自动生成;

		// Token: 0x0400FFD8 RID: 65496
		internal static int __PropertyOffset_向下吸附表面;

		// Token: 0x0400FFD9 RID: 65497
		internal static int __PropertyOffset_生成宽度;

		// Token: 0x0400FFDA RID: 65498
		internal static int __PropertyOffset_生成密度;

		// Token: 0x0400FFDB RID: 65499
		internal static int __PropertyOffset_缩放;

		// Token: 0x0400FFDC RID: 65500
		internal static int __PropertyOffset_CustomTime;

		// Token: 0x0400FFDD RID: 65501
		internal static int __PropertyOffset_ScatterCount;

		// Token: 0x0400FFDE RID: 65502
		internal static int __PropertyOffset_Tick;

		// Token: 0x0400FFDF RID: 65503
		internal static int __PropertyOffset_ScatterPerTick;

		// Token: 0x0400FFE0 RID: 65504
		internal static int __PropertyOffset_SplineLength;

		// Token: 0x0400FFE1 RID: 65505
		internal static int __PropertyOffset_ScatterLocation;

		// Token: 0x0400FFE2 RID: 65506
		internal static int __PropertyOffset_RandomTime;

		// Token: 0x0400FFE3 RID: 65507
		internal static int __PropertyOffset_TickStart;

		// Token: 0x0400FFE4 RID: 65508
		internal static int __PropertyOffset_InstanceCount;

		// Token: 0x0400FFE5 RID: 65509
		[Nullable(2)]
		private TMap<int, int> _InstanceCount;

		// Token: 0x0400FFE6 RID: 65510
		internal static int __PropertyOffset_CustomDataInfo;

		// Token: 0x0400FFE7 RID: 65511
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FVector> _CustomDataInfo;

		// Token: 0x0400FFE8 RID: 65512
		internal static int __PropertyOffset_AssetCount;

		// Token: 0x0400FFE9 RID: 65513
		internal static int __PropertyOffset_RandomID;

		// Token: 0x0400FFEA RID: 65514
		internal static int __PropertyOffset_CustomDataID;

		// Token: 0x0400FFEB RID: 65515
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _CustomDataID;

		// Token: 0x0400FFEC RID: 65516
		internal static int __PropertyOffset_LastGrowthTime;

		// Token: 0x0400FFED RID: 65517
		internal static int __PropertyOffset_RandomAngle;

		// Token: 0x0400FFEE RID: 65518
		internal static int __PropertyOffset_RandomWidth;

		// Token: 0x0400FFEF RID: 65519
		internal static int __PropertyOffset_启用流淌;

		// Token: 0x0400FFF0 RID: 65520
		internal static int __PropertyOffset_路径Texture;

		// Token: 0x0400FFF1 RID: 65521
		internal static int __PropertyOffset_路径RT;

		// Token: 0x0400FFF2 RID: 65522
		internal static int __PropertyOffset_基于RT撒点;

		// Token: 0x0400FFF3 RID: 65523
		internal static int __PropertyOffset_运行时生成;

		// Token: 0x0400FFF4 RID: 65524
		internal static int __PropertyOffset_ScatterAssets;

		// Token: 0x0400FFF5 RID: 65525
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _ScatterAssets;

		// Token: 0x0400FFF6 RID: 65526
		internal static int __PropertyOffset_MIDAssets;

		// Token: 0x0400FFF7 RID: 65527
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MIDAssets;

		// Token: 0x0400FFF8 RID: 65528
		internal static int __PropertyOffset_RTData;

		// Token: 0x0400FFF9 RID: 65529
		[Nullable(2)]
		private TArray<FLinearColor> _RTData;

		// Token: 0x0400FFFA RID: 65530
		internal static int __PropertyOffset_FirstLocation;

		// Token: 0x0400FFFB RID: 65531
		internal static int __PropertyOffset_FirstRight;

		// Token: 0x0400FFFC RID: 65532
		internal static int __PropertyOffset_Size;

		// Token: 0x0400FFFD RID: 65533
		internal static int __PropertyOffset_Preview;

		// Token: 0x0400FFFE RID: 65534
		private static IntPtr __花路预览_NativeFunctionPtr;

		// Token: 0x0400FFFF RID: 65535
		private static IntPtr __生成动态材质_NativeFunctionPtr;

		// Token: 0x04010000 RID: 65536
		private static IntPtr __生成路径RT_NativeFunctionPtr;

		// Token: 0x04010001 RID: 65537
		private static IntPtr __生成撒点_NativeFunctionPtr;

		// Token: 0x04010002 RID: 65538
		private static IntPtr __IsEditor_NativeFunctionPtr;

		// Token: 0x04010003 RID: 65539
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010004 RID: 65540
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010005 RID: 65541
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010006 RID: 65542
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008E4B RID: 36427
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __IsEditor_FunctionParams
		{
			// Token: 0x0402CA8C RID: 182924
			[FieldOffset(0)]
			public bool IsEditor;
		}

		// Token: 0x02008E4C RID: 36428
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CA8D RID: 182925
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E4D RID: 36429
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA8E RID: 182926
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
