using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068AD RID: 26797
	public struct IBvbChangeHandCard : IFlatbufferObject
	{
		// Token: 0x1700C4ED RID: 50413
		// (get) Token: 0x0602DD0D RID: 187661 RVA: 0x00642F1E File Offset: 0x0064111E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD0E RID: 187662 RVA: 0x00642F2B File Offset: 0x0064112B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD0F RID: 187663 RVA: 0x00642F34 File Offset: 0x00641134
		public static IBvbChangeHandCard GetRootAsIBvbChangeHandCard(ByteBuffer _bb)
		{
			return IBvbChangeHandCard.GetRootAsIBvbChangeHandCard(_bb, default(IBvbChangeHandCard));
		}

		// Token: 0x0602DD10 RID: 187664 RVA: 0x00642F50 File Offset: 0x00641150
		public static IBvbChangeHandCard GetRootAsIBvbChangeHandCard(ByteBuffer _bb, IBvbChangeHandCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD11 RID: 187665 RVA: 0x00642F6D File Offset: 0x0064116D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD12 RID: 187666 RVA: 0x00642F7C File Offset: 0x0064117C
		public IBvbChangeHandCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4EE RID: 50414
		// (get) Token: 0x0602DD13 RID: 187667 RVA: 0x00642F8C File Offset: 0x0064118C
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

		// Token: 0x1700C4EF RID: 50415
		// (get) Token: 0x0602DD14 RID: 187668 RVA: 0x00642FC8 File Offset: 0x006411C8
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

		// Token: 0x1700C4F0 RID: 50416
		// (get) Token: 0x0602DD15 RID: 187669 RVA: 0x00643004 File Offset: 0x00641204
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

		// Token: 0x0602DD16 RID: 187670 RVA: 0x00643040 File Offset: 0x00641240
		public static Offset<IBvbChangeHandCard> CreateIBvbChangeHandCard(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy, int HandCardIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IBvbChangeHandCard.AddHandCardIndex(builder, HandCardIndex);
			IBvbChangeHandCard.AddNullMask(builder, NullMask);
			IBvbChangeHandCard.AddType(builder, Type);
			return IBvbChangeHandCard.EndIBvbChangeHandCard(builder);
		}

		// Token: 0x0602DD17 RID: 187671 RVA: 0x00643064 File Offset: 0x00641264
		public static void StartIBvbChangeHandCard(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602DD18 RID: 187672 RVA: 0x0064306D File Offset: 0x0064126D
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DD19 RID: 187673 RVA: 0x00643078 File Offset: 0x00641278
		public static void AddHandCardIndex(FlatBufferBuilder builder, int handCardIndex)
		{
			builder.AddInt(1, handCardIndex, 0);
		}

		// Token: 0x0602DD1A RID: 187674 RVA: 0x00643083 File Offset: 0x00641283
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602DD1B RID: 187675 RVA: 0x0064308E File Offset: 0x0064128E
		public static Offset<IBvbChangeHandCard> EndIBvbChangeHandCard(FlatBufferBuilder builder)
		{
			return new Offset<IBvbChangeHandCard>(builder.EndTable());
		}

		// Token: 0x0602DD1C RID: 187676 RVA: 0x0064309C File Offset: 0x0064129C
		public IBvbChangeHandCardT UnPack()
		{
			IBvbChangeHandCardT bvbChangeHandCardT = new IBvbChangeHandCardT();
			this.UnPackTo(bvbChangeHandCardT);
			return bvbChangeHandCardT;
		}

		// Token: 0x0602DD1D RID: 187677 RVA: 0x006430B7 File Offset: 0x006412B7
		public void UnPackTo(IBvbChangeHandCardT _o)
		{
			_o.Type = this.Type;
			_o.HandCardIndex = this.HandCardIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DD1E RID: 187678 RVA: 0x006430E0 File Offset: 0x006412E0
		public static Offset<IBvbChangeHandCard> Pack(FlatBufferBuilder builder, IBvbChangeHandCardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbChangeHandCard>);
			}
			return IBvbChangeHandCard.CreateIBvbChangeHandCard(builder, _o.Type, _o.HandCardIndex, _o.NullMask);
		}

		// Token: 0x04011598 RID: 71064
		private Table __p;
	}
}
