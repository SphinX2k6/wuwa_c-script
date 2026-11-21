using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003365 RID: 13157
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorBatchBullet.SSkillBehaviorBatchBullet")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 41)]
	public class SSkillBehaviorBatchBullet : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060215FB RID: 136699 RVA: 0x0095F33D File Offset: 0x0095D53D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorBatchBullet._ScriptStructPtr != 0) ? SSkillBehaviorBatchBullet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorBatchBullet.SSkillBehaviorBatchBullet", ref SSkillBehaviorBatchBullet._ScriptStructPtr);
		}

		// Token: 0x17004414 RID: 17428
		// (get) Token: 0x060215FC RID: 136700 RVA: 0x0095F364 File Offset: 0x0095D564
		// (set) Token: 0x060215FD RID: 136701 RVA: 0x0095F3A7 File Offset: 0x0095D5A7
		[Nullable(1)]
		public TArray<string> Id
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Id) == null)
				{
					result = (this._Id = new TArray<string>(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_Id, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Id.CopyAssign(value);
			}
		}

		// Token: 0x17004415 RID: 17429
		// (get) Token: 0x060215FE RID: 136702 RVA: 0x0095F3B5 File Offset: 0x0095D5B5
		// (set) Token: 0x060215FF RID: 136703 RVA: 0x0095F3C5 File Offset: 0x0095D5C5
		public unsafe int Number
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_Number);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_Number) = value;
			}
		}

		// Token: 0x17004416 RID: 17430
		// (get) Token: 0x06021600 RID: 136704 RVA: 0x0095F3D6 File Offset: 0x0095D5D6
		// (set) Token: 0x06021601 RID: 136705 RVA: 0x0095F3E6 File Offset: 0x0095D5E6
		public unsafe float Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_Interval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_Interval) = value;
			}
		}

		// Token: 0x17004417 RID: 17431
		// (get) Token: 0x06021602 RID: 136706 RVA: 0x0095F3F7 File Offset: 0x0095D5F7
		// (set) Token: 0x06021603 RID: 136707 RVA: 0x0095F407 File Offset: 0x0095D607
		public unsafe bool StopOnSkillEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_StopOnSkillEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_StopOnSkillEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004418 RID: 17432
		// (get) Token: 0x06021604 RID: 136708 RVA: 0x0095F418 File Offset: 0x0095D618
		// (set) Token: 0x06021605 RID: 136709 RVA: 0x0095F42C File Offset: 0x0095D62C
		public unsafe FGameplayTag ContinueWithTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_ContinueWithTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_ContinueWithTag) = value;
			}
		}

		// Token: 0x17004419 RID: 17433
		// (get) Token: 0x06021606 RID: 136710 RVA: 0x0095F441 File Offset: 0x0095D641
		// (set) Token: 0x06021607 RID: 136711 RVA: 0x0095F455 File Offset: 0x0095D655
		public unsafe TEnumAsByte<EBatchBulletMoveStartMode> StartMoving
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_StartMoving);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBatchBullet.__PropertyOffset_StartMoving) = value;
			}
		}

		// Token: 0x06021608 RID: 136712 RVA: 0x0095F46A File Offset: 0x0095D66A
		public SSkillBehaviorBatchBullet()
		{
		}

		// Token: 0x06021609 RID: 136713 RVA: 0x0095F472 File Offset: 0x0095D672
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorBatchBullet.StaticStruct();
		}

		// Token: 0x0602160A RID: 136714 RVA: 0x0095F47E File Offset: 0x0095D67E
		[NullableContext(2)]
		public SSkillBehaviorBatchBullet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602160B RID: 136715 RVA: 0x0095F488 File Offset: 0x0095D688
		public SSkillBehaviorBatchBullet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602160C RID: 136716 RVA: 0x0095F493 File Offset: 0x0095D693
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorBatchBullet(Pointer, false, true);
		}

		// Token: 0x0602160D RID: 136717 RVA: 0x0095F49D File Offset: 0x0095D69D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorBatchBullet(Pointer, MemoryOwner);
		}

		// Token: 0x040123DA RID: 74714
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorBatchBullet.SSkillBehaviorBatchBullet";

		// Token: 0x040123DB RID: 74715
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123DC RID: 74716
		internal static int __PropertyOffset_Id;

		// Token: 0x040123DD RID: 74717
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Id;

		// Token: 0x040123DE RID: 74718
		internal static int __PropertyOffset_Number;

		// Token: 0x040123DF RID: 74719
		internal static int __PropertyOffset_Interval;

		// Token: 0x040123E0 RID: 74720
		internal static int __PropertyOffset_StopOnSkillEnd;

		// Token: 0x040123E1 RID: 74721
		internal static int __PropertyOffset_ContinueWithTag;

		// Token: 0x040123E2 RID: 74722
		internal static int __PropertyOffset_StartMoving;
	}
}
