using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A5D RID: 14941
	public struct IBvbGetCardEvolvedUse : IFlatbufferObject
	{
		// Token: 0x1700666B RID: 26219
		// (get) Token: 0x060143F3 RID: 82931 RVA: 0x002F53A4 File Offset: 0x002F35A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060143F4 RID: 82932 RVA: 0x002F53B1 File Offset: 0x002F35B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060143F5 RID: 82933 RVA: 0x002F53B8 File Offset: 0x002F35B8
		public static IBvbGetCardEvolvedUse GetRootAsIBvbGetCardEvolvedUse(ByteBuffer _bb)
		{
			return IBvbGetCardEvolvedUse.GetRootAsIBvbGetCardEvolvedUse(_bb, default(IBvbGetCardEvolvedUse));
		}

		// Token: 0x060143F6 RID: 82934 RVA: 0x002F53D4 File Offset: 0x002F35D4
		public static IBvbGetCardEvolvedUse GetRootAsIBvbGetCardEvolvedUse(ByteBuffer _bb, IBvbGetCardEvolvedUse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060143F7 RID: 82935 RVA: 0x002F53F1 File Offset: 0x002F35F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060143F8 RID: 82936 RVA: 0x002F5400 File Offset: 0x002F3600
		public IBvbGetCardEvolvedUse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700666C RID: 26220
		// (get) Token: 0x060143F9 RID: 82937 RVA: 0x002F5410 File Offset: 0x002F3610
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

		// Token: 0x1700666D RID: 26221
		// (get) Token: 0x060143FA RID: 82938 RVA: 0x002F544C File Offset: 0x002F364C
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

		// Token: 0x060143FB RID: 82939 RVA: 0x002F5488 File Offset: 0x002F3688
		public TTable? Card<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060143FC RID: 82940 RVA: 0x002F54CC File Offset: 0x002F36CC
		public IConstVarRef CardAsIConstVarRef()
		{
			return this.Card<IConstVarRef>().Value;
		}

		// Token: 0x060143FD RID: 82941 RVA: 0x002F54E8 File Offset: 0x002F36E8
		public IGlobalVarRef CardAsIGlobalVarRef()
		{
			return this.Card<IGlobalVarRef>().Value;
		}

		// Token: 0x060143FE RID: 82942 RVA: 0x002F5504 File Offset: 0x002F3704
		public IOtherVarRef CardAsIOtherVarRef()
		{
			return this.Card<IOtherVarRef>().Value;
		}

		// Token: 0x060143FF RID: 82943 RVA: 0x002F5520 File Offset: 0x002F3720
		public ISelfVarRef CardAsISelfVarRef()
		{
			return this.Card<ISelfVarRef>().Value;
		}

		// Token: 0x06014400 RID: 82944 RVA: 0x002F553C File Offset: 0x002F373C
		public ISystemVarRef CardAsISystemVarRef()
		{
			return this.Card<ISystemVarRef>().Value;
		}

		// Token: 0x06014401 RID: 82945 RVA: 0x002F5557 File Offset: 0x002F3757
		public static Offset<IBvbGetCardEvolvedUse> CreateIBvbGetCardEvolvedUse(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, TVarRef Card_type = TVarRef.NONE, int CardOffset = 0)
		{
			builder.StartTable(3);
			IBvbGetCardEvolvedUse.AddCard(builder, CardOffset);
			IBvbGetCardEvolvedUse.AddCardType(builder, Card_type);
			IBvbGetCardEvolvedUse.AddType(builder, Type);
			return IBvbGetCardEvolvedUse.EndIBvbGetCardEvolvedUse(builder);
		}

		// Token: 0x06014402 RID: 82946 RVA: 0x002F557B File Offset: 0x002F377B
		public static void StartIBvbGetCardEvolvedUse(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014403 RID: 82947 RVA: 0x002F5584 File Offset: 0x002F3784
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014404 RID: 82948 RVA: 0x002F558F File Offset: 0x002F378F
		public static void AddCardType(FlatBufferBuilder builder, TVarRef cardType)
		{
			builder.AddByte(1, (byte)cardType, 0);
		}

		// Token: 0x06014405 RID: 82949 RVA: 0x002F559A File Offset: 0x002F379A
		public static void AddCard(FlatBufferBuilder builder, int cardOffset)
		{
			builder.AddOffset(2, cardOffset, 0);
		}

		// Token: 0x06014406 RID: 82950 RVA: 0x002F55A5 File Offset: 0x002F37A5
		public static Offset<IBvbGetCardEvolvedUse> EndIBvbGetCardEvolvedUse(FlatBufferBuilder builder)
		{
			return new Offset<IBvbGetCardEvolvedUse>(builder.EndTable());
		}

		// Token: 0x06014407 RID: 82951 RVA: 0x002F55B4 File Offset: 0x002F37B4
		public IBvbGetCardEvolvedUseT UnPack()
		{
			IBvbGetCardEvolvedUseT bvbGetCardEvolvedUseT = new IBvbGetCardEvolvedUseT();
			this.UnPackTo(bvbGetCardEvolvedUseT);
			return bvbGetCardEvolvedUseT;
		}

		// Token: 0x06014408 RID: 82952 RVA: 0x002F55D0 File Offset: 0x002F37D0
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

		// Token: 0x06014409 RID: 82953 RVA: 0x002F573C File Offset: 0x002F393C
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

		// Token: 0x0400AEE2 RID: 44770
		private Table __p;
	}
}
