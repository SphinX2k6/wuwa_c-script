using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.KuroTetCubemapLerp
{
	// Token: 0x02003D00 RID: 15616
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/KuroTetCubemapLerp/BP_KuroTetCubemapLerp.BP_KuroTetCubemapLerp_C")]
	[UnrealStructLayout(1392, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1389)]
	public class BP_KuroTetCubemapLerp_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060254DD RID: 152797 RVA: 0x0095672E File Offset: 0x0095492E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroTetCubemapLerp_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/KuroTetCubemapLerp/BP_KuroTetCubemapLerp.BP_KuroTetCubemapLerp_C");
			}
			return BP_KuroTetCubemapLerp_C._ClassPtr;
		}

		// Token: 0x060254DE RID: 152798 RVA: 0x00956754 File Offset: 0x00954954
		public BP_KuroTetCubemapLerp_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroTetCubemapLerp_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060254DF RID: 152799 RVA: 0x0095677C File Offset: 0x0095497C
		[NullableContext(1)]
		public BP_KuroTetCubemapLerp_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroTetCubemapLerp_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BEA RID: 19434
		// (get) Token: 0x060254E0 RID: 152800 RVA: 0x009567AF File Offset: 0x009549AF
		// (set) Token: 0x060254E1 RID: 152801 RVA: 0x009567C3 File Offset: 0x009549C3
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004BEB RID: 19435
		// (get) Token: 0x060254E2 RID: 152802 RVA: 0x009567D8 File Offset: 0x009549D8
		// (set) Token: 0x060254E3 RID: 152803 RVA: 0x00956811 File Offset: 0x00954A11
		[Nullable(1)]
		public TArray<FVector> Points
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FVector>(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_2, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17004BEC RID: 19436
		// (get) Token: 0x060254E4 RID: 152804 RVA: 0x00956820 File Offset: 0x00954A20
		// (set) Token: 0x060254E5 RID: 152805 RVA: 0x00956859 File Offset: 0x00954A59
		[Nullable(1)]
		public TArray<UTexture> Rendertarget
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UTexture> result;
				if ((result = this._Rendertarget) == null)
				{
					result = (this._Rendertarget = new TArray<UTexture>(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Rendertarget.CopyAssign(value);
			}
		}

		// Token: 0x17004BED RID: 19437
		// (get) Token: 0x060254E6 RID: 152806 RVA: 0x00956867 File Offset: 0x00954A67
		// (set) Token: 0x060254E7 RID: 152807 RVA: 0x0095687B File Offset: 0x00954A7B
		public unsafe UTexture CubeRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004BEE RID: 19438
		// (get) Token: 0x060254E8 RID: 152808 RVA: 0x00956890 File Offset: 0x00954A90
		// (set) Token: 0x060254E9 RID: 152809 RVA: 0x009568A4 File Offset: 0x00954AA4
		public unsafe UTexture CubeRT1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004BEF RID: 19439
		// (get) Token: 0x060254EA RID: 152810 RVA: 0x009568B9 File Offset: 0x00954AB9
		// (set) Token: 0x060254EB RID: 152811 RVA: 0x009568CD File Offset: 0x00954ACD
		public unsafe UTexture CubeRT2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004BF0 RID: 19440
		// (get) Token: 0x060254EC RID: 152812 RVA: 0x009568E2 File Offset: 0x00954AE2
		// (set) Token: 0x060254ED RID: 152813 RVA: 0x009568F6 File Offset: 0x00954AF6
		public unsafe UTexture CubeRT3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004BF1 RID: 19441
		// (get) Token: 0x060254EE RID: 152814 RVA: 0x0095690B File Offset: 0x00954B0B
		// (set) Token: 0x060254EF RID: 152815 RVA: 0x0095691B File Offset: 0x00954B1B
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004BF2 RID: 19442
		// (get) Token: 0x060254F0 RID: 152816 RVA: 0x0095692C File Offset: 0x00954B2C
		// (set) Token: 0x060254F1 RID: 152817 RVA: 0x0095693C File Offset: 0x00954B3C
		public unsafe float Weight1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004BF3 RID: 19443
		// (get) Token: 0x060254F2 RID: 152818 RVA: 0x0095694D File Offset: 0x00954B4D
		// (set) Token: 0x060254F3 RID: 152819 RVA: 0x0095695D File Offset: 0x00954B5D
		public unsafe float Weight2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004BF4 RID: 19444
		// (get) Token: 0x060254F4 RID: 152820 RVA: 0x0095696E File Offset: 0x00954B6E
		// (set) Token: 0x060254F5 RID: 152821 RVA: 0x0095697E File Offset: 0x00954B7E
		public unsafe float Weight3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004BF5 RID: 19445
		// (get) Token: 0x060254F6 RID: 152822 RVA: 0x00956990 File Offset: 0x00954B90
		// (set) Token: 0x060254F7 RID: 152823 RVA: 0x009569C9 File Offset: 0x00954BC9
		[Nullable(1)]
		public TArray<AStaticMeshActor> BindMaterialActor
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._BindMaterialActor) == null)
				{
					result = (this._BindMaterialActor = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_12, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BindMaterialActor.CopyAssign(value);
			}
		}

		// Token: 0x17004BF6 RID: 19446
		// (get) Token: 0x060254F8 RID: 152824 RVA: 0x009569D7 File Offset: 0x00954BD7
		// (set) Token: 0x060254F9 RID: 152825 RVA: 0x009569E7 File Offset: 0x00954BE7
		public unsafe float WeightPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004BF7 RID: 19447
		// (get) Token: 0x060254FA RID: 152826 RVA: 0x009569F8 File Offset: 0x00954BF8
		// (set) Token: 0x060254FB RID: 152827 RVA: 0x00956A08 File Offset: 0x00954C08
		public unsafe bool bShowLine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x060254FC RID: 152828 RVA: 0x00956A1C File Offset: 0x00954C1C
		// (set) Token: 0x060254FD RID: 152829 RVA: 0x00956A55 File Offset: 0x00954C55
		[Nullable(1)]
		public TSet<int> tempTetIndices
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._tempTetIndices) == null)
				{
					result = (this._tempTetIndices = new TSet<int>(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_15, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.tempTetIndices.CopyAssign(value);
			}
		}

		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x060254FE RID: 152830 RVA: 0x00956A64 File Offset: 0x00954C64
		// (set) Token: 0x060254FF RID: 152831 RVA: 0x00956A9D File Offset: 0x00954C9D
		[Nullable(1)]
		public TArray<int> TetIndices
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TetIndices) == null)
				{
					result = (this._TetIndices = new TArray<int>(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_16, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TetIndices.CopyAssign(value);
			}
		}

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x06025500 RID: 152832 RVA: 0x00956AAB File Offset: 0x00954CAB
		// (set) Token: 0x06025501 RID: 152833 RVA: 0x00956ABB File Offset: 0x00954CBB
		public unsafe BP_EWorldType Editor_Type
		{
			get
			{
				return (BP_EWorldType)(*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_17));
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_17) = (byte)value;
			}
		}

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x06025502 RID: 152834 RVA: 0x00956ACC File Offset: 0x00954CCC
		// (set) Token: 0x06025503 RID: 152835 RVA: 0x00956AE0 File Offset: 0x00954CE0
		public unsafe AStaticMeshActor SequenceBindActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x06025504 RID: 152836 RVA: 0x00956AF5 File Offset: 0x00954CF5
		// (set) Token: 0x06025505 RID: 152837 RVA: 0x00956B09 File Offset: 0x00954D09
		public unsafe AStaticMeshActor SequenceBindActor_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x06025506 RID: 152838 RVA: 0x00956B1E File Offset: 0x00954D1E
		// (set) Token: 0x06025507 RID: 152839 RVA: 0x00956B32 File Offset: 0x00954D32
		public unsafe AStaticMeshActor SequenceBindActor_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x06025508 RID: 152840 RVA: 0x00956B47 File Offset: 0x00954D47
		// (set) Token: 0x06025509 RID: 152841 RVA: 0x00956B5B File Offset: 0x00954D5B
		public unsafe AStaticMeshActor SequenceBindActor_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x0602550A RID: 152842 RVA: 0x00956B70 File Offset: 0x00954D70
		// (set) Token: 0x0602550B RID: 152843 RVA: 0x00956B84 File Offset: 0x00954D84
		public unsafe AStaticMeshActor SequenceBindActor_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x0602550C RID: 152844 RVA: 0x00956B99 File Offset: 0x00954D99
		// (set) Token: 0x0602550D RID: 152845 RVA: 0x00956BAD File Offset: 0x00954DAD
		public unsafe AStaticMeshActor SequenceBindActor_4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x0602550E RID: 152846 RVA: 0x00956BC2 File Offset: 0x00954DC2
		// (set) Token: 0x0602550F RID: 152847 RVA: 0x00956BD6 File Offset: 0x00954DD6
		public unsafe AStaticMeshActor SequenceBindActor_5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroTetCubemapLerp_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x06025510 RID: 152848 RVA: 0x00956BEB File Offset: 0x00954DEB
		// (set) Token: 0x06025511 RID: 152849 RVA: 0x00956BFB File Offset: 0x00954DFB
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x06025512 RID: 152850 RVA: 0x00956C0C File Offset: 0x00954E0C
		// (set) Token: 0x06025513 RID: 152851 RVA: 0x00956C1C File Offset: 0x00954E1C
		public unsafe int lastSearchIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004C04 RID: 19460
		// (get) Token: 0x06025514 RID: 152852 RVA: 0x00956C2D File Offset: 0x00954E2D
		// (set) Token: 0x06025515 RID: 152853 RVA: 0x00956C3D File Offset: 0x00954E3D
		public unsafe int maxLoopCountPerTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004C05 RID: 19461
		// (get) Token: 0x06025516 RID: 152854 RVA: 0x00956C4E File Offset: 0x00954E4E
		// (set) Token: 0x06025517 RID: 152855 RVA: 0x00956C5E File Offset: 0x00954E5E
		public unsafe int tetCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17004C06 RID: 19462
		// (get) Token: 0x06025518 RID: 152856 RVA: 0x00956C6F File Offset: 0x00954E6F
		// (set) Token: 0x06025519 RID: 152857 RVA: 0x00956C7F File Offset: 0x00954E7F
		public unsafe int nowTetIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004C07 RID: 19463
		// (get) Token: 0x0602551A RID: 152858 RVA: 0x00956C90 File Offset: 0x00954E90
		// (set) Token: 0x0602551B RID: 152859 RVA: 0x00956CA4 File Offset: 0x00954EA4
		public unsafe FVector4 nowTetWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17004C08 RID: 19464
		// (get) Token: 0x0602551C RID: 152860 RVA: 0x00956CB9 File Offset: 0x00954EB9
		// (set) Token: 0x0602551D RID: 152861 RVA: 0x00956CC9 File Offset: 0x00954EC9
		public unsafe bool bNeedUpdateWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C09 RID: 19465
		// (get) Token: 0x0602551E RID: 152862 RVA: 0x00956CDA File Offset: 0x00954EDA
		// (set) Token: 0x0602551F RID: 152863 RVA: 0x00956CEA File Offset: 0x00954EEA
		public unsafe int maxLoopCountPerTick_Mobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17004C0A RID: 19466
		// (get) Token: 0x06025520 RID: 152864 RVA: 0x00956CFB File Offset: 0x00954EFB
		// (set) Token: 0x06025521 RID: 152865 RVA: 0x00956D0B File Offset: 0x00954F0B
		public unsafe int maxLoopCountPerTick_PC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17004C0B RID: 19467
		// (get) Token: 0x06025522 RID: 152866 RVA: 0x00956D1C File Offset: 0x00954F1C
		// (set) Token: 0x06025523 RID: 152867 RVA: 0x00956D2C File Offset: 0x00954F2C
		public unsafe bool bUseMeshMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroTetCubemapLerp_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025524 RID: 152868 RVA: 0x00956D40 File Offset: 0x00954F40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FindNowTetIndex_Opti(FVector P)
		{
			BP_KuroTetCubemapLerp_C.__FindNowTetIndex_Opti_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__FindNowTetIndex_Opti_FunctionParams[(UIntPtr)159] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__FindNowTetIndex_Opti_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__FindNowTetIndex_Opti_NativeFunctionPtr, (void*)ptr, 1);
			ptr->P = P;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__FindNowTetIndex_Opti_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025525 RID: 152869 RVA: 0x00956D89 File Offset: 0x00954F89
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06025526 RID: 152870 RVA: 0x00956DA0 File Offset: 0x00954FA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateActorMat(AStaticMeshActor self2)
		{
			BP_KuroTetCubemapLerp_C.__UpdateActorMat_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__UpdateActorMat_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__UpdateActorMat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__UpdateActorMat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->self2 = ((self2 != null) ? self2.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__UpdateActorMat_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025527 RID: 152871 RVA: 0x00956DF5 File Offset: 0x00954FF5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearPointNumber()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__ClearPointNumber_NativeFunctionPtr, null);
		}

		// Token: 0x06025528 RID: 152872 RVA: 0x00956E09 File Offset: 0x00955009
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ShowPointNumber()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__ShowPointNumber_NativeFunctionPtr, null);
		}

		// Token: 0x06025529 RID: 152873 RVA: 0x00956E20 File Offset: 0x00955020
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FindClosePoint(FVector P, ref int Array_Index)
		{
			BP_KuroTetCubemapLerp_C.__FindClosePoint_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__FindClosePoint_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__FindClosePoint_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__FindClosePoint_NativeFunctionPtr, (void*)ptr, 1);
			ptr->P = P;
			ptr->Array_Index = Array_Index;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__FindClosePoint_NativeFunctionPtr, (void*)ptr);
			Array_Index = ptr->Array_Index;
		}

		// Token: 0x0602552A RID: 152874 RVA: 0x00956E78 File Offset: 0x00955078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual float ScTP(FVector a, FVector b, FVector c)
		{
			BP_KuroTetCubemapLerp_C.__ScTP_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__ScTP_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__ScTP_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__ScTP_NativeFunctionPtr, (void*)ptr, 1);
			ptr->a = a;
			ptr->b = b;
			ptr->c = c;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__ScTP_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0602552B RID: 152875 RVA: 0x00956ED4 File Offset: 0x009550D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetUVWXInTet(FVector A, FVector B, FVector C, FVector D, FVector P, ref FVector4 UVWX)
		{
			BP_KuroTetCubemapLerp_C.__GetUVWXInTet_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__GetUVWXInTet_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__GetUVWXInTet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__GetUVWXInTet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			ptr->C = C;
			ptr->D = D;
			ptr->P = P;
			ptr->UVWX = UVWX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__GetUVWXInTet_NativeFunctionPtr, (void*)ptr);
			UVWX = ptr->UVWX;
		}

		// Token: 0x0602552C RID: 152876 RVA: 0x00956F55 File Offset: 0x00955155
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DrawTet()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__DrawTet_NativeFunctionPtr, null);
		}

		// Token: 0x0602552D RID: 152877 RVA: 0x00956F69 File Offset: 0x00955169
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ImportTetFromMesh()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__ImportTetFromMesh_NativeFunctionPtr, null);
		}

		// Token: 0x0602552E RID: 152878 RVA: 0x00956F7D File Offset: 0x0095517D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearPaint()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__ClearPaint_NativeFunctionPtr, null);
		}

		// Token: 0x0602552F RID: 152879 RVA: 0x00956F91 File Offset: 0x00955191
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x06025530 RID: 152880 RVA: 0x00956FA5 File Offset: 0x009551A5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Material_Parameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__Update_Material_Parameters_NativeFunctionPtr, null);
		}

		// Token: 0x06025531 RID: 152881 RVA: 0x00956FBC File Offset: 0x009551BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FindNowTetIndex(FVector P, ref int Index, ref FVector4 UVWX)
		{
			BP_KuroTetCubemapLerp_C.__FindNowTetIndex_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__FindNowTetIndex_FunctionParams[(UIntPtr)175] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__FindNowTetIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__FindNowTetIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->P = P;
			ptr->Index = Index;
			ptr->UVWX = UVWX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__FindNowTetIndex_NativeFunctionPtr, (void*)ptr);
			Index = ptr->Index;
			UVWX = ptr->UVWX;
		}

		// Token: 0x06025532 RID: 152882 RVA: 0x00957030 File Offset: 0x00955230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalculateWeights(FVector P)
		{
			BP_KuroTetCubemapLerp_C.__CalculateWeights_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__CalculateWeights_FunctionParams[(UIntPtr)463] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__CalculateWeights_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__CalculateWeights_NativeFunctionPtr, (void*)ptr, 1);
			ptr->P = P;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__CalculateWeights_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025533 RID: 152883 RVA: 0x0095707C File Offset: 0x0095527C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool IsInsideTet(FVector P, FVector A, FVector B, FVector C, FVector D, ref FVector4 UVWX)
		{
			BP_KuroTetCubemapLerp_C.__IsInsideTet_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__IsInsideTet_FunctionParams[(UIntPtr)143] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__IsInsideTet_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__IsInsideTet_NativeFunctionPtr, (void*)ptr, 1);
			ptr->P = P;
			ptr->A = A;
			ptr->B = B;
			ptr->C = C;
			ptr->D = D;
			ptr->UVWX = UVWX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__IsInsideTet_NativeFunctionPtr, (void*)ptr);
			UVWX = ptr->UVWX;
			return ptr->__Result;
		}

		// Token: 0x06025534 RID: 152884 RVA: 0x00957103 File Offset: 0x00955303
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025535 RID: 152885 RVA: 0x00957117 File Offset: 0x00955317
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025536 RID: 152886 RVA: 0x0095712C File Offset: 0x0095532C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025537 RID: 152887 RVA: 0x00957140 File Offset: 0x00955340
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025538 RID: 152888 RVA: 0x00957158 File Offset: 0x00955358
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroTetCubemapLerp_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025539 RID: 152889 RVA: 0x009571A0 File Offset: 0x009553A0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroTetCubemapLerp_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroTetCubemapLerp_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroTetCubemapLerp_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroTetCubemapLerp_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroTetCubemapLerp_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602553A RID: 152890 RVA: 0x009571E7 File Offset: 0x009553E7
		protected BP_KuroTetCubemapLerp_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401298B RID: 76171
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/KuroTetCubemapLerp/BP_KuroTetCubemapLerp.BP_KuroTetCubemapLerp_C";

		// Token: 0x0401298C RID: 76172
		private static IntPtr _ClassPtr;

		// Token: 0x0401298D RID: 76173
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401298E RID: 76174
		internal static int __PropertyOffset_1;

		// Token: 0x0401298F RID: 76175
		internal static int __PropertyOffset_2;

		// Token: 0x04012990 RID: 76176
		private TArray<FVector> _Points;

		// Token: 0x04012991 RID: 76177
		internal static int __PropertyOffset_3;

		// Token: 0x04012992 RID: 76178
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UTexture> _Rendertarget;

		// Token: 0x04012993 RID: 76179
		internal static int __PropertyOffset_4;

		// Token: 0x04012994 RID: 76180
		internal static int __PropertyOffset_5;

		// Token: 0x04012995 RID: 76181
		internal static int __PropertyOffset_6;

		// Token: 0x04012996 RID: 76182
		internal static int __PropertyOffset_7;

		// Token: 0x04012997 RID: 76183
		internal static int __PropertyOffset_8;

		// Token: 0x04012998 RID: 76184
		internal static int __PropertyOffset_9;

		// Token: 0x04012999 RID: 76185
		internal static int __PropertyOffset_10;

		// Token: 0x0401299A RID: 76186
		internal static int __PropertyOffset_11;

		// Token: 0x0401299B RID: 76187
		internal static int __PropertyOffset_12;

		// Token: 0x0401299C RID: 76188
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _BindMaterialActor;

		// Token: 0x0401299D RID: 76189
		internal static int __PropertyOffset_13;

		// Token: 0x0401299E RID: 76190
		internal static int __PropertyOffset_14;

		// Token: 0x0401299F RID: 76191
		internal static int __PropertyOffset_15;

		// Token: 0x040129A0 RID: 76192
		private TSet<int> _tempTetIndices;

		// Token: 0x040129A1 RID: 76193
		internal static int __PropertyOffset_16;

		// Token: 0x040129A2 RID: 76194
		private TArray<int> _TetIndices;

		// Token: 0x040129A3 RID: 76195
		internal static int __PropertyOffset_17;

		// Token: 0x040129A4 RID: 76196
		internal static int __PropertyOffset_18;

		// Token: 0x040129A5 RID: 76197
		internal static int __PropertyOffset_19;

		// Token: 0x040129A6 RID: 76198
		internal static int __PropertyOffset_20;

		// Token: 0x040129A7 RID: 76199
		internal static int __PropertyOffset_21;

		// Token: 0x040129A8 RID: 76200
		internal static int __PropertyOffset_22;

		// Token: 0x040129A9 RID: 76201
		internal static int __PropertyOffset_23;

		// Token: 0x040129AA RID: 76202
		internal static int __PropertyOffset_24;

		// Token: 0x040129AB RID: 76203
		internal static int __PropertyOffset_25;

		// Token: 0x040129AC RID: 76204
		internal static int __PropertyOffset_26;

		// Token: 0x040129AD RID: 76205
		internal static int __PropertyOffset_27;

		// Token: 0x040129AE RID: 76206
		internal static int __PropertyOffset_28;

		// Token: 0x040129AF RID: 76207
		internal static int __PropertyOffset_29;

		// Token: 0x040129B0 RID: 76208
		internal static int __PropertyOffset_30;

		// Token: 0x040129B1 RID: 76209
		internal static int __PropertyOffset_31;

		// Token: 0x040129B2 RID: 76210
		internal static int __PropertyOffset_32;

		// Token: 0x040129B3 RID: 76211
		internal static int __PropertyOffset_33;

		// Token: 0x040129B4 RID: 76212
		internal static int __PropertyOffset_34;

		// Token: 0x040129B5 RID: 76213
		private static IntPtr __FindNowTetIndex_Opti_NativeFunctionPtr;

		// Token: 0x040129B6 RID: 76214
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x040129B7 RID: 76215
		private static IntPtr __UpdateActorMat_NativeFunctionPtr;

		// Token: 0x040129B8 RID: 76216
		private static IntPtr __ClearPointNumber_NativeFunctionPtr;

		// Token: 0x040129B9 RID: 76217
		private static IntPtr __ShowPointNumber_NativeFunctionPtr;

		// Token: 0x040129BA RID: 76218
		private static IntPtr __FindClosePoint_NativeFunctionPtr;

		// Token: 0x040129BB RID: 76219
		private static IntPtr __ScTP_NativeFunctionPtr;

		// Token: 0x040129BC RID: 76220
		private static IntPtr __GetUVWXInTet_NativeFunctionPtr;

		// Token: 0x040129BD RID: 76221
		private static IntPtr __DrawTet_NativeFunctionPtr;

		// Token: 0x040129BE RID: 76222
		private static IntPtr __ImportTetFromMesh_NativeFunctionPtr;

		// Token: 0x040129BF RID: 76223
		private static IntPtr __ClearPaint_NativeFunctionPtr;

		// Token: 0x040129C0 RID: 76224
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x040129C1 RID: 76225
		private static IntPtr __Update_Material_Parameters_NativeFunctionPtr;

		// Token: 0x040129C2 RID: 76226
		private static IntPtr __FindNowTetIndex_NativeFunctionPtr;

		// Token: 0x040129C3 RID: 76227
		private static IntPtr __CalculateWeights_NativeFunctionPtr;

		// Token: 0x040129C4 RID: 76228
		private static IntPtr __IsInsideTet_NativeFunctionPtr;

		// Token: 0x040129C5 RID: 76229
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040129C6 RID: 76230
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040129C7 RID: 76231
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009FE2 RID: 40930
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 144)]
		protected ref struct __FindNowTetIndex_Opti_FunctionParams
		{
			// Token: 0x04031A6C RID: 203372
			[FieldOffset(0)]
			public FVector P;
		}

		// Token: 0x02009FE3 RID: 40931
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __UpdateActorMat_FunctionParams
		{
			// Token: 0x04031A6D RID: 203373
			[FieldOffset(0)]
			public IntPtr self2;
		}

		// Token: 0x02009FE4 RID: 40932
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __FindClosePoint_FunctionParams
		{
			// Token: 0x04031A6E RID: 203374
			[FieldOffset(0)]
			public FVector P;

			// Token: 0x04031A6F RID: 203375
			[FieldOffset(12)]
			public int Array_Index;
		}

		// Token: 0x02009FE5 RID: 40933
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __ScTP_FunctionParams
		{
			// Token: 0x04031A70 RID: 203376
			[FieldOffset(0)]
			public FVector a;

			// Token: 0x04031A71 RID: 203377
			[FieldOffset(12)]
			public FVector b;

			// Token: 0x04031A72 RID: 203378
			[FieldOffset(24)]
			public FVector c;

			// Token: 0x04031A73 RID: 203379
			[FieldOffset(36)]
			public float __Result;
		}

		// Token: 0x02009FE6 RID: 40934
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __GetUVWXInTet_FunctionParams
		{
			// Token: 0x04031A74 RID: 203380
			[FieldOffset(0)]
			public FVector A;

			// Token: 0x04031A75 RID: 203381
			[FieldOffset(12)]
			public FVector B;

			// Token: 0x04031A76 RID: 203382
			[FieldOffset(24)]
			public FVector C;

			// Token: 0x04031A77 RID: 203383
			[FieldOffset(36)]
			public FVector D;

			// Token: 0x04031A78 RID: 203384
			[FieldOffset(48)]
			public FVector P;

			// Token: 0x04031A79 RID: 203385
			[FieldOffset(64)]
			public FVector4 UVWX;
		}

		// Token: 0x02009FE7 RID: 40935
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 160)]
		protected ref struct __FindNowTetIndex_FunctionParams
		{
			// Token: 0x04031A7A RID: 203386
			[FieldOffset(0)]
			public FVector P;

			// Token: 0x04031A7B RID: 203387
			[FieldOffset(12)]
			public int Index;

			// Token: 0x04031A7C RID: 203388
			[FieldOffset(16)]
			public FVector4 UVWX;
		}

		// Token: 0x02009FE8 RID: 40936
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 448)]
		protected ref struct __CalculateWeights_FunctionParams
		{
			// Token: 0x04031A7D RID: 203389
			[FieldOffset(0)]
			public FVector P;
		}

		// Token: 0x02009FE9 RID: 40937
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __IsInsideTet_FunctionParams
		{
			// Token: 0x04031A7E RID: 203390
			[FieldOffset(0)]
			public FVector P;

			// Token: 0x04031A7F RID: 203391
			[FieldOffset(12)]
			public FVector A;

			// Token: 0x04031A80 RID: 203392
			[FieldOffset(24)]
			public FVector B;

			// Token: 0x04031A81 RID: 203393
			[FieldOffset(36)]
			public FVector C;

			// Token: 0x04031A82 RID: 203394
			[FieldOffset(48)]
			public FVector D;

			// Token: 0x04031A83 RID: 203395
			[FieldOffset(60)]
			public bool __Result;

			// Token: 0x04031A84 RID: 203396
			[FieldOffset(64)]
			public FVector4 UVWX;
		}

		// Token: 0x02009FEA RID: 40938
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A85 RID: 203397
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
