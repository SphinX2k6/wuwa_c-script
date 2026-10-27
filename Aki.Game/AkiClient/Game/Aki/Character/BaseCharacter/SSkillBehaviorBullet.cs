using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200432E RID: 17198
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SSkillBehaviorBullet.SSkillBehaviorBullet")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SSkillBehaviorBullet : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C911 RID: 182545 RVA: 0x00A22E07 File Offset: 0x00A21007
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillBehaviorBullet._ScriptStructPtr != 0) ? SSkillBehaviorBullet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SSkillBehaviorBullet.SSkillBehaviorBullet", ref SSkillBehaviorBullet._ScriptStructPtr);
		}

		// Token: 0x17006FED RID: 28653
		// (get) Token: 0x0602C912 RID: 182546 RVA: 0x00A22E2B File Offset: 0x00A2102B
		// (set) Token: 0x0602C913 RID: 182547 RVA: 0x00A22E3F File Offset: 0x00A2103F
		public unsafe string bulletRowName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorBullet.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorBullet.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006FEE RID: 28654
		// (get) Token: 0x0602C914 RID: 182548 RVA: 0x00A22E54 File Offset: 0x00A21054
		// (set) Token: 0x0602C915 RID: 182549 RVA: 0x00A22E64 File Offset: 0x00A21064
		public unsafe int bulletCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSkillBehaviorBullet.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSkillBehaviorBullet.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006FEF RID: 28655
		// (get) Token: 0x0602C916 RID: 182550 RVA: 0x00A22E75 File Offset: 0x00A21075
		// (set) Token: 0x0602C917 RID: 182551 RVA: 0x00A22E89 File Offset: 0x00A21089
		public unsafe string BlackboardKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorBullet.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillBehaviorBullet.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x0602C918 RID: 182552 RVA: 0x00A22E9E File Offset: 0x00A2109E
		public SSkillBehaviorBullet()
		{
		}

		// Token: 0x0602C919 RID: 182553 RVA: 0x00A22EA6 File Offset: 0x00A210A6
		public SSkillBehaviorBullet(string bulletRowName, int bulletCount, string BlackboardKey)
		{
			this.bulletRowName = bulletRowName;
			this.bulletCount = bulletCount;
			this.BlackboardKey = BlackboardKey;
		}

		// Token: 0x0602C91A RID: 182554 RVA: 0x00A22EC3 File Offset: 0x00A210C3
		protected override IntPtr GetUStructPtr()
		{
			return SSkillBehaviorBullet.StaticStruct();
		}

		// Token: 0x0602C91B RID: 182555 RVA: 0x00A22ECF File Offset: 0x00A210CF
		[NullableContext(2)]
		public SSkillBehaviorBullet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C91C RID: 182556 RVA: 0x00A22ED9 File Offset: 0x00A210D9
		public SSkillBehaviorBullet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C91D RID: 182557 RVA: 0x00A22EE4 File Offset: 0x00A210E4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillBehaviorBullet(Pointer, false, true);
		}

		// Token: 0x0602C91E RID: 182558 RVA: 0x00A22EEE File Offset: 0x00A210EE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillBehaviorBullet(Pointer, MemoryOwner);
		}

		// Token: 0x040177E2 RID: 96226
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SSkillBehaviorBullet.SSkillBehaviorBullet";

		// Token: 0x040177E3 RID: 96227
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040177E4 RID: 96228
		internal static int __PropertyOffset_0;

		// Token: 0x040177E5 RID: 96229
		internal static int __PropertyOffset_1;

		// Token: 0x040177E6 RID: 96230
		internal static int __PropertyOffset_2;
	}
}
