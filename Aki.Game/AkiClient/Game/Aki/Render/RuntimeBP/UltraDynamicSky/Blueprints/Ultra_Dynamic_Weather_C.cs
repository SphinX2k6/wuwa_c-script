using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints
{
	// Token: 0x02003A93 RID: 14995
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Weather.Ultra_Dynamic_Weather_C")]
	[UnrealStructLayout(2024, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2020)]
	public class Ultra_Dynamic_Weather_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602005C RID: 131164 RVA: 0x008C7EBD File Offset: 0x008C60BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (Ultra_Dynamic_Weather_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Weather.Ultra_Dynamic_Weather_C");
			}
			return Ultra_Dynamic_Weather_C._ClassPtr;
		}

		// Token: 0x0602005D RID: 131165 RVA: 0x008C7EE4 File Offset: 0x008C60E4
		public Ultra_Dynamic_Weather_C() : this(BuiltinUtils.AllocNativeUObject(Ultra_Dynamic_Weather_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602005E RID: 131166 RVA: 0x008C7F0C File Offset: 0x008C610C
		[NullableContext(1)]
		public Ultra_Dynamic_Weather_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(Ultra_Dynamic_Weather_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x0602005F RID: 131167 RVA: 0x008C7F3F File Offset: 0x008C613F
		// (set) Token: 0x06020060 RID: 131168 RVA: 0x008C7F53 File Offset: 0x008C6153
		public unsafe UAudioComponent Rain_Y_minus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x06020061 RID: 131169 RVA: 0x008C7F68 File Offset: 0x008C6168
		// (set) Token: 0x06020062 RID: 131170 RVA: 0x008C7F7C File Offset: 0x008C617C
		public unsafe UAudioComponent Rain_Y_plus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x06020063 RID: 131171 RVA: 0x008C7F91 File Offset: 0x008C6191
		// (set) Token: 0x06020064 RID: 131172 RVA: 0x008C7FA5 File Offset: 0x008C61A5
		public unsafe UAudioComponent Rain_X_minus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x06020065 RID: 131173 RVA: 0x008C7FBA File Offset: 0x008C61BA
		// (set) Token: 0x06020066 RID: 131174 RVA: 0x008C7FCE File Offset: 0x008C61CE
		public unsafe UAudioComponent Rain_X_plus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x06020067 RID: 131175 RVA: 0x008C7FE3 File Offset: 0x008C61E3
		// (set) Token: 0x06020068 RID: 131176 RVA: 0x008C7FF7 File Offset: 0x008C61F7
		public unsafe UAudioComponent Wind_Y_minus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x06020069 RID: 131177 RVA: 0x008C800C File Offset: 0x008C620C
		// (set) Token: 0x0602006A RID: 131178 RVA: 0x008C8020 File Offset: 0x008C6220
		public unsafe UAudioComponent Wind_Y_plus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0602006B RID: 131179 RVA: 0x008C8035 File Offset: 0x008C6235
		// (set) Token: 0x0602006C RID: 131180 RVA: 0x008C8049 File Offset: 0x008C6249
		public unsafe UAudioComponent Wind_X_minus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0602006D RID: 131181 RVA: 0x008C805E File Offset: 0x008C625E
		// (set) Token: 0x0602006E RID: 131182 RVA: 0x008C8072 File Offset: 0x008C6272
		public unsafe UAudioComponent Wind_Whistling
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17002E75 RID: 11893
		// (get) Token: 0x0602006F RID: 131183 RVA: 0x008C8087 File Offset: 0x008C6287
		// (set) Token: 0x06020070 RID: 131184 RVA: 0x008C809B File Offset: 0x008C629B
		public unsafe UAudioComponent DistantThunder_Cue
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17002E76 RID: 11894
		// (get) Token: 0x06020071 RID: 131185 RVA: 0x008C80B0 File Offset: 0x008C62B0
		// (set) Token: 0x06020072 RID: 131186 RVA: 0x008C80C4 File Offset: 0x008C62C4
		public unsafe UAudioComponent Wind_X_plus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17002E77 RID: 11895
		// (get) Token: 0x06020073 RID: 131187 RVA: 0x008C80D9 File Offset: 0x008C62D9
		// (set) Token: 0x06020074 RID: 131188 RVA: 0x008C80ED File Offset: 0x008C62ED
		public unsafe UNiagaraComponent Obscured_Lightning
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17002E78 RID: 11896
		// (get) Token: 0x06020075 RID: 131189 RVA: 0x008C8102 File Offset: 0x008C6302
		// (set) Token: 0x06020076 RID: 131190 RVA: 0x008C8116 File Offset: 0x008C6316
		public unsafe UDirectionalLightComponent Lightning_Light
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDirectionalLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17002E79 RID: 11897
		// (get) Token: 0x06020077 RID: 131191 RVA: 0x008C812B File Offset: 0x008C632B
		// (set) Token: 0x06020078 RID: 131192 RVA: 0x008C813F File Offset: 0x008C633F
		public unsafe UBillboardComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17002E7A RID: 11898
		// (get) Token: 0x06020079 RID: 131193 RVA: 0x008C8154 File Offset: 0x008C6354
		// (set) Token: 0x0602007A RID: 131194 RVA: 0x008C8168 File Offset: 0x008C6368
		public unsafe UNiagaraComponent Rain_and_Snow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x0602007B RID: 131195 RVA: 0x008C817D File Offset: 0x008C637D
		// (set) Token: 0x0602007C RID: 131196 RVA: 0x008C818D File Offset: 0x008C638D
		public unsafe float Lightning_Strength_Strength_42A3C5BF44EC76E7205FA595C4CFB5A2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x0602007D RID: 131197 RVA: 0x008C819E File Offset: 0x008C639E
		// (set) Token: 0x0602007E RID: 131198 RVA: 0x008C81B2 File Offset: 0x008C63B2
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> Lightning_Strength__Direction_42A3C5BF44EC76E7205FA595C4CFB5A2
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_16);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x0602007F RID: 131199 RVA: 0x008C81C7 File Offset: 0x008C63C7
		// (set) Token: 0x06020080 RID: 131200 RVA: 0x008C81DB File Offset: 0x008C63DB
		public unsafe UTimelineComponent Lightning_Strength
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x06020081 RID: 131201 RVA: 0x008C81F0 File Offset: 0x008C63F0
		// (set) Token: 0x06020082 RID: 131202 RVA: 0x008C8204 File Offset: 0x008C6404
		public unsafe Ultra_Dynamic_Sky_C UltraDynamicSky
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<Ultra_Dynamic_Sky_C>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x06020083 RID: 131203 RVA: 0x008C8219 File Offset: 0x008C6419
		// (set) Token: 0x06020084 RID: 131204 RVA: 0x008C822D File Offset: 0x008C642D
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_WeatherTypes> Weather_Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_19);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17002E80 RID: 11904
		// (get) Token: 0x06020085 RID: 131205 RVA: 0x008C8242 File Offset: 0x008C6442
		// (set) Token: 0x06020086 RID: 131206 RVA: 0x008C8252 File Offset: 0x008C6452
		public unsafe float Weather_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x06020087 RID: 131207 RVA: 0x008C8263 File Offset: 0x008C6463
		// (set) Token: 0x06020088 RID: 131208 RVA: 0x008C8273 File Offset: 0x008C6473
		public unsafe float Cloud_Coverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17002E82 RID: 11906
		// (get) Token: 0x06020089 RID: 131209 RVA: 0x008C8284 File Offset: 0x008C6484
		// (set) Token: 0x0602008A RID: 131210 RVA: 0x008C8294 File Offset: 0x008C6494
		public unsafe float Rain_or_Snow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0602008B RID: 131211 RVA: 0x008C82A5 File Offset: 0x008C64A5
		// (set) Token: 0x0602008C RID: 131212 RVA: 0x008C82B5 File Offset: 0x008C64B5
		public unsafe float Wind_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0602008D RID: 131213 RVA: 0x008C82C6 File Offset: 0x008C64C6
		// (set) Token: 0x0602008E RID: 131214 RVA: 0x008C82D6 File Offset: 0x008C64D6
		public unsafe float Wind_Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_24);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_24) = value;
			}
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x0602008F RID: 131215 RVA: 0x008C82E7 File Offset: 0x008C64E7
		// (set) Token: 0x06020090 RID: 131216 RVA: 0x008C82F7 File Offset: 0x008C64F7
		public unsafe float Temperature_Celsius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x06020091 RID: 131217 RVA: 0x008C8308 File Offset: 0x008C6508
		// (set) Token: 0x06020092 RID: 131218 RVA: 0x008C8318 File Offset: 0x008C6518
		public unsafe float Lerp_to_New_Settings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x06020093 RID: 131219 RVA: 0x008C8329 File Offset: 0x008C6529
		// (set) Token: 0x06020094 RID: 131220 RVA: 0x008C8339 File Offset: 0x008C6539
		public unsafe float Weather_Intensity_OLD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x06020095 RID: 131221 RVA: 0x008C834A File Offset: 0x008C654A
		// (set) Token: 0x06020096 RID: 131222 RVA: 0x008C835A File Offset: 0x008C655A
		public unsafe float Cloud_Coverage_OLD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x06020097 RID: 131223 RVA: 0x008C836B File Offset: 0x008C656B
		// (set) Token: 0x06020098 RID: 131224 RVA: 0x008C837B File Offset: 0x008C657B
		public unsafe float Rain_orSnow_OLD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x06020099 RID: 131225 RVA: 0x008C838C File Offset: 0x008C658C
		// (set) Token: 0x0602009A RID: 131226 RVA: 0x008C839C File Offset: 0x008C659C
		public unsafe float Wind_Intensity_OLD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x0602009B RID: 131227 RVA: 0x008C83AD File Offset: 0x008C65AD
		// (set) Token: 0x0602009C RID: 131228 RVA: 0x008C83C1 File Offset: 0x008C65C1
		public unsafe FRotator Wind_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x0602009D RID: 131229 RVA: 0x008C83D6 File Offset: 0x008C65D6
		// (set) Token: 0x0602009E RID: 131230 RVA: 0x008C83E6 File Offset: 0x008C65E6
		public unsafe float Lerp_to_Static_Settings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0602009F RID: 131231 RVA: 0x008C83F7 File Offset: 0x008C65F7
		// (set) Token: 0x060200A0 RID: 131232 RVA: 0x008C8407 File Offset: 0x008C6607
		public unsafe float Current_Weather_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x060200A1 RID: 131233 RVA: 0x008C8418 File Offset: 0x008C6618
		// (set) Token: 0x060200A2 RID: 131234 RVA: 0x008C8428 File Offset: 0x008C6628
		public unsafe float Current_Cloud_Coverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x060200A3 RID: 131235 RVA: 0x008C8439 File Offset: 0x008C6639
		// (set) Token: 0x060200A4 RID: 131236 RVA: 0x008C8449 File Offset: 0x008C6649
		public unsafe float Current_Rain_or_Snow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x060200A5 RID: 131237 RVA: 0x008C845A File Offset: 0x008C665A
		// (set) Token: 0x060200A6 RID: 131238 RVA: 0x008C846A File Offset: 0x008C666A
		public unsafe float Current_Wind_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_36);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_36) = value;
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x060200A7 RID: 131239 RVA: 0x008C847B File Offset: 0x008C667B
		// (set) Token: 0x060200A8 RID: 131240 RVA: 0x008C848B File Offset: 0x008C668B
		public unsafe float Transition_In_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x060200A9 RID: 131241 RVA: 0x008C849C File Offset: 0x008C669C
		// (set) Token: 0x060200AA RID: 131242 RVA: 0x008C84AC File Offset: 0x008C66AC
		public unsafe float Transition_Out_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x060200AB RID: 131243 RVA: 0x008C84BD File Offset: 0x008C66BD
		// (set) Token: 0x060200AC RID: 131244 RVA: 0x008C84CD File Offset: 0x008C66CD
		public unsafe float Hold_Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x060200AD RID: 131245 RVA: 0x008C84DE File Offset: 0x008C66DE
		// (set) Token: 0x060200AE RID: 131246 RVA: 0x008C84EE File Offset: 0x008C66EE
		public unsafe bool Use_Initial_Settings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x060200AF RID: 131247 RVA: 0x008C84FF File Offset: 0x008C66FF
		// (set) Token: 0x060200B0 RID: 131248 RVA: 0x008C850F File Offset: 0x008C670F
		public unsafe float Time_to_Hold_Initial_Settings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_41);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_41) = value;
			}
		}

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x060200B1 RID: 131249 RVA: 0x008C8520 File Offset: 0x008C6720
		// (set) Token: 0x060200B2 RID: 131250 RVA: 0x008C8530 File Offset: 0x008C6730
		public unsafe float Time_To_Transition_from_Initial_Settings_to_Random_Variation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_42);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_42) = value;
			}
		}

		// Token: 0x17002E97 RID: 11927
		// (get) Token: 0x060200B3 RID: 131251 RVA: 0x008C8541 File Offset: 0x008C6741
		// (set) Token: 0x060200B4 RID: 131252 RVA: 0x008C8551 File Offset: 0x008C6751
		public unsafe int Transition_State
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_43);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_43) = value;
			}
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x060200B5 RID: 131253 RVA: 0x008C8562 File Offset: 0x008C6762
		// (set) Token: 0x060200B6 RID: 131254 RVA: 0x008C8572 File Offset: 0x008C6772
		public unsafe float Timer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_44);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_44) = value;
			}
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x060200B7 RID: 131255 RVA: 0x008C8583 File Offset: 0x008C6783
		// (set) Token: 0x060200B8 RID: 131256 RVA: 0x008C8593 File Offset: 0x008C6793
		public unsafe bool Enable_Rain_and_Snow_Particles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_45) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_45) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x060200B9 RID: 131257 RVA: 0x008C85A4 File Offset: 0x008C67A4
		// (set) Token: 0x060200BA RID: 131258 RVA: 0x008C85B4 File Offset: 0x008C67B4
		public unsafe float Max_Particle_Spawn_Rate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_46);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_46) = value;
			}
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x060200BB RID: 131259 RVA: 0x008C85C5 File Offset: 0x008C67C5
		// (set) Token: 0x060200BC RID: 131260 RVA: 0x008C85D5 File Offset: 0x008C67D5
		public unsafe bool Particle_Collision_Enabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_47) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_47) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x060200BD RID: 131261 RVA: 0x008C85E6 File Offset: 0x008C67E6
		// (set) Token: 0x060200BE RID: 131262 RVA: 0x008C85F6 File Offset: 0x008C67F6
		public unsafe float Camera_Forward_Spawn_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_48);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_48) = value;
			}
		}

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x060200BF RID: 131263 RVA: 0x008C8607 File Offset: 0x008C6807
		// (set) Token: 0x060200C0 RID: 131264 RVA: 0x008C8617 File Offset: 0x008C6817
		public unsafe float Ceiling_Check_Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_49);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_49) = value;
			}
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x060200C1 RID: 131265 RVA: 0x008C8628 File Offset: 0x008C6828
		// (set) Token: 0x060200C2 RID: 131266 RVA: 0x008C8638 File Offset: 0x008C6838
		public unsafe float Spawn_Box_Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_50);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_50) = value;
			}
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x060200C3 RID: 131267 RVA: 0x008C8649 File Offset: 0x008C6849
		// (set) Token: 0x060200C4 RID: 131268 RVA: 0x008C8659 File Offset: 0x008C6859
		public unsafe float Max_Spawn_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_51);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_51) = value;
			}
		}

		// Token: 0x17002EA0 RID: 11936
		// (get) Token: 0x060200C5 RID: 131269 RVA: 0x008C866A File Offset: 0x008C686A
		// (set) Token: 0x060200C6 RID: 131270 RVA: 0x008C867A File Offset: 0x008C687A
		public unsafe float Spawn_Distance_Distribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_52);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_52) = value;
			}
		}

		// Token: 0x17002EA1 RID: 11937
		// (get) Token: 0x060200C7 RID: 131271 RVA: 0x008C868B File Offset: 0x008C688B
		// (set) Token: 0x060200C8 RID: 131272 RVA: 0x008C869B File Offset: 0x008C689B
		public unsafe float Minimum_Particle_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_53);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_53) = value;
			}
		}

		// Token: 0x17002EA2 RID: 11938
		// (get) Token: 0x060200C9 RID: 131273 RVA: 0x008C86AC File Offset: 0x008C68AC
		// (set) Token: 0x060200CA RID: 131274 RVA: 0x008C86BC File Offset: 0x008C68BC
		public unsafe float Rain_Drops_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_54);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_54) = value;
			}
		}

		// Token: 0x17002EA3 RID: 11939
		// (get) Token: 0x060200CB RID: 131275 RVA: 0x008C86CD File Offset: 0x008C68CD
		// (set) Token: 0x060200CC RID: 131276 RVA: 0x008C86DD File Offset: 0x008C68DD
		public unsafe float Snow_Flakes_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_55);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_55) = value;
			}
		}

		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x060200CD RID: 131277 RVA: 0x008C86EE File Offset: 0x008C68EE
		// (set) Token: 0x060200CE RID: 131278 RVA: 0x008C86FE File Offset: 0x008C68FE
		public unsafe float Rain_Drops_Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_56);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_56) = value;
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x060200CF RID: 131279 RVA: 0x008C870F File Offset: 0x008C690F
		// (set) Token: 0x060200D0 RID: 131280 RVA: 0x008C871F File Offset: 0x008C691F
		public unsafe float Snow_Flakes_Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_57);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_57) = value;
			}
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x060200D1 RID: 131281 RVA: 0x008C8730 File Offset: 0x008C6930
		// (set) Token: 0x060200D2 RID: 131282 RVA: 0x008C8744 File Offset: 0x008C6944
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> Rain_or_Snow_Particle_Collision_Channel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_58);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_58) = value;
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x060200D3 RID: 131283 RVA: 0x008C8759 File Offset: 0x008C6959
		// (set) Token: 0x060200D4 RID: 131284 RVA: 0x008C8769 File Offset: 0x008C6969
		public unsafe float Splash_Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_59);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_59) = value;
			}
		}

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x060200D5 RID: 131285 RVA: 0x008C877A File Offset: 0x008C697A
		// (set) Token: 0x060200D6 RID: 131286 RVA: 0x008C878A File Offset: 0x008C698A
		public unsafe bool Snow_Flakes_Stick_to_Surfaces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_60) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_60) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x060200D7 RID: 131287 RVA: 0x008C879B File Offset: 0x008C699B
		// (set) Token: 0x060200D8 RID: 131288 RVA: 0x008C87AB File Offset: 0x008C69AB
		public unsafe float Current_Snow_Percentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_61);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_61) = value;
			}
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x060200D9 RID: 131289 RVA: 0x008C87BC File Offset: 0x008C69BC
		// (set) Token: 0x060200DA RID: 131290 RVA: 0x008C87D0 File Offset: 0x008C69D0
		public unsafe FVector Current_Lightning_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_62);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_62) = value;
			}
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x060200DB RID: 131291 RVA: 0x008C87E5 File Offset: 0x008C69E5
		// (set) Token: 0x060200DC RID: 131292 RVA: 0x008C87F5 File Offset: 0x008C69F5
		public unsafe bool Spawn_Lightning_Flashes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_63) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_63) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x060200DD RID: 131293 RVA: 0x008C8806 File Offset: 0x008C6A06
		// (set) Token: 0x060200DE RID: 131294 RVA: 0x008C881A File Offset: 0x008C6A1A
		public unsafe FVector Current_Camera_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_64);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_64) = value;
			}
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x060200DF RID: 131295 RVA: 0x008C882F File Offset: 0x008C6A2F
		// (set) Token: 0x060200E0 RID: 131296 RVA: 0x008C883F File Offset: 0x008C6A3F
		public unsafe float Current_Lightning_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_65);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_65) = value;
			}
		}

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x060200E1 RID: 131297 RVA: 0x008C8850 File Offset: 0x008C6A50
		// (set) Token: 0x060200E2 RID: 131298 RVA: 0x008C8864 File Offset: 0x008C6A64
		public unsafe FFloatRange Lightning_Flash_Interval_Random_Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_66);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_66) = value;
			}
		}

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x060200E3 RID: 131299 RVA: 0x008C8879 File Offset: 0x008C6A79
		// (set) Token: 0x060200E4 RID: 131300 RVA: 0x008C8889 File Offset: 0x008C6A89
		public unsafe bool Lightning_Flash_Light_Source
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_67) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_67) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x060200E5 RID: 131301 RVA: 0x008C889A File Offset: 0x008C6A9A
		// (set) Token: 0x060200E6 RID: 131302 RVA: 0x008C88AE File Offset: 0x008C6AAE
		public unsafe FLinearColor Lightning_Flash_Light_Source_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_68);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_68) = value;
			}
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x060200E7 RID: 131303 RVA: 0x008C88C3 File Offset: 0x008C6AC3
		// (set) Token: 0x060200E8 RID: 131304 RVA: 0x008C88D3 File Offset: 0x008C6AD3
		public unsafe float Maximum_Lightning_Flash_Light_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_69);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_69) = value;
			}
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x060200E9 RID: 131305 RVA: 0x008C88E4 File Offset: 0x008C6AE4
		// (set) Token: 0x060200EA RID: 131306 RVA: 0x008C88F4 File Offset: 0x008C6AF4
		public unsafe bool Lightning_Flashes_Cast_Shadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_70) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_70) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EB3 RID: 11955
		// (get) Token: 0x060200EB RID: 131307 RVA: 0x008C8905 File Offset: 0x008C6B05
		// (set) Token: 0x060200EC RID: 131308 RVA: 0x008C8915 File Offset: 0x008C6B15
		public unsafe bool Lightning_Flashes_Cast_Light_Shaft_Bloom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_71) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_71) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EB4 RID: 11956
		// (get) Token: 0x060200ED RID: 131309 RVA: 0x008C8926 File Offset: 0x008C6B26
		// (set) Token: 0x060200EE RID: 131310 RVA: 0x008C8936 File Offset: 0x008C6B36
		public unsafe float Lightning_Flash_Light_Shaft_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_72);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_72) = value;
			}
		}

		// Token: 0x17002EB5 RID: 11957
		// (get) Token: 0x060200EF RID: 131311 RVA: 0x008C8947 File Offset: 0x008C6B47
		// (set) Token: 0x060200F0 RID: 131312 RVA: 0x008C895B File Offset: 0x008C6B5B
		public unsafe FFloatRange Lightning_Flash_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_73);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_73) = value;
			}
		}

		// Token: 0x17002EB6 RID: 11958
		// (get) Token: 0x060200F1 RID: 131313 RVA: 0x008C8970 File Offset: 0x008C6B70
		// (set) Token: 0x060200F2 RID: 131314 RVA: 0x008C8980 File Offset: 0x008C6B80
		public unsafe bool Enable_Obscured_Lightning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_74) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_74) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EB7 RID: 11959
		// (get) Token: 0x060200F3 RID: 131315 RVA: 0x008C8991 File Offset: 0x008C6B91
		// (set) Token: 0x060200F4 RID: 131316 RVA: 0x008C89A1 File Offset: 0x008C6BA1
		public unsafe float Obscured_Lightning_Spawn_Interval__Rain_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_75);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_75) = value;
			}
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x060200F5 RID: 131317 RVA: 0x008C89B2 File Offset: 0x008C6BB2
		// (set) Token: 0x060200F6 RID: 131318 RVA: 0x008C89C2 File Offset: 0x008C6BC2
		public unsafe float Obscured_Lightning_Spawn_Interval__Snow_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_76);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_76) = value;
			}
		}

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x060200F7 RID: 131319 RVA: 0x008C89D3 File Offset: 0x008C6BD3
		// (set) Token: 0x060200F8 RID: 131320 RVA: 0x008C89E3 File Offset: 0x008C6BE3
		public unsafe float Lightning_Flash_Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_77);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_77) = value;
			}
		}

		// Token: 0x17002EBA RID: 11962
		// (get) Token: 0x060200F9 RID: 131321 RVA: 0x008C89F4 File Offset: 0x008C6BF4
		// (set) Token: 0x060200FA RID: 131322 RVA: 0x008C8A04 File Offset: 0x008C6C04
		public unsafe bool Spawn_Lightning_Flashes_During_Snow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_78) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_78) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x060200FB RID: 131323 RVA: 0x008C8A15 File Offset: 0x008C6C15
		// (set) Token: 0x060200FC RID: 131324 RVA: 0x008C8A25 File Offset: 0x008C6C25
		public unsafe bool Enable_Fog_Particles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_79) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_79) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x060200FD RID: 131325 RVA: 0x008C8A36 File Offset: 0x008C6C36
		// (set) Token: 0x060200FE RID: 131326 RVA: 0x008C8A46 File Offset: 0x008C6C46
		public unsafe float Max_Fog_Particle_Percentage__Rain_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_80);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_80) = value;
			}
		}

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x060200FF RID: 131327 RVA: 0x008C8A57 File Offset: 0x008C6C57
		// (set) Token: 0x06020100 RID: 131328 RVA: 0x008C8A67 File Offset: 0x008C6C67
		public unsafe float Max_Fog_Particle_Percentage__Snow_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_81);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_81) = value;
			}
		}

		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x06020101 RID: 131329 RVA: 0x008C8A78 File Offset: 0x008C6C78
		// (set) Token: 0x06020102 RID: 131330 RVA: 0x008C8A88 File Offset: 0x008C6C88
		public unsafe float Fog_Particle_Intensity__Rain_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_82);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_82) = value;
			}
		}

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x06020103 RID: 131331 RVA: 0x008C8A99 File Offset: 0x008C6C99
		// (set) Token: 0x06020104 RID: 131332 RVA: 0x008C8AA9 File Offset: 0x008C6CA9
		public unsafe float Fog_Particle_Intensity__Snow_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_83);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_83) = value;
			}
		}

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x06020105 RID: 131333 RVA: 0x008C8ABA File Offset: 0x008C6CBA
		// (set) Token: 0x06020106 RID: 131334 RVA: 0x008C8ACA File Offset: 0x008C6CCA
		public unsafe float Fog_Particles_Draw_Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_84);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_84) = value;
			}
		}

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x06020107 RID: 131335 RVA: 0x008C8ADB File Offset: 0x008C6CDB
		// (set) Token: 0x06020108 RID: 131336 RVA: 0x008C8AEF File Offset: 0x008C6CEF
		public unsafe AWindDirectionalSource Wind_Directional_Source_Actor__for_SpeedTree_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AWindDirectionalSource>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_85);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_85, value);
			}
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x06020109 RID: 131337 RVA: 0x008C8B04 File Offset: 0x008C6D04
		// (set) Token: 0x0602010A RID: 131338 RVA: 0x008C8B14 File Offset: 0x008C6D14
		public unsafe bool Has_Valid_Wind_Actor_Reference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_86) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_86) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0602010B RID: 131339 RVA: 0x008C8B25 File Offset: 0x008C6D25
		// (set) Token: 0x0602010C RID: 131340 RVA: 0x008C8B35 File Offset: 0x008C6D35
		public unsafe float Material_Wetness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_87);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_87) = value;
			}
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0602010D RID: 131341 RVA: 0x008C8B46 File Offset: 0x008C6D46
		// (set) Token: 0x0602010E RID: 131342 RVA: 0x008C8B56 File Offset: 0x008C6D56
		public unsafe float Material_Snow_Coverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_88);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_88) = value;
			}
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0602010F RID: 131343 RVA: 0x008C8B67 File Offset: 0x008C6D67
		// (set) Token: 0x06020110 RID: 131344 RVA: 0x008C8B77 File Offset: 0x008C6D77
		public unsafe float Current_Material_Wetness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_89);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_89) = value;
			}
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x06020111 RID: 131345 RVA: 0x008C8B88 File Offset: 0x008C6D88
		// (set) Token: 0x06020112 RID: 131346 RVA: 0x008C8B98 File Offset: 0x008C6D98
		public unsafe float Current_Material_Snow_Coverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_90);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_90) = value;
			}
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x06020113 RID: 131347 RVA: 0x008C8BA9 File Offset: 0x008C6DA9
		// (set) Token: 0x06020114 RID: 131348 RVA: 0x008C8BB9 File Offset: 0x008C6DB9
		public unsafe bool Simulate_Changing_Material_Effects_with_Weather
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_91) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_91) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x06020115 RID: 131349 RVA: 0x008C8BCA File Offset: 0x008C6DCA
		// (set) Token: 0x06020116 RID: 131350 RVA: 0x008C8BDA File Offset: 0x008C6DDA
		public unsafe float Time_for_Materials_to_Get_Wet
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_92);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_92) = value;
			}
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x06020117 RID: 131351 RVA: 0x008C8BEB File Offset: 0x008C6DEB
		// (set) Token: 0x06020118 RID: 131352 RVA: 0x008C8BFB File Offset: 0x008C6DFB
		public unsafe float Time_for_Materials_to_Dry_Out
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_93);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_93) = value;
			}
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x06020119 RID: 131353 RVA: 0x008C8C0C File Offset: 0x008C6E0C
		// (set) Token: 0x0602011A RID: 131354 RVA: 0x008C8C1C File Offset: 0x008C6E1C
		public unsafe float Time_for_Materials_to_Gather_Snow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x0602011B RID: 131355 RVA: 0x008C8C2D File Offset: 0x008C6E2D
		// (set) Token: 0x0602011C RID: 131356 RVA: 0x008C8C3D File Offset: 0x008C6E3D
		public unsafe float Time_for_Snow_to_Melt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_95);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_95) = value;
			}
		}

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x0602011D RID: 131357 RVA: 0x008C8C4E File Offset: 0x008C6E4E
		// (set) Token: 0x0602011E RID: 131358 RVA: 0x008C8C5E File Offset: 0x008C6E5E
		public unsafe float Snow_Delta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_96);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_96) = value;
			}
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0602011F RID: 131359 RVA: 0x008C8C6F File Offset: 0x008C6E6F
		// (set) Token: 0x06020120 RID: 131360 RVA: 0x008C8C7F File Offset: 0x008C6E7F
		public unsafe float Amount_of_Snow_to_Turn_to_Wetness_when_Melted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_97);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_97) = value;
			}
		}

		// Token: 0x17002ECE RID: 11982
		// (get) Token: 0x06020121 RID: 131361 RVA: 0x008C8C90 File Offset: 0x008C6E90
		// (set) Token: 0x06020122 RID: 131362 RVA: 0x008C8CA0 File Offset: 0x008C6EA0
		public unsafe float Random_Cloud_Coverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_98);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_98) = value;
			}
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x06020123 RID: 131363 RVA: 0x008C8CB1 File Offset: 0x008C6EB1
		// (set) Token: 0x06020124 RID: 131364 RVA: 0x008C8CC1 File Offset: 0x008C6EC1
		public unsafe float Random_Weather_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_99);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_99) = value;
			}
		}

		// Token: 0x17002ED0 RID: 11984
		// (get) Token: 0x06020125 RID: 131365 RVA: 0x008C8CD2 File Offset: 0x008C6ED2
		// (set) Token: 0x06020126 RID: 131366 RVA: 0x008C8CE2 File Offset: 0x008C6EE2
		public unsafe float Random_Wind_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_100);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_100) = value;
			}
		}

		// Token: 0x17002ED1 RID: 11985
		// (get) Token: 0x06020127 RID: 131367 RVA: 0x008C8CF3 File Offset: 0x008C6EF3
		// (set) Token: 0x06020128 RID: 131368 RVA: 0x008C8D03 File Offset: 0x008C6F03
		public unsafe float Random_Rain_or_Snow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_101);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_101) = value;
			}
		}

		// Token: 0x17002ED2 RID: 11986
		// (get) Token: 0x06020129 RID: 131369 RVA: 0x008C8D14 File Offset: 0x008C6F14
		// (set) Token: 0x0602012A RID: 131370 RVA: 0x008C8D28 File Offset: 0x008C6F28
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_WeatherTypes> Current_Random_Weather_Type
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_102);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_102) = value;
			}
		}

		// Token: 0x17002ED3 RID: 11987
		// (get) Token: 0x0602012B RID: 131371 RVA: 0x008C8D3D File Offset: 0x008C6F3D
		// (set) Token: 0x0602012C RID: 131372 RVA: 0x008C8D51 File Offset: 0x008C6F51
		[Nullable(0)]
		public unsafe TEnumAsByte<UDS_Season> Season
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_103);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_103) = value;
			}
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x0602012D RID: 131373 RVA: 0x008C8D66 File Offset: 0x008C6F66
		// (set) Token: 0x0602012E RID: 131374 RVA: 0x008C8D7A File Offset: 0x008C6F7A
		public unsafe FFloatRange Weather_Type_Change_Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_104);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_104) = value;
			}
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x0602012F RID: 131375 RVA: 0x008C8D90 File Offset: 0x008C6F90
		// (set) Token: 0x06020130 RID: 131376 RVA: 0x008C8DC9 File Offset: 0x008C6FC9
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<UDS_WeatherTypes>, float> Weather_Type_Probabilities__Summer_
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<UDS_WeatherTypes>, float> result;
				if ((result = this._Weather_Type_Probabilities__Summer_) == null)
				{
					result = (this._Weather_Type_Probabilities__Summer_ = new TMap<TEnumAsByte<UDS_WeatherTypes>, float>(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_105, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Weather_Type_Probabilities__Summer_.CopyAssign(value);
			}
		}

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x06020131 RID: 131377 RVA: 0x008C8DD8 File Offset: 0x008C6FD8
		// (set) Token: 0x06020132 RID: 131378 RVA: 0x008C8E11 File Offset: 0x008C7011
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<UDS_WeatherTypes>, float> Weather_Type_Probabilities__Autumn_
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<UDS_WeatherTypes>, float> result;
				if ((result = this._Weather_Type_Probabilities__Autumn_) == null)
				{
					result = (this._Weather_Type_Probabilities__Autumn_ = new TMap<TEnumAsByte<UDS_WeatherTypes>, float>(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_106, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Weather_Type_Probabilities__Autumn_.CopyAssign(value);
			}
		}

		// Token: 0x17002ED7 RID: 11991
		// (get) Token: 0x06020133 RID: 131379 RVA: 0x008C8E20 File Offset: 0x008C7020
		// (set) Token: 0x06020134 RID: 131380 RVA: 0x008C8E59 File Offset: 0x008C7059
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<UDS_WeatherTypes>, float> Weather_Type_Probabilities__Winter_
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<UDS_WeatherTypes>, float> result;
				if ((result = this._Weather_Type_Probabilities__Winter_) == null)
				{
					result = (this._Weather_Type_Probabilities__Winter_ = new TMap<TEnumAsByte<UDS_WeatherTypes>, float>(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_107, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Weather_Type_Probabilities__Winter_.CopyAssign(value);
			}
		}

		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x06020135 RID: 131381 RVA: 0x008C8E68 File Offset: 0x008C7068
		// (set) Token: 0x06020136 RID: 131382 RVA: 0x008C8EA1 File Offset: 0x008C70A1
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<UDS_WeatherTypes>, float> Weather_Type_Probabilities__Spring_
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<UDS_WeatherTypes>, float> result;
				if ((result = this._Weather_Type_Probabilities__Spring_) == null)
				{
					result = (this._Weather_Type_Probabilities__Spring_ = new TMap<TEnumAsByte<UDS_WeatherTypes>, float>(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_108, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.Weather_Type_Probabilities__Spring_.CopyAssign(value);
			}
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x06020137 RID: 131383 RVA: 0x008C8EAF File Offset: 0x008C70AF
		// (set) Token: 0x06020138 RID: 131384 RVA: 0x008C8EBF File Offset: 0x008C70BF
		public unsafe bool Avoid_Extreme_Weather_Shifts
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_109) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_109) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x06020139 RID: 131385 RVA: 0x008C8ED0 File Offset: 0x008C70D0
		// (set) Token: 0x0602013A RID: 131386 RVA: 0x008C8EE0 File Offset: 0x008C70E0
		public unsafe bool Avoid_Repeating_Weather_Types
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_110) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_110) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0602013B RID: 131387 RVA: 0x008C8EF1 File Offset: 0x008C70F1
		// (set) Token: 0x0602013C RID: 131388 RVA: 0x008C8F01 File Offset: 0x008C7101
		public unsafe bool Avoid_Changing_Directly_from_Snow_to_Rain__Or_Vice_Versa_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_111) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_111) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0602013D RID: 131389 RVA: 0x008C8F12 File Offset: 0x008C7112
		// (set) Token: 0x0602013E RID: 131390 RVA: 0x008C8F22 File Offset: 0x008C7122
		public unsafe float Cloudiness_Change_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_112);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_112) = value;
			}
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0602013F RID: 131391 RVA: 0x008C8F33 File Offset: 0x008C7133
		// (set) Token: 0x06020140 RID: 131392 RVA: 0x008C8F43 File Offset: 0x008C7143
		public unsafe float Weather_Intensity_Change_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_113);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_113) = value;
			}
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x06020141 RID: 131393 RVA: 0x008C8F54 File Offset: 0x008C7154
		// (set) Token: 0x06020142 RID: 131394 RVA: 0x008C8F64 File Offset: 0x008C7164
		public unsafe float RainorSnow_Change_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_114);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_114) = value;
			}
		}

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x06020143 RID: 131395 RVA: 0x008C8F75 File Offset: 0x008C7175
		// (set) Token: 0x06020144 RID: 131396 RVA: 0x008C8F85 File Offset: 0x008C7185
		public unsafe float Wind_Intensity_Change_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_115);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_115) = value;
			}
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x06020145 RID: 131397 RVA: 0x008C8F96 File Offset: 0x008C7196
		// (set) Token: 0x06020146 RID: 131398 RVA: 0x008C8FA6 File Offset: 0x008C71A6
		public unsafe float Change_Speed_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_116);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_116) = value;
			}
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x06020147 RID: 131399 RVA: 0x008C8FB7 File Offset: 0x008C71B7
		// (set) Token: 0x06020148 RID: 131400 RVA: 0x008C8FC7 File Offset: 0x008C71C7
		public unsafe bool Use_Sound_Effects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_117) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_117) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x06020149 RID: 131401 RVA: 0x008C8FD8 File Offset: 0x008C71D8
		// (set) Token: 0x0602014A RID: 131402 RVA: 0x008C8FE8 File Offset: 0x008C71E8
		public unsafe float Rain_Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_118);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_118) = value;
			}
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x0602014B RID: 131403 RVA: 0x008C8FF9 File Offset: 0x008C71F9
		// (set) Token: 0x0602014C RID: 131404 RVA: 0x008C900D File Offset: 0x008C720D
		public unsafe UCurveFloat Rain_Fade_Curve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_119);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + Ultra_Dynamic_Weather_C.__PropertyOffset_119, value);
			}
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0602014D RID: 131405 RVA: 0x008C9022 File Offset: 0x008C7222
		// (set) Token: 0x0602014E RID: 131406 RVA: 0x008C9032 File Offset: 0x008C7232
		public unsafe float Distant_Thunder_Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_120);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_120) = value;
			}
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0602014F RID: 131407 RVA: 0x008C9043 File Offset: 0x008C7243
		// (set) Token: 0x06020150 RID: 131408 RVA: 0x008C9053 File Offset: 0x008C7253
		public unsafe float Close_Thunder_Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_121);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_121) = value;
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x06020151 RID: 131409 RVA: 0x008C9064 File Offset: 0x008C7264
		// (set) Token: 0x06020152 RID: 131410 RVA: 0x008C9074 File Offset: 0x008C7274
		public unsafe float Max_Cloud_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_122);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_122) = value;
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x06020153 RID: 131411 RVA: 0x008C9085 File Offset: 0x008C7285
		// (set) Token: 0x06020154 RID: 131412 RVA: 0x008C9095 File Offset: 0x008C7295
		public unsafe float Wind_Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_123);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_123) = value;
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x06020155 RID: 131413 RVA: 0x008C90A6 File Offset: 0x008C72A6
		// (set) Token: 0x06020156 RID: 131414 RVA: 0x008C90B6 File Offset: 0x008C72B6
		public unsafe float Wind_Whistling_Volume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_124);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_124) = value;
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x06020157 RID: 131415 RVA: 0x008C90C7 File Offset: 0x008C72C7
		// (set) Token: 0x06020158 RID: 131416 RVA: 0x008C90D7 File Offset: 0x008C72D7
		public unsafe bool Resetting_Particle_Emitters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_125) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_125) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x06020159 RID: 131417 RVA: 0x008C90E8 File Offset: 0x008C72E8
		// (set) Token: 0x0602015A RID: 131418 RVA: 0x008C90F8 File Offset: 0x008C72F8
		public unsafe float Intended_Cloud_Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_126);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_126) = value;
			}
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x0602015B RID: 131419 RVA: 0x008C9109 File Offset: 0x008C7309
		// (set) Token: 0x0602015C RID: 131420 RVA: 0x008C9119 File Offset: 0x008C7319
		public unsafe float Intended_Cloud_Coverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_127);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_127) = value;
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x0602015D RID: 131421 RVA: 0x008C912A File Offset: 0x008C732A
		// (set) Token: 0x0602015E RID: 131422 RVA: 0x008C913A File Offset: 0x008C733A
		public unsafe float Intended_Cloud_Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_128);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_128) = value;
			}
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x0602015F RID: 131423 RVA: 0x008C914B File Offset: 0x008C734B
		// (set) Token: 0x06020160 RID: 131424 RVA: 0x008C915B File Offset: 0x008C735B
		public unsafe float Cloud_Speed_Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_129);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_129) = value;
			}
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x06020161 RID: 131425 RVA: 0x008C916C File Offset: 0x008C736C
		// (set) Token: 0x06020162 RID: 131426 RVA: 0x008C917C File Offset: 0x008C737C
		public unsafe bool Runtime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_130) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_130) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x06020163 RID: 131427 RVA: 0x008C918D File Offset: 0x008C738D
		// (set) Token: 0x06020164 RID: 131428 RVA: 0x008C919D File Offset: 0x008C739D
		public unsafe float Lightning_Flash_Angle_Range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_131);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_131) = value;
			}
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x06020165 RID: 131429 RVA: 0x008C91AE File Offset: 0x008C73AE
		// (set) Token: 0x06020166 RID: 131430 RVA: 0x008C91BE File Offset: 0x008C73BE
		public unsafe float Fog_Particle_Camera_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_132);
			}
			set
			{
				*(base.NativePtr + (IntPtr)Ultra_Dynamic_Weather_C.__PropertyOffset_132) = value;
			}
		}

		// Token: 0x06020167 RID: 131431 RVA: 0x008C91D0 File Offset: 0x008C73D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Filter_Probability_Map([Nullable(new byte[]
		{
			2,
			0
		})] TMap<TEnumAsByte<UDS_WeatherTypes>, float> Probability_Map, [Nullable(new byte[]
		{
			2,
			0
		})] ref TMap<TEnumAsByte<UDS_WeatherTypes>, float> Filtered_Probability_Map)
		{
			Ultra_Dynamic_Weather_C.__Filter_Probability_Map_FunctionParams* ptr = stackalloc Ultra_Dynamic_Weather_C.__Filter_Probability_Map_FunctionParams[(UIntPtr)719] + 15L / (long)sizeof(Ultra_Dynamic_Weather_C.__Filter_Probability_Map_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Weather_C.__Filter_Probability_Map_NativeFunctionPtr, (void*)ptr, 1);
			if (Probability_Map != null)
			{
				Probability_Map.CopyTo(&ptr->Probability_Map, default(UScriptStructStackOnlyPtr));
			}
			TMap<TEnumAsByte<UDS_WeatherTypes>, float> tmap = Filtered_Probability_Map;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->Filtered_Probability_Map);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Filter_Probability_Map_NativeFunctionPtr, (void*)ptr);
			TMap<TEnumAsByte<UDS_WeatherTypes>, float> tmap2 = Filtered_Probability_Map;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->Filtered_Probability_Map);
			}
			UnrealReflectionUtils.DestroyStruct(Ultra_Dynamic_Weather_C.__Filter_Probability_Map_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020168 RID: 131432 RVA: 0x008C9264 File Offset: 0x008C7464
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ConstructionScript_Function(bool Run_By_Counterpart)
		{
			Ultra_Dynamic_Weather_C.__ConstructionScript_Function_FunctionParams* ptr = stackalloc Ultra_Dynamic_Weather_C.__ConstructionScript_Function_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(Ultra_Dynamic_Weather_C.__ConstructionScript_Function_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Weather_C.__ConstructionScript_Function_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Run_By_Counterpart = Run_By_Counterpart;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__ConstructionScript_Function_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020169 RID: 131433 RVA: 0x008C92AA File Offset: 0x008C74AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Audio_Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Audio_Update_NativeFunctionPtr, null);
		}

		// Token: 0x0602016A RID: 131434 RVA: 0x008C92C0 File Offset: 0x008C74C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Select_New_Random_Weather_Type(bool Filter_Probability_List)
		{
			Ultra_Dynamic_Weather_C.__Select_New_Random_Weather_Type_FunctionParams* ptr = stackalloc Ultra_Dynamic_Weather_C.__Select_New_Random_Weather_Type_FunctionParams[(UIntPtr)735] + 15L / (long)sizeof(Ultra_Dynamic_Weather_C.__Select_New_Random_Weather_Type_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Weather_C.__Select_New_Random_Weather_Type_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Filter_Probability_List = Filter_Probability_List;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Select_New_Random_Weather_Type_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602016B RID: 131435 RVA: 0x008C9309 File Offset: 0x008C7509
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Increment_Random_Weather()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Increment_Random_Weather_NativeFunctionPtr, null);
		}

		// Token: 0x0602016C RID: 131436 RVA: 0x008C931D File Offset: 0x008C751D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Material_Effects()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Set_Material_Effects_NativeFunctionPtr, null);
		}

		// Token: 0x0602016D RID: 131437 RVA: 0x008C9334 File Offset: 0x008C7534
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Get_Current_Weather_Type(ref UDS_WeatherTypes Current_Weather_Type)
		{
			Ultra_Dynamic_Weather_C.__Get_Current_Weather_Type_FunctionParams* ptr = stackalloc Ultra_Dynamic_Weather_C.__Get_Current_Weather_Type_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(Ultra_Dynamic_Weather_C.__Get_Current_Weather_Type_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Weather_C.__Get_Current_Weather_Type_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Current_Weather_Type = Current_Weather_Type;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Get_Current_Weather_Type_NativeFunctionPtr, (void*)ptr);
			Current_Weather_Type = ptr->Current_Weather_Type;
		}

		// Token: 0x0602016E RID: 131438 RVA: 0x008C938D File Offset: 0x008C758D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Apply_Weather_Preset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Apply_Weather_Preset_NativeFunctionPtr, null);
		}

		// Token: 0x0602016F RID: 131439 RVA: 0x008C93A1 File Offset: 0x008C75A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Print_Current_Status_To_Screen()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Print_Current_Status_To_Screen_NativeFunctionPtr, null);
		}

		// Token: 0x06020170 RID: 131440 RVA: 0x008C93B5 File Offset: 0x008C75B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Static_Variables()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Update_Static_Variables_NativeFunctionPtr, null);
		}

		// Token: 0x06020171 RID: 131441 RVA: 0x008C93C9 File Offset: 0x008C75C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Update_Active_Variables()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Update_Active_Variables_NativeFunctionPtr, null);
		}

		// Token: 0x06020172 RID: 131442 RVA: 0x008C93DD File Offset: 0x008C75DD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06020173 RID: 131443 RVA: 0x008C93F1 File Offset: 0x008C75F1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020174 RID: 131444 RVA: 0x008C9406 File Offset: 0x008C7606
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Lightning_Strength__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Lightning_Strength__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06020175 RID: 131445 RVA: 0x008C941A File Offset: 0x008C761A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Lightning_Strength__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Lightning_Strength__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06020176 RID: 131446 RVA: 0x008C942E File Offset: 0x008C762E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Flash_Lightning()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Flash_Lightning_NativeFunctionPtr, null);
		}

		// Token: 0x06020177 RID: 131447 RVA: 0x008C9444 File Offset: 0x008C7644
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			Ultra_Dynamic_Weather_C.__ReceiveTick_FunctionParams* ptr = stackalloc Ultra_Dynamic_Weather_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Ultra_Dynamic_Weather_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Weather_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020178 RID: 131448 RVA: 0x008C948C File Offset: 0x008C768C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			Ultra_Dynamic_Weather_C.__ReceiveTick_FunctionParams* ptr = stackalloc Ultra_Dynamic_Weather_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(Ultra_Dynamic_Weather_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Weather_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020179 RID: 131449 RVA: 0x008C94D3 File Offset: 0x008C76D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Force_Tick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Force_Tick_NativeFunctionPtr, null);
		}

		// Token: 0x0602017A RID: 131450 RVA: 0x008C94E7 File Offset: 0x008C76E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602017B RID: 131451 RVA: 0x008C94FB File Offset: 0x008C76FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602017C RID: 131452 RVA: 0x008C9510 File Offset: 0x008C7710
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Change_Weather_Using_Settings(float Weather_Intensity, float Cloudiness, float Wind_Intensity, float Rain___Snow, float Time_To_Transition_To_New_Settings, float Time_to_Hold_New_Settings, float Time_to_Transition_Back_to_Random_Variation, bool Reset_Particle_Emitters)
		{
			Ultra_Dynamic_Weather_C.__Change_Weather_Using_Settings_FunctionParams* ptr = stackalloc Ultra_Dynamic_Weather_C.__Change_Weather_Using_Settings_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(Ultra_Dynamic_Weather_C.__Change_Weather_Using_Settings_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Weather_C.__Change_Weather_Using_Settings_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Weather_Intensity = Weather_Intensity;
			ptr->Cloudiness = Cloudiness;
			ptr->Wind_Intensity = Wind_Intensity;
			ptr->Rain___Snow = Rain___Snow;
			ptr->Time_To_Transition_To_New_Settings = Time_To_Transition_To_New_Settings;
			ptr->Time_to_Hold_New_Settings = Time_to_Hold_New_Settings;
			ptr->Time_to_Transition_Back_to_Random_Variation = Time_to_Transition_Back_to_Random_Variation;
			ptr->Reset_Particle_Emitters = Reset_Particle_Emitters;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Change_Weather_Using_Settings_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602017D RID: 131453 RVA: 0x008C958C File Offset: 0x008C778C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Change_Weather_Using_Type(UDS_WeatherTypes New_Weather_Type, float Time_To_Transition_To_New_Settings, float Time_to_Hold_New_Settings, float Time_to_Transition_Back_to_Random_Variation, bool Reset_Particle_Emitters)
		{
			Ultra_Dynamic_Weather_C.__Change_Weather_Using_Type_FunctionParams* ptr = stackalloc Ultra_Dynamic_Weather_C.__Change_Weather_Using_Type_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(Ultra_Dynamic_Weather_C.__Change_Weather_Using_Type_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(Ultra_Dynamic_Weather_C.__Change_Weather_Using_Type_NativeFunctionPtr, (void*)ptr, 1);
			ptr->New_Weather_Type = New_Weather_Type;
			ptr->Time_To_Transition_To_New_Settings = Time_To_Transition_To_New_Settings;
			ptr->Time_to_Hold_New_Settings = Time_to_Hold_New_Settings;
			ptr->Time_to_Transition_Back_to_Random_Variation = Time_to_Transition_Back_to_Random_Variation;
			ptr->Reset_Particle_Emitters = Reset_Particle_Emitters;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, Ultra_Dynamic_Weather_C.__Change_Weather_Using_Type_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602017E RID: 131454 RVA: 0x008C95F5 File Offset: 0x008C77F5
		protected Ultra_Dynamic_Weather_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F725 RID: 63269
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Ultra_Dynamic_Weather.Ultra_Dynamic_Weather_C";

		// Token: 0x0400F726 RID: 63270
		private static IntPtr _ClassPtr;

		// Token: 0x0400F727 RID: 63271
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F728 RID: 63272
		internal static int __PropertyOffset_1;

		// Token: 0x0400F729 RID: 63273
		internal static int __PropertyOffset_2;

		// Token: 0x0400F72A RID: 63274
		internal static int __PropertyOffset_3;

		// Token: 0x0400F72B RID: 63275
		internal static int __PropertyOffset_4;

		// Token: 0x0400F72C RID: 63276
		internal static int __PropertyOffset_5;

		// Token: 0x0400F72D RID: 63277
		internal static int __PropertyOffset_6;

		// Token: 0x0400F72E RID: 63278
		internal static int __PropertyOffset_7;

		// Token: 0x0400F72F RID: 63279
		internal static int __PropertyOffset_8;

		// Token: 0x0400F730 RID: 63280
		internal static int __PropertyOffset_9;

		// Token: 0x0400F731 RID: 63281
		internal static int __PropertyOffset_10;

		// Token: 0x0400F732 RID: 63282
		internal static int __PropertyOffset_11;

		// Token: 0x0400F733 RID: 63283
		internal static int __PropertyOffset_12;

		// Token: 0x0400F734 RID: 63284
		internal static int __PropertyOffset_13;

		// Token: 0x0400F735 RID: 63285
		internal static int __PropertyOffset_14;

		// Token: 0x0400F736 RID: 63286
		internal static int __PropertyOffset_15;

		// Token: 0x0400F737 RID: 63287
		internal static int __PropertyOffset_16;

		// Token: 0x0400F738 RID: 63288
		internal static int __PropertyOffset_17;

		// Token: 0x0400F739 RID: 63289
		internal static int __PropertyOffset_18;

		// Token: 0x0400F73A RID: 63290
		internal static int __PropertyOffset_19;

		// Token: 0x0400F73B RID: 63291
		internal static int __PropertyOffset_20;

		// Token: 0x0400F73C RID: 63292
		internal static int __PropertyOffset_21;

		// Token: 0x0400F73D RID: 63293
		internal static int __PropertyOffset_22;

		// Token: 0x0400F73E RID: 63294
		internal static int __PropertyOffset_23;

		// Token: 0x0400F73F RID: 63295
		internal static int __PropertyOffset_24;

		// Token: 0x0400F740 RID: 63296
		internal static int __PropertyOffset_25;

		// Token: 0x0400F741 RID: 63297
		internal static int __PropertyOffset_26;

		// Token: 0x0400F742 RID: 63298
		internal static int __PropertyOffset_27;

		// Token: 0x0400F743 RID: 63299
		internal static int __PropertyOffset_28;

		// Token: 0x0400F744 RID: 63300
		internal static int __PropertyOffset_29;

		// Token: 0x0400F745 RID: 63301
		internal static int __PropertyOffset_30;

		// Token: 0x0400F746 RID: 63302
		internal static int __PropertyOffset_31;

		// Token: 0x0400F747 RID: 63303
		internal static int __PropertyOffset_32;

		// Token: 0x0400F748 RID: 63304
		internal static int __PropertyOffset_33;

		// Token: 0x0400F749 RID: 63305
		internal static int __PropertyOffset_34;

		// Token: 0x0400F74A RID: 63306
		internal static int __PropertyOffset_35;

		// Token: 0x0400F74B RID: 63307
		internal static int __PropertyOffset_36;

		// Token: 0x0400F74C RID: 63308
		internal static int __PropertyOffset_37;

		// Token: 0x0400F74D RID: 63309
		internal static int __PropertyOffset_38;

		// Token: 0x0400F74E RID: 63310
		internal static int __PropertyOffset_39;

		// Token: 0x0400F74F RID: 63311
		internal static int __PropertyOffset_40;

		// Token: 0x0400F750 RID: 63312
		internal static int __PropertyOffset_41;

		// Token: 0x0400F751 RID: 63313
		internal static int __PropertyOffset_42;

		// Token: 0x0400F752 RID: 63314
		internal static int __PropertyOffset_43;

		// Token: 0x0400F753 RID: 63315
		internal static int __PropertyOffset_44;

		// Token: 0x0400F754 RID: 63316
		internal static int __PropertyOffset_45;

		// Token: 0x0400F755 RID: 63317
		internal static int __PropertyOffset_46;

		// Token: 0x0400F756 RID: 63318
		internal static int __PropertyOffset_47;

		// Token: 0x0400F757 RID: 63319
		internal static int __PropertyOffset_48;

		// Token: 0x0400F758 RID: 63320
		internal static int __PropertyOffset_49;

		// Token: 0x0400F759 RID: 63321
		internal static int __PropertyOffset_50;

		// Token: 0x0400F75A RID: 63322
		internal static int __PropertyOffset_51;

		// Token: 0x0400F75B RID: 63323
		internal static int __PropertyOffset_52;

		// Token: 0x0400F75C RID: 63324
		internal static int __PropertyOffset_53;

		// Token: 0x0400F75D RID: 63325
		internal static int __PropertyOffset_54;

		// Token: 0x0400F75E RID: 63326
		internal static int __PropertyOffset_55;

		// Token: 0x0400F75F RID: 63327
		internal static int __PropertyOffset_56;

		// Token: 0x0400F760 RID: 63328
		internal static int __PropertyOffset_57;

		// Token: 0x0400F761 RID: 63329
		internal static int __PropertyOffset_58;

		// Token: 0x0400F762 RID: 63330
		internal static int __PropertyOffset_59;

		// Token: 0x0400F763 RID: 63331
		internal static int __PropertyOffset_60;

		// Token: 0x0400F764 RID: 63332
		internal static int __PropertyOffset_61;

		// Token: 0x0400F765 RID: 63333
		internal static int __PropertyOffset_62;

		// Token: 0x0400F766 RID: 63334
		internal static int __PropertyOffset_63;

		// Token: 0x0400F767 RID: 63335
		internal static int __PropertyOffset_64;

		// Token: 0x0400F768 RID: 63336
		internal static int __PropertyOffset_65;

		// Token: 0x0400F769 RID: 63337
		internal static int __PropertyOffset_66;

		// Token: 0x0400F76A RID: 63338
		internal static int __PropertyOffset_67;

		// Token: 0x0400F76B RID: 63339
		internal static int __PropertyOffset_68;

		// Token: 0x0400F76C RID: 63340
		internal static int __PropertyOffset_69;

		// Token: 0x0400F76D RID: 63341
		internal static int __PropertyOffset_70;

		// Token: 0x0400F76E RID: 63342
		internal static int __PropertyOffset_71;

		// Token: 0x0400F76F RID: 63343
		internal static int __PropertyOffset_72;

		// Token: 0x0400F770 RID: 63344
		internal static int __PropertyOffset_73;

		// Token: 0x0400F771 RID: 63345
		internal static int __PropertyOffset_74;

		// Token: 0x0400F772 RID: 63346
		internal static int __PropertyOffset_75;

		// Token: 0x0400F773 RID: 63347
		internal static int __PropertyOffset_76;

		// Token: 0x0400F774 RID: 63348
		internal static int __PropertyOffset_77;

		// Token: 0x0400F775 RID: 63349
		internal static int __PropertyOffset_78;

		// Token: 0x0400F776 RID: 63350
		internal static int __PropertyOffset_79;

		// Token: 0x0400F777 RID: 63351
		internal static int __PropertyOffset_80;

		// Token: 0x0400F778 RID: 63352
		internal static int __PropertyOffset_81;

		// Token: 0x0400F779 RID: 63353
		internal static int __PropertyOffset_82;

		// Token: 0x0400F77A RID: 63354
		internal static int __PropertyOffset_83;

		// Token: 0x0400F77B RID: 63355
		internal static int __PropertyOffset_84;

		// Token: 0x0400F77C RID: 63356
		internal static int __PropertyOffset_85;

		// Token: 0x0400F77D RID: 63357
		internal static int __PropertyOffset_86;

		// Token: 0x0400F77E RID: 63358
		internal static int __PropertyOffset_87;

		// Token: 0x0400F77F RID: 63359
		internal static int __PropertyOffset_88;

		// Token: 0x0400F780 RID: 63360
		internal static int __PropertyOffset_89;

		// Token: 0x0400F781 RID: 63361
		internal static int __PropertyOffset_90;

		// Token: 0x0400F782 RID: 63362
		internal static int __PropertyOffset_91;

		// Token: 0x0400F783 RID: 63363
		internal static int __PropertyOffset_92;

		// Token: 0x0400F784 RID: 63364
		internal static int __PropertyOffset_93;

		// Token: 0x0400F785 RID: 63365
		internal static int __PropertyOffset_94;

		// Token: 0x0400F786 RID: 63366
		internal static int __PropertyOffset_95;

		// Token: 0x0400F787 RID: 63367
		internal static int __PropertyOffset_96;

		// Token: 0x0400F788 RID: 63368
		internal static int __PropertyOffset_97;

		// Token: 0x0400F789 RID: 63369
		internal static int __PropertyOffset_98;

		// Token: 0x0400F78A RID: 63370
		internal static int __PropertyOffset_99;

		// Token: 0x0400F78B RID: 63371
		internal static int __PropertyOffset_100;

		// Token: 0x0400F78C RID: 63372
		internal static int __PropertyOffset_101;

		// Token: 0x0400F78D RID: 63373
		internal static int __PropertyOffset_102;

		// Token: 0x0400F78E RID: 63374
		internal static int __PropertyOffset_103;

		// Token: 0x0400F78F RID: 63375
		internal static int __PropertyOffset_104;

		// Token: 0x0400F790 RID: 63376
		internal static int __PropertyOffset_105;

		// Token: 0x0400F791 RID: 63377
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<UDS_WeatherTypes>, float> _Weather_Type_Probabilities__Summer_;

		// Token: 0x0400F792 RID: 63378
		internal static int __PropertyOffset_106;

		// Token: 0x0400F793 RID: 63379
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<UDS_WeatherTypes>, float> _Weather_Type_Probabilities__Autumn_;

		// Token: 0x0400F794 RID: 63380
		internal static int __PropertyOffset_107;

		// Token: 0x0400F795 RID: 63381
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<UDS_WeatherTypes>, float> _Weather_Type_Probabilities__Winter_;

		// Token: 0x0400F796 RID: 63382
		internal static int __PropertyOffset_108;

		// Token: 0x0400F797 RID: 63383
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<UDS_WeatherTypes>, float> _Weather_Type_Probabilities__Spring_;

		// Token: 0x0400F798 RID: 63384
		internal static int __PropertyOffset_109;

		// Token: 0x0400F799 RID: 63385
		internal static int __PropertyOffset_110;

		// Token: 0x0400F79A RID: 63386
		internal static int __PropertyOffset_111;

		// Token: 0x0400F79B RID: 63387
		internal static int __PropertyOffset_112;

		// Token: 0x0400F79C RID: 63388
		internal static int __PropertyOffset_113;

		// Token: 0x0400F79D RID: 63389
		internal static int __PropertyOffset_114;

		// Token: 0x0400F79E RID: 63390
		internal static int __PropertyOffset_115;

		// Token: 0x0400F79F RID: 63391
		internal static int __PropertyOffset_116;

		// Token: 0x0400F7A0 RID: 63392
		internal static int __PropertyOffset_117;

		// Token: 0x0400F7A1 RID: 63393
		internal static int __PropertyOffset_118;

		// Token: 0x0400F7A2 RID: 63394
		internal static int __PropertyOffset_119;

		// Token: 0x0400F7A3 RID: 63395
		internal static int __PropertyOffset_120;

		// Token: 0x0400F7A4 RID: 63396
		internal static int __PropertyOffset_121;

		// Token: 0x0400F7A5 RID: 63397
		internal static int __PropertyOffset_122;

		// Token: 0x0400F7A6 RID: 63398
		internal static int __PropertyOffset_123;

		// Token: 0x0400F7A7 RID: 63399
		internal static int __PropertyOffset_124;

		// Token: 0x0400F7A8 RID: 63400
		internal static int __PropertyOffset_125;

		// Token: 0x0400F7A9 RID: 63401
		internal static int __PropertyOffset_126;

		// Token: 0x0400F7AA RID: 63402
		internal static int __PropertyOffset_127;

		// Token: 0x0400F7AB RID: 63403
		internal static int __PropertyOffset_128;

		// Token: 0x0400F7AC RID: 63404
		internal static int __PropertyOffset_129;

		// Token: 0x0400F7AD RID: 63405
		internal static int __PropertyOffset_130;

		// Token: 0x0400F7AE RID: 63406
		internal static int __PropertyOffset_131;

		// Token: 0x0400F7AF RID: 63407
		internal static int __PropertyOffset_132;

		// Token: 0x0400F7B0 RID: 63408
		private static IntPtr __Filter_Probability_Map_NativeFunctionPtr;

		// Token: 0x0400F7B1 RID: 63409
		private static IntPtr __ConstructionScript_Function_NativeFunctionPtr;

		// Token: 0x0400F7B2 RID: 63410
		private static IntPtr __Audio_Update_NativeFunctionPtr;

		// Token: 0x0400F7B3 RID: 63411
		private static IntPtr __Select_New_Random_Weather_Type_NativeFunctionPtr;

		// Token: 0x0400F7B4 RID: 63412
		private static IntPtr __Increment_Random_Weather_NativeFunctionPtr;

		// Token: 0x0400F7B5 RID: 63413
		private static IntPtr __Set_Material_Effects_NativeFunctionPtr;

		// Token: 0x0400F7B6 RID: 63414
		private static IntPtr __Get_Current_Weather_Type_NativeFunctionPtr;

		// Token: 0x0400F7B7 RID: 63415
		private static IntPtr __Apply_Weather_Preset_NativeFunctionPtr;

		// Token: 0x0400F7B8 RID: 63416
		private static IntPtr __Print_Current_Status_To_Screen_NativeFunctionPtr;

		// Token: 0x0400F7B9 RID: 63417
		private static IntPtr __Update_Static_Variables_NativeFunctionPtr;

		// Token: 0x0400F7BA RID: 63418
		private static IntPtr __Update_Active_Variables_NativeFunctionPtr;

		// Token: 0x0400F7BB RID: 63419
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400F7BC RID: 63420
		private static IntPtr __Lightning_Strength__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0400F7BD RID: 63421
		private static IntPtr __Lightning_Strength__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0400F7BE RID: 63422
		private static IntPtr __Flash_Lightning_NativeFunctionPtr;

		// Token: 0x0400F7BF RID: 63423
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F7C0 RID: 63424
		private static IntPtr __Force_Tick_NativeFunctionPtr;

		// Token: 0x0400F7C1 RID: 63425
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F7C2 RID: 63426
		private static IntPtr __Change_Weather_Using_Settings_NativeFunctionPtr;

		// Token: 0x0400F7C3 RID: 63427
		private static IntPtr __Change_Weather_Using_Type_NativeFunctionPtr;

		// Token: 0x02009B6A RID: 39786
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 704)]
		protected ref struct __Filter_Probability_Map_FunctionParams
		{
			// Token: 0x040311A1 RID: 201121
			[FieldOffset(0)]
			public byte Probability_Map;

			// Token: 0x040311A2 RID: 201122
			[FieldOffset(80)]
			public byte Filtered_Probability_Map;
		}

		// Token: 0x02009B6B RID: 39787
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __ConstructionScript_Function_FunctionParams
		{
			// Token: 0x040311A3 RID: 201123
			[FieldOffset(0)]
			public bool Run_By_Counterpart;
		}

		// Token: 0x02009B6C RID: 39788
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 720)]
		protected ref struct __Select_New_Random_Weather_Type_FunctionParams
		{
			// Token: 0x040311A4 RID: 201124
			[FieldOffset(0)]
			public bool Filter_Probability_List;
		}

		// Token: 0x02009B6D RID: 39789
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __Get_Current_Weather_Type_FunctionParams
		{
			// Token: 0x040311A5 RID: 201125
			[FieldOffset(0)]
			public TEnumAsByte<UDS_WeatherTypes> Current_Weather_Type;
		}

		// Token: 0x02009B6E RID: 39790
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040311A6 RID: 201126
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009B6F RID: 39791
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Change_Weather_Using_Settings_FunctionParams
		{
			// Token: 0x040311A7 RID: 201127
			[FieldOffset(0)]
			public float Weather_Intensity;

			// Token: 0x040311A8 RID: 201128
			[FieldOffset(4)]
			public float Cloudiness;

			// Token: 0x040311A9 RID: 201129
			[FieldOffset(8)]
			public float Wind_Intensity;

			// Token: 0x040311AA RID: 201130
			[FieldOffset(12)]
			public float Rain___Snow;

			// Token: 0x040311AB RID: 201131
			[FieldOffset(16)]
			public float Time_To_Transition_To_New_Settings;

			// Token: 0x040311AC RID: 201132
			[FieldOffset(20)]
			public float Time_to_Hold_New_Settings;

			// Token: 0x040311AD RID: 201133
			[FieldOffset(24)]
			public float Time_to_Transition_Back_to_Random_Variation;

			// Token: 0x040311AE RID: 201134
			[FieldOffset(28)]
			public bool Reset_Particle_Emitters;
		}

		// Token: 0x02009B70 RID: 39792
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __Change_Weather_Using_Type_FunctionParams
		{
			// Token: 0x040311AF RID: 201135
			[FieldOffset(0)]
			public TEnumAsByte<UDS_WeatherTypes> New_Weather_Type;

			// Token: 0x040311B0 RID: 201136
			[FieldOffset(4)]
			public float Time_To_Transition_To_New_Settings;

			// Token: 0x040311B1 RID: 201137
			[FieldOffset(8)]
			public float Time_to_Hold_New_Settings;

			// Token: 0x040311B2 RID: 201138
			[FieldOffset(12)]
			public float Time_to_Transition_Back_to_Random_Variation;

			// Token: 0x040311B3 RID: 201139
			[FieldOffset(16)]
			public bool Reset_Particle_Emitters;
		}
	}
}
