using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Interaction
{
	// Token: 0x02003D11 RID: 15633
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceRenderTexture.BP_DiceRenderTexture_C")]
	[UnrealStructLayout(1216, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1204)]
	public class BP_DiceRenderTexture_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025775 RID: 153461 RVA: 0x0095A80D File Offset: 0x00958A0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DiceRenderTexture_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceRenderTexture.BP_DiceRenderTexture_C");
			}
			return BP_DiceRenderTexture_C._ClassPtr;
		}

		// Token: 0x06025776 RID: 153462 RVA: 0x0095A834 File Offset: 0x00958A34
		public BP_DiceRenderTexture_C() : this(BuiltinUtils.AllocNativeUObject(BP_DiceRenderTexture_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025777 RID: 153463 RVA: 0x0095A85C File Offset: 0x00958A5C
		[NullableContext(1)]
		public BP_DiceRenderTexture_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DiceRenderTexture_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004CCE RID: 19662
		// (get) Token: 0x06025778 RID: 153464 RVA: 0x0095A88F File Offset: 0x00958A8F
		// (set) Token: 0x06025779 RID: 153465 RVA: 0x0095A8A3 File Offset: 0x00958AA3
		public unsafe UStaticMeshComponent SM_Act_Pro_101AS
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004CCF RID: 19663
		// (get) Token: 0x0602577A RID: 153466 RVA: 0x0095A8B8 File Offset: 0x00958AB8
		// (set) Token: 0x0602577B RID: 153467 RVA: 0x0095A8CC File Offset: 0x00958ACC
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004CD0 RID: 19664
		// (get) Token: 0x0602577C RID: 153468 RVA: 0x0095A8E1 File Offset: 0x00958AE1
		// (set) Token: 0x0602577D RID: 153469 RVA: 0x0095A8F5 File Offset: 0x00958AF5
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004CD1 RID: 19665
		// (get) Token: 0x0602577E RID: 153470 RVA: 0x0095A90A File Offset: 0x00958B0A
		// (set) Token: 0x0602577F RID: 153471 RVA: 0x0095A91E File Offset: 0x00958B1E
		public unsafe USpringArmComponent SpringArm
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpringArmComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DiceRenderTexture_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004CD2 RID: 19666
		// (get) Token: 0x06025780 RID: 153472 RVA: 0x0095A933 File Offset: 0x00958B33
		// (set) Token: 0x06025781 RID: 153473 RVA: 0x0095A943 File Offset: 0x00958B43
		public unsafe int Counter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004CD3 RID: 19667
		// (get) Token: 0x06025782 RID: 153474 RVA: 0x0095A954 File Offset: 0x00958B54
		// (set) Token: 0x06025783 RID: 153475 RVA: 0x0095A964 File Offset: 0x00958B64
		public unsafe int Capture_Max_RTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004CD4 RID: 19668
		// (get) Token: 0x06025784 RID: 153476 RVA: 0x0095A975 File Offset: 0x00958B75
		// (set) Token: 0x06025785 RID: 153477 RVA: 0x0095A985 File Offset: 0x00958B85
		public unsafe int Capture_Max_RTSize_XScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004CD5 RID: 19669
		// (get) Token: 0x06025786 RID: 153478 RVA: 0x0095A996 File Offset: 0x00958B96
		// (set) Token: 0x06025787 RID: 153479 RVA: 0x0095A9A6 File Offset: 0x00958BA6
		public unsafe int Capture_Max_RTSize_YScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004CD6 RID: 19670
		// (get) Token: 0x06025788 RID: 153480 RVA: 0x0095A9B7 File Offset: 0x00958BB7
		// (set) Token: 0x06025789 RID: 153481 RVA: 0x0095A9CB File Offset: 0x00958BCB
		public unsafe FTransform RelativeLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004CD7 RID: 19671
		// (get) Token: 0x0602578A RID: 153482 RVA: 0x0095A9E0 File Offset: 0x00958BE0
		// (set) Token: 0x0602578B RID: 153483 RVA: 0x0095A9F4 File Offset: 0x00958BF4
		public unsafe FTransform RelativeLocation_DaFuWeng
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004CD8 RID: 19672
		// (get) Token: 0x0602578C RID: 153484 RVA: 0x0095AA09 File Offset: 0x00958C09
		// (set) Token: 0x0602578D RID: 153485 RVA: 0x0095AA19 File Offset: 0x00958C19
		public unsafe int SelectLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_DiceRenderTexture_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x0602578E RID: 153486 RVA: 0x0095AA2A File Offset: 0x00958C2A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetTransform()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceRenderTexture_C.__SetTransform_NativeFunctionPtr, null);
		}

		// Token: 0x0602578F RID: 153487 RVA: 0x0095AA3E File Offset: 0x00958C3E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceRenderTexture_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025790 RID: 153488 RVA: 0x0095AA52 File Offset: 0x00958C52
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DiceRenderTexture_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025791 RID: 153489 RVA: 0x0095AA68 File Offset: 0x00958C68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_DiceRenderTexture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DiceRenderTexture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DiceRenderTexture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DiceRenderTexture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceRenderTexture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025792 RID: 153490 RVA: 0x0095AAB0 File Offset: 0x00958CB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_DiceRenderTexture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_DiceRenderTexture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_DiceRenderTexture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_DiceRenderTexture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DiceRenderTexture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025793 RID: 153491 RVA: 0x0095AAF7 File Offset: 0x00958CF7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DiceRenderTexture_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025794 RID: 153492 RVA: 0x0095AB0B File Offset: 0x00958D0B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_DiceRenderTexture_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025795 RID: 153493 RVA: 0x0095AB20 File Offset: 0x00958D20
		protected BP_DiceRenderTexture_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B1C RID: 76572
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Interaction/BP_DiceRenderTexture.BP_DiceRenderTexture_C";

		// Token: 0x04012B1D RID: 76573
		private static IntPtr _ClassPtr;

		// Token: 0x04012B1E RID: 76574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012B1F RID: 76575
		internal static int __PropertyOffset_1;

		// Token: 0x04012B20 RID: 76576
		internal static int __PropertyOffset_2;

		// Token: 0x04012B21 RID: 76577
		internal static int __PropertyOffset_3;

		// Token: 0x04012B22 RID: 76578
		internal static int __PropertyOffset_4;

		// Token: 0x04012B23 RID: 76579
		internal static int __PropertyOffset_5;

		// Token: 0x04012B24 RID: 76580
		internal static int __PropertyOffset_6;

		// Token: 0x04012B25 RID: 76581
		internal static int __PropertyOffset_7;

		// Token: 0x04012B26 RID: 76582
		internal static int __PropertyOffset_8;

		// Token: 0x04012B27 RID: 76583
		internal static int __PropertyOffset_9;

		// Token: 0x04012B28 RID: 76584
		internal static int __PropertyOffset_10;

		// Token: 0x04012B29 RID: 76585
		internal static int __PropertyOffset_11;

		// Token: 0x04012B2A RID: 76586
		private static IntPtr __SetTransform_NativeFunctionPtr;

		// Token: 0x04012B2B RID: 76587
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012B2C RID: 76588
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012B2D RID: 76589
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009FFE RID: 40958
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A99 RID: 203417
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
