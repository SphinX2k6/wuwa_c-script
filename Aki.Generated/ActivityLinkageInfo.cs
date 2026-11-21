using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9F RID: 2975
	public struct ActivityLinkageInfo : IFlatbufferObject
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x001EC038 File Offset: 0x001EA238
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x001EC045 File Offset: 0x001EA245
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x001EC04C File Offset: 0x001EA24C
		public static ActivityLinkageInfo GetRootAsActivityLinkageInfo(ByteBuffer _bb)
		{
			return ActivityLinkageInfo.GetRootAsActivityLinkageInfo(_bb, default(ActivityLinkageInfo));
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x001EC068 File Offset: 0x001EA268
		public static ActivityLinkageInfo GetRootAsActivityLinkageInfo(ByteBuffer _bb, ActivityLinkageInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x001EC085 File Offset: 0x001EA285
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x001EC094 File Offset: 0x001EA294
		public ActivityLinkageInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060048B7 RID: 18615 RVA: 0x001EC0A4 File Offset: 0x001EA2A4
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

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x001EC0E0 File Offset: 0x001EA2E0
		public int ActivityLinkageId
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

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060048B9 RID: 18617 RVA: 0x001EC11C File Offset: 0x001EA31C
		public int Language
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

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060048BA RID: 18618 RVA: 0x001EC158 File Offset: 0x001EA358
		public string BigImage
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

		// Token: 0x060048BB RID: 18619 RVA: 0x001EC190 File Offset: 0x001EA390
		public Span<byte> GetBigImageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x001EC1A0 File Offset: 0x001EA3A0
		public byte[] GetBigImageArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060048BD RID: 18621 RVA: 0x001EC1B8 File Offset: 0x001EA3B8
		public string LinkUrl
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

		// Token: 0x060048BE RID: 18622 RVA: 0x001EC1F0 File Offset: 0x001EA3F0
		public Span<byte> GetLinkUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x001EC200 File Offset: 0x001EA400
		public byte[] GetLinkUrlArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x001EC218 File Offset: 0x001EA418
		public string QRCode
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x001EC250 File Offset: 0x001EA450
		public Span<byte> GetQRCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x001EC260 File Offset: 0x001EA460
		public byte[] GetQRCodeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400507C RID: 20604
		private Table __p;
	}
}
