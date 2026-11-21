using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E77 RID: 32375
	public class TCharacterLookAtDataUnion
	{
		// Token: 0x1700F217 RID: 61975
		// (get) Token: 0x0603A771 RID: 239473 RVA: 0x007DEDEC File Offset: 0x007DCFEC
		// (set) Token: 0x0603A772 RID: 239474 RVA: 0x007DEDF4 File Offset: 0x007DCFF4
		public TCharacterLookAtData Type { get; set; }

		// Token: 0x1700F218 RID: 61976
		// (get) Token: 0x0603A773 RID: 239475 RVA: 0x007DEDFD File Offset: 0x007DCFFD
		// (set) Token: 0x0603A774 RID: 239476 RVA: 0x007DEE05 File Offset: 0x007DD005
		public object Value { get; set; }

		// Token: 0x0603A775 RID: 239477 RVA: 0x007DEE0E File Offset: 0x007DD00E
		public TCharacterLookAtDataUnion()
		{
			this.Type = TCharacterLookAtData.NONE;
			this.Value = null;
		}

		// Token: 0x0603A776 RID: 239478 RVA: 0x007DEE24 File Offset: 0x007DD024
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A777 RID: 239479 RVA: 0x007DEE36 File Offset: 0x007DD036
		public ICharacterLookAtEmptyDataT AsICharacterLookAtEmptyData()
		{
			return this.As<ICharacterLookAtEmptyDataT>();
		}

		// Token: 0x0603A778 RID: 239480 RVA: 0x007DEE3E File Offset: 0x007DD03E
		public static TCharacterLookAtDataUnion FromICharacterLookAtEmptyData(ICharacterLookAtEmptyDataT _icharacterlookatemptydata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtEmptyData,
				Value = _icharacterlookatemptydata
			};
		}

		// Token: 0x0603A779 RID: 239481 RVA: 0x007DEE53 File Offset: 0x007DD053
		public ICharacterLookAtEntityDataT AsICharacterLookAtEntityData()
		{
			return this.As<ICharacterLookAtEntityDataT>();
		}

		// Token: 0x0603A77A RID: 239482 RVA: 0x007DEE5B File Offset: 0x007DD05B
		public static TCharacterLookAtDataUnion FromICharacterLookAtEntityData(ICharacterLookAtEntityDataT _icharacterlookatentitydata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtEntityData,
				Value = _icharacterlookatentitydata
			};
		}

		// Token: 0x0603A77B RID: 239483 RVA: 0x007DEE70 File Offset: 0x007DD070
		public ICharacterLookAtPlayerDataT AsICharacterLookAtPlayerData()
		{
			return this.As<ICharacterLookAtPlayerDataT>();
		}

		// Token: 0x0603A77C RID: 239484 RVA: 0x007DEE78 File Offset: 0x007DD078
		public static TCharacterLookAtDataUnion FromICharacterLookAtPlayerData(ICharacterLookAtPlayerDataT _icharacterlookatplayerdata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtPlayerData,
				Value = _icharacterlookatplayerdata
			};
		}

		// Token: 0x0603A77D RID: 239485 RVA: 0x007DEE8D File Offset: 0x007DD08D
		public ICharacterLookAtPositionDataT AsICharacterLookAtPositionData()
		{
			return this.As<ICharacterLookAtPositionDataT>();
		}

		// Token: 0x0603A77E RID: 239486 RVA: 0x007DEE95 File Offset: 0x007DD095
		public static TCharacterLookAtDataUnion FromICharacterLookAtPositionData(ICharacterLookAtPositionDataT _icharacterlookatpositiondata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtPositionData,
				Value = _icharacterlookatpositiondata
			};
		}

		// Token: 0x0603A77F RID: 239487 RVA: 0x007DEEAA File Offset: 0x007DD0AA
		public ICharacterLookAtUnlockDataT AsICharacterLookAtUnlockData()
		{
			return this.As<ICharacterLookAtUnlockDataT>();
		}

		// Token: 0x0603A780 RID: 239488 RVA: 0x007DEEB2 File Offset: 0x007DD0B2
		public static TCharacterLookAtDataUnion FromICharacterLookAtUnlockData(ICharacterLookAtUnlockDataT _icharacterlookatunlockdata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtUnlockData,
				Value = _icharacterlookatunlockdata
			};
		}

		// Token: 0x0603A781 RID: 239489 RVA: 0x007DEEC8 File Offset: 0x007DD0C8
		public static int Pack(FlatBufferBuilder builder, TCharacterLookAtDataUnion _o)
		{
			switch (_o.Type)
			{
			case TCharacterLookAtData.ICharacterLookAtEmptyData:
				return ICharacterLookAtEmptyData.Pack(builder, _o.AsICharacterLookAtEmptyData()).Value;
			case TCharacterLookAtData.ICharacterLookAtEntityData:
				return ICharacterLookAtEntityData.Pack(builder, _o.AsICharacterLookAtEntityData()).Value;
			case TCharacterLookAtData.ICharacterLookAtPlayerData:
				return ICharacterLookAtPlayerData.Pack(builder, _o.AsICharacterLookAtPlayerData()).Value;
			case TCharacterLookAtData.ICharacterLookAtPositionData:
				return ICharacterLookAtPositionData.Pack(builder, _o.AsICharacterLookAtPositionData()).Value;
			case TCharacterLookAtData.ICharacterLookAtUnlockData:
				return ICharacterLookAtUnlockData.Pack(builder, _o.AsICharacterLookAtUnlockData()).Value;
			default:
				return 0;
			}
		}
	}
}
