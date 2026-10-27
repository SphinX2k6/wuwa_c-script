using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.UI.Module.ActiveDebug
{
	// Token: 0x020039E1 RID: 14817
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/UI/Module/ActiveDebug/BvbPlayerItemData.BvbPlayerItemData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class BvbPlayerItemData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F02A RID: 127018 RVA: 0x008A764A File Offset: 0x008A584A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (BvbPlayerItemData._ScriptStructPtr != 0) ? BvbPlayerItemData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/UI/Module/ActiveDebug/BvbPlayerItemData.BvbPlayerItemData", ref BvbPlayerItemData._ScriptStructPtr);
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x0601F02B RID: 127019 RVA: 0x008A7670 File Offset: 0x008A5870
		// (set) Token: 0x0601F02C RID: 127020 RVA: 0x008A76B3 File Offset: 0x008A58B3
		public TArray<BvbCardItemData> CardsOnField
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BvbCardItemData> result;
				if ((result = this._CardsOnField) == null)
				{
					result = (this._CardsOnField = new TArray<BvbCardItemData>(base.NativePtr + (IntPtr)BvbPlayerItemData.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CardsOnField.CopyAssign(value);
			}
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x0601F02D RID: 127021 RVA: 0x008A76C4 File Offset: 0x008A58C4
		// (set) Token: 0x0601F02E RID: 127022 RVA: 0x008A7707 File Offset: 0x008A5907
		public TArray<BvbCardItemData> CardsOnHand
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BvbCardItemData> result;
				if ((result = this._CardsOnHand) == null)
				{
					result = (this._CardsOnHand = new TArray<BvbCardItemData>(base.NativePtr + (IntPtr)BvbPlayerItemData.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CardsOnHand.CopyAssign(value);
			}
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x0601F02F RID: 127023 RVA: 0x008A7718 File Offset: 0x008A5918
		// (set) Token: 0x0601F030 RID: 127024 RVA: 0x008A775B File Offset: 0x008A595B
		public TArray<BvbCardItemData> CardsInLibrary
		{
			get
			{
				base.FastCheckIsValid();
				TArray<BvbCardItemData> result;
				if ((result = this._CardsInLibrary) == null)
				{
					result = (this._CardsInLibrary = new TArray<BvbCardItemData>(base.NativePtr + (IntPtr)BvbPlayerItemData.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CardsInLibrary.CopyAssign(value);
			}
		}

		// Token: 0x0601F031 RID: 127025 RVA: 0x008A7769 File Offset: 0x008A5969
		public BvbPlayerItemData()
		{
		}

		// Token: 0x0601F032 RID: 127026 RVA: 0x008A7771 File Offset: 0x008A5971
		public BvbPlayerItemData(TArray<BvbCardItemData> CardsOnField, TArray<BvbCardItemData> CardsOnHand, TArray<BvbCardItemData> CardsInLibrary)
		{
			this.CardsOnField = CardsOnField;
			this.CardsOnHand = CardsOnHand;
			this.CardsInLibrary = CardsInLibrary;
		}

		// Token: 0x0601F033 RID: 127027 RVA: 0x008A778E File Offset: 0x008A598E
		protected override IntPtr GetUStructPtr()
		{
			return BvbPlayerItemData.StaticStruct();
		}

		// Token: 0x0601F034 RID: 127028 RVA: 0x008A779A File Offset: 0x008A599A
		[NullableContext(2)]
		public BvbPlayerItemData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F035 RID: 127029 RVA: 0x008A77A4 File Offset: 0x008A59A4
		public BvbPlayerItemData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F036 RID: 127030 RVA: 0x008A77AF File Offset: 0x008A59AF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new BvbPlayerItemData(Pointer, false, true);
		}

		// Token: 0x0601F037 RID: 127031 RVA: 0x008A77B9 File Offset: 0x008A59B9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new BvbPlayerItemData(Pointer, MemoryOwner);
		}

		// Token: 0x0400ED89 RID: 60809
		public const string __ObjectPath = "/Game/Aki/UI/Module/ActiveDebug/BvbPlayerItemData.BvbPlayerItemData";

		// Token: 0x0400ED8A RID: 60810
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400ED8B RID: 60811
		internal static int __PropertyOffset_0;

		// Token: 0x0400ED8C RID: 60812
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbCardItemData> _CardsOnField;

		// Token: 0x0400ED8D RID: 60813
		internal static int __PropertyOffset_1;

		// Token: 0x0400ED8E RID: 60814
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbCardItemData> _CardsOnHand;

		// Token: 0x0400ED8F RID: 60815
		internal static int __PropertyOffset_2;

		// Token: 0x0400ED90 RID: 60816
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BvbCardItemData> _CardsInLibrary;
	}
}
