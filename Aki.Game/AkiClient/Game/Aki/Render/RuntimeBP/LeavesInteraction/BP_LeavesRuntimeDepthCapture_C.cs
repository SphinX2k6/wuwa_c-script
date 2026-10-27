using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LeavesInteraction
{
	// Token: 0x02003CF9 RID: 15609
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesRuntimeDepthCapture.BP_LeavesRuntimeDepthCapture_C")]
	[UnrealStructLayout(1488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1482)]
	public class BP_LeavesRuntimeDepthCapture_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025433 RID: 152627 RVA: 0x009555DC File Offset: 0x009537DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LeavesRuntimeDepthCapture_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesRuntimeDepthCapture.BP_LeavesRuntimeDepthCapture_C");
			}
			return BP_LeavesRuntimeDepthCapture_C._ClassPtr;
		}

		// Token: 0x06025434 RID: 152628 RVA: 0x00955600 File Offset: 0x00953800
		public BP_LeavesRuntimeDepthCapture_C() : this(BuiltinUtils.AllocNativeUObject(BP_LeavesRuntimeDepthCapture_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025435 RID: 152629 RVA: 0x00955628 File Offset: 0x00953828
		[NullableContext(1)]
		public BP_LeavesRuntimeDepthCapture_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LeavesRuntimeDepthCapture_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BB5 RID: 19381
		// (get) Token: 0x06025436 RID: 152630 RVA: 0x0095565B File Offset: 0x0095385B
		// (set) Token: 0x06025437 RID: 152631 RVA: 0x0095566F File Offset: 0x0095386F
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004BB6 RID: 19382
		// (get) Token: 0x06025438 RID: 152632 RVA: 0x00955684 File Offset: 0x00953884
		// (set) Token: 0x06025439 RID: 152633 RVA: 0x00955698 File Offset: 0x00953898
		public unsafe UKuroCustomCaptureVolume KuroCustomCaptureVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCustomCaptureVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004BB7 RID: 19383
		// (get) Token: 0x0602543A RID: 152634 RVA: 0x009556AD File Offset: 0x009538AD
		// (set) Token: 0x0602543B RID: 152635 RVA: 0x009556C1 File Offset: 0x009538C1
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004BB8 RID: 19384
		// (get) Token: 0x0602543C RID: 152636 RVA: 0x009556D6 File Offset: 0x009538D6
		// (set) Token: 0x0602543D RID: 152637 RVA: 0x009556EA File Offset: 0x009538EA
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004BB9 RID: 19385
		// (get) Token: 0x0602543E RID: 152638 RVA: 0x009556FF File Offset: 0x009538FF
		// (set) Token: 0x0602543F RID: 152639 RVA: 0x00955713 File Offset: 0x00953913
		[Nullable(0)]
		public unsafe TEnumAsByte<ECaptureMode> CaptureMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_5);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004BBA RID: 19386
		// (get) Token: 0x06025440 RID: 152640 RVA: 0x00955728 File Offset: 0x00953928
		// (set) Token: 0x06025441 RID: 152641 RVA: 0x00955738 File Offset: 0x00953938
		public unsafe bool bCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LeavesRuntimeDepthCapture_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x06025442 RID: 152642 RVA: 0x00955749 File Offset: 0x00953949
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesRuntimeDepthCapture_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025443 RID: 152643 RVA: 0x0095575D File Offset: 0x0095395D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesRuntimeDepthCapture_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025444 RID: 152644 RVA: 0x00955774 File Offset: 0x00953974
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025445 RID: 152645 RVA: 0x009557BC File Offset: 0x009539BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LeavesRuntimeDepthCapture_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025446 RID: 152646 RVA: 0x00955803 File Offset: 0x00953A03
		protected BP_LeavesRuntimeDepthCapture_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401292D RID: 76077
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_LeavesRuntimeDepthCapture.BP_LeavesRuntimeDepthCapture_C";

		// Token: 0x0401292E RID: 76078
		private static IntPtr _ClassPtr;

		// Token: 0x0401292F RID: 76079
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012930 RID: 76080
		internal static int __PropertyOffset_1;

		// Token: 0x04012931 RID: 76081
		internal static int __PropertyOffset_2;

		// Token: 0x04012932 RID: 76082
		internal static int __PropertyOffset_3;

		// Token: 0x04012933 RID: 76083
		internal static int __PropertyOffset_4;

		// Token: 0x04012934 RID: 76084
		internal static int __PropertyOffset_5;

		// Token: 0x04012935 RID: 76085
		internal static int __PropertyOffset_6;

		// Token: 0x04012936 RID: 76086
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04012937 RID: 76087
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02009FD8 RID: 40920
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A5A RID: 203354
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
