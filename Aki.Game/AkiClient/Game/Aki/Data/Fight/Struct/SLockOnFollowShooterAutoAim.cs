using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F6C RID: 16236
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAutoAim.SLockOnFollowShooterAutoAim")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SLockOnFollowShooterAutoAim : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602964E RID: 169550 RVA: 0x009C32B0 File Offset: 0x009C14B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnFollowShooterAutoAim._ScriptStructPtr != 0) ? SLockOnFollowShooterAutoAim._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAutoAim.SLockOnFollowShooterAutoAim", ref SLockOnFollowShooterAutoAim._ScriptStructPtr);
		}

		// Token: 0x170062FD RID: 25341
		// (get) Token: 0x0602964F RID: 169551 RVA: 0x009C32D4 File Offset: 0x009C14D4
		// (set) Token: 0x06029650 RID: 169552 RVA: 0x009C32E8 File Offset: 0x009C14E8
		public unsafe FName ShouldAimAtLockOnTargetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170062FE RID: 25342
		// (get) Token: 0x06029651 RID: 169553 RVA: 0x009C32FD File Offset: 0x009C14FD
		// (set) Token: 0x06029652 RID: 169554 RVA: 0x009C330D File Offset: 0x009C150D
		public unsafe float RotationInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170062FF RID: 25343
		// (get) Token: 0x06029653 RID: 169555 RVA: 0x009C331E File Offset: 0x009C151E
		// (set) Token: 0x06029654 RID: 169556 RVA: 0x009C332E File Offset: 0x009C152E
		public unsafe float AutoShootAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006300 RID: 25344
		// (get) Token: 0x06029655 RID: 169557 RVA: 0x009C333F File Offset: 0x009C153F
		// (set) Token: 0x06029656 RID: 169558 RVA: 0x009C334F File Offset: 0x009C154F
		public unsafe float AutoShootGapTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006301 RID: 25345
		// (get) Token: 0x06029657 RID: 169559 RVA: 0x009C3360 File Offset: 0x009C1560
		// (set) Token: 0x06029658 RID: 169560 RVA: 0x009C3374 File Offset: 0x009C1574
		public unsafe FRotator RotateOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006302 RID: 25346
		// (get) Token: 0x06029659 RID: 169561 RVA: 0x009C338C File Offset: 0x009C158C
		// (set) Token: 0x0602965A RID: 169562 RVA: 0x009C33CF File Offset: 0x009C15CF
		public TMap<FGameplayTag, SLockOnFollowShooterAttachmentRule> MapAttachToFollowingWhileHasTag
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SLockOnFollowShooterAttachmentRule> result;
				if ((result = this._MapAttachToFollowingWhileHasTag) == null)
				{
					result = (this._MapAttachToFollowingWhileHasTag = new TMap<FGameplayTag, SLockOnFollowShooterAttachmentRule>(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MapAttachToFollowingWhileHasTag.CopyAssign(value);
			}
		}

		// Token: 0x17006303 RID: 25347
		// (get) Token: 0x0602965B RID: 169563 RVA: 0x009C33E0 File Offset: 0x009C15E0
		// (set) Token: 0x0602965C RID: 169564 RVA: 0x009C3423 File Offset: 0x009C1623
		public FGameplayTagContainer StopUpdateRotationWhileHasTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._StopUpdateRotationWhileHasTags) == null)
				{
					result = (this._StopUpdateRotationWhileHasTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_6, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006304 RID: 25348
		// (get) Token: 0x0602965D RID: 169565 RVA: 0x009C3444 File Offset: 0x009C1644
		// (set) Token: 0x0602965E RID: 169566 RVA: 0x009C3454 File Offset: 0x009C1654
		public unsafe int AutoShootSkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006305 RID: 25349
		// (get) Token: 0x0602965F RID: 169567 RVA: 0x009C3468 File Offset: 0x009C1668
		// (set) Token: 0x06029660 RID: 169568 RVA: 0x009C34AB File Offset: 0x009C16AB
		public FGameplayTagContainer HideWhileHasTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._HideWhileHasTags) == null)
				{
					result = (this._HideWhileHasTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_8, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_8, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06029661 RID: 169569 RVA: 0x009C34CC File Offset: 0x009C16CC
		public SLockOnFollowShooterAutoAim()
		{
		}

		// Token: 0x06029662 RID: 169570 RVA: 0x009C34D4 File Offset: 0x009C16D4
		public SLockOnFollowShooterAutoAim(FName ShouldAimAtLockOnTargetName, float RotationInterpSpeed, float AutoShootAngle, float AutoShootGapTime, FRotator RotateOffset, TMap<FGameplayTag, SLockOnFollowShooterAttachmentRule> MapAttachToFollowingWhileHasTag, FGameplayTagContainer StopUpdateRotationWhileHasTags, int AutoShootSkillId, FGameplayTagContainer HideWhileHasTags)
		{
			this.ShouldAimAtLockOnTargetName = ShouldAimAtLockOnTargetName;
			this.RotationInterpSpeed = RotationInterpSpeed;
			this.AutoShootAngle = AutoShootAngle;
			this.AutoShootGapTime = AutoShootGapTime;
			this.RotateOffset = RotateOffset;
			this.MapAttachToFollowingWhileHasTag = MapAttachToFollowingWhileHasTag;
			this.StopUpdateRotationWhileHasTags = StopUpdateRotationWhileHasTags;
			this.AutoShootSkillId = AutoShootSkillId;
			this.HideWhileHasTags = HideWhileHasTags;
		}

		// Token: 0x06029663 RID: 169571 RVA: 0x009C352C File Offset: 0x009C172C
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnFollowShooterAutoAim.StaticStruct();
		}

		// Token: 0x06029664 RID: 169572 RVA: 0x009C3538 File Offset: 0x009C1738
		[NullableContext(2)]
		public SLockOnFollowShooterAutoAim(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029665 RID: 169573 RVA: 0x009C3542 File Offset: 0x009C1742
		public SLockOnFollowShooterAutoAim(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029666 RID: 169574 RVA: 0x009C354D File Offset: 0x009C174D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnFollowShooterAutoAim(Pointer, false, true);
		}

		// Token: 0x06029667 RID: 169575 RVA: 0x009C3557 File Offset: 0x009C1757
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnFollowShooterAutoAim(Pointer, MemoryOwner);
		}

		// Token: 0x0401535F RID: 86879
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAutoAim.SLockOnFollowShooterAutoAim";

		// Token: 0x04015360 RID: 86880
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015361 RID: 86881
		internal static int __PropertyOffset_0;

		// Token: 0x04015362 RID: 86882
		internal static int __PropertyOffset_1;

		// Token: 0x04015363 RID: 86883
		internal static int __PropertyOffset_2;

		// Token: 0x04015364 RID: 86884
		internal static int __PropertyOffset_3;

		// Token: 0x04015365 RID: 86885
		internal static int __PropertyOffset_4;

		// Token: 0x04015366 RID: 86886
		internal static int __PropertyOffset_5;

		// Token: 0x04015367 RID: 86887
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SLockOnFollowShooterAttachmentRule> _MapAttachToFollowingWhileHasTag;

		// Token: 0x04015368 RID: 86888
		internal static int __PropertyOffset_6;

		// Token: 0x04015369 RID: 86889
		[Nullable(2)]
		private FGameplayTagContainer _StopUpdateRotationWhileHasTags;

		// Token: 0x0401536A RID: 86890
		internal static int __PropertyOffset_7;

		// Token: 0x0401536B RID: 86891
		internal static int __PropertyOffset_8;

		// Token: 0x0401536C RID: 86892
		[Nullable(2)]
		private FGameplayTagContainer _HideWhileHasTags;
	}
}
