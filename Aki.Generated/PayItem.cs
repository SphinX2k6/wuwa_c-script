using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAF RID: 3759
	public struct PayItem : IFlatbufferObject
	{
		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x0600A2E9 RID: 41705 RVA: 0x002A6368 File Offset: 0x002A4568
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x002A6375 File Offset: 0x002A4575
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x002A637C File Offset: 0x002A457C
		public static PayItem GetRootAsPayItem(ByteBuffer _bb)
		{
			return PayItem.GetRootAsPayItem(_bb, default(PayItem));
		}

		// Token: 0x0600A2EC RID: 41708 RVA: 0x002A6398 File Offset: 0x002A4598
		public static PayItem GetRootAsPayItem(ByteBuffer _bb, PayItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A2ED RID: 41709 RVA: 0x002A63B5 File Offset: 0x002A45B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x002A63C4 File Offset: 0x002A45C4
		public PayItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x0600A2EF RID: 41711 RVA: 0x002A63D4 File Offset: 0x002A45D4
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

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x0600A2F0 RID: 41712 RVA: 0x002A6410 File Offset: 0x002A4610
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

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x0600A2F1 RID: 41713 RVA: 0x002A644C File Offset: 0x002A464C
		public int ItemCount
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

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x0600A2F2 RID: 41714 RVA: 0x002A6488 File Offset: 0x002A4688
		public int PayId
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

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x0600A2F3 RID: 41715 RVA: 0x002A64C8 File Offset: 0x002A46C8
		public string StageImage
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

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x002A6500 File Offset: 0x002A4700
		public Span<byte> GetStageImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x002A6510 File Offset: 0x002A4710
		public byte[] GetStageImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x0600A2F6 RID: 41718 RVA: 0x002A6528 File Offset: 0x002A4728
		public int BonusItemCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x0600A2F7 RID: 41719 RVA: 0x002A6568 File Offset: 0x002A4768
		public int SpecialBonusItemCount
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004F65 RID: 20325
		private Table __p;
	}
}
