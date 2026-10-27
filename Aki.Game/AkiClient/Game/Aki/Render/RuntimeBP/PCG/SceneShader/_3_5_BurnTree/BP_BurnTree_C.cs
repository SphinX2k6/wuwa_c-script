using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._3_5_BurnTree
{
	// Token: 0x02003C11 RID: 15377
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_5_BurnTree/BP_BurnTree.BP_BurnTree_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class BP_BurnTree_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602328C RID: 144012 RVA: 0x0091BFD1 File Offset: 0x0091A1D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BurnTree_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_5_BurnTree/BP_BurnTree.BP_BurnTree_C");
			}
			return BP_BurnTree_C._ClassPtr;
		}

		// Token: 0x0602328D RID: 144013 RVA: 0x0091BFF8 File Offset: 0x0091A1F8
		public BP_BurnTree_C() : this(BuiltinUtils.AllocNativeUObject(BP_BurnTree_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602328E RID: 144014 RVA: 0x0091C020 File Offset: 0x0091A220
		[NullableContext(1)]
		public BP_BurnTree_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BurnTree_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x0602328F RID: 144015 RVA: 0x0091C053 File Offset: 0x0091A253
		// (set) Token: 0x06023290 RID: 144016 RVA: 0x0091C067 File Offset: 0x0091A267
		public unsafe UNiagaraComponent NS_Tree_Ash
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x06023291 RID: 144017 RVA: 0x0091C07C File Offset: 0x0091A27C
		// (set) Token: 0x06023292 RID: 144018 RVA: 0x0091C090 File Offset: 0x0091A290
		public unsafe UNiagaraComponent NS_TreeFire
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x06023293 RID: 144019 RVA: 0x0091C0A5 File Offset: 0x0091A2A5
		// (set) Token: 0x06023294 RID: 144020 RVA: 0x0091C0B9 File Offset: 0x0091A2B9
		public unsafe USphereComponent CollisionBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x06023295 RID: 144021 RVA: 0x0091C0CE File Offset: 0x0091A2CE
		// (set) Token: 0x06023296 RID: 144022 RVA: 0x0091C0E2 File Offset: 0x0091A2E2
		public unsafe UStaticMeshComponent Tree
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x06023297 RID: 144023 RVA: 0x0091C0F7 File Offset: 0x0091A2F7
		// (set) Token: 0x06023298 RID: 144024 RVA: 0x0091C10B File Offset: 0x0091A30B
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x06023299 RID: 144025 RVA: 0x0091C120 File Offset: 0x0091A320
		// (set) Token: 0x0602329A RID: 144026 RVA: 0x0091C134 File Offset: 0x0091A334
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x0602329B RID: 144027 RVA: 0x0091C149 File Offset: 0x0091A349
		// (set) Token: 0x0602329C RID: 144028 RVA: 0x0091C15D File Offset: 0x0091A35D
		public unsafe BP_WeatherController_C WeatherController
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_WeatherController_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x0602329D RID: 144029 RVA: 0x0091C172 File Offset: 0x0091A372
		// (set) Token: 0x0602329E RID: 144030 RVA: 0x0091C186 File Offset: 0x0091A386
		public unsafe UMaterialInstance Element_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x0602329F RID: 144031 RVA: 0x0091C19B File Offset: 0x0091A39B
		// (set) Token: 0x060232A0 RID: 144032 RVA: 0x0091C1AF File Offset: 0x0091A3AF
		public unsafe UMaterialInstance Element_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x060232A1 RID: 144033 RVA: 0x0091C1C4 File Offset: 0x0091A3C4
		// (set) Token: 0x060232A2 RID: 144034 RVA: 0x0091C1D8 File Offset: 0x0091A3D8
		public unsafe UMaterialInstance Element_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x060232A3 RID: 144035 RVA: 0x0091C1ED File Offset: 0x0091A3ED
		// (set) Token: 0x060232A4 RID: 144036 RVA: 0x0091C201 File Offset: 0x0091A401
		public unsafe UMaterialInstance Element_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x060232A5 RID: 144037 RVA: 0x0091C216 File Offset: 0x0091A416
		// (set) Token: 0x060232A6 RID: 144038 RVA: 0x0091C22A File Offset: 0x0091A42A
		public unsafe UMaterialInstanceDynamic DMI_Element_0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x060232A7 RID: 144039 RVA: 0x0091C23F File Offset: 0x0091A43F
		// (set) Token: 0x060232A8 RID: 144040 RVA: 0x0091C253 File Offset: 0x0091A453
		public unsafe UMaterialInstanceDynamic DMI_Element_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x060232A9 RID: 144041 RVA: 0x0091C268 File Offset: 0x0091A468
		// (set) Token: 0x060232AA RID: 144042 RVA: 0x0091C278 File Offset: 0x0091A478
		public unsafe bool Debug__BurnState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x060232AB RID: 144043 RVA: 0x0091C289 File Offset: 0x0091A489
		// (set) Token: 0x060232AC RID: 144044 RVA: 0x0091C299 File Offset: 0x0091A499
		public unsafe float Delta_Scond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x060232AD RID: 144045 RVA: 0x0091C2AA File Offset: 0x0091A4AA
		// (set) Token: 0x060232AE RID: 144046 RVA: 0x0091C2BA File Offset: 0x0091A4BA
		public unsafe float SpreadTime_Niagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x060232AF RID: 144047 RVA: 0x0091C2CB File Offset: 0x0091A4CB
		// (set) Token: 0x060232B0 RID: 144048 RVA: 0x0091C2DB File Offset: 0x0091A4DB
		public unsafe float SpreadSpeed_Niagara
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x060232B1 RID: 144049 RVA: 0x0091C2EC File Offset: 0x0091A4EC
		// (set) Token: 0x060232B2 RID: 144050 RVA: 0x0091C2FC File Offset: 0x0091A4FC
		public unsafe float SpeedTimeLinear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x060232B3 RID: 144051 RVA: 0x0091C30D File Offset: 0x0091A50D
		// (set) Token: 0x060232B4 RID: 144052 RVA: 0x0091C31D File Offset: 0x0091A51D
		public unsafe float SpeedTimeLinear_Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003FE8 RID: 16360
		// (get) Token: 0x060232B5 RID: 144053 RVA: 0x0091C32E File Offset: 0x0091A52E
		// (set) Token: 0x060232B6 RID: 144054 RVA: 0x0091C342 File Offset: 0x0091A542
		[Nullable(0)]
		public unsafe TEnumAsByte<E_EBurnState> EBurnState
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_20);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x060232B7 RID: 144055 RVA: 0x0091C357 File Offset: 0x0091A557
		// (set) Token: 0x060232B8 RID: 144056 RVA: 0x0091C367 File Offset: 0x0091A567
		public unsafe float BurnTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x060232B9 RID: 144057 RVA: 0x0091C378 File Offset: 0x0091A578
		// (set) Token: 0x060232BA RID: 144058 RVA: 0x0091C388 File Offset: 0x0091A588
		public unsafe float BurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x060232BB RID: 144059 RVA: 0x0091C399 File Offset: 0x0091A599
		// (set) Token: 0x060232BC RID: 144060 RVA: 0x0091C3A9 File Offset: 0x0091A5A9
		public unsafe float BurnDelayThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x060232BD RID: 144061 RVA: 0x0091C3BA File Offset: 0x0091A5BA
		// (set) Token: 0x060232BE RID: 144062 RVA: 0x0091C3CA File Offset: 0x0091A5CA
		public unsafe float Get_Rain_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x060232BF RID: 144063 RVA: 0x0091C3DB File Offset: 0x0091A5DB
		// (set) Token: 0x060232C0 RID: 144064 RVA: 0x0091C3EB File Offset: 0x0091A5EB
		public unsafe float MaterialBurnDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x060232C1 RID: 144065 RVA: 0x0091C3FC File Offset: 0x0091A5FC
		// (set) Token: 0x060232C2 RID: 144066 RVA: 0x0091C40C File Offset: 0x0091A60C
		public unsafe float ParticleFadeValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x060232C3 RID: 144067 RVA: 0x0091C41D File Offset: 0x0091A61D
		// (set) Token: 0x060232C4 RID: 144068 RVA: 0x0091C42D File Offset: 0x0091A62D
		public unsafe float ParticleFadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003FF0 RID: 16368
		// (get) Token: 0x060232C5 RID: 144069 RVA: 0x0091C43E File Offset: 0x0091A63E
		// (set) Token: 0x060232C6 RID: 144070 RVA: 0x0091C44E File Offset: 0x0091A64E
		public unsafe float ParticleFadeVale_Ash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x060232C7 RID: 144071 RVA: 0x0091C45F File Offset: 0x0091A65F
		// (set) Token: 0x060232C8 RID: 144072 RVA: 0x0091C46F File Offset: 0x0091A66F
		public unsafe float ParticleFadeSpeed_Ash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x060232C9 RID: 144073 RVA: 0x0091C480 File Offset: 0x0091A680
		// (set) Token: 0x060232CA RID: 144074 RVA: 0x0091C490 File Offset: 0x0091A690
		public unsafe bool bAshActivated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_30) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_30) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x060232CB RID: 144075 RVA: 0x0091C4A1 File Offset: 0x0091A6A1
		// (set) Token: 0x060232CC RID: 144076 RVA: 0x0091C4B1 File Offset: 0x0091A6B1
		public unsafe float EmberFadeValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x060232CD RID: 144077 RVA: 0x0091C4C2 File Offset: 0x0091A6C2
		// (set) Token: 0x060232CE RID: 144078 RVA: 0x0091C4D2 File Offset: 0x0091A6D2
		public unsafe float EmberFadeSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BurnTree_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x060232CF RID: 144079 RVA: 0x0091C4E3 File Offset: 0x0091A6E3
		// (set) Token: 0x060232D0 RID: 144080 RVA: 0x0091C4F7 File Offset: 0x0091A6F7
		public unsafe UMaterialInstanceDynamic DMI_Element_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_33);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_33, value);
			}
		}

		// Token: 0x17003FF6 RID: 16374
		// (get) Token: 0x060232D1 RID: 144081 RVA: 0x0091C50C File Offset: 0x0091A70C
		// (set) Token: 0x060232D2 RID: 144082 RVA: 0x0091C520 File Offset: 0x0091A720
		public unsafe UMaterialInstanceDynamic DMI_Element_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_34);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_34, value);
			}
		}

		// Token: 0x17003FF7 RID: 16375
		// (get) Token: 0x060232D3 RID: 144083 RVA: 0x0091C535 File Offset: 0x0091A735
		// (set) Token: 0x060232D4 RID: 144084 RVA: 0x0091C549 File Offset: 0x0091A749
		public unsafe UAkAudioEvent Audio_Event
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_35);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BurnTree_C.__PropertyOffset_35, value);
			}
		}

		// Token: 0x060232D5 RID: 144085 RVA: 0x0091C55E File Offset: 0x0091A75E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateEmberFadeValue()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__UpdateEmberFadeValue_NativeFunctionPtr, null);
		}

		// Token: 0x060232D6 RID: 144086 RVA: 0x0091C572 File Offset: 0x0091A772
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParticleFadeParam_Ash()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__UpdateParticleFadeParam_Ash_NativeFunctionPtr, null);
		}

		// Token: 0x060232D7 RID: 144087 RVA: 0x0091C586 File Offset: 0x0091A786
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateParticleFadeParam_Fire()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__UpdateParticleFadeParam_Fire_NativeFunctionPtr, null);
		}

		// Token: 0x060232D8 RID: 144088 RVA: 0x0091C59A File Offset: 0x0091A79A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLeafBurnThreshold()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__UpdateLeafBurnThreshold_NativeFunctionPtr, null);
		}

		// Token: 0x060232D9 RID: 144089 RVA: 0x0091C5AE File Offset: 0x0091A7AE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLeafBurnParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__UpdateLeafBurnParam_NativeFunctionPtr, null);
		}

		// Token: 0x060232DA RID: 144090 RVA: 0x0091C5C2 File Offset: 0x0091A7C2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFireNiagaraParam()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__UpdateFireNiagaraParam_NativeFunctionPtr, null);
		}

		// Token: 0x060232DB RID: 144091 RVA: 0x0091C5D6 File Offset: 0x0091A7D6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ResetBurnState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__ResetBurnState_NativeFunctionPtr, null);
		}

		// Token: 0x060232DC RID: 144092 RVA: 0x0091C5EA File Offset: 0x0091A7EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_StaticMeshAndDMI()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__Set_StaticMeshAndDMI_NativeFunctionPtr, null);
		}

		// Token: 0x060232DD RID: 144093 RVA: 0x0091C5FE File Offset: 0x0091A7FE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060232DE RID: 144094 RVA: 0x0091C612 File Offset: 0x0091A812
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BurnTree_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060232DF RID: 144095 RVA: 0x0091C627 File Offset: 0x0091A827
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060232E0 RID: 144096 RVA: 0x0091C63B File Offset: 0x0091A83B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BurnTree_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060232E1 RID: 144097 RVA: 0x0091C650 File Offset: 0x0091A850
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_BurnTree_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BurnTree_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BurnTree_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BurnTree_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060232E2 RID: 144098 RVA: 0x0091C698 File Offset: 0x0091A898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_BurnTree_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_BurnTree_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BurnTree_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BurnTree_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BurnTree_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060232E3 RID: 144099 RVA: 0x0091C6E0 File Offset: 0x0091A8E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_BurnTree_C.__EditorTick_FunctionParams* ptr = stackalloc BP_BurnTree_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BurnTree_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BurnTree_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060232E4 RID: 144100 RVA: 0x0091C728 File Offset: 0x0091A928
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_BurnTree_C.__EditorTick_FunctionParams* ptr = stackalloc BP_BurnTree_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_BurnTree_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BurnTree_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_BurnTree_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060232E5 RID: 144101 RVA: 0x0091C770 File Offset: 0x0091A970
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060232E6 RID: 144102 RVA: 0x0091C82C File Offset: 0x0091AA2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_BurnTree_C.__BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060232E7 RID: 144103 RVA: 0x0091C8B5 File Offset: 0x0091AAB5
		protected BP_BurnTree_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011537 RID: 70967
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_5_BurnTree/BP_BurnTree.BP_BurnTree_C";

		// Token: 0x04011538 RID: 70968
		private static IntPtr _ClassPtr;

		// Token: 0x04011539 RID: 70969
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401153A RID: 70970
		internal static int __PropertyOffset_1;

		// Token: 0x0401153B RID: 70971
		internal static int __PropertyOffset_2;

		// Token: 0x0401153C RID: 70972
		internal static int __PropertyOffset_3;

		// Token: 0x0401153D RID: 70973
		internal static int __PropertyOffset_4;

		// Token: 0x0401153E RID: 70974
		internal static int __PropertyOffset_5;

		// Token: 0x0401153F RID: 70975
		internal static int __PropertyOffset_6;

		// Token: 0x04011540 RID: 70976
		internal static int __PropertyOffset_7;

		// Token: 0x04011541 RID: 70977
		internal static int __PropertyOffset_8;

		// Token: 0x04011542 RID: 70978
		internal static int __PropertyOffset_9;

		// Token: 0x04011543 RID: 70979
		internal static int __PropertyOffset_10;

		// Token: 0x04011544 RID: 70980
		internal static int __PropertyOffset_11;

		// Token: 0x04011545 RID: 70981
		internal static int __PropertyOffset_12;

		// Token: 0x04011546 RID: 70982
		internal static int __PropertyOffset_13;

		// Token: 0x04011547 RID: 70983
		internal static int __PropertyOffset_14;

		// Token: 0x04011548 RID: 70984
		internal static int __PropertyOffset_15;

		// Token: 0x04011549 RID: 70985
		internal static int __PropertyOffset_16;

		// Token: 0x0401154A RID: 70986
		internal static int __PropertyOffset_17;

		// Token: 0x0401154B RID: 70987
		internal static int __PropertyOffset_18;

		// Token: 0x0401154C RID: 70988
		internal static int __PropertyOffset_19;

		// Token: 0x0401154D RID: 70989
		internal static int __PropertyOffset_20;

		// Token: 0x0401154E RID: 70990
		internal static int __PropertyOffset_21;

		// Token: 0x0401154F RID: 70991
		internal static int __PropertyOffset_22;

		// Token: 0x04011550 RID: 70992
		internal static int __PropertyOffset_23;

		// Token: 0x04011551 RID: 70993
		internal static int __PropertyOffset_24;

		// Token: 0x04011552 RID: 70994
		internal static int __PropertyOffset_25;

		// Token: 0x04011553 RID: 70995
		internal static int __PropertyOffset_26;

		// Token: 0x04011554 RID: 70996
		internal static int __PropertyOffset_27;

		// Token: 0x04011555 RID: 70997
		internal static int __PropertyOffset_28;

		// Token: 0x04011556 RID: 70998
		internal static int __PropertyOffset_29;

		// Token: 0x04011557 RID: 70999
		internal static int __PropertyOffset_30;

		// Token: 0x04011558 RID: 71000
		internal static int __PropertyOffset_31;

		// Token: 0x04011559 RID: 71001
		internal static int __PropertyOffset_32;

		// Token: 0x0401155A RID: 71002
		internal static int __PropertyOffset_33;

		// Token: 0x0401155B RID: 71003
		internal static int __PropertyOffset_34;

		// Token: 0x0401155C RID: 71004
		internal static int __PropertyOffset_35;

		// Token: 0x0401155D RID: 71005
		private static IntPtr __UpdateEmberFadeValue_NativeFunctionPtr;

		// Token: 0x0401155E RID: 71006
		private static IntPtr __UpdateParticleFadeParam_Ash_NativeFunctionPtr;

		// Token: 0x0401155F RID: 71007
		private static IntPtr __UpdateParticleFadeParam_Fire_NativeFunctionPtr;

		// Token: 0x04011560 RID: 71008
		private static IntPtr __UpdateLeafBurnThreshold_NativeFunctionPtr;

		// Token: 0x04011561 RID: 71009
		private static IntPtr __UpdateLeafBurnParam_NativeFunctionPtr;

		// Token: 0x04011562 RID: 71010
		private static IntPtr __UpdateFireNiagaraParam_NativeFunctionPtr;

		// Token: 0x04011563 RID: 71011
		private static IntPtr __ResetBurnState_NativeFunctionPtr;

		// Token: 0x04011564 RID: 71012
		private static IntPtr __Set_StaticMeshAndDMI_NativeFunctionPtr;

		// Token: 0x04011565 RID: 71013
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011566 RID: 71014
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011567 RID: 71015
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011568 RID: 71016
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04011569 RID: 71017
		private static IntPtr __BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0401156A RID: 71018
		private static IntPtr __BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x02009E1E RID: 40478
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031661 RID: 202337
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E1F RID: 40479
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031662 RID: 202338
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009E20 RID: 40480
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031663 RID: 202339
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031664 RID: 202340
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031665 RID: 202341
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031666 RID: 202342
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031667 RID: 202343
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031668 RID: 202344
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E21 RID: 40481
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_BurnTree_Collision_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031669 RID: 202345
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403166A RID: 202346
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403166B RID: 202347
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403166C RID: 202348
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
