using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP
{
	// Token: 0x020030F9 RID: 12537
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudFuBen.BP_CloudFuBen_C")]
	[UnrealStructLayout(2080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2076)]
	public class BP_CloudFuBen_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E8CD RID: 125133 RVA: 0x00916BB8 File Offset: 0x00914DB8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CloudFuBen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudFuBen.BP_CloudFuBen_C");
			}
			return BP_CloudFuBen_C._ClassPtr;
		}

		// Token: 0x0601E8CE RID: 125134 RVA: 0x00916BDC File Offset: 0x00914DDC
		public BP_CloudFuBen_C() : this(BuiltinUtils.AllocNativeUObject(BP_CloudFuBen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E8CF RID: 125135 RVA: 0x00916C04 File Offset: 0x00914E04
		[NullableContext(1)]
		public BP_CloudFuBen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CloudFuBen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0601E8D0 RID: 125136 RVA: 0x00916C37 File Offset: 0x00914E37
		// (set) Token: 0x0601E8D1 RID: 125137 RVA: 0x00916C4B File Offset: 0x00914E4B
		public unsafe UStaticMeshComponent Cloud_Anomalies
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Cloud_Anomalies);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Cloud_Anomalies, value);
			}
		}

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0601E8D2 RID: 125138 RVA: 0x00916C60 File Offset: 0x00914E60
		// (set) Token: 0x0601E8D3 RID: 125139 RVA: 0x00916C74 File Offset: 0x00914E74
		public unsafe UStaticMeshComponent Sun_Moon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Sun_Moon);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Sun_Moon, value);
			}
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x0601E8D4 RID: 125140 RVA: 0x00916C89 File Offset: 0x00914E89
		// (set) Token: 0x0601E8D5 RID: 125141 RVA: 0x00916C9D File Offset: 0x00914E9D
		public unsafe UStaticMeshComponent Cloud_BigShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Cloud_BigShape);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Cloud_BigShape, value);
			}
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0601E8D6 RID: 125142 RVA: 0x00916CB2 File Offset: 0x00914EB2
		// (set) Token: 0x0601E8D7 RID: 125143 RVA: 0x00916CC6 File Offset: 0x00914EC6
		public unsafe UStaticMeshComponent Cloud_Special
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Cloud_Special);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Cloud_Special, value);
			}
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0601E8D8 RID: 125144 RVA: 0x00916CDB File Offset: 0x00914EDB
		// (set) Token: 0x0601E8D9 RID: 125145 RVA: 0x00916CEF File Offset: 0x00914EEF
		public unsafe UStaticMeshComponent Cloud_Top
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Cloud_Top);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Cloud_Top, value);
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0601E8DA RID: 125146 RVA: 0x00916D04 File Offset: 0x00914F04
		// (set) Token: 0x0601E8DB RID: 125147 RVA: 0x00916D18 File Offset: 0x00914F18
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0601E8DC RID: 125148 RVA: 0x00916D2D File Offset: 0x00914F2D
		// (set) Token: 0x0601E8DD RID: 125149 RVA: 0x00916D41 File Offset: 0x00914F41
		public unsafe UMaterialInstanceDynamic DMI_Top
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DMI_Top);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DMI_Top, value);
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0601E8DE RID: 125150 RVA: 0x00916D56 File Offset: 0x00914F56
		// (set) Token: 0x0601E8DF RID: 125151 RVA: 0x00916D6A File Offset: 0x00914F6A
		public unsafe UMaterialInstanceDynamic DMI_Anomalies
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DMI_Anomalies);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DMI_Anomalies, value);
			}
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0601E8E0 RID: 125152 RVA: 0x00916D7F File Offset: 0x00914F7F
		// (set) Token: 0x0601E8E1 RID: 125153 RVA: 0x00916D93 File Offset: 0x00914F93
		public unsafe UMaterialInstanceDynamic DMI_SunMoon
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DMI_SunMoon);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DMI_SunMoon, value);
			}
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0601E8E2 RID: 125154 RVA: 0x00916DA8 File Offset: 0x00914FA8
		// (set) Token: 0x0601E8E3 RID: 125155 RVA: 0x00916DBC File Offset: 0x00914FBC
		public unsafe UMaterialInstanceDynamic DMI_BigShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DMI_BigShape);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_DMI_BigShape, value);
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0601E8E4 RID: 125156 RVA: 0x00916DD1 File Offset: 0x00914FD1
		// (set) Token: 0x0601E8E5 RID: 125157 RVA: 0x00916DE1 File Offset: 0x00914FE1
		public unsafe bool UpdatePerFourFrame01
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_UpdatePerFourFrame01) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_UpdatePerFourFrame01) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0601E8E6 RID: 125158 RVA: 0x00916DF2 File Offset: 0x00914FF2
		// (set) Token: 0x0601E8E7 RID: 125159 RVA: 0x00916E02 File Offset: 0x00915002
		public unsafe bool UpdatePerFourFrame02
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_UpdatePerFourFrame02) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_UpdatePerFourFrame02) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0601E8E8 RID: 125160 RVA: 0x00916E13 File Offset: 0x00915013
		// (set) Token: 0x0601E8E9 RID: 125161 RVA: 0x00916E27 File Offset: 0x00915027
		public unsafe UTexture2D Top_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Top_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Top_Texture, value);
			}
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0601E8EA RID: 125162 RVA: 0x00916E3C File Offset: 0x0091503C
		// (set) Token: 0x0601E8EB RID: 125163 RVA: 0x00916E50 File Offset: 0x00915050
		public unsafe UTexture2D POI_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_POI_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_POI_Texture, value);
			}
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0601E8EC RID: 125164 RVA: 0x00916E65 File Offset: 0x00915065
		// (set) Token: 0x0601E8ED RID: 125165 RVA: 0x00916E79 File Offset: 0x00915079
		public unsafe FRotator POI_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_POI_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_POI_Rotation) = value;
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0601E8EE RID: 125166 RVA: 0x00916E8E File Offset: 0x0091508E
		// (set) Token: 0x0601E8EF RID: 125167 RVA: 0x00916EA2 File Offset: 0x009150A2
		public unsafe UMaterialInstance TOP_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_TOP_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_TOP_Material, value);
			}
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0601E8F0 RID: 125168 RVA: 0x00916EB7 File Offset: 0x009150B7
		// (set) Token: 0x0601E8F1 RID: 125169 RVA: 0x00916EC7 File Offset: 0x009150C7
		public unsafe bool UV1UV2_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_UV1UV2_) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_UV1UV2_) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0601E8F2 RID: 125170 RVA: 0x00916ED8 File Offset: 0x009150D8
		// (set) Token: 0x0601E8F3 RID: 125171 RVA: 0x00916EE8 File Offset: 0x009150E8
		public unsafe float UVTiling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_UVTiling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_UVTiling) = value;
			}
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0601E8F4 RID: 125172 RVA: 0x00916EF9 File Offset: 0x009150F9
		// (set) Token: 0x0601E8F5 RID: 125173 RVA: 0x00916F09 File Offset: 0x00915109
		public unsafe float CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_CloudSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_CloudSpeed) = value;
			}
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0601E8F6 RID: 125174 RVA: 0x00916F1A File Offset: 0x0091511A
		// (set) Token: 0x0601E8F7 RID: 125175 RVA: 0x00916F2A File Offset: 0x0091512A
		public unsafe float Top_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Top_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Top_Rotation) = value;
			}
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0601E8F8 RID: 125176 RVA: 0x00916F3B File Offset: 0x0091513B
		// (set) Token: 0x0601E8F9 RID: 125177 RVA: 0x00916F4F File Offset: 0x0091514F
		public unsafe UTexture2D Special_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Special_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Special_Texture, value);
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0601E8FA RID: 125178 RVA: 0x00916F64 File Offset: 0x00915164
		// (set) Token: 0x0601E8FB RID: 125179 RVA: 0x00916F78 File Offset: 0x00915178
		public unsafe UMaterialInstance Special_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Special_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Special_Material, value);
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0601E8FC RID: 125180 RVA: 0x00916F8D File Offset: 0x0091518D
		// (set) Token: 0x0601E8FD RID: 125181 RVA: 0x00916FA1 File Offset: 0x009151A1
		public unsafe FRotator Special_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Special_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Special_Rotation) = value;
			}
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0601E8FE RID: 125182 RVA: 0x00916FB6 File Offset: 0x009151B6
		// (set) Token: 0x0601E8FF RID: 125183 RVA: 0x00916FC6 File Offset: 0x009151C6
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0601E900 RID: 125184 RVA: 0x00916FD7 File Offset: 0x009151D7
		// (set) Token: 0x0601E901 RID: 125185 RVA: 0x00916FE7 File Offset: 0x009151E7
		public unsafe int TransSortNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_TransSortNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_TransSortNumber) = value;
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0601E902 RID: 125186 RVA: 0x00916FF8 File Offset: 0x009151F8
		// (set) Token: 0x0601E903 RID: 125187 RVA: 0x0091700C File Offset: 0x0091520C
		public unsafe UStaticMesh CloudSpecialMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_CloudSpecialMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_CloudSpecialMesh, value);
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0601E904 RID: 125188 RVA: 0x00917021 File Offset: 0x00915221
		// (set) Token: 0x0601E905 RID: 125189 RVA: 0x00917035 File Offset: 0x00915235
		public unsafe UTexture2D Noise_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Noise_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Noise_Texture, value);
			}
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0601E906 RID: 125190 RVA: 0x0091704A File Offset: 0x0091524A
		// (set) Token: 0x0601E907 RID: 125191 RVA: 0x0091705A File Offset: 0x0091525A
		public unsafe float NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_NoiseStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_NoiseStrength) = value;
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0601E908 RID: 125192 RVA: 0x0091706B File Offset: 0x0091526B
		// (set) Token: 0x0601E909 RID: 125193 RVA: 0x0091707B File Offset: 0x0091527B
		public unsafe float NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_NoiseSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_NoiseSpeed) = value;
			}
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0601E90A RID: 125194 RVA: 0x0091708C File Offset: 0x0091528C
		// (set) Token: 0x0601E90B RID: 125195 RVA: 0x0091709C File Offset: 0x0091529C
		public unsafe float NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_NoiseTilling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_NoiseTilling) = value;
			}
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0601E90C RID: 125196 RVA: 0x009170AD File Offset: 0x009152AD
		// (set) Token: 0x0601E90D RID: 125197 RVA: 0x009170C1 File Offset: 0x009152C1
		public unsafe UTexture2D Anomalies_Texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Anomalies_Texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Anomalies_Texture, value);
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0601E90E RID: 125198 RVA: 0x009170D6 File Offset: 0x009152D6
		// (set) Token: 0x0601E90F RID: 125199 RVA: 0x009170EA File Offset: 0x009152EA
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0601E910 RID: 125200 RVA: 0x009170FF File Offset: 0x009152FF
		// (set) Token: 0x0601E911 RID: 125201 RVA: 0x00917113 File Offset: 0x00915313
		public unsafe FRotator Anomalies_Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_Rotation) = value;
			}
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0601E912 RID: 125202 RVA: 0x00917128 File Offset: 0x00915328
		// (set) Token: 0x0601E913 RID: 125203 RVA: 0x00917138 File Offset: 0x00915338
		public unsafe float Anomalies_Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_Intensity) = value;
			}
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0601E914 RID: 125204 RVA: 0x00917149 File Offset: 0x00915349
		// (set) Token: 0x0601E915 RID: 125205 RVA: 0x0091715D File Offset: 0x0091535D
		public unsafe FVector Anomalies_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_Scale) = value;
			}
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0601E916 RID: 125206 RVA: 0x00917174 File Offset: 0x00915374
		// (set) Token: 0x0601E917 RID: 125207 RVA: 0x009171AD File Offset: 0x009153AD
		[Nullable(1)]
		public FKuroCurveFloat Sky
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Sky) == null)
				{
					result = (this._Sky = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Sky, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Sky, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0601E918 RID: 125208 RVA: 0x009171D0 File Offset: 0x009153D0
		// (set) Token: 0x0601E919 RID: 125209 RVA: 0x00917209 File Offset: 0x00915409
		[Nullable(1)]
		public FKuroCurveFloat StarTrails
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._StarTrails) == null)
				{
					result = (this._StarTrails = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_StarTrails, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_StarTrails, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0601E91A RID: 125210 RVA: 0x0091722A File Offset: 0x0091542A
		// (set) Token: 0x0601E91B RID: 125211 RVA: 0x0091723A File Offset: 0x0091543A
		public unsafe float Delta_Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Delta_Seconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Delta_Seconds) = value;
			}
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0601E91C RID: 125212 RVA: 0x0091724B File Offset: 0x0091544B
		// (set) Token: 0x0601E91D RID: 125213 RVA: 0x0091725B File Offset: 0x0091545B
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0601E91E RID: 125214 RVA: 0x0091726C File Offset: 0x0091546C
		// (set) Token: 0x0601E91F RID: 125215 RVA: 0x0091727C File Offset: 0x0091547C
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0601E920 RID: 125216 RVA: 0x0091728D File Offset: 0x0091548D
		// (set) Token: 0x0601E921 RID: 125217 RVA: 0x0091729D File Offset: 0x0091549D
		public unsafe bool IsTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_IsTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_IsTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0601E922 RID: 125218 RVA: 0x009172AE File Offset: 0x009154AE
		// (set) Token: 0x0601E923 RID: 125219 RVA: 0x009172BE File Offset: 0x009154BE
		public unsafe float Anomalies_NoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_NoiseSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_NoiseSpeed) = value;
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0601E924 RID: 125220 RVA: 0x009172CF File Offset: 0x009154CF
		// (set) Token: 0x0601E925 RID: 125221 RVA: 0x009172DF File Offset: 0x009154DF
		public unsafe float Anomalies_NoiseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_NoiseStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_NoiseStrength) = value;
			}
		}

		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x0601E926 RID: 125222 RVA: 0x009172F0 File Offset: 0x009154F0
		// (set) Token: 0x0601E927 RID: 125223 RVA: 0x00917300 File Offset: 0x00915500
		public unsafe float Anomalies_NoiseTilling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_NoiseTilling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Anomalies_NoiseTilling) = value;
			}
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0601E928 RID: 125224 RVA: 0x00917311 File Offset: 0x00915511
		// (set) Token: 0x0601E929 RID: 125225 RVA: 0x00917325 File Offset: 0x00915525
		public unsafe UTexture2D Anomalies_NoiseTex
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Anomalies_NoiseTex);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CloudFuBen_C.__PropertyOffset_Anomalies_NoiseTex, value);
			}
		}

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0601E92A RID: 125226 RVA: 0x0091733A File Offset: 0x0091553A
		// (set) Token: 0x0601E92B RID: 125227 RVA: 0x0091734E File Offset: 0x0091554E
		[Nullable(1)]
		public unsafe string LevelLog
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CloudFuBen_C.__PropertyOffset_LevelLog)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CloudFuBen_C.__PropertyOffset_LevelLog)), value);
			}
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0601E92C RID: 125228 RVA: 0x00917363 File Offset: 0x00915563
		// (set) Token: 0x0601E92D RID: 125229 RVA: 0x00917373 File Offset: 0x00915573
		public unsafe float Translucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Translucent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CloudFuBen_C.__PropertyOffset_Translucent) = value;
			}
		}

		// Token: 0x0601E92E RID: 125230 RVA: 0x00917384 File Offset: 0x00915584
		[SkipLocalsInit]
		public unsafe virtual void Timer(ref float ElapsedTime)
		{
			BP_CloudFuBen_C.__Timer_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__Timer_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(BP_CloudFuBen_C.__Timer_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__Timer_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ElapsedTime = ElapsedTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Timer_NativeFunctionPtr, (void*)ptr);
			ElapsedTime = ptr->ElapsedTime;
		}

		// Token: 0x0601E92F RID: 125231 RVA: 0x009173D4 File Offset: 0x009155D4
		[SkipLocalsInit]
		public unsafe virtual void ChangeSky(bool IsTick)
		{
			BP_CloudFuBen_C.__ChangeSky_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__ChangeSky_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(BP_CloudFuBen_C.__ChangeSky_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__ChangeSky_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsTick = IsTick;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__ChangeSky_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E930 RID: 125232 RVA: 0x0091741C File Offset: 0x0091561C
		[SkipLocalsInit]
		public unsafe virtual void Special_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, FRotator POIRotation, float Intensity, FVector Scale, UTexture2D NoiseTex, float NoiseSpeed, float NoiseStrength, float NoiseTilling, FLinearColor Color)
		{
			BP_CloudFuBen_C.__Special_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__Special_Parameters_Initial_FunctionParams[(UIntPtr)263] + 15L / (long)sizeof(BP_CloudFuBen_C.__Special_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__Special_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->POIRotation = POIRotation;
			ptr->Intensity = Intensity;
			ptr->Scale = Scale;
			ptr->NoiseTex = ((NoiseTex != null) ? NoiseTex.NativePtr : IntPtr.Zero);
			ptr->NoiseSpeed = NoiseSpeed;
			ptr->NoiseStrength = NoiseStrength;
			ptr->NoiseTilling = NoiseTilling;
			ptr->Color = Color;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Special_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E931 RID: 125233 RVA: 0x009174F0 File Offset: 0x009156F0
		[SkipLocalsInit]
		public unsafe virtual void SunMoon_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, FRotator POIRotation, float Intensity)
		{
			BP_CloudFuBen_C.__SunMoon_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__SunMoon_Parameters_Initial_FunctionParams[(UIntPtr)231] + 15L / (long)sizeof(BP_CloudFuBen_C.__SunMoon_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__SunMoon_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->POIRotation = POIRotation;
			ptr->Intensity = Intensity;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__SunMoon_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E932 RID: 125234 RVA: 0x00917584 File Offset: 0x00915784
		[SkipLocalsInit]
		public unsafe virtual void Single_POI_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, FRotator POIRotation)
		{
			BP_CloudFuBen_C.__Single_POI_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__Single_POI_Parameters_Initial_FunctionParams[(UIntPtr)207] + 15L / (long)sizeof(BP_CloudFuBen_C.__Single_POI_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__Single_POI_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->POIRotation = POIRotation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Single_POI_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E933 RID: 125235 RVA: 0x00917610 File Offset: 0x00915810
		[SkipLocalsInit]
		public virtual void UpdatePerFourFrame()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__UpdatePerFourFrame_NativeFunctionPtr, null);
		}

		// Token: 0x0601E934 RID: 125236 RVA: 0x00917624 File Offset: 0x00915824
		[SkipLocalsInit]
		public unsafe virtual void CreateDMI(UStaticMeshComponent Mesh, UMaterialInstance Material, ref UMaterialInstanceDynamic DMI)
		{
			BP_CloudFuBen_C.__CreateDMI_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__CreateDMI_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_CloudFuBen_C.__CreateDMI_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__CreateDMI_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Material = ((Material != null) ? Material.NativePtr : IntPtr.Zero);
			ref BP_CloudFuBen_C.__CreateDMI_FunctionParams ptr2 = ref *ptr;
			UMaterialInstanceDynamic umaterialInstanceDynamic = DMI;
			ptr2.DMI = ((umaterialInstanceDynamic != null) ? umaterialInstanceDynamic.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__CreateDMI_NativeFunctionPtr, (void*)ptr);
			DMI = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(ptr->DMI);
		}

		// Token: 0x0601E935 RID: 125237 RVA: 0x009176B4 File Offset: 0x009158B4
		[SkipLocalsInit]
		public unsafe virtual void Single_Cloud_Parameters_Initial(UMaterialInstanceDynamic DMI, UStaticMeshComponent Mesh, UTexture2D Texture, bool UV1UV2_, float CloudSpeed, float Top_Rotation, float UVTiling, float NoiseStrength, float NoiseSpeed, float NoiseTilling, UTexture2D NoiseTex)
		{
			BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DMI = ((DMI != null) ? DMI.NativePtr : IntPtr.Zero);
			ptr->Mesh = ((Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
			ptr->Texture = ((Texture != null) ? Texture.NativePtr : IntPtr.Zero);
			ptr->UV1UV2_ = UV1UV2_;
			ptr->CloudSpeed = CloudSpeed;
			ptr->Top_Rotation = Top_Rotation;
			ptr->UVTiling = UVTiling;
			ptr->NoiseStrength = NoiseStrength;
			ptr->NoiseSpeed = NoiseSpeed;
			ptr->NoiseTilling = NoiseTilling;
			ptr->NoiseTex = ((NoiseTex != null) ? NoiseTex.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Single_Cloud_Parameters_Initial_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E936 RID: 125238 RVA: 0x00917785 File Offset: 0x00915985
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E937 RID: 125239 RVA: 0x00917799 File Offset: 0x00915999
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBen_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E938 RID: 125240 RVA: 0x009177AD File Offset: 0x009159AD
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E939 RID: 125241 RVA: 0x009177C1 File Offset: 0x009159C1
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E93A RID: 125242 RVA: 0x009177D8 File Offset: 0x009159D8
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_CloudFuBen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E93B RID: 125243 RVA: 0x00917820 File Offset: 0x00915A20
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_CloudFuBen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E93C RID: 125244 RVA: 0x00917868 File Offset: 0x00915A68
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_CloudFuBen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E93D RID: 125245 RVA: 0x009178B0 File Offset: 0x00915AB0
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_CloudFuBen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_CloudFuBen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_CloudFuBen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_CloudFuBen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_CloudFuBen_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E93E RID: 125246 RVA: 0x009178F6 File Offset: 0x00915AF6
		[SkipLocalsInit]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CloudFuBen_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x0601E93F RID: 125247 RVA: 0x0091790A File Offset: 0x00915B0A
		protected BP_CloudFuBen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401030A RID: 66314
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/GI/NewCloud/BP/BP_CloudFuBen.BP_CloudFuBen_C";

		// Token: 0x0401030B RID: 66315
		private static IntPtr _ClassPtr;

		// Token: 0x0401030C RID: 66316
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401030D RID: 66317
		internal static int __PropertyOffset_Cloud_Anomalies;

		// Token: 0x0401030E RID: 66318
		internal static int __PropertyOffset_Sun_Moon;

		// Token: 0x0401030F RID: 66319
		internal static int __PropertyOffset_Cloud_BigShape;

		// Token: 0x04010310 RID: 66320
		internal static int __PropertyOffset_Cloud_Special;

		// Token: 0x04010311 RID: 66321
		internal static int __PropertyOffset_Cloud_Top;

		// Token: 0x04010312 RID: 66322
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010313 RID: 66323
		internal static int __PropertyOffset_DMI_Top;

		// Token: 0x04010314 RID: 66324
		internal static int __PropertyOffset_DMI_Anomalies;

		// Token: 0x04010315 RID: 66325
		internal static int __PropertyOffset_DMI_SunMoon;

		// Token: 0x04010316 RID: 66326
		internal static int __PropertyOffset_DMI_BigShape;

		// Token: 0x04010317 RID: 66327
		internal static int __PropertyOffset_UpdatePerFourFrame01;

		// Token: 0x04010318 RID: 66328
		internal static int __PropertyOffset_UpdatePerFourFrame02;

		// Token: 0x04010319 RID: 66329
		internal static int __PropertyOffset_Top_Texture;

		// Token: 0x0401031A RID: 66330
		internal static int __PropertyOffset_POI_Texture;

		// Token: 0x0401031B RID: 66331
		internal static int __PropertyOffset_POI_Rotation;

		// Token: 0x0401031C RID: 66332
		internal static int __PropertyOffset_TOP_Material;

		// Token: 0x0401031D RID: 66333
		internal static int __PropertyOffset_UV1UV2_;

		// Token: 0x0401031E RID: 66334
		internal static int __PropertyOffset_UVTiling;

		// Token: 0x0401031F RID: 66335
		internal static int __PropertyOffset_CloudSpeed;

		// Token: 0x04010320 RID: 66336
		internal static int __PropertyOffset_Top_Rotation;

		// Token: 0x04010321 RID: 66337
		internal static int __PropertyOffset_Special_Texture;

		// Token: 0x04010322 RID: 66338
		internal static int __PropertyOffset_Special_Material;

		// Token: 0x04010323 RID: 66339
		internal static int __PropertyOffset_Special_Rotation;

		// Token: 0x04010324 RID: 66340
		internal static int __PropertyOffset_Intensity;

		// Token: 0x04010325 RID: 66341
		internal static int __PropertyOffset_TransSortNumber;

		// Token: 0x04010326 RID: 66342
		internal static int __PropertyOffset_CloudSpecialMesh;

		// Token: 0x04010327 RID: 66343
		internal static int __PropertyOffset_Noise_Texture;

		// Token: 0x04010328 RID: 66344
		internal static int __PropertyOffset_NoiseStrength;

		// Token: 0x04010329 RID: 66345
		internal static int __PropertyOffset_NoiseSpeed;

		// Token: 0x0401032A RID: 66346
		internal static int __PropertyOffset_NoiseTilling;

		// Token: 0x0401032B RID: 66347
		internal static int __PropertyOffset_Anomalies_Texture;

		// Token: 0x0401032C RID: 66348
		internal static int __PropertyOffset_Color;

		// Token: 0x0401032D RID: 66349
		internal static int __PropertyOffset_Anomalies_Rotation;

		// Token: 0x0401032E RID: 66350
		internal static int __PropertyOffset_Anomalies_Intensity;

		// Token: 0x0401032F RID: 66351
		internal static int __PropertyOffset_Anomalies_Scale;

		// Token: 0x04010330 RID: 66352
		internal static int __PropertyOffset_Sky;

		// Token: 0x04010331 RID: 66353
		private FKuroCurveFloat _Sky;

		// Token: 0x04010332 RID: 66354
		internal static int __PropertyOffset_StarTrails;

		// Token: 0x04010333 RID: 66355
		private FKuroCurveFloat _StarTrails;

		// Token: 0x04010334 RID: 66356
		internal static int __PropertyOffset_Delta_Seconds;

		// Token: 0x04010335 RID: 66357
		internal static int __PropertyOffset_Time;

		// Token: 0x04010336 RID: 66358
		internal static int __PropertyOffset_Duration;

		// Token: 0x04010337 RID: 66359
		internal static int __PropertyOffset_IsTick;

		// Token: 0x04010338 RID: 66360
		internal static int __PropertyOffset_Anomalies_NoiseSpeed;

		// Token: 0x04010339 RID: 66361
		internal static int __PropertyOffset_Anomalies_NoiseStrength;

		// Token: 0x0401033A RID: 66362
		internal static int __PropertyOffset_Anomalies_NoiseTilling;

		// Token: 0x0401033B RID: 66363
		internal static int __PropertyOffset_Anomalies_NoiseTex;

		// Token: 0x0401033C RID: 66364
		internal static int __PropertyOffset_LevelLog;

		// Token: 0x0401033D RID: 66365
		internal static int __PropertyOffset_Translucent;

		// Token: 0x0401033E RID: 66366
		private static IntPtr __Timer_NativeFunctionPtr;

		// Token: 0x0401033F RID: 66367
		private static IntPtr __ChangeSky_NativeFunctionPtr;

		// Token: 0x04010340 RID: 66368
		private static IntPtr __Special_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x04010341 RID: 66369
		private static IntPtr __SunMoon_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x04010342 RID: 66370
		private static IntPtr __Single_POI_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x04010343 RID: 66371
		private static IntPtr __UpdatePerFourFrame_NativeFunctionPtr;

		// Token: 0x04010344 RID: 66372
		private static IntPtr __CreateDMI_NativeFunctionPtr;

		// Token: 0x04010345 RID: 66373
		private static IntPtr __Single_Cloud_Parameters_Initial_NativeFunctionPtr;

		// Token: 0x04010346 RID: 66374
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010347 RID: 66375
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010348 RID: 66376
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010349 RID: 66377
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0401034A RID: 66378
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x02008E97 RID: 36503
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Timer_FunctionParams
		{
			// Token: 0x0402CB06 RID: 183046
			[FieldOffset(0)]
			public float ElapsedTime;
		}

		// Token: 0x02008E98 RID: 36504
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __ChangeSky_FunctionParams
		{
			// Token: 0x0402CB07 RID: 183047
			[FieldOffset(0)]
			public bool IsTick;
		}

		// Token: 0x02008E99 RID: 36505
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 248)]
		protected ref struct __Special_Parameters_Initial_FunctionParams
		{
			// Token: 0x0402CB08 RID: 183048
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x0402CB09 RID: 183049
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x0402CB0A RID: 183050
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x0402CB0B RID: 183051
			[FieldOffset(24)]
			public FRotator POIRotation;

			// Token: 0x0402CB0C RID: 183052
			[FieldOffset(36)]
			public float Intensity;

			// Token: 0x0402CB0D RID: 183053
			[FieldOffset(40)]
			public FVector Scale;

			// Token: 0x0402CB0E RID: 183054
			[FieldOffset(56)]
			public IntPtr NoiseTex;

			// Token: 0x0402CB0F RID: 183055
			[FieldOffset(64)]
			public float NoiseSpeed;

			// Token: 0x0402CB10 RID: 183056
			[FieldOffset(68)]
			public float NoiseStrength;

			// Token: 0x0402CB11 RID: 183057
			[FieldOffset(72)]
			public float NoiseTilling;

			// Token: 0x0402CB12 RID: 183058
			[FieldOffset(76)]
			public FLinearColor Color;
		}

		// Token: 0x02008E9A RID: 36506
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 216)]
		protected ref struct __SunMoon_Parameters_Initial_FunctionParams
		{
			// Token: 0x0402CB13 RID: 183059
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x0402CB14 RID: 183060
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x0402CB15 RID: 183061
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x0402CB16 RID: 183062
			[FieldOffset(24)]
			public FRotator POIRotation;

			// Token: 0x0402CB17 RID: 183063
			[FieldOffset(36)]
			public float Intensity;
		}

		// Token: 0x02008E9B RID: 36507
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __Single_POI_Parameters_Initial_FunctionParams
		{
			// Token: 0x0402CB18 RID: 183064
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x0402CB19 RID: 183065
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x0402CB1A RID: 183066
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x0402CB1B RID: 183067
			[FieldOffset(24)]
			public FRotator POIRotation;
		}

		// Token: 0x02008E9C RID: 36508
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CreateDMI_FunctionParams
		{
			// Token: 0x0402CB1C RID: 183068
			[FieldOffset(0)]
			public IntPtr Mesh;

			// Token: 0x0402CB1D RID: 183069
			[FieldOffset(8)]
			public IntPtr Material;

			// Token: 0x0402CB1E RID: 183070
			[FieldOffset(16)]
			public IntPtr DMI;
		}

		// Token: 0x02008E9D RID: 36509
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __Single_Cloud_Parameters_Initial_FunctionParams
		{
			// Token: 0x0402CB1F RID: 183071
			[FieldOffset(0)]
			public IntPtr DMI;

			// Token: 0x0402CB20 RID: 183072
			[FieldOffset(8)]
			public IntPtr Mesh;

			// Token: 0x0402CB21 RID: 183073
			[FieldOffset(16)]
			public IntPtr Texture;

			// Token: 0x0402CB22 RID: 183074
			[FieldOffset(24)]
			public bool UV1UV2_;

			// Token: 0x0402CB23 RID: 183075
			[FieldOffset(28)]
			public float CloudSpeed;

			// Token: 0x0402CB24 RID: 183076
			[FieldOffset(32)]
			public float Top_Rotation;

			// Token: 0x0402CB25 RID: 183077
			[FieldOffset(36)]
			public float UVTiling;

			// Token: 0x0402CB26 RID: 183078
			[FieldOffset(40)]
			public float NoiseStrength;

			// Token: 0x0402CB27 RID: 183079
			[FieldOffset(44)]
			public float NoiseSpeed;

			// Token: 0x0402CB28 RID: 183080
			[FieldOffset(48)]
			public float NoiseTilling;

			// Token: 0x0402CB29 RID: 183081
			[FieldOffset(56)]
			public IntPtr NoiseTex;
		}

		// Token: 0x02008E9E RID: 36510
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CB2A RID: 183082
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E9F RID: 36511
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CB2B RID: 183083
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
