using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Seq_BP.BPGobletLiquid
{
	// Token: 0x02003070 RID: 12400
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Seq_BP/BPGobletLiquid/BP_Prop_GobletLiquid.BP_Prop_GobletLiquid_C")]
	[UnrealStructLayout(1864, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1864)]
	public class BP_Prop_GobletLiquid_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D823 RID: 120867 RVA: 0x008F9C94 File Offset: 0x008F7E94
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Prop_GobletLiquid_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Seq_BP/BPGobletLiquid/BP_Prop_GobletLiquid.BP_Prop_GobletLiquid_C");
			}
			return BP_Prop_GobletLiquid_C._ClassPtr;
		}

		// Token: 0x0601D824 RID: 120868 RVA: 0x008F9CB8 File Offset: 0x008F7EB8
		public BP_Prop_GobletLiquid_C() : this(BuiltinUtils.AllocNativeUObject(BP_Prop_GobletLiquid_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D825 RID: 120869 RVA: 0x008F9CE0 File Offset: 0x008F7EE0
		[NullableContext(1)]
		public BP_Prop_GobletLiquid_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Prop_GobletLiquid_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0601D826 RID: 120870 RVA: 0x008F9D13 File Offset: 0x008F7F13
		// (set) Token: 0x0601D827 RID: 120871 RVA: 0x008F9D27 File Offset: 0x008F7F27
		public unsafe UKuroCollectActorComponent KuroCollectActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCollectActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_KuroCollectActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_KuroCollectActor, value);
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0601D828 RID: 120872 RVA: 0x008F9D3C File Offset: 0x008F7F3C
		// (set) Token: 0x0601D829 RID: 120873 RVA: 0x008F9D50 File Offset: 0x008F7F50
		public unsafe UNiagaraComponent NS_Fx_DrinksIngredients_Fall
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_DrinksIngredients_Fall);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_DrinksIngredients_Fall, value);
			}
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0601D82A RID: 120874 RVA: 0x008F9D65 File Offset: 0x008F7F65
		// (set) Token: 0x0601D82B RID: 120875 RVA: 0x008F9D79 File Offset: 0x008F7F79
		public unsafe UNiagaraComponent NS_Fx_DrinkOrnament
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_DrinkOrnament);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_DrinkOrnament, value);
			}
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x0601D82C RID: 120876 RVA: 0x008F9D8E File Offset: 0x008F7F8E
		// (set) Token: 0x0601D82D RID: 120877 RVA: 0x008F9DA2 File Offset: 0x008F7FA2
		public unsafe UNiagaraComponent NS_Fx_DrinksBatching02
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_DrinksBatching02);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_DrinksBatching02, value);
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x0601D82E RID: 120878 RVA: 0x008F9DB7 File Offset: 0x008F7FB7
		// (set) Token: 0x0601D82F RID: 120879 RVA: 0x008F9DCB File Offset: 0x008F7FCB
		public unsafe UNiagaraComponent NS_Fx_DrinksBatching01
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_DrinksBatching01);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_DrinksBatching01, value);
			}
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x0601D830 RID: 120880 RVA: 0x008F9DE0 File Offset: 0x008F7FE0
		// (set) Token: 0x0601D831 RID: 120881 RVA: 0x008F9DF4 File Offset: 0x008F7FF4
		public unsafe UNiagaraComponent NS_Fx_Liquid
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_Liquid);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_NS_Fx_Liquid, value);
			}
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x0601D832 RID: 120882 RVA: 0x008F9E09 File Offset: 0x008F8009
		// (set) Token: 0x0601D833 RID: 120883 RVA: 0x008F9E1D File Offset: 0x008F801D
		public unsafe USkeletalMeshComponent Liquid
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_Liquid);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_Liquid, value);
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x0601D834 RID: 120884 RVA: 0x008F9E32 File Offset: 0x008F8032
		// (set) Token: 0x0601D835 RID: 120885 RVA: 0x008F9E46 File Offset: 0x008F8046
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Prop_GobletLiquid_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0601D836 RID: 120886 RVA: 0x008F9E5B File Offset: 0x008F805B
		// (set) Token: 0x0601D837 RID: 120887 RVA: 0x008F9E6F File Offset: 0x008F806F
		public unsafe FLinearColor MainColorPalette
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_MainColorPalette);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_MainColorPalette) = value;
			}
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x0601D838 RID: 120888 RVA: 0x008F9E84 File Offset: 0x008F8084
		// (set) Token: 0x0601D839 RID: 120889 RVA: 0x008F9E98 File Offset: 0x008F8098
		public unsafe FLinearColor WaterLineColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterLineColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterLineColor) = value;
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0601D83A RID: 120890 RVA: 0x008F9EAD File Offset: 0x008F80AD
		// (set) Token: 0x0601D83B RID: 120891 RVA: 0x008F9EC1 File Offset: 0x008F80C1
		public unsafe FLinearColor WaterColor_High
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_High);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_High) = value;
			}
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0601D83C RID: 120892 RVA: 0x008F9ED6 File Offset: 0x008F80D6
		// (set) Token: 0x0601D83D RID: 120893 RVA: 0x008F9EEA File Offset: 0x008F80EA
		public unsafe FLinearColor WaterColor_Middle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_Middle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_Middle) = value;
			}
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x0601D83E RID: 120894 RVA: 0x008F9EFF File Offset: 0x008F80FF
		// (set) Token: 0x0601D83F RID: 120895 RVA: 0x008F9F13 File Offset: 0x008F8113
		public unsafe FLinearColor WaterColor_Down
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_Down);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_Down) = value;
			}
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x0601D840 RID: 120896 RVA: 0x008F9F28 File Offset: 0x008F8128
		// (set) Token: 0x0601D841 RID: 120897 RVA: 0x008F9F3C File Offset: 0x008F813C
		public unsafe FLinearColor FresnelColorAdd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_FresnelColorAdd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_FresnelColorAdd) = value;
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x0601D842 RID: 120898 RVA: 0x008F9F51 File Offset: 0x008F8151
		// (set) Token: 0x0601D843 RID: 120899 RVA: 0x008F9F61 File Offset: 0x008F8161
		public unsafe float FresnelRangeWater
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_FresnelRangeWater);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_FresnelRangeWater) = value;
			}
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x0601D844 RID: 120900 RVA: 0x008F9F72 File Offset: 0x008F8172
		// (set) Token: 0x0601D845 RID: 120901 RVA: 0x008F9F82 File Offset: 0x008F8182
		public unsafe float RefractIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_RefractIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_RefractIntensity) = value;
			}
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0601D846 RID: 120902 RVA: 0x008F9F93 File Offset: 0x008F8193
		// (set) Token: 0x0601D847 RID: 120903 RVA: 0x008F9FA3 File Offset: 0x008F81A3
		public unsafe float WaterRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterRoughness) = value;
			}
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x0601D848 RID: 120904 RVA: 0x008F9FB4 File Offset: 0x008F81B4
		// (set) Token: 0x0601D849 RID: 120905 RVA: 0x008F9FC4 File Offset: 0x008F81C4
		public unsafe float WaterMetallic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterMetallic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterMetallic) = value;
			}
		}

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0601D84A RID: 120906 RVA: 0x008F9FD5 File Offset: 0x008F81D5
		// (set) Token: 0x0601D84B RID: 120907 RVA: 0x008F9FE9 File Offset: 0x008F81E9
		public unsafe FLinearColor UPColor_Add
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_UPColor_Add);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_UPColor_Add) = value;
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0601D84C RID: 120908 RVA: 0x008F9FFE File Offset: 0x008F81FE
		// (set) Token: 0x0601D84D RID: 120909 RVA: 0x008FA012 File Offset: 0x008F8212
		public unsafe FLinearColor UpLighColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_UpLighColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_UpLighColor) = value;
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x0601D84E RID: 120910 RVA: 0x008FA027 File Offset: 0x008F8227
		// (set) Token: 0x0601D84F RID: 120911 RVA: 0x008FA037 File Offset: 0x008F8237
		public unsafe float Water_HighProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_Water_HighProcess);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_Water_HighProcess) = value;
			}
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x0601D850 RID: 120912 RVA: 0x008FA048 File Offset: 0x008F8248
		// (set) Token: 0x0601D851 RID: 120913 RVA: 0x008FA058 File Offset: 0x008F8258
		public unsafe float Water_HighProcess_Seq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_Water_HighProcess_Seq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_Water_HighProcess_Seq) = value;
			}
		}

		// Token: 0x17002F2E RID: 12078
		// (get) Token: 0x0601D852 RID: 120914 RVA: 0x008FA069 File Offset: 0x008F8269
		// (set) Token: 0x0601D853 RID: 120915 RVA: 0x008FA079 File Offset: 0x008F8279
		public unsafe float DrinkBatchPosHeighScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkBatchPosHeighScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkBatchPosHeighScale) = value;
			}
		}

		// Token: 0x17002F2F RID: 12079
		// (get) Token: 0x0601D854 RID: 120916 RVA: 0x008FA08A File Offset: 0x008F828A
		// (set) Token: 0x0601D855 RID: 120917 RVA: 0x008FA09A File Offset: 0x008F829A
		public unsafe float WaterMaskCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterMaskCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterMaskCenterOffset) = value;
			}
		}

		// Token: 0x17002F30 RID: 12080
		// (get) Token: 0x0601D856 RID: 120918 RVA: 0x008FA0AB File Offset: 0x008F82AB
		// (set) Token: 0x0601D857 RID: 120919 RVA: 0x008FA0BB File Offset: 0x008F82BB
		public unsafe float WaterMaskWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterMaskWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterMaskWidth) = value;
			}
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x0601D858 RID: 120920 RVA: 0x008FA0CC File Offset: 0x008F82CC
		// (set) Token: 0x0601D859 RID: 120921 RVA: 0x008FA0DC File Offset: 0x008F82DC
		public unsafe float WaterColor_MidHighProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_MidHighProcess);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_MidHighProcess) = value;
			}
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x0601D85A RID: 120922 RVA: 0x008FA0ED File Offset: 0x008F82ED
		// (set) Token: 0x0601D85B RID: 120923 RVA: 0x008FA0FD File Offset: 0x008F82FD
		public unsafe float WaterColor_MidHighWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_MidHighWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_MidHighWidth) = value;
			}
		}

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x0601D85C RID: 120924 RVA: 0x008FA10E File Offset: 0x008F830E
		// (set) Token: 0x0601D85D RID: 120925 RVA: 0x008FA11E File Offset: 0x008F831E
		public unsafe float WaterColor_DownMidProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_DownMidProcess);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_DownMidProcess) = value;
			}
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x0601D85E RID: 120926 RVA: 0x008FA12F File Offset: 0x008F832F
		// (set) Token: 0x0601D85F RID: 120927 RVA: 0x008FA13F File Offset: 0x008F833F
		public unsafe float WaterColor_DownMidWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_DownMidWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_WaterColor_DownMidWidth) = value;
			}
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x0601D860 RID: 120928 RVA: 0x008FA150 File Offset: 0x008F8350
		// (set) Token: 0x0601D861 RID: 120929 RVA: 0x008FA160 File Offset: 0x008F8360
		public unsafe float UpLightMask_Process
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_UpLightMask_Process);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_UpLightMask_Process) = value;
			}
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x0601D862 RID: 120930 RVA: 0x008FA171 File Offset: 0x008F8371
		// (set) Token: 0x0601D863 RID: 120931 RVA: 0x008FA181 File Offset: 0x008F8381
		public unsafe float BubbleIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_BubbleIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_BubbleIntensity) = value;
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x0601D864 RID: 120932 RVA: 0x008FA192 File Offset: 0x008F8392
		// (set) Token: 0x0601D865 RID: 120933 RVA: 0x008FA1A2 File Offset: 0x008F83A2
		public unsafe float BubbleSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_BubbleSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_BubbleSpeed) = value;
			}
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x0601D866 RID: 120934 RVA: 0x008FA1B3 File Offset: 0x008F83B3
		// (set) Token: 0x0601D867 RID: 120935 RVA: 0x008FA1C3 File Offset: 0x008F83C3
		public unsafe int DrinkOrnament_Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkOrnament_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkOrnament_Tag) = value;
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x0601D868 RID: 120936 RVA: 0x008FA1D4 File Offset: 0x008F83D4
		// (set) Token: 0x0601D869 RID: 120937 RVA: 0x008FA1E4 File Offset: 0x008F83E4
		public unsafe int DrinksBatching_Tag01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksBatching_Tag01);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksBatching_Tag01) = value;
			}
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x0601D86A RID: 120938 RVA: 0x008FA1F5 File Offset: 0x008F83F5
		// (set) Token: 0x0601D86B RID: 120939 RVA: 0x008FA205 File Offset: 0x008F8405
		public unsafe int DrinksBatching_Tag02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksBatching_Tag02);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksBatching_Tag02) = value;
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x0601D86C RID: 120940 RVA: 0x008FA216 File Offset: 0x008F8416
		// (set) Token: 0x0601D86D RID: 120941 RVA: 0x008FA226 File Offset: 0x008F8426
		public unsafe int DrinksIngredientsFall_Tag01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksIngredientsFall_Tag01);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksIngredientsFall_Tag01) = value;
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x0601D86E RID: 120942 RVA: 0x008FA237 File Offset: 0x008F8437
		// (set) Token: 0x0601D86F RID: 120943 RVA: 0x008FA247 File Offset: 0x008F8447
		public unsafe int DrinksIngredientsFall_Tag02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksIngredientsFall_Tag02);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksIngredientsFall_Tag02) = value;
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x0601D870 RID: 120944 RVA: 0x008FA258 File Offset: 0x008F8458
		// (set) Token: 0x0601D871 RID: 120945 RVA: 0x008FA26C File Offset: 0x008F846C
		public unsafe FVector DrinksIngredientsFall_LocationStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksIngredientsFall_LocationStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksIngredientsFall_LocationStart) = value;
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x0601D872 RID: 120946 RVA: 0x008FA281 File Offset: 0x008F8481
		// (set) Token: 0x0601D873 RID: 120947 RVA: 0x008FA291 File Offset: 0x008F8491
		public unsafe float Liquid_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_Liquid_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_Liquid_Time) = value;
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x0601D874 RID: 120948 RVA: 0x008FA2A2 File Offset: 0x008F84A2
		// (set) Token: 0x0601D875 RID: 120949 RVA: 0x008FA2B2 File Offset: 0x008F84B2
		public unsafe float DrinkOrnament_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkOrnament_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkOrnament_Scale) = value;
			}
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x0601D876 RID: 120950 RVA: 0x008FA2C3 File Offset: 0x008F84C3
		// (set) Token: 0x0601D877 RID: 120951 RVA: 0x008FA2D7 File Offset: 0x008F84D7
		public unsafe FVector DrinkOrnament_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkOrnament_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkOrnament_Location) = value;
			}
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x0601D878 RID: 120952 RVA: 0x008FA2EC File Offset: 0x008F84EC
		// (set) Token: 0x0601D879 RID: 120953 RVA: 0x008FA300 File Offset: 0x008F8500
		public unsafe FRotator DrinkOrnament_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkOrnament_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkOrnament_Rotation) = value;
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x0601D87A RID: 120954 RVA: 0x008FA315 File Offset: 0x008F8515
		// (set) Token: 0x0601D87B RID: 120955 RVA: 0x008FA325 File Offset: 0x008F8525
		public unsafe float DrinksBatching_Scale01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksBatching_Scale01);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksBatching_Scale01) = value;
			}
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x0601D87C RID: 120956 RVA: 0x008FA336 File Offset: 0x008F8536
		// (set) Token: 0x0601D87D RID: 120957 RVA: 0x008FA346 File Offset: 0x008F8546
		public unsafe float DrinksBatching_Scale02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksBatching_Scale02);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinksBatching_Scale02) = value;
			}
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x0601D87E RID: 120958 RVA: 0x008FA357 File Offset: 0x008F8557
		// (set) Token: 0x0601D87F RID: 120959 RVA: 0x008FA367 File Offset: 0x008F8567
		public unsafe float DrinkBatchPosScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkBatchPosScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkBatchPosScale) = value;
			}
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x0601D880 RID: 120960 RVA: 0x008FA378 File Offset: 0x008F8578
		// (set) Token: 0x0601D881 RID: 120961 RVA: 0x008FA38C File Offset: 0x008F858C
		public unsafe FVector DrinkBatchPosOnLiquid01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkBatchPosOnLiquid01);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkBatchPosOnLiquid01) = value;
			}
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x0601D882 RID: 120962 RVA: 0x008FA3A1 File Offset: 0x008F85A1
		// (set) Token: 0x0601D883 RID: 120963 RVA: 0x008FA3B5 File Offset: 0x008F85B5
		public unsafe FVector DrinkBatchPosOnLiquid02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkBatchPosOnLiquid02);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_DrinkBatchPosOnLiquid02) = value;
			}
		}

		// Token: 0x17002F47 RID: 12103
		// (get) Token: 0x0601D884 RID: 120964 RVA: 0x008FA3CA File Offset: 0x008F85CA
		// (set) Token: 0x0601D885 RID: 120965 RVA: 0x008FA3DA File Offset: 0x008F85DA
		public unsafe bool UseLiquidSocketPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_UseLiquidSocketPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_UseLiquidSocketPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F48 RID: 12104
		// (get) Token: 0x0601D886 RID: 120966 RVA: 0x008FA3EB File Offset: 0x008F85EB
		// (set) Token: 0x0601D887 RID: 120967 RVA: 0x008FA3FB File Offset: 0x008F85FB
		public unsafe bool IsUpdateMPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_IsUpdateMPC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_IsUpdateMPC) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F49 RID: 12105
		// (get) Token: 0x0601D888 RID: 120968 RVA: 0x008FA40C File Offset: 0x008F860C
		// (set) Token: 0x0601D889 RID: 120969 RVA: 0x008FA41C File Offset: 0x008F861C
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_IsTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_IsTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x0601D88A RID: 120970 RVA: 0x008FA42D File Offset: 0x008F862D
		// (set) Token: 0x0601D88B RID: 120971 RVA: 0x008FA441 File Offset: 0x008F8641
		public unsafe FVectorDouble LiquidLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_LiquidLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_LiquidLocation) = value;
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0601D88C RID: 120972 RVA: 0x008FA456 File Offset: 0x008F8656
		// (set) Token: 0x0601D88D RID: 120973 RVA: 0x008FA46A File Offset: 0x008F866A
		public unsafe FName LiquidSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_LiquidSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_LiquidSocketName) = value;
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x0601D88E RID: 120974 RVA: 0x008FA47F File Offset: 0x008F867F
		// (set) Token: 0x0601D88F RID: 120975 RVA: 0x008FA493 File Offset: 0x008F8693
		public unsafe FName BatchSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_BatchSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Prop_GobletLiquid_C.__PropertyOffset_BatchSocketName) = value;
			}
		}

		// Token: 0x0601D890 RID: 120976 RVA: 0x008FA4A8 File Offset: 0x008F86A8
		[SkipLocalsInit]
		public virtual void UpdateLiquidAndFallTag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UpdateLiquidAndFallTag_NativeFunctionPtr, null);
		}

		// Token: 0x0601D891 RID: 120977 RVA: 0x008FA4BC File Offset: 0x008F86BC
		[SkipLocalsInit]
		public unsafe virtual void GetBatchLiquidHeight(ref float LiquidHeight)
		{
			BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LiquidHeight = LiquidHeight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__GetBatchLiquidHeight_NativeFunctionPtr, (void*)ptr);
			LiquidHeight = ptr->LiquidHeight;
		}

		// Token: 0x0601D892 RID: 120978 RVA: 0x008FA50B File Offset: 0x008F870B
		[SkipLocalsInit]
		public virtual void UpdateLiquidMPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UpdateLiquidMPC_NativeFunctionPtr, null);
		}

		// Token: 0x0601D893 RID: 120979 RVA: 0x008FA51F File Offset: 0x008F871F
		[SkipLocalsInit]
		public virtual void PlayBatchingFallNiagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__PlayBatchingFallNiagara_NativeFunctionPtr, null);
		}

		// Token: 0x0601D894 RID: 120980 RVA: 0x008FA533 File Offset: 0x008F8733
		[SkipLocalsInit]
		public virtual void PlayLiquidNiagara()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__PlayLiquidNiagara_NativeFunctionPtr, null);
		}

		// Token: 0x0601D895 RID: 120981 RVA: 0x008FA547 File Offset: 0x008F8747
		[SkipLocalsInit]
		public virtual void UpdateGobletLiguid()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UpdateGobletLiguid_NativeFunctionPtr, null);
		}

		// Token: 0x0601D896 RID: 120982 RVA: 0x008FA55B File Offset: 0x008F875B
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D897 RID: 120983 RVA: 0x008FA56F File Offset: 0x008F876F
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601D898 RID: 120984 RVA: 0x008FA584 File Offset: 0x008F8784
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D899 RID: 120985 RVA: 0x008FA5CC File Offset: 0x008F87CC
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D89A RID: 120986 RVA: 0x008FA614 File Offset: 0x008F8814
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D89B RID: 120987 RVA: 0x008FA65C File Offset: 0x008F885C
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams* ptr = stackalloc BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Prop_GobletLiquid_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Prop_GobletLiquid_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Prop_GobletLiquid_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601D89C RID: 120988 RVA: 0x008FA6A2 File Offset: 0x008F88A2
		protected BP_Prop_GobletLiquid_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8A4 RID: 63652
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Seq_BP/BPGobletLiquid/BP_Prop_GobletLiquid.BP_Prop_GobletLiquid_C";

		// Token: 0x0400F8A5 RID: 63653
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8A6 RID: 63654
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8A7 RID: 63655
		internal static int __PropertyOffset_KuroCollectActor;

		// Token: 0x0400F8A8 RID: 63656
		internal static int __PropertyOffset_NS_Fx_DrinksIngredients_Fall;

		// Token: 0x0400F8A9 RID: 63657
		internal static int __PropertyOffset_NS_Fx_DrinkOrnament;

		// Token: 0x0400F8AA RID: 63658
		internal static int __PropertyOffset_NS_Fx_DrinksBatching02;

		// Token: 0x0400F8AB RID: 63659
		internal static int __PropertyOffset_NS_Fx_DrinksBatching01;

		// Token: 0x0400F8AC RID: 63660
		internal static int __PropertyOffset_NS_Fx_Liquid;

		// Token: 0x0400F8AD RID: 63661
		internal static int __PropertyOffset_Liquid;

		// Token: 0x0400F8AE RID: 63662
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F8AF RID: 63663
		internal static int __PropertyOffset_MainColorPalette;

		// Token: 0x0400F8B0 RID: 63664
		internal static int __PropertyOffset_WaterLineColor;

		// Token: 0x0400F8B1 RID: 63665
		internal static int __PropertyOffset_WaterColor_High;

		// Token: 0x0400F8B2 RID: 63666
		internal static int __PropertyOffset_WaterColor_Middle;

		// Token: 0x0400F8B3 RID: 63667
		internal static int __PropertyOffset_WaterColor_Down;

		// Token: 0x0400F8B4 RID: 63668
		internal static int __PropertyOffset_FresnelColorAdd;

		// Token: 0x0400F8B5 RID: 63669
		internal static int __PropertyOffset_FresnelRangeWater;

		// Token: 0x0400F8B6 RID: 63670
		internal static int __PropertyOffset_RefractIntensity;

		// Token: 0x0400F8B7 RID: 63671
		internal static int __PropertyOffset_WaterRoughness;

		// Token: 0x0400F8B8 RID: 63672
		internal static int __PropertyOffset_WaterMetallic;

		// Token: 0x0400F8B9 RID: 63673
		internal static int __PropertyOffset_UPColor_Add;

		// Token: 0x0400F8BA RID: 63674
		internal static int __PropertyOffset_UpLighColor;

		// Token: 0x0400F8BB RID: 63675
		internal static int __PropertyOffset_Water_HighProcess;

		// Token: 0x0400F8BC RID: 63676
		internal static int __PropertyOffset_Water_HighProcess_Seq;

		// Token: 0x0400F8BD RID: 63677
		internal static int __PropertyOffset_DrinkBatchPosHeighScale;

		// Token: 0x0400F8BE RID: 63678
		internal static int __PropertyOffset_WaterMaskCenterOffset;

		// Token: 0x0400F8BF RID: 63679
		internal static int __PropertyOffset_WaterMaskWidth;

		// Token: 0x0400F8C0 RID: 63680
		internal static int __PropertyOffset_WaterColor_MidHighProcess;

		// Token: 0x0400F8C1 RID: 63681
		internal static int __PropertyOffset_WaterColor_MidHighWidth;

		// Token: 0x0400F8C2 RID: 63682
		internal static int __PropertyOffset_WaterColor_DownMidProcess;

		// Token: 0x0400F8C3 RID: 63683
		internal static int __PropertyOffset_WaterColor_DownMidWidth;

		// Token: 0x0400F8C4 RID: 63684
		internal static int __PropertyOffset_UpLightMask_Process;

		// Token: 0x0400F8C5 RID: 63685
		internal static int __PropertyOffset_BubbleIntensity;

		// Token: 0x0400F8C6 RID: 63686
		internal static int __PropertyOffset_BubbleSpeed;

		// Token: 0x0400F8C7 RID: 63687
		internal static int __PropertyOffset_DrinkOrnament_Tag;

		// Token: 0x0400F8C8 RID: 63688
		internal static int __PropertyOffset_DrinksBatching_Tag01;

		// Token: 0x0400F8C9 RID: 63689
		internal static int __PropertyOffset_DrinksBatching_Tag02;

		// Token: 0x0400F8CA RID: 63690
		internal static int __PropertyOffset_DrinksIngredientsFall_Tag01;

		// Token: 0x0400F8CB RID: 63691
		internal static int __PropertyOffset_DrinksIngredientsFall_Tag02;

		// Token: 0x0400F8CC RID: 63692
		internal static int __PropertyOffset_DrinksIngredientsFall_LocationStart;

		// Token: 0x0400F8CD RID: 63693
		internal static int __PropertyOffset_Liquid_Time;

		// Token: 0x0400F8CE RID: 63694
		internal static int __PropertyOffset_DrinkOrnament_Scale;

		// Token: 0x0400F8CF RID: 63695
		internal static int __PropertyOffset_DrinkOrnament_Location;

		// Token: 0x0400F8D0 RID: 63696
		internal static int __PropertyOffset_DrinkOrnament_Rotation;

		// Token: 0x0400F8D1 RID: 63697
		internal static int __PropertyOffset_DrinksBatching_Scale01;

		// Token: 0x0400F8D2 RID: 63698
		internal static int __PropertyOffset_DrinksBatching_Scale02;

		// Token: 0x0400F8D3 RID: 63699
		internal static int __PropertyOffset_DrinkBatchPosScale;

		// Token: 0x0400F8D4 RID: 63700
		internal static int __PropertyOffset_DrinkBatchPosOnLiquid01;

		// Token: 0x0400F8D5 RID: 63701
		internal static int __PropertyOffset_DrinkBatchPosOnLiquid02;

		// Token: 0x0400F8D6 RID: 63702
		internal static int __PropertyOffset_UseLiquidSocketPosition;

		// Token: 0x0400F8D7 RID: 63703
		internal static int __PropertyOffset_IsUpdateMPC;

		// Token: 0x0400F8D8 RID: 63704
		internal static int __PropertyOffset_IsTick;

		// Token: 0x0400F8D9 RID: 63705
		internal static int __PropertyOffset_LiquidLocation;

		// Token: 0x0400F8DA RID: 63706
		internal static int __PropertyOffset_LiquidSocketName;

		// Token: 0x0400F8DB RID: 63707
		internal static int __PropertyOffset_BatchSocketName;

		// Token: 0x0400F8DC RID: 63708
		private static IntPtr __UpdateLiquidAndFallTag_NativeFunctionPtr;

		// Token: 0x0400F8DD RID: 63709
		private static IntPtr __GetBatchLiquidHeight_NativeFunctionPtr;

		// Token: 0x0400F8DE RID: 63710
		private static IntPtr __UpdateLiquidMPC_NativeFunctionPtr;

		// Token: 0x0400F8DF RID: 63711
		private static IntPtr __PlayBatchingFallNiagara_NativeFunctionPtr;

		// Token: 0x0400F8E0 RID: 63712
		private static IntPtr __PlayLiquidNiagara_NativeFunctionPtr;

		// Token: 0x0400F8E1 RID: 63713
		private static IntPtr __UpdateGobletLiguid_NativeFunctionPtr;

		// Token: 0x0400F8E2 RID: 63714
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F8E3 RID: 63715
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F8E4 RID: 63716
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008D45 RID: 36165
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __GetBatchLiquidHeight_FunctionParams
		{
			// Token: 0x0402C8B5 RID: 182453
			[FieldOffset(0)]
			public float LiquidHeight;
		}

		// Token: 0x02008D46 RID: 36166
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C8B6 RID: 182454
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008D47 RID: 36167
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402C8B7 RID: 182455
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
