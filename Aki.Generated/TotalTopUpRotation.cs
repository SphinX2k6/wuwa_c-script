using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001268 RID: 4712
	public struct TotalTopUpRotation : IFlatbufferObject
	{
		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x0600ECA0 RID: 60576 RVA: 0x0035A030 File Offset: 0x00358230
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ECA1 RID: 60577 RVA: 0x0035A03D File Offset: 0x0035823D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ECA2 RID: 60578 RVA: 0x0035A044 File Offset: 0x00358244
		public static TotalTopUpRotation GetRootAsTotalTopUpRotation(ByteBuffer _bb)
		{
			return TotalTopUpRotation.GetRootAsTotalTopUpRotation(_bb, default(TotalTopUpRotation));
		}

		// Token: 0x0600ECA3 RID: 60579 RVA: 0x0035A060 File Offset: 0x00358260
		public static TotalTopUpRotation GetRootAsTotalTopUpRotation(ByteBuffer _bb, TotalTopUpRotation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ECA4 RID: 60580 RVA: 0x0035A07D File Offset: 0x0035827D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ECA5 RID: 60581 RVA: 0x0035A08C File Offset: 0x0035828C
		public TotalTopUpRotation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x0600ECA6 RID: 60582 RVA: 0x0035A09C File Offset: 0x0035829C
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

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x0600ECA7 RID: 60583 RVA: 0x0035A0D8 File Offset: 0x003582D8
		public int ActivityId
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

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x0600ECA8 RID: 60584 RVA: 0x0035A114 File Offset: 0x00358314
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

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x0600ECA9 RID: 60585 RVA: 0x0035A150 File Offset: 0x00358350
		public int PreviewType
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

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x0600ECAA RID: 60586 RVA: 0x0035A190 File Offset: 0x00358390
		public string ResourcePath
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

		// Token: 0x0600ECAB RID: 60587 RVA: 0x0035A1C8 File Offset: 0x003583C8
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600ECAC RID: 60588 RVA: 0x0035A1D8 File Offset: 0x003583D8
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x0600ECAD RID: 60589 RVA: 0x0035A1F0 File Offset: 0x003583F0
		public int ShowDuration
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

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x0600ECAE RID: 60590 RVA: 0x0035A230 File Offset: 0x00358430
		public string PreviewName
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

		// Token: 0x0600ECAF RID: 60591 RVA: 0x0035A268 File Offset: 0x00358468
		public Span<byte> GetPreviewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600ECB0 RID: 60592 RVA: 0x0035A278 File Offset: 0x00358478
		public byte[] GetPreviewNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x0600ECB1 RID: 60593 RVA: 0x0035A290 File Offset: 0x00358490
		public string MusicName
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ECB2 RID: 60594 RVA: 0x0035A2C8 File Offset: 0x003584C8
		public Span<byte> GetMusicNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600ECB3 RID: 60595 RVA: 0x0035A2D8 File Offset: 0x003584D8
		public byte[] GetMusicNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x040058B6 RID: 22710
		private Table __p;
	}
}
