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
	// Token: 0x02003BA9 RID: 15273
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel.MediaPlayForModel_C")]
	[UnrealStructLayout(1576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1576)]
	public class MediaPlayForModel_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_SceneBp_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0602208E RID: 139406 RVA: 0x008FD6A0 File Offset: 0x008FB8A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (MediaPlayForModel_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel.MediaPlayForModel_C");
			}
			return MediaPlayForModel_C._ClassPtr;
		}

		// Token: 0x0602208F RID: 139407 RVA: 0x008FD6C4 File Offset: 0x008FB8C4
		public MediaPlayForModel_C() : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022090 RID: 139408 RVA: 0x008FD6EC File Offset: 0x008FB8EC
		[NullableContext(1)]
		public MediaPlayForModel_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(MediaPlayForModel_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x06022091 RID: 139409 RVA: 0x008FD71F File Offset: 0x008FB91F
		// (set) Token: 0x06022092 RID: 139410 RVA: 0x008FD733 File Offset: 0x008FB933
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x06022093 RID: 139411 RVA: 0x008FD748 File Offset: 0x008FB948
		// (set) Token: 0x06022094 RID: 139412 RVA: 0x008FD75C File Offset: 0x008FB95C
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x06022095 RID: 139413 RVA: 0x008FD771 File Offset: 0x008FB971
		// (set) Token: 0x06022096 RID: 139414 RVA: 0x008FD785 File Offset: 0x008FB985
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x06022097 RID: 139415 RVA: 0x008FD79A File Offset: 0x008FB99A
		// (set) Token: 0x06022098 RID: 139416 RVA: 0x008FD7AE File Offset: 0x008FB9AE
		public unsafe UMaterial ViedoMaterialTranSlucentTwoSide
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x06022099 RID: 139417 RVA: 0x008FD7C3 File Offset: 0x008FB9C3
		// (set) Token: 0x0602209A RID: 139418 RVA: 0x008FD7D7 File Offset: 0x008FB9D7
		public unsafe UMaterial ViedoMaterialTranSlucent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0602209B RID: 139419 RVA: 0x008FD7EC File Offset: 0x008FB9EC
		// (set) Token: 0x0602209C RID: 139420 RVA: 0x008FD800 File Offset: 0x008FBA00
		public unsafe UMaterial ViedoMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0602209D RID: 139421 RVA: 0x008FD815 File Offset: 0x008FBA15
		// (set) Token: 0x0602209E RID: 139422 RVA: 0x008FD825 File Offset: 0x008FBA25
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0602209F RID: 139423 RVA: 0x008FD836 File Offset: 0x008FBA36
		// (set) Token: 0x060220A0 RID: 139424 RVA: 0x008FD846 File Offset: 0x008FBA46
		public unsafe float DarkIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x060220A1 RID: 139425 RVA: 0x008FD857 File Offset: 0x008FBA57
		// (set) Token: 0x060220A2 RID: 139426 RVA: 0x008FD867 File Offset: 0x008FBA67
		public unsafe int AoiDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x060220A3 RID: 139427 RVA: 0x008FD878 File Offset: 0x008FBA78
		// (set) Token: 0x060220A4 RID: 139428 RVA: 0x008FD888 File Offset: 0x008FBA88
		public unsafe bool Translucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x060220A5 RID: 139429 RVA: 0x008FD899 File Offset: 0x008FBA99
		// (set) Token: 0x060220A6 RID: 139430 RVA: 0x008FD8A9 File Offset: 0x008FBAA9
		public unsafe bool TwoSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x060220A7 RID: 139431 RVA: 0x008FD8BA File Offset: 0x008FBABA
		// (set) Token: 0x060220A8 RID: 139432 RVA: 0x008FD8CA File Offset: 0x008FBACA
		public unsafe float Opacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x060220A9 RID: 139433 RVA: 0x008FD8DB File Offset: 0x008FBADB
		// (set) Token: 0x060220AA RID: 139434 RVA: 0x008FD8EF File Offset: 0x008FBAEF
		public unsafe PDA_MediaPlayDataAsset_C MediaPlayDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_MediaPlayDataAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x060220AB RID: 139435 RVA: 0x008FD904 File Offset: 0x008FBB04
		// (set) Token: 0x060220AC RID: 139436 RVA: 0x008FD918 File Offset: 0x008FBB18
		public unsafe UMediaPlayer ShareMediaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x060220AD RID: 139437 RVA: 0x008FD92D File Offset: 0x008FBB2D
		// (set) Token: 0x060220AE RID: 139438 RVA: 0x008FD941 File Offset: 0x008FBB41
		public unsafe UMediaTexture ShareMediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + MediaPlayForModel_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x060220AF RID: 139439 RVA: 0x008FD956 File Offset: 0x008FBB56
		// (set) Token: 0x060220B0 RID: 139440 RVA: 0x008FD966 File Offset: 0x008FBB66
		public unsafe bool isOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x060220B1 RID: 139441 RVA: 0x008FD977 File Offset: 0x008FBB77
		// (set) Token: 0x060220B2 RID: 139442 RVA: 0x008FD987 File Offset: 0x008FBB87
		public unsafe bool DrawDebugAoi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x060220B3 RID: 139443 RVA: 0x008FD998 File Offset: 0x008FBB98
		// (set) Token: 0x060220B4 RID: 139444 RVA: 0x008FD9A8 File Offset: 0x008FBBA8
		public unsafe bool isStopOnHide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x060220B5 RID: 139445 RVA: 0x008FD9B9 File Offset: 0x008FBBB9
		// (set) Token: 0x060220B6 RID: 139446 RVA: 0x008FD9C9 File Offset: 0x008FBBC9
		public unsafe bool enableQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x060220B7 RID: 139447 RVA: 0x008FD9DC File Offset: 0x008FBBDC
		// (set) Token: 0x060220B8 RID: 139448 RVA: 0x008FDA15 File Offset: 0x008FBC15
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
					result = (this._QualityDistanceList = new TArray<int>(base.NativePtr + (IntPtr)MediaPlayForModel_C.__PropertyOffset_20, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.QualityDistanceList.CopyAssign(value);
			}
		}

		// Token: 0x060220B9 RID: 139449 RVA: 0x008FDA24 File Offset: 0x008FBC24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ShouldStopOnHide(ref bool ret)
		{
			MediaPlayForModel_C.__ShouldStopOnHide_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__ShouldStopOnHide_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_C.__ShouldStopOnHide_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ShouldStopOnHide_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x060220BA RID: 139450 RVA: 0x008FDA74 File Offset: 0x008FBC74
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetAoiRange(ref int ret)
		{
			MediaPlayForModel_C.__GetAoiRange_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__GetAoiRange_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(MediaPlayForModel_C.__GetAoiRange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ret = ret;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__GetAoiRange_NativeFunctionPtr, (void*)ptr);
			ret = ptr->ret;
		}

		// Token: 0x060220BB RID: 139451 RVA: 0x008FDAC3 File Offset: 0x008FBCC3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ReInit_NativeFunctionPtr, null);
		}

		// Token: 0x060220BC RID: 139452 RVA: 0x008FDAD7 File Offset: 0x008FBCD7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ConstructionMediaPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ConstructionMediaPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060220BD RID: 139453 RVA: 0x008FDAEB File Offset: 0x008FBCEB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__OpenSource_NativeFunctionPtr, null);
		}

		// Token: 0x060220BE RID: 139454 RVA: 0x008FDAFF File Offset: 0x008FBCFF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__CloseSource_NativeFunctionPtr, null);
		}

		// Token: 0x060220BF RID: 139455 RVA: 0x008FDB13 File Offset: 0x008FBD13
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TickOutside()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__TickOutside_NativeFunctionPtr, null);
		}

		// Token: 0x060220C0 RID: 139456 RVA: 0x008FDB27 File Offset: 0x008FBD27
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Pause()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__Pause_NativeFunctionPtr, null);
		}

		// Token: 0x060220C1 RID: 139457 RVA: 0x008FDB3B File Offset: 0x008FBD3B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Resume()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__Resume_NativeFunctionPtr, null);
		}

		// Token: 0x060220C2 RID: 139458 RVA: 0x008FDB4F File Offset: 0x008FBD4F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060220C3 RID: 139459 RVA: 0x008FDB63 File Offset: 0x008FBD63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060220C4 RID: 139460 RVA: 0x008FDB78 File Offset: 0x008FBD78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			MediaPlayForModel_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060220C5 RID: 139461 RVA: 0x008FDBC0 File Offset: 0x008FBDC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			MediaPlayForModel_C.__EditorTick_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(MediaPlayForModel_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060220C6 RID: 139462 RVA: 0x008FDC07 File Offset: 0x008FBE07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void EditorInit()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__EditorInit_NativeFunctionPtr, null);
		}

		// Token: 0x060220C7 RID: 139463 RVA: 0x008FDC1B File Offset: 0x008FBE1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void EditorInit_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_C.__EditorInit_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060220C8 RID: 139464 RVA: 0x008FDC30 File Offset: 0x008FBE30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Start()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__Start_NativeFunctionPtr, null);
		}

		// Token: 0x060220C9 RID: 139465 RVA: 0x008FDC44 File Offset: 0x008FBE44
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Stop()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__Stop_NativeFunctionPtr, null);
		}

		// Token: 0x060220CA RID: 139466 RVA: 0x008FDC58 File Offset: 0x008FBE58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060220CB RID: 139467 RVA: 0x008FDCA4 File Offset: 0x008FBEA4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(MediaPlayForModel_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(MediaPlayForModel_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, MediaPlayForModel_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060220CC RID: 139468 RVA: 0x008FDCF0 File Offset: 0x008FBEF0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PlaySound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__PlaySound_NativeFunctionPtr, null);
		}

		// Token: 0x060220CD RID: 139469 RVA: 0x008FDD04 File Offset: 0x008FBF04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, MediaPlayForModel_C.__CloseSound_NativeFunctionPtr, null);
		}

		// Token: 0x060220CE RID: 139470 RVA: 0x008FDD18 File Offset: 0x008FBF18
		protected MediaPlayForModel_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A7F RID: 68223
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/SceneViedoPlay/MediaPlayForModel.MediaPlayForModel_C";

		// Token: 0x04010A80 RID: 68224
		private static IntPtr _ClassPtr;

		// Token: 0x04010A81 RID: 68225
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A82 RID: 68226
		internal static int __PropertyOffset_1;

		// Token: 0x04010A83 RID: 68227
		internal static int __PropertyOffset_2;

		// Token: 0x04010A84 RID: 68228
		internal static int __PropertyOffset_3;

		// Token: 0x04010A85 RID: 68229
		internal static int __PropertyOffset_4;

		// Token: 0x04010A86 RID: 68230
		internal static int __PropertyOffset_5;

		// Token: 0x04010A87 RID: 68231
		internal static int __PropertyOffset_6;

		// Token: 0x04010A88 RID: 68232
		internal static int __PropertyOffset_7;

		// Token: 0x04010A89 RID: 68233
		internal static int __PropertyOffset_8;

		// Token: 0x04010A8A RID: 68234
		internal static int __PropertyOffset_9;

		// Token: 0x04010A8B RID: 68235
		internal static int __PropertyOffset_10;

		// Token: 0x04010A8C RID: 68236
		internal static int __PropertyOffset_11;

		// Token: 0x04010A8D RID: 68237
		internal static int __PropertyOffset_12;

		// Token: 0x04010A8E RID: 68238
		internal static int __PropertyOffset_13;

		// Token: 0x04010A8F RID: 68239
		internal static int __PropertyOffset_14;

		// Token: 0x04010A90 RID: 68240
		internal static int __PropertyOffset_15;

		// Token: 0x04010A91 RID: 68241
		internal static int __PropertyOffset_16;

		// Token: 0x04010A92 RID: 68242
		internal static int __PropertyOffset_17;

		// Token: 0x04010A93 RID: 68243
		internal static int __PropertyOffset_18;

		// Token: 0x04010A94 RID: 68244
		internal static int __PropertyOffset_19;

		// Token: 0x04010A95 RID: 68245
		internal static int __PropertyOffset_20;

		// Token: 0x04010A96 RID: 68246
		private TArray<int> _QualityDistanceList;

		// Token: 0x04010A97 RID: 68247
		private static IntPtr __ShouldStopOnHide_NativeFunctionPtr;

		// Token: 0x04010A98 RID: 68248
		private static IntPtr __GetAoiRange_NativeFunctionPtr;

		// Token: 0x04010A99 RID: 68249
		private static IntPtr __ReInit_NativeFunctionPtr;

		// Token: 0x04010A9A RID: 68250
		private static IntPtr __ConstructionMediaPlay_NativeFunctionPtr;

		// Token: 0x04010A9B RID: 68251
		private static IntPtr __OpenSource_NativeFunctionPtr;

		// Token: 0x04010A9C RID: 68252
		private static IntPtr __CloseSource_NativeFunctionPtr;

		// Token: 0x04010A9D RID: 68253
		private static IntPtr __TickOutside_NativeFunctionPtr;

		// Token: 0x04010A9E RID: 68254
		private static IntPtr __Pause_NativeFunctionPtr;

		// Token: 0x04010A9F RID: 68255
		private static IntPtr __Resume_NativeFunctionPtr;

		// Token: 0x04010AA0 RID: 68256
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010AA1 RID: 68257
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x04010AA2 RID: 68258
		private static IntPtr __EditorInit_NativeFunctionPtr;

		// Token: 0x04010AA3 RID: 68259
		private static IntPtr __Start_NativeFunctionPtr;

		// Token: 0x04010AA4 RID: 68260
		private static IntPtr __Stop_NativeFunctionPtr;

		// Token: 0x04010AA5 RID: 68261
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x04010AA6 RID: 68262
		private static IntPtr __PlaySound_NativeFunctionPtr;

		// Token: 0x04010AA7 RID: 68263
		private static IntPtr __CloseSound_NativeFunctionPtr;

		// Token: 0x02009D1C RID: 40220
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ShouldStopOnHide_FunctionParams
		{
			// Token: 0x04031456 RID: 201814
			[FieldOffset(0)]
			public bool ret;
		}

		// Token: 0x02009D1D RID: 40221
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAoiRange_FunctionParams
		{
			// Token: 0x04031457 RID: 201815
			[FieldOffset(0)]
			public int ret;
		}

		// Token: 0x02009D1E RID: 40222
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031458 RID: 201816
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009D1F RID: 40223
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x04031459 RID: 201817
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
