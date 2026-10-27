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
	// Token: 0x02003BAA RID: 15274
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Extra.MediaPlayForModel_Extra_C")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class MediaPlayForModel_Extra_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x060220CF RID: 139471 RVA: 0x008FDD21 File Offset: 0x008FBF21
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (MediaPlayForModel_Extra_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Extra.MediaPlayForModel_Extra_C");
			}
			return MediaPlayForModel_Extra_C._ClassPtr;
		}

		// Token: 0x060220D0 RID: 139472 RVA: 0x008FDD48 File Offset: 0x008FBF48
		public MediaPlayForModel_Extra_C() : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_Extra_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060220D1 RID: 139473 RVA: 0x008FDD70 File Offset: 0x008FBF70
		[NullableContext(1)]
		public MediaPlayForModel_Extra_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_Extra_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x060220D2 RID: 139474 RVA: 0x008FDDA3 File Offset: 0x008FBFA3
		// (set) Token: 0x060220D3 RID: 139475 RVA: 0x008FDDB7 File Offset: 0x008FBFB7
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x060220D4 RID: 139476 RVA: 0x008FDDCC File Offset: 0x008FBFCC
		// (set) Token: 0x060220D5 RID: 139477 RVA: 0x008FDDE0 File Offset: 0x008FBFE0
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x060220D6 RID: 139478 RVA: 0x008FDDF5 File Offset: 0x008FBFF5
		// (set) Token: 0x060220D7 RID: 139479 RVA: 0x008FDE09 File Offset: 0x008FC009
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x060220D8 RID: 139480 RVA: 0x008FDE1E File Offset: 0x008FC01E
		// (set) Token: 0x060220D9 RID: 139481 RVA: 0x008FDE32 File Offset: 0x008FC032
		public unsafe UMaterial ViedoMaterialTranSlucentTwoSide
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x060220DA RID: 139482 RVA: 0x008FDE47 File Offset: 0x008FC047
		// (set) Token: 0x060220DB RID: 139483 RVA: 0x008FDE5B File Offset: 0x008FC05B
		public unsafe UMaterial ViedoMaterialTranSlucent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x060220DC RID: 139484 RVA: 0x008FDE70 File Offset: 0x008FC070
		// (set) Token: 0x060220DD RID: 139485 RVA: 0x008FDE84 File Offset: 0x008FC084
		public unsafe UMaterial ViedoMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x060220DE RID: 139486 RVA: 0x008FDE99 File Offset: 0x008FC099
		// (set) Token: 0x060220DF RID: 139487 RVA: 0x008FDEA9 File Offset: 0x008FC0A9
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x060220E0 RID: 139488 RVA: 0x008FDEBA File Offset: 0x008FC0BA
		// (set) Token: 0x060220E1 RID: 139489 RVA: 0x008FDECA File Offset: 0x008FC0CA
		public unsafe float DarkIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x060220E2 RID: 139490 RVA: 0x008FDEDB File Offset: 0x008FC0DB
		// (set) Token: 0x060220E3 RID: 139491 RVA: 0x008FDEEB File Offset: 0x008FC0EB
		public unsafe int AoiDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x060220E4 RID: 139492 RVA: 0x008FDEFC File Offset: 0x008FC0FC
		// (set) Token: 0x060220E5 RID: 139493 RVA: 0x008FDF0C File Offset: 0x008FC10C
		public unsafe bool Translucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x060220E6 RID: 139494 RVA: 0x008FDF1D File Offset: 0x008FC11D
		// (set) Token: 0x060220E7 RID: 139495 RVA: 0x008FDF2D File Offset: 0x008FC12D
		public unsafe bool TwoSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x060220E8 RID: 139496 RVA: 0x008FDF3E File Offset: 0x008FC13E
		// (set) Token: 0x060220E9 RID: 139497 RVA: 0x008FDF4E File Offset: 0x008FC14E
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x060220EA RID: 139498 RVA: 0x008FDF5F File Offset: 0x008FC15F
		// (set) Token: 0x060220EB RID: 139499 RVA: 0x008FDF73 File Offset: 0x008FC173
		public unsafe PDA_MediaPlayDataAsset_C MediaPlayDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_MediaPlayDataAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x060220EC RID: 139500 RVA: 0x008FDF88 File Offset: 0x008FC188
		// (set) Token: 0x060220ED RID: 139501 RVA: 0x008FDF9C File Offset: 0x008FC19C
		public unsafe UMediaPlayer ShareMediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x060220EE RID: 139502 RVA: 0x008FDFB1 File Offset: 0x008FC1B1
		// (set) Token: 0x060220EF RID: 139503 RVA: 0x008FDFC5 File Offset: 0x008FC1C5
		public unsafe UMediaTexture ShareMediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_Extra_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x060220F0 RID: 139504 RVA: 0x008FDFDA File Offset: 0x008FC1DA
		// (set) Token: 0x060220F1 RID: 139505 RVA: 0x008FDFEA File Offset: 0x008FC1EA
		public unsafe bool isOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x060220F2 RID: 139506 RVA: 0x008FDFFB File Offset: 0x008FC1FB
		// (set) Token: 0x060220F3 RID: 139507 RVA: 0x008FE00B File Offset: 0x008FC20B
		public unsafe bool DrawDebugAoi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x060220F4 RID: 139508 RVA: 0x008FE01C File Offset: 0x008FC21C
		// (set) Token: 0x060220F5 RID: 139509 RVA: 0x008FE02C File Offset: 0x008FC22C
		public unsafe bool isStopOnHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x060220F6 RID: 139510 RVA: 0x008FE03D File Offset: 0x008FC23D
		// (set) Token: 0x060220F7 RID: 139511 RVA: 0x008FE04D File Offset: 0x008FC24D
		public unsafe bool enableQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x060220F8 RID: 139512 RVA: 0x008FE060 File Offset: 0x008FC260
		// (set) Token: 0x060220F9 RID: 139513 RVA: 0x008FE099 File Offset: 0x008FC299
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
					result = (this._QualityDistanceList = new TArray<int>(base.NativePtr + (IntPtr)MediaPlayForModel_Extra_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QualityDistanceList.CopyAssign(value);
			}
		}

		// Token: 0x060220FA RID: 139514 RVA: 0x008FE0A8 File Offset: 0x008FC2A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			MediaPlayForModel_Extra_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x060220FB RID: 139515 RVA: 0x008FE0F8 File Offset: 0x008FC2F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			MediaPlayForModel_Extra_C.__GetAoiRange_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__GetAoiRange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x060220FC RID: 139516 RVA: 0x008FE147 File Offset: 0x008FC347
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReInit_NativeFunctionPtr, null);
		}

		// Token: 0x060220FD RID: 139517 RVA: 0x008FE15B File Offset: 0x008FC35B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ConstructionMediaPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ConstructionMediaPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060220FE RID: 139518 RVA: 0x008FE16F File Offset: 0x008FC36F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__OpenSource_NativeFunctionPtr, null);
		}

		// Token: 0x060220FF RID: 139519 RVA: 0x008FE183 File Offset: 0x008FC383
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__CloseSource_NativeFunctionPtr, null);
		}

		// Token: 0x06022100 RID: 139520 RVA: 0x008FE197 File Offset: 0x008FC397
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x06022101 RID: 139521 RVA: 0x008FE1AB File Offset: 0x008FC3AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x06022102 RID: 139522 RVA: 0x008FE1BF File Offset: 0x008FC3BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x06022103 RID: 139523 RVA: 0x008FE1D3 File Offset: 0x008FC3D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022104 RID: 139524 RVA: 0x008FE1E7 File Offset: 0x008FC3E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022105 RID: 139525 RVA: 0x008FE1FC File Offset: 0x008FC3FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			MediaPlayForModel_Extra_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022106 RID: 139526 RVA: 0x008FE244 File Offset: 0x008FC444
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			MediaPlayForModel_Extra_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022107 RID: 139527 RVA: 0x008FE28B File Offset: 0x008FC48B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x06022108 RID: 139528 RVA: 0x008FE29F File Offset: 0x008FC49F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x06022109 RID: 139529 RVA: 0x008FE2B4 File Offset: 0x008FC4B4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602210A RID: 139530 RVA: 0x008FE300 File Offset: 0x008FC500
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_Extra_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_Extra_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602210B RID: 139531 RVA: 0x008FE34C File Offset: 0x008FC54C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlaySound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__PlaySound_NativeFunctionPtr, null);
		}

		// Token: 0x0602210C RID: 139532 RVA: 0x008FE360 File Offset: 0x008FC560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_Extra_C.__CloseSound_NativeFunctionPtr, null);
		}

		// Token: 0x0602210D RID: 139533 RVA: 0x008FE374 File Offset: 0x008FC574
		protected MediaPlayForModel_Extra_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010AA8 RID: 68264
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel_Extra.MediaPlayForModel_Extra_C";

		// Token: 0x04010AA9 RID: 68265
		private static IntPtr _ClassPtr;

		// Token: 0x04010AAA RID: 68266
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010AAB RID: 68267
		internal static int __PropertyOffset_1;

		// Token: 0x04010AAC RID: 68268
		internal static int __PropertyOffset_2;

		// Token: 0x04010AAD RID: 68269
		internal static int __PropertyOffset_3;

		// Token: 0x04010AAE RID: 68270
		internal static int __PropertyOffset_4;

		// Token: 0x04010AAF RID: 68271
		internal static int __PropertyOffset_5;

		// Token: 0x04010AB0 RID: 68272
		internal static int __PropertyOffset_6;

		// Token: 0x04010AB1 RID: 68273
		internal static int __PropertyOffset_7;

		// Token: 0x04010AB2 RID: 68274
		internal static int __PropertyOffset_8;

		// Token: 0x04010AB3 RID: 68275
		internal static int __PropertyOffset_9;

		// Token: 0x04010AB4 RID: 68276
		internal static int __PropertyOffset_10;

		// Token: 0x04010AB5 RID: 68277
		internal static int __PropertyOffset_11;

		// Token: 0x04010AB6 RID: 68278
		internal static int __PropertyOffset_12;

		// Token: 0x04010AB7 RID: 68279
		internal static int __PropertyOffset_13;

		// Token: 0x04010AB8 RID: 68280
		internal static int __PropertyOffset_14;

		// Token: 0x04010AB9 RID: 68281
		internal static int __PropertyOffset_15;

		// Token: 0x04010ABA RID: 68282
		internal static int __PropertyOffset_16;

		// Token: 0x04010ABB RID: 68283
		internal static int __PropertyOffset_17;

		// Token: 0x04010ABC RID: 68284
		internal static int __PropertyOffset_18;

		// Token: 0x04010ABD RID: 68285
		internal static int __PropertyOffset_19;

		// Token: 0x04010ABE RID: 68286
		internal static int __PropertyOffset_20;

		// Token: 0x04010ABF RID: 68287
		private TArray<int> _QualityDistanceList;

		// Token: 0x04010AC0 RID: 68288
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x04010AC1 RID: 68289
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x04010AC2 RID: 68290
		private static IntPtr __ReInit_NativeFunctionPtr;

		// Token: 0x04010AC3 RID: 68291
		private static IntPtr __ConstructionMediaPlay_NativeFunctionPtr;

		// Token: 0x04010AC4 RID: 68292
		private static IntPtr __OpenSource_NativeFunctionPtr;

		// Token: 0x04010AC5 RID: 68293
		private static IntPtr __CloseSource_NativeFunctionPtr;

		// Token: 0x04010AC6 RID: 68294
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x04010AC7 RID: 68295
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x04010AC8 RID: 68296
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x04010AC9 RID: 68297
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010ACA RID: 68298
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010ACB RID: 68299
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x04010ACC RID: 68300
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04010ACD RID: 68301
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04010ACE RID: 68302
		private static IntPtr __PlaySound_NativeFunctionPtr;

		// Token: 0x04010ACF RID: 68303
		private static IntPtr __CloseSound_NativeFunctionPtr;

		// Token: 0x02009D20 RID: 40224
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x0403145A RID: 201818
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02009D21 RID: 40225
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x0403145B RID: 201819
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02009D22 RID: 40226
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403145C RID: 201820
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D23 RID: 40227
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x0403145D RID: 201821
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
