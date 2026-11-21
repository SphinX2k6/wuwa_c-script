using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x02003039 RID: 12345
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbPlayerItemData.BvbPlayerItemData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class BvbPlayerItemData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D4A0 RID: 119968 RVA: 0x008EFF11 File Offset: 0x008EE111
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BvbPlayerItemData._ScriptStructPtr != 0) ? BvbPlayerItemData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/UI/Module/ActiveDebug/BvbPlayerItemData.BvbPlayerItemData", ref BvbPlayerItemData._ScriptStructPtr);
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0601D4A1 RID: 119969 RVA: 0x008EFF38 File Offset: 0x008EE138
		// (set) Token: 0x0601D4A2 RID: 119970 RVA: 0x008EFF7B File Offset: 0x008EE17B
		public TArray<BvbCardItemData> CardsOnField
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BvbCardItemData> result;
				if ((result = this._CardsOnField) == null)
				{
					result = (this._CardsOnField = new TArray<BvbCardItemData>(base.NativePtr + (IntPtr)BvbPlayerItemData.__PropertyOffset_CardsOnField, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CardsOnField.CopyAssign(value);
			}
		}

		// Token: 0x17002E91 RID: 11921
		// (get) Token: 0x0601D4A3 RID: 119971 RVA: 0x008EFF8C File Offset: 0x008EE18C
		// (set) Token: 0x0601D4A4 RID: 119972 RVA: 0x008EFFCF File Offset: 0x008EE1CF
		public TArray<BvbCardItemData> CardsOnHand
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BvbCardItemData> result;
				if ((result = this._CardsOnHand) == null)
				{
					result = (this._CardsOnHand = new TArray<BvbCardItemData>(base.NativePtr + (IntPtr)BvbPlayerItemData.__PropertyOffset_CardsOnHand, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CardsOnHand.CopyAssign(value);
			}
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0601D4A5 RID: 119973 RVA: 0x008EFFE0 File Offset: 0x008EE1E0
		// (set) Token: 0x0601D4A6 RID: 119974 RVA: 0x008F0023 File Offset: 0x008EE223
		public TArray<BvbCardItemData> CardsInLibrary
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BvbCardItemData> result;
				if ((result = this._CardsInLibrary) == null)
				{
					result = (this._CardsInLibrary = new TArray<BvbCardItemData>(base.NativePtr + (IntPtr)BvbPlayerItemData.__PropertyOffset_CardsInLibrary, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CardsInLibrary.CopyAssign(value);
			}
		}

		// Token: 0x0601D4A7 RID: 119975 RVA: 0x008F0031 File Offset: 0x008EE231
		public BvbPlayerItemData()
		{
		}

		// Token: 0x0601D4A8 RID: 119976 RVA: 0x008F0039 File Offset: 0x008EE239
		protected override IntPtr GetUStructPtr()
		{
			return BvbPlayerItemData.StaticStruct();
		}

		// Token: 0x0601D4A9 RID: 119977 RVA: 0x008F0045 File Offset: 0x008EE245
		[NullableContext(2)]
		public BvbPlayerItemData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D4AA RID: 119978 RVA: 0x008F004F File Offset: 0x008EE24F
		public BvbPlayerItemData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D4AB RID: 119979 RVA: 0x008F005A File Offset: 0x008EE25A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BvbPlayerItemData(Pointer, false, true);
		}

		// Token: 0x0601D4AC RID: 119980 RVA: 0x008F0064 File Offset: 0x008EE264
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BvbPlayerItemData(Pointer, MemoryOwner);
		}

		// Token: 0x0400F6BB RID: 63163
		public const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbPlayerItemData.BvbPlayerItemData";

		// Token: 0x0400F6BC RID: 63164
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F6BD RID: 63165
		internal static int __PropertyOffset_CardsOnField;

		// Token: 0x0400F6BE RID: 63166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbCardItemData> _CardsOnField;

		// Token: 0x0400F6BF RID: 63167
		internal static int __PropertyOffset_CardsOnHand;

		// Token: 0x0400F6C0 RID: 63168
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbCardItemData> _CardsOnHand;

		// Token: 0x0400F6C1 RID: 63169
		internal static int __PropertyOffset_CardsInLibrary;

		// Token: 0x0400F6C2 RID: 63170
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbCardItemData> _CardsInLibrary;
	}
}
