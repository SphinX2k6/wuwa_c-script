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
	// Token: 0x020030D3 RID: 12499
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel.MediaPlayForModel_C")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class MediaPlayForModel_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E185 RID: 123269 RVA: 0x0090ADD7 File Offset: 0x00908FD7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (MediaPlayForModel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel.MediaPlayForModel_C");
			}
			return MediaPlayForModel_C._ClassPtr;
		}

		// Token: 0x0601E186 RID: 123270 RVA: 0x0090ADFC File Offset: 0x00908FFC
		public MediaPlayForModel_C() : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E187 RID: 123271 RVA: 0x0090AE24 File Offset: 0x00909024
		[NullableContext(1)]
		public MediaPlayForModel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x0601E188 RID: 123272 RVA: 0x0090AE57 File Offset: 0x00909057
		// (set) Token: 0x0601E189 RID: 123273 RVA: 0x0090AE6B File Offset: 0x0090906B
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_Ak);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_Ak, value);
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0601E18A RID: 123274 RVA: 0x0090AE80 File Offset: 0x00909080
		// (set) Token: 0x0601E18B RID: 123275 RVA: 0x0090AE94 File Offset: 0x00909094
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170031F0 RID: 12784
		// (get) Token: 0x0601E18C RID: 123276 RVA: 0x0090AEA9 File Offset: 0x009090A9
		// (set) Token: 0x0601E18D RID: 123277 RVA: 0x0090AEBD File Offset: 0x009090BD
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x170031F1 RID: 12785
		// (get) Token: 0x0601E18E RID: 123278 RVA: 0x0090AED2 File Offset: 0x009090D2
		// (set) Token: 0x0601E18F RID: 123279 RVA: 0x0090AEE6 File Offset: 0x009090E6
		public unsafe UMaterial ViedoMaterialTranSlucentTwoSide
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ViedoMaterialTranSlucentTwoSide);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ViedoMaterialTranSlucentTwoSide, value);
			}
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0601E190 RID: 123280 RVA: 0x0090AEFB File Offset: 0x009090FB
		// (set) Token: 0x0601E191 RID: 123281 RVA: 0x0090AF0F File Offset: 0x0090910F
		public unsafe UMaterial ViedoMaterialTranSlucent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ViedoMaterialTranSlucent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ViedoMaterialTranSlucent, value);
			}
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0601E192 RID: 123282 RVA: 0x0090AF24 File Offset: 0x00909124
		// (set) Token: 0x0601E193 RID: 123283 RVA: 0x0090AF38 File Offset: 0x00909138
		public unsafe UMaterial ViedoMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ViedoMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ViedoMaterial, value);
			}
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0601E194 RID: 123284 RVA: 0x0090AF4D File Offset: 0x0090914D
		// (set) Token: 0x0601E195 RID: 123285 RVA: 0x0090AF5D File Offset: 0x0090915D
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0601E196 RID: 123286 RVA: 0x0090AF6E File Offset: 0x0090916E
		// (set) Token: 0x0601E197 RID: 123287 RVA: 0x0090AF7E File Offset: 0x0090917E
		public unsafe float DarkIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_DarkIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_DarkIntensity) = value;
			}
		}

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0601E198 RID: 123288 RVA: 0x0090AF8F File Offset: 0x0090918F
		// (set) Token: 0x0601E199 RID: 123289 RVA: 0x0090AF9F File Offset: 0x0090919F
		public unsafe int AoiDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_AoiDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_AoiDistance) = value;
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0601E19A RID: 123290 RVA: 0x0090AFB0 File Offset: 0x009091B0
		// (set) Token: 0x0601E19B RID: 123291 RVA: 0x0090AFC0 File Offset: 0x009091C0
		public unsafe bool Translucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_Translucent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_Translucent) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0601E19C RID: 123292 RVA: 0x0090AFD1 File Offset: 0x009091D1
		// (set) Token: 0x0601E19D RID: 123293 RVA: 0x0090AFE1 File Offset: 0x009091E1
		public unsafe bool TwoSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_TwoSide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_TwoSide) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0601E19E RID: 123294 RVA: 0x0090AFF2 File Offset: 0x009091F2
		// (set) Token: 0x0601E19F RID: 123295 RVA: 0x0090B002 File Offset: 0x00909202
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_Opacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_Opacity) = value;
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0601E1A0 RID: 123296 RVA: 0x0090B013 File Offset: 0x00909213
		// (set) Token: 0x0601E1A1 RID: 123297 RVA: 0x0090B027 File Offset: 0x00909227
		public unsafe PDA_MediaPlayDataAsset_C MediaPlayDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_MediaPlayDataAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_MediaPlayDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_MediaPlayDataAsset, value);
			}
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0601E1A2 RID: 123298 RVA: 0x0090B03C File Offset: 0x0090923C
		// (set) Token: 0x0601E1A3 RID: 123299 RVA: 0x0090B050 File Offset: 0x00909250
		public unsafe UMediaPlayer ShareMediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ShareMediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ShareMediaPlayer, value);
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0601E1A4 RID: 123300 RVA: 0x0090B065 File Offset: 0x00909265
		// (set) Token: 0x0601E1A5 RID: 123301 RVA: 0x0090B079 File Offset: 0x00909279
		public unsafe UMediaTexture ShareMediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ShareMediaTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_ShareMediaTexture, value);
			}
		}

		// Token: 0x170031FD RID: 12797
		// (get) Token: 0x0601E1A6 RID: 123302 RVA: 0x0090B08E File Offset: 0x0090928E
		// (set) Token: 0x0601E1A7 RID: 123303 RVA: 0x0090B09E File Offset: 0x0090929E
		public unsafe bool isOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_isOpen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_isOpen) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031FE RID: 12798
		// (get) Token: 0x0601E1A8 RID: 123304 RVA: 0x0090B0AF File Offset: 0x009092AF
		// (set) Token: 0x0601E1A9 RID: 123305 RVA: 0x0090B0BF File Offset: 0x009092BF
		public unsafe bool DrawDebugAoi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_DrawDebugAoi) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_DrawDebugAoi) = (value ? 1 : 0);
			}
		}

		// Token: 0x170031FF RID: 12799
		// (get) Token: 0x0601E1AA RID: 123306 RVA: 0x0090B0D0 File Offset: 0x009092D0
		// (set) Token: 0x0601E1AB RID: 123307 RVA: 0x0090B0E0 File Offset: 0x009092E0
		public unsafe bool isStopOnHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_isStopOnHide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_isStopOnHide) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003200 RID: 12800
		// (get) Token: 0x0601E1AC RID: 123308 RVA: 0x0090B0F1 File Offset: 0x009092F1
		// (set) Token: 0x0601E1AD RID: 123309 RVA: 0x0090B101 File Offset: 0x00909301
		public unsafe bool enableQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_enableQualityLevel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_enableQualityLevel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003201 RID: 12801
		// (get) Token: 0x0601E1AE RID: 123310 RVA: 0x0090B114 File Offset: 0x00909314
		// (set) Token: 0x0601E1AF RID: 123311 RVA: 0x0090B14D File Offset: 0x0090934D
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
					result = (this._QualityDistanceList = new TArray<int>(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_QualityDistanceList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QualityDistanceList.CopyAssign(value);
			}
		}

		// Token: 0x0601E1B0 RID: 123312 RVA: 0x0090B15C File Offset: 0x0090935C
		[SkipLocalsInit]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			MediaPlayForModel_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E1B1 RID: 123313 RVA: 0x0090B1AC File Offset: 0x009093AC
		[SkipLocalsInit]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			MediaPlayForModel_C.__GetAoiRange_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__GetAoiRange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E1B2 RID: 123314 RVA: 0x0090B1FB File Offset: 0x009093FB
		[SkipLocalsInit]
		public virtual void ReInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ReInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1B3 RID: 123315 RVA: 0x0090B20F File Offset: 0x0090940F
		[SkipLocalsInit]
		public virtual void ConstructionMediaPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ConstructionMediaPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1B4 RID: 123316 RVA: 0x0090B223 File Offset: 0x00909423
		[SkipLocalsInit]
		public virtual void OpenSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__OpenSource_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1B5 RID: 123317 RVA: 0x0090B237 File Offset: 0x00909437
		[SkipLocalsInit]
		public virtual void CloseSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__CloseSource_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1B6 RID: 123318 RVA: 0x0090B24B File Offset: 0x0090944B
		[SkipLocalsInit]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1B7 RID: 123319 RVA: 0x0090B25F File Offset: 0x0090945F
		[SkipLocalsInit]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1B8 RID: 123320 RVA: 0x0090B273 File Offset: 0x00909473
		[SkipLocalsInit]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1B9 RID: 123321 RVA: 0x0090B287 File Offset: 0x00909487
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1BA RID: 123322 RVA: 0x0090B29B File Offset: 0x0090949B
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1BB RID: 123323 RVA: 0x0090B2B0 File Offset: 0x009094B0
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			MediaPlayForModel_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E1BC RID: 123324 RVA: 0x0090B2F8 File Offset: 0x009094F8
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			MediaPlayForModel_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E1BD RID: 123325 RVA: 0x0090B33E File Offset: 0x0090953E
		[SkipLocalsInit]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1BE RID: 123326 RVA: 0x0090B352 File Offset: 0x00909552
		[SkipLocalsInit]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1BF RID: 123327 RVA: 0x0090B366 File Offset: 0x00909566
		[SkipLocalsInit]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1C0 RID: 123328 RVA: 0x0090B37A File Offset: 0x0090957A
		[SkipLocalsInit]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1C1 RID: 123329 RVA: 0x0090B390 File Offset: 0x00909590
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E1C2 RID: 123330 RVA: 0x0090B3DC File Offset: 0x009095DC
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E1C3 RID: 123331 RVA: 0x0090B427 File Offset: 0x00909627
		[SkipLocalsInit]
		public virtual void PlaySound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__PlaySound_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1C4 RID: 123332 RVA: 0x0090B43B File Offset: 0x0090963B
		[SkipLocalsInit]
		public virtual void CloseSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__CloseSound_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1C5 RID: 123333 RVA: 0x0090B44F File Offset: 0x0090964F
		protected MediaPlayForModel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE98 RID: 65176
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel.MediaPlayForModel_C";

		// Token: 0x0400FE99 RID: 65177
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE9A RID: 65178
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE9B RID: 65179
		internal static int __PropertyOffset_Ak;

		// Token: 0x0400FE9C RID: 65180
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400FE9D RID: 65181
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FE9E RID: 65182
		internal static int __PropertyOffset_ViedoMaterialTranSlucentTwoSide;

		// Token: 0x0400FE9F RID: 65183
		internal static int __PropertyOffset_ViedoMaterialTranSlucent;

		// Token: 0x0400FEA0 RID: 65184
		internal static int __PropertyOffset_ViedoMaterial;

		// Token: 0x0400FEA1 RID: 65185
		internal static int __PropertyOffset_Intensity;

		// Token: 0x0400FEA2 RID: 65186
		internal static int __PropertyOffset_DarkIntensity;

		// Token: 0x0400FEA3 RID: 65187
		internal static int __PropertyOffset_AoiDistance;

		// Token: 0x0400FEA4 RID: 65188
		internal static int __PropertyOffset_Translucent;

		// Token: 0x0400FEA5 RID: 65189
		internal static int __PropertyOffset_TwoSide;

		// Token: 0x0400FEA6 RID: 65190
		internal static int __PropertyOffset_Opacity;

		// Token: 0x0400FEA7 RID: 65191
		internal static int __PropertyOffset_MediaPlayDataAsset;

		// Token: 0x0400FEA8 RID: 65192
		internal static int __PropertyOffset_ShareMediaPlayer;

		// Token: 0x0400FEA9 RID: 65193
		internal static int __PropertyOffset_ShareMediaTexture;

		// Token: 0x0400FEAA RID: 65194
		internal static int __PropertyOffset_isOpen;

		// Token: 0x0400FEAB RID: 65195
		internal static int __PropertyOffset_DrawDebugAoi;

		// Token: 0x0400FEAC RID: 65196
		internal static int __PropertyOffset_isStopOnHide;

		// Token: 0x0400FEAD RID: 65197
		internal static int __PropertyOffset_enableQualityLevel;

		// Token: 0x0400FEAE RID: 65198
		internal static int __PropertyOffset_QualityDistanceList;

		// Token: 0x0400FEAF RID: 65199
		private TArray<int> _QualityDistanceList;

		// Token: 0x0400FEB0 RID: 65200
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x0400FEB1 RID: 65201
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x0400FEB2 RID: 65202
		private static IntPtr __ReInit_NativeFunctionPtr;

		// Token: 0x0400FEB3 RID: 65203
		private static IntPtr __ConstructionMediaPlay_NativeFunctionPtr;

		// Token: 0x0400FEB4 RID: 65204
		private static IntPtr __OpenSource_NativeFunctionPtr;

		// Token: 0x0400FEB5 RID: 65205
		private static IntPtr __CloseSource_NativeFunctionPtr;

		// Token: 0x0400FEB6 RID: 65206
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x0400FEB7 RID: 65207
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x0400FEB8 RID: 65208
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x0400FEB9 RID: 65209
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FEBA RID: 65210
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FEBB RID: 65211
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x0400FEBC RID: 65212
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400FEBD RID: 65213
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x0400FEBE RID: 65214
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0400FEBF RID: 65215
		private static IntPtr __PlaySound_NativeFunctionPtr;

		// Token: 0x0400FEC0 RID: 65216
		private static IntPtr __CloseSound_NativeFunctionPtr;

		// Token: 0x02008E1D RID: 36381
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0402CA5C RID: 182876
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02008E1E RID: 36382
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0402CA5D RID: 182877
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02008E1F RID: 36383
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CA5E RID: 182878
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E20 RID: 36384
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CA5F RID: 182879
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
