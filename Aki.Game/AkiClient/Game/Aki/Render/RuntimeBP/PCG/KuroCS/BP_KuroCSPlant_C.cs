using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUGrassInteraction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.KuroCS
{
	// Token: 0x02003C86 RID: 15494
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/KuroCS/BP_KuroCSPlant.BP_KuroCSPlant_C")]
	[UnrealStructLayout(1496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1490)]
	public class BP_KuroCSPlant_C : AKuroCSSkeltalPlant, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602428E RID: 148110 RVA: 0x00936548 File Offset: 0x00934748
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCSPlant_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/BP_KuroCSPlant.BP_KuroCSPlant_C");
			}
			return BP_KuroCSPlant_C._ClassPtr;
		}

		// Token: 0x0602428F RID: 148111 RVA: 0x0093656C File Offset: 0x0093476C
		public BP_KuroCSPlant_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSPlant_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024290 RID: 148112 RVA: 0x00936594 File Offset: 0x00934794
		[NullableContext(1)]
		public BP_KuroCSPlant_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCSPlant_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004597 RID: 17815
		// (get) Token: 0x06024291 RID: 148113 RVA: 0x009365C7 File Offset: 0x009347C7
		// (set) Token: 0x06024292 RID: 148114 RVA: 0x009365DB File Offset: 0x009347DB
		public unsafe UStaticMeshComponent StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004598 RID: 17816
		// (get) Token: 0x06024293 RID: 148115 RVA: 0x009365F0 File Offset: 0x009347F0
		// (set) Token: 0x06024294 RID: 148116 RVA: 0x00936604 File Offset: 0x00934804
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004599 RID: 17817
		// (get) Token: 0x06024295 RID: 148117 RVA: 0x00936619 File Offset: 0x00934819
		// (set) Token: 0x06024296 RID: 148118 RVA: 0x0093662D File Offset: 0x0093482D
		public unsafe UStaticMesh Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700459A RID: 17818
		// (get) Token: 0x06024297 RID: 148119 RVA: 0x00936642 File Offset: 0x00934842
		// (set) Token: 0x06024298 RID: 148120 RVA: 0x00936652 File Offset: 0x00934852
		public unsafe int First_Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700459B RID: 17819
		// (get) Token: 0x06024299 RID: 148121 RVA: 0x00936663 File Offset: 0x00934863
		// (set) Token: 0x0602429A RID: 148122 RVA: 0x00936673 File Offset: 0x00934873
		public unsafe int Last_Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700459C RID: 17820
		// (get) Token: 0x0602429B RID: 148123 RVA: 0x00936684 File Offset: 0x00934884
		// (set) Token: 0x0602429C RID: 148124 RVA: 0x00936694 File Offset: 0x00934894
		public unsafe bool MultiMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700459D RID: 17821
		// (get) Token: 0x0602429D RID: 148125 RVA: 0x009366A5 File Offset: 0x009348A5
		// (set) Token: 0x0602429E RID: 148126 RVA: 0x009366B9 File Offset: 0x009348B9
		public unsafe UMaterialInterface Dynamic_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700459E RID: 17822
		// (get) Token: 0x0602429F RID: 148127 RVA: 0x009366CE File Offset: 0x009348CE
		// (set) Token: 0x060242A0 RID: 148128 RVA: 0x009366E2 File Offset: 0x009348E2
		public unsafe UMaterialInterface Static_Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700459F RID: 17823
		// (get) Token: 0x060242A1 RID: 148129 RVA: 0x009366F8 File Offset: 0x009348F8
		// (set) Token: 0x060242A2 RID: 148130 RVA: 0x00936731 File Offset: 0x00934931
		[Nullable(1)]
		public TArray<UMaterialInterface> Dynamic_Material_list
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Dynamic_Material_list) == null)
				{
					result = (this._Dynamic_Material_list = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_9, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Dynamic_Material_list.CopyAssign(value);
			}
		}

		// Token: 0x170045A0 RID: 17824
		// (get) Token: 0x060242A3 RID: 148131 RVA: 0x00936740 File Offset: 0x00934940
		// (set) Token: 0x060242A4 RID: 148132 RVA: 0x00936779 File Offset: 0x00934979
		[Nullable(1)]
		public TArray<UMaterialInterface> Static_Material_list
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Static_Material_list) == null)
				{
					result = (this._Static_Material_list = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_10, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Static_Material_list.CopyAssign(value);
			}
		}

		// Token: 0x170045A1 RID: 17825
		// (get) Token: 0x060242A5 RID: 148133 RVA: 0x00936788 File Offset: 0x00934988
		// (set) Token: 0x060242A6 RID: 148134 RVA: 0x009367C1 File Offset: 0x009349C1
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
					result = (this._CustomData = new TArray<float>(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_11, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x170045A2 RID: 17826
		// (get) Token: 0x060242A7 RID: 148135 RVA: 0x009367CF File Offset: 0x009349CF
		// (set) Token: 0x060242A8 RID: 148136 RVA: 0x009367E3 File Offset: 0x009349E3
		public unsafe BP_GPUFoliageInteraction_C DataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_GPUFoliageInteraction_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCSPlant_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x170045A3 RID: 17827
		// (get) Token: 0x060242A9 RID: 148137 RVA: 0x009367F8 File Offset: 0x009349F8
		// (set) Token: 0x060242AA RID: 148138 RVA: 0x00936831 File Offset: 0x00934A31
		[Nullable(1)]
		public FKuroCurveFloat Curve_Float
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Curve_Float) == null)
				{
					result = (this._Curve_Float = new FKuroCurveFloat(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_13, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_13, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170045A4 RID: 17828
		// (get) Token: 0x060242AB RID: 148139 RVA: 0x00936852 File Offset: 0x00934A52
		// (set) Token: 0x060242AC RID: 148140 RVA: 0x00936862 File Offset: 0x00934A62
		public unsafe bool InitOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045A5 RID: 17829
		// (get) Token: 0x060242AD RID: 148141 RVA: 0x00936873 File Offset: 0x00934A73
		// (set) Token: 0x060242AE RID: 148142 RVA: 0x00936883 File Offset: 0x00934A83
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCSPlant_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x060242AF RID: 148143 RVA: 0x00936894 File Offset: 0x00934A94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void DebugDraw()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__DebugDraw_NativeFunctionPtr, null);
		}

		// Token: 0x060242B0 RID: 148144 RVA: 0x009368A8 File Offset: 0x00934AA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_CS_Data_From_DA()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__Set_CS_Data_From_DA_NativeFunctionPtr, null);
		}

		// Token: 0x060242B1 RID: 148145 RVA: 0x009368BC File Offset: 0x00934ABC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CopyCustomPrimitiveData(UStaticMeshComponent Target)
		{
			BP_KuroCSPlant_C.__CopyCustomPrimitiveData_FunctionParams* ptr = stackalloc BP_KuroCSPlant_C.__CopyCustomPrimitiveData_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCSPlant_C.__CopyCustomPrimitiveData_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlant_C.__CopyCustomPrimitiveData_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__CopyCustomPrimitiveData_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060242B2 RID: 148146 RVA: 0x00936914 File Offset: 0x00934B14
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual bool Set_Plant_Data(Struct_GPUInteractiveFoliage Foliage_Data)
		{
			BP_KuroCSPlant_C.__Set_Plant_Data_FunctionParams* ptr = stackalloc BP_KuroCSPlant_C.__Set_Plant_Data_FunctionParams[(UIntPtr)591] + 15L / (long)sizeof(BP_KuroCSPlant_C.__Set_Plant_Data_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlant_C.__Set_Plant_Data_NativeFunctionPtr, (void*)ptr, 1);
			if (Foliage_Data != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(Struct_GPUInteractiveFoliage.StaticStruct(), &ptr->Foliage_Data, Foliage_Data.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__Set_Plant_Data_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(BP_KuroCSPlant_C.__Set_Plant_Data_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060242B3 RID: 148147 RVA: 0x0093698F File Offset: 0x00934B8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Params_And_MID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__Set_Params_And_MID_NativeFunctionPtr, null);
		}

		// Token: 0x060242B4 RID: 148148 RVA: 0x009369A3 File Offset: 0x00934BA3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Stop_Interaction()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__Stop_Interaction_NativeFunctionPtr, null);
		}

		// Token: 0x060242B5 RID: 148149 RVA: 0x009369B7 File Offset: 0x00934BB7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Draw_Transfrom()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__Draw_Transfrom_NativeFunctionPtr, null);
		}

		// Token: 0x060242B6 RID: 148150 RVA: 0x009369CB File Offset: 0x00934BCB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060242B7 RID: 148151 RVA: 0x009369DF File Offset: 0x00934BDF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSPlant_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060242B8 RID: 148152 RVA: 0x009369F4 File Offset: 0x00934BF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_KuroCSPlant_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSPlant_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSPlant_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlant_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060242B9 RID: 148153 RVA: 0x00936A3C File Offset: 0x00934C3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_KuroCSPlant_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_KuroCSPlant_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_KuroCSPlant_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlant_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSPlant_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060242BA RID: 148154 RVA: 0x00936A84 File Offset: 0x00934C84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060242BB RID: 148155 RVA: 0x00936B40 File Offset: 0x00934D40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060242BC RID: 148156 RVA: 0x00936BC9 File Offset: 0x00934DC9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060242BD RID: 148157 RVA: 0x00936BDD File Offset: 0x00934DDD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSPlant_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060242BE RID: 148158 RVA: 0x00936BF4 File Offset: 0x00934DF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSPlant_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSPlant_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSPlant_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlant_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCSPlant_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060242BF RID: 148159 RVA: 0x00936C40 File Offset: 0x00934E40
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_KuroCSPlant_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_KuroCSPlant_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_KuroCSPlant_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_KuroCSPlant_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCSPlant_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x060242C0 RID: 148160 RVA: 0x00936C8C File Offset: 0x00934E8C
		protected BP_KuroCSPlant_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011E7C RID: 73340
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/KuroCS/BP_KuroCSPlant.BP_KuroCSPlant_C";

		// Token: 0x04011E7D RID: 73341
		private static IntPtr _ClassPtr;

		// Token: 0x04011E7E RID: 73342
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011E7F RID: 73343
		internal static int __PropertyOffset_1;

		// Token: 0x04011E80 RID: 73344
		internal static int __PropertyOffset_2;

		// Token: 0x04011E81 RID: 73345
		internal static int __PropertyOffset_3;

		// Token: 0x04011E82 RID: 73346
		internal static int __PropertyOffset_4;

		// Token: 0x04011E83 RID: 73347
		internal static int __PropertyOffset_5;

		// Token: 0x04011E84 RID: 73348
		internal static int __PropertyOffset_6;

		// Token: 0x04011E85 RID: 73349
		internal static int __PropertyOffset_7;

		// Token: 0x04011E86 RID: 73350
		internal static int __PropertyOffset_8;

		// Token: 0x04011E87 RID: 73351
		internal static int __PropertyOffset_9;

		// Token: 0x04011E88 RID: 73352
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Dynamic_Material_list;

		// Token: 0x04011E89 RID: 73353
		internal static int __PropertyOffset_10;

		// Token: 0x04011E8A RID: 73354
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Static_Material_list;

		// Token: 0x04011E8B RID: 73355
		internal static int __PropertyOffset_11;

		// Token: 0x04011E8C RID: 73356
		private TArray<float> _CustomData;

		// Token: 0x04011E8D RID: 73357
		internal static int __PropertyOffset_12;

		// Token: 0x04011E8E RID: 73358
		internal static int __PropertyOffset_13;

		// Token: 0x04011E8F RID: 73359
		private FKuroCurveFloat _Curve_Float;

		// Token: 0x04011E90 RID: 73360
		internal static int __PropertyOffset_14;

		// Token: 0x04011E91 RID: 73361
		internal static int __PropertyOffset_15;

		// Token: 0x04011E92 RID: 73362
		private static IntPtr __DebugDraw_NativeFunctionPtr;

		// Token: 0x04011E93 RID: 73363
		private static IntPtr __Set_CS_Data_From_DA_NativeFunctionPtr;

		// Token: 0x04011E94 RID: 73364
		private static IntPtr __CopyCustomPrimitiveData_NativeFunctionPtr;

		// Token: 0x04011E95 RID: 73365
		private static IntPtr __Set_Plant_Data_NativeFunctionPtr;

		// Token: 0x04011E96 RID: 73366
		private static IntPtr __Set_Params_And_MID_NativeFunctionPtr;

		// Token: 0x04011E97 RID: 73367
		private static IntPtr __Stop_Interaction_NativeFunctionPtr;

		// Token: 0x04011E98 RID: 73368
		private static IntPtr __Draw_Transfrom_NativeFunctionPtr;

		// Token: 0x04011E99 RID: 73369
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x04011E9A RID: 73370
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011E9B RID: 73371
		private static IntPtr __BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011E9C RID: 73372
		private static IntPtr __BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011E9D RID: 73373
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04011E9E RID: 73374
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x02009ED8 RID: 40664
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __CopyCustomPrimitiveData_FunctionParams
		{
			// Token: 0x040317C5 RID: 202693
			[FieldOffset(0)]
			public IntPtr Target;
		}

		// Token: 0x02009ED9 RID: 40665
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 576)]
		protected ref struct __Set_Plant_Data_FunctionParams
		{
			// Token: 0x040317C6 RID: 202694
			[FieldOffset(0)]
			public byte Foliage_Data;

			// Token: 0x040317C7 RID: 202695
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x02009EDA RID: 40666
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040317C8 RID: 202696
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009EDB RID: 40667
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040317C9 RID: 202697
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040317CA RID: 202698
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040317CB RID: 202699
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040317CC RID: 202700
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040317CD RID: 202701
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040317CE RID: 202702
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009EDC RID: 40668
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_LongGrass_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040317CF RID: 202703
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040317D0 RID: 202704
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040317D1 RID: 202705
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040317D2 RID: 202706
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009EDD RID: 40669
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040317D3 RID: 202707
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}
	}
}
