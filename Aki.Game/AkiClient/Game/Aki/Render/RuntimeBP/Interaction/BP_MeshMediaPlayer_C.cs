using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.SceneViedoPlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D17 RID: 15639
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_MeshMediaPlayer.BP_MeshMediaPlayer_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class BP_MeshMediaPlayer_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060257FD RID: 153597 RVA: 0x0095B6FC File Offset: 0x009598FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshMediaPlayer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_MeshMediaPlayer.BP_MeshMediaPlayer_C");
			}
			return BP_MeshMediaPlayer_C._ClassPtr;
		}

		// Token: 0x060257FE RID: 153598 RVA: 0x0095B720 File Offset: 0x00959920
		public BP_MeshMediaPlayer_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshMediaPlayer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060257FF RID: 153599 RVA: 0x0095B748 File Offset: 0x00959948
		[NullableContext(1)]
		public BP_MeshMediaPlayer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshMediaPlayer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CF2 RID: 19698
		// (get) Token: 0x06025800 RID: 153600 RVA: 0x0095B77B File Offset: 0x0095997B
		// (set) Token: 0x06025801 RID: 153601 RVA: 0x0095B78F File Offset: 0x0095998F
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CF3 RID: 19699
		// (get) Token: 0x06025802 RID: 153602 RVA: 0x0095B7A4 File Offset: 0x009599A4
		// (set) Token: 0x06025803 RID: 153603 RVA: 0x0095B7B8 File Offset: 0x009599B8
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004CF4 RID: 19700
		// (get) Token: 0x06025804 RID: 153604 RVA: 0x0095B7CD File Offset: 0x009599CD
		// (set) Token: 0x06025805 RID: 153605 RVA: 0x0095B7E1 File Offset: 0x009599E1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004CF5 RID: 19701
		// (get) Token: 0x06025806 RID: 153606 RVA: 0x0095B7F6 File Offset: 0x009599F6
		// (set) Token: 0x06025807 RID: 153607 RVA: 0x0095B806 File Offset: 0x00959A06
		public unsafe float MediaIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004CF6 RID: 19702
		// (get) Token: 0x06025808 RID: 153608 RVA: 0x0095B817 File Offset: 0x00959A17
		// (set) Token: 0x06025809 RID: 153609 RVA: 0x0095B827 File Offset: 0x00959A27
		public unsafe float MediaTransparency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004CF7 RID: 19703
		// (get) Token: 0x0602580A RID: 153610 RVA: 0x0095B838 File Offset: 0x00959A38
		// (set) Token: 0x0602580B RID: 153611 RVA: 0x0095B84C File Offset: 0x00959A4C
		public unsafe FColor MediaColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004CF8 RID: 19704
		// (get) Token: 0x0602580C RID: 153612 RVA: 0x0095B861 File Offset: 0x00959A61
		// (set) Token: 0x0602580D RID: 153613 RVA: 0x0095B875 File Offset: 0x00959A75
		public unsafe PDA_MediaPlayDataAsset_C MediaPlayDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_MediaPlayDataAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004CF9 RID: 19705
		// (get) Token: 0x0602580E RID: 153614 RVA: 0x0095B88A File Offset: 0x00959A8A
		// (set) Token: 0x0602580F RID: 153615 RVA: 0x0095B89E File Offset: 0x00959A9E
		public unsafe UMaterialInstance MediaMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004CFA RID: 19706
		// (get) Token: 0x06025810 RID: 153616 RVA: 0x0095B8B3 File Offset: 0x00959AB3
		// (set) Token: 0x06025811 RID: 153617 RVA: 0x0095B8C7 File Offset: 0x00959AC7
		public unsafe UMaterialInstanceDynamic MediaMaterial_Dynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004CFB RID: 19707
		// (get) Token: 0x06025812 RID: 153618 RVA: 0x0095B8DC File Offset: 0x00959ADC
		// (set) Token: 0x06025813 RID: 153619 RVA: 0x0095B8F0 File Offset: 0x00959AF0
		public unsafe UMediaTexture MediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004CFC RID: 19708
		// (get) Token: 0x06025814 RID: 153620 RVA: 0x0095B905 File Offset: 0x00959B05
		// (set) Token: 0x06025815 RID: 153621 RVA: 0x0095B919 File Offset: 0x00959B19
		public unsafe UMediaPlayer MeidaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004CFD RID: 19709
		// (get) Token: 0x06025816 RID: 153622 RVA: 0x0095B92E File Offset: 0x00959B2E
		// (set) Token: 0x06025817 RID: 153623 RVA: 0x0095B942 File Offset: 0x00959B42
		public unsafe FVector BackgroundUV_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004CFE RID: 19710
		// (get) Token: 0x06025818 RID: 153624 RVA: 0x0095B957 File Offset: 0x00959B57
		// (set) Token: 0x06025819 RID: 153625 RVA: 0x0095B96B File Offset: 0x00959B6B
		public unsafe FVector BackgroundUV_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004CFF RID: 19711
		// (get) Token: 0x0602581A RID: 153626 RVA: 0x0095B980 File Offset: 0x00959B80
		// (set) Token: 0x0602581B RID: 153627 RVA: 0x0095B994 File Offset: 0x00959B94
		public unsafe UTexture2D MainTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004D00 RID: 19712
		// (get) Token: 0x0602581C RID: 153628 RVA: 0x0095B9A9 File Offset: 0x00959BA9
		// (set) Token: 0x0602581D RID: 153629 RVA: 0x0095B9BD File Offset: 0x00959BBD
		public unsafe FVector ScreenUV_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004D01 RID: 19713
		// (get) Token: 0x0602581E RID: 153630 RVA: 0x0095B9D2 File Offset: 0x00959BD2
		// (set) Token: 0x0602581F RID: 153631 RVA: 0x0095B9E6 File Offset: 0x00959BE6
		public unsafe FVector ScreenUV_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004D02 RID: 19714
		// (get) Token: 0x06025820 RID: 153632 RVA: 0x0095B9FB File Offset: 0x00959BFB
		// (set) Token: 0x06025821 RID: 153633 RVA: 0x0095BA0B File Offset: 0x00959C0B
		public unsafe int NumberOfChunks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004D03 RID: 19715
		// (get) Token: 0x06025822 RID: 153634 RVA: 0x0095BA1C File Offset: 0x00959C1C
		// (set) Token: 0x06025823 RID: 153635 RVA: 0x0095BA2C File Offset: 0x00959C2C
		public unsafe int PlayingChunk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x06025824 RID: 153636 RVA: 0x0095BA3D File Offset: 0x00959C3D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LoadDA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__LoadDA_NativeFunctionPtr, null);
		}

		// Token: 0x06025825 RID: 153637 RVA: 0x0095BA51 File Offset: 0x00959C51
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReplayMedia()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__ReplayMedia_NativeFunctionPtr, null);
		}

		// Token: 0x06025826 RID: 153638 RVA: 0x0095BA65 File Offset: 0x00959C65
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__CloseSound_NativeFunctionPtr, null);
		}

		// Token: 0x06025827 RID: 153639 RVA: 0x0095BA79 File Offset: 0x00959C79
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__OpenSound_NativeFunctionPtr, null);
		}

		// Token: 0x06025828 RID: 153640 RVA: 0x0095BA8D File Offset: 0x00959C8D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseMedia()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__CloseMedia_NativeFunctionPtr, null);
		}

		// Token: 0x06025829 RID: 153641 RVA: 0x0095BAA1 File Offset: 0x00959CA1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenMedia()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__OpenMedia_NativeFunctionPtr, null);
		}

		// Token: 0x0602582A RID: 153642 RVA: 0x0095BAB5 File Offset: 0x00959CB5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602582B RID: 153643 RVA: 0x0095BAC9 File Offset: 0x00959CC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602582C RID: 153644 RVA: 0x0095BADE File Offset: 0x00959CDE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602582D RID: 153645 RVA: 0x0095BAF2 File Offset: 0x00959CF2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602582E RID: 153646 RVA: 0x0095BB08 File Offset: 0x00959D08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MeshMediaPlayer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshMediaPlayer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshMediaPlayer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshMediaPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602582F RID: 153647 RVA: 0x0095BB50 File Offset: 0x00959D50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MeshMediaPlayer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshMediaPlayer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshMediaPlayer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshMediaPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025830 RID: 153648 RVA: 0x0095BB97 File Offset: 0x00959D97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__OpenSource_NativeFunctionPtr, null);
		}

		// Token: 0x06025831 RID: 153649 RVA: 0x0095BBAB File Offset: 0x00959DAB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__CloseSource_NativeFunctionPtr, null);
		}

		// Token: 0x06025832 RID: 153650 RVA: 0x0095BBC0 File Offset: 0x00959DC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MeshMediaPlayer_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshMediaPlayer_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshMediaPlayer_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshMediaPlayer_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025833 RID: 153651 RVA: 0x0095BC08 File Offset: 0x00959E08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MeshMediaPlayer_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshMediaPlayer_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshMediaPlayer_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshMediaPlayer_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshMediaPlayer_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025834 RID: 153652 RVA: 0x0095BC4F File Offset: 0x00959E4F
		protected BP_MeshMediaPlayer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B6B RID: 76651
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_MeshMediaPlayer.BP_MeshMediaPlayer_C";

		// Token: 0x04012B6C RID: 76652
		private static IntPtr _ClassPtr;

		// Token: 0x04012B6D RID: 76653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B6E RID: 76654
		internal static int __PropertyOffset_1;

		// Token: 0x04012B6F RID: 76655
		internal static int __PropertyOffset_2;

		// Token: 0x04012B70 RID: 76656
		internal static int __PropertyOffset_3;

		// Token: 0x04012B71 RID: 76657
		internal static int __PropertyOffset_4;

		// Token: 0x04012B72 RID: 76658
		internal static int __PropertyOffset_5;

		// Token: 0x04012B73 RID: 76659
		internal static int __PropertyOffset_6;

		// Token: 0x04012B74 RID: 76660
		internal static int __PropertyOffset_7;

		// Token: 0x04012B75 RID: 76661
		internal static int __PropertyOffset_8;

		// Token: 0x04012B76 RID: 76662
		internal static int __PropertyOffset_9;

		// Token: 0x04012B77 RID: 76663
		internal static int __PropertyOffset_10;

		// Token: 0x04012B78 RID: 76664
		internal static int __PropertyOffset_11;

		// Token: 0x04012B79 RID: 76665
		internal static int __PropertyOffset_12;

		// Token: 0x04012B7A RID: 76666
		internal static int __PropertyOffset_13;

		// Token: 0x04012B7B RID: 76667
		internal static int __PropertyOffset_14;

		// Token: 0x04012B7C RID: 76668
		internal static int __PropertyOffset_15;

		// Token: 0x04012B7D RID: 76669
		internal static int __PropertyOffset_16;

		// Token: 0x04012B7E RID: 76670
		internal static int __PropertyOffset_17;

		// Token: 0x04012B7F RID: 76671
		internal static int __PropertyOffset_18;

		// Token: 0x04012B80 RID: 76672
		private static IntPtr __LoadDA_NativeFunctionPtr;

		// Token: 0x04012B81 RID: 76673
		private static IntPtr __ReplayMedia_NativeFunctionPtr;

		// Token: 0x04012B82 RID: 76674
		private static IntPtr __CloseSound_NativeFunctionPtr;

		// Token: 0x04012B83 RID: 76675
		private static IntPtr __OpenSound_NativeFunctionPtr;

		// Token: 0x04012B84 RID: 76676
		private static IntPtr __CloseMedia_NativeFunctionPtr;

		// Token: 0x04012B85 RID: 76677
		private static IntPtr __OpenMedia_NativeFunctionPtr;

		// Token: 0x04012B86 RID: 76678
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012B87 RID: 76679
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012B88 RID: 76680
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012B89 RID: 76681
		private static IntPtr __OpenSource_NativeFunctionPtr;

		// Token: 0x04012B8A RID: 76682
		private static IntPtr __CloseSource_NativeFunctionPtr;

		// Token: 0x04012B8B RID: 76683
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A005 RID: 40965
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031AA0 RID: 203424
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A006 RID: 40966
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031AA1 RID: 203425
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
