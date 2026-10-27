using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CB7 RID: 15543
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_genCloth_33_cut.BP_genCloth_33_cut_C")]
	[UnrealStructLayout(1992, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1986)]
	public class BP_genCloth_33_cut_C : AKuroCSGenericCloth_33, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024A3F RID: 150079 RVA: 0x00944AE8 File Offset: 0x00942CE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_genCloth_33_cut_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_genCloth_33_cut.BP_genCloth_33_cut_C");
			}
			return BP_genCloth_33_cut_C._ClassPtr;
		}

		// Token: 0x06024A40 RID: 150080 RVA: 0x00944B0C File Offset: 0x00942D0C
		public BP_genCloth_33_cut_C() : this(BuiltinUtils.AllocNativeUObject(BP_genCloth_33_cut_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024A41 RID: 150081 RVA: 0x00944B34 File Offset: 0x00942D34
		[NullableContext(1)]
		public BP_genCloth_33_cut_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_genCloth_33_cut_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700482A RID: 18474
		// (get) Token: 0x06024A42 RID: 150082 RVA: 0x00944B67 File Offset: 0x00942D67
		// (set) Token: 0x06024A43 RID: 150083 RVA: 0x00944B7B File Offset: 0x00942D7B
		public unsafe UStaticMeshComponent xpbd_test1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700482B RID: 18475
		// (get) Token: 0x06024A44 RID: 150084 RVA: 0x00944B90 File Offset: 0x00942D90
		// (set) Token: 0x06024A45 RID: 150085 RVA: 0x00944BA4 File Offset: 0x00942DA4
		public unsafe UStaticMeshComponent SM_NotClothPart
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700482C RID: 18476
		// (get) Token: 0x06024A46 RID: 150086 RVA: 0x00944BB9 File Offset: 0x00942DB9
		// (set) Token: 0x06024A47 RID: 150087 RVA: 0x00944BCD File Offset: 0x00942DCD
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700482D RID: 18477
		// (get) Token: 0x06024A48 RID: 150088 RVA: 0x00944BE2 File Offset: 0x00942DE2
		// (set) Token: 0x06024A49 RID: 150089 RVA: 0x00944BF6 File Offset: 0x00942DF6
		public unsafe UBoxComponent BoxStopPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x06024A4A RID: 150090 RVA: 0x00944C0B File Offset: 0x00942E0B
		// (set) Token: 0x06024A4B RID: 150091 RVA: 0x00944C1F File Offset: 0x00942E1F
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x06024A4C RID: 150092 RVA: 0x00944C34 File Offset: 0x00942E34
		// (set) Token: 0x06024A4D RID: 150093 RVA: 0x00944C48 File Offset: 0x00942E48
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004830 RID: 18480
		// (get) Token: 0x06024A4E RID: 150094 RVA: 0x00944C5D File Offset: 0x00942E5D
		// (set) Token: 0x06024A4F RID: 150095 RVA: 0x00944C71 File Offset: 0x00942E71
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004831 RID: 18481
		// (get) Token: 0x06024A50 RID: 150096 RVA: 0x00944C86 File Offset: 0x00942E86
		// (set) Token: 0x06024A51 RID: 150097 RVA: 0x00944C9A File Offset: 0x00942E9A
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004832 RID: 18482
		// (get) Token: 0x06024A52 RID: 150098 RVA: 0x00944CAF File Offset: 0x00942EAF
		// (set) Token: 0x06024A53 RID: 150099 RVA: 0x00944CC3 File Offset: 0x00942EC3
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x06024A54 RID: 150100 RVA: 0x00944CD8 File Offset: 0x00942ED8
		// (set) Token: 0x06024A55 RID: 150101 RVA: 0x00944CE8 File Offset: 0x00942EE8
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x06024A56 RID: 150102 RVA: 0x00944CF9 File Offset: 0x00942EF9
		// (set) Token: 0x06024A57 RID: 150103 RVA: 0x00944D0D File Offset: 0x00942F0D
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x06024A58 RID: 150104 RVA: 0x00944D22 File Offset: 0x00942F22
		// (set) Token: 0x06024A59 RID: 150105 RVA: 0x00944D32 File Offset: 0x00942F32
		public unsafe float force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x06024A5A RID: 150106 RVA: 0x00944D43 File Offset: 0x00942F43
		// (set) Token: 0x06024A5B RID: 150107 RVA: 0x00944D53 File Offset: 0x00942F53
		public unsafe bool Pressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x06024A5C RID: 150108 RVA: 0x00944D64 File Offset: 0x00942F64
		// (set) Token: 0x06024A5D RID: 150109 RVA: 0x00944D74 File Offset: 0x00942F74
		public unsafe bool FS_isPhysicSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x06024A5E RID: 150110 RVA: 0x00944D85 File Offset: 0x00942F85
		// (set) Token: 0x06024A5F RID: 150111 RVA: 0x00944D95 File Offset: 0x00942F95
		public unsafe float mass_in_kg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x06024A60 RID: 150112 RVA: 0x00944DA6 File Offset: 0x00942FA6
		// (set) Token: 0x06024A61 RID: 150113 RVA: 0x00944DB6 File Offset: 0x00942FB6
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x06024A62 RID: 150114 RVA: 0x00944DC7 File Offset: 0x00942FC7
		// (set) Token: 0x06024A63 RID: 150115 RVA: 0x00944DD7 File Offset: 0x00942FD7
		public unsafe bool _2DRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700483B RID: 18491
		// (get) Token: 0x06024A64 RID: 150116 RVA: 0x00944DE8 File Offset: 0x00942FE8
		// (set) Token: 0x06024A65 RID: 150117 RVA: 0x00944DF8 File Offset: 0x00942FF8
		public unsafe int XCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700483C RID: 18492
		// (get) Token: 0x06024A66 RID: 150118 RVA: 0x00944E09 File Offset: 0x00943009
		// (set) Token: 0x06024A67 RID: 150119 RVA: 0x00944E19 File Offset: 0x00943019
		public unsafe bool ReadFromBPL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700483D RID: 18493
		// (get) Token: 0x06024A68 RID: 150120 RVA: 0x00944E2A File Offset: 0x0094302A
		// (set) Token: 0x06024A69 RID: 150121 RVA: 0x00944E3A File Offset: 0x0094303A
		public unsafe bool extraOneMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700483E RID: 18494
		// (get) Token: 0x06024A6A RID: 150122 RVA: 0x00944E4B File Offset: 0x0094304B
		// (set) Token: 0x06024A6B RID: 150123 RVA: 0x00944E5F File Offset: 0x0094305F
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x1700483F RID: 18495
		// (get) Token: 0x06024A6C RID: 150124 RVA: 0x00944E74 File Offset: 0x00943074
		// (set) Token: 0x06024A6D RID: 150125 RVA: 0x00944E88 File Offset: 0x00943088
		public unsafe UMaterialInstanceDynamic MID1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17004840 RID: 18496
		// (get) Token: 0x06024A6E RID: 150126 RVA: 0x00944E9D File Offset: 0x0094309D
		// (set) Token: 0x06024A6F RID: 150127 RVA: 0x00944EAD File Offset: 0x009430AD
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004841 RID: 18497
		// (get) Token: 0x06024A70 RID: 150128 RVA: 0x00944EBE File Offset: 0x009430BE
		// (set) Token: 0x06024A71 RID: 150129 RVA: 0x00944ECE File Offset: 0x009430CE
		public unsafe bool UseYCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004842 RID: 18498
		// (get) Token: 0x06024A72 RID: 150130 RVA: 0x00944EDF File Offset: 0x009430DF
		// (set) Token: 0x06024A73 RID: 150131 RVA: 0x00944EEF File Offset: 0x009430EF
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17004843 RID: 18499
		// (get) Token: 0x06024A74 RID: 150132 RVA: 0x00944F00 File Offset: 0x00943100
		// (set) Token: 0x06024A75 RID: 150133 RVA: 0x00944F14 File Offset: 0x00943114
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17004844 RID: 18500
		// (get) Token: 0x06024A76 RID: 150134 RVA: 0x00944F29 File Offset: 0x00943129
		// (set) Token: 0x06024A77 RID: 150135 RVA: 0x00944F3D File Offset: 0x0094313D
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17004845 RID: 18501
		// (get) Token: 0x06024A78 RID: 150136 RVA: 0x00944F52 File Offset: 0x00943152
		// (set) Token: 0x06024A79 RID: 150137 RVA: 0x00944F66 File Offset: 0x00943166
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17004846 RID: 18502
		// (get) Token: 0x06024A7A RID: 150138 RVA: 0x00944F7B File Offset: 0x0094317B
		// (set) Token: 0x06024A7B RID: 150139 RVA: 0x00944F8F File Offset: 0x0094318F
		public unsafe FVector gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004847 RID: 18503
		// (get) Token: 0x06024A7C RID: 150140 RVA: 0x00944FA4 File Offset: 0x009431A4
		// (set) Token: 0x06024A7D RID: 150141 RVA: 0x00944FB4 File Offset: 0x009431B4
		public unsafe bool UseStaticCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004848 RID: 18504
		// (get) Token: 0x06024A7E RID: 150142 RVA: 0x00944FC5 File Offset: 0x009431C5
		// (set) Token: 0x06024A7F RID: 150143 RVA: 0x00944FD9 File Offset: 0x009431D9
		public unsafe UChildActorComponent editorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_31);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_genCloth_33_cut_C.__PropertyOffset_31, value);
			}
		}

		// Token: 0x17004849 RID: 18505
		// (get) Token: 0x06024A80 RID: 150144 RVA: 0x00944FF0 File Offset: 0x009431F0
		// (set) Token: 0x06024A81 RID: 150145 RVA: 0x00945029 File Offset: 0x00943229
		[Nullable(1)]
		public TArray<FKuroCSUnifiedCollider_genericCloth_33> ColArr
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSUnifiedCollider_genericCloth_33> result;
				if ((result = this._ColArr) == null)
				{
					result = (this._ColArr = new TArray<FKuroCSUnifiedCollider_genericCloth_33>(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_32, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ColArr.CopyAssign(value);
			}
		}

		// Token: 0x1700484A RID: 18506
		// (get) Token: 0x06024A82 RID: 150146 RVA: 0x00945037 File Offset: 0x00943237
		// (set) Token: 0x06024A83 RID: 150147 RVA: 0x00945047 File Offset: 0x00943247
		public unsafe bool Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700484B RID: 18507
		// (get) Token: 0x06024A84 RID: 150148 RVA: 0x00945058 File Offset: 0x00943258
		// (set) Token: 0x06024A85 RID: 150149 RVA: 0x00945068 File Offset: 0x00943268
		public unsafe float FadeOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x1700484C RID: 18508
		// (get) Token: 0x06024A86 RID: 150150 RVA: 0x00945079 File Offset: 0x00943279
		// (set) Token: 0x06024A87 RID: 150151 RVA: 0x00945089 File Offset: 0x00943289
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_35) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_35) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700484D RID: 18509
		// (get) Token: 0x06024A88 RID: 150152 RVA: 0x0094509A File Offset: 0x0094329A
		// (set) Token: 0x06024A89 RID: 150153 RVA: 0x009450AA File Offset: 0x009432AA
		public unsafe bool alreadyBuildArr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700484E RID: 18510
		// (get) Token: 0x06024A8A RID: 150154 RVA: 0x009450BB File Offset: 0x009432BB
		// (set) Token: 0x06024A8B RID: 150155 RVA: 0x009450CB File Offset: 0x009432CB
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_37) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_37) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700484F RID: 18511
		// (get) Token: 0x06024A8C RID: 150156 RVA: 0x009450DC File Offset: 0x009432DC
		// (set) Token: 0x06024A8D RID: 150157 RVA: 0x009450EC File Offset: 0x009432EC
		public unsafe bool PlatformCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004850 RID: 18512
		// (get) Token: 0x06024A8E RID: 150158 RVA: 0x009450FD File Offset: 0x009432FD
		// (set) Token: 0x06024A8F RID: 150159 RVA: 0x00945111 File Offset: 0x00943311
		public unsafe FVectorDouble AttackPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17004851 RID: 18513
		// (get) Token: 0x06024A90 RID: 150160 RVA: 0x00945126 File Offset: 0x00943326
		// (set) Token: 0x06024A91 RID: 150161 RVA: 0x0094513A File Offset: 0x0094333A
		public unsafe FVectorDouble PlayerDirectory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17004852 RID: 18514
		// (get) Token: 0x06024A92 RID: 150162 RVA: 0x0094514F File Offset: 0x0094334F
		// (set) Token: 0x06024A93 RID: 150163 RVA: 0x00945163 File Offset: 0x00943363
		public unsafe FVectorDouble PlayerPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17004853 RID: 18515
		// (get) Token: 0x06024A94 RID: 150164 RVA: 0x00945178 File Offset: 0x00943378
		// (set) Token: 0x06024A95 RID: 150165 RVA: 0x00945188 File Offset: 0x00943388
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17004854 RID: 18516
		// (get) Token: 0x06024A96 RID: 150166 RVA: 0x00945199 File Offset: 0x00943399
		// (set) Token: 0x06024A97 RID: 150167 RVA: 0x009451A9 File Offset: 0x009433A9
		public unsafe bool Splited
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_43) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_43) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004855 RID: 18517
		// (get) Token: 0x06024A98 RID: 150168 RVA: 0x009451BC File Offset: 0x009433BC
		// (set) Token: 0x06024A99 RID: 150169 RVA: 0x009451F5 File Offset: 0x009433F5
		[Nullable(1)]
		public TArray<TSoftObjectPtr<UObject>> Staticmesh
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UObject>> result;
				if ((result = this._Staticmesh) == null)
				{
					result = (this._Staticmesh = new TArray<TSoftObjectPtr<UObject>>(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_44, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Staticmesh.CopyAssign(value);
			}
		}

		// Token: 0x17004856 RID: 18518
		// (get) Token: 0x06024A9A RID: 150170 RVA: 0x00945203 File Offset: 0x00943403
		// (set) Token: 0x06024A9B RID: 150171 RVA: 0x00945213 File Offset: 0x00943413
		public unsafe float mytimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17004857 RID: 18519
		// (get) Token: 0x06024A9C RID: 150172 RVA: 0x00945224 File Offset: 0x00943424
		// (set) Token: 0x06024A9D RID: 150173 RVA: 0x00945234 File Offset: 0x00943434
		public unsafe bool startTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_46) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_46) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004858 RID: 18520
		// (get) Token: 0x06024A9E RID: 150174 RVA: 0x00945248 File Offset: 0x00943448
		// (set) Token: 0x06024A9F RID: 150175 RVA: 0x00945281 File Offset: 0x00943481
		[Nullable(1)]
		public TArray<UStaticMesh> Staticmesh_0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._Staticmesh_0) == null)
				{
					result = (this._Staticmesh_0 = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_47, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Staticmesh_0.CopyAssign(value);
			}
		}

		// Token: 0x17004859 RID: 18521
		// (get) Token: 0x06024AA0 RID: 150176 RVA: 0x0094528F File Offset: 0x0094348F
		// (set) Token: 0x06024AA1 RID: 150177 RVA: 0x0094529F File Offset: 0x0094349F
		public unsafe bool MID1_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700485A RID: 18522
		// (get) Token: 0x06024AA2 RID: 150178 RVA: 0x009452B0 File Offset: 0x009434B0
		// (set) Token: 0x06024AA3 RID: 150179 RVA: 0x009452C0 File Offset: 0x009434C0
		public unsafe bool 不需要砍碎
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_genCloth_33_cut_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024AA4 RID: 150180 RVA: 0x009452D1 File Offset: 0x009434D1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06024AA5 RID: 150181 RVA: 0x009452E5 File Offset: 0x009434E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_33_cut_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024AA6 RID: 150182 RVA: 0x009452FA File Offset: 0x009434FA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06024AA7 RID: 150183 RVA: 0x0094530E File Offset: 0x0094350E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_33_cut_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06024AA8 RID: 150184 RVA: 0x00945324 File Offset: 0x00943524
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_genCloth_33_cut_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_genCloth_33_cut_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_genCloth_33_cut_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_cut_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024AA9 RID: 150185 RVA: 0x0094536C File Offset: 0x0094356C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_genCloth_33_cut_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_genCloth_33_cut_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_genCloth_33_cut_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_cut_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_33_cut_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024AAA RID: 150186 RVA: 0x009453B4 File Offset: 0x009435B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_genCloth_33_cut_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_genCloth_33_cut_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_genCloth_33_cut_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_cut_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024AAB RID: 150187 RVA: 0x00945400 File Offset: 0x00943600
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_genCloth_33_cut_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_genCloth_33_cut_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_genCloth_33_cut_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_cut_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_genCloth_33_cut_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06024AAC RID: 150188 RVA: 0x0094544C File Offset: 0x0094364C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024AAD RID: 150189 RVA: 0x00945500 File Offset: 0x00943700
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024AAE RID: 150190 RVA: 0x009455BC File Offset: 0x009437BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024AAF RID: 150191 RVA: 0x00945645 File Offset: 0x00943845
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x06024AB0 RID: 150192 RVA: 0x00945659 File Offset: 0x00943859
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetDeadNode()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__SetDeadNode_NativeFunctionPtr, null);
		}

		// Token: 0x06024AB1 RID: 150193 RVA: 0x00945670 File Offset: 0x00943870
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_genCloth_33_cut_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_genCloth_33_cut_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_genCloth_33_cut_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_genCloth_33_cut_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_genCloth_33_cut_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06024AB2 RID: 150194 RVA: 0x009456D3 File Offset: 0x009438D3
		protected BP_genCloth_33_cut_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012336 RID: 74550
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/BP_genCloth_33_cut.BP_genCloth_33_cut_C";

		// Token: 0x04012337 RID: 74551
		private static IntPtr _ClassPtr;

		// Token: 0x04012338 RID: 74552
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012339 RID: 74553
		internal static int __PropertyOffset_1;

		// Token: 0x0401233A RID: 74554
		internal static int __PropertyOffset_2;

		// Token: 0x0401233B RID: 74555
		internal static int __PropertyOffset_3;

		// Token: 0x0401233C RID: 74556
		internal static int __PropertyOffset_4;

		// Token: 0x0401233D RID: 74557
		internal static int __PropertyOffset_5;

		// Token: 0x0401233E RID: 74558
		internal static int __PropertyOffset_6;

		// Token: 0x0401233F RID: 74559
		internal static int __PropertyOffset_7;

		// Token: 0x04012340 RID: 74560
		internal static int __PropertyOffset_8;

		// Token: 0x04012341 RID: 74561
		internal static int __PropertyOffset_9;

		// Token: 0x04012342 RID: 74562
		internal static int __PropertyOffset_10;

		// Token: 0x04012343 RID: 74563
		internal static int __PropertyOffset_11;

		// Token: 0x04012344 RID: 74564
		internal static int __PropertyOffset_12;

		// Token: 0x04012345 RID: 74565
		internal static int __PropertyOffset_13;

		// Token: 0x04012346 RID: 74566
		internal static int __PropertyOffset_14;

		// Token: 0x04012347 RID: 74567
		internal static int __PropertyOffset_15;

		// Token: 0x04012348 RID: 74568
		internal static int __PropertyOffset_16;

		// Token: 0x04012349 RID: 74569
		internal static int __PropertyOffset_17;

		// Token: 0x0401234A RID: 74570
		internal static int __PropertyOffset_18;

		// Token: 0x0401234B RID: 74571
		internal static int __PropertyOffset_19;

		// Token: 0x0401234C RID: 74572
		internal static int __PropertyOffset_20;

		// Token: 0x0401234D RID: 74573
		internal static int __PropertyOffset_21;

		// Token: 0x0401234E RID: 74574
		internal static int __PropertyOffset_22;

		// Token: 0x0401234F RID: 74575
		internal static int __PropertyOffset_23;

		// Token: 0x04012350 RID: 74576
		internal static int __PropertyOffset_24;

		// Token: 0x04012351 RID: 74577
		internal static int __PropertyOffset_25;

		// Token: 0x04012352 RID: 74578
		internal static int __PropertyOffset_26;

		// Token: 0x04012353 RID: 74579
		internal static int __PropertyOffset_27;

		// Token: 0x04012354 RID: 74580
		internal static int __PropertyOffset_28;

		// Token: 0x04012355 RID: 74581
		internal static int __PropertyOffset_29;

		// Token: 0x04012356 RID: 74582
		internal static int __PropertyOffset_30;

		// Token: 0x04012357 RID: 74583
		internal static int __PropertyOffset_31;

		// Token: 0x04012358 RID: 74584
		internal static int __PropertyOffset_32;

		// Token: 0x04012359 RID: 74585
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSUnifiedCollider_genericCloth_33> _ColArr;

		// Token: 0x0401235A RID: 74586
		internal static int __PropertyOffset_33;

		// Token: 0x0401235B RID: 74587
		internal static int __PropertyOffset_34;

		// Token: 0x0401235C RID: 74588
		internal static int __PropertyOffset_35;

		// Token: 0x0401235D RID: 74589
		internal static int __PropertyOffset_36;

		// Token: 0x0401235E RID: 74590
		internal static int __PropertyOffset_37;

		// Token: 0x0401235F RID: 74591
		internal static int __PropertyOffset_38;

		// Token: 0x04012360 RID: 74592
		internal static int __PropertyOffset_39;

		// Token: 0x04012361 RID: 74593
		internal static int __PropertyOffset_40;

		// Token: 0x04012362 RID: 74594
		internal static int __PropertyOffset_41;

		// Token: 0x04012363 RID: 74595
		internal static int __PropertyOffset_42;

		// Token: 0x04012364 RID: 74596
		internal static int __PropertyOffset_43;

		// Token: 0x04012365 RID: 74597
		internal static int __PropertyOffset_44;

		// Token: 0x04012366 RID: 74598
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UObject>> _Staticmesh;

		// Token: 0x04012367 RID: 74599
		internal static int __PropertyOffset_45;

		// Token: 0x04012368 RID: 74600
		internal static int __PropertyOffset_46;

		// Token: 0x04012369 RID: 74601
		internal static int __PropertyOffset_47;

		// Token: 0x0401236A RID: 74602
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _Staticmesh_0;

		// Token: 0x0401236B RID: 74603
		internal static int __PropertyOffset_48;

		// Token: 0x0401236C RID: 74604
		internal static int __PropertyOffset_49;

		// Token: 0x0401236D RID: 74605
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401236E RID: 74606
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401236F RID: 74607
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012370 RID: 74608
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04012371 RID: 74609
		private static IntPtr __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012372 RID: 74610
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012373 RID: 74611
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04012374 RID: 74612
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04012375 RID: 74613
		private static IntPtr __SetDeadNode_NativeFunctionPtr;

		// Token: 0x04012376 RID: 74614
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x02009F59 RID: 40793
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031933 RID: 203059
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F5A RID: 40794
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031934 RID: 203060
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009F5B RID: 40795
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031935 RID: 203061
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x04031936 RID: 203062
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031937 RID: 203063
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031938 RID: 203064
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x04031939 RID: 203065
			[FieldOffset(36)]
			public byte Hit;
		}

		// Token: 0x02009F5C RID: 40796
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403193A RID: 203066
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403193B RID: 203067
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403193C RID: 203068
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403193D RID: 203069
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403193E RID: 203070
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403193F RID: 203071
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F5D RID: 40797
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031940 RID: 203072
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031941 RID: 203073
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031942 RID: 203074
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031943 RID: 203075
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F5E RID: 40798
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x04031944 RID: 203076
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031945 RID: 203077
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031946 RID: 203078
			[FieldOffset(32)]
			public int Id;
		}
	}
}
