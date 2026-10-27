using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200432A RID: 17194
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SReplaceMontage.SReplaceMontage")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SReplaceMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C86D RID: 182381 RVA: 0x00A21DF8 File Offset: 0x00A1FFF8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReplaceMontage._ScriptStructPtr != 0) ? SReplaceMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SReplaceMontage.SReplaceMontage", ref SReplaceMontage._ScriptStructPtr);
		}

		// Token: 0x17006FAB RID: 28587
		// (get) Token: 0x0602C86E RID: 182382 RVA: 0x00A21E1C File Offset: 0x00A2001C
		// (set) Token: 0x0602C86F RID: 182383 RVA: 0x00A21E3B File Offset: 0x00A2003B
		public TSoftObjectPtr<UAnimMontage> OldMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SReplaceMontage.__PropertyOffset_0, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReplaceMontage.__PropertyOffset_0, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006FAC RID: 28588
		// (get) Token: 0x0602C870 RID: 182384 RVA: 0x00A21E60 File Offset: 0x00A20060
		// (set) Token: 0x0602C871 RID: 182385 RVA: 0x00A21E7F File Offset: 0x00A2007F
		public TSoftObjectPtr<UAnimMontage> NewMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SReplaceMontage.__PropertyOffset_1, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReplaceMontage.__PropertyOffset_1, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0602C872 RID: 182386 RVA: 0x00A21EA4 File Offset: 0x00A200A4
		public SReplaceMontage()
		{
		}

		// Token: 0x0602C873 RID: 182387 RVA: 0x00A21EAC File Offset: 0x00A200AC
		public SReplaceMontage(TSoftObjectPtr<UAnimMontage> OldMontage, TSoftObjectPtr<UAnimMontage> NewMontage)
		{
			this.OldMontage = OldMontage;
			this.NewMontage = NewMontage;
		}

		// Token: 0x0602C874 RID: 182388 RVA: 0x00A21EC2 File Offset: 0x00A200C2
		protected override IntPtr GetUStructPtr()
		{
			return SReplaceMontage.StaticStruct();
		}

		// Token: 0x0602C875 RID: 182389 RVA: 0x00A21ECE File Offset: 0x00A200CE
		[NullableContext(2)]
		public SReplaceMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C876 RID: 182390 RVA: 0x00A21ED8 File Offset: 0x00A200D8
		public SReplaceMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C877 RID: 182391 RVA: 0x00A21EE3 File Offset: 0x00A200E3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReplaceMontage(Pointer, false, true);
		}

		// Token: 0x0602C878 RID: 182392 RVA: 0x00A21EED File Offset: 0x00A200ED
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReplaceMontage(Pointer, MemoryOwner);
		}

		// Token: 0x0401778C RID: 96140
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SReplaceMontage.SReplaceMontage";

		// Token: 0x0401778D RID: 96141
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401778E RID: 96142
		internal static int __PropertyOffset_0;

		// Token: 0x0401778F RID: 96143
		internal static int __PropertyOffset_1;
	}
}
