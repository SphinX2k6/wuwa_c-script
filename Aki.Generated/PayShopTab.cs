using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F99 RID: 3993
	public struct PayShopTab : IFlatbufferObject
	{
		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x0600A959 RID: 43353 RVA: 0x002C4180 File Offset: 0x002C2380
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A95A RID: 43354 RVA: 0x002C418D File Offset: 0x002C238D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A95B RID: 43355 RVA: 0x002C4194 File Offset: 0x002C2394
		public static PayShopTab GetRootAsPayShopTab(ByteBuffer _bb)
		{
			return PayShopTab.GetRootAsPayShopTab(_bb, default(PayShopTab));
		}

		// Token: 0x0600A95C RID: 43356 RVA: 0x002C41B0 File Offset: 0x002C23B0
		public static PayShopTab GetRootAsPayShopTab(ByteBuffer _bb, PayShopTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A95D RID: 43357 RVA: 0x002C41CD File Offset: 0x002C23CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A95E RID: 43358 RVA: 0x002C41DC File Offset: 0x002C23DC
		public PayShopTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x0600A95F RID: 43359 RVA: 0x002C41EC File Offset: 0x002C23EC
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

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x0600A960 RID: 43360 RVA: 0x002C4228 File Offset: 0x002C2428
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

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x0600A961 RID: 43361 RVA: 0x002C4264 File Offset: 0x002C2464
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

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x0600A962 RID: 43362 RVA: 0x002C42A0 File Offset: 0x002C24A0
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

		// Token: 0x0600A963 RID: 43363 RVA: 0x002C42D8 File Offset: 0x002C24D8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x002C42E8 File Offset: 0x002C24E8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x0600A965 RID: 43365 RVA: 0x002C4300 File Offset: 0x002C2500
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

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x0600A966 RID: 43366 RVA: 0x002C4340 File Offset: 0x002C2540
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x0600A967 RID: 43367 RVA: 0x002C4380 File Offset: 0x002C2580
		public bool NeedShowShowTime
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400554F RID: 21839
		private Table __p;
	}
}
