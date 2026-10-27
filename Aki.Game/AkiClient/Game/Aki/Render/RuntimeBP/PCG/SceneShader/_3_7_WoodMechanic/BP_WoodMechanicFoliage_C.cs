using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._3_7_WoodMechanic
{
	// Token: 0x02003C0C RID: 15372
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_WoodMechanic/BP_WoodMechanicFoliage.BP_WoodMechanicFoliage_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1668)]
	public class BP_WoodMechanicFoliage_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023164 RID: 143716 RVA: 0x0091A270 File Offset: 0x00918470
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WoodMechanicFoliage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_WoodMechanic/BP_WoodMechanicFoliage.BP_WoodMechanicFoliage_C");
			}
			return BP_WoodMechanicFoliage_C._ClassPtr;
		}

		// Token: 0x06023165 RID: 143717 RVA: 0x0091A294 File Offset: 0x00918494
		public BP_WoodMechanicFoliage_C() : this(BuiltinUtils.AllocNativeUObject(BP_WoodMechanicFoliage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023166 RID: 143718 RVA: 0x0091A2BC File Offset: 0x009184BC
		[NullableContext(1)]
		public BP_WoodMechanicFoliage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WoodMechanicFoliage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x06023167 RID: 143719 RVA: 0x0091A2EF File Offset: 0x009184EF
		// (set) Token: 0x06023168 RID: 143720 RVA: 0x0091A303 File Offset: 0x00918503
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x06023169 RID: 143721 RVA: 0x0091A318 File Offset: 0x00918518
		// (set) Token: 0x0602316A RID: 143722 RVA: 0x0091A32C File Offset: 0x0091852C
		public unsafe USphereComponent TriggerSphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x0602316B RID: 143723 RVA: 0x0091A341 File Offset: 0x00918541
		// (set) Token: 0x0602316C RID: 143724 RVA: 0x0091A355 File Offset: 0x00918555
		public unsafe UStaticMeshComponent PlantMeshCompoent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x0602316D RID: 143725 RVA: 0x0091A36A File Offset: 0x0091856A
		// (set) Token: 0x0602316E RID: 143726 RVA: 0x0091A37E File Offset: 0x0091857E
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x0602316F RID: 143727 RVA: 0x0091A393 File Offset: 0x00918593
		// (set) Token: 0x06023170 RID: 143728 RVA: 0x0091A3A3 File Offset: 0x009185A3
		public unsafe float TL_SwitchAlpha_SwitchAlpha_ED5270F74FD4808D8CC0A8BDABB6BE60
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x06023171 RID: 143729 RVA: 0x0091A3B4 File Offset: 0x009185B4
		// (set) Token: 0x06023172 RID: 143730 RVA: 0x0091A3C8 File Offset: 0x009185C8
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> TL_SwitchAlpha__Direction_ED5270F74FD4808D8CC0A8BDABB6BE60
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x06023173 RID: 143731 RVA: 0x0091A3DD File Offset: 0x009185DD
		// (set) Token: 0x06023174 RID: 143732 RVA: 0x0091A3F1 File Offset: 0x009185F1
		public unsafe UTimelineComponent TL_SwitchAlpha
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x06023175 RID: 143733 RVA: 0x0091A406 File Offset: 0x00918606
		// (set) Token: 0x06023176 RID: 143734 RVA: 0x0091A41A File Offset: 0x0091861A
		public unsafe UStaticMesh PlantMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x06023177 RID: 143735 RVA: 0x0091A42F File Offset: 0x0091862F
		// (set) Token: 0x06023178 RID: 143736 RVA: 0x0091A43F File Offset: 0x0091863F
		public unsafe float TriggerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x06023179 RID: 143737 RVA: 0x0091A450 File Offset: 0x00918650
		// (set) Token: 0x0602317A RID: 143738 RVA: 0x0091A460 File Offset: 0x00918660
		public unsafe float EnterDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x0602317B RID: 143739 RVA: 0x0091A471 File Offset: 0x00918671
		// (set) Token: 0x0602317C RID: 143740 RVA: 0x0091A481 File Offset: 0x00918681
		public unsafe float ExitDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x0602317D RID: 143741 RVA: 0x0091A492 File Offset: 0x00918692
		// (set) Token: 0x0602317E RID: 143742 RVA: 0x0091A4A2 File Offset: 0x009186A2
		public unsafe float MinTransitionDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x0602317F RID: 143743 RVA: 0x0091A4B3 File Offset: 0x009186B3
		// (set) Token: 0x06023180 RID: 143744 RVA: 0x0091A4C3 File Offset: 0x009186C3
		public unsafe float SwitchAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x06023181 RID: 143745 RVA: 0x0091A4D4 File Offset: 0x009186D4
		// (set) Token: 0x06023182 RID: 143746 RVA: 0x0091A50D File Offset: 0x0091870D
		[Nullable(1)]
		public TArray<UMaterialInstanceDynamic> PlantMIDs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._PlantMIDs) == null)
				{
					result = (this._PlantMIDs = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PlantMIDs.CopyAssign(value);
			}
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x06023183 RID: 143747 RVA: 0x0091A51B File Offset: 0x0091871B
		// (set) Token: 0x06023184 RID: 143748 RVA: 0x0091A52B File Offset: 0x0091872B
		public unsafe bool bPlayerInsideRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x06023185 RID: 143749 RVA: 0x0091A53C File Offset: 0x0091873C
		// (set) Token: 0x06023186 RID: 143750 RVA: 0x0091A54C File Offset: 0x0091874C
		public unsafe int TargetMaterialElementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x06023187 RID: 143751 RVA: 0x0091A55D File Offset: 0x0091875D
		// (set) Token: 0x06023188 RID: 143752 RVA: 0x0091A56D File Offset: 0x0091876D
		public unsafe float SwitchAlpha_Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003F7B RID: 16251
		// (get) Token: 0x06023189 RID: 143753 RVA: 0x0091A57E File Offset: 0x0091877E
		// (set) Token: 0x0602318A RID: 143754 RVA: 0x0091A592 File Offset: 0x00918792
		public unsafe UNiagaraSystem Niagara_Asset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x0602318B RID: 143755 RVA: 0x0091A5A7 File Offset: 0x009187A7
		// (set) Token: 0x0602318C RID: 143756 RVA: 0x0091A5B7 File Offset: 0x009187B7
		public unsafe float Switch_WindTimeContral
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x0602318D RID: 143757 RVA: 0x0091A5C8 File Offset: 0x009187C8
		// (set) Token: 0x0602318E RID: 143758 RVA: 0x0091A5D8 File Offset: 0x009187D8
		public unsafe float PlayerFieldOpened_Water
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x0602318F RID: 143759 RVA: 0x0091A5E9 File Offset: 0x009187E9
		// (set) Token: 0x06023190 RID: 143760 RVA: 0x0091A5F9 File Offset: 0x009187F9
		public unsafe float PlayerFieldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x06023191 RID: 143761 RVA: 0x0091A60A File Offset: 0x0091880A
		// (set) Token: 0x06023192 RID: 143762 RVA: 0x0091A61E File Offset: 0x0091881E
		public unsafe FLinearColor PlayerFieldLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x06023193 RID: 143763 RVA: 0x0091A633 File Offset: 0x00918833
		// (set) Token: 0x06023194 RID: 143764 RVA: 0x0091A643 File Offset: 0x00918843
		public unsafe float FieldRefreshInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x06023195 RID: 143765 RVA: 0x0091A654 File Offset: 0x00918854
		// (set) Token: 0x06023196 RID: 143766 RVA: 0x0091A68D File Offset: 0x0091888D
		[Nullable(1)]
		public FTimerHandle FieldRefreshTimerHandle
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTimerHandle result;
				if ((result = this._FieldRefreshTimerHandle) == null)
				{
					result = (this._FieldRefreshTimerHandle = new FTimerHandle(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_24, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_24, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x06023197 RID: 143767 RVA: 0x0091A6AE File Offset: 0x009188AE
		// (set) Token: 0x06023198 RID: 143768 RVA: 0x0091A6C2 File Offset: 0x009188C2
		public unsafe UMaterialParameterCollection MPC_SceneInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WoodMechanicFoliage_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x06023199 RID: 143769 RVA: 0x0091A6D7 File Offset: 0x009188D7
		// (set) Token: 0x0602319A RID: 143770 RVA: 0x0091A6EB File Offset: 0x009188EB
		public unsafe FName Opened
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x0602319B RID: 143771 RVA: 0x0091A700 File Offset: 0x00918900
		// (set) Token: 0x0602319C RID: 143772 RVA: 0x0091A714 File Offset: 0x00918914
		public unsafe FName Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x0602319D RID: 143773 RVA: 0x0091A729 File Offset: 0x00918929
		// (set) Token: 0x0602319E RID: 143774 RVA: 0x0091A73D File Offset: 0x0091893D
		public unsafe FName Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WoodMechanicFoliage_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x0602319F RID: 143775 RVA: 0x0091A752 File Offset: 0x00918952
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopFieldMonitoring()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__StopFieldMonitoring_NativeFunctionPtr, null);
		}

		// Token: 0x060231A0 RID: 143776 RVA: 0x0091A766 File Offset: 0x00918966
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartFieldMonitoring()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__StartFieldMonitoring_NativeFunctionPtr, null);
		}

		// Token: 0x060231A1 RID: 143777 RVA: 0x0091A77A File Offset: 0x0091897A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePlantStateByPlayerField()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__UpdatePlantStateByPlayerField_NativeFunctionPtr, null);
		}

		// Token: 0x060231A2 RID: 143778 RVA: 0x0091A78E File Offset: 0x0091898E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Niagara_Param()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__Set_Niagara_Param_NativeFunctionPtr, null);
		}

		// Token: 0x060231A3 RID: 143779 RVA: 0x0091A7A4 File Offset: 0x009189A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPlayerFieldState(bool bNewInsideRange)
		{
			BP_WoodMechanicFoliage_C.__SetPlayerFieldState_FunctionParams* ptr = stackalloc BP_WoodMechanicFoliage_C.__SetPlayerFieldState_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_WoodMechanicFoliage_C.__SetPlayerFieldState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WoodMechanicFoliage_C.__SetPlayerFieldState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bNewInsideRange = bNewInsideRange;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__SetPlayerFieldState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060231A4 RID: 143780 RVA: 0x0091A7EA File Offset: 0x009189EA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HandlePlayerExitRange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__HandlePlayerExitRange_NativeFunctionPtr, null);
		}

		// Token: 0x060231A5 RID: 143781 RVA: 0x0091A7FE File Offset: 0x009189FE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HandlePlayerEnterRange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__HandlePlayerEnterRange_NativeFunctionPtr, null);
		}

		// Token: 0x060231A6 RID: 143782 RVA: 0x0091A812 File Offset: 0x00918A12
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ApplySwitchAlpha()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__ApplySwitchAlpha_NativeFunctionPtr, null);
		}

		// Token: 0x060231A7 RID: 143783 RVA: 0x0091A826 File Offset: 0x00918A26
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializePlantVisuals()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__InitializePlantVisuals_NativeFunctionPtr, null);
		}

		// Token: 0x060231A8 RID: 143784 RVA: 0x0091A83A File Offset: 0x00918A3A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060231A9 RID: 143785 RVA: 0x0091A84E File Offset: 0x00918A4E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060231AA RID: 143786 RVA: 0x0091A863 File Offset: 0x00918A63
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TL_SwitchAlpha__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__TL_SwitchAlpha__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060231AB RID: 143787 RVA: 0x0091A877 File Offset: 0x00918A77
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TL_SwitchAlpha__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__TL_SwitchAlpha__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060231AC RID: 143788 RVA: 0x0091A88C File Offset: 0x00918A8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060231AD RID: 143789 RVA: 0x0091A948 File Offset: 0x00918B48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060231AE RID: 143790 RVA: 0x0091A9D1 File Offset: 0x00918BD1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateWaterField()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__UpdateWaterField_NativeFunctionPtr, null);
		}

		// Token: 0x060231AF RID: 143791 RVA: 0x0091A9E5 File Offset: 0x00918BE5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshWaterField()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__RefreshWaterField_NativeFunctionPtr, null);
		}

		// Token: 0x060231B0 RID: 143792 RVA: 0x0091A9F9 File Offset: 0x00918BF9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060231B1 RID: 143793 RVA: 0x0091AA0D File Offset: 0x00918C0D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WoodMechanicFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060231B2 RID: 143794 RVA: 0x0091AA22 File Offset: 0x00918C22
		protected BP_WoodMechanicFoliage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011483 RID: 70787
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_WoodMechanic/BP_WoodMechanicFoliage.BP_WoodMechanicFoliage_C";

		// Token: 0x04011484 RID: 70788
		private static IntPtr _ClassPtr;

		// Token: 0x04011485 RID: 70789
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011486 RID: 70790
		internal static int __PropertyOffset_1;

		// Token: 0x04011487 RID: 70791
		internal static int __PropertyOffset_2;

		// Token: 0x04011488 RID: 70792
		internal static int __PropertyOffset_3;

		// Token: 0x04011489 RID: 70793
		internal static int __PropertyOffset_4;

		// Token: 0x0401148A RID: 70794
		internal static int __PropertyOffset_5;

		// Token: 0x0401148B RID: 70795
		internal static int __PropertyOffset_6;

		// Token: 0x0401148C RID: 70796
		internal static int __PropertyOffset_7;

		// Token: 0x0401148D RID: 70797
		internal static int __PropertyOffset_8;

		// Token: 0x0401148E RID: 70798
		internal static int __PropertyOffset_9;

		// Token: 0x0401148F RID: 70799
		internal static int __PropertyOffset_10;

		// Token: 0x04011490 RID: 70800
		internal static int __PropertyOffset_11;

		// Token: 0x04011491 RID: 70801
		internal static int __PropertyOffset_12;

		// Token: 0x04011492 RID: 70802
		internal static int __PropertyOffset_13;

		// Token: 0x04011493 RID: 70803
		internal static int __PropertyOffset_14;

		// Token: 0x04011494 RID: 70804
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _PlantMIDs;

		// Token: 0x04011495 RID: 70805
		internal static int __PropertyOffset_15;

		// Token: 0x04011496 RID: 70806
		internal static int __PropertyOffset_16;

		// Token: 0x04011497 RID: 70807
		internal static int __PropertyOffset_17;

		// Token: 0x04011498 RID: 70808
		internal static int __PropertyOffset_18;

		// Token: 0x04011499 RID: 70809
		internal static int __PropertyOffset_19;

		// Token: 0x0401149A RID: 70810
		internal static int __PropertyOffset_20;

		// Token: 0x0401149B RID: 70811
		internal static int __PropertyOffset_21;

		// Token: 0x0401149C RID: 70812
		internal static int __PropertyOffset_22;

		// Token: 0x0401149D RID: 70813
		internal static int __PropertyOffset_23;

		// Token: 0x0401149E RID: 70814
		internal static int __PropertyOffset_24;

		// Token: 0x0401149F RID: 70815
		private FTimerHandle _FieldRefreshTimerHandle;

		// Token: 0x040114A0 RID: 70816
		internal static int __PropertyOffset_25;

		// Token: 0x040114A1 RID: 70817
		internal static int __PropertyOffset_26;

		// Token: 0x040114A2 RID: 70818
		internal static int __PropertyOffset_27;

		// Token: 0x040114A3 RID: 70819
		internal static int __PropertyOffset_28;

		// Token: 0x040114A4 RID: 70820
		private static IntPtr __StopFieldMonitoring_NativeFunctionPtr;

		// Token: 0x040114A5 RID: 70821
		private static IntPtr __StartFieldMonitoring_NativeFunctionPtr;

		// Token: 0x040114A6 RID: 70822
		private static IntPtr __UpdatePlantStateByPlayerField_NativeFunctionPtr;

		// Token: 0x040114A7 RID: 70823
		private static IntPtr __Set_Niagara_Param_NativeFunctionPtr;

		// Token: 0x040114A8 RID: 70824
		private static IntPtr __SetPlayerFieldState_NativeFunctionPtr;

		// Token: 0x040114A9 RID: 70825
		private static IntPtr __HandlePlayerExitRange_NativeFunctionPtr;

		// Token: 0x040114AA RID: 70826
		private static IntPtr __HandlePlayerEnterRange_NativeFunctionPtr;

		// Token: 0x040114AB RID: 70827
		private static IntPtr __ApplySwitchAlpha_NativeFunctionPtr;

		// Token: 0x040114AC RID: 70828
		private static IntPtr __InitializePlantVisuals_NativeFunctionPtr;

		// Token: 0x040114AD RID: 70829
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040114AE RID: 70830
		private static IntPtr __TL_SwitchAlpha__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040114AF RID: 70831
		private static IntPtr __TL_SwitchAlpha__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040114B0 RID: 70832
		private static IntPtr __BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040114B1 RID: 70833
		private static IntPtr __BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040114B2 RID: 70834
		private static IntPtr __UpdateWaterField_NativeFunctionPtr;

		// Token: 0x040114B3 RID: 70835
		private static IntPtr __RefreshWaterField_NativeFunctionPtr;

		// Token: 0x040114B4 RID: 70836
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009E0F RID: 40463
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetPlayerFieldState_FunctionParams
		{
			// Token: 0x0403163E RID: 202302
			[FieldOffset(0)]
			public bool bNewInsideRange;
		}

		// Token: 0x02009E10 RID: 40464
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403163F RID: 202303
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031640 RID: 202304
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031641 RID: 202305
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031642 RID: 202306
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x04031643 RID: 202307
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031644 RID: 202308
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E11 RID: 40465
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031645 RID: 202309
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031646 RID: 202310
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031647 RID: 202311
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031648 RID: 202312
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
