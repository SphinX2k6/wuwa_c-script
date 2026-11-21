using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Common_Seq.Video.SplitScreen
{
	// Token: 0x02003083 RID: 12419
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen_New.BP_SplitScreen_New_C")]
	[UnrealStructLayout(1920, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1916)]
	public class BP_SplitScreen_New_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D9B6 RID: 121270 RVA: 0x008FCB67 File Offset: 0x008FAD67
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SplitScreen_New_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen_New.BP_SplitScreen_New_C");
			}
			return BP_SplitScreen_New_C._ClassPtr;
		}

		// Token: 0x0601D9B7 RID: 121271 RVA: 0x008FCB8C File Offset: 0x008FAD8C
		public BP_SplitScreen_New_C() : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreen_New_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D9B8 RID: 121272 RVA: 0x008FCBB4 File Offset: 0x008FADB4
		[NullableContext(1)]
		public BP_SplitScreen_New_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SplitScreen_New_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FAF RID: 12207
		// (get) Token: 0x0601D9B9 RID: 121273 RVA: 0x008FCBE7 File Offset: 0x008FADE7
		// (set) Token: 0x0601D9BA RID: 121274 RVA: 0x008FCBFB File Offset: 0x008FADFB
		public unsafe UChildActorComponent CharacterActor_3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_CharacterActor_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_CharacterActor_3, value);
			}
		}

		// Token: 0x17002FB0 RID: 12208
		// (get) Token: 0x0601D9BB RID: 121275 RVA: 0x008FCC10 File Offset: 0x008FAE10
		// (set) Token: 0x0601D9BC RID: 121276 RVA: 0x008FCC24 File Offset: 0x008FAE24
		public unsafe USceneComponent Character3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_Character3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_Character3, value);
			}
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x0601D9BD RID: 121277 RVA: 0x008FCC39 File Offset: 0x008FAE39
		// (set) Token: 0x0601D9BE RID: 121278 RVA: 0x008FCC4D File Offset: 0x008FAE4D
		public unsafe UChildActorComponent CharacterActor_2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_CharacterActor_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_CharacterActor_2, value);
			}
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x0601D9BF RID: 121279 RVA: 0x008FCC62 File Offset: 0x008FAE62
		// (set) Token: 0x0601D9C0 RID: 121280 RVA: 0x008FCC76 File Offset: 0x008FAE76
		public unsafe USceneComponent Character2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_Character2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_Character2, value);
			}
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x0601D9C1 RID: 121281 RVA: 0x008FCC8B File Offset: 0x008FAE8B
		// (set) Token: 0x0601D9C2 RID: 121282 RVA: 0x008FCC9F File Offset: 0x008FAE9F
		public unsafe UChildActorComponent CharacterActor_1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_CharacterActor_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_CharacterActor_1, value);
			}
		}

		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x0601D9C3 RID: 121283 RVA: 0x008FCCB4 File Offset: 0x008FAEB4
		// (set) Token: 0x0601D9C4 RID: 121284 RVA: 0x008FCCC8 File Offset: 0x008FAEC8
		public unsafe USceneComponent Character1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_Character1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_Character1, value);
			}
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x0601D9C5 RID: 121285 RVA: 0x008FCCDD File Offset: 0x008FAEDD
		// (set) Token: 0x0601D9C6 RID: 121286 RVA: 0x008FCCF1 File Offset: 0x008FAEF1
		public unsafe UPointLightComponent PointLight3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_PointLight3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_PointLight3, value);
			}
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x0601D9C7 RID: 121287 RVA: 0x008FCD06 File Offset: 0x008FAF06
		// (set) Token: 0x0601D9C8 RID: 121288 RVA: 0x008FCD1A File Offset: 0x008FAF1A
		public unsafe UPointLightComponent PointLight2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_PointLight2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_PointLight2, value);
			}
		}

		// Token: 0x17002FB7 RID: 12215
		// (get) Token: 0x0601D9C9 RID: 121289 RVA: 0x008FCD2F File Offset: 0x008FAF2F
		// (set) Token: 0x0601D9CA RID: 121290 RVA: 0x008FCD43 File Offset: 0x008FAF43
		public unsafe UPointLightComponent PointLight1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_PointLight1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_PointLight1, value);
			}
		}

		// Token: 0x17002FB8 RID: 12216
		// (get) Token: 0x0601D9CB RID: 121291 RVA: 0x008FCD58 File Offset: 0x008FAF58
		// (set) Token: 0x0601D9CC RID: 121292 RVA: 0x008FCD6C File Offset: 0x008FAF6C
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17002FB9 RID: 12217
		// (get) Token: 0x0601D9CD RID: 121293 RVA: 0x008FCD81 File Offset: 0x008FAF81
		// (set) Token: 0x0601D9CE RID: 121294 RVA: 0x008FCD95 File Offset: 0x008FAF95
		public unsafe UMaterialParameterCollection MPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_MPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_MPC, value);
			}
		}

		// Token: 0x17002FBA RID: 12218
		// (get) Token: 0x0601D9CF RID: 121295 RVA: 0x008FCDAA File Offset: 0x008FAFAA
		// (set) Token: 0x0601D9D0 RID: 121296 RVA: 0x008FCDBE File Offset: 0x008FAFBE
		public unsafe FName Angle_LinePosition__LineDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Angle_LinePosition__LineDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Angle_LinePosition__LineDistance) = value;
			}
		}

		// Token: 0x17002FBB RID: 12219
		// (get) Token: 0x0601D9D1 RID: 121297 RVA: 0x008FCDD3 File Offset: 0x008FAFD3
		// (set) Token: 0x0601D9D2 RID: 121298 RVA: 0x008FCDE3 File Offset: 0x008FAFE3
		public unsafe float E_LinkPos_1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_E_LinkPos_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_E_LinkPos_1) = value;
			}
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x0601D9D3 RID: 121299 RVA: 0x008FCDF4 File Offset: 0x008FAFF4
		// (set) Token: 0x0601D9D4 RID: 121300 RVA: 0x008FCE04 File Offset: 0x008FB004
		public unsafe float E_LinkPos_2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_E_LinkPos_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_E_LinkPos_2) = value;
			}
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x0601D9D5 RID: 121301 RVA: 0x008FCE15 File Offset: 0x008FB015
		// (set) Token: 0x0601D9D6 RID: 121302 RVA: 0x008FCE25 File Offset: 0x008FB025
		public unsafe float E_LinkPos_3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_E_LinkPos_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_E_LinkPos_3) = value;
			}
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x0601D9D7 RID: 121303 RVA: 0x008FCE36 File Offset: 0x008FB036
		// (set) Token: 0x0601D9D8 RID: 121304 RVA: 0x008FCE46 File Offset: 0x008FB046
		public unsafe float LightYaw1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LightYaw1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LightYaw1) = value;
			}
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x0601D9D9 RID: 121305 RVA: 0x008FCE57 File Offset: 0x008FB057
		// (set) Token: 0x0601D9DA RID: 121306 RVA: 0x008FCE67 File Offset: 0x008FB067
		public unsafe float LightYaw2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LightYaw2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LightYaw2) = value;
			}
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x0601D9DB RID: 121307 RVA: 0x008FCE78 File Offset: 0x008FB078
		// (set) Token: 0x0601D9DC RID: 121308 RVA: 0x008FCE88 File Offset: 0x008FB088
		public unsafe float LightYaw3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LightYaw3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LightYaw3) = value;
			}
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x0601D9DD RID: 121309 RVA: 0x008FCE99 File Offset: 0x008FB099
		// (set) Token: 0x0601D9DE RID: 121310 RVA: 0x008FCEA9 File Offset: 0x008FB0A9
		public unsafe float FaceLightYaw1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_FaceLightYaw1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_FaceLightYaw1) = value;
			}
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x0601D9DF RID: 121311 RVA: 0x008FCEBA File Offset: 0x008FB0BA
		// (set) Token: 0x0601D9E0 RID: 121312 RVA: 0x008FCECA File Offset: 0x008FB0CA
		public unsafe float FaceLightYaw2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_FaceLightYaw2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_FaceLightYaw2) = value;
			}
		}

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x0601D9E1 RID: 121313 RVA: 0x008FCEDB File Offset: 0x008FB0DB
		// (set) Token: 0x0601D9E2 RID: 121314 RVA: 0x008FCEEB File Offset: 0x008FB0EB
		public unsafe float FaceLightYaw3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_FaceLightYaw3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_FaceLightYaw3) = value;
			}
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x0601D9E3 RID: 121315 RVA: 0x008FCEFC File Offset: 0x008FB0FC
		// (set) Token: 0x0601D9E4 RID: 121316 RVA: 0x008FCF10 File Offset: 0x008FB110
		public unsafe FVector PointLight1_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight1_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight1_Location) = value;
			}
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x0601D9E5 RID: 121317 RVA: 0x008FCF25 File Offset: 0x008FB125
		// (set) Token: 0x0601D9E6 RID: 121318 RVA: 0x008FCF39 File Offset: 0x008FB139
		public unsafe FVector PointLight2_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight2_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight2_Location) = value;
			}
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x0601D9E7 RID: 121319 RVA: 0x008FCF4E File Offset: 0x008FB14E
		// (set) Token: 0x0601D9E8 RID: 121320 RVA: 0x008FCF62 File Offset: 0x008FB162
		public unsafe FVector PointLight3_Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight3_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight3_Location) = value;
			}
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x0601D9E9 RID: 121321 RVA: 0x008FCF77 File Offset: 0x008FB177
		// (set) Token: 0x0601D9EA RID: 121322 RVA: 0x008FCF8B File Offset: 0x008FB18B
		public unsafe FLinearColor PointLight1_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight1_ToonLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight1_ToonLightColor) = value;
			}
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x0601D9EB RID: 121323 RVA: 0x008FCFA0 File Offset: 0x008FB1A0
		// (set) Token: 0x0601D9EC RID: 121324 RVA: 0x008FCFB4 File Offset: 0x008FB1B4
		public unsafe FLinearColor PointLight2_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight2_ToonLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight2_ToonLightColor) = value;
			}
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x0601D9ED RID: 121325 RVA: 0x008FCFC9 File Offset: 0x008FB1C9
		// (set) Token: 0x0601D9EE RID: 121326 RVA: 0x008FCFDD File Offset: 0x008FB1DD
		public unsafe FLinearColor PointLight3_ToonLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight3_ToonLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_PointLight3_ToonLightColor) = value;
			}
		}

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x0601D9EF RID: 121327 RVA: 0x008FCFF2 File Offset: 0x008FB1F2
		// (set) Token: 0x0601D9F0 RID: 121328 RVA: 0x008FD006 File Offset: 0x008FB206
		public unsafe FLinearColor EyeLightSimulation_TongKong1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_TongKong1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_TongKong1) = value;
			}
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x0601D9F1 RID: 121329 RVA: 0x008FD01B File Offset: 0x008FB21B
		// (set) Token: 0x0601D9F2 RID: 121330 RVA: 0x008FD02F File Offset: 0x008FB22F
		public unsafe FLinearColor EyeLightSimulation_TongKong2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_TongKong2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_TongKong2) = value;
			}
		}

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0601D9F3 RID: 121331 RVA: 0x008FD044 File Offset: 0x008FB244
		// (set) Token: 0x0601D9F4 RID: 121332 RVA: 0x008FD058 File Offset: 0x008FB258
		public unsafe FLinearColor EyeLightSimulation_TongKong3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_TongKong3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_TongKong3) = value;
			}
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0601D9F5 RID: 121333 RVA: 0x008FD06D File Offset: 0x008FB26D
		// (set) Token: 0x0601D9F6 RID: 121334 RVA: 0x008FD081 File Offset: 0x008FB281
		public unsafe FLinearColor EyeLightSimulation_YanBai1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_YanBai1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_YanBai1) = value;
			}
		}

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x0601D9F7 RID: 121335 RVA: 0x008FD096 File Offset: 0x008FB296
		// (set) Token: 0x0601D9F8 RID: 121336 RVA: 0x008FD0AA File Offset: 0x008FB2AA
		public unsafe FLinearColor EyeLightSimulation_YanBai2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_YanBai2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_YanBai2) = value;
			}
		}

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x0601D9F9 RID: 121337 RVA: 0x008FD0BF File Offset: 0x008FB2BF
		// (set) Token: 0x0601D9FA RID: 121338 RVA: 0x008FD0D3 File Offset: 0x008FB2D3
		public unsafe FLinearColor EyeLightSimulation_YanBai3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_YanBai3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_YanBai3) = value;
			}
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x0601D9FB RID: 121339 RVA: 0x008FD0E8 File Offset: 0x008FB2E8
		// (set) Token: 0x0601D9FC RID: 121340 RVA: 0x008FD0FC File Offset: 0x008FB2FC
		public unsafe FLinearColor EyeLightSimulation_Color1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_Color1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_Color1) = value;
			}
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x0601D9FD RID: 121341 RVA: 0x008FD111 File Offset: 0x008FB311
		// (set) Token: 0x0601D9FE RID: 121342 RVA: 0x008FD125 File Offset: 0x008FB325
		public unsafe FLinearColor EyeLightSimulation_Color2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_Color2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_Color2) = value;
			}
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x0601D9FF RID: 121343 RVA: 0x008FD13A File Offset: 0x008FB33A
		// (set) Token: 0x0601DA00 RID: 121344 RVA: 0x008FD14E File Offset: 0x008FB34E
		public unsafe FLinearColor EyeLightSimulation_Color3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_Color3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_EyeLightSimulation_Color3) = value;
			}
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x0601DA01 RID: 121345 RVA: 0x008FD163 File Offset: 0x008FB363
		// (set) Token: 0x0601DA02 RID: 121346 RVA: 0x008FD173 File Offset: 0x008FB373
		public unsafe byte MeshPart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_MeshPart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_MeshPart) = value;
			}
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0601DA03 RID: 121347 RVA: 0x008FD184 File Offset: 0x008FB384
		// (set) Token: 0x0601DA04 RID: 121348 RVA: 0x008FD194 File Offset: 0x008FB394
		public unsafe int Handle1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Handle1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Handle1) = value;
			}
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0601DA05 RID: 121349 RVA: 0x008FD1A5 File Offset: 0x008FB3A5
		// (set) Token: 0x0601DA06 RID: 121350 RVA: 0x008FD1B5 File Offset: 0x008FB3B5
		public unsafe int Handle2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Handle2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Handle2) = value;
			}
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x0601DA07 RID: 121351 RVA: 0x008FD1C6 File Offset: 0x008FB3C6
		// (set) Token: 0x0601DA08 RID: 121352 RVA: 0x008FD1D6 File Offset: 0x008FB3D6
		public unsafe int Handle3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Handle3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Handle3) = value;
			}
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x0601DA09 RID: 121353 RVA: 0x008FD1E7 File Offset: 0x008FB3E7
		// (set) Token: 0x0601DA0A RID: 121354 RVA: 0x008FD1FB File Offset: 0x008FB3FB
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_KuroMaterialControllerComponent1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_KuroMaterialControllerComponent1, value);
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x0601DA0B RID: 121355 RVA: 0x008FD210 File Offset: 0x008FB410
		// (set) Token: 0x0601DA0C RID: 121356 RVA: 0x008FD224 File Offset: 0x008FB424
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_KuroMaterialControllerComponent2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_KuroMaterialControllerComponent2, value);
			}
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x0601DA0D RID: 121357 RVA: 0x008FD239 File Offset: 0x008FB439
		// (set) Token: 0x0601DA0E RID: 121358 RVA: 0x008FD24D File Offset: 0x008FB44D
		public unsafe UKuroMaterialControllerComponent KuroMaterialControllerComponent3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_KuroMaterialControllerComponent3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SplitScreen_New_C.__PropertyOffset_KuroMaterialControllerComponent3, value);
			}
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x0601DA0F RID: 121359 RVA: 0x008FD262 File Offset: 0x008FB462
		// (set) Token: 0x0601DA10 RID: 121360 RVA: 0x008FD272 File Offset: 0x008FB472
		public unsafe float textX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_textX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_textX) = value;
			}
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x0601DA11 RID: 121361 RVA: 0x008FD283 File Offset: 0x008FB483
		// (set) Token: 0x0601DA12 RID: 121362 RVA: 0x008FD293 File Offset: 0x008FB493
		public unsafe float textY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_textY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_textY) = value;
			}
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x0601DA13 RID: 121363 RVA: 0x008FD2A4 File Offset: 0x008FB4A4
		// (set) Token: 0x0601DA14 RID: 121364 RVA: 0x008FD2B4 File Offset: 0x008FB4B4
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0601DA15 RID: 121365 RVA: 0x008FD2C5 File Offset: 0x008FB4C5
		// (set) Token: 0x0601DA16 RID: 121366 RVA: 0x008FD2D9 File Offset: 0x008FB4D9
		public unsafe FVector LinkCameraLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LinkCameraLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LinkCameraLocation) = value;
			}
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x0601DA17 RID: 121367 RVA: 0x008FD2EE File Offset: 0x008FB4EE
		// (set) Token: 0x0601DA18 RID: 121368 RVA: 0x008FD302 File Offset: 0x008FB502
		public unsafe FVector LinkCameraRelativeLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LinkCameraRelativeLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_LinkCameraRelativeLocation) = value;
			}
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x0601DA19 RID: 121369 RVA: 0x008FD317 File Offset: 0x008FB517
		// (set) Token: 0x0601DA1A RID: 121370 RVA: 0x008FD327 File Offset: 0x008FB527
		public unsafe bool IsThree
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_IsThree) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_IsThree) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x0601DA1B RID: 121371 RVA: 0x008FD338 File Offset: 0x008FB538
		// (set) Token: 0x0601DA1C RID: 121372 RVA: 0x008FD348 File Offset: 0x008FB548
		public unsafe int RoleId1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_RoleId1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_RoleId1) = value;
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x0601DA1D RID: 121373 RVA: 0x008FD359 File Offset: 0x008FB559
		// (set) Token: 0x0601DA1E RID: 121374 RVA: 0x008FD369 File Offset: 0x008FB569
		public unsafe int RoleId2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_RoleId2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_RoleId2) = value;
			}
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x0601DA1F RID: 121375 RVA: 0x008FD37A File Offset: 0x008FB57A
		// (set) Token: 0x0601DA20 RID: 121376 RVA: 0x008FD38A File Offset: 0x008FB58A
		public unsafe int RoleId3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_RoleId3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SplitScreen_New_C.__PropertyOffset_RoleId3) = value;
			}
		}

		// Token: 0x0601DA21 RID: 121377 RVA: 0x008FD39C File Offset: 0x008FB59C
		[SkipLocalsInit]
		public unsafe virtual void SetLightDirection(USkeletalMeshComponent Mesh, float LightYaw, float FaceLightYaw)
		{
			BP_SplitScreen_New_C.__SetLightDirection_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__SetLightDirection_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_SplitScreen_New_C.__SetLightDirection_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->LightYaw = LightYaw;
			ptr->FaceLightYaw = FaceLightYaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__SetLightDirection_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA22 RID: 121378 RVA: 0x008FD400 File Offset: 0x008FB600
		[SkipLocalsInit]
		public unsafe virtual FVector EulerToForward(float Pitch, float Yaw)
		{
			BP_SplitScreen_New_C.__EulerToForward_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__EulerToForward_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(BP_SplitScreen_New_C.__EulerToForward_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__EulerToForward_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Pitch = Pitch;
			ptr->Yaw = Yaw;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__EulerToForward_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601DA23 RID: 121379 RVA: 0x008FD453 File Offset: 0x008FB653
		[SkipLocalsInit]
		public virtual void SetPosByViewSize()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__SetPosByViewSize_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA24 RID: 121380 RVA: 0x008FD467 File Offset: 0x008FB667
		[SkipLocalsInit]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA25 RID: 121381 RVA: 0x008FD47C File Offset: 0x008FB67C
		[SkipLocalsInit]
		public unsafe virtual void InitKuroMaterialController(UKuroMaterialControllerComponent KuroMaterialControllerComponent, UChildActorComponent CharacterActorComponent, UPointLightComponent PointLightComponent, FVector PointLight_Location, FLinearColor PointLight_ToonLightColor, FLinearColor EyeLightSimulation_TongKong, FLinearColor EyeLightSimulation_YanBai, FLinearColor EyeLightSimulation_Color, float E_LinkPos, bool Channel0, bool Channel1, bool Channel2, float LightYaw, float FaceLightYaw, int RoleId, ref int returnHandle)
		{
			BP_SplitScreen_New_C.__InitKuroMaterialController_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__InitKuroMaterialController_FunctionParams[(UIntPtr)359] + 15L / (long)sizeof(BP_SplitScreen_New_C.__InitKuroMaterialController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__InitKuroMaterialController_NativeFunctionPtr, (void*)ptr, 1);
			ptr->KuroMaterialControllerComponent = ((KuroMaterialControllerComponent != null) ? KuroMaterialControllerComponent.NativePtr : IntPtr.Zero);
			ptr->CharacterActorComponent = ((CharacterActorComponent != null) ? CharacterActorComponent.NativePtr : IntPtr.Zero);
			ptr->PointLightComponent = ((PointLightComponent != null) ? PointLightComponent.NativePtr : IntPtr.Zero);
			ptr->PointLight_Location = PointLight_Location;
			ptr->PointLight_ToonLightColor = PointLight_ToonLightColor;
			ptr->EyeLightSimulation_TongKong = EyeLightSimulation_TongKong;
			ptr->EyeLightSimulation_YanBai = EyeLightSimulation_YanBai;
			ptr->EyeLightSimulation_Color = EyeLightSimulation_Color;
			ptr->E_LinkPos = E_LinkPos;
			ptr->Channel0 = Channel0;
			ptr->Channel1 = Channel1;
			ptr->Channel2 = Channel2;
			ptr->LightYaw = LightYaw;
			ptr->FaceLightYaw = FaceLightYaw;
			ptr->RoleId = RoleId;
			ptr->returnHandle = returnHandle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__InitKuroMaterialController_NativeFunctionPtr, (void*)ptr);
			returnHandle = ptr->returnHandle;
		}

		// Token: 0x0601DA26 RID: 121382 RVA: 0x008FD572 File Offset: 0x008FB772
		[SkipLocalsInit]
		public virtual void End()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__End_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA27 RID: 121383 RVA: 0x008FD586 File Offset: 0x008FB786
		[SkipLocalsInit]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA28 RID: 121384 RVA: 0x008FD59A File Offset: 0x008FB79A
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA29 RID: 121385 RVA: 0x008FD5AE File Offset: 0x008FB7AE
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_New_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601DA2A RID: 121386 RVA: 0x008FD5C4 File Offset: 0x008FB7C4
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SplitScreen_New_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_New_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA2B RID: 121387 RVA: 0x008FD60C File Offset: 0x008FB80C
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SplitScreen_New_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_New_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_New_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA2C RID: 121388 RVA: 0x008FD654 File Offset: 0x008FB854
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SplitScreen_New_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_New_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SplitScreen_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA2D RID: 121389 RVA: 0x008FD69C File Offset: 0x008FB89C
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SplitScreen_New_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SplitScreen_New_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SplitScreen_New_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SplitScreen_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SplitScreen_New_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601DA2E RID: 121390 RVA: 0x008FD6E2 File Offset: 0x008FB8E2
		protected BP_SplitScreen_New_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9AC RID: 63916
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Sequence/Common_Seq/Video/SplitScreen/BP_SplitScreen_New.BP_SplitScreen_New_C";

		// Token: 0x0400F9AD RID: 63917
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9AE RID: 63918
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9AF RID: 63919
		internal static int __PropertyOffset_CharacterActor_3;

		// Token: 0x0400F9B0 RID: 63920
		internal static int __PropertyOffset_Character3;

		// Token: 0x0400F9B1 RID: 63921
		internal static int __PropertyOffset_CharacterActor_2;

		// Token: 0x0400F9B2 RID: 63922
		internal static int __PropertyOffset_Character2;

		// Token: 0x0400F9B3 RID: 63923
		internal static int __PropertyOffset_CharacterActor_1;

		// Token: 0x0400F9B4 RID: 63924
		internal static int __PropertyOffset_Character1;

		// Token: 0x0400F9B5 RID: 63925
		internal static int __PropertyOffset_PointLight3;

		// Token: 0x0400F9B6 RID: 63926
		internal static int __PropertyOffset_PointLight2;

		// Token: 0x0400F9B7 RID: 63927
		internal static int __PropertyOffset_PointLight1;

		// Token: 0x0400F9B8 RID: 63928
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400F9B9 RID: 63929
		internal static int __PropertyOffset_MPC;

		// Token: 0x0400F9BA RID: 63930
		internal static int __PropertyOffset_Angle_LinePosition__LineDistance;

		// Token: 0x0400F9BB RID: 63931
		internal static int __PropertyOffset_E_LinkPos_1;

		// Token: 0x0400F9BC RID: 63932
		internal static int __PropertyOffset_E_LinkPos_2;

		// Token: 0x0400F9BD RID: 63933
		internal static int __PropertyOffset_E_LinkPos_3;

		// Token: 0x0400F9BE RID: 63934
		internal static int __PropertyOffset_LightYaw1;

		// Token: 0x0400F9BF RID: 63935
		internal static int __PropertyOffset_LightYaw2;

		// Token: 0x0400F9C0 RID: 63936
		internal static int __PropertyOffset_LightYaw3;

		// Token: 0x0400F9C1 RID: 63937
		internal static int __PropertyOffset_FaceLightYaw1;

		// Token: 0x0400F9C2 RID: 63938
		internal static int __PropertyOffset_FaceLightYaw2;

		// Token: 0x0400F9C3 RID: 63939
		internal static int __PropertyOffset_FaceLightYaw3;

		// Token: 0x0400F9C4 RID: 63940
		internal static int __PropertyOffset_PointLight1_Location;

		// Token: 0x0400F9C5 RID: 63941
		internal static int __PropertyOffset_PointLight2_Location;

		// Token: 0x0400F9C6 RID: 63942
		internal static int __PropertyOffset_PointLight3_Location;

		// Token: 0x0400F9C7 RID: 63943
		internal static int __PropertyOffset_PointLight1_ToonLightColor;

		// Token: 0x0400F9C8 RID: 63944
		internal static int __PropertyOffset_PointLight2_ToonLightColor;

		// Token: 0x0400F9C9 RID: 63945
		internal static int __PropertyOffset_PointLight3_ToonLightColor;

		// Token: 0x0400F9CA RID: 63946
		internal static int __PropertyOffset_EyeLightSimulation_TongKong1;

		// Token: 0x0400F9CB RID: 63947
		internal static int __PropertyOffset_EyeLightSimulation_TongKong2;

		// Token: 0x0400F9CC RID: 63948
		internal static int __PropertyOffset_EyeLightSimulation_TongKong3;

		// Token: 0x0400F9CD RID: 63949
		internal static int __PropertyOffset_EyeLightSimulation_YanBai1;

		// Token: 0x0400F9CE RID: 63950
		internal static int __PropertyOffset_EyeLightSimulation_YanBai2;

		// Token: 0x0400F9CF RID: 63951
		internal static int __PropertyOffset_EyeLightSimulation_YanBai3;

		// Token: 0x0400F9D0 RID: 63952
		internal static int __PropertyOffset_EyeLightSimulation_Color1;

		// Token: 0x0400F9D1 RID: 63953
		internal static int __PropertyOffset_EyeLightSimulation_Color2;

		// Token: 0x0400F9D2 RID: 63954
		internal static int __PropertyOffset_EyeLightSimulation_Color3;

		// Token: 0x0400F9D3 RID: 63955
		internal static int __PropertyOffset_MeshPart;

		// Token: 0x0400F9D4 RID: 63956
		internal static int __PropertyOffset_Handle1;

		// Token: 0x0400F9D5 RID: 63957
		internal static int __PropertyOffset_Handle2;

		// Token: 0x0400F9D6 RID: 63958
		internal static int __PropertyOffset_Handle3;

		// Token: 0x0400F9D7 RID: 63959
		internal static int __PropertyOffset_KuroMaterialControllerComponent1;

		// Token: 0x0400F9D8 RID: 63960
		internal static int __PropertyOffset_KuroMaterialControllerComponent2;

		// Token: 0x0400F9D9 RID: 63961
		internal static int __PropertyOffset_KuroMaterialControllerComponent3;

		// Token: 0x0400F9DA RID: 63962
		internal static int __PropertyOffset_textX;

		// Token: 0x0400F9DB RID: 63963
		internal static int __PropertyOffset_textY;

		// Token: 0x0400F9DC RID: 63964
		internal static int __PropertyOffset_Width;

		// Token: 0x0400F9DD RID: 63965
		internal static int __PropertyOffset_LinkCameraLocation;

		// Token: 0x0400F9DE RID: 63966
		internal static int __PropertyOffset_LinkCameraRelativeLocation;

		// Token: 0x0400F9DF RID: 63967
		internal static int __PropertyOffset_IsThree;

		// Token: 0x0400F9E0 RID: 63968
		internal static int __PropertyOffset_RoleId1;

		// Token: 0x0400F9E1 RID: 63969
		internal static int __PropertyOffset_RoleId2;

		// Token: 0x0400F9E2 RID: 63970
		internal static int __PropertyOffset_RoleId3;

		// Token: 0x0400F9E3 RID: 63971
		private static IntPtr __SetLightDirection_NativeFunctionPtr;

		// Token: 0x0400F9E4 RID: 63972
		private static IntPtr __EulerToForward_NativeFunctionPtr;

		// Token: 0x0400F9E5 RID: 63973
		private static IntPtr __SetPosByViewSize_NativeFunctionPtr;

		// Token: 0x0400F9E6 RID: 63974
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x0400F9E7 RID: 63975
		private static IntPtr __InitKuroMaterialController_NativeFunctionPtr;

		// Token: 0x0400F9E8 RID: 63976
		private static IntPtr __End_NativeFunctionPtr;

		// Token: 0x0400F9E9 RID: 63977
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400F9EA RID: 63978
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400F9EB RID: 63979
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400F9EC RID: 63980
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008D69 RID: 36201
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SetLightDirection_FunctionParams
		{
			// Token: 0x0402C902 RID: 182530
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x0402C903 RID: 182531
			[FieldOffset(8)]
			public float LightYaw;

			// Token: 0x0402C904 RID: 182532
			[FieldOffset(12)]
			public float FaceLightYaw;
		}

		// Token: 0x02008D6A RID: 36202
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __EulerToForward_FunctionParams
		{
			// Token: 0x0402C905 RID: 182533
			[FieldOffset(0)]
			public float Pitch;

			// Token: 0x0402C906 RID: 182534
			[FieldOffset(4)]
			public float Yaw;

			// Token: 0x0402C907 RID: 182535
			[FieldOffset(8)]
			public FVector __Result;
		}

		// Token: 0x02008D6B RID: 36203
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 344)]
		protected ref struct __InitKuroMaterialController_FunctionParams
		{
			// Token: 0x0402C908 RID: 182536
			[FieldOffset(0)]
			public IntPtr KuroMaterialControllerComponent;

			// Token: 0x0402C909 RID: 182537
			[FieldOffset(8)]
			public IntPtr CharacterActorComponent;

			// Token: 0x0402C90A RID: 182538
			[FieldOffset(16)]
			public IntPtr PointLightComponent;

			// Token: 0x0402C90B RID: 182539
			[FieldOffset(24)]
			public FVector PointLight_Location;

			// Token: 0x0402C90C RID: 182540
			[FieldOffset(36)]
			public FLinearColor PointLight_ToonLightColor;

			// Token: 0x0402C90D RID: 182541
			[FieldOffset(52)]
			public FLinearColor EyeLightSimulation_TongKong;

			// Token: 0x0402C90E RID: 182542
			[FieldOffset(68)]
			public FLinearColor EyeLightSimulation_YanBai;

			// Token: 0x0402C90F RID: 182543
			[FieldOffset(84)]
			public FLinearColor EyeLightSimulation_Color;

			// Token: 0x0402C910 RID: 182544
			[FieldOffset(100)]
			public float E_LinkPos;

			// Token: 0x0402C911 RID: 182545
			[FieldOffset(104)]
			public bool Channel0;

			// Token: 0x0402C912 RID: 182546
			[FieldOffset(105)]
			public bool Channel1;

			// Token: 0x0402C913 RID: 182547
			[FieldOffset(106)]
			public bool Channel2;

			// Token: 0x0402C914 RID: 182548
			[FieldOffset(108)]
			public float LightYaw;

			// Token: 0x0402C915 RID: 182549
			[FieldOffset(112)]
			public float FaceLightYaw;

			// Token: 0x0402C916 RID: 182550
			[FieldOffset(116)]
			public int RoleId;

			// Token: 0x0402C917 RID: 182551
			[FieldOffset(120)]
			public int returnHandle;
		}

		// Token: 0x02008D6C RID: 36204
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402C918 RID: 182552
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008D6D RID: 36205
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402C919 RID: 182553
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
