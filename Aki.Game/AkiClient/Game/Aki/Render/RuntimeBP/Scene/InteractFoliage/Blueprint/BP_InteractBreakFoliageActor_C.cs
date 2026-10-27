using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint.MeshActor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.InteractFoliage.Blueprint
{
	// Token: 0x02003B52 RID: 15186
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractBreakFoliageActor.BP_InteractBreakFoliageActor_C")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class BP_InteractBreakFoliageActor_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021A3D RID: 137789 RVA: 0x008F1A43 File Offset: 0x008EFC43
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_InteractBreakFoliageActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractBreakFoliageActor.BP_InteractBreakFoliageActor_C");
			}
			return BP_InteractBreakFoliageActor_C._ClassPtr;
		}

		// Token: 0x06021A3E RID: 137790 RVA: 0x008F1A68 File Offset: 0x008EFC68
		public BP_InteractBreakFoliageActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_InteractBreakFoliageActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021A3F RID: 137791 RVA: 0x008F1A90 File Offset: 0x008EFC90
		[NullableContext(1)]
		public BP_InteractBreakFoliageActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_InteractBreakFoliageActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x06021A40 RID: 137792 RVA: 0x008F1AC3 File Offset: 0x008EFCC3
		// (set) Token: 0x06021A41 RID: 137793 RVA: 0x008F1AD7 File Offset: 0x008EFCD7
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x06021A42 RID: 137794 RVA: 0x008F1AEC File Offset: 0x008EFCEC
		// (set) Token: 0x06021A43 RID: 137795 RVA: 0x008F1B00 File Offset: 0x008EFD00
		public unsafe USkeletalMeshComponent SkeletalMeshFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x06021A44 RID: 137796 RVA: 0x008F1B15 File Offset: 0x008EFD15
		// (set) Token: 0x06021A45 RID: 137797 RVA: 0x008F1B29 File Offset: 0x008EFD29
		public unsafe UStaticMeshComponent StaticMeshFoliage
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x06021A46 RID: 137798 RVA: 0x008F1B3E File Offset: 0x008EFD3E
		// (set) Token: 0x06021A47 RID: 137799 RVA: 0x008F1B52 File Offset: 0x008EFD52
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x06021A48 RID: 137800 RVA: 0x008F1B67 File Offset: 0x008EFD67
		// (set) Token: 0x06021A49 RID: 137801 RVA: 0x008F1B77 File Offset: 0x008EFD77
		public unsafe float PointDissolveTimeline_NewTrack_0_D19F1AC4432ACC0334FB0C888B0DFE3E
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x06021A4A RID: 137802 RVA: 0x008F1B88 File Offset: 0x008EFD88
		// (set) Token: 0x06021A4B RID: 137803 RVA: 0x008F1B9C File Offset: 0x008EFD9C
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> PointDissolveTimeline__Direction_D19F1AC4432ACC0334FB0C888B0DFE3E
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x06021A4C RID: 137804 RVA: 0x008F1BB1 File Offset: 0x008EFDB1
		// (set) Token: 0x06021A4D RID: 137805 RVA: 0x008F1BC5 File Offset: 0x008EFDC5
		public unsafe UTimelineComponent PointDissolveTimeline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x06021A4E RID: 137806 RVA: 0x008F1BDA File Offset: 0x008EFDDA
		// (set) Token: 0x06021A4F RID: 137807 RVA: 0x008F1BEA File Offset: 0x008EFDEA
		public unsafe float PartDissolveTimeline_NewTrack_0_8AF5E49A48B1594A8225889CB48ACD7F
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x06021A50 RID: 137808 RVA: 0x008F1BFB File Offset: 0x008EFDFB
		// (set) Token: 0x06021A51 RID: 137809 RVA: 0x008F1C0F File Offset: 0x008EFE0F
		[Nullable(0)]
		public unsafe TEnumAsByte<ETimelineDirection> PartDissolveTimeline__Direction_8AF5E49A48B1594A8225889CB48ACD7F
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_9);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x06021A52 RID: 137810 RVA: 0x008F1C24 File Offset: 0x008EFE24
		// (set) Token: 0x06021A53 RID: 137811 RVA: 0x008F1C38 File Offset: 0x008EFE38
		public unsafe UTimelineComponent PartDissolveTimeline
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTimelineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x06021A54 RID: 137812 RVA: 0x008F1C4D File Offset: 0x008EFE4D
		// (set) Token: 0x06021A55 RID: 137813 RVA: 0x008F1C61 File Offset: 0x008EFE61
		public unsafe KUROInteractFoliage_C FoliageType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<KUROInteractFoliage_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_InteractBreakFoliageActor_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x06021A56 RID: 137814 RVA: 0x008F1C76 File Offset: 0x008EFE76
		// (set) Token: 0x06021A57 RID: 137815 RVA: 0x008F1C86 File Offset: 0x008EFE86
		public unsafe bool Active
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x06021A58 RID: 137816 RVA: 0x008F1C97 File Offset: 0x008EFE97
		// (set) Token: 0x06021A59 RID: 137817 RVA: 0x008F1CA7 File Offset: 0x008EFEA7
		public unsafe float CachedQualityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x06021A5A RID: 137818 RVA: 0x008F1CB8 File Offset: 0x008EFEB8
		// (set) Token: 0x06021A5B RID: 137819 RVA: 0x008F1CCC File Offset: 0x008EFECC
		public unsafe FName AngleBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x06021A5C RID: 137820 RVA: 0x008F1CE1 File Offset: 0x008EFEE1
		// (set) Token: 0x06021A5D RID: 137821 RVA: 0x008F1CF5 File Offset: 0x008EFEF5
		public unsafe FName BreakBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x06021A5E RID: 137822 RVA: 0x008F1D0A File Offset: 0x008EFF0A
		// (set) Token: 0x06021A5F RID: 137823 RVA: 0x008F1D1E File Offset: 0x008EFF1E
		public unsafe FVector InitialDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x06021A60 RID: 137824 RVA: 0x008F1D33 File Offset: 0x008EFF33
		// (set) Token: 0x06021A61 RID: 137825 RVA: 0x008F1D43 File Offset: 0x008EFF43
		public unsafe bool UpperBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x06021A62 RID: 137826 RVA: 0x008F1D54 File Offset: 0x008EFF54
		// (set) Token: 0x06021A63 RID: 137827 RVA: 0x008F1D68 File Offset: 0x008EFF68
		public unsafe FName BreakJointName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x06021A64 RID: 137828 RVA: 0x008F1D80 File Offset: 0x008EFF80
		// (set) Token: 0x06021A65 RID: 137829 RVA: 0x008F1DB9 File Offset: 0x008EFFB9
		[Nullable(1)]
		public FCollisionResponseContainer New_Reponses
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCollisionResponseContainer result;
				if ((result = this._New_Reponses) == null)
				{
					result = (this._New_Reponses = new FCollisionResponseContainer(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_19, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionResponseContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_19, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x06021A66 RID: 137830 RVA: 0x008F1DDA File Offset: 0x008EFFDA
		// (set) Token: 0x06021A67 RID: 137831 RVA: 0x008F1DEA File Offset: 0x008EFFEA
		public unsafe float ImpulseStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x06021A68 RID: 137832 RVA: 0x008F1DFB File Offset: 0x008EFFFB
		// (set) Token: 0x06021A69 RID: 137833 RVA: 0x008F1E0F File Offset: 0x008F000F
		public unsafe FVector ExtraImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x06021A6A RID: 137834 RVA: 0x008F1E24 File Offset: 0x008F0024
		// (set) Token: 0x06021A6B RID: 137835 RVA: 0x008F1E34 File Offset: 0x008F0034
		public unsafe float AngularThreashold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x06021A6C RID: 137836 RVA: 0x008F1E45 File Offset: 0x008F0045
		// (set) Token: 0x06021A6D RID: 137837 RVA: 0x008F1E55 File Offset: 0x008F0055
		public unsafe float DissolveTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x06021A6E RID: 137838 RVA: 0x008F1E66 File Offset: 0x008F0066
		// (set) Token: 0x06021A6F RID: 137839 RVA: 0x008F1E76 File Offset: 0x008F0076
		public unsafe bool Broken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x06021A70 RID: 137840 RVA: 0x008F1E87 File Offset: 0x008F0087
		// (set) Token: 0x06021A71 RID: 137841 RVA: 0x008F1E97 File Offset: 0x008F0097
		public unsafe float PartDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_25);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_25) = value;
			}
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x06021A72 RID: 137842 RVA: 0x008F1EA8 File Offset: 0x008F00A8
		// (set) Token: 0x06021A73 RID: 137843 RVA: 0x008F1EB8 File Offset: 0x008F00B8
		public unsafe float BreakPointDissolve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x06021A74 RID: 137844 RVA: 0x008F1ECC File Offset: 0x008F00CC
		// (set) Token: 0x06021A75 RID: 137845 RVA: 0x008F1F05 File Offset: 0x008F0105
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
					result = (this._CustomData = new TArray<float>(base.NativePtr + (IntPtr)BP_InteractBreakFoliageActor_C.__PropertyOffset_27, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x06021A76 RID: 137846 RVA: 0x008F1F13 File Offset: 0x008F0113
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Reset()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__Reset_NativeFunctionPtr, null);
		}

		// Token: 0x06021A77 RID: 137847 RVA: 0x008F1F27 File Offset: 0x008F0127
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Test()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__Test_NativeFunctionPtr, null);
		}

		// Token: 0x06021A78 RID: 137848 RVA: 0x008F1F3C File Offset: 0x008F013C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AdaptQualityLevel(ref bool bShouldTick)
		{
			BP_InteractBreakFoliageActor_C.__AdaptQualityLevel_FunctionParams* ptr = stackalloc BP_InteractBreakFoliageActor_C.__AdaptQualityLevel_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InteractBreakFoliageActor_C.__AdaptQualityLevel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBreakFoliageActor_C.__AdaptQualityLevel_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bShouldTick = bShouldTick;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__AdaptQualityLevel_NativeFunctionPtr, (void*)ptr);
			bShouldTick = ptr->bShouldTick;
		}

		// Token: 0x06021A79 RID: 137849 RVA: 0x008F1F8C File Offset: 0x008F018C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ChangeActiveFoliageNum(float ChangeNum)
		{
			BP_InteractBreakFoliageActor_C.__ChangeActiveFoliageNum_FunctionParams* ptr = stackalloc BP_InteractBreakFoliageActor_C.__ChangeActiveFoliageNum_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(BP_InteractBreakFoliageActor_C.__ChangeActiveFoliageNum_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBreakFoliageActor_C.__ChangeActiveFoliageNum_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ChangeNum = ChangeNum;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__ChangeActiveFoliageNum_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021A7A RID: 137850 RVA: 0x008F1FD2 File Offset: 0x008F01D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06021A7B RID: 137851 RVA: 0x008F1FE6 File Offset: 0x008F01E6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021A7C RID: 137852 RVA: 0x008F1FFB File Offset: 0x008F01FB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PartDissolveTimeline__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__PartDissolveTimeline__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021A7D RID: 137853 RVA: 0x008F200F File Offset: 0x008F020F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PartDissolveTimeline__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__PartDissolveTimeline__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021A7E RID: 137854 RVA: 0x008F2023 File Offset: 0x008F0223
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PointDissolveTimeline__FinishedFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__PointDissolveTimeline__FinishedFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021A7F RID: 137855 RVA: 0x008F2037 File Offset: 0x008F0237
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void PointDissolveTimeline__UpdateFunc()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__PointDissolveTimeline__UpdateFunc_NativeFunctionPtr, null);
		}

		// Token: 0x06021A80 RID: 137856 RVA: 0x008F204C File Offset: 0x008F024C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021A81 RID: 137857 RVA: 0x008F2108 File Offset: 0x008F0308
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021A82 RID: 137858 RVA: 0x008F2194 File Offset: 0x008F0394
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_InteractBreakFoliageActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractBreakFoliageActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractBreakFoliageActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBreakFoliageActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021A83 RID: 137859 RVA: 0x008F21DC File Offset: 0x008F03DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_InteractBreakFoliageActor_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_InteractBreakFoliageActor_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractBreakFoliageActor_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBreakFoliageActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021A84 RID: 137860 RVA: 0x008F2223 File Offset: 0x008F0423
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TestBreak()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__TestBreak_NativeFunctionPtr, null);
		}

		// Token: 0x06021A85 RID: 137861 RVA: 0x008F2238 File Offset: 0x008F0438
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void CallChange(float Weight)
		{
			BP_InteractBreakFoliageActor_C.__CallChange_FunctionParams* ptr = stackalloc BP_InteractBreakFoliageActor_C.__CallChange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_InteractBreakFoliageActor_C.__CallChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_InteractBreakFoliageActor_C.__CallChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Weight = Weight;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__CallChange_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06021A86 RID: 137862 RVA: 0x008F227E File Offset: 0x008F047E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06021A87 RID: 137863 RVA: 0x008F2292 File Offset: 0x008F0492
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_InteractBreakFoliageActor_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06021A88 RID: 137864 RVA: 0x008F22A7 File Offset: 0x008F04A7
		protected BP_InteractBreakFoliageActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010676 RID: 67190
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/InteractFoliage/Blueprint/BP_InteractBreakFoliageActor.BP_InteractBreakFoliageActor_C";

		// Token: 0x04010677 RID: 67191
		private static IntPtr _ClassPtr;

		// Token: 0x04010678 RID: 67192
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010679 RID: 67193
		internal static int __PropertyOffset_1;

		// Token: 0x0401067A RID: 67194
		internal static int __PropertyOffset_2;

		// Token: 0x0401067B RID: 67195
		internal static int __PropertyOffset_3;

		// Token: 0x0401067C RID: 67196
		internal static int __PropertyOffset_4;

		// Token: 0x0401067D RID: 67197
		internal static int __PropertyOffset_5;

		// Token: 0x0401067E RID: 67198
		internal static int __PropertyOffset_6;

		// Token: 0x0401067F RID: 67199
		internal static int __PropertyOffset_7;

		// Token: 0x04010680 RID: 67200
		internal static int __PropertyOffset_8;

		// Token: 0x04010681 RID: 67201
		internal static int __PropertyOffset_9;

		// Token: 0x04010682 RID: 67202
		internal static int __PropertyOffset_10;

		// Token: 0x04010683 RID: 67203
		internal static int __PropertyOffset_11;

		// Token: 0x04010684 RID: 67204
		internal static int __PropertyOffset_12;

		// Token: 0x04010685 RID: 67205
		internal static int __PropertyOffset_13;

		// Token: 0x04010686 RID: 67206
		internal static int __PropertyOffset_14;

		// Token: 0x04010687 RID: 67207
		internal static int __PropertyOffset_15;

		// Token: 0x04010688 RID: 67208
		internal static int __PropertyOffset_16;

		// Token: 0x04010689 RID: 67209
		internal static int __PropertyOffset_17;

		// Token: 0x0401068A RID: 67210
		internal static int __PropertyOffset_18;

		// Token: 0x0401068B RID: 67211
		internal static int __PropertyOffset_19;

		// Token: 0x0401068C RID: 67212
		private FCollisionResponseContainer _New_Reponses;

		// Token: 0x0401068D RID: 67213
		internal static int __PropertyOffset_20;

		// Token: 0x0401068E RID: 67214
		internal static int __PropertyOffset_21;

		// Token: 0x0401068F RID: 67215
		internal static int __PropertyOffset_22;

		// Token: 0x04010690 RID: 67216
		internal static int __PropertyOffset_23;

		// Token: 0x04010691 RID: 67217
		internal static int __PropertyOffset_24;

		// Token: 0x04010692 RID: 67218
		internal static int __PropertyOffset_25;

		// Token: 0x04010693 RID: 67219
		internal static int __PropertyOffset_26;

		// Token: 0x04010694 RID: 67220
		internal static int __PropertyOffset_27;

		// Token: 0x04010695 RID: 67221
		private TArray<float> _CustomData;

		// Token: 0x04010696 RID: 67222
		private static IntPtr __Reset_NativeFunctionPtr;

		// Token: 0x04010697 RID: 67223
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x04010698 RID: 67224
		private static IntPtr __AdaptQualityLevel_NativeFunctionPtr;

		// Token: 0x04010699 RID: 67225
		private static IntPtr __ChangeActiveFoliageNum_NativeFunctionPtr;

		// Token: 0x0401069A RID: 67226
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0401069B RID: 67227
		private static IntPtr __PartDissolveTimeline__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0401069C RID: 67228
		private static IntPtr __PartDissolveTimeline__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0401069D RID: 67229
		private static IntPtr __PointDissolveTimeline__FinishedFunc_NativeFunctionPtr;

		// Token: 0x0401069E RID: 67230
		private static IntPtr __PointDissolveTimeline__UpdateFunc_NativeFunctionPtr;

		// Token: 0x0401069F RID: 67231
		private static IntPtr __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040106A0 RID: 67232
		private static IntPtr __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040106A1 RID: 67233
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040106A2 RID: 67234
		private static IntPtr __TestBreak_NativeFunctionPtr;

		// Token: 0x040106A3 RID: 67235
		private static IntPtr __CallChange_NativeFunctionPtr;

		// Token: 0x040106A4 RID: 67236
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02009CAC RID: 40108
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __AdaptQualityLevel_FunctionParams
		{
			// Token: 0x04031379 RID: 201593
			[FieldOffset(0)]
			public bool bShouldTick;
		}

		// Token: 0x02009CAD RID: 40109
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ChangeActiveFoliageNum_FunctionParams
		{
			// Token: 0x0403137A RID: 201594
			[FieldOffset(0)]
			public float ChangeNum;
		}

		// Token: 0x02009CAE RID: 40110
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x0403137B RID: 201595
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x0403137C RID: 201596
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x0403137D RID: 201597
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x0403137E RID: 201598
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x0403137F RID: 201599
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x04031380 RID: 201600
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009CAF RID: 40111
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_InteractFoliageActor_Box_K2Node_ComponentBoundEvent_1_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x04031381 RID: 201601
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x04031382 RID: 201602
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x04031383 RID: 201603
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x04031384 RID: 201604
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009CB0 RID: 40112
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04031385 RID: 201605
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009CB1 RID: 40113
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __CallChange_FunctionParams
		{
			// Token: 0x04031386 RID: 201606
			[FieldOffset(0)]
			public float Weight;
		}
	}
}
