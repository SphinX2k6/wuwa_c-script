using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E38 RID: 15928
	public struct IBvbGetCardEvolvedUse : IFlatbufferObject
	{
		// Token: 0x17006B9B RID: 27547
		// (get) Token: 0x0601570F RID: 87823 RVA: 0x00318590 File Offset: 0x00316790
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015710 RID: 87824 RVA: 0x0031859D File Offset: 0x0031679D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015711 RID: 87825 RVA: 0x003185A4 File Offset: 0x003167A4
		public static IBvbGetCardEvolvedUse GetRootAsIBvbGetCardEvolvedUse(ByteBuffer _bb)
		{
			return IBvbGetCardEvolvedUse.GetRootAsIBvbGetCardEvolvedUse(_bb, default(IBvbGetCardEvolvedUse));
		}

		// Token: 0x06015712 RID: 87826 RVA: 0x003185C0 File Offset: 0x003167C0
		public static IBvbGetCardEvolvedUse GetRootAsIBvbGetCardEvolvedUse(ByteBuffer _bb, IBvbGetCardEvolvedUse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015713 RID: 87827 RVA: 0x003185DD File Offset: 0x003167DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015714 RID: 87828 RVA: 0x003185EC File Offset: 0x003167EC
		public IBvbGetCardEvolvedUse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B9C RID: 27548
		// (get) Token: 0x06015715 RID: 87829 RVA: 0x003185FC File Offset: 0x003167FC
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

		// Token: 0x17006B9D RID: 27549
		// (get) Token: 0x06015716 RID: 87830 RVA: 0x00318638 File Offset: 0x00316838
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

		// Token: 0x06015717 RID: 87831 RVA: 0x00318674 File Offset: 0x00316874
		public TTable? Card<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015718 RID: 87832 RVA: 0x003186B8 File Offset: 0x003168B8
		public IConstVarRef CardAsIConstVarRef()
		{
			return this.Card<IConstVarRef>().Value;
		}

		// Token: 0x06015719 RID: 87833 RVA: 0x003186D4 File Offset: 0x003168D4
		public IGlobalVarRef CardAsIGlobalVarRef()
		{
			return this.Card<IGlobalVarRef>().Value;
		}

		// Token: 0x0601571A RID: 87834 RVA: 0x003186F0 File Offset: 0x003168F0
		public IOtherVarRef CardAsIOtherVarRef()
		{
			return this.Card<IOtherVarRef>().Value;
		}

		// Token: 0x0601571B RID: 87835 RVA: 0x0031870C File Offset: 0x0031690C
		public ISelfVarRef CardAsISelfVarRef()
		{
			return this.Card<ISelfVarRef>().Value;
		}

		// Token: 0x0601571C RID: 87836 RVA: 0x00318728 File Offset: 0x00316928
		public ISystemVarRef CardAsISystemVarRef()
		{
			return this.Card<ISystemVarRef>().Value;
		}

		// Token: 0x0601571D RID: 87837 RVA: 0x00318743 File Offset: 0x00316943
		public static Offset<IBvbGetCardEvolvedUse> CreateIBvbGetCardEvolvedUse(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, TVarRef Card_type = TVarRef.NONE, int CardOffset = 0)
		{
			builder.StartTable(3);
			IBvbGetCardEvolvedUse.AddCard(builder, CardOffset);
			IBvbGetCardEvolvedUse.AddCardType(builder, Card_type);
			IBvbGetCardEvolvedUse.AddType(builder, Type);
			return IBvbGetCardEvolvedUse.EndIBvbGetCardEvolvedUse(builder);
		}

		// Token: 0x0601571E RID: 87838 RVA: 0x00318767 File Offset: 0x00316967
		public static void StartIBvbGetCardEvolvedUse(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601571F RID: 87839 RVA: 0x00318770 File Offset: 0x00316970
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015720 RID: 87840 RVA: 0x0031877B File Offset: 0x0031697B
		public static void AddCardType(FlatBufferBuilder builder, TVarRef cardType)
		{
			builder.AddByte(1, (byte)cardType, 0);
		}

		// Token: 0x06015721 RID: 87841 RVA: 0x00318786 File Offset: 0x00316986
		public static void AddCard(FlatBufferBuilder builder, int cardOffset)
		{
			builder.AddOffset(2, cardOffset, 0);
		}

		// Token: 0x06015722 RID: 87842 RVA: 0x00318791 File Offset: 0x00316991
		public static Offset<IBvbGetCardEvolvedUse> EndIBvbGetCardEvolvedUse(FlatBufferBuilder builder)
		{
			return new Offset<IBvbGetCardEvolvedUse>(builder.EndTable());
		}

		// Token: 0x06015723 RID: 87843 RVA: 0x003187A0 File Offset: 0x003169A0
		public IBvbGetCardEvolvedUseT UnPack()
		{
			IBvbGetCardEvolvedUseT bvbGetCardEvolvedUseT = new IBvbGetCardEvolvedUseT();
			this.UnPackTo(bvbGetCardEvolvedUseT);
			return bvbGetCardEvolvedUseT;
		}

		// Token: 0x06015724 RID: 87844 RVA: 0x003187BC File Offset: 0x003169BC
		public void UnPackTo(IBvbGetCardEvolvedUseT _o)
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

		// Token: 0x06015725 RID: 87845 RVA: 0x00318928 File Offset: 0x00316B28
		public static Offset<IBvbGetCardEvolvedUse> Pack(FlatBufferBuilder builder, IBvbGetCardEvolvedUseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbGetCardEvolvedUse>);
			}
			TVarRef card_type = (_o.Card == null) ? TVarRef.NONE : _o.Card.Type;
			int cardOffset = (_o.Card == null) ? 0 : TVarRefUnion.Pack(builder, _o.Card);
			return IBvbGetCardEvolvedUse.CreateIBvbGetCardEvolvedUse(builder, _o.Type, card_type, cardOffset);
		}

		// Token: 0x0400B804 RID: 47108
		private Table __p;
	}
}
