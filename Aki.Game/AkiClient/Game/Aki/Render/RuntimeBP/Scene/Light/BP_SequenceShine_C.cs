using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B18 RID: 15128
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SequenceShine.BP_SequenceShine_C")]
	[UnrealStructLayout(1800, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1800)]
	public class BP_SequenceShine_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021123 RID: 135459 RVA: 0x008E42C4 File Offset: 0x008E24C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SequenceShine_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SequenceShine.BP_SequenceShine_C");
			}
			return BP_SequenceShine_C._ClassPtr;
		}

		// Token: 0x06021124 RID: 135460 RVA: 0x008E42E8 File Offset: 0x008E24E8
		public BP_SequenceShine_C() : this(BuiltinUtils.AllocNativeUObject(BP_SequenceShine_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021125 RID: 135461 RVA: 0x008E4310 File Offset: 0x008E2510
		[NullableContext(1)]
		public BP_SequenceShine_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SequenceShine_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x06021126 RID: 135462 RVA: 0x008E4343 File Offset: 0x008E2543
		// (set) Token: 0x06021127 RID: 135463 RVA: 0x008E4357 File Offset: 0x008E2557
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x06021128 RID: 135464 RVA: 0x008E436C File Offset: 0x008E256C
		// (set) Token: 0x06021129 RID: 135465 RVA: 0x008E4380 File Offset: 0x008E2580
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0602112A RID: 135466 RVA: 0x008E4395 File Offset: 0x008E2595
		// (set) Token: 0x0602112B RID: 135467 RVA: 0x008E43A9 File Offset: 0x008E25A9
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0602112C RID: 135468 RVA: 0x008E43BE File Offset: 0x008E25BE
		// (set) Token: 0x0602112D RID: 135469 RVA: 0x008E43D2 File Offset: 0x008E25D2
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0602112E RID: 135470 RVA: 0x008E43E8 File Offset: 0x008E25E8
		// (set) Token: 0x0602112F RID: 135471 RVA: 0x008E4421 File Offset: 0x008E2621
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x06021130 RID: 135472 RVA: 0x008E4430 File Offset: 0x008E2630
		// (set) Token: 0x06021131 RID: 135473 RVA: 0x008E4469 File Offset: 0x008E2669
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x06021132 RID: 135474 RVA: 0x008E4478 File Offset: 0x008E2678
		// (set) Token: 0x06021133 RID: 135475 RVA: 0x008E44B1 File Offset: 0x008E26B1
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x06021134 RID: 135476 RVA: 0x008E44BF File Offset: 0x008E26BF
		// (set) Token: 0x06021135 RID: 135477 RVA: 0x008E44CF File Offset: 0x008E26CF
		public unsafe float CenterX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x06021136 RID: 135478 RVA: 0x008E44E0 File Offset: 0x008E26E0
		// (set) Token: 0x06021137 RID: 135479 RVA: 0x008E44F0 File Offset: 0x008E26F0
		public unsafe float CenterY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x06021138 RID: 135480 RVA: 0x008E4501 File Offset: 0x008E2701
		// (set) Token: 0x06021139 RID: 135481 RVA: 0x008E4511 File Offset: 0x008E2711
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0602113A RID: 135482 RVA: 0x008E4522 File Offset: 0x008E2722
		// (set) Token: 0x0602113B RID: 135483 RVA: 0x008E4536 File Offset: 0x008E2736
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0602113C RID: 135484 RVA: 0x008E454B File Offset: 0x008E274B
		// (set) Token: 0x0602113D RID: 135485 RVA: 0x008E455B File Offset: 0x008E275B
		public unsafe float LengthIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0602113E RID: 135486 RVA: 0x008E456C File Offset: 0x008E276C
		// (set) Token: 0x0602113F RID: 135487 RVA: 0x008E457C File Offset: 0x008E277C
		public unsafe float NumSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x06021140 RID: 135488 RVA: 0x008E458D File Offset: 0x008E278D
		// (set) Token: 0x06021141 RID: 135489 RVA: 0x008E45A1 File Offset: 0x008E27A1
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x06021142 RID: 135490 RVA: 0x008E45B6 File Offset: 0x008E27B6
		// (set) Token: 0x06021143 RID: 135491 RVA: 0x008E45C6 File Offset: 0x008E27C6
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x06021144 RID: 135492 RVA: 0x008E45D7 File Offset: 0x008E27D7
		// (set) Token: 0x06021145 RID: 135493 RVA: 0x008E45E7 File Offset: 0x008E27E7
		public unsafe int ToonDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x06021146 RID: 135494 RVA: 0x008E45F8 File Offset: 0x008E27F8
		// (set) Token: 0x06021147 RID: 135495 RVA: 0x008E4608 File Offset: 0x008E2808
		public unsafe float TransitionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x06021148 RID: 135496 RVA: 0x008E4619 File Offset: 0x008E2819
		// (set) Token: 0x06021149 RID: 135497 RVA: 0x008E4629 File Offset: 0x008E2829
		public unsafe bool bEnableActorPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0602114A RID: 135498 RVA: 0x008E463A File Offset: 0x008E283A
		// (set) Token: 0x0602114B RID: 135499 RVA: 0x008E464A File Offset: 0x008E284A
		public unsafe bool DisableStencilTest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_19) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_C.__PropertyOffset_19) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0602114C RID: 135500 RVA: 0x008E465B File Offset: 0x008E285B
		// (set) Token: 0x0602114D RID: 135501 RVA: 0x008E466F File Offset: 0x008E286F
		public unsafe UMaterialInstance Material_DisableStencil
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x0602114E RID: 135502 RVA: 0x008E4684 File Offset: 0x008E2884
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0602114F RID: 135503 RVA: 0x008E4698 File Offset: 0x008E2898
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021150 RID: 135504 RVA: 0x008E46AC File Offset: 0x008E28AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021151 RID: 135505 RVA: 0x008E46C1 File Offset: 0x008E28C1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021152 RID: 135506 RVA: 0x008E46D5 File Offset: 0x008E28D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021153 RID: 135507 RVA: 0x008E46EC File Offset: 0x008E28EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SequenceShine_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SequenceShine_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceShine_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceShine_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021154 RID: 135508 RVA: 0x008E4734 File Offset: 0x008E2934
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SequenceShine_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SequenceShine_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceShine_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceShine_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021155 RID: 135509 RVA: 0x008E477B File Offset: 0x008E297B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06021156 RID: 135510 RVA: 0x008E478F File Offset: 0x008E298F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021157 RID: 135511 RVA: 0x008E47A4 File Offset: 0x008E29A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SequenceShine_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SequenceShine_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceShine_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceShine_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021158 RID: 135512 RVA: 0x008E47EC File Offset: 0x008E29EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SequenceShine_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SequenceShine_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceShine_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceShine_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021159 RID: 135513 RVA: 0x008E4833 File Offset: 0x008E2A33
		protected BP_SequenceShine_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401016C RID: 65900
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SequenceShine.BP_SequenceShine_C";

		// Token: 0x0401016D RID: 65901
		private static IntPtr _ClassPtr;

		// Token: 0x0401016E RID: 65902
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401016F RID: 65903
		internal static int __PropertyOffset_1;

		// Token: 0x04010170 RID: 65904
		internal static int __PropertyOffset_2;

		// Token: 0x04010171 RID: 65905
		internal static int __PropertyOffset_3;

		// Token: 0x04010172 RID: 65906
		internal static int __PropertyOffset_4;

		// Token: 0x04010173 RID: 65907
		internal static int __PropertyOffset_5;

		// Token: 0x04010174 RID: 65908
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04010175 RID: 65909
		internal static int __PropertyOffset_6;

		// Token: 0x04010176 RID: 65910
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04010177 RID: 65911
		internal static int __PropertyOffset_7;

		// Token: 0x04010178 RID: 65912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04010179 RID: 65913
		internal static int __PropertyOffset_8;

		// Token: 0x0401017A RID: 65914
		internal static int __PropertyOffset_9;

		// Token: 0x0401017B RID: 65915
		internal static int __PropertyOffset_10;

		// Token: 0x0401017C RID: 65916
		internal static int __PropertyOffset_11;

		// Token: 0x0401017D RID: 65917
		internal static int __PropertyOffset_12;

		// Token: 0x0401017E RID: 65918
		internal static int __PropertyOffset_13;

		// Token: 0x0401017F RID: 65919
		internal static int __PropertyOffset_14;

		// Token: 0x04010180 RID: 65920
		internal static int __PropertyOffset_15;

		// Token: 0x04010181 RID: 65921
		internal static int __PropertyOffset_16;

		// Token: 0x04010182 RID: 65922
		internal static int __PropertyOffset_17;

		// Token: 0x04010183 RID: 65923
		internal static int __PropertyOffset_18;

		// Token: 0x04010184 RID: 65924
		internal static int __PropertyOffset_19;

		// Token: 0x04010185 RID: 65925
		internal static int __PropertyOffset_20;

		// Token: 0x04010186 RID: 65926
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x04010187 RID: 65927
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04010188 RID: 65928
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04010189 RID: 65929
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0401018A RID: 65930
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x0401018B RID: 65931
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C6B RID: 40043
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031329 RID: 201513
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C6C RID: 40044
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403132A RID: 201514
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
