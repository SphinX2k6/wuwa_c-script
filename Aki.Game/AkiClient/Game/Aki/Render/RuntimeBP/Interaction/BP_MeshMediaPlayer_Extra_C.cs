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
	// Token: 0x02003D18 RID: 15640
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_MeshMediaPlayer_Extra.BP_MeshMediaPlayer_Extra_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class BP_MeshMediaPlayer_Extra_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025835 RID: 153653 RVA: 0x0095BC58 File Offset: 0x00959E58
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshMediaPlayer_Extra_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_MeshMediaPlayer_Extra.BP_MeshMediaPlayer_Extra_C");
			}
			return BP_MeshMediaPlayer_Extra_C._ClassPtr;
		}

		// Token: 0x06025836 RID: 153654 RVA: 0x0095BC7C File Offset: 0x00959E7C
		public BP_MeshMediaPlayer_Extra_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshMediaPlayer_Extra_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025837 RID: 153655 RVA: 0x0095BCA4 File Offset: 0x00959EA4
		[NullableContext(1)]
		public BP_MeshMediaPlayer_Extra_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshMediaPlayer_Extra_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D04 RID: 19716
		// (get) Token: 0x06025838 RID: 153656 RVA: 0x0095BCD7 File Offset: 0x00959ED7
		// (set) Token: 0x06025839 RID: 153657 RVA: 0x0095BCEB File Offset: 0x00959EEB
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004D05 RID: 19717
		// (get) Token: 0x0602583A RID: 153658 RVA: 0x0095BD00 File Offset: 0x00959F00
		// (set) Token: 0x0602583B RID: 153659 RVA: 0x0095BD14 File Offset: 0x00959F14
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004D06 RID: 19718
		// (get) Token: 0x0602583C RID: 153660 RVA: 0x0095BD29 File Offset: 0x00959F29
		// (set) Token: 0x0602583D RID: 153661 RVA: 0x0095BD3D File Offset: 0x00959F3D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004D07 RID: 19719
		// (get) Token: 0x0602583E RID: 153662 RVA: 0x0095BD52 File Offset: 0x00959F52
		// (set) Token: 0x0602583F RID: 153663 RVA: 0x0095BD62 File Offset: 0x00959F62
		public unsafe float MediaIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004D08 RID: 19720
		// (get) Token: 0x06025840 RID: 153664 RVA: 0x0095BD73 File Offset: 0x00959F73
		// (set) Token: 0x06025841 RID: 153665 RVA: 0x0095BD83 File Offset: 0x00959F83
		public unsafe float MediaTransparency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004D09 RID: 19721
		// (get) Token: 0x06025842 RID: 153666 RVA: 0x0095BD94 File Offset: 0x00959F94
		// (set) Token: 0x06025843 RID: 153667 RVA: 0x0095BDA8 File Offset: 0x00959FA8
		public unsafe FColor MediaColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004D0A RID: 19722
		// (get) Token: 0x06025844 RID: 153668 RVA: 0x0095BDBD File Offset: 0x00959FBD
		// (set) Token: 0x06025845 RID: 153669 RVA: 0x0095BDD1 File Offset: 0x00959FD1
		public unsafe PDA_MediaPlayDataAsset_C MediaPlayDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_MediaPlayDataAsset_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004D0B RID: 19723
		// (get) Token: 0x06025846 RID: 153670 RVA: 0x0095BDE6 File Offset: 0x00959FE6
		// (set) Token: 0x06025847 RID: 153671 RVA: 0x0095BDFA File Offset: 0x00959FFA
		public unsafe UMaterialInstance MediaMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004D0C RID: 19724
		// (get) Token: 0x06025848 RID: 153672 RVA: 0x0095BE0F File Offset: 0x0095A00F
		// (set) Token: 0x06025849 RID: 153673 RVA: 0x0095BE23 File Offset: 0x0095A023
		public unsafe UMaterialInstanceDynamic MediaMaterial_Dynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17004D0D RID: 19725
		// (get) Token: 0x0602584A RID: 153674 RVA: 0x0095BE38 File Offset: 0x0095A038
		// (set) Token: 0x0602584B RID: 153675 RVA: 0x0095BE4C File Offset: 0x0095A04C
		public unsafe UMediaTexture MediaTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004D0E RID: 19726
		// (get) Token: 0x0602584C RID: 153676 RVA: 0x0095BE61 File Offset: 0x0095A061
		// (set) Token: 0x0602584D RID: 153677 RVA: 0x0095BE75 File Offset: 0x0095A075
		public unsafe UMediaPlayer MeidaPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004D0F RID: 19727
		// (get) Token: 0x0602584E RID: 153678 RVA: 0x0095BE8A File Offset: 0x0095A08A
		// (set) Token: 0x0602584F RID: 153679 RVA: 0x0095BE9E File Offset: 0x0095A09E
		public unsafe FVector BackgroundUV_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004D10 RID: 19728
		// (get) Token: 0x06025850 RID: 153680 RVA: 0x0095BEB3 File Offset: 0x0095A0B3
		// (set) Token: 0x06025851 RID: 153681 RVA: 0x0095BEC7 File Offset: 0x0095A0C7
		public unsafe FVector BackgroundUV_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004D11 RID: 19729
		// (get) Token: 0x06025852 RID: 153682 RVA: 0x0095BEDC File Offset: 0x0095A0DC
		// (set) Token: 0x06025853 RID: 153683 RVA: 0x0095BEF0 File Offset: 0x0095A0F0
		public unsafe UTexture2D MainTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshMediaPlayer_Extra_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004D12 RID: 19730
		// (get) Token: 0x06025854 RID: 153684 RVA: 0x0095BF05 File Offset: 0x0095A105
		// (set) Token: 0x06025855 RID: 153685 RVA: 0x0095BF19 File Offset: 0x0095A119
		public unsafe FVector ScreenUV_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004D13 RID: 19731
		// (get) Token: 0x06025856 RID: 153686 RVA: 0x0095BF2E File Offset: 0x0095A12E
		// (set) Token: 0x06025857 RID: 153687 RVA: 0x0095BF42 File Offset: 0x0095A142
		public unsafe FVector ScreenUV_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004D14 RID: 19732
		// (get) Token: 0x06025858 RID: 153688 RVA: 0x0095BF57 File Offset: 0x0095A157
		// (set) Token: 0x06025859 RID: 153689 RVA: 0x0095BF67 File Offset: 0x0095A167
		public unsafe int NumberOfChunks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004D15 RID: 19733
		// (get) Token: 0x0602585A RID: 153690 RVA: 0x0095BF78 File Offset: 0x0095A178
		// (set) Token: 0x0602585B RID: 153691 RVA: 0x0095BF88 File Offset: 0x0095A188
		public unsafe int PlayingChunk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshMediaPlayer_Extra_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x0602585C RID: 153692 RVA: 0x0095BF99 File Offset: 0x0095A199
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReplayMedia()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__ReplayMedia_NativeFunctionPtr, null);
		}

		// Token: 0x0602585D RID: 153693 RVA: 0x0095BFAD File Offset: 0x0095A1AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void LoadDA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__LoadDA_NativeFunctionPtr, null);
		}

		// Token: 0x0602585E RID: 153694 RVA: 0x0095BFC1 File Offset: 0x0095A1C1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__CloseSound_NativeFunctionPtr, null);
		}

		// Token: 0x0602585F RID: 153695 RVA: 0x0095BFD5 File Offset: 0x0095A1D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenSound()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__OpenSound_NativeFunctionPtr, null);
		}

		// Token: 0x06025860 RID: 153696 RVA: 0x0095BFE9 File Offset: 0x0095A1E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseMedia()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__CloseMedia_NativeFunctionPtr, null);
		}

		// Token: 0x06025861 RID: 153697 RVA: 0x0095BFFD File Offset: 0x0095A1FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenMedia()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__OpenMedia_NativeFunctionPtr, null);
		}

		// Token: 0x06025862 RID: 153698 RVA: 0x0095C011 File Offset: 0x0095A211
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025863 RID: 153699 RVA: 0x0095C025 File Offset: 0x0095A225
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025864 RID: 153700 RVA: 0x0095C03A File Offset: 0x0095A23A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025865 RID: 153701 RVA: 0x0095C04E File Offset: 0x0095A24E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025866 RID: 153702 RVA: 0x0095C064 File Offset: 0x0095A264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MeshMediaPlayer_Extra_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshMediaPlayer_Extra_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshMediaPlayer_Extra_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshMediaPlayer_Extra_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025867 RID: 153703 RVA: 0x0095C0AC File Offset: 0x0095A2AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MeshMediaPlayer_Extra_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshMediaPlayer_Extra_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshMediaPlayer_Extra_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshMediaPlayer_Extra_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025868 RID: 153704 RVA: 0x0095C0F3 File Offset: 0x0095A2F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OpenSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__OpenSource_NativeFunctionPtr, null);
		}

		// Token: 0x06025869 RID: 153705 RVA: 0x0095C107 File Offset: 0x0095A307
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CloseSource()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__CloseSource_NativeFunctionPtr, null);
		}

		// Token: 0x0602586A RID: 153706 RVA: 0x0095C11C File Offset: 0x0095A31C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MeshMediaPlayer_Extra_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshMediaPlayer_Extra_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshMediaPlayer_Extra_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshMediaPlayer_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602586B RID: 153707 RVA: 0x0095C164 File Offset: 0x0095A364
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MeshMediaPlayer_Extra_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshMediaPlayer_Extra_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshMediaPlayer_Extra_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshMediaPlayer_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshMediaPlayer_Extra_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602586C RID: 153708 RVA: 0x0095C1AB File Offset: 0x0095A3AB
		protected BP_MeshMediaPlayer_Extra_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B8C RID: 76684
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_MeshMediaPlayer_Extra.BP_MeshMediaPlayer_Extra_C";

		// Token: 0x04012B8D RID: 76685
		private static IntPtr _ClassPtr;

		// Token: 0x04012B8E RID: 76686
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B8F RID: 76687
		internal static int __PropertyOffset_1;

		// Token: 0x04012B90 RID: 76688
		internal static int __PropertyOffset_2;

		// Token: 0x04012B91 RID: 76689
		internal static int __PropertyOffset_3;

		// Token: 0x04012B92 RID: 76690
		internal static int __PropertyOffset_4;

		// Token: 0x04012B93 RID: 76691
		internal static int __PropertyOffset_5;

		// Token: 0x04012B94 RID: 76692
		internal static int __PropertyOffset_6;

		// Token: 0x04012B95 RID: 76693
		internal static int __PropertyOffset_7;

		// Token: 0x04012B96 RID: 76694
		internal static int __PropertyOffset_8;

		// Token: 0x04012B97 RID: 76695
		internal static int __PropertyOffset_9;

		// Token: 0x04012B98 RID: 76696
		internal static int __PropertyOffset_10;

		// Token: 0x04012B99 RID: 76697
		internal static int __PropertyOffset_11;

		// Token: 0x04012B9A RID: 76698
		internal static int __PropertyOffset_12;

		// Token: 0x04012B9B RID: 76699
		internal static int __PropertyOffset_13;

		// Token: 0x04012B9C RID: 76700
		internal static int __PropertyOffset_14;

		// Token: 0x04012B9D RID: 76701
		internal static int __PropertyOffset_15;

		// Token: 0x04012B9E RID: 76702
		internal static int __PropertyOffset_16;

		// Token: 0x04012B9F RID: 76703
		internal static int __PropertyOffset_17;

		// Token: 0x04012BA0 RID: 76704
		internal static int __PropertyOffset_18;

		// Token: 0x04012BA1 RID: 76705
		private static IntPtr __ReplayMedia_NativeFunctionPtr;

		// Token: 0x04012BA2 RID: 76706
		private static IntPtr __LoadDA_NativeFunctionPtr;

		// Token: 0x04012BA3 RID: 76707
		private static IntPtr __CloseSound_NativeFunctionPtr;

		// Token: 0x04012BA4 RID: 76708
		private static IntPtr __OpenSound_NativeFunctionPtr;

		// Token: 0x04012BA5 RID: 76709
		private static IntPtr __CloseMedia_NativeFunctionPtr;

		// Token: 0x04012BA6 RID: 76710
		private static IntPtr __OpenMedia_NativeFunctionPtr;

		// Token: 0x04012BA7 RID: 76711
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012BA8 RID: 76712
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012BA9 RID: 76713
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012BAA RID: 76714
		private static IntPtr __OpenSource_NativeFunctionPtr;

		// Token: 0x04012BAB RID: 76715
		private static IntPtr __CloseSource_NativeFunctionPtr;

		// Token: 0x04012BAC RID: 76716
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A007 RID: 40967
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031AA2 RID: 203426
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A008 RID: 40968
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031AA3 RID: 203427
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
