using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG._2DRayCastingGamePlay.Camera
{
	// Token: 0x02003CE6 RID: 15590
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/Camera/BP_cpuRayCasting_camera.BP_cpuRayCasting_camera_C")]
	[UnrealStructLayout(1912, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1912)]
	public class BP_cpuRayCasting_camera_C : AFSRayCastingActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025113 RID: 151827 RVA: 0x00950655 File Offset: 0x0094E855
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_cpuRayCasting_camera_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/Camera/BP_cpuRayCasting_camera.BP_cpuRayCasting_camera_C");
			}
			return BP_cpuRayCasting_camera_C._ClassPtr;
		}

		// Token: 0x06025114 RID: 151828 RVA: 0x0095067C File Offset: 0x0094E87C
		public BP_cpuRayCasting_camera_C() : this(BuiltinUtils.AllocNativeUObject(BP_cpuRayCasting_camera_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025115 RID: 151829 RVA: 0x009506A4 File Offset: 0x0094E8A4
		public BP_cpuRayCasting_camera_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_cpuRayCasting_camera_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004AA2 RID: 19106
		// (get) Token: 0x06025116 RID: 151830 RVA: 0x009506D7 File Offset: 0x0094E8D7
		// (set) Token: 0x06025117 RID: 151831 RVA: 0x009506EB File Offset: 0x0094E8EB
		[Nullable(2)]
		public unsafe UProceduralMeshComponent PM_rayArea
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProceduralMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004AA3 RID: 19107
		// (get) Token: 0x06025118 RID: 151832 RVA: 0x00950700 File Offset: 0x0094E900
		// (set) Token: 0x06025119 RID: 151833 RVA: 0x00950714 File Offset: 0x0094E914
		[Nullable(2)]
		public unsafe UStaticMeshComponent Plane1
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_2);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004AA4 RID: 19108
		// (get) Token: 0x0602511A RID: 151834 RVA: 0x00950729 File Offset: 0x0094E929
		// (set) Token: 0x0602511B RID: 151835 RVA: 0x0095073D File Offset: 0x0094E93D
		[Nullable(2)]
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004AA5 RID: 19109
		// (get) Token: 0x0602511C RID: 151836 RVA: 0x00950752 File Offset: 0x0094E952
		// (set) Token: 0x0602511D RID: 151837 RVA: 0x00950766 File Offset: 0x0094E966
		[Nullable(2)]
		public unsafe UBoxComponent Box_Collision
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_4);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004AA6 RID: 19110
		// (get) Token: 0x0602511E RID: 151838 RVA: 0x0095077B File Offset: 0x0094E97B
		// (set) Token: 0x0602511F RID: 151839 RVA: 0x0095078F File Offset: 0x0094E98F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_5);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004AA7 RID: 19111
		// (get) Token: 0x06025120 RID: 151840 RVA: 0x009507A4 File Offset: 0x0094E9A4
		// (set) Token: 0x06025121 RID: 151841 RVA: 0x009507DD File Offset: 0x0094E9DD
		public TArray<float> Dis
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Dis) == null)
				{
					result = (this._Dis = new TArray<float>(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.Dis.CopyAssign(value);
			}
		}

		// Token: 0x17004AA8 RID: 19112
		// (get) Token: 0x06025122 RID: 151842 RVA: 0x009507EC File Offset: 0x0094E9EC
		// (set) Token: 0x06025123 RID: 151843 RVA: 0x00950825 File Offset: 0x0094EA25
		public TArray<FVector> Dirs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Dirs) == null)
				{
					result = (this._Dirs = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.Dirs.CopyAssign(value);
			}
		}

		// Token: 0x17004AA9 RID: 19113
		// (get) Token: 0x06025124 RID: 151844 RVA: 0x00950834 File Offset: 0x0094EA34
		// (set) Token: 0x06025125 RID: 151845 RVA: 0x0095086D File Offset: 0x0094EA6D
		public TArray<FVector> EndPos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._EndPos) == null)
				{
					result = (this._EndPos = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.EndPos.CopyAssign(value);
			}
		}

		// Token: 0x17004AAA RID: 19114
		// (get) Token: 0x06025126 RID: 151846 RVA: 0x0095087B File Offset: 0x0094EA7B
		// (set) Token: 0x06025127 RID: 151847 RVA: 0x0095088B File Offset: 0x0094EA8B
		public unsafe float RayCastingDetectDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004AAB RID: 19115
		// (get) Token: 0x06025128 RID: 151848 RVA: 0x0095089C File Offset: 0x0094EA9C
		// (set) Token: 0x06025129 RID: 151849 RVA: 0x009508AC File Offset: 0x0094EAAC
		public unsafe int particleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004AAC RID: 19116
		// (get) Token: 0x0602512A RID: 151850 RVA: 0x009508BD File Offset: 0x0094EABD
		// (set) Token: 0x0602512B RID: 151851 RVA: 0x009508CD File Offset: 0x0094EACD
		public unsafe int CountIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004AAD RID: 19117
		// (get) Token: 0x0602512C RID: 151852 RVA: 0x009508E0 File Offset: 0x0094EAE0
		// (set) Token: 0x0602512D RID: 151853 RVA: 0x00950919 File Offset: 0x0094EB19
		public TArray<FVector> Vertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17004AAE RID: 19118
		// (get) Token: 0x0602512E RID: 151854 RVA: 0x00950928 File Offset: 0x0094EB28
		// (set) Token: 0x0602512F RID: 151855 RVA: 0x00950961 File Offset: 0x0094EB61
		public TArray<int> triangles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._triangles) == null)
				{
					result = (this._triangles = new TArray<int>(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.triangles.CopyAssign(value);
			}
		}

		// Token: 0x17004AAF RID: 19119
		// (get) Token: 0x06025130 RID: 151856 RVA: 0x0095096F File Offset: 0x0094EB6F
		// (set) Token: 0x06025131 RID: 151857 RVA: 0x0095097F File Offset: 0x0094EB7F
		public unsafe bool stopMeshing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AB0 RID: 19120
		// (get) Token: 0x06025132 RID: 151858 RVA: 0x00950990 File Offset: 0x0094EB90
		// (set) Token: 0x06025133 RID: 151859 RVA: 0x009509A4 File Offset: 0x0094EBA4
		public unsafe FRotator RayStartoRatation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004AB1 RID: 19121
		// (get) Token: 0x06025134 RID: 151860 RVA: 0x009509B9 File Offset: 0x0094EBB9
		// (set) Token: 0x06025135 RID: 151861 RVA: 0x009509C9 File Offset: 0x0094EBC9
		public unsafe int BatchSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004AB2 RID: 19122
		// (get) Token: 0x06025136 RID: 151862 RVA: 0x009509DA File Offset: 0x0094EBDA
		// (set) Token: 0x06025137 RID: 151863 RVA: 0x009509EA File Offset: 0x0094EBEA
		public unsafe bool PlayerColOnOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AB3 RID: 19123
		// (get) Token: 0x06025138 RID: 151864 RVA: 0x009509FB File Offset: 0x0094EBFB
		// (set) Token: 0x06025139 RID: 151865 RVA: 0x00950A0B File Offset: 0x0094EC0B
		public unsafe bool drawdebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AB4 RID: 19124
		// (get) Token: 0x0602513A RID: 151866 RVA: 0x00950A1C File Offset: 0x0094EC1C
		// (set) Token: 0x0602513B RID: 151867 RVA: 0x00950A55 File Offset: 0x0094EC55
		public TArray<FName> ParamNameList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ParamNameList) == null)
				{
					result = (this._ParamNameList = new TArray<FName>(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				this.ParamNameList.CopyAssign(value);
			}
		}

		// Token: 0x17004AB5 RID: 19125
		// (get) Token: 0x0602513C RID: 151868 RVA: 0x00950A64 File Offset: 0x0094EC64
		// (set) Token: 0x0602513D RID: 151869 RVA: 0x00950A9D File Offset: 0x0094EC9D
		public TArray<FVector2D> UvList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._UvList) == null)
				{
					result = (this._UvList = new TArray<FVector2D>(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_20, this));
				}
				return result;
			}
			set
			{
				this.UvList.CopyAssign(value);
			}
		}

		// Token: 0x17004AB6 RID: 19126
		// (get) Token: 0x0602513E RID: 151870 RVA: 0x00950AAB File Offset: 0x0094ECAB
		// (set) Token: 0x0602513F RID: 151871 RVA: 0x00950ABF File Offset: 0x0094ECBF
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MID
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_21);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_camera_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17004AB7 RID: 19127
		// (get) Token: 0x06025140 RID: 151872 RVA: 0x00950AD4 File Offset: 0x0094ECD4
		// (set) Token: 0x06025141 RID: 151873 RVA: 0x00950AE4 File Offset: 0x0094ECE4
		public unsafe bool motionOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AB8 RID: 19128
		// (get) Token: 0x06025142 RID: 151874 RVA: 0x00950AF5 File Offset: 0x0094ECF5
		// (set) Token: 0x06025143 RID: 151875 RVA: 0x00950B09 File Offset: 0x0094ED09
		public unsafe FVector C
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004AB9 RID: 19129
		// (get) Token: 0x06025144 RID: 151876 RVA: 0x00950B1E File Offset: 0x0094ED1E
		// (set) Token: 0x06025145 RID: 151877 RVA: 0x00950B2E File Offset: 0x0094ED2E
		public unsafe float R
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004ABA RID: 19130
		// (get) Token: 0x06025146 RID: 151878 RVA: 0x00950B3F File Offset: 0x0094ED3F
		// (set) Token: 0x06025147 RID: 151879 RVA: 0x00950B4F File Offset: 0x0094ED4F
		public unsafe float dA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004ABB RID: 19131
		// (get) Token: 0x06025148 RID: 151880 RVA: 0x00950B60 File Offset: 0x0094ED60
		// (set) Token: 0x06025149 RID: 151881 RVA: 0x00950B70 File Offset: 0x0094ED70
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004ABC RID: 19132
		// (get) Token: 0x0602514A RID: 151882 RVA: 0x00950B81 File Offset: 0x0094ED81
		// (set) Token: 0x0602514B RID: 151883 RVA: 0x00950B91 File Offset: 0x0094ED91
		public unsafe float debugangle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004ABD RID: 19133
		// (get) Token: 0x0602514C RID: 151884 RVA: 0x00950BA2 File Offset: 0x0094EDA2
		// (set) Token: 0x0602514D RID: 151885 RVA: 0x00950BB2 File Offset: 0x0094EDB2
		public unsafe int debugdir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004ABE RID: 19134
		// (get) Token: 0x0602514E RID: 151886 RVA: 0x00950BC3 File Offset: 0x0094EDC3
		// (set) Token: 0x0602514F RID: 151887 RVA: 0x00950BD3 File Offset: 0x0094EDD3
		public unsafe float BoundingBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004ABF RID: 19135
		// (get) Token: 0x06025150 RID: 151888 RVA: 0x00950BE4 File Offset: 0x0094EDE4
		// (set) Token: 0x06025151 RID: 151889 RVA: 0x00950C1D File Offset: 0x0094EE1D
		public TArray<AActor> IgnoreActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._IgnoreActors) == null)
				{
					result = (this._IgnoreActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_30, this));
				}
				return result;
			}
			set
			{
				this.IgnoreActors.CopyAssign(value);
			}
		}

		// Token: 0x17004AC0 RID: 19136
		// (get) Token: 0x06025152 RID: 151890 RVA: 0x00950C2B File Offset: 0x0094EE2B
		// (set) Token: 0x06025153 RID: 151891 RVA: 0x00950C3B File Offset: 0x0094EE3B
		public unsafe double Max_Degree_Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17004AC1 RID: 19137
		// (get) Token: 0x06025154 RID: 151892 RVA: 0x00950C4C File Offset: 0x0094EE4C
		// (set) Token: 0x06025155 RID: 151893 RVA: 0x00950C5C File Offset: 0x0094EE5C
		public unsafe double Return_Speed_Degrees_Second
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004AC2 RID: 19138
		// (get) Token: 0x06025156 RID: 151894 RVA: 0x00950C6D File Offset: 0x0094EE6D
		// (set) Token: 0x06025157 RID: 151895 RVA: 0x00950C7D File Offset: 0x0094EE7D
		public unsafe double Follow_Speed_Degrees_Second
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17004AC3 RID: 19139
		// (get) Token: 0x06025158 RID: 151896 RVA: 0x00950C8E File Offset: 0x0094EE8E
		// (set) Token: 0x06025159 RID: 151897 RVA: 0x00950C9E File Offset: 0x0094EE9E
		public unsafe double Min_Active_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17004AC4 RID: 19140
		// (get) Token: 0x0602515A RID: 151898 RVA: 0x00950CAF File Offset: 0x0094EEAF
		// (set) Token: 0x0602515B RID: 151899 RVA: 0x00950CBF File Offset: 0x0094EEBF
		public unsafe double Max_Active_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17004AC5 RID: 19141
		// (get) Token: 0x0602515C RID: 151900 RVA: 0x00950CD0 File Offset: 0x0094EED0
		// (set) Token: 0x0602515D RID: 151901 RVA: 0x00950CE0 File Offset: 0x0094EEE0
		public unsafe bool Enable跷跷板
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AC6 RID: 19142
		// (get) Token: 0x0602515E RID: 151902 RVA: 0x00950CF1 File Offset: 0x0094EEF1
		// (set) Token: 0x0602515F RID: 151903 RVA: 0x00950D01 File Offset: 0x0094EF01
		public unsafe float RayCastingDetectMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17004AC7 RID: 19143
		// (get) Token: 0x06025160 RID: 151904 RVA: 0x00950D12 File Offset: 0x0094EF12
		// (set) Token: 0x06025161 RID: 151905 RVA: 0x00950D22 File Offset: 0x0094EF22
		public unsafe bool 固定碰撞体_旋转不可用_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AC8 RID: 19144
		// (get) Token: 0x06025162 RID: 151906 RVA: 0x00950D33 File Offset: 0x0094EF33
		// (set) Token: 0x06025163 RID: 151907 RVA: 0x00950D47 File Offset: 0x0094EF47
		public unsafe FVector startWorldPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17004AC9 RID: 19145
		// (get) Token: 0x06025164 RID: 151908 RVA: 0x00950D5C File Offset: 0x0094EF5C
		// (set) Token: 0x06025165 RID: 151909 RVA: 0x00950D6C File Offset: 0x0094EF6C
		public unsafe bool DebugMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ACA RID: 19146
		// (get) Token: 0x06025166 RID: 151910 RVA: 0x00950D7D File Offset: 0x0094EF7D
		// (set) Token: 0x06025167 RID: 151911 RVA: 0x00950D8D File Offset: 0x0094EF8D
		public unsafe bool bEditorT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ACB RID: 19147
		// (get) Token: 0x06025168 RID: 151912 RVA: 0x00950D9E File Offset: 0x0094EF9E
		// (set) Token: 0x06025169 RID: 151913 RVA: 0x00950DAE File Offset: 0x0094EFAE
		public unsafe bool bLinear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ACC RID: 19148
		// (get) Token: 0x0602516A RID: 151914 RVA: 0x00950DBF File Offset: 0x0094EFBF
		// (set) Token: 0x0602516B RID: 151915 RVA: 0x00950DCF File Offset: 0x0094EFCF
		public unsafe bool bdebugTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ACD RID: 19149
		// (get) Token: 0x0602516C RID: 151916 RVA: 0x00950DE0 File Offset: 0x0094EFE0
		// (set) Token: 0x0602516D RID: 151917 RVA: 0x00950E19 File Offset: 0x0094F019
		public TArray<int> Intarr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Intarr) == null)
				{
					result = (this._Intarr = new TArray<int>(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_44, this));
				}
				return result;
			}
			set
			{
				this.Intarr.CopyAssign(value);
			}
		}

		// Token: 0x17004ACE RID: 19150
		// (get) Token: 0x0602516E RID: 151918 RVA: 0x00950E27 File Offset: 0x0094F027
		// (set) Token: 0x0602516F RID: 151919 RVA: 0x00950E3B File Offset: 0x0094F03B
		public unsafe FRandomStream randomStream
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_camera_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x06025170 RID: 151920 RVA: 0x00950E50 File Offset: 0x0094F050
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void boxcollisionConst()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__boxcollisionConst_NativeFunctionPtr, null);
		}

		// Token: 0x06025171 RID: 151921 RVA: 0x00950E64 File Offset: 0x0094F064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Rotate_Plane_by_Player(bool OnPlaneOrNot, bool StopPlaneReturn)
		{
			BP_cpuRayCasting_camera_C.__Rotate_Plane_by_Player_FunctionParams* ptr = stackalloc BP_cpuRayCasting_camera_C.__Rotate_Plane_by_Player_FunctionParams[(UIntPtr)1567] + 15L / (long)sizeof(BP_cpuRayCasting_camera_C.__Rotate_Plane_by_Player_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_camera_C.__Rotate_Plane_by_Player_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OnPlaneOrNot = OnPlaneOrNot;
			ptr->StopPlaneReturn = StopPlaneReturn;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__Rotate_Plane_by_Player_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025172 RID: 151922 RVA: 0x00950EB4 File Offset: 0x0094F0B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void updateScale()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__updateScale_NativeFunctionPtr, null);
		}

		// Token: 0x06025173 RID: 151923 RVA: 0x00950EC8 File Offset: 0x0094F0C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DebugMovement(float dt)
		{
			BP_cpuRayCasting_camera_C.__DebugMovement_FunctionParams* ptr = stackalloc BP_cpuRayCasting_camera_C.__DebugMovement_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_cpuRayCasting_camera_C.__DebugMovement_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_camera_C.__DebugMovement_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__DebugMovement_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025174 RID: 151924 RVA: 0x00950F11 File Offset: 0x0094F111
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_All()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__Init_All_NativeFunctionPtr, null);
		}

		// Token: 0x06025175 RID: 151925 RVA: 0x00950F25 File Offset: 0x0094F125
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_Triangles()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__Init_Triangles_NativeFunctionPtr, null);
		}

		// Token: 0x06025176 RID: 151926 RVA: 0x00950F39 File Offset: 0x0094F139
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Create_Mesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__Create_Mesh_NativeFunctionPtr, null);
		}

		// Token: 0x06025177 RID: 151927 RVA: 0x00950F4D File Offset: 0x0094F14D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void initRay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__initRay_NativeFunctionPtr, null);
		}

		// Token: 0x06025178 RID: 151928 RVA: 0x00950F61 File Offset: 0x0094F161
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025179 RID: 151929 RVA: 0x00950F75 File Offset: 0x0094F175
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602517A RID: 151930 RVA: 0x00950F8A File Offset: 0x0094F18A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602517B RID: 151931 RVA: 0x00950F9E File Offset: 0x0094F19E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x0602517C RID: 151932 RVA: 0x00950FB4 File Offset: 0x0094F1B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_cpuRayCasting_camera_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_cpuRayCasting_camera_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_camera_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_camera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602517D RID: 151933 RVA: 0x00950FFC File Offset: 0x0094F1FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_cpuRayCasting_camera_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_cpuRayCasting_camera_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_camera_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_camera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602517E RID: 151934 RVA: 0x00951043 File Offset: 0x0094F243
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602517F RID: 151935 RVA: 0x00951057 File Offset: 0x0094F257
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_cpuRayCasting_camera_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025180 RID: 151936 RVA: 0x0095106C File Offset: 0x0094F26C
		protected BP_cpuRayCasting_camera_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012728 RID: 75560
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/Camera/BP_cpuRayCasting_camera.BP_cpuRayCasting_camera_C";

		// Token: 0x04012729 RID: 75561
		private static IntPtr _ClassPtr;

		// Token: 0x0401272A RID: 75562
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401272B RID: 75563
		internal static int __PropertyOffset_1;

		// Token: 0x0401272C RID: 75564
		internal static int __PropertyOffset_2;

		// Token: 0x0401272D RID: 75565
		internal static int __PropertyOffset_3;

		// Token: 0x0401272E RID: 75566
		internal static int __PropertyOffset_4;

		// Token: 0x0401272F RID: 75567
		internal static int __PropertyOffset_5;

		// Token: 0x04012730 RID: 75568
		internal static int __PropertyOffset_6;

		// Token: 0x04012731 RID: 75569
		[Nullable(2)]
		private TArray<float> _Dis;

		// Token: 0x04012732 RID: 75570
		internal static int __PropertyOffset_7;

		// Token: 0x04012733 RID: 75571
		[Nullable(2)]
		private TArray<FVector> _Dirs;

		// Token: 0x04012734 RID: 75572
		internal static int __PropertyOffset_8;

		// Token: 0x04012735 RID: 75573
		[Nullable(2)]
		private TArray<FVector> _EndPos;

		// Token: 0x04012736 RID: 75574
		internal static int __PropertyOffset_9;

		// Token: 0x04012737 RID: 75575
		internal static int __PropertyOffset_10;

		// Token: 0x04012738 RID: 75576
		internal static int __PropertyOffset_11;

		// Token: 0x04012739 RID: 75577
		internal static int __PropertyOffset_12;

		// Token: 0x0401273A RID: 75578
		[Nullable(2)]
		private TArray<FVector> _Vertices;

		// Token: 0x0401273B RID: 75579
		internal static int __PropertyOffset_13;

		// Token: 0x0401273C RID: 75580
		[Nullable(2)]
		private TArray<int> _triangles;

		// Token: 0x0401273D RID: 75581
		internal static int __PropertyOffset_14;

		// Token: 0x0401273E RID: 75582
		internal static int __PropertyOffset_15;

		// Token: 0x0401273F RID: 75583
		internal static int __PropertyOffset_16;

		// Token: 0x04012740 RID: 75584
		internal static int __PropertyOffset_17;

		// Token: 0x04012741 RID: 75585
		internal static int __PropertyOffset_18;

		// Token: 0x04012742 RID: 75586
		internal static int __PropertyOffset_19;

		// Token: 0x04012743 RID: 75587
		[Nullable(2)]
		private TArray<FName> _ParamNameList;

		// Token: 0x04012744 RID: 75588
		internal static int __PropertyOffset_20;

		// Token: 0x04012745 RID: 75589
		[Nullable(2)]
		private TArray<FVector2D> _UvList;

		// Token: 0x04012746 RID: 75590
		internal static int __PropertyOffset_21;

		// Token: 0x04012747 RID: 75591
		internal static int __PropertyOffset_22;

		// Token: 0x04012748 RID: 75592
		internal static int __PropertyOffset_23;

		// Token: 0x04012749 RID: 75593
		internal static int __PropertyOffset_24;

		// Token: 0x0401274A RID: 75594
		internal static int __PropertyOffset_25;

		// Token: 0x0401274B RID: 75595
		internal static int __PropertyOffset_26;

		// Token: 0x0401274C RID: 75596
		internal static int __PropertyOffset_27;

		// Token: 0x0401274D RID: 75597
		internal static int __PropertyOffset_28;

		// Token: 0x0401274E RID: 75598
		internal static int __PropertyOffset_29;

		// Token: 0x0401274F RID: 75599
		internal static int __PropertyOffset_30;

		// Token: 0x04012750 RID: 75600
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _IgnoreActors;

		// Token: 0x04012751 RID: 75601
		internal static int __PropertyOffset_31;

		// Token: 0x04012752 RID: 75602
		internal static int __PropertyOffset_32;

		// Token: 0x04012753 RID: 75603
		internal static int __PropertyOffset_33;

		// Token: 0x04012754 RID: 75604
		internal static int __PropertyOffset_34;

		// Token: 0x04012755 RID: 75605
		internal static int __PropertyOffset_35;

		// Token: 0x04012756 RID: 75606
		internal static int __PropertyOffset_36;

		// Token: 0x04012757 RID: 75607
		internal static int __PropertyOffset_37;

		// Token: 0x04012758 RID: 75608
		internal static int __PropertyOffset_38;

		// Token: 0x04012759 RID: 75609
		internal static int __PropertyOffset_39;

		// Token: 0x0401275A RID: 75610
		internal static int __PropertyOffset_40;

		// Token: 0x0401275B RID: 75611
		internal static int __PropertyOffset_41;

		// Token: 0x0401275C RID: 75612
		internal static int __PropertyOffset_42;

		// Token: 0x0401275D RID: 75613
		internal static int __PropertyOffset_43;

		// Token: 0x0401275E RID: 75614
		internal static int __PropertyOffset_44;

		// Token: 0x0401275F RID: 75615
		[Nullable(2)]
		private TArray<int> _Intarr;

		// Token: 0x04012760 RID: 75616
		internal static int __PropertyOffset_45;

		// Token: 0x04012761 RID: 75617
		private static IntPtr __boxcollisionConst_NativeFunctionPtr;

		// Token: 0x04012762 RID: 75618
		private static IntPtr __Rotate_Plane_by_Player_NativeFunctionPtr;

		// Token: 0x04012763 RID: 75619
		private static IntPtr __updateScale_NativeFunctionPtr;

		// Token: 0x04012764 RID: 75620
		private static IntPtr __DebugMovement_NativeFunctionPtr;

		// Token: 0x04012765 RID: 75621
		private static IntPtr __Init_All_NativeFunctionPtr;

		// Token: 0x04012766 RID: 75622
		private static IntPtr __Init_Triangles_NativeFunctionPtr;

		// Token: 0x04012767 RID: 75623
		private static IntPtr __Create_Mesh_NativeFunctionPtr;

		// Token: 0x04012768 RID: 75624
		private static IntPtr __initRay_NativeFunctionPtr;

		// Token: 0x04012769 RID: 75625
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401276A RID: 75626
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401276B RID: 75627
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x0401276C RID: 75628
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401276D RID: 75629
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009FAD RID: 40877
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1552)]
		protected ref struct __Rotate_Plane_by_Player_FunctionParams
		{
			// Token: 0x04031A0B RID: 203275
			[FieldOffset(0)]
			public bool OnPlaneOrNot;

			// Token: 0x04031A0C RID: 203276
			[FieldOffset(1)]
			public bool StopPlaneReturn;
		}

		// Token: 0x02009FAE RID: 40878
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __DebugMovement_FunctionParams
		{
			// Token: 0x04031A0D RID: 203277
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x02009FAF RID: 40879
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A0E RID: 203278
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
