using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Data.Fight.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.FollowShooter
{
	// Token: 0x02003F77 RID: 16247
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/FollowShooter/BP_FollowShooterConfig.BP_FollowShooterConfig_C")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class BP_FollowShooterConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060297C0 RID: 169920 RVA: 0x009C53EB File Offset: 0x009C35EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FollowShooterConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/FollowShooter/BP_FollowShooterConfig.BP_FollowShooterConfig_C");
			}
			return BP_FollowShooterConfig_C._ClassPtr;
		}

		// Token: 0x060297C1 RID: 169921 RVA: 0x009C5410 File Offset: 0x009C3610
		public BP_FollowShooterConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FollowShooterConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060297C2 RID: 169922 RVA: 0x009C5438 File Offset: 0x009C3638
		public BP_FollowShooterConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FollowShooterConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700638C RID: 25484
		// (get) Token: 0x060297C3 RID: 169923 RVA: 0x009C546B File Offset: 0x009C366B
		// (set) Token: 0x060297C4 RID: 169924 RVA: 0x009C547B File Offset: 0x009C367B
		public unsafe bool AutoEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700638D RID: 25485
		// (get) Token: 0x060297C5 RID: 169925 RVA: 0x009C548C File Offset: 0x009C368C
		// (set) Token: 0x060297C6 RID: 169926 RVA: 0x009C549C File Offset: 0x009C369C
		public unsafe bool NeedUploadData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700638E RID: 25486
		// (get) Token: 0x060297C7 RID: 169927 RVA: 0x009C54B0 File Offset: 0x009C36B0
		// (set) Token: 0x060297C8 RID: 169928 RVA: 0x009C54E9 File Offset: 0x009C36E9
		public TArray<SInputAction> NeedInputActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInputAction> result;
				if ((result = this._NeedInputActions) == null)
				{
					result = (this._NeedInputActions = new TArray<SInputAction>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.NeedInputActions.CopyAssign(value);
			}
		}

		// Token: 0x1700638F RID: 25487
		// (get) Token: 0x060297C9 RID: 169929 RVA: 0x009C54F8 File Offset: 0x009C36F8
		// (set) Token: 0x060297CA RID: 169930 RVA: 0x009C5531 File Offset: 0x009C3731
		public TArray<FGameplayTag> AddTagsWhenEnable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._AddTagsWhenEnable) == null)
				{
					result = (this._AddTagsWhenEnable = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.AddTagsWhenEnable.CopyAssign(value);
			}
		}

		// Token: 0x17006390 RID: 25488
		// (get) Token: 0x060297CB RID: 169931 RVA: 0x009C5540 File Offset: 0x009C3740
		// (set) Token: 0x060297CC RID: 169932 RVA: 0x009C5579 File Offset: 0x009C3779
		public TArray<FGameplayTag> AddTagsToPlayerWhenPossess
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._AddTagsToPlayerWhenPossess) == null)
				{
					result = (this._AddTagsToPlayerWhenPossess = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_4, this));
				}
				return result;
			}
			set
			{
				this.AddTagsToPlayerWhenPossess.CopyAssign(value);
			}
		}

		// Token: 0x17006391 RID: 25489
		// (get) Token: 0x060297CD RID: 169933 RVA: 0x009C5588 File Offset: 0x009C3788
		// (set) Token: 0x060297CE RID: 169934 RVA: 0x009C55C1 File Offset: 0x009C37C1
		public TArray<FGameplayTag> DisableWhenCurrentRoleHasTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._DisableWhenCurrentRoleHasTags) == null)
				{
					result = (this._DisableWhenCurrentRoleHasTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_5, this));
				}
				return result;
			}
			set
			{
				this.DisableWhenCurrentRoleHasTags.CopyAssign(value);
			}
		}

		// Token: 0x17006392 RID: 25490
		// (get) Token: 0x060297CF RID: 169935 RVA: 0x009C55D0 File Offset: 0x009C37D0
		// (set) Token: 0x060297D0 RID: 169936 RVA: 0x009C5609 File Offset: 0x009C3809
		public TMap<FGameplayTag, FGameplayTagContainer> AddTagsWhenCurrentRoleHasAnyTags
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FGameplayTagContainer> result;
				if ((result = this._AddTagsWhenCurrentRoleHasAnyTags) == null)
				{
					result = (this._AddTagsWhenCurrentRoleHasAnyTags = new TMap<FGameplayTag, FGameplayTagContainer>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_6, this));
				}
				return result;
			}
			set
			{
				this.AddTagsWhenCurrentRoleHasAnyTags.CopyAssign(value);
			}
		}

		// Token: 0x17006393 RID: 25491
		// (get) Token: 0x060297D1 RID: 169937 RVA: 0x009C5617 File Offset: 0x009C3817
		// (set) Token: 0x060297D2 RID: 169938 RVA: 0x009C5627 File Offset: 0x009C3827
		public unsafe int DelayDisappearMillisecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006394 RID: 25492
		// (get) Token: 0x060297D3 RID: 169939 RVA: 0x009C5638 File Offset: 0x009C3838
		// (set) Token: 0x060297D4 RID: 169940 RVA: 0x009C5671 File Offset: 0x009C3871
		public SLockOnFollowShooter LockOnConfig
		{
			get
			{
				base.FastCheckIsValid();
				SLockOnFollowShooter result;
				if ((result = this._LockOnConfig) == null)
				{
					result = (this._LockOnConfig = new SLockOnFollowShooter(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_8, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SLockOnFollowShooter.StaticStruct(), base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006395 RID: 25493
		// (get) Token: 0x060297D5 RID: 169941 RVA: 0x009C5692 File Offset: 0x009C3892
		// (set) Token: 0x060297D6 RID: 169942 RVA: 0x009C56A2 File Offset: 0x009C38A2
		public unsafe int AimType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006396 RID: 25494
		// (get) Token: 0x060297D7 RID: 169943 RVA: 0x009C56B3 File Offset: 0x009C38B3
		// (set) Token: 0x060297D8 RID: 169944 RVA: 0x009C56C7 File Offset: 0x009C38C7
		public unsafe string SightResId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_10)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_10)), value);
			}
		}

		// Token: 0x17006397 RID: 25495
		// (get) Token: 0x060297D9 RID: 169945 RVA: 0x009C56DC File Offset: 0x009C38DC
		// (set) Token: 0x060297DA RID: 169946 RVA: 0x009C5715 File Offset: 0x009C3915
		public SBornTransform BornTransform
		{
			get
			{
				base.FastCheckIsValid();
				SBornTransform result;
				if ((result = this._BornTransform) == null)
				{
					result = (this._BornTransform = new SBornTransform(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_11, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBornTransform.StaticStruct(), base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_11, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006398 RID: 25496
		// (get) Token: 0x060297DB RID: 169947 RVA: 0x009C5738 File Offset: 0x009C3938
		// (set) Token: 0x060297DC RID: 169948 RVA: 0x009C5771 File Offset: 0x009C3971
		public TArray<SFollowShooterTagConfig> AddTagByCheckCurrentRoleTag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFollowShooterTagConfig> result;
				if ((result = this._AddTagByCheckCurrentRoleTag) == null)
				{
					result = (this._AddTagByCheckCurrentRoleTag = new TArray<SFollowShooterTagConfig>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_12, this));
				}
				return result;
			}
			set
			{
				this.AddTagByCheckCurrentRoleTag.CopyAssign(value);
			}
		}

		// Token: 0x17006399 RID: 25497
		// (get) Token: 0x060297DD RID: 169949 RVA: 0x009C577F File Offset: 0x009C397F
		// (set) Token: 0x060297DE RID: 169950 RVA: 0x009C578F File Offset: 0x009C398F
		public unsafe bool SetEntityEnableAfterMaterialController
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700639A RID: 25498
		// (get) Token: 0x060297DF RID: 169951 RVA: 0x009C57A0 File Offset: 0x009C39A0
		// (set) Token: 0x060297E0 RID: 169952 RVA: 0x009C57D9 File Offset: 0x009C39D9
		public FGameplayTagContainer DisableInputWhenHasTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._DisableInputWhenHasTags) == null)
				{
					result = (this._DisableInputWhenHasTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_14, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_14, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700639B RID: 25499
		// (get) Token: 0x060297E1 RID: 169953 RVA: 0x009C57FC File Offset: 0x009C39FC
		// (set) Token: 0x060297E2 RID: 169954 RVA: 0x009C5835 File Offset: 0x009C3A35
		public TArray<SFollowShooterEnablePriorityInfo> EnablePriority
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFollowShooterEnablePriorityInfo> result;
				if ((result = this._EnablePriority) == null)
				{
					result = (this._EnablePriority = new TArray<SFollowShooterEnablePriorityInfo>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_15, this));
				}
				return result;
			}
			set
			{
				this.EnablePriority.CopyAssign(value);
			}
		}

		// Token: 0x060297E3 RID: 169955 RVA: 0x009C5843 File Offset: 0x009C3A43
		protected BP_FollowShooterConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015418 RID: 87064
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/FollowShooter/BP_FollowShooterConfig.BP_FollowShooterConfig_C";

		// Token: 0x04015419 RID: 87065
		private static IntPtr _ClassPtr;

		// Token: 0x0401541A RID: 87066
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401541B RID: 87067
		internal static int __PropertyOffset_0;

		// Token: 0x0401541C RID: 87068
		internal static int __PropertyOffset_1;

		// Token: 0x0401541D RID: 87069
		internal static int __PropertyOffset_2;

		// Token: 0x0401541E RID: 87070
		[Nullable(2)]
		private TArray<SInputAction> _NeedInputActions;

		// Token: 0x0401541F RID: 87071
		internal static int __PropertyOffset_3;

		// Token: 0x04015420 RID: 87072
		[Nullable(2)]
		private TArray<FGameplayTag> _AddTagsWhenEnable;

		// Token: 0x04015421 RID: 87073
		internal static int __PropertyOffset_4;

		// Token: 0x04015422 RID: 87074
		[Nullable(2)]
		private TArray<FGameplayTag> _AddTagsToPlayerWhenPossess;

		// Token: 0x04015423 RID: 87075
		internal static int __PropertyOffset_5;

		// Token: 0x04015424 RID: 87076
		[Nullable(2)]
		private TArray<FGameplayTag> _DisableWhenCurrentRoleHasTags;

		// Token: 0x04015425 RID: 87077
		internal static int __PropertyOffset_6;

		// Token: 0x04015426 RID: 87078
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FGameplayTagContainer> _AddTagsWhenCurrentRoleHasAnyTags;

		// Token: 0x04015427 RID: 87079
		internal static int __PropertyOffset_7;

		// Token: 0x04015428 RID: 87080
		internal static int __PropertyOffset_8;

		// Token: 0x04015429 RID: 87081
		[Nullable(2)]
		private SLockOnFollowShooter _LockOnConfig;

		// Token: 0x0401542A RID: 87082
		internal static int __PropertyOffset_9;

		// Token: 0x0401542B RID: 87083
		internal static int __PropertyOffset_10;

		// Token: 0x0401542C RID: 87084
		internal static int __PropertyOffset_11;

		// Token: 0x0401542D RID: 87085
		[Nullable(2)]
		private SBornTransform _BornTransform;

		// Token: 0x0401542E RID: 87086
		internal static int __PropertyOffset_12;

		// Token: 0x0401542F RID: 87087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFollowShooterTagConfig> _AddTagByCheckCurrentRoleTag;

		// Token: 0x04015430 RID: 87088
		internal static int __PropertyOffset_13;

		// Token: 0x04015431 RID: 87089
		internal static int __PropertyOffset_14;

		// Token: 0x04015432 RID: 87090
		[Nullable(2)]
		private FGameplayTagContainer _DisableInputWhenHasTags;

		// Token: 0x04015433 RID: 87091
		internal static int __PropertyOffset_15;

		// Token: 0x04015434 RID: 87092
		[Nullable(2)]
		private TArray<SFollowShooterEnablePriorityInfo> _EnablePriority;
	}
}
