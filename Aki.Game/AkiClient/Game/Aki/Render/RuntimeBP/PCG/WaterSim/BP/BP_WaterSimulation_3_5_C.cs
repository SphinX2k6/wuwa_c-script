using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.WaterSim.BP
{
	// Token: 0x02003BD5 RID: 15317
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_3_5.BP_WaterSimulation_3_5_C")]
	[UnrealStructLayout(1856, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1848)]
	public class BP_WaterSimulation_3_5_C : AKuroBPActor, IUnrealUObject, IUnrealObject, INiagaraParticleCallbackHandler, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06022673 RID: 140915 RVA: 0x00907DBC File Offset: 0x00905FBC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterSimulation_3_5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_3_5.BP_WaterSimulation_3_5_C");
			}
			return BP_WaterSimulation_3_5_C._ClassPtr;
		}

		// Token: 0x06022674 RID: 140916 RVA: 0x00907DE0 File Offset: 0x00905FE0
		int INiagaraParticleCallbackHandler.InterfaceOffset()
		{
			return BP_WaterSimulation_3_5_C.__InterfaceOffset_INiagaraParticleCallbackHandler;
		}

		// Token: 0x06022675 RID: 140917 RVA: 0x00907DE8 File Offset: 0x00905FE8
		public BP_WaterSimulation_3_5_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_3_5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022676 RID: 140918 RVA: 0x00907E10 File Offset: 0x00906010
		[NullableContext(1)]
		public BP_WaterSimulation_3_5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterSimulation_3_5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x06022677 RID: 140919 RVA: 0x00907E43 File Offset: 0x00906043
		// (set) Token: 0x06022678 RID: 140920 RVA: 0x00907E57 File Offset: 0x00906057
		public unsafe UBoxComponent WaterInteraction_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003B64 RID: 15204
		// (get) Token: 0x06022679 RID: 140921 RVA: 0x00907E6C File Offset: 0x0090606C
		// (set) Token: 0x0602267A RID: 140922 RVA: 0x00907E80 File Offset: 0x00906080
		public unsafe UStaticMeshComponent WaterInteractionCollision
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x0602267B RID: 140923 RVA: 0x00907E95 File Offset: 0x00906095
		// (set) Token: 0x0602267C RID: 140924 RVA: 0x00907EA9 File Offset: 0x009060A9
		public unsafe UStaticMeshComponent WaterSource
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x0602267D RID: 140925 RVA: 0x00907EBE File Offset: 0x009060BE
		// (set) Token: 0x0602267E RID: 140926 RVA: 0x00907ED2 File Offset: 0x009060D2
		public unsafe UStaticMeshComponent PreView_Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x0602267F RID: 140927 RVA: 0x00907EE7 File Offset: 0x009060E7
		// (set) Token: 0x06022680 RID: 140928 RVA: 0x00907EFB File Offset: 0x009060FB
		public unsafe UBoxComponent Sim_Volume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x06022681 RID: 140929 RVA: 0x00907F10 File Offset: 0x00906110
		// (set) Token: 0x06022682 RID: 140930 RVA: 0x00907F24 File Offset: 0x00906124
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x06022683 RID: 140931 RVA: 0x00907F39 File Offset: 0x00906139
		// (set) Token: 0x06022684 RID: 140932 RVA: 0x00907F49 File Offset: 0x00906149
		public unsafe bool Sim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B6A RID: 15210
		// (get) Token: 0x06022685 RID: 140933 RVA: 0x00907F5A File Offset: 0x0090615A
		// (set) Token: 0x06022686 RID: 140934 RVA: 0x00907F6A File Offset: 0x0090616A
		public unsafe bool SeqControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B6B RID: 15211
		// (get) Token: 0x06022687 RID: 140935 RVA: 0x00907F7B File Offset: 0x0090617B
		// (set) Token: 0x06022688 RID: 140936 RVA: 0x00907F8B File Offset: 0x0090618B
		public unsafe bool DAControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B6C RID: 15212
		// (get) Token: 0x06022689 RID: 140937 RVA: 0x00907F9C File Offset: 0x0090619C
		// (set) Token: 0x0602268A RID: 140938 RVA: 0x00907FB0 File Offset: 0x009061B0
		public unsafe FVector SimBoxOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003B6D RID: 15213
		// (get) Token: 0x0602268B RID: 140939 RVA: 0x00907FC5 File Offset: 0x009061C5
		// (set) Token: 0x0602268C RID: 140940 RVA: 0x00907FD9 File Offset: 0x009061D9
		public unsafe FVector SimBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x0602268D RID: 140941 RVA: 0x00907FEE File Offset: 0x009061EE
		// (set) Token: 0x0602268E RID: 140942 RVA: 0x00907FFE File Offset: 0x009061FE
		public unsafe int SimSize_M_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0602268F RID: 140943 RVA: 0x0090800F File Offset: 0x0090620F
		// (set) Token: 0x06022690 RID: 140944 RVA: 0x00908023 File Offset: 0x00906223
		public unsafe UMaterial M_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x06022691 RID: 140945 RVA: 0x00908038 File Offset: 0x00906238
		// (set) Token: 0x06022692 RID: 140946 RVA: 0x0090804C File Offset: 0x0090624C
		public unsafe UMaterial M_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x06022693 RID: 140947 RVA: 0x00908061 File Offset: 0x00906261
		// (set) Token: 0x06022694 RID: 140948 RVA: 0x00908075 File Offset: 0x00906275
		public unsafe UMaterial M_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003B72 RID: 15218
		// (get) Token: 0x06022695 RID: 140949 RVA: 0x0090808A File Offset: 0x0090628A
		// (set) Token: 0x06022696 RID: 140950 RVA: 0x0090809E File Offset: 0x0090629E
		public unsafe UMaterial M_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17003B73 RID: 15219
		// (get) Token: 0x06022697 RID: 140951 RVA: 0x009080B3 File Offset: 0x009062B3
		// (set) Token: 0x06022698 RID: 140952 RVA: 0x009080C7 File Offset: 0x009062C7
		public unsafe UMaterial M_Water_Clear
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17003B74 RID: 15220
		// (get) Token: 0x06022699 RID: 140953 RVA: 0x009080DC File Offset: 0x009062DC
		// (set) Token: 0x0602269A RID: 140954 RVA: 0x009080F0 File Offset: 0x009062F0
		public unsafe UMaterialInstanceDynamic MI_Velocity
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003B75 RID: 15221
		// (get) Token: 0x0602269B RID: 140955 RVA: 0x00908105 File Offset: 0x00906305
		// (set) Token: 0x0602269C RID: 140956 RVA: 0x00908119 File Offset: 0x00906319
		public unsafe UMaterialInstanceDynamic MI_Height
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17003B76 RID: 15222
		// (get) Token: 0x0602269D RID: 140957 RVA: 0x0090812E File Offset: 0x0090632E
		// (set) Token: 0x0602269E RID: 140958 RVA: 0x00908142 File Offset: 0x00906342
		public unsafe UMaterialInstanceDynamic MI_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x17003B77 RID: 15223
		// (get) Token: 0x0602269F RID: 140959 RVA: 0x00908157 File Offset: 0x00906357
		// (set) Token: 0x060226A0 RID: 140960 RVA: 0x0090816B File Offset: 0x0090636B
		public unsafe UMaterialInstanceDynamic MI_PreView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_21);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_21, value);
			}
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x060226A1 RID: 140961 RVA: 0x00908180 File Offset: 0x00906380
		// (set) Token: 0x060226A2 RID: 140962 RVA: 0x00908194 File Offset: 0x00906394
		public unsafe UTexture RT_HeightMap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_22);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_22, value);
			}
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x060226A3 RID: 140963 RVA: 0x009081A9 File Offset: 0x009063A9
		// (set) Token: 0x060226A4 RID: 140964 RVA: 0x009081BD File Offset: 0x009063BD
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_23);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_23, value);
			}
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x060226A5 RID: 140965 RVA: 0x009081D2 File Offset: 0x009063D2
		// (set) Token: 0x060226A6 RID: 140966 RVA: 0x009081E6 File Offset: 0x009063E6
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Temp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_24);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_24, value);
			}
		}

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x060226A7 RID: 140967 RVA: 0x009081FB File Offset: 0x009063FB
		// (set) Token: 0x060226A8 RID: 140968 RVA: 0x0090820F File Offset: 0x0090640F
		public unsafe UTextureRenderTarget2D RT_Water_VelocityHeightFoam_Blur
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x060226A9 RID: 140969 RVA: 0x00908224 File Offset: 0x00906424
		// (set) Token: 0x060226AA RID: 140970 RVA: 0x00908238 File Offset: 0x00906438
		public unsafe UStaticMeshComponent RenderActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_26);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_26, value);
			}
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x060226AB RID: 140971 RVA: 0x0090824D File Offset: 0x0090644D
		// (set) Token: 0x060226AC RID: 140972 RVA: 0x00908261 File Offset: 0x00906461
		public unsafe UMaterialInterface M_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_27);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_27, value);
			}
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x060226AD RID: 140973 RVA: 0x00908276 File Offset: 0x00906476
		// (set) Token: 0x060226AE RID: 140974 RVA: 0x0090828A File Offset: 0x0090648A
		public unsafe UMaterialInstanceDynamic MI_Water_Render
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x060226AF RID: 140975 RVA: 0x0090829F File Offset: 0x0090649F
		// (set) Token: 0x060226B0 RID: 140976 RVA: 0x009082AF File Offset: 0x009064AF
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x060226B1 RID: 140977 RVA: 0x009082C0 File Offset: 0x009064C0
		// (set) Token: 0x060226B2 RID: 140978 RVA: 0x009082D0 File Offset: 0x009064D0
		public unsafe float DurationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x060226B3 RID: 140979 RVA: 0x009082E1 File Offset: 0x009064E1
		// (set) Token: 0x060226B4 RID: 140980 RVA: 0x009082F5 File Offset: 0x009064F5
		public unsafe FLinearColor WaterSuorcePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x060226B5 RID: 140981 RVA: 0x0090830A File Offset: 0x0090650A
		// (set) Token: 0x060226B6 RID: 140982 RVA: 0x0090831E File Offset: 0x0090651E
		public unsafe FLinearColor WaterSuorcePos1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x060226B7 RID: 140983 RVA: 0x00908333 File Offset: 0x00906533
		// (set) Token: 0x060226B8 RID: 140984 RVA: 0x00908343 File Offset: 0x00906543
		public unsafe float WaterActorHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x060226B9 RID: 140985 RVA: 0x00908354 File Offset: 0x00906554
		// (set) Token: 0x060226BA RID: 140986 RVA: 0x00908364 File Offset: 0x00906564
		public unsafe float PlayerWaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x060226BB RID: 140987 RVA: 0x00908375 File Offset: 0x00906575
		// (set) Token: 0x060226BC RID: 140988 RVA: 0x00908385 File Offset: 0x00906585
		public unsafe float CameraWaterHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x060226BD RID: 140989 RVA: 0x00908396 File Offset: 0x00906596
		// (set) Token: 0x060226BE RID: 140990 RVA: 0x009083AA File Offset: 0x009065AA
		public unsafe FVector PlayerWaterNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x060226BF RID: 140991 RVA: 0x009083BF File Offset: 0x009065BF
		// (set) Token: 0x060226C0 RID: 140992 RVA: 0x009083CF File Offset: 0x009065CF
		public unsafe float PlayerWaterVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x060226C1 RID: 140993 RVA: 0x009083E0 File Offset: 0x009065E0
		// (set) Token: 0x060226C2 RID: 140994 RVA: 0x009083F0 File Offset: 0x009065F0
		public unsafe float CameraWaterVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x060226C3 RID: 140995 RVA: 0x00908401 File Offset: 0x00906601
		// (set) Token: 0x060226C4 RID: 140996 RVA: 0x00908415 File Offset: 0x00906615
		public unsafe FVector CameraWaterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x060226C5 RID: 140997 RVA: 0x0090842A File Offset: 0x0090662A
		// (set) Token: 0x060226C6 RID: 140998 RVA: 0x0090843E File Offset: 0x0090663E
		public unsafe FVector PlayerWaterPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x060226C7 RID: 140999 RVA: 0x00908453 File Offset: 0x00906653
		// (set) Token: 0x060226C8 RID: 141000 RVA: 0x00908463 File Offset: 0x00906663
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x060226C9 RID: 141001 RVA: 0x00908474 File Offset: 0x00906674
		// (set) Token: 0x060226CA RID: 141002 RVA: 0x00908484 File Offset: 0x00906684
		public unsafe float AccelerationClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x060226CB RID: 141003 RVA: 0x00908495 File Offset: 0x00906695
		// (set) Token: 0x060226CC RID: 141004 RVA: 0x009084A5 File Offset: 0x009066A5
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x060226CD RID: 141005 RVA: 0x009084B6 File Offset: 0x009066B6
		// (set) Token: 0x060226CE RID: 141006 RVA: 0x009084C6 File Offset: 0x009066C6
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x060226CF RID: 141007 RVA: 0x009084D7 File Offset: 0x009066D7
		// (set) Token: 0x060226D0 RID: 141008 RVA: 0x009084E7 File Offset: 0x009066E7
		public unsafe float VelocityClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x060226D1 RID: 141009 RVA: 0x009084F8 File Offset: 0x009066F8
		// (set) Token: 0x060226D2 RID: 141010 RVA: 0x00908508 File Offset: 0x00906708
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x060226D3 RID: 141011 RVA: 0x00908519 File Offset: 0x00906719
		// (set) Token: 0x060226D4 RID: 141012 RVA: 0x00908529 File Offset: 0x00906729
		public unsafe int LoopNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x060226D5 RID: 141013 RVA: 0x0090853A File Offset: 0x0090673A
		// (set) Token: 0x060226D6 RID: 141014 RVA: 0x0090854E File Offset: 0x0090674E
		public unsafe BP_GlobalGI_C GlobalGI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_48);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_48, value);
			}
		}

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x060226D7 RID: 141015 RVA: 0x00908563 File Offset: 0x00906763
		// (set) Token: 0x060226D8 RID: 141016 RVA: 0x00908577 File Offset: 0x00906777
		public unsafe BP_HeightmapReadback_C BP_HeightmapReadback
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_HeightmapReadback_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_49);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterSimulation_3_5_C.__PropertyOffset_49, value);
			}
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x060226D9 RID: 141017 RVA: 0x0090858C File Offset: 0x0090678C
		// (set) Token: 0x060226DA RID: 141018 RVA: 0x0090859C File Offset: 0x0090679C
		public unsafe int Readback_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x060226DB RID: 141019 RVA: 0x009085AD File Offset: 0x009067AD
		// (set) Token: 0x060226DC RID: 141020 RVA: 0x009085BD File Offset: 0x009067BD
		public unsafe int Readback_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x060226DD RID: 141021 RVA: 0x009085CE File Offset: 0x009067CE
		// (set) Token: 0x060226DE RID: 141022 RVA: 0x009085DE File Offset: 0x009067DE
		public unsafe float Readback_Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x060226DF RID: 141023 RVA: 0x009085EF File Offset: 0x009067EF
		// (set) Token: 0x060226E0 RID: 141024 RVA: 0x00908603 File Offset: 0x00906803
		public unsafe FVector4 CaptureRangeMax_Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x060226E1 RID: 141025 RVA: 0x00908618 File Offset: 0x00906818
		// (set) Token: 0x060226E2 RID: 141026 RVA: 0x00908628 File Offset: 0x00906828
		public unsafe bool DynamicWaterFlow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_54) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_54) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x060226E3 RID: 141027 RVA: 0x00908639 File Offset: 0x00906839
		// (set) Token: 0x060226E4 RID: 141028 RVA: 0x00908649 File Offset: 0x00906849
		public unsafe bool OverlapVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_55) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_55) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x060226E5 RID: 141029 RVA: 0x0090865A File Offset: 0x0090685A
		// (set) Token: 0x060226E6 RID: 141030 RVA: 0x0090866A File Offset: 0x0090686A
		public unsafe bool Is_Simulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_56) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_56) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x060226E7 RID: 141031 RVA: 0x0090867B File Offset: 0x0090687B
		// (set) Token: 0x060226E8 RID: 141032 RVA: 0x0090868B File Offset: 0x0090688B
		public unsafe float CameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterSimulation_3_5_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x060226E9 RID: 141033 RVA: 0x0090869C File Offset: 0x0090689C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReStartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__ReStartSim_NativeFunctionPtr, null);
		}

		// Token: 0x060226EA RID: 141034 RVA: 0x009086B0 File Offset: 0x009068B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void HideRenderWaterMesh(bool HideRenderWater)
		{
			BP_WaterSimulation_3_5_C.__HideRenderWaterMesh_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__HideRenderWaterMesh_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__HideRenderWaterMesh_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__HideRenderWaterMesh_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HideRenderWater = HideRenderWater;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__HideRenderWaterMesh_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060226EB RID: 141035 RVA: 0x009086F6 File Offset: 0x009068F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CalcHeightmap()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__CalcHeightmap_NativeFunctionPtr, null);
		}

		// Token: 0x060226EC RID: 141036 RVA: 0x0090870A File Offset: 0x0090690A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetMPCParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__SetMPCParameters_NativeFunctionPtr, null);
		}

		// Token: 0x060226ED RID: 141037 RVA: 0x0090871E File Offset: 0x0090691E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__StopSim_NativeFunctionPtr, null);
		}

		// Token: 0x060226EE RID: 141038 RVA: 0x00908732 File Offset: 0x00906932
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartSim()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__StartSim_NativeFunctionPtr, null);
		}

		// Token: 0x060226EF RID: 141039 RVA: 0x00908746 File Offset: 0x00906946
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearWater()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__ClearWater_NativeFunctionPtr, null);
		}

		// Token: 0x060226F0 RID: 141040 RVA: 0x0090875C File Offset: 0x0090695C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetMaterialParameter(UMaterialInterface Material, UTexture VelocityHeightFoam, ref UMaterialInstanceDynamic MaterialInstance)
		{
			BP_WaterSimulation_3_5_C.__SetMaterialParameter_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__SetMaterialParameter_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__SetMaterialParameter_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			ptr->VelocityHeightFoam = ((VelocityHeightFoam != null) ? VelocityHeightFoam.NativePtr : IntPtr.Zero);
			ref BP_WaterSimulation_3_5_C.__SetMaterialParameter_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = MaterialInstance;
			ptr2.MaterialInstance = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__SetMaterialParameter_NativeFunctionPtr, (void*)ptr);
			MaterialInstance = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->MaterialInstance);
		}

		// Token: 0x060226F1 RID: 141041 RVA: 0x009087EC File Offset: 0x009069EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060226F2 RID: 141042 RVA: 0x00908800 File Offset: 0x00906A00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060226F3 RID: 141043 RVA: 0x00908818 File Offset: 0x00906A18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ReceiveParticleData([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_WaterSimulation_3_5_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_WaterSimulation_3_5_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060226F4 RID: 141044 RVA: 0x009088A8 File Offset: 0x00906AA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveParticleData_Implementation([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem)
		{
			BP_WaterSimulation_3_5_C.__ReceiveParticleData_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__ReceiveParticleData_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__ReceiveParticleData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
			object obj = Data;
			if (obj != null)
			{
				obj.MoveTo(&ptr->Data);
			}
			ptr->NiagaraSystem = ((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 0);
			object obj2 = Data;
			if (obj2 != null)
			{
				obj2.MoveAssign(&ptr->Data);
			}
			UnrealReflectionUtils.DestroyStruct(BP_WaterSimulation_3_5_C.__ReceiveParticleData_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060226F5 RID: 141045 RVA: 0x00908937 File Offset: 0x00906B37
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060226F6 RID: 141046 RVA: 0x0090894B File Offset: 0x00906B4B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060226F7 RID: 141047 RVA: 0x00908960 File Offset: 0x00906B60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WaterSimulation_3_5_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060226F8 RID: 141048 RVA: 0x009089A8 File Offset: 0x00906BA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WaterSimulation_3_5_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060226F9 RID: 141049 RVA: 0x009089EF File Offset: 0x00906BEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x060226FA RID: 141050 RVA: 0x00908A04 File Offset: 0x00906C04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060226FB RID: 141051 RVA: 0x00908AC0 File Offset: 0x00906CC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060226FC RID: 141052 RVA: 0x00908B4C File Offset: 0x00906D4C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060226FD RID: 141053 RVA: 0x00908C08 File Offset: 0x00906E08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterSimulation_3_5_C.__BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060226FE RID: 141054 RVA: 0x00908C91 File Offset: 0x00906E91
		protected BP_WaterSimulation_3_5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010E23 RID: 69155
		internal static int __InterfaceOffset_INiagaraParticleCallbackHandler;

		// Token: 0x04010E24 RID: 69156
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/WaterSim/BP/BP_WaterSimulation_3_5.BP_WaterSimulation_3_5_C";

		// Token: 0x04010E25 RID: 69157
		private static IntPtr _ClassPtr;

		// Token: 0x04010E26 RID: 69158
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E27 RID: 69159
		internal static int __PropertyOffset_1;

		// Token: 0x04010E28 RID: 69160
		internal static int __PropertyOffset_2;

		// Token: 0x04010E29 RID: 69161
		internal static int __PropertyOffset_3;

		// Token: 0x04010E2A RID: 69162
		internal static int __PropertyOffset_4;

		// Token: 0x04010E2B RID: 69163
		internal static int __PropertyOffset_5;

		// Token: 0x04010E2C RID: 69164
		internal static int __PropertyOffset_6;

		// Token: 0x04010E2D RID: 69165
		internal static int __PropertyOffset_7;

		// Token: 0x04010E2E RID: 69166
		internal static int __PropertyOffset_8;

		// Token: 0x04010E2F RID: 69167
		internal static int __PropertyOffset_9;

		// Token: 0x04010E30 RID: 69168
		internal static int __PropertyOffset_10;

		// Token: 0x04010E31 RID: 69169
		internal static int __PropertyOffset_11;

		// Token: 0x04010E32 RID: 69170
		internal static int __PropertyOffset_12;

		// Token: 0x04010E33 RID: 69171
		internal static int __PropertyOffset_13;

		// Token: 0x04010E34 RID: 69172
		internal static int __PropertyOffset_14;

		// Token: 0x04010E35 RID: 69173
		internal static int __PropertyOffset_15;

		// Token: 0x04010E36 RID: 69174
		internal static int __PropertyOffset_16;

		// Token: 0x04010E37 RID: 69175
		internal static int __PropertyOffset_17;

		// Token: 0x04010E38 RID: 69176
		internal static int __PropertyOffset_18;

		// Token: 0x04010E39 RID: 69177
		internal static int __PropertyOffset_19;

		// Token: 0x04010E3A RID: 69178
		internal static int __PropertyOffset_20;

		// Token: 0x04010E3B RID: 69179
		internal static int __PropertyOffset_21;

		// Token: 0x04010E3C RID: 69180
		internal static int __PropertyOffset_22;

		// Token: 0x04010E3D RID: 69181
		internal static int __PropertyOffset_23;

		// Token: 0x04010E3E RID: 69182
		internal static int __PropertyOffset_24;

		// Token: 0x04010E3F RID: 69183
		internal static int __PropertyOffset_25;

		// Token: 0x04010E40 RID: 69184
		internal static int __PropertyOffset_26;

		// Token: 0x04010E41 RID: 69185
		internal static int __PropertyOffset_27;

		// Token: 0x04010E42 RID: 69186
		internal static int __PropertyOffset_28;

		// Token: 0x04010E43 RID: 69187
		internal static int __PropertyOffset_29;

		// Token: 0x04010E44 RID: 69188
		internal static int __PropertyOffset_30;

		// Token: 0x04010E45 RID: 69189
		internal static int __PropertyOffset_31;

		// Token: 0x04010E46 RID: 69190
		internal static int __PropertyOffset_32;

		// Token: 0x04010E47 RID: 69191
		internal static int __PropertyOffset_33;

		// Token: 0x04010E48 RID: 69192
		internal static int __PropertyOffset_34;

		// Token: 0x04010E49 RID: 69193
		internal static int __PropertyOffset_35;

		// Token: 0x04010E4A RID: 69194
		internal static int __PropertyOffset_36;

		// Token: 0x04010E4B RID: 69195
		internal static int __PropertyOffset_37;

		// Token: 0x04010E4C RID: 69196
		internal static int __PropertyOffset_38;

		// Token: 0x04010E4D RID: 69197
		internal static int __PropertyOffset_39;

		// Token: 0x04010E4E RID: 69198
		internal static int __PropertyOffset_40;

		// Token: 0x04010E4F RID: 69199
		internal static int __PropertyOffset_41;

		// Token: 0x04010E50 RID: 69200
		internal static int __PropertyOffset_42;

		// Token: 0x04010E51 RID: 69201
		internal static int __PropertyOffset_43;

		// Token: 0x04010E52 RID: 69202
		internal static int __PropertyOffset_44;

		// Token: 0x04010E53 RID: 69203
		internal static int __PropertyOffset_45;

		// Token: 0x04010E54 RID: 69204
		internal static int __PropertyOffset_46;

		// Token: 0x04010E55 RID: 69205
		internal static int __PropertyOffset_47;

		// Token: 0x04010E56 RID: 69206
		internal static int __PropertyOffset_48;

		// Token: 0x04010E57 RID: 69207
		internal static int __PropertyOffset_49;

		// Token: 0x04010E58 RID: 69208
		internal static int __PropertyOffset_50;

		// Token: 0x04010E59 RID: 69209
		internal static int __PropertyOffset_51;

		// Token: 0x04010E5A RID: 69210
		internal static int __PropertyOffset_52;

		// Token: 0x04010E5B RID: 69211
		internal static int __PropertyOffset_53;

		// Token: 0x04010E5C RID: 69212
		internal static int __PropertyOffset_54;

		// Token: 0x04010E5D RID: 69213
		internal static int __PropertyOffset_55;

		// Token: 0x04010E5E RID: 69214
		internal static int __PropertyOffset_56;

		// Token: 0x04010E5F RID: 69215
		internal static int __PropertyOffset_57;

		// Token: 0x04010E60 RID: 69216
		private static IntPtr __ReStartSim_NativeFunctionPtr;

		// Token: 0x04010E61 RID: 69217
		private static IntPtr __HideRenderWaterMesh_NativeFunctionPtr;

		// Token: 0x04010E62 RID: 69218
		private static IntPtr __CalcHeightmap_NativeFunctionPtr;

		// Token: 0x04010E63 RID: 69219
		private static IntPtr __SetMPCParameters_NativeFunctionPtr;

		// Token: 0x04010E64 RID: 69220
		private static IntPtr __StopSim_NativeFunctionPtr;

		// Token: 0x04010E65 RID: 69221
		private static IntPtr __StartSim_NativeFunctionPtr;

		// Token: 0x04010E66 RID: 69222
		private static IntPtr __ClearWater_NativeFunctionPtr;

		// Token: 0x04010E67 RID: 69223
		private static IntPtr __SetMaterialParameter_NativeFunctionPtr;

		// Token: 0x04010E68 RID: 69224
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010E69 RID: 69225
		private static IntPtr __ReceiveParticleData_NativeFunctionPtr;

		// Token: 0x04010E6A RID: 69226
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010E6B RID: 69227
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010E6C RID: 69228
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010E6D RID: 69229
		private static IntPtr __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010E6E RID: 69230
		private static IntPtr __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010E6F RID: 69231
		private static IntPtr __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04010E70 RID: 69232
		private static IntPtr __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009D74 RID: 40308
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HideRenderWaterMesh_FunctionParams
		{
			// Token: 0x040314F4 RID: 201972
			[FieldOffset(0)]
			public bool HideRenderWater;
		}

		// Token: 0x02009D75 RID: 40309
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __SetMaterialParameter_FunctionParams
		{
			// Token: 0x040314F5 RID: 201973
			[FieldOffset(0)]
			public IntPtr Material;

			// Token: 0x040314F6 RID: 201974
			[FieldOffset(8)]
			public IntPtr VelocityHeightFoam;

			// Token: 0x040314F7 RID: 201975
			[FieldOffset(16)]
			public IntPtr MaterialInstance;
		}

		// Token: 0x02009D76 RID: 40310
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ReceiveParticleData_FunctionParams
		{
			// Token: 0x040314F8 RID: 201976
			[FieldOffset(0)]
			public byte Data;

			// Token: 0x040314F9 RID: 201977
			[FieldOffset(16)]
			public IntPtr NiagaraSystem;
		}

		// Token: 0x02009D77 RID: 40311
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040314FA RID: 201978
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D78 RID: 40312
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040314FB RID: 201979
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040314FC RID: 201980
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040314FD RID: 201981
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040314FE RID: 201982
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040314FF RID: 201983
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031500 RID: 201984
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D79 RID: 40313
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterSimulation_Sim_Volume_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031501 RID: 201985
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031502 RID: 201986
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031503 RID: 201987
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031504 RID: 201988
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009D7A RID: 40314
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031505 RID: 201989
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031506 RID: 201990
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031507 RID: 201991
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031508 RID: 201992
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031509 RID: 201993
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403150A RID: 201994
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009D7B RID: 40315
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_WaterSimulation_WaterInteraction_Volume_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403150B RID: 201995
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403150C RID: 201996
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403150D RID: 201997
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403150E RID: 201998
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
