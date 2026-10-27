using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D19 RID: 15641
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_MeshTexturePlayer.BP_MeshTexturePlayer_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class BP_MeshTexturePlayer_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602586D RID: 153709 RVA: 0x0095C1B4 File Offset: 0x0095A3B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshTexturePlayer_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_MeshTexturePlayer.BP_MeshTexturePlayer_C");
			}
			return BP_MeshTexturePlayer_C._ClassPtr;
		}

		// Token: 0x0602586E RID: 153710 RVA: 0x0095C1D8 File Offset: 0x0095A3D8
		public BP_MeshTexturePlayer_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshTexturePlayer_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602586F RID: 153711 RVA: 0x0095C200 File Offset: 0x0095A400
		[NullableContext(1)]
		public BP_MeshTexturePlayer_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshTexturePlayer_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D16 RID: 19734
		// (get) Token: 0x06025870 RID: 153712 RVA: 0x0095C233 File Offset: 0x0095A433
		// (set) Token: 0x06025871 RID: 153713 RVA: 0x0095C247 File Offset: 0x0095A447
		public unsafe UAkComponent Ak
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004D17 RID: 19735
		// (get) Token: 0x06025872 RID: 153714 RVA: 0x0095C25C File Offset: 0x0095A45C
		// (set) Token: 0x06025873 RID: 153715 RVA: 0x0095C270 File Offset: 0x0095A470
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004D18 RID: 19736
		// (get) Token: 0x06025874 RID: 153716 RVA: 0x0095C285 File Offset: 0x0095A485
		// (set) Token: 0x06025875 RID: 153717 RVA: 0x0095C299 File Offset: 0x0095A499
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004D19 RID: 19737
		// (get) Token: 0x06025876 RID: 153718 RVA: 0x0095C2AE File Offset: 0x0095A4AE
		// (set) Token: 0x06025877 RID: 153719 RVA: 0x0095C2BE File Offset: 0x0095A4BE
		public unsafe float MediaIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004D1A RID: 19738
		// (get) Token: 0x06025878 RID: 153720 RVA: 0x0095C2CF File Offset: 0x0095A4CF
		// (set) Token: 0x06025879 RID: 153721 RVA: 0x0095C2DF File Offset: 0x0095A4DF
		public unsafe float GlitchIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004D1B RID: 19739
		// (get) Token: 0x0602587A RID: 153722 RVA: 0x0095C2F0 File Offset: 0x0095A4F0
		// (set) Token: 0x0602587B RID: 153723 RVA: 0x0095C304 File Offset: 0x0095A504
		public unsafe UStaticMesh ActorMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17004D1C RID: 19740
		// (get) Token: 0x0602587C RID: 153724 RVA: 0x0095C319 File Offset: 0x0095A519
		// (set) Token: 0x0602587D RID: 153725 RVA: 0x0095C329 File Offset: 0x0095A529
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004D1D RID: 19741
		// (get) Token: 0x0602587E RID: 153726 RVA: 0x0095C33A File Offset: 0x0095A53A
		// (set) Token: 0x0602587F RID: 153727 RVA: 0x0095C34E File Offset: 0x0095A54E
		public unsafe UTexture2D ScreenTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004D1E RID: 19742
		// (get) Token: 0x06025880 RID: 153728 RVA: 0x0095C363 File Offset: 0x0095A563
		// (set) Token: 0x06025881 RID: 153729 RVA: 0x0095C377 File Offset: 0x0095A577
		public unsafe FVector ScreenUV_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004D1F RID: 19743
		// (get) Token: 0x06025882 RID: 153730 RVA: 0x0095C38C File Offset: 0x0095A58C
		// (set) Token: 0x06025883 RID: 153731 RVA: 0x0095C3A0 File Offset: 0x0095A5A0
		public unsafe FVector ScreenUV_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004D20 RID: 19744
		// (get) Token: 0x06025884 RID: 153732 RVA: 0x0095C3B5 File Offset: 0x0095A5B5
		// (set) Token: 0x06025885 RID: 153733 RVA: 0x0095C3C9 File Offset: 0x0095A5C9
		public unsafe UMaterialInstance MediaMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17004D21 RID: 19745
		// (get) Token: 0x06025886 RID: 153734 RVA: 0x0095C3DE File Offset: 0x0095A5DE
		// (set) Token: 0x06025887 RID: 153735 RVA: 0x0095C3F2 File Offset: 0x0095A5F2
		public unsafe UMaterialInstanceDynamic MediaMaterial_Dynamic
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17004D22 RID: 19746
		// (get) Token: 0x06025888 RID: 153736 RVA: 0x0095C407 File Offset: 0x0095A607
		// (set) Token: 0x06025889 RID: 153737 RVA: 0x0095C41B File Offset: 0x0095A61B
		public unsafe UTexture2D MainTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_MeshTexturePlayer_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17004D23 RID: 19747
		// (get) Token: 0x0602588A RID: 153738 RVA: 0x0095C430 File Offset: 0x0095A630
		// (set) Token: 0x0602588B RID: 153739 RVA: 0x0095C444 File Offset: 0x0095A644
		public unsafe FVector BackgroundUV_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004D24 RID: 19748
		// (get) Token: 0x0602588C RID: 153740 RVA: 0x0095C459 File Offset: 0x0095A659
		// (set) Token: 0x0602588D RID: 153741 RVA: 0x0095C46D File Offset: 0x0095A66D
		public unsafe FVector BackgroundUV_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17004D25 RID: 19749
		// (get) Token: 0x0602588E RID: 153742 RVA: 0x0095C482 File Offset: 0x0095A682
		// (set) Token: 0x0602588F RID: 153743 RVA: 0x0095C492 File Offset: 0x0095A692
		public unsafe int NumberOfChunks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17004D26 RID: 19750
		// (get) Token: 0x06025890 RID: 153744 RVA: 0x0095C4A3 File Offset: 0x0095A6A3
		// (set) Token: 0x06025891 RID: 153745 RVA: 0x0095C4B3 File Offset: 0x0095A6B3
		public unsafe int PlayingChunk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_MeshTexturePlayer_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x06025892 RID: 153746 RVA: 0x0095C4C4 File Offset: 0x0095A6C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshTexturePlayer_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025893 RID: 153747 RVA: 0x0095C4D8 File Offset: 0x0095A6D8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshTexturePlayer_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025894 RID: 153748 RVA: 0x0095C4F0 File Offset: 0x0095A6F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_MeshTexturePlayer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshTexturePlayer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshTexturePlayer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshTexturePlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshTexturePlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025895 RID: 153749 RVA: 0x0095C538 File Offset: 0x0095A738
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_MeshTexturePlayer_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_MeshTexturePlayer_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshTexturePlayer_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshTexturePlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshTexturePlayer_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025896 RID: 153750 RVA: 0x0095C580 File Offset: 0x0095A780
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_MeshTexturePlayer_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshTexturePlayer_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshTexturePlayer_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshTexturePlayer_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_MeshTexturePlayer_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025897 RID: 153751 RVA: 0x0095C5C8 File Offset: 0x0095A7C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_MeshTexturePlayer_C.__EditorTick_FunctionParams* ptr = stackalloc BP_MeshTexturePlayer_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_MeshTexturePlayer_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_MeshTexturePlayer_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_MeshTexturePlayer_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025898 RID: 153752 RVA: 0x0095C60F File Offset: 0x0095A80F
		protected BP_MeshTexturePlayer_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BAD RID: 76717
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_MeshTexturePlayer.BP_MeshTexturePlayer_C";

		// Token: 0x04012BAE RID: 76718
		private static IntPtr _ClassPtr;

		// Token: 0x04012BAF RID: 76719
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BB0 RID: 76720
		internal static int __PropertyOffset_1;

		// Token: 0x04012BB1 RID: 76721
		internal static int __PropertyOffset_2;

		// Token: 0x04012BB2 RID: 76722
		internal static int __PropertyOffset_3;

		// Token: 0x04012BB3 RID: 76723
		internal static int __PropertyOffset_4;

		// Token: 0x04012BB4 RID: 76724
		internal static int __PropertyOffset_5;

		// Token: 0x04012BB5 RID: 76725
		internal static int __PropertyOffset_6;

		// Token: 0x04012BB6 RID: 76726
		internal static int __PropertyOffset_7;

		// Token: 0x04012BB7 RID: 76727
		internal static int __PropertyOffset_8;

		// Token: 0x04012BB8 RID: 76728
		internal static int __PropertyOffset_9;

		// Token: 0x04012BB9 RID: 76729
		internal static int __PropertyOffset_10;

		// Token: 0x04012BBA RID: 76730
		internal static int __PropertyOffset_11;

		// Token: 0x04012BBB RID: 76731
		internal static int __PropertyOffset_12;

		// Token: 0x04012BBC RID: 76732
		internal static int __PropertyOffset_13;

		// Token: 0x04012BBD RID: 76733
		internal static int __PropertyOffset_14;

		// Token: 0x04012BBE RID: 76734
		internal static int __PropertyOffset_15;

		// Token: 0x04012BBF RID: 76735
		internal static int __PropertyOffset_16;

		// Token: 0x04012BC0 RID: 76736
		internal static int __PropertyOffset_17;

		// Token: 0x04012BC1 RID: 76737
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012BC2 RID: 76738
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012BC3 RID: 76739
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x0200A009 RID: 40969
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031AA4 RID: 203428
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x0200A00A RID: 40970
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031AA5 RID: 203429
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
