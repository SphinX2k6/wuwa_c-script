using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C8 RID: 26824
	public struct IBvbRecycleHandCard : IFlatbufferObject
	{
		// Token: 0x1700C527 RID: 50471
		// (get) Token: 0x0602DE21 RID: 187937 RVA: 0x00644F1A File Offset: 0x0064311A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DE22 RID: 187938 RVA: 0x00644F27 File Offset: 0x00643127
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DE23 RID: 187939 RVA: 0x00644F30 File Offset: 0x00643130
		public static IBvbRecycleHandCard GetRootAsIBvbRecycleHandCard(ByteBuffer _bb)
		{
			return IBvbRecycleHandCard.GetRootAsIBvbRecycleHandCard(_bb, default(IBvbRecycleHandCard));
		}

		// Token: 0x0602DE24 RID: 187940 RVA: 0x00644F4C File Offset: 0x0064314C
		public static IBvbRecycleHandCard GetRootAsIBvbRecycleHandCard(ByteBuffer _bb, IBvbRecycleHandCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE25 RID: 187941 RVA: 0x00644F69 File Offset: 0x00643169
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE26 RID: 187942 RVA: 0x00644F78 File Offset: 0x00643178
		public IBvbRecycleHandCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C528 RID: 50472
		// (get) Token: 0x0602DE27 RID: 187943 RVA: 0x00644F88 File Offset: 0x00643188
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

		// Token: 0x1700C529 RID: 50473
		// (get) Token: 0x0602DE28 RID: 187944 RVA: 0x00644FC4 File Offset: 0x006431C4
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

		// Token: 0x1700C52A RID: 50474
		// (get) Token: 0x0602DE29 RID: 187945 RVA: 0x00645000 File Offset: 0x00643200
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

		// Token: 0x0602DE2A RID: 187946 RVA: 0x0064503C File Offset: 0x0064323C
		public static Offset<IBvbRecycleHandCard> CreateIBvbRecycleHandCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int HandCardIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IBvbRecycleHandCard.AddHandCardIndex(builder, HandCardIndex);
			IBvbRecycleHandCard.AddNullMask(builder, NullMask);
			IBvbRecycleHandCard.AddType(builder, Type);
			return IBvbRecycleHandCard.EndIBvbRecycleHandCard(builder);
		}

		// Token: 0x0602DE2B RID: 187947 RVA: 0x00645060 File Offset: 0x00643260
		public static void StartIBvbRecycleHandCard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DE2C RID: 187948 RVA: 0x00645069 File Offset: 0x00643269
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DE2D RID: 187949 RVA: 0x00645074 File Offset: 0x00643274
		public static void AddHandCardIndex(FlatBufferBuilder builder, int handCardIndex)
		{
			builder.AddInt(1, handCardIndex, 0);
		}

		// Token: 0x0602DE2E RID: 187950 RVA: 0x0064507F File Offset: 0x0064327F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602DE2F RID: 187951 RVA: 0x0064508A File Offset: 0x0064328A
		public static Offset<IBvbRecycleHandCard> EndIBvbRecycleHandCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbRecycleHandCard>(builder.EndTable());
		}

		// Token: 0x0602DE30 RID: 187952 RVA: 0x00645098 File Offset: 0x00643298
		public IBvbRecycleHandCardT UnPack()
		{
			IBvbRecycleHandCardT bvbRecycleHandCardT = new IBvbRecycleHandCardT();
			this.UnPackTo(bvbRecycleHandCardT);
			return bvbRecycleHandCardT;
		}

		// Token: 0x0602DE31 RID: 187953 RVA: 0x006450B3 File Offset: 0x006432B3
		public void UnPackTo(IBvbRecycleHandCardT _o)
		{
			_o.Type = this.Type;
			_o.HandCardIndex = this.HandCardIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DE32 RID: 187954 RVA: 0x006450DC File Offset: 0x006432DC
		public static Offset<IBvbRecycleHandCard> Pack(FlatBufferBuilder builder, IBvbRecycleHandCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbRecycleHandCard>);
			}
			return IBvbRecycleHandCard.CreateIBvbRecycleHandCard(builder, _o.Type, _o.HandCardIndex, _o.NullMask);
		}

		// Token: 0x040115C7 RID: 71111
		private Table __p;
	}
}
