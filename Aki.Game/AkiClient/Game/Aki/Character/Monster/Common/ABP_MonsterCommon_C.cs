using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Monster.Common
{
	// Token: 0x020032C5 RID: 12997
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C")]
	[UnrealStructLayout(15200, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 15192)]
	public class ABP_MonsterCommon_C : UKuroAnimInstanceMonster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020E9D RID: 134813 RVA: 0x0095258D File Offset: 0x0095078D
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_MonsterCommon_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C");
			}
			return ABP_MonsterCommon_C._ClassPtr;
		}

		// Token: 0x06020E9E RID: 134814 RVA: 0x009525B4 File Offset: 0x009507B4
		public ABP_MonsterCommon_C() : this(BuiltinUtils.AllocNativeUObject(ABP_MonsterCommon_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E9F RID: 134815 RVA: 0x009525DC File Offset: 0x009507DC
		[NullableContext(1)]
		public ABP_MonsterCommon_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_MonsterCommon_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170041BC RID: 16828
		// (get) Token: 0x06020EA0 RID: 134816 RVA: 0x0095260F File Offset: 0x0095080F
		// (set) Token: 0x06020EA1 RID: 134817 RVA: 0x00952623 File Offset: 0x00950823
		public unsafe TsBaseCharacter As_Base_Character
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_As_Base_Character);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_As_Base_Character, value);
			}
		}

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x06020EA2 RID: 134818 RVA: 0x00952638 File Offset: 0x00950838
		// (set) Token: 0x06020EA3 RID: 134819 RVA: 0x00952671 File Offset: 0x00950871
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
					result = (this._NewEventDispatcher_0 = new NewEventDispatcher_0(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_NewEventDispatcher_0, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_NewEventDispatcher_0, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x06020EA4 RID: 134820 RVA: 0x00952692 File Offset: 0x00950892
		// (set) Token: 0x06020EA5 RID: 134821 RVA: 0x009526A2 File Offset: 0x009508A2
		public unsafe int Increment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Increment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Increment) = value;
			}
		}

		// Token: 0x170041BF RID: 16831
		// (get) Token: 0x06020EA6 RID: 134822 RVA: 0x009526B3 File Offset: 0x009508B3
		// (set) Token: 0x06020EA7 RID: 134823 RVA: 0x009526C3 File Offset: 0x009508C3
		public unsafe SightLockMode CameraMode_DEPRECATED
		{
			get
			{
				return (SightLockMode)(*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_CameraMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_CameraMode) = (byte)value;
			}
		}

		// Token: 0x170041C0 RID: 16832
		// (get) Token: 0x06020EA8 RID: 134824 RVA: 0x009526D4 File Offset: 0x009508D4
		// (set) Token: 0x06020EA9 RID: 134825 RVA: 0x009526E4 File Offset: 0x009508E4
		public unsafe float Assist_Limit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Assist_Limit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Assist_Limit) = value;
			}
		}

		// Token: 0x170041C1 RID: 16833
		// (get) Token: 0x06020EAA RID: 134826 RVA: 0x009526F5 File Offset: 0x009508F5
		// (set) Token: 0x06020EAB RID: 134827 RVA: 0x00952709 File Offset: 0x00950909
		public unsafe FName Sight_Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Sight_Bone_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Sight_Bone_Name) = value;
			}
		}

		// Token: 0x170041C2 RID: 16834
		// (get) Token: 0x06020EAC RID: 134828 RVA: 0x0095271E File Offset: 0x0095091E
		// (set) Token: 0x06020EAD RID: 134829 RVA: 0x00952732 File Offset: 0x00950932
		public unsafe FName Begin_Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Begin_Bone_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Begin_Bone_Name) = value;
			}
		}

		// Token: 0x170041C3 RID: 16835
		// (get) Token: 0x06020EAE RID: 134830 RVA: 0x00952747 File Offset: 0x00950947
		// (set) Token: 0x06020EAF RID: 134831 RVA: 0x0095275B File Offset: 0x0095095B
		public unsafe FName End_Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_End_Bone_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_End_Bone_Name) = value;
			}
		}

		// Token: 0x170041C4 RID: 16836
		// (get) Token: 0x06020EB0 RID: 134832 RVA: 0x00952770 File Offset: 0x00950970
		// (set) Token: 0x06020EB1 RID: 134833 RVA: 0x00952780 File Offset: 0x00950980
		public unsafe float ShakeAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_ShakeAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_ShakeAlpha) = value;
			}
		}

		// Token: 0x170041C5 RID: 16837
		// (get) Token: 0x06020EB2 RID: 134834 RVA: 0x00952791 File Offset: 0x00950991
		// (set) Token: 0x06020EB3 RID: 134835 RVA: 0x009527A1 File Offset: 0x009509A1
		public unsafe int ShakeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_ShakeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_ShakeRange) = value;
			}
		}

		// Token: 0x170041C6 RID: 16838
		// (get) Token: 0x06020EB4 RID: 134836 RVA: 0x009527B4 File Offset: 0x009509B4
		// (set) Token: 0x06020EB5 RID: 134837 RVA: 0x009527ED File Offset: 0x009509ED
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
					result = (this._HitMaterial = new TArray<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_HitMaterial, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.HitMaterial.CopyAssign(value);
			}
		}

		// Token: 0x170041C7 RID: 16839
		// (get) Token: 0x06020EB6 RID: 134838 RVA: 0x009527FB File Offset: 0x009509FB
		// (set) Token: 0x06020EB7 RID: 134839 RVA: 0x0095280B File Offset: 0x00950A0B
		public unsafe float ToughDecreaseValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_ToughDecreaseValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_ToughDecreaseValue) = value;
			}
		}

		// Token: 0x170041C8 RID: 16840
		// (get) Token: 0x06020EB8 RID: 134840 RVA: 0x0095281C File Offset: 0x00950A1C
		// (set) Token: 0x06020EB9 RID: 134841 RVA: 0x00952855 File Offset: 0x00950A55
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
					result = (this._CachedTagContainer = new FGameplayTagContainer(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_CachedTagContainer, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_CachedTagContainer, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170041C9 RID: 16841
		// (get) Token: 0x06020EBA RID: 134842 RVA: 0x00952876 File Offset: 0x00950A76
		// (set) Token: 0x06020EBB RID: 134843 RVA: 0x00952886 File Offset: 0x00950A86
		public unsafe bool TestFkBoolean
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_TestFkBoolean) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_TestFkBoolean) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041CA RID: 16842
		// (get) Token: 0x06020EBC RID: 134844 RVA: 0x00952897 File Offset: 0x00950A97
		// (set) Token: 0x06020EBD RID: 134845 RVA: 0x009528AB File Offset: 0x00950AAB
		public unsafe UCurveFloat ShakeCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_ShakeCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_ShakeCurve, value);
			}
		}

		// Token: 0x170041CB RID: 16843
		// (get) Token: 0x06020EBE RID: 134846 RVA: 0x009528C0 File Offset: 0x00950AC0
		// (set) Token: 0x06020EBF RID: 134847 RVA: 0x009528D0 File Offset: 0x00950AD0
		public unsafe bool 大体型怪物
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_大体型怪物) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_大体型怪物) = (value ? 1 : 0);
			}
		}

		// Token: 0x170041CC RID: 16844
		// (get) Token: 0x06020EC0 RID: 134848 RVA: 0x009528E1 File Offset: 0x00950AE1
		// (set) Token: 0x06020EC1 RID: 134849 RVA: 0x009528F5 File Offset: 0x00950AF5
		public unsafe TsBaseCharacter 仇恨当前对象
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseCharacter>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_仇恨当前对象);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_仇恨当前对象, value);
			}
		}

		// Token: 0x170041CD RID: 16845
		// (get) Token: 0x06020EC2 RID: 134850 RVA: 0x0095290A File Offset: 0x00950B0A
		// (set) Token: 0x06020EC3 RID: 134851 RVA: 0x0095291E File Offset: 0x00950B1E
		public unsafe FName Bone_Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Bone_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_MonsterCommon_C.__PropertyOffset_Bone_Name) = value;
			}
		}

		// Token: 0x170041CE RID: 16846
		// (get) Token: 0x06020EC4 RID: 134852 RVA: 0x00952933 File Offset: 0x00950B33
		// (set) Token: 0x06020EC5 RID: 134853 RVA: 0x00952947 File Offset: 0x00950B47
		public unsafe BP_ABPLogicParams_C Ts逻辑变量集
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_ABPLogicParams_C>(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_Ts逻辑变量集);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABP_MonsterCommon_C.__PropertyOffset_Ts逻辑变量集, value);
			}
		}

		// Token: 0x06020EC6 RID: 134854 RVA: 0x0095295C File Offset: 0x00950B5C
		[SkipLocalsInit]
		public virtual void 初始化绑定_Tag()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__初始化绑定_Tag_NativeFunctionPtr, null);
		}

		// Token: 0x06020EC7 RID: 134855 RVA: 0x00952970 File Offset: 0x00950B70
		[SkipLocalsInit]
		public override void BlueprintInitializeAnimation()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020EC8 RID: 134856 RVA: 0x00952984 File Offset: 0x00950B84
		[SkipLocalsInit]
		protected virtual void BlueprintInitializeAnimation_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MonsterCommon_C.__BlueprintInitializeAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x06020EC9 RID: 134857 RVA: 0x00952998 File Offset: 0x00950B98
		[SkipLocalsInit]
		public unsafe virtual void PlayShakeFX(int Section)
		{
			ABP_MonsterCommon_C.__PlayShakeFX_FunctionParams* ptr = stackalloc ABP_MonsterCommon_C.__PlayShakeFX_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_MonsterCommon_C.__PlayShakeFX_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_MonsterCommon_C.__PlayShakeFX_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Section = Section;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__PlayShakeFX_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020ECA RID: 134858 RVA: 0x009529DE File Offset: 0x00950BDE
		[SkipLocalsInit]
		public override void OnComponentStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020ECB RID: 134859 RVA: 0x009529F2 File Offset: 0x00950BF2
		[SkipLocalsInit]
		protected virtual void OnComponentStart_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_MonsterCommon_C.__OnComponentStart_NativeFunctionPtr, null);
		}

		// Token: 0x06020ECC RID: 134860 RVA: 0x00952A06 File Offset: 0x00950C06
		[SkipLocalsInit]
		public virtual void TestFk()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_MonsterCommon_C.__TestFk_NativeFunctionPtr, null);
		}

		// Token: 0x06020ECD RID: 134861 RVA: 0x00952A1A File Offset: 0x00950C1A
		protected ABP_MonsterCommon_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011D37 RID: 73015
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Monster/Common/ABP_MonsterCommon.ABP_MonsterCommon_C";

		// Token: 0x04011D38 RID: 73016
		private static IntPtr _ClassPtr;

		// Token: 0x04011D39 RID: 73017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011D3A RID: 73018
		public static IntPtr __NewEventDispatcher_0__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04011D3B RID: 73019
		internal static int __PropertyOffset_As_Base_Character;

		// Token: 0x04011D3C RID: 73020
		internal static int __PropertyOffset_NewEventDispatcher_0;

		// Token: 0x04011D3D RID: 73021
		private NewEventDispatcher_0 _NewEventDispatcher_0;

		// Token: 0x04011D3E RID: 73022
		internal static int __PropertyOffset_Increment;

		// Token: 0x04011D3F RID: 73023
		internal static int __PropertyOffset_CameraMode;

		// Token: 0x04011D40 RID: 73024
		internal static int __PropertyOffset_Assist_Limit;

		// Token: 0x04011D41 RID: 73025
		internal static int __PropertyOffset_Sight_Bone_Name;

		// Token: 0x04011D42 RID: 73026
		internal static int __PropertyOffset_Begin_Bone_Name;

		// Token: 0x04011D43 RID: 73027
		internal static int __PropertyOffset_End_Bone_Name;

		// Token: 0x04011D44 RID: 73028
		internal static int __PropertyOffset_ShakeAlpha;

		// Token: 0x04011D45 RID: 73029
		internal static int __PropertyOffset_ShakeRange;

		// Token: 0x04011D46 RID: 73030
		internal static int __PropertyOffset_HitMaterial;

		// Token: 0x04011D47 RID: 73031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<PD_CharacterControllerData_C> _HitMaterial;

		// Token: 0x04011D48 RID: 73032
		internal static int __PropertyOffset_ToughDecreaseValue;

		// Token: 0x04011D49 RID: 73033
		internal static int __PropertyOffset_CachedTagContainer;

		// Token: 0x04011D4A RID: 73034
		private FGameplayTagContainer _CachedTagContainer;

		// Token: 0x04011D4B RID: 73035
		internal static int __PropertyOffset_TestFkBoolean;

		// Token: 0x04011D4C RID: 73036
		internal static int __PropertyOffset_ShakeCurve;

		// Token: 0x04011D4D RID: 73037
		internal static int __PropertyOffset_大体型怪物;

		// Token: 0x04011D4E RID: 73038
		internal static int __PropertyOffset_仇恨当前对象;

		// Token: 0x04011D4F RID: 73039
		internal static int __PropertyOffset_Bone_Name;

		// Token: 0x04011D50 RID: 73040
		internal static int __PropertyOffset_Ts逻辑变量集;

		// Token: 0x04011D51 RID: 73041
		private static IntPtr __初始化绑定_Tag_NativeFunctionPtr;

		// Token: 0x04011D52 RID: 73042
		private static IntPtr __BlueprintInitializeAnimation_NativeFunctionPtr;

		// Token: 0x04011D53 RID: 73043
		private static IntPtr __PlayShakeFX_NativeFunctionPtr;

		// Token: 0x04011D54 RID: 73044
		private static IntPtr __OnComponentStart_NativeFunctionPtr;

		// Token: 0x04011D55 RID: 73045
		private static IntPtr __TestFk_NativeFunctionPtr;

		// Token: 0x02008FE9 RID: 36841
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __PlayShakeFX_FunctionParams
		{
			// Token: 0x0402CD98 RID: 183704
			[FieldOffset(0)]
			public int Section;
		}
	}
}
