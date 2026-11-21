using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Vehicle
{
	// Token: 0x020031B9 RID: 12729
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/BP_VehicleConfig.BP_VehicleConfig_C")]
	[UnrealStructLayout(752, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 752)]
	public class BP_VehicleConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F775 RID: 128885 RVA: 0x0092E4BE File Offset: 0x0092C6BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VehicleConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Vehicle/BP_VehicleConfig.BP_VehicleConfig_C");
			}
			return BP_VehicleConfig_C._ClassPtr;
		}

		// Token: 0x0601F776 RID: 128886 RVA: 0x0092E4E4 File Offset: 0x0092C6E4
		public BP_VehicleConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_VehicleConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F777 RID: 128887 RVA: 0x0092E50C File Offset: 0x0092C70C
		public BP_VehicleConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VehicleConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0601F778 RID: 128888 RVA: 0x0092E540 File Offset: 0x0092C740
		// (set) Token: 0x0601F779 RID: 128889 RVA: 0x0092E579 File Offset: 0x0092C779
		public FGameplayTagContainer 载具出生Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._载具出生Tag) == null)
				{
					result = (this._载具出生Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_载具出生Tag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_载具出生Tag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0601F77A RID: 128890 RVA: 0x0092E59C File Offset: 0x0092C79C
		// (set) Token: 0x0601F77B RID: 128891 RVA: 0x0092E5D5 File Offset: 0x0092C7D5
		public FGameplayTagContainer 载具乘坐期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._载具乘坐期间Tag) == null)
				{
					result = (this._载具乘坐期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_载具乘坐期间Tag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_载具乘坐期间Tag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0601F77C RID: 128892 RVA: 0x0092E5F8 File Offset: 0x0092C7F8
		// (set) Token: 0x0601F77D RID: 128893 RVA: 0x0092E631 File Offset: 0x0092C831
		public FGameplayTagContainer 角色乘坐期间Tag
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._角色乘坐期间Tag) == null)
				{
					result = (this._角色乘坐期间Tag = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_角色乘坐期间Tag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_角色乘坐期间Tag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0601F77E RID: 128894 RVA: 0x0092E652 File Offset: 0x0092C852
		// (set) Token: 0x0601F77F RID: 128895 RVA: 0x0092E662 File Offset: 0x0092C862
		public unsafe float 弹射时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_弹射时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_弹射时间) = value;
			}
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0601F780 RID: 128896 RVA: 0x0092E673 File Offset: 0x0092C873
		// (set) Token: 0x0601F781 RID: 128897 RVA: 0x0092E683 File Offset: 0x0092C883
		public unsafe float 弹射高度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_弹射高度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_弹射高度) = value;
			}
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0601F782 RID: 128898 RVA: 0x0092E694 File Offset: 0x0092C894
		// (set) Token: 0x0601F783 RID: 128899 RVA: 0x0092E6A4 File Offset: 0x0092C8A4
		public unsafe float 打开滑翔伞延迟时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_打开滑翔伞延迟时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_打开滑翔伞延迟时间) = value;
			}
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0601F784 RID: 128900 RVA: 0x0092E6B5 File Offset: 0x0092C8B5
		// (set) Token: 0x0601F785 RID: 128901 RVA: 0x0092E6CA File Offset: 0x0092C8CA
		public TSoftObjectPtr<UCurveFloat> 弹射时间路径曲线
		{
			get
			{
				return new TSoftObjectPtr<UCurveFloat>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_弹射时间路径曲线, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_弹射时间路径曲线, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x0601F786 RID: 128902 RVA: 0x0092E6EF File Offset: 0x0092C8EF
		// (set) Token: 0x0601F787 RID: 128903 RVA: 0x0092E704 File Offset: 0x0092C904
		public TSoftObjectPtr<UEffectModelGroup> PreEnterEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_PreEnterEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_PreEnterEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x0601F788 RID: 128904 RVA: 0x0092E729 File Offset: 0x0092C929
		// (set) Token: 0x0601F789 RID: 128905 RVA: 0x0092E73E File Offset: 0x0092C93E
		public TSoftObjectPtr<UEffectModelGroup> PostEnterEffect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelGroup>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_PostEnterEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_PostEnterEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x0601F78A RID: 128906 RVA: 0x0092E763 File Offset: 0x0092C963
		// (set) Token: 0x0601F78B RID: 128907 RVA: 0x0092E778 File Offset: 0x0092C978
		public TSoftObjectPtr<PD_CharacterControllerData_C> PreEnterMatEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerData_C>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_PreEnterMatEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_PreEnterMatEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x0601F78C RID: 128908 RVA: 0x0092E79D File Offset: 0x0092C99D
		// (set) Token: 0x0601F78D RID: 128909 RVA: 0x0092E7B2 File Offset: 0x0092C9B2
		public TSoftObjectPtr<PD_CharacterControllerDataGroup_C> PostEnterMatEffect
		{
			get
			{
				return new TSoftObjectPtr<PD_CharacterControllerDataGroup_C>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_PostEnterMatEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_PostEnterMatEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x0601F78E RID: 128910 RVA: 0x0092E7D8 File Offset: 0x0092C9D8
		// (set) Token: 0x0601F78F RID: 128911 RVA: 0x0092E811 File Offset: 0x0092CA11
		public TMap<FGameplayTag, SGameplayTagArray> 驾驶员同步Tag
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SGameplayTagArray> result;
				if ((result = this._驾驶员同步Tag) == null)
				{
					result = (this._驾驶员同步Tag = new TMap<FGameplayTag, SGameplayTagArray>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_驾驶员同步Tag, this));
				}
				return result;
			}
			set
			{
				this.驾驶员同步Tag.CopyAssign(value);
			}
		}

		// Token: 0x17003984 RID: 14724
		// (get) Token: 0x0601F790 RID: 128912 RVA: 0x0092E820 File Offset: 0x0092CA20
		// (set) Token: 0x0601F791 RID: 128913 RVA: 0x0092E859 File Offset: 0x0092CA59
		public TMap<FGameplayTag, SInt64Array> 驾驶员同步Buff
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SInt64Array> result;
				if ((result = this._驾驶员同步Buff) == null)
				{
					result = (this._驾驶员同步Buff = new TMap<FGameplayTag, SInt64Array>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_驾驶员同步Buff, this));
				}
				return result;
			}
			set
			{
				this.驾驶员同步Buff.CopyAssign(value);
			}
		}

		// Token: 0x17003985 RID: 14725
		// (get) Token: 0x0601F792 RID: 128914 RVA: 0x0092E867 File Offset: 0x0092CA67
		// (set) Token: 0x0601F793 RID: 128915 RVA: 0x0092E87B File Offset: 0x0092CA7B
		[Nullable(2)]
		public unsafe UCurveFloat 前后输入映射曲线
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleConfig_C.__PropertyOffset_前后输入映射曲线);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_VehicleConfig_C.__PropertyOffset_前后输入映射曲线, value);
			}
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x0601F794 RID: 128916 RVA: 0x0092E890 File Offset: 0x0092CA90
		// (set) Token: 0x0601F795 RID: 128917 RVA: 0x0092E8C9 File Offset: 0x0092CAC9
		public TMap<FGameplayTag, SGameplayTagArray> 载具同步驾驶员Tag
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SGameplayTagArray> result;
				if ((result = this._载具同步驾驶员Tag) == null)
				{
					result = (this._载具同步驾驶员Tag = new TMap<FGameplayTag, SGameplayTagArray>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_载具同步驾驶员Tag, this));
				}
				return result;
			}
			set
			{
				this.载具同步驾驶员Tag.CopyAssign(value);
			}
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x0601F796 RID: 128918 RVA: 0x0092E8D8 File Offset: 0x0092CAD8
		// (set) Token: 0x0601F797 RID: 128919 RVA: 0x0092E911 File Offset: 0x0092CB11
		public TArray<SFloatThresholdAndCameraShake> 撞击震屏
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndCameraShake> result;
				if ((result = this._撞击震屏) == null)
				{
					result = (this._撞击震屏 = new TArray<SFloatThresholdAndCameraShake>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_撞击震屏, this));
				}
				return result;
			}
			set
			{
				this.撞击震屏.CopyAssign(value);
			}
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x0601F798 RID: 128920 RVA: 0x0092E920 File Offset: 0x0092CB20
		// (set) Token: 0x0601F799 RID: 128921 RVA: 0x0092E959 File Offset: 0x0092CB59
		public TArray<SFloatThresholdAndCameraShake> 撞击震屏Z
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndCameraShake> result;
				if ((result = this._撞击震屏Z) == null)
				{
					result = (this._撞击震屏Z = new TArray<SFloatThresholdAndCameraShake>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_撞击震屏Z, this));
				}
				return result;
			}
			set
			{
				this.撞击震屏Z.CopyAssign(value);
			}
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x0601F79A RID: 128922 RVA: 0x0092E967 File Offset: 0x0092CB67
		// (set) Token: 0x0601F79B RID: 128923 RVA: 0x0092E977 File Offset: 0x0092CB77
		public unsafe float 震屏CD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_震屏CD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_震屏CD) = value;
			}
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x0601F79C RID: 128924 RVA: 0x0092E988 File Offset: 0x0092CB88
		// (set) Token: 0x0601F79D RID: 128925 RVA: 0x0092E9C1 File Offset: 0x0092CBC1
		public TArray<SFloatThresholdAndCameraShake> 撞击震屏_第一人称
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndCameraShake> result;
				if ((result = this._撞击震屏_第一人称) == null)
				{
					result = (this._撞击震屏_第一人称 = new TArray<SFloatThresholdAndCameraShake>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_撞击震屏_第一人称, this));
				}
				return result;
			}
			set
			{
				this.撞击震屏_第一人称.CopyAssign(value);
			}
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0601F79E RID: 128926 RVA: 0x0092E9D0 File Offset: 0x0092CBD0
		// (set) Token: 0x0601F79F RID: 128927 RVA: 0x0092EA09 File Offset: 0x0092CC09
		public TArray<SFloatThresholdAndCameraShake> 撞击震屏Z_第一人称
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFloatThresholdAndCameraShake> result;
				if ((result = this._撞击震屏Z_第一人称) == null)
				{
					result = (this._撞击震屏Z_第一人称 = new TArray<SFloatThresholdAndCameraShake>(base.NativePtr + (IntPtr)BP_VehicleConfig_C.__PropertyOffset_撞击震屏Z_第一人称, this));
				}
				return result;
			}
			set
			{
				this.撞击震屏Z_第一人称.CopyAssign(value);
			}
		}

		// Token: 0x0601F7A0 RID: 128928 RVA: 0x0092EA17 File Offset: 0x0092CC17
		protected BP_VehicleConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DFD RID: 69117
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/BP_VehicleConfig.BP_VehicleConfig_C";

		// Token: 0x04010DFE RID: 69118
		private static IntPtr _ClassPtr;

		// Token: 0x04010DFF RID: 69119
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010E00 RID: 69120
		internal static int __PropertyOffset_载具出生Tag;

		// Token: 0x04010E01 RID: 69121
		[Nullable(2)]
		private FGameplayTagContainer _载具出生Tag;

		// Token: 0x04010E02 RID: 69122
		internal static int __PropertyOffset_载具乘坐期间Tag;

		// Token: 0x04010E03 RID: 69123
		[Nullable(2)]
		private FGameplayTagContainer _载具乘坐期间Tag;

		// Token: 0x04010E04 RID: 69124
		internal static int __PropertyOffset_角色乘坐期间Tag;

		// Token: 0x04010E05 RID: 69125
		[Nullable(2)]
		private FGameplayTagContainer _角色乘坐期间Tag;

		// Token: 0x04010E06 RID: 69126
		internal static int __PropertyOffset_弹射时间;

		// Token: 0x04010E07 RID: 69127
		internal static int __PropertyOffset_弹射高度;

		// Token: 0x04010E08 RID: 69128
		internal static int __PropertyOffset_打开滑翔伞延迟时间;

		// Token: 0x04010E09 RID: 69129
		internal static int __PropertyOffset_弹射时间路径曲线;

		// Token: 0x04010E0A RID: 69130
		internal static int __PropertyOffset_PreEnterEffect;

		// Token: 0x04010E0B RID: 69131
		internal static int __PropertyOffset_PostEnterEffect;

		// Token: 0x04010E0C RID: 69132
		internal static int __PropertyOffset_PreEnterMatEffect;

		// Token: 0x04010E0D RID: 69133
		internal static int __PropertyOffset_PostEnterMatEffect;

		// Token: 0x04010E0E RID: 69134
		internal static int __PropertyOffset_驾驶员同步Tag;

		// Token: 0x04010E0F RID: 69135
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SGameplayTagArray> _驾驶员同步Tag;

		// Token: 0x04010E10 RID: 69136
		internal static int __PropertyOffset_驾驶员同步Buff;

		// Token: 0x04010E11 RID: 69137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SInt64Array> _驾驶员同步Buff;

		// Token: 0x04010E12 RID: 69138
		internal static int __PropertyOffset_前后输入映射曲线;

		// Token: 0x04010E13 RID: 69139
		internal static int __PropertyOffset_载具同步驾驶员Tag;

		// Token: 0x04010E14 RID: 69140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SGameplayTagArray> _载具同步驾驶员Tag;

		// Token: 0x04010E15 RID: 69141
		internal static int __PropertyOffset_撞击震屏;

		// Token: 0x04010E16 RID: 69142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFloatThresholdAndCameraShake> _撞击震屏;

		// Token: 0x04010E17 RID: 69143
		internal static int __PropertyOffset_撞击震屏Z;

		// Token: 0x04010E18 RID: 69144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFloatThresholdAndCameraShake> _撞击震屏Z;

		// Token: 0x04010E19 RID: 69145
		internal static int __PropertyOffset_震屏CD;

		// Token: 0x04010E1A RID: 69146
		internal static int __PropertyOffset_撞击震屏_第一人称;

		// Token: 0x04010E1B RID: 69147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFloatThresholdAndCameraShake> _撞击震屏_第一人称;

		// Token: 0x04010E1C RID: 69148
		internal static int __PropertyOffset_撞击震屏Z_第一人称;

		// Token: 0x04010E1D RID: 69149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFloatThresholdAndCameraShake> _撞击震屏Z_第一人称;
	}
}
