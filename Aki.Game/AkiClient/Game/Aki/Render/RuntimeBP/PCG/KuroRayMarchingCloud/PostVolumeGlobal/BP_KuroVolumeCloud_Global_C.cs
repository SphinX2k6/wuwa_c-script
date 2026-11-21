using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroRayMarchingCloud.PostVolumeGlobal
{
	// Token: 0x020030E7 RID: 12519
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/BP_KuroVolumeCloud_Global.BP_KuroVolumeCloud_Global_C")]
	[UnrealStructLayout(2016, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2012)]
	public class BP_KuroVolumeCloud_Global_C : AKuroBPCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E454 RID: 123988 RVA: 0x0090FDBC File Offset: 0x0090DFBC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroVolumeCloud_Global_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/BP_KuroVolumeCloud_Global.BP_KuroVolumeCloud_Global_C");
			}
			return BP_KuroVolumeCloud_Global_C._ClassPtr;
		}

		// Token: 0x0601E455 RID: 123989 RVA: 0x0090FDE0 File Offset: 0x0090DFE0
		public BP_KuroVolumeCloud_Global_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeCloud_Global_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E456 RID: 123990 RVA: 0x0090FE08 File Offset: 0x0090E008
		[NullableContext(1)]
		public BP_KuroVolumeCloud_Global_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumeCloud_Global_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0601E457 RID: 123991 RVA: 0x0090FE3B File Offset: 0x0090E03B
		// (set) Token: 0x0601E458 RID: 123992 RVA: 0x0090FE4F File Offset: 0x0090E04F
		public unsafe UStaticMeshComponent Cube
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_Cube);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_Cube, value);
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0601E459 RID: 123993 RVA: 0x0090FE64 File Offset: 0x0090E064
		// (set) Token: 0x0601E45A RID: 123994 RVA: 0x0090FE78 File Offset: 0x0090E078
		public unsafe USceneComponent CloudRange
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_CloudRange);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_CloudRange, value);
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0601E45B RID: 123995 RVA: 0x0090FE8D File Offset: 0x0090E08D
		// (set) Token: 0x0601E45C RID: 123996 RVA: 0x0090FEA1 File Offset: 0x0090E0A1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0601E45D RID: 123997 RVA: 0x0090FEB6 File Offset: 0x0090E0B6
		// (set) Token: 0x0601E45E RID: 123998 RVA: 0x0090FEC6 File Offset: 0x0090E0C6
		public unsafe bool bEditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bEditorTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bEditorTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0601E45F RID: 123999 RVA: 0x0090FED7 File Offset: 0x0090E0D7
		// (set) Token: 0x0601E460 RID: 124000 RVA: 0x0090FEE7 File Offset: 0x0090E0E7
		public unsafe bool bUpdateTransformAlways
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bUpdateTransformAlways) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bUpdateTransformAlways) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0601E461 RID: 124001 RVA: 0x0090FEF8 File Offset: 0x0090E0F8
		// (set) Token: 0x0601E462 RID: 124002 RVA: 0x0090FF08 File Offset: 0x0090E108
		public unsafe bool bDirty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bDirty) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bDirty) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032C9 RID: 13001
		// (get) Token: 0x0601E463 RID: 124003 RVA: 0x0090FF19 File Offset: 0x0090E119
		// (set) Token: 0x0601E464 RID: 124004 RVA: 0x0090FF2D File Offset: 0x0090E12D
		public unsafe FLinearColor BakeFlowSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_BakeFlowSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_BakeFlowSpeed) = value;
			}
		}

		// Token: 0x170032CA RID: 13002
		// (get) Token: 0x0601E465 RID: 124005 RVA: 0x0090FF42 File Offset: 0x0090E142
		// (set) Token: 0x0601E466 RID: 124006 RVA: 0x0090FF56 File Offset: 0x0090E156
		public unsafe UMaterialInterface LastMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastMaterial, value);
			}
		}

		// Token: 0x170032CB RID: 13003
		// (get) Token: 0x0601E467 RID: 124007 RVA: 0x0090FF6B File Offset: 0x0090E16B
		// (set) Token: 0x0601E468 RID: 124008 RVA: 0x0090FF7F File Offset: 0x0090E17F
		public unsafe FVectorDouble LastPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastPosition) = value;
			}
		}

		// Token: 0x170032CC RID: 13004
		// (get) Token: 0x0601E469 RID: 124009 RVA: 0x0090FF94 File Offset: 0x0090E194
		// (set) Token: 0x0601E46A RID: 124010 RVA: 0x0090FFA8 File Offset: 0x0090E1A8
		public unsafe FVectorDouble LastScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastScale) = value;
			}
		}

		// Token: 0x170032CD RID: 13005
		// (get) Token: 0x0601E46B RID: 124011 RVA: 0x0090FFBD File Offset: 0x0090E1BD
		// (set) Token: 0x0601E46C RID: 124012 RVA: 0x0090FFCD File Offset: 0x0090E1CD
		public unsafe bool bLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bLocal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bLocal) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0601E46D RID: 124013 RVA: 0x0090FFDE File Offset: 0x0090E1DE
		// (set) Token: 0x0601E46E RID: 124014 RVA: 0x0090FFF2 File Offset: 0x0090E1F2
		public unsafe FLinearColor CloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_CloudSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_CloudSpeed) = value;
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0601E46F RID: 124015 RVA: 0x00910007 File Offset: 0x0090E207
		// (set) Token: 0x0601E470 RID: 124016 RVA: 0x0091001B File Offset: 0x0090E21B
		public unsafe FLinearColor LocalSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LocalSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LocalSpeed) = value;
			}
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0601E471 RID: 124017 RVA: 0x00910030 File Offset: 0x0090E230
		// (set) Token: 0x0601E472 RID: 124018 RVA: 0x00910040 File Offset: 0x0090E240
		public unsafe int FadeGroup_0_2_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_FadeGroup_0_2_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_FadeGroup_0_2_) = value;
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0601E473 RID: 124019 RVA: 0x00910051 File Offset: 0x0090E251
		// (set) Token: 0x0601E474 RID: 124020 RVA: 0x00910061 File Offset: 0x0090E261
		public unsafe float LocalOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LocalOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LocalOpacity) = value;
			}
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0601E475 RID: 124021 RVA: 0x00910072 File Offset: 0x0090E272
		// (set) Token: 0x0601E476 RID: 124022 RVA: 0x00910086 File Offset: 0x0090E286
		public unsafe FLinearColor ThunderColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderColor) = value;
			}
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0601E477 RID: 124023 RVA: 0x0091009B File Offset: 0x0090E29B
		// (set) Token: 0x0601E478 RID: 124024 RVA: 0x009100AB File Offset: 0x0090E2AB
		public unsafe float ThunderSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderSpeed) = value;
			}
		}

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0601E479 RID: 124025 RVA: 0x009100BC File Offset: 0x0090E2BC
		// (set) Token: 0x0601E47A RID: 124026 RVA: 0x009100CC File Offset: 0x0090E2CC
		public unsafe float ThunderTimeCounter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderTimeCounter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderTimeCounter) = value;
			}
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0601E47B RID: 124027 RVA: 0x009100DD File Offset: 0x0090E2DD
		// (set) Token: 0x0601E47C RID: 124028 RVA: 0x009100F1 File Offset: 0x0090E2F1
		public unsafe UCurveFloat ThunderCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderCurve, value);
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0601E47D RID: 124029 RVA: 0x00910106 File Offset: 0x0090E306
		// (set) Token: 0x0601E47E RID: 124030 RVA: 0x0091011A File Offset: 0x0090E31A
		public unsafe UCurveFloat ThunderCurve2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderCurve2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderCurve2, value);
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0601E47F RID: 124031 RVA: 0x0091012F File Offset: 0x0090E32F
		// (set) Token: 0x0601E480 RID: 124032 RVA: 0x00910143 File Offset: 0x0090E343
		public unsafe UCurveFloat ThunderCurve3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderCurve3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_ThunderCurve3, value);
			}
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0601E481 RID: 124033 RVA: 0x00910158 File Offset: 0x0090E358
		// (set) Token: 0x0601E482 RID: 124034 RVA: 0x00910191 File Offset: 0x0090E391
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_Scalar_Parameters, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0601E483 RID: 124035 RVA: 0x009101A0 File Offset: 0x0090E3A0
		// (set) Token: 0x0601E484 RID: 124036 RVA: 0x009101D9 File Offset: 0x0090E3D9
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_Vector_Parameters, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0601E485 RID: 124037 RVA: 0x009101E8 File Offset: 0x0090E3E8
		// (set) Token: 0x0601E486 RID: 124038 RVA: 0x00910221 File Offset: 0x0090E421
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_Texture_Parameters, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0601E487 RID: 124039 RVA: 0x0091022F File Offset: 0x0090E42F
		// (set) Token: 0x0601E488 RID: 124040 RVA: 0x0091023F File Offset: 0x0090E43F
		public unsafe bool bUseGlobalSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bUseGlobalSpeed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bUseGlobalSpeed) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0601E489 RID: 124041 RVA: 0x00910250 File Offset: 0x0090E450
		// (set) Token: 0x0601E48A RID: 124042 RVA: 0x00910260 File Offset: 0x0090E460
		public unsafe bool bEnableDistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bEnableDistanceFade) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bEnableDistanceFade) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032DD RID: 13021
		// (get) Token: 0x0601E48B RID: 124043 RVA: 0x00910271 File Offset: 0x0090E471
		// (set) Token: 0x0601E48C RID: 124044 RVA: 0x00910281 File Offset: 0x0090E481
		public unsafe double DistanceFadeWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_DistanceFadeWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_DistanceFadeWidth) = value;
			}
		}

		// Token: 0x170032DE RID: 13022
		// (get) Token: 0x0601E48D RID: 124045 RVA: 0x00910292 File Offset: 0x0090E492
		// (set) Token: 0x0601E48E RID: 124046 RVA: 0x009102A2 File Offset: 0x0090E4A2
		public unsafe double DistanceFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_DistanceFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_DistanceFade) = value;
			}
		}

		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0601E48F RID: 124047 RVA: 0x009102B3 File Offset: 0x0090E4B3
		// (set) Token: 0x0601E490 RID: 124048 RVA: 0x009102C3 File Offset: 0x0090E4C3
		public unsafe int NowQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_NowQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_NowQuality) = value;
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0601E491 RID: 124049 RVA: 0x009102D4 File Offset: 0x0090E4D4
		// (set) Token: 0x0601E492 RID: 124050 RVA: 0x009102E8 File Offset: 0x0090E4E8
		public unsafe AStaticMeshActor LowQualityMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AStaticMeshActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_LowQualityMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_LowQualityMesh, value);
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0601E493 RID: 124051 RVA: 0x009102FD File Offset: 0x0090E4FD
		// (set) Token: 0x0601E494 RID: 124052 RVA: 0x0091030D File Offset: 0x0090E50D
		public unsafe float CacheLocalOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_CacheLocalOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_CacheLocalOpacity) = value;
			}
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0601E495 RID: 124053 RVA: 0x0091031E File Offset: 0x0090E51E
		// (set) Token: 0x0601E496 RID: 124054 RVA: 0x0091032E File Offset: 0x0090E52E
		public unsafe bool LastNotAffectedByVRS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastNotAffectedByVRS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastNotAffectedByVRS) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0601E497 RID: 124055 RVA: 0x0091033F File Offset: 0x0090E53F
		// (set) Token: 0x0601E498 RID: 124056 RVA: 0x0091034F File Offset: 0x0090E54F
		public unsafe int LastQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastQualityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_LastQualityLevel) = value;
			}
		}

		// Token: 0x170032E4 RID: 13028
		// (get) Token: 0x0601E499 RID: 124057 RVA: 0x00910360 File Offset: 0x0090E560
		// (set) Token: 0x0601E49A RID: 124058 RVA: 0x00910374 File Offset: 0x0090E574
		public unsafe UMaterialParameterCollection MPC_GlobalShader
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_MPC_GlobalShader);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumeCloud_Global_C.__PropertyOffset_MPC_GlobalShader, value);
			}
		}

		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0601E49B RID: 124059 RVA: 0x00910389 File Offset: 0x0090E589
		// (set) Token: 0x0601E49C RID: 124060 RVA: 0x00910399 File Offset: 0x0090E599
		public unsafe float VolumeCloudSpeedMulti
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_VolumeCloudSpeedMulti);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_VolumeCloudSpeedMulti) = value;
			}
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0601E49D RID: 124061 RVA: 0x009103AA File Offset: 0x0090E5AA
		// (set) Token: 0x0601E49E RID: 124062 RVA: 0x009103BA File Offset: 0x0090E5BA
		public unsafe bool bShouldTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bShouldTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bShouldTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0601E49F RID: 124063 RVA: 0x009103CB File Offset: 0x0090E5CB
		// (set) Token: 0x0601E4A0 RID: 124064 RVA: 0x009103DB File Offset: 0x0090E5DB
		public unsafe bool bLocalOnlyForVRS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bLocalOnlyForVRS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bLocalOnlyForVRS) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0601E4A1 RID: 124065 RVA: 0x009103EC File Offset: 0x0090E5EC
		// (set) Token: 0x0601E4A2 RID: 124066 RVA: 0x009103FC File Offset: 0x0090E5FC
		public unsafe bool bVolumeCloudNotAffectedByVRS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bVolumeCloudNotAffectedByVRS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bVolumeCloudNotAffectedByVRS) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0601E4A3 RID: 124067 RVA: 0x0091040D File Offset: 0x0090E60D
		// (set) Token: 0x0601E4A4 RID: 124068 RVA: 0x0091041D File Offset: 0x0090E61D
		public unsafe bool bMac
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bMac) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_bMac) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0601E4A5 RID: 124069 RVA: 0x0091042E File Offset: 0x0090E62E
		// (set) Token: 0x0601E4A6 RID: 124070 RVA: 0x00910442 File Offset: 0x0090E642
		public unsafe FName FadeGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_FadeGroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_FadeGroupName) = value;
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0601E4A7 RID: 124071 RVA: 0x00910457 File Offset: 0x0090E657
		// (set) Token: 0x0601E4A8 RID: 124072 RVA: 0x00910467 File Offset: 0x0090E667
		public unsafe bool vrsNotChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_vrsNotChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_vrsNotChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0601E4A9 RID: 124073 RVA: 0x00910478 File Offset: 0x0090E678
		// (set) Token: 0x0601E4AA RID: 124074 RVA: 0x00910488 File Offset: 0x0090E688
		public unsafe int VRSQualityOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_VRSQualityOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroVolumeCloud_Global_C.__PropertyOffset_VRSQualityOffset) = value;
			}
		}

		// Token: 0x0601E4AB RID: 124075 RVA: 0x00910499 File Offset: 0x0090E699
		[SkipLocalsInit]
		public virtual void UpdateCloudShadingRateLocal()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateCloudShadingRateLocal_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4AC RID: 124076 RVA: 0x009104AD File Offset: 0x0090E6AD
		[SkipLocalsInit]
		public virtual void UpdateCloudShadingRate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateCloudShadingRate_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4AD RID: 124077 RVA: 0x009104C1 File Offset: 0x0090E6C1
		[SkipLocalsInit]
		public virtual void CleanMID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__CleanMID_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4AE RID: 124078 RVA: 0x009104D5 File Offset: 0x0090E6D5
		[SkipLocalsInit]
		public virtual void CheckNeed_Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__CheckNeed_Update_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4AF RID: 124079 RVA: 0x009104E9 File Offset: 0x0090E6E9
		[SkipLocalsInit]
		public virtual void Update()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__Update_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4B0 RID: 124080 RVA: 0x009104FD File Offset: 0x0090E6FD
		[SkipLocalsInit]
		public virtual void UpdateCloudLighting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateCloudLighting_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4B1 RID: 124081 RVA: 0x00910511 File Offset: 0x0090E711
		[SkipLocalsInit]
		public virtual void UpdateCloudTransform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateCloudTransform_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4B2 RID: 124082 RVA: 0x00910525 File Offset: 0x0090E725
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4B3 RID: 124083 RVA: 0x00910539 File Offset: 0x0090E739
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4B4 RID: 124084 RVA: 0x0091054D File Offset: 0x0090E74D
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4B5 RID: 124085 RVA: 0x00910561 File Offset: 0x0090E761
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4B6 RID: 124086 RVA: 0x00910578 File Offset: 0x0090E778
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Global_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E4B7 RID: 124087 RVA: 0x009105C0 File Offset: 0x0090E7C0
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroVolumeCloud_Global_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Global_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E4B8 RID: 124088 RVA: 0x00910606 File Offset: 0x0090E806
		[SkipLocalsInit]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4B9 RID: 124089 RVA: 0x0091061A File Offset: 0x0090E81A
		[SkipLocalsInit]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4BA RID: 124090 RVA: 0x0091062E File Offset: 0x0090E82E
		[SkipLocalsInit]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4BB RID: 124091 RVA: 0x00910642 File Offset: 0x0090E842
		[SkipLocalsInit]
		public override void BeforeCookForPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4BC RID: 124092 RVA: 0x00910656 File Offset: 0x0090E856
		[SkipLocalsInit]
		protected override void BeforeCookForPC_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4BD RID: 124093 RVA: 0x0091066A File Offset: 0x0090E86A
		[SkipLocalsInit]
		public override void BeforeSave()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeSave_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4BE RID: 124094 RVA: 0x0091067E File Offset: 0x0090E87E
		[SkipLocalsInit]
		protected virtual void BeforeSave_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__BeforeSave_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4BF RID: 124095 RVA: 0x00910692 File Offset: 0x0090E892
		[SkipLocalsInit]
		public virtual void UpdateQualitySwitch()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__UpdateQualitySwitch_NativeFunctionPtr, null);
		}

		// Token: 0x0601E4C0 RID: 124096 RVA: 0x009106A8 File Offset: 0x0090E8A8
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E4C1 RID: 124097 RVA: 0x009106F4 File Offset: 0x0090E8F4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumeCloud_Global_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E4C2 RID: 124098 RVA: 0x0091073F File Offset: 0x0090E93F
		protected BP_KuroVolumeCloud_Global_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010059 RID: 65625
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroRayMarchingCloud/PostVolumeGlobal/BP_KuroVolumeCloud_Global.BP_KuroVolumeCloud_Global_C";

		// Token: 0x0401005A RID: 65626
		private static IntPtr _ClassPtr;

		// Token: 0x0401005B RID: 65627
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401005C RID: 65628
		internal static int __PropertyOffset_Cube;

		// Token: 0x0401005D RID: 65629
		internal static int __PropertyOffset_CloudRange;

		// Token: 0x0401005E RID: 65630
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0401005F RID: 65631
		internal static int __PropertyOffset_bEditorTick;

		// Token: 0x04010060 RID: 65632
		internal static int __PropertyOffset_bUpdateTransformAlways;

		// Token: 0x04010061 RID: 65633
		internal static int __PropertyOffset_bDirty;

		// Token: 0x04010062 RID: 65634
		internal static int __PropertyOffset_BakeFlowSpeed;

		// Token: 0x04010063 RID: 65635
		internal static int __PropertyOffset_LastMaterial;

		// Token: 0x04010064 RID: 65636
		internal static int __PropertyOffset_LastPosition;

		// Token: 0x04010065 RID: 65637
		internal static int __PropertyOffset_LastScale;

		// Token: 0x04010066 RID: 65638
		internal static int __PropertyOffset_bLocal;

		// Token: 0x04010067 RID: 65639
		internal static int __PropertyOffset_CloudSpeed;

		// Token: 0x04010068 RID: 65640
		internal static int __PropertyOffset_LocalSpeed;

		// Token: 0x04010069 RID: 65641
		internal static int __PropertyOffset_FadeGroup_0_2_;

		// Token: 0x0401006A RID: 65642
		internal static int __PropertyOffset_LocalOpacity;

		// Token: 0x0401006B RID: 65643
		internal static int __PropertyOffset_ThunderColor;

		// Token: 0x0401006C RID: 65644
		internal static int __PropertyOffset_ThunderSpeed;

		// Token: 0x0401006D RID: 65645
		internal static int __PropertyOffset_ThunderTimeCounter;

		// Token: 0x0401006E RID: 65646
		internal static int __PropertyOffset_ThunderCurve;

		// Token: 0x0401006F RID: 65647
		internal static int __PropertyOffset_ThunderCurve2;

		// Token: 0x04010070 RID: 65648
		internal static int __PropertyOffset_ThunderCurve3;

		// Token: 0x04010071 RID: 65649
		internal static int __PropertyOffset_Scalar_Parameters;

		// Token: 0x04010072 RID: 65650
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04010073 RID: 65651
		internal static int __PropertyOffset_Vector_Parameters;

		// Token: 0x04010074 RID: 65652
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04010075 RID: 65653
		internal static int __PropertyOffset_Texture_Parameters;

		// Token: 0x04010076 RID: 65654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04010077 RID: 65655
		internal static int __PropertyOffset_bUseGlobalSpeed;

		// Token: 0x04010078 RID: 65656
		internal static int __PropertyOffset_bEnableDistanceFade;

		// Token: 0x04010079 RID: 65657
		internal static int __PropertyOffset_DistanceFadeWidth;

		// Token: 0x0401007A RID: 65658
		internal static int __PropertyOffset_DistanceFade;

		// Token: 0x0401007B RID: 65659
		internal static int __PropertyOffset_NowQuality;

		// Token: 0x0401007C RID: 65660
		internal static int __PropertyOffset_LowQualityMesh;

		// Token: 0x0401007D RID: 65661
		internal static int __PropertyOffset_CacheLocalOpacity;

		// Token: 0x0401007E RID: 65662
		internal static int __PropertyOffset_LastNotAffectedByVRS;

		// Token: 0x0401007F RID: 65663
		internal static int __PropertyOffset_LastQualityLevel;

		// Token: 0x04010080 RID: 65664
		internal static int __PropertyOffset_MPC_GlobalShader;

		// Token: 0x04010081 RID: 65665
		internal static int __PropertyOffset_VolumeCloudSpeedMulti;

		// Token: 0x04010082 RID: 65666
		internal static int __PropertyOffset_bShouldTick;

		// Token: 0x04010083 RID: 65667
		internal static int __PropertyOffset_bLocalOnlyForVRS;

		// Token: 0x04010084 RID: 65668
		internal static int __PropertyOffset_bVolumeCloudNotAffectedByVRS;

		// Token: 0x04010085 RID: 65669
		internal static int __PropertyOffset_bMac;

		// Token: 0x04010086 RID: 65670
		internal static int __PropertyOffset_FadeGroupName;

		// Token: 0x04010087 RID: 65671
		internal static int __PropertyOffset_vrsNotChanged;

		// Token: 0x04010088 RID: 65672
		internal static int __PropertyOffset_VRSQualityOffset;

		// Token: 0x04010089 RID: 65673
		private static IntPtr __UpdateCloudShadingRateLocal_NativeFunctionPtr;

		// Token: 0x0401008A RID: 65674
		private static IntPtr __UpdateCloudShadingRate_NativeFunctionPtr;

		// Token: 0x0401008B RID: 65675
		private static IntPtr __CleanMID_NativeFunctionPtr;

		// Token: 0x0401008C RID: 65676
		private static IntPtr __CheckNeed_Update_NativeFunctionPtr;

		// Token: 0x0401008D RID: 65677
		private static IntPtr __Update_NativeFunctionPtr;

		// Token: 0x0401008E RID: 65678
		private static IntPtr __UpdateCloudLighting_NativeFunctionPtr;

		// Token: 0x0401008F RID: 65679
		private static IntPtr __UpdateCloudTransform_NativeFunctionPtr;

		// Token: 0x04010090 RID: 65680
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010091 RID: 65681
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010092 RID: 65682
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04010093 RID: 65683
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010094 RID: 65684
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x04010095 RID: 65685
		private static IntPtr __BeforeCookForPC_NativeFunctionPtr;

		// Token: 0x04010096 RID: 65686
		private static IntPtr __BeforeSave_NativeFunctionPtr;

		// Token: 0x04010097 RID: 65687
		private static IntPtr __UpdateQualitySwitch_NativeFunctionPtr;

		// Token: 0x04010098 RID: 65688
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02008E5C RID: 36444
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CAA7 RID: 182951
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E5D RID: 36445
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CAA8 RID: 182952
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
