using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020032A4 RID: 12964
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/SCharacterFootprint.SCharacterFootprint")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class SCharacterFootprint : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060209AF RID: 133551 RVA: 0x0094ACBB File Offset: 0x00948EBB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterFootprint._ScriptStructPtr != 0) ? SCharacterFootprint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Role/Common/Data/Structure/SCharacterFootprint.SCharacterFootprint", ref SCharacterFootprint._ScriptStructPtr);
		}

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x060209B0 RID: 133552 RVA: 0x0094ACDF File Offset: 0x00948EDF
		// (set) Token: 0x060209B1 RID: 133553 RVA: 0x0094ACF3 File Offset: 0x00948EF3
		public unsafe FGameplayTag Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x060209B2 RID: 133554 RVA: 0x0094AD08 File Offset: 0x00948F08
		// (set) Token: 0x060209B3 RID: 133555 RVA: 0x0094AD18 File Offset: 0x00948F18
		public unsafe int SortID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_SortID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_SortID) = value;
			}
		}

		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x060209B4 RID: 133556 RVA: 0x0094AD29 File Offset: 0x00948F29
		// (set) Token: 0x060209B5 RID: 133557 RVA: 0x0094AD39 File Offset: 0x00948F39
		public unsafe int OverrideGlobalFootEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_OverrideGlobalFootEffect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_OverrideGlobalFootEffect) = value;
			}
		}

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x060209B6 RID: 133558 RVA: 0x0094AD4A File Offset: 0x00948F4A
		// (set) Token: 0x060209B7 RID: 133559 RVA: 0x0094AD5A File Offset: 0x00948F5A
		public unsafe int OverrideOtherCharacterFootEffect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_OverrideOtherCharacterFootEffect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_OverrideOtherCharacterFootEffect) = value;
			}
		}

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x060209B8 RID: 133560 RVA: 0x0094AD6B File Offset: 0x00948F6B
		// (set) Token: 0x060209B9 RID: 133561 RVA: 0x0094AD8A File Offset: 0x00948F8A
		public TSoftObjectPtr<UEffectModelBase> Effect
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_Effect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SCharacterFootprint.__PropertyOffset_Effect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060209BA RID: 133562 RVA: 0x0094ADAF File Offset: 0x00948FAF
		public SCharacterFootprint()
		{
		}

		// Token: 0x060209BB RID: 133563 RVA: 0x0094ADB7 File Offset: 0x00948FB7
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterFootprint.StaticStruct();
		}

		// Token: 0x060209BC RID: 133564 RVA: 0x0094ADC3 File Offset: 0x00948FC3
		[NullableContext(2)]
		public SCharacterFootprint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060209BD RID: 133565 RVA: 0x0094ADCD File Offset: 0x00948FCD
		public SCharacterFootprint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060209BE RID: 133566 RVA: 0x0094ADD8 File Offset: 0x00948FD8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterFootprint(Pointer, false, true);
		}

		// Token: 0x060209BF RID: 133567 RVA: 0x0094ADE2 File Offset: 0x00948FE2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterFootprint(Pointer, MemoryOwner);
		}

		// Token: 0x04011A01 RID: 72193
		public const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/SCharacterFootprint.SCharacterFootprint";

		// Token: 0x04011A02 RID: 72194
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011A03 RID: 72195
		internal static int __PropertyOffset_Tag;

		// Token: 0x04011A04 RID: 72196
		internal static int __PropertyOffset_SortID;

		// Token: 0x04011A05 RID: 72197
		internal static int __PropertyOffset_OverrideGlobalFootEffect;

		// Token: 0x04011A06 RID: 72198
		internal static int __PropertyOffset_OverrideOtherCharacterFootEffect;

		// Token: 0x04011A07 RID: 72199
		internal static int __PropertyOffset_Effect;
	}
}
