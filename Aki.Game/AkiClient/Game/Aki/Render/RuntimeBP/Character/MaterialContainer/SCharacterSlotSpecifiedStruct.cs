using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer
{
	// Token: 0x02003E26 RID: 15910
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/SCharacterSlotSpecifiedStruct.SCharacterSlotSpecifiedStruct")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SCharacterSlotSpecifiedStruct : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027DFF RID: 163327 RVA: 0x0099D8D7 File Offset: 0x0099BAD7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCharacterSlotSpecifiedStruct._ScriptStructPtr != 0) ? SCharacterSlotSpecifiedStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/SCharacterSlotSpecifiedStruct.SCharacterSlotSpecifiedStruct", ref SCharacterSlotSpecifiedStruct._ScriptStructPtr);
		}

		// Token: 0x17005A8A RID: 23178
		// (get) Token: 0x06027E00 RID: 163328 RVA: 0x0099D8FB File Offset: 0x0099BAFB
		// (set) Token: 0x06027E01 RID: 163329 RVA: 0x0099D90F File Offset: 0x0099BB0F
		public unsafe TEnumAsByte<ECharacterSlotSpecifiedType> SlotSpecifiedType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCharacterSlotSpecifiedStruct.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCharacterSlotSpecifiedStruct.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005A8B RID: 23179
		// (get) Token: 0x06027E02 RID: 163330 RVA: 0x0099D924 File Offset: 0x0099BB24
		// (set) Token: 0x06027E03 RID: 163331 RVA: 0x0099D967 File Offset: 0x0099BB67
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<ECharacterSlotType>> SlotTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<ECharacterSlotType>> result;
				if ((result = this._SlotTypes) == null)
				{
					result = (this._SlotTypes = new TArray<TEnumAsByte<ECharacterSlotType>>(base.NativePtr + (IntPtr)SCharacterSlotSpecifiedStruct.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.SlotTypes.CopyAssign(value);
			}
		}

		// Token: 0x06027E04 RID: 163332 RVA: 0x0099D975 File Offset: 0x0099BB75
		public SCharacterSlotSpecifiedStruct()
		{
		}

		// Token: 0x06027E05 RID: 163333 RVA: 0x0099D97D File Offset: 0x0099BB7D
		public SCharacterSlotSpecifiedStruct(TEnumAsByte<ECharacterSlotSpecifiedType> SlotSpecifiedType, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<ECharacterSlotType>> SlotTypes)
		{
			this.SlotSpecifiedType = SlotSpecifiedType;
			this.SlotTypes = SlotTypes;
		}

		// Token: 0x06027E06 RID: 163334 RVA: 0x0099D993 File Offset: 0x0099BB93
		protected override IntPtr GetUStructPtr()
		{
			return SCharacterSlotSpecifiedStruct.StaticStruct();
		}

		// Token: 0x06027E07 RID: 163335 RVA: 0x0099D99F File Offset: 0x0099BB9F
		[NullableContext(2)]
		public SCharacterSlotSpecifiedStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027E08 RID: 163336 RVA: 0x0099D9A9 File Offset: 0x0099BBA9
		public SCharacterSlotSpecifiedStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027E09 RID: 163337 RVA: 0x0099D9B4 File Offset: 0x0099BBB4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCharacterSlotSpecifiedStruct(Pointer, false, true);
		}

		// Token: 0x06027E0A RID: 163338 RVA: 0x0099D9BE File Offset: 0x0099BBBE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCharacterSlotSpecifiedStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04014393 RID: 82835
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/MaterialContainer/SCharacterSlotSpecifiedStruct.SCharacterSlotSpecifiedStruct";

		// Token: 0x04014394 RID: 82836
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014395 RID: 82837
		internal static int __PropertyOffset_0;

		// Token: 0x04014396 RID: 82838
		internal static int __PropertyOffset_1;

		// Token: 0x04014397 RID: 82839
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECharacterSlotType>> _SlotTypes;
	}
}
