using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence
{
	// Token: 0x02003AE0 RID: 15072
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/BP_StillFramePicturePostProcess.BP_StillFramePicturePostProcess_C")]
	[UnrealStructLayout(1536, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1532)]
	public class BP_StillFramePicturePostProcess_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602090F RID: 133391 RVA: 0x008D6854 File Offset: 0x008D4A54
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_StillFramePicturePostProcess_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/BP_StillFramePicturePostProcess.BP_StillFramePicturePostProcess_C");
			}
			return BP_StillFramePicturePostProcess_C._ClassPtr;
		}

		// Token: 0x06020910 RID: 133392 RVA: 0x008D6878 File Offset: 0x008D4A78
		public BP_StillFramePicturePostProcess_C() : this(BuiltinUtils.AllocNativeUObject(BP_StillFramePicturePostProcess_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020911 RID: 133393 RVA: 0x008D68A0 File Offset: 0x008D4AA0
		[NullableContext(1)]
		public BP_StillFramePicturePostProcess_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_StillFramePicturePostProcess_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003163 RID: 12643
		// (get) Token: 0x06020912 RID: 133394 RVA: 0x008D68D3 File Offset: 0x008D4AD3
		// (set) Token: 0x06020913 RID: 133395 RVA: 0x008D68E7 File Offset: 0x008D4AE7
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003164 RID: 12644
		// (get) Token: 0x06020914 RID: 133396 RVA: 0x008D68FC File Offset: 0x008D4AFC
		// (set) Token: 0x06020915 RID: 133397 RVA: 0x008D6910 File Offset: 0x008D4B10
		public unsafe UMaterialInterface MainMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003165 RID: 12645
		// (get) Token: 0x06020916 RID: 133398 RVA: 0x008D6925 File Offset: 0x008D4B25
		// (set) Token: 0x06020917 RID: 133399 RVA: 0x008D6939 File Offset: 0x008D4B39
		public unsafe UMaterialInstanceDynamic DynamicMaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003166 RID: 12646
		// (get) Token: 0x06020918 RID: 133400 RVA: 0x008D694E File Offset: 0x008D4B4E
		// (set) Token: 0x06020919 RID: 133401 RVA: 0x008D6962 File Offset: 0x008D4B62
		public unsafe UTexture FirstTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003167 RID: 12647
		// (get) Token: 0x0602091A RID: 133402 RVA: 0x008D6977 File Offset: 0x008D4B77
		// (set) Token: 0x0602091B RID: 133403 RVA: 0x008D698B File Offset: 0x008D4B8B
		public unsafe UTexture SecondTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_StillFramePicturePostProcess_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17003168 RID: 12648
		// (get) Token: 0x0602091C RID: 133404 RVA: 0x008D69A0 File Offset: 0x008D4BA0
		// (set) Token: 0x0602091D RID: 133405 RVA: 0x008D69B0 File Offset: 0x008D4BB0
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0602091E RID: 133406 RVA: 0x008D69C1 File Offset: 0x008D4BC1
		// (set) Token: 0x0602091F RID: 133407 RVA: 0x008D69D1 File Offset: 0x008D4BD1
		public unsafe float First_V_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x06020920 RID: 133408 RVA: 0x008D69E2 File Offset: 0x008D4BE2
		// (set) Token: 0x06020921 RID: 133409 RVA: 0x008D69F2 File Offset: 0x008D4BF2
		public unsafe float First_U_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x06020922 RID: 133410 RVA: 0x008D6A03 File Offset: 0x008D4C03
		// (set) Token: 0x06020923 RID: 133411 RVA: 0x008D6A13 File Offset: 0x008D4C13
		public unsafe float First_UV_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x06020924 RID: 133412 RVA: 0x008D6A24 File Offset: 0x008D4C24
		// (set) Token: 0x06020925 RID: 133413 RVA: 0x008D6A34 File Offset: 0x008D4C34
		public unsafe float First_Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x06020926 RID: 133414 RVA: 0x008D6A45 File Offset: 0x008D4C45
		// (set) Token: 0x06020927 RID: 133415 RVA: 0x008D6A55 File Offset: 0x008D4C55
		public unsafe float Second_U_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x06020928 RID: 133416 RVA: 0x008D6A66 File Offset: 0x008D4C66
		// (set) Token: 0x06020929 RID: 133417 RVA: 0x008D6A76 File Offset: 0x008D4C76
		public unsafe float Second_V_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0602092A RID: 133418 RVA: 0x008D6A87 File Offset: 0x008D4C87
		// (set) Token: 0x0602092B RID: 133419 RVA: 0x008D6A97 File Offset: 0x008D4C97
		public unsafe float Second_UV_Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0602092C RID: 133420 RVA: 0x008D6AA8 File Offset: 0x008D4CA8
		// (set) Token: 0x0602092D RID: 133421 RVA: 0x008D6AB8 File Offset: 0x008D4CB8
		public unsafe float Second_Saturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_StillFramePicturePostProcess_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x0602092E RID: 133422 RVA: 0x008D6AC9 File Offset: 0x008D4CC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StillFramePicturePostProcess_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602092F RID: 133423 RVA: 0x008D6ADD File Offset: 0x008D4CDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StillFramePicturePostProcess_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020930 RID: 133424 RVA: 0x008D6AF4 File Offset: 0x008D4CF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_StillFramePicturePostProcess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StillFramePicturePostProcess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StillFramePicturePostProcess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StillFramePicturePostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StillFramePicturePostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020931 RID: 133425 RVA: 0x008D6B3C File Offset: 0x008D4D3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_StillFramePicturePostProcess_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_StillFramePicturePostProcess_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StillFramePicturePostProcess_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StillFramePicturePostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StillFramePicturePostProcess_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020932 RID: 133426 RVA: 0x008D6B83 File Offset: 0x008D4D83
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StillFramePicturePostProcess_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020933 RID: 133427 RVA: 0x008D6B97 File Offset: 0x008D4D97
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StillFramePicturePostProcess_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020934 RID: 133428 RVA: 0x008D6BAC File Offset: 0x008D4DAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_StillFramePicturePostProcess_C.__EditorTick_FunctionParams* ptr = stackalloc BP_StillFramePicturePostProcess_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StillFramePicturePostProcess_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StillFramePicturePostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_StillFramePicturePostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020935 RID: 133429 RVA: 0x008D6BF4 File Offset: 0x008D4DF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_StillFramePicturePostProcess_C.__EditorTick_FunctionParams* ptr = stackalloc BP_StillFramePicturePostProcess_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_StillFramePicturePostProcess_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_StillFramePicturePostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_StillFramePicturePostProcess_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020936 RID: 133430 RVA: 0x008D6C3B File Offset: 0x008D4E3B
		protected BP_StillFramePicturePostProcess_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC93 RID: 64659
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/BP_StillFramePicturePostProcess.BP_StillFramePicturePostProcess_C";

		// Token: 0x0400FC94 RID: 64660
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC95 RID: 64661
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC96 RID: 64662
		internal static int __PropertyOffset_1;

		// Token: 0x0400FC97 RID: 64663
		internal static int __PropertyOffset_2;

		// Token: 0x0400FC98 RID: 64664
		internal static int __PropertyOffset_3;

		// Token: 0x0400FC99 RID: 64665
		internal static int __PropertyOffset_4;

		// Token: 0x0400FC9A RID: 64666
		internal static int __PropertyOffset_5;

		// Token: 0x0400FC9B RID: 64667
		internal static int __PropertyOffset_6;

		// Token: 0x0400FC9C RID: 64668
		internal static int __PropertyOffset_7;

		// Token: 0x0400FC9D RID: 64669
		internal static int __PropertyOffset_8;

		// Token: 0x0400FC9E RID: 64670
		internal static int __PropertyOffset_9;

		// Token: 0x0400FC9F RID: 64671
		internal static int __PropertyOffset_10;

		// Token: 0x0400FCA0 RID: 64672
		internal static int __PropertyOffset_11;

		// Token: 0x0400FCA1 RID: 64673
		internal static int __PropertyOffset_12;

		// Token: 0x0400FCA2 RID: 64674
		internal static int __PropertyOffset_13;

		// Token: 0x0400FCA3 RID: 64675
		internal static int __PropertyOffset_14;

		// Token: 0x0400FCA4 RID: 64676
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FCA5 RID: 64677
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FCA6 RID: 64678
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FCA7 RID: 64679
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009BDE RID: 39902
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031272 RID: 201330
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BDF RID: 39903
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031273 RID: 201331
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
