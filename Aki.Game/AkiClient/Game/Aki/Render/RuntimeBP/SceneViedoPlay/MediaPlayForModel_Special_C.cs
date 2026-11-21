using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.Interface;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.SceneViedoPlay
{
	// Token: 0x020030D5 RID: 12501
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Special.MediaPlayForModel_Special_C")]
	[UnrealStructLayout(1680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1680)]
	public class MediaPlayForModel_Special_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E205 RID: 123397 RVA: 0x0090BAB0 File Offset: 0x00909CB0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (MediaPlayForModel_Special_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Special.MediaPlayForModel_Special_C");
			}
			return MediaPlayForModel_Special_C._ClassPtr;
		}

		// Token: 0x0601E206 RID: 123398 RVA: 0x0090BAD4 File Offset: 0x00909CD4
		public MediaPlayForModel_Special_C() : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_Special_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E207 RID: 123399 RVA: 0x0090BAFC File Offset: 0x00909CFC
		[NullableContext(1)]
		public MediaPlayForModel_Special_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_Special_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0601E208 RID: 123400 RVA: 0x0090BB2F File Offset: 0x00909D2F
		// (set) Token: 0x0601E209 RID: 123401 RVA: 0x0090BB43 File Offset: 0x00909D43
		public unsafe USceneComponent VolumeLightSoucePos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_VolumeLightSoucePos);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_VolumeLightSoucePos, value);
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0601E20A RID: 123402 RVA: 0x0090BB58 File Offset: 0x00909D58
		// (set) Token: 0x0601E20B RID: 123403 RVA: 0x0090BB6C File Offset: 0x00909D6C
		public unsafe UStaticMeshComponent VolumeMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_VolumeMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_VolumeMesh, value);
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0601E20C RID: 123404 RVA: 0x0090BB81 File Offset: 0x00909D81
		// (set) Token: 0x0601E20D RID: 123405 RVA: 0x0090BB95 File Offset: 0x00909D95
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_Ak);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_Ak, value);
			}
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0601E20E RID: 123406 RVA: 0x0090BBAA File Offset: 0x00909DAA
		// (set) Token: 0x0601E20F RID: 123407 RVA: 0x0090BBBE File Offset: 0x00909DBE
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0601E210 RID: 123408 RVA: 0x0090BBD3 File Offset: 0x00909DD3
		// (set) Token: 0x0601E211 RID: 123409 RVA: 0x0090BBE7 File Offset: 0x00909DE7
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0601E212 RID: 123410 RVA: 0x0090BBFC File Offset: 0x00909DFC
		// (set) Token: 0x0601E213 RID: 123411 RVA: 0x0090BC10 File Offset: 0x00909E10
		public unsafe UMaterial ViedoMaterialTranSlucentTwoSide
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ViedoMaterialTranSlucentTwoSide);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ViedoMaterialTranSlucentTwoSide, value);
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0601E214 RID: 123412 RVA: 0x0090BC25 File Offset: 0x00909E25
		// (set) Token: 0x0601E215 RID: 123413 RVA: 0x0090BC39 File Offset: 0x00909E39
		public unsafe UMaterial ViedoMaterialTranSlucent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ViedoMaterialTranSlucent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ViedoMaterialTranSlucent, value);
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0601E216 RID: 123414 RVA: 0x0090BC4E File Offset: 0x00909E4E
		// (set) Token: 0x0601E217 RID: 123415 RVA: 0x0090BC62 File Offset: 0x00909E62
		public unsafe UMaterial ViedoMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ViedoMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ViedoMaterial, value);
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0601E218 RID: 123416 RVA: 0x0090BC77 File Offset: 0x00909E77
		// (set) Token: 0x0601E219 RID: 123417 RVA: 0x0090BC87 File Offset: 0x00909E87
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0601E21A RID: 123418 RVA: 0x0090BC98 File Offset: 0x00909E98
		// (set) Token: 0x0601E21B RID: 123419 RVA: 0x0090BCA8 File Offset: 0x00909EA8
		public unsafe float DarkIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_DarkIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_DarkIntensity) = value;
			}
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0601E21C RID: 123420 RVA: 0x0090BCB9 File Offset: 0x00909EB9
		// (set) Token: 0x0601E21D RID: 123421 RVA: 0x0090BCC9 File Offset: 0x00909EC9
		public unsafe int AoiDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_AoiDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_AoiDistance) = value;
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0601E21E RID: 123422 RVA: 0x0090BCDA File Offset: 0x00909EDA
		// (set) Token: 0x0601E21F RID: 123423 RVA: 0x0090BCEA File Offset: 0x00909EEA
		public unsafe bool Translucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_Translucent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_Translucent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0601E220 RID: 123424 RVA: 0x0090BCFB File Offset: 0x00909EFB
		// (set) Token: 0x0601E221 RID: 123425 RVA: 0x0090BD0B File Offset: 0x00909F0B
		public unsafe bool TwoSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_TwoSide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_TwoSide) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0601E222 RID: 123426 RVA: 0x0090BD1C File Offset: 0x00909F1C
		// (set) Token: 0x0601E223 RID: 123427 RVA: 0x0090BD2C File Offset: 0x00909F2C
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_Opacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_Opacity) = value;
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0601E224 RID: 123428 RVA: 0x0090BD3D File Offset: 0x00909F3D
		// (set) Token: 0x0601E225 RID: 123429 RVA: 0x0090BD51 File Offset: 0x00909F51
		public unsafe PDA_MediaPlayDataAsset_C MediaPlayDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_MediaPlayDataAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_MediaPlayDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_MediaPlayDataAsset, value);
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0601E226 RID: 123430 RVA: 0x0090BD66 File Offset: 0x00909F66
		// (set) Token: 0x0601E227 RID: 123431 RVA: 0x0090BD7A File Offset: 0x00909F7A
		public unsafe UMediaPlayer ShareMediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ShareMediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ShareMediaPlayer, value);
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0601E228 RID: 123432 RVA: 0x0090BD8F File Offset: 0x00909F8F
		// (set) Token: 0x0601E229 RID: 123433 RVA: 0x0090BDA3 File Offset: 0x00909FA3
		public unsafe UMediaTexture ShareMediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ShareMediaTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ShareMediaTexture, value);
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0601E22A RID: 123434 RVA: 0x0090BDB8 File Offset: 0x00909FB8
		// (set) Token: 0x0601E22B RID: 123435 RVA: 0x0090BDC8 File Offset: 0x00909FC8
		public unsafe bool IsMainPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_IsMainPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_IsMainPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0601E22C RID: 123436 RVA: 0x0090BDD9 File Offset: 0x00909FD9
		// (set) Token: 0x0601E22D RID: 123437 RVA: 0x0090BDE9 File Offset: 0x00909FE9
		public unsafe bool isPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_isPlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_isPlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0601E22E RID: 123438 RVA: 0x0090BDFA File Offset: 0x00909FFA
		// (set) Token: 0x0601E22F RID: 123439 RVA: 0x0090BE0A File Offset: 0x0090A00A
		public unsafe bool DrawDebugAoi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_DrawDebugAoi) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_DrawDebugAoi) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0601E230 RID: 123440 RVA: 0x0090BE1B File Offset: 0x0090A01B
		// (set) Token: 0x0601E231 RID: 123441 RVA: 0x0090BE2B File Offset: 0x0090A02B
		public unsafe bool isStopOnHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_isStopOnHide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_isStopOnHide) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0601E232 RID: 123442 RVA: 0x0090BE3C File Offset: 0x0090A03C
		// (set) Token: 0x0601E233 RID: 123443 RVA: 0x0090BE4C File Offset: 0x0090A04C
		public unsafe bool enableQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_enableQualityLevel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_enableQualityLevel) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0601E234 RID: 123444 RVA: 0x0090BE60 File Offset: 0x0090A060
		// (set) Token: 0x0601E235 RID: 123445 RVA: 0x0090BE99 File Offset: 0x0090A099
		[Nullable(1)]
		public TArray<int> QualityDistanceList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._QualityDistanceList) == null)
				{
					result = (this._QualityDistanceList = new TArray<int>(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_QualityDistanceList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QualityDistanceList.CopyAssign(value);
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0601E236 RID: 123446 RVA: 0x0090BEA7 File Offset: 0x0090A0A7
		// (set) Token: 0x0601E237 RID: 123447 RVA: 0x0090BEBB File Offset: 0x0090A0BB
		public unsafe UMaterialInstanceDynamic DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_DynamicMaterialInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_DynamicMaterialInstance, value);
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0601E238 RID: 123448 RVA: 0x0090BED0 File Offset: 0x0090A0D0
		// (set) Token: 0x0601E239 RID: 123449 RVA: 0x0090BEE0 File Offset: 0x0090A0E0
		public unsafe float MP4编辑器最大预览距离
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_MP4编辑器最大预览距离);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_MP4编辑器最大预览距离) = value;
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0601E23A RID: 123450 RVA: 0x0090BEF1 File Offset: 0x0090A0F1
		// (set) Token: 0x0601E23B RID: 123451 RVA: 0x0090BF01 File Offset: 0x0090A101
		public unsafe bool bPostProcess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_bPostProcess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_bPostProcess) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0601E23C RID: 123452 RVA: 0x0090BF12 File Offset: 0x0090A112
		// (set) Token: 0x0601E23D RID: 123453 RVA: 0x0090BF26 File Offset: 0x0090A126
		public unsafe UMaterialInstance VolumeLightMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_VolumeLightMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_VolumeLightMaterial, value);
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0601E23E RID: 123454 RVA: 0x0090BF3B File Offset: 0x0090A13B
		// (set) Token: 0x0601E23F RID: 123455 RVA: 0x0090BF4F File Offset: 0x0090A14F
		public unsafe UMaterialInstanceDynamic VolumeLightMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_VolumeLightMID);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_VolumeLightMID, value);
			}
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0601E240 RID: 123456 RVA: 0x0090BF64 File Offset: 0x0090A164
		// (set) Token: 0x0601E241 RID: 123457 RVA: 0x0090BF78 File Offset: 0x0090A178
		public unsafe UMaterialInstanceDynamic MediaTexPostProcessDMI
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_MediaTexPostProcessDMI);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_MediaTexPostProcessDMI, value);
			}
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0601E242 RID: 123458 RVA: 0x0090BF8D File Offset: 0x0090A18D
		// (set) Token: 0x0601E243 RID: 123459 RVA: 0x0090BFA1 File Offset: 0x0090A1A1
		public unsafe UMaterialInterface MediaTexPostProcessMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_MediaTexPostProcessMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_MediaTexPostProcessMaterial, value);
			}
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0601E244 RID: 123460 RVA: 0x0090BFB6 File Offset: 0x0090A1B6
		// (set) Token: 0x0601E245 RID: 123461 RVA: 0x0090BFC6 File Offset: 0x0090A1C6
		public unsafe int PostTexHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_PostTexHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_PostTexHeight) = value;
			}
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0601E246 RID: 123462 RVA: 0x0090BFD7 File Offset: 0x0090A1D7
		// (set) Token: 0x0601E247 RID: 123463 RVA: 0x0090BFE7 File Offset: 0x0090A1E7
		public unsafe int PostTexWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_PostTexWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_PostTexWidth) = value;
			}
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0601E248 RID: 123464 RVA: 0x0090BFF8 File Offset: 0x0090A1F8
		// (set) Token: 0x0601E249 RID: 123465 RVA: 0x0090C00C File Offset: 0x0090A20C
		public unsafe UTextureRenderTarget2D MediaTexPostProcessRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_MediaTexPostProcessRT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_MediaTexPostProcessRT, value);
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0601E24A RID: 123466 RVA: 0x0090C021 File Offset: 0x0090A221
		// (set) Token: 0x0601E24B RID: 123467 RVA: 0x0090C031 File Offset: 0x0090A231
		public unsafe bool bEnableVolumeLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_bEnableVolumeLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Special_C.__PropertyOffset_bEnableVolumeLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0601E24C RID: 123468 RVA: 0x0090C042 File Offset: 0x0090A242
		// (set) Token: 0x0601E24D RID: 123469 RVA: 0x0090C056 File Offset: 0x0090A256
		public unsafe UMediaPlayer ShareMediaPlayer_EditorPreview
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ShareMediaPlayer_EditorPreview);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ShareMediaPlayer_EditorPreview, value);
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0601E24E RID: 123470 RVA: 0x0090C06B File Offset: 0x0090A26B
		// (set) Token: 0x0601E24F RID: 123471 RVA: 0x0090C07F File Offset: 0x0090A27F
		public unsafe UMediaTexture ShareMediaTexture_EditorPreview
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ShareMediaTexture_EditorPreview);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Special_C.__PropertyOffset_ShareMediaTexture_EditorPreview, value);
			}
		}

		// Token: 0x0601E250 RID: 123472 RVA: 0x0090C094 File Offset: 0x0090A294
		[SkipLocalsInit]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			MediaPlayForModel_Special_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E251 RID: 123473 RVA: 0x0090C0E4 File Offset: 0x0090A2E4
		[SkipLocalsInit]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			MediaPlayForModel_Special_C.__GetAoiRange_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__GetAoiRange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E252 RID: 123474 RVA: 0x0090C133 File Offset: 0x0090A333
		[SkipLocalsInit]
		public virtual void DownSampleMediaTex()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__DownSampleMediaTex_NativeFunctionPtr, null);
		}

		// Token: 0x0601E253 RID: 123475 RVA: 0x0090C147 File Offset: 0x0090A347
		[SkipLocalsInit]
		public virtual void 编辑器强制停止()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器强制停止_NativeFunctionPtr, null);
		}

		// Token: 0x0601E254 RID: 123476 RVA: 0x0090C15B File Offset: 0x0090A35B
		[SkipLocalsInit]
		public virtual void 编辑器强制播放()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器强制播放_NativeFunctionPtr, null);
		}

		// Token: 0x0601E255 RID: 123477 RVA: 0x0090C16F File Offset: 0x0090A36F
		[SkipLocalsInit]
		public virtual void 编辑器_MP4播放器初始化()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器_MP4播放器初始化_NativeFunctionPtr, null);
		}

		// Token: 0x0601E256 RID: 123478 RVA: 0x0090C183 File Offset: 0x0090A383
		[SkipLocalsInit]
		public virtual void 编辑器MP4播放器停止预览()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器MP4播放器停止预览_NativeFunctionPtr, null);
		}

		// Token: 0x0601E257 RID: 123479 RVA: 0x0090C197 File Offset: 0x0090A397
		[SkipLocalsInit]
		public virtual void 编辑器MP4播放器开始预览()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__编辑器MP4播放器开始预览_NativeFunctionPtr, null);
		}

		// Token: 0x0601E258 RID: 123480 RVA: 0x0090C1AC File Offset: 0x0090A3AC
		[SkipLocalsInit]
		public unsafe virtual void GetSource(ref UMediaSource MediaSource)
		{
			MediaPlayForModel_Special_C.__GetSource_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__GetSource_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__GetSource_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__GetSource_NativeFunctionPtr, (void*)ptr, 1);
			ref MediaPlayForModel_Special_C.__GetSource_FunctionParams ptr2 = ref *ptr;
			UMediaSource umediaSource = MediaSource;
			ptr2.MediaSource = ((umediaSource != null) ? umediaSource.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__GetSource_NativeFunctionPtr, (void*)ptr);
			MediaSource = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaSource>(ptr->MediaSource);
		}

		// Token: 0x0601E259 RID: 123481 RVA: 0x0090C210 File Offset: 0x0090A410
		[SkipLocalsInit]
		public virtual void Init()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Init_NativeFunctionPtr, null);
		}

		// Token: 0x0601E25A RID: 123482 RVA: 0x0090C224 File Offset: 0x0090A424
		[SkipLocalsInit]
		public virtual void HideVolumeLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__HideVolumeLight_NativeFunctionPtr, null);
		}

		// Token: 0x0601E25B RID: 123483 RVA: 0x0090C238 File Offset: 0x0090A438
		[SkipLocalsInit]
		public virtual void ShowVolumeLight()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ShowVolumeLight_NativeFunctionPtr, null);
		}

		// Token: 0x0601E25C RID: 123484 RVA: 0x0090C24C File Offset: 0x0090A44C
		[SkipLocalsInit]
		public virtual void Release_Player_Asset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Release_Player_Asset_NativeFunctionPtr, null);
		}

		// Token: 0x0601E25D RID: 123485 RVA: 0x0090C260 File Offset: 0x0090A460
		[SkipLocalsInit]
		public unsafe virtual void AllocatePlayerAsset(UMediaPlayer player, UMediaTexture texture)
		{
			MediaPlayForModel_Special_C.__AllocatePlayerAsset_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__AllocatePlayerAsset_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__AllocatePlayerAsset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__AllocatePlayerAsset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->player = ((player != null) ? player.NativePtr : IntPtr.Zero);
			ptr->texture = ((texture != null) ? texture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__AllocatePlayerAsset_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E25E RID: 123486 RVA: 0x0090C2CC File Offset: 0x0090A4CC
		[SkipLocalsInit]
		public unsafe virtual void OpenSource(ref bool Successs)
		{
			MediaPlayForModel_Special_C.__OpenSource_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__OpenSource_FunctionParams[(UIntPtr)127] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__OpenSource_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__OpenSource_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Successs = Successs;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OpenSource_NativeFunctionPtr, (void*)ptr);
			Successs = ptr->Successs;
		}

		// Token: 0x0601E25F RID: 123487 RVA: 0x0090C31B File Offset: 0x0090A51B
		[SkipLocalsInit]
		public virtual void CloseSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__CloseSource_NativeFunctionPtr, null);
		}

		// Token: 0x0601E260 RID: 123488 RVA: 0x0090C32F File Offset: 0x0090A52F
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E261 RID: 123489 RVA: 0x0090C343 File Offset: 0x0090A543
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E262 RID: 123490 RVA: 0x0090C357 File Offset: 0x0090A557
		[SkipLocalsInit]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x0601E263 RID: 123491 RVA: 0x0090C36B File Offset: 0x0090A56B
		[SkipLocalsInit]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x0601E264 RID: 123492 RVA: 0x0090C37F File Offset: 0x0090A57F
		[SkipLocalsInit]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x0601E265 RID: 123493 RVA: 0x0090C393 File Offset: 0x0090A593
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E266 RID: 123494 RVA: 0x0090C3A7 File Offset: 0x0090A5A7
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E267 RID: 123495 RVA: 0x0090C3BC File Offset: 0x0090A5BC
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			MediaPlayForModel_Special_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E268 RID: 123496 RVA: 0x0090C404 File Offset: 0x0090A604
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			MediaPlayForModel_Special_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E269 RID: 123497 RVA: 0x0090C44A File Offset: 0x0090A64A
		[SkipLocalsInit]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601E26A RID: 123498 RVA: 0x0090C45E File Offset: 0x0090A65E
		[SkipLocalsInit]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x0601E26B RID: 123499 RVA: 0x0090C474 File Offset: 0x0090A674
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E26C RID: 123500 RVA: 0x0090C4C0 File Offset: 0x0090A6C0
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E26D RID: 123501 RVA: 0x0090C50B File Offset: 0x0090A70B
		[SkipLocalsInit]
		public virtual void PlaySound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__PlaySound_NativeFunctionPtr, null);
		}

		// Token: 0x0601E26E RID: 123502 RVA: 0x0090C51F File Offset: 0x0090A71F
		[SkipLocalsInit]
		public virtual void CloseSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__CloseSound_NativeFunctionPtr, null);
		}

		// Token: 0x0601E26F RID: 123503 RVA: 0x0090C534 File Offset: 0x0090A734
		[SkipLocalsInit]
		public unsafe virtual void OnMp4PlayRequested(UMediaPlayer InPlayer, UMediaTexture InTexture)
		{
			MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPlayer = ((InPlayer != null) ? InPlayer.NativePtr : IntPtr.Zero);
			ptr->InTexture = ((InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E270 RID: 123504 RVA: 0x0090C5A0 File Offset: 0x0090A7A0
		[SkipLocalsInit]
		protected unsafe virtual void OnMp4PlayRequested_Implementation(UMediaPlayer InPlayer, UMediaTexture InTexture)
		{
			MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__OnMp4PlayRequested_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPlayer = ((InPlayer != null) ? InPlayer.NativePtr : IntPtr.Zero);
			ptr->InTexture = ((InTexture != null) ? InTexture.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMp4PlayRequested_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E271 RID: 123505 RVA: 0x0090C60B File Offset: 0x0090A80B
		[SkipLocalsInit]
		public virtual void OnMp4StopRequested()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMp4StopRequested_NativeFunctionPtr, null);
		}

		// Token: 0x0601E272 RID: 123506 RVA: 0x0090C61F File Offset: 0x0090A81F
		[SkipLocalsInit]
		protected virtual void OnMp4StopRequested_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMp4StopRequested_NativeFunctionPtr, null);
		}

		// Token: 0x0601E273 RID: 123507 RVA: 0x0090C633 File Offset: 0x0090A833
		[SkipLocalsInit]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601E274 RID: 123508 RVA: 0x0090C647 File Offset: 0x0090A847
		[SkipLocalsInit]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601E275 RID: 123509 RVA: 0x0090C65C File Offset: 0x0090A85C
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E276 RID: 123510 RVA: 0x0090C6A4 File Offset: 0x0090A8A4
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Special_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Special_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Special_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E277 RID: 123511 RVA: 0x0090C6EA File Offset: 0x0090A8EA
		[SkipLocalsInit]
		public virtual void OnMediaAsyncClosed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__OnMediaAsyncClosed_NativeFunctionPtr, null);
		}

		// Token: 0x0601E278 RID: 123512 RVA: 0x0090C6FE File Offset: 0x0090A8FE
		[SkipLocalsInit]
		public virtual void CustomEvent_0()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Special_C.__CustomEvent_0_NativeFunctionPtr, null);
		}

		// Token: 0x0601E279 RID: 123513 RVA: 0x0090C712 File Offset: 0x0090A912
		protected MediaPlayForModel_Special_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEE9 RID: 65257
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Special.MediaPlayForModel_Special_C";

		// Token: 0x0400FEEA RID: 65258
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEEB RID: 65259
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEEC RID: 65260
		internal static int __PropertyOffset_VolumeLightSoucePos;

		// Token: 0x0400FEED RID: 65261
		internal static int __PropertyOffset_VolumeMesh;

		// Token: 0x0400FEEE RID: 65262
		internal static int __PropertyOffset_Ak;

		// Token: 0x0400FEEF RID: 65263
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400FEF0 RID: 65264
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FEF1 RID: 65265
		internal static int __PropertyOffset_ViedoMaterialTranSlucentTwoSide;

		// Token: 0x0400FEF2 RID: 65266
		internal static int __PropertyOffset_ViedoMaterialTranSlucent;

		// Token: 0x0400FEF3 RID: 65267
		internal static int __PropertyOffset_ViedoMaterial;

		// Token: 0x0400FEF4 RID: 65268
		internal static int __PropertyOffset_Intensity;

		// Token: 0x0400FEF5 RID: 65269
		internal static int __PropertyOffset_DarkIntensity;

		// Token: 0x0400FEF6 RID: 65270
		internal static int __PropertyOffset_AoiDistance;

		// Token: 0x0400FEF7 RID: 65271
		internal static int __PropertyOffset_Translucent;

		// Token: 0x0400FEF8 RID: 65272
		internal static int __PropertyOffset_TwoSide;

		// Token: 0x0400FEF9 RID: 65273
		internal static int __PropertyOffset_Opacity;

		// Token: 0x0400FEFA RID: 65274
		internal static int __PropertyOffset_MediaPlayDataAsset;

		// Token: 0x0400FEFB RID: 65275
		internal static int __PropertyOffset_ShareMediaPlayer;

		// Token: 0x0400FEFC RID: 65276
		internal static int __PropertyOffset_ShareMediaTexture;

		// Token: 0x0400FEFD RID: 65277
		internal static int __PropertyOffset_IsMainPlayer;

		// Token: 0x0400FEFE RID: 65278
		internal static int __PropertyOffset_isPlaying;

		// Token: 0x0400FEFF RID: 65279
		internal static int __PropertyOffset_DrawDebugAoi;

		// Token: 0x0400FF00 RID: 65280
		internal static int __PropertyOffset_isStopOnHide;

		// Token: 0x0400FF01 RID: 65281
		internal static int __PropertyOffset_enableQualityLevel;

		// Token: 0x0400FF02 RID: 65282
		internal static int __PropertyOffset_QualityDistanceList;

		// Token: 0x0400FF03 RID: 65283
		private TArray<int> _QualityDistanceList;

		// Token: 0x0400FF04 RID: 65284
		internal static int __PropertyOffset_DynamicMaterialInstance;

		// Token: 0x0400FF05 RID: 65285
		internal static int __PropertyOffset_MP4编辑器最大预览距离;

		// Token: 0x0400FF06 RID: 65286
		internal static int __PropertyOffset_bPostProcess;

		// Token: 0x0400FF07 RID: 65287
		internal static int __PropertyOffset_VolumeLightMaterial;

		// Token: 0x0400FF08 RID: 65288
		internal static int __PropertyOffset_VolumeLightMID;

		// Token: 0x0400FF09 RID: 65289
		internal static int __PropertyOffset_MediaTexPostProcessDMI;

		// Token: 0x0400FF0A RID: 65290
		internal static int __PropertyOffset_MediaTexPostProcessMaterial;

		// Token: 0x0400FF0B RID: 65291
		internal static int __PropertyOffset_PostTexHeight;

		// Token: 0x0400FF0C RID: 65292
		internal static int __PropertyOffset_PostTexWidth;

		// Token: 0x0400FF0D RID: 65293
		internal static int __PropertyOffset_MediaTexPostProcessRT;

		// Token: 0x0400FF0E RID: 65294
		internal static int __PropertyOffset_bEnableVolumeLight;

		// Token: 0x0400FF0F RID: 65295
		internal static int __PropertyOffset_ShareMediaPlayer_EditorPreview;

		// Token: 0x0400FF10 RID: 65296
		internal static int __PropertyOffset_ShareMediaTexture_EditorPreview;

		// Token: 0x0400FF11 RID: 65297
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x0400FF12 RID: 65298
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x0400FF13 RID: 65299
		private static IntPtr __DownSampleMediaTex_NativeFunctionPtr;

		// Token: 0x0400FF14 RID: 65300
		private static IntPtr __编辑器强制停止_NativeFunctionPtr;

		// Token: 0x0400FF15 RID: 65301
		private static IntPtr __编辑器强制播放_NativeFunctionPtr;

		// Token: 0x0400FF16 RID: 65302
		private static IntPtr __编辑器_MP4播放器初始化_NativeFunctionPtr;

		// Token: 0x0400FF17 RID: 65303
		private static IntPtr __编辑器MP4播放器停止预览_NativeFunctionPtr;

		// Token: 0x0400FF18 RID: 65304
		private static IntPtr __编辑器MP4播放器开始预览_NativeFunctionPtr;

		// Token: 0x0400FF19 RID: 65305
		private static IntPtr __GetSource_NativeFunctionPtr;

		// Token: 0x0400FF1A RID: 65306
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x0400FF1B RID: 65307
		private static IntPtr __HideVolumeLight_NativeFunctionPtr;

		// Token: 0x0400FF1C RID: 65308
		private static IntPtr __ShowVolumeLight_NativeFunctionPtr;

		// Token: 0x0400FF1D RID: 65309
		private static IntPtr __Release_Player_Asset_NativeFunctionPtr;

		// Token: 0x0400FF1E RID: 65310
		private static IntPtr __AllocatePlayerAsset_NativeFunctionPtr;

		// Token: 0x0400FF1F RID: 65311
		private static IntPtr __OpenSource_NativeFunctionPtr;

		// Token: 0x0400FF20 RID: 65312
		private static IntPtr __CloseSource_NativeFunctionPtr;

		// Token: 0x0400FF21 RID: 65313
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FF22 RID: 65314
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x0400FF23 RID: 65315
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x0400FF24 RID: 65316
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x0400FF25 RID: 65317
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FF26 RID: 65318
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FF27 RID: 65319
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400FF28 RID: 65320
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x0400FF29 RID: 65321
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0400FF2A RID: 65322
		private static IntPtr __PlaySound_NativeFunctionPtr;

		// Token: 0x0400FF2B RID: 65323
		private static IntPtr __CloseSound_NativeFunctionPtr;

		// Token: 0x0400FF2C RID: 65324
		private static IntPtr __OnMp4PlayRequested_NativeFunctionPtr;

		// Token: 0x0400FF2D RID: 65325
		private static IntPtr __OnMp4StopRequested_NativeFunctionPtr;

		// Token: 0x0400FF2E RID: 65326
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x0400FF2F RID: 65327
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FF30 RID: 65328
		private static IntPtr __OnMediaAsyncClosed_NativeFunctionPtr;

		// Token: 0x0400FF31 RID: 65329
		private static IntPtr __CustomEvent_0_NativeFunctionPtr;

		// Token: 0x02008E25 RID: 36389
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0402CA64 RID: 182884
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02008E26 RID: 36390
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0402CA65 RID: 182885
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02008E27 RID: 36391
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSource_FunctionParams
		{
			// Token: 0x0402CA66 RID: 182886
			[FieldOffset(0)]
			public IntPtr MediaSource;
		}

		// Token: 0x02008E28 RID: 36392
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AllocatePlayerAsset_FunctionParams
		{
			// Token: 0x0402CA67 RID: 182887
			[FieldOffset(0)]
			public IntPtr player;

			// Token: 0x0402CA68 RID: 182888
			[FieldOffset(8)]
			public IntPtr texture;
		}

		// Token: 0x02008E29 RID: 36393
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __OpenSource_FunctionParams
		{
			// Token: 0x0402CA69 RID: 182889
			[FieldOffset(0)]
			public bool Successs;
		}

		// Token: 0x02008E2A RID: 36394
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CA6A RID: 182890
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E2B RID: 36395
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CA6B RID: 182891
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02008E2C RID: 36396
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnMp4PlayRequested_FunctionParams
		{
			// Token: 0x0402CA6C RID: 182892
			[FieldOffset(0)]
			public IntPtr InPlayer;

			// Token: 0x0402CA6D RID: 182893
			[FieldOffset(8)]
			public IntPtr InTexture;
		}

		// Token: 0x02008E2D RID: 36397
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA6E RID: 182894
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
