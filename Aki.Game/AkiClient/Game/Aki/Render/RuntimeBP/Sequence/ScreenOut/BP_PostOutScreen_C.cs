using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Sequence.ScreenOut
{
	// Token: 0x02003AE2 RID: 15074
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Sequence/ScreenOut/BP_PostOutScreen.BP_PostOutScreen_C")]
	[UnrealStructLayout(1744, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1744)]
	public class BP_PostOutScreen_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020952 RID: 133458 RVA: 0x008D6FA1 File Offset: 0x008D51A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_PostOutScreen_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Sequence/ScreenOut/BP_PostOutScreen.BP_PostOutScreen_C");
			}
			return BP_PostOutScreen_C._ClassPtr;
		}

		// Token: 0x06020953 RID: 133459 RVA: 0x008D6FC8 File Offset: 0x008D51C8
		public BP_PostOutScreen_C() : this(BuiltinUtils.AllocNativeUObject(BP_PostOutScreen_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020954 RID: 133460 RVA: 0x008D6FF0 File Offset: 0x008D51F0
		[NullableContext(1)]
		public BP_PostOutScreen_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_PostOutScreen_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x06020955 RID: 133461 RVA: 0x008D7023 File Offset: 0x008D5223
		// (set) Token: 0x06020956 RID: 133462 RVA: 0x008D7037 File Offset: 0x008D5237
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostOutScreen_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostOutScreen_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x06020957 RID: 133463 RVA: 0x008D704C File Offset: 0x008D524C
		// (set) Token: 0x06020958 RID: 133464 RVA: 0x008D7060 File Offset: 0x008D5260
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostOutScreen_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostOutScreen_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x06020959 RID: 133465 RVA: 0x008D7075 File Offset: 0x008D5275
		// (set) Token: 0x0602095A RID: 133466 RVA: 0x008D7089 File Offset: 0x008D5289
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostOutScreen_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostOutScreen_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0602095B RID: 133467 RVA: 0x008D70A0 File Offset: 0x008D52A0
		// (set) Token: 0x0602095C RID: 133468 RVA: 0x008D70D9 File Offset: 0x008D52D9
		[Nullable(1)]
		public TMap<FName, float> Scalar_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, float> result;
				if ((result = this._Scalar_Parameters) == null)
				{
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_4, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0602095D RID: 133469 RVA: 0x008D70E8 File Offset: 0x008D52E8
		// (set) Token: 0x0602095E RID: 133470 RVA: 0x008D7121 File Offset: 0x008D5321
		[Nullable(1)]
		public TMap<FName, FLinearColor> Vector_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FLinearColor> result;
				if ((result = this._Vector_Parameters) == null)
				{
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0602095F RID: 133471 RVA: 0x008D7130 File Offset: 0x008D5330
		// (set) Token: 0x06020960 RID: 133472 RVA: 0x008D7169 File Offset: 0x008D5369
		[Nullable(1)]
		public TMap<FName, UTexture> Texture_Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UTexture> result;
				if ((result = this._Texture_Parameters) == null)
				{
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x06020961 RID: 133473 RVA: 0x008D7177 File Offset: 0x008D5377
		// (set) Token: 0x06020962 RID: 133474 RVA: 0x008D7187 File Offset: 0x008D5387
		public unsafe float TopAndBotRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x06020963 RID: 133475 RVA: 0x008D7198 File Offset: 0x008D5398
		// (set) Token: 0x06020964 RID: 133476 RVA: 0x008D71A8 File Offset: 0x008D53A8
		public unsafe float Aspect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x06020965 RID: 133477 RVA: 0x008D71B9 File Offset: 0x008D53B9
		// (set) Token: 0x06020966 RID: 133478 RVA: 0x008D71CD File Offset: 0x008D53CD
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostOutScreen_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_PostOutScreen_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x06020967 RID: 133479 RVA: 0x008D71E2 File Offset: 0x008D53E2
		// (set) Token: 0x06020968 RID: 133480 RVA: 0x008D71F2 File Offset: 0x008D53F2
		public unsafe bool DisableGammaOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x06020969 RID: 133481 RVA: 0x008D7203 File Offset: 0x008D5403
		// (set) Token: 0x0602096A RID: 133482 RVA: 0x008D7213 File Offset: 0x008D5413
		public unsafe int OriginalVal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_PostOutScreen_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x0602096B RID: 133483 RVA: 0x008D7224 File Offset: 0x008D5424
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostOutScreen_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0602096C RID: 133484 RVA: 0x008D7238 File Offset: 0x008D5438
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostOutScreen_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602096D RID: 133485 RVA: 0x008D724C File Offset: 0x008D544C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostOutScreen_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602096E RID: 133486 RVA: 0x008D7261 File Offset: 0x008D5461
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostOutScreen_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602096F RID: 133487 RVA: 0x008D7275 File Offset: 0x008D5475
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostOutScreen_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020970 RID: 133488 RVA: 0x008D728C File Offset: 0x008D548C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_PostOutScreen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PostOutScreen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PostOutScreen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PostOutScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostOutScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020971 RID: 133489 RVA: 0x008D72D4 File Offset: 0x008D54D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_PostOutScreen_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_PostOutScreen_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PostOutScreen_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PostOutScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostOutScreen_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020972 RID: 133490 RVA: 0x008D731B File Offset: 0x008D551B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostOutScreen_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06020973 RID: 133491 RVA: 0x008D732F File Offset: 0x008D552F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostOutScreen_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06020974 RID: 133492 RVA: 0x008D7344 File Offset: 0x008D5544
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_PostOutScreen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PostOutScreen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PostOutScreen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PostOutScreen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_PostOutScreen_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020975 RID: 133493 RVA: 0x008D738C File Offset: 0x008D558C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_PostOutScreen_C.__EditorTick_FunctionParams* ptr = stackalloc BP_PostOutScreen_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_PostOutScreen_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_PostOutScreen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_PostOutScreen_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06020976 RID: 133494 RVA: 0x008D73D3 File Offset: 0x008D55D3
		protected BP_PostOutScreen_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FCBC RID: 64700
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Sequence/ScreenOut/BP_PostOutScreen.BP_PostOutScreen_C";

		// Token: 0x0400FCBD RID: 64701
		private static IntPtr _ClassPtr;

		// Token: 0x0400FCBE RID: 64702
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FCBF RID: 64703
		internal static int __PropertyOffset_1;

		// Token: 0x0400FCC0 RID: 64704
		internal static int __PropertyOffset_2;

		// Token: 0x0400FCC1 RID: 64705
		internal static int __PropertyOffset_3;

		// Token: 0x0400FCC2 RID: 64706
		internal static int __PropertyOffset_4;

		// Token: 0x0400FCC3 RID: 64707
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x0400FCC4 RID: 64708
		internal static int __PropertyOffset_5;

		// Token: 0x0400FCC5 RID: 64709
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x0400FCC6 RID: 64710
		internal static int __PropertyOffset_6;

		// Token: 0x0400FCC7 RID: 64711
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x0400FCC8 RID: 64712
		internal static int __PropertyOffset_7;

		// Token: 0x0400FCC9 RID: 64713
		internal static int __PropertyOffset_8;

		// Token: 0x0400FCCA RID: 64714
		internal static int __PropertyOffset_9;

		// Token: 0x0400FCCB RID: 64715
		internal static int __PropertyOffset_10;

		// Token: 0x0400FCCC RID: 64716
		internal static int __PropertyOffset_11;

		// Token: 0x0400FCCD RID: 64717
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x0400FCCE RID: 64718
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0400FCCF RID: 64719
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0400FCD0 RID: 64720
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0400FCD1 RID: 64721
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0400FCD2 RID: 64722
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009BE1 RID: 39905
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031275 RID: 201333
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009BE2 RID: 39906
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x04031276 RID: 201334
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
