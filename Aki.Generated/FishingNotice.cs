using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C83 RID: 3203
	public struct FishingNotice : IFlatbufferObject
	{
		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06006FAF RID: 28591 RVA: 0x00231F91 File Offset: 0x00230191
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x00231F9E File Offset: 0x0023019E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x00231FA8 File Offset: 0x002301A8
		public static FishingNotice GetRootAsFishingNotice(ByteBuffer _bb)
		{
			return FishingNotice.GetRootAsFishingNotice(_bb, default(FishingNotice));
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x00231FC4 File Offset: 0x002301C4
		public static FishingNotice GetRootAsFishingNotice(ByteBuffer _bb, FishingNotice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x00231FE1 File Offset: 0x002301E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x00231FF0 File Offset: 0x002301F0
		public FishingNotice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06006FB5 RID: 28597 RVA: 0x00232000 File Offset: 0x00230200
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

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06006FB6 RID: 28598 RVA: 0x0023203C File Offset: 0x0023023C
		public int AlertCondition
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

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06006FB7 RID: 28599 RVA: 0x00232078 File Offset: 0x00230278
		public int FinishCondition
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

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06006FB8 RID: 28600 RVA: 0x002320B4 File Offset: 0x002302B4
		public string AlertTip
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

		// Token: 0x06006FB9 RID: 28601 RVA: 0x002320EC File Offset: 0x002302EC
		public Span<byte> GetAlertTipBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x002320FC File Offset: 0x002302FC
		public byte[] GetAlertTipArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CD3 RID: 19667
		private Table __p;
	}
}
