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
	// Token: 0x02003C28 RID: 15400
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSplineMultiMesh.PCG_RoadSplineMultiMesh_C")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1196)]
	public class PCG_RoadSplineMultiMesh_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023577 RID: 144759 RVA: 0x00921810 File Offset: 0x0091FA10
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PCG_RoadSplineMultiMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSplineMultiMesh.PCG_RoadSplineMultiMesh_C");
			}
			return PCG_RoadSplineMultiMesh_C._ClassPtr;
		}

		// Token: 0x06023578 RID: 144760 RVA: 0x00921834 File Offset: 0x0091FA34
		public PCG_RoadSplineMultiMesh_C() : this(BuiltinUtils.AllocNativeUObject(PCG_RoadSplineMultiMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023579 RID: 144761 RVA: 0x0092185C File Offset: 0x0091FA5C
		public PCG_RoadSplineMultiMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PCG_RoadSplineMultiMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x0602357A RID: 144762 RVA: 0x0092188F File Offset: 0x0091FA8F
		// (set) Token: 0x0602357B RID: 144763 RVA: 0x009218A3 File Offset: 0x0091FAA3
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSplineMultiMesh_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSplineMultiMesh_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x0602357C RID: 144764 RVA: 0x009218B8 File Offset: 0x0091FAB8
		// (set) Token: 0x0602357D RID: 144765 RVA: 0x009218CC File Offset: 0x0091FACC
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSplineMultiMesh_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSplineMultiMesh_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x0602357E RID: 144766 RVA: 0x009218E1 File Offset: 0x0091FAE1
		// (set) Token: 0x0602357F RID: 144767 RVA: 0x009218F1 File Offset: 0x0091FAF1
		public unsafe bool 启用
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x06023580 RID: 144768 RVA: 0x00921902 File Offset: 0x0091FB02
		// (set) Token: 0x06023581 RID: 144769 RVA: 0x00921912 File Offset: 0x0091FB12
		public unsafe float 吸附偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170040CE RID: 16590
		// (get) Token: 0x06023582 RID: 144770 RVA: 0x00921924 File Offset: 0x0091FB24
		// (set) Token: 0x06023583 RID: 144771 RVA: 0x0092195D File Offset: 0x0091FB5D
		public FCollisionProfileName 添加碰撞_测试_
		{
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._添加碰撞_测试_) == null)
				{
					result = (this._添加碰撞_测试_ = new FCollisionProfileName(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_4, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x06023584 RID: 144772 RVA: 0x0092197E File Offset: 0x0091FB7E
		// (set) Token: 0x06023585 RID: 144773 RVA: 0x0092198E File Offset: 0x0091FB8E
		public unsafe bool 开启自定义深度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x06023586 RID: 144774 RVA: 0x009219A0 File Offset: 0x0091FBA0
		// (set) Token: 0x06023587 RID: 144775 RVA: 0x009219D9 File Offset: 0x0091FBD9
		public TArray<SPCG_RoadPropertyBasedMultiMesh> 模型列表
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPCG_RoadPropertyBasedMultiMesh> result;
				if ((result = this._模型列表) == null)
				{
					result = (this._模型列表 = new TArray<SPCG_RoadPropertyBasedMultiMesh>(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.模型列表.CopyAssign(value);
			}
		}

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x06023588 RID: 144776 RVA: 0x009219E7 File Offset: 0x0091FBE7
		// (set) Token: 0x06023589 RID: 144777 RVA: 0x009219F7 File Offset: 0x0091FBF7
		public unsafe float Spline_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x0602358A RID: 144778 RVA: 0x00921A08 File Offset: 0x0091FC08
		// (set) Token: 0x0602358B RID: 144779 RVA: 0x00921A41 File Offset: 0x0091FC41
		public TMap<UMaterialInterface, SPCG_RoadSplineDecalProperity> 贴花列表
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UMaterialInterface, SPCG_RoadSplineDecalProperity> result;
				if ((result = this._贴花列表) == null)
				{
					result = (this._贴花列表 = new TMap<UMaterialInterface, SPCG_RoadSplineDecalProperity>(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.贴花列表.CopyAssign(value);
			}
		}

		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x0602358C RID: 144780 RVA: 0x00921A4F File Offset: 0x0091FC4F
		// (set) Token: 0x0602358D RID: 144781 RVA: 0x00921A5F File Offset: 0x0091FC5F
		public unsafe bool VertexCompress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x0602358E RID: 144782 RVA: 0x00921A70 File Offset: 0x0091FC70
		// (set) Token: 0x0602358F RID: 144783 RVA: 0x00921A80 File Offset: 0x0091FC80
		public unsafe bool 低内存设备禁用
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040D5 RID: 16597
		// (get) Token: 0x06023590 RID: 144784 RVA: 0x00921A91 File Offset: 0x0091FC91
		// (set) Token: 0x06023591 RID: 144785 RVA: 0x00921AA1 File Offset: 0x0091FCA1
		public unsafe int 基于分段数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170040D6 RID: 16598
		// (get) Token: 0x06023592 RID: 144786 RVA: 0x00921AB2 File Offset: 0x0091FCB2
		// (set) Token: 0x06023593 RID: 144787 RVA: 0x00921AC2 File Offset: 0x0091FCC2
		public unsafe float 基于分段长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSplineMultiMesh_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x06023594 RID: 144788 RVA: 0x00921AD3 File Offset: 0x0091FCD3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 生成贴花()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSplineMultiMesh_C.__生成贴花_NativeFunctionPtr, null);
		}

		// Token: 0x06023595 RID: 144789 RVA: 0x00921AE8 File Offset: 0x0091FCE8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetRoadMesh(ref UStaticMesh 基础模型)
		{
			PCG_RoadSplineMultiMesh_C.__GetRoadMesh_FunctionParams* ptr = stackalloc PCG_RoadSplineMultiMesh_C.__GetRoadMesh_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(PCG_RoadSplineMultiMesh_C.__GetRoadMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSplineMultiMesh_C.__GetRoadMesh_NativeFunctionPtr, (void*)ptr, 1);
			ref PCG_RoadSplineMultiMesh_C.__GetRoadMesh_FunctionParams ptr2 = ref *ptr;
			UStaticMesh ustaticMesh = 基础模型;
			ptr2.基础模型 = ((ustaticMesh != null) ? ustaticMesh.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSplineMultiMesh_C.__GetRoadMesh_NativeFunctionPtr, (void*)ptr);
			基础模型 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMesh>(ptr->基础模型);
		}

		// Token: 0x06023596 RID: 144790 RVA: 0x00921B4C File Offset: 0x0091FD4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 向下吸附到地形()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSplineMultiMesh_C.__向下吸附到地形_NativeFunctionPtr, null);
		}

		// Token: 0x06023597 RID: 144791 RVA: 0x00921B60 File Offset: 0x0091FD60
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetMeshNum(SPCG_RoadPropertyBasedMultiMesh Property, ref int Count, ref float StepDistance)
		{
			PCG_RoadSplineMultiMesh_C.__GetMeshNum_FunctionParams* ptr = stackalloc PCG_RoadSplineMultiMesh_C.__GetMeshNum_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(PCG_RoadSplineMultiMesh_C.__GetMeshNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSplineMultiMesh_C.__GetMeshNum_NativeFunctionPtr, (void*)ptr, 1);
			if (Property != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SPCG_RoadPropertyBasedMultiMesh.StaticStruct(), &ptr->Property, Property.NativePtr, 1, false);
			}
			ptr->Count = Count;
			ptr->StepDistance = StepDistance;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSplineMultiMesh_C.__GetMeshNum_NativeFunctionPtr, (void*)ptr);
			Count = ptr->Count;
			StepDistance = ptr->StepDistance;
		}

		// Token: 0x06023598 RID: 144792 RVA: 0x00921BE4 File Offset: 0x0091FDE4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GenerateSplineMesh(SPCG_RoadPropertyBasedMultiMesh Property)
		{
			PCG_RoadSplineMultiMesh_C.__GenerateSplineMesh_FunctionParams* ptr = stackalloc PCG_RoadSplineMultiMesh_C.__GenerateSplineMesh_FunctionParams[(UIntPtr)559] + 15L / (long)sizeof(PCG_RoadSplineMultiMesh_C.__GenerateSplineMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSplineMultiMesh_C.__GenerateSplineMesh_NativeFunctionPtr, (void*)ptr, 1);
			if (Property != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SPCG_RoadPropertyBasedMultiMesh.StaticStruct(), &ptr->Property, Property.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSplineMultiMesh_C.__GenerateSplineMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023599 RID: 144793 RVA: 0x00921C48 File Offset: 0x0091FE48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSplineMultiMesh_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602359A RID: 144794 RVA: 0x00921C5C File Offset: 0x0091FE5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, PCG_RoadSplineMultiMesh_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602359B RID: 144795 RVA: 0x00921C71 File Offset: 0x0091FE71
		protected PCG_RoadSplineMultiMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116FD RID: 71421
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSplineMultiMesh.PCG_RoadSplineMultiMesh_C";

		// Token: 0x040116FE RID: 71422
		private static IntPtr _ClassPtr;

		// Token: 0x040116FF RID: 71423
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011700 RID: 71424
		internal static int __PropertyOffset_0;

		// Token: 0x04011701 RID: 71425
		internal static int __PropertyOffset_1;

		// Token: 0x04011702 RID: 71426
		internal static int __PropertyOffset_2;

		// Token: 0x04011703 RID: 71427
		internal static int __PropertyOffset_3;

		// Token: 0x04011704 RID: 71428
		internal static int __PropertyOffset_4;

		// Token: 0x04011705 RID: 71429
		[Nullable(2)]
		private FCollisionProfileName _添加碰撞_测试_;

		// Token: 0x04011706 RID: 71430
		internal static int __PropertyOffset_5;

		// Token: 0x04011707 RID: 71431
		internal static int __PropertyOffset_6;

		// Token: 0x04011708 RID: 71432
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPCG_RoadPropertyBasedMultiMesh> _模型列表;

		// Token: 0x04011709 RID: 71433
		internal static int __PropertyOffset_7;

		// Token: 0x0401170A RID: 71434
		internal static int __PropertyOffset_8;

		// Token: 0x0401170B RID: 71435
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UMaterialInterface, SPCG_RoadSplineDecalProperity> _贴花列表;

		// Token: 0x0401170C RID: 71436
		internal static int __PropertyOffset_9;

		// Token: 0x0401170D RID: 71437
		internal static int __PropertyOffset_10;

		// Token: 0x0401170E RID: 71438
		internal static int __PropertyOffset_11;

		// Token: 0x0401170F RID: 71439
		internal static int __PropertyOffset_12;

		// Token: 0x04011710 RID: 71440
		private static IntPtr __生成贴花_NativeFunctionPtr;

		// Token: 0x04011711 RID: 71441
		private static IntPtr __GetRoadMesh_NativeFunctionPtr;

		// Token: 0x04011712 RID: 71442
		private static IntPtr __向下吸附到地形_NativeFunctionPtr;

		// Token: 0x04011713 RID: 71443
		private static IntPtr __GetMeshNum_NativeFunctionPtr;

		// Token: 0x04011714 RID: 71444
		private static IntPtr __GenerateSplineMesh_NativeFunctionPtr;

		// Token: 0x04011715 RID: 71445
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02009E5D RID: 40541
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __GetRoadMesh_FunctionParams
		{
			// Token: 0x040316DF RID: 202463
			[FieldOffset(0)]
			public IntPtr 基础模型;
		}

		// Token: 0x02009E5E RID: 40542
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __GetMeshNum_FunctionParams
		{
			// Token: 0x040316E0 RID: 202464
			[FieldOffset(0)]
			public byte Property;

			// Token: 0x040316E1 RID: 202465
			[FieldOffset(40)]
			public int Count;

			// Token: 0x040316E2 RID: 202466
			[FieldOffset(44)]
			public float StepDistance;
		}

		// Token: 0x02009E5F RID: 40543
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 544)]
		protected ref struct __GenerateSplineMesh_FunctionParams
		{
			// Token: 0x040316E3 RID: 202467
			[FieldOffset(0)]
			public byte Property;
		}
	}
}
