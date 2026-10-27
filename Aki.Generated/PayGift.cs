using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAE RID: 3758
	public struct PayGift : IFlatbufferObject
	{
		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x0600A2E1 RID: 41697 RVA: 0x002A6284 File Offset: 0x002A4484
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x002A6291 File Offset: 0x002A4491
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x002A6298 File Offset: 0x002A4498
		public static PayGift GetRootAsPayGift(ByteBuffer _bb)
		{
			return PayGift.GetRootAsPayGift(_bb, default(PayGift));
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x002A62B4 File Offset: 0x002A44B4
		public static PayGift GetRootAsPayGift(ByteBuffer _bb, PayGift obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x002A62D1 File Offset: 0x002A44D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x002A62E0 File Offset: 0x002A44E0
		public PayGift __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x0600A2E7 RID: 41703 RVA: 0x002A62F0 File Offset: 0x002A44F0
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

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x0600A2E8 RID: 41704 RVA: 0x002A632C File Offset: 0x002A452C
		public int ItemId
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

		// Token: 0x04004F64 RID: 20324
		private Table __p;
	}
}
