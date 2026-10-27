using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118D RID: 4493
	public struct VideoCaption : IFlatbufferObject
	{
		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x0600E716 RID: 59158 RVA: 0x00340919 File Offset: 0x0033EB19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E717 RID: 59159 RVA: 0x00340926 File Offset: 0x0033EB26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E718 RID: 59160 RVA: 0x00340930 File Offset: 0x0033EB30
		public static VideoCaption GetRootAsVideoCaption(ByteBuffer _bb)
		{
			return VideoCaption.GetRootAsVideoCaption(_bb, default(VideoCaption));
		}

		// Token: 0x0600E719 RID: 59161 RVA: 0x0034094C File Offset: 0x0033EB4C
		public static VideoCaption GetRootAsVideoCaption(ByteBuffer _bb, VideoCaption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E71A RID: 59162 RVA: 0x00340969 File Offset: 0x0033EB69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E71B RID: 59163 RVA: 0x00340978 File Offset: 0x0033EB78
		public VideoCaption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x0600E71C RID: 59164 RVA: 0x00340988 File Offset: 0x0033EB88
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

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x0600E71D RID: 59165 RVA: 0x003409C4 File Offset: 0x0033EBC4
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

		// Token: 0x0600E71E RID: 59166 RVA: 0x003409FB File Offset: 0x0033EBFB
		public Span<byte> GetCgNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E71F RID: 59167 RVA: 0x00340A0A File Offset: 0x0033EC0A
		public byte[] GetCgNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x0600E720 RID: 59168 RVA: 0x00340A24 File Offset: 0x0033EC24
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

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x0600E721 RID: 59169 RVA: 0x00340A60 File Offset: 0x0033EC60
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

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x0600E722 RID: 59170 RVA: 0x00340AA0 File Offset: 0x0033ECA0
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

		// Token: 0x0600E723 RID: 59171 RVA: 0x00340AD8 File Offset: 0x0033ECD8
		public Span<byte> GetCaptionTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E724 RID: 59172 RVA: 0x00340AE8 File Offset: 0x0033ECE8
		public byte[] GetCaptionTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x0600E725 RID: 59173 RVA: 0x00340B00 File Offset: 0x0033ED00
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

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x0600E726 RID: 59174 RVA: 0x00340B40 File Offset: 0x0033ED40
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

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x0600E727 RID: 59175 RVA: 0x00340B80 File Offset: 0x0033ED80
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

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x0600E728 RID: 59176 RVA: 0x00340BC0 File Offset: 0x0033EDC0
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

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x0600E729 RID: 59177 RVA: 0x00340C00 File Offset: 0x0033EE00
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

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x0600E72A RID: 59178 RVA: 0x00340C40 File Offset: 0x0033EE40
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

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x0600E72B RID: 59179 RVA: 0x00340C80 File Offset: 0x0033EE80
		public bool IsPlaySubtitleVoice
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040052D7 RID: 21207
		private Table __p;
	}
}
