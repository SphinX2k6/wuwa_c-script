using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline.Structure;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.RoadSpline
{
	// Token: 0x02003C2A RID: 15402
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSpline_DiffeEnd.PCG_RoadSpline_DiffeEnd_C")]
	[UnrealStructLayout(1224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1218)]
	public class PCG_RoadSpline_DiffeEnd_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060235E8 RID: 144872 RVA: 0x009223E0 File Offset: 0x009205E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PCG_RoadSpline_DiffeEnd_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSpline_DiffeEnd.PCG_RoadSpline_DiffeEnd_C");
			}
			return PCG_RoadSpline_DiffeEnd_C._ClassPtr;
		}

		// Token: 0x060235E9 RID: 144873 RVA: 0x00922404 File Offset: 0x00920604
		public PCG_RoadSpline_DiffeEnd_C() : this(BuiltinUtils.AllocNativeUObject(PCG_RoadSpline_DiffeEnd_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060235EA RID: 144874 RVA: 0x0092242C File Offset: 0x0092062C
		[NullableContext(1)]
		public PCG_RoadSpline_DiffeEnd_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PCG_RoadSpline_DiffeEnd_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x060235EB RID: 144875 RVA: 0x0092245F File Offset: 0x0092065F
		// (set) Token: 0x060235EC RID: 144876 RVA: 0x00922473 File Offset: 0x00920673
		public unsafe UStaticMeshComponent StaticMesh1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x060235ED RID: 144877 RVA: 0x00922488 File Offset: 0x00920688
		// (set) Token: 0x060235EE RID: 144878 RVA: 0x0092249C File Offset: 0x0092069C
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x060235EF RID: 144879 RVA: 0x009224B1 File Offset: 0x009206B1
		// (set) Token: 0x060235F0 RID: 144880 RVA: 0x009224C5 File Offset: 0x009206C5
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x060235F1 RID: 144881 RVA: 0x009224DA File Offset: 0x009206DA
		// (set) Token: 0x060235F2 RID: 144882 RVA: 0x009224EE File Offset: 0x009206EE
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x060235F3 RID: 144883 RVA: 0x00922503 File Offset: 0x00920703
		// (set) Token: 0x060235F4 RID: 144884 RVA: 0x00922513 File Offset: 0x00920713
		public unsafe float 吸附偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x060235F5 RID: 144885 RVA: 0x00922524 File Offset: 0x00920724
		// (set) Token: 0x060235F6 RID: 144886 RVA: 0x00922534 File Offset: 0x00920734
		public unsafe bool 启用
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x060235F7 RID: 144887 RVA: 0x00922545 File Offset: 0x00920745
		// (set) Token: 0x060235F8 RID: 144888 RVA: 0x00922559 File Offset: 0x00920759
		public unsafe AActor SplineActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x060235F9 RID: 144889 RVA: 0x00922570 File Offset: 0x00920770
		// (set) Token: 0x060235FA RID: 144890 RVA: 0x009225A9 File Offset: 0x009207A9
		[Nullable(1)]
		public FCollisionProfileName 添加碰撞__测试_
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._添加碰撞__测试_) == null)
				{
					result = (this._添加碰撞__测试_ = new FCollisionProfileName(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_7, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x060235FB RID: 144891 RVA: 0x009225CA File Offset: 0x009207CA
		// (set) Token: 0x060235FC RID: 144892 RVA: 0x009225DE File Offset: 0x009207DE
		public unsafe FVector UpDirection__测试_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x060235FD RID: 144893 RVA: 0x009225F3 File Offset: 0x009207F3
		// (set) Token: 0x060235FE RID: 144894 RVA: 0x00922603 File Offset: 0x00920803
		public unsafe bool 开启自定义深度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040FF RID: 16639
		// (get) Token: 0x060235FF RID: 144895 RVA: 0x00922614 File Offset: 0x00920814
		// (set) Token: 0x06023600 RID: 144896 RVA: 0x0092264D File Offset: 0x0092084D
		[Nullable(1)]
		public SPCG_RoadPropertyBased 属性列表
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SPCG_RoadPropertyBased result;
				if ((result = this._属性列表) == null)
				{
					result = (this._属性列表 = new SPCG_RoadPropertyBased(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPCG_RoadPropertyBased.StaticStruct(), base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004100 RID: 16640
		// (get) Token: 0x06023601 RID: 144897 RVA: 0x00922670 File Offset: 0x00920870
		// (set) Token: 0x06023602 RID: 144898 RVA: 0x009226A9 File Offset: 0x009208A9
		[Nullable(1)]
		public TArray<UStaticMesh> 封口模型
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._封口模型) == null)
				{
					result = (this._封口模型 = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.封口模型.CopyAssign(value);
			}
		}

		// Token: 0x17004101 RID: 16641
		// (get) Token: 0x06023603 RID: 144899 RVA: 0x009226B7 File Offset: 0x009208B7
		// (set) Token: 0x06023604 RID: 144900 RVA: 0x009226CB File Offset: 0x009208CB
		public unsafe FVector 封口偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x06023605 RID: 144901 RVA: 0x009226E0 File Offset: 0x009208E0
		// (set) Token: 0x06023606 RID: 144902 RVA: 0x009226F0 File Offset: 0x009208F0
		public unsafe float 封口旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004103 RID: 16643
		// (get) Token: 0x06023607 RID: 144903 RVA: 0x00922701 File Offset: 0x00920901
		// (set) Token: 0x06023608 RID: 144904 RVA: 0x00922711 File Offset: 0x00920911
		public unsafe bool VertexCompress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004104 RID: 16644
		// (get) Token: 0x06023609 RID: 144905 RVA: 0x00922722 File Offset: 0x00920922
		// (set) Token: 0x0602360A RID: 144906 RVA: 0x00922732 File Offset: 0x00920932
		public unsafe bool 低内存设备禁用
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_DiffeEnd_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602360B RID: 144907 RVA: 0x00922744 File Offset: 0x00920944
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetRoadWidth(bool IgnoreScale, ref float Width)
		{
			PCG_RoadSpline_DiffeEnd_C.__GetRoadWidth_FunctionParams* ptr = stackalloc PCG_RoadSpline_DiffeEnd_C.__GetRoadWidth_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(PCG_RoadSpline_DiffeEnd_C.__GetRoadWidth_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSpline_DiffeEnd_C.__GetRoadWidth_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IgnoreScale = IgnoreScale;
			ptr->Width = Width;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_DiffeEnd_C.__GetRoadWidth_NativeFunctionPtr, (void*)ptr);
			Width = ptr->Width;
		}

		// Token: 0x0602360C RID: 144908 RVA: 0x0092279C File Offset: 0x0092099C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetRoadMesh(ref UStaticMesh 基础模型)
		{
			PCG_RoadSpline_DiffeEnd_C.__GetRoadMesh_FunctionParams* ptr = stackalloc PCG_RoadSpline_DiffeEnd_C.__GetRoadMesh_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(PCG_RoadSpline_DiffeEnd_C.__GetRoadMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSpline_DiffeEnd_C.__GetRoadMesh_NativeFunctionPtr, (void*)ptr, 1);
			ref PCG_RoadSpline_DiffeEnd_C.__GetRoadMesh_FunctionParams ptr2 = ref *ptr;
			UStaticMesh ustaticMesh = 基础模型;
			ptr2.基础模型 = ((ustaticMesh != null) ? ustaticMesh.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_DiffeEnd_C.__GetRoadMesh_NativeFunctionPtr, (void*)ptr);
			基础模型 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMesh>(ptr->基础模型);
		}

		// Token: 0x0602360D RID: 144909 RVA: 0x00922800 File Offset: 0x00920A00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CopyToSplineActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_DiffeEnd_C.__CopyToSplineActor_NativeFunctionPtr, null);
		}

		// Token: 0x0602360E RID: 144910 RVA: 0x00922814 File Offset: 0x00920A14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CopySplineActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_DiffeEnd_C.__CopySplineActor_NativeFunctionPtr, null);
		}

		// Token: 0x0602360F RID: 144911 RVA: 0x00922828 File Offset: 0x00920A28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 向下吸附到地形()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_DiffeEnd_C.__向下吸附到地形_NativeFunctionPtr, null);
		}

		// Token: 0x06023610 RID: 144912 RVA: 0x0092283C File Offset: 0x00920A3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GenerateEndCaps()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_DiffeEnd_C.__GenerateEndCaps_NativeFunctionPtr, null);
		}

		// Token: 0x06023611 RID: 144913 RVA: 0x00922850 File Offset: 0x00920A50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GenerateMesh(bool ByPoint)
		{
			PCG_RoadSpline_DiffeEnd_C.__GenerateMesh_FunctionParams* ptr = stackalloc PCG_RoadSpline_DiffeEnd_C.__GenerateMesh_FunctionParams[(UIntPtr)911] + 15L / (long)sizeof(PCG_RoadSpline_DiffeEnd_C.__GenerateMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSpline_DiffeEnd_C.__GenerateMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ByPoint = ByPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_DiffeEnd_C.__GenerateMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023612 RID: 144914 RVA: 0x00922899 File Offset: 0x00920A99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_DiffeEnd_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06023613 RID: 144915 RVA: 0x009228AD File Offset: 0x00920AAD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, PCG_RoadSpline_DiffeEnd_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023614 RID: 144916 RVA: 0x009228C2 File Offset: 0x00920AC2
		protected PCG_RoadSpline_DiffeEnd_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011743 RID: 71491
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSpline_DiffeEnd.PCG_RoadSpline_DiffeEnd_C";

		// Token: 0x04011744 RID: 71492
		private static IntPtr _ClassPtr;

		// Token: 0x04011745 RID: 71493
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011746 RID: 71494
		internal static int __PropertyOffset_0;

		// Token: 0x04011747 RID: 71495
		internal static int __PropertyOffset_1;

		// Token: 0x04011748 RID: 71496
		internal static int __PropertyOffset_2;

		// Token: 0x04011749 RID: 71497
		internal static int __PropertyOffset_3;

		// Token: 0x0401174A RID: 71498
		internal static int __PropertyOffset_4;

		// Token: 0x0401174B RID: 71499
		internal static int __PropertyOffset_5;

		// Token: 0x0401174C RID: 71500
		internal static int __PropertyOffset_6;

		// Token: 0x0401174D RID: 71501
		internal static int __PropertyOffset_7;

		// Token: 0x0401174E RID: 71502
		private FCollisionProfileName _添加碰撞__测试_;

		// Token: 0x0401174F RID: 71503
		internal static int __PropertyOffset_8;

		// Token: 0x04011750 RID: 71504
		internal static int __PropertyOffset_9;

		// Token: 0x04011751 RID: 71505
		internal static int __PropertyOffset_10;

		// Token: 0x04011752 RID: 71506
		private SPCG_RoadPropertyBased _属性列表;

		// Token: 0x04011753 RID: 71507
		internal static int __PropertyOffset_11;

		// Token: 0x04011754 RID: 71508
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _封口模型;

		// Token: 0x04011755 RID: 71509
		internal static int __PropertyOffset_12;

		// Token: 0x04011756 RID: 71510
		internal static int __PropertyOffset_13;

		// Token: 0x04011757 RID: 71511
		internal static int __PropertyOffset_14;

		// Token: 0x04011758 RID: 71512
		internal static int __PropertyOffset_15;

		// Token: 0x04011759 RID: 71513
		private static IntPtr __GetRoadWidth_NativeFunctionPtr;

		// Token: 0x0401175A RID: 71514
		private static IntPtr __GetRoadMesh_NativeFunctionPtr;

		// Token: 0x0401175B RID: 71515
		private static IntPtr __CopyToSplineActor_NativeFunctionPtr;

		// Token: 0x0401175C RID: 71516
		private static IntPtr __CopySplineActor_NativeFunctionPtr;

		// Token: 0x0401175D RID: 71517
		private static IntPtr __向下吸附到地形_NativeFunctionPtr;

		// Token: 0x0401175E RID: 71518
		private static IntPtr __GenerateEndCaps_NativeFunctionPtr;

		// Token: 0x0401175F RID: 71519
		private static IntPtr __GenerateMesh_NativeFunctionPtr;

		// Token: 0x04011760 RID: 71520
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02009E64 RID: 40548
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetRoadWidth_FunctionParams
		{
			// Token: 0x040316E9 RID: 202473
			[FieldOffset(0)]
			public bool IgnoreScale;

			// Token: 0x040316EA RID: 202474
			[FieldOffset(4)]
			public float Width;
		}

		// Token: 0x02009E65 RID: 40549
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetRoadMesh_FunctionParams
		{
			// Token: 0x040316EB RID: 202475
			[FieldOffset(0)]
			public IntPtr 基础模型;
		}

		// Token: 0x02009E66 RID: 40550
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 896)]
		protected ref struct __GenerateMesh_FunctionParams
		{
			// Token: 0x040316EC RID: 202476
			[FieldOffset(0)]
			public bool ByPoint;
		}
	}
}
