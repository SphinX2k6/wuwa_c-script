using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063C5 RID: 25541
	public struct IDiscardForEnergyToEvolutionType : IFlatbufferObject
	{
		// Token: 0x1700BCB6 RID: 48310
		// (get) Token: 0x0602B5FA RID: 177658 RVA: 0x005E9244 File Offset: 0x005E7444
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B5FB RID: 177659 RVA: 0x005E9251 File Offset: 0x005E7451
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B5FC RID: 177660 RVA: 0x005E9258 File Offset: 0x005E7458
		public static IDiscardForEnergyToEvolutionType GetRootAsIDiscardForEnergyToEvolutionType(ByteBuffer _bb)
		{
			return IDiscardForEnergyToEvolutionType.GetRootAsIDiscardForEnergyToEvolutionType(_bb, default(IDiscardForEnergyToEvolutionType));
		}

		// Token: 0x0602B5FD RID: 177661 RVA: 0x005E9274 File Offset: 0x005E7474
		public static IDiscardForEnergyToEvolutionType GetRootAsIDiscardForEnergyToEvolutionType(ByteBuffer _bb, IDiscardForEnergyToEvolutionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B5FE RID: 177662 RVA: 0x005E9291 File Offset: 0x005E7491
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B5FF RID: 177663 RVA: 0x005E92A0 File Offset: 0x005E74A0
		public IDiscardForEnergyToEvolutionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCB7 RID: 48311
		// (get) Token: 0x0602B600 RID: 177664 RVA: 0x005E92B0 File Offset: 0x005E74B0
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

		// Token: 0x1700BCB8 RID: 48312
		// (get) Token: 0x0602B601 RID: 177665 RVA: 0x005E92EC File Offset: 0x005E74EC
		public TVarRef ReserveBoardCardType
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

		// Token: 0x0602B602 RID: 177666 RVA: 0x005E9328 File Offset: 0x005E7528
		public TTable? ReserveBoardCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B603 RID: 177667 RVA: 0x005E936C File Offset: 0x005E756C
		public IConstVarRef ReserveBoardCardAsIConstVarRef()
		{
			return this.ReserveBoardCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B604 RID: 177668 RVA: 0x005E9388 File Offset: 0x005E7588
		public IGlobalVarRef ReserveBoardCardAsIGlobalVarRef()
		{
			return this.ReserveBoardCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B605 RID: 177669 RVA: 0x005E93A4 File Offset: 0x005E75A4
		public IOtherVarRef ReserveBoardCardAsIOtherVarRef()
		{
			return this.ReserveBoardCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B606 RID: 177670 RVA: 0x005E93C0 File Offset: 0x005E75C0
		public ISelfVarRef ReserveBoardCardAsISelfVarRef()
		{
			return this.ReserveBoardCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B607 RID: 177671 RVA: 0x005E93DC File Offset: 0x005E75DC
		public ISystemVarRef ReserveBoardCardAsISystemVarRef()
		{
			return this.ReserveBoardCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700BCB9 RID: 48313
		// (get) Token: 0x0602B608 RID: 177672 RVA: 0x005E93F8 File Offset: 0x005E75F8
		public TVarRef ReserveHandCardType
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

		// Token: 0x0602B609 RID: 177673 RVA: 0x005E9438 File Offset: 0x005E7638
		public TTable? ReserveHandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B60A RID: 177674 RVA: 0x005E9480 File Offset: 0x005E7680
		public IConstVarRef ReserveHandCardAsIConstVarRef()
		{
			return this.ReserveHandCard<IConstVarRef>().Value;
		}

		// Token: 0x0602B60B RID: 177675 RVA: 0x005E949C File Offset: 0x005E769C
		public IGlobalVarRef ReserveHandCardAsIGlobalVarRef()
		{
			return this.ReserveHandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x0602B60C RID: 177676 RVA: 0x005E94B8 File Offset: 0x005E76B8
		public IOtherVarRef ReserveHandCardAsIOtherVarRef()
		{
			return this.ReserveHandCard<IOtherVarRef>().Value;
		}

		// Token: 0x0602B60D RID: 177677 RVA: 0x005E94D4 File Offset: 0x005E76D4
		public ISelfVarRef ReserveHandCardAsISelfVarRef()
		{
			return this.ReserveHandCard<ISelfVarRef>().Value;
		}

		// Token: 0x0602B60E RID: 177678 RVA: 0x005E94F0 File Offset: 0x005E76F0
		public ISystemVarRef ReserveHandCardAsISystemVarRef()
		{
			return this.ReserveHandCard<ISystemVarRef>().Value;
		}

		// Token: 0x0602B60F RID: 177679 RVA: 0x005E950B File Offset: 0x005E770B
		public static Offset<IDiscardForEnergyToEvolutionType> CreateIDiscardForEnergyToEvolutionType(FlatBufferBuilder builder, EGoalActType Type = EGoalActType.Deploy, TVarRef ReserveBoardCard_type = TVarRef.NONE, int ReserveBoardCardOffset = 0, TVarRef ReserveHandCard_type = TVarRef.NONE, int ReserveHandCardOffset = 0)
		{
			builder.StartTable(5);
			IDiscardForEnergyToEvolutionType.AddReserveHandCard(builder, ReserveHandCardOffset);
			IDiscardForEnergyToEvolutionType.AddReserveBoardCard(builder, ReserveBoardCardOffset);
			IDiscardForEnergyToEvolutionType.AddReserveHandCardType(builder, ReserveHandCard_type);
			IDiscardForEnergyToEvolutionType.AddReserveBoardCardType(builder, ReserveBoardCard_type);
			IDiscardForEnergyToEvolutionType.AddType(builder, Type);
			return IDiscardForEnergyToEvolutionType.EndIDiscardForEnergyToEvolutionType(builder);
		}

		// Token: 0x0602B610 RID: 177680 RVA: 0x005E953F File Offset: 0x005E773F
		public static void StartIDiscardForEnergyToEvolutionType(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B611 RID: 177681 RVA: 0x005E9548 File Offset: 0x005E7748
		public static void AddType(FlatBufferBuilder builder, EGoalActType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B612 RID: 177682 RVA: 0x005E9553 File Offset: 0x005E7753
		public static void AddReserveBoardCardType(FlatBufferBuilder builder, TVarRef reserveBoardCardType)
		{
			builder.AddByte(1, (byte)reserveBoardCardType, 0);
		}

		// Token: 0x0602B613 RID: 177683 RVA: 0x005E955E File Offset: 0x005E775E
		public static void AddReserveBoardCard(FlatBufferBuilder builder, int reserveBoardCardOffset)
		{
			builder.AddOffset(2, reserveBoardCardOffset, 0);
		}

		// Token: 0x0602B614 RID: 177684 RVA: 0x005E9569 File Offset: 0x005E7769
		public static void AddReserveHandCardType(FlatBufferBuilder builder, TVarRef reserveHandCardType)
		{
			builder.AddByte(3, (byte)reserveHandCardType, 0);
		}

		// Token: 0x0602B615 RID: 177685 RVA: 0x005E9574 File Offset: 0x005E7774
		public static void AddReserveHandCard(FlatBufferBuilder builder, int reserveHandCardOffset)
		{
			builder.AddOffset(4, reserveHandCardOffset, 0);
		}

		// Token: 0x0602B616 RID: 177686 RVA: 0x005E957F File Offset: 0x005E777F
		public static Offset<IDiscardForEnergyToEvolutionType> EndIDiscardForEnergyToEvolutionType(FlatBufferBuilder builder)
		{
			return new Offset<IDiscardForEnergyToEvolutionType>(builder.EndTable());
		}

		// Token: 0x0602B617 RID: 177687 RVA: 0x005E958C File Offset: 0x005E778C
		public IDiscardForEnergyToEvolutionTypeT UnPack()
		{
			IDiscardForEnergyToEvolutionTypeT discardForEnergyToEvolutionTypeT = new IDiscardForEnergyToEvolutionTypeT();
			this.UnPackTo(discardForEnergyToEvolutionTypeT);
			return discardForEnergyToEvolutionTypeT;
		}

		// Token: 0x0602B618 RID: 177688 RVA: 0x005E95A8 File Offset: 0x005E77A8
		public void UnPackTo(IDiscardForEnergyToEvolutionTypeT _o)
		{
			_o.Type = this.Type;
			_o.ReserveBoardCard = new TVarRefUnion();
			_o.ReserveBoardCard.Type = this.ReserveBoardCardType;
			switch (this.ReserveBoardCardType)
			{
			case TVarRef.IConstVarRef:
				_o.ReserveBoardCard.Value = ((this.ReserveBoardCard<IConstVarRef>() != null) ? this.ReserveBoardCard<IConstVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IGlobalVarRef:
				_o.ReserveBoardCard.Value = ((this.ReserveBoardCard<IGlobalVarRef>() != null) ? this.ReserveBoardCard<IGlobalVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.IOtherVarRef:
				_o.ReserveBoardCard.Value = ((this.ReserveBoardCard<IOtherVarRef>() != null) ? this.ReserveBoardCard<IOtherVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISelfVarRef:
				_o.ReserveBoardCard.Value = ((this.ReserveBoardCard<ISelfVarRef>() != null) ? this.ReserveBoardCard<ISelfVarRef>().Value.UnPack() : null);
				break;
			case TVarRef.ISystemVarRef:
				_o.ReserveBoardCard.Value = ((this.ReserveBoardCard<ISystemVarRef>() != null) ? this.ReserveBoardCard<ISystemVarRef>().Value.UnPack() : null);
				break;
			}
			_o.ReserveHandCard = new TVarRefUnion();
			_o.ReserveHandCard.Type = this.ReserveHandCardType;
			switch (this.ReserveHandCardType)
			{
			case TVarRef.IConstVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<IConstVarRef>() != null) ? this.ReserveHandCard<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<IGlobalVarRef>() != null) ? this.ReserveHandCard<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<IOtherVarRef>() != null) ? this.ReserveHandCard<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<ISelfVarRef>() != null) ? this.ReserveHandCard<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.ReserveHandCard.Value = ((this.ReserveHandCard<ISystemVarRef>() != null) ? this.ReserveHandCard<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602B619 RID: 177689 RVA: 0x005E9874 File Offset: 0x005E7A74
		public static Offset<IDiscardForEnergyToEvolutionType> Pack(FlatBufferBuilder builder, IDiscardForEnergyToEvolutionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDiscardForEnergyToEvolutionType>);
			}
			TVarRef reserveBoardCard_type = (_o.ReserveBoardCard == null) ? TVarRef.NONE : _o.ReserveBoardCard.Type;
			int reserveBoardCardOffset = (_o.ReserveBoardCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReserveBoardCard);
			TVarRef reserveHandCard_type = (_o.ReserveHandCard == null) ? TVarRef.NONE : _o.ReserveHandCard.Type;
			int reserveHandCardOffset = (_o.ReserveHandCard == null) ? 0 : TVarRefUnion.Pack(builder, _o.ReserveHandCard);
			return IDiscardForEnergyToEvolutionType.CreateIDiscardForEnergyToEvolutionType(builder, _o.Type, reserveBoardCard_type, reserveBoardCardOffset, reserveHandCard_type, reserveHandCardOffset);
		}

		// Token: 0x040104B3 RID: 66739
		private Table __p;
	}
}
