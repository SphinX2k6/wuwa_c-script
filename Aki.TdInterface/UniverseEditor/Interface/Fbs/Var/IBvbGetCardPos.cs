using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E3B RID: 15931
	public struct IBvbGetCardPos : IFlatbufferObject
	{
		// Token: 0x17006BA0 RID: 27552
		// (get) Token: 0x0601572C RID: 87852 RVA: 0x00318A1C File Offset: 0x00316C1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601572D RID: 87853 RVA: 0x00318A29 File Offset: 0x00316C29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601572E RID: 87854 RVA: 0x00318A30 File Offset: 0x00316C30
		public static IBvbGetCardPos GetRootAsIBvbGetCardPos(ByteBuffer _bb)
		{
			return IBvbGetCardPos.GetRootAsIBvbGetCardPos(_bb, default(IBvbGetCardPos));
		}

		// Token: 0x0601572F RID: 87855 RVA: 0x00318A4C File Offset: 0x00316C4C
		public static IBvbGetCardPos GetRootAsIBvbGetCardPos(ByteBuffer _bb, IBvbGetCardPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015730 RID: 87856 RVA: 0x00318A69 File Offset: 0x00316C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015731 RID: 87857 RVA: 0x00318A78 File Offset: 0x00316C78
		public IBvbGetCardPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BA1 RID: 27553
		// (get) Token: 0x06015732 RID: 87858 RVA: 0x00318A88 File Offset: 0x00316C88
		public ESystemVarName Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemVarName.CommonHotFixVar;
				}
				return (ESystemVarName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BA2 RID: 27554
		// (get) Token: 0x06015733 RID: 87859 RVA: 0x00318AC4 File Offset: 0x00316CC4
		public TVarRef CardType
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

		// Token: 0x06015734 RID: 87860 RVA: 0x00318B00 File Offset: 0x00316D00
		public TTable? Card<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015735 RID: 87861 RVA: 0x00318B44 File Offset: 0x00316D44
		public IConstVarRef CardAsIConstVarRef()
		{
			return this.Card<IConstVarRef>().Value;
		}

		// Token: 0x06015736 RID: 87862 RVA: 0x00318B60 File Offset: 0x00316D60
		public IGlobalVarRef CardAsIGlobalVarRef()
		{
			return this.Card<IGlobalVarRef>().Value;
		}

		// Token: 0x06015737 RID: 87863 RVA: 0x00318B7C File Offset: 0x00316D7C
		public IOtherVarRef CardAsIOtherVarRef()
		{
			return this.Card<IOtherVarRef>().Value;
		}

		// Token: 0x06015738 RID: 87864 RVA: 0x00318B98 File Offset: 0x00316D98
		public ISelfVarRef CardAsISelfVarRef()
		{
			return this.Card<ISelfVarRef>().Value;
		}

		// Token: 0x06015739 RID: 87865 RVA: 0x00318BB4 File Offset: 0x00316DB4
		public ISystemVarRef CardAsISystemVarRef()
		{
			return this.Card<ISystemVarRef>().Value;
		}

		// Token: 0x0601573A RID: 87866 RVA: 0x00318BCF File Offset: 0x00316DCF
		public static Offset<IBvbGetCardPos> CreateIBvbGetCardPos(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, TVarRef Card_type = TVarRef.NONE, int CardOffset = 0)
		{
			builder.StartTable(3);
			IBvbGetCardPos.AddCard(builder, CardOffset);
			IBvbGetCardPos.AddCardType(builder, Card_type);
			IBvbGetCardPos.AddType(builder, Type);
			return IBvbGetCardPos.EndIBvbGetCardPos(builder);
		}

		// Token: 0x0601573B RID: 87867 RVA: 0x00318BF3 File Offset: 0x00316DF3
		public static void StartIBvbGetCardPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601573C RID: 87868 RVA: 0x00318BFC File Offset: 0x00316DFC
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601573D RID: 87869 RVA: 0x00318C07 File Offset: 0x00316E07
		public static void AddCardType(FlatBufferBuilder builder, TVarRef cardType)
		{
			builder.AddByte(1, (byte)cardType, 0);
		}

		// Token: 0x0601573E RID: 87870 RVA: 0x00318C12 File Offset: 0x00316E12
		public static void AddCard(FlatBufferBuilder builder, int cardOffset)
		{
			builder.AddOffset(2, cardOffset, 0);
		}

		// Token: 0x0601573F RID: 87871 RVA: 0x00318C1D File Offset: 0x00316E1D
		public static Offset<IBvbGetCardPos> EndIBvbGetCardPos(FlatBufferBuilder builder)
		{
			return new Offset<IBvbGetCardPos>(builder.EndTable());
		}

		// Token: 0x06015740 RID: 87872 RVA: 0x00318C2C File Offset: 0x00316E2C
		public IBvbGetCardPosT UnPack()
		{
			IBvbGetCardPosT bvbGetCardPosT = new IBvbGetCardPosT();
			this.UnPackTo(bvbGetCardPosT);
			return bvbGetCardPosT;
		}

		// Token: 0x06015741 RID: 87873 RVA: 0x00318C48 File Offset: 0x00316E48
		public void UnPackTo(IBvbGetCardPosT _o)
		{
			_o.Type = this.Type;
			_o.Card = new TVarRefUnion();
			_o.Card.Type = this.CardType;
			switch (this.CardType)
			{
			case TVarRef.IConstVarRef:
				_o.Card.Value = ((this.Card<IConstVarRef>() != null) ? this.Card<IConstVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IGlobalVarRef:
				_o.Card.Value = ((this.Card<IGlobalVarRef>() != null) ? this.Card<IGlobalVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.IOtherVarRef:
				_o.Card.Value = ((this.Card<IOtherVarRef>() != null) ? this.Card<IOtherVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISelfVarRef:
				_o.Card.Value = ((this.Card<ISelfVarRef>() != null) ? this.Card<ISelfVarRef>().Value.UnPack() : null);
				return;
			case TVarRef.ISystemVarRef:
				_o.Card.Value = ((this.Card<ISystemVarRef>() != null) ? this.Card<ISystemVarRef>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06015742 RID: 87874 RVA: 0x00318DB4 File Offset: 0x00316FB4
		public static Offset<IBvbGetCardPos> Pack(FlatBufferBuilder builder, IBvbGetCardPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbGetCardPos>);
			}
			TVarRef card_type = (_o.Card == null) ? TVarRef.NONE : _o.Card.Type;
			int cardOffset = (_o.Card == null) ? 0 : TVarRefUnion.Pack(builder, _o.Card);
			return IBvbGetCardPos.CreateIBvbGetCardPos(builder, _o.Type, card_type, cardOffset);
		}

		// Token: 0x0400B807 RID: 47111
		private Table __p;
	}
}
