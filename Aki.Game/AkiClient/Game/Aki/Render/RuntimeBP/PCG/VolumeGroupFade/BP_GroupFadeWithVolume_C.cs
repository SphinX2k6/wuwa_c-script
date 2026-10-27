using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene;
using AkiClient.Game.Aki.Render.RuntimeBP.GI;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.NewCloud.BP;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.VolumeGroupFade
{
	// Token: 0x02003BE2 RID: 15330
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_GroupFadeWithVolume.BP_GroupFadeWithVolume_C")]
	[UnrealStructLayout(2576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2573)]
	public class BP_GroupFadeWithVolume_C : AKuroBPCustomCookActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060229B0 RID: 141744 RVA: 0x0090D6FE File Offset: 0x0090B8FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GroupFadeWithVolume_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_GroupFadeWithVolume.BP_GroupFadeWithVolume_C");
			}
			return BP_GroupFadeWithVolume_C._ClassPtr;
		}

		// Token: 0x060229B1 RID: 141745 RVA: 0x0090D724 File Offset: 0x0090B924
		public BP_GroupFadeWithVolume_C() : this(BuiltinUtils.AllocNativeUObject(BP_GroupFadeWithVolume_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060229B2 RID: 141746 RVA: 0x0090D74C File Offset: 0x0090B94C
		public BP_GroupFadeWithVolume_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GroupFadeWithVolume_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x060229B3 RID: 141747 RVA: 0x0090D77F File Offset: 0x0090B97F
		// (set) Token: 0x060229B4 RID: 141748 RVA: 0x0090D793 File Offset: 0x0090B993
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroupFadeWithVolume_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroupFadeWithVolume_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x060229B5 RID: 141749 RVA: 0x0090D7A8 File Offset: 0x0090B9A8
		// (set) Token: 0x060229B6 RID: 141750 RVA: 0x0090D7E1 File Offset: 0x0090B9E1
		public TSet<ALight> LightList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<ALight> result;
				if ((result = this._LightList) == null)
				{
					result = (this._LightList = new TSet<ALight>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.LightList.CopyAssign(value);
			}
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x060229B7 RID: 141751 RVA: 0x0090D7F0 File Offset: 0x0090B9F0
		// (set) Token: 0x060229B8 RID: 141752 RVA: 0x0090D829 File Offset: 0x0090BA29
		public TArray<float> CachedLightIntensity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedLightIntensity) == null)
				{
					result = (this._CachedLightIntensity = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.CachedLightIntensity.CopyAssign(value);
			}
		}

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x060229B9 RID: 141753 RVA: 0x0090D838 File Offset: 0x0090BA38
		// (set) Token: 0x060229BA RID: 141754 RVA: 0x0090D871 File Offset: 0x0090BA71
		public TSet<BP_VolumetricSphereLight_C> VolumeLightSphereList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<BP_VolumetricSphereLight_C> result;
				if ((result = this._VolumeLightSphereList) == null)
				{
					result = (this._VolumeLightSphereList = new TSet<BP_VolumetricSphereLight_C>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.VolumeLightSphereList.CopyAssign(value);
			}
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x060229BB RID: 141755 RVA: 0x0090D880 File Offset: 0x0090BA80
		// (set) Token: 0x060229BC RID: 141756 RVA: 0x0090D8B9 File Offset: 0x0090BAB9
		public TArray<float> CachedVolumeLightSphere
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedVolumeLightSphere) == null)
				{
					result = (this._CachedVolumeLightSphere = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.CachedVolumeLightSphere.CopyAssign(value);
			}
		}

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x060229BD RID: 141757 RVA: 0x0090D8C8 File Offset: 0x0090BAC8
		// (set) Token: 0x060229BE RID: 141758 RVA: 0x0090D901 File Offset: 0x0090BB01
		public TSet<BP_KuroLightDecal_C> DecalLightList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<BP_KuroLightDecal_C> result;
				if ((result = this._DecalLightList) == null)
				{
					result = (this._DecalLightList = new TSet<BP_KuroLightDecal_C>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.DecalLightList.CopyAssign(value);
			}
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x060229BF RID: 141759 RVA: 0x0090D910 File Offset: 0x0090BB10
		// (set) Token: 0x060229C0 RID: 141760 RVA: 0x0090D949 File Offset: 0x0090BB49
		public TArray<float> CachedDecalLight
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedDecalLight) == null)
				{
					result = (this._CachedDecalLight = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_7, this));
				}
				return result;
			}
			set
			{
				this.CachedDecalLight.CopyAssign(value);
			}
		}

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x060229C1 RID: 141761 RVA: 0x0090D958 File Offset: 0x0090BB58
		// (set) Token: 0x060229C2 RID: 141762 RVA: 0x0090D991 File Offset: 0x0090BB91
		public TSet<BP_VolumetricSphereLightSuperFar_C> VolumeLightSphereSuperFarList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<BP_VolumetricSphereLightSuperFar_C> result;
				if ((result = this._VolumeLightSphereSuperFarList) == null)
				{
					result = (this._VolumeLightSphereSuperFarList = new TSet<BP_VolumetricSphereLightSuperFar_C>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				this.VolumeLightSphereSuperFarList.CopyAssign(value);
			}
		}

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x060229C3 RID: 141763 RVA: 0x0090D9A0 File Offset: 0x0090BBA0
		// (set) Token: 0x060229C4 RID: 141764 RVA: 0x0090D9D9 File Offset: 0x0090BBD9
		public TArray<float> CachedVolumeLightSphereSuperFar
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedVolumeLightSphereSuperFar) == null)
				{
					result = (this._CachedVolumeLightSphereSuperFar = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_9, this));
				}
				return result;
			}
			set
			{
				this.CachedVolumeLightSphereSuperFar.CopyAssign(value);
			}
		}

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x060229C5 RID: 141765 RVA: 0x0090D9E7 File Offset: 0x0090BBE7
		// (set) Token: 0x060229C6 RID: 141766 RVA: 0x0090D9FB File Offset: 0x0090BBFB
		[Nullable(2)]
		public unsafe AKuroPostProcessVolume BoundVolume
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AKuroPostProcessVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroupFadeWithVolume_C.__PropertyOffset_10);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroupFadeWithVolume_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x060229C7 RID: 141767 RVA: 0x0090DA10 File Offset: 0x0090BC10
		// (set) Token: 0x060229C8 RID: 141768 RVA: 0x0090DA24 File Offset: 0x0090BC24
		[Nullable(2)]
		public unsafe BP_GlobalGI_C CachedGlobalGI
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GlobalGI_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroupFadeWithVolume_C.__PropertyOffset_11);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_GroupFadeWithVolume_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x060229C9 RID: 141769 RVA: 0x0090DA39 File Offset: 0x0090BC39
		// (set) Token: 0x060229CA RID: 141770 RVA: 0x0090DA49 File Offset: 0x0090BC49
		public unsafe float lastWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x060229CB RID: 141771 RVA: 0x0090DA5C File Offset: 0x0090BC5C
		// (set) Token: 0x060229CC RID: 141772 RVA: 0x0090DA95 File Offset: 0x0090BC95
		public TSet<BP_SingleCloud_C> CloudList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<BP_SingleCloud_C> result;
				if ((result = this._CloudList) == null)
				{
					result = (this._CloudList = new TSet<BP_SingleCloud_C>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_13, this));
				}
				return result;
			}
			set
			{
				this.CloudList.CopyAssign(value);
			}
		}

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x060229CD RID: 141773 RVA: 0x0090DAA4 File Offset: 0x0090BCA4
		// (set) Token: 0x060229CE RID: 141774 RVA: 0x0090DADD File Offset: 0x0090BCDD
		public TArray<float> CachedCloudIntensity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedCloudIntensity) == null)
				{
					result = (this._CachedCloudIntensity = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				this.CachedCloudIntensity.CopyAssign(value);
			}
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x060229CF RID: 141775 RVA: 0x0090DAEC File Offset: 0x0090BCEC
		// (set) Token: 0x060229D0 RID: 141776 RVA: 0x0090DB25 File Offset: 0x0090BD25
		public TSet<BP_SingleCloud_Custom_C> CustomCloudList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<BP_SingleCloud_Custom_C> result;
				if ((result = this._CustomCloudList) == null)
				{
					result = (this._CustomCloudList = new TSet<BP_SingleCloud_Custom_C>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.CustomCloudList.CopyAssign(value);
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x060229D1 RID: 141777 RVA: 0x0090DB34 File Offset: 0x0090BD34
		// (set) Token: 0x060229D2 RID: 141778 RVA: 0x0090DB6D File Offset: 0x0090BD6D
		public TArray<float> CachedCustomCloudIntensity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedCustomCloudIntensity) == null)
				{
					result = (this._CachedCustomCloudIntensity = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_16, this));
				}
				return result;
			}
			set
			{
				this.CachedCustomCloudIntensity.CopyAssign(value);
			}
		}

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x060229D3 RID: 141779 RVA: 0x0090DB7B File Offset: 0x0090BD7B
		// (set) Token: 0x060229D4 RID: 141780 RVA: 0x0090DB8B File Offset: 0x0090BD8B
		public unsafe bool bPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x060229D5 RID: 141781 RVA: 0x0090DB9C File Offset: 0x0090BD9C
		// (set) Token: 0x060229D6 RID: 141782 RVA: 0x0090DBAC File Offset: 0x0090BDAC
		public unsafe bool bMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x060229D7 RID: 141783 RVA: 0x0090DBC0 File Offset: 0x0090BDC0
		// (set) Token: 0x060229D8 RID: 141784 RVA: 0x0090DBF9 File Offset: 0x0090BDF9
		public TSet<AKuroPostProcessVolume> FadeOutVolumes
		{
			get
			{
				base.FastCheckIsValid();
				TSet<AKuroPostProcessVolume> result;
				if ((result = this._FadeOutVolumes) == null)
				{
					result = (this._FadeOutVolumes = new TSet<AKuroPostProcessVolume>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_19, this));
				}
				return result;
			}
			set
			{
				this.FadeOutVolumes.CopyAssign(value);
			}
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x060229D9 RID: 141785 RVA: 0x0090DC07 File Offset: 0x0090BE07
		// (set) Token: 0x060229DA RID: 141786 RVA: 0x0090DC17 File Offset: 0x0090BE17
		public unsafe float maxFadeoutWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x060229DB RID: 141787 RVA: 0x0090DC28 File Offset: 0x0090BE28
		// (set) Token: 0x060229DC RID: 141788 RVA: 0x0090DC38 File Offset: 0x0090BE38
		public unsafe bool bCooked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x060229DD RID: 141789 RVA: 0x0090DC4C File Offset: 0x0090BE4C
		// (set) Token: 0x060229DE RID: 141790 RVA: 0x0090DC85 File Offset: 0x0090BE85
		public TSet<BP_SuperFarFog_C> SuperfarFogList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<BP_SuperFarFog_C> result;
				if ((result = this._SuperfarFogList) == null)
				{
					result = (this._SuperfarFogList = new TSet<BP_SuperFarFog_C>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_22, this));
				}
				return result;
			}
			set
			{
				this.SuperfarFogList.CopyAssign(value);
			}
		}

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x060229DF RID: 141791 RVA: 0x0090DC94 File Offset: 0x0090BE94
		// (set) Token: 0x060229E0 RID: 141792 RVA: 0x0090DCCD File Offset: 0x0090BECD
		public TArray<float> CachedSuperFarFogOpacity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedSuperFarFogOpacity) == null)
				{
					result = (this._CachedSuperFarFogOpacity = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_23, this));
				}
				return result;
			}
			set
			{
				this.CachedSuperFarFogOpacity.CopyAssign(value);
			}
		}

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x060229E1 RID: 141793 RVA: 0x0090DCDC File Offset: 0x0090BEDC
		// (set) Token: 0x060229E2 RID: 141794 RVA: 0x0090DD15 File Offset: 0x0090BF15
		public TArray<float> CachedSuperFarFogOpacity_Night
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedSuperFarFogOpacity_Night) == null)
				{
					result = (this._CachedSuperFarFogOpacity_Night = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_24, this));
				}
				return result;
			}
			set
			{
				this.CachedSuperFarFogOpacity_Night.CopyAssign(value);
			}
		}

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x060229E3 RID: 141795 RVA: 0x0090DD24 File Offset: 0x0090BF24
		// (set) Token: 0x060229E4 RID: 141796 RVA: 0x0090DD5D File Offset: 0x0090BF5D
		public TSet<BP_KuroFlickLight_C> FlickLightList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<BP_KuroFlickLight_C> result;
				if ((result = this._FlickLightList) == null)
				{
					result = (this._FlickLightList = new TSet<BP_KuroFlickLight_C>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_25, this));
				}
				return result;
			}
			set
			{
				this.FlickLightList.CopyAssign(value);
			}
		}

		// Token: 0x17003CBC RID: 15548
		// (get) Token: 0x060229E5 RID: 141797 RVA: 0x0090DD6C File Offset: 0x0090BF6C
		// (set) Token: 0x060229E6 RID: 141798 RVA: 0x0090DDA5 File Offset: 0x0090BFA5
		public TArray<float> CachedFlickLightIntensity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedFlickLightIntensity) == null)
				{
					result = (this._CachedFlickLightIntensity = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_26, this));
				}
				return result;
			}
			set
			{
				this.CachedFlickLightIntensity.CopyAssign(value);
			}
		}

		// Token: 0x17003CBD RID: 15549
		// (get) Token: 0x060229E7 RID: 141799 RVA: 0x0090DDB4 File Offset: 0x0090BFB4
		// (set) Token: 0x060229E8 RID: 141800 RVA: 0x0090DDED File Offset: 0x0090BFED
		public TSet<BP_KuroLightDecal_C> LightDecalList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<BP_KuroLightDecal_C> result;
				if ((result = this._LightDecalList) == null)
				{
					result = (this._LightDecalList = new TSet<BP_KuroLightDecal_C>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_27, this));
				}
				return result;
			}
			set
			{
				this.LightDecalList.CopyAssign(value);
			}
		}

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x060229E9 RID: 141801 RVA: 0x0090DDFC File Offset: 0x0090BFFC
		// (set) Token: 0x060229EA RID: 141802 RVA: 0x0090DE35 File Offset: 0x0090C035
		public TArray<float> CachedLightDecalIntensity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedLightDecalIntensity) == null)
				{
					result = (this._CachedLightDecalIntensity = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_28, this));
				}
				return result;
			}
			set
			{
				this.CachedLightDecalIntensity.CopyAssign(value);
			}
		}

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x060229EB RID: 141803 RVA: 0x0090DE44 File Offset: 0x0090C044
		// (set) Token: 0x060229EC RID: 141804 RVA: 0x0090DE7D File Offset: 0x0090C07D
		public TSet<BP_ShadowDecal_C> ShadowDecalList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<BP_ShadowDecal_C> result;
				if ((result = this._ShadowDecalList) == null)
				{
					result = (this._ShadowDecalList = new TSet<BP_ShadowDecal_C>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_29, this));
				}
				return result;
			}
			set
			{
				this.ShadowDecalList.CopyAssign(value);
			}
		}

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x060229ED RID: 141805 RVA: 0x0090DE8C File Offset: 0x0090C08C
		// (set) Token: 0x060229EE RID: 141806 RVA: 0x0090DEC5 File Offset: 0x0090C0C5
		public TArray<float> CachedShadowDecalIntensity
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CachedShadowDecalIntensity) == null)
				{
					result = (this._CachedShadowDecalIntensity = new TArray<float>(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_30, this));
				}
				return result;
			}
			set
			{
				this.CachedShadowDecalIntensity.CopyAssign(value);
			}
		}

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x060229EF RID: 141807 RVA: 0x0090DED3 File Offset: 0x0090C0D3
		// (set) Token: 0x060229F0 RID: 141808 RVA: 0x0090DEE3 File Offset: 0x0090C0E3
		public unsafe bool bUseMPCFadeGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x060229F1 RID: 141809 RVA: 0x0090DEF4 File Offset: 0x0090C0F4
		// (set) Token: 0x060229F2 RID: 141810 RVA: 0x0090DF04 File Offset: 0x0090C104
		public unsafe int MPCFadeGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x060229F3 RID: 141811 RVA: 0x0090DF15 File Offset: 0x0090C115
		// (set) Token: 0x060229F4 RID: 141812 RVA: 0x0090DF29 File Offset: 0x0090C129
		public unsafe FName FadeGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_33);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_33) = value;
			}
		}

		// Token: 0x17003CC4 RID: 15556
		// (get) Token: 0x060229F5 RID: 141813 RVA: 0x0090DF3E File Offset: 0x0090C13E
		// (set) Token: 0x060229F6 RID: 141814 RVA: 0x0090DF4E File Offset: 0x0090C14E
		public unsafe bool bForceShow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GroupFadeWithVolume_C.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x060229F7 RID: 141815 RVA: 0x0090DF60 File Offset: 0x0090C160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateShadowDecal(float A)
		{
			BP_GroupFadeWithVolume_C.__UpdateShadowDecal_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__UpdateShadowDecal_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__UpdateShadowDecal_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__UpdateShadowDecal_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UpdateShadowDecal_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060229F8 RID: 141816 RVA: 0x0090DFA6 File Offset: 0x0090C1A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheShadowDecal()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheShadowDecal_NativeFunctionPtr, null);
		}

		// Token: 0x060229F9 RID: 141817 RVA: 0x0090DFBC File Offset: 0x0090C1BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateLightDecal(float A)
		{
			BP_GroupFadeWithVolume_C.__UpdateLightDecal_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__UpdateLightDecal_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__UpdateLightDecal_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__UpdateLightDecal_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UpdateLightDecal_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060229FA RID: 141818 RVA: 0x0090E002 File Offset: 0x0090C202
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheLightDecal()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheLightDecal_NativeFunctionPtr, null);
		}

		// Token: 0x060229FB RID: 141819 RVA: 0x0090E018 File Offset: 0x0090C218
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateFlickLight(float A)
		{
			BP_GroupFadeWithVolume_C.__UpdateFlickLight_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__UpdateFlickLight_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__UpdateFlickLight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__UpdateFlickLight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UpdateFlickLight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060229FC RID: 141820 RVA: 0x0090E05E File Offset: 0x0090C25E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheFlickLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheFlickLight_NativeFunctionPtr, null);
		}

		// Token: 0x060229FD RID: 141821 RVA: 0x0090E072 File Offset: 0x0090C272
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void MarkLightExcludeFromTOD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__MarkLightExcludeFromTOD_NativeFunctionPtr, null);
		}

		// Token: 0x060229FE RID: 141822 RVA: 0x0090E088 File Offset: 0x0090C288
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual float ComputeWeight()
		{
			BP_GroupFadeWithVolume_C.__ComputeWeight_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__ComputeWeight_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__ComputeWeight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__ComputeWeight_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__ComputeWeight_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060229FF RID: 141823 RVA: 0x0090E0D0 File Offset: 0x0090C2D0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CheckObjectPlatform(UObject Object, ref bool valid)
		{
			BP_GroupFadeWithVolume_C.__CheckObjectPlatform_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__CheckObjectPlatform_FunctionParams[(UIntPtr)183] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__CheckObjectPlatform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__CheckObjectPlatform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			ptr->valid = valid;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CheckObjectPlatform_NativeFunctionPtr, (void*)ptr);
			valid = ptr->valid;
		}

		// Token: 0x06022A00 RID: 141824 RVA: 0x0090E138 File Offset: 0x0090C338
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CheckPlatform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CheckPlatform_NativeFunctionPtr, null);
		}

		// Token: 0x06022A01 RID: 141825 RVA: 0x0090E14C File Offset: 0x0090C34C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateSuperFarFog(float A)
		{
			BP_GroupFadeWithVolume_C.__UpdateSuperFarFog_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__UpdateSuperFarFog_FunctionParams[(UIntPtr)151] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__UpdateSuperFarFog_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__UpdateSuperFarFog_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UpdateSuperFarFog_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A02 RID: 141826 RVA: 0x0090E195 File Offset: 0x0090C395
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheSuperFarFog()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheSuperFarFog_NativeFunctionPtr, null);
		}

		// Token: 0x06022A03 RID: 141827 RVA: 0x0090E1AC File Offset: 0x0090C3AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCustomCloud(float B)
		{
			BP_GroupFadeWithVolume_C.__UpdateCustomCloud_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__UpdateCustomCloud_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__UpdateCustomCloud_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__UpdateCustomCloud_NativeFunctionPtr, (void*)ptr, 1);
			ptr->B = B;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UpdateCustomCloud_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A04 RID: 141828 RVA: 0x0090E1F2 File Offset: 0x0090C3F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheCustomCloud()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheCustomCloud_NativeFunctionPtr, null);
		}

		// Token: 0x06022A05 RID: 141829 RVA: 0x0090E208 File Offset: 0x0090C408
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateCloud(float B)
		{
			BP_GroupFadeWithVolume_C.__UpdateCloud_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__UpdateCloud_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__UpdateCloud_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__UpdateCloud_NativeFunctionPtr, (void*)ptr, 1);
			ptr->B = B;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UpdateCloud_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A06 RID: 141830 RVA: 0x0090E24E File Offset: 0x0090C44E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheCloud()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheCloud_NativeFunctionPtr, null);
		}

		// Token: 0x06022A07 RID: 141831 RVA: 0x0090E264 File Offset: 0x0090C464
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateVolumeLightSphereFar(float A)
		{
			BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphereFar_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphereFar_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphereFar_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphereFar_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphereFar_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A08 RID: 141832 RVA: 0x0090E2AA File Offset: 0x0090C4AA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheVolumeLightSphereFar()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheVolumeLightSphereFar_NativeFunctionPtr, null);
		}

		// Token: 0x06022A09 RID: 141833 RVA: 0x0090E2C0 File Offset: 0x0090C4C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateVolumeLightSphere(float B)
		{
			BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphere_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphere_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphere_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphere_NativeFunctionPtr, (void*)ptr, 1);
			ptr->B = B;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UpdateVolumeLightSphere_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A0A RID: 141834 RVA: 0x0090E306 File Offset: 0x0090C506
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheVolumeLightSphere()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheVolumeLightSphere_NativeFunctionPtr, null);
		}

		// Token: 0x06022A0B RID: 141835 RVA: 0x0090E31C File Offset: 0x0090C51C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void UpdateLight(float A)
		{
			BP_GroupFadeWithVolume_C.__UpdateLight_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__UpdateLight_FunctionParams[(UIntPtr)295] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__UpdateLight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__UpdateLight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UpdateLight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A0C RID: 141836 RVA: 0x0090E365 File Offset: 0x0090C565
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheLightInstensity()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheLightInstensity_NativeFunctionPtr, null);
		}

		// Token: 0x06022A0D RID: 141837 RVA: 0x0090E379 File Offset: 0x0090C579
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ClearInvalid()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__ClearInvalid_NativeFunctionPtr, null);
		}

		// Token: 0x06022A0E RID: 141838 RVA: 0x0090E38D File Offset: 0x0090C58D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022A0F RID: 141839 RVA: 0x0090E3A1 File Offset: 0x0090C5A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A10 RID: 141840 RVA: 0x0090E3B6 File Offset: 0x0090C5B6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022A11 RID: 141841 RVA: 0x0090E3CA File Offset: 0x0090C5CA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A12 RID: 141842 RVA: 0x0090E3E0 File Offset: 0x0090C5E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_GroupFadeWithVolume_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022A13 RID: 141843 RVA: 0x0090E428 File Offset: 0x0090C628
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_GroupFadeWithVolume_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_GroupFadeWithVolume_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_GroupFadeWithVolume_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_GroupFadeWithVolume_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022A14 RID: 141844 RVA: 0x0090E46F File Offset: 0x0090C66F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CacheIntensity()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__CacheIntensity_NativeFunctionPtr, null);
		}

		// Token: 0x06022A15 RID: 141845 RVA: 0x0090E483 File Offset: 0x0090C683
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForMobile()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__BeforeCookForMobile_NativeFunctionPtr, null);
		}

		// Token: 0x06022A16 RID: 141846 RVA: 0x0090E497 File Offset: 0x0090C697
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForMobile_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__BeforeCookForMobile_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A17 RID: 141847 RVA: 0x0090E4AC File Offset: 0x0090C6AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BeforeCookForPC()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__BeforeCookForPC_NativeFunctionPtr, null);
		}

		// Token: 0x06022A18 RID: 141848 RVA: 0x0090E4C0 File Offset: 0x0090C6C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void BeforeCookForPC_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_GroupFadeWithVolume_C.__BeforeCookForPC_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022A19 RID: 141849 RVA: 0x0090E4D5 File Offset: 0x0090C6D5
		protected BP_GroupFadeWithVolume_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FFC RID: 69628
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/VolumeGroupFade/BP_GroupFadeWithVolume.BP_GroupFadeWithVolume_C";

		// Token: 0x04010FFD RID: 69629
		private static IntPtr _ClassPtr;

		// Token: 0x04010FFE RID: 69630
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FFF RID: 69631
		internal static int __PropertyOffset_1;

		// Token: 0x04011000 RID: 69632
		internal static int __PropertyOffset_2;

		// Token: 0x04011001 RID: 69633
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<ALight> _LightList;

		// Token: 0x04011002 RID: 69634
		internal static int __PropertyOffset_3;

		// Token: 0x04011003 RID: 69635
		[Nullable(2)]
		private TArray<float> _CachedLightIntensity;

		// Token: 0x04011004 RID: 69636
		internal static int __PropertyOffset_4;

		// Token: 0x04011005 RID: 69637
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_VolumetricSphereLight_C> _VolumeLightSphereList;

		// Token: 0x04011006 RID: 69638
		internal static int __PropertyOffset_5;

		// Token: 0x04011007 RID: 69639
		[Nullable(2)]
		private TArray<float> _CachedVolumeLightSphere;

		// Token: 0x04011008 RID: 69640
		internal static int __PropertyOffset_6;

		// Token: 0x04011009 RID: 69641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_KuroLightDecal_C> _DecalLightList;

		// Token: 0x0401100A RID: 69642
		internal static int __PropertyOffset_7;

		// Token: 0x0401100B RID: 69643
		[Nullable(2)]
		private TArray<float> _CachedDecalLight;

		// Token: 0x0401100C RID: 69644
		internal static int __PropertyOffset_8;

		// Token: 0x0401100D RID: 69645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_VolumetricSphereLightSuperFar_C> _VolumeLightSphereSuperFarList;

		// Token: 0x0401100E RID: 69646
		internal static int __PropertyOffset_9;

		// Token: 0x0401100F RID: 69647
		[Nullable(2)]
		private TArray<float> _CachedVolumeLightSphereSuperFar;

		// Token: 0x04011010 RID: 69648
		internal static int __PropertyOffset_10;

		// Token: 0x04011011 RID: 69649
		internal static int __PropertyOffset_11;

		// Token: 0x04011012 RID: 69650
		internal static int __PropertyOffset_12;

		// Token: 0x04011013 RID: 69651
		internal static int __PropertyOffset_13;

		// Token: 0x04011014 RID: 69652
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_SingleCloud_C> _CloudList;

		// Token: 0x04011015 RID: 69653
		internal static int __PropertyOffset_14;

		// Token: 0x04011016 RID: 69654
		[Nullable(2)]
		private TArray<float> _CachedCloudIntensity;

		// Token: 0x04011017 RID: 69655
		internal static int __PropertyOffset_15;

		// Token: 0x04011018 RID: 69656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_SingleCloud_Custom_C> _CustomCloudList;

		// Token: 0x04011019 RID: 69657
		internal static int __PropertyOffset_16;

		// Token: 0x0401101A RID: 69658
		[Nullable(2)]
		private TArray<float> _CachedCustomCloudIntensity;

		// Token: 0x0401101B RID: 69659
		internal static int __PropertyOffset_17;

		// Token: 0x0401101C RID: 69660
		internal static int __PropertyOffset_18;

		// Token: 0x0401101D RID: 69661
		internal static int __PropertyOffset_19;

		// Token: 0x0401101E RID: 69662
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AKuroPostProcessVolume> _FadeOutVolumes;

		// Token: 0x0401101F RID: 69663
		internal static int __PropertyOffset_20;

		// Token: 0x04011020 RID: 69664
		internal static int __PropertyOffset_21;

		// Token: 0x04011021 RID: 69665
		internal static int __PropertyOffset_22;

		// Token: 0x04011022 RID: 69666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_SuperFarFog_C> _SuperfarFogList;

		// Token: 0x04011023 RID: 69667
		internal static int __PropertyOffset_23;

		// Token: 0x04011024 RID: 69668
		[Nullable(2)]
		private TArray<float> _CachedSuperFarFogOpacity;

		// Token: 0x04011025 RID: 69669
		internal static int __PropertyOffset_24;

		// Token: 0x04011026 RID: 69670
		[Nullable(2)]
		private TArray<float> _CachedSuperFarFogOpacity_Night;

		// Token: 0x04011027 RID: 69671
		internal static int __PropertyOffset_25;

		// Token: 0x04011028 RID: 69672
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_KuroFlickLight_C> _FlickLightList;

		// Token: 0x04011029 RID: 69673
		internal static int __PropertyOffset_26;

		// Token: 0x0401102A RID: 69674
		[Nullable(2)]
		private TArray<float> _CachedFlickLightIntensity;

		// Token: 0x0401102B RID: 69675
		internal static int __PropertyOffset_27;

		// Token: 0x0401102C RID: 69676
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_KuroLightDecal_C> _LightDecalList;

		// Token: 0x0401102D RID: 69677
		internal static int __PropertyOffset_28;

		// Token: 0x0401102E RID: 69678
		[Nullable(2)]
		private TArray<float> _CachedLightDecalIntensity;

		// Token: 0x0401102F RID: 69679
		internal static int __PropertyOffset_29;

		// Token: 0x04011030 RID: 69680
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<BP_ShadowDecal_C> _ShadowDecalList;

		// Token: 0x04011031 RID: 69681
		internal static int __PropertyOffset_30;

		// Token: 0x04011032 RID: 69682
		[Nullable(2)]
		private TArray<float> _CachedShadowDecalIntensity;

		// Token: 0x04011033 RID: 69683
		internal static int __PropertyOffset_31;

		// Token: 0x04011034 RID: 69684
		internal static int __PropertyOffset_32;

		// Token: 0x04011035 RID: 69685
		internal static int __PropertyOffset_33;

		// Token: 0x04011036 RID: 69686
		internal static int __PropertyOffset_34;

		// Token: 0x04011037 RID: 69687
		private static IntPtr __UpdateShadowDecal_NativeFunctionPtr;

		// Token: 0x04011038 RID: 69688
		private static IntPtr __CacheShadowDecal_NativeFunctionPtr;

		// Token: 0x04011039 RID: 69689
		private static IntPtr __UpdateLightDecal_NativeFunctionPtr;

		// Token: 0x0401103A RID: 69690
		private static IntPtr __CacheLightDecal_NativeFunctionPtr;

		// Token: 0x0401103B RID: 69691
		private static IntPtr __UpdateFlickLight_NativeFunctionPtr;

		// Token: 0x0401103C RID: 69692
		private static IntPtr __CacheFlickLight_NativeFunctionPtr;

		// Token: 0x0401103D RID: 69693
		private static IntPtr __MarkLightExcludeFromTOD_NativeFunctionPtr;

		// Token: 0x0401103E RID: 69694
		private static IntPtr __ComputeWeight_NativeFunctionPtr;

		// Token: 0x0401103F RID: 69695
		private static IntPtr __CheckObjectPlatform_NativeFunctionPtr;

		// Token: 0x04011040 RID: 69696
		private static IntPtr __CheckPlatform_NativeFunctionPtr;

		// Token: 0x04011041 RID: 69697
		private static IntPtr __UpdateSuperFarFog_NativeFunctionPtr;

		// Token: 0x04011042 RID: 69698
		private static IntPtr __CacheSuperFarFog_NativeFunctionPtr;

		// Token: 0x04011043 RID: 69699
		private static IntPtr __UpdateCustomCloud_NativeFunctionPtr;

		// Token: 0x04011044 RID: 69700
		private static IntPtr __CacheCustomCloud_NativeFunctionPtr;

		// Token: 0x04011045 RID: 69701
		private static IntPtr __UpdateCloud_NativeFunctionPtr;

		// Token: 0x04011046 RID: 69702
		private static IntPtr __CacheCloud_NativeFunctionPtr;

		// Token: 0x04011047 RID: 69703
		private static IntPtr __UpdateVolumeLightSphereFar_NativeFunctionPtr;

		// Token: 0x04011048 RID: 69704
		private static IntPtr __CacheVolumeLightSphereFar_NativeFunctionPtr;

		// Token: 0x04011049 RID: 69705
		private static IntPtr __UpdateVolumeLightSphere_NativeFunctionPtr;

		// Token: 0x0401104A RID: 69706
		private static IntPtr __CacheVolumeLightSphere_NativeFunctionPtr;

		// Token: 0x0401104B RID: 69707
		private static IntPtr __UpdateLight_NativeFunctionPtr;

		// Token: 0x0401104C RID: 69708
		private static IntPtr __CacheLightInstensity_NativeFunctionPtr;

		// Token: 0x0401104D RID: 69709
		private static IntPtr __ClearInvalid_NativeFunctionPtr;

		// Token: 0x0401104E RID: 69710
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401104F RID: 69711
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011050 RID: 69712
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011051 RID: 69713
		private static IntPtr __CacheIntensity_NativeFunctionPtr;

		// Token: 0x04011052 RID: 69714
		private static IntPtr __BeforeCookForMobile_NativeFunctionPtr;

		// Token: 0x04011053 RID: 69715
		private static IntPtr __BeforeCookForPC_NativeFunctionPtr;

		// Token: 0x02009DA2 RID: 40354
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __UpdateShadowDecal_FunctionParams
		{
			// Token: 0x04031583 RID: 202115
			[FieldOffset(0)]
			public float A;
		}

		// Token: 0x02009DA3 RID: 40355
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __UpdateLightDecal_FunctionParams
		{
			// Token: 0x04031584 RID: 202116
			[FieldOffset(0)]
			public float A;
		}

		// Token: 0x02009DA4 RID: 40356
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateFlickLight_FunctionParams
		{
			// Token: 0x04031585 RID: 202117
			[FieldOffset(0)]
			public float A;
		}

		// Token: 0x02009DA5 RID: 40357
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __ComputeWeight_FunctionParams
		{
			// Token: 0x04031586 RID: 202118
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02009DA6 RID: 40358
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 168)]
		protected ref struct __CheckObjectPlatform_FunctionParams
		{
			// Token: 0x04031587 RID: 202119
			[FieldOffset(0)]
			public IntPtr Object;

			// Token: 0x04031588 RID: 202120
			[FieldOffset(8)]
			public bool valid;
		}

		// Token: 0x02009DA7 RID: 40359
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 136)]
		protected ref struct __UpdateSuperFarFog_FunctionParams
		{
			// Token: 0x04031589 RID: 202121
			[FieldOffset(0)]
			public float A;
		}

		// Token: 0x02009DA8 RID: 40360
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateCustomCloud_FunctionParams
		{
			// Token: 0x0403158A RID: 202122
			[FieldOffset(0)]
			public float B;
		}

		// Token: 0x02009DA9 RID: 40361
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __UpdateCloud_FunctionParams
		{
			// Token: 0x0403158B RID: 202123
			[FieldOffset(0)]
			public float B;
		}

		// Token: 0x02009DAA RID: 40362
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateVolumeLightSphereFar_FunctionParams
		{
			// Token: 0x0403158C RID: 202124
			[FieldOffset(0)]
			public float A;
		}

		// Token: 0x02009DAB RID: 40363
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __UpdateVolumeLightSphere_FunctionParams
		{
			// Token: 0x0403158D RID: 202125
			[FieldOffset(0)]
			public float B;
		}

		// Token: 0x02009DAC RID: 40364
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 280)]
		protected ref struct __UpdateLight_FunctionParams
		{
			// Token: 0x0403158E RID: 202126
			[FieldOffset(0)]
			public float A;
		}

		// Token: 0x02009DAD RID: 40365
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403158F RID: 202127
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
