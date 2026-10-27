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
	// Token: 0x02003C29 RID: 15401
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSpline.PCG_RoadSpline_C")]
	[UnrealStructLayout(1744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1744)]
	public class PCG_RoadSpline_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602359C RID: 144796 RVA: 0x00921C7A File Offset: 0x0091FE7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PCG_RoadSpline_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSpline.PCG_RoadSpline_C");
			}
			return PCG_RoadSpline_C._ClassPtr;
		}

		// Token: 0x0602359D RID: 144797 RVA: 0x00921CA0 File Offset: 0x0091FEA0
		public PCG_RoadSpline_C() : this(BuiltinUtils.AllocNativeUObject(PCG_RoadSpline_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602359E RID: 144798 RVA: 0x00921CC8 File Offset: 0x0091FEC8
		[NullableContext(1)]
		public PCG_RoadSpline_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PCG_RoadSpline_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x0602359F RID: 144799 RVA: 0x00921CFB File Offset: 0x0091FEFB
		// (set) Token: 0x060235A0 RID: 144800 RVA: 0x00921D0F File Offset: 0x0091FF0F
		public unsafe UInstancedStaticMeshComponent InstancedStaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170040D8 RID: 16600
		// (get) Token: 0x060235A1 RID: 144801 RVA: 0x00921D24 File Offset: 0x0091FF24
		// (set) Token: 0x060235A2 RID: 144802 RVA: 0x00921D38 File Offset: 0x0091FF38
		public unsafe USplineComponent Spline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x170040D9 RID: 16601
		// (get) Token: 0x060235A3 RID: 144803 RVA: 0x00921D4D File Offset: 0x0091FF4D
		// (set) Token: 0x060235A4 RID: 144804 RVA: 0x00921D61 File Offset: 0x0091FF61
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x170040DA RID: 16602
		// (get) Token: 0x060235A5 RID: 144805 RVA: 0x00921D76 File Offset: 0x0091FF76
		// (set) Token: 0x060235A6 RID: 144806 RVA: 0x00921D86 File Offset: 0x0091FF86
		public unsafe float 吸附偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170040DB RID: 16603
		// (get) Token: 0x060235A7 RID: 144807 RVA: 0x00921D97 File Offset: 0x0091FF97
		// (set) Token: 0x060235A8 RID: 144808 RVA: 0x00921DAB File Offset: 0x0091FFAB
		public unsafe AActor SplineActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x060235A9 RID: 144809 RVA: 0x00921DC0 File Offset: 0x0091FFC0
		// (set) Token: 0x060235AA RID: 144810 RVA: 0x00921DD0 File Offset: 0x0091FFD0
		public unsafe bool 启用
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x060235AB RID: 144811 RVA: 0x00921DE1 File Offset: 0x0091FFE1
		// (set) Token: 0x060235AC RID: 144812 RVA: 0x00921DF1 File Offset: 0x0091FFF1
		public unsafe bool 低内存设备禁用
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x060235AD RID: 144813 RVA: 0x00921E02 File Offset: 0x00920002
		// (set) Token: 0x060235AE RID: 144814 RVA: 0x00921E12 File Offset: 0x00920012
		public unsafe bool 开启投影
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040DF RID: 16607
		// (get) Token: 0x060235AF RID: 144815 RVA: 0x00921E23 File Offset: 0x00920023
		// (set) Token: 0x060235B0 RID: 144816 RVA: 0x00921E33 File Offset: 0x00920033
		public unsafe bool 开启自定义深度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040E0 RID: 16608
		// (get) Token: 0x060235B1 RID: 144817 RVA: 0x00921E44 File Offset: 0x00920044
		// (set) Token: 0x060235B2 RID: 144818 RVA: 0x00921E7D File Offset: 0x0092007D
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
					result = (this._添加碰撞__测试_ = new FCollisionProfileName(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_10, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040E1 RID: 16609
		// (get) Token: 0x060235B3 RID: 144819 RVA: 0x00921E9E File Offset: 0x0092009E
		// (set) Token: 0x060235B4 RID: 144820 RVA: 0x00921EB2 File Offset: 0x009200B2
		public unsafe FVector UpDirection__测试_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170040E2 RID: 16610
		// (get) Token: 0x060235B5 RID: 144821 RVA: 0x00921EC7 File Offset: 0x009200C7
		// (set) Token: 0x060235B6 RID: 144822 RVA: 0x00921ED7 File Offset: 0x009200D7
		public unsafe bool 顶点旋转同步
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040E3 RID: 16611
		// (get) Token: 0x060235B7 RID: 144823 RVA: 0x00921EE8 File Offset: 0x009200E8
		// (set) Token: 0x060235B8 RID: 144824 RVA: 0x00921F21 File Offset: 0x00920121
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
					result = (this._属性列表 = new SPCG_RoadPropertyBased(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPCG_RoadPropertyBased.StaticStruct(), base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170040E4 RID: 16612
		// (get) Token: 0x060235B9 RID: 144825 RVA: 0x00921F42 File Offset: 0x00920142
		// (set) Token: 0x060235BA RID: 144826 RVA: 0x00921F56 File Offset: 0x00920156
		public unsafe UStaticMesh 封口模型
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x170040E5 RID: 16613
		// (get) Token: 0x060235BB RID: 144827 RVA: 0x00921F6B File Offset: 0x0092016B
		// (set) Token: 0x060235BC RID: 144828 RVA: 0x00921F7F File Offset: 0x0092017F
		public unsafe FVector 封口偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170040E6 RID: 16614
		// (get) Token: 0x060235BD RID: 144829 RVA: 0x00921F94 File Offset: 0x00920194
		// (set) Token: 0x060235BE RID: 144830 RVA: 0x00921FA4 File Offset: 0x009201A4
		public unsafe float 封口旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170040E7 RID: 16615
		// (get) Token: 0x060235BF RID: 144831 RVA: 0x00921FB5 File Offset: 0x009201B5
		// (set) Token: 0x060235C0 RID: 144832 RVA: 0x00921FC5 File Offset: 0x009201C5
		public unsafe bool VertexCompress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x060235C1 RID: 144833 RVA: 0x00921FD6 File Offset: 0x009201D6
		// (set) Token: 0x060235C2 RID: 144834 RVA: 0x00921FEA File Offset: 0x009201EA
		public unsafe ASkeletalMeshActor 骨骼动画对象
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ASkeletalMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x170040E9 RID: 16617
		// (get) Token: 0x060235C3 RID: 144835 RVA: 0x00921FFF File Offset: 0x009201FF
		// (set) Token: 0x060235C4 RID: 144836 RVA: 0x00922013 File Offset: 0x00920213
		public unsafe ALevelSequenceActor 序列帧对象
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x170040EA RID: 16618
		// (get) Token: 0x060235C5 RID: 144837 RVA: 0x00922028 File Offset: 0x00920228
		// (set) Token: 0x060235C6 RID: 144838 RVA: 0x00922038 File Offset: 0x00920238
		public unsafe float 动画帧数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170040EB RID: 16619
		// (get) Token: 0x060235C7 RID: 144839 RVA: 0x00922049 File Offset: 0x00920249
		// (set) Token: 0x060235C8 RID: 144840 RVA: 0x0092205D File Offset: 0x0092025D
		public unsafe FName 骨骼名称
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170040EC RID: 16620
		// (get) Token: 0x060235C9 RID: 144841 RVA: 0x00922072 File Offset: 0x00920272
		// (set) Token: 0x060235CA RID: 144842 RVA: 0x00922082 File Offset: 0x00920282
		public unsafe bool Tick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040ED RID: 16621
		// (get) Token: 0x060235CB RID: 144843 RVA: 0x00922093 File Offset: 0x00920293
		// (set) Token: 0x060235CC RID: 144844 RVA: 0x009220A3 File Offset: 0x009202A3
		public unsafe float Frame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170040EE RID: 16622
		// (get) Token: 0x060235CD RID: 144845 RVA: 0x009220B4 File Offset: 0x009202B4
		// (set) Token: 0x060235CE RID: 144846 RVA: 0x009220C8 File Offset: 0x009202C8
		public unsafe FVectorDouble LastPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x060235CF RID: 144847 RVA: 0x009220DD File Offset: 0x009202DD
		// (set) Token: 0x060235D0 RID: 144848 RVA: 0x009220ED File Offset: 0x009202ED
		public unsafe float 最小采样距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x060235D1 RID: 144849 RVA: 0x009220FE File Offset: 0x009202FE
		// (set) Token: 0x060235D2 RID: 144850 RVA: 0x0092210E File Offset: 0x0092030E
		public unsafe bool IsSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x060235D3 RID: 144851 RVA: 0x0092211F File Offset: 0x0092031F
		// (set) Token: 0x060235D4 RID: 144852 RVA: 0x00922133 File Offset: 0x00920333
		public unsafe ULevelSequencePlayer Sequence_Player
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + PCG_RoadSpline_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x060235D5 RID: 144853 RVA: 0x00922148 File Offset: 0x00920348
		// (set) Token: 0x060235D6 RID: 144854 RVA: 0x0092215C File Offset: 0x0092035C
		public unsafe FVectorDouble FirstPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x060235D7 RID: 144855 RVA: 0x00922171 File Offset: 0x00920371
		// (set) Token: 0x060235D8 RID: 144856 RVA: 0x00922181 File Offset: 0x00920381
		public unsafe int 基于分段数
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x060235D9 RID: 144857 RVA: 0x00922192 File Offset: 0x00920392
		// (set) Token: 0x060235DA RID: 144858 RVA: 0x009221A2 File Offset: 0x009203A2
		public unsafe float 基于分段长度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PCG_RoadSpline_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x060235DB RID: 144859 RVA: 0x009221B3 File Offset: 0x009203B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 追踪动画轨迹()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__追踪动画轨迹_NativeFunctionPtr, null);
		}

		// Token: 0x060235DC RID: 144860 RVA: 0x009221C8 File Offset: 0x009203C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetRoadWidth(bool IgnoreScale, ref float Width)
		{
			PCG_RoadSpline_C.__GetRoadWidth_FunctionParams* ptr = stackalloc PCG_RoadSpline_C.__GetRoadWidth_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(PCG_RoadSpline_C.__GetRoadWidth_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSpline_C.__GetRoadWidth_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IgnoreScale = IgnoreScale;
			ptr->Width = Width;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__GetRoadWidth_NativeFunctionPtr, (void*)ptr);
			Width = ptr->Width;
		}

		// Token: 0x060235DD RID: 144861 RVA: 0x00922220 File Offset: 0x00920420
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetRoadMesh(ref UStaticMesh 基础模型)
		{
			PCG_RoadSpline_C.__GetRoadMesh_FunctionParams* ptr = stackalloc PCG_RoadSpline_C.__GetRoadMesh_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(PCG_RoadSpline_C.__GetRoadMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSpline_C.__GetRoadMesh_NativeFunctionPtr, (void*)ptr, 1);
			ref PCG_RoadSpline_C.__GetRoadMesh_FunctionParams ptr2 = ref *ptr;
			UStaticMesh ustaticMesh = 基础模型;
			ptr2.基础模型 = ((ustaticMesh != null) ? ustaticMesh.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__GetRoadMesh_NativeFunctionPtr, (void*)ptr);
			基础模型 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMesh>(ptr->基础模型);
		}

		// Token: 0x060235DE RID: 144862 RVA: 0x00922284 File Offset: 0x00920484
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CopyToSplineActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__CopyToSplineActor_NativeFunctionPtr, null);
		}

		// Token: 0x060235DF RID: 144863 RVA: 0x00922298 File Offset: 0x00920498
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CopySplineActor()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__CopySplineActor_NativeFunctionPtr, null);
		}

		// Token: 0x060235E0 RID: 144864 RVA: 0x009222AC File Offset: 0x009204AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 向下吸附到地形()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__向下吸附到地形_NativeFunctionPtr, null);
		}

		// Token: 0x060235E1 RID: 144865 RVA: 0x009222C0 File Offset: 0x009204C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void GenerateEndCaps()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__GenerateEndCaps_NativeFunctionPtr, null);
		}

		// Token: 0x060235E2 RID: 144866 RVA: 0x009222D4 File Offset: 0x009204D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GenerateMesh(bool ByPoint)
		{
			PCG_RoadSpline_C.__GenerateMesh_FunctionParams* ptr = stackalloc PCG_RoadSpline_C.__GenerateMesh_FunctionParams[(UIntPtr)959] + 15L / (long)sizeof(PCG_RoadSpline_C.__GenerateMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSpline_C.__GenerateMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ByPoint = ByPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__GenerateMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060235E3 RID: 144867 RVA: 0x0092231D File Offset: 0x0092051D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060235E4 RID: 144868 RVA: 0x00922331 File Offset: 0x00920531
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, PCG_RoadSpline_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060235E5 RID: 144869 RVA: 0x00922348 File Offset: 0x00920548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			PCG_RoadSpline_C.__EditorTick_FunctionParams* ptr = stackalloc PCG_RoadSpline_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(PCG_RoadSpline_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSpline_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, PCG_RoadSpline_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060235E6 RID: 144870 RVA: 0x00922390 File Offset: 0x00920590
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			PCG_RoadSpline_C.__EditorTick_FunctionParams* ptr = stackalloc PCG_RoadSpline_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(PCG_RoadSpline_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(PCG_RoadSpline_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, PCG_RoadSpline_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060235E7 RID: 144871 RVA: 0x009223D7 File Offset: 0x009205D7
		protected PCG_RoadSpline_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011716 RID: 71446
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/RoadSpline/PCG_RoadSpline.PCG_RoadSpline_C";

		// Token: 0x04011717 RID: 71447
		private static IntPtr _ClassPtr;

		// Token: 0x04011718 RID: 71448
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011719 RID: 71449
		internal static int __PropertyOffset_1;

		// Token: 0x0401171A RID: 71450
		internal static int __PropertyOffset_2;

		// Token: 0x0401171B RID: 71451
		internal static int __PropertyOffset_3;

		// Token: 0x0401171C RID: 71452
		internal static int __PropertyOffset_4;

		// Token: 0x0401171D RID: 71453
		internal static int __PropertyOffset_5;

		// Token: 0x0401171E RID: 71454
		internal static int __PropertyOffset_6;

		// Token: 0x0401171F RID: 71455
		internal static int __PropertyOffset_7;

		// Token: 0x04011720 RID: 71456
		internal static int __PropertyOffset_8;

		// Token: 0x04011721 RID: 71457
		internal static int __PropertyOffset_9;

		// Token: 0x04011722 RID: 71458
		internal static int __PropertyOffset_10;

		// Token: 0x04011723 RID: 71459
		private FCollisionProfileName _添加碰撞__测试_;

		// Token: 0x04011724 RID: 71460
		internal static int __PropertyOffset_11;

		// Token: 0x04011725 RID: 71461
		internal static int __PropertyOffset_12;

		// Token: 0x04011726 RID: 71462
		internal static int __PropertyOffset_13;

		// Token: 0x04011727 RID: 71463
		private SPCG_RoadPropertyBased _属性列表;

		// Token: 0x04011728 RID: 71464
		internal static int __PropertyOffset_14;

		// Token: 0x04011729 RID: 71465
		internal static int __PropertyOffset_15;

		// Token: 0x0401172A RID: 71466
		internal static int __PropertyOffset_16;

		// Token: 0x0401172B RID: 71467
		internal static int __PropertyOffset_17;

		// Token: 0x0401172C RID: 71468
		internal static int __PropertyOffset_18;

		// Token: 0x0401172D RID: 71469
		internal static int __PropertyOffset_19;

		// Token: 0x0401172E RID: 71470
		internal static int __PropertyOffset_20;

		// Token: 0x0401172F RID: 71471
		internal static int __PropertyOffset_21;

		// Token: 0x04011730 RID: 71472
		internal static int __PropertyOffset_22;

		// Token: 0x04011731 RID: 71473
		internal static int __PropertyOffset_23;

		// Token: 0x04011732 RID: 71474
		internal static int __PropertyOffset_24;

		// Token: 0x04011733 RID: 71475
		internal static int __PropertyOffset_25;

		// Token: 0x04011734 RID: 71476
		internal static int __PropertyOffset_26;

		// Token: 0x04011735 RID: 71477
		internal static int __PropertyOffset_27;

		// Token: 0x04011736 RID: 71478
		internal static int __PropertyOffset_28;

		// Token: 0x04011737 RID: 71479
		internal static int __PropertyOffset_29;

		// Token: 0x04011738 RID: 71480
		internal static int __PropertyOffset_30;

		// Token: 0x04011739 RID: 71481
		private static IntPtr __追踪动画轨迹_NativeFunctionPtr;

		// Token: 0x0401173A RID: 71482
		private static IntPtr __GetRoadWidth_NativeFunctionPtr;

		// Token: 0x0401173B RID: 71483
		private static IntPtr __GetRoadMesh_NativeFunctionPtr;

		// Token: 0x0401173C RID: 71484
		private static IntPtr __CopyToSplineActor_NativeFunctionPtr;

		// Token: 0x0401173D RID: 71485
		private static IntPtr __CopySplineActor_NativeFunctionPtr;

		// Token: 0x0401173E RID: 71486
		private static IntPtr __向下吸附到地形_NativeFunctionPtr;

		// Token: 0x0401173F RID: 71487
		private static IntPtr __GenerateEndCaps_NativeFunctionPtr;

		// Token: 0x04011740 RID: 71488
		private static IntPtr __GenerateMesh_NativeFunctionPtr;

		// Token: 0x04011741 RID: 71489
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011742 RID: 71490
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009E60 RID: 40544
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetRoadWidth_FunctionParams
		{
			// Token: 0x040316E4 RID: 202468
			[FieldOffset(0)]
			public bool IgnoreScale;

			// Token: 0x040316E5 RID: 202469
			[FieldOffset(4)]
			public float Width;
		}

		// Token: 0x02009E61 RID: 40545
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetRoadMesh_FunctionParams
		{
			// Token: 0x040316E6 RID: 202470
			[FieldOffset(0)]
			public IntPtr 基础模型;
		}

		// Token: 0x02009E62 RID: 40546
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 944)]
		protected ref struct __GenerateMesh_FunctionParams
		{
			// Token: 0x040316E7 RID: 202471
			[FieldOffset(0)]
			public bool ByPoint;
		}

		// Token: 0x02009E63 RID: 40547
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040316E8 RID: 202472
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
