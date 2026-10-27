using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D85 RID: 23941
	public struct IDiscardForEnergyToDeployType : IFlatbufferObject
	{
		// Token: 0x1700B349 RID: 45897
		// (get) Token: 0x06028F48 RID: 167752 RVA: 0x0059FD66 File Offset: 0x0059DF66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028F49 RID: 167753 RVA: 0x0059FD73 File Offset: 0x0059DF73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028F4A RID: 167754 RVA: 0x0059FD7C File Offset: 0x0059DF7C
		public static IDiscardForEnergyToDeployType GetRootAsIDiscardForEnergyToDeployType(ByteBuffer _bb)
		{
			return IDiscardForEnergyToDeployType.GetRootAsIDiscardForEnergyToDeployType(_bb, default(IDiscardForEnergyToDeployType));
		}

		// Token: 0x06028F4B RID: 167755 RVA: 0x0059FD98 File Offset: 0x0059DF98
		public static IDiscardForEnergyToDeployType GetRootAsIDiscardForEnergyToDeployType(ByteBuffer _bb, IDiscardForEnergyToDeployType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028F4C RID: 167756 RVA: 0x0059FDB5 File Offset: 0x0059DFB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028F4D RID: 167757 RVA: 0x0059FDC4 File Offset: 0x0059DFC4
		public IDiscardForEnergyToDeployType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B34A RID: 45898
		// (get) Token: 0x06028F4E RID: 167758 RVA: 0x0059FDD4 File Offset: 0x0059DFD4
		public EGoalActType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGoalActType.Deploy;
				}
				return (EGoalActType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B34B RID: 45899
		// (get) Token: 0x06028F4F RID: 167759 RVA: 0x0059FE10 File Offset: 0x0059E010
		public TVarRef ReserveHandCardType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028F50 RID: 167760 RVA: 0x0059FE4C File Offset: 0x0059E04C
		public TTable? ReserveHandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028F51 RID: 167761 RVA: 0x0059FE90 File Offset: 0x0059E090
		public IConstVarRef ReserveHandCardAsIConstVarRef()
		{
			return this.ReserveHandCard<IConstVarRef>().Value;
		}

		// Token: 0x06028F52 RID: 167762 RVA: 0x0059FEAC File Offset: 0x0059E0AC
		public IGlobalVarRef ReserveHandCardAsIGlobalVarRef()
		{
			return this.ReserveHandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028F53 RID: 167763 RVA: 0x0059FEC8 File Offset: 0x0059E0C8
		public IOtherVarRef ReserveHandCardAsIOtherVarRef()
		{
			return this.ReserveHandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028F54 RID: 167764 RVA: 0x0059FEE4 File Offset: 0x0059E0E4
		public ISelfVarRef ReserveHandCardAsISelfVarRef()
		{
			return this.ReserveHandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028F55 RID: 167765 RVA: 0x0059FF00 File Offset: 0x0059E100
		public ISystemVarRef ReserveHandCardAsISystemVarRef()
		{
			return this.ReserveHandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700B34C RID: 45900
		// (get) Token: 0x06028F56 RID: 167766 RVA: 0x0059FF1C File Offset: 0x0059E11C
		public TVarRef BoardPosType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVarRef.NONE;
				}
				return (TVarRef)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028F57 RID: 167767 RVA: 0x0059FF5C File Offset: 0x0059E15C
		public TTable? BoardPos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028F58 RID: 167768 RVA: 0x0059FFA4 File Offset: 0x0059E1A4
		public IConstVarRef BoardPosAsIConstVarRef()
		{
			return this.BoardPos<IConstVarRef>().Value;
		}

		// Token: 0x06028F59 RID: 167769 RVA: 0x0059FFC0 File Offset: 0x0059E1C0
		public IGlobalVarRef BoardPosAsIGlobalVarRef()
		{
			return this.BoardPos<IGlobalVarRef>().Value;
		}

		// Token: 0x06028F5A RID: 167770 RVA: 0x0059FFDC File Offset: 0x0059E1DC
		public IOtherVarRef BoardPosAsIOtherVarRef()
		{
			return this.BoardPos<IOtherVarRef>().Value;
		}

		// Token: 0x06028F5B RID: 167771 RVA: 0x0059FFF8 File Offset: 0x0059E1F8
		public ISelfVarRef BoardPosAsISelfVarRef()
		{
			return this.BoardPos<ISelfVarRef>().Value;
		}

		// Token: 0x06028F5C RID: 167772 RVA: 0x005A0014 File Offset: 0x0059E214
		public ISystemVarRef BoardPosAsISystemVarRef()
		{
			return this.BoardPos<ISystemVarRef>().Value;
		}

		// Token: 0x06028F5D RID: 167773 RVA: 0x005A002F File Offset: 0x0059E22F
		public static Offset<IDiscardForEnergyToDeployType> CreateIDiscardForEnergyToDeployType(FlatBufferBuilder builder, EGoalActType Type = EGoalActType.Deploy, TVarRef ReserveHandCard_type = TVarRef.NONE, int ReserveHandCardOffset = 0, TVarRef BoardPos_type = TVarRef.NONE, int BoardPosOffset = 0)
		{
			builder.StartTable(5);
			IDiscardForEnergyToDeployType.AddBoardPos(builder, BoardPosOffset);
			IDiscardForEnergyToDeployType.AddReserveHandCard(builder, ReserveHandCardOffset);
			IDiscardForEnergyToDeployType.AddBoardPosType(builder, BoardPos_type);
			IDiscardForEnergyToDeployType.AddReserveHandCardType(builder, ReserveHandCard_type);
			IDiscardForEnergyToDeployType.AddType(builder, Type);
			return IDiscardForEnergyToDeployType.EndIDiscardForEnergyToDeployType(builder);
		}

		// Token: 0x06028F5E RID: 167774 RVA: 0x005A0063 File Offset: 0x0059E263
		public static void StartIDiscardForEnergyToDeployType(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028F5F RID: 167775 RVA: 0x005A006C File Offset: 0x0059E26C
		public static void AddType(FlatBufferBuilder builder, EGoalActType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028F60 RID: 167776 RVA: 0x005A0077 File Offset: 0x0059E277
		public static void AddReserveHandCardType(FlatBufferBuilder builder, TVarRef reserveHandCardType)
		{
			builder.AddByte(1, (byte)reserveHandCardType, 0);
		}

		// Token: 0x06028F61 RID: 167777 RVA: 0x005A0082 File Offset: 0x0059E282
		public static void AddReserveHandCard(FlatBufferBuilder builder, int reserveHandCardOffset)
		{
			builder.AddOffset(2, reserveHandCardOffset, 0);
		}

		// Token: 0x06028F62 RID: 167778 RVA: 0x005A008D File Offset: 0x0059E28D
		public static void AddBoardPosType(FlatBufferBuilder builder, TVarRef boardPosType)
		{
			builder.AddByte(3, (byte)boardPosType, 0);
		}

		// Token: 0x06028F63 RID: 167779 RVA: 0x005A0098 File Offset: 0x0059E298
		public static void AddBoardPos(FlatBufferBuilder builder, int boardPosOffset)
		{
			builder.AddOffset(4, boardPosOffset, 0);
		}

		// Token: 0x06028F64 RID: 167780 RVA: 0x005A00A3 File Offset: 0x0059E2A3
		public static Offset<IDiscardForEnergyToDeployType> EndIDiscardForEnergyToDeployType(FlatBufferBuilder builder)
		{
			return new Offset<IDiscardForEnergyToDeployType>(builder.EndTable());
		}

		// Token: 0x06028F65 RID: 167781 RVA: 0x005A00B0 File Offset: 0x0059E2B0
		public IDiscardForEnergyToDeployTypeT UnPack()
		{
			IDiscardForEnergyToDeployTypeT discardForEnergyToDeployTypeT = new IDiscardForEnergyToDeployTypeT();
			this.UnPackTo(discardForEnergyToDeployTypeT);
			return discardForEnergyToDeployTypeT;
		}

		// Token: 0x06028F66 RID: 167782 RVA: 0x005A00CC File Offset: 0x0059E2CC
		public void UnPackTo(IDiscardForEnergyToDeployTypeT _o)
		{
			_o.Type = this.Type;
			_o.ReserveHandCard = new TVarRefUnion();
			_o.ReserveHandCard.Type = this.ReserveHandCardType;
			switch (this.ReserveHandCardType)
			{
			case TVarRef.IConstVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<IConstVarRef>() != null) ? this.ReserveHandCard<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<IGlobalVarRef>() != null) ? this.ReserveHandCard<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<IOtherVarRef>() != null) ? this.ReserveHandCard<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<ISelfVarRef>() != null) ? this.ReserveHandCard<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<ISystemVarRef>() != null) ? this.ReserveHandCard<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.BoardPos = new TVarRefUnion();
			_o.BoardPos.Type = this.BoardPosType;
			switch (this.BoardPosType)
			{
			case TVarRef.IConstVarRef:
				_o.BoardPos.Value = ((this.BoardPos<IConstVarRef>() != null) ? this.BoardPos<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.BoardPos.Value = ((this.BoardPos<IGlobalVarRef>() != null) ? this.BoardPos<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.BoardPos.Value = ((this.BoardPos<IOtherVarRef>() != null) ? this.BoardPos<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.BoardPos.Value = ((this.BoardPos<ISelfVarRef>() != null) ? this.BoardPos<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.BoardPos.Value = ((this.BoardPos<ISystemVarRef>() != null) ? this.BoardPos<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06028F67 RID: 167783 RVA: 0x005A0398 File Offset: 0x0059E598
		public static Offset<IDiscardForEnergyToDeployType> Pack(FlatBufferBuilder builder, IDiscardForEnergyToDeployTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDiscardForEnergyToDeployType>);
			}
			TVarRef reserveHandCard_type = (_o.ReserveHandCard == null) ? TVarRef.NONE : _o.ReserveHandCard.Type;
			int reserveHandCardOffset = (_o.ReserveHandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReserveHandCard);
			TVarRef boardPos_type = (_o.BoardPos == null) ? TVarRef.NONE : _o.BoardPos.Type;
			int boardPosOffset = (_o.BoardPos == null) ? 0 : TVarRefUnion.Pack(builder, _o.BoardPos);
			return IDiscardForEnergyToDeployType.CreateIDiscardForEnergyToDeployType(builder, _o.Type, reserveHandCard_type, reserveHandCardOffset, boardPos_type, boardPosOffset);
		}

		// Token: 0x0400F754 RID: 63316
		private Table __p;
	}
}
