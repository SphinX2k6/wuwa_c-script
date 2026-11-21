using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003366 RID: 13158
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorBullet.SSkillBehaviorBullet")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SSkillBehaviorBullet : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602160E RID: 136718 RVA: 0x0095F4A6 File Offset: 0x0095D6A6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorBullet._ScriptStructPtr != 0) ? SSkillBehaviorBullet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorBullet.SSkillBehaviorBullet", ref SSkillBehaviorBullet._ScriptStructPtr);
		}

		// Token: 0x1700441A RID: 17434
		// (get) Token: 0x0602160F RID: 136719 RVA: 0x0095F4CA File Offset: 0x0095D6CA
		// (set) Token: 0x06021610 RID: 136720 RVA: 0x0095F4DE File Offset: 0x0095D6DE
		public unsafe string bulletRowName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorBullet.__PropertyOffset_bulletRowName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorBullet.__PropertyOffset_bulletRowName)), value);
			}
		}

		// Token: 0x1700441B RID: 17435
		// (get) Token: 0x06021611 RID: 136721 RVA: 0x0095F4F3 File Offset: 0x0095D6F3
		// (set) Token: 0x06021612 RID: 136722 RVA: 0x0095F503 File Offset: 0x0095D703
		public unsafe int bulletCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBullet.__PropertyOffset_bulletCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBullet.__PropertyOffset_bulletCount) = value;
			}
		}

		// Token: 0x1700441C RID: 17436
		// (get) Token: 0x06021613 RID: 136723 RVA: 0x0095F514 File Offset: 0x0095D714
		// (set) Token: 0x06021614 RID: 136724 RVA: 0x0095F528 File Offset: 0x0095D728
		public unsafe string BlackboardKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorBullet.__PropertyOffset_BlackboardKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorBullet.__PropertyOffset_BlackboardKey)), value);
			}
		}

		// Token: 0x06021615 RID: 136725 RVA: 0x0095F53D File Offset: 0x0095D73D
		public SSkillBehaviorBullet()
		{
		}

		// Token: 0x06021616 RID: 136726 RVA: 0x0095F545 File Offset: 0x0095D745
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorBullet.StaticStruct();
		}

		// Token: 0x06021617 RID: 136727 RVA: 0x0095F551 File Offset: 0x0095D751
		[NullableContext(2)]
		public SSkillBehaviorBullet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021618 RID: 136728 RVA: 0x0095F55B File Offset: 0x0095D75B
		public SSkillBehaviorBullet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021619 RID: 136729 RVA: 0x0095F566 File Offset: 0x0095D766
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorBullet(Pointer, false, true);
		}

		// Token: 0x0602161A RID: 136730 RVA: 0x0095F570 File Offset: 0x0095D770
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorBullet(Pointer, MemoryOwner);
		}

		// Token: 0x040123E3 RID: 74723
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorBullet.SSkillBehaviorBullet";

		// Token: 0x040123E4 RID: 74724
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123E5 RID: 74725
		internal static int __PropertyOffset_bulletRowName;

		// Token: 0x040123E6 RID: 74726
		internal static int __PropertyOffset_bulletCount;

		// Token: 0x040123E7 RID: 74727
		internal static int __PropertyOffset_BlackboardKey;
	}
}
