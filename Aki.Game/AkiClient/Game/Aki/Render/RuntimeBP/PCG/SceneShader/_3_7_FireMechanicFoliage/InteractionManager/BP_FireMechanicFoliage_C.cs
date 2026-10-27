using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._3_7_FireMechanicFoliage.InteractionManager
{
	// Token: 0x02003C10 RID: 15376
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_FireMechanicFoliage/InteractionManager/BP_FireMechanicFoliage.BP_FireMechanicFoliage_C")]
	[UnrealStructLayout(1720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1713)]
	public class BP_FireMechanicFoliage_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023223 RID: 143907 RVA: 0x0091B630 File Offset: 0x00919830
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FireMechanicFoliage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_FireMechanicFoliage/InteractionManager/BP_FireMechanicFoliage.BP_FireMechanicFoliage_C");
			}
			return BP_FireMechanicFoliage_C._ClassPtr;
		}

		// Token: 0x06023224 RID: 143908 RVA: 0x0091B654 File Offset: 0x00919854
		public BP_FireMechanicFoliage_C() : this(BuiltinUtils.AllocNativeUObject(BP_FireMechanicFoliage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023225 RID: 143909 RVA: 0x0091B67C File Offset: 0x0091987C
		[NullableContext(1)]
		public BP_FireMechanicFoliage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FireMechanicFoliage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FAB RID: 16299
		// (get) Token: 0x06023226 RID: 143910 RVA: 0x0091B6AF File Offset: 0x009198AF
		// (set) Token: 0x06023227 RID: 143911 RVA: 0x0091B6C3 File Offset: 0x009198C3
		public unsafe UTextRenderComponent FireFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextRenderComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003FAC RID: 16300
		// (get) Token: 0x06023228 RID: 143912 RVA: 0x0091B6D8 File Offset: 0x009198D8
		// (set) Token: 0x06023229 RID: 143913 RVA: 0x0091B6EC File Offset: 0x009198EC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003FAD RID: 16301
		// (get) Token: 0x0602322A RID: 143914 RVA: 0x0091B701 File Offset: 0x00919901
		// (set) Token: 0x0602322B RID: 143915 RVA: 0x0091B715 File Offset: 0x00919915
		public unsafe FLinearColor Player_PositionOpened
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17003FAE RID: 16302
		// (get) Token: 0x0602322C RID: 143916 RVA: 0x0091B72A File Offset: 0x0091992A
		// (set) Token: 0x0602322D RID: 143917 RVA: 0x0091B73E File Offset: 0x0091993E
		public unsafe FLinearColor Lantern_01_PositionOpened
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003FAF RID: 16303
		// (get) Token: 0x0602322E RID: 143918 RVA: 0x0091B753 File Offset: 0x00919953
		// (set) Token: 0x0602322F RID: 143919 RVA: 0x0091B767 File Offset: 0x00919967
		public unsafe FLinearColor Lantern_02_PositionOpened
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003FB0 RID: 16304
		// (get) Token: 0x06023230 RID: 143920 RVA: 0x0091B77C File Offset: 0x0091997C
		// (set) Token: 0x06023231 RID: 143921 RVA: 0x0091B790 File Offset: 0x00919990
		public unsafe UTextureRenderTarget2D RT_FireInfluence_History
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003FB1 RID: 16305
		// (get) Token: 0x06023232 RID: 143922 RVA: 0x0091B7A5 File Offset: 0x009199A5
		// (set) Token: 0x06023233 RID: 143923 RVA: 0x0091B7B9 File Offset: 0x009199B9
		public unsafe UTextureRenderTarget2D RT_FireInfluence_Current
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003FB2 RID: 16306
		// (get) Token: 0x06023234 RID: 143924 RVA: 0x0091B7CE File Offset: 0x009199CE
		// (set) Token: 0x06023235 RID: 143925 RVA: 0x0091B7E2 File Offset: 0x009199E2
		public unsafe UMaterialInstanceDynamic MID_FireInfluence_HistoryMerge
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x06023236 RID: 143926 RVA: 0x0091B7F7 File Offset: 0x009199F7
		// (set) Token: 0x06023237 RID: 143927 RVA: 0x0091B80B File Offset: 0x00919A0B
		public unsafe UMaterialInstanceDynamic MID_FireInfluence_Copy
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x06023238 RID: 143928 RVA: 0x0091B820 File Offset: 0x00919A20
		// (set) Token: 0x06023239 RID: 143929 RVA: 0x0091B834 File Offset: 0x00919A34
		public unsafe FVector2D CurrentFieldCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x0602323A RID: 143930 RVA: 0x0091B849 File Offset: 0x00919A49
		// (set) Token: 0x0602323B RID: 143931 RVA: 0x0091B85D File Offset: 0x00919A5D
		public unsafe FVector2D HistoryFieldCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x0602323C RID: 143932 RVA: 0x0091B872 File Offset: 0x00919A72
		// (set) Token: 0x0602323D RID: 143933 RVA: 0x0091B882 File Offset: 0x00919A82
		public unsafe float FieldHalfExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x0602323E RID: 143934 RVA: 0x0091B893 File Offset: 0x00919A93
		// (set) Token: 0x0602323F RID: 143935 RVA: 0x0091B8A3 File Offset: 0x00919AA3
		public unsafe float UpdateInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x06023240 RID: 143936 RVA: 0x0091B8B4 File Offset: 0x00919AB4
		// (set) Token: 0x06023241 RID: 143937 RVA: 0x0091B8C4 File Offset: 0x00919AC4
		public unsafe float PlayerMaxRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x06023242 RID: 143938 RVA: 0x0091B8D5 File Offset: 0x00919AD5
		// (set) Token: 0x06023243 RID: 143939 RVA: 0x0091B8E5 File Offset: 0x00919AE5
		public unsafe float PlayerExpandDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x06023244 RID: 143940 RVA: 0x0091B8F6 File Offset: 0x00919AF6
		// (set) Token: 0x06023245 RID: 143941 RVA: 0x0091B906 File Offset: 0x00919B06
		public unsafe float PlayerRecoverSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x06023246 RID: 143942 RVA: 0x0091B917 File Offset: 0x00919B17
		// (set) Token: 0x06023247 RID: 143943 RVA: 0x0091B927 File Offset: 0x00919B27
		public unsafe float LanternMaxRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x06023248 RID: 143944 RVA: 0x0091B938 File Offset: 0x00919B38
		// (set) Token: 0x06023249 RID: 143945 RVA: 0x0091B948 File Offset: 0x00919B48
		public unsafe float LanternExpandDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x0602324A RID: 143946 RVA: 0x0091B959 File Offset: 0x00919B59
		// (set) Token: 0x0602324B RID: 143947 RVA: 0x0091B969 File Offset: 0x00919B69
		public unsafe float LanternRecoverSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003FBE RID: 16318
		// (get) Token: 0x0602324C RID: 143948 RVA: 0x0091B97A File Offset: 0x00919B7A
		// (set) Token: 0x0602324D RID: 143949 RVA: 0x0091B98A File Offset: 0x00919B8A
		public unsafe bool Player_IsActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x0602324E RID: 143950 RVA: 0x0091B99B File Offset: 0x00919B9B
		// (set) Token: 0x0602324F RID: 143951 RVA: 0x0091B9AB File Offset: 0x00919BAB
		public unsafe bool Lantern_01_IsActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x06023250 RID: 143952 RVA: 0x0091B9BC File Offset: 0x00919BBC
		// (set) Token: 0x06023251 RID: 143953 RVA: 0x0091B9CC File Offset: 0x00919BCC
		public unsafe bool Lantern_02_IsActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_22) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_22) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x06023252 RID: 143954 RVA: 0x0091B9DD File Offset: 0x00919BDD
		// (set) Token: 0x06023253 RID: 143955 RVA: 0x0091B9ED File Offset: 0x00919BED
		public unsafe bool Player_WasActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x06023254 RID: 143956 RVA: 0x0091B9FE File Offset: 0x00919BFE
		// (set) Token: 0x06023255 RID: 143957 RVA: 0x0091BA0E File Offset: 0x00919C0E
		public unsafe bool Lantern_01_WasActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x06023256 RID: 143958 RVA: 0x0091BA1F File Offset: 0x00919C1F
		// (set) Token: 0x06023257 RID: 143959 RVA: 0x0091BA2F File Offset: 0x00919C2F
		public unsafe bool Lantern_02_WasActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x06023258 RID: 143960 RVA: 0x0091BA40 File Offset: 0x00919C40
		// (set) Token: 0x06023259 RID: 143961 RVA: 0x0091BA50 File Offset: 0x00919C50
		public unsafe float Player_ActivationElapsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x0602325A RID: 143962 RVA: 0x0091BA61 File Offset: 0x00919C61
		// (set) Token: 0x0602325B RID: 143963 RVA: 0x0091BA71 File Offset: 0x00919C71
		public unsafe float Lantern_01_ActivationElapsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x0602325C RID: 143964 RVA: 0x0091BA82 File Offset: 0x00919C82
		// (set) Token: 0x0602325D RID: 143965 RVA: 0x0091BA92 File Offset: 0x00919C92
		public unsafe float Lantern_02_ActivationElapsed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x0602325E RID: 143966 RVA: 0x0091BAA3 File Offset: 0x00919CA3
		// (set) Token: 0x0602325F RID: 143967 RVA: 0x0091BAB3 File Offset: 0x00919CB3
		public unsafe float Player_CurrentRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x06023260 RID: 143968 RVA: 0x0091BAC4 File Offset: 0x00919CC4
		// (set) Token: 0x06023261 RID: 143969 RVA: 0x0091BAD4 File Offset: 0x00919CD4
		public unsafe float Lantern_01_CurrentRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x06023262 RID: 143970 RVA: 0x0091BAE5 File Offset: 0x00919CE5
		// (set) Token: 0x06023263 RID: 143971 RVA: 0x0091BAF5 File Offset: 0x00919CF5
		public unsafe float Lantern_02_CurrentRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_31);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_31) = value;
			}
		}

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x06023264 RID: 143972 RVA: 0x0091BB06 File Offset: 0x00919D06
		// (set) Token: 0x06023265 RID: 143973 RVA: 0x0091BB1A File Offset: 0x00919D1A
		public unsafe FVector Player_CurrentWorldPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x06023266 RID: 143974 RVA: 0x0091BB2F File Offset: 0x00919D2F
		// (set) Token: 0x06023267 RID: 143975 RVA: 0x0091BB43 File Offset: 0x00919D43
		public unsafe FVector Lantern_01_CurrentWorldPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x06023268 RID: 143976 RVA: 0x0091BB58 File Offset: 0x00919D58
		// (set) Token: 0x06023269 RID: 143977 RVA: 0x0091BB6C File Offset: 0x00919D6C
		public unsafe FVector Lantern_02_CurrentWorldPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_34);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_34) = value;
			}
		}

		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x0602326A RID: 143978 RVA: 0x0091BB81 File Offset: 0x00919D81
		// (set) Token: 0x0602326B RID: 143979 RVA: 0x0091BB91 File Offset: 0x00919D91
		public unsafe float ResidualRecoveryTimeRemaining
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x0602326C RID: 143980 RVA: 0x0091BBA2 File Offset: 0x00919DA2
		// (set) Token: 0x0602326D RID: 143981 RVA: 0x0091BBB6 File Offset: 0x00919DB6
		public unsafe UMaterialInstanceDynamic MID_FireInfluence_HistoryMerge_Accumulation
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_36);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_36, value);
			}
		}

		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x0602326E RID: 143982 RVA: 0x0091BBCB File Offset: 0x00919DCB
		// (set) Token: 0x0602326F RID: 143983 RVA: 0x0091BBDB File Offset: 0x00919DDB
		public unsafe float HeatUpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_37);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_37) = value;
			}
		}

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x06023270 RID: 143984 RVA: 0x0091BBEC File Offset: 0x00919DEC
		// (set) Token: 0x06023271 RID: 143985 RVA: 0x0091BBFC File Offset: 0x00919DFC
		public unsafe float CoolDownSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_38);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_38) = value;
			}
		}

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x06023272 RID: 143986 RVA: 0x0091BC0D File Offset: 0x00919E0D
		// (set) Token: 0x06023273 RID: 143987 RVA: 0x0091BC1D File Offset: 0x00919E1D
		public unsafe float AccumThresholdStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_39);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_39) = value;
			}
		}

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x06023274 RID: 143988 RVA: 0x0091BC2E File Offset: 0x00919E2E
		// (set) Token: 0x06023275 RID: 143989 RVA: 0x0091BC3E File Offset: 0x00919E3E
		public unsafe float AccumThresholdEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_40);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_40) = value;
			}
		}

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x06023276 RID: 143990 RVA: 0x0091BC4F File Offset: 0x00919E4F
		// (set) Token: 0x06023277 RID: 143991 RVA: 0x0091BC63 File Offset: 0x00919E63
		public unsafe UMaterialParameterCollection MPC_SceneInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_41);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FireMechanicFoliage_C.__PropertyOffset_41, value);
			}
		}

		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x06023278 RID: 143992 RVA: 0x0091BC78 File Offset: 0x00919E78
		// (set) Token: 0x06023279 RID: 143993 RVA: 0x0091BC88 File Offset: 0x00919E88
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FireMechanicFoliage_C.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602327A RID: 143994 RVA: 0x0091BC99 File Offset: 0x00919E99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Debug_Position()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__Debug_Position_NativeFunctionPtr, null);
		}

		// Token: 0x0602327B RID: 143995 RVA: 0x0091BCB0 File Offset: 0x00919EB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShouldUpdateFireField_Accumlation(ref bool AnySourceActive)
		{
			BP_FireMechanicFoliage_C.__ShouldUpdateFireField_Accumlation_FunctionParams* ptr = stackalloc BP_FireMechanicFoliage_C.__ShouldUpdateFireField_Accumlation_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(BP_FireMechanicFoliage_C.__ShouldUpdateFireField_Accumlation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FireMechanicFoliage_C.__ShouldUpdateFireField_Accumlation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AnySourceActive = AnySourceActive;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__ShouldUpdateFireField_Accumlation_NativeFunctionPtr, (void*)ptr);
			AnySourceActive = ptr->AnySourceActive;
		}

		// Token: 0x0602327C RID: 143996 RVA: 0x0091BCFF File Offset: 0x00919EFF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickFireInfluence()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__TickFireInfluence_NativeFunctionPtr, null);
		}

		// Token: 0x0602327D RID: 143997 RVA: 0x0091BD13 File Offset: 0x00919F13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PublishFieldParameters()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__PublishFieldParameters_NativeFunctionPtr, null);
		}

		// Token: 0x0602327E RID: 143998 RVA: 0x0091BD28 File Offset: 0x00919F28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CopyCurrentToHistory(ref UTextureRenderTarget RT_FireInfluence_History)
		{
			BP_FireMechanicFoliage_C.__CopyCurrentToHistory_FunctionParams* ptr = stackalloc BP_FireMechanicFoliage_C.__CopyCurrentToHistory_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_FireMechanicFoliage_C.__CopyCurrentToHistory_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FireMechanicFoliage_C.__CopyCurrentToHistory_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_FireMechanicFoliage_C.__CopyCurrentToHistory_FunctionParams ptr2 = ref *ptr;
			UTextureRenderTarget utextureRenderTarget = RT_FireInfluence_History;
			ptr2.RT_FireInfluence_History = ((utextureRenderTarget != null) ? utextureRenderTarget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__CopyCurrentToHistory_NativeFunctionPtr, (void*)ptr);
			RT_FireInfluence_History = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget>(ptr->RT_FireInfluence_History);
		}

		// Token: 0x0602327F RID: 143999 RVA: 0x0091BD8C File Offset: 0x00919F8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MergeHistoryField_Accumlation(ref UTextureRenderTarget RT_FireInfluence_Current)
		{
			BP_FireMechanicFoliage_C.__MergeHistoryField_Accumlation_FunctionParams* ptr = stackalloc BP_FireMechanicFoliage_C.__MergeHistoryField_Accumlation_FunctionParams[(UIntPtr)327] + 15L / (long)sizeof(BP_FireMechanicFoliage_C.__MergeHistoryField_Accumlation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FireMechanicFoliage_C.__MergeHistoryField_Accumlation_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_FireMechanicFoliage_C.__MergeHistoryField_Accumlation_FunctionParams ptr2 = ref *ptr;
			UTextureRenderTarget utextureRenderTarget = RT_FireInfluence_Current;
			ptr2.RT_FireInfluence_Current = ((utextureRenderTarget != null) ? utextureRenderTarget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__MergeHistoryField_Accumlation_NativeFunctionPtr, (void*)ptr);
			RT_FireInfluence_Current = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget>(ptr->RT_FireInfluence_Current);
		}

		// Token: 0x06023280 RID: 144000 RVA: 0x0091BDF4 File Offset: 0x00919FF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void MergeHistoryField(ref UTextureRenderTarget RT_FireInfluence_Current)
		{
			BP_FireMechanicFoliage_C.__MergeHistoryField_FunctionParams* ptr = stackalloc BP_FireMechanicFoliage_C.__MergeHistoryField_FunctionParams[(UIntPtr)311] + 15L / (long)sizeof(BP_FireMechanicFoliage_C.__MergeHistoryField_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FireMechanicFoliage_C.__MergeHistoryField_NativeFunctionPtr, (void*)ptr, 1);
			ref BP_FireMechanicFoliage_C.__MergeHistoryField_FunctionParams ptr2 = ref *ptr;
			UTextureRenderTarget utextureRenderTarget = RT_FireInfluence_Current;
			ptr2.RT_FireInfluence_Current = ((utextureRenderTarget != null) ? utextureRenderTarget.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__MergeHistoryField_NativeFunctionPtr, (void*)ptr);
			RT_FireInfluence_Current = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget>(ptr->RT_FireInfluence_Current);
		}

		// Token: 0x06023281 RID: 144001 RVA: 0x0091BE5B File Offset: 0x0091A05B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSourceState()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__UpdateSourceState_NativeFunctionPtr, null);
		}

		// Token: 0x06023282 RID: 144002 RVA: 0x0091BE6F File Offset: 0x0091A06F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateFieldCenter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__UpdateFieldCenter_NativeFunctionPtr, null);
		}

		// Token: 0x06023283 RID: 144003 RVA: 0x0091BE84 File Offset: 0x0091A084
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShouldUpdateFireField(ref bool AnySourceActive)
		{
			BP_FireMechanicFoliage_C.__ShouldUpdateFireField_FunctionParams* ptr = stackalloc BP_FireMechanicFoliage_C.__ShouldUpdateFireField_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_FireMechanicFoliage_C.__ShouldUpdateFireField_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FireMechanicFoliage_C.__ShouldUpdateFireField_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AnySourceActive = AnySourceActive;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__ShouldUpdateFireField_NativeFunctionPtr, (void*)ptr);
			AnySourceActive = ptr->AnySourceActive;
		}

		// Token: 0x06023284 RID: 144004 RVA: 0x0091BED3 File Offset: 0x0091A0D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Initialize_Fire_Influence()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__Initialize_Fire_Influence_NativeFunctionPtr, null);
		}

		// Token: 0x06023285 RID: 144005 RVA: 0x0091BEE7 File Offset: 0x0091A0E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_FireMechanicPosition()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__Set_FireMechanicPosition_NativeFunctionPtr, null);
		}

		// Token: 0x06023286 RID: 144006 RVA: 0x0091BEFC File Offset: 0x0091A0FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FireMechanicFoliage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FireMechanicFoliage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FireMechanicFoliage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FireMechanicFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06023287 RID: 144007 RVA: 0x0091BF44 File Offset: 0x0091A144
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FireMechanicFoliage_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FireMechanicFoliage_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FireMechanicFoliage_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FireMechanicFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06023288 RID: 144008 RVA: 0x0091BF8B File Offset: 0x0091A18B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PrintDebugInfo()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__PrintDebugInfo_NativeFunctionPtr, null);
		}

		// Token: 0x06023289 RID: 144009 RVA: 0x0091BF9F File Offset: 0x0091A19F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602328A RID: 144010 RVA: 0x0091BFB3 File Offset: 0x0091A1B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FireMechanicFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602328B RID: 144011 RVA: 0x0091BFC8 File Offset: 0x0091A1C8
		protected BP_FireMechanicFoliage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114FB RID: 70907
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_FireMechanicFoliage/InteractionManager/BP_FireMechanicFoliage.BP_FireMechanicFoliage_C";

		// Token: 0x040114FC RID: 70908
		private static IntPtr _ClassPtr;

		// Token: 0x040114FD RID: 70909
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114FE RID: 70910
		internal static int __PropertyOffset_1;

		// Token: 0x040114FF RID: 70911
		internal static int __PropertyOffset_2;

		// Token: 0x04011500 RID: 70912
		internal static int __PropertyOffset_3;

		// Token: 0x04011501 RID: 70913
		internal static int __PropertyOffset_4;

		// Token: 0x04011502 RID: 70914
		internal static int __PropertyOffset_5;

		// Token: 0x04011503 RID: 70915
		internal static int __PropertyOffset_6;

		// Token: 0x04011504 RID: 70916
		internal static int __PropertyOffset_7;

		// Token: 0x04011505 RID: 70917
		internal static int __PropertyOffset_8;

		// Token: 0x04011506 RID: 70918
		internal static int __PropertyOffset_9;

		// Token: 0x04011507 RID: 70919
		internal static int __PropertyOffset_10;

		// Token: 0x04011508 RID: 70920
		internal static int __PropertyOffset_11;

		// Token: 0x04011509 RID: 70921
		internal static int __PropertyOffset_12;

		// Token: 0x0401150A RID: 70922
		internal static int __PropertyOffset_13;

		// Token: 0x0401150B RID: 70923
		internal static int __PropertyOffset_14;

		// Token: 0x0401150C RID: 70924
		internal static int __PropertyOffset_15;

		// Token: 0x0401150D RID: 70925
		internal static int __PropertyOffset_16;

		// Token: 0x0401150E RID: 70926
		internal static int __PropertyOffset_17;

		// Token: 0x0401150F RID: 70927
		internal static int __PropertyOffset_18;

		// Token: 0x04011510 RID: 70928
		internal static int __PropertyOffset_19;

		// Token: 0x04011511 RID: 70929
		internal static int __PropertyOffset_20;

		// Token: 0x04011512 RID: 70930
		internal static int __PropertyOffset_21;

		// Token: 0x04011513 RID: 70931
		internal static int __PropertyOffset_22;

		// Token: 0x04011514 RID: 70932
		internal static int __PropertyOffset_23;

		// Token: 0x04011515 RID: 70933
		internal static int __PropertyOffset_24;

		// Token: 0x04011516 RID: 70934
		internal static int __PropertyOffset_25;

		// Token: 0x04011517 RID: 70935
		internal static int __PropertyOffset_26;

		// Token: 0x04011518 RID: 70936
		internal static int __PropertyOffset_27;

		// Token: 0x04011519 RID: 70937
		internal static int __PropertyOffset_28;

		// Token: 0x0401151A RID: 70938
		internal static int __PropertyOffset_29;

		// Token: 0x0401151B RID: 70939
		internal static int __PropertyOffset_30;

		// Token: 0x0401151C RID: 70940
		internal static int __PropertyOffset_31;

		// Token: 0x0401151D RID: 70941
		internal static int __PropertyOffset_32;

		// Token: 0x0401151E RID: 70942
		internal static int __PropertyOffset_33;

		// Token: 0x0401151F RID: 70943
		internal static int __PropertyOffset_34;

		// Token: 0x04011520 RID: 70944
		internal static int __PropertyOffset_35;

		// Token: 0x04011521 RID: 70945
		internal static int __PropertyOffset_36;

		// Token: 0x04011522 RID: 70946
		internal static int __PropertyOffset_37;

		// Token: 0x04011523 RID: 70947
		internal static int __PropertyOffset_38;

		// Token: 0x04011524 RID: 70948
		internal static int __PropertyOffset_39;

		// Token: 0x04011525 RID: 70949
		internal static int __PropertyOffset_40;

		// Token: 0x04011526 RID: 70950
		internal static int __PropertyOffset_41;

		// Token: 0x04011527 RID: 70951
		internal static int __PropertyOffset_42;

		// Token: 0x04011528 RID: 70952
		private static IntPtr __Debug_Position_NativeFunctionPtr;

		// Token: 0x04011529 RID: 70953
		private static IntPtr __ShouldUpdateFireField_Accumlation_NativeFunctionPtr;

		// Token: 0x0401152A RID: 70954
		private static IntPtr __TickFireInfluence_NativeFunctionPtr;

		// Token: 0x0401152B RID: 70955
		private static IntPtr __PublishFieldParameters_NativeFunctionPtr;

		// Token: 0x0401152C RID: 70956
		private static IntPtr __CopyCurrentToHistory_NativeFunctionPtr;

		// Token: 0x0401152D RID: 70957
		private static IntPtr __MergeHistoryField_Accumlation_NativeFunctionPtr;

		// Token: 0x0401152E RID: 70958
		private static IntPtr __MergeHistoryField_NativeFunctionPtr;

		// Token: 0x0401152F RID: 70959
		private static IntPtr __UpdateSourceState_NativeFunctionPtr;

		// Token: 0x04011530 RID: 70960
		private static IntPtr __UpdateFieldCenter_NativeFunctionPtr;

		// Token: 0x04011531 RID: 70961
		private static IntPtr __ShouldUpdateFireField_NativeFunctionPtr;

		// Token: 0x04011532 RID: 70962
		private static IntPtr __Initialize_Fire_Influence_NativeFunctionPtr;

		// Token: 0x04011533 RID: 70963
		private static IntPtr __Set_FireMechanicPosition_NativeFunctionPtr;

		// Token: 0x04011534 RID: 70964
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011535 RID: 70965
		private static IntPtr __PrintDebugInfo_NativeFunctionPtr;

		// Token: 0x04011536 RID: 70966
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009E18 RID: 40472
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ShouldUpdateFireField_Accumlation_FunctionParams
		{
			// Token: 0x0403165B RID: 202331
			[FieldOffset(0)]
			public bool AnySourceActive;
		}

		// Token: 0x02009E19 RID: 40473
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __CopyCurrentToHistory_FunctionParams
		{
			// Token: 0x0403165C RID: 202332
			[FieldOffset(0)]
			public IntPtr RT_FireInfluence_History;
		}

		// Token: 0x02009E1A RID: 40474
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __MergeHistoryField_Accumlation_FunctionParams
		{
			// Token: 0x0403165D RID: 202333
			[FieldOffset(0)]
			public IntPtr RT_FireInfluence_Current;
		}

		// Token: 0x02009E1B RID: 40475
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 296)]
		protected ref struct __MergeHistoryField_FunctionParams
		{
			// Token: 0x0403165E RID: 202334
			[FieldOffset(0)]
			public IntPtr RT_FireInfluence_Current;
		}

		// Token: 0x02009E1C RID: 40476
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __ShouldUpdateFireField_FunctionParams
		{
			// Token: 0x0403165F RID: 202335
			[FieldOffset(0)]
			public bool AnySourceActive;
		}

		// Token: 0x02009E1D RID: 40477
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031660 RID: 202336
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
