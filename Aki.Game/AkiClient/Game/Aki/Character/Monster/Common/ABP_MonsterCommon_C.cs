using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Fight.AssestStruct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x0200424D RID: 16973
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C")]
	[UnrealStructLayout(15184, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 15176)]
	public class ABP_MonsterCommon_C : UKuroAnimInstanceMonster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602BF5F RID: 180063 RVA: 0x00A1053C File Offset: 0x00A0E73C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_MonsterCommon_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C");
			}
			return ABP_MonsterCommon_C._ClassPtr;
		}

		// Token: 0x0602BF60 RID: 180064 RVA: 0x00A10560 File Offset: 0x00A0E760
		public ABP_MonsterCommon_C() : this(BuiltinUtils.AllocNativeUObject(ABP_MonsterCommon_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602BF61 RID: 180065 RVA: 0x00A10588 File Offset: 0x00A0E788
		[NullableContext(1)]
		public ABP_MonsterCommon_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_MonsterCommon_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D10 RID: 27920
		// (get) Token: 0x0602BF62 RID: 180066 RVA: 0x00A105BB File Offset: 0x00A0E7BB
		// (set) Token: 0x0602BF63 RID: 180067 RVA: 0x00A105CF File Offset: 0x00A0E7CF
		public unsafe TsBaseCharacter As_Base_Character
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_81);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_81, value);
			}
		}

		// Token: 0x17006D11 RID: 27921
		// (get) Token: 0x0602BF64 RID: 180068 RVA: 0x00A105E4 File Offset: 0x00A0E7E4
		// (set) Token: 0x0602BF65 RID: 180069 RVA: 0x00A1061D File Offset: 0x00A0E81D
		[Nullable(1)]
		public FSkeletonGroup Skeleton_Block_Info
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSkeletonGroup result;
				if ((result = this._Skeleton_Block_Info) == null)
				{
					result = (this._Skeleton_Block_Info = new FSkeletonGroup(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_82, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSkeletonGroup.StaticStruct(), base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_82, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006D12 RID: 27922
		// (get) Token: 0x0602BF66 RID: 180070 RVA: 0x00A1063E File Offset: 0x00A0E83E
		// (set) Token: 0x0602BF67 RID: 180071 RVA: 0x00A10652 File Offset: 0x00A0E852
		public unsafe FK_Shake_AssestData_C FKShakeData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<FK_Shake_AssestData_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_83);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_83, value);
			}
		}

		// Token: 0x17006D13 RID: 27923
		// (get) Token: 0x0602BF68 RID: 180072 RVA: 0x00A10668 File Offset: 0x00A0E868
		// (set) Token: 0x0602BF69 RID: 180073 RVA: 0x00A106A1 File Offset: 0x00A0E8A1
		[Nullable(1)]
		public NewEventDispatcher_0 NewEventDispatcher_0
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				NewEventDispatcher_0 result;
				if ((result = this._NewEventDispatcher_0) == null)
				{
					result = (this._NewEventDispatcher_0 = new NewEventDispatcher_0(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_84, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_84, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006D14 RID: 27924
		// (get) Token: 0x0602BF6A RID: 180074 RVA: 0x00A106C2 File Offset: 0x00A0E8C2
		// (set) Token: 0x0602BF6B RID: 180075 RVA: 0x00A106D2 File Offset: 0x00A0E8D2
		public unsafe int Increment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_85);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_85) = value;
			}
		}

		// Token: 0x17006D15 RID: 27925
		// (get) Token: 0x0602BF6C RID: 180076 RVA: 0x00A106E3 File Offset: 0x00A0E8E3
		// (set) Token: 0x0602BF6D RID: 180077 RVA: 0x00A106F3 File Offset: 0x00A0E8F3
		public unsafe SightLockMode CameraMode_DEPRECATED
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_86));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_86) = (byte)value;
			}
		}

		// Token: 0x17006D16 RID: 27926
		// (get) Token: 0x0602BF6E RID: 180078 RVA: 0x00A10704 File Offset: 0x00A0E904
		// (set) Token: 0x0602BF6F RID: 180079 RVA: 0x00A10714 File Offset: 0x00A0E914
		public unsafe float Assist_Limit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_87);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_87) = value;
			}
		}

		// Token: 0x17006D17 RID: 27927
		// (get) Token: 0x0602BF70 RID: 180080 RVA: 0x00A10725 File Offset: 0x00A0E925
		// (set) Token: 0x0602BF71 RID: 180081 RVA: 0x00A10739 File Offset: 0x00A0E939
		public unsafe FName Sight_Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_88);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_88) = value;
			}
		}

		// Token: 0x17006D18 RID: 27928
		// (get) Token: 0x0602BF72 RID: 180082 RVA: 0x00A1074E File Offset: 0x00A0E94E
		// (set) Token: 0x0602BF73 RID: 180083 RVA: 0x00A10762 File Offset: 0x00A0E962
		public unsafe FName Begin_Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_89);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_89) = value;
			}
		}

		// Token: 0x17006D19 RID: 27929
		// (get) Token: 0x0602BF74 RID: 180084 RVA: 0x00A10777 File Offset: 0x00A0E977
		// (set) Token: 0x0602BF75 RID: 180085 RVA: 0x00A1078B File Offset: 0x00A0E98B
		public unsafe FName End_Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_90);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_90) = value;
			}
		}

		// Token: 0x17006D1A RID: 27930
		// (get) Token: 0x0602BF76 RID: 180086 RVA: 0x00A107A0 File Offset: 0x00A0E9A0
		// (set) Token: 0x0602BF77 RID: 180087 RVA: 0x00A107B0 File Offset: 0x00A0E9B0
		public unsafe float ShakeAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_91);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_91) = value;
			}
		}

		// Token: 0x17006D1B RID: 27931
		// (get) Token: 0x0602BF78 RID: 180088 RVA: 0x00A107C1 File Offset: 0x00A0E9C1
		// (set) Token: 0x0602BF79 RID: 180089 RVA: 0x00A107D1 File Offset: 0x00A0E9D1
		public unsafe int ShakeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_92);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_92) = value;
			}
		}

		// Token: 0x17006D1C RID: 27932
		// (get) Token: 0x0602BF7A RID: 180090 RVA: 0x00A107E4 File Offset: 0x00A0E9E4
		// (set) Token: 0x0602BF7B RID: 180091 RVA: 0x00A1081D File Offset: 0x00A0EA1D
		[Nullable(1)]
		public TArray<PD_CharacterControllerData_C> HitMaterial
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<PD_CharacterControllerData_C> result;
				if ((result = this._HitMaterial) == null)
				{
					result = (this._HitMaterial = new TArray<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_93, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HitMaterial.CopyAssign(value);
			}
		}

		// Token: 0x17006D1D RID: 27933
		// (get) Token: 0x0602BF7C RID: 180092 RVA: 0x00A1082B File Offset: 0x00A0EA2B
		// (set) Token: 0x0602BF7D RID: 180093 RVA: 0x00A1083B File Offset: 0x00A0EA3B
		public unsafe float ToughDecreaseValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_94);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_94) = value;
			}
		}

		// Token: 0x17006D1E RID: 27934
		// (get) Token: 0x0602BF7E RID: 180094 RVA: 0x00A1084C File Offset: 0x00A0EA4C
		// (set) Token: 0x0602BF7F RID: 180095 RVA: 0x00A10885 File Offset: 0x00A0EA85
		[Nullable(1)]
		public FGameplayTagContainer CachedTagContainer
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._CachedTagContainer) == null)
				{
					result = (this._CachedTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_95, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_95, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006D1F RID: 27935
		// (get) Token: 0x0602BF80 RID: 180096 RVA: 0x00A108A6 File Offset: 0x00A0EAA6
		// (set) Token: 0x0602BF81 RID: 180097 RVA: 0x00A108B6 File Offset: 0x00A0EAB6
		public unsafe bool TestFkBoolean
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_96) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_96) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D20 RID: 27936
		// (get) Token: 0x0602BF82 RID: 180098 RVA: 0x00A108C7 File Offset: 0x00A0EAC7
		// (set) Token: 0x0602BF83 RID: 180099 RVA: 0x00A108DB File Offset: 0x00A0EADB
		public unsafe UCurveFloat ShakeCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_97);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_97, value);
			}
		}

		// Token: 0x17006D21 RID: 27937
		// (get) Token: 0x0602BF84 RID: 180100 RVA: 0x00A108F0 File Offset: 0x00A0EAF0
		// (set) Token: 0x0602BF85 RID: 180101 RVA: 0x00A10900 File Offset: 0x00A0EB00
		public unsafe bool 大体型怪物
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_98) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_98) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D22 RID: 27938
		// (get) Token: 0x0602BF86 RID: 180102 RVA: 0x00A10911 File Offset: 0x00A0EB11
		// (set) Token: 0x0602BF87 RID: 180103 RVA: 0x00A10925 File Offset: 0x00A0EB25
		public unsafe TsBaseCharacter 仇恨当前对象
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_99);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_99, value);
			}
		}

		// Token: 0x17006D23 RID: 27939
		// (get) Token: 0x0602BF88 RID: 180104 RVA: 0x00A1093A File Offset: 0x00A0EB3A
		// (set) Token: 0x0602BF89 RID: 180105 RVA: 0x00A1094E File Offset: 0x00A0EB4E
		public unsafe FName Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_100);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_100) = value;
			}
		}

		// Token: 0x17006D24 RID: 27940
		// (get) Token: 0x0602BF8A RID: 180106 RVA: 0x00A10963 File Offset: 0x00A0EB63
		// (set) Token: 0x0602BF8B RID: 180107 RVA: 0x00A10977 File Offset: 0x00A0EB77
		public unsafe BP_ABPLogicParams_C Ts逻辑变量集
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_ABPLogicParams_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_101);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_101, value);
			}
		}

		// Token: 0x17006D25 RID: 27941
		// (get) Token: 0x0602BF8C RID: 180108 RVA: 0x00A1098C File Offset: 0x00A0EB8C
		// (set) Token: 0x0602BF8D RID: 180109 RVA: 0x00A109C5 File Offset: 0x00A0EBC5
		[Nullable(1)]
		public FBoneFeedbackAnimConfigGroup Feedback_Anim
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FBoneFeedbackAnimConfigGroup result;
				if ((result = this._Feedback_Anim) == null)
				{
					result = (this._Feedback_Anim = new FBoneFeedbackAnimConfigGroup(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_102, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneFeedbackAnimConfigGroup.StaticStruct(), base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_102, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602BF8E RID: 180110 RVA: 0x00A109E8 File Offset: 0x00A0EBE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void IKAndFk(FPoseLink InPose, ref FPoseLink IKAndFk)
		{
			ABP_MonsterCommon_C.__IKAndFk_FunctionParams* ptr = stackalloc ABP_MonsterCommon_C.__IKAndFk_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(ABP_MonsterCommon_C.__IKAndFk_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MonsterCommon_C.__IKAndFk_NativeFunctionPtr, (void*)ptr, 1);
			if (InPose != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->InPose, InPose.NativePtr, 1, false);
			}
			if (IKAndFk != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->IKAndFk, IKAndFk.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__IKAndFk_NativeFunctionPtr, (void*)ptr);
			if (IKAndFk != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), IKAndFk.NativePtr, &ptr->IKAndFk, 1, false);
			}
		}

		// Token: 0x0602BF8F RID: 180111 RVA: 0x00A10A94 File Offset: 0x00A0EC94
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_MonsterCommon_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_MonsterCommon_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_MonsterCommon_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MonsterCommon_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602BF90 RID: 180112 RVA: 0x00A10B1B File Offset: 0x00A0ED1B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 初始化绑定_Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__初始化绑定_Tag_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF91 RID: 180113 RVA: 0x00A10B2F File Offset: 0x00A0ED2F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF92 RID: 180114 RVA: 0x00A10B43 File Offset: 0x00A0ED43
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MonsterCommon_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BF93 RID: 180115 RVA: 0x00A10B58 File Offset: 0x00A0ED58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayShakeFX(int Section)
		{
			ABP_MonsterCommon_C.__PlayShakeFX_FunctionParams* ptr = stackalloc ABP_MonsterCommon_C.__PlayShakeFX_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MonsterCommon_C.__PlayShakeFX_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MonsterCommon_C.__PlayShakeFX_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Section = Section;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__PlayShakeFX_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BF94 RID: 180116 RVA: 0x00A10B9E File Offset: 0x00A0ED9E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF95 RID: 180117 RVA: 0x00A10BB2 File Offset: 0x00A0EDB2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MonsterCommon_C.__OnComponentStart_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602BF96 RID: 180118 RVA: 0x00A10BC7 File Offset: 0x00A0EDC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void TestFk()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__TestFk_NativeFunctionPtr, null);
		}

		// Token: 0x0602BF97 RID: 180119 RVA: 0x00A10BDB File Offset: 0x00A0EDDB
		protected ABP_MonsterCommon_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016F52 RID: 94034
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C";

		// Token: 0x04016F53 RID: 94035
		private static IntPtr _ClassPtr;

		// Token: 0x04016F54 RID: 94036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04016F55 RID: 94037
		public static IntPtr __NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04016F56 RID: 94038
		internal static int __PropertyOffset_81;

		// Token: 0x04016F57 RID: 94039
		internal static int __PropertyOffset_82;

		// Token: 0x04016F58 RID: 94040
		private FSkeletonGroup _Skeleton_Block_Info;

		// Token: 0x04016F59 RID: 94041
		internal static int __PropertyOffset_83;

		// Token: 0x04016F5A RID: 94042
		internal static int __PropertyOffset_84;

		// Token: 0x04016F5B RID: 94043
		private NewEventDispatcher_0 _NewEventDispatcher_0;

		// Token: 0x04016F5C RID: 94044
		internal static int __PropertyOffset_85;

		// Token: 0x04016F5D RID: 94045
		internal static int __PropertyOffset_86;

		// Token: 0x04016F5E RID: 94046
		internal static int __PropertyOffset_87;

		// Token: 0x04016F5F RID: 94047
		internal static int __PropertyOffset_88;

		// Token: 0x04016F60 RID: 94048
		internal static int __PropertyOffset_89;

		// Token: 0x04016F61 RID: 94049
		internal static int __PropertyOffset_90;

		// Token: 0x04016F62 RID: 94050
		internal static int __PropertyOffset_91;

		// Token: 0x04016F63 RID: 94051
		internal static int __PropertyOffset_92;

		// Token: 0x04016F64 RID: 94052
		internal static int __PropertyOffset_93;

		// Token: 0x04016F65 RID: 94053
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<PD_CharacterControllerData_C> _HitMaterial;

		// Token: 0x04016F66 RID: 94054
		internal static int __PropertyOffset_94;

		// Token: 0x04016F67 RID: 94055
		internal static int __PropertyOffset_95;

		// Token: 0x04016F68 RID: 94056
		private FGameplayTagContainer _CachedTagContainer;

		// Token: 0x04016F69 RID: 94057
		internal static int __PropertyOffset_96;

		// Token: 0x04016F6A RID: 94058
		internal static int __PropertyOffset_97;

		// Token: 0x04016F6B RID: 94059
		internal static int __PropertyOffset_98;

		// Token: 0x04016F6C RID: 94060
		internal static int __PropertyOffset_99;

		// Token: 0x04016F6D RID: 94061
		internal static int __PropertyOffset_100;

		// Token: 0x04016F6E RID: 94062
		internal static int __PropertyOffset_101;

		// Token: 0x04016F6F RID: 94063
		internal static int __PropertyOffset_102;

		// Token: 0x04016F70 RID: 94064
		private FBoneFeedbackAnimConfigGroup _Feedback_Anim;

		// Token: 0x04016F71 RID: 94065
		private static IntPtr __IKAndFk_NativeFunctionPtr;

		// Token: 0x04016F72 RID: 94066
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x04016F73 RID: 94067
		private static IntPtr __初始化绑定_Tag_NativeFunctionPtr;

		// Token: 0x04016F74 RID: 94068
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04016F75 RID: 94069
		private static IntPtr __PlayShakeFX_NativeFunctionPtr;

		// Token: 0x04016F76 RID: 94070
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x04016F77 RID: 94071
		private static IntPtr __TestFk_NativeFunctionPtr;

		// Token: 0x0200A5A9 RID: 42409
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __IKAndFk_FunctionParams
		{
			// Token: 0x0403243C RID: 205884
			[FieldOffset(0)]
			public byte InPose;

			// Token: 0x0403243D RID: 205885
			[FieldOffset(24)]
			public byte IKAndFk;
		}

		// Token: 0x0200A5AA RID: 42410
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403243E RID: 205886
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A5AB RID: 42411
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __PlayShakeFX_FunctionParams
		{
			// Token: 0x0403243F RID: 205887
			[FieldOffset(0)]
			public int Section;
		}
	}
}
