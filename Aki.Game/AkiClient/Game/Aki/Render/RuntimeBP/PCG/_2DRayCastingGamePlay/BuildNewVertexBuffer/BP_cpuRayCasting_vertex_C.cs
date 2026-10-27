using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG._2DRayCastingGamePlay.BuildNewVertexBuffer
{
	// Token: 0x02003CE7 RID: 15591
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/BP_cpuRayCasting_vertex.BP_cpuRayCasting_vertex_C")]
	[UnrealStructLayout(2128, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2120)]
	public class BP_cpuRayCasting_vertex_C : AHexagonConsumer, IUnrealUObject, IUnrealObject, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06025181 RID: 151937 RVA: 0x00951075 File Offset: 0x0094F275
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_cpuRayCasting_vertex_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/BP_cpuRayCasting_vertex.BP_cpuRayCasting_vertex_C");
			}
			return BP_cpuRayCasting_vertex_C._ClassPtr;
		}

		// Token: 0x06025182 RID: 151938 RVA: 0x0095109C File Offset: 0x0094F29C
		public BP_cpuRayCasting_vertex_C() : this(BuiltinUtils.AllocNativeUObject(BP_cpuRayCasting_vertex_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025183 RID: 151939 RVA: 0x009510C4 File Offset: 0x0094F2C4
		[NullableContext(1)]
		public BP_cpuRayCasting_vertex_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_cpuRayCasting_vertex_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004ACF RID: 19151
		// (get) Token: 0x06025184 RID: 151940 RVA: 0x009510F7 File Offset: 0x0094F2F7
		// (set) Token: 0x06025185 RID: 151941 RVA: 0x0095110B File Offset: 0x0094F30B
		public unsafe UStaticMeshComponent Plane1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004AD0 RID: 19152
		// (get) Token: 0x06025186 RID: 151942 RVA: 0x00951120 File Offset: 0x0094F320
		// (set) Token: 0x06025187 RID: 151943 RVA: 0x00951134 File Offset: 0x0094F334
		public unsafe UBoxComponent Box_Collision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004AD1 RID: 19153
		// (get) Token: 0x06025188 RID: 151944 RVA: 0x0095114C File Offset: 0x0094F34C
		// (set) Token: 0x06025189 RID: 151945 RVA: 0x00951185 File Offset: 0x0094F385
		[Nullable(1)]
		public TArray<FVector> EndPos
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._EndPos) == null)
				{
					result = (this._EndPos = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.EndPos.CopyAssign(value);
			}
		}

		// Token: 0x17004AD2 RID: 19154
		// (get) Token: 0x0602518A RID: 151946 RVA: 0x00951193 File Offset: 0x0094F393
		// (set) Token: 0x0602518B RID: 151947 RVA: 0x009511A3 File Offset: 0x0094F3A3
		public unsafe float RayCastingDetectDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004AD3 RID: 19155
		// (get) Token: 0x0602518C RID: 151948 RVA: 0x009511B4 File Offset: 0x0094F3B4
		// (set) Token: 0x0602518D RID: 151949 RVA: 0x009511C4 File Offset: 0x0094F3C4
		public unsafe int CountIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004AD4 RID: 19156
		// (get) Token: 0x0602518E RID: 151950 RVA: 0x009511D8 File Offset: 0x0094F3D8
		// (set) Token: 0x0602518F RID: 151951 RVA: 0x00951211 File Offset: 0x0094F411
		[Nullable(1)]
		public TArray<FVector> Vertices
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Vertices) == null)
				{
					result = (this._Vertices = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vertices.CopyAssign(value);
			}
		}

		// Token: 0x17004AD5 RID: 19157
		// (get) Token: 0x06025190 RID: 151952 RVA: 0x00951220 File Offset: 0x0094F420
		// (set) Token: 0x06025191 RID: 151953 RVA: 0x00951259 File Offset: 0x0094F459
		[Nullable(1)]
		public TArray<int> triangles
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._triangles) == null)
				{
					result = (this._triangles = new TArray<int>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.triangles.CopyAssign(value);
			}
		}

		// Token: 0x17004AD6 RID: 19158
		// (get) Token: 0x06025192 RID: 151954 RVA: 0x00951268 File Offset: 0x0094F468
		// (set) Token: 0x06025193 RID: 151955 RVA: 0x009512A1 File Offset: 0x0094F4A1
		[Nullable(1)]
		public FSoftObjectPath EffectNormal
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EffectNormal) == null)
				{
					result = (this._EffectNormal = new FSoftObjectPath(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_8, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004AD7 RID: 19159
		// (get) Token: 0x06025194 RID: 151956 RVA: 0x009512C2 File Offset: 0x0094F4C2
		// (set) Token: 0x06025195 RID: 151957 RVA: 0x009512D2 File Offset: 0x0094F4D2
		public unsafe bool stopMeshing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AD8 RID: 19160
		// (get) Token: 0x06025196 RID: 151958 RVA: 0x009512E3 File Offset: 0x0094F4E3
		// (set) Token: 0x06025197 RID: 151959 RVA: 0x009512F7 File Offset: 0x0094F4F7
		public unsafe FRotator RayStartoRatation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004AD9 RID: 19161
		// (get) Token: 0x06025198 RID: 151960 RVA: 0x0095130C File Offset: 0x0094F50C
		// (set) Token: 0x06025199 RID: 151961 RVA: 0x0095131C File Offset: 0x0094F51C
		public unsafe int BatchSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004ADA RID: 19162
		// (get) Token: 0x0602519A RID: 151962 RVA: 0x0095132D File Offset: 0x0094F52D
		// (set) Token: 0x0602519B RID: 151963 RVA: 0x0095133D File Offset: 0x0094F53D
		public unsafe bool PlayerColOnOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ADB RID: 19163
		// (get) Token: 0x0602519C RID: 151964 RVA: 0x0095134E File Offset: 0x0094F54E
		// (set) Token: 0x0602519D RID: 151965 RVA: 0x0095135E File Offset: 0x0094F55E
		public unsafe bool drawdebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ADC RID: 19164
		// (get) Token: 0x0602519E RID: 151966 RVA: 0x0095136F File Offset: 0x0094F56F
		// (set) Token: 0x0602519F RID: 151967 RVA: 0x0095137F File Offset: 0x0094F57F
		public unsafe bool motionOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004ADD RID: 19165
		// (get) Token: 0x060251A0 RID: 151968 RVA: 0x00951390 File Offset: 0x0094F590
		// (set) Token: 0x060251A1 RID: 151969 RVA: 0x009513A4 File Offset: 0x0094F5A4
		public unsafe FVector C
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004ADE RID: 19166
		// (get) Token: 0x060251A2 RID: 151970 RVA: 0x009513B9 File Offset: 0x0094F5B9
		// (set) Token: 0x060251A3 RID: 151971 RVA: 0x009513C9 File Offset: 0x0094F5C9
		public unsafe float R
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004ADF RID: 19167
		// (get) Token: 0x060251A4 RID: 151972 RVA: 0x009513DA File Offset: 0x0094F5DA
		// (set) Token: 0x060251A5 RID: 151973 RVA: 0x009513EA File Offset: 0x0094F5EA
		public unsafe float dA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004AE0 RID: 19168
		// (get) Token: 0x060251A6 RID: 151974 RVA: 0x009513FB File Offset: 0x0094F5FB
		// (set) Token: 0x060251A7 RID: 151975 RVA: 0x0095140B File Offset: 0x0094F60B
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17004AE1 RID: 19169
		// (get) Token: 0x060251A8 RID: 151976 RVA: 0x0095141C File Offset: 0x0094F61C
		// (set) Token: 0x060251A9 RID: 151977 RVA: 0x0095142C File Offset: 0x0094F62C
		public unsafe float debugangle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17004AE2 RID: 19170
		// (get) Token: 0x060251AA RID: 151978 RVA: 0x0095143D File Offset: 0x0094F63D
		// (set) Token: 0x060251AB RID: 151979 RVA: 0x0095144D File Offset: 0x0094F64D
		public unsafe int debugdir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17004AE3 RID: 19171
		// (get) Token: 0x060251AC RID: 151980 RVA: 0x0095145E File Offset: 0x0094F65E
		// (set) Token: 0x060251AD RID: 151981 RVA: 0x0095146E File Offset: 0x0094F66E
		public unsafe float BoundingBoxSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17004AE4 RID: 19172
		// (get) Token: 0x060251AE RID: 151982 RVA: 0x00951480 File Offset: 0x0094F680
		// (set) Token: 0x060251AF RID: 151983 RVA: 0x009514B9 File Offset: 0x0094F6B9
		[Nullable(1)]
		public TArray<AActor> IgnoreActors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._IgnoreActors) == null)
				{
					result = (this._IgnoreActors = new TArray<AActor>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_22, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IgnoreActors.CopyAssign(value);
			}
		}

		// Token: 0x17004AE5 RID: 19173
		// (get) Token: 0x060251B0 RID: 151984 RVA: 0x009514C7 File Offset: 0x0094F6C7
		// (set) Token: 0x060251B1 RID: 151985 RVA: 0x009514D7 File Offset: 0x0094F6D7
		public unsafe double Max_Degree_Angle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004AE6 RID: 19174
		// (get) Token: 0x060251B2 RID: 151986 RVA: 0x009514E8 File Offset: 0x0094F6E8
		// (set) Token: 0x060251B3 RID: 151987 RVA: 0x009514F8 File Offset: 0x0094F6F8
		public unsafe double Return_Speed_Degrees_Second
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17004AE7 RID: 19175
		// (get) Token: 0x060251B4 RID: 151988 RVA: 0x00951509 File Offset: 0x0094F709
		// (set) Token: 0x060251B5 RID: 151989 RVA: 0x00951519 File Offset: 0x0094F719
		public unsafe double Follow_Speed_Degrees_Second
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004AE8 RID: 19176
		// (get) Token: 0x060251B6 RID: 151990 RVA: 0x0095152A File Offset: 0x0094F72A
		// (set) Token: 0x060251B7 RID: 151991 RVA: 0x0095153A File Offset: 0x0094F73A
		public unsafe double Min_Active_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004AE9 RID: 19177
		// (get) Token: 0x060251B8 RID: 151992 RVA: 0x0095154B File Offset: 0x0094F74B
		// (set) Token: 0x060251B9 RID: 151993 RVA: 0x0095155B File Offset: 0x0094F75B
		public unsafe double Max_Active_Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004AEA RID: 19178
		// (get) Token: 0x060251BA RID: 151994 RVA: 0x0095156C File Offset: 0x0094F76C
		// (set) Token: 0x060251BB RID: 151995 RVA: 0x0095157C File Offset: 0x0094F77C
		public unsafe bool Enable跷跷板
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AEB RID: 19179
		// (get) Token: 0x060251BC RID: 151996 RVA: 0x0095158D File Offset: 0x0094F78D
		// (set) Token: 0x060251BD RID: 151997 RVA: 0x0095159D File Offset: 0x0094F79D
		public unsafe float RayCastingDetectMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004AEC RID: 19180
		// (get) Token: 0x060251BE RID: 151998 RVA: 0x009515AE File Offset: 0x0094F7AE
		// (set) Token: 0x060251BF RID: 151999 RVA: 0x009515C2 File Offset: 0x0094F7C2
		public unsafe FVector startWorldPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004AED RID: 19181
		// (get) Token: 0x060251C0 RID: 152000 RVA: 0x009515D7 File Offset: 0x0094F7D7
		// (set) Token: 0x060251C1 RID: 152001 RVA: 0x009515E7 File Offset: 0x0094F7E7
		public unsafe bool DebugMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AEE RID: 19182
		// (get) Token: 0x060251C2 RID: 152002 RVA: 0x009515F8 File Offset: 0x0094F7F8
		// (set) Token: 0x060251C3 RID: 152003 RVA: 0x00951608 File Offset: 0x0094F808
		public unsafe bool bEditorT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_32) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_32) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AEF RID: 19183
		// (get) Token: 0x060251C4 RID: 152004 RVA: 0x00951619 File Offset: 0x0094F819
		// (set) Token: 0x060251C5 RID: 152005 RVA: 0x00951629 File Offset: 0x0094F829
		public unsafe bool bdebugTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AF0 RID: 19184
		// (get) Token: 0x060251C6 RID: 152006 RVA: 0x0095163A File Offset: 0x0094F83A
		// (set) Token: 0x060251C7 RID: 152007 RVA: 0x0095164E File Offset: 0x0094F84E
		public unsafe UTextureRenderTarget2D cap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x17004AF1 RID: 19185
		// (get) Token: 0x060251C8 RID: 152008 RVA: 0x00951663 File Offset: 0x0094F863
		// (set) Token: 0x060251C9 RID: 152009 RVA: 0x00951677 File Offset: 0x0094F877
		public unsafe UTextureRenderTarget2D final
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x17004AF2 RID: 19186
		// (get) Token: 0x060251CA RID: 152010 RVA: 0x0095168C File Offset: 0x0094F88C
		// (set) Token: 0x060251CB RID: 152011 RVA: 0x009516A0 File Offset: 0x0094F8A0
		public unsafe UMaterialInstanceDynamic DMat_add
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x17004AF3 RID: 19187
		// (get) Token: 0x060251CC RID: 152012 RVA: 0x009516B5 File Offset: 0x0094F8B5
		// (set) Token: 0x060251CD RID: 152013 RVA: 0x009516C9 File Offset: 0x0094F8C9
		public unsafe UMaterialInstanceDynamic DMat_preview
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_37);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_37, value);
			}
		}

		// Token: 0x17004AF4 RID: 19188
		// (get) Token: 0x060251CE RID: 152014 RVA: 0x009516DE File Offset: 0x0094F8DE
		// (set) Token: 0x060251CF RID: 152015 RVA: 0x009516F2 File Offset: 0x0094F8F2
		public unsafe UMaterialInstanceDynamic DMat_preview_ice
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_38);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_38, value);
			}
		}

		// Token: 0x17004AF5 RID: 19189
		// (get) Token: 0x060251D0 RID: 152016 RVA: 0x00951707 File Offset: 0x0094F907
		// (set) Token: 0x060251D1 RID: 152017 RVA: 0x00951717 File Offset: 0x0094F917
		public unsafe bool DoNotNeedRayCasting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AF6 RID: 19190
		// (get) Token: 0x060251D2 RID: 152018 RVA: 0x00951728 File Offset: 0x0094F928
		// (set) Token: 0x060251D3 RID: 152019 RVA: 0x00951738 File Offset: 0x0094F938
		public unsafe int RTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17004AF7 RID: 19191
		// (get) Token: 0x060251D4 RID: 152020 RVA: 0x00951749 File Offset: 0x0094F949
		// (set) Token: 0x060251D5 RID: 152021 RVA: 0x00951759 File Offset: 0x0094F959
		public unsafe bool 是不是冰封状态_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AF8 RID: 19192
		// (get) Token: 0x060251D6 RID: 152022 RVA: 0x0095176A File Offset: 0x0094F96A
		// (set) Token: 0x060251D7 RID: 152023 RVA: 0x0095177A File Offset: 0x0094F97A
		public unsafe bool 锁定碰撞体模式_跷跷板直接关闭_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AF9 RID: 19193
		// (get) Token: 0x060251D8 RID: 152024 RVA: 0x0095178B File Offset: 0x0094F98B
		// (set) Token: 0x060251D9 RID: 152025 RVA: 0x0095179B File Offset: 0x0094F99B
		public unsafe bool 多个光片模式_玩家离开立刻停止跷跷板_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AFA RID: 19194
		// (get) Token: 0x060251DA RID: 152026 RVA: 0x009517AC File Offset: 0x0094F9AC
		// (set) Token: 0x060251DB RID: 152027 RVA: 0x009517C0 File Offset: 0x0094F9C0
		public unsafe FTransform startTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17004AFB RID: 19195
		// (get) Token: 0x060251DC RID: 152028 RVA: 0x009517D5 File Offset: 0x0094F9D5
		// (set) Token: 0x060251DD RID: 152029 RVA: 0x009517E5 File Offset: 0x0094F9E5
		public unsafe float LastFrameRayCastingDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17004AFC RID: 19196
		// (get) Token: 0x060251DE RID: 152030 RVA: 0x009517F6 File Offset: 0x0094F9F6
		// (set) Token: 0x060251DF RID: 152031 RVA: 0x00951806 File Offset: 0x0094FA06
		public unsafe bool LastFrame_是不是冰封状态_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004AFD RID: 19197
		// (get) Token: 0x060251E0 RID: 152032 RVA: 0x00951817 File Offset: 0x0094FA17
		// (set) Token: 0x060251E1 RID: 152033 RVA: 0x0095182B File Offset: 0x0094FA2B
		public unsafe AStaticMeshActor actorBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_47);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_47, value);
			}
		}

		// Token: 0x17004AFE RID: 19198
		// (get) Token: 0x060251E2 RID: 152034 RVA: 0x00951840 File Offset: 0x0094FA40
		// (set) Token: 0x060251E3 RID: 152035 RVA: 0x00951879 File Offset: 0x0094FA79
		[Nullable(1)]
		public TArray<FVector> SkipTraceBoxOrigins
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._SkipTraceBoxOrigins) == null)
				{
					result = (this._SkipTraceBoxOrigins = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_48, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkipTraceBoxOrigins.CopyAssign(value);
			}
		}

		// Token: 0x17004AFF RID: 19199
		// (get) Token: 0x060251E4 RID: 152036 RVA: 0x00951888 File Offset: 0x0094FA88
		// (set) Token: 0x060251E5 RID: 152037 RVA: 0x009518C1 File Offset: 0x0094FAC1
		[Nullable(1)]
		public TArray<FVector> SkipTraceBoxExtent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._SkipTraceBoxExtent) == null)
				{
					result = (this._SkipTraceBoxExtent = new TArray<FVector>(base.NativePtr + (IntPtr)BP_cpuRayCasting_vertex_C.__PropertyOffset_49, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SkipTraceBoxExtent.CopyAssign(value);
			}
		}

		// Token: 0x17004B00 RID: 19200
		// (get) Token: 0x060251E6 RID: 152038 RVA: 0x009518CF File Offset: 0x0094FACF
		// (set) Token: 0x060251E7 RID: 152039 RVA: 0x009518E3 File Offset: 0x0094FAE3
		public unsafe PD_EntityIDToBoxArr_C DataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PD_EntityIDToBoxArr_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_50);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_cpuRayCasting_vertex_C.__PropertyOffset_50, value);
			}
		}

		// Token: 0x060251E8 RID: 152040 RVA: 0x009518F8 File Offset: 0x0094FAF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetHandle(ref int Handle)
		{
			BP_cpuRayCasting_vertex_C.__GetHandle_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__GetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x060251E9 RID: 152041 RVA: 0x00951947 File Offset: 0x0094FB47
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void boxcollisionConst()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__boxcollisionConst_NativeFunctionPtr, null);
		}

		// Token: 0x060251EA RID: 152042 RVA: 0x0095195C File Offset: 0x0094FB5C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Rotate_Plane_by_Player(bool OnPlaneOrNot, bool StopPlaneReturn)
		{
			BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_FunctionParams[(UIntPtr)1551] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OnPlaneOrNot = OnPlaneOrNot;
			ptr->StopPlaneReturn = StopPlaneReturn;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__Rotate_Plane_by_Player_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060251EB RID: 152043 RVA: 0x009519AC File Offset: 0x0094FBAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DebugMovement(float dt)
		{
			BP_cpuRayCasting_vertex_C.__DebugMovement_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__DebugMovement_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__DebugMovement_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__DebugMovement_NativeFunctionPtr, (void*)ptr, 1);
			ptr->dt = dt;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__DebugMovement_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060251EC RID: 152044 RVA: 0x009519F5 File Offset: 0x0094FBF5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_All()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__Init_All_NativeFunctionPtr, null);
		}

		// Token: 0x060251ED RID: 152045 RVA: 0x00951A09 File Offset: 0x0094FC09
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Init_Triangles()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__Init_Triangles_NativeFunctionPtr, null);
		}

		// Token: 0x060251EE RID: 152046 RVA: 0x00951A1D File Offset: 0x0094FC1D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void initRay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__initRay_NativeFunctionPtr, null);
		}

		// Token: 0x060251EF RID: 152047 RVA: 0x00951A31 File Offset: 0x0094FC31
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060251F0 RID: 152048 RVA: 0x00951A45 File Offset: 0x0094FC45
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060251F1 RID: 152049 RVA: 0x00951A5A File Offset: 0x0094FC5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x060251F2 RID: 152050 RVA: 0x00951A6E File Offset: 0x0094FC6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060251F3 RID: 152051 RVA: 0x00951A84 File Offset: 0x0094FC84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060251F4 RID: 152052 RVA: 0x00951ACC File Offset: 0x0094FCCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060251F5 RID: 152053 RVA: 0x00951B13 File Offset: 0x0094FD13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060251F6 RID: 152054 RVA: 0x00951B27 File Offset: 0x0094FD27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060251F7 RID: 152055 RVA: 0x00951B3C File Offset: 0x0094FD3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CustomEvent1()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__CustomEvent1_NativeFunctionPtr, null);
		}

		// Token: 0x060251F8 RID: 152056 RVA: 0x00951B50 File Offset: 0x0094FD50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__test_NativeFunctionPtr, null);
		}

		// Token: 0x060251F9 RID: 152057 RVA: 0x00951B64 File Offset: 0x0094FD64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SeveralLightPlane()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__SeveralLightPlane_NativeFunctionPtr, null);
		}

		// Token: 0x060251FA RID: 152058 RVA: 0x00951B78 File Offset: 0x0094FD78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x060251FB RID: 152059 RVA: 0x00951B8C File Offset: 0x0094FD8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SaveBoxToBp()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__SaveBoxToBp_NativeFunctionPtr, null);
		}

		// Token: 0x060251FC RID: 152060 RVA: 0x00951BA0 File Offset: 0x0094FDA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetHandle(int Handle)
		{
			BP_cpuRayCasting_vertex_C.__SetHandle_FunctionParams* ptr = stackalloc BP_cpuRayCasting_vertex_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_cpuRayCasting_vertex_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_cpuRayCasting_vertex_C.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060251FD RID: 152061 RVA: 0x00951BE6 File Offset: 0x0094FDE6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SaveBoxArrToDA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_cpuRayCasting_vertex_C.__SaveBoxArrToDA_NativeFunctionPtr, null);
		}

		// Token: 0x060251FE RID: 152062 RVA: 0x00951BFA File Offset: 0x0094FDFA
		protected BP_cpuRayCasting_vertex_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401276E RID: 75630
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/BP_cpuRayCasting_vertex.BP_cpuRayCasting_vertex_C";

		// Token: 0x0401276F RID: 75631
		private static IntPtr _ClassPtr;

		// Token: 0x04012770 RID: 75632
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012771 RID: 75633
		internal static int __PropertyOffset_1;

		// Token: 0x04012772 RID: 75634
		internal static int __PropertyOffset_2;

		// Token: 0x04012773 RID: 75635
		internal static int __PropertyOffset_3;

		// Token: 0x04012774 RID: 75636
		private TArray<FVector> _EndPos;

		// Token: 0x04012775 RID: 75637
		internal static int __PropertyOffset_4;

		// Token: 0x04012776 RID: 75638
		internal static int __PropertyOffset_5;

		// Token: 0x04012777 RID: 75639
		internal static int __PropertyOffset_6;

		// Token: 0x04012778 RID: 75640
		private TArray<FVector> _Vertices;

		// Token: 0x04012779 RID: 75641
		internal static int __PropertyOffset_7;

		// Token: 0x0401277A RID: 75642
		private TArray<int> _triangles;

		// Token: 0x0401277B RID: 75643
		internal static int __PropertyOffset_8;

		// Token: 0x0401277C RID: 75644
		private FSoftObjectPath _EffectNormal;

		// Token: 0x0401277D RID: 75645
		internal static int __PropertyOffset_9;

		// Token: 0x0401277E RID: 75646
		internal static int __PropertyOffset_10;

		// Token: 0x0401277F RID: 75647
		internal static int __PropertyOffset_11;

		// Token: 0x04012780 RID: 75648
		internal static int __PropertyOffset_12;

		// Token: 0x04012781 RID: 75649
		internal static int __PropertyOffset_13;

		// Token: 0x04012782 RID: 75650
		internal static int __PropertyOffset_14;

		// Token: 0x04012783 RID: 75651
		internal static int __PropertyOffset_15;

		// Token: 0x04012784 RID: 75652
		internal static int __PropertyOffset_16;

		// Token: 0x04012785 RID: 75653
		internal static int __PropertyOffset_17;

		// Token: 0x04012786 RID: 75654
		internal static int __PropertyOffset_18;

		// Token: 0x04012787 RID: 75655
		internal static int __PropertyOffset_19;

		// Token: 0x04012788 RID: 75656
		internal static int __PropertyOffset_20;

		// Token: 0x04012789 RID: 75657
		internal static int __PropertyOffset_21;

		// Token: 0x0401278A RID: 75658
		internal static int __PropertyOffset_22;

		// Token: 0x0401278B RID: 75659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _IgnoreActors;

		// Token: 0x0401278C RID: 75660
		internal static int __PropertyOffset_23;

		// Token: 0x0401278D RID: 75661
		internal static int __PropertyOffset_24;

		// Token: 0x0401278E RID: 75662
		internal static int __PropertyOffset_25;

		// Token: 0x0401278F RID: 75663
		internal static int __PropertyOffset_26;

		// Token: 0x04012790 RID: 75664
		internal static int __PropertyOffset_27;

		// Token: 0x04012791 RID: 75665
		internal static int __PropertyOffset_28;

		// Token: 0x04012792 RID: 75666
		internal static int __PropertyOffset_29;

		// Token: 0x04012793 RID: 75667
		internal static int __PropertyOffset_30;

		// Token: 0x04012794 RID: 75668
		internal static int __PropertyOffset_31;

		// Token: 0x04012795 RID: 75669
		internal static int __PropertyOffset_32;

		// Token: 0x04012796 RID: 75670
		internal static int __PropertyOffset_33;

		// Token: 0x04012797 RID: 75671
		internal static int __PropertyOffset_34;

		// Token: 0x04012798 RID: 75672
		internal static int __PropertyOffset_35;

		// Token: 0x04012799 RID: 75673
		internal static int __PropertyOffset_36;

		// Token: 0x0401279A RID: 75674
		internal static int __PropertyOffset_37;

		// Token: 0x0401279B RID: 75675
		internal static int __PropertyOffset_38;

		// Token: 0x0401279C RID: 75676
		internal static int __PropertyOffset_39;

		// Token: 0x0401279D RID: 75677
		internal static int __PropertyOffset_40;

		// Token: 0x0401279E RID: 75678
		internal static int __PropertyOffset_41;

		// Token: 0x0401279F RID: 75679
		internal static int __PropertyOffset_42;

		// Token: 0x040127A0 RID: 75680
		internal static int __PropertyOffset_43;

		// Token: 0x040127A1 RID: 75681
		internal static int __PropertyOffset_44;

		// Token: 0x040127A2 RID: 75682
		internal static int __PropertyOffset_45;

		// Token: 0x040127A3 RID: 75683
		internal static int __PropertyOffset_46;

		// Token: 0x040127A4 RID: 75684
		internal static int __PropertyOffset_47;

		// Token: 0x040127A5 RID: 75685
		internal static int __PropertyOffset_48;

		// Token: 0x040127A6 RID: 75686
		private TArray<FVector> _SkipTraceBoxOrigins;

		// Token: 0x040127A7 RID: 75687
		internal static int __PropertyOffset_49;

		// Token: 0x040127A8 RID: 75688
		private TArray<FVector> _SkipTraceBoxExtent;

		// Token: 0x040127A9 RID: 75689
		internal static int __PropertyOffset_50;

		// Token: 0x040127AA RID: 75690
		private static IntPtr __GetHandle_NativeFunctionPtr;

		// Token: 0x040127AB RID: 75691
		private static IntPtr __boxcollisionConst_NativeFunctionPtr;

		// Token: 0x040127AC RID: 75692
		private static IntPtr __Rotate_Plane_by_Player_NativeFunctionPtr;

		// Token: 0x040127AD RID: 75693
		private static IntPtr __DebugMovement_NativeFunctionPtr;

		// Token: 0x040127AE RID: 75694
		private static IntPtr __Init_All_NativeFunctionPtr;

		// Token: 0x040127AF RID: 75695
		private static IntPtr __Init_Triangles_NativeFunctionPtr;

		// Token: 0x040127B0 RID: 75696
		private static IntPtr __initRay_NativeFunctionPtr;

		// Token: 0x040127B1 RID: 75697
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040127B2 RID: 75698
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x040127B3 RID: 75699
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040127B4 RID: 75700
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040127B5 RID: 75701
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040127B6 RID: 75702
		private static IntPtr __CustomEvent1_NativeFunctionPtr;

		// Token: 0x040127B7 RID: 75703
		private static IntPtr __test_NativeFunctionPtr;

		// Token: 0x040127B8 RID: 75704
		private static IntPtr __SeveralLightPlane_NativeFunctionPtr;

		// Token: 0x040127B9 RID: 75705
		private static IntPtr __RemoveHandle_NativeFunctionPtr;

		// Token: 0x040127BA RID: 75706
		private static IntPtr __SaveBoxToBp_NativeFunctionPtr;

		// Token: 0x040127BB RID: 75707
		private static IntPtr __SetHandle_NativeFunctionPtr;

		// Token: 0x040127BC RID: 75708
		private static IntPtr __SaveBoxArrToDA_NativeFunctionPtr;

		// Token: 0x02009FB0 RID: 40880
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x04031A0F RID: 203279
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02009FB1 RID: 40881
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1536)]
		protected ref struct __Rotate_Plane_by_Player_FunctionParams
		{
			// Token: 0x04031A10 RID: 203280
			[FieldOffset(0)]
			public bool OnPlaneOrNot;

			// Token: 0x04031A11 RID: 203281
			[FieldOffset(1)]
			public bool StopPlaneReturn;
		}

		// Token: 0x02009FB2 RID: 40882
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __DebugMovement_FunctionParams
		{
			// Token: 0x04031A12 RID: 203282
			[FieldOffset(0)]
			public float dt;
		}

		// Token: 0x02009FB3 RID: 40883
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A13 RID: 203283
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FB4 RID: 40884
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x04031A14 RID: 203284
			[FieldOffset(0)]
			public int Handle;
		}
	}
}
