using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEC RID: 3564
	public struct GmOrderList : IFlatbufferObject
	{
		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06008159 RID: 33113 RVA: 0x0026B9A8 File Offset: 0x00269BA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x0026B9B5 File Offset: 0x00269BB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x0026B9BC File Offset: 0x00269BBC
		public static GmOrderList GetRootAsGmOrderList(ByteBuffer _bb)
		{
			return GmOrderList.GetRootAsGmOrderList(_bb, default(GmOrderList));
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x0026B9D8 File Offset: 0x00269BD8
		public static GmOrderList GetRootAsGmOrderList(ByteBuffer _bb, GmOrderList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x0026B9F5 File Offset: 0x00269BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600815E RID: 33118 RVA: 0x0026BA04 File Offset: 0x00269C04
		public GmOrderList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x0600815F RID: 33119 RVA: 0x0026BA14 File Offset: 0x00269C14
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06008160 RID: 33120 RVA: 0x0026BA50 File Offset: 0x00269C50
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008161 RID: 33121 RVA: 0x0026BA87 File Offset: 0x00269C87
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x0026BA96 File Offset: 0x00269C96
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06008163 RID: 33123 RVA: 0x0026BAB0 File Offset: 0x00269CB0
		public string OrderList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06008164 RID: 33124 RVA: 0x0026BAEC File Offset: 0x00269CEC
		public int OrderListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x0026BB17 File Offset: 0x00269D17
		[NullableContext(1)]
		public string[] OrderList()
		{
			return this.OrderListIter().ToArray<string>();
		}

		// Token: 0x06008166 RID: 33126 RVA: 0x0026BB24 File Offset: 0x00269D24
		[NullableContext(1)]
		public IEnumerable<string> OrderListIter()
		{
			GmOrderList.<OrderListIter>d__18 <OrderListIter>d__ = new GmOrderList.<OrderListIter>d__18(-2);
			<OrderListIter>d__.<>3__<>4__this = this;
			return <OrderListIter>d__;
		}

		// Token: 0x04005362 RID: 21346
		private Table __p;
	}
}
