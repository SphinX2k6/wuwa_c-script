using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB0 RID: 3760
	public struct PayShop : IFlatbufferObject
	{
		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x0600A2F8 RID: 41720 RVA: 0x002A65A5 File Offset: 0x002A47A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A2F9 RID: 41721 RVA: 0x002A65B2 File Offset: 0x002A47B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A2FA RID: 41722 RVA: 0x002A65BC File Offset: 0x002A47BC
		public static PayShop GetRootAsPayShop(ByteBuffer _bb)
		{
			return PayShop.GetRootAsPayShop(_bb, default(PayShop));
		}

		// Token: 0x0600A2FB RID: 41723 RVA: 0x002A65D8 File Offset: 0x002A47D8
		public static PayShop GetRootAsPayShop(ByteBuffer _bb, PayShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x002A65F5 File Offset: 0x002A47F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x002A6604 File Offset: 0x002A4804
		public PayShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x0600A2FE RID: 41726 RVA: 0x002A6614 File Offset: 0x002A4814
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

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x0600A2FF RID: 41727 RVA: 0x002A6650 File Offset: 0x002A4850
		public int ShopTabViewType
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

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x0600A300 RID: 41728 RVA: 0x002A668C File Offset: 0x002A488C
		public int DynamicTabId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x0600A301 RID: 41729 RVA: 0x002A66C8 File Offset: 0x002A48C8
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x0600A302 RID: 41730 RVA: 0x002A6708 File Offset: 0x002A4908
		public string Name
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x002A6740 File Offset: 0x002A4940
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x002A6750 File Offset: 0x002A4950
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x002A6768 File Offset: 0x002A4968
		public int Money(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x0600A306 RID: 41734 RVA: 0x002A67A8 File Offset: 0x002A49A8
		public int MoneyLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A307 RID: 41735 RVA: 0x002A67D4 File Offset: 0x002A49D4
		public Span<int> GetMoneyBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600A308 RID: 41736 RVA: 0x002A67E4 File Offset: 0x002A49E4
		public int[] GetMoneyArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x0600A309 RID: 41737 RVA: 0x002A67FC File Offset: 0x002A49FC
		public string Notice
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x002A6834 File Offset: 0x002A4A34
		public Span<byte> GetNoticeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x002A6844 File Offset: 0x002A4A44
		public byte[] GetNoticeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x0600A30C RID: 41740 RVA: 0x002A685C File Offset: 0x002A4A5C
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x0600A30D RID: 41741 RVA: 0x002A689C File Offset: 0x002A4A9C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A30E RID: 41742 RVA: 0x002A68D4 File Offset: 0x002A4AD4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A30F RID: 41743 RVA: 0x002A68E4 File Offset: 0x002A4AE4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x0600A310 RID: 41744 RVA: 0x002A68FC File Offset: 0x002A4AFC
		public int SortRule
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x002A693C File Offset: 0x002A4B3C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MoneyIter()或GetMoneyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Money()
		{
			PayShop payShop = this;
			return payShop.GetMoneyArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x002A6960 File Offset: 0x002A4B60
		[NullableContext(1)]
		public readonly IEnumerable<int> MoneyIter()
		{
			PayShop.<MoneyIter>d__38 <MoneyIter>d__ = new PayShop.<MoneyIter>d__38(-2);
			<MoneyIter>d__.<>3__<>4__this = this;
			return <MoneyIter>d__;
		}

		// Token: 0x04004F66 RID: 20326
		private Table __p;
	}
}
