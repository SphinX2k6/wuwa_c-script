using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E17 RID: 15895
	public struct IBvbCardFilterCompareCardType : IFlatbufferObject
	{
		// Token: 0x17006B57 RID: 27479
		// (get) Token: 0x060155E6 RID: 87526 RVA: 0x00316272 File Offset: 0x00314472
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060155E7 RID: 87527 RVA: 0x0031627F File Offset: 0x0031447F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060155E8 RID: 87528 RVA: 0x00316288 File Offset: 0x00314488
		public static IBvbCardFilterCompareCardType GetRootAsIBvbCardFilterCompareCardType(ByteBuffer _bb)
		{
			return IBvbCardFilterCompareCardType.GetRootAsIBvbCardFilterCompareCardType(_bb, default(IBvbCardFilterCompareCardType));
		}

		// Token: 0x060155E9 RID: 87529 RVA: 0x003162A4 File Offset: 0x003144A4
		public static IBvbCardFilterCompareCardType GetRootAsIBvbCardFilterCompareCardType(ByteBuffer _bb, IBvbCardFilterCompareCardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060155EA RID: 87530 RVA: 0x003162C1 File Offset: 0x003144C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060155EB RID: 87531 RVA: 0x003162D0 File Offset: 0x003144D0
		public IBvbCardFilterCompareCardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B58 RID: 27480
		// (get) Token: 0x060155EC RID: 87532 RVA: 0x003162E0 File Offset: 0x003144E0
		public EBvbCardFilterType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbCardFilterType.CompareCost;
				}
				return (EBvbCardFilterType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006B59 RID: 27481
		// (get) Token: 0x060155ED RID: 87533 RVA: 0x0031631C File Offset: 0x0031451C
		public int CardType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060155EE RID: 87534 RVA: 0x00316358 File Offset: 0x00314558
		public static Offset<IBvbCardFilterCompareCardType> CreateIBvbCardFilterCompareCardType(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, int CardType = 0)
		{
			builder.StartTable(2);
			IBvbCardFilterCompareCardType.AddCardType(builder, CardType);
			IBvbCardFilterCompareCardType.AddType(builder, Type);
			return IBvbCardFilterCompareCardType.EndIBvbCardFilterCompareCardType(builder);
		}

		// Token: 0x060155EF RID: 87535 RVA: 0x00316375 File Offset: 0x00314575
		public static void StartIBvbCardFilterCompareCardType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060155F0 RID: 87536 RVA: 0x0031637E File Offset: 0x0031457E
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060155F1 RID: 87537 RVA: 0x00316389 File Offset: 0x00314589
		public static void AddCardType(FlatBufferBuilder builder, int cardType)
		{
			builder.AddInt(1, cardType, 0);
		}

		// Token: 0x060155F2 RID: 87538 RVA: 0x00316394 File Offset: 0x00314594
		public static Offset<IBvbCardFilterCompareCardType> EndIBvbCardFilterCompareCardType(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCompareCardType>(builder.EndTable());
		}

		// Token: 0x060155F3 RID: 87539 RVA: 0x003163A4 File Offset: 0x003145A4
		public IBvbCardFilterCompareCardTypeT UnPack()
		{
			IBvbCardFilterCompareCardTypeT bvbCardFilterCompareCardTypeT = new IBvbCardFilterCompareCardTypeT();
			this.UnPackTo(bvbCardFilterCompareCardTypeT);
			return bvbCardFilterCompareCardTypeT;
		}

		// Token: 0x060155F4 RID: 87540 RVA: 0x003163BF File Offset: 0x003145BF
		public void UnPackTo(IBvbCardFilterCompareCardTypeT _o)
		{
			_o.Type = this.Type;
			_o.CardType = this.CardType;
		}

		// Token: 0x060155F5 RID: 87541 RVA: 0x003163DC File Offset: 0x003145DC
		public static Offset<IBvbCardFilterCompareCardType> Pack(FlatBufferBuilder builder, IBvbCardFilterCompareCardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCompareCardType>);
			}
			return IBvbCardFilterCompareCardType.CreateIBvbCardFilterCompareCardType(builder, _o.Type, _o.CardType);
		}

		// Token: 0x0400B7DD RID: 47069
		private Table __p;
	}
}
