using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200334D RID: 13133
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SFloatingMovementState.SFloatingMovementState")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class SFloatingMovementState : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213AD RID: 136109 RVA: 0x0095C150 File Offset: 0x0095A350
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFloatingMovementState._ScriptStructPtr != 0) ? SFloatingMovementState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SFloatingMovementState.SFloatingMovementState", ref SFloatingMovementState._ScriptStructPtr);
		}

		// Token: 0x17004341 RID: 17217
		// (get) Token: 0x060213AE RID: 136110 RVA: 0x0095C174 File Offset: 0x0095A374
		// (set) Token: 0x060213AF RID: 136111 RVA: 0x0095C188 File Offset: 0x0095A388
		[Nullable(0)]
		public unsafe TEnumAsByte<EFloatingMovementType> Mode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_Mode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_Mode) = value;
			}
		}

		// Token: 0x17004342 RID: 17218
		// (get) Token: 0x060213B0 RID: 136112 RVA: 0x0095C1A0 File Offset: 0x0095A3A0
		// (set) Token: 0x060213B1 RID: 136113 RVA: 0x0095C1E3 File Offset: 0x0095A3E3
		public FGameplayTagContainer MovementTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._MovementTagList) == null)
				{
					result = (this._MovementTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_MovementTagList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_MovementTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004343 RID: 17219
		// (get) Token: 0x060213B2 RID: 136114 RVA: 0x0095C204 File Offset: 0x0095A404
		// (set) Token: 0x060213B3 RID: 136115 RVA: 0x0095C247 File Offset: 0x0095A447
		public FGameplayTagContainer BannedMovementTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._BannedMovementTagList) == null)
				{
					result = (this._BannedMovementTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_BannedMovementTagList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_BannedMovementTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004344 RID: 17220
		// (get) Token: 0x060213B4 RID: 136116 RVA: 0x0095C268 File Offset: 0x0095A468
		// (set) Token: 0x060213B5 RID: 136117 RVA: 0x0095C2AB File Offset: 0x0095A4AB
		public FGameplayTagContainer MoveTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._MoveTagList) == null)
				{
					result = (this._MoveTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_MoveTagList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_MoveTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004345 RID: 17221
		// (get) Token: 0x060213B6 RID: 136118 RVA: 0x0095C2CC File Offset: 0x0095A4CC
		// (set) Token: 0x060213B7 RID: 136119 RVA: 0x0095C30F File Offset: 0x0095A50F
		public FGameplayTagContainer StandTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._StandTagList) == null)
				{
					result = (this._StandTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_StandTagList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SFloatingMovementState.__PropertyOffset_StandTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060213B8 RID: 136120 RVA: 0x0095C330 File Offset: 0x0095A530
		public SFloatingMovementState()
		{
		}

		// Token: 0x060213B9 RID: 136121 RVA: 0x0095C338 File Offset: 0x0095A538
		protected override IntPtr GetUStructPtr()
		{
			return SFloatingMovementState.StaticStruct();
		}

		// Token: 0x060213BA RID: 136122 RVA: 0x0095C344 File Offset: 0x0095A544
		[NullableContext(2)]
		public SFloatingMovementState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213BB RID: 136123 RVA: 0x0095C34E File Offset: 0x0095A54E
		public SFloatingMovementState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213BC RID: 136124 RVA: 0x0095C359 File Offset: 0x0095A559
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFloatingMovementState(Pointer, false, true);
		}

		// Token: 0x060213BD RID: 136125 RVA: 0x0095C363 File Offset: 0x0095A563
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFloatingMovementState(Pointer, MemoryOwner);
		}

		// Token: 0x040122A9 RID: 74409
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SFloatingMovementState.SFloatingMovementState";

		// Token: 0x040122AA RID: 74410
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040122AB RID: 74411
		internal static int __PropertyOffset_Mode;

		// Token: 0x040122AC RID: 74412
		internal static int __PropertyOffset_MovementTagList;

		// Token: 0x040122AD RID: 74413
		[Nullable(2)]
		private FGameplayTagContainer _MovementTagList;

		// Token: 0x040122AE RID: 74414
		internal static int __PropertyOffset_BannedMovementTagList;

		// Token: 0x040122AF RID: 74415
		[Nullable(2)]
		private FGameplayTagContainer _BannedMovementTagList;

		// Token: 0x040122B0 RID: 74416
		internal static int __PropertyOffset_MoveTagList;

		// Token: 0x040122B1 RID: 74417
		[Nullable(2)]
		private FGameplayTagContainer _MoveTagList;

		// Token: 0x040122B2 RID: 74418
		internal static int __PropertyOffset_StandTagList;

		// Token: 0x040122B3 RID: 74419
		[Nullable(2)]
		private FGameplayTagContainer _StandTagList;
	}
}
