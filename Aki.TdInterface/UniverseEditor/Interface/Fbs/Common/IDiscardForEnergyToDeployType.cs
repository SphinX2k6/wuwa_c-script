using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063C2 RID: 25538
	public struct IDiscardForEnergyToDeployType : IFlatbufferObject
	{
		// Token: 0x1700BCAF RID: 48303
		// (get) Token: 0x0602B5D2 RID: 177618 RVA: 0x005E8A96 File Offset: 0x005E6C96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B5D3 RID: 177619 RVA: 0x005E8AA3 File Offset: 0x005E6CA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B5D4 RID: 177620 RVA: 0x005E8AAC File Offset: 0x005E6CAC
		public static IDiscardForEnergyToDeployType GetRootAsIDiscardForEnergyToDeployType(ByteBuffer _bb)
		{
			return IDiscardForEnergyToDeployType.GetRootAsIDiscardForEnergyToDeployType(_bb, default(IDiscardForEnergyToDeployType));
		}

		// Token: 0x0602B5D5 RID: 177621 RVA: 0x005E8AC8 File Offset: 0x005E6CC8
		public static IDiscardForEnergyToDeployType GetRootAsIDiscardForEnergyToDeployType(ByteBuffer _bb, IDiscardForEnergyToDeployType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B5D6 RID: 177622 RVA: 0x005E8AE5 File Offset: 0x005E6CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B5D7 RID: 177623 RVA: 0x005E8AF4 File Offset: 0x005E6CF4
		public IDiscardForEnergyToDeployType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCB0 RID: 48304
		// (get) Token: 0x0602B5D8 RID: 177624 RVA: 0x005E8B04 File Offset: 0x005E6D04
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

		// Token: 0x1700BCB1 RID: 48305
		// (get) Token: 0x0602B5D9 RID: 177625 RVA: 0x005E8B40 File Offset: 0x005E6D40
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

		// Token: 0x0602B5DA RID: 177626 RVA: 0x005E8B7C File Offset: 0x005E6D7C
		public TTable? ReserveHandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B5DB RID: 177627 RVA: 0x005E8BC0 File Offset: 0x005E6DC0
		public IConstVarRef ReserveHandCardAsIConstVarRef()
		{
			return this.ReserveHandCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B5DC RID: 177628 RVA: 0x005E8BDC File Offset: 0x005E6DDC
		public IGlobalVarRef ReserveHandCardAsIGlobalVarRef()
		{
			return this.ReserveHandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B5DD RID: 177629 RVA: 0x005E8BF8 File Offset: 0x005E6DF8
		public IOtherVarRef ReserveHandCardAsIOtherVarRef()
		{
			return this.ReserveHandCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B5DE RID: 177630 RVA: 0x005E8C14 File Offset: 0x005E6E14
		public ISelfVarRef ReserveHandCardAsISelfVarRef()
		{
			return this.ReserveHandCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B5DF RID: 177631 RVA: 0x005E8C30 File Offset: 0x005E6E30
		public ISystemVarRef ReserveHandCardAsISystemVarRef()
		{
			return this.ReserveHandCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700BCB2 RID: 48306
		// (get) Token: 0x0602B5E0 RID: 177632 RVA: 0x005E8C4C File Offset: 0x005E6E4C
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

		// Token: 0x0602B5E1 RID: 177633 RVA: 0x005E8C8C File Offset: 0x005E6E8C
		public TTable? BoardPos<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B5E2 RID: 177634 RVA: 0x005E8CD4 File Offset: 0x005E6ED4
		public IConstVarRef BoardPosAsIConstVarRef()
		{
			return this.BoardPos<IConstVarRef>().Value;
		}

		// Token: 0x0602B5E3 RID: 177635 RVA: 0x005E8CF0 File Offset: 0x005E6EF0
		public IGlobalVarRef BoardPosAsIGlobalVarRef()
		{
			return this.BoardPos<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B5E4 RID: 177636 RVA: 0x005E8D0C File Offset: 0x005E6F0C
		public IOtherVarRef BoardPosAsIOtherVarRef()
		{
			return this.BoardPos<IOtherVarRef>().Value;
		}

		// Token: 0x0602B5E5 RID: 177637 RVA: 0x005E8D28 File Offset: 0x005E6F28
		public ISelfVarRef BoardPosAsISelfVarRef()
		{
			return this.BoardPos<ISelfVarRef>().Value;
		}

		// Token: 0x0602B5E6 RID: 177638 RVA: 0x005E8D44 File Offset: 0x005E6F44
		public ISystemVarRef BoardPosAsISystemVarRef()
		{
			return this.BoardPos<ISystemVarRef>().Value;
		}

		// Token: 0x0602B5E7 RID: 177639 RVA: 0x005E8D5F File Offset: 0x005E6F5F
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

		// Token: 0x0602B5E8 RID: 177640 RVA: 0x005E8D93 File Offset: 0x005E6F93
		public static void StartIDiscardForEnergyToDeployType(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B5E9 RID: 177641 RVA: 0x005E8D9C File Offset: 0x005E6F9C
		public static void AddType(FlatBufferBuilder builder, EGoalActType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B5EA RID: 177642 RVA: 0x005E8DA7 File Offset: 0x005E6FA7
		public static void AddReserveHandCardType(FlatBufferBuilder builder, TVarRef reserveHandCardType)
		{
			builder.AddByte(1, (byte)reserveHandCardType, 0);
		}

		// Token: 0x0602B5EB RID: 177643 RVA: 0x005E8DB2 File Offset: 0x005E6FB2
		public static void AddReserveHandCard(FlatBufferBuilder builder, int reserveHandCardOffset)
		{
			builder.AddOffset(2, reserveHandCardOffset, 0);
		}

		// Token: 0x0602B5EC RID: 177644 RVA: 0x005E8DBD File Offset: 0x005E6FBD
		public static void AddBoardPosType(FlatBufferBuilder builder, TVarRef boardPosType)
		{
			builder.AddByte(3, (byte)boardPosType, 0);
		}

		// Token: 0x0602B5ED RID: 177645 RVA: 0x005E8DC8 File Offset: 0x005E6FC8
		public static void AddBoardPos(FlatBufferBuilder builder, int boardPosOffset)
		{
			builder.AddOffset(4, boardPosOffset, 0);
		}

		// Token: 0x0602B5EE RID: 177646 RVA: 0x005E8DD3 File Offset: 0x005E6FD3
		public static Offset<IDiscardForEnergyToDeployType> EndIDiscardForEnergyToDeployType(FlatBufferBuilder builder)
		{
			return new Offset<IDiscardForEnergyToDeployType>(builder.EndTable());
		}

		// Token: 0x0602B5EF RID: 177647 RVA: 0x005E8DE0 File Offset: 0x005E6FE0
		public IDiscardForEnergyToDeployTypeT UnPack()
		{
			IDiscardForEnergyToDeployTypeT discardForEnergyToDeployTypeT = new IDiscardForEnergyToDeployTypeT();
			this.UnPackTo(discardForEnergyToDeployTypeT);
			return discardForEnergyToDeployTypeT;
		}

		// Token: 0x0602B5F0 RID: 177648 RVA: 0x005E8DFC File Offset: 0x005E6FFC
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

		// Token: 0x0602B5F1 RID: 177649 RVA: 0x005E90C8 File Offset: 0x005E72C8
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

		// Token: 0x040104AF RID: 66735
		private Table __p;
	}
}
