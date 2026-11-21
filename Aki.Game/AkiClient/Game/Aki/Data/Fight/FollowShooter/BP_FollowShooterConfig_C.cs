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
	// Token: 0x02003214 RID: 12820
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/FollowShooter/BP_FollowShooterConfig.BP_FollowShooterConfig_C")]
	[UnrealStructLayout(672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class BP_FollowShooterConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FFA8 RID: 130984 RVA: 0x0093A247 File Offset: 0x00938447
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FollowShooterConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Fight/FollowShooter/BP_FollowShooterConfig.BP_FollowShooterConfig_C");
			}
			return BP_FollowShooterConfig_C._ClassPtr;
		}

		// Token: 0x0601FFA9 RID: 130985 RVA: 0x0093A26C File Offset: 0x0093846C
		public BP_FollowShooterConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FollowShooterConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FFAA RID: 130986 RVA: 0x0093A294 File Offset: 0x00938494
		public BP_FollowShooterConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FollowShooterConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C8D RID: 15501
		// (get) Token: 0x0601FFAB RID: 130987 RVA: 0x0093A2C7 File Offset: 0x009384C7
		// (set) Token: 0x0601FFAC RID: 130988 RVA: 0x0093A2D7 File Offset: 0x009384D7
		public unsafe bool AutoEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_AutoEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_AutoEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C8E RID: 15502
		// (get) Token: 0x0601FFAD RID: 130989 RVA: 0x0093A2E8 File Offset: 0x009384E8
		// (set) Token: 0x0601FFAE RID: 130990 RVA: 0x0093A2F8 File Offset: 0x009384F8
		public unsafe bool NeedUploadData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_NeedUploadData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_NeedUploadData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C8F RID: 15503
		// (get) Token: 0x0601FFAF RID: 130991 RVA: 0x0093A30C File Offset: 0x0093850C
		// (set) Token: 0x0601FFB0 RID: 130992 RVA: 0x0093A345 File Offset: 0x00938545
		public TArray<SInputAction> NeedInputActions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SInputAction> result;
				if ((result = this._NeedInputActions) == null)
				{
					result = (this._NeedInputActions = new TArray<SInputAction>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_NeedInputActions, this));
				}
				return result;
			}
			set
			{
				this.NeedInputActions.CopyAssign(value);
			}
		}

		// Token: 0x17003C90 RID: 15504
		// (get) Token: 0x0601FFB1 RID: 130993 RVA: 0x0093A354 File Offset: 0x00938554
		// (set) Token: 0x0601FFB2 RID: 130994 RVA: 0x0093A38D File Offset: 0x0093858D
		public TArray<FGameplayTag> AddTagsWhenEnable
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._AddTagsWhenEnable) == null)
				{
					result = (this._AddTagsWhenEnable = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_AddTagsWhenEnable, this));
				}
				return result;
			}
			set
			{
				this.AddTagsWhenEnable.CopyAssign(value);
			}
		}

		// Token: 0x17003C91 RID: 15505
		// (get) Token: 0x0601FFB3 RID: 130995 RVA: 0x0093A39C File Offset: 0x0093859C
		// (set) Token: 0x0601FFB4 RID: 130996 RVA: 0x0093A3D5 File Offset: 0x009385D5
		public TArray<FGameplayTag> AddTagsToPlayerWhenPossess
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._AddTagsToPlayerWhenPossess) == null)
				{
					result = (this._AddTagsToPlayerWhenPossess = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_AddTagsToPlayerWhenPossess, this));
				}
				return result;
			}
			set
			{
				this.AddTagsToPlayerWhenPossess.CopyAssign(value);
			}
		}

		// Token: 0x17003C92 RID: 15506
		// (get) Token: 0x0601FFB5 RID: 130997 RVA: 0x0093A3E4 File Offset: 0x009385E4
		// (set) Token: 0x0601FFB6 RID: 130998 RVA: 0x0093A41D File Offset: 0x0093861D
		public TArray<FGameplayTag> DisableWhenCurrentRoleHasTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._DisableWhenCurrentRoleHasTags) == null)
				{
					result = (this._DisableWhenCurrentRoleHasTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_DisableWhenCurrentRoleHasTags, this));
				}
				return result;
			}
			set
			{
				this.DisableWhenCurrentRoleHasTags.CopyAssign(value);
			}
		}

		// Token: 0x17003C93 RID: 15507
		// (get) Token: 0x0601FFB7 RID: 130999 RVA: 0x0093A42C File Offset: 0x0093862C
		// (set) Token: 0x0601FFB8 RID: 131000 RVA: 0x0093A465 File Offset: 0x00938665
		public TMap<FGameplayTag, FGameplayTagContainer> AddTagsWhenCurrentRoleHasAnyTags
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, FGameplayTagContainer> result;
				if ((result = this._AddTagsWhenCurrentRoleHasAnyTags) == null)
				{
					result = (this._AddTagsWhenCurrentRoleHasAnyTags = new TMap<FGameplayTag, FGameplayTagContainer>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_AddTagsWhenCurrentRoleHasAnyTags, this));
				}
				return result;
			}
			set
			{
				this.AddTagsWhenCurrentRoleHasAnyTags.CopyAssign(value);
			}
		}

		// Token: 0x17003C94 RID: 15508
		// (get) Token: 0x0601FFB9 RID: 131001 RVA: 0x0093A473 File Offset: 0x00938673
		// (set) Token: 0x0601FFBA RID: 131002 RVA: 0x0093A483 File Offset: 0x00938683
		public unsafe int DelayDisappearMillisecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_DelayDisappearMillisecond);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_DelayDisappearMillisecond) = value;
			}
		}

		// Token: 0x17003C95 RID: 15509
		// (get) Token: 0x0601FFBB RID: 131003 RVA: 0x0093A494 File Offset: 0x00938694
		// (set) Token: 0x0601FFBC RID: 131004 RVA: 0x0093A4CD File Offset: 0x009386CD
		public SLockOnFollowShooter LockOnConfig
		{
			get
			{
				base.FastCheckIsValid();
				SLockOnFollowShooter result;
				if ((result = this._LockOnConfig) == null)
				{
					result = (this._LockOnConfig = new SLockOnFollowShooter(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_LockOnConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SLockOnFollowShooter.StaticStruct(), base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_LockOnConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C96 RID: 15510
		// (get) Token: 0x0601FFBD RID: 131005 RVA: 0x0093A4EE File Offset: 0x009386EE
		// (set) Token: 0x0601FFBE RID: 131006 RVA: 0x0093A4FE File Offset: 0x009386FE
		public unsafe int AimType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_AimType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_AimType) = value;
			}
		}

		// Token: 0x17003C97 RID: 15511
		// (get) Token: 0x0601FFBF RID: 131007 RVA: 0x0093A50F File Offset: 0x0093870F
		// (set) Token: 0x0601FFC0 RID: 131008 RVA: 0x0093A523 File Offset: 0x00938723
		public unsafe string SightResId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_SightResId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_SightResId)), value);
			}
		}

		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0601FFC1 RID: 131009 RVA: 0x0093A538 File Offset: 0x00938738
		// (set) Token: 0x0601FFC2 RID: 131010 RVA: 0x0093A571 File Offset: 0x00938771
		public SBornTransform BornTransform
		{
			get
			{
				base.FastCheckIsValid();
				SBornTransform result;
				if ((result = this._BornTransform) == null)
				{
					result = (this._BornTransform = new SBornTransform(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_BornTransform, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SBornTransform.StaticStruct(), base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_BornTransform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x0601FFC3 RID: 131011 RVA: 0x0093A594 File Offset: 0x00938794
		// (set) Token: 0x0601FFC4 RID: 131012 RVA: 0x0093A5CD File Offset: 0x009387CD
		public TArray<SFollowShooterTagConfig> AddTagByCheckCurrentRoleTag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFollowShooterTagConfig> result;
				if ((result = this._AddTagByCheckCurrentRoleTag) == null)
				{
					result = (this._AddTagByCheckCurrentRoleTag = new TArray<SFollowShooterTagConfig>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_AddTagByCheckCurrentRoleTag, this));
				}
				return result;
			}
			set
			{
				this.AddTagByCheckCurrentRoleTag.CopyAssign(value);
			}
		}

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0601FFC5 RID: 131013 RVA: 0x0093A5DB File Offset: 0x009387DB
		// (set) Token: 0x0601FFC6 RID: 131014 RVA: 0x0093A5EB File Offset: 0x009387EB
		public unsafe bool SetEntityEnableAfterMaterialController
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_SetEntityEnableAfterMaterialController) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_SetEntityEnableAfterMaterialController) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x0601FFC7 RID: 131015 RVA: 0x0093A5FC File Offset: 0x009387FC
		// (set) Token: 0x0601FFC8 RID: 131016 RVA: 0x0093A635 File Offset: 0x00938835
		public FGameplayTagContainer DisableInputWhenHasTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._DisableInputWhenHasTags) == null)
				{
					result = (this._DisableInputWhenHasTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_DisableInputWhenHasTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_DisableInputWhenHasTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C9C RID: 15516
		// (get) Token: 0x0601FFC9 RID: 131017 RVA: 0x0093A658 File Offset: 0x00938858
		// (set) Token: 0x0601FFCA RID: 131018 RVA: 0x0093A691 File Offset: 0x00938891
		public TArray<SFollowShooterEnablePriorityInfo> EnablePriority
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFollowShooterEnablePriorityInfo> result;
				if ((result = this._EnablePriority) == null)
				{
					result = (this._EnablePriority = new TArray<SFollowShooterEnablePriorityInfo>(base.NativePtr + (IntPtr)BP_FollowShooterConfig_C.__PropertyOffset_EnablePriority, this));
				}
				return result;
			}
			set
			{
				this.EnablePriority.CopyAssign(value);
			}
		}

		// Token: 0x0601FFCB RID: 131019 RVA: 0x0093A69F File Offset: 0x0093889F
		protected BP_FollowShooterConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112BB RID: 70331
		public new const string __ObjectPath = "/Game/Aki/Data/Fight/FollowShooter/BP_FollowShooterConfig.BP_FollowShooterConfig_C";

		// Token: 0x040112BC RID: 70332
		private static IntPtr _ClassPtr;

		// Token: 0x040112BD RID: 70333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112BE RID: 70334
		internal static int __PropertyOffset_AutoEnable;

		// Token: 0x040112BF RID: 70335
		internal static int __PropertyOffset_NeedUploadData;

		// Token: 0x040112C0 RID: 70336
		internal static int __PropertyOffset_NeedInputActions;

		// Token: 0x040112C1 RID: 70337
		[Nullable(2)]
		private TArray<SInputAction> _NeedInputActions;

		// Token: 0x040112C2 RID: 70338
		internal static int __PropertyOffset_AddTagsWhenEnable;

		// Token: 0x040112C3 RID: 70339
		[Nullable(2)]
		private TArray<FGameplayTag> _AddTagsWhenEnable;

		// Token: 0x040112C4 RID: 70340
		internal static int __PropertyOffset_AddTagsToPlayerWhenPossess;

		// Token: 0x040112C5 RID: 70341
		[Nullable(2)]
		private TArray<FGameplayTag> _AddTagsToPlayerWhenPossess;

		// Token: 0x040112C6 RID: 70342
		internal static int __PropertyOffset_DisableWhenCurrentRoleHasTags;

		// Token: 0x040112C7 RID: 70343
		[Nullable(2)]
		private TArray<FGameplayTag> _DisableWhenCurrentRoleHasTags;

		// Token: 0x040112C8 RID: 70344
		internal static int __PropertyOffset_AddTagsWhenCurrentRoleHasAnyTags;

		// Token: 0x040112C9 RID: 70345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, FGameplayTagContainer> _AddTagsWhenCurrentRoleHasAnyTags;

		// Token: 0x040112CA RID: 70346
		internal static int __PropertyOffset_DelayDisappearMillisecond;

		// Token: 0x040112CB RID: 70347
		internal static int __PropertyOffset_LockOnConfig;

		// Token: 0x040112CC RID: 70348
		[Nullable(2)]
		private SLockOnFollowShooter _LockOnConfig;

		// Token: 0x040112CD RID: 70349
		internal static int __PropertyOffset_AimType;

		// Token: 0x040112CE RID: 70350
		internal static int __PropertyOffset_SightResId;

		// Token: 0x040112CF RID: 70351
		internal static int __PropertyOffset_BornTransform;

		// Token: 0x040112D0 RID: 70352
		[Nullable(2)]
		private SBornTransform _BornTransform;

		// Token: 0x040112D1 RID: 70353
		internal static int __PropertyOffset_AddTagByCheckCurrentRoleTag;

		// Token: 0x040112D2 RID: 70354
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFollowShooterTagConfig> _AddTagByCheckCurrentRoleTag;

		// Token: 0x040112D3 RID: 70355
		internal static int __PropertyOffset_SetEntityEnableAfterMaterialController;

		// Token: 0x040112D4 RID: 70356
		internal static int __PropertyOffset_DisableInputWhenHasTags;

		// Token: 0x040112D5 RID: 70357
		[Nullable(2)]
		private FGameplayTagContainer _DisableInputWhenHasTags;

		// Token: 0x040112D6 RID: 70358
		internal static int __PropertyOffset_EnablePriority;

		// Token: 0x040112D7 RID: 70359
		[Nullable(2)]
		private TArray<SFollowShooterEnablePriorityInfo> _EnablePriority;
	}
}
