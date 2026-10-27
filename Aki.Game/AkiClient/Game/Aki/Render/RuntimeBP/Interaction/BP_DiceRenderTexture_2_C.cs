using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D10 RID: 15632
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceRenderTexture_2.BP_DiceRenderTexture_2_C")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class BP_DiceRenderTexture_2_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602575B RID: 153435 RVA: 0x0095A57B File Offset: 0x0095877B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DiceRenderTexture_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceRenderTexture_2.BP_DiceRenderTexture_2_C");
			}
			return BP_DiceRenderTexture_2_C._ClassPtr;
		}

		// Token: 0x0602575C RID: 153436 RVA: 0x0095A5A0 File Offset: 0x009587A0
		public BP_DiceRenderTexture_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_DiceRenderTexture_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602575D RID: 153437 RVA: 0x0095A5C8 File Offset: 0x009587C8
		[NullableContext(1)]
		public BP_DiceRenderTexture_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DiceRenderTexture_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CC6 RID: 19654
		// (get) Token: 0x0602575E RID: 153438 RVA: 0x0095A5FB File Offset: 0x009587FB
		// (set) Token: 0x0602575F RID: 153439 RVA: 0x0095A60F File Offset: 0x0095880F
		public unsafe UStaticMeshComponent SM_Act_Pro_101AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CC7 RID: 19655
		// (get) Token: 0x06025760 RID: 153440 RVA: 0x0095A624 File Offset: 0x00958824
		// (set) Token: 0x06025761 RID: 153441 RVA: 0x0095A638 File Offset: 0x00958838
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004CC8 RID: 19656
		// (get) Token: 0x06025762 RID: 153442 RVA: 0x0095A64D File Offset: 0x0095884D
		// (set) Token: 0x06025763 RID: 153443 RVA: 0x0095A661 File Offset: 0x00958861
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004CC9 RID: 19657
		// (get) Token: 0x06025764 RID: 153444 RVA: 0x0095A676 File Offset: 0x00958876
		// (set) Token: 0x06025765 RID: 153445 RVA: 0x0095A68A File Offset: 0x0095888A
		public unsafe USpringArmComponent SpringArm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpringArmComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_2_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_2_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004CCA RID: 19658
		// (get) Token: 0x06025766 RID: 153446 RVA: 0x0095A69F File Offset: 0x0095889F
		// (set) Token: 0x06025767 RID: 153447 RVA: 0x0095A6AF File Offset: 0x009588AF
		public unsafe int Counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_2_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_2_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004CCB RID: 19659
		// (get) Token: 0x06025768 RID: 153448 RVA: 0x0095A6C0 File Offset: 0x009588C0
		// (set) Token: 0x06025769 RID: 153449 RVA: 0x0095A6D0 File Offset: 0x009588D0
		public unsafe int Capture_Max_RTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_2_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_2_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004CCC RID: 19660
		// (get) Token: 0x0602576A RID: 153450 RVA: 0x0095A6E1 File Offset: 0x009588E1
		// (set) Token: 0x0602576B RID: 153451 RVA: 0x0095A6F1 File Offset: 0x009588F1
		public unsafe int Capture_Max_RTSize_XScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_2_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_2_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004CCD RID: 19661
		// (get) Token: 0x0602576C RID: 153452 RVA: 0x0095A702 File Offset: 0x00958902
		// (set) Token: 0x0602576D RID: 153453 RVA: 0x0095A712 File Offset: 0x00958912
		public unsafe int Capture_Max_RTSize_YScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_2_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_2_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x0602576E RID: 153454 RVA: 0x0095A723 File Offset: 0x00958923
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceRenderTexture_2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602576F RID: 153455 RVA: 0x0095A737 File Offset: 0x00958937
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DiceRenderTexture_2_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025770 RID: 153456 RVA: 0x0095A74C File Offset: 0x0095894C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DiceRenderTexture_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DiceRenderTexture_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DiceRenderTexture_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DiceRenderTexture_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceRenderTexture_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025771 RID: 153457 RVA: 0x0095A794 File Offset: 0x00958994
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DiceRenderTexture_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DiceRenderTexture_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DiceRenderTexture_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DiceRenderTexture_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DiceRenderTexture_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025772 RID: 153458 RVA: 0x0095A7DB File Offset: 0x009589DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceRenderTexture_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025773 RID: 153459 RVA: 0x0095A7EF File Offset: 0x009589EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DiceRenderTexture_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025774 RID: 153460 RVA: 0x0095A804 File Offset: 0x00958A04
		protected BP_DiceRenderTexture_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B0E RID: 76558
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceRenderTexture_2.BP_DiceRenderTexture_2_C";

		// Token: 0x04012B0F RID: 76559
		private static IntPtr _ClassPtr;

		// Token: 0x04012B10 RID: 76560
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B11 RID: 76561
		internal static int __PropertyOffset_1;

		// Token: 0x04012B12 RID: 76562
		internal static int __PropertyOffset_2;

		// Token: 0x04012B13 RID: 76563
		internal static int __PropertyOffset_3;

		// Token: 0x04012B14 RID: 76564
		internal static int __PropertyOffset_4;

		// Token: 0x04012B15 RID: 76565
		internal static int __PropertyOffset_5;

		// Token: 0x04012B16 RID: 76566
		internal static int __PropertyOffset_6;

		// Token: 0x04012B17 RID: 76567
		internal static int __PropertyOffset_7;

		// Token: 0x04012B18 RID: 76568
		internal static int __PropertyOffset_8;

		// Token: 0x04012B19 RID: 76569
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012B1A RID: 76570
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012B1B RID: 76571
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009FFD RID: 40957
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A98 RID: 203416
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
