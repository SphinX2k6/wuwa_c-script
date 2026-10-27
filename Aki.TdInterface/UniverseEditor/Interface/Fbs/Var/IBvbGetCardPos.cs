using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A60 RID: 14944
	public struct IBvbGetCardPos : IFlatbufferObject
	{
		// Token: 0x17006670 RID: 26224
		// (get) Token: 0x06014410 RID: 82960 RVA: 0x002F5830 File Offset: 0x002F3A30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014411 RID: 82961 RVA: 0x002F583D File Offset: 0x002F3A3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014412 RID: 82962 RVA: 0x002F5844 File Offset: 0x002F3A44
		public static IBvbGetCardPos GetRootAsIBvbGetCardPos(ByteBuffer _bb)
		{
			return IBvbGetCardPos.GetRootAsIBvbGetCardPos(_bb, default(IBvbGetCardPos));
		}

		// Token: 0x06014413 RID: 82963 RVA: 0x002F5860 File Offset: 0x002F3A60
		public static IBvbGetCardPos GetRootAsIBvbGetCardPos(ByteBuffer _bb, IBvbGetCardPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014414 RID: 82964 RVA: 0x002F587D File Offset: 0x002F3A7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014415 RID: 82965 RVA: 0x002F588C File Offset: 0x002F3A8C
		public IBvbGetCardPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006671 RID: 26225
		// (get) Token: 0x06014416 RID: 82966 RVA: 0x002F589C File Offset: 0x002F3A9C
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

		// Token: 0x17006672 RID: 26226
		// (get) Token: 0x06014417 RID: 82967 RVA: 0x002F58D8 File Offset: 0x002F3AD8
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

		// Token: 0x06014418 RID: 82968 RVA: 0x002F5914 File Offset: 0x002F3B14
		public TTable? Card<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06014419 RID: 82969 RVA: 0x002F5958 File Offset: 0x002F3B58
		public IConstVarRef CardAsIConstVarRef()
		{
			return this.Card<IConstVarRef>().Value;
		}

		// Token: 0x0601441A RID: 82970 RVA: 0x002F5974 File Offset: 0x002F3B74
		public IGlobalVarRef CardAsIGlobalVarRef()
		{
			return this.Card<IGlobalVarRef>().Value;
		}

		// Token: 0x0601441B RID: 82971 RVA: 0x002F5990 File Offset: 0x002F3B90
		public IOtherVarRef CardAsIOtherVarRef()
		{
			return this.Card<IOtherVarRef>().Value;
		}

		// Token: 0x0601441C RID: 82972 RVA: 0x002F59AC File Offset: 0x002F3BAC
		public ISelfVarRef CardAsISelfVarRef()
		{
			return this.Card<ISelfVarRef>().Value;
		}

		// Token: 0x0601441D RID: 82973 RVA: 0x002F59C8 File Offset: 0x002F3BC8
		public ISystemVarRef CardAsISystemVarRef()
		{
			return this.Card<ISystemVarRef>().Value;
		}

		// Token: 0x0601441E RID: 82974 RVA: 0x002F59E3 File Offset: 0x002F3BE3
		public static Offset<IBvbGetCardPos> CreateIBvbGetCardPos(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, TVarRef Card_type = TVarRef.NONE, int CardOffset = 0)
		{
			builder.StartTable(3);
			IBvbGetCardPos.AddCard(builder, CardOffset);
			IBvbGetCardPos.AddCardType(builder, Card_type);
			IBvbGetCardPos.AddType(builder, Type);
			return IBvbGetCardPos.EndIBvbGetCardPos(builder);
		}

		// Token: 0x0601441F RID: 82975 RVA: 0x002F5A07 File Offset: 0x002F3C07
		public static void StartIBvbGetCardPos(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014420 RID: 82976 RVA: 0x002F5A10 File Offset: 0x002F3C10
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014421 RID: 82977 RVA: 0x002F5A1B File Offset: 0x002F3C1B
		public static void AddCardType(FlatBufferBuilder builder, TVarRef cardType)
		{
			builder.AddByte(1, (byte)cardType, 0);
		}

		// Token: 0x06014422 RID: 82978 RVA: 0x002F5A26 File Offset: 0x002F3C26
		public static void AddCard(FlatBufferBuilder builder, int cardOffset)
		{
			builder.AddOffset(2, cardOffset, 0);
		}

		// Token: 0x06014423 RID: 82979 RVA: 0x002F5A31 File Offset: 0x002F3C31
		public static Offset<IBvbGetCardPos> EndIBvbGetCardPos(FlatBufferBuilder builder)
		{
			return new Offset<IBvbGetCardPos>(builder.EndTable());
		}

		// Token: 0x06014424 RID: 82980 RVA: 0x002F5A40 File Offset: 0x002F3C40
		public IBvbGetCardPosT UnPack()
		{
			IBvbGetCardPosT bvbGetCardPosT = new IBvbGetCardPosT();
			this.UnPackTo(bvbGetCardPosT);
			return bvbGetCardPosT;
		}

		// Token: 0x06014425 RID: 82981 RVA: 0x002F5A5C File Offset: 0x002F3C5C
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

		// Token: 0x06014426 RID: 82982 RVA: 0x002F5BC8 File Offset: 0x002F3DC8
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

		// Token: 0x0400AEE5 RID: 44773
		private Table __p;
	}
}
