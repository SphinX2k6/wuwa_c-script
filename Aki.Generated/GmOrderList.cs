using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D07 RID: 3335
	public struct GmOrderList : IFlatbufferObject
	{
		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06007B41 RID: 31553 RVA: 0x0024CE58 File Offset: 0x0024B058
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x0024CE65 File Offset: 0x0024B065
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x0024CE6C File Offset: 0x0024B06C
		public static GmOrderList GetRootAsGmOrderList(ByteBuffer _bb)
		{
			return GmOrderList.GetRootAsGmOrderList(_bb, default(GmOrderList));
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x0024CE88 File Offset: 0x0024B088
		public static GmOrderList GetRootAsGmOrderList(ByteBuffer _bb, GmOrderList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x0024CEA5 File Offset: 0x0024B0A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x0024CEB4 File Offset: 0x0024B0B4
		public GmOrderList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06007B47 RID: 31559 RVA: 0x0024CEC4 File Offset: 0x0024B0C4
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

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06007B48 RID: 31560 RVA: 0x0024CF00 File Offset: 0x0024B100
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

		// Token: 0x06007B49 RID: 31561 RVA: 0x0024CF37 File Offset: 0x0024B137
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x0024CF46 File Offset: 0x0024B146
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x0024CF60 File Offset: 0x0024B160
		public string OrderList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06007B4C RID: 31564 RVA: 0x0024CF9C File Offset: 0x0024B19C
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

		// Token: 0x06007B4D RID: 31565 RVA: 0x0024CFC7 File Offset: 0x0024B1C7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OrderListIter()或GetOrderListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] OrderList()
		{
			return this.OrderListIter().ToArray<string>();
		}

		// Token: 0x06007B4E RID: 31566 RVA: 0x0024CFD4 File Offset: 0x0024B1D4
		[NullableContext(1)]
		public readonly IEnumerable<string> OrderListIter()
		{
			GmOrderList.<OrderListIter>d__18 <OrderListIter>d__ = new GmOrderList.<OrderListIter>d__18(-2);
			<OrderListIter>d__.<>3__<>4__this = this;
			return <OrderListIter>d__;
		}

		// Token: 0x04004D7D RID: 19837
		private Table __p;
	}
}
