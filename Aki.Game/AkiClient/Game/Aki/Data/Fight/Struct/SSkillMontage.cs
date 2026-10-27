using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F75 RID: 16245
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SSkillMontage.SSkillMontage")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class SSkillMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602975E RID: 169822 RVA: 0x009C4CF4 File Offset: 0x009C2EF4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSkillMontage._ScriptStructPtr != 0) ? SSkillMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SSkillMontage.SSkillMontage", ref SSkillMontage._ScriptStructPtr);
		}

		// Token: 0x17006361 RID: 25441
		// (get) Token: 0x0602975F RID: 169823 RVA: 0x009C4D18 File Offset: 0x009C2F18
		// (set) Token: 0x06029760 RID: 169824 RVA: 0x009C4D2C File Offset: 0x009C2F2C
		public unsafe string CharacterPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillMontage.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillMontage.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006362 RID: 25442
		// (get) Token: 0x06029761 RID: 169825 RVA: 0x009C4D41 File Offset: 0x009C2F41
		// (set) Token: 0x06029762 RID: 169826 RVA: 0x009C4D55 File Offset: 0x009C2F55
		public unsafe string MontageName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SSkillMontage.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SSkillMontage.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006363 RID: 25443
		// (get) Token: 0x06029763 RID: 169827 RVA: 0x009C4D6A File Offset: 0x009C2F6A
		// (set) Token: 0x06029764 RID: 169828 RVA: 0x009C4D89 File Offset: 0x009C2F89
		public TSoftObjectPtr<UAnimMontage> CommonAnim
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SSkillMontage.__PropertyOffset_2, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSkillMontage.__PropertyOffset_2, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006364 RID: 25444
		// (get) Token: 0x06029765 RID: 169829 RVA: 0x009C4DAE File Offset: 0x009C2FAE
		// (set) Token: 0x06029766 RID: 169830 RVA: 0x009C4DCD File Offset: 0x009C2FCD
		public TSoftObjectPtr<UAnimMontage> BaseAnim
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SSkillMontage.__PropertyOffset_3, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSkillMontage.__PropertyOffset_3, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06029767 RID: 169831 RVA: 0x009C4DF2 File Offset: 0x009C2FF2
		public SSkillMontage()
		{
		}

		// Token: 0x06029768 RID: 169832 RVA: 0x009C4DFA File Offset: 0x009C2FFA
		public SSkillMontage(string CharacterPath, string MontageName, TSoftObjectPtr<UAnimMontage> CommonAnim, TSoftObjectPtr<UAnimMontage> BaseAnim)
		{
			this.CharacterPath = CharacterPath;
			this.MontageName = MontageName;
			this.CommonAnim = CommonAnim;
			this.BaseAnim = BaseAnim;
		}

		// Token: 0x06029769 RID: 169833 RVA: 0x009C4E1F File Offset: 0x009C301F
		protected override IntPtr GetUStructPtr()
		{
			return SSkillMontage.StaticStruct();
		}

		// Token: 0x0602976A RID: 169834 RVA: 0x009C4E2B File Offset: 0x009C302B
		[NullableContext(2)]
		public SSkillMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602976B RID: 169835 RVA: 0x009C4E35 File Offset: 0x009C3035
		public SSkillMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602976C RID: 169836 RVA: 0x009C4E40 File Offset: 0x009C3040
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSkillMontage(Pointer, false, true);
		}

		// Token: 0x0602976D RID: 169837 RVA: 0x009C4E4A File Offset: 0x009C304A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSkillMontage(Pointer, MemoryOwner);
		}

		// Token: 0x040153E8 RID: 87016
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SSkillMontage.SSkillMontage";

		// Token: 0x040153E9 RID: 87017
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040153EA RID: 87018
		internal static int __PropertyOffset_0;

		// Token: 0x040153EB RID: 87019
		internal static int __PropertyOffset_1;

		// Token: 0x040153EC RID: 87020
		internal static int __PropertyOffset_2;

		// Token: 0x040153ED RID: 87021
		internal static int __PropertyOffset_3;
	}
}
