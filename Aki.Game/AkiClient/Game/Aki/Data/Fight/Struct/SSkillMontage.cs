using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003212 RID: 12818
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SSkillMontage.SSkillMontage")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class SSkillMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FF47 RID: 130887 RVA: 0x00939B74 File Offset: 0x00937D74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillMontage._ScriptStructPtr != 0) ? SSkillMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SSkillMontage.SSkillMontage", ref SSkillMontage._ScriptStructPtr);
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x0601FF48 RID: 130888 RVA: 0x00939B98 File Offset: 0x00937D98
		// (set) Token: 0x0601FF49 RID: 130889 RVA: 0x00939BAC File Offset: 0x00937DAC
		public unsafe string CharacterPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillMontage.__PropertyOffset_CharacterPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillMontage.__PropertyOffset_CharacterPath)), value);
			}
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0601FF4A RID: 130890 RVA: 0x00939BC1 File Offset: 0x00937DC1
		// (set) Token: 0x0601FF4B RID: 130891 RVA: 0x00939BD5 File Offset: 0x00937DD5
		public unsafe string MontageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillMontage.__PropertyOffset_MontageName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillMontage.__PropertyOffset_MontageName)), value);
			}
		}

		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0601FF4C RID: 130892 RVA: 0x00939BEA File Offset: 0x00937DEA
		// (set) Token: 0x0601FF4D RID: 130893 RVA: 0x00939C09 File Offset: 0x00937E09
		public TSoftObjectPtr<UAnimMontage> CommonAnim
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SSkillMontage.__PropertyOffset_CommonAnim, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSkillMontage.__PropertyOffset_CommonAnim, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003C65 RID: 15461
		// (get) Token: 0x0601FF4E RID: 130894 RVA: 0x00939C2E File Offset: 0x00937E2E
		// (set) Token: 0x0601FF4F RID: 130895 RVA: 0x00939C4D File Offset: 0x00937E4D
		public TSoftObjectPtr<UAnimMontage> BaseAnim
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SSkillMontage.__PropertyOffset_BaseAnim, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSkillMontage.__PropertyOffset_BaseAnim, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601FF50 RID: 130896 RVA: 0x00939C72 File Offset: 0x00937E72
		public SSkillMontage()
		{
		}

		// Token: 0x0601FF51 RID: 130897 RVA: 0x00939C7A File Offset: 0x00937E7A
		protected override IntPtr GetUStructPtr()
		{
			return SSkillMontage.StaticStruct();
		}

		// Token: 0x0601FF52 RID: 130898 RVA: 0x00939C86 File Offset: 0x00937E86
		[NullableContext(2)]
		public SSkillMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FF53 RID: 130899 RVA: 0x00939C90 File Offset: 0x00937E90
		public SSkillMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FF54 RID: 130900 RVA: 0x00939C9B File Offset: 0x00937E9B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillMontage(Pointer, false, true);
		}

		// Token: 0x0601FF55 RID: 130901 RVA: 0x00939CA5 File Offset: 0x00937EA5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillMontage(Pointer, MemoryOwner);
		}

		// Token: 0x0401128B RID: 70283
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SSkillMontage.SSkillMontage";

		// Token: 0x0401128C RID: 70284
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401128D RID: 70285
		internal static int __PropertyOffset_CharacterPath;

		// Token: 0x0401128E RID: 70286
		internal static int __PropertyOffset_MontageName;

		// Token: 0x0401128F RID: 70287
		internal static int __PropertyOffset_CommonAnim;

		// Token: 0x04011290 RID: 70288
		internal static int __PropertyOffset_BaseAnim;
	}
}
