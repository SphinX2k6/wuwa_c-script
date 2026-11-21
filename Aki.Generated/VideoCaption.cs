using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C3 RID: 4803
	public struct VideoCaption : IFlatbufferObject
	{
		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x0600F484 RID: 62596 RVA: 0x0036B6D2 File Offset: 0x003698D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F485 RID: 62597 RVA: 0x0036B6DF File Offset: 0x003698DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F486 RID: 62598 RVA: 0x0036B6E8 File Offset: 0x003698E8
		public static VideoCaption GetRootAsVideoCaption(ByteBuffer _bb)
		{
			return VideoCaption.GetRootAsVideoCaption(_bb, default(VideoCaption));
		}

		// Token: 0x0600F487 RID: 62599 RVA: 0x0036B704 File Offset: 0x00369904
		public static VideoCaption GetRootAsVideoCaption(ByteBuffer _bb, VideoCaption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F488 RID: 62600 RVA: 0x0036B721 File Offset: 0x00369921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F489 RID: 62601 RVA: 0x0036B730 File Offset: 0x00369930
		public VideoCaption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x0600F48A RID: 62602 RVA: 0x0036B740 File Offset: 0x00369940
		public int CaptionId
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

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x0600F48B RID: 62603 RVA: 0x0036B77C File Offset: 0x0036997C
		public string CgName
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

		// Token: 0x0600F48C RID: 62604 RVA: 0x0036B7B3 File Offset: 0x003699B3
		public Span<byte> GetCgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F48D RID: 62605 RVA: 0x0036B7C2 File Offset: 0x003699C2
		public byte[] GetCgNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170040F2 RID: 16626
		// (get) Token: 0x0600F48E RID: 62606 RVA: 0x0036B7DC File Offset: 0x003699DC
		public int ShowMoment
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

		// Token: 0x170040F3 RID: 16627
		// (get) Token: 0x0600F48F RID: 62607 RVA: 0x0036B818 File Offset: 0x00369A18
		public int Duration
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

		// Token: 0x170040F4 RID: 16628
		// (get) Token: 0x0600F490 RID: 62608 RVA: 0x0036B858 File Offset: 0x00369A58
		public string CaptionText
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

		// Token: 0x0600F491 RID: 62609 RVA: 0x0036B890 File Offset: 0x00369A90
		public Span<byte> GetCaptionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600F492 RID: 62610 RVA: 0x0036B8A0 File Offset: 0x00369AA0
		public byte[] GetCaptionTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170040F5 RID: 16629
		// (get) Token: 0x0600F493 RID: 62611 RVA: 0x0036B8B8 File Offset: 0x00369AB8
		public int ShowMomentEn
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

		// Token: 0x170040F6 RID: 16630
		// (get) Token: 0x0600F494 RID: 62612 RVA: 0x0036B8F8 File Offset: 0x00369AF8
		public int DurationEn
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

		// Token: 0x170040F7 RID: 16631
		// (get) Token: 0x0600F495 RID: 62613 RVA: 0x0036B938 File Offset: 0x00369B38
		public int ShowMomentKo
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170040F8 RID: 16632
		// (get) Token: 0x0600F496 RID: 62614 RVA: 0x0036B978 File Offset: 0x00369B78
		public int DurationKo
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170040F9 RID: 16633
		// (get) Token: 0x0600F497 RID: 62615 RVA: 0x0036B9B8 File Offset: 0x00369BB8
		public int ShowMomentJa
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

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x0600F498 RID: 62616 RVA: 0x0036B9F8 File Offset: 0x00369BF8
		public int DurationJa
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x0600F499 RID: 62617 RVA: 0x0036BA38 File Offset: 0x00369C38
		public bool IsPlaySubtitleVoice
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400591A RID: 22810
		private Table __p;
	}
}
