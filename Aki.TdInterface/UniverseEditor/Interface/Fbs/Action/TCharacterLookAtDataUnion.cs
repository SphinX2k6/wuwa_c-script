using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007669 RID: 30313
	public class TCharacterLookAtDataUnion
	{
		// Token: 0x1700E5D9 RID: 58841
		// (get) Token: 0x060372CC RID: 225996 RVA: 0x0077ACF0 File Offset: 0x00778EF0
		// (set) Token: 0x060372CD RID: 225997 RVA: 0x0077ACF8 File Offset: 0x00778EF8
		public TCharacterLookAtData Type { get; set; }

		// Token: 0x1700E5DA RID: 58842
		// (get) Token: 0x060372CE RID: 225998 RVA: 0x0077AD01 File Offset: 0x00778F01
		// (set) Token: 0x060372CF RID: 225999 RVA: 0x0077AD09 File Offset: 0x00778F09
		public object Value { get; set; }

		// Token: 0x060372D0 RID: 226000 RVA: 0x0077AD12 File Offset: 0x00778F12
		public TCharacterLookAtDataUnion()
		{
			this.Type = TCharacterLookAtData.NONE;
			this.Value = null;
		}

		// Token: 0x060372D1 RID: 226001 RVA: 0x0077AD28 File Offset: 0x00778F28
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060372D2 RID: 226002 RVA: 0x0077AD3A File Offset: 0x00778F3A
		public ICharacterLookAtEmptyDataT AsICharacterLookAtEmptyData()
		{
			return this.As<ICharacterLookAtEmptyDataT>();
		}

		// Token: 0x060372D3 RID: 226003 RVA: 0x0077AD42 File Offset: 0x00778F42
		public static TCharacterLookAtDataUnion FromICharacterLookAtEmptyData(ICharacterLookAtEmptyDataT _icharacterlookatemptydata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtEmptyData,
				Value = _icharacterlookatemptydata
			};
		}

		// Token: 0x060372D4 RID: 226004 RVA: 0x0077AD57 File Offset: 0x00778F57
		public ICharacterLookAtEntityDataT AsICharacterLookAtEntityData()
		{
			return this.As<ICharacterLookAtEntityDataT>();
		}

		// Token: 0x060372D5 RID: 226005 RVA: 0x0077AD5F File Offset: 0x00778F5F
		public static TCharacterLookAtDataUnion FromICharacterLookAtEntityData(ICharacterLookAtEntityDataT _icharacterlookatentitydata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtEntityData,
				Value = _icharacterlookatentitydata
			};
		}

		// Token: 0x060372D6 RID: 226006 RVA: 0x0077AD74 File Offset: 0x00778F74
		public ICharacterLookAtPlayerDataT AsICharacterLookAtPlayerData()
		{
			return this.As<ICharacterLookAtPlayerDataT>();
		}

		// Token: 0x060372D7 RID: 226007 RVA: 0x0077AD7C File Offset: 0x00778F7C
		public static TCharacterLookAtDataUnion FromICharacterLookAtPlayerData(ICharacterLookAtPlayerDataT _icharacterlookatplayerdata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtPlayerData,
				Value = _icharacterlookatplayerdata
			};
		}

		// Token: 0x060372D8 RID: 226008 RVA: 0x0077AD91 File Offset: 0x00778F91
		public ICharacterLookAtPositionDataT AsICharacterLookAtPositionData()
		{
			return this.As<ICharacterLookAtPositionDataT>();
		}

		// Token: 0x060372D9 RID: 226009 RVA: 0x0077AD99 File Offset: 0x00778F99
		public static TCharacterLookAtDataUnion FromICharacterLookAtPositionData(ICharacterLookAtPositionDataT _icharacterlookatpositiondata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtPositionData,
				Value = _icharacterlookatpositiondata
			};
		}

		// Token: 0x060372DA RID: 226010 RVA: 0x0077ADAE File Offset: 0x00778FAE
		public ICharacterLookAtUnlockDataT AsICharacterLookAtUnlockData()
		{
			return this.As<ICharacterLookAtUnlockDataT>();
		}

		// Token: 0x060372DB RID: 226011 RVA: 0x0077ADB6 File Offset: 0x00778FB6
		public static TCharacterLookAtDataUnion FromICharacterLookAtUnlockData(ICharacterLookAtUnlockDataT _icharacterlookatunlockdata)
		{
			return new TCharacterLookAtDataUnion
			{
				Type = TCharacterLookAtData.ICharacterLookAtUnlockData,
				Value = _icharacterlookatunlockdata
			};
		}

		// Token: 0x060372DC RID: 226012 RVA: 0x0077ADCC File Offset: 0x00778FCC
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
