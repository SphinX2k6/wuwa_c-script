using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB4 RID: 3764
	public struct PayShopTab : IFlatbufferObject
	{
		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x0600A339 RID: 41785 RVA: 0x002A6E24 File Offset: 0x002A5024
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x002A6E31 File Offset: 0x002A5031
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x002A6E38 File Offset: 0x002A5038
		public static PayShopTab GetRootAsPayShopTab(ByteBuffer _bb)
		{
			return PayShopTab.GetRootAsPayShopTab(_bb, default(PayShopTab));
		}

		// Token: 0x0600A33C RID: 41788 RVA: 0x002A6E54 File Offset: 0x002A5054
		public static PayShopTab GetRootAsPayShopTab(ByteBuffer _bb, PayShopTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x002A6E71 File Offset: 0x002A5071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A33E RID: 41790 RVA: 0x002A6E80 File Offset: 0x002A5080
		public PayShopTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x0600A33F RID: 41791 RVA: 0x002A6E90 File Offset: 0x002A5090
		public int ShopId
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

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x0600A340 RID: 41792 RVA: 0x002A6ECC File Offset: 0x002A50CC
		public int TabId
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

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x0600A341 RID: 41793 RVA: 0x002A6F08 File Offset: 0x002A5108
		public int Sort
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

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x0600A342 RID: 41794 RVA: 0x002A6F44 File Offset: 0x002A5144
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x002A6F7C File Offset: 0x002A517C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x002A6F8C File Offset: 0x002A518C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x0600A345 RID: 41797 RVA: 0x002A6FA4 File Offset: 0x002A51A4
		public int Logic
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x0600A346 RID: 41798 RVA: 0x002A6FE4 File Offset: 0x002A51E4
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004F6A RID: 20330
		private Table __p;
	}
}
