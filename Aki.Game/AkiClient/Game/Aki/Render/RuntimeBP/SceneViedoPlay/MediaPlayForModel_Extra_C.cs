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
	// Token: 0x020030D4 RID: 12500
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Extra.MediaPlayForModel_Extra_C")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class MediaPlayForModel_Extra_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E1C6 RID: 123334 RVA: 0x0090B458 File Offset: 0x00909658
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (MediaPlayForModel_Extra_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Extra.MediaPlayForModel_Extra_C");
			}
			return MediaPlayForModel_Extra_C._ClassPtr;
		}

		// Token: 0x0601E1C7 RID: 123335 RVA: 0x0090B47C File Offset: 0x0090967C
		public MediaPlayForModel_Extra_C() : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_Extra_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E1C8 RID: 123336 RVA: 0x0090B4A4 File Offset: 0x009096A4
		[NullableContext(1)]
		public MediaPlayForModel_Extra_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_Extra_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003202 RID: 12802
		// (get) Token: 0x0601E1C9 RID: 123337 RVA: 0x0090B4D7 File Offset: 0x009096D7
		// (set) Token: 0x0601E1CA RID: 123338 RVA: 0x0090B4EB File Offset: 0x009096EB
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_Ak);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_Ak, value);
			}
		}

		// Token: 0x17003203 RID: 12803
		// (get) Token: 0x0601E1CB RID: 123339 RVA: 0x0090B500 File Offset: 0x00909700
		// (set) Token: 0x0601E1CC RID: 123340 RVA: 0x0090B514 File Offset: 0x00909714
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x17003204 RID: 12804
		// (get) Token: 0x0601E1CD RID: 123341 RVA: 0x0090B529 File Offset: 0x00909729
		// (set) Token: 0x0601E1CE RID: 123342 RVA: 0x0090B53D File Offset: 0x0090973D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003205 RID: 12805
		// (get) Token: 0x0601E1CF RID: 123343 RVA: 0x0090B552 File Offset: 0x00909752
		// (set) Token: 0x0601E1D0 RID: 123344 RVA: 0x0090B566 File Offset: 0x00909766
		public unsafe UMaterial ViedoMaterialTranSlucentTwoSide
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ViedoMaterialTranSlucentTwoSide);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ViedoMaterialTranSlucentTwoSide, value);
			}
		}

		// Token: 0x17003206 RID: 12806
		// (get) Token: 0x0601E1D1 RID: 123345 RVA: 0x0090B57B File Offset: 0x0090977B
		// (set) Token: 0x0601E1D2 RID: 123346 RVA: 0x0090B58F File Offset: 0x0090978F
		public unsafe UMaterial ViedoMaterialTranSlucent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ViedoMaterialTranSlucent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ViedoMaterialTranSlucent, value);
			}
		}

		// Token: 0x17003207 RID: 12807
		// (get) Token: 0x0601E1D3 RID: 123347 RVA: 0x0090B5A4 File Offset: 0x009097A4
		// (set) Token: 0x0601E1D4 RID: 123348 RVA: 0x0090B5B8 File Offset: 0x009097B8
		public unsafe UMaterial ViedoMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ViedoMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ViedoMaterial, value);
			}
		}

		// Token: 0x17003208 RID: 12808
		// (get) Token: 0x0601E1D5 RID: 123349 RVA: 0x0090B5CD File Offset: 0x009097CD
		// (set) Token: 0x0601E1D6 RID: 123350 RVA: 0x0090B5DD File Offset: 0x009097DD
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x17003209 RID: 12809
		// (get) Token: 0x0601E1D7 RID: 123351 RVA: 0x0090B5EE File Offset: 0x009097EE
		// (set) Token: 0x0601E1D8 RID: 123352 RVA: 0x0090B5FE File Offset: 0x009097FE
		public unsafe float DarkIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_DarkIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_DarkIntensity) = value;
			}
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0601E1D9 RID: 123353 RVA: 0x0090B60F File Offset: 0x0090980F
		// (set) Token: 0x0601E1DA RID: 123354 RVA: 0x0090B61F File Offset: 0x0090981F
		public unsafe int AoiDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_AoiDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_AoiDistance) = value;
			}
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0601E1DB RID: 123355 RVA: 0x0090B630 File Offset: 0x00909830
		// (set) Token: 0x0601E1DC RID: 123356 RVA: 0x0090B640 File Offset: 0x00909840
		public unsafe bool Translucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_Translucent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_Translucent) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0601E1DD RID: 123357 RVA: 0x0090B651 File Offset: 0x00909851
		// (set) Token: 0x0601E1DE RID: 123358 RVA: 0x0090B661 File Offset: 0x00909861
		public unsafe bool TwoSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_TwoSide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_TwoSide) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0601E1DF RID: 123359 RVA: 0x0090B672 File Offset: 0x00909872
		// (set) Token: 0x0601E1E0 RID: 123360 RVA: 0x0090B682 File Offset: 0x00909882
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_Opacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_Opacity) = value;
			}
		}

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0601E1E1 RID: 123361 RVA: 0x0090B693 File Offset: 0x00909893
		// (set) Token: 0x0601E1E2 RID: 123362 RVA: 0x0090B6A7 File Offset: 0x009098A7
		public unsafe PDA_MediaPlayDataAsset_C MediaPlayDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_MediaPlayDataAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_MediaPlayDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_MediaPlayDataAsset, value);
			}
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0601E1E3 RID: 123363 RVA: 0x0090B6BC File Offset: 0x009098BC
		// (set) Token: 0x0601E1E4 RID: 123364 RVA: 0x0090B6D0 File Offset: 0x009098D0
		public unsafe UMediaPlayer ShareMediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ShareMediaPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ShareMediaPlayer, value);
			}
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0601E1E5 RID: 123365 RVA: 0x0090B6E5 File Offset: 0x009098E5
		// (set) Token: 0x0601E1E6 RID: 123366 RVA: 0x0090B6F9 File Offset: 0x009098F9
		public unsafe UMediaTexture ShareMediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ShareMediaTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_ShareMediaTexture, value);
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0601E1E7 RID: 123367 RVA: 0x0090B70E File Offset: 0x0090990E
		// (set) Token: 0x0601E1E8 RID: 123368 RVA: 0x0090B71E File Offset: 0x0090991E
		public unsafe bool isOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_isOpen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_isOpen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0601E1E9 RID: 123369 RVA: 0x0090B72F File Offset: 0x0090992F
		// (set) Token: 0x0601E1EA RID: 123370 RVA: 0x0090B73F File Offset: 0x0090993F
		public unsafe bool DrawDebugAoi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_DrawDebugAoi) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_DrawDebugAoi) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0601E1EB RID: 123371 RVA: 0x0090B750 File Offset: 0x00909950
		// (set) Token: 0x0601E1EC RID: 123372 RVA: 0x0090B760 File Offset: 0x00909960
		public unsafe bool isStopOnHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_isStopOnHide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_isStopOnHide) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0601E1ED RID: 123373 RVA: 0x0090B771 File Offset: 0x00909971
		// (set) Token: 0x0601E1EE RID: 123374 RVA: 0x0090B781 File Offset: 0x00909981
		public unsafe bool enableQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_enableQualityLevel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_enableQualityLevel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0601E1EF RID: 123375 RVA: 0x0090B794 File Offset: 0x00909994
		// (set) Token: 0x0601E1F0 RID: 123376 RVA: 0x0090B7CD File Offset: 0x009099CD
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
					result = (this._QualityDistanceList = new TArray<int>(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_QualityDistanceList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QualityDistanceList.CopyAssign(value);
			}
		}

		// Token: 0x0601E1F1 RID: 123377 RVA: 0x0090B7DC File Offset: 0x009099DC
		[SkipLocalsInit]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			MediaPlayForModel_Extra_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E1F2 RID: 123378 RVA: 0x0090B82C File Offset: 0x00909A2C
		[SkipLocalsInit]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			MediaPlayForModel_Extra_C.__GetAoiRange_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__GetAoiRange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x0601E1F3 RID: 123379 RVA: 0x0090B87B File Offset: 0x00909A7B
		[SkipLocalsInit]
		public virtual void ReInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReInit_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1F4 RID: 123380 RVA: 0x0090B88F File Offset: 0x00909A8F
		[SkipLocalsInit]
		public virtual void ConstructionMediaPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ConstructionMediaPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1F5 RID: 123381 RVA: 0x0090B8A3 File Offset: 0x00909AA3
		[SkipLocalsInit]
		public virtual void OpenSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__OpenSource_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1F6 RID: 123382 RVA: 0x0090B8B7 File Offset: 0x00909AB7
		[SkipLocalsInit]
		public virtual void CloseSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__CloseSource_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1F7 RID: 123383 RVA: 0x0090B8CB File Offset: 0x00909ACB
		[SkipLocalsInit]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1F8 RID: 123384 RVA: 0x0090B8DF File Offset: 0x00909ADF
		[SkipLocalsInit]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1F9 RID: 123385 RVA: 0x0090B8F3 File Offset: 0x00909AF3
		[SkipLocalsInit]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1FA RID: 123386 RVA: 0x0090B907 File Offset: 0x00909B07
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1FB RID: 123387 RVA: 0x0090B91B File Offset: 0x00909B1B
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1FC RID: 123388 RVA: 0x0090B930 File Offset: 0x00909B30
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			MediaPlayForModel_Extra_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E1FD RID: 123389 RVA: 0x0090B978 File Offset: 0x00909B78
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			MediaPlayForModel_Extra_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E1FE RID: 123390 RVA: 0x0090B9BE File Offset: 0x00909BBE
		[SkipLocalsInit]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x0601E1FF RID: 123391 RVA: 0x0090B9D2 File Offset: 0x00909BD2
		[SkipLocalsInit]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x0601E200 RID: 123392 RVA: 0x0090B9E8 File Offset: 0x00909BE8
		[SkipLocalsInit]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E201 RID: 123393 RVA: 0x0090BA34 File Offset: 0x00909C34
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E202 RID: 123394 RVA: 0x0090BA7F File Offset: 0x00909C7F
		[SkipLocalsInit]
		public virtual void PlaySound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__PlaySound_NativeFunctionPtr, null);
		}

		// Token: 0x0601E203 RID: 123395 RVA: 0x0090BA93 File Offset: 0x00909C93
		[SkipLocalsInit]
		public virtual void CloseSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__CloseSound_NativeFunctionPtr, null);
		}

		// Token: 0x0601E204 RID: 123396 RVA: 0x0090BAA7 File Offset: 0x00909CA7
		protected MediaPlayForModel_Extra_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEC1 RID: 65217
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Extra.MediaPlayForModel_Extra_C";

		// Token: 0x0400FEC2 RID: 65218
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEC3 RID: 65219
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FEC4 RID: 65220
		internal static int __PropertyOffset_Ak;

		// Token: 0x0400FEC5 RID: 65221
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400FEC6 RID: 65222
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FEC7 RID: 65223
		internal static int __PropertyOffset_ViedoMaterialTranSlucentTwoSide;

		// Token: 0x0400FEC8 RID: 65224
		internal static int __PropertyOffset_ViedoMaterialTranSlucent;

		// Token: 0x0400FEC9 RID: 65225
		internal static int __PropertyOffset_ViedoMaterial;

		// Token: 0x0400FECA RID: 65226
		internal static int __PropertyOffset_Intensity;

		// Token: 0x0400FECB RID: 65227
		internal static int __PropertyOffset_DarkIntensity;

		// Token: 0x0400FECC RID: 65228
		internal static int __PropertyOffset_AoiDistance;

		// Token: 0x0400FECD RID: 65229
		internal static int __PropertyOffset_Translucent;

		// Token: 0x0400FECE RID: 65230
		internal static int __PropertyOffset_TwoSide;

		// Token: 0x0400FECF RID: 65231
		internal static int __PropertyOffset_Opacity;

		// Token: 0x0400FED0 RID: 65232
		internal static int __PropertyOffset_MediaPlayDataAsset;

		// Token: 0x0400FED1 RID: 65233
		internal static int __PropertyOffset_ShareMediaPlayer;

		// Token: 0x0400FED2 RID: 65234
		internal static int __PropertyOffset_ShareMediaTexture;

		// Token: 0x0400FED3 RID: 65235
		internal static int __PropertyOffset_isOpen;

		// Token: 0x0400FED4 RID: 65236
		internal static int __PropertyOffset_DrawDebugAoi;

		// Token: 0x0400FED5 RID: 65237
		internal static int __PropertyOffset_isStopOnHide;

		// Token: 0x0400FED6 RID: 65238
		internal static int __PropertyOffset_enableQualityLevel;

		// Token: 0x0400FED7 RID: 65239
		internal static int __PropertyOffset_QualityDistanceList;

		// Token: 0x0400FED8 RID: 65240
		private TArray<int> _QualityDistanceList;

		// Token: 0x0400FED9 RID: 65241
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x0400FEDA RID: 65242
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x0400FEDB RID: 65243
		private static IntPtr __ReInit_NativeFunctionPtr;

		// Token: 0x0400FEDC RID: 65244
		private static IntPtr __ConstructionMediaPlay_NativeFunctionPtr;

		// Token: 0x0400FEDD RID: 65245
		private static IntPtr __OpenSource_NativeFunctionPtr;

		// Token: 0x0400FEDE RID: 65246
		private static IntPtr __CloseSource_NativeFunctionPtr;

		// Token: 0x0400FEDF RID: 65247
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x0400FEE0 RID: 65248
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x0400FEE1 RID: 65249
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x0400FEE2 RID: 65250
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FEE3 RID: 65251
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0400FEE4 RID: 65252
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x0400FEE5 RID: 65253
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x0400FEE6 RID: 65254
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x0400FEE7 RID: 65255
		private static IntPtr __PlaySound_NativeFunctionPtr;

		// Token: 0x0400FEE8 RID: 65256
		private static IntPtr __CloseSound_NativeFunctionPtr;

		// Token: 0x02008E21 RID: 36385
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0402CA60 RID: 182880
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02008E22 RID: 36386
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0402CA61 RID: 182881
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02008E23 RID: 36387
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CA62 RID: 182882
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E24 RID: 36388
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0402CA63 RID: 182883
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
