using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200623C RID: 25148
	public struct IBvbChangeHandCard : IFlatbufferObject
	{
		// Token: 0x1700BB65 RID: 47973
		// (get) Token: 0x0602B5AC RID: 177580 RVA: 0x005F8116 File Offset: 0x005F6316
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B5AD RID: 177581 RVA: 0x005F8123 File Offset: 0x005F6323
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B5AE RID: 177582 RVA: 0x005F812C File Offset: 0x005F632C
		public static IBvbChangeHandCard GetRootAsIBvbChangeHandCard(ByteBuffer _bb)
		{
			return IBvbChangeHandCard.GetRootAsIBvbChangeHandCard(_bb, default(IBvbChangeHandCard));
		}

		// Token: 0x0602B5AF RID: 177583 RVA: 0x005F8148 File Offset: 0x005F6348
		public static IBvbChangeHandCard GetRootAsIBvbChangeHandCard(ByteBuffer _bb, IBvbChangeHandCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B5B0 RID: 177584 RVA: 0x005F8165 File Offset: 0x005F6365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B5B1 RID: 177585 RVA: 0x005F8174 File Offset: 0x005F6374
		public IBvbChangeHandCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB66 RID: 47974
		// (get) Token: 0x0602B5B2 RID: 177586 RVA: 0x005F8184 File Offset: 0x005F6384
		public EBvbPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return (EBvbPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BB67 RID: 47975
		// (get) Token: 0x0602B5B3 RID: 177587 RVA: 0x005F81C0 File Offset: 0x005F63C0
		public int HandCardIndex
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

		// Token: 0x1700BB68 RID: 47976
		// (get) Token: 0x0602B5B4 RID: 177588 RVA: 0x005F81FC File Offset: 0x005F63FC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B5B5 RID: 177589 RVA: 0x005F8238 File Offset: 0x005F6438
		public static Offset<IBvbChangeHandCard> CreateIBvbChangeHandCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int HandCardIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IBvbChangeHandCard.AddHandCardIndex(builder, HandCardIndex);
			IBvbChangeHandCard.AddNullMask(builder, NullMask);
			IBvbChangeHandCard.AddType(builder, Type);
			return IBvbChangeHandCard.EndIBvbChangeHandCard(builder);
		}

		// Token: 0x0602B5B6 RID: 177590 RVA: 0x005F825C File Offset: 0x005F645C
		public static void StartIBvbChangeHandCard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B5B7 RID: 177591 RVA: 0x005F8265 File Offset: 0x005F6465
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B5B8 RID: 177592 RVA: 0x005F8270 File Offset: 0x005F6470
		public static void AddHandCardIndex(FlatBufferBuilder builder, int handCardIndex)
		{
			builder.AddInt(1, handCardIndex, 0);
		}

		// Token: 0x0602B5B9 RID: 177593 RVA: 0x005F827B File Offset: 0x005F647B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602B5BA RID: 177594 RVA: 0x005F8286 File Offset: 0x005F6486
		public static Offset<IBvbChangeHandCard> EndIBvbChangeHandCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbChangeHandCard>(builder.EndTable());
		}

		// Token: 0x0602B5BB RID: 177595 RVA: 0x005F8294 File Offset: 0x005F6494
		public IBvbChangeHandCardT UnPack()
		{
			IBvbChangeHandCardT bvbChangeHandCardT = new IBvbChangeHandCardT();
			this.UnPackTo(bvbChangeHandCardT);
			return bvbChangeHandCardT;
		}

		// Token: 0x0602B5BC RID: 177596 RVA: 0x005F82AF File Offset: 0x005F64AF
		public void UnPackTo(IBvbChangeHandCardT _o)
		{
			_o.Type = this.Type;
			_o.HandCardIndex = this.HandCardIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B5BD RID: 177597 RVA: 0x005F82D8 File Offset: 0x005F64D8
		public static Offset<IBvbChangeHandCard> Pack(FlatBufferBuilder builder, IBvbChangeHandCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbChangeHandCard>);
			}
			return IBvbChangeHandCard.CreateIBvbChangeHandCard(builder, _o.Type, _o.HandCardIndex, _o.NullMask);
		}

		// Token: 0x04010783 RID: 67459
		private Table __p;
	}
}
