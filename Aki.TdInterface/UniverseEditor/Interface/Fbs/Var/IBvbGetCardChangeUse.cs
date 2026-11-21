using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E35 RID: 15925
	public struct IBvbGetCardChangeUse : IFlatbufferObject
	{
		// Token: 0x17006B96 RID: 27542
		// (get) Token: 0x060156F2 RID: 87794 RVA: 0x00318104 File Offset: 0x00316304
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060156F3 RID: 87795 RVA: 0x00318111 File Offset: 0x00316311
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060156F4 RID: 87796 RVA: 0x00318118 File Offset: 0x00316318
		public static IBvbGetCardChangeUse GetRootAsIBvbGetCardChangeUse(ByteBuffer _bb)
		{
			return IBvbGetCardChangeUse.GetRootAsIBvbGetCardChangeUse(_bb, default(IBvbGetCardChangeUse));
		}

		// Token: 0x060156F5 RID: 87797 RVA: 0x00318134 File Offset: 0x00316334
		public static IBvbGetCardChangeUse GetRootAsIBvbGetCardChangeUse(ByteBuffer _bb, IBvbGetCardChangeUse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060156F6 RID: 87798 RVA: 0x00318151 File Offset: 0x00316351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060156F7 RID: 87799 RVA: 0x00318160 File Offset: 0x00316360
		public IBvbGetCardChangeUse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B97 RID: 27543
		// (get) Token: 0x060156F8 RID: 87800 RVA: 0x00318170 File Offset: 0x00316370
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

		// Token: 0x17006B98 RID: 27544
		// (get) Token: 0x060156F9 RID: 87801 RVA: 0x003181AC File Offset: 0x003163AC
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

		// Token: 0x060156FA RID: 87802 RVA: 0x003181E8 File Offset: 0x003163E8
		public TTable? Card<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060156FB RID: 87803 RVA: 0x0031822C File Offset: 0x0031642C
		public IConstVarRef CardAsIConstVarRef()
		{
			return this.Card<IConstVarRef>().Value;
		}

		// Token: 0x060156FC RID: 87804 RVA: 0x00318248 File Offset: 0x00316448
		public IGlobalVarRef CardAsIGlobalVarRef()
		{
			return this.Card<IGlobalVarRef>().Value;
		}

		// Token: 0x060156FD RID: 87805 RVA: 0x00318264 File Offset: 0x00316464
		public IOtherVarRef CardAsIOtherVarRef()
		{
			return this.Card<IOtherVarRef>().Value;
		}

		// Token: 0x060156FE RID: 87806 RVA: 0x00318280 File Offset: 0x00316480
		public ISelfVarRef CardAsISelfVarRef()
		{
			return this.Card<ISelfVarRef>().Value;
		}

		// Token: 0x060156FF RID: 87807 RVA: 0x0031829C File Offset: 0x0031649C
		public ISystemVarRef CardAsISystemVarRef()
		{
			return this.Card<ISystemVarRef>().Value;
		}

		// Token: 0x06015700 RID: 87808 RVA: 0x003182B7 File Offset: 0x003164B7
		public static Offset<IBvbGetCardChangeUse> CreateIBvbGetCardChangeUse(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, TVarRef Card_type = TVarRef.NONE, int CardOffset = 0)
		{
			builder.StartTable(3);
			IBvbGetCardChangeUse.AddCard(builder, CardOffset);
			IBvbGetCardChangeUse.AddCardType(builder, Card_type);
			IBvbGetCardChangeUse.AddType(builder, Type);
			return IBvbGetCardChangeUse.EndIBvbGetCardChangeUse(builder);
		}

		// Token: 0x06015701 RID: 87809 RVA: 0x003182DB File Offset: 0x003164DB
		public static void StartIBvbGetCardChangeUse(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015702 RID: 87810 RVA: 0x003182E4 File Offset: 0x003164E4
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015703 RID: 87811 RVA: 0x003182EF File Offset: 0x003164EF
		public static void AddCardType(FlatBufferBuilder builder, TVarRef cardType)
		{
			builder.AddByte(1, (byte)cardType, 0);
		}

		// Token: 0x06015704 RID: 87812 RVA: 0x003182FA File Offset: 0x003164FA
		public static void AddCard(FlatBufferBuilder builder, int cardOffset)
		{
			builder.AddOffset(2, cardOffset, 0);
		}

		// Token: 0x06015705 RID: 87813 RVA: 0x00318305 File Offset: 0x00316505
		public static Offset<IBvbGetCardChangeUse> EndIBvbGetCardChangeUse(FlatBufferBuilder builder)
		{
			return new Offset<IBvbGetCardChangeUse>(builder.EndTable());
		}

		// Token: 0x06015706 RID: 87814 RVA: 0x00318314 File Offset: 0x00316514
		public IBvbGetCardChangeUseT UnPack()
		{
			IBvbGetCardChangeUseT bvbGetCardChangeUseT = new IBvbGetCardChangeUseT();
			this.UnPackTo(bvbGetCardChangeUseT);
			return bvbGetCardChangeUseT;
		}

		// Token: 0x06015707 RID: 87815 RVA: 0x00318330 File Offset: 0x00316530
		public void UnPackTo(IBvbGetCardChangeUseT _o)
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

		// Token: 0x06015708 RID: 87816 RVA: 0x0031849C File Offset: 0x0031669C
		public static Offset<IBvbGetCardChangeUse> Pack(FlatBufferBuilder builder, IBvbGetCardChangeUseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbGetCardChangeUse>);
			}
			TVarRef card_type = (_o.Card == null) ? TVarRef.NONE : _o.Card.Type;
			int cardOffset = (_o.Card == null) ? 0 : TVarRefUnion.Pack(builder, _o.Card);
			return IBvbGetCardChangeUse.CreateIBvbGetCardChangeUse(builder, _o.Type, card_type, cardOffset);
		}

		// Token: 0x0400B801 RID: 47105
		private Table __p;
	}
}
