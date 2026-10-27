using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A3C RID: 14908
	public struct IBvbCardFilterCompareCardType : IFlatbufferObject
	{
		// Token: 0x17006627 RID: 26151
		// (get) Token: 0x060142CA RID: 82634 RVA: 0x002F3086 File Offset: 0x002F1286
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060142CB RID: 82635 RVA: 0x002F3093 File Offset: 0x002F1293
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060142CC RID: 82636 RVA: 0x002F309C File Offset: 0x002F129C
		public static IBvbCardFilterCompareCardType GetRootAsIBvbCardFilterCompareCardType(ByteBuffer _bb)
		{
			return IBvbCardFilterCompareCardType.GetRootAsIBvbCardFilterCompareCardType(_bb, default(IBvbCardFilterCompareCardType));
		}

		// Token: 0x060142CD RID: 82637 RVA: 0x002F30B8 File Offset: 0x002F12B8
		public static IBvbCardFilterCompareCardType GetRootAsIBvbCardFilterCompareCardType(ByteBuffer _bb, IBvbCardFilterCompareCardType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060142CE RID: 82638 RVA: 0x002F30D5 File Offset: 0x002F12D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060142CF RID: 82639 RVA: 0x002F30E4 File Offset: 0x002F12E4
		public IBvbCardFilterCompareCardType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006628 RID: 26152
		// (get) Token: 0x060142D0 RID: 82640 RVA: 0x002F30F4 File Offset: 0x002F12F4
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

		// Token: 0x17006629 RID: 26153
		// (get) Token: 0x060142D1 RID: 82641 RVA: 0x002F3130 File Offset: 0x002F1330
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

		// Token: 0x060142D2 RID: 82642 RVA: 0x002F316C File Offset: 0x002F136C
		public static Offset<IBvbCardFilterCompareCardType> CreateIBvbCardFilterCompareCardType(FlatBufferBuilder builder, EBvbCardFilterType Type = EBvbCardFilterType.CompareCost, int CardType = 0)
		{
			builder.StartTable(2);
			IBvbCardFilterCompareCardType.AddCardType(builder, CardType);
			IBvbCardFilterCompareCardType.AddType(builder, Type);
			return IBvbCardFilterCompareCardType.EndIBvbCardFilterCompareCardType(builder);
		}

		// Token: 0x060142D3 RID: 82643 RVA: 0x002F3189 File Offset: 0x002F1389
		public static void StartIBvbCardFilterCompareCardType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060142D4 RID: 82644 RVA: 0x002F3192 File Offset: 0x002F1392
		public static void AddType(FlatBufferBuilder builder, EBvbCardFilterType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060142D5 RID: 82645 RVA: 0x002F319D File Offset: 0x002F139D
		public static void AddCardType(FlatBufferBuilder builder, int cardType)
		{
			builder.AddInt(1, cardType, 0);
		}

		// Token: 0x060142D6 RID: 82646 RVA: 0x002F31A8 File Offset: 0x002F13A8
		public static Offset<IBvbCardFilterCompareCardType> EndIBvbCardFilterCompareCardType(FlatBufferBuilder builder)
		{
			return new Offset<IBvbCardFilterCompareCardType>(builder.EndTable());
		}

		// Token: 0x060142D7 RID: 82647 RVA: 0x002F31B8 File Offset: 0x002F13B8
		public IBvbCardFilterCompareCardTypeT UnPack()
		{
			IBvbCardFilterCompareCardTypeT bvbCardFilterCompareCardTypeT = new IBvbCardFilterCompareCardTypeT();
			this.UnPackTo(bvbCardFilterCompareCardTypeT);
			return bvbCardFilterCompareCardTypeT;
		}

		// Token: 0x060142D8 RID: 82648 RVA: 0x002F31D3 File Offset: 0x002F13D3
		public void UnPackTo(IBvbCardFilterCompareCardTypeT _o)
		{
			_o.Type = this.Type;
			_o.CardType = this.CardType;
		}

		// Token: 0x060142D9 RID: 82649 RVA: 0x002F31F0 File Offset: 0x002F13F0
		public static Offset<IBvbCardFilterCompareCardType> Pack(FlatBufferBuilder builder, IBvbCardFilterCompareCardTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbCardFilterCompareCardType>);
			}
			return IBvbCardFilterCompareCardType.CreateIBvbCardFilterCompareCardType(builder, _o.Type, _o.CardType);
		}

		// Token: 0x0400AEBB RID: 44731
		private Table __p;
	}
}
