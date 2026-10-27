using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.Spindrift
{
	// Token: 0x02003BED RID: 15341
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrift_2.BP_FX_Sprindrift_2_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class BP_FX_Sprindrift_2_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x06022D59 RID: 142681 RVA: 0x0091382B File Offset: 0x00911A2B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FX_Sprindrift_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrift_2.BP_FX_Sprindrift_2_C");
			}
			return BP_FX_Sprindrift_2_C._ClassPtr;
		}

		// Token: 0x06022D5A RID: 142682 RVA: 0x00913850 File Offset: 0x00911A50
		public BP_FX_Sprindrift_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_FX_Sprindrift_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022D5B RID: 142683 RVA: 0x00913878 File Offset: 0x00911A78
		[NullableContext(1)]
		public BP_FX_Sprindrift_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FX_Sprindrift_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x06022D5C RID: 142684 RVA: 0x009138AB File Offset: 0x00911AAB
		// (set) Token: 0x06022D5D RID: 142685 RVA: 0x009138BF File Offset: 0x00911ABF
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x06022D5E RID: 142686 RVA: 0x009138D4 File Offset: 0x00911AD4
		// (set) Token: 0x06022D5F RID: 142687 RVA: 0x009138E8 File Offset: 0x00911AE8
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x06022D60 RID: 142688 RVA: 0x009138FD File Offset: 0x00911AFD
		// (set) Token: 0x06022D61 RID: 142689 RVA: 0x00913911 File Offset: 0x00911B11
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x06022D62 RID: 142690 RVA: 0x00913926 File Offset: 0x00911B26
		// (set) Token: 0x06022D63 RID: 142691 RVA: 0x0091393A File Offset: 0x00911B3A
		public unsafe UNiagaraSystem 粒子特效
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x06022D64 RID: 142692 RVA: 0x0091394F File Offset: 0x00911B4F
		// (set) Token: 0x06022D65 RID: 142693 RVA: 0x0091395F File Offset: 0x00911B5F
		public unsafe int 全局时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x06022D66 RID: 142694 RVA: 0x00913970 File Offset: 0x00911B70
		// (set) Token: 0x06022D67 RID: 142695 RVA: 0x00913980 File Offset: 0x00911B80
		public unsafe int 浪花数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x06022D68 RID: 142696 RVA: 0x00913991 File Offset: 0x00911B91
		// (set) Token: 0x06022D69 RID: 142697 RVA: 0x009139A1 File Offset: 0x00911BA1
		public unsafe float 浪花范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x06022D6A RID: 142698 RVA: 0x009139B2 File Offset: 0x00911BB2
		// (set) Token: 0x06022D6B RID: 142699 RVA: 0x009139C6 File Offset: 0x00911BC6
		public unsafe FLinearColor 浪花颜色_白天_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x06022D6C RID: 142700 RVA: 0x009139DB File Offset: 0x00911BDB
		// (set) Token: 0x06022D6D RID: 142701 RVA: 0x009139EF File Offset: 0x00911BEF
		public unsafe FLinearColor 浪花颜色_夜晚_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x06022D6E RID: 142702 RVA: 0x00913A04 File Offset: 0x00911C04
		// (set) Token: 0x06022D6F RID: 142703 RVA: 0x00913A14 File Offset: 0x00911C14
		public unsafe float 浪花周期
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x06022D70 RID: 142704 RVA: 0x00913A25 File Offset: 0x00911C25
		// (set) Token: 0x06022D71 RID: 142705 RVA: 0x00913A39 File Offset: 0x00911C39
		public unsafe FVector2D 周期偏移_白天_夜晚_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x06022D72 RID: 142706 RVA: 0x00913A4E File Offset: 0x00911C4E
		// (set) Token: 0x06022D73 RID: 142707 RVA: 0x00913A5E File Offset: 0x00911C5E
		public unsafe bool Activate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x06022D74 RID: 142708 RVA: 0x00913A6F File Offset: 0x00911C6F
		// (set) Token: 0x06022D75 RID: 142709 RVA: 0x00913A7F File Offset: 0x00911C7F
		public unsafe bool IsDayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x06022D76 RID: 142710 RVA: 0x00913A90 File Offset: 0x00911C90
		// (set) Token: 0x06022D77 RID: 142711 RVA: 0x00913AA4 File Offset: 0x00911CA4
		public unsafe UStaticMeshComponent CaptureMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x06022D78 RID: 142712 RVA: 0x00913AB9 File Offset: 0x00911CB9
		// (set) Token: 0x06022D79 RID: 142713 RVA: 0x00913ACD File Offset: 0x00911CCD
		public unsafe UTextureRenderTarget2D RTCaptureWaveLine
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x06022D7A RID: 142714 RVA: 0x00913AE2 File Offset: 0x00911CE2
		// (set) Token: 0x06022D7B RID: 142715 RVA: 0x00913AF2 File Offset: 0x00911CF2
		public unsafe float ActivateTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrift_2_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x06022D7C RID: 142716 RVA: 0x00913B03 File Offset: 0x00911D03
		// (set) Token: 0x06022D7D RID: 142717 RVA: 0x00913B17 File Offset: 0x00911D17
		public unsafe USceneCaptureComponent2D SceneCaptureComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_17);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrift_2_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x06022D7E RID: 142718 RVA: 0x00913B2C File Offset: 0x00911D2C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void GetHandle(ref int Handle)
		{
			BP_FX_Sprindrift_2_C.__GetHandle_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__GetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x06022D7F RID: 142719 RVA: 0x00913B7B File Offset: 0x00911D7B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CaptureWaveLine()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__CaptureWaveLine_NativeFunctionPtr, null);
		}

		// Token: 0x06022D80 RID: 142720 RVA: 0x00913B90 File Offset: 0x00911D90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void DayAndNight(bool IsDayTime)
		{
			BP_FX_Sprindrift_2_C.__DayAndNight_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__DayAndNight_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__DayAndNight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__DayAndNight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDayTime = IsDayTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__DayAndNight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D81 RID: 142721 RVA: 0x00913BD9 File Offset: 0x00911DD9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06022D82 RID: 142722 RVA: 0x00913BED File Offset: 0x00911DED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022D83 RID: 142723 RVA: 0x00913C04 File Offset: 0x00911E04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetHandle(int Handle)
		{
			BP_FX_Sprindrift_2_C.__SetHandle_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D84 RID: 142724 RVA: 0x00913C4A File Offset: 0x00911E4A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x06022D85 RID: 142725 RVA: 0x00913C5E File Offset: 0x00911E5E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06022D86 RID: 142726 RVA: 0x00913C72 File Offset: 0x00911E72
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06022D87 RID: 142727 RVA: 0x00913C88 File Offset: 0x00911E88
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D88 RID: 142728 RVA: 0x00913CD0 File Offset: 0x00911ED0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022D89 RID: 142729 RVA: 0x00913D18 File Offset: 0x00911F18
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06022D8A RID: 142730 RVA: 0x00913D60 File Offset: 0x00911F60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrift_2_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrift_2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrift_2_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022D8B RID: 142731 RVA: 0x00913DA7 File Offset: 0x00911FA7
		protected BP_FX_Sprindrift_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011236 RID: 70198
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrift_2.BP_FX_Sprindrift_2_C";

		// Token: 0x04011237 RID: 70199
		private static IntPtr _ClassPtr;

		// Token: 0x04011238 RID: 70200
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011239 RID: 70201
		internal static int __PropertyOffset_1;

		// Token: 0x0401123A RID: 70202
		internal static int __PropertyOffset_2;

		// Token: 0x0401123B RID: 70203
		internal static int __PropertyOffset_3;

		// Token: 0x0401123C RID: 70204
		internal static int __PropertyOffset_4;

		// Token: 0x0401123D RID: 70205
		internal static int __PropertyOffset_5;

		// Token: 0x0401123E RID: 70206
		internal static int __PropertyOffset_6;

		// Token: 0x0401123F RID: 70207
		internal static int __PropertyOffset_7;

		// Token: 0x04011240 RID: 70208
		internal static int __PropertyOffset_8;

		// Token: 0x04011241 RID: 70209
		internal static int __PropertyOffset_9;

		// Token: 0x04011242 RID: 70210
		internal static int __PropertyOffset_10;

		// Token: 0x04011243 RID: 70211
		internal static int __PropertyOffset_11;

		// Token: 0x04011244 RID: 70212
		internal static int __PropertyOffset_12;

		// Token: 0x04011245 RID: 70213
		internal static int __PropertyOffset_13;

		// Token: 0x04011246 RID: 70214
		internal static int __PropertyOffset_14;

		// Token: 0x04011247 RID: 70215
		internal static int __PropertyOffset_15;

		// Token: 0x04011248 RID: 70216
		internal static int __PropertyOffset_16;

		// Token: 0x04011249 RID: 70217
		internal static int __PropertyOffset_17;

		// Token: 0x0401124A RID: 70218
		private static IntPtr __GetHandle_NativeFunctionPtr;

		// Token: 0x0401124B RID: 70219
		private static IntPtr __CaptureWaveLine_NativeFunctionPtr;

		// Token: 0x0401124C RID: 70220
		private static IntPtr __DayAndNight_NativeFunctionPtr;

		// Token: 0x0401124D RID: 70221
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401124E RID: 70222
		private static IntPtr __SetHandle_NativeFunctionPtr;

		// Token: 0x0401124F RID: 70223
		private static IntPtr __RemoveHandle_NativeFunctionPtr;

		// Token: 0x04011250 RID: 70224
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011251 RID: 70225
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011252 RID: 70226
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009DDB RID: 40411
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x040315DE RID: 202206
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02009DDC RID: 40412
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __DayAndNight_FunctionParams
		{
			// Token: 0x040315DF RID: 202207
			[FieldOffset(0)]
			public bool IsDayTime;
		}

		// Token: 0x02009DDD RID: 40413
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x040315E0 RID: 202208
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02009DDE RID: 40414
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040315E1 RID: 202209
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009DDF RID: 40415
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040315E2 RID: 202210
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
