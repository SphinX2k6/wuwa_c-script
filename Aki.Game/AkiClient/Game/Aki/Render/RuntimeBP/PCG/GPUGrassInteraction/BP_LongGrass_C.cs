using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUGrassInteraction
{
	// Token: 0x02003CA6 RID: 15526
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUGrassInteraction/BP_LongGrass.BP_LongGrass_C")]
	[UnrealStructLayout(1608, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1601)]
	public class BP_LongGrass_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024776 RID: 149366 RVA: 0x0093F964 File Offset: 0x0093DB64
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LongGrass_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUGrassInteraction/BP_LongGrass.BP_LongGrass_C");
			}
			return BP_LongGrass_C._ClassPtr;
		}

		// Token: 0x06024777 RID: 149367 RVA: 0x0093F988 File Offset: 0x0093DB88
		public BP_LongGrass_C() : this(BuiltinUtils.AllocNativeUObject(BP_LongGrass_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024778 RID: 149368 RVA: 0x0093F9B0 File Offset: 0x0093DBB0
		[NullableContext(1)]
		public BP_LongGrass_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LongGrass_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004736 RID: 18230
		// (get) Token: 0x06024779 RID: 149369 RVA: 0x0093F9E3 File Offset: 0x0093DBE3
		// (set) Token: 0x0602477A RID: 149370 RVA: 0x0093F9F7 File Offset: 0x0093DBF7
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004737 RID: 18231
		// (get) Token: 0x0602477B RID: 149371 RVA: 0x0093FA0C File Offset: 0x0093DC0C
		// (set) Token: 0x0602477C RID: 149372 RVA: 0x0093FA20 File Offset: 0x0093DC20
		public unsafe UStaticMeshComponent Static_Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004738 RID: 18232
		// (get) Token: 0x0602477D RID: 149373 RVA: 0x0093FA35 File Offset: 0x0093DC35
		// (set) Token: 0x0602477E RID: 149374 RVA: 0x0093FA49 File Offset: 0x0093DC49
		public unsafe UNiagaraComponent NS_FX_LongGrass
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004739 RID: 18233
		// (get) Token: 0x0602477F RID: 149375 RVA: 0x0093FA5E File Offset: 0x0093DC5E
		// (set) Token: 0x06024780 RID: 149376 RVA: 0x0093FA72 File Offset: 0x0093DC72
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700473A RID: 18234
		// (get) Token: 0x06024781 RID: 149377 RVA: 0x0093FA87 File Offset: 0x0093DC87
		// (set) Token: 0x06024782 RID: 149378 RVA: 0x0093FA9B File Offset: 0x0093DC9B
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700473B RID: 18235
		// (get) Token: 0x06024783 RID: 149379 RVA: 0x0093FAB0 File Offset: 0x0093DCB0
		// (set) Token: 0x06024784 RID: 149380 RVA: 0x0093FAC4 File Offset: 0x0093DCC4
		public unsafe UHoudiniPointCache HoudiniPointCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHoudiniPointCache>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x1700473C RID: 18236
		// (get) Token: 0x06024785 RID: 149381 RVA: 0x0093FAD9 File Offset: 0x0093DCD9
		// (set) Token: 0x06024786 RID: 149382 RVA: 0x0093FAE9 File Offset: 0x0093DCE9
		public unsafe int BoneCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700473D RID: 18237
		// (get) Token: 0x06024787 RID: 149383 RVA: 0x0093FAFA File Offset: 0x0093DCFA
		// (set) Token: 0x06024788 RID: 149384 RVA: 0x0093FB0A File Offset: 0x0093DD0A
		public unsafe bool bAllowDebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_8) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_8) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700473E RID: 18238
		// (get) Token: 0x06024789 RID: 149385 RVA: 0x0093FB1B File Offset: 0x0093DD1B
		// (set) Token: 0x0602478A RID: 149386 RVA: 0x0093FB2F File Offset: 0x0093DD2F
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x1700473F RID: 18239
		// (get) Token: 0x0602478B RID: 149387 RVA: 0x0093FB44 File Offset: 0x0093DD44
		// (set) Token: 0x0602478C RID: 149388 RVA: 0x0093FB58 File Offset: 0x0093DD58
		public unsafe UTextureRenderTarget2D RT_Rot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17004740 RID: 18240
		// (get) Token: 0x0602478D RID: 149389 RVA: 0x0093FB6D File Offset: 0x0093DD6D
		// (set) Token: 0x0602478E RID: 149390 RVA: 0x0093FB7D File Offset: 0x0093DD7D
		public unsafe int First_Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004741 RID: 18241
		// (get) Token: 0x0602478F RID: 149391 RVA: 0x0093FB8E File Offset: 0x0093DD8E
		// (set) Token: 0x06024790 RID: 149392 RVA: 0x0093FB9E File Offset: 0x0093DD9E
		public unsafe int Last_Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17004742 RID: 18242
		// (get) Token: 0x06024791 RID: 149393 RVA: 0x0093FBAF File Offset: 0x0093DDAF
		// (set) Token: 0x06024792 RID: 149394 RVA: 0x0093FBBF File Offset: 0x0093DDBF
		public unsafe int InteractionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17004743 RID: 18243
		// (get) Token: 0x06024793 RID: 149395 RVA: 0x0093FBD0 File Offset: 0x0093DDD0
		// (set) Token: 0x06024794 RID: 149396 RVA: 0x0093FBE4 File Offset: 0x0093DDE4
		public unsafe UMaterialInterface Dynamic_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_14);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_14, value);
			}
		}

		// Token: 0x17004744 RID: 18244
		// (get) Token: 0x06024795 RID: 149397 RVA: 0x0093FBF9 File Offset: 0x0093DDF9
		// (set) Token: 0x06024796 RID: 149398 RVA: 0x0093FC09 File Offset: 0x0093DE09
		public unsafe bool Active
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004745 RID: 18245
		// (get) Token: 0x06024797 RID: 149399 RVA: 0x0093FC1A File Offset: 0x0093DE1A
		// (set) Token: 0x06024798 RID: 149400 RVA: 0x0093FC2A File Offset: 0x0093DE2A
		public unsafe bool StopAlready
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004746 RID: 18246
		// (get) Token: 0x06024799 RID: 149401 RVA: 0x0093FC3B File Offset: 0x0093DE3B
		// (set) Token: 0x0602479A RID: 149402 RVA: 0x0093FC4B File Offset: 0x0093DE4B
		public unsafe float TickTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17004747 RID: 18247
		// (get) Token: 0x0602479B RID: 149403 RVA: 0x0093FC5C File Offset: 0x0093DE5C
		// (set) Token: 0x0602479C RID: 149404 RVA: 0x0093FC70 File Offset: 0x0093DE70
		public unsafe UMaterialInterface Static_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004748 RID: 18248
		// (get) Token: 0x0602479D RID: 149405 RVA: 0x0093FC88 File Offset: 0x0093DE88
		// (set) Token: 0x0602479E RID: 149406 RVA: 0x0093FCC1 File Offset: 0x0093DEC1
		[Nullable(1)]
		public TArray<float> CustomData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomData) == null)
				{
					result = (this._CustomData = new TArray<float>(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_19, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x17004749 RID: 18249
		// (get) Token: 0x0602479F RID: 149407 RVA: 0x0093FCCF File Offset: 0x0093DECF
		// (set) Token: 0x060247A0 RID: 149408 RVA: 0x0093FCE3 File Offset: 0x0093DEE3
		public unsafe BP_GPUFoliageInteraction_C DataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GPUFoliageInteraction_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_20);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LongGrass_C.__PropertyOffset_20, value);
			}
		}

		// Token: 0x1700474A RID: 18250
		// (get) Token: 0x060247A1 RID: 149409 RVA: 0x0093FCF8 File Offset: 0x0093DEF8
		// (set) Token: 0x060247A2 RID: 149410 RVA: 0x0093FD08 File Offset: 0x0093DF08
		public unsafe bool UseDataAsset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_LongGrass_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x060247A3 RID: 149411 RVA: 0x0093FD1C File Offset: 0x0093DF1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CopyCustomPrimitiveData(UStaticMeshComponent Target)
		{
			BP_LongGrass_C.__CopyCustomPrimitiveData_FunctionParams* ptr = stackalloc BP_LongGrass_C.__CopyCustomPrimitiveData_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_LongGrass_C.__CopyCustomPrimitiveData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LongGrass_C.__CopyCustomPrimitiveData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__CopyCustomPrimitiveData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060247A4 RID: 149412 RVA: 0x0093FD71 File Offset: 0x0093DF71
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Params_And_MID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__Set_Params_And_MID_NativeFunctionPtr, null);
		}

		// Token: 0x060247A5 RID: 149413 RVA: 0x0093FD85 File Offset: 0x0093DF85
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Stop_Interaction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__Stop_Interaction_NativeFunctionPtr, null);
		}

		// Token: 0x060247A6 RID: 149414 RVA: 0x0093FD99 File Offset: 0x0093DF99
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Draw_Transfrom()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__Draw_Transfrom_NativeFunctionPtr, null);
		}

		// Token: 0x060247A7 RID: 149415 RVA: 0x0093FDAD File Offset: 0x0093DFAD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Clear_RT()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__Clear_RT_NativeFunctionPtr, null);
		}

		// Token: 0x060247A8 RID: 149416 RVA: 0x0093FDC1 File Offset: 0x0093DFC1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060247A9 RID: 149417 RVA: 0x0093FDD5 File Offset: 0x0093DFD5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LongGrass_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060247AA RID: 149418 RVA: 0x0093FDEC File Offset: 0x0093DFEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060247AB RID: 149419 RVA: 0x0093FE78 File Offset: 0x0093E078
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_LongGrass_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LongGrass_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LongGrass_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LongGrass_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060247AC RID: 149420 RVA: 0x0093FEC0 File Offset: 0x0093E0C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_LongGrass_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_LongGrass_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LongGrass_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LongGrass_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LongGrass_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060247AD RID: 149421 RVA: 0x0093FF08 File Offset: 0x0093E108
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060247AE RID: 149422 RVA: 0x0093FFC4 File Offset: 0x0093E1C4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void EditorTick(float DeltaSeconds)
		{
			BP_LongGrass_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LongGrass_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LongGrass_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LongGrass_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LongGrass_C.__EditorTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060247AF RID: 149423 RVA: 0x0094000C File Offset: 0x0093E20C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void EditorTick_Implementation(float DeltaSeconds)
		{
			BP_LongGrass_C.__EditorTick_FunctionParams* ptr = stackalloc BP_LongGrass_C.__EditorTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_LongGrass_C.__EditorTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_LongGrass_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_LongGrass_C.__EditorTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060247B0 RID: 149424 RVA: 0x00940053 File Offset: 0x0093E253
		protected BP_LongGrass_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040121A0 RID: 74144
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUGrassInteraction/BP_LongGrass.BP_LongGrass_C";

		// Token: 0x040121A1 RID: 74145
		private static IntPtr _ClassPtr;

		// Token: 0x040121A2 RID: 74146
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040121A3 RID: 74147
		internal static int __PropertyOffset_1;

		// Token: 0x040121A4 RID: 74148
		internal static int __PropertyOffset_2;

		// Token: 0x040121A5 RID: 74149
		internal static int __PropertyOffset_3;

		// Token: 0x040121A6 RID: 74150
		internal static int __PropertyOffset_4;

		// Token: 0x040121A7 RID: 74151
		internal static int __PropertyOffset_5;

		// Token: 0x040121A8 RID: 74152
		internal static int __PropertyOffset_6;

		// Token: 0x040121A9 RID: 74153
		internal static int __PropertyOffset_7;

		// Token: 0x040121AA RID: 74154
		internal static int __PropertyOffset_8;

		// Token: 0x040121AB RID: 74155
		internal static int __PropertyOffset_9;

		// Token: 0x040121AC RID: 74156
		internal static int __PropertyOffset_10;

		// Token: 0x040121AD RID: 74157
		internal static int __PropertyOffset_11;

		// Token: 0x040121AE RID: 74158
		internal static int __PropertyOffset_12;

		// Token: 0x040121AF RID: 74159
		internal static int __PropertyOffset_13;

		// Token: 0x040121B0 RID: 74160
		internal static int __PropertyOffset_14;

		// Token: 0x040121B1 RID: 74161
		internal static int __PropertyOffset_15;

		// Token: 0x040121B2 RID: 74162
		internal static int __PropertyOffset_16;

		// Token: 0x040121B3 RID: 74163
		internal static int __PropertyOffset_17;

		// Token: 0x040121B4 RID: 74164
		internal static int __PropertyOffset_18;

		// Token: 0x040121B5 RID: 74165
		internal static int __PropertyOffset_19;

		// Token: 0x040121B6 RID: 74166
		private TArray<float> _CustomData;

		// Token: 0x040121B7 RID: 74167
		internal static int __PropertyOffset_20;

		// Token: 0x040121B8 RID: 74168
		internal static int __PropertyOffset_21;

		// Token: 0x040121B9 RID: 74169
		private static IntPtr __CopyCustomPrimitiveData_NativeFunctionPtr;

		// Token: 0x040121BA RID: 74170
		private static IntPtr __Set_Params_And_MID_NativeFunctionPtr;

		// Token: 0x040121BB RID: 74171
		private static IntPtr __Stop_Interaction_NativeFunctionPtr;

		// Token: 0x040121BC RID: 74172
		private static IntPtr __Draw_Transfrom_NativeFunctionPtr;

		// Token: 0x040121BD RID: 74173
		private static IntPtr __Clear_RT_NativeFunctionPtr;

		// Token: 0x040121BE RID: 74174
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040121BF RID: 74175
		private static IntPtr __BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040121C0 RID: 74176
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040121C1 RID: 74177
		private static IntPtr __BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040121C2 RID: 74178
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009F28 RID: 40744
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CopyCustomPrimitiveData_FunctionParams
		{
			// Token: 0x040318A2 RID: 202914
			[FieldOffset(0)]
			public IntPtr Target;
		}

		// Token: 0x02009F29 RID: 40745
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318A3 RID: 202915
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040318A4 RID: 202916
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318A5 RID: 202917
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318A6 RID: 202918
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009F2A RID: 40746
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040318A7 RID: 202919
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009F2B RID: 40747
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040318A8 RID: 202920
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040318A9 RID: 202921
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040318AA RID: 202922
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040318AB RID: 202923
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040318AC RID: 202924
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040318AD RID: 202925
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009F2C RID: 40748
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __EditorTick_FunctionParams
		{
			// Token: 0x040318AE RID: 202926
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
