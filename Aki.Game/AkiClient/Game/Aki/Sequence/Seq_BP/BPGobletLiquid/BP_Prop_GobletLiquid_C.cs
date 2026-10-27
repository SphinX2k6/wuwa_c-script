using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP.BPGobletLiquid
{
	// Token: 0x02003A24 RID: 14884
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BPGobletLiquid/BP_Prop_GobletLiquid.BP_Prop_GobletLiquid_C")]
	[UnrealStructLayout(1864, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1864)]
	public class BP_Prop_GobletLiquid_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F48C RID: 128140 RVA: 0x008B42F1 File Offset: 0x008B24F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Prop_GobletLiquid_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BPGobletLiquid/BP_Prop_GobletLiquid.BP_Prop_GobletLiquid_C");
			}
			return BP_Prop_GobletLiquid_C._ClassPtr;
		}

		// Token: 0x0601F48D RID: 128141 RVA: 0x008B4318 File Offset: 0x008B2518
		public BP_Prop_GobletLiquid_C() : this(BuiltinUtils.AllocNativeUObject(BP_Prop_GobletLiquid_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F48E RID: 128142 RVA: 0x008B4340 File Offset: 0x008B2540
		[NullableContext(1)]
		public BP_Prop_GobletLiquid_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Prop_GobletLiquid_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x0601F48F RID: 128143 RVA: 0x008B4373 File Offset: 0x008B2573
		// (set) Token: 0x0601F490 RID: 128144 RVA: 0x008B4387 File Offset: 0x008B2587
		public unsafe UKuroCollectActorComponent KuroCollectActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCollectActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x0601F491 RID: 128145 RVA: 0x008B439C File Offset: 0x008B259C
		// (set) Token: 0x0601F492 RID: 128146 RVA: 0x008B43B0 File Offset: 0x008B25B0
		public unsafe UNiagaraComponent NS_Fx_DrinksIngredients_Fall
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x0601F493 RID: 128147 RVA: 0x008B43C5 File Offset: 0x008B25C5
		// (set) Token: 0x0601F494 RID: 128148 RVA: 0x008B43D9 File Offset: 0x008B25D9
		public unsafe UNiagaraComponent NS_Fx_DrinkOrnament
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x0601F495 RID: 128149 RVA: 0x008B43EE File Offset: 0x008B25EE
		// (set) Token: 0x0601F496 RID: 128150 RVA: 0x008B4402 File Offset: 0x008B2602
		public unsafe UNiagaraComponent NS_Fx_DrinksBatching02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x0601F497 RID: 128151 RVA: 0x008B4417 File Offset: 0x008B2617
		// (set) Token: 0x0601F498 RID: 128152 RVA: 0x008B442B File Offset: 0x008B262B
		public unsafe UNiagaraComponent NS_Fx_DrinksBatching01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x0601F499 RID: 128153 RVA: 0x008B4440 File Offset: 0x008B2640
		// (set) Token: 0x0601F49A RID: 128154 RVA: 0x008B4454 File Offset: 0x008B2654
		public unsafe UNiagaraComponent NS_Fx_Liquid
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x0601F49B RID: 128155 RVA: 0x008B4469 File Offset: 0x008B2669
		// (set) Token: 0x0601F49C RID: 128156 RVA: 0x008B447D File Offset: 0x008B267D
		public unsafe USkeletalMeshComponent Liquid
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x0601F49D RID: 128157 RVA: 0x008B4492 File Offset: 0x008B2692
		// (set) Token: 0x0601F49E RID: 128158 RVA: 0x008B44A6 File Offset: 0x008B26A6
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x0601F49F RID: 128159 RVA: 0x008B44BB File Offset: 0x008B26BB
		// (set) Token: 0x0601F4A0 RID: 128160 RVA: 0x008B44CF File Offset: 0x008B26CF
		public unsafe FLinearColor MainColorPalette
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x0601F4A1 RID: 128161 RVA: 0x008B44E4 File Offset: 0x008B26E4
		// (set) Token: 0x0601F4A2 RID: 128162 RVA: 0x008B44F8 File Offset: 0x008B26F8
		public unsafe FLinearColor WaterLineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x0601F4A3 RID: 128163 RVA: 0x008B450D File Offset: 0x008B270D
		// (set) Token: 0x0601F4A4 RID: 128164 RVA: 0x008B4521 File Offset: 0x008B2721
		public unsafe FLinearColor WaterColor_High
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x0601F4A5 RID: 128165 RVA: 0x008B4536 File Offset: 0x008B2736
		// (set) Token: 0x0601F4A6 RID: 128166 RVA: 0x008B454A File Offset: 0x008B274A
		public unsafe FLinearColor WaterColor_Middle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x0601F4A7 RID: 128167 RVA: 0x008B455F File Offset: 0x008B275F
		// (set) Token: 0x0601F4A8 RID: 128168 RVA: 0x008B4573 File Offset: 0x008B2773
		public unsafe FLinearColor WaterColor_Down
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x0601F4A9 RID: 128169 RVA: 0x008B4588 File Offset: 0x008B2788
		// (set) Token: 0x0601F4AA RID: 128170 RVA: 0x008B459C File Offset: 0x008B279C
		public unsafe FLinearColor FresnelColorAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x0601F4AB RID: 128171 RVA: 0x008B45B1 File Offset: 0x008B27B1
		// (set) Token: 0x0601F4AC RID: 128172 RVA: 0x008B45C1 File Offset: 0x008B27C1
		public unsafe float FresnelRangeWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x0601F4AD RID: 128173 RVA: 0x008B45D2 File Offset: 0x008B27D2
		// (set) Token: 0x0601F4AE RID: 128174 RVA: 0x008B45E2 File Offset: 0x008B27E2
		public unsafe float RefractIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x0601F4AF RID: 128175 RVA: 0x008B45F3 File Offset: 0x008B27F3
		// (set) Token: 0x0601F4B0 RID: 128176 RVA: 0x008B4603 File Offset: 0x008B2803
		public unsafe float WaterRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x0601F4B1 RID: 128177 RVA: 0x008B4614 File Offset: 0x008B2814
		// (set) Token: 0x0601F4B2 RID: 128178 RVA: 0x008B4624 File Offset: 0x008B2824
		public unsafe float WaterMetallic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x0601F4B3 RID: 128179 RVA: 0x008B4635 File Offset: 0x008B2835
		// (set) Token: 0x0601F4B4 RID: 128180 RVA: 0x008B4649 File Offset: 0x008B2849
		public unsafe FLinearColor UPColor_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x0601F4B5 RID: 128181 RVA: 0x008B465E File Offset: 0x008B285E
		// (set) Token: 0x0601F4B6 RID: 128182 RVA: 0x008B4672 File Offset: 0x008B2872
		public unsafe FLinearColor UpLighColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0601F4B7 RID: 128183 RVA: 0x008B4687 File Offset: 0x008B2887
		// (set) Token: 0x0601F4B8 RID: 128184 RVA: 0x008B4697 File Offset: 0x008B2897
		public unsafe float Water_HighProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0601F4B9 RID: 128185 RVA: 0x008B46A8 File Offset: 0x008B28A8
		// (set) Token: 0x0601F4BA RID: 128186 RVA: 0x008B46B8 File Offset: 0x008B28B8
		public unsafe float Water_HighProcess_Seq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0601F4BB RID: 128187 RVA: 0x008B46C9 File Offset: 0x008B28C9
		// (set) Token: 0x0601F4BC RID: 128188 RVA: 0x008B46D9 File Offset: 0x008B28D9
		public unsafe float DrinkBatchPosHeighScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x0601F4BD RID: 128189 RVA: 0x008B46EA File Offset: 0x008B28EA
		// (set) Token: 0x0601F4BE RID: 128190 RVA: 0x008B46FA File Offset: 0x008B28FA
		public unsafe float WaterMaskCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x0601F4BF RID: 128191 RVA: 0x008B470B File Offset: 0x008B290B
		// (set) Token: 0x0601F4C0 RID: 128192 RVA: 0x008B471B File Offset: 0x008B291B
		public unsafe float WaterMaskWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x0601F4C1 RID: 128193 RVA: 0x008B472C File Offset: 0x008B292C
		// (set) Token: 0x0601F4C2 RID: 128194 RVA: 0x008B473C File Offset: 0x008B293C
		public unsafe float WaterColor_MidHighProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x0601F4C3 RID: 128195 RVA: 0x008B474D File Offset: 0x008B294D
		// (set) Token: 0x0601F4C4 RID: 128196 RVA: 0x008B475D File Offset: 0x008B295D
		public unsafe float WaterColor_MidHighWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x0601F4C5 RID: 128197 RVA: 0x008B476E File Offset: 0x008B296E
		// (set) Token: 0x0601F4C6 RID: 128198 RVA: 0x008B477E File Offset: 0x008B297E
		public unsafe float WaterColor_DownMidProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x0601F4C7 RID: 128199 RVA: 0x008B478F File Offset: 0x008B298F
		// (set) Token: 0x0601F4C8 RID: 128200 RVA: 0x008B479F File Offset: 0x008B299F
		public unsafe float WaterColor_DownMidWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x0601F4C9 RID: 128201 RVA: 0x008B47B0 File Offset: 0x008B29B0
		// (set) Token: 0x0601F4CA RID: 128202 RVA: 0x008B47C0 File Offset: 0x008B29C0
		public unsafe float UpLightMask_Process
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x0601F4CB RID: 128203 RVA: 0x008B47D1 File Offset: 0x008B29D1
		// (set) Token: 0x0601F4CC RID: 128204 RVA: 0x008B47E1 File Offset: 0x008B29E1
		public unsafe float BubbleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x0601F4CD RID: 128205 RVA: 0x008B47F2 File Offset: 0x008B29F2
		// (set) Token: 0x0601F4CE RID: 128206 RVA: 0x008B4802 File Offset: 0x008B2A02
		public unsafe float BubbleSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x0601F4CF RID: 128207 RVA: 0x008B4813 File Offset: 0x008B2A13
		// (set) Token: 0x0601F4D0 RID: 128208 RVA: 0x008B4823 File Offset: 0x008B2A23
		public unsafe int DrinkOrnament_Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x0601F4D1 RID: 128209 RVA: 0x008B4834 File Offset: 0x008B2A34
		// (set) Token: 0x0601F4D2 RID: 128210 RVA: 0x008B4844 File Offset: 0x008B2A44
		public unsafe int DrinksBatching_Tag01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x0601F4D3 RID: 128211 RVA: 0x008B4855 File Offset: 0x008B2A55
		// (set) Token: 0x0601F4D4 RID: 128212 RVA: 0x008B4865 File Offset: 0x008B2A65
		public unsafe int DrinksBatching_Tag02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x0601F4D5 RID: 128213 RVA: 0x008B4876 File Offset: 0x008B2A76
		// (set) Token: 0x0601F4D6 RID: 128214 RVA: 0x008B4886 File Offset: 0x008B2A86
		public unsafe int DrinksIngredientsFall_Tag01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x0601F4D7 RID: 128215 RVA: 0x008B4897 File Offset: 0x008B2A97
		// (set) Token: 0x0601F4D8 RID: 128216 RVA: 0x008B48A7 File Offset: 0x008B2AA7
		public unsafe int DrinksIngredientsFall_Tag02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x0601F4D9 RID: 128217 RVA: 0x008B48B8 File Offset: 0x008B2AB8
		// (set) Token: 0x0601F4DA RID: 128218 RVA: 0x008B48CC File Offset: 0x008B2ACC
		public unsafe FVector DrinksIngredientsFall_LocationStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x0601F4DB RID: 128219 RVA: 0x008B48E1 File Offset: 0x008B2AE1
		// (set) Token: 0x0601F4DC RID: 128220 RVA: 0x008B48F1 File Offset: 0x008B2AF1
		public unsafe float Liquid_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x0601F4DD RID: 128221 RVA: 0x008B4902 File Offset: 0x008B2B02
		// (set) Token: 0x0601F4DE RID: 128222 RVA: 0x008B4912 File Offset: 0x008B2B12
		public unsafe float DrinkOrnament_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x0601F4DF RID: 128223 RVA: 0x008B4923 File Offset: 0x008B2B23
		// (set) Token: 0x0601F4E0 RID: 128224 RVA: 0x008B4937 File Offset: 0x008B2B37
		public unsafe FVector DrinkOrnament_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x0601F4E1 RID: 128225 RVA: 0x008B494C File Offset: 0x008B2B4C
		// (set) Token: 0x0601F4E2 RID: 128226 RVA: 0x008B4960 File Offset: 0x008B2B60
		public unsafe FRotator DrinkOrnament_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x0601F4E3 RID: 128227 RVA: 0x008B4975 File Offset: 0x008B2B75
		// (set) Token: 0x0601F4E4 RID: 128228 RVA: 0x008B4985 File Offset: 0x008B2B85
		public unsafe float DrinksBatching_Scale01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17002AB8 RID: 10936
		// (get) Token: 0x0601F4E5 RID: 128229 RVA: 0x008B4996 File Offset: 0x008B2B96
		// (set) Token: 0x0601F4E6 RID: 128230 RVA: 0x008B49A6 File Offset: 0x008B2BA6
		public unsafe float DrinksBatching_Scale02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17002AB9 RID: 10937
		// (get) Token: 0x0601F4E7 RID: 128231 RVA: 0x008B49B7 File Offset: 0x008B2BB7
		// (set) Token: 0x0601F4E8 RID: 128232 RVA: 0x008B49C7 File Offset: 0x008B2BC7
		public unsafe float DrinkBatchPosScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_45);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_45) = value;
			}
		}

		// Token: 0x17002ABA RID: 10938
		// (get) Token: 0x0601F4E9 RID: 128233 RVA: 0x008B49D8 File Offset: 0x008B2BD8
		// (set) Token: 0x0601F4EA RID: 128234 RVA: 0x008B49EC File Offset: 0x008B2BEC
		public unsafe FVector DrinkBatchPosOnLiquid01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17002ABB RID: 10939
		// (get) Token: 0x0601F4EB RID: 128235 RVA: 0x008B4A01 File Offset: 0x008B2C01
		// (set) Token: 0x0601F4EC RID: 128236 RVA: 0x008B4A15 File Offset: 0x008B2C15
		public unsafe FVector DrinkBatchPosOnLiquid02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_47);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_47) = value;
			}
		}

		// Token: 0x17002ABC RID: 10940
		// (get) Token: 0x0601F4ED RID: 128237 RVA: 0x008B4A2A File Offset: 0x008B2C2A
		// (set) Token: 0x0601F4EE RID: 128238 RVA: 0x008B4A3A File Offset: 0x008B2C3A
		public unsafe bool UseLiquidSocketPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_48) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_48) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ABD RID: 10941
		// (get) Token: 0x0601F4EF RID: 128239 RVA: 0x008B4A4B File Offset: 0x008B2C4B
		// (set) Token: 0x0601F4F0 RID: 128240 RVA: 0x008B4A5B File Offset: 0x008B2C5B
		public unsafe bool IsUpdateMPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_49) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_49) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ABE RID: 10942
		// (get) Token: 0x0601F4F1 RID: 128241 RVA: 0x008B4A6C File Offset: 0x008B2C6C
		// (set) Token: 0x0601F4F2 RID: 128242 RVA: 0x008B4A7C File Offset: 0x008B2C7C
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_50) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_50) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x0601F4F3 RID: 128243 RVA: 0x008B4A8D File Offset: 0x008B2C8D
		// (set) Token: 0x0601F4F4 RID: 128244 RVA: 0x008B4AA1 File Offset: 0x008B2CA1
		public unsafe FVectorDouble LiquidLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x0601F4F5 RID: 128245 RVA: 0x008B4AB6 File Offset: 0x008B2CB6
		// (set) Token: 0x0601F4F6 RID: 128246 RVA: 0x008B4ACA File Offset: 0x008B2CCA
		public unsafe FName LiquidSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x0601F4F7 RID: 128247 RVA: 0x008B4ADF File Offset: 0x008B2CDF
		// (set) Token: 0x0601F4F8 RID: 128248 RVA: 0x008B4AF3 File Offset: 0x008B2CF3
		public unsafe FName BatchSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x0601F4F9 RID: 128249 RVA: 0x008B4B08 File Offset: 0x008B2D08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLiquidAndFallTag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UpdateLiquidAndFallTag_NativeFunctionPtr, null);
		}

		// Token: 0x0601F4FA RID: 128250 RVA: 0x008B4B1C File Offset: 0x008B2D1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetBatchLiquidHeight(ref float LiquidHeight)
		{
			BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LiquidHeight = LiquidHeight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_NativeFunctionPtr, (void*)ptr);
			LiquidHeight = ptr->LiquidHeight;
		}

		// Token: 0x0601F4FB RID: 128251 RVA: 0x008B4B6B File Offset: 0x008B2D6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateLiquidMPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UpdateLiquidMPC_NativeFunctionPtr, null);
		}

		// Token: 0x0601F4FC RID: 128252 RVA: 0x008B4B7F File Offset: 0x008B2D7F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayBatchingFallNiagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__PlayBatchingFallNiagara_NativeFunctionPtr, null);
		}

		// Token: 0x0601F4FD RID: 128253 RVA: 0x008B4B93 File Offset: 0x008B2D93
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlayLiquidNiagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__PlayLiquidNiagara_NativeFunctionPtr, null);
		}

		// Token: 0x0601F4FE RID: 128254 RVA: 0x008B4BA7 File Offset: 0x008B2DA7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateGobletLiguid()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UpdateGobletLiguid_NativeFunctionPtr, null);
		}

		// Token: 0x0601F4FF RID: 128255 RVA: 0x008B4BBB File Offset: 0x008B2DBB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601F500 RID: 128256 RVA: 0x008B4BCF File Offset: 0x008B2DCF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601F501 RID: 128257 RVA: 0x008B4BE4 File Offset: 0x008B2DE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F502 RID: 128258 RVA: 0x008B4C2C File Offset: 0x008B2E2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F503 RID: 128259 RVA: 0x008B4C74 File Offset: 0x008B2E74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601F504 RID: 128260 RVA: 0x008B4CBC File Offset: 0x008B2EBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601F505 RID: 128261 RVA: 0x008B4D03 File Offset: 0x008B2F03
		protected BP_Prop_GobletLiquid_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F017 RID: 61463
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BPGobletLiquid/BP_Prop_GobletLiquid.BP_Prop_GobletLiquid_C";

		// Token: 0x0400F018 RID: 61464
		private static IntPtr _ClassPtr;

		// Token: 0x0400F019 RID: 61465
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F01A RID: 61466
		internal static int __PropertyOffset_1;

		// Token: 0x0400F01B RID: 61467
		internal static int __PropertyOffset_2;

		// Token: 0x0400F01C RID: 61468
		internal static int __PropertyOffset_3;

		// Token: 0x0400F01D RID: 61469
		internal static int __PropertyOffset_4;

		// Token: 0x0400F01E RID: 61470
		internal static int __PropertyOffset_5;

		// Token: 0x0400F01F RID: 61471
		internal static int __PropertyOffset_6;

		// Token: 0x0400F020 RID: 61472
		internal static int __PropertyOffset_7;

		// Token: 0x0400F021 RID: 61473
		internal static int __PropertyOffset_8;

		// Token: 0x0400F022 RID: 61474
		internal static int __PropertyOffset_9;

		// Token: 0x0400F023 RID: 61475
		internal static int __PropertyOffset_10;

		// Token: 0x0400F024 RID: 61476
		internal static int __PropertyOffset_11;

		// Token: 0x0400F025 RID: 61477
		internal static int __PropertyOffset_12;

		// Token: 0x0400F026 RID: 61478
		internal static int __PropertyOffset_13;

		// Token: 0x0400F027 RID: 61479
		internal static int __PropertyOffset_14;

		// Token: 0x0400F028 RID: 61480
		internal static int __PropertyOffset_15;

		// Token: 0x0400F029 RID: 61481
		internal static int __PropertyOffset_16;

		// Token: 0x0400F02A RID: 61482
		internal static int __PropertyOffset_17;

		// Token: 0x0400F02B RID: 61483
		internal static int __PropertyOffset_18;

		// Token: 0x0400F02C RID: 61484
		internal static int __PropertyOffset_19;

		// Token: 0x0400F02D RID: 61485
		internal static int __PropertyOffset_20;

		// Token: 0x0400F02E RID: 61486
		internal static int __PropertyOffset_21;

		// Token: 0x0400F02F RID: 61487
		internal static int __PropertyOffset_22;

		// Token: 0x0400F030 RID: 61488
		internal static int __PropertyOffset_23;

		// Token: 0x0400F031 RID: 61489
		internal static int __PropertyOffset_24;

		// Token: 0x0400F032 RID: 61490
		internal static int __PropertyOffset_25;

		// Token: 0x0400F033 RID: 61491
		internal static int __PropertyOffset_26;

		// Token: 0x0400F034 RID: 61492
		internal static int __PropertyOffset_27;

		// Token: 0x0400F035 RID: 61493
		internal static int __PropertyOffset_28;

		// Token: 0x0400F036 RID: 61494
		internal static int __PropertyOffset_29;

		// Token: 0x0400F037 RID: 61495
		internal static int __PropertyOffset_30;

		// Token: 0x0400F038 RID: 61496
		internal static int __PropertyOffset_31;

		// Token: 0x0400F039 RID: 61497
		internal static int __PropertyOffset_32;

		// Token: 0x0400F03A RID: 61498
		internal static int __PropertyOffset_33;

		// Token: 0x0400F03B RID: 61499
		internal static int __PropertyOffset_34;

		// Token: 0x0400F03C RID: 61500
		internal static int __PropertyOffset_35;

		// Token: 0x0400F03D RID: 61501
		internal static int __PropertyOffset_36;

		// Token: 0x0400F03E RID: 61502
		internal static int __PropertyOffset_37;

		// Token: 0x0400F03F RID: 61503
		internal static int __PropertyOffset_38;

		// Token: 0x0400F040 RID: 61504
		internal static int __PropertyOffset_39;

		// Token: 0x0400F041 RID: 61505
		internal static int __PropertyOffset_40;

		// Token: 0x0400F042 RID: 61506
		internal static int __PropertyOffset_41;

		// Token: 0x0400F043 RID: 61507
		internal static int __PropertyOffset_42;

		// Token: 0x0400F044 RID: 61508
		internal static int __PropertyOffset_43;

		// Token: 0x0400F045 RID: 61509
		internal static int __PropertyOffset_44;

		// Token: 0x0400F046 RID: 61510
		internal static int __PropertyOffset_45;

		// Token: 0x0400F047 RID: 61511
		internal static int __PropertyOffset_46;

		// Token: 0x0400F048 RID: 61512
		internal static int __PropertyOffset_47;

		// Token: 0x0400F049 RID: 61513
		internal static int __PropertyOffset_48;

		// Token: 0x0400F04A RID: 61514
		internal static int __PropertyOffset_49;

		// Token: 0x0400F04B RID: 61515
		internal static int __PropertyOffset_50;

		// Token: 0x0400F04C RID: 61516
		internal static int __PropertyOffset_51;

		// Token: 0x0400F04D RID: 61517
		internal static int __PropertyOffset_52;

		// Token: 0x0400F04E RID: 61518
		internal static int __PropertyOffset_53;

		// Token: 0x0400F04F RID: 61519
		private static IntPtr __UpdateLiquidAndFallTag_NativeFunctionPtr;

		// Token: 0x0400F050 RID: 61520
		private static IntPtr __GetBatchLiquidHeight_NativeFunctionPtr;

		// Token: 0x0400F051 RID: 61521
		private static IntPtr __UpdateLiquidMPC_NativeFunctionPtr;

		// Token: 0x0400F052 RID: 61522
		private static IntPtr __PlayBatchingFallNiagara_NativeFunctionPtr;

		// Token: 0x0400F053 RID: 61523
		private static IntPtr __PlayLiquidNiagara_NativeFunctionPtr;

		// Token: 0x0400F054 RID: 61524
		private static IntPtr __UpdateGobletLiguid_NativeFunctionPtr;

		// Token: 0x0400F055 RID: 61525
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F056 RID: 61526
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F057 RID: 61527
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009AB6 RID: 39606
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetBatchLiquidHeight_FunctionParams
		{
			// Token: 0x04031042 RID: 200770
			[FieldOffset(0)]
			public float LiquidHeight;
		}

		// Token: 0x02009AB7 RID: 39607
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031043 RID: 200771
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009AB8 RID: 39608
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031044 RID: 200772
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
