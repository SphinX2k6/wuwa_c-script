using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AClusterBalloons
{
	// Token: 0x02003CDF RID: 15583
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/BP_AClusterBallons_2.BP_AClusterBallons_2_C")]
	[UnrealStructLayout(1888, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class BP_AClusterBallons_2_C : AKuroCSBalloons, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025020 RID: 151584 RVA: 0x0094E857 File Offset: 0x0094CA57
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AClusterBallons_2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/BP_AClusterBallons_2.BP_AClusterBallons_2_C");
			}
			return BP_AClusterBallons_2_C._ClassPtr;
		}

		// Token: 0x06025021 RID: 151585 RVA: 0x0094E87C File Offset: 0x0094CA7C
		public BP_AClusterBallons_2_C() : this(BuiltinUtils.AllocNativeUObject(BP_AClusterBallons_2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025022 RID: 151586 RVA: 0x0094E8A4 File Offset: 0x0094CAA4
		[NullableContext(1)]
		public BP_AClusterBallons_2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AClusterBallons_2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A4C RID: 19020
		// (get) Token: 0x06025023 RID: 151587 RVA: 0x0094E8D7 File Offset: 0x0094CAD7
		// (set) Token: 0x06025024 RID: 151588 RVA: 0x0094E8EB File Offset: 0x0094CAEB
		public unsafe UBoxComponent ValidBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004A4D RID: 19021
		// (get) Token: 0x06025025 RID: 151589 RVA: 0x0094E900 File Offset: 0x0094CB00
		// (set) Token: 0x06025026 RID: 151590 RVA: 0x0094E914 File Offset: 0x0094CB14
		public unsafe UStaticMeshComponent xpbd_test
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004A4E RID: 19022
		// (get) Token: 0x06025027 RID: 151591 RVA: 0x0094E929 File Offset: 0x0094CB29
		// (set) Token: 0x06025028 RID: 151592 RVA: 0x0094E93D File Offset: 0x0094CB3D
		public unsafe UTextureRenderTarget2D RT_Pos
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x17004A4F RID: 19023
		// (get) Token: 0x06025029 RID: 151593 RVA: 0x0094E952 File Offset: 0x0094CB52
		// (set) Token: 0x0602502A RID: 151594 RVA: 0x0094E966 File Offset: 0x0094CB66
		public unsafe UDataTable DT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x17004A50 RID: 19024
		// (get) Token: 0x0602502B RID: 151595 RVA: 0x0094E97B File Offset: 0x0094CB7B
		// (set) Token: 0x0602502C RID: 151596 RVA: 0x0094E98F File Offset: 0x0094CB8F
		public unsafe UMaterialInstanceDynamic MID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17004A51 RID: 19025
		// (get) Token: 0x0602502D RID: 151597 RVA: 0x0094E9A4 File Offset: 0x0094CBA4
		// (set) Token: 0x0602502E RID: 151598 RVA: 0x0094E9B4 File Offset: 0x0094CBB4
		public unsafe bool debugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A52 RID: 19026
		// (get) Token: 0x0602502F RID: 151599 RVA: 0x0094E9C5 File Offset: 0x0094CBC5
		// (set) Token: 0x06025030 RID: 151600 RVA: 0x0094E9D9 File Offset: 0x0094CBD9
		public unsafe UMaterialInstance InputMat
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17004A53 RID: 19027
		// (get) Token: 0x06025031 RID: 151601 RVA: 0x0094E9EE File Offset: 0x0094CBEE
		// (set) Token: 0x06025032 RID: 151602 RVA: 0x0094E9FE File Offset: 0x0094CBFE
		public unsafe float force
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17004A54 RID: 19028
		// (get) Token: 0x06025033 RID: 151603 RVA: 0x0094EA0F File Offset: 0x0094CC0F
		// (set) Token: 0x06025034 RID: 151604 RVA: 0x0094EA1F File Offset: 0x0094CC1F
		public unsafe bool Pressing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_9) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_9) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A55 RID: 19029
		// (get) Token: 0x06025035 RID: 151605 RVA: 0x0094EA30 File Offset: 0x0094CC30
		// (set) Token: 0x06025036 RID: 151606 RVA: 0x0094EA40 File Offset: 0x0094CC40
		public unsafe bool FS_isPhysicSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_10) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_10) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A56 RID: 19030
		// (get) Token: 0x06025037 RID: 151607 RVA: 0x0094EA51 File Offset: 0x0094CC51
		// (set) Token: 0x06025038 RID: 151608 RVA: 0x0094EA61 File Offset: 0x0094CC61
		public unsafe float mass_in_kg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17004A57 RID: 19031
		// (get) Token: 0x06025039 RID: 151609 RVA: 0x0094EA72 File Offset: 0x0094CC72
		// (set) Token: 0x0602503A RID: 151610 RVA: 0x0094EA82 File Offset: 0x0094CC82
		public unsafe bool beditorTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_12) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_12) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A58 RID: 19032
		// (get) Token: 0x0602503B RID: 151611 RVA: 0x0094EA93 File Offset: 0x0094CC93
		// (set) Token: 0x0602503C RID: 151612 RVA: 0x0094EAA3 File Offset: 0x0094CCA3
		public unsafe bool _2DRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A59 RID: 19033
		// (get) Token: 0x0602503D RID: 151613 RVA: 0x0094EAB4 File Offset: 0x0094CCB4
		// (set) Token: 0x0602503E RID: 151614 RVA: 0x0094EAC4 File Offset: 0x0094CCC4
		public unsafe int XCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17004A5A RID: 19034
		// (get) Token: 0x0602503F RID: 151615 RVA: 0x0094EAD5 File Offset: 0x0094CCD5
		// (set) Token: 0x06025040 RID: 151616 RVA: 0x0094EAE5 File Offset: 0x0094CCE5
		public unsafe bool ReadDataInBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A5B RID: 19035
		// (get) Token: 0x06025041 RID: 151617 RVA: 0x0094EAF6 File Offset: 0x0094CCF6
		// (set) Token: 0x06025042 RID: 151618 RVA: 0x0094EB0A File Offset: 0x0094CD0A
		public unsafe UStaticMesh inputStaticMesh_ForBPL_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_16);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_16, value);
			}
		}

		// Token: 0x17004A5C RID: 19036
		// (get) Token: 0x06025043 RID: 151619 RVA: 0x0094EB1F File Offset: 0x0094CD1F
		// (set) Token: 0x06025044 RID: 151620 RVA: 0x0094EB2F File Offset: 0x0094CD2F
		public unsafe bool extraOneMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A5D RID: 19037
		// (get) Token: 0x06025045 RID: 151621 RVA: 0x0094EB40 File Offset: 0x0094CD40
		// (set) Token: 0x06025046 RID: 151622 RVA: 0x0094EB54 File Offset: 0x0094CD54
		public unsafe UMaterialInstance InputMat1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_18);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_18, value);
			}
		}

		// Token: 0x17004A5E RID: 19038
		// (get) Token: 0x06025047 RID: 151623 RVA: 0x0094EB69 File Offset: 0x0094CD69
		// (set) Token: 0x06025048 RID: 151624 RVA: 0x0094EB7D File Offset: 0x0094CD7D
		public unsafe UMaterialInstanceDynamic MID1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_19);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_19, value);
			}
		}

		// Token: 0x17004A5F RID: 19039
		// (get) Token: 0x06025049 RID: 151625 RVA: 0x0094EB92 File Offset: 0x0094CD92
		// (set) Token: 0x0602504A RID: 151626 RVA: 0x0094EBA2 File Offset: 0x0094CDA2
		public unsafe bool StopBP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A60 RID: 19040
		// (get) Token: 0x0602504B RID: 151627 RVA: 0x0094EBB3 File Offset: 0x0094CDB3
		// (set) Token: 0x0602504C RID: 151628 RVA: 0x0094EBC3 File Offset: 0x0094CDC3
		public unsafe bool UseYCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A61 RID: 19041
		// (get) Token: 0x0602504D RID: 151629 RVA: 0x0094EBD4 File Offset: 0x0094CDD4
		// (set) Token: 0x0602504E RID: 151630 RVA: 0x0094EBE8 File Offset: 0x0094CDE8
		public unsafe FVector WeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17004A62 RID: 19042
		// (get) Token: 0x0602504F RID: 151631 RVA: 0x0094EBFD File Offset: 0x0094CDFD
		// (set) Token: 0x06025050 RID: 151632 RVA: 0x0094EC11 File Offset: 0x0094CE11
		public unsafe FVector LastWeaponPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_23);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_23) = value;
			}
		}

		// Token: 0x17004A63 RID: 19043
		// (get) Token: 0x06025051 RID: 151633 RVA: 0x0094EC26 File Offset: 0x0094CE26
		// (set) Token: 0x06025052 RID: 151634 RVA: 0x0094EC36 File Offset: 0x0094CE36
		public unsafe bool alreadyBuildArr
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A64 RID: 19044
		// (get) Token: 0x06025053 RID: 151635 RVA: 0x0094EC47 File Offset: 0x0094CE47
		// (set) Token: 0x06025054 RID: 151636 RVA: 0x0094EC57 File Offset: 0x0094CE57
		public unsafe bool initOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A65 RID: 19045
		// (get) Token: 0x06025055 RID: 151637 RVA: 0x0094EC68 File Offset: 0x0094CE68
		// (set) Token: 0x06025056 RID: 151638 RVA: 0x0094EC78 File Offset: 0x0094CE78
		public unsafe bool PlatformCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A66 RID: 19046
		// (get) Token: 0x06025057 RID: 151639 RVA: 0x0094EC89 File Offset: 0x0094CE89
		// (set) Token: 0x06025058 RID: 151640 RVA: 0x0094EC99 File Offset: 0x0094CE99
		public unsafe bool bAfterBeginplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A67 RID: 19047
		// (get) Token: 0x06025059 RID: 151641 RVA: 0x0094ECAA File Offset: 0x0094CEAA
		// (set) Token: 0x0602505A RID: 151642 RVA: 0x0094ECBE File Offset: 0x0094CEBE
		public unsafe UChildActorComponent EditorTicker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChildActorComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_28);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_28, value);
			}
		}

		// Token: 0x17004A68 RID: 19048
		// (get) Token: 0x0602505B RID: 151643 RVA: 0x0094ECD3 File Offset: 0x0094CED3
		// (set) Token: 0x0602505C RID: 151644 RVA: 0x0094ECE3 File Offset: 0x0094CEE3
		public unsafe int YCount_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_29);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AClusterBallons_2_C.__PropertyOffset_29) = value;
			}
		}

		// Token: 0x17004A69 RID: 19049
		// (get) Token: 0x0602505D RID: 151645 RVA: 0x0094ECF4 File Offset: 0x0094CEF4
		// (set) Token: 0x0602505E RID: 151646 RVA: 0x0094ED08 File Offset: 0x0094CF08
		public unsafe UTextureRenderTarget2D RT_N
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_30);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AClusterBallons_2_C.__PropertyOffset_30, value);
			}
		}

		// Token: 0x0602505F RID: 151647 RVA: 0x0094ED1D File Offset: 0x0094CF1D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_2_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x06025060 RID: 151648 RVA: 0x0094ED31 File Offset: 0x0094CF31
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_2_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025061 RID: 151649 RVA: 0x0094ED46 File Offset: 0x0094CF46
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06025062 RID: 151650 RVA: 0x0094ED5A File Offset: 0x0094CF5A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_2_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06025063 RID: 151651 RVA: 0x0094ED70 File Offset: 0x0094CF70
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_AClusterBallons_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AClusterBallons_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AClusterBallons_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025064 RID: 151652 RVA: 0x0094EDB8 File Offset: 0x0094CFB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_AClusterBallons_2_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_AClusterBallons_2_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_AClusterBallons_2_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_2_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025065 RID: 151653 RVA: 0x0094EE00 File Offset: 0x0094D000
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveEndPlay(EEndPlayReason EndPlayReason)
		{
			BP_AClusterBallons_2_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_AClusterBallons_2_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_AClusterBallons_2_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_2_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_2_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025066 RID: 151654 RVA: 0x0094EE4C File Offset: 0x0094D04C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveEndPlay_Implementation(EEndPlayReason EndPlayReason)
		{
			BP_AClusterBallons_2_C.__ReceiveEndPlay_FunctionParams* ptr = stackalloc BP_AClusterBallons_2_C.__ReceiveEndPlay_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(BP_AClusterBallons_2_C.__ReceiveEndPlay_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_2_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EndPlayReason = EndPlayReason;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_AClusterBallons_2_C.__ReceiveEndPlay_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06025067 RID: 151655 RVA: 0x0094EE98 File Offset: 0x0094D098
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult Hit)
		{
			BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->HitComponent = ((HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->NormalImpulse = NormalImpulse;
			if (Hit != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->Hit, Hit.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025068 RID: 151656 RVA: 0x0094EF4C File Offset: 0x0094D14C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			ptr->bFromSweep = bFromSweep;
			if (SweepResult != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), &ptr->SweepResult, SweepResult.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06025069 RID: 151657 RVA: 0x0094F008 File Offset: 0x0094D208
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex)
		{
			BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams* ptr = stackalloc BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OverlappedComponent = ((OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero);
			ptr->OtherActor = ((OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero);
			ptr->OtherComp = ((OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero);
			ptr->OtherBodyIndex = OtherBodyIndex;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_2_C.__BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602506A RID: 151658 RVA: 0x0094F094 File Offset: 0x0094D294
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnWeaponInteraction(FVectorDouble OriginPoint, BP_SceneBattleInteract_C Config, int Id)
		{
			BP_AClusterBallons_2_C.__OnWeaponInteraction_FunctionParams* ptr = stackalloc BP_AClusterBallons_2_C.__OnWeaponInteraction_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(BP_AClusterBallons_2_C.__OnWeaponInteraction_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_AClusterBallons_2_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OriginPoint = OriginPoint;
			ptr->Config = ((Config != null) ? Config.NativePtr : IntPtr.Zero);
			ptr->Id = Id;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_2_C.__OnWeaponInteraction_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602506B RID: 151659 RVA: 0x0094F0F7 File Offset: 0x0094D2F7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void EditorTick()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_AClusterBallons_2_C.__EditorTick_NativeFunctionPtr, null);
		}

		// Token: 0x0602506C RID: 151660 RVA: 0x0094F10B File Offset: 0x0094D30B
		protected BP_AClusterBallons_2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012680 RID: 75392
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/BP_AClusterBallons_2.BP_AClusterBallons_2_C";

		// Token: 0x04012681 RID: 75393
		private static IntPtr _ClassPtr;

		// Token: 0x04012682 RID: 75394
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012683 RID: 75395
		internal static int __PropertyOffset_1;

		// Token: 0x04012684 RID: 75396
		internal static int __PropertyOffset_2;

		// Token: 0x04012685 RID: 75397
		internal static int __PropertyOffset_3;

		// Token: 0x04012686 RID: 75398
		internal static int __PropertyOffset_4;

		// Token: 0x04012687 RID: 75399
		internal static int __PropertyOffset_5;

		// Token: 0x04012688 RID: 75400
		internal static int __PropertyOffset_6;

		// Token: 0x04012689 RID: 75401
		internal static int __PropertyOffset_7;

		// Token: 0x0401268A RID: 75402
		internal static int __PropertyOffset_8;

		// Token: 0x0401268B RID: 75403
		internal static int __PropertyOffset_9;

		// Token: 0x0401268C RID: 75404
		internal static int __PropertyOffset_10;

		// Token: 0x0401268D RID: 75405
		internal static int __PropertyOffset_11;

		// Token: 0x0401268E RID: 75406
		internal static int __PropertyOffset_12;

		// Token: 0x0401268F RID: 75407
		internal static int __PropertyOffset_13;

		// Token: 0x04012690 RID: 75408
		internal static int __PropertyOffset_14;

		// Token: 0x04012691 RID: 75409
		internal static int __PropertyOffset_15;

		// Token: 0x04012692 RID: 75410
		internal static int __PropertyOffset_16;

		// Token: 0x04012693 RID: 75411
		internal static int __PropertyOffset_17;

		// Token: 0x04012694 RID: 75412
		internal static int __PropertyOffset_18;

		// Token: 0x04012695 RID: 75413
		internal static int __PropertyOffset_19;

		// Token: 0x04012696 RID: 75414
		internal static int __PropertyOffset_20;

		// Token: 0x04012697 RID: 75415
		internal static int __PropertyOffset_21;

		// Token: 0x04012698 RID: 75416
		internal static int __PropertyOffset_22;

		// Token: 0x04012699 RID: 75417
		internal static int __PropertyOffset_23;

		// Token: 0x0401269A RID: 75418
		internal static int __PropertyOffset_24;

		// Token: 0x0401269B RID: 75419
		internal static int __PropertyOffset_25;

		// Token: 0x0401269C RID: 75420
		internal static int __PropertyOffset_26;

		// Token: 0x0401269D RID: 75421
		internal static int __PropertyOffset_27;

		// Token: 0x0401269E RID: 75422
		internal static int __PropertyOffset_28;

		// Token: 0x0401269F RID: 75423
		internal static int __PropertyOffset_29;

		// Token: 0x040126A0 RID: 75424
		internal static int __PropertyOffset_30;

		// Token: 0x040126A1 RID: 75425
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x040126A2 RID: 75426
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x040126A3 RID: 75427
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040126A4 RID: 75428
		private static IntPtr __ReceiveEndPlay_NativeFunctionPtr;

		// Token: 0x040126A5 RID: 75429
		private static IntPtr __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040126A6 RID: 75430
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040126A7 RID: 75431
		private static IntPtr __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040126A8 RID: 75432
		private static IntPtr __OnWeaponInteraction_NativeFunctionPtr;

		// Token: 0x040126A9 RID: 75433
		private static IntPtr __EditorTick_NativeFunctionPtr;

		// Token: 0x02009FA2 RID: 40866
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x040319E8 RID: 203240
			[FieldOffset(0)]
			public float DeltaSeconds;
		}

		// Token: 0x02009FA3 RID: 40867
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __ReceiveEndPlay_FunctionParams
		{
			// Token: 0x040319E9 RID: 203241
			[FieldOffset(0)]
			public TEnumAsByte<EEndPlayReason> EndPlayReason;
		}

		// Token: 0x02009FA4 RID: 40868
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_xpbd_test_K2Node_ComponentBoundEvent_1_ComponentHitSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319EA RID: 203242
			[FieldOffset(0)]
			public IntPtr HitComponent;

			// Token: 0x040319EB RID: 203243
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319EC RID: 203244
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319ED RID: 203245
			[FieldOffset(24)]
			public FVector NormalImpulse;

			// Token: 0x040319EE RID: 203246
			[FieldOffset(36)]
			public byte Hit;
		}

		// Token: 0x02009FA5 RID: 40869
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_0_ComponentBeginOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319EF RID: 203247
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319F0 RID: 203248
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319F1 RID: 203249
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319F2 RID: 203250
			[FieldOffset(24)]
			public int OtherBodyIndex;

			// Token: 0x040319F3 RID: 203251
			[FieldOffset(28)]
			public bool bFromSweep;

			// Token: 0x040319F4 RID: 203252
			[FieldOffset(32)]
			public byte SweepResult;
		}

		// Token: 0x02009FA6 RID: 40870
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __BndEvt__BP_RPBD_ValidBox_K2Node_ComponentBoundEvent_3_ComponentEndOverlapSignature__DelegateSignature_FunctionParams
		{
			// Token: 0x040319F5 RID: 203253
			[FieldOffset(0)]
			public IntPtr OverlappedComponent;

			// Token: 0x040319F6 RID: 203254
			[FieldOffset(8)]
			public IntPtr OtherActor;

			// Token: 0x040319F7 RID: 203255
			[FieldOffset(16)]
			public IntPtr OtherComp;

			// Token: 0x040319F8 RID: 203256
			[FieldOffset(24)]
			public int OtherBodyIndex;
		}

		// Token: 0x02009FA7 RID: 40871
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWeaponInteraction_FunctionParams
		{
			// Token: 0x040319F9 RID: 203257
			[FieldOffset(0)]
			public FVectorDouble OriginPoint;

			// Token: 0x040319FA RID: 203258
			[FieldOffset(24)]
			public IntPtr Config;

			// Token: 0x040319FB RID: 203259
			[FieldOffset(32)]
			public int Id;
		}
	}
}
