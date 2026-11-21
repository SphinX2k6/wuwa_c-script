using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200336C RID: 13164
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillTarget.SSkillTarget")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class SSkillTarget : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060216C0 RID: 136896 RVA: 0x00960486 File Offset: 0x0095E686
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillTarget._ScriptStructPtr != 0) ? SSkillTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillTarget.SSkillTarget", ref SSkillTarget._ScriptStructPtr);
		}

		// Token: 0x1700445E RID: 17502
		// (get) Token: 0x060216C1 RID: 136897 RVA: 0x009604AA File Offset: 0x0095E6AA
		// (set) Token: 0x060216C2 RID: 136898 RVA: 0x009604BA File Offset: 0x0095E6BA
		public unsafe int LockOnConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_LockOnConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_LockOnConfigId) = value;
			}
		}

		// Token: 0x1700445F RID: 17503
		// (get) Token: 0x060216C3 RID: 136899 RVA: 0x009604CB File Offset: 0x0095E6CB
		// (set) Token: 0x060216C4 RID: 136900 RVA: 0x009604DF File Offset: 0x0095E6DF
		public unsafe TEnumAsByte<ESkillTargetPriority> SkillTargetPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_SkillTargetPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_SkillTargetPriority) = value;
			}
		}

		// Token: 0x17004460 RID: 17504
		// (get) Token: 0x060216C5 RID: 136901 RVA: 0x009604F4 File Offset: 0x0095E6F4
		// (set) Token: 0x060216C6 RID: 136902 RVA: 0x00960504 File Offset: 0x0095E704
		public unsafe bool ShowTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_ShowTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_ShowTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004461 RID: 17505
		// (get) Token: 0x060216C7 RID: 136903 RVA: 0x00960515 File Offset: 0x0095E715
		// (set) Token: 0x060216C8 RID: 136904 RVA: 0x00960525 File Offset: 0x0095E725
		public unsafe bool HateOrLockOnChanged
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_HateOrLockOnChanged) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_HateOrLockOnChanged) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004462 RID: 17506
		// (get) Token: 0x060216C9 RID: 136905 RVA: 0x00960536 File Offset: 0x0095E736
		// (set) Token: 0x060216CA RID: 136906 RVA: 0x00960546 File Offset: 0x0095E746
		public unsafe bool TargetDied
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_TargetDied) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_TargetDied) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004463 RID: 17507
		// (get) Token: 0x060216CB RID: 136907 RVA: 0x00960557 File Offset: 0x0095E757
		// (set) Token: 0x060216CC RID: 136908 RVA: 0x00960567 File Offset: 0x0095E767
		public unsafe bool GlobalTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_GlobalTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_GlobalTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004464 RID: 17508
		// (get) Token: 0x060216CD RID: 136909 RVA: 0x00960578 File Offset: 0x0095E778
		// (set) Token: 0x060216CE RID: 136910 RVA: 0x0096058C File Offset: 0x0095E78C
		[Nullable(1)]
		public unsafe string BlackboardKey
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTarget.__PropertyOffset_BlackboardKey)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillTarget.__PropertyOffset_BlackboardKey)), value);
			}
		}

		// Token: 0x17004465 RID: 17509
		// (get) Token: 0x060216CF RID: 136911 RVA: 0x009605A1 File Offset: 0x0095E7A1
		// (set) Token: 0x060216D0 RID: 136912 RVA: 0x009605B1 File Offset: 0x0095E7B1
		public unsafe float SkillTargetRemainTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_SkillTargetRemainTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillTarget.__PropertyOffset_SkillTargetRemainTime) = value;
			}
		}

		// Token: 0x060216D1 RID: 136913 RVA: 0x009605C2 File Offset: 0x0095E7C2
		public SSkillTarget()
		{
		}

		// Token: 0x060216D2 RID: 136914 RVA: 0x009605CA File Offset: 0x0095E7CA
		protected override IntPtr GetUStructPtr()
		{
			return SSkillTarget.StaticStruct();
		}

		// Token: 0x060216D3 RID: 136915 RVA: 0x009605D6 File Offset: 0x0095E7D6
		[NullableContext(2)]
		public SSkillTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060216D4 RID: 136916 RVA: 0x009605E0 File Offset: 0x0095E7E0
		public SSkillTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060216D5 RID: 136917 RVA: 0x009605EB File Offset: 0x0095E7EB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillTarget(Pointer, false, true);
		}

		// Token: 0x060216D6 RID: 136918 RVA: 0x009605F5 File Offset: 0x0095E7F5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillTarget(Pointer, MemoryOwner);
		}

		// Token: 0x04012449 RID: 74825
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillTarget.SSkillTarget";

		// Token: 0x0401244A RID: 74826
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401244B RID: 74827
		internal static int __PropertyOffset_LockOnConfigId;

		// Token: 0x0401244C RID: 74828
		internal static int __PropertyOffset_SkillTargetPriority;

		// Token: 0x0401244D RID: 74829
		internal static int __PropertyOffset_ShowTarget;

		// Token: 0x0401244E RID: 74830
		internal static int __PropertyOffset_HateOrLockOnChanged;

		// Token: 0x0401244F RID: 74831
		internal static int __PropertyOffset_TargetDied;

		// Token: 0x04012450 RID: 74832
		internal static int __PropertyOffset_GlobalTarget;

		// Token: 0x04012451 RID: 74833
		internal static int __PropertyOffset_BlackboardKey;

		// Token: 0x04012452 RID: 74834
		internal static int __PropertyOffset_SkillTargetRemainTime;
	}
}
