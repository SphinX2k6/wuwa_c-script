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
	// Token: 0x020030DB RID: 12507
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrigt.BP_FX_Sprindrigt_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1546)]
	public class BP_FX_Sprindrigt_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject, IBPI_EffectInterface_C, IUnrealBlueprintInterface, IUnrealInterface
	{
		// Token: 0x0601E308 RID: 123656 RVA: 0x0090D647 File Offset: 0x0090B847
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FX_Sprindrigt_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrigt.BP_FX_Sprindrigt_C");
			}
			return BP_FX_Sprindrigt_C._ClassPtr;
		}

		// Token: 0x0601E309 RID: 123657 RVA: 0x0090D66C File Offset: 0x0090B86C
		public BP_FX_Sprindrigt_C() : this(BuiltinUtils.AllocNativeUObject(BP_FX_Sprindrigt_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E30A RID: 123658 RVA: 0x0090D694 File Offset: 0x0090B894
		[NullableContext(1)]
		public BP_FX_Sprindrigt_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FX_Sprindrigt_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003267 RID: 12903
		// (get) Token: 0x0601E30B RID: 123659 RVA: 0x0090D6C7 File Offset: 0x0090B8C7
		// (set) Token: 0x0601E30C RID: 123660 RVA: 0x0090D6DB File Offset: 0x0090B8DB
		public unsafe UArrowComponent Arrow
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UArrowComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_Arrow);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_Arrow, value);
			}
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0601E30D RID: 123661 RVA: 0x0090D6F0 File Offset: 0x0090B8F0
		// (set) Token: 0x0601E30E RID: 123662 RVA: 0x0090D704 File Offset: 0x0090B904
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_Niagara);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_Niagara, value);
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0601E30F RID: 123663 RVA: 0x0090D719 File Offset: 0x0090B919
		// (set) Token: 0x0601E310 RID: 123664 RVA: 0x0090D72D File Offset: 0x0090B92D
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0601E311 RID: 123665 RVA: 0x0090D742 File Offset: 0x0090B942
		// (set) Token: 0x0601E312 RID: 123666 RVA: 0x0090D756 File Offset: 0x0090B956
		public unsafe UNiagaraSystem 粒子特效
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_粒子特效);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_FX_Sprindrigt_C.__PropertyOffset_粒子特效, value);
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0601E313 RID: 123667 RVA: 0x0090D76B File Offset: 0x0090B96B
		// (set) Token: 0x0601E314 RID: 123668 RVA: 0x0090D77B File Offset: 0x0090B97B
		public unsafe int 全局时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_全局时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_全局时间) = value;
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0601E315 RID: 123669 RVA: 0x0090D78C File Offset: 0x0090B98C
		// (set) Token: 0x0601E316 RID: 123670 RVA: 0x0090D79C File Offset: 0x0090B99C
		public unsafe int 浪花数量
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花数量);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花数量) = value;
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0601E317 RID: 123671 RVA: 0x0090D7AD File Offset: 0x0090B9AD
		// (set) Token: 0x0601E318 RID: 123672 RVA: 0x0090D7BD File Offset: 0x0090B9BD
		public unsafe float 浪花范围
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花范围);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花范围) = value;
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0601E319 RID: 123673 RVA: 0x0090D7CE File Offset: 0x0090B9CE
		// (set) Token: 0x0601E31A RID: 123674 RVA: 0x0090D7E2 File Offset: 0x0090B9E2
		public unsafe FLinearColor 浪花颜色_白天_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花颜色_白天_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花颜色_白天_) = value;
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0601E31B RID: 123675 RVA: 0x0090D7F7 File Offset: 0x0090B9F7
		// (set) Token: 0x0601E31C RID: 123676 RVA: 0x0090D80B File Offset: 0x0090BA0B
		public unsafe FLinearColor 浪花颜色_夜晚_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花颜色_夜晚_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花颜色_夜晚_) = value;
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0601E31D RID: 123677 RVA: 0x0090D820 File Offset: 0x0090BA20
		// (set) Token: 0x0601E31E RID: 123678 RVA: 0x0090D830 File Offset: 0x0090BA30
		public unsafe float 浪花周期
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花周期);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_浪花周期) = value;
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0601E31F RID: 123679 RVA: 0x0090D841 File Offset: 0x0090BA41
		// (set) Token: 0x0601E320 RID: 123680 RVA: 0x0090D855 File Offset: 0x0090BA55
		public unsafe FVector2D 周期偏移_白天_夜晚_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_周期偏移_白天_夜晚_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_周期偏移_白天_夜晚_) = value;
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0601E321 RID: 123681 RVA: 0x0090D86A File Offset: 0x0090BA6A
		// (set) Token: 0x0601E322 RID: 123682 RVA: 0x0090D87A File Offset: 0x0090BA7A
		public unsafe bool Activate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_Activate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_Activate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0601E323 RID: 123683 RVA: 0x0090D88B File Offset: 0x0090BA8B
		// (set) Token: 0x0601E324 RID: 123684 RVA: 0x0090D89B File Offset: 0x0090BA9B
		public unsafe bool IsDayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_IsDayTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FX_Sprindrigt_C.__PropertyOffset_IsDayTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601E325 RID: 123685 RVA: 0x0090D8AC File Offset: 0x0090BAAC
		[SkipLocalsInit]
		public unsafe virtual void GetHandle(ref int Handle)
		{
			BP_FX_Sprindrigt_C.__GetHandle_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__GetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__GetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__GetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__GetHandle_NativeFunctionPtr, (void*)ptr);
			Handle = ptr->Handle;
		}

		// Token: 0x0601E326 RID: 123686 RVA: 0x0090D8FC File Offset: 0x0090BAFC
		[SkipLocalsInit]
		public unsafe virtual void DayAndNight(bool IsDayTime)
		{
			BP_FX_Sprindrigt_C.__DayAndNight_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__DayAndNight_FunctionParams[(UIntPtr)247] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__DayAndNight_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__DayAndNight_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IsDayTime = IsDayTime;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__DayAndNight_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E327 RID: 123687 RVA: 0x0090D945 File Offset: 0x0090BB45
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E328 RID: 123688 RVA: 0x0090D959 File Offset: 0x0090BB59
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601E329 RID: 123689 RVA: 0x0090D970 File Offset: 0x0090BB70
		[SkipLocalsInit]
		public unsafe virtual void SetHandle(int Handle)
		{
			BP_FX_Sprindrigt_C.__SetHandle_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__SetHandle_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__SetHandle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__SetHandle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Handle = Handle;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__SetHandle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E32A RID: 123690 RVA: 0x0090D9B6 File Offset: 0x0090BBB6
		[SkipLocalsInit]
		public virtual void RemoveHandle()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__RemoveHandle_NativeFunctionPtr, null);
		}

		// Token: 0x0601E32B RID: 123691 RVA: 0x0090D9CA File Offset: 0x0090BBCA
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E32C RID: 123692 RVA: 0x0090D9DE File Offset: 0x0090BBDE
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0601E32D RID: 123693 RVA: 0x0090D9F4 File Offset: 0x0090BBF4
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E32E RID: 123694 RVA: 0x0090DA3C File Offset: 0x0090BC3C
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E32F RID: 123695 RVA: 0x0090DA84 File Offset: 0x0090BC84
		[SkipLocalsInit]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_FX_Sprindrigt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E330 RID: 123696 RVA: 0x0090DACC File Offset: 0x0090BCCC
		[SkipLocalsInit]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_FX_Sprindrigt_C.__EditorTick_FunctionParams* ptr = stackalloc BP_FX_Sprindrigt_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_FX_Sprindrigt_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_FX_Sprindrigt_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_FX_Sprindrigt_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601E331 RID: 123697 RVA: 0x0090DB12 File Offset: 0x0090BD12
		protected BP_FX_Sprindrigt_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF8B RID: 65419
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/Spindrift/BP_FX_Sprindrigt.BP_FX_Sprindrigt_C";

		// Token: 0x0400FF8C RID: 65420
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF8D RID: 65421
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF8E RID: 65422
		internal static int __PropertyOffset_Arrow;

		// Token: 0x0400FF8F RID: 65423
		internal static int __PropertyOffset_Niagara;

		// Token: 0x0400FF90 RID: 65424
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x0400FF91 RID: 65425
		internal static int __PropertyOffset_粒子特效;

		// Token: 0x0400FF92 RID: 65426
		internal static int __PropertyOffset_全局时间;

		// Token: 0x0400FF93 RID: 65427
		internal static int __PropertyOffset_浪花数量;

		// Token: 0x0400FF94 RID: 65428
		internal static int __PropertyOffset_浪花范围;

		// Token: 0x0400FF95 RID: 65429
		internal static int __PropertyOffset_浪花颜色_白天_;

		// Token: 0x0400FF96 RID: 65430
		internal static int __PropertyOffset_浪花颜色_夜晚_;

		// Token: 0x0400FF97 RID: 65431
		internal static int __PropertyOffset_浪花周期;

		// Token: 0x0400FF98 RID: 65432
		internal static int __PropertyOffset_周期偏移_白天_夜晚_;

		// Token: 0x0400FF99 RID: 65433
		internal static int __PropertyOffset_Activate;

		// Token: 0x0400FF9A RID: 65434
		internal static int __PropertyOffset_IsDayTime;

		// Token: 0x0400FF9B RID: 65435
		private static IntPtr __GetHandle_NativeFunctionPtr;

		// Token: 0x0400FF9C RID: 65436
		private static IntPtr __DayAndNight_NativeFunctionPtr;

		// Token: 0x0400FF9D RID: 65437
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FF9E RID: 65438
		private static IntPtr __SetHandle_NativeFunctionPtr;

		// Token: 0x0400FF9F RID: 65439
		private static IntPtr __RemoveHandle_NativeFunctionPtr;

		// Token: 0x0400FFA0 RID: 65440
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FFA1 RID: 65441
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FFA2 RID: 65442
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02008E37 RID: 36407
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetHandle_FunctionParams
		{
			// Token: 0x0402CA78 RID: 182904
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02008E38 RID: 36408
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 232)]
		protected ref struct __DayAndNight_FunctionParams
		{
			// Token: 0x0402CA79 RID: 182905
			[FieldOffset(0)]
			public bool IsDayTime;
		}

		// Token: 0x02008E39 RID: 36409
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetHandle_FunctionParams
		{
			// Token: 0x0402CA7A RID: 182906
			[FieldOffset(0)]
			public int Handle;
		}

		// Token: 0x02008E3A RID: 36410
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CA7B RID: 182907
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02008E3B RID: 36411
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0402CA7C RID: 182908
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
