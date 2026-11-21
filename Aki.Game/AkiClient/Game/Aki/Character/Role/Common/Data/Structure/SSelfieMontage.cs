using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020032A6 RID: 12966
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/SSelfieMontage.SSelfieMontage")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class SSelfieMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060209CD RID: 133581 RVA: 0x0094AED9 File Offset: 0x009490D9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSelfieMontage._ScriptStructPtr != 0) ? SSelfieMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/Structure/SSelfieMontage.SSelfieMontage", ref SSelfieMontage._ScriptStructPtr);
		}

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x060209CE RID: 133582 RVA: 0x0094AEFD File Offset: 0x009490FD
		// (set) Token: 0x060209CF RID: 133583 RVA: 0x0094AF0D File Offset: 0x0094910D
		public unsafe int ConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_ConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_ConfigId) = value;
			}
		}

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x060209D0 RID: 133584 RVA: 0x0094AF1E File Offset: 0x0094911E
		// (set) Token: 0x060209D1 RID: 133585 RVA: 0x0094AF32 File Offset: 0x00949132
		public unsafe TEnumAsByte<ESelfieMontageType> MontageType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_MontageType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_MontageType) = value;
			}
		}

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x060209D2 RID: 133586 RVA: 0x0094AF47 File Offset: 0x00949147
		// (set) Token: 0x060209D3 RID: 133587 RVA: 0x0094AF66 File Offset: 0x00949166
		[Nullable(1)]
		public TSoftObjectPtr<UAnimMontage> MontageRef
		{
			[NullableContext(1)]
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_MontageRef, base.MemoryOwner ?? this);
			}
			[NullableContext(1)]
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SSelfieMontage.__PropertyOffset_MontageRef, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060209D4 RID: 133588 RVA: 0x0094AF8B File Offset: 0x0094918B
		public SSelfieMontage()
		{
		}

		// Token: 0x060209D5 RID: 133589 RVA: 0x0094AF93 File Offset: 0x00949193
		protected override IntPtr GetUStructPtr()
		{
			return SSelfieMontage.StaticStruct();
		}

		// Token: 0x060209D6 RID: 133590 RVA: 0x0094AF9F File Offset: 0x0094919F
		[NullableContext(2)]
		public SSelfieMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060209D7 RID: 133591 RVA: 0x0094AFA9 File Offset: 0x009491A9
		public SSelfieMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060209D8 RID: 133592 RVA: 0x0094AFB4 File Offset: 0x009491B4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSelfieMontage(Pointer, false, true);
		}

		// Token: 0x060209D9 RID: 133593 RVA: 0x0094AFBE File Offset: 0x009491BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSelfieMontage(Pointer, MemoryOwner);
		}

		// Token: 0x04011A0D RID: 72205
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/SSelfieMontage.SSelfieMontage";

		// Token: 0x04011A0E RID: 72206
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011A0F RID: 72207
		internal static int __PropertyOffset_ConfigId;

		// Token: 0x04011A10 RID: 72208
		internal static int __PropertyOffset_MontageType;

		// Token: 0x04011A11 RID: 72209
		internal static int __PropertyOffset_MontageRef;
	}
}
