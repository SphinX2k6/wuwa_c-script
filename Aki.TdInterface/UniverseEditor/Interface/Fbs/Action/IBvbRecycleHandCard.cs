using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006257 RID: 25175
	public struct IBvbRecycleHandCard : IFlatbufferObject
	{
		// Token: 0x1700BB9F RID: 48031
		// (get) Token: 0x0602B6C0 RID: 177856 RVA: 0x005FA112 File Offset: 0x005F8312
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B6C1 RID: 177857 RVA: 0x005FA11F File Offset: 0x005F831F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B6C2 RID: 177858 RVA: 0x005FA128 File Offset: 0x005F8328
		public static IBvbRecycleHandCard GetRootAsIBvbRecycleHandCard(ByteBuffer _bb)
		{
			return IBvbRecycleHandCard.GetRootAsIBvbRecycleHandCard(_bb, default(IBvbRecycleHandCard));
		}

		// Token: 0x0602B6C3 RID: 177859 RVA: 0x005FA144 File Offset: 0x005F8344
		public static IBvbRecycleHandCard GetRootAsIBvbRecycleHandCard(ByteBuffer _bb, IBvbRecycleHandCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B6C4 RID: 177860 RVA: 0x005FA161 File Offset: 0x005F8361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B6C5 RID: 177861 RVA: 0x005FA170 File Offset: 0x005F8370
		public IBvbRecycleHandCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBA0 RID: 48032
		// (get) Token: 0x0602B6C6 RID: 177862 RVA: 0x005FA180 File Offset: 0x005F8380
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

		// Token: 0x1700BBA1 RID: 48033
		// (get) Token: 0x0602B6C7 RID: 177863 RVA: 0x005FA1BC File Offset: 0x005F83BC
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

		// Token: 0x1700BBA2 RID: 48034
		// (get) Token: 0x0602B6C8 RID: 177864 RVA: 0x005FA1F8 File Offset: 0x005F83F8
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

		// Token: 0x0602B6C9 RID: 177865 RVA: 0x005FA234 File Offset: 0x005F8434
		public static Offset<IBvbRecycleHandCard> CreateIBvbRecycleHandCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int HandCardIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IBvbRecycleHandCard.AddHandCardIndex(builder, HandCardIndex);
			IBvbRecycleHandCard.AddNullMask(builder, NullMask);
			IBvbRecycleHandCard.AddType(builder, Type);
			return IBvbRecycleHandCard.EndIBvbRecycleHandCard(builder);
		}

		// Token: 0x0602B6CA RID: 177866 RVA: 0x005FA258 File Offset: 0x005F8458
		public static void StartIBvbRecycleHandCard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B6CB RID: 177867 RVA: 0x005FA261 File Offset: 0x005F8461
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B6CC RID: 177868 RVA: 0x005FA26C File Offset: 0x005F846C
		public static void AddHandCardIndex(FlatBufferBuilder builder, int handCardIndex)
		{
			builder.AddInt(1, handCardIndex, 0);
		}

		// Token: 0x0602B6CD RID: 177869 RVA: 0x005FA277 File Offset: 0x005F8477
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602B6CE RID: 177870 RVA: 0x005FA282 File Offset: 0x005F8482
		public static Offset<IBvbRecycleHandCard> EndIBvbRecycleHandCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbRecycleHandCard>(builder.EndTable());
		}

		// Token: 0x0602B6CF RID: 177871 RVA: 0x005FA290 File Offset: 0x005F8490
		public IBvbRecycleHandCardT UnPack()
		{
			IBvbRecycleHandCardT bvbRecycleHandCardT = new IBvbRecycleHandCardT();
			this.UnPackTo(bvbRecycleHandCardT);
			return bvbRecycleHandCardT;
		}

		// Token: 0x0602B6D0 RID: 177872 RVA: 0x005FA2AB File Offset: 0x005F84AB
		public void UnPackTo(IBvbRecycleHandCardT _o)
		{
			_o.Type = this.Type;
			_o.HandCardIndex = this.HandCardIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B6D1 RID: 177873 RVA: 0x005FA2D4 File Offset: 0x005F84D4
		public static Offset<IBvbRecycleHandCard> Pack(FlatBufferBuilder builder, IBvbRecycleHandCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbRecycleHandCard>);
			}
			return IBvbRecycleHandCard.CreateIBvbRecycleHandCard(builder, _o.Type, _o.HandCardIndex, _o.NullMask);
		}

		// Token: 0x040107B2 RID: 67506
		private Table __p;
	}
}
