using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004300 RID: 17152
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCaughtTriggerInfo.SCaughtTriggerInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SCaughtTriggerInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C556 RID: 181590 RVA: 0x00A1D55A File Offset: 0x00A1B75A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCaughtTriggerInfo._ScriptStructPtr != 0) ? SCaughtTriggerInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCaughtTriggerInfo.SCaughtTriggerInfo", ref SCaughtTriggerInfo._ScriptStructPtr);
		}

		// Token: 0x17006EC3 RID: 28355
		// (get) Token: 0x0602C557 RID: 181591 RVA: 0x00A1D57E File Offset: 0x00A1B77E
		// (set) Token: 0x0602C558 RID: 181592 RVA: 0x00A1D592 File Offset: 0x00A1B792
		public unsafe string BulletId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtTriggerInfo.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCaughtTriggerInfo.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006EC4 RID: 28356
		// (get) Token: 0x0602C559 RID: 181593 RVA: 0x00A1D5A7 File Offset: 0x00A1B7A7
		// (set) Token: 0x0602C55A RID: 181594 RVA: 0x00A1D5B7 File Offset: 0x00A1B7B7
		public unsafe int CaughtMxNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006EC5 RID: 28357
		// (get) Token: 0x0602C55B RID: 181595 RVA: 0x00A1D5C8 File Offset: 0x00A1B7C8
		// (set) Token: 0x0602C55C RID: 181596 RVA: 0x00A1D5D8 File Offset: 0x00A1B7D8
		public unsafe int CaughtLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006EC6 RID: 28358
		// (get) Token: 0x0602C55D RID: 181597 RVA: 0x00A1D5E9 File Offset: 0x00A1B7E9
		// (set) Token: 0x0602C55E RID: 181598 RVA: 0x00A1D5F9 File Offset: 0x00A1B7F9
		public unsafe bool CaughtAimTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006EC7 RID: 28359
		// (get) Token: 0x0602C55F RID: 181599 RVA: 0x00A1D60C File Offset: 0x00A1B80C
		// (set) Token: 0x0602C560 RID: 181600 RVA: 0x00A1D64F File Offset: 0x00A1B84F
		public TArray<FGameplayTag> CaughtTargetTag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._CaughtTargetTag) == null)
				{
					result = (this._CaughtTargetTag = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SCaughtTriggerInfo.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CaughtTargetTag.CopyAssign(value);
			}
		}

		// Token: 0x0602C561 RID: 181601 RVA: 0x00A1D65D File Offset: 0x00A1B85D
		public SCaughtTriggerInfo()
		{
		}

		// Token: 0x0602C562 RID: 181602 RVA: 0x00A1D665 File Offset: 0x00A1B865
		public SCaughtTriggerInfo(string BulletId, int CaughtMxNumber, int CaughtLevel, bool CaughtAimTarget, TArray<FGameplayTag> CaughtTargetTag)
		{
			this.BulletId = BulletId;
			this.CaughtMxNumber = CaughtMxNumber;
			this.CaughtLevel = CaughtLevel;
			this.CaughtAimTarget = CaughtAimTarget;
			this.CaughtTargetTag = CaughtTargetTag;
		}

		// Token: 0x0602C563 RID: 181603 RVA: 0x00A1D692 File Offset: 0x00A1B892
		protected override IntPtr GetUStructPtr()
		{
			return SCaughtTriggerInfo.StaticStruct();
		}

		// Token: 0x0602C564 RID: 181604 RVA: 0x00A1D69E File Offset: 0x00A1B89E
		[NullableContext(2)]
		public SCaughtTriggerInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C565 RID: 181605 RVA: 0x00A1D6A8 File Offset: 0x00A1B8A8
		public SCaughtTriggerInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C566 RID: 181606 RVA: 0x00A1D6B3 File Offset: 0x00A1B8B3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCaughtTriggerInfo(Pointer, false, true);
		}

		// Token: 0x0602C567 RID: 181607 RVA: 0x00A1D6BD File Offset: 0x00A1B8BD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCaughtTriggerInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04017604 RID: 95748
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCaughtTriggerInfo.SCaughtTriggerInfo";

		// Token: 0x04017605 RID: 95749
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017606 RID: 95750
		internal static int __PropertyOffset_0;

		// Token: 0x04017607 RID: 95751
		internal static int __PropertyOffset_1;

		// Token: 0x04017608 RID: 95752
		internal static int __PropertyOffset_2;

		// Token: 0x04017609 RID: 95753
		internal static int __PropertyOffset_3;

		// Token: 0x0401760A RID: 95754
		internal static int __PropertyOffset_4;

		// Token: 0x0401760B RID: 95755
		[Nullable(2)]
		private TArray<FGameplayTag> _CaughtTargetTag;
	}
}
