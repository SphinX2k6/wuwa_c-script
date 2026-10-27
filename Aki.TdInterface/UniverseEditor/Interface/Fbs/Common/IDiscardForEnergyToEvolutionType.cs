using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D88 RID: 23944
	public struct IDiscardForEnergyToEvolutionType : IFlatbufferObject
	{
		// Token: 0x1700B350 RID: 45904
		// (get) Token: 0x06028F70 RID: 167792 RVA: 0x005A0514 File Offset: 0x0059E714
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028F71 RID: 167793 RVA: 0x005A0521 File Offset: 0x0059E721
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028F72 RID: 167794 RVA: 0x005A0528 File Offset: 0x0059E728
		public static IDiscardForEnergyToEvolutionType GetRootAsIDiscardForEnergyToEvolutionType(ByteBuffer _bb)
		{
			return IDiscardForEnergyToEvolutionType.GetRootAsIDiscardForEnergyToEvolutionType(_bb, default(IDiscardForEnergyToEvolutionType));
		}

		// Token: 0x06028F73 RID: 167795 RVA: 0x005A0544 File Offset: 0x0059E744
		public static IDiscardForEnergyToEvolutionType GetRootAsIDiscardForEnergyToEvolutionType(ByteBuffer _bb, IDiscardForEnergyToEvolutionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028F74 RID: 167796 RVA: 0x005A0561 File Offset: 0x0059E761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028F75 RID: 167797 RVA: 0x005A0570 File Offset: 0x0059E770
		public IDiscardForEnergyToEvolutionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B351 RID: 45905
		// (get) Token: 0x06028F76 RID: 167798 RVA: 0x005A0580 File Offset: 0x0059E780
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

		// Token: 0x1700B352 RID: 45906
		// (get) Token: 0x06028F77 RID: 167799 RVA: 0x005A05BC File Offset: 0x0059E7BC
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

		// Token: 0x06028F78 RID: 167800 RVA: 0x005A05F8 File Offset: 0x0059E7F8
		public TTable? ReserveBoardCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028F79 RID: 167801 RVA: 0x005A063C File Offset: 0x0059E83C
		public IConstVarRef ReserveBoardCardAsIConstVarRef()
		{
			return this.ReserveBoardCard<IConstVarRef>().Value;
		}

		// Token: 0x06028F7A RID: 167802 RVA: 0x005A0658 File Offset: 0x0059E858
		public IGlobalVarRef ReserveBoardCardAsIGlobalVarRef()
		{
			return this.ReserveBoardCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028F7B RID: 167803 RVA: 0x005A0674 File Offset: 0x0059E874
		public IOtherVarRef ReserveBoardCardAsIOtherVarRef()
		{
			return this.ReserveBoardCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028F7C RID: 167804 RVA: 0x005A0690 File Offset: 0x0059E890
		public ISelfVarRef ReserveBoardCardAsISelfVarRef()
		{
			return this.ReserveBoardCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028F7D RID: 167805 RVA: 0x005A06AC File Offset: 0x0059E8AC
		public ISystemVarRef ReserveBoardCardAsISystemVarRef()
		{
			return this.ReserveBoardCard<ISystemVarRef>().Value;
		}

		// Token: 0x1700B353 RID: 45907
		// (get) Token: 0x06028F7E RID: 167806 RVA: 0x005A06C8 File Offset: 0x0059E8C8
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

		// Token: 0x06028F7F RID: 167807 RVA: 0x005A0708 File Offset: 0x0059E908
		public TTable? ReserveHandCard<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028F80 RID: 167808 RVA: 0x005A0750 File Offset: 0x0059E950
		public IConstVarRef ReserveHandCardAsIConstVarRef()
		{
			return this.ReserveHandCard<IConstVarRef>().Value;
		}

		// Token: 0x06028F81 RID: 167809 RVA: 0x005A076C File Offset: 0x0059E96C
		public IGlobalVarRef ReserveHandCardAsIGlobalVarRef()
		{
			return this.ReserveHandCard<IGlobalVarRef>().Value;
		}

		// Token: 0x06028F82 RID: 167810 RVA: 0x005A0788 File Offset: 0x0059E988
		public IOtherVarRef ReserveHandCardAsIOtherVarRef()
		{
			return this.ReserveHandCard<IOtherVarRef>().Value;
		}

		// Token: 0x06028F83 RID: 167811 RVA: 0x005A07A4 File Offset: 0x0059E9A4
		public ISelfVarRef ReserveHandCardAsISelfVarRef()
		{
			return this.ReserveHandCard<ISelfVarRef>().Value;
		}

		// Token: 0x06028F84 RID: 167812 RVA: 0x005A07C0 File Offset: 0x0059E9C0
		public ISystemVarRef ReserveHandCardAsISystemVarRef()
		{
			return this.ReserveHandCard<ISystemVarRef>().Value;
		}

		// Token: 0x06028F85 RID: 167813 RVA: 0x005A07DB File Offset: 0x0059E9DB
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

		// Token: 0x06028F86 RID: 167814 RVA: 0x005A080F File Offset: 0x0059EA0F
		public static void StartIDiscardForEnergyToEvolutionType(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06028F87 RID: 167815 RVA: 0x005A0818 File Offset: 0x0059EA18
		public static void AddType(FlatBufferBuilder builder, EGoalActType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028F88 RID: 167816 RVA: 0x005A0823 File Offset: 0x0059EA23
		public static void AddReserveBoardCardType(FlatBufferBuilder builder, TVarRef reserveBoardCardType)
		{
			builder.AddByte(1, (byte)reserveBoardCardType, 0);
		}

		// Token: 0x06028F89 RID: 167817 RVA: 0x005A082E File Offset: 0x0059EA2E
		public static void AddReserveBoardCard(FlatBufferBuilder builder, int reserveBoardCardOffset)
		{
			builder.AddOffset(2, reserveBoardCardOffset, 0);
		}

		// Token: 0x06028F8A RID: 167818 RVA: 0x005A0839 File Offset: 0x0059EA39
		public static void AddReserveHandCardType(FlatBufferBuilder builder, TVarRef reserveHandCardType)
		{
			builder.AddByte(3, (byte)reserveHandCardType, 0);
		}

		// Token: 0x06028F8B RID: 167819 RVA: 0x005A0844 File Offset: 0x0059EA44
		public static void AddReserveHandCard(FlatBufferBuilder builder, int reserveHandCardOffset)
		{
			builder.AddOffset(4, reserveHandCardOffset, 0);
		}

		// Token: 0x06028F8C RID: 167820 RVA: 0x005A084F File Offset: 0x0059EA4F
		public static Offset<IDiscardForEnergyToEvolutionType> EndIDiscardForEnergyToEvolutionType(FlatBufferBuilder builder)
		{
			return new Offset<IDiscardForEnergyToEvolutionType>(builder.EndTable());
		}

		// Token: 0x06028F8D RID: 167821 RVA: 0x005A085C File Offset: 0x0059EA5C
		public IDiscardForEnergyToEvolutionTypeT UnPack()
		{
			IDiscardForEnergyToEvolutionTypeT discardForEnergyToEvolutionTypeT = new IDiscardForEnergyToEvolutionTypeT();
			this.UnPackTo(discardForEnergyToEvolutionTypeT);
			return discardForEnergyToEvolutionTypeT;
		}

		// Token: 0x06028F8E RID: 167822 RVA: 0x005A0878 File Offset: 0x0059EA78
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

		// Token: 0x06028F8F RID: 167823 RVA: 0x005A0B44 File Offset: 0x0059ED44
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

		// Token: 0x0400F758 RID: 63320
		private Table __p;
	}
}
