using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._3_7_WaterMechanicFoliage
{
	// Token: 0x02003C0D RID: 15373
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_WaterMechanicFoliage/BP_WaterMechanicFoliage.BP_WaterMechanicFoliage_C")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1668)]
	public class BP_WaterMechanicFoliage_C : AKuroBPEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060231B3 RID: 143795 RVA: 0x0091AA2B File Offset: 0x00918C2B
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_WaterMechanicFoliage_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_WaterMechanicFoliage/BP_WaterMechanicFoliage.BP_WaterMechanicFoliage_C");
			}
			return BP_WaterMechanicFoliage_C._ClassPtr;
		}

		// Token: 0x060231B4 RID: 143796 RVA: 0x0091AA50 File Offset: 0x00918C50
		public BP_WaterMechanicFoliage_C() : this(BuiltinUtils.AllocNativeUObject(BP_WaterMechanicFoliage_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060231B5 RID: 143797 RVA: 0x0091AA78 File Offset: 0x00918C78
		[NullableContext(1)]
		public BP_WaterMechanicFoliage_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_WaterMechanicFoliage_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x060231B6 RID: 143798 RVA: 0x0091AAAB File Offset: 0x00918CAB
		// (set) Token: 0x060231B7 RID: 143799 RVA: 0x0091AABF File Offset: 0x00918CBF
		public unsafe UNiagaraComponent Niagara
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x060231B8 RID: 143800 RVA: 0x0091AAD4 File Offset: 0x00918CD4
		// (set) Token: 0x060231B9 RID: 143801 RVA: 0x0091AAE8 File Offset: 0x00918CE8
		public unsafe USphereComponent TriggerSphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x060231BA RID: 143802 RVA: 0x0091AAFD File Offset: 0x00918CFD
		// (set) Token: 0x060231BB RID: 143803 RVA: 0x0091AB11 File Offset: 0x00918D11
		public unsafe UStaticMeshComponent PlantMeshCompoent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x060231BC RID: 143804 RVA: 0x0091AB26 File Offset: 0x00918D26
		// (set) Token: 0x060231BD RID: 143805 RVA: 0x0091AB3A File Offset: 0x00918D3A
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x060231BE RID: 143806 RVA: 0x0091AB4F File Offset: 0x00918D4F
		// (set) Token: 0x060231BF RID: 143807 RVA: 0x0091AB5F File Offset: 0x00918D5F
		public unsafe float TL_SwitchAlpha_SwitchAlpha_9F62DBF049B3C674D47BB885DD47D8F5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x060231C0 RID: 143808 RVA: 0x0091AB70 File Offset: 0x00918D70
		// (set) Token: 0x060231C1 RID: 143809 RVA: 0x0091AB84 File Offset: 0x00918D84
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> TL_SwitchAlpha__Direction_9F62DBF049B3C674D47BB885DD47D8F5
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x060231C2 RID: 143810 RVA: 0x0091AB99 File Offset: 0x00918D99
		// (set) Token: 0x060231C3 RID: 143811 RVA: 0x0091ABAD File Offset: 0x00918DAD
		public unsafe UTimelineComponent TL_SwitchAlpha
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x060231C4 RID: 143812 RVA: 0x0091ABC2 File Offset: 0x00918DC2
		// (set) Token: 0x060231C5 RID: 143813 RVA: 0x0091ABD6 File Offset: 0x00918DD6
		public unsafe UStaticMesh PlantMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x060231C6 RID: 143814 RVA: 0x0091ABEB File Offset: 0x00918DEB
		// (set) Token: 0x060231C7 RID: 143815 RVA: 0x0091ABFB File Offset: 0x00918DFB
		public unsafe float TriggerRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x060231C8 RID: 143816 RVA: 0x0091AC0C File Offset: 0x00918E0C
		// (set) Token: 0x060231C9 RID: 143817 RVA: 0x0091AC1C File Offset: 0x00918E1C
		public unsafe float EnterDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x060231CA RID: 143818 RVA: 0x0091AC2D File Offset: 0x00918E2D
		// (set) Token: 0x060231CB RID: 143819 RVA: 0x0091AC3D File Offset: 0x00918E3D
		public unsafe float ExitDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x060231CC RID: 143820 RVA: 0x0091AC4E File Offset: 0x00918E4E
		// (set) Token: 0x060231CD RID: 143821 RVA: 0x0091AC5E File Offset: 0x00918E5E
		public unsafe float MinTransitionDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x060231CE RID: 143822 RVA: 0x0091AC6F File Offset: 0x00918E6F
		// (set) Token: 0x060231CF RID: 143823 RVA: 0x0091AC7F File Offset: 0x00918E7F
		public unsafe float SwitchAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x060231D0 RID: 143824 RVA: 0x0091AC90 File Offset: 0x00918E90
		// (set) Token: 0x060231D1 RID: 143825 RVA: 0x0091ACC9 File Offset: 0x00918EC9
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
					result = (this._PlantMIDs = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_14, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PlantMIDs.CopyAssign(value);
			}
		}

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x060231D2 RID: 143826 RVA: 0x0091ACD7 File Offset: 0x00918ED7
		// (set) Token: 0x060231D3 RID: 143827 RVA: 0x0091ACE7 File Offset: 0x00918EE7
		public unsafe bool bPlayerInsideRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x060231D4 RID: 143828 RVA: 0x0091ACF8 File Offset: 0x00918EF8
		// (set) Token: 0x060231D5 RID: 143829 RVA: 0x0091AD08 File Offset: 0x00918F08
		public unsafe int TargetMaterialElementIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x060231D6 RID: 143830 RVA: 0x0091AD19 File Offset: 0x00918F19
		// (set) Token: 0x060231D7 RID: 143831 RVA: 0x0091AD29 File Offset: 0x00918F29
		public unsafe float SwitchAlpha_Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x060231D8 RID: 143832 RVA: 0x0091AD3A File Offset: 0x00918F3A
		// (set) Token: 0x060231D9 RID: 143833 RVA: 0x0091AD4E File Offset: 0x00918F4E
		public unsafe UNiagaraSystem Niagara_Asset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x060231DA RID: 143834 RVA: 0x0091AD63 File Offset: 0x00918F63
		// (set) Token: 0x060231DB RID: 143835 RVA: 0x0091AD73 File Offset: 0x00918F73
		public unsafe float Switch_WindTimeContral
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x060231DC RID: 143836 RVA: 0x0091AD84 File Offset: 0x00918F84
		// (set) Token: 0x060231DD RID: 143837 RVA: 0x0091AD94 File Offset: 0x00918F94
		public unsafe float PlayerFieldOpened_Water
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x060231DE RID: 143838 RVA: 0x0091ADA5 File Offset: 0x00918FA5
		// (set) Token: 0x060231DF RID: 143839 RVA: 0x0091ADB5 File Offset: 0x00918FB5
		public unsafe float PlayerFieldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x060231E0 RID: 143840 RVA: 0x0091ADC6 File Offset: 0x00918FC6
		// (set) Token: 0x060231E1 RID: 143841 RVA: 0x0091ADDA File Offset: 0x00918FDA
		public unsafe FLinearColor PlayerFieldLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x060231E2 RID: 143842 RVA: 0x0091ADEF File Offset: 0x00918FEF
		// (set) Token: 0x060231E3 RID: 143843 RVA: 0x0091ADFF File Offset: 0x00918FFF
		public unsafe float FieldRefreshInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x060231E4 RID: 143844 RVA: 0x0091AE10 File Offset: 0x00919010
		// (set) Token: 0x060231E5 RID: 143845 RVA: 0x0091AE49 File Offset: 0x00919049
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
					result = (this._FieldRefreshTimerHandle = new FTimerHandle(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_24, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimerHandle.StaticStruct(), base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_24, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F9E RID: 16286
		// (get) Token: 0x060231E6 RID: 143846 RVA: 0x0091AE6A File Offset: 0x0091906A
		// (set) Token: 0x060231E7 RID: 143847 RVA: 0x0091AE7E File Offset: 0x0091907E
		public unsafe UMaterialParameterCollection MPC_SceneInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_25);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_WaterMechanicFoliage_C.__PropertyOffset_25, value);
			}
		}

		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x060231E8 RID: 143848 RVA: 0x0091AE93 File Offset: 0x00919093
		// (set) Token: 0x060231E9 RID: 143849 RVA: 0x0091AEA7 File Offset: 0x009190A7
		public unsafe FName Opened
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x060231EA RID: 143850 RVA: 0x0091AEBC File Offset: 0x009190BC
		// (set) Token: 0x060231EB RID: 143851 RVA: 0x0091AED0 File Offset: 0x009190D0
		public unsafe FName Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x060231EC RID: 143852 RVA: 0x0091AEE5 File Offset: 0x009190E5
		// (set) Token: 0x060231ED RID: 143853 RVA: 0x0091AEF9 File Offset: 0x009190F9
		public unsafe FName Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_28);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_WaterMechanicFoliage_C.__PropertyOffset_28) = value;
			}
		}

		// Token: 0x060231EE RID: 143854 RVA: 0x0091AF0E File Offset: 0x0091910E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StopFieldMonitoring()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__StopFieldMonitoring_NativeFunctionPtr, null);
		}

		// Token: 0x060231EF RID: 143855 RVA: 0x0091AF22 File Offset: 0x00919122
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartFieldMonitoring()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__StartFieldMonitoring_NativeFunctionPtr, null);
		}

		// Token: 0x060231F0 RID: 143856 RVA: 0x0091AF36 File Offset: 0x00919136
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdatePlantStateByPlayerField()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__UpdatePlantStateByPlayerField_NativeFunctionPtr, null);
		}

		// Token: 0x060231F1 RID: 143857 RVA: 0x0091AF4A File Offset: 0x0091914A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Set_Niagara_Param()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__Set_Niagara_Param_NativeFunctionPtr, null);
		}

		// Token: 0x060231F2 RID: 143858 RVA: 0x0091AF60 File Offset: 0x00919160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPlayerFieldState(bool bNewInsideRange)
		{
			BP_WaterMechanicFoliage_C.__SetPlayerFieldState_FunctionParams* ptr = stackalloc BP_WaterMechanicFoliage_C.__SetPlayerFieldState_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(BP_WaterMechanicFoliage_C.__SetPlayerFieldState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterMechanicFoliage_C.__SetPlayerFieldState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bNewInsideRange = bNewInsideRange;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__SetPlayerFieldState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060231F3 RID: 143859 RVA: 0x0091AFA6 File Offset: 0x009191A6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HandlePlayerExitRange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__HandlePlayerExitRange_NativeFunctionPtr, null);
		}

		// Token: 0x060231F4 RID: 143860 RVA: 0x0091AFBA File Offset: 0x009191BA
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HandlePlayerEnterRange()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__HandlePlayerEnterRange_NativeFunctionPtr, null);
		}

		// Token: 0x060231F5 RID: 143861 RVA: 0x0091AFCE File Offset: 0x009191CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ApplySwitchAlpha()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__ApplySwitchAlpha_NativeFunctionPtr, null);
		}

		// Token: 0x060231F6 RID: 143862 RVA: 0x0091AFE2 File Offset: 0x009191E2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitializePlantVisuals()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__InitializePlantVisuals_NativeFunctionPtr, null);
		}

		// Token: 0x060231F7 RID: 143863 RVA: 0x0091AFF6 File Offset: 0x009191F6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060231F8 RID: 143864 RVA: 0x0091B00A File Offset: 0x0091920A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060231F9 RID: 143865 RVA: 0x0091B01F File Offset: 0x0091921F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TL_SwitchAlpha__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__TL_SwitchAlpha__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060231FA RID: 143866 RVA: 0x0091B033 File Offset: 0x00919233
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TL_SwitchAlpha__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__TL_SwitchAlpha__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x060231FB RID: 143867 RVA: 0x0091B048 File Offset: 0x00919248
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060231FC RID: 143868 RVA: 0x0091B104 File Offset: 0x00919304
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060231FD RID: 143869 RVA: 0x0091B18D File Offset: 0x0091938D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateWaterField()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__UpdateWaterField_NativeFunctionPtr, null);
		}

		// Token: 0x060231FE RID: 143870 RVA: 0x0091B1A1 File Offset: 0x009193A1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void RefreshWaterField()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__RefreshWaterField_NativeFunctionPtr, null);
		}

		// Token: 0x060231FF RID: 143871 RVA: 0x0091B1B5 File Offset: 0x009193B5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06023200 RID: 143872 RVA: 0x0091B1C9 File Offset: 0x009193C9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_WaterMechanicFoliage_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06023201 RID: 143873 RVA: 0x0091B1DE File Offset: 0x009193DE
		protected BP_WaterMechanicFoliage_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114B5 RID: 70837
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_WaterMechanicFoliage/BP_WaterMechanicFoliage.BP_WaterMechanicFoliage_C";

		// Token: 0x040114B6 RID: 70838
		private static IntPtr _ClassPtr;

		// Token: 0x040114B7 RID: 70839
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114B8 RID: 70840
		internal static int __PropertyOffset_1;

		// Token: 0x040114B9 RID: 70841
		internal static int __PropertyOffset_2;

		// Token: 0x040114BA RID: 70842
		internal static int __PropertyOffset_3;

		// Token: 0x040114BB RID: 70843
		internal static int __PropertyOffset_4;

		// Token: 0x040114BC RID: 70844
		internal static int __PropertyOffset_5;

		// Token: 0x040114BD RID: 70845
		internal static int __PropertyOffset_6;

		// Token: 0x040114BE RID: 70846
		internal static int __PropertyOffset_7;

		// Token: 0x040114BF RID: 70847
		internal static int __PropertyOffset_8;

		// Token: 0x040114C0 RID: 70848
		internal static int __PropertyOffset_9;

		// Token: 0x040114C1 RID: 70849
		internal static int __PropertyOffset_10;

		// Token: 0x040114C2 RID: 70850
		internal static int __PropertyOffset_11;

		// Token: 0x040114C3 RID: 70851
		internal static int __PropertyOffset_12;

		// Token: 0x040114C4 RID: 70852
		internal static int __PropertyOffset_13;

		// Token: 0x040114C5 RID: 70853
		internal static int __PropertyOffset_14;

		// Token: 0x040114C6 RID: 70854
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _PlantMIDs;

		// Token: 0x040114C7 RID: 70855
		internal static int __PropertyOffset_15;

		// Token: 0x040114C8 RID: 70856
		internal static int __PropertyOffset_16;

		// Token: 0x040114C9 RID: 70857
		internal static int __PropertyOffset_17;

		// Token: 0x040114CA RID: 70858
		internal static int __PropertyOffset_18;

		// Token: 0x040114CB RID: 70859
		internal static int __PropertyOffset_19;

		// Token: 0x040114CC RID: 70860
		internal static int __PropertyOffset_20;

		// Token: 0x040114CD RID: 70861
		internal static int __PropertyOffset_21;

		// Token: 0x040114CE RID: 70862
		internal static int __PropertyOffset_22;

		// Token: 0x040114CF RID: 70863
		internal static int __PropertyOffset_23;

		// Token: 0x040114D0 RID: 70864
		internal static int __PropertyOffset_24;

		// Token: 0x040114D1 RID: 70865
		private FTimerHandle _FieldRefreshTimerHandle;

		// Token: 0x040114D2 RID: 70866
		internal static int __PropertyOffset_25;

		// Token: 0x040114D3 RID: 70867
		internal static int __PropertyOffset_26;

		// Token: 0x040114D4 RID: 70868
		internal static int __PropertyOffset_27;

		// Token: 0x040114D5 RID: 70869
		internal static int __PropertyOffset_28;

		// Token: 0x040114D6 RID: 70870
		private static IntPtr __StopFieldMonitoring_NativeFunctionPtr;

		// Token: 0x040114D7 RID: 70871
		private static IntPtr __StartFieldMonitoring_NativeFunctionPtr;

		// Token: 0x040114D8 RID: 70872
		private static IntPtr __UpdatePlantStateByPlayerField_NativeFunctionPtr;

		// Token: 0x040114D9 RID: 70873
		private static IntPtr __Set_Niagara_Param_NativeFunctionPtr;

		// Token: 0x040114DA RID: 70874
		private static IntPtr __SetPlayerFieldState_NativeFunctionPtr;

		// Token: 0x040114DB RID: 70875
		private static IntPtr __HandlePlayerExitRange_NativeFunctionPtr;

		// Token: 0x040114DC RID: 70876
		private static IntPtr __HandlePlayerEnterRange_NativeFunctionPtr;

		// Token: 0x040114DD RID: 70877
		private static IntPtr __ApplySwitchAlpha_NativeFunctionPtr;

		// Token: 0x040114DE RID: 70878
		private static IntPtr __InitializePlantVisuals_NativeFunctionPtr;

		// Token: 0x040114DF RID: 70879
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040114E0 RID: 70880
		private static IntPtr __TL_SwitchAlpha__FinishedFunc_NativeFunctionPtr;

		// Token: 0x040114E1 RID: 70881
		private static IntPtr __TL_SwitchAlpha__UpdateFunc_NativeFunctionPtr;

		// Token: 0x040114E2 RID: 70882
		private static IntPtr __BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040114E3 RID: 70883
		private static IntPtr __BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040114E4 RID: 70884
		private static IntPtr __UpdateWaterField_NativeFunctionPtr;

		// Token: 0x040114E5 RID: 70885
		private static IntPtr __RefreshWaterField_NativeFunctionPtr;

		// Token: 0x040114E6 RID: 70886
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009E12 RID: 40466
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SetPlayerFieldState_FunctionParams
		{
			// Token: 0x04031649 RID: 202313
			[FieldOffset(0)]
			public bool bNewInsideRange;
		}

		// Token: 0x02009E13 RID: 40467
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_2_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403164A RID: 202314
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403164B RID: 202315
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403164C RID: 202316
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403164D RID: 202317
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403164E RID: 202318
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x0403164F RID: 202319
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009E14 RID: 40468
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_MechanicFoliage_Water_TriggerSphere_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031650 RID: 202320
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031651 RID: 202321
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031652 RID: 202322
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031653 RID: 202323
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}
	}
}
