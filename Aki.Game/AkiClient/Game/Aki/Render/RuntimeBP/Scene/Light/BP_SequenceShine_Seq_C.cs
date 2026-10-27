using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Light
{
	// Token: 0x02003B19 RID: 15129
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SequenceShine_Seq.BP_SequenceShine_Seq_C")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1813)]
	public class BP_SequenceShine_Seq_C : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602115A RID: 135514 RVA: 0x008E483C File Offset: 0x008E2A3C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SequenceShine_Seq_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SequenceShine_Seq.BP_SequenceShine_Seq_C");
			}
			return BP_SequenceShine_Seq_C._ClassPtr;
		}

		// Token: 0x0602115B RID: 135515 RVA: 0x008E4860 File Offset: 0x008E2A60
		public BP_SequenceShine_Seq_C() : this(BuiltinUtils.AllocNativeUObject(BP_SequenceShine_Seq_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602115C RID: 135516 RVA: 0x008E4888 File Offset: 0x008E2A88
		[NullableContext(1)]
		public BP_SequenceShine_Seq_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SequenceShine_Seq_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0602115D RID: 135517 RVA: 0x008E48BB File Offset: 0x008E2ABB
		// (set) Token: 0x0602115E RID: 135518 RVA: 0x008E48CF File Offset: 0x008E2ACF
		public unsafe UKuroGameBudgetComponent KuroGameBudget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGameBudgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0602115F RID: 135519 RVA: 0x008E48E4 File Offset: 0x008E2AE4
		// (set) Token: 0x06021160 RID: 135520 RVA: 0x008E48F8 File Offset: 0x008E2AF8
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x06021161 RID: 135521 RVA: 0x008E490D File Offset: 0x008E2B0D
		// (set) Token: 0x06021162 RID: 135522 RVA: 0x008E4921 File Offset: 0x008E2B21
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x06021163 RID: 135523 RVA: 0x008E4936 File Offset: 0x008E2B36
		// (set) Token: 0x06021164 RID: 135524 RVA: 0x008E494A File Offset: 0x008E2B4A
		public unsafe UMaterialInstanceDynamic DynamicMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x06021165 RID: 135525 RVA: 0x008E4960 File Offset: 0x008E2B60
		// (set) Token: 0x06021166 RID: 135526 RVA: 0x008E4999 File Offset: 0x008E2B99
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
					result = (this._Scalar_Parameters = new TMap<FName, float>(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_5, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Scalar_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x06021167 RID: 135527 RVA: 0x008E49A8 File Offset: 0x008E2BA8
		// (set) Token: 0x06021168 RID: 135528 RVA: 0x008E49E1 File Offset: 0x008E2BE1
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
					result = (this._Vector_Parameters = new TMap<FName, FLinearColor>(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_6, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Vector_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x06021169 RID: 135529 RVA: 0x008E49F0 File Offset: 0x008E2BF0
		// (set) Token: 0x0602116A RID: 135530 RVA: 0x008E4A29 File Offset: 0x008E2C29
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
					result = (this._Texture_Parameters = new TMap<FName, UTexture>(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_7, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Texture_Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0602116B RID: 135531 RVA: 0x008E4A37 File Offset: 0x008E2C37
		// (set) Token: 0x0602116C RID: 135532 RVA: 0x008E4A4B File Offset: 0x008E2C4B
		public unsafe UMaterialInstance Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0602116D RID: 135533 RVA: 0x008E4A60 File Offset: 0x008E2C60
		// (set) Token: 0x0602116E RID: 135534 RVA: 0x008E4A70 File Offset: 0x008E2C70
		public unsafe float LengthIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0602116F RID: 135535 RVA: 0x008E4A81 File Offset: 0x008E2C81
		// (set) Token: 0x06021170 RID: 135536 RVA: 0x008E4A91 File Offset: 0x008E2C91
		public unsafe float NumSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x06021171 RID: 135537 RVA: 0x008E4AA2 File Offset: 0x008E2CA2
		// (set) Token: 0x06021172 RID: 135538 RVA: 0x008E4AB6 File Offset: 0x008E2CB6
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x06021173 RID: 135539 RVA: 0x008E4ACB File Offset: 0x008E2CCB
		// (set) Token: 0x06021174 RID: 135540 RVA: 0x008E4ADB File Offset: 0x008E2CDB
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x06021175 RID: 135541 RVA: 0x008E4AEC File Offset: 0x008E2CEC
		// (set) Token: 0x06021176 RID: 135542 RVA: 0x008E4AFC File Offset: 0x008E2CFC
		public unsafe int ToonDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x06021177 RID: 135543 RVA: 0x008E4B0D File Offset: 0x008E2D0D
		// (set) Token: 0x06021178 RID: 135544 RVA: 0x008E4B1D File Offset: 0x008E2D1D
		public unsafe float CharacterIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x06021179 RID: 135545 RVA: 0x008E4B2E File Offset: 0x008E2D2E
		// (set) Token: 0x0602117A RID: 135546 RVA: 0x008E4B42 File Offset: 0x008E2D42
		public unsafe UMaterialInstance Material_DisableStencil
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceShine_Seq_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0602117B RID: 135547 RVA: 0x008E4B57 File Offset: 0x008E2D57
		// (set) Token: 0x0602117C RID: 135548 RVA: 0x008E4B67 File Offset: 0x008E2D67
		public unsafe float ShineIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0602117D RID: 135549 RVA: 0x008E4B78 File Offset: 0x008E2D78
		// (set) Token: 0x0602117E RID: 135550 RVA: 0x008E4B88 File Offset: 0x008E2D88
		public unsafe bool EnableSimLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0602117F RID: 135551 RVA: 0x008E4B99 File Offset: 0x008E2D99
		// (set) Token: 0x06021180 RID: 135552 RVA: 0x008E4BA9 File Offset: 0x008E2DA9
		public unsafe float SimLightUV_X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x06021181 RID: 135553 RVA: 0x008E4BBA File Offset: 0x008E2DBA
		// (set) Token: 0x06021182 RID: 135554 RVA: 0x008E4BCA File Offset: 0x008E2DCA
		public unsafe float SimLightUV_Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x06021183 RID: 135555 RVA: 0x008E4BDB File Offset: 0x008E2DDB
		// (set) Token: 0x06021184 RID: 135556 RVA: 0x008E4BEB File Offset: 0x008E2DEB
		public unsafe float SimLightRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x06021185 RID: 135557 RVA: 0x008E4BFC File Offset: 0x008E2DFC
		// (set) Token: 0x06021186 RID: 135558 RVA: 0x008E4C0C File Offset: 0x008E2E0C
		public unsafe float SimLightDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x06021187 RID: 135559 RVA: 0x008E4C1D File Offset: 0x008E2E1D
		// (set) Token: 0x06021188 RID: 135560 RVA: 0x008E4C2D File Offset: 0x008E2E2D
		public unsafe float SimLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x06021189 RID: 135561 RVA: 0x008E4C3E File Offset: 0x008E2E3E
		// (set) Token: 0x0602118A RID: 135562 RVA: 0x008E4C4E File Offset: 0x008E2E4E
		public unsafe bool DebugSimLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceShine_Seq_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602118B RID: 135563 RVA: 0x008E4C5F File Offset: 0x008E2E5F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void SetParameter()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__SetParameter_NativeFunctionPtr, null);
		}

		// Token: 0x0602118C RID: 135564 RVA: 0x008E4C73 File Offset: 0x008E2E73
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0602118D RID: 135565 RVA: 0x008E4C87 File Offset: 0x008E2E87
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602118E RID: 135566 RVA: 0x008E4C9C File Offset: 0x008E2E9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602118F RID: 135567 RVA: 0x008E4CB0 File Offset: 0x008E2EB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021190 RID: 135568 RVA: 0x008E4CC8 File Offset: 0x008E2EC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_SequenceShine_Seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SequenceShine_Seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceShine_Seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceShine_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021191 RID: 135569 RVA: 0x008E4D10 File Offset: 0x008E2F10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_SequenceShine_Seq_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_SequenceShine_Seq_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceShine_Seq_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceShine_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021192 RID: 135570 RVA: 0x008E4D57 File Offset: 0x008E2F57
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveDestroyed()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__ReceiveDestroyed_NativeFunctionPtr, null);
		}

		// Token: 0x06021193 RID: 135571 RVA: 0x008E4D6B File Offset: 0x008E2F6B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveDestroyed_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__ReceiveDestroyed_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021194 RID: 135572 RVA: 0x008E4D80 File Offset: 0x008E2F80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_SequenceShine_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SequenceShine_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceShine_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceShine_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021195 RID: 135573 RVA: 0x008E4DC8 File Offset: 0x008E2FC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_SequenceShine_Seq_C.__EditorTick_FunctionParams* ptr = stackalloc BP_SequenceShine_Seq_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_SequenceShine_Seq_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_SequenceShine_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_SequenceShine_Seq_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021196 RID: 135574 RVA: 0x008E4E0F File Offset: 0x008E300F
		protected BP_SequenceShine_Seq_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401018C RID: 65932
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Light/BP_SequenceShine_Seq.BP_SequenceShine_Seq_C";

		// Token: 0x0401018D RID: 65933
		private static IntPtr _ClassPtr;

		// Token: 0x0401018E RID: 65934
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401018F RID: 65935
		internal static int __PropertyOffset_1;

		// Token: 0x04010190 RID: 65936
		internal static int __PropertyOffset_2;

		// Token: 0x04010191 RID: 65937
		internal static int __PropertyOffset_3;

		// Token: 0x04010192 RID: 65938
		internal static int __PropertyOffset_4;

		// Token: 0x04010193 RID: 65939
		internal static int __PropertyOffset_5;

		// Token: 0x04010194 RID: 65940
		private TMap<FName, float> _Scalar_Parameters;

		// Token: 0x04010195 RID: 65941
		internal static int __PropertyOffset_6;

		// Token: 0x04010196 RID: 65942
		private TMap<FName, FLinearColor> _Vector_Parameters;

		// Token: 0x04010197 RID: 65943
		internal static int __PropertyOffset_7;

		// Token: 0x04010198 RID: 65944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UTexture> _Texture_Parameters;

		// Token: 0x04010199 RID: 65945
		internal static int __PropertyOffset_8;

		// Token: 0x0401019A RID: 65946
		internal static int __PropertyOffset_9;

		// Token: 0x0401019B RID: 65947
		internal static int __PropertyOffset_10;

		// Token: 0x0401019C RID: 65948
		internal static int __PropertyOffset_11;

		// Token: 0x0401019D RID: 65949
		internal static int __PropertyOffset_12;

		// Token: 0x0401019E RID: 65950
		internal static int __PropertyOffset_13;

		// Token: 0x0401019F RID: 65951
		internal static int __PropertyOffset_14;

		// Token: 0x040101A0 RID: 65952
		internal static int __PropertyOffset_15;

		// Token: 0x040101A1 RID: 65953
		internal static int __PropertyOffset_16;

		// Token: 0x040101A2 RID: 65954
		internal static int __PropertyOffset_17;

		// Token: 0x040101A3 RID: 65955
		internal static int __PropertyOffset_18;

		// Token: 0x040101A4 RID: 65956
		internal static int __PropertyOffset_19;

		// Token: 0x040101A5 RID: 65957
		internal static int __PropertyOffset_20;

		// Token: 0x040101A6 RID: 65958
		internal static int __PropertyOffset_21;

		// Token: 0x040101A7 RID: 65959
		internal static int __PropertyOffset_22;

		// Token: 0x040101A8 RID: 65960
		internal static int __PropertyOffset_23;

		// Token: 0x040101A9 RID: 65961
		private static IntPtr __SetParameter_NativeFunctionPtr;

		// Token: 0x040101AA RID: 65962
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040101AB RID: 65963
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040101AC RID: 65964
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040101AD RID: 65965
		private static IntPtr __ReceiveDestroyed_NativeFunctionPtr;

		// Token: 0x040101AE RID: 65966
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009C6D RID: 40045
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403132B RID: 201515
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009C6E RID: 40046
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x0403132C RID: 201516
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
