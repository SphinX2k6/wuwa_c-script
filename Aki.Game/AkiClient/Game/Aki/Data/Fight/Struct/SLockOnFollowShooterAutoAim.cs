using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x0200320D RID: 12813
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAutoAim.SLockOnFollowShooterAutoAim")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class SLockOnFollowShooterAutoAim : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FED2 RID: 130770 RVA: 0x00939250 File Offset: 0x00937450
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SLockOnFollowShooterAutoAim._ScriptStructPtr != 0) ? SLockOnFollowShooterAutoAim._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAutoAim.SLockOnFollowShooterAutoAim", ref SLockOnFollowShooterAutoAim._ScriptStructPtr);
		}

		// Token: 0x17003C39 RID: 15417
		// (get) Token: 0x0601FED3 RID: 130771 RVA: 0x00939274 File Offset: 0x00937474
		// (set) Token: 0x0601FED4 RID: 130772 RVA: 0x00939288 File Offset: 0x00937488
		public unsafe FName ShouldAimAtLockOnTargetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_ShouldAimAtLockOnTargetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_ShouldAimAtLockOnTargetName) = value;
			}
		}

		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x0601FED5 RID: 130773 RVA: 0x0093929D File Offset: 0x0093749D
		// (set) Token: 0x0601FED6 RID: 130774 RVA: 0x009392AD File Offset: 0x009374AD
		public unsafe float RotationInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_RotationInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_RotationInterpSpeed) = value;
			}
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x0601FED7 RID: 130775 RVA: 0x009392BE File Offset: 0x009374BE
		// (set) Token: 0x0601FED8 RID: 130776 RVA: 0x009392CE File Offset: 0x009374CE
		public unsafe float AutoShootAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_AutoShootAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_AutoShootAngle) = value;
			}
		}

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x0601FED9 RID: 130777 RVA: 0x009392DF File Offset: 0x009374DF
		// (set) Token: 0x0601FEDA RID: 130778 RVA: 0x009392EF File Offset: 0x009374EF
		public unsafe float AutoShootGapTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_AutoShootGapTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_AutoShootGapTime) = value;
			}
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x0601FEDB RID: 130779 RVA: 0x00939300 File Offset: 0x00937500
		// (set) Token: 0x0601FEDC RID: 130780 RVA: 0x00939314 File Offset: 0x00937514
		public unsafe FRotator RotateOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_RotateOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_RotateOffset) = value;
			}
		}

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x0601FEDD RID: 130781 RVA: 0x0093932C File Offset: 0x0093752C
		// (set) Token: 0x0601FEDE RID: 130782 RVA: 0x0093936F File Offset: 0x0093756F
		public TMap<FGameplayTag, SLockOnFollowShooterAttachmentRule> MapAttachToFollowingWhileHasTag
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGameplayTag, SLockOnFollowShooterAttachmentRule> result;
				if ((result = this._MapAttachToFollowingWhileHasTag) == null)
				{
					result = (this._MapAttachToFollowingWhileHasTag = new TMap<FGameplayTag, SLockOnFollowShooterAttachmentRule>(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_MapAttachToFollowingWhileHasTag, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MapAttachToFollowingWhileHasTag.CopyAssign(value);
			}
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x0601FEDF RID: 130783 RVA: 0x00939380 File Offset: 0x00937580
		// (set) Token: 0x0601FEE0 RID: 130784 RVA: 0x009393C3 File Offset: 0x009375C3
		public FGameplayTagContainer StopUpdateRotationWhileHasTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._StopUpdateRotationWhileHasTags) == null)
				{
					result = (this._StopUpdateRotationWhileHasTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_StopUpdateRotationWhileHasTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_StopUpdateRotationWhileHasTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x0601FEE1 RID: 130785 RVA: 0x009393E4 File Offset: 0x009375E4
		// (set) Token: 0x0601FEE2 RID: 130786 RVA: 0x009393F4 File Offset: 0x009375F4
		public unsafe int AutoShootSkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_AutoShootSkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_AutoShootSkillId) = value;
			}
		}

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x0601FEE3 RID: 130787 RVA: 0x00939408 File Offset: 0x00937608
		// (set) Token: 0x0601FEE4 RID: 130788 RVA: 0x0093944B File Offset: 0x0093764B
		public FGameplayTagContainer HideWhileHasTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._HideWhileHasTags) == null)
				{
					result = (this._HideWhileHasTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_HideWhileHasTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SLockOnFollowShooterAutoAim.__PropertyOffset_HideWhileHasTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601FEE5 RID: 130789 RVA: 0x0093946C File Offset: 0x0093766C
		public SLockOnFollowShooterAutoAim()
		{
		}

		// Token: 0x0601FEE6 RID: 130790 RVA: 0x00939474 File Offset: 0x00937674
		protected override IntPtr GetUStructPtr()
		{
			return SLockOnFollowShooterAutoAim.StaticStruct();
		}

		// Token: 0x0601FEE7 RID: 130791 RVA: 0x00939480 File Offset: 0x00937680
		[NullableContext(2)]
		public SLockOnFollowShooterAutoAim(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FEE8 RID: 130792 RVA: 0x0093948A File Offset: 0x0093768A
		public SLockOnFollowShooterAutoAim(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FEE9 RID: 130793 RVA: 0x00939495 File Offset: 0x00937695
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SLockOnFollowShooterAutoAim(Pointer, false, true);
		}

		// Token: 0x0601FEEA RID: 130794 RVA: 0x0093949F File Offset: 0x0093769F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SLockOnFollowShooterAutoAim(Pointer, MemoryOwner);
		}

		// Token: 0x04011253 RID: 70227
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SLockOnFollowShooterAutoAim.SLockOnFollowShooterAutoAim";

		// Token: 0x04011254 RID: 70228
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011255 RID: 70229
		internal static int __PropertyOffset_ShouldAimAtLockOnTargetName;

		// Token: 0x04011256 RID: 70230
		internal static int __PropertyOffset_RotationInterpSpeed;

		// Token: 0x04011257 RID: 70231
		internal static int __PropertyOffset_AutoShootAngle;

		// Token: 0x04011258 RID: 70232
		internal static int __PropertyOffset_AutoShootGapTime;

		// Token: 0x04011259 RID: 70233
		internal static int __PropertyOffset_RotateOffset;

		// Token: 0x0401125A RID: 70234
		internal static int __PropertyOffset_MapAttachToFollowingWhileHasTag;

		// Token: 0x0401125B RID: 70235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGameplayTag, SLockOnFollowShooterAttachmentRule> _MapAttachToFollowingWhileHasTag;

		// Token: 0x0401125C RID: 70236
		internal static int __PropertyOffset_StopUpdateRotationWhileHasTags;

		// Token: 0x0401125D RID: 70237
		[Nullable(2)]
		private FGameplayTagContainer _StopUpdateRotationWhileHasTags;

		// Token: 0x0401125E RID: 70238
		internal static int __PropertyOffset_AutoShootSkillId;

		// Token: 0x0401125F RID: 70239
		internal static int __PropertyOffset_HideWhileHasTags;

		// Token: 0x04011260 RID: 70240
		[Nullable(2)]
		private FGameplayTagContainer _HideWhileHasTags;
	}
}
