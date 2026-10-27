using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A5A RID: 14938
	public struct IBvbGetCardChangeUse : IFlatbufferObject
	{
		// Token: 0x17006666 RID: 26214
		// (get) Token: 0x060143D6 RID: 82902 RVA: 0x002F4F18 File Offset: 0x002F3118
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060143D7 RID: 82903 RVA: 0x002F4F25 File Offset: 0x002F3125
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060143D8 RID: 82904 RVA: 0x002F4F2C File Offset: 0x002F312C
		public static IBvbGetCardChangeUse GetRootAsIBvbGetCardChangeUse(ByteBuffer _bb)
		{
			return IBvbGetCardChangeUse.GetRootAsIBvbGetCardChangeUse(_bb, default(IBvbGetCardChangeUse));
		}

		// Token: 0x060143D9 RID: 82905 RVA: 0x002F4F48 File Offset: 0x002F3148
		public static IBvbGetCardChangeUse GetRootAsIBvbGetCardChangeUse(ByteBuffer _bb, IBvbGetCardChangeUse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060143DA RID: 82906 RVA: 0x002F4F65 File Offset: 0x002F3165
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060143DB RID: 82907 RVA: 0x002F4F74 File Offset: 0x002F3174
		public IBvbGetCardChangeUse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006667 RID: 26215
		// (get) Token: 0x060143DC RID: 82908 RVA: 0x002F4F84 File Offset: 0x002F3184
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

		// Token: 0x17006668 RID: 26216
		// (get) Token: 0x060143DD RID: 82909 RVA: 0x002F4FC0 File Offset: 0x002F31C0
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

		// Token: 0x060143DE RID: 82910 RVA: 0x002F4FFC File Offset: 0x002F31FC
		public TTable? Card<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060143DF RID: 82911 RVA: 0x002F5040 File Offset: 0x002F3240
		public IConstVarRef CardAsIConstVarRef()
		{
			return this.Card<IConstVarRef>().Value;
		}

		// Token: 0x060143E0 RID: 82912 RVA: 0x002F505C File Offset: 0x002F325C
		public IGlobalVarRef CardAsIGlobalVarRef()
		{
			return this.Card<IGlobalVarRef>().Value;
		}

		// Token: 0x060143E1 RID: 82913 RVA: 0x002F5078 File Offset: 0x002F3278
		public IOtherVarRef CardAsIOtherVarRef()
		{
			return this.Card<IOtherVarRef>().Value;
		}

		// Token: 0x060143E2 RID: 82914 RVA: 0x002F5094 File Offset: 0x002F3294
		public ISelfVarRef CardAsISelfVarRef()
		{
			return this.Card<ISelfVarRef>().Value;
		}

		// Token: 0x060143E3 RID: 82915 RVA: 0x002F50B0 File Offset: 0x002F32B0
		public ISystemVarRef CardAsISystemVarRef()
		{
			return this.Card<ISystemVarRef>().Value;
		}

		// Token: 0x060143E4 RID: 82916 RVA: 0x002F50CB File Offset: 0x002F32CB
		public static Offset<IBvbGetCardChangeUse> CreateIBvbGetCardChangeUse(FlatBufferBuilder builder, ESystemVarName Type = ESystemVarName.CommonHotFixVar, TVarRef Card_type = TVarRef.NONE, int CardOffset = 0)
		{
			builder.StartTable(3);
			IBvbGetCardChangeUse.AddCard(builder, CardOffset);
			IBvbGetCardChangeUse.AddCardType(builder, Card_type);
			IBvbGetCardChangeUse.AddType(builder, Type);
			return IBvbGetCardChangeUse.EndIBvbGetCardChangeUse(builder);
		}

		// Token: 0x060143E5 RID: 82917 RVA: 0x002F50EF File Offset: 0x002F32EF
		public static void StartIBvbGetCardChangeUse(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060143E6 RID: 82918 RVA: 0x002F50F8 File Offset: 0x002F32F8
		public static void AddType(FlatBufferBuilder builder, ESystemVarName type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060143E7 RID: 82919 RVA: 0x002F5103 File Offset: 0x002F3303
		public static void AddCardType(FlatBufferBuilder builder, TVarRef cardType)
		{
			builder.AddByte(1, (byte)cardType, 0);
		}

		// Token: 0x060143E8 RID: 82920 RVA: 0x002F510E File Offset: 0x002F330E
		public static void AddCard(FlatBufferBuilder builder, int cardOffset)
		{
			builder.AddOffset(2, cardOffset, 0);
		}

		// Token: 0x060143E9 RID: 82921 RVA: 0x002F5119 File Offset: 0x002F3319
		public static Offset<IBvbGetCardChangeUse> EndIBvbGetCardChangeUse(FlatBufferBuilder builder)
		{
			return new Offset<IBvbGetCardChangeUse>(builder.EndTable());
		}

		// Token: 0x060143EA RID: 82922 RVA: 0x002F5128 File Offset: 0x002F3328
		public IBvbGetCardChangeUseT UnPack()
		{
			IBvbGetCardChangeUseT bvbGetCardChangeUseT = new IBvbGetCardChangeUseT();
			this.UnPackTo(bvbGetCardChangeUseT);
			return bvbGetCardChangeUseT;
		}

		// Token: 0x060143EB RID: 82923 RVA: 0x002F5144 File Offset: 0x002F3344
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

		// Token: 0x060143EC RID: 82924 RVA: 0x002F52B0 File Offset: 0x002F34B0
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

		// Token: 0x0400AEDF RID: 44767
		private Table __p;
	}
}
