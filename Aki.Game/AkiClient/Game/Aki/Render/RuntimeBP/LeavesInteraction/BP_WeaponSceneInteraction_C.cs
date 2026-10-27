using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.LeavesInteraction
{
	// Token: 0x02003CFA RID: 15610
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_WeaponSceneInteraction.BP_WeaponSceneInteraction_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1564)]
	public class BP_WeaponSceneInteraction_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025447 RID: 152647 RVA: 0x0095580C File Offset: 0x00953A0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WeaponSceneInteraction_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_WeaponSceneInteraction.BP_WeaponSceneInteraction_C");
			}
			return BP_WeaponSceneInteraction_C._ClassPtr;
		}

		// Token: 0x06025448 RID: 152648 RVA: 0x00955830 File Offset: 0x00953A30
		public BP_WeaponSceneInteraction_C() : this(BuiltinUtils.AllocNativeUObject(BP_WeaponSceneInteraction_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025449 RID: 152649 RVA: 0x00955858 File Offset: 0x00953A58
		[NullableContext(1)]
		public BP_WeaponSceneInteraction_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WeaponSceneInteraction_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BBB RID: 19387
		// (get) Token: 0x0602544A RID: 152650 RVA: 0x0095588B File Offset: 0x00953A8B
		// (set) Token: 0x0602544B RID: 152651 RVA: 0x0095589F File Offset: 0x00953A9F
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004BBC RID: 19388
		// (get) Token: 0x0602544C RID: 152652 RVA: 0x009558B4 File Offset: 0x00953AB4
		// (set) Token: 0x0602544D RID: 152653 RVA: 0x009558C8 File Offset: 0x00953AC8
		public unsafe BP_SceneBattleInteract_C Config
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SceneBattleInteract_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004BBD RID: 19389
		// (get) Token: 0x0602544E RID: 152654 RVA: 0x009558DD File Offset: 0x00953ADD
		// (set) Token: 0x0602544F RID: 152655 RVA: 0x009558F1 File Offset: 0x00953AF1
		public unsafe UMaterialInstanceDynamic AddPointsMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004BBE RID: 19390
		// (get) Token: 0x06025450 RID: 152656 RVA: 0x00955906 File Offset: 0x00953B06
		// (set) Token: 0x06025451 RID: 152657 RVA: 0x0095591A File Offset: 0x00953B1A
		public unsafe UTextureRenderTarget2D PointRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004BBF RID: 19391
		// (get) Token: 0x06025452 RID: 152658 RVA: 0x0095592F File Offset: 0x00953B2F
		// (set) Token: 0x06025453 RID: 152659 RVA: 0x00955943 File Offset: 0x00953B43
		public unsafe FVectorDouble PrevPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17004BC0 RID: 19392
		// (get) Token: 0x06025454 RID: 152660 RVA: 0x00955958 File Offset: 0x00953B58
		// (set) Token: 0x06025455 RID: 152661 RVA: 0x0095596C File Offset: 0x00953B6C
		public unsafe FVectorDouble CurrPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17004BC1 RID: 19393
		// (get) Token: 0x06025456 RID: 152662 RVA: 0x00955981 File Offset: 0x00953B81
		// (set) Token: 0x06025457 RID: 152663 RVA: 0x00955991 File Offset: 0x00953B91
		public unsafe float captureSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17004BC2 RID: 19394
		// (get) Token: 0x06025458 RID: 152664 RVA: 0x009559A2 File Offset: 0x00953BA2
		// (set) Token: 0x06025459 RID: 152665 RVA: 0x009559B6 File Offset: 0x00953BB6
		public unsafe UTextureRenderTarget2D ResultRT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WeaponSceneInteraction_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17004BC3 RID: 19395
		// (get) Token: 0x0602545A RID: 152666 RVA: 0x009559CB File Offset: 0x00953BCB
		// (set) Token: 0x0602545B RID: 152667 RVA: 0x009559DB File Offset: 0x00953BDB
		public unsafe float PlayerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17004BC4 RID: 19396
		// (get) Token: 0x0602545C RID: 152668 RVA: 0x009559EC File Offset: 0x00953BEC
		// (set) Token: 0x0602545D RID: 152669 RVA: 0x00955A00 File Offset: 0x00953C00
		public unsafe FVector PlayerPrevUV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17004BC5 RID: 19397
		// (get) Token: 0x0602545E RID: 152670 RVA: 0x00955A15 File Offset: 0x00953C15
		// (set) Token: 0x0602545F RID: 152671 RVA: 0x00955A25 File Offset: 0x00953C25
		public unsafe float WeaponInteractRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WeaponSceneInteraction_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x06025460 RID: 152672 RVA: 0x00955A38 File Offset: 0x00953C38
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CalcTexCoord(FVectorDouble RTCenter, FVectorDouble WeaponPointLocation, float CaptureSize, ref FVector TexCoord)
		{
			BP_WeaponSceneInteraction_C.__CalcTexCoord_FunctionParams* ptr = stackalloc BP_WeaponSceneInteraction_C.__CalcTexCoord_FunctionParams[(UIntPtr)191] + 15L / (long)sizeof(BP_WeaponSceneInteraction_C.__CalcTexCoord_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponSceneInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr, 1);
			ptr->RTCenter = RTCenter;
			ptr->WeaponPointLocation = WeaponPointLocation;
			ptr->CaptureSize = CaptureSize;
			ptr->TexCoord = TexCoord;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponSceneInteraction_C.__CalcTexCoord_NativeFunctionPtr, (void*)ptr);
			TexCoord = ptr->TexCoord;
		}

		// Token: 0x06025461 RID: 152673 RVA: 0x00955AA9 File Offset: 0x00953CA9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponSceneInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025462 RID: 152674 RVA: 0x00955ABD File Offset: 0x00953CBD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponSceneInteraction_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025463 RID: 152675 RVA: 0x00955AD4 File Offset: 0x00953CD4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_WeaponSceneInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeaponSceneInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeaponSceneInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponSceneInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponSceneInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025464 RID: 152676 RVA: 0x00955B1C File Offset: 0x00953D1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_WeaponSceneInteraction_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_WeaponSceneInteraction_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_WeaponSceneInteraction_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponSceneInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WeaponSceneInteraction_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025465 RID: 152677 RVA: 0x00955B64 File Offset: 0x00953D64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteract(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_WeaponSceneInteraction_C.__OnWeaponInteract_FunctionParams* ptr = stackalloc BP_WeaponSceneInteraction_C.__OnWeaponInteract_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_WeaponSceneInteraction_C.__OnWeaponInteract_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WeaponSceneInteraction_C.__OnWeaponInteract_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponSceneInteraction_C.__OnWeaponInteract_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025466 RID: 152678 RVA: 0x00955BC7 File Offset: 0x00953DC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Clear_RT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WeaponSceneInteraction_C.__Clear_RT_NativeFunctionPtr, null);
		}

		// Token: 0x06025467 RID: 152679 RVA: 0x00955BDB File Offset: 0x00953DDB
		protected BP_WeaponSceneInteraction_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012938 RID: 76088
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/LeavesInteraction/BP_WeaponSceneInteraction.BP_WeaponSceneInteraction_C";

		// Token: 0x04012939 RID: 76089
		private static IntPtr _ClassPtr;

		// Token: 0x0401293A RID: 76090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401293B RID: 76091
		internal static int __PropertyOffset_1;

		// Token: 0x0401293C RID: 76092
		internal static int __PropertyOffset_2;

		// Token: 0x0401293D RID: 76093
		internal static int __PropertyOffset_3;

		// Token: 0x0401293E RID: 76094
		internal static int __PropertyOffset_4;

		// Token: 0x0401293F RID: 76095
		internal static int __PropertyOffset_5;

		// Token: 0x04012940 RID: 76096
		internal static int __PropertyOffset_6;

		// Token: 0x04012941 RID: 76097
		internal static int __PropertyOffset_7;

		// Token: 0x04012942 RID: 76098
		internal static int __PropertyOffset_8;

		// Token: 0x04012943 RID: 76099
		internal static int __PropertyOffset_9;

		// Token: 0x04012944 RID: 76100
		internal static int __PropertyOffset_10;

		// Token: 0x04012945 RID: 76101
		internal static int __PropertyOffset_11;

		// Token: 0x04012946 RID: 76102
		private static IntPtr __CalcTexCoord_NativeFunctionPtr;

		// Token: 0x04012947 RID: 76103
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04012948 RID: 76104
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04012949 RID: 76105
		private static IntPtr __OnWeaponInteract_NativeFunctionPtr;

		// Token: 0x0401294A RID: 76106
		private static IntPtr __Clear_RT_NativeFunctionPtr;

		// Token: 0x02009FD9 RID: 40921
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __CalcTexCoord_FunctionParams
		{
			// Token: 0x04031A5B RID: 203355
			[FieldOffset(0)]
			public FVectorDouble RTCenter;

			// Token: 0x04031A5C RID: 203356
			[FieldOffset(24)]
			public FVectorDouble WeaponPointLocation;

			// Token: 0x04031A5D RID: 203357
			[FieldOffset(48)]
			public float CaptureSize;

			// Token: 0x04031A5E RID: 203358
			[FieldOffset(52)]
			public FVector TexCoord;
		}

		// Token: 0x02009FDA RID: 40922
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031A5F RID: 203359
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FDB RID: 40923
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteract_FunctionParams
		{
			// Token: 0x04031A60 RID: 203360
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x04031A61 RID: 203361
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x04031A62 RID: 203362
			[FieldOffset(32)]
			public int Id;
		}
	}
}
