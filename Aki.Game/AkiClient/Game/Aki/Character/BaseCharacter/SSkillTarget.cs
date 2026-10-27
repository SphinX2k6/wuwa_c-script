using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004335 RID: 17205
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillTarget.SSkillTarget")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class SSkillTarget : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C9D8 RID: 182744 RVA: 0x00A2421C File Offset: 0x00A2241C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillTarget._ScriptStructPtr != 0) ? SSkillTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillTarget.SSkillTarget", ref SSkillTarget._ScriptStructPtr);
		}

		// Token: 0x17007035 RID: 28725
		// (get) Token: 0x0602C9D9 RID: 182745 RVA: 0x00A24240 File Offset: 0x00A22440
		// (set) Token: 0x0602C9DA RID: 182746 RVA: 0x00A24250 File Offset: 0x00A22450
		public unsafe int LockOnConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007036 RID: 28726
		// (get) Token: 0x0602C9DB RID: 182747 RVA: 0x00A24261 File Offset: 0x00A22461
		// (set) Token: 0x0602C9DC RID: 182748 RVA: 0x00A24275 File Offset: 0x00A22475
		public unsafe TEnumAsByte<ESkillTargetPriority> SkillTargetPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007037 RID: 28727
		// (get) Token: 0x0602C9DD RID: 182749 RVA: 0x00A2428A File Offset: 0x00A2248A
		// (set) Token: 0x0602C9DE RID: 182750 RVA: 0x00A2429A File Offset: 0x00A2249A
		public unsafe bool ShowTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007038 RID: 28728
		// (get) Token: 0x0602C9DF RID: 182751 RVA: 0x00A242AB File Offset: 0x00A224AB
		// (set) Token: 0x0602C9E0 RID: 182752 RVA: 0x00A242BB File Offset: 0x00A224BB
		public unsafe bool HateOrLockOnChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007039 RID: 28729
		// (get) Token: 0x0602C9E1 RID: 182753 RVA: 0x00A242CC File Offset: 0x00A224CC
		// (set) Token: 0x0602C9E2 RID: 182754 RVA: 0x00A242DC File Offset: 0x00A224DC
		public unsafe bool TargetDied
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700703A RID: 28730
		// (get) Token: 0x0602C9E3 RID: 182755 RVA: 0x00A242ED File Offset: 0x00A224ED
		// (set) Token: 0x0602C9E4 RID: 182756 RVA: 0x00A242FD File Offset: 0x00A224FD
		public unsafe bool GlobalTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700703B RID: 28731
		// (get) Token: 0x0602C9E5 RID: 182757 RVA: 0x00A2430E File Offset: 0x00A2250E
		// (set) Token: 0x0602C9E6 RID: 182758 RVA: 0x00A24322 File Offset: 0x00A22522
		[Nullable(1)]
		public unsafe string BlackboardKey
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTarget.__PropertyOffset_6)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTarget.__PropertyOffset_6)), value);
			}
		}

		// Token: 0x1700703C RID: 28732
		// (get) Token: 0x0602C9E7 RID: 182759 RVA: 0x00A24337 File Offset: 0x00A22537
		// (set) Token: 0x0602C9E8 RID: 182760 RVA: 0x00A24347 File Offset: 0x00A22547
		public unsafe float SkillTargetRemainTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x0602C9E9 RID: 182761 RVA: 0x00A24358 File Offset: 0x00A22558
		public SSkillTarget()
		{
		}

		// Token: 0x0602C9EA RID: 182762 RVA: 0x00A24360 File Offset: 0x00A22560
		public SSkillTarget(int LockOnConfigId, TEnumAsByte<ESkillTargetPriority> SkillTargetPriority, bool ShowTarget, bool HateOrLockOnChanged, bool TargetDied, bool GlobalTarget, [Nullable(1)] string BlackboardKey, float SkillTargetRemainTime)
		{
			this.LockOnConfigId = LockOnConfigId;
			this.SkillTargetPriority = SkillTargetPriority;
			this.ShowTarget = ShowTarget;
			this.HateOrLockOnChanged = HateOrLockOnChanged;
			this.TargetDied = TargetDied;
			this.GlobalTarget = GlobalTarget;
			this.BlackboardKey = BlackboardKey;
			this.SkillTargetRemainTime = SkillTargetRemainTime;
		}

		// Token: 0x0602C9EB RID: 182763 RVA: 0x00A243B0 File Offset: 0x00A225B0
		protected override IntPtr GetUStructPtr()
		{
			return SSkillTarget.StaticStruct();
		}

		// Token: 0x0602C9EC RID: 182764 RVA: 0x00A243BC File Offset: 0x00A225BC
		[NullableContext(2)]
		public SSkillTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C9ED RID: 182765 RVA: 0x00A243C6 File Offset: 0x00A225C6
		public SSkillTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C9EE RID: 182766 RVA: 0x00A243D1 File Offset: 0x00A225D1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillTarget(Pointer, false, true);
		}

		// Token: 0x0602C9EF RID: 182767 RVA: 0x00A243DB File Offset: 0x00A225DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04017852 RID: 96338
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillTarget.SSkillTarget";

		// Token: 0x04017853 RID: 96339
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017854 RID: 96340
		internal static int __PropertyOffset_0;

		// Token: 0x04017855 RID: 96341
		internal static int __PropertyOffset_1;

		// Token: 0x04017856 RID: 96342
		internal static int __PropertyOffset_2;

		// Token: 0x04017857 RID: 96343
		internal static int __PropertyOffset_3;

		// Token: 0x04017858 RID: 96344
		internal static int __PropertyOffset_4;

		// Token: 0x04017859 RID: 96345
		internal static int __PropertyOffset_5;

		// Token: 0x0401785A RID: 96346
		internal static int __PropertyOffset_6;

		// Token: 0x0401785B RID: 96347
		internal static int __PropertyOffset_7;
	}
}
